using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Categoria(int _id, string _desc)
        {
            Id = _id;
            Descripcion = _desc;
        }

        public Categoria() { }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
