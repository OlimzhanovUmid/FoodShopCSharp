namespace Shop
{
    partial class Shop
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
            this.menu = new System.Windows.Forms.ListView();
            this.Label = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.orderl = new System.Windows.Forms.Label();
            this.orderbox = new System.Windows.Forms.ComboBox();
            this.orderlist = new System.Windows.Forms.ListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.Button();
            this.pricelabel = new System.Windows.Forms.Label();
            this.pricesumm = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Button();
            this.bag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(10, 36);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(440, 316);
            this.menu.TabIndex = 0;
            this.menu.UseCompatibleStateImageBehavior = false;
            this.menu.SelectedIndexChanged += new System.EventHandler(this.menu_SelectedIndexChanged);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(10, 10);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(76, 26);
            this.Label.TabIndex = 1;
            this.Label.Text = "Menu:";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(455, 62);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(137, 22);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // orderl
            // 
            this.orderl.AutoSize = true;
            this.orderl.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderl.Location = new System.Drawing.Point(741, 10);
            this.orderl.Name = "orderl";
            this.orderl.Size = new System.Drawing.Size(114, 26);
            this.orderl.TabIndex = 4;
            this.orderl.Text = "OrderList:";
            // 
            // orderbox
            // 
            this.orderbox.FormattingEnabled = true;
            this.orderbox.Location = new System.Drawing.Point(455, 36);
            this.orderbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderbox.Name = "orderbox";
            this.orderbox.Size = new System.Drawing.Size(281, 23);
            this.orderbox.TabIndex = 5;
            this.orderbox.SelectedIndexChanged += new System.EventHandler(this.orderbox_SelectedIndexChanged);
            // 
            // orderlist
            // 
            this.orderlist.FormattingEnabled = true;
            this.orderlist.ItemHeight = 15;
            this.orderlist.Location = new System.Drawing.Point(741, 36);
            this.orderlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderlist.Name = "orderlist";
            this.orderlist.Size = new System.Drawing.Size(281, 289);
            this.orderlist.TabIndex = 6;
            this.orderlist.SelectedIndexChanged += new System.EventHandler(this.orderlist_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(455, 110);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(281, 241);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(598, 62);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(138, 22);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pricelabel.Location = new System.Drawing.Point(741, 325);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(70, 26);
            this.pricelabel.TabIndex = 10;
            this.pricelabel.Text = "Price:";
            // 
            // pricesumm
            // 
            this.pricesumm.AutoSize = true;
            this.pricesumm.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pricesumm.Location = new System.Drawing.Point(821, 329);
            this.pricesumm.Name = "pricesumm";
            this.pricesumm.Size = new System.Drawing.Size(21, 20);
            this.pricesumm.TabIndex = 11;
            this.pricesumm.Text = "0";
            this.pricesumm.Click += new System.EventHandler(this.pricesumm_Click);
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(627, 84);
            this.balance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(108, 22);
            this.balance.TabIndex = 12;
            this.balance.Text = "Подсчитать?";
            this.balance.UseVisualStyleBackColor = true;
            this.balance.Click += new System.EventHandler(this.balance_Click);
            // 
            // bag
            // 
            this.bag.AutoSize = true;
            this.bag.Location = new System.Drawing.Point(455, 88);
            this.bag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bag.Name = "bag";
            this.bag.Size = new System.Drawing.Size(150, 19);
            this.bag.TabIndex = 13;
            this.bag.Text = "Добавить пакетик? 300";
            this.bag.UseVisualStyleBackColor = true;
            this.bag.CheckedChanged += new System.EventHandler(this.bag_CheckedChanged);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 360);
            this.Controls.Add(this.bag);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.pricesumm);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.orderlist);
            this.Controls.Add(this.orderbox);
            this.Controls.Add(this.orderl);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.menu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView menu;
        private Label Label;
        private Button add;
        private Label orderl;
        private ComboBox orderbox;
        private ListBox orderlist;
        private PictureBox pictureBox;
        private Button delete;
        private Label pricelabel;
        private Label pricesumm;
        private Button balance;
        private CheckBox bag;
    }
}