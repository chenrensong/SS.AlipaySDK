using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEcEmployeeInfoModifyResponse.
    /// </summary>
    public class AlipayCommerceEcEmployeeInfoModifyResponse : AopResponse
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }
    }
}
