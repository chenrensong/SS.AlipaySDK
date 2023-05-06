using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateSceneFacegroupQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSceneFacegroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 学校人脸库ID
        /// </summary>
        [XmlElement("school_group_id")]
        public string SchoolGroupId { get; set; }
    }
}
