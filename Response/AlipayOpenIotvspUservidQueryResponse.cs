using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenIotvspUservidQueryResponse.
    /// </summary>
    public class AlipayOpenIotvspUservidQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回刷脸vid
        /// </summary>
        [XmlElement("vid_info_list")]
        public IotIdentityOrgUserVidInfoResponse VidInfoList { get; set; }
    }
}
