using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodDeviceInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodDeviceInitializeModel : AopObject
    {
        /// <summary>
        /// 设备sn，通常置于设备标签中
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 扩展信息，必须为JSON格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// IMEI移动设备识别码
        /// </summary>
        [XmlElement("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 物料id,需支付宝同学提供
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// mac地址，网络设备网卡地址
        /// </summary>
        [XmlElement("mac")]
        public string Mac { get; set; }

        /// <summary>
        /// 设备无线网络类型，可选项[2G,3G,4G,WIRED,BT,OTHER,NONE]  2G-2G移动网络  3G-3G移动网络  4G-4G移动网络  WIRED-有线网络  WIFI-无线网络  BT-蓝牙  OTHER-其他网络类型  NONE-无联网功能
        /// </summary>
        [XmlElement("net_type")]
        public string NetType { get; set; }

        /// <summary>
        /// 软件版本
        /// </summary>
        [XmlElement("os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// 加签明文，针对带miniSDK的特殊设备使用，其他设备不需要填该内容
        /// </summary>
        [XmlElement("plain_text")]
        public string PlainText { get; set; }

        /// <summary>
        /// 加签信息，针对带miniSDK的特殊设备使用，其他设备不需要填写该内容
        /// </summary>
        [XmlElement("sign_info")]
        public string SignInfo { get; set; }

        /// <summary>
        /// 供应商id,该值由支付宝同学提供
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
