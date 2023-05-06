using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceDataScenicMappingQueryResponse.
    /// </summary>
    public class AlipayCommerceDataScenicMappingQueryResponse : AopResponse
    {
        /// <summary>
        /// 景区审核信息查询结果
        /// </summary>
        [XmlElement("scenic_audit_response")]
        public ScenicAuditResponse ScenicAuditResponse { get; set; }
    }
}
