using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.Adapter;

namespace GIR.SIGIMGERENCIAL.Application.Adapter
{
    public static class Adapter
    {
        public static TTarget To<TTarget>(this object source)
            where TTarget : class, new()
        {
            return TypeAdapterFactory.Create().Adapt<TTarget>(source);
        }
    }
}