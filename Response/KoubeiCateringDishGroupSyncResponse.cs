using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringDishGroupSyncResponse.
    /// </summary>
    public class KoubeiCateringDishGroupSyncResponse : AopResponse
    {
        /// <summary>
        /// 组模型
        /// </summary>
        [XmlElement("kb_dish_group")]
        public KbdishGroupInfo KbDishGroup { get; set; }
    }
}
