using StevenOmarAlfaroVillanuevaSemana8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StevenOmarAlfaroVillanuevaSemana8.DAO
{
     public class CRUDProducto
    {
        public void AgregarProducto(Producto producto) 
        {
            using (AlmacenContext db = new AlmacenContext()) 
            { 
             Producto producto1 = new Producto();    
              producto1.Nombre = producto.Nombre;
              producto1.Descripcion = producto.Descripcion;
              producto1.Precio = producto.Precio;
              producto1.Stock = producto.Stock;
              db.Add(producto1);

              db.SaveChanges();


            }
        }

        public Producto ProductoIndividual(int id) 
        {
            using (AlmacenContext db = new AlmacenContext()) 
            { 
              
             var buscar =  db.Productos.FirstOrDefault(x => x.Id == id);

                return buscar;
            
            }
        
        }

        public void ActualizarProducto(Producto ParameterProduct)
        {
            using (AlmacenContext db = new AlmacenContext()) 
            {
             var buscar = ProductoIndividual(ParameterProduct.Id);
                if (buscar == null)
                {
                    Console.WriteLine("El id no existe");
                }
                else 
                { 
                 buscar.Nombre =ParameterProduct.Nombre;
                    db.Update(buscar);
                    db.SaveChanges();
                }
            }
        
        }


     }
}
