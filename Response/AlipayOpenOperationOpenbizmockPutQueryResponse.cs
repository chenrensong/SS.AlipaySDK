using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockPutQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockPutQueryResponse : AopResponse
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
