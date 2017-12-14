using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoServices
{
    public class CursoServices
    {
        public void FindAll()
        {
            new CursoDataAccess.CursoDataAcess().FindAll();
        }
    }
}
