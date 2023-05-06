using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringDishAreaSyncResponse.
    /// </summary>
    public class KoubeiCateringDishAreaSyncResponse : AopResponse
    {
        /// <summary>
        /// 餐区餐台模型
        /// </summary>
        [XmlElement("kb_dish_area")]
        public KbdishAreaInfo KbDishArea { get; set; }
    }
}
