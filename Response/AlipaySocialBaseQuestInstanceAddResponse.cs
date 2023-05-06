using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceAddResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstanceAddResponse : AopResponse
    {
        /// <summary>
        /// 小目标实例模型
        /// </summary>
        [XmlElement("instance")]
        public QuestInstanceDO Instance { get; set; }
    }
}
