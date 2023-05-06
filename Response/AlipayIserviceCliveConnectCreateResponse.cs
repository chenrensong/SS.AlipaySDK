using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceCliveConnectCreateResponse.
    /// </summary>
    public class AlipayIserviceCliveConnectCreateResponse : AopResponse
    {
        /// <summary>
        /// 响应
        /// </summary>
        [XmlElement("value")]
        public ConnectServerAdaptResult Value { get; set; }
    }
}
