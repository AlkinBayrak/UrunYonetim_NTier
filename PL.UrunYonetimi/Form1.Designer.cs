namespace PL.UrunYonetimi
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            grpProducts = new GroupBox();
            dgvProducts = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 60);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Product Price";
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(116, 57);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 3;
            // 
            // grpProducts
            // 
            grpProducts.Controls.Add(dgvProducts);
            grpProducts.Controls.Add(btnUpdate);
            grpProducts.Controls.Add(txtName);
            grpProducts.Controls.Add(btnDelete);
            grpProducts.Controls.Add(txtPrice);
            grpProducts.Controls.Add(btnAdd);
            grpProducts.Controls.Add(label1);
            grpProducts.Controls.Add(label2);
            grpProducts.Location = new Point(36, 45);
            grpProducts.Name = "grpProducts";
            grpProducts.Size = new Size(257, 356);
            grpProducts.TabIndex = 4;
            grpProducts.TabStop = false;
            grpProducts.Text = "groupBox1";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(6, 170);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(245, 169);
            dgvProducts.TabIndex = 5;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(90, 126);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(162, 97);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 97);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpProducts);
            Name = "Form1";
            Text = "Form1";
            grpProducts.ResumeLayout(false);
            grpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtPrice;
        private GroupBox grpProducts;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvProducts;
    }
}
