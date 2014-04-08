using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // streams


namespace LibraryProject
{
    class File
    {
        public List<Item> itemsList;
        public List<Patron> patronsList;

    
        /// <summary>
        /// readFile function
        /// 
        /// </summary>
        /// <param name="mystream">Stream element passed from forum</param>
    
        public void readFile()
        {
            string inputstring = null;
            StreamReader data = null;
            Stream myStream = null;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c://";
            openFileDialog1.Filter = "text files(*.txt)|*txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    data = new StreamReader(myStream);
                }
            }

            // populate items list
            do
            {
                inputstring = data.ReadLine();
                if (inputstring != "**")
                {
                    string title = inputstring;
                    string category = data.ReadLine();
                    
                    // read in checkedout date
                    DateTime checkedOut = DateTime.Parse(data.ReadLine());

                    //read in duedate
                    DateTime dueDate = DateTime.Parse(data.ReadLine());
                   
                    // create a items object and push to list
                    // need items constructor

                    //read in next line to check if at end of items list

                    inputstring = data.ReadLine();

                }
            } while (inputstring != null);
        }

        public void saveFile(string filename)
        {
            // take each item and patron and save them to a file

            // path variable can be replaced with a savedialog
            string enviromentPath = "C:\\Users\\Ikani\\Desktop\\";
            string path = enviromentPath + filename + ".xml";
            
            foreach(Item i in itemsList)
            {

            }

            foreach(Patron i in patronsList)
            {

            }

     

        }



    }
}
