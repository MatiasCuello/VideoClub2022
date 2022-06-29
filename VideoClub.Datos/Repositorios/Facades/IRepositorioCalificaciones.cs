﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEntidades.Entidades;

namespace VideoClub.Datos.Repositorios.Facades
{
    public interface IRepositorioCalificaciones
    {
        List<Calificacion> GetCalificacion();
        void Guardar(Calificacion calificacion);
        void Borrar(int id);
        bool Existe(Calificacion calificacion);
        Calificacion GetCalificacionPorId(int id);
    }
}
