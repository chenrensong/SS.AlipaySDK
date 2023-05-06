using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayBossProdMyTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdMyTestQueryModel : AopObject
    {
        /// <summary>
        /// 区.
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }
    }
}
