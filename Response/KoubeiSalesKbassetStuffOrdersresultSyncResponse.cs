using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffOrdersresultSyncResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffOrdersresultSyncResponse : AopResponse
    {
        /// <summary>
        /// 物料单据反馈结果
        /// </summary>
        [XmlArray("orders_feedback_result")]
        [XmlArrayItem("access_orders_feed_back_result")]
        public List<AccessOrdersFeedBackResult> OrdersFeedbackResult { get; set; }
    }
}
