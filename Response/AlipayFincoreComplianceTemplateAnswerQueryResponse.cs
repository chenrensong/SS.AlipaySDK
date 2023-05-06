using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateAnswerQueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceTemplateAnswerQueryResponse : AopResponse
    {
        /// <summary>
        /// 模版答题要素
        /// </summary>
        [XmlArray("answers")]
        [XmlArrayItem("template_answer_d_t_o")]
        public List<TemplateAnswerDTO> Answers { get; set; }
    }
}
