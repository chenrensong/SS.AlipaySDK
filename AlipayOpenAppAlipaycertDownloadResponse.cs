using System.Xml.Serialization;

namespace SS.AlipaySDK
{
    public class AlipayOpenAppAlipaycertDownloadResponse : AopResponse
    {
        [XmlElement("alipay_cert_content")]
        public string AlipayCertContent { get; set; }
    }
}
