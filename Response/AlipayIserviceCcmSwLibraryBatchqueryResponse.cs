using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwLibraryBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCcmSwLibraryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 知识库集合
        /// </summary>
        [XmlArray("libraries")]
        [XmlArrayItem("library_info")]
        public List<LibraryInfo> Libraries { get; set; }
    }
}
