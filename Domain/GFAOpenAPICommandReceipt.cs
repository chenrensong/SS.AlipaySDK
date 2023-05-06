using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// GFAOpenAPICommandReceipt Data Structure.
    /// </summary>
    [Serializable]
    public class GFAOpenAPICommandReceipt : AopObject
    {
        /// <summary>
        /// 回执扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 回执状态
        /// </summary>
        [XmlElement("receipt_status")]
        public string ReceiptStatus { get; set; }
    }
}
