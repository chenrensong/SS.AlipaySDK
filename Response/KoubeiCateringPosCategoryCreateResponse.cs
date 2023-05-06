using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosCategoryCreateResponse.
    /// </summary>
    public class KoubeiCateringPosCategoryCreateResponse : AopResponse
    {
        /// <summary>
        /// 新建菜类ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }
    }
}
