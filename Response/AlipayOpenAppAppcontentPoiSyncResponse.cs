using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentPoiSyncResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentPoiSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝返回的唯一编码
        /// </summary>
        [XmlElement("alipay_poi_id")]
        public string AlipayPoiId { get; set; }
    }
}
