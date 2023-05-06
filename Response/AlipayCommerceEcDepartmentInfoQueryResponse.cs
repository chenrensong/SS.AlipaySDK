using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEcDepartmentInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceEcDepartmentInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 部门信息
        /// </summary>
        [XmlElement("department_info")]
        public DepartmentInfoDTO DepartmentInfo { get; set; }
    }
}
