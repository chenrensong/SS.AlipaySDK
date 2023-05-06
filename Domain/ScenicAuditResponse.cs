using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// ScenicAuditResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ScenicAuditResponse : AopObject
    {
        /// <summary>
        /// 景区审核信息查询结果
        /// </summary>
        [XmlArray("scenic_audit_info")]
        [XmlArrayItem("scenic_audit_info")]
        public List<ScenicAuditInfo> ScenicAuditInfo { get; set; }
    }
}
