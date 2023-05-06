using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeUnionbankQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeUnionbankQueryModel : AopObject
    {
        /// <summary>
        /// 银联编号
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }
    }
}
