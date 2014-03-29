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

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Library Project\nCS 2450\n\nBrad Soderman\nAustin Barnes\nIkani Samani\nJosh Duren");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lstItemsLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstPatrons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Listener for when the advance time button is clicked
        private void btnAdvDate_Click(object sender, EventArgs e)
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
