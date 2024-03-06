using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Noah.Modelo
{
    public class Repositorio
    {
        pizzeriaEntities db;
        public Repositorio()
        {
            DbConnect();
        }
        public void DbConnect()
        {
            db = new pizzeriaEntities();
        }

        public List<comanda> GetComandas()
        {
            return db.comanda.OrderBy(a => a.numCda).ToList();
        }
        public void PostComanda(comanda c)
        {
            db.comanda.Add(c);
            db.SaveChanges();
        }
        public async void PrepararPizza(comanda c)
        {
            await Task.Delay(30000);
            c.massaFeta = true;

            for (int i = 0; i < c.qntIng; i++)
            {
                await Task.Delay(5000);
                c.qntIngPosats++;
            }

            await Task.Delay(450000);
            c.horaFinal = DateTime.Now;
        }
    }
}