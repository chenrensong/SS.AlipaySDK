using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosPracticeCreateResponse.
    /// </summary>
    public class KoubeiCateringPosPracticeCreateResponse : AopResponse
    {
        /// <summary>
        /// 做法id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
