using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserAdCancelModel : AopObject
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
