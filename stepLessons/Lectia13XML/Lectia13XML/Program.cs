using System;
using System.Xml;

namespace Lectia13XML
{
    #region exemplu1
    //class CreareXML
    //{
    //    static void Main()
    //    {
    //        XmlTextWriter writer = new XmlTextWriter("D:\\XML\\exemplu.xml", System.Text.Encoding.UTF8);
    //        writer.WriteStartDocument(true);
    //        writer.Formatting = Formatting.Indented; // formatarea ca sa nu sa se puna intrun rand

    //        writer.WriteStartElement("Exemplu"); //<Exemplu>
    //        writer.WriteStartElement("Numar"); //<Numar>
    //        writer.WriteString("1");  //continut
    //        writer.WriteEndElement(); //</Numar>
    //        writer.WriteEndElement(); //</Exemplu>
    //        writer.WriteEndDocument();
    //        writer.Close();

    //        Console.Write("Fisier XML creat cu succes");
    //    }
    //}
    #endregion

    #region ex1
    class CreareXML
    {
        static void Main()
        {
            XmlTextWriter writer = new XmlTextWriter("D:\\XML\\ex1.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented; // formatarea ca sa nu sa se puna intrun rand

            writer.WriteStartElement("UtilizatoriDataBase"); //<UtilizatoriDataBase>

            writer.WriteStartElement("Utilizator"); //<Utilizator>
            writer.WriteStartElement("Utilizator_ID"); //<Utilizator_ID>
            writer.WriteString("123qwer");
            writer.WriteEndElement(); //<Utilizator_ID>
            writer.WriteStartElement("Utilizator_password"); //<Utilizator_password>
            writer.WriteString("pass123");
            writer.WriteEndElement(); //<Utilizator_password>
            writer.WriteEndElement(); //<Utilizator>
            writer.WriteStartElement("Utilizator"); //<Utilizator>
            writer.WriteStartElement("Utilizator_ID"); //Utilizator_ID
            writer.WriteString("321pot");
            writer.WriteEndElement(); //Utilizator_ID
            writer.WriteStartElement("Utilizator_password"); //<Utilizator_password>
            writer.WriteString("pass321");
            writer.WriteEndElement(); //<Utilizator_password>
            writer.WriteEndElement(); //<Utilizator>

            writer.WriteEndElement(); //<UtilizatoriDataBase>

            writer.WriteEndDocument();
            writer.Close();

            Console.Write("Fisier XML creat cu succes");
        }
    }
    #endregion

}
