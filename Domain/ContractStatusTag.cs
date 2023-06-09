using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// ContractStatusTag Data Structure.
    /// </summary>
    [Serializable]
    public class ContractStatusTag : AopObject
    {
        /// <summary>
        /// 合约标签码，在下列值中：  code - view - desc  EFFECTIVE - 守约中 - 加油,守约有助于积累信用哦  PENDING_PAY - 待支付 - 请及时返还优惠, 以免对你的信用造成影响哦  OVERDUE - 已逾期 - 请及时返还优惠, 以免对你的信用造成影响哦  PROMISED - 已守约 - 约定期内均可享受优惠哦  FINISHED - 已完成 - 服务约定已结束
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 合约标签码，在下列值中： code - view - desc EFFECTIVE - 守约中 - 加油,守约有助于积累信用哦 PENDING_PAY - 待支付 - 请及时返还优惠, 以免对你的信用造成影响哦 OVERDUE - 已逾期 - 请及时返还优惠, 以免对你的信用造成影响哦 PROMISED - 已守约 - 约定期内均可享受优惠哦 FINISHED - 已完成 - 服务约定已结束
        /// </summary>
        [XmlElement("tag_desc")]
        public string TagDesc { get; set; }

        /// <summary>
        /// 合约标签码，在下列值中： code - view - desc EFFECTIVE - 守约中 - 加油,守约有助于积累信用哦 PENDING_PAY - 待支付 - 请及时返还优惠, 以免对你的信用造成影响哦 OVERDUE - 已逾期 - 请及时返还优惠, 以免对你的信用造成影响哦 PROMISED - 已守约 - 约定期内均可享受优惠哦 FINISHED - 已完成 - 服务约定已结束
        /// </summary>
        [XmlElement("tag_view")]
        public string TagView { get; set; }
    }
}
