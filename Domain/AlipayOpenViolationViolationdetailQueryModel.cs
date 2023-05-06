using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenViolationViolationdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenViolationViolationdetailQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝侧生成的违规记录唯一标识
        /// </summary>
        [XmlElement("violation_record_id")]
        public string ViolationRecordId { get; set; }
    }
}
