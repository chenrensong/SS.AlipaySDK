using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// MsgApplyKeyword Data Structure.
    /// </summary>
    [Serializable]
    public class MsgApplyKeyword : AopObject
    {
        /// <summary>
        /// 模板关键字名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
