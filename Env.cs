using ejercicioClase.Clases;
namespace ejercicioClase;

    public static class Env
    {
        private static string fileNameProducto = "productos.json";
        private static string fileNameCategoria = "productos.json";
        private static List<Producto> productos = new();

        public static string FileName { get => fileNameProducto; set => fileNameProducto = value; }
        public static string fileNameCategoria { get => fileNameCategoria; set => fileNameCategoria
         = value; }
        public static List<Producto> Productos { get => productos; set => productos = value; }

        public static void LoadDataProductos(string nombreArchivo, List<Producto> listProducts)
        {
            if (!File.Exists(nombreArchivo))
            {
                File.WriteAllText(nombreArchivo, "");
                Productos = listProducts;
                return;
            }

            using (StreamReader reader = new StreamReader(nombreArchivo))
            {
                string json = reader.ReadToEnd();
                Productos = JsonSerializer.Deserialize<List<Producto>>(json, new JsonSerializerOptions() 
                { PropertyNameCaseInsensitive = true }) ?? new List<Producto>();
            }
        }
    }
