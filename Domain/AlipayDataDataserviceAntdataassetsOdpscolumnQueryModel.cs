using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsOdpscolumnQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAntdataassetsOdpscolumnQueryModel : AopObject
    {
        /// <summary>
        /// ODPS表的guid
        /// </summary>
        [XmlElement("guid")]
        public string Guid { get; set; }
    }
}
