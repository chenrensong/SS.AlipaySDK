using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankPaymentTradeDistrictQueryResponse.
    /// </summary>
    public class MybankPaymentTradeDistrictQueryResponse : AopResponse
    {
        /// <summary>
        /// District列表
        /// </summary>
        [XmlArray("district_details")]
        [XmlArrayItem("district")]
        public List<District> DistrictDetails { get; set; }
    }
}
