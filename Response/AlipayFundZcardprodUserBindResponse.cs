using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundZcardprodUserBindResponse.
    /// </summary>
    public class AlipayFundZcardprodUserBindResponse : AopResponse
    {
        /// <summary>
        /// 邀请密钥
        /// </summary>
        [XmlElement("bind_token")]
        public string BindToken { get; set; }
    }
}
