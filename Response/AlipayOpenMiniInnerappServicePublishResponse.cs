using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerappServicePublishResponse.
    /// </summary>
    public class AlipayOpenMiniInnerappServicePublishResponse : AopResponse
    {
        /// <summary>
        /// 服务ID
        /// </summary>
        [XmlElement("merchandise_id")]
        public string MerchandiseId { get; set; }
    }
}
