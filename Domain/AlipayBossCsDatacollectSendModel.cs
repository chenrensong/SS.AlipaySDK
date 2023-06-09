using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayBossCsDatacollectSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossCsDatacollectSendModel : AopObject
    {
        /// <summary>
        /// 上数提交数据内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
