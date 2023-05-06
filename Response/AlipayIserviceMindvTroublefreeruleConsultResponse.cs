using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceMindvTroublefreeruleConsultResponse.
    /// </summary>
    public class AlipayIserviceMindvTroublefreeruleConsultResponse : AopResponse
    {
        /// <summary>
        /// 返回 true 表示未被防打扰过滤，返回false表示已被过滤
        /// </summary>
        [XmlElement("result_data")]
        public bool ResultData { get; set; }
    }
}
