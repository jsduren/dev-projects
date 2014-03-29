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

        private void updatePatronInfo()
        {
            
        }

        private void updateItemInfo()
        {
            
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
            
        }

        private void btnCheckInClicked()
        {
            
        }
    }
}