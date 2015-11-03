using System;
using ejercicio01.MiBD;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace ejercicio01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //instanciar bd

           // if (Regex.IsMatch(txtId.Text, @"^\d+$") && Regex.IsMatch(txtSueldo.Text, @"^\d+$"))
          //  {
                demoEF db = new demoEF();
                Empleado emp = new Empleado();
                emp.Nombre = txtNombre.Text;
                emp.Sueldo = int.Parse(txtSueldo.Text);

                db.Empleados.Add(emp);
                db.SaveChanges();
          //  }
         //   else
        //    {

         //       MessageBox.Show("No texto");
         //   }

        }




        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(txtId.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();
                int id = int.Parse(txtId.Text);
                var emp = db.Empleados
                             .SingleOrDefault(x => x.id == id);

                if (emp != null)
                {
                    db.Empleados.Remove(emp);
                    db.SaveChanges();

                }
            }
            else
            {
                MessageBox.Show("Solo numeros #id");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            demoEF db = new demoEF();
            int id = int.Parse(txtId.Text);
            var emp = db.Empleados
                        .SingleOrDefault(x => x.id == id);

            /* if(Empleado != null){
               emp.Nombre=txtNombre.Text;
               emp.Sueldo*/
        }

        private void btbverID_Click(object sender, RoutedEventArgs e)
        {
            demoEF db = new demoEF();
            int id = int.Parse(txtId.Text);
            var registros = from s in db.Empleados

                            select new
                            {
                                s.Nombre,
                                s.Sueldo
                            };
        }

        private void btnverTodos_Click(object sender, RoutedEventArgs e)
        {
            demoEF db = new demoEF();
            int id = int.Parse(txtId.Text);
            var registros = from s in db.Empleados

                            select s;

            dbGrid.ItemsSource = registros.ToList();



        }


    }
       
}
