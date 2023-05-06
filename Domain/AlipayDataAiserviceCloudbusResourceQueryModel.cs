using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusResourceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusResourceQueryModel : AopObject
    {
        /// <summary>
        /// 按类型查找， 空默认查询所有
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
