using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthTemplatetextQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMobileauthTemplatetextQueryModel : AopObject
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [XmlElement("request")]
        public string Request { get; set; }
    }
}
