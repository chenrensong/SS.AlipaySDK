using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionScopeModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceInstitutionScopeModifyResponse : AopResponse
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
