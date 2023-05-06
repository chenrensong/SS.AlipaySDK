using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureGroupkeyQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureGroupkeyQueryResponse : AopResponse
    {
        /// <summary>
        /// 学校人脸库ID
        /// </summary>
        [XmlElement("group_key")]
        public string GroupKey { get; set; }
    }
}
