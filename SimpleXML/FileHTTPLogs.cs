using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimpleTechnicalSupportFiles
{
    internal class FileHTTPLogs
    {
        [XmlRoot("Logs", Namespace = "http://www.http-log.simple", IsNullable = false)]
        public partial class Logs
        {
            [XmlElement("Log")]
            public List<Log> Log { get; set; }
        }

        public partial class Log
        {
            private int status_code;
            private int session;
            private long timestamp;

            [XmlAttribute("SID")]
            public string SID;

            [XmlAttribute("Date")]
            public DateTime Date;

            [XmlAttribute("Method")]
            public string Method;

            [XmlAttribute("DeviceID")]
            public string DeviceID;

            [XmlAttribute("StatusCode")]
            public string StatusCode
            {
                get
                {
                    return Convert.ToString(status_code);
                }

                set
                {
                    status_code = Convert.ToInt32(value);
                }
            }

            [XmlAttribute("Session")]
            public string Session
            {
                get
                {
                    return Convert.ToString(session);
                }

                set
                {
                    session = Convert.ToInt32(value);
                }
            }

            [XmlAttribute("Timestamp")]
            public string Timestamp
            {
                get
                {
                    return Convert.ToString(timestamp);
                }

                set
                {
                    timestamp = long.Parse(value);
                }
            }

            public User User;
            public Data Data;
            public URL URL;
        }

        public class User
        {
            [XmlAttribute("Name")]
            public string Name;

            [XmlAttribute("ID")]
            public string ID;
        }

        public class Data
        {
            [XmlAttribute("Path")]
            public string Path;

            [XmlAttribute("Request")]
            public string Request;

            [XmlAttribute("Response")]
            public string Response;

            public string GetRequest()
            {
                return string.Concat(Path, "\\", Request);
            }

            public string GetResponse()
            {
                return string.Concat(Path, "\\", Response);
            }
        }

        public class URL
        {
            [XmlAttribute("URL")]
            public string url;

            [XmlElement("Base")]
            public string Base;

            [XmlElement("Relative")]
            public string Relative;
        }
    }
}
