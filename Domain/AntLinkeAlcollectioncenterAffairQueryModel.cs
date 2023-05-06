using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AntLinkeAlcollectioncenterAffairQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntLinkeAlcollectioncenterAffairQueryModel : AopObject
    {
        /// <summary>
        /// 案件id
        /// </summary>
        [XmlElement("affair_id")]
        public string AffairId { get; set; }
    }
}
