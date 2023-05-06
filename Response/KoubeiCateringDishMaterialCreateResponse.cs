using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringDishMaterialCreateResponse.
    /// </summary>
    public class KoubeiCateringDishMaterialCreateResponse : AopResponse
    {
        /// <summary>
        /// 菜品加料通用模型返回
        /// </summary>
        [XmlElement("kb_dish_material_info")]
        public KbdishMaterialInfo KbDishMaterialInfo { get; set; }
    }
}
