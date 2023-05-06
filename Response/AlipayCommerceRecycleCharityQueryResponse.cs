using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceRecycleCharityQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleCharityQueryResponse : AopResponse
    {
        /// <summary>
        /// 公益捐赠项目列表
        /// </summary>
        [XmlArray("charity_project_list")]
        [XmlArrayItem("recycle_charity_project_d_t_o")]
        public List<RecycleCharityProjectDTO> CharityProjectList { get; set; }
    }
}
