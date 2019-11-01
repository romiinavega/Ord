using System;
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
using System.Collections.ObjectModel;

namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> miLista = new ObservableCollection<int>();
        ObservableCollection<Alumno> alumno = new ObservableCollection<Alumno>();

        public MainWindow()
        {
            InitializeComponent();
            miLista.Add(58);
            miLista.Add(35);
            miLista.Add(20);
            miLista.Add(16);
            miLista.Add(14);
            miLista.Add(12);
            miLista.Add(60);
            miLista.Add(4);


            alumno.Add(new Alumno("Jose", 9.1f, 2));
            alumno.Add(new Alumno("Juan", 8.1f, 2));
            alumno.Add(new Alumno("Lucia", 10f, 2));
            alumno.Add(new Alumno("Pedro", 5.6f, 2));
            alumno.Add(new Alumno("Ana", 9.4f, 4));
            alumno.Add(new Alumno("Maria", 8.9f, 3));
            alumno.Add(new Alumno("Marian", 9.2f, 5));
            alumno.Add(new Alumno("Romina con honores", 11f, 7));




            lstNumeros.ItemsSource = miLista;
        }

        private void btnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            /*var temp = miLista[0];
            miLista[0] = miLista[3];
            miLista[3] = temp;*/

            int gap, temp, i;
            gap = miLista.Count / 2;
            
            while(gap > 0)
            {
                for(i=0; i<miLista.Count; i++)
                {
                    if(gap + i < miLista.Count && miLista[i] > miLista[gap + i])
                    {
                        temp = miLista[i];
                        miLista[i] = miLista[gap + i];
                        miLista[gap + i] = temp;

                    }
                }

                gap--;
            }
        }

        private void btnOrdenar_Bubble_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;

            do
            {
                intercambio = false;
                for(int i=0; i<miLista.Count-1; i++)
                {
                    if(miLista[i]>miLista[i+1])
                    {
                        int temp = miLista[i];
                        miLista[i] = miLista[i+1];
                        miLista[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);

        }
    }
}
