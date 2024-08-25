using System.Xml.Serialization;

namespace XmlSerializationBasics.SerializationWithXmlElement;

[XmlRoot(elementName: "book")]
public class BookInfo
{
    [XmlElement(elementName: "book-title")]
    public string? Title { get; set; }

    [XmlElement(elementName: "book-price")]
    public decimal Price { get; set; }

    [XmlElement(elementName: "book-genre")]
    public string? Genre { get; set; }

    [XmlElement(elementName: "book-isbn")]
    public string? Isbn { get; set; }

    [XmlElement(elementName: "book-publication-date")]
    public string? PublicationDate { get; set; }
}
