using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniItemBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniItemBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序商品列表
        /// </summary>
        [XmlArray("result_obj")]
        [XmlArrayItem("item_v_o")]
        public List<ItemVO> ResultObj { get; set; }
    }
}
