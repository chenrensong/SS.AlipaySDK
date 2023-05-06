using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AnttechBlockchainQueryconditionQueryResponse.
    /// </summary>
    public class AnttechBlockchainQueryconditionQueryResponse : AopResponse
    {
        /// <summary>
        /// 春天来了
        /// </summary>
        [XmlElement("season")]
        public string Season { get; set; }
    }
}
