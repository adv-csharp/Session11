
using _4_serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

var products = new List<Product>() { 
    new Product {Id = 1, Name = "Monitor", Price = 1000 },
    new Product {Id = 2, Name = "Pc", Price = 1000 },
    new Product {Id = 3, Name = "Mouse", Price = 1000 },
    new Product {Id = 4, Name = "Keyboard", Price = 1000 },
};


/**
 * 
 * Serialization 
 *  memeory -> 
 * Desrialization
 *  -> memory
 *  
 *  Formats
 *      Binary
 *          C#
 *          ProtoBuff
 *          ..
 *      Pain Text
 *          XML
 *          JSON
 *          Yaml
 *          Toml
 *          ini
 *          ...
 *          
 *  
 */


/*Binary*/
var bf = new BinaryFormatter();
var fs = new FileStream(Path.Combine(AppContext.BaseDirectory, "products.bin"), FileMode.Create);
bf.Serialize(fs, products);
fs.Close();

var bfD = new BinaryFormatter();
var fsD = new FileStream(Path.Combine(AppContext.BaseDirectory, "products.bin"), FileMode.Open);
var sample = (List<Product>)bfD.Deserialize(fsD);
fs.Close();
Console.WriteLine("Binary " + sample.Count);

/*XML*/
var xmlSer = new XmlSerializer(products.GetType());
var xmlWriter = new StreamWriter(Path.Combine(AppContext.BaseDirectory, "products.xml"));
xmlSer.Serialize(xmlWriter, products);
xmlWriter.Close();

var xmlReader = new StreamReader(Path.Combine(AppContext.BaseDirectory, "products.xml"));
var sample2 = (List<Product>)xmlSer.Deserialize(xmlReader);
Console.WriteLine("XML " + sample2.Count);

/* 
 *  JSON - JavaScript Object Notaion
 *  NewtonSoft.JSON
 *  System.Text.JSON
 */

var json = JsonSerializer.Serialize(products);
File.WriteAllText(Path.Combine(AppContext.BaseDirectory, "products.json"), json);

var sample3 = JsonSerializer.Deserialize<List<Product>>(json);

Console.WriteLine("JSON " + sample3.Count);