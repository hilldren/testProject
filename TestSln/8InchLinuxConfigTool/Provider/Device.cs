using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WinSCP;

namespace _8InchLinuxConfigTool.Provider
{
    public class Device
    {
        public static string HostName { get; set; }
        public static string base_deviceDirectory
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + HostName;
            }
        }
        public static string eth_configFilePath
        {
            get
            {
                return base_deviceDirectory + "\\eth.conf";
            }
        }
        public static string fun_normal_configFilePath
        {
            get
            {
                return base_deviceDirectory + "\\config.ini";
            }
        }
        public static string fun_important_configFilePath
        {
            get
            {
                return base_deviceDirectory + "\\core_config.ini";
            }
        }
        public static string DB_FilePath
        {
            get
            {
                return base_deviceDirectory + "\\model.db";
            }
        }
        public static string Log_FilePath
        {
            get
            {
                return base_deviceDirectory + "\\Log\\";
            }
        }
        public static SessionOptions sessionOptions;
        public static Session session;
        public static string Version { get; set; }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="HostName"></param>
        /// <param name="UserName"></param>
        /// <param name="Pwd"></param>
        /// <returns></returns>
        public static bool Connection(string HostName, string UserName, string Pwd)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(HostName))
                {
                    MessageBox.Show("请输入IP");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(UserName))
                {
                    MessageBox.Show("请输入用户名");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(Pwd))
                {
                    MessageBox.Show("请输入密码");
                    return false;
                }
                sessionOptions = new SessionOptions()
                {
                    Protocol = Protocol.Sftp,
                    HostName = HostName,
                    UserName = UserName,
                    Password = Pwd,
                };
                session = new Session();
                Device.HostName = HostName;

                //第一次连接通过扫描获取服务器指纹
                var hostKey = session.ScanFingerprint(sessionOptions, "SHA-256");
                sessionOptions.SshHostKeyFingerprint = hostKey;
                //连接
                session.Open(sessionOptions);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("登录失败");
                Logger.SaveLog("错误日志", ex);
                return false;
            }
        }
        /// <summary>
        /// 初始化设备文件目录
        /// </summary>
        public static void InitDeviceFileDirectory()
        {
            if (!Directory.Exists(base_deviceDirectory))
            {
                Directory.CreateDirectory(base_deviceDirectory);
            }
        }

        public static void GetFiles(string sourcePath, string localPath)
        {
          
            //下载文件到本地目录
            TransferOptions transferOptions = new TransferOptions();
            transferOptions.TransferMode = TransferMode.Binary;
            TransferOperationResult transferResult;
            transferResult = session.GetFiles(sourcePath, localPath, false, transferOptions);
            transferResult.Check();
            
        }

        public static void PutFiles(string sourcePath, string localPath)
        {
            if (!File.Exists(eth_configFilePath))
            {
                File.Create(eth_configFilePath).Dispose();
            }

            //下载文件到本地目录
            TransferOptions transferOptions = new TransferOptions();
            transferOptions.TransferMode = TransferMode.Binary;
            TransferOperationResult transferResult;
            transferResult = session.PutFiles(localPath, sourcePath, false, transferOptions);
            transferResult.Check();

        }
        /// <summary>
        /// 获取eth文件
        /// </summary>
        public static void GetEth_Config()
        {
            GetFiles("/mnt/mtd/nsd/config/setting/eth.conf", eth_configFilePath);
        }

        public static void Get_fun_normal_Config()
        {
            GetFiles("/mnt/mtd/nsd/ai/camera/config/config.ini", fun_normal_configFilePath);
        }

        public static void Get_fun_important_Config()
        {
            GetFiles("/mnt/mtd/nsd/ai/camera/config/core_config.ini", fun_important_configFilePath);
        }

        public static void Get_DB_File()
        {
            GetFiles("/mnt/mtd/nsd/ai/camera/db/model.db", DB_FilePath);
        }
        public static void Get_log_file()
        {
            if (!Directory.Exists(Log_FilePath))
            {
                Directory.CreateDirectory(Log_FilePath);
            }
            GetFiles("/mnt/mtd/nsd/ai/camera/logs/*", Log_FilePath);

            DirectoryInfo root = new DirectoryInfo(Device.Log_FilePath);
            FileInfo[] files = root.GetFiles().OrderByDescending(p => p.CreationTime).ToArray();
            foreach (var file in files)
            {
                StreamReader s = File.OpenText(file.FullName);
                string firstLine = s.ReadLine();//读取一行
                if (!firstLine.Contains("version")) continue;
                var aryfirstLine = firstLine.Split(' ');
                var version = aryfirstLine[aryfirstLine.Length - 1];
                Device.Version = version.TrimEnd('.');
                break;
            }
        }

        public static void PutEth_Config()
        {
            PutFiles("/mnt/mtd/nsd/config/setting/eth.conf", eth_configFilePath);
        }

        public static void Put_fun_normal_Config()
        {
            PutFiles("/mnt/mtd/nsd/ai/camera/config/config.ini", fun_normal_configFilePath);
        }

        public static void Put_fun_important_Config()
        {
            PutFiles("/mnt/mtd/nsd/ai/camera/config/core_config.ini", fun_important_configFilePath);
        }

        public static void Cmd(string text)
        {
            session.ExecuteCommand(text).Check();
        }
    }
}
