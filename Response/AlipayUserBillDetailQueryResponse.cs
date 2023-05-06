using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserBillDetailQueryResponse.
    /// </summary>
    public class AlipayUserBillDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 消费记录模型
        /// </summary>
        [XmlElement("consume_record")]
        public ConsumeRecord ConsumeRecord { get; set; }
    }
}
