using Extensions;
using Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace UR_MTrack
{
    public class XmlFileFactory : IDisposable
    {
        ExperimentSettings _settings;
        string _path;

        public XmlFileFactory() { }
        public XmlFileFactory(ExperimentSettings settings)
        {
            _settings = settings;
            _path=_settings.Filepath = GetFileName(_settings.Datapath, _settings.FlyName);
        }


        public XDocument BuildMeasFile()
        {
            if (_settings == null) { Log.Append("Experiment Settings Not Set", LogType.Fail, true); }
            try
            {
                var header = BuildXMLHeader();
                var sequence = BuildXMLSequence();
                var timeSeries = BuildXMLTimeSeries();

                var doc = new XDocument();
                doc.Add(header);
                doc.Root.Add(sequence);
                doc.Root.Add(timeSeries);
                return doc;
            }
            catch (Exception ex) { Log.Append(ex); }
            return new XDocument();
        }


        public void AppendTimeseriesValues(IEnumerable<string> lines)
        {
            new XElement("csv_data", @""));

            try
            {
                XDocument doc = XDocument.Load(_path);
                XElement element = doc.Descendants(xmlElement).FirstOrDefault();

                if (!element.Equals(@""))
                {
                    element.Value = newValue;
                    doc.Save(path);
                }
                else
                {
                    Log.Append(string.Format("XElement \"{0}\" not found.", xmlElement));
                }
            }
            catch (Exception ex)
            {
                Log.Append(string.Format("An error occurred while changing value for XElement \"{0}\"\nStacktrace:\n{1}", xmlElement, ex.StackTrace));
            }
        }

        public void ChangeXMLValue(string path, string xmlElement, string newValue)
        {
            if (!File.Exists(path)) { Log.Append(string.Format("Unable to change Value for \"{0}\"\nFile {1} does not exist.", xmlElement, path)); return; }

            try
            {
                XDocument doc = XDocument.Load(path);
                XElement element = doc.Descendants(xmlElement).FirstOrDefault();

                if (!element.Equals(@""))
                {
                    element.Value = newValue;
                    doc.Save(path);
                }
                else
                {
                    Log.Append(string.Format("XElement \"{0}\" not found.", xmlElement));
                }
            }
            catch (Exception ex)
            {
                Log.Append(string.Format("An error occurred while changing value for XElement \"{0}\"\nStacktrace:\n{1}", xmlElement, ex.StackTrace));
            }
        }



        /// <summary>
        /// The name of an outputfile has the structure >>FLYNAME-nn.xml<<
        /// where >>nn<< represents a file counter 
        /// </summary>
        /// <returns></returns>
        string GetFileName(string folderPath, string flyName)
        {
            // Get all XML files in the directory and extract the int-counter from filename and deliver the max-value
            var max = Directory.GetFiles(folderPath, "*.xml")
                                    .Where(f => f.Contains(flyName))
                                    .Select(f => Path.GetFileNameWithoutExtension(f))
                                    .Select(str => str.Substring(str.Length - 2).ToNumberOnly()).Max();
            return Path.Combine(folderPath, string.Format("{0}-{1}{2}", flyName, (max + 1).ToString("00"), ".xml"));
        }


        XElement BuildXMLHeader()
        {
            try
            {
                var header = new XElement("DTS_xml",
                                    new XElement("metadata",
                                         new XElement("license", "PDDL", new XAttribute("URI", "http://opendatacommons.org/licenses/pddl")),
                                         new XElement("URIs",
                                             new XElement("recording", _settings.Recording),
                                             new XElement("analysis", _settings.Analysis),
                                             new XElement("datamodel", _settings.DataModel)),
                                         new XElement("experimenter",
                                             new XElement("firstname", _settings.FirstName),
                                             new XElement("lastname", _settings.LastName),
                                             new XElement("orcid", _settings.ORCID.ToString())),
                                         new XElement("fly",
                                             new XElement("name", _settings.FlyName),
                                             new XElement("description", _settings.FlyDescription),
                                             new XElement("flybase", _settings.FlyBase)),
                                         new XElement("experiment", new XAttribute("type", "torquemeter"),
                                             new XElement("dateTime", _settings.TimeStamp.ToString("yyyy-MM-ddTHH:mm:ss")),
                                             new XElement("duration", _settings.Duration.ToString()),
                                             new XElement("description", _settings.ExperimentDescription),
                                             new XElement("sample_rate", _settings.SamplingRate.ToString()),
                                             new XElement("arena_type", _settings.Arena.ToString()),
                                             new XElement("meter_type", _settings.DMSType.ToString()))));
                return header;
            }
            catch (Exception ex) { Log.Append(ex); }
            return new XElement("Failed Header Build");
        }

        XElement BuildXMLSequence()
        {
            try
            {
                var seqElement = new XElement("sequence", new XAttribute("periods", _settings.PeriodCount.ToString()));
                // Dynamically create and add <period> elements based on the provided data
                foreach (var period in _settings.PeriodCollection)
                {
                    XElement periodElement = new XElement("period", new XAttribute("number", period.Number.ToString()), // Use the provided number
                        new XElement("type", period.Type.ToString()),
                        new XElement("duration", period.Duration.ToString()),
                        new XElement("outcome", period.Outcome.ToString()),
                        new XElement("pattern", period.Pattern.ToString()),
                        new XElement("coup_coeff", period.CoupCoeff.ToString()),
                        new XElement("contingency", period.Contingency.ToString())
                    );

                    // Add the constructed <period> element to the root <sequence> element
                    seqElement.Add(periodElement);
                }
                return seqElement;
            }
            catch (Exception ex) { Log.Append(ex); }
            return new XElement("Failed Sequence Build");
        }

        XElement BuildXMLTimeSeries()
        {
            try
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
            catch (Exception ex) { Log.Append(ex); }
            return new XElement("Failed Time Series Build");
        }



        public bool ValidateXML(string path)
        {
            bool valid = false;
            var schemes = new XmlSchemaSet();
            var schemaPath = Path.Combine(Properties.Settings.Default.AppSettingsPath, @"periods.xsd");

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
                            Type = node.SelectSingleNode("type").InnerText.ToEnum<ExperimentType>(),
                            Duration = int.Parse(node.SelectSingleNode("duration").InnerText),
                            Outcome = int.Parse(node.SelectSingleNode("outcome").InnerText),
                            Pattern = (DisplayPattern)int.Parse(node.SelectSingleNode("pattern").InnerText),
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

        public void Dispose()
        {

        }

        #region Unused Methods




        #endregion
    }
}




