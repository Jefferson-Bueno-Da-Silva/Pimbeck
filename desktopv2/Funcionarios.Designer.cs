﻿
namespace desktopv2
{
    partial class Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            this.H1 = new System.Windows.Forms.Label();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.moveToBack = new System.Windows.Forms.PictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.moveToBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.H1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.H1.Location = new System.Drawing.Point(342, 46);
            this.H1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(161, 32);
            this.H1.TabIndex = 4;
            this.H1.Text = "Funcionarios";
            // 
            // AddEmployee
            // 
            this.AddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployee.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployee.FlatAppearance.BorderSize = 0;
            this.AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddEmployee.Location = new System.Drawing.Point(225, 589);
            this.AddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(404, 44);
            this.AddEmployee.TabIndex = 38;
            this.AddEmployee.Text = "Adicionar Funcionario";
            this.AddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // moveToBack
            // 
            this.moveToBack.BackColor = System.Drawing.Color.Transparent;
            this.moveToBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.moveToBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveToBack.Image = ((System.Drawing.Image)(resources.GetObject("moveToBack.Image")));
            this.moveToBack.Location = new System.Drawing.Point(13, 13);
            this.moveToBack.Margin = new System.Windows.Forms.Padding(4);
            this.moveToBack.Name = "moveToBack";
            this.moveToBack.Size = new System.Drawing.Size(42, 45);
            this.moveToBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moveToBack.TabIndex = 5;
            this.moveToBack.TabStop = false;
            this.moveToBack.Click += new System.EventHandler(this.moveToBack_Click);
            // 
            // panel17
            // 
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(829, 29);
            this.panel17.TabIndex = 40;
            this.panel17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel17_MouseDown);
            this.panel17.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel17_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(13, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(816, 461);
            this.dataGridView1.TabIndex = 41;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(845, 655);
            this.Controls.Add(this.moveToBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.H1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moveToBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.PictureBox moveToBack;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}