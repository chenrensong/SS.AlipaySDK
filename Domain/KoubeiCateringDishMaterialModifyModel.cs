using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// KoubeiCateringDishMaterialModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishMaterialModifyModel : AopObject
    {
        /// <summary>
        /// 菜品加料入参
        /// </summary>
        [XmlElement("kb_dish_material_info")]
        public KbdishMaterialInfo KbDishMaterialInfo { get; set; }
    }
}
