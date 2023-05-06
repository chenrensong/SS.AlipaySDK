using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRecruitEnrollQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignRecruitEnrollQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动报名基本信息。
        /// </summary>
        [XmlElement("enroll_base_info")]
        public RecruitEnrollBaseInfo EnrollBaseInfo { get; set; }

        /// <summary>
        /// 活动报名内容。
        /// </summary>
        [XmlElement("enroll_content")]
        public RecruitEnrollContent EnrollContent { get; set; }

        /// <summary>
        /// 活动报名素材。
        /// </summary>
        [XmlElement("enroll_material")]
        public RecruitEnrollMaterial EnrollMaterial { get; set; }

        /// <summary>
        /// 幂等ID。 创建报名时传入的 out_biz_no。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 定向信息。
        /// </summary>
        [XmlElement("serving_target")]
        public RecruitServingTarget ServingTarget { get; set; }
    }
}
