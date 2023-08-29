using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Bola
    {
        public string cor;
        public string circun;
        public string material;

        public Bola(string cor, string circun, string material)
        {
            this.cor = cor;
            this.circun = circun;
            this.material = material;
        }

        public string GetCor()
        {
            return cor;
        }

        public void SetCor(string novaCor)
        {
            cor = novaCor;
        }
    }
}
