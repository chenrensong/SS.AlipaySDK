using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// RecruitMaterialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitMaterialInfo : AopObject
    {
        /// <summary>
        /// 素材ID。
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }
    }
}
