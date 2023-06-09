using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenAppSilanApigrayoneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppSilanApigrayoneQueryModel : AopObject
    {
        /// <summary>
        /// param
        /// </summary>
        [XmlElement("param_1")]
        public string Param1 { get; set; }
    }
}
