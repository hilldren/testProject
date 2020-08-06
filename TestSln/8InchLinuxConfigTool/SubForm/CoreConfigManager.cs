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
    public partial class CoreConfigManager : Form
    {
        Dictionary<string, string> dictConfig = new Dictionary<string, string>();
        public CoreConfigManager()
        {
            InitializeComponent();
        }

        private void frmConfigManager_Load(object sender, EventArgs e)
        {
            try
            {
                //if (!CacheHelper.Exist("CoreConfigManager"))
                //{
                //    Device.Get_fun_important_Config();
                //    CacheHelper.Set("CoreConfigManager", DateTime.Now.AddHours(2), "");
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
            if (!File.Exists(Device.fun_important_configFilePath) || ToolCls.FileIsUsed(Device.fun_important_configFilePath))
            {
                MessageBox.Show("文件下载中，请稍后再试！");
                return;
            }
            var core_Content = File.ReadAllText(Device.fun_important_configFilePath);
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
                    var key = textBox.Name;
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SaveConfig();
                Device.Put_fun_important_Config();
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
            if (string.IsNullOrWhiteSpace(camera_id.Text))
            {
                MessageBox.Show("设备编码不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(area_code.Text))
            {
                MessageBox.Show("小区编码不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(no_screen_server.Text))
            {
                MessageBox.Show("无屏服务IP不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(no_screen_port.Text))
            {
                MessageBox.Show("无屏服务端口不能为空");
                return;
            }
            foreach (Control item in this.Controls)//获取控件的值赋值给配置文件
            {
                if (item is TextBox)
                {
                    var textBox = item as TextBox;
                    dictConfig[textBox.Name] = textBox.Text;
                }
            }
            var core_Content = File.ReadAllText(Device.fun_important_configFilePath);
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
            File.WriteAllText(Device.fun_important_configFilePath, core_Content);
        }
    }
}
