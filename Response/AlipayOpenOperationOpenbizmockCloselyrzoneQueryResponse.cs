using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockCloselyrzoneQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockCloselyrzoneQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试人员测试时需要
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
