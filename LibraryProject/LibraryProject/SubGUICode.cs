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
            var selItem = int.Parse(lstBox.SelectedIndex.ToString(CultureInfo.InvariantCulture));
            if (listName == "lstPatrons"){
                return patrons[selItem];
            }
            return  items[selItem];
        }

<<<<<<< HEAD
=======
        //Brad
        //Brad Notes: 
        //   first and last in the patron class needs to be made public so I can access them.
        //   In the Adult and Child classes, there needs to be a reference to the array that holds that Objecs items.
>>>>>>> 33b4fc630b77850e2bce86f9cde63af5ecd8574a

        private void updatePatronInfo()
        {
            txtBPatronName.Text = curPatron.first + " " + curPatron.last;

            //check the type of the patron
            if (curPatron is Adult)
            {
                txtBPatronType.Text = "Adult";
                //Adult adult = (Adult)curPatron;
                
                txtBPatronItemsOut.Text = calculateNoItems(Adult.MAX_ITEMS, (Adult)curPatron).ToString();
            }
            else if (curPatron is Child)
            {
                txtBPatronType.Text = "Child";
                //Child child = (Child)curPatron;

                txtBPatronItemsOut.Text = calculateNoItems(Child.MAX_ITEMS, (Child)curPatron).ToString();
            }
        }

        //calculates the number of items in the Adult AdultItems array
        private int calculateNoItems(int maxItems, Adult theAdult)
        {
            int patronItemCount = 0;
            for (int i = 0; i < maxItems; i++)
            {
                if (theAdult.adultArray[i] != null)
                {
                    patronItemCount++;
                }
            }
            return patronItemCount;
        }

        //calculates the number of items in the Child ChildBooks array
        private int calculateNoItems(int maxItems, Child theChild)
        {
            int patronItemCount = 0;
            for (int i = 0; i < maxItems; i++)
            {
                if (theChild.childArray[i] != null)
                {
                    patronItemCount++;
                }
            }
            return patronItemCount;
        }

<<<<<<< HEAD
        
=======
        //Brad
        //Notes:
        //  title needs to be made public so it can be accessed.
        //  I am unsure how to access the child class's data through an instance of the parent class
        //  status of the object (checked out or checked in) maybe should be in the Item class since all items will need it.
>>>>>>> 33b4fc630b77850e2bce86f9cde63af5ecd8574a
        private void updateItemInfo()
        {
            txtBItemTitle.Text = curItem.title;
            txtBItemStatus.Text = curItem.status;

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

        private void updateItemsLibrary(){
            lstItemsLibrary = items;
        }

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
            if (!curItem.checkOutState)
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
            if (curItem.checkOutState){
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
            curItem.checkout(curPatron.getName(), dateToday.Value.Date);
            curPatron.checkout(curItem); //curItem is a Item object
            updateItemsCheckOut();
            updateItemsLibrary();

        }

        private void btnCheckInClicked()
        {
            curItem.checkin();
            curPatron.checkin(curItem); //curItem is a Item object
            updateItemsCheckOut();
            updateItemsLibrary();
        }

        //Code for when the button to advance the date is clicked
        private void btnAdvancedDayClicked()
        {
            //Increment the date by one
            var today = dateToday.Value.AddDays(1);
            int day365 = today.DayOfYear;
            foreach (Item x in checkedOut)
            {
                if (x.dueDate.DayOfYear > day365)
                {
                    lstItemsOverdue.Items.Add(x);
                }
            }
        }
    }
}