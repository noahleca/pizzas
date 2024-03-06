using Pizzeria_Noah.Modelo;
using Pizzeria_Noah.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria_Noah.Controlador
{
    public class Controlador
    {
        Form1 f;
        Repositorio r;
        DateTime horaInici;
        DateTime horaIniciSimulacion;
        List<comanda> listaPedido = new List<comanda>();
        int velocidadSimulacion = 1;

        public Controlador()
        {
            f = new Form1();
            r = new Repositorio();
            LoadListeners();
            horaInici = DateTime.Now;
            LoadData();
            Application.Run(f);
        }
        void LoadListeners()
        {
            f.buttonInici.Click += ButtonInici_Click;
            f.buttonComanda.Click += ButtonComanda_Click;
        }

        private async void ButtonComanda_Click(object sender, EventArgs e)
        {
            if (int.TryParse(f.textBoxIngredients.Text, out int numIngredientes) && numIngredientes >= 0)
            {
                comanda c = new comanda
                {
                    qntIng = numIngredientes
                };
                listaPedido.Add(c);
                await Task.Run(() => r.PrepararPizza(c));
                r.PostComanda(c);
            }
        }

        private void ButtonInici_Click(object sender, EventArgs e)
        {
            string iniciText = f.textBoxSimulats.Text;
            if (!string.IsNullOrEmpty(iniciText) && int.TryParse(iniciText, out int velocidadSimulacion) && velocidadSimulacion > 0)
            {
                this.velocidadSimulacion = velocidadSimulacion;
                horaIniciSimulacion = DateTime.Now;
                LoadTimers();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido mayor a 0.");
            }
        }

        void LoadData()
        {
            f.labelHoraInici.Text = horaInici.ToString("HH:mm:ss");
        }

        void LoadTimers()
        {
            Timer timerReal = new Timer();
            timerReal.Interval = 1000;
            timerReal.Tick += UpdateTempsReal;
            timerReal.Start();

            Timer timerSimulado = new Timer();
            timerSimulado.Interval = 1000 / velocidadSimulacion;
            timerSimulado.Tick += UpdateTempsSimulat;
            timerSimulado.Start();
        }

        private void UpdateTempsReal(object sender, EventArgs e)
        {
            TimeSpan tiempoTranscurrido = DateTime.Now - horaIniciSimulacion;
            f.labelTempsReal.Text = tiempoTranscurrido.ToString(@"hh\:mm\:ss");
        }

        private void UpdateTempsSimulat(object sender, EventArgs e)
        {
            TimeSpan tiempoTranscurrido = DateTime.Now - horaIniciSimulacion;
            TimeSpan tiempoSimulado = TimeSpan.FromSeconds(tiempoTranscurrido.TotalSeconds * velocidadSimulacion);
            f.labelTempsSimulat.Text = tiempoSimulado.ToString(@"hh\:mm\:ss");
        }

        public async void PrepararComanda()
        {
            await Task.Delay(30000);
            
        }
    }
}
