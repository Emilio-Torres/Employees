using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EmployeesSolution
{
    public partial class frmEmployees : Form
    {
        private Connection connection;
        private bool isConnected;
        private List<Employee> employeeslist = new List<Employee>();
        public frmEmployees()
        {
            InitializeComponent();
            this.cmbstatus.SelectedIndex = 0;
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            frmSetConnection setconnection = new frmSetConnection();
            setconnection.ShowDialog();
            if (setconnection.getisConnected())
            {
                if (setconnection.getisIntegratedSecurity())
                    this.connection = new Connection(setconnection.getServer(), setconnection.getCatalog());
                else
                    this.connection = new Connection(setconnection.getServer(), setconnection.getCatalog(), setconnection.getUser(), setconnection.getPassword());
                isConnected = true;
                loadData();
            }
            else
                MessageBox.Show("Connection can´t be setted");
        }

        private void loadData()
        {
            this.dgvEmployees.DataSource = null;
            this.dgvEmployees.Refresh();
            //this.dgvEmployees.Rows.Clear();
            this.employeeslist = connection.EmployeesList();
            this.dgvEmployees.DataSource = employeeslist;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Regex RFCregex = new Regex(@"^[A-Z&Ñ]{4}[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])[A-Z0-9]{2}[0-9A]$");
            string name;
            int id = 0;
            string lastname;
            string rfc;
            DateTime borndate;
            if (!this.isConnected)
            {
                MessageBox.Show("The connection must be setted first");
                return;
            }
            rfc = this.txtRFC.Text.Trim();
            if (!RFCregex.IsMatch(rfc))
            {
                MessageBox.Show("RFC format error");
                return;
            }
            if (int.TryParse(this.txtId.Text, out id))
            {
                name = this.txtName.Text.Trim();
                lastname = this.txtLastName.Text.Trim();
                borndate = this.dtpBorn.Value.Date;
                if (connection.existRFC(rfc))
                {
                    MessageBox.Show("There is already an Employee whit the RFC: " + rfc);
                    return;
                }
                Employee employee = new Employee();
                employee.ID = id;
                employee.Name = name;
                employee.LastName = lastname;
                employee.RFC = rfc;
                employee.BornDate = borndate;
                employee.Status = (EmployeeStatus)this.cmbstatus.SelectedIndex;
                if (connection.insertEmployee(employee) > 0)
                    MessageBox.Show("Employee added correctly");
                else
                    MessageBox.Show("Error adding Employee");
                loadData();
            }
            else
                MessageBox.Show("ID format error, it must be a number");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filter = this.textBox1.Text.Trim();
            if (filter.Length > 0)
            {
                List<Employee> filteredemployees = employeeslist.Where(x => x.Name.Contains(filter)).ToList();
                this.dgvEmployees.DataSource = null;
                this.dgvEmployees.Refresh();
                this.dgvEmployees.DataSource = filteredemployees;
            }
            else
                loadData();
        }
    }
}
