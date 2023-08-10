using ejercicioClase.Clases;

internal class Program
{
    private static void Main()
    {
        Producto p = new Producto();
        Guid id = Guid.NewGuid();
        p.CodProducto = id.ToString();
        p.Nombre = "XXXXXXX";
        p.PrecioVenta = 23000;
        p.PrecioCompra = 50000;
        p.Stock = 8;
        p.StockMin = 10;
        p.Stock = 20;
        Env.productos.Add(p);


    }    
}