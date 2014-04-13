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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstItemsCheckedOut = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblListOfPatrons = new System.Windows.Forms.Label();
            this.lblListOfItems = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblListOfCurrentlyCheckedOut = new System.Windows.Forms.Label();
            this.txtBPatronType = new System.Windows.Forms.TextBox();
            this.txtBPatronItemsOut = new System.Windows.Forms.TextBox();
            this.txtBPatronName = new System.Windows.Forms.TextBox();
            this.txtBItemTitle = new System.Windows.Forms.TextBox();
            this.txtBItemType = new System.Windows.Forms.TextBox();
            this.txtBItemCheckoutLen = new System.Windows.Forms.TextBox();
            this.dateDue = new System.Windows.Forms.DateTimePicker();
            this.txtBItemStatus = new System.Windows.Forms.TextBox();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.dateToday = new System.Windows.Forms.DateTimePicker();
            this.btnAdvDate = new System.Windows.Forms.Button();
            this.lblOverdueDescription = new System.Windows.Forms.Label();
            this.lblCheckedOutDesc = new System.Windows.Forms.Label();
            this.lblLibraryDesc = new System.Windows.Forms.Label();
            this.lblPatronDesc = new System.Windows.Forms.Label();
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
            this.lblPatronItemsCheckedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblPatronType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblPatronName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lstItemsOverdue.Enabled = false;
            this.lstItemsOverdue.FormattingEnabled = true;
            this.lstItemsOverdue.Location = new System.Drawing.Point(28, 305);
            this.lstItemsOverdue.Name = "lstItemsOverdue";
            this.lstItemsOverdue.Size = new System.Drawing.Size(163, 108);
            this.lstItemsOverdue.TabIndex = 19;
            // 
            // lstItemsLibrary
            // 
            this.lstItemsLibrary.FormattingEnabled = true;
            this.lstItemsLibrary.Location = new System.Drawing.Point(528, 240);
            this.lstItemsLibrary.Name = "lstItemsLibrary";
            this.lstItemsLibrary.Size = new System.Drawing.Size(192, 173);
            this.lstItemsLibrary.TabIndex = 17;
            this.lstItemsLibrary.SelectedIndexChanged += new System.EventHandler(this.lstItemsLibrary_SelectedIndexChanged);
            // 
            // lstPatrons
            // 
            this.lstPatrons.FormattingEnabled = true;
            this.lstPatrons.Location = new System.Drawing.Point(528, 70);
            this.lstPatrons.Name = "lstPatrons";
            this.lstPatrons.Size = new System.Drawing.Size(192, 121);
            this.lstPatrons.TabIndex = 16;
            this.lstPatrons.SelectedIndexChanged += new System.EventHandler(this.lstPatrons_SelectedIndexChanged);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lstItemsCheckedOut
            // 
            this.lstItemsCheckedOut.FormattingEnabled = true;
            this.lstItemsCheckedOut.Location = new System.Drawing.Point(202, 305);
            this.lstItemsCheckedOut.Name = "lstItemsCheckedOut";
            this.lstItemsCheckedOut.Size = new System.Drawing.Size(163, 108);
            this.lstItemsCheckedOut.TabIndex = 18;
            this.lstItemsCheckedOut.SelectedIndexChanged += new System.EventHandler(this.lstItemsCheckedOut_SelectedIndexChanged);
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
            this.lblListOfPatrons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfPatrons.Location = new System.Drawing.Point(578, 36);
            this.lblListOfPatrons.Name = "lblListOfPatrons";
            this.lblListOfPatrons.Size = new System.Drawing.Size(89, 13);
            this.lblListOfPatrons.TabIndex = 30;
            this.lblListOfPatrons.Text = "List of Patrons";
            // 
            // lblListOfItems
            // 
            this.lblListOfItems.AutoSize = true;
            this.lblListOfItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfItems.Location = new System.Drawing.Point(591, 208);
            this.lblListOfItems.Name = "lblListOfItems";
            this.lblListOfItems.Size = new System.Drawing.Size(76, 13);
            this.lblListOfItems.TabIndex = 31;
            this.lblListOfItems.Text = "List of Items";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Items Overdue";
            // 
            // lblListOfCurrentlyCheckedOut
            // 
            this.lblListOfCurrentlyCheckedOut.AutoSize = true;
            this.lblListOfCurrentlyCheckedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfCurrentlyCheckedOut.Location = new System.Drawing.Point(199, 273);
            this.lblListOfCurrentlyCheckedOut.Name = "lblListOfCurrentlyCheckedOut";
            this.lblListOfCurrentlyCheckedOut.Size = new System.Drawing.Size(169, 13);
            this.lblListOfCurrentlyCheckedOut.TabIndex = 33;
            this.lblListOfCurrentlyCheckedOut.Text = "Items Currently Checked Out";
            // 
            // txtBPatronType
            // 
            this.txtBPatronType.Enabled = false;
            this.txtBPatronType.Location = new System.Drawing.Point(120, 59);
            this.txtBPatronType.Name = "txtBPatronType";
            this.txtBPatronType.Size = new System.Drawing.Size(100, 20);
            this.txtBPatronType.TabIndex = 34;
            // 
            // txtBPatronItemsOut
            // 
            this.txtBPatronItemsOut.Enabled = false;
            this.txtBPatronItemsOut.Location = new System.Drawing.Point(120, 85);
            this.txtBPatronItemsOut.Name = "txtBPatronItemsOut";
            this.txtBPatronItemsOut.Size = new System.Drawing.Size(100, 20);
            this.txtBPatronItemsOut.TabIndex = 35;
            // 
            // txtBPatronName
            // 
            this.txtBPatronName.Enabled = false;
            this.txtBPatronName.Location = new System.Drawing.Point(120, 33);
            this.txtBPatronName.Name = "txtBPatronName";
            this.txtBPatronName.Size = new System.Drawing.Size(100, 20);
            this.txtBPatronName.TabIndex = 36;
            // 
            // txtBItemTitle
            // 
            this.txtBItemTitle.Enabled = false;
            this.txtBItemTitle.Location = new System.Drawing.Point(120, 121);
            this.txtBItemTitle.Name = "txtBItemTitle";
            this.txtBItemTitle.Size = new System.Drawing.Size(100, 20);
            this.txtBItemTitle.TabIndex = 37;
            // 
            // txtBItemType
            // 
            this.txtBItemType.Enabled = false;
            this.txtBItemType.Location = new System.Drawing.Point(120, 144);
            this.txtBItemType.Name = "txtBItemType";
            this.txtBItemType.Size = new System.Drawing.Size(100, 20);
            this.txtBItemType.TabIndex = 38;
            // 
            // txtBItemCheckoutLen
            // 
            this.txtBItemCheckoutLen.Enabled = false;
            this.txtBItemCheckoutLen.Location = new System.Drawing.Point(120, 167);
            this.txtBItemCheckoutLen.Name = "txtBItemCheckoutLen";
            this.txtBItemCheckoutLen.Size = new System.Drawing.Size(100, 20);
            this.txtBItemCheckoutLen.TabIndex = 39;
            // 
            // dateDue
            // 
            this.dateDue.Enabled = false;
            this.dateDue.Location = new System.Drawing.Point(120, 218);
            this.dateDue.Name = "dateDue";
            this.dateDue.Size = new System.Drawing.Size(200, 20);
            this.dateDue.TabIndex = 41;
            // 
            // txtBItemStatus
            // 
            this.txtBItemStatus.Enabled = false;
            this.txtBItemStatus.Location = new System.Drawing.Point(120, 192);
            this.txtBItemStatus.Name = "txtBItemStatus";
            this.txtBItemStatus.Size = new System.Drawing.Size(100, 20);
            this.txtBItemStatus.TabIndex = 42;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.Location = new System.Drawing.Point(339, 36);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(86, 13);
            this.lblTodayDate.TabIndex = 43;
            this.lblTodayDate.Text = "Today\'s Date:";
            // 
            // dateToday
            // 
            this.dateToday.Enabled = false;
            this.dateToday.Location = new System.Drawing.Point(281, 54);
            this.dateToday.Name = "dateToday";
            this.dateToday.Size = new System.Drawing.Size(200, 20);
            this.dateToday.TabIndex = 44;
            // 
            // btnAdvDate
            // 
            this.btnAdvDate.Location = new System.Drawing.Point(333, 80);
            this.btnAdvDate.Name = "btnAdvDate";
            this.btnAdvDate.Size = new System.Drawing.Size(88, 23);
            this.btnAdvDate.TabIndex = 45;
            this.btnAdvDate.Text = "Advance Date";
            this.btnAdvDate.UseVisualStyleBackColor = true;
            this.btnAdvDate.Click += new System.EventHandler(this.btnAdvDate_Click);
            // 
            // lblOverdueDescription
            // 
            this.lblOverdueDescription.AutoSize = true;
            this.lblOverdueDescription.Location = new System.Drawing.Point(49, 289);
            this.lblOverdueDescription.Name = "lblOverdueDescription";
            this.lblOverdueDescription.Size = new System.Drawing.Size(116, 13);
            this.lblOverdueDescription.TabIndex = 46;
            this.lblOverdueDescription.Text = "- Days Overdue - Title -";
            // 
            // lblCheckedOutDesc
            // 
            this.lblCheckedOutDesc.AutoSize = true;
            this.lblCheckedOutDesc.Location = new System.Drawing.Point(236, 289);
            this.lblCheckedOutDesc.Name = "lblCheckedOutDesc";
            this.lblCheckedOutDesc.Size = new System.Drawing.Size(94, 13);
            this.lblCheckedOutDesc.TabIndex = 47;
            this.lblCheckedOutDesc.Text = "- Title - Due Date -";
            // 
            // lblLibraryDesc
            // 
            this.lblLibraryDesc.AutoSize = true;
            this.lblLibraryDesc.Location = new System.Drawing.Point(549, 224);
            this.lblLibraryDesc.Name = "lblLibraryDesc";
            this.lblLibraryDesc.Size = new System.Drawing.Size(144, 13);
            this.lblLibraryDesc.TabIndex = 48;
            this.lblLibraryDesc.Text = "- Checked Out - Title - Type -";
            // 
            // lblPatronDesc
            // 
            this.lblPatronDesc.AutoSize = true;
            this.lblPatronDesc.Location = new System.Drawing.Point(578, 54);
            this.lblPatronDesc.Name = "lblPatronDesc";
            this.lblPatronDesc.Size = new System.Drawing.Size(80, 13);
            this.lblPatronDesc.TabIndex = 49;
            this.lblPatronDesc.Text = "- Name - Type -";
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 467);
            this.Controls.Add(this.lblPatronDesc);
            this.Controls.Add(this.lblLibraryDesc);
            this.Controls.Add(this.lblCheckedOutDesc);
            this.Controls.Add(this.lblOverdueDescription);
            this.Controls.Add(this.btnAdvDate);
            this.Controls.Add(this.dateToday);
            this.Controls.Add(this.lblTodayDate);
            this.Controls.Add(this.txtBItemStatus);
            this.Controls.Add(this.dateDue);
            this.Controls.Add(this.txtBItemCheckoutLen);
            this.Controls.Add(this.txtBItemType);
            this.Controls.Add(this.txtBItemTitle);
            this.Controls.Add(this.txtBPatronName);
            this.Controls.Add(this.txtBPatronItemsOut);
            this.Controls.Add(this.txtBPatronType);
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
            this.Load += new System.EventHandler(this.LibraryForm_Load);
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
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ListBox lstItemsCheckedOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblListOfPatrons;
        private System.Windows.Forms.Label lblListOfItems;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblListOfCurrentlyCheckedOut;
        private System.Windows.Forms.TextBox txtBPatronType;
        private System.Windows.Forms.TextBox txtBPatronItemsOut;
        private System.Windows.Forms.TextBox txtBPatronName;
        private System.Windows.Forms.TextBox txtBItemTitle;
        private System.Windows.Forms.TextBox txtBItemType;
        private System.Windows.Forms.TextBox txtBItemCheckoutLen;
        private System.Windows.Forms.DateTimePicker dateDue;
        private System.Windows.Forms.TextBox txtBItemStatus;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.DateTimePicker dateToday;
        private System.Windows.Forms.Button btnAdvDate;
        private System.Windows.Forms.Label lblOverdueDescription;
        private System.Windows.Forms.Label lblCheckedOutDesc;
        private System.Windows.Forms.Label lblLibraryDesc;
        private System.Windows.Forms.Label lblPatronDesc;
    }
}

