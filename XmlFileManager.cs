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
using ScottPlot.Statistics.Interpolation;
using static System.Net.Mime.MediaTypeNames;


namespace plotBrembs
{
    public class XmlFileManager
    {
        private Form1 form;

        public string fileName { get; set; }
        public string filePath { get; set; }

        public XmlFileManager(string filePath, string fileName)
        {
            this.filePath = filePath;
            this.fileName = fileName;
            XDocument doc = CreateBasicSchema();
            saveXML(doc);
        }

        public XmlFileManager(string filePath, string fileName, Form1 form)
        {
            this.form = form;
            this.filePath = filePath;
            this.fileName = fileName;
            XDocument doc = CreateBasicSchemaPeriod(int.Parse(form.getNumberTextBox));
            saveXML(doc);
            //
        }

        public void saveXML(XDocument docXML)
        {
            if (!File.Exists(Path.Combine(this.filePath, this.fileName)))
            {
                try
                {
                    docXML.Save(Path.Combine(this.filePath, this.fileName));
                    Console.WriteLine("XML file created successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error Message");
                }
            }
        }

        public static XDocument CreateBasicSchema()
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
                        new XElement("csv_data", @""
                        // Assuming csv_data will be filled with actual CSV content or more elements
                        )

                )
            )
        );
        return doc;
        }
        public static XDocument CreateBasicSchemaPeriod(int numberOfPeriods)
        {
            // Create the root <sequence> element with the "periods" attribute
            XElement root = new XElement("sequence", new XAttribute("periods", numberOfPeriods));

            // Dynamically create and add <period> elements to the root
            for (int i = 1; i <= numberOfPeriods; i++)
            {
                XElement periodElement = new XElement("period",
                    new XAttribute("number", i.ToString()), // Make sure the "number" attribute reflects the loop iteration
                    new XElement("type", "optomotorR"),
                    new XElement("duration", "30"),
                    new XElement("outcome", "0"),
                    new XElement("pattern", "3"),
                    new XElement("coup_coeff", "0"),
                    new XElement("contingency", "")
                );

                // Add the constructed <period> element to the root <sequence> element
                root.Add(periodElement);
            }

            // Create the XDocument and add the root element
            XDocument periods = new XDocument();
            periods.Add(root);

            return periods;
        }

        public static Boolean validateXML(string directory, string fileName)
        {
            Boolean valid = false;
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("http://www.brembs.net", Path.GetDirectoryName(Path.Combine(System.Windows.Forms.Application.ExecutablePath, @"period.xsd")));
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas = schemas;
            settings.ValidationEventHandler += ValidationEventHandler;

            using (XmlReader reader = XmlReader.Create(Path.Combine(directory, fileName), settings))
            {
                try
                {
                    while (reader.Read()) { }
                    Debug.WriteLine("XML file is valid.");
                    valid = true;
                }
                catch (XmlException ex)
                {
                    Debug.WriteLine($"XML exception: {ex.Message}");
                    valid = false;
                }
            }

            return valid;
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                case XmlSeverityType.Warning:
                    MessageBox.Show($"Validation error: {e.Message}", @"Error");
                    break;
            }
        }




        /*      public void UpdateFirstName(string xmlElement, string newValue)
              {
                  if (!File.Exists(FilePath))
                  {
                      Console.WriteLine("File does not exist.");
                      return;
                  }

                  try
                  {
                      XDocument doc = XDocument.Load(FilePath);
                      XElement firstNameElement = doc.Descendants(xmlElement).FirstOrDefault();

                      if (firstNameElement != @"")
                      {
                          firstNameElement.Value = newValue;
                          WriteXml(doc.Root); // Pass the updated root element to your existing WriteXml method
                      }
                      else
                      {
                          Console.WriteLine("The firstname element was not found.");
                      }
                  }
                  catch (Exception ex)
                  {
                      Console.WriteLine($"An error occurred while updating the firstname: {ex.Message}");
                  }
              } 

              public void WriteXml(XElement newContent)
              {
                  try
                  {
                      XDocument doc = new XDocument(newContent); // Create a new XDocument with the new content
                      doc.Save(FilePath);
                      Console.WriteLine("XML file saved successfully.");
                  }
                  catch (Exception ex)
                  {
                      Console.WriteLine($"An error occurred: {ex.Message}");
                  }
              } */

    }
}




