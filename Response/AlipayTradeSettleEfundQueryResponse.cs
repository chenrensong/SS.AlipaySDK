using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayTradeSettleEfundQueryResponse.
    /// </summary>
    public class AlipayTradeSettleEfundQueryResponse : AopResponse
    {
        /// <summary>
        /// 电商管控金额
        /// </summary>
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }
    }
}
