namespace ejercicioClase.Clases;

    public class Producto
    {        
        public string IdCategoria {get; set;} 
        public string CodProducto {get; set;}
        public string Nombre {get; set;}
        public int Stock {get; set;}
        public int StockMin {get; set;}
        public int StockMax {get; set;}
        public int PrecioVenta {get; set;}
        public int PrecioCompra {get; set;}

        public Producto(string _IdCategoria, string _CodProducto, string _Nombre, int _Stock, int _StockMin,int _StockMax, int _PrecioVenta,int _PrecioCompra)
        {
            this.IdCategoria = _IdCategoria;
            this.CodProducto = _CodProducto;
            this.Nombre = _Nombre;
            this.Stock = _Stock;
            this.StockMin = _StockMin;
            this.StockMax = _StockMax;
            this.PrecioVenta = _PrecioVenta;
            this.PrecioCompra = _PrecioCompra;
        }
        public Producto(){
            if(!File.Exists(Env.FileName)){
                File.WriteAllText(Env.FileName, "");
            }
        }
        public Producto AgregarProducto(string codProducto,List<Categoria> categorias){
/*             List<Categoria> categori = new();
 */            Console.Clear();
            Console.WriteLine("Ingrese el id de la categoria a la cual quiere ingresar el producto: ");
            string IdCategoria = Console.ReadLine();
/*             var filteredResult = from s in categorias
                    where s.Id == IdCategoria
                    select s;
            foreach (Categoria cate in filteredResult)
            {
                categori.Add(cate);
            } */
            Console.WriteLine("Ingrese el Nombre del producto");
            string Nombrestring = Console.ReadLine();

            Console.WriteLine("Ingrese el Stock del producto");
            int Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Stock minimo del producto");
            int StockMin = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Stock maximo del producto");
            int StockMax = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Precio de la venta del producto");
            int PrecioVenta = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Precio de la compra del producto");
            int PrecioCompra = int.Parse(Console.ReadLine());

            Producto ProductoNuevo = new(IdCategoria, codProducto,Nombre,Stock,StockMin,StockMax,PrecioVenta,PrecioCompra);
            return ProductoNuevo;
        }
    }
