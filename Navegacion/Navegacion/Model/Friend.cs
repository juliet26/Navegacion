using Navegacion.ViewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Navegacion.Model
{
    public class Friend : NotificableFriend
    {
        #region Atributos
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        private string nombre;
        private string telefono;
        private string email;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { SetValue(ref nombre, value); }
        }

        public string Telefono
        {
            get { return telefono; }
            set { SetValue(ref telefono, value); }
        }

        public string Email
        {
            get { return email; }
            set { SetValue(ref email, value); }
        }
        #endregion
    }
}
