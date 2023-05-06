using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayEbppCommunityPubkeyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityPubkeyQueryModel : AopObject
    {
        /// <summary>
        /// ISV短名(创建ISV时生成)
        /// </summary>
        [XmlElement("isv_short_name")]
        public string IsvShortName { get; set; }
    }
}
