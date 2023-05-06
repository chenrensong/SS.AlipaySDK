using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInsserviceprodItemQueryModel : AopObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
