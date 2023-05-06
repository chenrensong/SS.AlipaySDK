using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntfortuneContentCommunityTopicListQueryResponse.
    /// </summary>
    public class AntfortuneContentCommunityTopicListQueryResponse : AopResponse
    {
        /// <summary>
        /// 话题VO列表
        /// </summary>
        [XmlArray("topic_list")]
        [XmlArrayItem("topic_item_vo")]
        public List<TopicItemVo> TopicList { get; set; }
    }
}
