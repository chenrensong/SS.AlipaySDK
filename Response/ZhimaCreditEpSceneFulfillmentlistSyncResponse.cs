using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneFulfillmentlistSyncResponse.
    /// </summary>
    public class ZhimaCreditEpSceneFulfillmentlistSyncResponse : AopResponse
    {
        /// <summary>
        /// 履约同步结果列表
        /// </summary>
        [XmlArray("fulfillment_result_list")]
        [XmlArrayItem("fulfillment_result")]
        public List<FulfillmentResult> FulfillmentResultList { get; set; }
    }
}
