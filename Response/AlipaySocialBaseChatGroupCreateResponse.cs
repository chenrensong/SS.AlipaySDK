using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGroupCreateResponse.
    /// </summary>
    public class AlipaySocialBaseChatGroupCreateResponse : AopResponse
    {
        /// <summary>
        /// 群信息
        /// </summary>
        [XmlElement("group_info")]
        public GroupInfo GroupInfo { get; set; }

        /// <summary>
        /// 群成员信息列表
        /// </summary>
        [XmlArray("member_infos")]
        [XmlArrayItem("member_info")]
        public List<MemberInfo> MemberInfos { get; set; }
    }
}
