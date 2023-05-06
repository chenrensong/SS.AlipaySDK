using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandAutomatApplyUploadResponse.
    /// </summary>
    public class AntMerchantExpandAutomatApplyUploadResponse : AopResponse
    {
        /// <summary>
        /// 支付宝设备ID
        /// </summary>
        [XmlElement("alipay_terminal_id")]
        public string AlipayTerminalId { get; set; }
    }
}
