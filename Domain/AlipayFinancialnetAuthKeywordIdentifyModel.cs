using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthKeywordIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthKeywordIdentifyModel : AopObject
    {
        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
