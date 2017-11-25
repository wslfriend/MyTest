﻿﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.School.Entity
{
    /// <summary>交易</summary>
    [Serializable]
    [DataObject]
    [Description("交易")]
    [BindTable("Trade", Description = "交易", ConnName = "Bill", DbType = DatabaseType.SqlServer)]
    public partial class Trade : ITrade
    {
        #region 属性
        private Int32 _ID;
        /// <summary>订单编号</summary>
        [DisplayName("订单编号")]
        [Description("订单编号")]
        [DataObjectField(true, true, false, 10)]
        [BindColumn(1, "ID", "订单编号", null, "int", 10, 0, false)]
        public virtual Int32 ID
        {
            get { return _ID; }
            set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } }
        }

        private Int32 _NodeID;
        /// <summary>节点号</summary>
        [DisplayName("节点号")]
        [Description("节点号")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(2, "NodeID", "节点号", null, "int", 10, 0, false)]
        public virtual Int32 NodeID
        {
            get { return _NodeID; }
            set { if (OnPropertyChanging(__.NodeID, value)) { _NodeID = value; OnPropertyChanged(__.NodeID); } }
        }

        private String _Tid;
        /// <summary>订单号</summary>
        [DisplayName("订单号")]
        [Description("订单号")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(3, "Tid", "订单号", null, "nvarchar(50)", 0, 0, true)]
        public virtual String Tid
        {
            get { return _Tid; }
            set { if (OnPropertyChanging(__.Tid, value)) { _Tid = value; OnPropertyChanged(__.Tid); } }
        }

        private Int32 _Status;
        /// <summary>状态</summary>
        [DisplayName("状态")]
        [Description("状态")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(4, "Status", "状态", null, "int", 10, 0, false)]
        public virtual Int32 Status
        {
            get { return _Status; }
            set { if (OnPropertyChanging(__.Status, value)) { _Status = value; OnPropertyChanged(__.Status); } }
        }

        private Int32 _PayStatus;
        /// <summary>是否支付</summary>
        [DisplayName("是否支付")]
        [Description("是否支付")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(5, "PayStatus", "是否支付", null, "int", 10, 0, false)]
        public virtual Int32 PayStatus
        {
            get { return _PayStatus; }
            set { if (OnPropertyChanging(__.PayStatus, value)) { _PayStatus = value; OnPropertyChanged(__.PayStatus); } }
        }

        private Int32 _ShipStatus;
        /// <summary>是否发货</summary>
        [DisplayName("是否发货")]
        [Description("是否发货")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(6, "ShipStatus", "是否发货", null, "int", 10, 0, false)]
        public virtual Int32 ShipStatus
        {
            get { return _ShipStatus; }
            set { if (OnPropertyChanging(__.ShipStatus, value)) { _ShipStatus = value; OnPropertyChanged(__.ShipStatus); } }
        }

        private String _CreateIPReceiverPhone;
        /// <summary>收货人电话</summary>
        [DisplayName("收货人电话")]
        [Description("收货人电话")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(7, "CreateIPReceiverPhone", "收货人电话", null, "nvarchar(50)", 0, 0, true)]
        public virtual String CreateIPReceiverPhone
        {
            get { return _CreateIPReceiverPhone; }
            set { if (OnPropertyChanging(__.CreateIPReceiverPhone, value)) { _CreateIPReceiverPhone = value; OnPropertyChanged(__.CreateIPReceiverPhone); } }
        }

        private String _ReceiverMobile;
        /// <summary>收货人手机号</summary>
        [DisplayName("收货人手机号")]
        [Description("收货人手机号")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(8, "ReceiverMobile", "收货人手机号", null, "nvarchar(50)", 0, 0, true)]
        public virtual String ReceiverMobile
        {
            get { return _ReceiverMobile; }
            set { if (OnPropertyChanging(__.ReceiverMobile, value)) { _ReceiverMobile = value; OnPropertyChanged(__.ReceiverMobile); } }
        }

        private String _ReceiverState;
        /// <summary>收货省</summary>
        [DisplayName("收货省")]
        [Description("收货省")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(9, "ReceiverState", "收货省", null, "nvarchar(50)", 0, 0, true)]
        public virtual String ReceiverState
        {
            get { return _ReceiverState; }
            set { if (OnPropertyChanging(__.ReceiverState, value)) { _ReceiverState = value; OnPropertyChanged(__.ReceiverState); } }
        }

        private String _ReceiverCity;
        /// <summary>收货人区</summary>
        [DisplayName("收货人区")]
        [Description("收货人区")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(10, "ReceiverCity", "收货人区", null, "nvarchar(50)", 0, 0, true)]
        public virtual String ReceiverCity
        {
            get { return _ReceiverCity; }
            set { if (OnPropertyChanging(__.ReceiverCity, value)) { _ReceiverCity = value; OnPropertyChanged(__.ReceiverCity); } }
        }

        private String _Receiver_District;
        /// <summary>收货区</summary>
        [DisplayName("收货区")]
        [Description("收货区")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(11, "Receiver_District", "收货区", null, "nvarchar(50)", 0, 0, true)]
        public virtual String Receiver_District
        {
            get { return _Receiver_District; }
            set { if (OnPropertyChanging(__.Receiver_District, value)) { _Receiver_District = value; OnPropertyChanged(__.Receiver_District); } }
        }

        private String _ReceiverAddress;
        /// <summary>收货地址</summary>
        [DisplayName("收货地址")]
        [Description("收货地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(12, "ReceiverAddress", "收货地址", null, "nvarchar(50)", 0, 0, true)]
        public virtual String ReceiverAddress
        {
            get { return _ReceiverAddress; }
            set { if (OnPropertyChanging(__.ReceiverAddress, value)) { _ReceiverAddress = value; OnPropertyChanged(__.ReceiverAddress); } }
        }

        private String _BuyerName;
        /// <summary>买家昵称</summary>
        [DisplayName("买家昵称")]
        [Description("买家昵称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(13, "BuyerName", "买家昵称", null, "nvarchar(50)", 0, 0, true)]
        public virtual String BuyerName
        {
            get { return _BuyerName; }
            set { if (OnPropertyChanging(__.BuyerName, value)) { _BuyerName = value; OnPropertyChanged(__.BuyerName); } }
        }

        private Int32 _Created;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(14, "Created", "创建时间", null, "int", 10, 0, false)]
        public virtual Int32 Created
        {
            get { return _Created; }
            set { if (OnPropertyChanging(__.Created, value)) { _Created = value; OnPropertyChanged(__.Created); } }
        }

        private Int32 _Modified;
        /// <summary>是否发送过</summary>
        [DisplayName("是否发送过")]
        [Description("是否发送过")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(15, "Modified", "是否发送过", null, "int", 10, 0, false)]
        public virtual Int32 Modified
        {
            get { return _Modified; }
            set { if (OnPropertyChanging(__.Modified, value)) { _Modified = value; OnPropertyChanged(__.Modified); } }
        }

        private Int32 _IsSend;
        /// <summary>更新者</summary>
        [DisplayName("更新者")]
        [Description("更新者")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(16, "IsSend", "更新者", null, "int", 10, 0, false)]
        public virtual Int32 IsSend
        {
            get { return _IsSend; }
            set { if (OnPropertyChanging(__.IsSend, value)) { _IsSend = value; OnPropertyChanged(__.IsSend); } }
        }

        private String _ErrorMsg;
        /// <summary>错误原因</summary>
        [DisplayName("错误原因")]
        [Description("错误原因")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn(17, "ErrorMsg", "错误原因", null, "nvarchar(200)", 0, 0, true)]
        public virtual String ErrorMsg
        {
            get { return _ErrorMsg; }
            set { if (OnPropertyChanging(__.ErrorMsg, value)) { _ErrorMsg = value; OnPropertyChanged(__.ErrorMsg); } }
        }
        #endregion

        #region 获取/设置 字段值
        /// <summary>
        /// 获取/设置 字段值。
        /// 一个索引，基类使用反射实现。
        /// 派生实体类可重写该索引，以避免反射带来的性能损耗
        /// </summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.ID : return _ID;
                    case __.NodeID : return _NodeID;
                    case __.Tid : return _Tid;
                    case __.Status : return _Status;
                    case __.PayStatus : return _PayStatus;
                    case __.ShipStatus : return _ShipStatus;
                    case __.CreateIPReceiverPhone : return _CreateIPReceiverPhone;
                    case __.ReceiverMobile : return _ReceiverMobile;
                    case __.ReceiverState : return _ReceiverState;
                    case __.ReceiverCity : return _ReceiverCity;
                    case __.Receiver_District : return _Receiver_District;
                    case __.ReceiverAddress : return _ReceiverAddress;
                    case __.BuyerName : return _BuyerName;
                    case __.Created : return _Created;
                    case __.Modified : return _Modified;
                    case __.IsSend : return _IsSend;
                    case __.ErrorMsg : return _ErrorMsg;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.NodeID : _NodeID = Convert.ToInt32(value); break;
                    case __.Tid : _Tid = Convert.ToString(value); break;
                    case __.Status : _Status = Convert.ToInt32(value); break;
                    case __.PayStatus : _PayStatus = Convert.ToInt32(value); break;
                    case __.ShipStatus : _ShipStatus = Convert.ToInt32(value); break;
                    case __.CreateIPReceiverPhone : _CreateIPReceiverPhone = Convert.ToString(value); break;
                    case __.ReceiverMobile : _ReceiverMobile = Convert.ToString(value); break;
                    case __.ReceiverState : _ReceiverState = Convert.ToString(value); break;
                    case __.ReceiverCity : _ReceiverCity = Convert.ToString(value); break;
                    case __.Receiver_District : _Receiver_District = Convert.ToString(value); break;
                    case __.ReceiverAddress : _ReceiverAddress = Convert.ToString(value); break;
                    case __.BuyerName : _BuyerName = Convert.ToString(value); break;
                    case __.Created : _Created = Convert.ToInt32(value); break;
                    case __.Modified : _Modified = Convert.ToInt32(value); break;
                    case __.IsSend : _IsSend = Convert.ToInt32(value); break;
                    case __.ErrorMsg : _ErrorMsg = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得交易字段信息的快捷方式</summary>
        public partial class _
        {
            ///<summary>订单编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            ///<summary>节点号</summary>
            public static readonly Field NodeID = FindByName(__.NodeID);

            ///<summary>订单号</summary>
            public static readonly Field Tid = FindByName(__.Tid);

            ///<summary>状态</summary>
            public static readonly Field Status = FindByName(__.Status);

            ///<summary>是否支付</summary>
            public static readonly Field PayStatus = FindByName(__.PayStatus);

            ///<summary>是否发货</summary>
            public static readonly Field ShipStatus = FindByName(__.ShipStatus);

            ///<summary>收货人电话</summary>
            public static readonly Field CreateIPReceiverPhone = FindByName(__.CreateIPReceiverPhone);

            ///<summary>收货人手机号</summary>
            public static readonly Field ReceiverMobile = FindByName(__.ReceiverMobile);

            ///<summary>收货省</summary>
            public static readonly Field ReceiverState = FindByName(__.ReceiverState);

            ///<summary>收货人区</summary>
            public static readonly Field ReceiverCity = FindByName(__.ReceiverCity);

            ///<summary>收货区</summary>
            public static readonly Field Receiver_District = FindByName(__.Receiver_District);

            ///<summary>收货地址</summary>
            public static readonly Field ReceiverAddress = FindByName(__.ReceiverAddress);

            ///<summary>买家昵称</summary>
            public static readonly Field BuyerName = FindByName(__.BuyerName);

            ///<summary>创建时间</summary>
            public static readonly Field Created = FindByName(__.Created);

            ///<summary>是否发送过</summary>
            public static readonly Field Modified = FindByName(__.Modified);

            ///<summary>更新者</summary>
            public static readonly Field IsSend = FindByName(__.IsSend);

            ///<summary>错误原因</summary>
            public static readonly Field ErrorMsg = FindByName(__.ErrorMsg);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得交易字段名称的快捷方式</summary>
        partial class __
        {
            ///<summary>订单编号</summary>
            public const String ID = "ID";

            ///<summary>节点号</summary>
            public const String NodeID = "NodeID";

            ///<summary>订单号</summary>
            public const String Tid = "Tid";

            ///<summary>状态</summary>
            public const String Status = "Status";

            ///<summary>是否支付</summary>
            public const String PayStatus = "PayStatus";

            ///<summary>是否发货</summary>
            public const String ShipStatus = "ShipStatus";

            ///<summary>收货人电话</summary>
            public const String CreateIPReceiverPhone = "CreateIPReceiverPhone";

            ///<summary>收货人手机号</summary>
            public const String ReceiverMobile = "ReceiverMobile";

            ///<summary>收货省</summary>
            public const String ReceiverState = "ReceiverState";

            ///<summary>收货人区</summary>
            public const String ReceiverCity = "ReceiverCity";

            ///<summary>收货区</summary>
            public const String Receiver_District = "Receiver_District";

            ///<summary>收货地址</summary>
            public const String ReceiverAddress = "ReceiverAddress";

            ///<summary>买家昵称</summary>
            public const String BuyerName = "BuyerName";

            ///<summary>创建时间</summary>
            public const String Created = "Created";

            ///<summary>是否发送过</summary>
            public const String Modified = "Modified";

            ///<summary>更新者</summary>
            public const String IsSend = "IsSend";

            ///<summary>错误原因</summary>
            public const String ErrorMsg = "ErrorMsg";

        }
        #endregion
    }

    /// <summary>交易接口</summary>
    public partial interface ITrade
    {
        #region 属性
        /// <summary>订单编号</summary>
        Int32 ID { get; set; }

        /// <summary>节点号</summary>
        Int32 NodeID { get; set; }

        /// <summary>订单号</summary>
        String Tid { get; set; }

        /// <summary>状态</summary>
        Int32 Status { get; set; }

        /// <summary>是否支付</summary>
        Int32 PayStatus { get; set; }

        /// <summary>是否发货</summary>
        Int32 ShipStatus { get; set; }

        /// <summary>收货人电话</summary>
        String CreateIPReceiverPhone { get; set; }

        /// <summary>收货人手机号</summary>
        String ReceiverMobile { get; set; }

        /// <summary>收货省</summary>
        String ReceiverState { get; set; }

        /// <summary>收货人区</summary>
        String ReceiverCity { get; set; }

        /// <summary>收货区</summary>
        String Receiver_District { get; set; }

        /// <summary>收货地址</summary>
        String ReceiverAddress { get; set; }

        /// <summary>买家昵称</summary>
        String BuyerName { get; set; }

        /// <summary>创建时间</summary>
        Int32 Created { get; set; }

        /// <summary>是否发送过</summary>
        Int32 Modified { get; set; }

        /// <summary>更新者</summary>
        Int32 IsSend { get; set; }

        /// <summary>错误原因</summary>
        String ErrorMsg { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}