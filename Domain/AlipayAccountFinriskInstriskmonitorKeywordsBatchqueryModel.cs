using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询机构关键词
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
