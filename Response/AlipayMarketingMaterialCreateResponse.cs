using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingMaterialCreateResponse.
    /// </summary>
    public class AlipayMarketingMaterialCreateResponse : AopResponse
    {
        /// <summary>
        /// 素材id
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }
    }
}
