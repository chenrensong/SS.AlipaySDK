using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringDishMenuSyncResponse.
    /// </summary>
    public class KoubeiCateringDishMenuSyncResponse : AopResponse
    {
        /// <summary>
        /// 口碑菜谱id
        /// </summary>
        [XmlElement("cook_id")]
        public string CookId { get; set; }
    }
}
