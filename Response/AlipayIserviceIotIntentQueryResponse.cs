using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceIotIntentQueryResponse.
    /// </summary>
    public class AlipayIserviceIotIntentQueryResponse : AopResponse
    {
        /// <summary>
        /// iot的响应类
        /// </summary>
        [XmlElement("iot_response")]
        public IntentQueryResponse IotResponse { get; set; }
    }
}
