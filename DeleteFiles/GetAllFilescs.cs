using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteFiles
{
    class GetAllFilescs
    {
         List<Element> list_with_name_and_date;
        public   void printallTxtFIles(string url )
        {

            try
            {

                // What directory are the files in?...

                DirectoryInfo dinfo = new DirectoryInfo(url);
                // What type of file do we want?...

                FileInfo[] Files = dinfo.GetFiles("*.txt");
                // Iterate through each file, displaying only the name inside the listbox...


                int i = 0;
                list_with_name_and_date = new List<Element>();

                Element el; 
                
              
                foreach (FileInfo file in Files)
                {
                    // Console.WriteLine(" ---  " + file.FullName);

                    el = new Element();

                    el.Date = Convert.ToDateTime(System.IO.File.GetLastWriteTime(file.FullName).ToString("dd/MM/yy HH:mm:ss"));
                    el.SomeData = file.FullName;


                    list_with_name_and_date.Add(el);
                    string files_name = file.FullName;

                    i++;
                    //sString.Format("[{0, 10}]", "Foo    ");
                  //  Console.WriteLine(files_name+"                               |   "+  Convert.ToDateTime(System.IO.File.GetLastWriteTime(file.FullName).ToString("dd/MM/yy HH:mm:ss")));
                }

                Console.WriteLine("--- count --- " + i.ToString());


                DateTime date1 = Convert.ToDateTime("08-08-2019 12:45:22");
                DateTime date2 = Convert.ToDateTime("01-11-2019 16:55:29");

                int value = DateTime.Compare(date1, date2);

                // checking 
                if (value > 0) 
                    Console.Write("date1 is later than date2. ");
                else if (value < 0)
                    Console.Write("date1 is earlier than date2. ");
                else
                    Console.Write("date1 is the same as date2. ");
                

                TimeSpan diff = date2 - date1;
                double hours = diff.TotalHours;
                Console.WriteLine("\nhour " + Convert.ToInt32(hours)/24);



            }
            catch (IOException e)
            {
                Console.WriteLine(
                    "{0}: The write operation could not " +
                    "be performed because the specified " +
                    "part of the file is locked.",
                    e.GetType().Name);

                throw new System.ArgumentException("Parameter cannot be null", "original");
            }

        }//printallTxtFIles(string url )


        public  List<Element> getData()
        {

            Console.WriteLine("size in  class " + list_with_name_and_date.Count);

            return list_with_name_and_date;
        }



    }
}
