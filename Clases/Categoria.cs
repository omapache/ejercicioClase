namespace ejercicioClase.Clases;

    public class Categoria
    {
        public int Id {get; set;}
        public string Descripcion {get; set;}

        public Categoria(int _Id, string _Descripcion){
            this.Id = _Id;
            this.Descripcion = _Descripcion;
        }
        public Categoria AgregarCategoria(int Id){
            Console.Clear();
            Console.WriteLine("Ingrese la Descripcion de la categoria");
            string Descripcion = Console.ReadLine();

            Categoria categoriaNueva = new(Id, Descripcion);
            return categoriaNueva;
        }
    }
