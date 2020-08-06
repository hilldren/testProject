using _8InchLinuxConfigTool.Provider;
using Common;
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

namespace _8InchLinuxConfigTool.SubForm
{
    public partial class NormalConfigManager_More : Form
    {
        public NormalConfigManager_More()
        {
            InitializeComponent();
        }
        public void SaveConfig()
        {
            string Content = txtConfContent.Text;
            Content = Content.Replace("\r\n", "\n");
            File.WriteAllText(Device.fun_normal_configFilePath, Content);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveConfig();
            }
            catch (Exception ex)
            {
                Logger.SaveLog("错误日志", ex);
                MessageBox.Show("保存失败");
                return;
            }
            MessageBox.Show("保存成功");
        }

        private void NormalConfigManager_More_Load(object sender, EventArgs e)
        {
            string Content = File.ReadAllText(Device.fun_normal_configFilePath);
            Content = Content.Replace("\n", "\r\n");
            txtConfContent.Text = Content;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainFrm mainFrm = this.ParentForm as MainFrm;
            mainFrm.btnNormalConfig_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveConfig();
                Device.Put_fun_normal_Config();
            }
            catch (Exception ex)
            {
                Logger.SaveLog("错误日志", ex);
                MessageBox.Show("下发失败");
                return;
            }
            MessageBox.Show("下发成功");
        }
    }
}
