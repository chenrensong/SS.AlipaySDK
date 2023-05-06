using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileQueryResponse.
    /// </summary>
    public class AlipayInsScenePetprofilePlatformprofileQueryResponse : AopResponse
    {
        /// <summary>
        /// 宠物档案
        /// </summary>
        [XmlElement("pet_profile")]
        public PlatformPetProfile PetProfile { get; set; }
    }
}
