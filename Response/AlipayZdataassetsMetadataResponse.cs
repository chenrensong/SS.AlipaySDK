using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayZdataassetsMetadataResponse.
    /// </summary>
    public class AlipayZdataassetsMetadataResponse : AopResponse
    {
        /// <summary>
        /// 用户标签集合
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("customer_entity")]
        public List<CustomerEntity> Result { get; set; }
    }
}
