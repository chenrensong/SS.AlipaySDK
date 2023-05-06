using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEcEmployeeInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceEcEmployeeInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 员工信息
        /// </summary>
        [XmlElement("employee_info")]
        public EmployeeInfoDTO EmployeeInfo { get; set; }
    }
}
