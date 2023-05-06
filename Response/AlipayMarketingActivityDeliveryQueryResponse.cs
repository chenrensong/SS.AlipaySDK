using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingActivityDeliveryQueryResponse.
    /// </summary>
    public class AlipayMarketingActivityDeliveryQueryResponse : AopResponse
    {
        /// <summary>
        /// 投放计划基础信息。
        /// </summary>
        [XmlElement("delivery_base_info")]
        public DeliveryBaseInfo DeliveryBaseInfo { get; set; }

        /// <summary>
        /// 投放的展位编码。
        /// </summary>
        [XmlElement("delivery_booth_code")]
        public string DeliveryBoothCode { get; set; }

        /// <summary>
        /// 投放计划错误信息描述，如投放计划审核失败时为审核失败原因。
        /// </summary>
        [XmlElement("delivery_error_msg")]
        public string DeliveryErrorMsg { get; set; }

        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// [已废弃] 投放信息列表
        /// </summary>
        [XmlArray("delivery_info_list")]
        [XmlArrayItem("promo_delivery_info")]
        public List<PromoDeliveryInfo> DeliveryInfoList { get; set; }

        /// <summary>
        /// 投放计划玩法配置。 限制：投放玩法配置有且仅能配置一个。
        /// </summary>
        [XmlElement("delivery_play_config")]
        public DeliveryPlayConfig DeliveryPlayConfig { get; set; }

        /// <summary>
        /// 投放计划状态。  枚举值： ACTIVE：生效中 INACTIVE：失效状态 AUDITING：审核中 AUDIT_NO_PASS：审核不通过。
        /// </summary>
        [XmlElement("delivery_status")]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// 投放计划定向规则。
        /// </summary>
        [XmlElement("delivery_target_rule")]
        public DeliveryTargetRule DeliveryTargetRule { get; set; }
    }
}
