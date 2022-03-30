﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.Tp1.Interface
{
    public interface ITransportePublico
    {
        string Avanzar();

        string Detenerse();

        string AnunciarCantidadPasajeros(int numeroPasajeros);

        string AnunciarFormasDePagoAceptadas();
    }
}
