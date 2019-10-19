using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "bayesaverage")]
    public class BayesAverage
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}
