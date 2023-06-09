using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringDishDictionaryQueryResponse.
    /// </summary>
    public class KoubeiCateringDishDictionaryQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的字典数据列表
        /// </summary>
        [XmlArray("kb_dish_dictionary_list")]
        [XmlArrayItem("kbdish_dictionary")]
        public List<KbdishDictionary> KbDishDictionaryList { get; set; }
    }
}
