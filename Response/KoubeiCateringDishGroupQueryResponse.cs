using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringDishGroupQueryResponse.
    /// </summary>
    public class KoubeiCateringDishGroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 项目列表
        /// </summary>
        [XmlArray("kb_dish_group_list")]
        [XmlArrayItem("kbdish_group_info")]
        public List<KbdishGroupInfo> KbDishGroupList { get; set; }
    }
}
