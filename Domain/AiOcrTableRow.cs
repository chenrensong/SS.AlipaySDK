using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AiOcrTableRow Data Structure.
    /// </summary>
    [Serializable]
    public class AiOcrTableRow : AopObject
    {
        /// <summary>
        /// table一行的内容
        /// </summary>
        [XmlArray("row")]
        [XmlArrayItem("ai_ocr_table_context")]
        public List<AiOcrTableContext> Row { get; set; }
    }
}
