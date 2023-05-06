using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataServiceOpenAnalyzeResponse.
    /// </summary>
    public class AlipayDataServiceOpenAnalyzeResponse : AopResponse
    {
        /// <summary>
        /// 调用返回
        /// </summary>
        [XmlElement("result")]
        public AlipayDataServiceResult Result { get; set; }
    }
}
