using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceUserlevelZrankGetResponse.
    /// </summary>
    public class AlipayDataDataserviceUserlevelZrankGetResponse : AopResponse
    {
        /// <summary>
        /// 活跃高价值用户返回
        /// </summary>
        [XmlElement("result")]
        public AlipayHighValueCustomerResult Result { get; set; }
    }
}
