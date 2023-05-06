using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileIdentifyResponse.
    /// </summary>
    public class AlipayInsScenePetprofilePlatformprofileIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 核身结果，true表示同一只宠物，false表示非同一只宠物。
        /// </summary>
        [XmlElement("verify_result")]
        public bool VerifyResult { get; set; }
    }
}
