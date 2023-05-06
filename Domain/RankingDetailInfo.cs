using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// RankingDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RankingDetailInfo : AopObject
    {
        /// <summary>
        /// 积分值
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }
    }
}
