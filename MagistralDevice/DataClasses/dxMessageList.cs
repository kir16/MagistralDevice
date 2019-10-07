// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 5.0.0.47. www.xsd2code.com
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global

#pragma warning disable
namespace MagistralDevice.DataClasses
{
  [XmlRoot(ElementName = "MessageList")]
  // ReSharper disable once InconsistentNaming
  public sealed class dxMessageList
  {
    /// <summary>
    ///   MessageList class constructor
    /// </summary>
    public dxMessageList() {
      MessageItem = new List<dxMessage>();
    }

    public List<dxMessage> MessageItem
    {
      get;
      set;
    }

    private static XmlSerializer Serializer
    {
      get
      {
        if( _serializer != null ) {
          return _serializer;
        }

        _serializer = new XmlSerializerFactory().CreateSerializer(typeof(dxMessageList));
        if( _serializer == null ) {
          return null;
        }

        // ReSharper disable PossibleNullReferenceException
        _serializer.UnknownNode += delegate(object sender, XmlNodeEventArgs e) {
                                     Debug.WriteLine("[Unknown Node] Ln {0} Col {1} Object: {2} LocalName {3}, NodeName: {4}", e.LineNumber, e.LinePosition, e.ObjectBeingDeserialized.GetType().FullName, e.LocalName, e.Name);
                                   };
        _serializer.UnknownElement += delegate(object sender, XmlElementEventArgs e) {
                                        Debug.WriteLine("[Unknown Element  ] Ln {0} Col {1} Object : {2} ExpectedElements {3}, Element : {4}",
                                                        e.LineNumber,
                                                        e.LinePosition,
                                                        e.ObjectBeingDeserialized.GetType().FullName,
                                                        e.ExpectedElements,
                                                        e.Element.InnerXml);
                                      };
        _serializer.UnknownAttribute += delegate(object sender, XmlAttributeEventArgs e) {
                                          Debug.WriteLine("[Unknown Attribute] Ln {0} Col {1} Object : {2} LocalName {3}, Text : {4}",
                                                          e.LineNumber,
                                                          e.LinePosition,
                                                          e.ObjectBeingDeserialized.GetType().FullName,
                                                          e.ExpectedAttributes,
                                                          e.Attr.Name);
                                        };
        // ReSharper restore PossibleNullReferenceException

        return _serializer;
      }
    }

    /// <summary>
    ///   Serializes current dxMessageList object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public bool SaveToFile(string fileName, out Exception exception) {
      exception = null;
      try {
        SaveToFile(fileName);
        return true;
      }
      catch( Exception e ) {
        exception = e;
        return false;
      }
    }

    public void SaveToFile(string fileName) {
      StreamWriter streamWriter = null;
      try {
        string xmlString = Serialize();
        FileInfo xmlFile = new FileInfo(fileName ?? throw new ArgumentNullException(nameof(fileName)));
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally {
        streamWriter?.Dispose();
      }
    }

    /// <summary>
    ///   Deserializes xml markup from file into an dxMessageList object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output dxMessageList object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out dxMessageList obj, out Exception exception) {
      exception = null;
      obj = default(dxMessageList);
      try {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch( Exception ex ) {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out dxMessageList obj) {
      bool result = LoadFromFile(fileName, out obj, out Exception exception);
      if( exception != null ) {
        throw exception;
      }
      return result;
    }

    public static dxMessageList LoadFromFile(string fileName) {
      FileStream file = null;
      StreamReader sr = null;
      try {
        file = new FileStream(fileName ?? throw new ArgumentNullException(nameof(fileName)), FileMode.Open, FileAccess.Read);
        sr = new StreamReader(file);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally {
        file?.Dispose();

        sr?.Dispose();
      }
    }

    #region Clone method

    /// <summary>
    ///   Create a clone of this dxMessageList object
    /// </summary>
    public dxMessageList Clone() {
      return(dxMessageList)MemberwiseClone();
    }

    #endregion

    #region Private fields

    private static XmlSerializer _serializer;

    #endregion

    #region Serialize/Deserialize

    /// <summary>
    ///   Serializes current dxMessageList object into an XML string
    /// </summary>
    /// <returns>string XML value</returns>
    public string Serialize() {
      StreamReader streamReader = null;
      MemoryStream memoryStream = null;
      try {
        memoryStream = new MemoryStream();
        XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
                                              {
                                                  Indent = true,
                                                  IndentChars = "  "
                                              };
        XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
        Serializer?.Serialize(xmlWriter, this);
        memoryStream.Seek(0, SeekOrigin.Begin);
        streamReader = new StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally {
        streamReader?.Dispose();

        memoryStream?.Dispose();
      }
    }

    /// <summary>
    ///   Deserializes workflow markup into an dxMessageList object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output dxMessageList object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out dxMessageList obj, out Exception exception) {
      exception = null;
      obj = default(dxMessageList);
      try {
        obj = Deserialize(input);
        return true;
      }
      catch( Exception ex ) {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string input, out dxMessageList obj) {
      bool result = Deserialize(input, out obj, out Exception exception);
      if( exception != null ) {
        throw exception;
      }
      return result;
    }

    public static dxMessageList Deserialize(string input) {
      StringReader stringReader = null;
      try {
        stringReader = new StringReader(input ?? throw new ArgumentNullException(nameof(input)));
        if( Serializer != null ) {
          return(dxMessageList)Serializer.Deserialize(XmlReader.Create(stringReader));
        }
        return new dxMessageList();
      }
      finally {
        stringReader?.Dispose();
      }
    }

    public static dxMessageList Deserialize(Stream s) {
      if( Serializer != null ) {
        return(dxMessageList)Serializer.Deserialize(s ?? throw new ArgumentNullException(nameof(s)));
      }
      return new dxMessageList();
    }

    #endregion
  }
}
#pragma warning restore
