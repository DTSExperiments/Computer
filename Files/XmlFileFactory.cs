using System;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;
using System.Xml.Schema;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using Extensions;
using Logging;

namespace UR_MTrack
{
    public class XmlFileFactory
    {
        public XmlFileFactory()
        {
            //List<Period> periods = new List<Period>();
            //periods = CollectPeriodData();
            //XDocument doc = CreateBasicSchemaPeriod(periods);
            //SaveXML(doc);
            ////
        }

        public string Filename
        {
            get
            {
                return "Periods-" + (new DateTimeOffset(DateTime.UtcNow)).ToString("yyyyMMdd_HHmmss");
            }
        }

        void SaveXML(XDocument docXML, string path)
        {
            if (!File.Exists(path))
            {
                try
                {
                    docXML.Save(Path.Combine(path));
                    Log.Append("XML file created successfully.", LogType.Success, false);
                }
                catch (Exception ex)
                {
                    Log.Append("Failed saving XML.", LogType.Fail, true);
                    throw new Exception("Failed saving XML", ex);
                }
            }
        }

        XElement BuildXMLHeader(ExperimentSettings expdata)
        {
            var header = new XElement("metadata",
                                     new XElement("license", "PDDL", new XAttribute("URI", "http://opendatacommons.org/licenses/pddl")),
                                     new XElement("URIs",
                                         new XElement("recording", expdata.Recording),
                                         new XElement("analysis", expdata.Analysis),
                                         new XElement("datamodel", expdata.DataModel)),
                                     new XElement("experimenter",
                                         new XElement("firstname", expdata.FirstName),
                                         new XElement("lastname", expdata.LastName),
                                         new XElement("orcid", expdata.ORCID)),
                                     new XElement("fly",
                                         new XElement("name", expdata.FlyName),
                                         new XElement("description", expdata.FlyDescription),
                                         new XElement("flybase", expdata.FlyBase)),
                                     new XElement("experiment", new XAttribute("type", "torquemeter"),
                                         new XElement("dateTime", expdata.TimeStamp.ToString("yyyy-MM-ddTHH:mm:ss")),
                                         new XElement("duration", expdata.Duration),
                                         new XElement("description", expdata.ExperimentDescription),
                                         new XElement("sample_rate", expdata.SamplingRate),
                                         new XElement("arena_type", expdata.Arena),
                                         new XElement("meter_type", expdata.DMSType)));
            return header;  
        }


        XElement BuildXMLSequence(ExperimentSettings expdata)
        {
            var seqElement = new XElement("sequence", new XAttribute("periods", expdata.PeriodCount.ToString()));
            // Dynamically create and add <period> elements based on the provided data
            foreach (var period in expdata.PeriodCollection)
            {
                XElement periodElement = new XElement("period",
                    new XAttribute("number", period.Number.ToString()), // Use the provided number
                    new XElement("type", period.Type),
                    new XElement("duration", period.Duration),
                    new XElement("outcome", period.Outcome),
                    new XElement("pattern", period.Pattern),
                    new XElement("coup_coeff", period.CoupCoeff),
                    new XElement("contingency", period.Contingency)
                );

                // Add the constructed <period> element to the root <sequence> element
                seqElement.Add(periodElement);
            }
            return seqElement;
        }

        XElement BuildXMLTimeSeries(ExperimentSettings expdata)
        {
            var tsElement = new XElement("timeseries",
                                        new XElement("CSV_descriptor",
                                            new XElement("delimiter", "tab"),
                                            new XElement("header", "0"),
                                            new XElement("nullSequence", "NaN")),

                                        new XElement("variables",
                                            new XElement("variable",
                                                new XAttribute("number", "1"),
                                                new XElement("type", "time"),
                                                new XElement("var_type", "uint16"),
                                                new XElement("unit", "ms")),

                                            new XElement("variable",
                                                new XAttribute("number", "2"),
                                                new XElement("type", "a_pos"),
                                                new XElement("var_type", "int16"),
                                                new XElement("unit", "arb_unit")),

                                            new XElement("variable",
                                                new XAttribute("number", "3"),
                                                new XElement("type", "torque"),
                                                new XElement("var_type", "int16"),
                                                new XElement("unit", "arb_unit")),

                                            new XElement("variable",
                                                new XAttribute("number", "4"),
                                                new XElement("type", "period"),
                                                new XElement("var_type", "uint8"),
                                                new XElement("unit", "number"))),
                                        new XElement("csv_data", @""));
            return tsElement;
        }

        /// <summary>
        /// Create a XML file (skeleton) and save it to the given path.
        /// </summary>
        /// <param name="path"></param>
        /// <exception cref="Exception"></exception>
        public void CreateBasicSchema(string path)
        {
            XDocument doc = new XDocument(
                new XElement("DTS_xml",
                    new XElement("metadata",
                        new XElement("license", "PDDL", new XAttribute("URI", "http://opendatacommons.org/licenses/pddl")),
                        new XElement("URIs",
                            new XElement("recording", @""),
                            new XElement("analysis", @""),
                            new XElement("datamodel", @"")
                        ),
                        new XElement("experimenter",
                            new XElement("firstname", @""),
                            new XElement("lastname", @""),
                            new XElement("orcid", @"")
                        ),
                        new XElement("fly",
                            new XElement("name", @""),
                            new XElement("description", @""),
                            new XElement("flybase", @"")
                        ),
                        new XElement("experiment", new XAttribute("type", @""),
                            new XElement("dateTime", @""),
                            new XElement("duration", @""),
                            new XElement("description", @""),
                            new XElement("sample_rate", @""),
                            new XElement("arena_type", @""),
                            new XElement("meter_type", @"")
                        )
                    ),
                    new XElement("sequence", new XAttribute("periods", @""), @""),
                    new XElement("timeseries",
                        new XElement("CSV_descriptor",
                            new XElement("delimiter", "tab"),
                            new XElement("header", "0"),
                            new XElement("nullSequence", "NaN")
                        ),
                        new XElement("variables",

                            new XElement("variable",
                                new XAttribute("number", "1"),
                                new XElement("type", "time"),
                                new XElement("var_type", "uint16"),
                                new XElement("unit", "ms")
                            ),

                            new XElement("variable",
                                new XAttribute("number", "2"),
                                new XElement("type", "a_pos"),
                                new XElement("var_type", "int16"),
                                new XElement("unit", "arb_unit")
                            ),

                            new XElement("variable",
                                new XAttribute("number", "3"),
                                new XElement("type", "torque"),
                                new XElement("var_type", "int16"),
                                new XElement("unit", "arb_unit")
                            ),

                            new XElement("variable",
                                new XAttribute("number", "4"),
                                new XElement("type", "period"),
                                new XElement("var_type", "uint8"),
                                new XElement("unit", "number")
                            )
                        ),
                        new XElement("csv_data", @"")
                )
            )
        );
            try
            {
                doc.Save(path);
                Log.Append("XML file created successfully.", LogType.Success, false);
            }
            catch (Exception ex)
            {
                Log.Append("Failed saving XML.", LogType.Fail, true);
                throw new Exception("Failed saving XML", ex);
            }
        }



        /// <summary>
        /// Create and save XML file from periods
        /// </summary>
        /// <param name="periodsData"></param>
        public void CreateBasicSchemaPeriod(IEnumerable<PeriodValues> periodsData, string path)
        {
            // Create the root <sequence> element with the "periods" attribute
            XElement root = new XElement("sequence", new XAttribute("periods", periodsData.Count()));

            // Dynamically create and add <period> elements based on the provided data
            foreach (var period in periodsData)
            {
                XElement periodElement = new XElement("period",
                    new XAttribute("number", period.Number.ToString()), // Use the provided number
                    new XElement("type", period.Type),
                    new XElement("duration", period.Duration),
                    new XElement("outcome", period.Outcome),
                    new XElement("pattern", period.Pattern),
                    new XElement("coup_coeff", period.CoupCoeff),
                    new XElement("contingency", period.Contingency)
                );

                // Add the constructed <period> element to the root <sequence> element
                root.Add(periodElement);
            }

            // Create the XDocument and add the root element
            var doc = new XDocument();
            doc.Add(root);

            try
            {
                doc.Save(path);
                Log.Append("XML file created successfully.", LogType.Success, false);
            }
            catch (Exception ex)
            {
                Log.Append("Failed saving XML.", LogType.Fail, true);
                throw new Exception("Failed saving XML", ex);
            }
        }


        public bool ValidateXML(string path)
        {
            bool valid = false;
            var schemes = new XmlSchemaSet();
            var schemaPath = Path.Combine(Properties.Settings.Default.SettingsPath, @"periods.xsd");

            // Read the schema file into a string
            var schemaContent = (new FileFactory()).OpenFile(schemaPath);

            // Use StringReader to provide a stream for XmlSchema.Read
            using (StringReader sr = new StringReader(schemaContent))
            {
                XmlSchema scheme = XmlSchema.Read(sr, (sender, args) =>
                {
                    // Handle any validation errors here, if necessary
                    Log.Append("Validation error\n" + args.Message);
                    valid = false;
                });
                // Assuming no target namespace, pass null as the first argument
                schemes.Add(scheme);
            }
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas = schemes;
            settings.ValidationEventHandler += ValidationEventHandler;

            using (XmlReader reader = XmlReader.Create(path, settings))
            {
                try
                {
                    while (reader.Read()) { }
                    valid = true;
                    Log.Append("XML file is valid.", LogType.Success);
                }
                catch (XmlException ex)
                {
                    Log.Append("XML file validation failed.", LogType.Fail, true, ex.Message);
                    Debug.WriteLine($"XML exception: {ex.Message}");
                    valid = false;
                }
            }

            return valid;
        }

        public IEnumerable<PeriodValues> ReadPeriodsFromXml(string path)
        {
            var periods = new List<PeriodValues>();
            var doc = new XmlDocument();
            if (ValidateXML(path))
            {
                doc.Load(Path.Combine(path));

                XmlNodeList periodNodes = doc.DocumentElement.SelectNodes("/sequence/period");
                foreach (XmlNode node in periodNodes)
                {
                    try
                    {
                        PeriodValues period = new PeriodValues
                        {
                            Number = int.Parse(node.Attributes["number"].Value),
                            Type = node.SelectSingleNode("type").InnerText.ToEnum<PeriodType>(),
                            Duration = int.Parse(node.SelectSingleNode("duration").InnerText),
                            Outcome = int.Parse(node.SelectSingleNode("outcome").InnerText),
                            Pattern = (PeriodPattern)int.Parse(node.SelectSingleNode("pattern").InnerText),
                            CoupCoeff = int.Parse(node.SelectSingleNode("coup_coeff").InnerText),
                            Contingency = node.SelectSingleNode("contingency").InnerText.ToEnum<PeriodContingency>()
                        };
                        periods.Add(period);
                    }
                    catch (Exception ex) { Log.Append(ex); }
                }
            }
            MessageBox.Show("Please check logfile for further information.", "Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return periods;
        }


        void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                case XmlSeverityType.Warning:
                    Log.Append(string.Format("Validation error: {0}", e.Message), LogType.Error);
                    break;
            }
        }

        #region Unused Methods

        //public XDocument CreateBasicSchemaPeriod(int numberOfPeriods)
        //{
        //    // Create the root <sequence> element with the "periods" attribute
        //    XElement root = new XElement("sequence", new XAttribute("periods", numberOfPeriods));

        //    // Dynamically create and add <period> elements to the root
        //    for (int i = 1; i <= numberOfPeriods; i++)
        //    {
        //        XElement periodElement = new XElement("period",
        //            new XAttribute("number", i.ToString()), // Make sure the "number" attribute reflects the loop iteration
        //            new XElement("type", "optomotorR"),
        //            new XElement("duration", "30"),
        //            new XElement("outcome", "0"),
        //            new XElement("pattern", "3"),
        //            new XElement("coup_coeff", "0"),
        //            new XElement("contingency", "")
        //        );

        //        // Add the constructed <period> element to the root <sequence> element
        //        root.Add(periodElement);
        //    }

        //    // Create the XDocument and add the root element
        //    XDocument periods = new XDocument();
        //    periods.Add(root);

        //    return periods;
        //}


        //public void UpdateFirstName(string xmlElement, string newValue)
        //{
        //          if (!File.Exists(FilePath))
        //          {
        //              Console.WriteLine("File does not exist.");
        //              return;
        //          }

        //          try
        //          {
        //              XDocument doc = XDocument.Load(FilePath);
        //              XElement firstNameElement = doc.Descendants(xmlElement).FirstOrDefault();

        //              if (firstNameElement != @"")
        //              {
        //                  firstNameElement.Value = newValue;
        //                  WriteXml(doc.Root); // Pass the updated root element to your existing WriteXml method
        //              }
        //              else
        //              {
        //                  Console.WriteLine("The firstname element was not found.");
        //              }
        //          }
        //          catch (Exception ex)
        //          {
        //              Console.WriteLine($"An error occurred while updating the firstname: {ex.Message}");
        //          }
        //      } 

        //      public void WriteXml(XElement newContent)
        //      {
        //          try
        //          {
        //              XDocument doc = new XDocument(newContent); // Create a new XDocument with the new content
        //              doc.Save(FilePath);
        //              Console.WriteLine("XML file saved successfully.");
        //          }
        //          catch (Exception ex)
        //          {
        //              Console.WriteLine($"An error occurred: {ex.Message}");
        //          }
        //      } 

        #endregion
    }
}




