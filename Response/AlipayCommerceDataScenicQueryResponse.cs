using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceDataScenicQueryResponse.
    /// </summary>
    public class AlipayCommerceDataScenicQueryResponse : AopResponse
    {
        /// <summary>
        /// 景区分页信息
        /// </summary>
        [XmlElement("pagination_scenic_info")]
        public PaginationScenicInfo PaginationScenicInfo { get; set; }
    }
}
