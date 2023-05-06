using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppReproCesCreateResponse.
    /// </summary>
    public class AlipayOpenAppReproCesCreateResponse : AopResponse
    {
        /// <summary>
        /// 21
        /// </summary>
        [XmlArray("resname")]
        [XmlArrayItem("gavinmed")]
        public List<Gavinmed> Resname { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("string")]
        public List<string> Result { get; set; }
    }
}
