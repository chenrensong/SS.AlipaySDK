using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayUserCertifyIdentifyFileQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyIdentifyFileQueryModel : AopObject
    {
        /// <summary>
        /// 文件的地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
