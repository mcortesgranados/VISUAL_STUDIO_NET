using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCO_VSNET_CSHARP_001.PruebaTecnica
{
    public class Alcancia
    {
        public List<Denominacion> l_denominaciones;
        public List<Moneda> l_monedas;

        

        public void agregarDenominacion(Denominacion denominacion)
        {
            l_denominaciones.Add(denominacion);
        }

        public Alcancia()
        {
            l_denominaciones = new List<Denominacion>();
            l_monedas = new List<Moneda>();
        }

        
    }

    public class Denominacion
    {
        private String nombreDenominacion;

        public Denominacion(string nombreDenominacion)
        {
            this.nombreDenominacion = nombreDenominacion;
        }

        public void setNombreDenominacion(String nombreDenominacion)
        {
            this.nombreDenominacion = nombreDenominacion;
        }

        public String getNombreDenominacion()
        {
            return this.nombreDenominacion;
        }
    }

    public class Moneda
    {
        Denominacion denominacion;

        public Moneda(Denominacion denominacion)
        {
            this.denominacion = denominacion;
        }
    }

}