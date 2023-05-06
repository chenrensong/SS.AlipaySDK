using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceReceiptBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceReceiptBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 小票查询总结果
        /// </summary>
        [XmlArray("receipt_energy_infos")]
        [XmlArrayItem("receipt_energy_info_d_t_o")]
        public List<ReceiptEnergyInfoDTO> ReceiptEnergyInfos { get; set; }
    }
}
