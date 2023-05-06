using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// InvoiceOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceOrderInfo : AopObject
    {
        /// <summary>
        /// 商品CODE
        /// </summary>
        [XmlElement("article_code")]
        public string ArticleCode { get; set; }

        /// <summary>
        /// 商品原价，单位元，最多2位小数
        /// </summary>
        [XmlElement("article_fee")]
        public long ArticleFee { get; set; }

        /// <summary>
        /// 服务市场商品ID
        /// </summary>
        [XmlElement("article_id")]
        public string ArticleId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("article_name")]
        public string ArticleName { get; set; }

        /// <summary>
        /// 订购时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("buy_date")]
        public string BuyDate { get; set; }

        /// <summary>
        /// 服务生效截止时间，格式yyyy-MM-dd HH:mm:ss. 新订购可空。
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [XmlElement("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 实付总金额，单位元，最多2位小数
        /// </summary>
        [XmlElement("fact_total_fee")]
        public long FactTotalFee { get; set; }

        /// <summary>
        /// 税号可开发票类型，列表类型。 可选值： 增值税电子普通发票：PLAIN, 增值税专用发票：SPECIAL， 增值税普通发票：PLAIN_INVOICE，增值税普通发票(卷式)：PAPER_INVOICE
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 商品规格CODE
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品规格ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品规格名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 服务市场订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订购类型，可选值： 新订购：new 续订：renew
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 税控服务商key，服务商入驻中台后生成
        /// </summary>
        [XmlElement("provider_key")]
        public string ProviderKey { get; set; }

        /// <summary>
        /// 服务生效起始时间，格式yyyy-MM-dd HH:mm:ss. 新订购可空。
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 产品类型，产品码由中台定义。 对应支付宝开票系统中的 productCode, 默认为DOCK_TAX_OPEN 税控托管产品
        /// </summary>
        [XmlElement("tax_feature")]
        public string TaxFeature { get; set; }
    }
}
