using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _8InchLinuxConfigTool.Provider
{
    public class ToolCls
    {
        /// <summary>
        /// XML格式化为文本显示
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ShowXml(string str)
        {
            MemoryStream mstream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(mstream, null);
            XmlDocument xmldoc = new XmlDocument();
            writer.Formatting = Formatting.Indented;
            xmldoc.LoadXml(str);
            xmldoc.WriteTo(writer);
            writer.Flush();
            writer.Close();
            Encoding encoding = Encoding.GetEncoding("utf-8");
            string strReturn = encoding.GetString(mstream.ToArray());
            mstream.Close();
            return strReturn;
        }

        public static XmlElement GetFromXMLEl(XmlDocument xmlDoc, string strPath)
        {
            XmlElement xe = xmlDoc.DocumentElement; // DocumentElement 获取xml文档对象的根XmlElement.
            XmlElement selectXe = (XmlElement)xe.SelectSingleNode(strPath);  //selectSingleNode 根据XPath表达式,获得符合条件的第一个节点.
            return selectXe;
        }


        /// <summary>
        /// 返回指示文件是否已被其它程序使用的布尔值
        /// </summary>
        /// <param name="fileFullName">文件的完全限定名，例如：“C:\MyFile.txt”。</param>
        /// <returns>如果文件已被其它程序使用，则为 true；否则为 false。</returns>
        public static Boolean FileIsUsed(String fileFullName)
        {
            Boolean result = false;
            //判断文件是否存在，如果不存在，直接返回 false
            if (!System.IO.File.Exists(fileFullName))
            {
                result = false;
            }//end: 如果文件不存在的处理逻辑
            else
            {//如果文件存在，则继续判断文件是否已被其它程序使用
             //逻辑：尝试执行打开文件的操作，如果文件已经被其它程序使用，则打开失败，抛出异常，根据此类异常可以判断文件是否已被其它程序使用。
                System.IO.FileStream fileStream = null;
                try
                {
                    fileStream = System.IO.File.Open(fileFullName, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None);
                    result = false;
                }
                catch (System.IO.IOException ioEx)
                {
                    result = true;
                }
                catch (System.Exception ex)
                {
                    result = true;
                }
                finally
                {
                    if (fileStream != null)
                    {
                        fileStream.Close();
                    }
                }
            }//end: 如果文件存在的处理逻辑
             //返回指示文件是否已被其它程序使用的值
            return result;
        }//end method FileIsUsed
    }
}
