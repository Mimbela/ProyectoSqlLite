using ProyectoSqlLite.Base;
using ProyectoSqlLite.Models;
using ProyectoSqlLite.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProyectoSqlLite.ViewModels
{
    public class RazaModel : ViewModelBase
    {
        RepositoryRazas repo;
        public RazaModel()
        {
            this.repo = new RepositoryRazas();
            this.Raza = new Raza();
        }

        public Command InsertarRaza
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.InsertarRaza(this.Raza.Codigo,
                        Raza.Nombre, Raza.Caracteristicas
                        );
                });
            }
         }

        public Command ModificarRaza
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.ModificarRaza(this.Raza.Codigo,
                        Raza.Nombre, Raza.Caracteristicas
                        );
                });
            }
        }

        public Command EliminarRaza
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.EliminarRaza(this.Raza.Codigo
                        );
                });
            }
        }

        private Raza _Raza;
        public Raza Raza
        {
            get { return this._Raza; }
            set
            {
                this._Raza = value;
                OnPropertyChanged("Raza");
            }
        }
    }
}
