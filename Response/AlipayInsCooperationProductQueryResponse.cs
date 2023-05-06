using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsCooperationProductQueryResponse.
    /// </summary>
    public class AlipayInsCooperationProductQueryResponse : AopResponse
    {
        /// <summary>
        /// 保险产品
        /// </summary>
        [XmlElement("product")]
        public InsProduct Product { get; set; }
    }
}
