﻿//Written by: Brad Soderman, Josh Duren
//GUI was designed by Brad Soderman

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
        private List<Patron> patrons = new List<Patron>();
        private List<Item> items = new List<Item>();
        private List<Item> checkedOut = new List<Item>();

        public LibraryForm()
        {
            InitializeComponent();
        }

        //Checkout Button Listener
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            btnCheckOutClicked();
        }

        //Checkin Button Listener
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            btnCheckInClicked();
        }

        //Exit toolstrip Listener
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                closeFile();
                Close();
            }
        }

        //About toolstrip Listener
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Library Project\nCS 2450\n\nBrad Soderman\nAustin Barnes\nIkani Samani\nJosh Duren");
        }

        //Open toolstrip Listener
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        //Save toolstrip Listener
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeFile();
        }

        //when the list of library items is clicked 
        private void lstItemsLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged(lstItemsLibrary);
        }

        //when the list that contains the patrons is clicked
        private void lstPatrons_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged(lstPatrons);
        }

        //Listener for when the advance time button is clicked
        private void btnAdvDate_Click(object sender, EventArgs e)
        {
            btnAdvancedDayClicked();
        }

        //when the list that contains the checked out items is clicked
        private void lstItemsCheckedOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged(lstItemsCheckedOut);
        }

        //Listener for when the Form is Loaded
        private void LibraryForm_Load(object sender, EventArgs e)
        {
            curDateTime = dateToday.Value;
            btnCheckIn.Enabled = false;
            btnCheckOut.Enabled = false;
            dateDue.Visible = false;
            lblItemDueDate.Visible = false;
        }

    }
}
