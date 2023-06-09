using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerEnrollcertifyQueryResponse.
    /// </summary>
    public class ZolozIdentificationCustomerEnrollcertifyQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否为攻击
        /// </summary>
        [XmlElement("attack")]
        public bool Attack { get; set; }

        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 图片字节数组进行Base64编码后的字符串
        /// </summary>
        [XmlElement("img_str")]
        public string ImgStr { get; set; }
    }
}
