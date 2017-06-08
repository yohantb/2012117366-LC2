﻿using _2012117366_PER.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IAdministradorEquipoRepository AdministradorEquipo { get; }
        IAdministradorLineaRepository AdministradorLinea { get; }
        ICentroAtencionRepository CentroAtencion { get; }
        IClienteRepository Cliente { get; }
        IContratoRepository Contrato { get; }
        IDepartamentoRepository Departamento { get; }
        IDireccionRepository Direccion { get; }
        IDistritoRepository Distrito { get; }
        IEquipoCelularRepository EquipoCelular { get; }
        IEstadoEvaluacionRepository EstadoEvaluacion { get; }
        IEvaluacionRepository Evaluacion { get; }
        ILineaTelefonicaRepository LineaTelefonica { get; }
        IPlanRepository Plan { get; }
        IProvinciaRepository Provincia { get; }
        ITipoEvaluacionRepository TipoEvaluacion { get; }
        ITipoLineaRepository TipoLinea { get; }
        ITipoPagoRepository TipoPago { get; }
        ITipoPlanRepository TipoPlan { get; }
        ITipoTrabajadorRepository TipoTrabajado { get; }
        ITrabajadorRepository Trabajador { get; }
        IVentaRepository Venta { get; }

        int SaveChanges();

    }
}
