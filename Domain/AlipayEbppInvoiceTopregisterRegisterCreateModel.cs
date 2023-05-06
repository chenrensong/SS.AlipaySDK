using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTopregisterRegisterCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTopregisterRegisterCreateModel : AopObject
    {
        /// <summary>
        /// 创建工单请求
        /// </summary>
        [XmlElement("create_request")]
        public InvoiceRegisterCreateDTO CreateRequest { get; set; }
    }
}
