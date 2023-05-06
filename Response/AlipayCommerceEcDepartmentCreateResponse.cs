using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEcDepartmentCreateResponse.
    /// </summary>
    public class AlipayCommerceEcDepartmentCreateResponse : AopResponse
    {
        /// <summary>
        /// 新创建的部门id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }
    }
}
