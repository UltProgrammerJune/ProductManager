namespace ProductManager
{
    partial class Form1
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
            addBtn = new Button();
            label1 = new Label();
            productTxt = new TextBox();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(28, 131);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(115, 67);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add Product";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 77);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            // 
            // productTxt
            // 
            productTxt.Location = new Point(169, 77);
            productTxt.Name = "productTxt";
            productTxt.Size = new Size(100, 23);
            productTxt.TabIndex = 2;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(169, 131);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(115, 67);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 258);
            Controls.Add(exitBtn);
            Controls.Add(productTxt);
            Controls.Add(label1);
            Controls.Add(addBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private Label label1;
        private TextBox productTxt;
        private Button exitBtn;
    }
}
