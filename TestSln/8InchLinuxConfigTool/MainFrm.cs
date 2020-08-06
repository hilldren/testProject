using _8InchLinuxConfigTool.Provider;
using _8InchLinuxConfigTool.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8InchLinuxConfigTool
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            Device.InitDeviceFileDirectory();

            Task.Factory.StartNew(() =>
            {
                Device.GetEth_Config();
            });

            Task.Factory.StartNew(() =>
            {
                Device.Get_fun_normal_Config();
            });
            Task.Factory.StartNew(() =>
            {
                Device.Get_fun_important_Config();
            });

            Task.Factory.StartNew(() =>
            {
                Device.Get_log_file();
                this.Invoke(new Action(() =>
                {
                    this.Text += " " + Device.Version;
                }));
            });
           
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            pnRight.Controls.Clear();
            NetConfigManager frmConfig = new NetConfigManager();
            frmConfig.Dock = DockStyle.Fill;
            frmConfig.TopLevel = false;
            this.pnRight.Controls.Clear();
            this.pnRight.Controls.Add(frmConfig);
            frmConfig.Show();
        }

        private void btnCoreConfig_Click(object sender, EventArgs e)
        {
            pnRight.Controls.Clear();
            CoreConfigManager coreConfig = new CoreConfigManager();
            coreConfig.Dock = DockStyle.Fill;
            coreConfig.TopLevel = false;
            this.pnRight.Controls.Clear();
            this.pnRight.Controls.Add(coreConfig);
            coreConfig.Show();
        }

        public void btnNormalConfig_Click(object sender, EventArgs e)
        {
            pnRight.Controls.Clear();
            NormalConfigManager normalConfig = new NormalConfigManager();
            normalConfig.Dock = DockStyle.Fill;
            normalConfig.TopLevel = false;
            this.pnRight.Controls.Clear();
            this.pnRight.Controls.Add(normalConfig);
            normalConfig.Show();
        }

        public void btnNormalConfig_More_Click(object sender, EventArgs e)
        {
            pnRight.Controls.Clear();
            NormalConfigManager_More normalConfig = new NormalConfigManager_More();
            normalConfig.Dock = DockStyle.Fill;
            normalConfig.TopLevel = false;
            this.pnRight.Controls.Clear();
            this.pnRight.Controls.Add(normalConfig);
            normalConfig.Show();
        }

        private void btnDataQuery_Click(object sender, EventArgs e)
        {
            pnRight.Controls.Clear();
            DataQuery dataQuery = new DataQuery();
            dataQuery.Dock = DockStyle.Fill;
            dataQuery.TopLevel = false;
            this.pnRight.Controls.Clear();
            this.pnRight.Controls.Add(dataQuery);
            dataQuery.Show();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            pnRight.Controls.Clear();
            LogQuery logQuery = new LogQuery();
            logQuery.Dock = DockStyle.Fill;
            logQuery.TopLevel = false;
            this.pnRight.Controls.Clear();
            this.pnRight.Controls.Add(logQuery);
            logQuery.Show();
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("确认重启吗？", "重启", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    Device.ReBoot();
            //    MessageBox.Show("重启成功");
            //    Login login = new Login();
            //    login.Show();
            //    this.Hide();
            //}
            pnRight.Controls.Clear();
            Command command = new Command();
            command.Dock = DockStyle.Fill;
            command.TopLevel = false;
            this.pnRight.Controls.Clear();
            this.pnRight.Controls.Add(command);
            command.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出登录吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }

        }

        private void btnUpdateProgram_Click(object sender, EventArgs e)
        {
            pnRight.Controls.Clear();
            UpdateProgram updateProgram = new UpdateProgram();
            updateProgram.Dock = DockStyle.Fill;
            updateProgram.TopLevel = false;
            this.pnRight.Controls.Clear();
            this.pnRight.Controls.Add(updateProgram);
            updateProgram.Show();
        }

        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
