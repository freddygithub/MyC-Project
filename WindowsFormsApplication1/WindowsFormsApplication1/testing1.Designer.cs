namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.addToCartButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.shopLabel = new System.Windows.Forms.Label();
            this.cartLabel = new System.Windows.Forms.Label();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.makePurchaseButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(122, 282);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(98, 37);
            this.addToCartButton.TabIndex = 0;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(259, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(172, 20);
            this.title.TabIndex = 1;
            this.title.Text = "My Shop Application";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(16, 90);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(204, 186);
            this.itemsListBox.TabIndex = 3;
            // 
            // shopLabel
            // 
            this.shopLabel.AutoSize = true;
            this.shopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopLabel.Location = new System.Drawing.Point(12, 67);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(103, 20);
            this.shopLabel.TabIndex = 4;
            this.shopLabel.Text = "Store Items";
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartLabel.Location = new System.Drawing.Point(414, 67);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(124, 20);
            this.cartLabel.TabIndex = 6;
            this.cartLabel.Text = "Shopping Cart";
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.Location = new System.Drawing.Point(418, 90);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(210, 186);
            this.cartListBox.TabIndex = 5;
            // 
            // makePurchaseButton
            // 
            this.makePurchaseButton.Location = new System.Drawing.Point(528, 282);
            this.makePurchaseButton.Name = "makePurchaseButton";
            this.makePurchaseButton.Size = new System.Drawing.Size(100, 37);
            this.makePurchaseButton.TabIndex = 7;
            this.makePurchaseButton.Text = "Purchase";
            this.makePurchaseButton.UseVisualStyleBackColor = true;
            this.makePurchaseButton.Click += new System.EventHandler(this.makePurchaseButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.FormattingEnabled = true;
            this.priceTextBox.Location = new System.Drawing.Point(418, 345);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(210, 69);
            this.priceTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 601);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.makePurchaseButton);
            this.Controls.Add(this.cartLabel);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.shopLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.addToCartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Button makePurchaseButton;
        private System.Windows.Forms.ListBox priceTextBox;
    }
}

