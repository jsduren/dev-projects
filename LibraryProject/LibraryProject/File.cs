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
        public static List<Item> itemsList = null;
        public static List<Patron> patronsList = null;

        // Assumed C# will create default constructor and destructor

        public static void readFile()
        {
            string inputstring = null;
            StreamReader data = null;
            Stream myStream = null;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c://";
            openFileDialog1.Filter = "bin files(*.bin)|*bin";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    data = new StreamReader(myStream);
                }
                else
                    throw new Exception("streamReader problem");
            }

            itemsList = new List<Item>();
            // populate items list
            try
            {
                string star = data.ReadLine();
                if (star != "*")
                    throw new FileLoadException("No Star found");
                do
                {
                    inputstring = data.ReadLine();
                    if (inputstring != "**")
                    {
                        string title = inputstring;
                        string category = data.ReadLine();
                        string whoCheckedout = data.ReadLine();
                        string tempInt = data.ReadLine();
                        bool checkStatus = (tempInt == "1") ? true : false;

                        // read in checkedout date
                        string time = data.ReadLine();
                        DateTime checkedOut = DateTime.Parse(time);

                        //read in duedate
                        time = data.ReadLine();
                        DateTime dueDate = DateTime.Parse(time);

                        // create a items object and push
                        // need items constructor
                        if (category == "AdultBook")
                        {

                            AdultBook temp = new AdultBook(title, checkStatus, whoCheckedout, checkedOut, dueDate);
                            itemsList.Add(temp);
                        }
                        else if (category == "ChildBook")
                        {
                            ChildBook temp = new ChildBook(title, checkStatus, whoCheckedout, checkedOut, dueDate);
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
                        else
                            throw new FileLoadException("invalid file");

                    }
                } while (inputstring != "**");
  
            patronsList = new List<Patron>();

                do
                {
                    inputstring = data.ReadLine();
                    if (inputstring == "***")
                        break;

                    string fname = inputstring;
                    string lname = data.ReadLine();
                    string category = data.ReadLine();
                    string numItems = data.ReadLine();

                    if (category == "Adult")
                    {
                        Adult temp = new Adult(fname, lname, int.Parse(numItems));
                        patronsList.Add(temp);
                    }
                    else
                    {
                        Child temp = new Child(fname, lname, int.Parse(numItems));
                        patronsList.Add(temp);
                    }

                } while (inputstring != "***");

                MessageBox.Show("File Loaded!!");
            }
            catch (Exception e)
            {
                data.Close();
                throw new FileLoadException("Unable to Load");
            }
            finally
            {
                myStream.Close();
            }

        }


        public static void saveFile()
        {
            //Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Bin Files | *.bin"; 
            saveFileDialog1.FilterIndex = 2 ;
            saveFileDialog1.RestoreDirectory = true ;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                writer.WriteLine("*");
                 // Code to write the stream goes here.
                foreach(Item i in itemsList)
                {
                    writer.WriteLine(i.title); //write title
                    string tempCategory;
                    if (i is AdultBook)
                        tempCategory = "AdultBook";
                    else if (i is ChildBook)
                        tempCategory = "ChildBook";
                    else if (i is DVD)
                        tempCategory = "DVD";
                    else if (i is VHS)
                        tempCategory = "VHS";
                    else
                        throw new FieldAccessException("Category is incorrect");
                    writer.WriteLine(tempCategory); //write category

                    writer.WriteLine(i.whoCheckedOut); // who checked it out
                    
                    int temp = (i.checkedout) ? 1 : 0;
                    writer.WriteLine(temp);             // checkout boolean writeout
                    
                    writer.WriteLine(i.checkDate.ToString());
                    writer.WriteLine(i.dueDate.ToString());
                }
                writer.WriteLine("**"); // signals end of items list
                foreach (Patron i in patronsList)
                {
                    string fullname = i.displayName();
                    string[] splitNames = fullname.Split();
                    string numItems = i.numberofItems.ToString();
                    //write first name
                    writer.WriteLine(splitNames[0]);
                    // write last name
                    writer.WriteLine(splitNames[1]);
                    if (i is Adult)
                        writer.WriteLine("Adult");
                    else
                        writer.WriteLine("Child");
                    writer.WriteLine(numItems);
                 }
                writer.WriteLine("***"); // signals end of patrons list


                    writer.Close();
                    MessageBox.Show("File Saved succesfully!");
            }
     

        }



    }
}
