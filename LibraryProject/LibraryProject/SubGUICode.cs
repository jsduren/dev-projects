using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private Object ListBoxIndexSelected(ListBox lstBox)
        {
            var listName = lstBox.Name.ToString();
            var selItem = int.Parse(lstBox.SelectedIndex.ToString());
            if (listName == "lstPatrons")
            {
                return patrons[selItem];
            }
            
            return items[selItem];
        }

        //Brad
        //Brad Notes: 
        //   first and last in the patron class needs to be made public so I can access them.
        //   In the Adult and Child classes, there needs to be a reference to the array that holds that Objecs items.

        private void updatePatronInfo()
        {
            txtBPatronName.Text = curPatron.first + " " + curPatron.last;

            //check the type of the patron
            if (curPatron is Adult)
            {
                txtBPatronType.Text = "Adult";
            }
            else if (curPatron is Child)
            {
                txtBPatronType.Text = "Child";
            }

            //I am unsure how to access the child classes (Adult, Child) from an instance of the parent class (Patron)
            //var childPatron = (Child)curPatron;
        }

        //Brad
        //Notes:
        //  title needs to be made public so it can be accessed.
        //  I am unsure how to access the child class's data through an instance of the parent class
        //  status of the object (checked out or checked in) maybe should be in the Item class since all items will need it.
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
            
        }

        private void updateItemsLibrary()
        {
            
        }

        private void selectedIndexChanged(ListBox lstBox)
        {
            var listName = lstBox.Name.ToString();

            if (listName == "lstItemsLibrary")
            {
                
            } 
            else if (listName == "lstItemsCheckedOut")
            {
                
            }
            else if (listName == "listPatrons")
            {
                
            }
        }

        private void patronSelected(ListBox lstBox)
        {
            for (int i = 0; i < lstBox.Size.Height; i++)
            {
                
            }
        }

        private void itemLibrarySelected(ListBox lstBox)
        {
            
        }

        private void itemCheckOutSelected(ListBox lstBox)
        {
            
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