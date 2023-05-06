using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingVoucherBatchsendResponse.
    /// </summary>
    public class AlipayMarketingVoucherBatchsendResponse : AopResponse
    {
        /// <summary>
        /// 批量发券信息
        /// </summary>
        [XmlArray("vouchers")]
        [XmlArrayItem("open_voucher_d_t_o")]
        public List<OpenVoucherDTO> Vouchers { get; set; }
    }
}
