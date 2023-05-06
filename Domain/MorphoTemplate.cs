using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// MorphoTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class MorphoTemplate : AopObject
    {
        /// <summary>
        /// 闪蝶搭建平台模板名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
