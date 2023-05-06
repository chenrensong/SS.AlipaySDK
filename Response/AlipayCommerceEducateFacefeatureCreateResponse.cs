using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureCreateResponse : AopResponse
    {
        /// <summary>
        /// 通用一脸通行用户入库结果
        /// </summary>
        [XmlArray("face_put_list")]
        [XmlArrayItem("standard_face_put_info")]
        public List<StandardFacePutInfo> FacePutList { get; set; }
    }
}
