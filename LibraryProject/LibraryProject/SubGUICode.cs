﻿using System;
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
            
        }

        private void openFile()
        {
            /*File.readFile();
            items.Clear();
            items = File.itemsList;
            patrons.Clear();
            patrons = File.patronsList;*/
            updatePatrons();
            updateItemsLibrary();
        }

        private void closeFile()
        {
            File.itemsList.Clear();
            File.itemsList = items;
            File.patronsList.Clear();
            File.patronsList = patrons;
            File.saveFile();
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
                txtBItemCheckoutLen.Text = "2 Weeks";
                dateDue.Value = inputItem.dueDate;
              
            }
            else if (inputItem is ChildBook)
            {
                txtBItemType.Text = "Child Book";
                txtBItemCheckoutLen.Text = "1 Week";
                dateDue.Value = inputItem.dueDate;
              
            }
            else if (inputItem is DVD)
            {
                txtBItemType.Text = "DVD";
                txtBItemCheckoutLen.Text = "2 days";
                dateDue.Value = inputItem.dueDate;
            }
            else if (inputItem is VHS)
            {
                txtBItemType.Text = "VHS";
                txtBItemCheckoutLen.Text = "3 days";
                dateDue.Value = inputItem.dueDate;
            }
        }

        private void updatePatrons()
        {
            lstPatrons.Items.Clear();
            foreach (Patron perPatron in patrons)
            {
                if (perPatron is Child)
                {
                    lstItemsLibrary.Items.Add(perPatron.displayName() + "\tChild");
                }
                else
                {
                    lstItemsLibrary.Items.Add(perPatron.displayName() + "\tAdult");
                }
            }
        }

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
        }

        private void updateItemsLibrary()
        {
            lstItemsLibrary.Items.Clear();
            foreach (Item x in items)
            {
                if (x.checkedout)
                {
                    lstItemsLibrary.Items.Add("X\t" + x.title);
                }
                else
                {
                    lstItemsLibrary.Items.Add("\t" + x.title);
                }
            }
        }

        //Josh is this still necessary? -Brad
        private void updateOverdueItems(int daysOfYear )
        {
            
            lstItemsOverdue.Items.Clear();
            foreach (Item x in checkedOut)
            {
                if ((x.dueDate.DayOfYear - daysOfYear) < 0)
                {
                    lstItemsOverdue.Items.Add(x.title + "\t" + (x.dueDate.DayOfYear - daysOfYear));
                }
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

        private void btnCheckOutClicked()
        {
            //pass the Item that is being checked out to the Patron class
            Item tempItem = checkedOut[curItemIndex];
            if (patrons[curPatronIndex].checkout(ref tempItem)) //curItem is a Item object -- If checkout is Successful
            {
                updateItemInLibrary(tempItem);
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

        private void btnCheckInClicked()
        {
            checkedOut[curItemIndex].checkin();
            Item tempItem = checkedOut[curItemIndex];
            patrons[curPatronIndex].checkin(ref tempItem); //curItem is a Item object
            updateItemInLibrary(tempItem);
            updateItemsCheckOut();
            updateItemsLibrary();
            updateOverdueItems(dateToday.Value.DayOfYear);
        }

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
            var today = dateToday.Value.AddDays(1);
            int day365 = today.DayOfYear;
            updateOverdueItems(day365);
        }
    }
}