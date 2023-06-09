using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringDishAreaQueryResponse.
    /// </summary>
    public class KoubeiCateringDishAreaQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回餐区大模型列表
        /// </summary>
        [XmlArray("kb_dish_area_list")]
        [XmlArrayItem("kbdish_area_info")]
        public List<KbdishAreaInfo> KbDishAreaList { get; set; }
    }
}
