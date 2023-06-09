using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppProductSearchResponse.
    /// </summary>
    public class AlipayEbppProductSearchResponse : AopResponse
    {
        /// <summary>
        /// 产品(学校)模型列表
        /// </summary>
        [XmlArray("exproductconfs")]
        [XmlArrayItem("exproductconf_response")]
        public List<ExproductconfResponse> Exproductconfs { get; set; }
    }
}
