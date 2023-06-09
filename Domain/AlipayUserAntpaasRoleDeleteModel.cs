using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayUserAntpaasRoleDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntpaasRoleDeleteModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 角色Id
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 被动建立关系的 会员来源业务平台类型。104-金融云平台，103-淘宝平台，102-保险平台
        /// </summary>
        [XmlElement("join_rel_role_biz_platform")]
        public string JoinRelRoleBizPlatform { get; set; }

        /// <summary>
        /// 主操作员ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 角色关系类型，1-保险业务，2-金融云业务
        /// </summary>
        [XmlElement("rel_biz_typ")]
        public string RelBizTyp { get; set; }
    }
}
