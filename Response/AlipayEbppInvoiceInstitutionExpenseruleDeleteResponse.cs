using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionExpenseruleDeleteResponse.
    /// </summary>
    public class AlipayEbppInvoiceInstitutionExpenseruleDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
