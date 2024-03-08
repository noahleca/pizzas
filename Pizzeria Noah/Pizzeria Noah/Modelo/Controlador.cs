﻿using Pizzeria_Noah.Modelo;
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

        int HACER_MASA = 30000;
        int PONER_INGREDIENTE = 5000;
        int COCINAR_PIZZA = 450000;

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
            DateTime now = DateTime.Now;
            HACER_MASA = 30000 / velocidadSimulacion;
            PONER_INGREDIENTE = 5000 / velocidadSimulacion;
            COCINAR_PIZZA = 450000 / velocidadSimulacion;
            if (int.TryParse(f.textBoxIngredients.Text, out int numIngredientes) && numIngredientes >= 0)
            {
                comanda c = new comanda
                {
                    horaCda = now,
                    qntIng = numIngredientes
                };
                r.PostComanda(c);
                PrepararComanda(c);
                f.dataGridView.DataSource = r.GetComandas(horaInici);

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
                f.buttonInici.Enabled = false;
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

        public async void PrepararComanda(comanda c)
        {
            string tiempoLabel = f.labelTempsSimulat.Text;
            TimeSpan tiempoSimuladoInicial = TimeSpan.ParseExact(tiempoLabel, @"hh\:mm\:ss", null);

            await Task.Delay(HACER_MASA);
            c.massaFeta = true;
            r.UpdateComanda(c);
            f.dataGridView.DataSource = r.GetComandas(horaInici);

            for (int i = 0; i < c.qntIng; i++)
            {

                await Task.Delay(PONER_INGREDIENTE);
                c.qntIngPosats++;
                r.UpdateComanda(c);
                f.dataGridView.DataSource = r.GetComandas(horaInici);

            }

            await Task.Delay(COCINAR_PIZZA);
            DateTime? inicioPedido = c.horaCda;

            tiempoLabel = f.labelTempsSimulat.Text;

            TimeSpan tiempoSimuladoFinal = TimeSpan.ParseExact(tiempoLabel, @"hh\:mm\:ss", null);


            TimeSpan tiempoTranscurrido = tiempoSimuladoFinal - tiempoSimuladoInicial;

            DateTime? horaFinalPedido = inicioPedido + tiempoTranscurrido;
            c.horaFinal = horaFinalPedido;
            r.UpdateComanda(c);
            f.dataGridView.DataSource = r.GetComandas(horaInici);


        }
    }
}
