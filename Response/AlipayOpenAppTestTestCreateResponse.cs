using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppTestTestCreateResponse.
    /// </summary>
    public class AlipayOpenAppTestTestCreateResponse : AopResponse
    {
        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
