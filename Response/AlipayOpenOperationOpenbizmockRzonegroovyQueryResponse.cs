using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockRzonegroovyQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockRzonegroovyQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
