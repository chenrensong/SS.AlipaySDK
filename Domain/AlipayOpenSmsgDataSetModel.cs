using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenSmsgDataSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSmsgDataSetModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("paramone")]
        public string Paramone { get; set; }

        /// <summary>
        /// 测试参数2
        /// </summary>
        [XmlElement("paramtwo")]
        public string Paramtwo { get; set; }
    }
}
