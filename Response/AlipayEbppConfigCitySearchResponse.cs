using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppConfigCitySearchResponse.
    /// </summary>
    public class AlipayEbppConfigCitySearchResponse : AopResponse
    {
        /// <summary>
        /// 接口主要输出参数列表: AreaInfoResult{List{ areaInfo：{province, cityList<String>}} }
        /// </summary>
        [XmlArray("area_info_result")]
        [XmlArrayItem("area_info")]
        public List<AreaInfo> AreaInfoResult { get; set; }
    }
}
