using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceMindvSnapshotQueryResponse.
    /// </summary>
    public class AlipayIserviceMindvSnapshotQueryResponse : AopResponse
    {
        /// <summary>
        /// 快照创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 快照唯一id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
