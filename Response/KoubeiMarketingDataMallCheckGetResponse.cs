using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMarketingDataMallCheckGetResponse.
    /// </summary>
    public class KoubeiMarketingDataMallCheckGetResponse : AopResponse
    {
        /// <summary>
        /// 返回数据字段
        /// </summary>
        [XmlArray("data_results")]
        [XmlArrayItem("data_sec_check_result")]
        public List<DataSecCheckResult> DataResults { get; set; }
    }
}
