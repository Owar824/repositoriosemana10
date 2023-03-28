using StevenOmarAlfaroVillanuevaSemana8.DAO;
using StevenOmarAlfaroVillanuevaSemana8.Models;

CRUDProducto crud = new CRUDProducto();
Producto producto = new Producto();

Console.WriteLine("Menú");
Console.WriteLine("Pulse 1 para insertar Producto");
Console.WriteLine("Pulse 2 para  actualizar Producto");
var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu) 
{
    case 1:
        int bucle = 1;
        while (bucle == 1) 
        {
            Console.WriteLine("Ingresa el nombre de tu Producto: ");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa la descripcion de tu producto: ");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingresa el precio de tu producto: ");
            producto.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingresa la cantidad de producto disponible: ");
            producto.Stock = Convert.ToInt32(Console.ReadLine());
            crud.AgregarProducto(producto);

            Console.WriteLine("El producto se ingreso corectamente");
            Console.WriteLine("pulse 1 para continuar agregando productos");
            Console.WriteLine("Pulsa 0 para salir");
            bucle = Convert.ToInt32(Console.ReadLine());
        }
        break;
      case 2:
        Console.WriteLine("Actualizar datos");
        break;



}