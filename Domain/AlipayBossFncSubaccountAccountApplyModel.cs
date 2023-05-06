using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayBossFncSubaccountAccountApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncSubaccountAccountApplyModel : AopObject
    {
        /// <summary>
        /// 子户创建申请
        /// </summary>
        [XmlElement("apply_sub_account_and_bind_order")]
        public ApplySubAccountAndBindOrder ApplySubAccountAndBindOrder { get; set; }
    }
}
