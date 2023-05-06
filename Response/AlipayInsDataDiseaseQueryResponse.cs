using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsDataDiseaseQueryResponse.
    /// </summary>
    public class AlipayInsDataDiseaseQueryResponse : AopResponse
    {
        /// <summary>
        /// 匹配的疾病
        /// </summary>
        [XmlArray("disease_list")]
        [XmlArrayItem("disease_d_t_o")]
        public List<DiseaseDTO> DiseaseList { get; set; }
    }
}
