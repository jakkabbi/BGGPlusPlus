
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{

    [XmlRoot(ElementName = "items")]
    public class Items
    {
        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
        [XmlAttribute(AttributeName = "termsofuse")]
        public string Termsofuse { get; set; }
    }

}
