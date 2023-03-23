using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesSolution
{
    public partial class frmSetConnection : Form
    {
        private Connection connection;
        private string server = "";
        private string catalog = "";
        private string user = "";
        private string password = "";
        private bool isConnected = false;
        private bool isIntegatedSecurity = false;

        public string getServer() { return server; }
        public string getCatalog() { return catalog; }
        public string getUser() { return user; }
        public string getPassword() { return password; }
        public bool getisConnected() { return isConnected; }    
        public bool getisIntegratedSecurity() { return isIntegatedSecurity; }

        public frmSetConnection()
        {
            InitializeComponent();
            isConnected = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.server = this.txtServer.Text.Trim();
            this.catalog = this.txtCatalog.Text.Trim();
            this.user = this.txtUser.Text.Trim();
            this.password = this.txtPassword.Text.Trim();
            try
            {
                if (server.Length == 0)
                {
                    MessageBox.Show("Fill Server field");
                    return;
                }
                if (catalog.Length == 0)
                {
                    MessageBox.Show("Fill Initial Catalog field");
                    return;
                }
                if (this.chkSecurity.Checked)
                    this.connection = new Connection(server, catalog);
                else
                {
                    if (user.Length == 0)
                    {
                        MessageBox.Show("Fill User field");
                        return;
                    }
                    if (password.Length == 0)
                    {
                        MessageBox.Show("Fill Password field");
                        return;
                    }
                    this.connection = new Connection(server, catalog, user, password);
                }
                if (!this.connection.TestConnection())
                {
                    isConnected = false;
                    return;
                }
                else if (this.connection.TestConnection() && this.chkSecurity.Checked)
                {
                    isConnected = true;
                    isIntegatedSecurity = true;
                    return;
                }
                else if (this.connection.TestConnection() && !this.chkSecurity.Checked)
                {
                    isConnected = true;
                    isIntegatedSecurity = false;
                    return;
                }
                else
                    isConnected = false;
            }
            catch { }
        }

        private void chkSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSecurity.Checked)
            {
                txtPassword.Enabled = false;
                txtUser.Enabled = false;
            }
            else
            {
                txtPassword.Enabled = true;
                txtUser.Enabled = true;
            }
        }
    }
}
