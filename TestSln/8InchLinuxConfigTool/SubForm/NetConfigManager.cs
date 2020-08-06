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
    public partial class NetConfigManager : Form
    {
        public NetConfigManager()
        {
            InitializeComponent();
        }

        private void frmConfigManager_Load(object sender, EventArgs e)
        {
            try
            {
                //if (!CacheHelper.Exist("NetConfigManager"))
                //{
                //    Device.GetEth_Config();
                //    CacheHelper.Set("NetConfigManager", DateTime.Now.AddHours(2), "");
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
            if (!File.Exists(Device.eth_configFilePath) || ToolCls.FileIsUsed(Device.eth_configFilePath)) {
                MessageBox.Show("文件下载中，请稍后再试！");
                return;
            }
            var eth_Content = File.ReadAllText(Device.eth_configFilePath);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(eth_Content);
            var eth_el = ToolCls.GetFromXMLEl(doc, "/root/eth");
            var dns_el = ToolCls.GetFromXMLEl(doc, "/root/eth/dns");
            var ip = eth_el.GetAttribute("ip");
            var submask = eth_el.GetAttribute("submask");
            var gateway = eth_el.GetAttribute("gateway");
            var dns1 = dns_el.GetAttribute("dns1");
            var dns2 = dns_el.GetAttribute("dns2");
            txtIP.Text = ip;
            txtsubmask.Text = submask;
            txtgateway.Text = gateway;
            txtdns1.Text = dns1;
            txtdns2.Text = dns2;
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
                Device.PutEth_Config();
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
            if (string.IsNullOrWhiteSpace(txtIP.Text))
            {
                MessageBox.Show("IP不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtsubmask.Text))
            {
                MessageBox.Show("子网掩码不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtgateway.Text))
            {
                MessageBox.Show("网关不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdns1.Text))
            {
                MessageBox.Show("dns1不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdns2.Text))
            {
                MessageBox.Show("dns2不能为空");
                return;
            }
            var eth_Content = File.ReadAllText(Device.eth_configFilePath);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(eth_Content);
            var eth_el = ToolCls.GetFromXMLEl(doc, "/root/eth");
            var dns_el = ToolCls.GetFromXMLEl(doc, "/root/eth/dns");
            eth_el.SetAttribute("ip", txtIP.Text);
            eth_el.SetAttribute("submask", txtsubmask.Text);
            eth_el.SetAttribute("gateway", txtgateway.Text);
            dns_el.SetAttribute("dns1", txtdns1.Text);
            dns_el.SetAttribute("dns2", txtdns2.Text);
            doc.Save(Device.eth_configFilePath);
        }
    }
}
