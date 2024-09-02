using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBaseDeDatosLibrosBueno
{
    public interface IGestor<T>
    {
        void agregar(T item);
        void eliminar(T item);
        T buscar(int id);
        void actualizar(T item);
        IEnumerable<T> buscarTodos();
    }
}
