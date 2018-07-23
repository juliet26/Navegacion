using Navegacion.ViewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Navegacion.Model
{
    public class Usuario : NotificableIncidencia
    {
        #region Atributos
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        private string identificacion;
        private string nombres;
        private string apellidos;
        private string cargo;
        private string area;
        private string sede;
        private string correo;
        private string password;
        #endregion

        #region Propiedades
        public string Identificacion
        {
            get { return identificacion; }
            set { SetValue(ref identificacion, value); }
        }
        public string Nombres
        {
            get { return nombres; }
            set { SetValue(ref nombres, value); }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { SetValue(ref apellidos, value); }
        }
        public string Cargo
        {
            get { return cargo; }
            set { SetValue(ref cargo, value); }
        }
        public string Area
        {
            get { return area; }
            set { SetValue(ref area, value); }
        }
        public string Correo
        {
            get { return correo; }
            set { SetValue(ref correo, value); }
        }
        public string Sede
        {
            get { return sede; }
            set { SetValue(ref sede, value); }
        }

        public string Password
        {
            get { return password; }
            set { SetValue(ref sede, password); }
        }

        #endregion
    }
}
