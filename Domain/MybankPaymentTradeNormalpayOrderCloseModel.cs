using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeNormalpayOrderCloseModel : AopObject
    {
        /// <summary>
        /// 网商订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
