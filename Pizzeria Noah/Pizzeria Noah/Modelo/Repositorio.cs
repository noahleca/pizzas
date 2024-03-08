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

        public List<comanda> GetComandas(DateTime data)
        {
            return db.comanda.Where(a => a.horaCda >= data).OrderBy(a => a.numCda).ToList();
        }
        public void PostComanda(comanda c)
        {
            db.comanda.Add(c);
            db.SaveChanges();
        }
        public void UpdateComanda(comanda c)
        {
            var comanda = db.comanda.FirstOrDefault(p => p.numCda == c.numCda);
            if (comanda != null)
            {
                comanda.massaFeta = c.massaFeta;
                comanda.qntIngPosats = c.qntIngPosats;
                comanda.horaFinal = c.horaFinal;

                db.SaveChanges();
            }

        }
    }
}