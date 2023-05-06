using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceEcEmployeeTitleDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEmployeeTitleDeleteModel : AopObject
    {
        /// <summary>
        /// 员工抬头列表
        /// </summary>
        [XmlArray("employee_title_list")]
        [XmlArrayItem("employee_title_d_t_o")]
        public List<EmployeeTitleDTO> EmployeeTitleList { get; set; }
    }
}
