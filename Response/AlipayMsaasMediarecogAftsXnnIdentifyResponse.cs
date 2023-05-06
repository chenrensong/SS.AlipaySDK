using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogAftsXnnIdentifyResponse.
    /// </summary>
    public class AlipayMsaasMediarecogAftsXnnIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 算法返回结果，json字符串
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
