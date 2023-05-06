using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// FengdieActivityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieActivityCreateModel : AopObject
    {
        /// <summary>
        /// 云凤蝶站点的 id
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }
    }
}
