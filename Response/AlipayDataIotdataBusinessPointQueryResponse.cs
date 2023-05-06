using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataIotdataBusinessPointQueryResponse.
    /// </summary>
    public class AlipayDataIotdataBusinessPointQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务点位信息列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("business_point")]
        public List<BusinessPoint> Data { get; set; }
    }
}
