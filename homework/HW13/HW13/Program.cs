using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace HW13
{
    class Class1
    {
        public int[] IdTranzactie { get; set; }
        public DateTime[] DataTranzactiei { get; set; }
        public decimal[] SumaTranzactiei { get; set; }
        public bool[] StatutulTranzactiei { get; set; }
        public int Len { get; set; }

        // de la len nu lucreaza normal XML sortarea si etc de asta nu il includ in fisier

        public Class1(int _Len)
        {
            IdTranzactie = new int[_Len];
            DataTranzactiei = new DateTime[_Len];
            SumaTranzactiei = new decimal[_Len];
            StatutulTranzactiei = new bool[_Len];
            Len = _Len;
        }
    }

    class Program
    {
        static void Main()
        {
            Class1 obj = new Class1(50);

            //foreach(var i in obj.IdTranzactie)
            //{
            //    i = "";
            //} nu stiu :/

            Random rand = new Random();

            //string[] words = new string[] { "word", "cuvant", "red", "green", "blue", "casino", "car", "gun" };

            for (int i = 0; i < obj.Len; i++)
            {
                obj.IdTranzactie[i] = (obj.Len - i - 1);//words[rand.Next(words.Length)];
                obj.DataTranzactiei[i] = RandomDay();
                obj.SumaTranzactiei[i] = Convert.ToDecimal(rand.NextDouble() * rand.Next(10000));
                if (rand.Next(2) == 0)
                    obj.StatutulTranzactiei[i] = false;
                else
                    obj.StatutulTranzactiei[i] = true;

            }

            for (int i = 0; i < obj.Len; i++)
            {
                Console.WriteLine((i + 1).ToString() + $". IdTranzactie = {obj.IdTranzactie[i]}, DataTranzactiei = {obj.DataTranzactiei[i].Date}, SumaTranzactiei = {obj.SumaTranzactiei[i]}, StatutulTranzactiei = {obj.StatutulTranzactiei[i]}");
            }

            XMLController.WriteXML(obj);

            Console.WriteLine("/-------------------------/");
            Console.WriteLine("/-------------------------/");
            Console.WriteLine("/-------------------------/");

            XMLController.ReadXML();

            Console.WriteLine("/-------------------------/");
            Console.WriteLine("/-------------------------/");
            Console.WriteLine("/-------------------------/");

            XMLController.SortByIdXML();

            XMLController.SortByTransactVal();
        }

        static DateTime RandomDay()
        {
            Random gen = new Random();
            DateTime start = new DateTime(1999, 1, 1); //anul, luna, ziua
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }

    class XMLController
    {
        public static string path = "D:\\XML\\exFinal.xml";
        public static void WriteXML(Class1 obj)
        {
            XmlTextWriter writer = new XmlTextWriter(path, System.Text.Encoding.UTF8);

            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartElement("Tranzactii"); //<Tranzactii>

            for (int i = 0; i < obj.Len; i++)
            {
                writer.WriteStartElement("Tranzactie"); //<Tranzactie>

                writer.WriteStartElement("IdTranzactie"); //<IdTranzactie>
                writer.WriteValue(obj.IdTranzactie[i]);
                writer.WriteEndElement(); //</IdTranzactie>

                writer.WriteStartElement("DataTranzactiei"); //<DataTranzactiei>
                writer.WriteValue(obj.DataTranzactiei[i].Date);
                writer.WriteEndElement(); //</DataTranzactiei>

                writer.WriteStartElement("SumaTranzactiei"); //<SumaTranzactiei>
                writer.WriteValue(obj.SumaTranzactiei[i]);
                writer.WriteEndElement(); //</SumaTranzactiei>

                writer.WriteStartElement("StatutulTranzactiei"); //<StatutulTranzactiei>
                writer.WriteValue(obj.StatutulTranzactiei[i]);
                writer.WriteEndElement(); //</StatutulTranzactiei>

                writer.WriteEndElement(); //</Tranzactie>
            }

            //writer.WriteStartElement("Len"); //<Len>
            //writer.WriteValue(obj.Len);
            //writer.WriteEndElement(); //</Len>
            writer.WriteEndElement(); //</Tranzactii>
            writer.WriteEndDocument();
            writer.Close();
        }

        public static void ReadXML()
        {
            XmlDataDocument documentXML = new XmlDataDocument();
            XmlNodeList xmlnode;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            documentXML.Load(fs);
            xmlnode = documentXML.GetElementsByTagName("Tranzactie");

            for (int i = 0; i < xmlnode.Count; i++)
            {
                for (int j = 0; j < xmlnode[i].ChildNodes.Count; j++)
                    Console.Write(xmlnode[i].ChildNodes.Item(j).InnerText + " ");

                Console.WriteLine();
            }

        }

        public static void SortByTransactXML()
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(path, new XmlReaderSettings());

            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);

            // clonam scheletul tabelei dupa ca sa putem seta tipul de date la coloane
            DataTable ds2 = ds.Tables[0].Clone();
            //ds2.Columns["DataTranzactiei"].DataType = typeof(DateTime);
            ds2.Columns["SumaTranzactiei"].DataType = typeof(Int32);

            // incarcam tabela
            foreach (DataRow row in ds.Tables[0].Rows)
                ds2.ImportRow(row);

            DataView dv = new DataView();
            dv = new DataView(ds2, "SumaTranzactiei > 500", "SumaTranzactiei ASC", DataViewRowState.CurrentRows);

            dv.ToTable().WriteXml("Rezultat.xml");
            Console.WriteLine("XML creat");
        }

        public static void SortByIdXML()
        {
            //XmlReader xmlFile;
            //xmlFile = XmlReader.Create(path, new XmlReaderSettings());
            //DataSet ds = new DataSet();
            //ds.ReadXml(xmlFile);

            //DataView dv;
            //dv = new DataView(ds.Tables[0]);
            //dv.Sort = "IdTranzactie";

            //for (int i = 0; i < dv.Count; i++)
            //{
            //    Console.WriteLine(dv[i][0] + "  " + dv[i][1] + "  " + dv[i][2] + "  " + dv[i][3]);
            //}

            XmlReader xmlFile;
            xmlFile = XmlReader.Create(path, new XmlReaderSettings());

            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);

            //Clonati structura
            DataTable ds2 = ds.Tables[0].Clone();

            //Transformati tipul datelor din coloana Produs_pret
            ds2.Columns["IdTranzactie"].DataType = typeof(Int32);

            //Importati din nou continutul
            foreach (DataRow row in ds.Tables[0].Rows)
                ds2.ImportRow(row);

            DataView dv;
            dv = new DataView(ds2);
            dv.Sort = "IdTranzactie";

            dv.ToTable().WriteXml("D:\\XML\\exRezultat.xml");

            Console.WriteLine("XML creat");

        }

        public static void SortByTransactVal()
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(path, new XmlReaderSettings());

            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);

            //Clonati structura
            DataTable ds2 = ds.Tables[0].Clone();

            //Transformati tipul datelor din coloana Produs_pret
            ds2.Columns["SumaTranzactiei"].DataType = typeof(Decimal);

            //Importati din nou continutul
            foreach (DataRow row in ds.Tables[0].Rows)
                ds2.ImportRow(row);

            //Filtrare sortarea
            DataView dv = new DataView();
            dv = new DataView(ds2, "SumaTranzactiei >= 1000", "SumaTranzactiei DESC", DataViewRowState.CurrentRows);

            dv.ToTable().WriteXml("D:\\XML\\exRezultat2.xml");
            Console.WriteLine("XML creat");

        }

        public static void SerializeXML()
        {
            //Deschiderea XML
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(path, new XmlReaderSettings());
            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);

            //Serializare
            StreamWriter serialWriter;
            serialWriter = new StreamWriter("D:\\XML\\XMLserializat.xml");
            XmlSerializer xmlWriter = new XmlSerializer(ds.GetType());
            xmlWriter.Serialize(serialWriter, ds);
            serialWriter.Close();
            ds.Clear();

            Console.WriteLine("Serializare finisata cu succes!");
        }

        public static void DeserializeXML()
        {
            DataSet ds = new DataSet();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataSet));
            FileStream readStream = new FileStream("D:\\XML\\XMLserializat.xml", FileMode.Open);
            ds = (DataSet)xmlSerializer.Deserialize(readStream);
            readStream.Close();
            DataView dv = new DataView(ds.Tables[0]);
            dv.ToTable().WriteXml("D:\\XML\\XMLdeserializat.xml");

            Console.WriteLine("XML deserializat");
        }
    }
}
