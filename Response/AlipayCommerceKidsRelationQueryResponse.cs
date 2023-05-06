using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceKidsRelationQueryResponse.
    /// </summary>
    public class AlipayCommerceKidsRelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 孩子信息列表
        /// </summary>
        [XmlArray("relation_list")]
        [XmlArrayItem("user_info_v_o")]
        public List<UserInfoVO> RelationList { get; set; }
    }
}
