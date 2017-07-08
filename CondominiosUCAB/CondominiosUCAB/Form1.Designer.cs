namespace CondominiosUCAB
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
            this.insertD = new System.Windows.Forms.Button();
            this.data1 = new System.Windows.Forms.TextBox();
            this.data2 = new System.Windows.Forms.TextBox();
            this.data3 = new System.Windows.Forms.TextBox();
            this.deleteD = new System.Windows.Forms.Button();
            this.updateD = new System.Windows.Forms.Button();
            this.consultD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // insertD
            // 
            this.insertD.Location = new System.Drawing.Point(222, 50);
            this.insertD.Name = "insertD";
            this.insertD.Size = new System.Drawing.Size(75, 23);
            this.insertD.TabIndex = 0;
            this.insertD.Text = "Insert";
            this.insertD.UseVisualStyleBackColor = true;
            this.insertD.Click += new System.EventHandler(this.insertD_Click);
            // 
            // data1
            // 
            this.data1.Location = new System.Drawing.Point(37, 52);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(152, 20);
            this.data1.TabIndex = 1;
            this.data1.Text = "ID";
            // 
            // data2
            // 
            this.data2.Location = new System.Drawing.Point(37, 88);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(152, 20);
            this.data2.TabIndex = 2;
            this.data2.Text = "Name";
            // 
            // data3
            // 
            this.data3.Location = new System.Drawing.Point(37, 124);
            this.data3.Name = "data3";
            this.data3.Size = new System.Drawing.Size(152, 20);
            this.data3.TabIndex = 3;
            this.data3.Text = "Need";
            // 
            // deleteD
            // 
            this.deleteD.Location = new System.Drawing.Point(222, 88);
            this.deleteD.Name = "deleteD";
            this.deleteD.Size = new System.Drawing.Size(75, 23);
            this.deleteD.TabIndex = 4;
            this.deleteD.Text = "Delete";
            this.deleteD.UseVisualStyleBackColor = true;
            this.deleteD.Click += new System.EventHandler(this.deleteD_Click);
            // 
            // updateD
            // 
            this.updateD.Location = new System.Drawing.Point(222, 124);
            this.updateD.Name = "updateD";
            this.updateD.Size = new System.Drawing.Size(75, 23);
            this.updateD.TabIndex = 5;
            this.updateD.Text = "Update";
            this.updateD.UseVisualStyleBackColor = true;
            this.updateD.Click += new System.EventHandler(this.updateD_Click);
            // 
            // consultD
            // 
            this.consultD.Location = new System.Drawing.Point(150, 178);
            this.consultD.Name = "consultD";
            this.consultD.Size = new System.Drawing.Size(75, 23);
            this.consultD.TabIndex = 6;
            this.consultD.Text = "Consult";
            this.consultD.UseVisualStyleBackColor = true;
            this.consultD.Click += new System.EventHandler(this.consultD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 308);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 332);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.consultD);
            this.Controls.Add(this.updateD);
            this.Controls.Add(this.deleteD);
            this.Controls.Add(this.data3);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.insertD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertD;
        private System.Windows.Forms.TextBox data1;
        private System.Windows.Forms.TextBox data2;
        private System.Windows.Forms.TextBox data3;
        private System.Windows.Forms.Button deleteD;
        private System.Windows.Forms.Button updateD;
        private System.Windows.Forms.Button consultD;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

