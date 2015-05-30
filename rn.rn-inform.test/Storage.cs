using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace rn.rn_inform.test.Storage
{
    public interface IContainer<T>
    {
        String Name { set; get; }
        List<T> InnerStorage { set; get; }
    }


    [Serializable]
    [XmlRoot("SPF4ImportData")]
    public class RNUObj : IContainer<ProjDocBinderRevision>
    {
        protected RNUObj() { }
        private static RNUObj instance;
        public static RNUObj Instance()
        {
            if (instance == null)
            {
                instance = new RNUObj();
            }

            return instance;
        }


        [XmlIgnore]
        public String Name { set; get; }

        [XmlAttribute]
        public String Configuration = "Unknown";

        [XmlAttribute]
        public String FileVersion = "0.4.1-simplified";

        [XmlElement("ProjDocBinderRevision")]
        public List<ProjDocBinderRevision> innerStorage = new List<ProjDocBinderRevision>();

        public List<ProjDocBinderRevision> InnerStorage
        {
            set { innerStorage = value; }
            get { return innerStorage; }
        }
    }


    [Serializable]
    public class ProjDocBinderRevision : IContainer<ProjDocRevision>
    {
        [XmlAttribute]
        public string Name { set; get; }

        [XmlAttribute]
        public String Description { set; get; }

        [XmlAttribute]
        public String RNUObj { set; get; }

        [XmlAttribute]
        public String RNContract { set; get; }

        [XmlAttribute]
        public String RNProjectDiscipline { set; get; }

        [XmlAttribute]
        public String RevisionNumber { set; get; }

        [XmlAttribute(DataType = "date")]
        public DateTime SPFRevIssueDate { set; get; }

        [XmlAttribute]
        public String Owner { set; get; }

        [XmlElement("ProjDocRevision")]
        public List<ProjDocRevision> innerStorage = new List<ProjDocRevision>();

        public List<ProjDocRevision> InnerStorage
        {
            set { innerStorage = value; }
            get { return innerStorage; }
        }
    }

    [Serializable]
    public class ProjDocRevision : IContainer<File>
    {
        [XmlAttribute]
        public string Name { set; get; }

        [XmlAttribute]
        public String Description { set; get; }

        [XmlAttribute]
        public String RNDocType { set; get; }

        [XmlAttribute]
        public String RevisionNumber { set; get; }

        [XmlAttribute(DataType = "date")]
        public DateTime SPFRevIssueDate { set; get; }

        [XmlAttribute]
        public String Owner { set; get; }

        [XmlAttribute]
        public String RNAllSheetsSize { set; get; }

        [XmlElement("File")]
        public List<File> innerStorage = new List<File>();

        public List<File> InnerStorage
        {
            set { innerStorage = value; }
            get { return innerStorage; }
        }
    }

    [Serializable]
    public class File
    {
        [XmlAttribute]
        public String FileName { set; get; }
    }
}
