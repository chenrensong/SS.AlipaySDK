using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceModifyResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstanceModifyResponse : AopResponse
    {
        /// <summary>
        /// 返回用户添加小目标实例
        /// </summary>
        [XmlElement("instance")]
        public QuestInstanceDO Instance { get; set; }
    }
}
