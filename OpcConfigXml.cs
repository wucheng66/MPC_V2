using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OpcHelper
{
    public class OcpConfigXml
    {
        private OpcConfig _config;
        public OpcConfig Config { get { return _config; } }
        public void LoadFromXmlFile(string fileName)
        {
            _config = OpcConfig.FromXmlFile(fileName);
        }
        public void SaveToXmlFile(string fileName)
        {
            _config.ToXmlFile(fileName);
        }

    }


    public class OpcConfig
    {
        public OpcConfig()
        {
            Servers = new List<OpcCfgServer>();
        }
        public List<OpcCfgServer> Servers;

        public string[] ServerNames
        {
            get
            {
                string[] names = new string[Servers.Count];
                for (int i = 0; i < Servers.Count; i++)
                    names[i] = Servers[i].Name;
                return names;
            }
        }

        public int CurrentServerIndex = 0;
        public OpcCfgServer CurrentServer { get { return Servers[CurrentServerIndex]; } }
        public override string ToString()
        {
            XmlSerializer serializer = new XmlSerializer(this.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, this);

            return writer.ToString();
        }

        public static OpcConfig FromString(string str)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(OpcConfig));

            return (OpcConfig)serializer.Deserialize(new StringReader(str));
        }

        public void ToXmlFile(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(this.GetType());
            StreamWriter file = new StreamWriter(fileName);
            serializer.Serialize(file, this);
            file.Close();
        }

        public static OpcConfig FromXmlFile(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(OpcConfig));
            StreamReader file = new StreamReader(fileName);

            var config = (OpcConfig)serializer.Deserialize(file);
            file.Close();
            return config;
        }

    }

    public class OpcCfgServer
    {
        public OpcCfgServer()
        {
            Groups = new List<OpcCfgGroup>();
        }
        [XmlAttribute]
        public string Name;
        public int CurrentGroupIndex = -1;
        public OpcCfgGroup CurrentGroup
        {
            get
            {
                if (CurrentGroupIndex >= 0)
                    return Groups[CurrentGroupIndex];
                else
                    return null;
            }
        }
        public List<OpcCfgGroup> Groups;

        public string[] GroupNames
        {
            get
            {
                string[] names = new string[Groups.Count];
                for (int i = 0; i < Groups.Count; i++)
                    names[i] = Groups[i].Name;
                return names;
            }
        }
    }
    public class OpcCfgGroup
    {
        public OpcCfgGroup()
        {
            Items = new List<string>();
        }
        [XmlAttribute]
        public string Name;
        public List<string> Items;
    }
}
