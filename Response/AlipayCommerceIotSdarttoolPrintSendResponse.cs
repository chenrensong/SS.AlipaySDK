using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolPrintSendResponse.
    /// </summary>
    public class AlipayCommerceIotSdarttoolPrintSendResponse : AopResponse
    {
        /// <summary>
        /// 打印任务编号
        /// </summary>
        [XmlElement("print_no")]
        public string PrintNo { get; set; }
    }
}
