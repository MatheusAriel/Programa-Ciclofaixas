using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclofaixas
{
    interface IDAO<T> where T : class
    {
        List<T> ListaTodos();
        void Inserir(T t);
        void Editar(T novo, string Procura);
        void Remover(string procura);
    }
    
}
