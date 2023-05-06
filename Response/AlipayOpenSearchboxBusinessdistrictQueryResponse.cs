using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenSearchboxBusinessdistrictQueryResponse.
    /// </summary>
    public class AlipayOpenSearchboxBusinessdistrictQueryResponse : AopResponse
    {
        /// <summary>
        /// 商圈信息
        /// </summary>
        [XmlArray("business_district_info_list")]
        [XmlArrayItem("business_district_info")]
        public List<BusinessDistrictInfo> BusinessDistrictInfoList { get; set; }
    }
}
