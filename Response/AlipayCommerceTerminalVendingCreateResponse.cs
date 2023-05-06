using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTerminalVendingCreateResponse.
    /// </summary>
    public class AlipayCommerceTerminalVendingCreateResponse : AopResponse
    {
        /// <summary>
        /// 同步订单记录初始化后返回的唯一Id,后续用于订单状态更新
        /// </summary>
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }
    }
}
