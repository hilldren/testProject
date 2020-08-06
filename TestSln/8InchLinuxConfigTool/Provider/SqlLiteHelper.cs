using SqlSugar;
using System;
using System.Collections.Generic;
 
using System.Data.Common;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8InchLinuxConfigTool.Provider
{
    public class SqlLiteHelper
    {

        private static string connectionString
        {
            get
            {
                return $"Data Source={Device.DB_FilePath};Pooling=true;FailIfMissing=false";
            }
        }
        public static SqlSugarClient GetInstance(string str = "")
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                str = connectionString;
            }
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = str,
                DbType = DbType.Sqlite, //必填   
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute,  // Attribute用于DbFirst  从数据库生成model的
            }); return db;
        }
    }
}
