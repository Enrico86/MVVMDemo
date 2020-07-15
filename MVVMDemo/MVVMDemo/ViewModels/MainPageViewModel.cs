using MVVMDemo.Enums;
using MVVMDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMDemo.ViewModels
{
    public class MainPageViewModel
    {
        public Person CurrentPerson { get; set; }
        //Propiedad de tipo Person que pretendemos sea el origen de datos del DataBinding
        public Person CurrentPerson2 { get; set; }

        public MainPageViewModel()
        {
            LoadData();
            //Cargamos los datos que hemos definido en este método LoadData para que las propiedades del objeto Person que
            //hemos llamado CurrentPerson tengan unos valores. De esta manera cuando hagamos el binding entre esta propiedad y 
            //los campos de la MainPage, en estos campos deberían verse reflejado estos valores.

        }



        public void LoadData()
        {
            ///Simulando una conexión a un WebService
            CurrentPerson = new Person()
            {
                Nombre = "Enrico",
                Apellido = "Nocher",
                Telefono = "624988874",
                Email = "test.enri@prueba.com",
                Direccion = "GranVia de les Corts Catalanes 752, 4-5",
                Genre = Genre.Male
            };

            CurrentPerson2 = new Person()
            {
                Nombre = "Angelo",
                Apellido = "Nocher",
                Telefono = "614589587",
                Email = "test.angelo@prueba.com",
                Direccion = "Torino",
                Genre = Genre.Male
            };
        }
    }
}
