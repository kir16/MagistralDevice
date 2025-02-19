// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 5.0.0.47. www.xsd2code.com
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

// ReSharper disable MemberCanBePrivate.Global

#pragma warning disable
namespace MagistralDevice.DataClasses
{
  [XmlRoot(ElementName = "Message")]

  // ReSharper disable once InconsistentNaming
  public sealed class dxMessage
  {
    #region Private fields

    private static XmlSerializer _serializer;

    #endregion

    public int Code
    {
      get;
      set;
    }

    public string Text
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

        _serializer = new XmlSerializerFactory().CreateSerializer(typeof(dxMessage));
        if( _serializer != null ) {
          // ReSharper disable PossibleNullReferenceException
          _serializer.UnknownNode += delegate(object sender, XmlNodeEventArgs e) {
                                       Debug.WriteLine("[Unknown Node] Ln {0} Col {1} Object: {2} LocalName {3}, NodeName: {4}", e.LineNumber, e.LinePosition, e.ObjectBeingDeserialized.GetType().FullName, e.LocalName, e.Name);
                                     };

          _serializer.UnknownElement += delegate(object sender, XmlElementEventArgs e) {
                                          Debug.WriteLine("[Unknown Element  ] Ln {0} Col {1} Object : {2} ExpectedElements {3}, Element : {4}"
                                                        , e.LineNumber
                                                        , e.LinePosition
                                                        , e.ObjectBeingDeserialized.GetType().FullName
                                                        , e.ExpectedElements
                                                        , e.Element.InnerXml);
                                        };

          _serializer.UnknownAttribute += delegate(object sender, XmlAttributeEventArgs e) {
                                            Debug.WriteLine("[Unknown Attribute] Ln {0} Col {1} Object : {2} LocalName {3}, Text : {4}"
                                                          , e.LineNumber
                                                          , e.LinePosition
                                                          , e.ObjectBeingDeserialized.GetType().FullName
                                                          , e.ExpectedAttributes
                                                          , e.Attr.Name);
                                          };

          // ReSharper restore PossibleNullReferenceException

          return _serializer;
        }

        return null;
      }
    }

    /// <summary>
    ///   Serializes current dxMessage object into file
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

        if( fileName == null ) {
          throw new ArgumentNullException(nameof(fileName));
        }

        FileInfo xmlFile = new FileInfo(fileName);
        streamWriter = xmlFile.CreateText();
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally {
        streamWriter?.Dispose();
      }
    }

    /// <summary>
    ///   Deserializes xml markup from file into an dxMessage object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output dxMessage object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out dxMessage obj, out Exception exception) {
      exception = null;
      obj = default;
      try {
        obj = LoadFromFile(fileName);
        return true;
      }
      catch( Exception ex ) {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out dxMessage obj) {
      Exception exception;
      bool result = LoadFromFile(fileName, out obj, out exception);
      if( exception != null ) {
        throw exception;
      }

      return result;
    }

    public static dxMessage LoadFromFile(string fileName) {
      FileStream file = null;
      StreamReader sr = null;
      try {
        if( fileName == null ) {
          throw new ArgumentNullException(nameof(fileName));
        }

        file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
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
    ///   Create a clone of this dxMessage object
    /// </summary>
    public dxMessage Clone() {
      return (dxMessage)MemberwiseClone();
    }

    #endregion

    #region Serialize/Deserialize

    /// <summary>
    ///   Serializes current dxMessage object into an XML string
    /// </summary>
    /// <returns>string XML value</returns>
    public string Serialize() {
      StreamReader streamReader = null;
      MemoryStream memoryStream = null;
      try {
        memoryStream = new MemoryStream();
        XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
                                              {
                                                Indent = false
                                              , CloseOutput = true
                                              , NewLineChars = " "
                                              , NewLineHandling = NewLineHandling.Entitize
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
    ///   Deserializes workflow markup into an dxMessage object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output dxMessage object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out dxMessage obj, out Exception exception) {
      exception = null;
      obj = default;
      try {
        obj = Deserialize(input);
        return true;
      }
      catch( Exception ex ) {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string input, out dxMessage obj) {
      Exception exception;
      bool result = Deserialize(input, out obj, out exception);
      if( exception != null ) {
        throw exception;
      }

      return result;
    }

    public static dxMessage Deserialize(string input) {
      StringReader stringReader = null;
      try {
        if( string.IsNullOrEmpty(input) ) {
          return null;
        }

        stringReader = new StringReader(input);
        if( Serializer != null ) {
          return (dxMessage)Serializer.Deserialize(XmlReader.Create(stringReader));
        }

        return new dxMessage();
      }
      finally {
        stringReader?.Dispose();
      }
    }

    public static dxMessage Deserialize(Stream s) {
      if( Serializer == null ) {
        return new dxMessage();
      }

      if( s == null ) {
        throw new ArgumentNullException(nameof(s));
      }

      return (dxMessage)Serializer.Deserialize(s);
    }

    #endregion
  }
}
#pragma warning restore
