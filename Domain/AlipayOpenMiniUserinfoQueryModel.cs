using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenMiniUserinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniUserinfoQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("logonid")]
        public string Logonid { get; set; }
    }
}
