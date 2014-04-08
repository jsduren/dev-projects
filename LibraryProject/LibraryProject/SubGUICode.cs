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


        private void updatePatronInfo()
        {
            
        }

        
        private void updateItemInfo()
        {
            
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
            foreach (Item x in checkedOut)
            {
                if (x.dueDate < today)
                {
                    lstItemsOverdue.Items.Add(x);
                }
            }
        }
    }
}