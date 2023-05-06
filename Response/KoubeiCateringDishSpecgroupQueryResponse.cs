using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringDishSpecgroupQueryResponse.
    /// </summary>
    public class KoubeiCateringDishSpecgroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户的在接入蚂蚁开放平台的user_id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 规格标签信息
        /// </summary>
        [XmlArray("spec_group_list")]
        [XmlArrayItem("kbdish_spec_group")]
        public List<KbdishSpecGroup> SpecGroupList { get; set; }
    }
}
