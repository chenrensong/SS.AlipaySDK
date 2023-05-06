using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankPaymentTradeUserclassificationCreateormodifyResponse.
    /// </summary>
    public class MybankPaymentTradeUserclassificationCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 打标结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
