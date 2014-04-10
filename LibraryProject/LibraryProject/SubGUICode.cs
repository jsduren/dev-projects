using System;
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
        private Patron curPatron;
        private Item curItem;

        // Will return the correct type of object for what list the index was selected on
        private Object ListBoxIndexSelected(ListBox lstBox){
            var listName = lstBox.Name.ToString();
            var selItem = lstBox.SelectedIndex;
            if (listName == "lstPatrons"){
                return patrons[selItem];
            }
            return  items[selItem];
        }

        //displays the selected patrons information in the text boxes
        private void updatePatronInfo()
        {
            txtBPatronName.Text = curPatron.displayName();

            //check the type of the patron
            if (curPatron is Adult)
            {
                txtBPatronType.Text = "Adult";
             
                txtBPatronItemsOut.Text = curPatron.numberofItems.ToString();
            }
            else if (curPatron is Child)
            {
                txtBPatronType.Text = "Child";
               
                txtBPatronItemsOut.Text = curPatron.numberofItems.ToString();
            }
        }

        //      THESE WERE BEING USED BEFORE THERE WAS A NUMBER OF ITEMS BEING HELD BY THE PATRON
        //calculates the number of items in the Adult AdultItems array
        //private int calculateNoItems(int maxItems, Adult theAdult)
        //{
        //    int patronItemCount = 0;
        //    for (int i = 0; i < maxItems; i++)
        //    {
        //        if (theAdult.adultArray[i] != null)
        //        {
        //            patronItemCount++;
        //        }
        //    }
        //    return patronItemCount;
        //}

        //calculates the number of items in the Child ChildBooks array
        //private int calculateNoItems(int maxItems, Child theChild)
        //{
        //    int patronItemCount = 0;
        //    for (int i = 0; i < maxItems; i++)
        //    {
        //        if (theChild.childArray[i] != null)
        //        {
        //            patronItemCount++;
        //        }
        //    }
        //    return patronItemCount;
        //}
        

        //displays the selected item's information in the text boxes
        private void updateItemInfo()
        {
            txtBItemTitle.Text = curItem.title;
            if (curItem.checkedout == false)
            {
                txtBItemStatus.Text = "Checked In";
            }
            else
            {
                txtBItemStatus.Text = "Checked Out";
            }

            //check type of item
            if (curItem is AdultBook)
            {
                txtBItemType.Text = "Adult Book";
                txtBItemCheckoutLen.Text = "2 Weeks";
                dateDue.Value = curItem.dueDate;
              
            }
            else if (curItem is ChildBook)
            {
                txtBItemType.Text = "Child Book";
                txtBItemCheckoutLen.Text = "1 Week";
                dateDue.Value = curItem.dueDate;
              
            }
            else if (curItem is DVD)
            {
                txtBItemType.Text = "DVD";
                txtBItemCheckoutLen.Text = "2 days";
                dateDue.Value = curItem.dueDate;
            }
            else if (curItem is VHS)
            {
                txtBItemType.Text = "VHS";
                txtBItemCheckoutLen.Text = "3 days";
                dateDue.Value = curItem.dueDate;
            }
        }

        private void updateItemsCheckOut()
        {
            lstItemsCheckedOut = checkedOut;
        }

        private void updateItemsLibrary()
        {
            lstItemsLibrary = items;
        }

        //Josh is this still necessary? -Brad
        private void updateOverdueItems()
        {
            foreach (var item in lstItemsCheckedOut)
            {
                if (item.dueDate > dateToday.Value)
                {
                    
                }
                //lstItemsOverdue. item;
            }
            
        }

        private void SelectedIndexChanged(ListBox lstBox){
            var listName = lstBox.Name.ToString();

            if (listName == "lstItemsLibrary"){
                itemLibrarySelected(lstBox);
            } 
            else if (listName == "lstItemsCheckedOut"){
                itemCheckOutSelected(lstBox);
            }
            else if (listName == "listPatrons"){
                patronSelected(lstBox);
            }
        }

        private void patronSelected(ListBox lstBox)
        {
            curPatron = (Patron)ListBoxIndexSelected(lstBox);
            updatePatronInfo();
        }

        // Selecting an item that will be(if not already) checked out
        private void itemLibrarySelected(ListBox lstBox){
            curItem = (Item)ListBoxIndexSelected(lstBox);
            btnCheckIn.Enabled = false;
            if (!curItem.checkedout)
            {
                btnCheckOut.Enabled = true;
            }
            else
            {
                btnCheckOut.Enabled = false;
            }
            updateItemInfo();
        }

        // Selecting an item that can be checked in (that is alreayd check out)
        private void itemCheckOutSelected(ListBox lstBox){
            curItem = (Item)ListBoxIndexSelected(lstBox);
            btnCheckOut.Enabled = false;
            if (curItem.checkedout){
                btnCheckIn.Enabled = true;
            }
            else{
                btnCheckIn.Enabled = false;
            }
            updateItemInfo();
        }

        private void btnCheckOutClicked()
        {
            //pass the Item that is being checked out to the Patron class
            curItem.checkout(curPatron.displayName());
            curPatron.checkout(ref curItem); //curItem is a Item object
            updateItemsCheckOut();
            updateItemsLibrary();

        }

        private void btnCheckInClicked()
        {
            curItem.checkin();
            curPatron.checkin(ref curItem); //curItem is a Item object
            updateItemsCheckOut();
            updateItemsLibrary();
        }

        //Code for when the button to advance the date is clicked
        private void btnAdvancedDayClicked()
        {
            //Increment the date by one
            var today = dateToday.Value.AddDays(1);
            int day365 = today.DayOfYear;
            lstItemsOverdue.Items.Clear();
            foreach (Item x in checkedOut)
            {
                if ((x.dueDate.DayOfYear - day365) < 0)
                {
                    lstItemsOverdue.Items.Add(x);
                }
            }
        }
    }
}