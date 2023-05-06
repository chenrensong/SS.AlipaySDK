using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// IotIdentityOrgUserSaveApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class IotIdentityOrgUserSaveApiResponse : AopObject
    {
        /// <summary>
        /// 人脸id
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }
    }
}
