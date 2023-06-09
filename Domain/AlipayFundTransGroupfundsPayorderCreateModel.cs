using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayFundTransGroupfundsPayorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransGroupfundsPayorderCreateModel : AopObject
    {
        /// <summary>
        /// 付款活动关联的批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 付款方关联的资金单据号，团体资金批次创建后获得/资金单据查询接口获得
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 当前发起付款的用户支付宝账户ID
        /// </summary>
        [XmlElement("current_user_id")]
        public string CurrentUserId { get; set; }

        /// <summary>
        /// 扩展参数，业务扩展使用
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }
    }
}
