using Navegacion.ViewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Navegacion.Model
{
    public class Incidencia : NotificableIncidencia
    {

        #region Atributos
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        private int usuario;
        private DateTime fecha = new DateTime();
        private string area;
        private String observaciones;
        #endregion

        #region Propiedades
        public int Usuario
        {
            get { return usuario; }
            set { SetValue(ref usuario, value); }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { SetValue(ref fecha, value); }
        }

        public string Area
        {
            get { return area; }
            set { SetValue(ref area, value); }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { SetValue(ref observaciones, value); }
        }
        #endregion
        
    }
}
