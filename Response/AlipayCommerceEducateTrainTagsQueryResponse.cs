using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateTrainTagsQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTrainTagsQueryResponse : AopResponse
    {
        /// <summary>
        /// 标签信息列表
        /// </summary>
        [XmlArray("tag_infos")]
        [XmlArrayItem("tag_info_v_o")]
        public List<TagInfoVO> TagInfos { get; set; }
    }
}
