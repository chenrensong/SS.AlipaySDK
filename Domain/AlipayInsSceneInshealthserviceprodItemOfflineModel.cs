using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodItemOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInshealthserviceprodItemOfflineModel : AopObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
