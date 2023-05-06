using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategoryQueryModel : AopObject
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }
    }
}
