using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotProfileSnBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotProfileSnBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// sn列表
        /// </summary>
        [XmlArray("sn_list")]
        [XmlArrayItem("profile_sn_detail")]
        public List<ProfileSnDetail> SnList { get; set; }
    }
}
