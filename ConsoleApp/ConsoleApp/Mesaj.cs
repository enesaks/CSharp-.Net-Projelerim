using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Mesaj
    {
        public String mesj;
        private String msjSahibi;
        
        public Mesaj(String name)
        {
            this.msjSahibi = name;

        }


        public void Mesajlar()
        {
            Console.WriteLine(this.msjSahibi  + " : " + this.mesj);
        }

    }
}
