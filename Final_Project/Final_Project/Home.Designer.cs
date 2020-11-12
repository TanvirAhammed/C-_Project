namespace Final_Project
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.SellBurgerButton = new System.Windows.Forms.Button();
            this.ManageButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.SellBurgerButton);
            this.panel1.Controls.Add(this.ManageButton);
            this.panel1.Location = new System.Drawing.Point(100, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 578);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(682, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 66);
            this.button3.TabIndex = 0;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SellBurgerButton
            // 
            this.SellBurgerButton.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellBurgerButton.Location = new System.Drawing.Point(422, 243);
            this.SellBurgerButton.Name = "SellBurgerButton";
            this.SellBurgerButton.Size = new System.Drawing.Size(215, 112);
            this.SellBurgerButton.TabIndex = 0;
            this.SellBurgerButton.Text = "Sell Burger\'s";
            this.SellBurgerButton.UseVisualStyleBackColor = true;
            this.SellBurgerButton.Click += new System.EventHandler(this.SellBurgerButton_Click);
            // 
            // ManageButton
            // 
            this.ManageButton.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageButton.Location = new System.Drawing.Point(99, 243);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(210, 112);
            this.ManageButton.TabIndex = 0;
            this.ManageButton.Text = "Manage Seller\'s";
            this.ManageButton.UseVisualStyleBackColor = true;
            this.ManageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 696);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
      
        private System.Windows.Forms.Button ManageButton;
        private System.Windows.Forms.Button SellBurgerButton;
    }
}