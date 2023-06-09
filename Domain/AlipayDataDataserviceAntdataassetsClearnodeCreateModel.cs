using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsClearnodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAntdataassetsClearnodeCreateModel : AopObject
    {
        /// <summary>
        /// ODPS表的guid
        /// </summary>
        [XmlElement("guid")]
        public string Guid { get; set; }
    }
}
