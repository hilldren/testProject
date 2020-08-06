using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.PORTRAIT_DATA
{
    public class SYS_MODELS
    {
        #region Property

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string GUID
        {
            get;
            set;
        }

        /// <summary>
        /// 建模ID
        /// </summary>
        public double MODELID
        {
            get;
            set;
        }

        /// <summary>
        /// 异步比对批次号
        /// </summary>
        public string VERIFYINDEX
        {
            get;
            set;
        }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string FILENAME
        {
            get;
            set;
        }

        /// <summary>
        /// 导入时间
        /// </summary>
        public DateTime IMPORTDATE
        {
            get;
            set;
        }

        /// <summary>
        /// 库类别
        /// </summary>
        public string MODELTYPE
        {
            get;
            set;
        }

        /// <summary>
        /// 摄像头ID
        /// </summary>
        public string CAMID
        {
            get;
            set;
        }

        /// <summary>
        /// 建模信息
        /// </summary>
        public string FEATURE
        {
            get;
            set;
        }

        /// <summary>
        /// 用户组标识
        /// </summary>
        public string USERGROUPID
        {
            get;
            set;
        }

        /// <summary>
        /// 精确人脸角度
        /// </summary>
        public double HANGLE
        {
            get;
            set;
        }

        /// <summary>
        /// 创建时间（采集时间）
        /// </summary>
        public DateTime CREATEDATETIME
        {
            get;
            set;
        }

        /// <summary>
        /// 比对CCIP地址
        /// </summary>
        public string CCIP
        {
            get;
            set;
        }

        /// <summary>
        /// 所属角度
        /// </summary>
        public double ANGLEFLAG
        {
            get;
            set;
        }

        /// <summary>
        /// 中转状态
        /// </summary>
        public double TRANSITSIGN
        {
            get;
            set;
        }

        /// <summary>
        /// 建模信息2，多算法
        /// </summary>
        public string FETURE2
        {
            get;
            set;
        }

        /// <summary>
        /// 图片信息
        /// </summary>
        public string QUERYPATH
        {
            get;
            set;
        }

        /// <summary>
        /// 图片信息
        /// </summary>
        public byte[] QUERYIMAGE
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double FLAG
        {
            get;
            set;
        }


        #endregion
    }
}
