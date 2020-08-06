using _8InchLinuxConfigTool.Provider;
using Common;
using Model.PORTRAIT_DATA;
using SqlSugar;
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
    public partial class DataQuery : Form
    {
        int PageSize = 13;
        int PageIndex = 1;
        int TotalCount = 0;
        public DataQuery()
        {
            InitializeComponent();

            if (!CacheHelper.Exist("DataQuery"))
            {
                bool updateDb = false;
                if (File.Exists(Device.DB_FilePath))
                {
                    updateDb = true;
                }
                Task.Factory.StartNew(() =>
                {
                    Device.Get_DB_File();
                }).ContinueWith((t) =>
                {
                    if (updateDb)
                    {
                        MessageBox.Show("数据库DB文件更新完毕");
                    }
                    else
                    {
                        MessageBox.Show("数据库DB文件下载完毕");
                    }
                });
                CacheHelper.Set("DataQuery", DateTime.Now.AddHours(2), "");
            }

        }

        private void DataQuery_Load(object sender, EventArgs e)
        {
            btnQuery_Click(null, null);
        }
        public void BindDgv()
        {
            SqlSugarClient db = null;
            try
            {
                db = SqlLiteHelper.GetInstance();
                if (!File.Exists(Device.DB_FilePath))
                {
                    MessageBox.Show("文件下载中，请稍后再试！");
                    return;
                }
                var sourceList = db.Queryable<SYS_USERROOM, SYS_MODELS>((u, m) => new object[] {
        JoinType.Left,u.GUID==m.GUID})
                    .Select((u, m) => new
                    {
                        u.GUID,
                        u.NAME,
                        u.CREATETIME,
                        m.MODELID,
                        m.FEATURE,
                        u.STARTTIME,
                        u.ENDTIME,
                        u.AREACODE,
                        u.AREANAME,
                        u.USERTYPE,
                    });
                if (!string.IsNullOrWhiteSpace(txtName.Text))
                {
                    sourceList = sourceList.Where(u => u.NAME.Contains(txtName.Text));
                }
                TotalCount = sourceList.Count();
                if (PageIndex <= 1) { PageIndex = 1; }
                var maxPageIndex = Math.Ceiling((decimal)TotalCount / (decimal)PageSize);
                if (PageIndex >= maxPageIndex) { PageIndex = maxPageIndex.ToInt32(); }
                var skip = (PageIndex - 1) * PageSize;
                sourceList = sourceList.Take(PageSize).Skip(skip)
           .OrderBy(u => u.CREATETIME, OrderByType.Desc);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = sourceList.ToList();
                lblTotalCount.Text = $"第{PageIndex}页，每页{PageSize}条，总数：" + TotalCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("文件下载中，请稍后再试！");
            }
            db.Close();
            db.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            PageIndex = 1;
            BindDgv();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PageIndex++;
            BindDgv();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            PageIndex--;
            BindDgv();
        }
    }
}
