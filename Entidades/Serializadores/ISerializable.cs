﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Serializadores
{
    public interface ISerializable<T>
    {

        bool Serializar(T datos);
        List<T> Deserializar();

    }
}
