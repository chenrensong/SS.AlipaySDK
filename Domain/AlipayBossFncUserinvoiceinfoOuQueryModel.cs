using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoOuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncUserinvoiceinfoOuQueryModel : AopObject
    {
        /// <summary>
        /// 机构代码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
