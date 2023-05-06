using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeProfileQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeProfileQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡包充值卡面详情模板设置
        /// </summary>
        [XmlElement("card_template_config")]
        public PayForPrivilegeCardTemplateConfig CardTemplateConfig { get; set; }
    }
}
