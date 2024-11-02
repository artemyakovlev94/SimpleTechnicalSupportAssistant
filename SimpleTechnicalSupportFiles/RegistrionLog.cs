using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimpleTechnicalSupportFiles.FileHTTPLogs;
using System.Xml.Serialization;

namespace SimpleTechnicalSupportFiles
{
    public class RegistrionLog
    {
        [XmlRoot("Log", Namespace = "http://www.registration-log.simple", IsNullable = false)]
        public partial class Log
        {
            [XmlAttribute("Date")]
            public DateTime Date;

            [XmlAttribute("DateServer")]
            public DateTime DateServer;

            [XmlAttribute("Level")]
            public string Level;

            [XmlElement("Event")]
            public LogEvent Event;

            [XmlElement("Connect")]
            public LogConnect Connect;

            [XmlElement("Metadata")]
            public LogMetadata Metadata;

            [XmlElement("Transaction")]
            public LogTransaction Transaction;

            [XmlElement("DataSeparation")]
            public LogDataSeparation DataSeparation;

            [XmlElement("Data")]
            public LogData Data;
        }

        public class LogEvent
        {
            [XmlElement("Name")]
            public string Name;

            [XmlElement("View")]
            public string View;
        }

        public class LogConnect
        {
            [XmlElement("Computer")]
            public string Computer;

            [XmlElement("Server")]
            public string Server;

            [XmlElement("Session")]
            public int Session;

            [XmlElement("Connection")]
            public int Connection;

            [XmlElement("Port")]
            public LogConnectPort Port;

            [XmlElement("User")]
            public LogConnectUser User;

            [XmlElement("App")]
            public LogConnectApp App;
        }

        public class LogConnectPort
        {
            [XmlAttribute("Main")]
            public string Main;

            [XmlAttribute("Additional")]
            public string Additional;
        }

        public class LogConnectUser
        {
            [XmlAttribute("ID")]
            public string ID;

            [XmlAttribute("Name")]
            public string Name;
        }

        public class LogConnectApp
        {
            [XmlElement("Name")]
            public string Name;

            [XmlElement("View")]
            public string View;
        }

        public class LogMetadata
        {
            [XmlElement("Name")]
            public string Name;

            [XmlElement("View")]
            public string View;
        }

        public class LogTransaction
        {
            [XmlElement("Name")]
            public string Name;

            [XmlElement("Status")]
            public string Status;
        }

        public class LogDataSeparation
        {
            [XmlElement("Name")]
            public string Name;

            [XmlElement("View")]
            public string View;
        }
        
        public class LogData
        {
            [XmlElement("Data")]
            public string Data;

            [XmlElement("Comment")]
            public string Comment;
        }
    }
}
