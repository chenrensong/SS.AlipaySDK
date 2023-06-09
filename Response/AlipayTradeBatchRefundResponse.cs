using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayTradeBatchRefundResponse.
    /// </summary>
    public class AlipayTradeBatchRefundResponse : AopResponse
    {
        /// <summary>
        /// 请求的批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }
    }
}
