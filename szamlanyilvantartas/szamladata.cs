using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace szamlanyilvantartas
{
    internal class szamladata
    {
        int id;
        string tulajnev;
        int egyenleg;
        DateTime datum;

        public int Id { get => id; set => id = value; }
        public string Tulajnev { get => tulajnev; set => tulajnev = value; }
        public int Egyenleg { get => egyenleg; set => egyenleg = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        public szamladata(int id, string tulajnev, int egyenleg, DateTime datum)
        {
            Id = id;
            Tulajnev = tulajnev;
            Egyenleg = egyenleg;
            Datum = datum;
        }

        public override string ToString()
            {
            return tulajnev + " " + Egyenleg+" "+datum;
            }
    }
}
