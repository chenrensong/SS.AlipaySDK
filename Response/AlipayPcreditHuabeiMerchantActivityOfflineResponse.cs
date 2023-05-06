using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantActivityOfflineResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantActivityOfflineResponse : AopResponse
    {
        /// <summary>
        /// 商户活动ID
        /// </summary>
        [XmlElement("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
