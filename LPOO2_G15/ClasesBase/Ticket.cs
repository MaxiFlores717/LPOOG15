using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Ticket
    {
        private int TicketNro;

        public int TicketNro1
        {
            get { return TicketNro; }
            set { TicketNro = value; }
        }
        private DateTime FechaHoraEnt;

        public DateTime FechaHoraEnt1
        {
            get { return FechaHoraEnt; }
            set { FechaHoraEnt = value; }
        }
        private DateTime FechaHoraSal;

        public DateTime FechaHoraSal1
        {
            get { return FechaHoraSal; }
            set { FechaHoraSal = value; }
        }
        private int ClienteDNI;

        public int ClienteDNI1
        {
            get { return ClienteDNI; }
            set { ClienteDNI = value; }
        }
        private string Patente;

        public string Patente1
        {
            get { return Patente; }
            set { Patente = value; }
        }
        private int TVCodigo;

        public int TVCodigo1
        {
            get { return TVCodigo; }
            set { TVCodigo = value; }
        }
        private int SectorCodigo;

        public int SectorCodigo1
        {
            get { return SectorCodigo; }
            set { SectorCodigo = value; }
        }
        private double Duracion;

        public double Duracion1
        {
            get { return Duracion; }
            set { Duracion = value; }
        }
        private decimal Tarifa;

        public decimal Tarifa1
        {
            get { return Tarifa; }
            set { Tarifa = value; }
        }
        private decimal Total;

        public decimal Total1
        {
            get { return Total; }
            set { Total = value; }
        }
    }
}
