using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayMarketingRecruitEnrollCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingRecruitEnrollCloseModel : AopObject
    {
        /// <summary>
        /// 报名ID
        /// </summary>
        [XmlElement("enroll_id")]
        public string EnrollId { get; set; }
    }
}
