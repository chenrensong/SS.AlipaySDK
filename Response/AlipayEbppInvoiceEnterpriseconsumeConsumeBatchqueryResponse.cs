using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 企业查询到的员工账单列表
        /// </summary>
        [XmlArray("expense_consume_info_list")]
        [XmlArrayItem("expense_consume_info")]
        public List<ExpenseConsumeInfo> ExpenseConsumeInfoList { get; set; }
    }
}
