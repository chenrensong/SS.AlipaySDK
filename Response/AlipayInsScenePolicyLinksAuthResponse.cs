using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsScenePolicyLinksAuthResponse.
    /// </summary>
    public class AlipayInsScenePolicyLinksAuthResponse : AopResponse
    {
        /// <summary>
        /// 保单链接列表
        /// </summary>
        [XmlArray("policy_links")]
        [XmlArrayItem("ins_policy_link_d_t_o")]
        public List<InsPolicyLinkDTO> PolicyLinks { get; set; }
    }
}
