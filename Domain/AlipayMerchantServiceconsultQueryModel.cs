using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayMerchantServiceconsultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantServiceconsultQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝侧服务咨询工单号
        /// </summary>
        [XmlElement("consult_event_id")]
        public string ConsultEventId { get; set; }
    }
}
