using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceRegioninfoQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinDataserviceRegioninfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 区域信息列表
        /// </summary>
        [XmlArray("region_list")]
        [XmlArrayItem("agri_region_info")]
        public List<AgriRegionInfo> RegionList { get; set; }
    }
}
