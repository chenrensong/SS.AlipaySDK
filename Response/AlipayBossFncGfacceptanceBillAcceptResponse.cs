using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncGfacceptanceBillAcceptResponse.
    /// </summary>
    public class AlipayBossFncGfacceptanceBillAcceptResponse : AopResponse
    {
        /// <summary>
        /// 业财受理结果
        /// </summary>
        [XmlElement("result")]
        public GFAOpenAPIAcceptanceResult Result { get; set; }
    }
}
