using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniActivityGiftQueryResponse.
    /// </summary>
    public class AlipayOpenMiniActivityGiftQueryResponse : AopResponse
    {
        /// <summary>
        /// 金额(分), 仅限代金券
        /// </summary>
        [XmlElement("amount_cent")]
        public long AmountCent { get; set; }

        /// <summary>
        /// 最大抵扣金额(分)
        /// </summary>
        [XmlElement("ceiling_amount_cent")]
        public long CeilingAmountCent { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 门槛金额(分)
        /// </summary>
        [XmlElement("floor_amount_cent")]
        public long FloorAmountCent { get; set; }

        /// <summary>
        /// 领券后完整跳转链接
        /// </summary>
        [XmlElement("full_redirect_url")]
        public string FullRedirectUrl { get; set; }

        /// <summary>
        /// 小程序 id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 创建活动的商户 id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 券余量
        /// </summary>
        [XmlElement("remain_amount")]
        public long RemainAmount { get; set; }

        /// <summary>
        /// 单用户领取上限
        /// </summary>
        [XmlElement("single_user_limit")]
        public long SingleUserLimit { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// draft,创建中;init,待发布;active,已发布;pause,暂停;finished,终止
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 活动模板 id, 即小程序识别的活动 id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// 库存总量
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 折扣比例, 仅限折扣券
        /// </summary>
        [XmlElement("voucher_discount_percent")]
        public string VoucherDiscountPercent { get; set; }

        /// <summary>
        /// 领取券跳转地址
        /// </summary>
        [XmlElement("voucher_jump_url")]
        public string VoucherJumpUrl { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 小程序活动关联的券模板 id
        /// </summary>
        [XmlElement("voucher_template_id")]
        public string VoucherTemplateId { get; set; }

        /// <summary>
        /// 券类型: 代金券    FIX_VOUCHER    CASHLESS_FIX_VOUCHER    ITEM_CASHLESS_FIX_VOUCHER 折扣券    DISCOUNT_VOUCHER    CASHLESS_DISCOUNT_VOUCHER    ITEM_CASHLESS_DISCOUNT_VOUCHER 券码券    CODE_VOUCHER 特价券    ITEM_CASHLESS_SPE_VOUCHER
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
