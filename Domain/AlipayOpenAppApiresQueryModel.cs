using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenAppApiresQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppApiresQueryModel : AopObject
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
