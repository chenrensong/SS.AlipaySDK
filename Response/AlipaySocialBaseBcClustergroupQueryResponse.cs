using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySocialBaseBcClustergroupQueryResponse.
    /// </summary>
    public class AlipaySocialBaseBcClustergroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 社交聊天群的概要信息
        /// </summary>
        [XmlArray("group_briefs")]
        [XmlArrayItem("group_brief")]
        public List<GroupBrief> GroupBriefs { get; set; }
    }
}
