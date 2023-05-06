using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsDataDsbImageUploadResponse.
    /// </summary>
    public class AlipayInsDataDsbImageUploadResponse : AopResponse
    {
        /// <summary>
        /// 图像文件在oss存储上的路径
        /// </summary>
        [XmlElement("image_path")]
        public string ImagePath { get; set; }
    }
}
