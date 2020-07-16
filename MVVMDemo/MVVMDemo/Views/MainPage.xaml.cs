using MVVMDemo.Models;
using MVVMDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            //Binding binding = new Binding();
            ////Primero instanciamos un objeto de la clase Binding, que será el enlace de la primera propiedad de CurrentPerson
            //binding.Source = CurrentPerson;
            ////El primer paso será asignar un origen (a través de la propiedad Source) a este binding. Y dado que los datos
            ////que queremos mostrar en la MainPage son las propiedades del objeto CurrwentPerson, el origen será este objeto.
            //binding.Path = "Nombre";
            ////Con esta línea de código estamos especificando la ruta del binding. Es decir, anteriormente le hemos dicho que 
            ////el origen del enlace es con la propiedad CurrentPerson, y ahora estamos diciendole que propiedad en especifico 
            ////queremos que coja. Tiene que ser un string y tiene que ser exactamente igual al nombre de la propiedad de 
            ////CurrentPerson
            //nombreEntry.SetBinding(Entry.TextProperty, binding);
            ////Por último la tercera pieza del binding, el destino. Para poder especificar el destino tenemos que invocar
            ////el método SetBinding a través del control de la interfaz gráfica al que queremos enlazar la propiedad. En este 
            ////caso queremos que el destino sea una de las propiedades del control nombreEntry (un Entry que hemos diseñado en la
            ////interfaz gráfica). El método SetBinding requiere dos parametros: primero la BindableProperty que queremos enlazar,
            ////es decir, a que propiedad del control nombreEntry queremos enlazar. Y en este caso queremos enlazar a la propiedad
            ////TextProperty del control nombreEntry que pertenece a la clase Entry). Y como segundo parametro tenemos que definir 
            ////cual es el objeto de la clase Binding que estamos seteando, y en este caso es el objeto que habíamos llamado binding 
            ////que tenía cómo origen la propiedad Nombre de CurrentPerson.

            //Binding binding2 = new Binding();
            //binding2.Source = CurrentPerson;
            //binding2.Path = "Apellido";
            //apellidoEntry.SetBinding(Entry.TextProperty, binding2);
            ////Vamos a crear los demás Bindings de las demás propiedades de CurrentPerson que queremos enlazar con los demás controles
            ////de la Interfaz Gráfica.

            //Binding binding3 = new Binding();
            //binding3.Source = CurrentPerson;
            //binding3.Path = "Telefono";
            //telefonoEntry.SetBinding(Entry.TextProperty, binding3);

            //Binding binding4 = new Binding();
            //binding4.Source = CurrentPerson;
            //binding4.Path = "Email";
            //emailEntry.SetBinding(Entry.TextProperty, binding4);

            //Binding binding5 = new Binding();
            //binding5.Source = CurrentPerson;
            //binding5.Path = "Direccion";
            //direccionEntry.SetBinding(Entry.TextProperty, binding5);

        }
        protected override void OnAppearing()
        {
            MainPageViewModel vm = new MainPageViewModel(Navigation);
            base.OnAppearing();
            vm.LoadData();
            BindingContext = vm;
        }

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    //    CurrentPerson.Nombre = "Juan";
        //    //    CurrentPerson.Telefono = "000000000";
        //    //    CurrentPerson.Email = "ejemplo@ejemplo.com";
        //    //    CurrentPerson.Apellido = "La Prueba";
        //    //    CurrentPerson.Direccion = "Gran Via de la Prueba 999";

        //    //    CurrentPerson2.Nombre = "EjemploPropertyChanged";

        //}
    }
}
