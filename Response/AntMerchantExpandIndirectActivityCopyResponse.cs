using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectActivityCopyResponse.
    /// </summary>
    public class AntMerchantExpandIndirectActivityCopyResponse : AopResponse
    {
        /// <summary>
        /// 活动权益复制结果
        /// </summary>
        [XmlArray("copy_result")]
        [XmlArrayItem("activity_copy_result")]
        public List<ActivityCopyResult> CopyResult { get; set; }
    }
}
