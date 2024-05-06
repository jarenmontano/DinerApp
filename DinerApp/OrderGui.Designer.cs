namespace DinerApp
{
    partial class OrderGui
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            placeOrderToolStripMenuItem = new ToolStripMenuItem();
            clearOrderToolStripMenuItem = new ToolStripMenuItem();
            displayOrderToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            entreeToolStripMenuItem = new ToolStripMenuItem();
            drinkToolStripMenuItem = new ToolStripMenuItem();
            specialRequestToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            lblEntreeSelection = new Label();
            lblSpecialRequests = new Label();
            lstBxEntreeSelection = new ListBox();
            CBxSpecialRequests = new ComboBox();
            chBxWater = new CheckBox();
            grbxDrinkSelection = new GroupBox();
            rbCoffee = new RadioButton();
            rbTea = new RadioButton();
            rbLemonade = new RadioButton();
            rbSoda = new RadioButton();
            rbJuice = new RadioButton();
            rbMilk = new RadioButton();
            menuStrip.SuspendLayout();
            grbxDrinkSelection.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { placeOrderToolStripMenuItem, clearOrderToolStripMenuItem, displayOrderToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // placeOrderToolStripMenuItem
            // 
            placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            placeOrderToolStripMenuItem.Size = new Size(145, 22);
            placeOrderToolStripMenuItem.Text = "Place Order";
            placeOrderToolStripMenuItem.Click += placeOrderToolStripMenuItem_Click;
            // 
            // clearOrderToolStripMenuItem
            // 
            clearOrderToolStripMenuItem.Name = "clearOrderToolStripMenuItem";
            clearOrderToolStripMenuItem.Size = new Size(145, 22);
            clearOrderToolStripMenuItem.Text = "Clear Order";
            clearOrderToolStripMenuItem.Click += clearOrderToolStripMenuItem_Click;
            // 
            // displayOrderToolStripMenuItem
            // 
            displayOrderToolStripMenuItem.Name = "displayOrderToolStripMenuItem";
            displayOrderToolStripMenuItem.Size = new Size(145, 22);
            displayOrderToolStripMenuItem.Text = "Display Order";
            displayOrderToolStripMenuItem.Click += displayOrderToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(145, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { entreeToolStripMenuItem, drinkToolStripMenuItem, specialRequestToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // entreeToolStripMenuItem
            // 
            entreeToolStripMenuItem.Name = "entreeToolStripMenuItem";
            entreeToolStripMenuItem.Size = new Size(156, 22);
            entreeToolStripMenuItem.Text = "Entree";
            entreeToolStripMenuItem.Click += entreeToolStripMenuItem_Click;
            // 
            // drinkToolStripMenuItem
            // 
            drinkToolStripMenuItem.Name = "drinkToolStripMenuItem";
            drinkToolStripMenuItem.Size = new Size(156, 22);
            drinkToolStripMenuItem.Text = "Drink";
            drinkToolStripMenuItem.Click += drinkToolStripMenuItem_Click;
            // 
            // specialRequestToolStripMenuItem
            // 
            specialRequestToolStripMenuItem.Name = "specialRequestToolStripMenuItem";
            specialRequestToolStripMenuItem.Size = new Size(156, 22);
            specialRequestToolStripMenuItem.Text = "Special Request";
            specialRequestToolStripMenuItem.Click += specialRequestToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // lblEntreeSelection
            // 
            lblEntreeSelection.AutoSize = true;
            lblEntreeSelection.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEntreeSelection.Location = new Point(41, 44);
            lblEntreeSelection.Name = "lblEntreeSelection";
            lblEntreeSelection.Size = new Size(107, 17);
            lblEntreeSelection.TabIndex = 1;
            lblEntreeSelection.Text = "Entree Selection";
            // 
            // lblSpecialRequests
            // 
            lblSpecialRequests.AutoSize = true;
            lblSpecialRequests.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpecialRequests.Location = new Point(41, 210);
            lblSpecialRequests.Name = "lblSpecialRequests";
            lblSpecialRequests.Size = new Size(110, 17);
            lblSpecialRequests.TabIndex = 2;
            lblSpecialRequests.Text = "Special Requests";
            // 
            // lstBxEntreeSelection
            // 
            lstBxEntreeSelection.BackColor = Color.LemonChiffon;
            lstBxEntreeSelection.FormattingEnabled = true;
            lstBxEntreeSelection.ItemHeight = 15;
            lstBxEntreeSelection.Location = new Point(41, 75);
            lstBxEntreeSelection.Name = "lstBxEntreeSelection";
            lstBxEntreeSelection.Size = new Size(171, 94);
            lstBxEntreeSelection.Sorted = true;
            lstBxEntreeSelection.TabIndex = 3;
            lstBxEntreeSelection.SelectedIndexChanged += lstBxEntreeSelection_SelectedIndexChanged;
            // 
            // CBxSpecialRequests
            // 
            CBxSpecialRequests.BackColor = Color.LemonChiffon;
            CBxSpecialRequests.FormattingEnabled = true;
            CBxSpecialRequests.Items.AddRange(new object[] { "Whole Wheat", "Pumpernickle", "Seedless Rye", "Soughdough", "Pita" });
            CBxSpecialRequests.Location = new Point(40, 243);
            CBxSpecialRequests.Name = "CBxSpecialRequests";
            CBxSpecialRequests.Size = new Size(172, 23);
            CBxSpecialRequests.TabIndex = 4;
            CBxSpecialRequests.SelectedIndexChanged += CBxSpecialRequests_SelectedIndexChanged;
            CBxSpecialRequests.TextChanged += CBxSpecialRequests_TextChanged;
            // 
            // chBxWater
            // 
            chBxWater.AutoSize = true;
            chBxWater.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chBxWater.Location = new Point(79, 309);
            chBxWater.Name = "chBxWater";
            chBxWater.Size = new Size(63, 21);
            chBxWater.TabIndex = 5;
            chBxWater.Text = "Water";
            chBxWater.UseVisualStyleBackColor = true;
            chBxWater.CheckedChanged += chBxWater_CheckedChanged;
            // 
            // grbxDrinkSelection
            // 
            grbxDrinkSelection.Controls.Add(rbCoffee);
            grbxDrinkSelection.Controls.Add(rbTea);
            grbxDrinkSelection.Controls.Add(rbLemonade);
            grbxDrinkSelection.Controls.Add(rbSoda);
            grbxDrinkSelection.Controls.Add(rbJuice);
            grbxDrinkSelection.Controls.Add(rbMilk);
            grbxDrinkSelection.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            grbxDrinkSelection.Location = new Point(318, 44);
            grbxDrinkSelection.Name = "grbxDrinkSelection";
            grbxDrinkSelection.Size = new Size(150, 286);
            grbxDrinkSelection.TabIndex = 6;
            grbxDrinkSelection.TabStop = false;
            grbxDrinkSelection.Text = "Drink Selection";
            // 
            // rbCoffee
            // 
            rbCoffee.AutoSize = true;
            rbCoffee.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbCoffee.Location = new Point(22, 247);
            rbCoffee.Name = "rbCoffee";
            rbCoffee.Size = new Size(66, 21);
            rbCoffee.TabIndex = 5;
            rbCoffee.Text = "Coffee";
            rbCoffee.UseVisualStyleBackColor = true;
            rbCoffee.CheckedChanged += Drink_CheckedChanged;
            // 
            // rbTea
            // 
            rbTea.AutoSize = true;
            rbTea.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbTea.Location = new Point(22, 201);
            rbTea.Name = "rbTea";
            rbTea.Size = new Size(47, 21);
            rbTea.TabIndex = 4;
            rbTea.Text = "Tea";
            rbTea.UseVisualStyleBackColor = true;
            rbTea.CheckedChanged += Drink_CheckedChanged;
            // 
            // rbLemonade
            // 
            rbLemonade.AutoSize = true;
            rbLemonade.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbLemonade.Location = new Point(22, 162);
            rbLemonade.Name = "rbLemonade";
            rbLemonade.Size = new Size(90, 21);
            rbLemonade.TabIndex = 3;
            rbLemonade.Text = "Lemonade";
            rbLemonade.UseVisualStyleBackColor = true;
            rbLemonade.CheckedChanged += Drink_CheckedChanged;
            // 
            // rbSoda
            // 
            rbSoda.AutoSize = true;
            rbSoda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbSoda.Location = new Point(22, 119);
            rbSoda.Name = "rbSoda";
            rbSoda.Size = new Size(56, 21);
            rbSoda.TabIndex = 2;
            rbSoda.Text = "Soda";
            rbSoda.UseVisualStyleBackColor = true;
            rbSoda.CheckedChanged += Drink_CheckedChanged;
            // 
            // rbJuice
            // 
            rbJuice.AutoSize = true;
            rbJuice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbJuice.Location = new Point(22, 76);
            rbJuice.Name = "rbJuice";
            rbJuice.Size = new Size(57, 21);
            rbJuice.TabIndex = 1;
            rbJuice.Text = "Juice";
            rbJuice.UseVisualStyleBackColor = true;
            rbJuice.CheckedChanged += Drink_CheckedChanged;
            // 
            // rbMilk
            // 
            rbMilk.AutoSize = true;
            rbMilk.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbMilk.Location = new Point(22, 31);
            rbMilk.Name = "rbMilk";
            rbMilk.Size = new Size(53, 21);
            rbMilk.TabIndex = 0;
            rbMilk.Text = "Milk";
            rbMilk.UseVisualStyleBackColor = true;
            rbMilk.CheckedChanged += Drink_CheckedChanged;
            // 
            // OrderGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(grbxDrinkSelection);
            Controls.Add(chBxWater);
            Controls.Add(CBxSpecialRequests);
            Controls.Add(lstBxEntreeSelection);
            Controls.Add(lblSpecialRequests);
            Controls.Add(lblEntreeSelection);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "OrderGui";
            Text = "Student - Dinner by the Valley";
            Load += OrderGui_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            grbxDrinkSelection.ResumeLayout(false);
            grbxDrinkSelection.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem placeOrderToolStripMenuItem;
        private ToolStripMenuItem clearOrderToolStripMenuItem;
        private ToolStripMenuItem displayOrderToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem entreeToolStripMenuItem;
        private ToolStripMenuItem drinkToolStripMenuItem;
        private ToolStripMenuItem specialRequestToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label lblEntreeSelection;
        private Label lblSpecialRequests;
        private ListBox lstBxEntreeSelection;
        private ComboBox CBxSpecialRequests;
        private CheckBox chBxWater;
        private GroupBox grbxDrinkSelection;
        private RadioButton rbCoffee;
        private RadioButton rbTea;
        private RadioButton rbLemonade;
        private RadioButton rbSoda;
        private RadioButton rbJuice;
        private RadioButton rbMilk;
    }
}