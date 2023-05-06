using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserMaterialQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserMaterialQueryModel : AopObject
    {
        /// <summary>
        /// 物料id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
