using _8InchLinuxConfigTool.Provider;
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
    public partial class LogQuery : Form
    {
        public LogQuery()
        {
            InitializeComponent();
        }

        private void LogQuery_Load(object sender, EventArgs e)
        {
            //if (!File.Exists(Device.Log_FilePath) || ToolCls.FileIsUsed(Device.Log_FilePath))
            //{
            //    MessageBox.Show("文件下载中，请稍后再试！");
            //    return;
            //}
            DirectoryInfo root = new DirectoryInfo(Device.Log_FilePath);
            FileInfo[] files = root.GetFiles().OrderByDescending(p=>p.Name).ToArray();
            foreach (var file in files)
            {
                var Item = new listBox1Item()
                {
                    key = file.Name,
                    value = file.FullName,
                };
                listBox1.Items.Add(Item);
            }
            listBox1.DisplayMember = "key";
            listBox1.ValueMember = "value";

        }

        public class listBox1Item
        {
            public string key { get; set; }
            public string value { get; set; }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selItem = listBox1.SelectedItem as listBox1Item;
                var filePath = selItem.value;
                var logContent = File.ReadAllText(filePath);
                this.textBox1.Text = logContent.Replace("\n","\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取错误");
                Common.Logger.SaveLog("错误日志", ex);
            }
        }
    }
}
