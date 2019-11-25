using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteFiles
{
    class Element
    {
        DateTime date;
        String fileName;

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string SomeData
        {
            get
            {
                return fileName;
            }

            set
            {
                fileName = value;
            }
        }
    }
}
