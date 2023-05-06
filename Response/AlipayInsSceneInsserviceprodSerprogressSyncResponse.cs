using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerprogressSyncResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerprogressSyncResponse : AopResponse
    {
        /// <summary>
        /// 进度明细编号(业务主键)
        /// </summary>
        [XmlElement("progress_no")]
        public string ProgressNo { get; set; }
    }
}
