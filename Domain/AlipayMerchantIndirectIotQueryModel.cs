using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectIotQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectIotQueryModel : AopObject
    {
        /// <summary>
        /// 不同物联网平台接入渠道不同值，支付宝物联网平台传设备SN号，阿里云物联网平台传设备deviceName
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 固定枚举值,支付宝物联网平台传SN，阿里云物联网平台传ALIYUN
        /// </summary>
        [XmlElement("device_id_type")]
        public string DeviceIdType { get; set; }

        /// <summary>
        /// 表示调用时机： AFTER_PAY 支付后 BEFORE_PAY 支付前
        /// </summary>
        [XmlElement("occasion")]
        public string Occasion { get; set; }

        /// <summary>
        /// 固定枚举值（阿里云物联网平台：ALIYUN，支付宝物联网平台：SDK）
        /// </summary>
        [XmlElement("play_mode")]
        public string PlayMode { get; set; }

        /// <summary>
        /// 间连商户在支付宝体系内的唯一id,一般以2088开头
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 不同物联网平台接入渠道不同值，支付宝物联网平台传设备sourceId号，阿里云物联网平台传设备productKey
        /// </summary>
        [XmlElement("suppler_id")]
        public string SupplerId { get; set; }

        /// <summary>
        /// 交易订单id
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 交易类型 可选值: ALIPAY_TRADE 支付宝交易 OTHER 其他交易途径
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
