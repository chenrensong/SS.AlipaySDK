using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenSearchBrandserviceBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchBrandserviceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 服务信息详情
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("box_exclusive_service_data")]
        public List<BoxExclusiveServiceData> Data { get; set; }
    }
}
