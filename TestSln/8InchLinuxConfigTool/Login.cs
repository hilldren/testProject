using _8InchLinuxConfigTool.Provider;
using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSCP;

namespace _8InchLinuxConfigTool
{
    public partial class Login : Form
    {
        string iniPath = AppDomain.CurrentDomain.BaseDirectory + "config.ini";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login_flag = Device.Connection(txtHostName.Text, txtUserName.Text, txtPwd.Text);
            if (login_flag)
            {
                MainFrm mainFrm = new MainFrm();
                mainFrm.Text = txtHostName.Text;
                mainFrm.Show();
                this.Hide();
            }
            var loginInParam = new
            {
                HostName = txtHostName.Text,
                UserName = txtUserName.Text,
            };
            File.WriteAllText(iniPath,  JsonConvert.SerializeObject(loginInParam));
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (File.Exists(iniPath)) {
                var text = File.ReadAllText(iniPath);
                if (!string.IsNullOrWhiteSpace(text)) {
                    dynamic dy = JsonConvert.DeserializeObject<dynamic>(text);
                    txtHostName.Text = dy.HostName;
                    txtUserName.Text = dy.UserName;
                    txtPwd.Text = "";
                }
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnLogin_Click(null, null);
            }
        }

        private void txtHostName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnLogin_Click(null, null);
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
