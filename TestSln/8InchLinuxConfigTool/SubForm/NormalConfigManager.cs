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
using System.Xml;

namespace _8InchLinuxConfigTool.SubForm
{
    public partial class NormalConfigManager : Form
    {
        Dictionary<string, string> dictConfig = new Dictionary<string, string>();
        public NormalConfigManager()
        {
            InitializeComponent();
        }

        private void frmConfigManager_Load(object sender, EventArgs e)
        {
            try
            {
                //if (!CacheHelper.Exist("NormalConfigManager"))
                //{
                //    Device.Get_fun_normal_Config();
                //    CacheHelper.Set("NormalConfigManager", DateTime.Now.AddHours(2), "");
                //}
                LoadConfig();
            }
            catch (Exception ex)
            {
                Logger.SaveLog("错误日志", ex);
                MessageBox.Show("加载出错了，请稍后重试");
            }
        }

        private void LoadConfig()
        {
            if (!File.Exists(Device.fun_normal_configFilePath)||ToolCls.FileIsUsed(Device.fun_normal_configFilePath))
            {
                MessageBox.Show("文件下载中，请稍后再试！");
                return;
            }
            var core_Content = File.ReadAllText(Device.fun_normal_configFilePath);
            var aryContent = core_Content.Split('\n');
            foreach (var item in aryContent)
            {
                if (item.Contains("="))
                {
                    var ary_item = item.Split('=');
                    dictConfig.Add(ary_item[0], ary_item[1]);
                }
            }
            foreach (Control item in this.Controls)//赋值给控件
            {
                if (item is TextBox)
                {
                    var textBox = item as TextBox;
                    var key = textBox.Name.Replace("txt_", "");
                    if (dictConfig.ContainsKey(key))
                    {
                        textBox.Text = dictConfig[key];
                    }
                }

            }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainFrm mainFrm = this.ParentForm as MainFrm;
            mainFrm.btnNormalConfig_More_Click(null, null);
        }

        private void btnSend_Click(object sender, EventArgs e)
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

        private void SaveConfig()
        {
            foreach (Control item in this.Controls)//获取控件的值赋值给配置文件
            {
                if (item is TextBox)
                {
                    var textBox = item as TextBox;
                    dictConfig[textBox.Name.Replace("txt_", "")] = textBox.Text;
                }
            }
            var core_Content = File.ReadAllText(Device.fun_normal_configFilePath);
            var aryContent = core_Content.Split('\n');
            foreach (var item in aryContent)
            {
                if (item.Contains("="))
                {
                    var ary_item = item.Split('=');
                    var key = ary_item[0];
                    var oldValue = ary_item[1];
                    if (dictConfig.ContainsKey(ary_item[0]))
                    {
                        var newValue = dictConfig[key];
                        var newContent = key + "=" + newValue;
                        var oldContent = key + "=" + oldValue;
                        core_Content = core_Content.Replace(oldContent, newContent);
                    }
                }
            }
            File.WriteAllText(Device.fun_normal_configFilePath, core_Content);
        }
    }
}
