using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataIotdataUserBusinessQueryResponse.
    /// </summary>
    public class AlipayDataIotdataUserBusinessQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户管理的业务列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("user_business")]
        public List<UserBusiness> Data { get; set; }
    }
}
