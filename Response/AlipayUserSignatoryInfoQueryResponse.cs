using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserSignatoryInfoQueryResponse.
    /// </summary>
    public class AlipayUserSignatoryInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("out_put_map")]
        public SignatoryInfoMap OutPutMap { get; set; }
    }
}
