using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.PORTRAIT_DATA
{
  
    public class SYS_USERROOM
    {
        #region Property



        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string GUID
        {
            get;
            set;
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string NAME
        {
            get;
            set;
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string SEX
        {
            get;
            set;
        }

        /// <summary>
        /// 摄像主键
        /// </summary>
        public string CAMID
        {
            get;
            set;
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string USERINFO
        {
            get;
            set;
        }

        /// <summary>
        /// 民族
        /// </summary>
        public string NATION
        {
            get;
            set;
        }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string USERID
        {
            get;
            set;
        }

        /// <summary>
        /// 用户标识代号
        /// </summary>
        public string USERKEY
        {
            get;
            set;
        }

        /// <summary>
        /// 地址
        /// </summary>
        public string ADDRESS
        {
            get;
            set;
        }

        /// <summary>
        /// 国籍
        /// </summary>
        public string NAIONALITY
        {
            get;
            set;
        }

        /// <summary>
        /// 生日
        /// </summary>
        public string BIRTHDAY
        {
            get;
            set;
        }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CREATETIME
        {
            get;
            set;
        }

        /// <summary>
        /// 楼号
        /// </summary>
        public string BUILDINGNUM
        {
            get;
            set;
        }

        /// <summary>
        /// 单位号
        /// </summary>
        public string UNITNUM
        {
            get;
            set;
        }

        /// <summary>
        /// 房号
        /// </summary>
        public string ROOMNUM
        {
            get;
            set;
        }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime STARTTIME
        {
            get;
            set;
        }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime ENDTIME
        {
            get;
            set;
        }

        /// <summary>
        /// 类型
        /// </summary>
        public string CASETYPE
        {
            get;
            set;
        }

        /// <summary>
        /// 邀请码
        /// </summary>
        public string INVITECODE
        {
            get;
            set;
        }

        /// <summary>
        /// Rfid卡
        /// </summary>
        public string RFID
        {
            get;
            set;
        }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string PHONE
        {
            get;
            set;
        }

        /// <summary>
        /// 原因
        /// </summary>
        public string REASON
        {
            get;
            set;
        }

        /// <summary>
        /// 来访人员
        /// </summary>
        public double VISITNUM
        {
            get;
            set;
        }

        /// <summary>
        /// 来访人员单位
        /// </summary>
        public string UNIT
        {
            get;
            set;
        }

        /// <summary>
        /// 车牌号码
        /// </summary>
        public string CARNUM
        {
            get;
            set;
        }

        /// <summary>
        /// 携带物品
        /// </summary>
        public string GOODS
        {
            get;
            set;
        }

        /// <summary>
        /// 部门编号
        /// </summary>
        public string DEPARTMENTID
        {
            get;
            set;
        }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DEPARTMENTNAME
        {
            get;
            set;
        }

        /// <summary>
        /// 业主名称
        /// </summary>
        public string OWNER
        {
            get;
            set;
        }

        /// <summary>
        /// 业主电话
        /// </summary>
        public string OWNERTEL
        {
            get;
            set;
        }

        /// <summary>
        /// 创建人员
        /// </summary>
        public string APPLYID
        {
            get;
            set;
        }

        /// <summary>
        /// IC卡号
        /// </summary>
        public string ICCODE
        {
            get;
            set;
        }

        /// <summary>
        /// 银行卡号
        /// </summary>
        public string BANKNUM
        {
            get;
            set;
        }

        /// <summary>
        /// 住客类型，自住，租住，社会活动，工作人员
        /// </summary>
        public string USERTYPE
        {
            get;
            set;
        }

        /// <summary>
        /// 小区编号
        /// </summary>
        public string AREACODE
        {
            get;
            set;
        }

        /// <summary>
        /// 小区名称
        /// </summary>
        public string AREANAME
        {
            get;
            set;
        }

        /// <summary>
        /// 创建名称
        /// </summary>
        public string APPLYNAME
        {
            get;
            set;
        }

        /// <summary>
        /// 审批人ID
        /// </summary>
        public string APPROVEID
        {
            get;
            set;
        }

        /// <summary>
        /// 审批人名称
        /// </summary>
        public string APPROVENAME
        {
            get;
            set;
        }

        /// <summary>
        /// 审批时间
        /// </summary>
        public DateTime APPROVETIME
        {
            get;
            set;
        }

        /// <summary>
        /// 业主编号
        /// </summary>
        public string OWNERID
        {
            get;
            set;
        }

        /// <summary>
        /// 审批状态
        /// </summary>
        public double APPROVESTATE
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string OPENID
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string UNITCODE
        {
            get;
            set;
        }

        /// <summary>
        /// 指纹对应ID
        /// </summary>
        public string FINGERKEY
        {
            get;
            set;
        }

        /// <summary>
        /// 籍贯
        /// </summary>
        public string NATIVE
        {
            get;
            set;
        }

        /// <summary>
        /// 学历
        /// </summary>
        public string EDUCATION
        {
            get;
            set;
        }

        /// <summary>
        /// 工作单位
        /// </summary>
        public string WORKUNIT
        {
            get;
            set;
        }

        /// <summary>
        /// 职务
        /// </summary>
        public string POST
        {
            get;
            set;
        }

        /// <summary>
        /// 开户行
        /// </summary>
        public string OPENBANK
        {
            get;
            set;
        }

        /// <summary>
        /// 紧急联系人
        /// </summary>
        public string EMERGENCYUSER
        {
            get;
            set;
        }

        /// <summary>
        /// 紧急联系方式
        /// </summary>
        public string EMERGENCYTEL
        {
            get;
            set;
        }

        /// <summary>
        /// 紧急联系地址
        /// </summary>
        public string EMERGENCYADDRESS
        {
            get;
            set;
        }

        /// <summary>
        /// 是否同步分中心
        /// </summary>
        public double ISSYN
        {
            get;
            set;
        }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UPDATETIME
        {
            get;
            set;
        }

        /// <summary>
        /// 所在派出所
        /// </summary>
        public string POLICESTATION
        {
            get;
            set;
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string REMARK
        {
            get;
            set;
        }

        /// <summary>
        /// 楼宇名称
        /// </summary>
        public string BUILDINGNAME
        {
            get;
            set;
        }

        /// <summary>
        /// 单元id
        /// </summary>
        public string UNITID
        {
            get;
            set;
        }

        /// <summary>
        /// 单元名称
        /// </summary>
        public string UNIDNAME
        {
            get;
            set;
        }

        /// <summary>
        /// 房间名称
        /// </summary>
        public string ROOMNAME
        {
            get;
            set;
        }

        /// <summary>
        /// 楼宇id
        /// </summary>
        public string BUILDINGID
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string IDENTITYTYPE
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime INTIME
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime OUTTIME
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public double STATE
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
        /// 核签状态
        /// </summary>
        public double SIGNATURESTATE
        {
            get;
            set;
        }

        /// <summary>
        /// 出没次数
        /// </summary>
        public double APPEARCOUNT
        {
            get;
            set;
        }

        /// <summary>
        /// 人员类型
        /// </summary>
        public double PERSONTYPE
        {
            get;
            set;
        }

        /// <summary>
        /// 出没类型
        /// </summary>
        public double APPEARTYPE
        {
            get;
            set;
        }

        /// <summary>
        /// 是否已经还证
        /// </summary>
        public double ISRETURNPASS
        {
            get;
            set;
        }

        /// <summary>
        /// 审批意见
        /// </summary>
        public string APPROVEOPINION
        {
            get;
            set;
        }

        /// <summary>
        /// 房间id
        /// </summary>
        public string ROOMID
        {
            get;
            set;
        }

        /// <summary>
        /// 0身份证1护照2港澳通行证3台胞证
        /// </summary>
        public double CERTIFICATETYPE
        {
            get;
            set;
        }

        /// <summary>
        /// 是否是管理员，1表示管理员，0表示非管理员
        /// </summary>
        public double ISMANAGER
        {
            get;
            set;
        }

        /// <summary>
        /// 证件照
        /// </summary>
        public byte[] PHOTO1
        {
            get;
            set;
        }

        /// <summary>
        /// 现场照
        /// </summary>
        public byte[] PHOTO2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] PHOTO3
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] PHOTO4
        {
            get;
            set;
        }

        /// <summary>
        /// 证件照
        /// </summary>
        public string PHOTOURL1
        {
            get;
            set;
        }

        /// <summary>
        /// 现场照
        /// </summary>
        public string PHOTOURL2
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PHOTOURL3
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PHOTOURL4
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

        /// <summary>
        /// 缴费照片
        /// </summary>
        public string PAYMENTPHOTOURL
        {
            get;
            set;
        }

        /// <summary>
        /// 合同照片
        /// </summary>
        public string CONTRACTPHOTOURL
        {
            get;
            set;
        }

        /// <summary>
        /// 人员信息是否已经转到轨迹0表示没有1表示已传
        /// </summary>
        public double ISTRANSFERTRACE
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string AUTHORIZATIONID
        {
            get;
            set;
        }

        /// <summary>
        /// 微信的openid
        /// </summary>
        public string WECHATID
        {
            get;
            set;
        }


        #endregion
    }
}
