using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayBossFncInvoicreceiptQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoicreceiptQueryModel : AopObject
    {
        /// <summary>
        /// 对账单号
        /// </summary>
        [XmlArray("statement_bill_nos")]
        [XmlArrayItem("string")]
        public List<string> StatementBillNos { get; set; }
    }
}
