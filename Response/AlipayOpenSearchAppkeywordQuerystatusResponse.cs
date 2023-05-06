using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenSearchAppkeywordQuerystatusResponse.
    /// </summary>
    public class AlipayOpenSearchAppkeywordQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 关键词工单审核状态返回值
        /// </summary>
        [XmlArray("key_words")]
        [XmlArrayItem("key_word_info")]
        public List<KeyWordInfo> KeyWords { get; set; }
    }
}
