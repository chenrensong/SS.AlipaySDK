using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainBizorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMaintainBizorderQueryModel : AopObject
    {
        /// <summary>
        /// 车主平台生成的订单号。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
