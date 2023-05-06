using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthPositionAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerJobworthPositionAddModel : AopObject
    {
        /// <summary>
        /// 职位信息
        /// </summary>
        [XmlElement("jobworth_position_info")]
        public JobWorthPositionInfo JobworthPositionInfo { get; set; }
    }
}
