using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// UserCertifyPayload Data Structure.
    /// </summary>
    [Serializable]
    public class UserCertifyPayload : AopObject
    {
        /// <summary>
        /// 授权编码
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }
    }
}
