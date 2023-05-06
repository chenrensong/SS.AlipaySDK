using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestnumberQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockTestnumberQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
