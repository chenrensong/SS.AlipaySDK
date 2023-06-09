using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosCooklistQueryResponse.
    /// </summary>
    public class KoubeiCateringPosCooklistQueryResponse : AopResponse
    {
        /// <summary>
        /// 菜谱列表
        /// </summary>
        [XmlArray("cook_models")]
        [XmlArrayItem("pos_dish_cook_model")]
        public List<PosDishCookModel> CookModels { get; set; }
    }
}
