using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwTreeBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCcmSwTreeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 类目集合
        /// </summary>
        [XmlArray("trees")]
        [XmlArrayItem("tree_info")]
        public List<TreeInfo> Trees { get; set; }
    }
}
