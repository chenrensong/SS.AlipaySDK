using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniMessageTemplateBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniMessageTemplateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小，规定最大分页大小为10
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 消息子板查询列表
        /// </summary>
        [XmlArray("template_list")]
        [XmlArrayItem("merchant_msg_template_v_o")]
        public List<MerchantMsgTemplateVO> TemplateList { get; set; }

        /// <summary>
        /// 查询结果总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
