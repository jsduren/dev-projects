using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // streams


namespace LibraryProject
{
    static class File
    {
        public List<Item> itemsList;
        public List<Patron> patronsList;


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
                    string whoCheckedout = data.ReadLine();
                    int tempInt = int.Parse(data.ReadLine());
                    bool checkStatus = (tempInt == 1) ? true : false;
                    
                    // read in checkedout date
                    DateTime checkedOut = DateTime.Parse(data.ReadLine());

                    //read in duedate
                    DateTime dueDate = DateTime.Parse(data.ReadLine());
                   
                    // create a items object and push
                    // need items constructor
                    if (category == "AdultBook")
                    {
                        AdultBook temp = new AdultBook(title,checkStatus, whoCheckedout, checkedOut, dueDate);
                        itemsList.Add(temp);
                    }
                    else if(category == "ChildBook")
                    {
                        ChildBook temp = new ChildBook(title, checkStatus, whoCheckedout,checkedOut, dueDate);
                        itemsList.Add(temp);
                    }
                    else if (category == "DVD")
                    {
                        DVD temp = new DVD(title, checkStatus, whoCheckedout, checkedOut, dueDate);
                        itemsList.Add(temp);
                    }
                    else if (category == "VHS")
                    {
                        VHS temp = new VHS(title, checkStatus, whoCheckedout, checkedOut, dueDate);
                        itemsList.Add(temp);
                    }

                    //read in next line to check if at end of items list
                    inputstring = data.ReadLine();

                }
            } while (inputstring != null);
        }

        public void saveFile()
        {
            Stream myStream ;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"  ;
            saveFileDialog1.FilterIndex = 2 ;
            saveFileDialog1.RestoreDirectory = true ;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }


            foreach(Item i in itemsList)
            {

            }

            foreach(Patron i in patronsList)
            {

            }

     

        }



    }
}
