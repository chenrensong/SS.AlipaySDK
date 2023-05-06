using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileModifyResponse.
    /// </summary>
    public class AlipayInsScenePetprofilePlatformprofileModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改结果
        /// </summary>
        [XmlElement("change_result")]
        public bool ChangeResult { get; set; }
    }
}
