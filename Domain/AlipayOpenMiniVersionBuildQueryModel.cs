using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionBuildQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionBuildQueryModel : AopObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序投放的端参数，默认为支付宝端。支持：  com.alipay.alipaywallet：支付宝端。 com.alipay.iot.xpaas：IOT端。 例如：投放到支付宝钱包为支付宝端需传入 com.alipay.alipaywallet。
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }
    }
}
