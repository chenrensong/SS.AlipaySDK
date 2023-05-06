using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFincoreFunddsOrderWitnessQueryResponse.
    /// </summary>
    public class AlipayFincoreFunddsOrderWitnessQueryResponse : AopResponse
    {
        /// <summary>
        /// fundds订单号
        /// </summary>
        [XmlElement("fds_no")]
        public string FdsNo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付条目列表
        /// </summary>
        [XmlArray("pay_fund_item_list")]
        [XmlArrayItem("fds_pay_fund_item_d_t_o")]
        public List<FdsPayFundItemDTO> PayFundItemList { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
