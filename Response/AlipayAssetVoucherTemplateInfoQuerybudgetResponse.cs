using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayAssetVoucherTemplateInfoQuerybudgetResponse.
    /// </summary>
    public class AlipayAssetVoucherTemplateInfoQuerybudgetResponse : AopResponse
    {
        /// <summary>
        /// 券模板预算列表
        /// </summary>
        [XmlArray("template_list")]
        [XmlArrayItem("voucher_template_budget_d_t_o")]
        public List<VoucherTemplateBudgetDTO> TemplateList { get; set; }
    }
}
