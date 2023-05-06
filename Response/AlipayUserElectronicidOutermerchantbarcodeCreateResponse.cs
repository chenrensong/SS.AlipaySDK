using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserElectronicidOutermerchantbarcodeCreateResponse.
    /// </summary>
    public class AlipayUserElectronicidOutermerchantbarcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 二维码码串
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 二维码图片链接
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }
    }
}
