using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpzh
{
    internal class NGC
    {
        //1=átlagos, 2=optimista, 3=pesszimista 
        public int type { get; set; }
        public float happines { get; set; }

        public NGC()
        {
            Random random = new Random();
            float rnd = (float)(random.NextDouble()*10);
            if (rnd <= 6.7)
            {
                this.type = 1;
            }
            else if (rnd > 6.7 && rnd <= 8.7)
            {
                this.type = 2;
            }
            else
            {
                this.type = 3;
            }

            switch (type)
            {
                case 1:
                    this.happines = (float)(random.NextDouble()*100);
                    break;
                case 2:
                    this.happines = (float)(60 + random.NextDouble() * 40);
                    break;
                case 3:
                    this.happines = (float)(random.NextDouble() * 20);
                    break;
            }
        }
    }
}
