using MVVMDemo.Enums;
using MVVMDemo.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMDemo.Models
{
    public class Person : BaseViewModel
    {
        private string nombre;
        private string apellido;
        private string telefono;
        private string email;
        private string direccion;
        private Genre genre;
        private decimal salary;

        public string Nombre
        {
            get => nombre; set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }
        public string Apellido
        {
            get => apellido; set
            {
                apellido = value;
                OnPropertyChanged();
            }
        }
        public string Telefono
        {
            get => telefono; set
            {
                telefono = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get => email; set
            {
                email = value;
                OnPropertyChanged();
            }
        }
        public string Direccion
        {
            get => direccion; set
            {
                direccion = value;
                OnPropertyChanged();
            }
        }



        public Genre Genre
        {
            get { return genre; }
            set 
            { 
                genre = value;
                OnPropertyChanged();
            }
        }



        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }


    }
}
