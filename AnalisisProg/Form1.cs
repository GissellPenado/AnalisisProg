using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisProg
{
    public partial class Form1 : Form
    {
        List<long> numeros = new List<long>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            btnGenerar.Enabled = false;
            long cant = long.Parse(txtCantidad.Text);

            Random rdn = new Random();
            numeros.Clear();

            Stopwatch sw = new Stopwatch();
            lblTiempoini.Text = "Tiempo de Inicio: " + DateTime.Now.ToString("hh:mm:ss");
            sw.Start();
            for (long i = 0; i < cant; i++)
            {
                numeros.Add(rdn.Next(100, 500000));
            }
            lstDatos.DataSource = null;
            lstDatos.DataSource = numeros;
            sw.Stop();

            lblTiempofin.Text = "Tiempo Fin: " + DateTime.Now.ToString("hh:mm:ss");
            lblDuracion.Text = "Duración: " + sw.ElapsedMilliseconds / 1000 + " segundos";
            btnGenerar.Enabled = true;

        }

        private void btnOrdenarInsertion_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            lblTiempoini.Text = "Tiempo de Inicio: " + DateTime.Now.ToString("hh:mm:ss");
            sw.Start();
            InsertionSort(numeros);
            lstOrdenada.DataSource = null;
            lstOrdenada.DataSource = numeros;
            sw.Stop();
            lblTiempofin.Text = "Tiempo Fin: " + DateTime.Now.ToString("hh:mm:ss");
            lblDuracion.Text = "Duración: " + sw.ElapsedMilliseconds / 1000 + " segundos";
        }

        private void btnOrdenarQuick_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            lblTiempoini.Text = "Tiempo de Inicio: " + DateTime.Now.ToString("hh:mm:ss");
            sw.Start();

            QuickSort(numeros, 0, numeros.Count - 1);

            lstOrdenada.DataSource = null;
            lstOrdenada.DataSource = numeros;
            sw.Stop();
            lblTiempofin.Text = "Tiempo Fin: " + DateTime.Now.ToString("hh:mm:ss");
            lblDuracion.Text = "Duración: " + sw.ElapsedMilliseconds / 1000 + " segundos";
        }

        private void btnBuscarSecuencial_Click(object sender, EventArgs e)
        {
            long valorBuscar = long.Parse(txtBuscar.Text);
            numeros.Sort();
            Stopwatch sw = new Stopwatch();
            lblTiempoini.Text = "Tiempo de Inicio: " + DateTime.Now.ToString("hh:mm:ss");
            sw.Start();

            bool encontrado = BusquedaBinaria(numeros, valorBuscar);

            sw.Stop();
            lblTiempofin.Text = "Tiempo Fin: " + DateTime.Now.ToString("hh:mm:ss");
            lblDuracion.Text = $"Duración: {sw.ElapsedMilliseconds / 1000} segundos | Encontrado: {encontrado}";
        }

        private bool BusquedaSecuencial(List<long> array, long valor)
        {
            foreach (var item in array)
            {
                if (item == valor)
                    return true;
            }
            return false;
        }

        private bool BusquedaBinaria(List<long> array, long valor)
        {
            int izquierda = 0;
            int derecha = array.Count - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;
                if (array[medio] == valor)
                    return true;
                if (array[medio] < valor)
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }
            return false;
        }

        private void InsertionSort(List<long> array)
        {
            for (int i = 1; i < array.Count; i ++)
            {
                long key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        private void QuickSort(List<long> array, int low, int high)
        {
            if (low < high)
            {
                // Particiona el array
                int pivotIndex = Partition(array, low, high);
                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        private int Partition (List<long> array, int low, int high)
        {
            long pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    // Intercambia array[i] y array[j]
                    long temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            // Intercambia array[i + 1] y array[high]
            long temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;
            return i + 1;
        }

        private void btnBuscarBinaria_Click(object sender, EventArgs e)
        {
            long valorBuscar = long.Parse(txtBuscar.Text);
            // Asegurarse de que la lista esté ordenada antes de realizar búsqueda binaria
            numeros.Sort();
            Stopwatch sw = new Stopwatch();
            lblTiempoini.Text = "Tiempo de Inicio: " + DateTime.Now.ToString("hh:mm:ss");
            sw.Start();

            bool encontrado = BusquedaBinaria(numeros, valorBuscar);

            sw.Stop();
            lblTiempofin.Text = "Tiempo Fin: " + DateTime.Now.ToString("hh:mm:ss");
            lblDuracion.Text = $"Duración: {sw.ElapsedMilliseconds / 1000} segundos | Encontrado: {encontrado}";
        }
    }
}
