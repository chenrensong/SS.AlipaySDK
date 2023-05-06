using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayMerchantQipanCrowduserDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanCrowduserDeleteModel : AopObject
    {
        /// <summary>
        /// 支付宝人群code
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 人群包中需剔除的用户列表 单次上传用户数上限为1000，若用户量过大可分批上传
        /// </summary>
        [XmlArray("user_list")]
        [XmlArrayItem("qipan_merchant_crowd_user")]
        public List<QipanMerchantCrowdUser> UserList { get; set; }
    }
}
