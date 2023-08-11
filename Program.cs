using ejercicioClase.Clases;
using ejercicioClase.View;


internal class Program
{
    private static void Main()
    {
        List<Producto> listaProducto = new ();
        List<Categoria> listaCategoria = new (){
            new Categoria(1, "Lacteos"),
            new Categoria(2, "Hogar"),
            new Categoria(3, "Aseo personal"),
            new Categoria(4, "Bebidas gaseosas"),
            new Categoria(5, "Bebidas alcoholicas"),
            new Categoria(6, "Abarrotes"),
            new Categoria(7, "Carnes")
        };
        var menu = new MainMenu();
        int opcion;
        do{
            opcion = menu.Menu();

            switch(opcion)
            {
                case 1:
                    var registroProducto = producto.RegistrarProducto();
                    listaProducto.Add(registroProducto);
                    registroProducto.MostrarProductos(listaProducto);

                    Env.LoadDataProductos(Env.FileName, listaProducto);
                    Env.Productos.Add(registroProducto);

                    string json = JsonSerializer.Serialize(Env.Productos, new JsonSerializerOptions() 
                    { WriteIndented = true });
                    File.WriteAllText(Env.FileName, json);
                    break;

                case 2:
                    var registroCategoria = categoria.RegistrarCategoria();
                    listaCategoria.Add(registroCategoria);
                    registroCategoria.MostrarCategorias(listaCategoria);
                    break;

                case 3:
                    categoria.MostrarCategorias(listaCategoria);
                    break;

                case 4:
                    producto.MostrarProductos(listaProducto);
                    break;

                case 5:
                    break;

                case 6:
                    break;
            }
        }
        while(opcion != 6);


    }    
}