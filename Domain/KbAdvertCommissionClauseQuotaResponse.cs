using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// KbAdvertCommissionClauseQuotaResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertCommissionClauseQuotaResponse : AopObject
    {
        /// <summary>
        /// 分佣定额(精度2位的非负小数)
        /// </summary>
        [XmlElement("quota_amount")]
        public string QuotaAmount { get; set; }
    }
}
