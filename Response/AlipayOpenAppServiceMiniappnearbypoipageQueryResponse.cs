using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbypoipageQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceMiniappnearbypoipageQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务poi信息列表
        /// </summary>
        [XmlElement("addresses")]
        public AddressDTO Addresses { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
