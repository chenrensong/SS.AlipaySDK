using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandAutomatApplyModifyResponse.
    /// </summary>
    public class AntMerchantExpandAutomatApplyModifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝设备ID
        /// </summary>
        [XmlElement("alipay_terminal_id")]
        public string AlipayTerminalId { get; set; }
    }
}
