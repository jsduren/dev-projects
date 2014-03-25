namespace LibraryProject
{
    partial class LibraryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblItemStatus = new System.Windows.Forms.Label();
            this.lblItemDueDate = new System.Windows.Forms.Label();
            this.lblItemCheckoutLength = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.lblItemTitle = new System.Windows.Forms.Label();
            this.lblPatronItemsCheckedOut = new System.Windows.Forms.Label();
            this.lblPatronType = new System.Windows.Forms.Label();
            this.lblPatronName = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lstItemsOverdue = new System.Windows.Forms.ListBox();
            this.lstItemsLibrary = new System.Windows.Forms.ListBox();
            this.lstPatrons = new System.Windows.Forms.ListBox();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstItemsCheckedOut = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblListOfPatrons = new System.Windows.Forms.Label();
            this.lblListOfItems = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblListOfCurrentlyCheckedOut = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.AutoSize = true;
            this.lblItemStatus.Location = new System.Drawing.Point(77, 195);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(40, 13);
            this.lblItemStatus.TabIndex = 29;
            this.lblItemStatus.Text = "Status:";
            this.lblItemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemDueDate
            // 
            this.lblItemDueDate.AutoSize = true;
            this.lblItemDueDate.Location = new System.Drawing.Point(61, 224);
            this.lblItemDueDate.Name = "lblItemDueDate";
            this.lblItemDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblItemDueDate.TabIndex = 28;
            this.lblItemDueDate.Text = "Due Date:";
            this.lblItemDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemCheckoutLength
            // 
            this.lblItemCheckoutLength.AutoSize = true;
            this.lblItemCheckoutLength.Location = new System.Drawing.Point(25, 170);
            this.lblItemCheckoutLength.Name = "lblItemCheckoutLength";
            this.lblItemCheckoutLength.Size = new System.Drawing.Size(92, 13);
            this.lblItemCheckoutLength.TabIndex = 27;
            this.lblItemCheckoutLength.Text = "Checkout Length:";
            this.lblItemCheckoutLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(83, 147);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(34, 13);
            this.lblItemType.TabIndex = 26;
            this.lblItemType.Text = "Type:";
            this.lblItemType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemTitle
            // 
            this.lblItemTitle.AutoSize = true;
            this.lblItemTitle.Location = new System.Drawing.Point(87, 124);
            this.lblItemTitle.Name = "lblItemTitle";
            this.lblItemTitle.Size = new System.Drawing.Size(30, 13);
            this.lblItemTitle.TabIndex = 25;
            this.lblItemTitle.Text = "Title:";
            this.lblItemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPatronItemsCheckedOut
            // 
            this.lblPatronItemsCheckedOut.AutoSize = true;
            this.lblPatronItemsCheckedOut.Location = new System.Drawing.Point(-4, 88);
            this.lblPatronItemsCheckedOut.Name = "lblPatronItemsCheckedOut";
            this.lblPatronItemsCheckedOut.Size = new System.Drawing.Size(121, 13);
            this.lblPatronItemsCheckedOut.TabIndex = 24;
            this.lblPatronItemsCheckedOut.Text = "No. Items Checked Out:";
            this.lblPatronItemsCheckedOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPatronType
            // 
            this.lblPatronType.AutoSize = true;
            this.lblPatronType.Location = new System.Drawing.Point(83, 62);
            this.lblPatronType.Name = "lblPatronType";
            this.lblPatronType.Size = new System.Drawing.Size(34, 13);
            this.lblPatronType.TabIndex = 23;
            this.lblPatronType.Text = "Type:";
            this.lblPatronType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPatronName
            // 
            this.lblPatronName.AutoSize = true;
            this.lblPatronName.Location = new System.Drawing.Point(79, 36);
            this.lblPatronName.Name = "lblPatronName";
            this.lblPatronName.Size = new System.Drawing.Size(38, 13);
            this.lblPatronName.TabIndex = 22;
            this.lblPatronName.Text = "Name:";
            this.lblPatronName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(437, 334);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIn.TabIndex = 21;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(437, 272);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 20;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lstItemsOverdue
            // 
            this.lstItemsOverdue.FormattingEnabled = true;
            this.lstItemsOverdue.Location = new System.Drawing.Point(22, 289);
            this.lstItemsOverdue.Name = "lstItemsOverdue";
            this.lstItemsOverdue.Size = new System.Drawing.Size(163, 108);
            this.lstItemsOverdue.TabIndex = 19;
            // 
            // lstItemsLibrary
            // 
            this.lstItemsLibrary.FormattingEnabled = true;
            this.lstItemsLibrary.Location = new System.Drawing.Point(528, 224);
            this.lstItemsLibrary.Name = "lstItemsLibrary";
            this.lstItemsLibrary.Size = new System.Drawing.Size(152, 173);
            this.lstItemsLibrary.TabIndex = 17;
            // 
            // lstPatrons
            // 
            this.lstPatrons.FormattingEnabled = true;
            this.lstPatrons.Location = new System.Drawing.Point(528, 62);
            this.lstPatrons.Name = "lstPatrons";
            this.lstPatrons.Size = new System.Drawing.Size(152, 121);
            this.lstPatrons.TabIndex = 16;
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.saveToolStripMenuItem1.Text = "Exit";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem1.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Save";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "Open";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lstItemsCheckedOut
            // 
            this.lstItemsCheckedOut.FormattingEnabled = true;
            this.lstItemsCheckedOut.Location = new System.Drawing.Point(202, 289);
            this.lstItemsCheckedOut.Name = "lstItemsCheckedOut";
            this.lstItemsCheckedOut.Size = new System.Drawing.Size(163, 108);
            this.lstItemsCheckedOut.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblListOfPatrons
            // 
            this.lblListOfPatrons.AutoSize = true;
            this.lblListOfPatrons.Location = new System.Drawing.Point(525, 46);
            this.lblListOfPatrons.Name = "lblListOfPatrons";
            this.lblListOfPatrons.Size = new System.Drawing.Size(74, 13);
            this.lblListOfPatrons.TabIndex = 30;
            this.lblListOfPatrons.Text = "List of Patrons";
            // 
            // lblListOfItems
            // 
            this.lblListOfItems.AutoSize = true;
            this.lblListOfItems.Location = new System.Drawing.Point(525, 208);
            this.lblListOfItems.Name = "lblListOfItems";
            this.lblListOfItems.Size = new System.Drawing.Size(63, 13);
            this.lblListOfItems.TabIndex = 31;
            this.lblListOfItems.Text = "List of Items";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Items Overdue";
            // 
            // lblListOfCurrentlyCheckedOut
            // 
            this.lblListOfCurrentlyCheckedOut.AutoSize = true;
            this.lblListOfCurrentlyCheckedOut.Location = new System.Drawing.Point(199, 273);
            this.lblListOfCurrentlyCheckedOut.Name = "lblListOfCurrentlyCheckedOut";
            this.lblListOfCurrentlyCheckedOut.Size = new System.Drawing.Size(142, 13);
            this.lblListOfCurrentlyCheckedOut.TabIndex = 33;
            this.lblListOfCurrentlyCheckedOut.Text = "Items Currently Checked Out";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 35;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 36;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 121);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 37;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 144);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 38;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(120, 167);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 39;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(120, 192);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 42;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 467);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblListOfCurrentlyCheckedOut);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblListOfItems);
            this.Controls.Add(this.lblListOfPatrons);
            this.Controls.Add(this.lblItemStatus);
            this.Controls.Add(this.lblItemDueDate);
            this.Controls.Add(this.lblItemCheckoutLength);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.lblItemTitle);
            this.Controls.Add(this.lblPatronItemsCheckedOut);
            this.Controls.Add(this.lblPatronType);
            this.Controls.Add(this.lblPatronName);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lstItemsOverdue);
            this.Controls.Add(this.lstItemsLibrary);
            this.Controls.Add(this.lstPatrons);
            this.Controls.Add(this.lstItemsCheckedOut);
            this.Controls.Add(this.menuStrip1);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemStatus;
        private System.Windows.Forms.Label lblItemDueDate;
        private System.Windows.Forms.Label lblItemCheckoutLength;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Label lblItemTitle;
        private System.Windows.Forms.Label lblPatronItemsCheckedOut;
        private System.Windows.Forms.Label lblPatronType;
        private System.Windows.Forms.Label lblPatronName;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ListBox lstItemsOverdue;
        private System.Windows.Forms.ListBox lstItemsLibrary;
        private System.Windows.Forms.ListBox lstPatrons;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ListBox lstItemsCheckedOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblListOfPatrons;
        private System.Windows.Forms.Label lblListOfItems;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblListOfCurrentlyCheckedOut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox7;
    }
}

