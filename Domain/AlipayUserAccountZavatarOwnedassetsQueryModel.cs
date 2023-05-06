using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayUserAccountZavatarOwnedassetsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountZavatarOwnedassetsQueryModel : AopObject
    {
        /// <summary>
        /// 场景信息
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
