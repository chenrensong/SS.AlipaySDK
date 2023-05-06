using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayDataDataserviceBillDownloadurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceBillDownloadurlQueryModel : AopObject
    {
        /// <summary>
        /// 账单时间：  * 日账单格式为yyyy-MM-dd，最早可下载2016年1月1日开始的日账单。不支持下载当日账单，只能下载前一日24点前的账单数据（T+1），当日数据一般于次日 9 点前生成，特殊情况可能延迟。  * 月账单格式为yyyy-MM，最早可下载2016年1月开始的月账单。不支持下载当月账单，只能下载上一月账单数据，当月账单一般在次月 3 日生成，特殊情况可能延迟。
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单类型，商户通过接口或商户经开放平台授权后其所属服务商通过接口可以获取以下账单类型，支持： trade：商户基于支付宝交易收单的业务账单； signcustomer：基于商户支付宝余额收入及支出等资金变动的账务账单； merchant_act：营销活动账单，包含营销活动的发放，核销记录 trade_zft_merchant：直付通二级商户查询交易的业务账单； zft_acc：直付通平台商查询二级商户流水使用，返回所有二级商户流水。
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 二级商户smid，这个参数只在bill_type是trade_zft_merchant时才能使用
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
