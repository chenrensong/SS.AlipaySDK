using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiQualityTestShieldCaselaunchApplyResponse.
    /// </summary>
    public class KoubeiQualityTestShieldCaselaunchApplyResponse : AopResponse
    {
        /// <summary>
        /// 拓展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }
    }
}
