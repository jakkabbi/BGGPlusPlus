using System.Xml.Serialization;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "results")]
    public class Results
    {
        [XmlElement(ElementName = "result")]
        public List<Result> Result { get; set; }
        [XmlAttribute(AttributeName = "numplayers")]
        public string Numplayers { get; set; }
    }

}
