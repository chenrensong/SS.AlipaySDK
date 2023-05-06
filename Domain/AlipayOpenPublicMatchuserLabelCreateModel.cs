using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenPublicMatchuserLabelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMatchuserLabelCreateModel : AopObject
    {
        /// <summary>
        /// 标签 id，只支持生活号自定义标签。通过 <a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.life.label.create">alipay.open.public.life.label.create</a>(创建标签接口)创建自定义标签后获取。
        /// </summary>
        [XmlElement("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签值，由开发者自主指定，标签值类型要满足 <a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.life.label.create">alipay.open.public.life.label.create</a>(创建标签接口)中data_type参数的限定。
        /// </summary>
        [XmlElement("label_value")]
        public string LabelValue { get; set; }

        /// <summary>
        /// 支付宝用户匹配器列表，最多传入10条
        /// </summary>
        [XmlArray("matchers")]
        [XmlArrayItem("matcher")]
        public List<Matcher> Matchers { get; set; }
    }
}
