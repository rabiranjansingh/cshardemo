using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DeleteFiles
{
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
        }


        GetAllFilescs obj = new GetAllFilescs();
        private void Page1_Load(object sender, EventArgs e)
        {
            string path = @"E:\txtfiles\"; 
            obj.printallTxtFIles(path);
            textBox1.Focus();
        }

        int day = 0;
        private void button1_Click(object sender, EventArgs e)
        { 
             
            day = Convert.ToInt32(textBox1.Text);
            Console.WriteLine("---------- " + day);
             
            List<Element> ll= obj.getData();
            Console.WriteLine(ll.Count);


                

            DateTime date1 = System.DateTime.Now.AddDays(-day);
            DateTime date2 = Convert.ToDateTime("01-11-2019 16:55:29");

            TimeSpan diff = date1 - date2;
            double hours = diff.TotalHours;
            Console.WriteLine("\ndays  " + Convert.ToInt32(hours)/24);

            

            // total days  ( from total minute )
            Console.WriteLine("    ");

            if(hours !=0)
            {

                Console.WriteLine("  total hour we get is " + hours);

            }

            // delete   data files from hard  drive 

            if (diff != null)
            {
                Console.WriteLine("diff is null ");
                Console.WriteLine("- - - - - -");
            }

       

            //DateTime inputdate = Convert.ToDateTime(day .ToString()+"-08-2019 12:45:22");

            foreach (var money in ll)   
            {
                //Console.WriteLine("File name  is {0} and date is  is {1}", money.SomeData, money.Date);

                int value = DateTime.Compare(date1, money.Date);

                if (value < 0)
                {
                    Console.Write("date1 is later than date2. \n ");
                    Console.WriteLine("File name  is {0} and date is  is {1}", money.SomeData, money.Date);
                    File.Delete(money.SomeData);


                    break;
                    
                }
            
                //else if (value < 0)
                //    Console.Write("date1 is earlier than date2.  \n");
                //else
                //    Console.Write("date1 is the same as date2.  \n");

            

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
