using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeOrderdetailQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeOrderdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 对象
        /// </summary>
        [XmlElement("data")]
        public RechargeOrderTuitionDTO Data { get; set; }
    }
}
