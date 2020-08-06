using _8InchLinuxConfigTool.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8InchLinuxConfigTool.SubForm
{
    public partial class UpdateProgram : Form
    {
        public UpdateProgram()
        {
            InitializeComponent();
        }

        private void btnSelDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txtUpdatePackageDirectory.Text = path.SelectedPath;
        }

        private void UpdateProgram_Load(object sender, EventArgs e)
        {
            this.txtDeviceUpdateDirectory.Text = ConfigurationManager.AppSettings["DeviceUpdateDirectory"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtUpdatePackageDirectory.Text))
            {
                MessageBox.Show("请选择更新包目录");
                return;
            }
            Device.PutFiles(txtDeviceUpdateDirectory.Text, txtUpdatePackageDirectory.Text);
            MessageBox.Show("更新包下发成功");
        }
    }
}
