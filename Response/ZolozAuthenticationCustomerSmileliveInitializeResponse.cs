using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerSmileliveInitializeResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerSmileliveInitializeResponse : AopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
