using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeDebarkApplyResponse.
    /// </summary>
    public class AlipayOpenPublicLifeDebarkApplyResponse : AopResponse
    {
        /// <summary>
        /// 下架成功后返回的提示
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
