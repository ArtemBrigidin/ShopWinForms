namespace WinFormsApp4
{
    partial class MainWindow
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
            ShopsListBox = new ListBox();
            ProductsListBox = new ListBox();
            addShop_btn = new Button();
            nameShopTextBox = new TextBox();
            addItemToShop = new Button();
            ItemName = new TextBox();
            SuspendLayout();
            // 
            // ShopsListBox
            // 
            ShopsListBox.FormattingEnabled = true;
            ShopsListBox.ItemHeight = 15;
            ShopsListBox.Location = new Point(26, 12);
            ShopsListBox.Name = "ShopsListBox";
            ShopsListBox.Size = new Size(166, 364);
            ShopsListBox.TabIndex = 0;
            ShopsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ProductsListBox
            // 
            ProductsListBox.FormattingEnabled = true;
            ProductsListBox.ItemHeight = 15;
            ProductsListBox.Location = new Point(292, 12);
            ProductsListBox.Name = "ProductsListBox";
            ProductsListBox.Size = new Size(166, 364);
            ProductsListBox.TabIndex = 1;
            // 
            // addShop_btn
            // 
            addShop_btn.Location = new Point(26, 421);
            addShop_btn.Name = "addShop_btn";
            addShop_btn.Size = new Size(166, 23);
            addShop_btn.TabIndex = 2;
            addShop_btn.Text = "Добавить магазин";
            addShop_btn.UseVisualStyleBackColor = true;
            addShop_btn.Click += addShop_btn_Click;
            // 
            // nameShopTextBox
            // 
            nameShopTextBox.Location = new Point(26, 392);
            nameShopTextBox.Name = "nameShopTextBox";
            nameShopTextBox.PlaceholderText = "Название магазина";
            nameShopTextBox.Size = new Size(166, 23);
            nameShopTextBox.TabIndex = 5;
            // 
            // addItemToShop
            // 
            addItemToShop.Location = new Point(292, 420);
            addItemToShop.Name = "addItemToShop";
            addItemToShop.Size = new Size(166, 23);
            addItemToShop.TabIndex = 6;
            addItemToShop.Text = "Добавить продукт";
            addItemToShop.UseVisualStyleBackColor = true;
            addItemToShop.Click += addItemToShop_Click;
            // 
            // ItemName
            // 
            ItemName.Location = new Point(292, 391);
            ItemName.Name = "ItemName";
            ItemName.PlaceholderText = "Название продукта";
            ItemName.Size = new Size(166, 23);
            ItemName.TabIndex = 8;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 454);
            Controls.Add(ItemName);
            Controls.Add(addItemToShop);
            Controls.Add(nameShopTextBox);
            Controls.Add(addShop_btn);
            Controls.Add(ProductsListBox);
            Controls.Add(ShopsListBox);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ShopsListBox;
        private ListBox ProductsListBox;
        private Button addShop_btn;
        protected TextBox nameShopTextBox;
        private Button addItemToShop;
        private TextBox ItemName;
    }
}