﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TestReadHTTPLogs.Classes
{
    public class SchemeXML
    {
        public class FileHTTPLogs
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

        public class FileIssue
        {
            [XmlRoot("Issue", Namespace = "http://www.exchange-support.simple", IsNullable = false)]
            public partial class Issue
            {
                [XmlElement("Environment")]
                public Environment Environment { get; set; }

                [XmlElement("MobileApp")]
                public MobileApp MobileApp { get; set; }

                [XmlElement("HTTPLogs")]
                public HTTPLogs HTTPLogs { get; set; }

                [XmlElement("LogFiles")]
                public LogFiles LogFiles { get; set; }

                [XmlElement("Attachments")]
                public Attachments Attachments { get; set; }

                [XmlElement("Message")]
                public string Message { get; set; }
            }


            public class Environment
            {
                [XmlElement("Platform")]
                public EnvironmentPlatform Platform { get; set; }

                [XmlElement("Configuration")]
                public EnvironmentConfiguration Configuration { get; set; }

                [XmlElement("ExtensionSimple")]
                public EnvironmentExtensionSimple ExtensionSimple { get; set; }

                [XmlElement("Client")]
                public EnvironmentClient Client { get; set; }

                [XmlElement("Computer")]
                public EnvironmentComputer Computer { get; set; }
            }

            public class EnvironmentPlatform
            {
                [XmlAttribute("Version")]
                public string Version;

                [XmlAttribute("Type")]
                public string Type;
            }

            public class EnvironmentConfiguration
            {
                [XmlAttribute("Name")]
                public string Name;

                [XmlAttribute("Synonym")]
                public string Synonym;

                [XmlAttribute("Edition")]
                public string Edition;

                [XmlAttribute("Version")]
                public string Version;

                [XmlAttribute("SupportID")]
                public string SupportID;

                [XmlElement("CompatibilityMode")]
                public string CompatibilityMode;

                [XmlElement("VersionSSL")]
                public string VersionSSL;

                [XmlElement("LanguageCode")]
                public string LanguageCode;

                [XmlElement("IsFileDB")]
                public bool IsFileDB;

                [XmlElement("IDFileDB")]
                public string IDFileDB;

                [XmlElement("IsBasicVersion")]
                public bool IsBasicVersion;

                [XmlElement("Published")]
                public bool Published;

                [XmlElement("Subsystems")]
                public EnvironmentConfigurationSubsystems Subsystems;

                [XmlElement("SeparationData")]
                public EnvironmentConfigurationSeparationData SeparationData;

                [XmlElement("DIB")]
                public EnvironmentConfigurationDIB DIB;
            }

            public class EnvironmentConfigurationSubsystems
            {
                [XmlElement("Subsystem")]
                public List<EnvironmentConfigurationSubsystem> Subsystem;
            }

            public class EnvironmentConfigurationSubsystem
            {
                [XmlAttribute("Name")]
                public string Name;

                [XmlAttribute("SupportID")]
                public string SupportID;

                [XmlAttribute("Version")]
                public string Version;

                [XmlAttribute("IsConfiguration")]
                public bool IsConfiguration;
            }

            public class EnvironmentConfigurationSeparationData
            {
                [XmlAttribute("Available")]
                public bool Available;

                [XmlAttribute("Enabled")]
                public bool Enabled;
            }

            public class EnvironmentConfigurationDIB
            {
                [XmlAttribute("IsNodeDIB")]
                public bool IsNodeDIB;

                [XmlAttribute("IsNodeDIBWithFilter")]
                public bool IsNodeDIBWithFilter;

                [XmlAttribute("AnUpdateIsRequired")]
                public bool AnUpdateIsRequired;
            }

            public class EnvironmentExtensionSimple
            {
                [XmlAttribute("Version")]
                public string Version;

                [XmlElement("ReplaceBarcodeFlow")]
                public bool ReplaceBarcodeFlow;

                [XmlElement("ExchangeOption")]
                public string ExchangeOption;

                [XmlElement("HTTPLoggingEnabled")]
                public bool HTTPLoggingEnabled;

                [XmlElement("InstallingPreviewVersion")]
                public bool InstallingPreviewVersion;

                [XmlElement("RegisterChangesAfterUploadingDocument")]
                public bool RegisterChangesAfterUploadingDocument;

                [XmlElement("Published")]
                public bool Published;
            }

            public class EnvironmentClient
            {
                [XmlElement("IsWindowsClient")]
                public bool IsWindowsClient;

                [XmlElement("IsWindowsServer")]
                public bool IsWindowsServer;

                [XmlElement("IsLinuxClient")]
                public bool IsLinuxClient;

                [XmlElement("IsLinuxServer")]
                public bool IsLinuxServer;

                [XmlElement("IsMacOSClient")]
                public bool IsMacOSClient;

                [XmlElement("IsWebClient")]
                public bool IsWebClient;

                [XmlElement("IsMobileClient")]
                public bool IsMobileClient;

                [XmlElement("IsOfflineWorkplace")]
                public bool IsOfflineWorkplace;

                [XmlElement("IsDebuggingMode")]
                public bool IsDebuggingMode;

                [XmlElement("ConnectedViaWebServer")]
                public bool ConnectedViaWebServer;
            }

            public class EnvironmentComputer
            {
                [XmlElement("AvailableRAM")]
                public decimal AvailableRAM;

                [XmlElement("CPU")]
                public string CPU;

                [XmlElement("OSVersion")]
                public string OS;
            }

            public class MobileApp
            {
                [XmlElement("Version")]
                public string Version;

                [XmlElement("Configuration")]
                public string Configuration;

                [XmlElement("ConfigurationVersion")]
                public string ConfigurationVersion;
            }

            public class HTTPLogs
            {
                public FileHTTPLogs.Logs Logs;
            }

            public class LogFiles
            {
                [XmlAttribute("Path")]
                public string Path;

                [XmlElement("LogFile")]
                public List<File> files;
            }

            public class File
            {
                [XmlAttribute("Order")]
                public string Order;

                [XmlAttribute("Path")]
                public string Path;
            }

            public class Attachments
            {
                [XmlAttribute("Path")]
                public string Path;

                [XmlElement("Attachment")]
                public List<Attachment> attachments;
            }

            public class Attachment
            {
                [XmlElement("Name")]
                public string Name;

                [XmlElement("View")]
                public string View;

                [XmlElement("Description")]
                public string Description;

                [XmlElement("File")]
                public File file;
            }
        }
    }
}
