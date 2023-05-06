using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// MPromoConstraint Data Structure.
    /// </summary>
    [Serializable]
    public class MPromoConstraint : AopObject
    {
        /// <summary>
        /// 人群类型，仅当need_crowd_flag=true时生效，支持枚举取值: 商户门店会员：MERCHANT_SHOP_MEMBER
        /// </summary>
        [XmlElement("crowd_type")]
        public string CrowdType { get; set; }

        /// <summary>
        /// 人群对应的值，如crowd_type='MERCHANT_SHOP_MEMBER'时，如需设置会员等级人群类型,该值需要设置,注意:设置等级人群时,适用门店只能绑定同一个会员模板;
        /// </summary>
        [XmlArray("member_levels")]
        [XmlArrayItem("m_member_level")]
        public List<MMemberLevel> MemberLevels { get; set; }

        /// <summary>
        /// 活动是否设置人群信息标识
        /// </summary>
        [XmlElement("need_crowd_flag")]
        public bool NeedCrowdFlag { get; set; }

        /// <summary>
        /// 描述用户在某个周期内限制参与的次数；目前仅支持维度天维度：D
        /// </summary>
        [XmlElement("sub_dimension")]
        public string SubDimension { get; set; }

        /// <summary>
        /// 描述用户在指定周期(sub_dimension)维度内,可参与的次数;取值范围1~99,-1为不限制
        /// </summary>
        [XmlElement("sub_win_count")]
        public string SubWinCount { get; set; }

        /// <summary>
        /// 活动适用的门店集合;最大支持10000个非重复门店Id
        /// </summary>
        [XmlArray("suit_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> SuitShopIds { get; set; }

        /// <summary>
        /// 用户在整个活动期间参与的总次数;取值范围1~99,取值-1为不限制
        /// </summary>
        [XmlElement("total_win_count")]
        public string TotalWinCount { get; set; }
    }
}
