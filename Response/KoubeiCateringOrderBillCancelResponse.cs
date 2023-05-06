using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringOrderBillCancelResponse.
    /// </summary>
    public class KoubeiCateringOrderBillCancelResponse : AopResponse
    {
        /// <summary>
        /// 是否需要重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
