using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AdMaterialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AdMaterialInfo : AopObject
    {
        /// <summary>
        /// 物料id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 物料地址
        /// </summary>
        [XmlElement("material_url")]
        public string MaterialUrl { get; set; }
    }
}
