namespace ejercicioClase.Clases;

    public class Categoria
    {
        public string Id {get; set;}
        public string Descripcion {get; set;}

        public Categoria(string _Id, string _Descripcion){
            this.Id = _Id;
            this.Descripcion = _Descripcion;
        }
        public AgregarCategoria(id){
            Console.Clear();
            Console.WriteLine("Ingrese la Descripcion de la categoria");
            string Descripcion = Console.ReadLine();
            
        }
    }
