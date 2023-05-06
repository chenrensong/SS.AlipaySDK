using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAuthResauthCheckResponse.
    /// </summary>
    public class AlipayOpenAuthResauthCheckResponse : AopResponse
    {
        /// <summary>
        /// 是否授权，1：授权/0：未授权
        /// </summary>
        [XmlElement("auth_status")]
        public long AuthStatus { get; set; }
    }
}
