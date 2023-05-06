using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceOperationIsvQrcodeUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationIsvQrcodeUnbindModel : AopObject
    {
        /// <summary>
        /// 微信公众号二维码码值
        /// </summary>
        [XmlElement("qrcode_url")]
        public string QrcodeUrl { get; set; }
    }
}
