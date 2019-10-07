// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 5.0.0.47. www.xsd2code.com
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace DataClasses
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Collections.Generic;

[XmlRootAttribute(ElementName="Command")]
public class dxCommand
{
    #region Private fields
    private CommandNames _name;
    private dxParameterList _parameters;
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// Command class constructor
    /// </summary>
    public dxCommand()
    {
        _parameters = new dxParameterList();
    }
    
    public CommandNames Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    
    public dxParameterList Parameters
    {
        get
        {
            return _parameters;
        }
        set
        {
            _parameters = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(dxCommand));
                serializer.UnknownNode += delegate(object sender, XmlNodeEventArgs e) {Debug.WriteLine("[Unknown Node] Ln {0} Col {1} Object: {2} LocalName {3}, NodeName: {4}", e.LineNumber, e.LinePosition, e.ObjectBeingDeserialized.GetType().FullName, e.LocalName, e.Name);};
                serializer.UnknownElement +=  delegate(object sender, XmlElementEventArgs e){Debug.WriteLine("[Unknown Element  ] Ln {0} Col {1} Object : {2} ExpectedElements {3}, Element : {4}", e.LineNumber, e.LinePosition, e.ObjectBeingDeserialized.GetType().FullName, e.ExpectedElements, e.Element.InnerXml);};
                serializer.UnknownAttribute +=  delegate(object sender, XmlAttributeEventArgs e) {Debug.WriteLine("[Unknown Attribute] Ln {0} Col {1} Object : {2} LocalName {3}, Text : {4}", e.LineNumber, e.LinePosition, e.ObjectBeingDeserialized.GetType().FullName, e.ExpectedAttributes, e.Attr.Name);};
            }
            return serializer;
        }
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current dxCommand object into an XML string
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize()
    {
        StreamReader streamReader = null;
        MemoryStream memoryStream = null;
        try
        {
            memoryStream = new MemoryStream();
            System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.IndentChars = "  ";
            System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
            Serializer.Serialize(xmlWriter, this);
            memoryStream.Seek(0, SeekOrigin.Begin);
            streamReader = new StreamReader(memoryStream);
            return streamReader.ReadToEnd();
        }
        finally
        {
            if ((streamReader != null))
            {
                streamReader.Dispose();
            }
            if ((memoryStream != null))
            {
                memoryStream.Dispose();
            }
        }
    }
    
    /// <summary>
    /// Deserializes workflow markup into an dxCommand object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output dxCommand object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out dxCommand obj, out Exception exception)
    {
        exception = null;
        obj = default(dxCommand);
        try
        {
            obj = Deserialize(input);
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool Deserialize(string input, out dxCommand obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public static dxCommand Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((dxCommand)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static dxCommand Deserialize(Stream s)
    {
        return ((dxCommand)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current dxCommand object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out Exception exception)
    {
        exception = null;
        try
        {
            SaveToFile(fileName);
            return true;
        }
        catch (Exception e)
        {
            exception = e;
            return false;
        }
    }
    
    public virtual void SaveToFile(string fileName)
    {
        StreamWriter streamWriter = null;
        try
        {
            string xmlString = Serialize();
            FileInfo xmlFile = new FileInfo(fileName);
            streamWriter = xmlFile.CreateText();
            streamWriter.WriteLine(xmlString);
            streamWriter.Close();
        }
        finally
        {
            if ((streamWriter != null))
            {
                streamWriter.Dispose();
            }
        }
    }
    
    /// <summary>
    /// Deserializes xml markup from file into an dxCommand object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output dxCommand object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out dxCommand obj, out Exception exception)
    {
        exception = null;
        obj = default(dxCommand);
        try
        {
            obj = LoadFromFile(fileName);
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool LoadFromFile(string fileName, out dxCommand obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static dxCommand LoadFromFile(string fileName)
    {
        FileStream file = null;
        StreamReader sr = null;
        try
        {
            file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(file);
            string xmlString = sr.ReadToEnd();
            sr.Close();
            file.Close();
            return Deserialize(xmlString);
        }
        finally
        {
            if ((file != null))
            {
                file.Dispose();
            }
            if ((sr != null))
            {
                sr.Dispose();
            }
        }
    }
    
    #region Clone method
    /// <summary>
    /// Create a clone of this dxCommand object
    /// </summary>
    public virtual dxCommand Clone()
    {
        return ((dxCommand)(MemberwiseClone()));
    }
    #endregion
}
}
#pragma warning restore
