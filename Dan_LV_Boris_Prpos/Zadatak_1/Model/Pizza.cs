using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1.Model
{
    class Pizza
    {
        public int smallPiza = 200;
        public int mediumPiza = 400;
        public int biggPiza = 600;
        public int salama = 100;
        public int kulen = 150;
        public int kecap = 40;
        public int sunka = 120;
        public int majonez = 40;
        public int paprika = 55;
        public int masline = 61;
        public int origano = 34;
        public int susam = 14;
        public int sir = 84;

        public bool smallPizab;
        public bool mediumPizab;
        public bool biggPizab;
        public bool kulenb;
        public bool kecapb;
        public bool sunkab;
        public bool majonezb;
        public bool paprikab;
        public bool maslineb;
        public bool origanob;
        public bool susamb;
        public bool sirb;

        private bool salamab;

        public bool SalamaB
        {
            get { return salamab; }
            set { salamab = value; }
        }

    }
}
