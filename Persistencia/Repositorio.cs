using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP6.Modelo;

namespace TP6.Persistencia
{
    public class Repositorio : IRepositorio
    {
        private static List<Producto> _productos = new List<Producto>();
        public Repositorio()
        {
            _productos = ObtenerProductosPrecargados();
        }

        public void AgregarProducto(Producto p)
        {
            _productos.Add(p);
        }

        public bool EliminarProducto(int codigo)
        {
            Producto borrar = _productos.First(x => x.Codigo == codigo);

            if(borrar != null)
            {
                _productos.Remove(borrar);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Producto> ObtenerProductosPrecargados()
        {
            return new List<Producto>{
            new Producto(12345, "Coca Cola 3lt", 100, 50, mg: 1),
            new Producto(12321, "Galletas Pepitos", 120, pf: 200, 35),
            new Producto(10101, "Galletas Oreo", 200, 20, mg: 0.8),
            new Producto(11111, "Oblea Tita", 700, 5, mg: 2),
            new Producto(42024, "Chocolate Cofler", 500, pf: 501, 42),
            new Producto(99999, "Alfajor Grandote", 50, 300, mg: 0.5),
            new Producto(10000, "Mentitas", 20, pf: 300, 200)
            };
        }

        public Producto ObtenerProductoPorCodigo(int codigo)
        {
            return _productos?.First(x => x.Codigo == codigo);
        }

        public List<Producto> ObtenerProductos()
        {
           return _productos;
        }

        public bool VerificarCodigo(int codigo)
        {
            return !_productos.Any(x => x.Codigo == codigo); 
        }
    }
}
