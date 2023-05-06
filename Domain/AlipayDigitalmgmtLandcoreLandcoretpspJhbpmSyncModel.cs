using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtLandcoreLandcoretpspJhbpmSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtLandcoreLandcoretpspJhbpmSyncModel : AopObject
    {
        /// <summary>
        /// 蚂蚁方创建流程时对应的puid
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }
    }
}
