using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenSearchServiceinbrandBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchServiceinbrandBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 品牌绑定的官方账号详情
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("box_exclusive_service_open_api_infos")]
        public List<BoxExclusiveServiceOpenApiInfos> Data { get; set; }
    }
}
