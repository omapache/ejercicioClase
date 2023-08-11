namespace ejercicioClase.Clases;

    public class Categoria
    {
        public int Id {get; set;}
        public string Descripcion {get; set;}

        public Categoria(int _Id, string _Descripcion){
            this.Id = _Id;
            this.Descripcion = _Descripcion;
        }
        public Categoria(){
            if(!File.Exists(Env.FileName)){
                File.WriteAllText(Env.FileName, "");
            }
        }
        public Categoria AgregarCategoria(int Id){
            Console.Clear();
            Console.WriteLine("Ingrese la Descripcion de la categoria");
            string Descripcion = Console.ReadLine();

            Categoria categoriaNueva = new(Id, Descripcion);
            return categoriaNueva;
        }

        public void MostrarCategorias(List<Categoria> listaCategoria){
            Console.Clear();
            Console.WriteLine("MOSTRAR CATEGORÍAS\n");
            var orderByResult = from c in listaCategoria
                            orderby c.Id
                            select new {c.Id, c.Descripcion};

            Console.WriteLine("{0, -20} {1, 7}\n", "ID CATEGORÍA", "NOMBRE CATEGORÍA");
            foreach (var categori in orderByResult)
            {
                Console.WriteLine("{0, -20} {1, -30}", categori.Id, categori.Descripcion); 
            }
            Console.ReadKey();
        }
    }
