using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 创意按条件分页查询结果
        /// </summary>
        [XmlElement("creative_list")]
        public PageCreative CreativeList { get; set; }
    }
}
