using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeProfileSetResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeProfileSetResponse : AopResponse
    {
        /// <summary>
        /// 卡包充值卡面模板设置
        /// </summary>
        [XmlElement("card_template_config")]
        public PayForPrivilegeCardTemplateConfig CardTemplateConfig { get; set; }
    }
}
