using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppOpenbizmockOpenidnonstandQueryResponse.
    /// </summary>
    public class AlipayOpenAppOpenbizmockOpenidnonstandQueryResponse : AopResponse
    {
        /// <summary>
        /// 模拟结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
