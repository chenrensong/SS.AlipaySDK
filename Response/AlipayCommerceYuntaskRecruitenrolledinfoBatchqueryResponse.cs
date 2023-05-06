using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskRecruitenrolledinfoBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskRecruitenrolledinfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 招商报名记录
        /// </summary>
        [XmlArray("enrolled_infos")]
        [XmlArrayItem("yun_task_recruit_enrolled_info")]
        public List<YunTaskRecruitEnrolledInfo> EnrolledInfos { get; set; }
    }
}
