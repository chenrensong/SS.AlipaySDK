using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// CompanyDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyDetail : AopObject
    {
        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 公司对应ouCode
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }
    }
}
