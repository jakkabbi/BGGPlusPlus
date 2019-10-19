using System.Xml.Serialization;

namespace BGGPlusPlus.Model.BGGModels
{
    [XmlRoot(ElementName = "ratings")]
    public class Ratings
    {
        [XmlElement(ElementName = "usersrated")]
        public UsersRated Usersrated { get; set; }
        [XmlElement(ElementName = "average")]
        public Average Average { get; set; }
        [XmlElement(ElementName = "bayesaverage")]
        public BayesAverage Bayesaverage { get; set; }
        [XmlElement(ElementName = "ranks")]
        public Ranks Ranks { get; set; }
        [XmlElement(ElementName = "stddev")]
        public StdDev Stddev { get; set; }
        [XmlElement(ElementName = "median")]
        public Median Median { get; set; }
        [XmlElement(ElementName = "owned")]
        public Owned Owned { get; set; }
        [XmlElement(ElementName = "trading")]
        public Trading Trading { get; set; }
        [XmlElement(ElementName = "wanting")]
        public Wanting Wanting { get; set; }
        [XmlElement(ElementName = "wishing")]
        public Wishing Wishing { get; set; }
        [XmlElement(ElementName = "numcomments")]
        public NumComments Numcomments { get; set; }
        [XmlElement(ElementName = "numweights")]
        public NumWeights Numweights { get; set; }
        [XmlElement(ElementName = "averageweight")]
        public AverageWeight Averageweight { get; set; }
    }

}
