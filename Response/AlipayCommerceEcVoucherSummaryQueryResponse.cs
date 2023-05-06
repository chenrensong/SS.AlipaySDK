using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEcVoucherSummaryQueryResponse.
    /// </summary>
    public class AlipayCommerceEcVoucherSummaryQueryResponse : AopResponse
    {
        /// <summary>
        /// 发票信息列表
        /// </summary>
        [XmlArray("voucher_info_list")]
        [XmlArrayItem("ec_voucher_info")]
        public List<EcVoucherInfo> VoucherInfoList { get; set; }
    }
}
