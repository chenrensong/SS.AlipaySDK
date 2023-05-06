using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosPracticeModifyResponse.
    /// </summary>
    public class KoubeiCateringPosPracticeModifyResponse : AopResponse
    {
        /// <summary>
        /// 做法id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
