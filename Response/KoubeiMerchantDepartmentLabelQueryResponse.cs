using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMerchantDepartmentLabelQueryResponse.
    /// </summary>
    public class KoubeiMerchantDepartmentLabelQueryResponse : AopResponse
    {
        /// <summary>
        /// 人员组织可用的部门标签列表
        /// </summary>
        [XmlArray("department_labels")]
        [XmlArrayItem("department_label")]
        public List<DepartmentLabel> DepartmentLabels { get; set; }
    }
}
