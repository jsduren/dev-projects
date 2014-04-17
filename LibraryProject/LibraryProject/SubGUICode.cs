//Written by: Brad Soderman, Josh Duren

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class LibraryForm : Form
    {
        public static DateTime curDateTime;
        private int curPatronIndex;
        private int curItemIndex;

        // Will return the correct type of object for what list the index was selected on
        private int ListBoxIndexSelected(ListBox lstBox){
            var listName = lstBox.Name.ToString();
            var selItem = lstBox.SelectedIndex;
            if (listName == "lstPatrons"){
                return selItem;
            }
            return  selItem;
        }

        //displays the selected patrons information in the text boxes
        private void updatePatronInfo()
        {
            txtBPatronName.Text = patrons[curPatronIndex].displayName();

            //check the type of the patron
            if (patrons[curPatronIndex] is Adult)
            {
                txtBPatronType.Text = "Adult";

                txtBPatronItemsOut.Text = patrons[curPatronIndex].numberofItems.ToString();
            }
            else if (patrons[curPatronIndex] is Child)
            {
                txtBPatronType.Text = "Child";

                txtBPatronItemsOut.Text = patrons[curPatronIndex].numberofItems.ToString();
            }
        }

        private void itemsInitilizerTest()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                    {
                        items.Add(new AdultBook(("Item" + i + j), false, "", new DateTime(dateToday.Value.Year, dateToday.Value.Month, dateToday.Value.Day), new DateTime(dateToday.Value.Year, dateToday.Value.Month, dateToday.Value.Day)));
                    }
                    else if (j == 1)
                    {
                        items.Add(new ChildBook(("Item" + i + j), false, "", new DateTime(dateToday.Value.Year, dateToday.Value.Month, dateToday.Value.Day), new DateTime(dateToday.Value.Year, dateToday.Value.Month, dateToday.Value.Day)));
                    }
                    else if (j == 2)
                    {
                        items.Add(new DVD(("Item" + i + j), false, "", new DateTime(dateToday.Value.Year, dateToday.Value.Month, dateToday.Value.Day), new DateTime(dateToday.Value.Year, dateToday.Value.Month, dateToday.Value.Day)));
                    }
                    else if (j == 3)
                    {
                        items.Add(new VHS(("Item" + i + j), false, "", new DateTime(dateToday.Value.Year, dateToday.Value.Month, dateToday.Value.Day), new DateTime(dateToday.Value.Year, dateToday.Value.Month, dateToday.Value.Day)));
                    }
                }
                
            }
        }

        private void patronInitilizerTest()
        {
            for (int i = 0; i < 10; i++)
            {
               if (i % 2 == 0)
               {
                   patrons.Add(new Adult("Patron" + i, "Last" + i, 0));
               }
               else
               {
                   patrons.Add(new Child("Child" + i, "Last" + i, 0));
               }
            }
        }

        //calls the readFile method in the File class and updates the patrons and the items in the library and enables the advance date button
        private void openFile()
        {
            //itemsInitilizerTest();
            //patronInitilizerTest();
            try
            {
                File.readFile();
                items.Clear();
                items = File.itemsList;
                patrons.Clear();
                patrons = File.patronsList;
                updatePatrons();
                updateItemsLibrary();
                btnAdvDate.Enabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Incorrect File Format. Try Again.");
            }
        }

        //calls the saveFile method in the File class and calls the clearGUI method and disables the advance date button
        private void closeFile()
        {
            //File.itemsList.Clear();
            File.itemsList = items;
            //File.patronsList.Clear();
            File.patronsList = patrons;
            File.saveFile();
            clearGUI();
            btnAdvDate.Enabled = false;
           
        }

        //clears the items from the GUI after it has been saved.
        private void clearGUI()
        {
            lstItemsOverdue.Items.Clear();
            lstItemsCheckedOut.Items.Clear();
            lstPatrons.Items.Clear();
            lstItemsLibrary.Items.Clear();
            txtBItemCheckoutLen.Clear();
            txtBItemStatus.Clear();
            txtBItemTitle.Clear();
            txtBItemType.Clear();
            txtBPatronItemsOut.Clear();
            txtBPatronName.Clear();
            txtBPatronType.Clear();
        }

        //displays the selected item's information in the text boxes
        private void updateItemInfo(Item inputItem)
        {
            txtBItemTitle.Text = inputItem.title;
            if (inputItem.checkedout == false)
            {
                txtBItemStatus.Text = "Checked In";
            }
            else
            {
                txtBItemStatus.Text = "Checked Out";
            }

            //check type of item
            if (inputItem is AdultBook)
            {
                txtBItemType.Text = "Adult Book";
            }
            else if (inputItem is ChildBook)
            {
                txtBItemType.Text = "Child Book";
            }
            else if (inputItem is DVD)
            {
                txtBItemType.Text = "DVD";
            }
            else if (inputItem is VHS)
            {
                txtBItemType.Text = "VHS";
            }
           
           if (inputItem.maxDays() % 7 == 0)
           {
               txtBItemCheckoutLen.Text = (inputItem.maxDays() / 7) + " weeks";
           }
           else
           {
               txtBItemCheckoutLen.Text = inputItem.maxDays() + " days";
           }

           if (inputItem.checkedout)
           {
               dateDue.Value = inputItem.dueDate;
           }
           else
           {
               DateTime tempdate = dateToday.Value;
               tempdate.AddDays(inputItem.maxDays());
               dateDue.Value = tempdate;
           }
        }

        //update the list of patrons 
        private void updatePatrons()
        {
            lstPatrons.Items.Clear();
            foreach (Patron perPatron in patrons)
            {
                if (perPatron is Child)
                {
                    lstPatrons.Items.Add(perPatron.displayName() + "\tChild");
                }
                else
                {
                    lstPatrons.Items.Add(perPatron.displayName() + "\tAdult");
                }
            }
        }

        //updates the list of Items checked out.
        private void updateItemsCheckOut()
        {
            lstItemsCheckedOut.Items.Clear();
            checkedOut.Clear();
            foreach (Item x in items)
            {
                if (x.checkedout && x.whoCheckedOut == patrons[curPatronIndex].displayName())
                {
                    checkedOut.Add(x);
                    lstItemsCheckedOut.Items.Add(x.title + "\t" + x.dueDate);
                }
            }
            if (checkedOut.Count == 0)
            {
                btnCheckIn.Enabled = false;
            }
        }

        //update the Items in the Library
        private void updateItemsLibrary()
        {
            lstItemsLibrary.Items.Clear();
            foreach (Item x in items)
            {
                if (x.checkedout)
                {
                    lstItemsLibrary.Items.Add("X\t" + x.title + "\t" + x.GetType());
                }
                else
                {
                    lstItemsLibrary.Items.Add(" \t" + x.title + "\t" + x.GetType());
                }
            }
        }

        //updates the Items that are in the Overdue list
        private void updateOverdueItems(int daysOfYear)
        {
            
            lstItemsOverdue.Items.Clear();
            foreach (Item x in checkedOut)
            {
                if ((x.dueDate.DayOfYear - daysOfYear) < 0)
                {
                    lstItemsOverdue.Items.Add((daysOfYear - x.dueDate.DayOfYear) + "\t" + x.title);
                }
            }
        }

        //determines the listbox that has been selected.
        private void SelectedIndexChanged(ListBox lstBox){
            var listName = lstBox.Name.ToString();

            if (listName == "lstItemsLibrary"){
                itemLibrarySelected(lstBox);
            } 
            else if (listName == "lstItemsCheckedOut"){
                itemCheckOutSelected(lstBox);
            }
            else if (listName == "lstPatrons"){
                patronSelected(lstBox);
            }
        }

        //sets the index to the selected patron
        private void patronSelected(ListBox lstBox)
        {
            curPatronIndex = ListBoxIndexSelected(lstBox);
            updatePatronInfo();
            updateItemsCheckOut();
            updateOverdueItems(dateToday.Value.DayOfYear);
        }

        // Selecting an item that will be(if not already) checked out
        private void itemLibrarySelected(ListBox lstBox){
            curItemIndex = ListBoxIndexSelected(lstBox);
            btnCheckIn.Enabled = false;
            if (!items[curItemIndex].checkedout)
            {
                btnCheckOut.Enabled = true;
            }
            else
            {
                btnCheckOut.Enabled = false;
            }
            updateItemInfo(items[curItemIndex]);
        }

        // Selecting an item that can be checked in (that is alreayd check out)
        private void itemCheckOutSelected(ListBox lstBox){
            curItemIndex = ListBoxIndexSelected(lstBox);
            btnCheckOut.Enabled = false;
            if (checkedOut[curItemIndex].checkedout){
                btnCheckIn.Enabled = true;
            }
            else{
                btnCheckIn.Enabled = false;
            }
            updateItemInfo(checkedOut[curItemIndex]);
        }

        //updates the number of items in the numberItems textbox
        private void updateNumberPatronItems()
        {
            txtBPatronItemsOut.Text = patrons[curPatronIndex].numberofItems.ToString();
        }

        //when the checkout button gets clicked
        private void btnCheckOutClicked()
        {
            try
            {
                //pass the Item that is being checked out to the Patron class
                Item tempItem = items[curItemIndex];
                if (patrons[curPatronIndex].checkout(ref tempItem)) //curItem is a Item object -- If checkout is Successful
                {
                    updateNumberPatronItems();
                    updateItemsCheckOut();
                    updateItemsLibrary();
                }
                else
                {
                    MessageBox.Show(text: "You are unable to checkout the current item.",
                        caption: "Checkout Failed",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Patron Checkout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //when the button to check in is clicked
        private void btnCheckInClicked()
        {
            checkedOut[curItemIndex].checkin();
            Item tempItem = checkedOut[curItemIndex];
            patrons[curPatronIndex].checkin(ref tempItem); //curItem is a Item object
            updateItemInLibrary(tempItem);
            updateNumberPatronItems();
            updateItemsCheckOut();
            updateItemsLibrary();
            updateOverdueItems(dateToday.Value.DayOfYear);
        }

        //updates a specific item in the Library
        private void updateItemInLibrary(Item inputItem)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].title == inputItem.title)
                {
                    items[i] = inputItem;
                    i = items.Count;
                }
            }
        }

        //Code for when the button to advance the date is clicked
        private void btnAdvancedDayClicked()
        {
            //Increment the date by one
            curDateTime = curDateTime.AddDays(1);
            var today = curDateTime;
            dateToday.Value = today;
            int day365 = today.DayOfYear;
            updateOverdueItems(day365);
        }
    }
}