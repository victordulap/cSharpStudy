using System;

public class Human
{
    public static Human singleton;

    public string name { get; /*private */set; } // noi acum putem lua valoarea lui name, da nu putem sa ii setam valoare din alta parte in afara de clasa
    // si putem folosi ca alternativa la randul de jos

    public void setName(string name)
    {
        this.name = name;
    }

    //public string Name => name; // il face readonly automat pe Name
    //public string Name() => name;
}

public class Program
{
    public static void Main(string[] args)
    {
        //Human obj = new Human();
        //obj.Name = "test"; nu putem atribui pentru ca e readonllly
        //Console.WriteLine(obj.Name);
        //Console.WriteLine(obj.Name());
        Human.singleton.setName("XYZ");
        Console.WriteLine(Human.singleton.name); // cu ajutor la singleton putem afisa
    }
}

