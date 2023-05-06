using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneEcommerceInsureCheckResponse.
    /// </summary>
    public class AlipayInsSceneEcommerceInsureCheckResponse : AopResponse
    {
        /// <summary>
        /// 准入结果列表
        /// </summary>
        [XmlArray("admit_result")]
        [XmlArrayItem("insure_admit_detail_result_d_t_o")]
        public List<InsureAdmitDetailResultDTO> AdmitResult { get; set; }
    }
}
