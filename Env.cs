using ejercicioClase.Clases;
namespace ejercicioClase;

    public static class Env
    {
        private static string filename = "producto.json";
        private static List<Producto> productos = new();

        public static string FileName { get => filename; set => filename = value; } 
        public static List<Producto> Productos { get => productos; set => productos = value; }
    }
