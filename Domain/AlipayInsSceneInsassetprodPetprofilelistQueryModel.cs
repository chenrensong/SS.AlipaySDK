using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayInsSceneInsassetprodPetprofilelistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInsassetprodPetprofilelistQueryModel : AopObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }
    }
}
