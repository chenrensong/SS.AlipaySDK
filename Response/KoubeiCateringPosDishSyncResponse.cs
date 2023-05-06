using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosDishSyncResponse.
    /// </summary>
    public class KoubeiCateringPosDishSyncResponse : AopResponse
    {
        /// <summary>
        /// 菜品的ID
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }
    }
}
