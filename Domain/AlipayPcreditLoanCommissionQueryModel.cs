using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayPcreditLoanCommissionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanCommissionQueryModel : AopObject
    {
        /// <summary>
        /// 账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 账户类型： 1.支付宝登录号-ALIPAY_LOGON_ID 2.支付宝会员ID-ALIPAY_USER_ID
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 指定数据查询的日期，格式为：yyyyMMdd，如果用户指定则使用指定日期，否则使用系统日期
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 渠道，用于标识请求来源
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 企业ID，如居然之家、红星美凯龙等
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部请求号，代表了一次请求，作为业务幂等性控制
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
