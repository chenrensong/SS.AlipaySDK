using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitleDynamicGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTitleDynamicGetModel : AopObject
    {
        /// <summary>
        /// 抬头动态码
        /// </summary>
        [XmlElement("bar_code")]
        public string BarCode { get; set; }
    }
}
