using Practica.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Bases
{
    public interface ILogic <T,TId>
    {
        List<T> GetAll();
        string Add(T aux);
        string Update(T aux);

        string Delete(TId aux);

    }
}
