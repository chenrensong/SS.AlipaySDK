using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionBillBatchqueryResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionBillBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 账单列表
        /// </summary>
        [XmlArray("bill_list")]
        [XmlArrayItem("supervision_bill_info")]
        public List<SupervisionBillInfo> BillList { get; set; }

        /// <summary>
        /// 当前页面
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
