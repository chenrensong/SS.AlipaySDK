using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntLinkeAlcollectioncenterCreateResponse.
    /// </summary>
    public class AntLinkeAlcollectioncenterCreateResponse : AopResponse
    {
        /// <summary>
        /// 案件id
        /// </summary>
        [XmlElement("affair_id")]
        public string AffairId { get; set; }
    }
}
