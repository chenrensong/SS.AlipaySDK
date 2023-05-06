using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdCreateResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserAdCreateResponse : AopResponse
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
