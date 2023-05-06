using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierNameMatchResponse.
    /// </summary>
    public class ZhimaCreditEpDossierNameMatchResponse : AopResponse
    {
        /// <summary>
        /// 企业简版档案信息
        /// </summary>
        [XmlArray("ep_dossier_lite_detail")]
        [XmlArrayItem("ep_dossier_lite_detail")]
        public List<EpDossierLiteDetail> EpDossierLiteDetail { get; set; }
    }
}
