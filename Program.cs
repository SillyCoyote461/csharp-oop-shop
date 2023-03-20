Product[] productList = new Product[3];
productList[0] = new Product("Pasta", "500gr grano italiano", 1.50, 22);
productList[1] = new Product("Tonno", "200gr Tonno del mar Ionio", 2.00, 22);
productList[2] = new Product("Pane", "1kg pane duro", 1.00, 22);

foreach (Product product in productList)
{
    Console.WriteLine(product.ToString());
    Console.WriteLine($"prezzo iva compresa: {product.GetFullprice()}");
}
