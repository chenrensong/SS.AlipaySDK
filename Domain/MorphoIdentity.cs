using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// MorphoIdentity Data Structure.
    /// </summary>
    [Serializable]
    public class MorphoIdentity : AopObject
    {
        /// <summary>
        /// 闪蝶侧用户身份唯一标识
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }
    }
}
