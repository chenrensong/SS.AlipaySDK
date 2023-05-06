using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsUnderwritePolicyQueryResponse.
    /// </summary>
    public class AlipayInsUnderwritePolicyQueryResponse : AopResponse
    {
        /// <summary>
        /// 保单
        /// </summary>
        [XmlElement("policy")]
        public InsPolicy Policy { get; set; }
    }
}
