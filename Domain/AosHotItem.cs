using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AosHotItem Data Structure.
    /// </summary>
    [Serializable]
    public class AosHotItem : AopObject
    {
        /// <summary>
        /// 图片类型热搜
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// item的打分
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 搜索结果item的sequence用于关联搜索热搜和用户点击行为
        /// </summary>
        [XmlElement("sequence")]
        public string Sequence { get; set; }

        /// <summary>
        /// 热搜的展示title
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 热搜结果item的trace_id用于关联搜索热搜和用户行为
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
