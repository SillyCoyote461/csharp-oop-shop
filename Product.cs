using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Product
{
    private readonly int code;
    private string name;
    private string description;
    private double price;
    private double iva;

    //constructor
    public Product(string name, string description, double price, double iva)
    {
        Random rnd = new Random();
        code = rnd.Next(1, 99999999);

        this.name = name;
        this.description = description;
        this.price = price;
        this.iva = iva;
    }

    //properties
    public int Code
    {
        get { return code; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public double Iva
    {
        get { return iva; }
        set { iva = value; }
    }

    //methods
    public override string ToString()
    {
        var bk = Environment.NewLine;
        return 
            $"{bk}" +
            $"Nome prodotto: {name} {bk}" +
            $"Descrizione prodotto: {description} {bk}" +
            $"Prezzo prodotto: {price}€ {bk}" +
            $"Iva prodotto: {iva}% {bk}" +
            $"Codice prodotto: {code} {bk}";
    }

    public double GetFullprice()
    {
        double tax = (price / 100) * iva;
        return price + tax;
    }
};

