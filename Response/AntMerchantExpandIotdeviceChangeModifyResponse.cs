using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandIotdeviceChangeModifyResponse.
    /// </summary>
    public class AntMerchantExpandIotdeviceChangeModifyResponse : AopResponse
    {
        /// <summary>
        /// 业务单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }
    }
}
