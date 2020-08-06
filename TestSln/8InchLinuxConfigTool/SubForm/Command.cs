using _8InchLinuxConfigTool.Provider;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8InchLinuxConfigTool.SubForm
{
    public partial class Command : Form
    {
        public Command()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text)) {
                    MessageBox.Show("请输入命令");
                    return;
                }
                Device.Cmd(textBox1.Text);
                MessageBox.Show("指令生效");
                if (textBox1.Text == "reboot") {
                    
                    Login login = new Login();
                    login.Show();
                    MainFrm mainFrm = this.ParentForm as MainFrm;
                    mainFrm.Hide();
                  
                   
                }
            }
            catch (Exception ex)
            {
                Logger.SaveLog("错误日志", ex);
                MessageBox.Show("无效命令");
            }
        }
    }
}
