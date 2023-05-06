using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTruspleCustomsauthinitSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceTruspleCustomsauthinitSubmitModel : AopObject
    {
        /// <summary>
        /// 组织机构代码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }
    }
}
