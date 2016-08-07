using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Application.Helper
{
    public class MapperHelper
    {
        public static void Initialise()
        {
            AdminMapperHelper.Initialise();
            ComumMapperHelper.Initialise();
        }
    }
}