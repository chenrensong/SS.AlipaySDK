using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySocialBaseRelationFriendsQueryResponse.
    /// </summary>
    public class AlipaySocialBaseRelationFriendsQueryResponse : AopResponse
    {
        /// <summary>
        /// 好友列表数据
        /// </summary>
        [XmlArray("friend_list")]
        [XmlArrayItem("friend_list_v_o")]
        public List<FriendListVO> FriendList { get; set; }
    }
}
