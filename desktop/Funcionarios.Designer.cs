
namespace Recepcao
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moveToBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveToBack)).BeginInit();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.H1.Location = new System.Drawing.Point(387, 31);
            this.H1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(197, 41);
            this.H1.TabIndex = 4;
            this.H1.Text = "Funcionarios";
            this.H1.Click += new System.EventHandler(this.H1_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployee.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployee.FlatAppearance.BorderSize = 0;
            this.AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("AddEmployee.Image")));
            this.AddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddEmployee.Location = new System.Drawing.Point(263, 610);
            this.AddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(483, 47);
            this.AddEmployee.TabIndex = 38;
            this.AddEmployee.Text = "Adicionar Funcionario";
            this.AddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.name,
            this.address});
            this.dataGridView1.Location = new System.Drawing.Point(27, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(933, 492);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Codigo";
            this.Cod.MinimumWidth = 6;
            this.Cod.Name = "Cod";
            this.Cod.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Nome";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // address
            // 
            this.address.HeaderText = "Endereço";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Width = 125;
            // 
            // moveToBack
            // 
            this.moveToBack.BackColor = System.Drawing.Color.Transparent;
            this.moveToBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moveToBack.BackgroundImage")));
            this.moveToBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.moveToBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveToBack.Location = new System.Drawing.Point(20, 18);
            this.moveToBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moveToBack.Name = "moveToBack";
            this.moveToBack.Size = new System.Drawing.Size(67, 62);
            this.moveToBack.TabIndex = 5;
            this.moveToBack.TabStop = false;
            this.moveToBack.Click += new System.EventHandler(this.moveToBack_Click);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(987, 714);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.moveToBack);
            this.Controls.Add(this.H1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveToBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.PictureBox moveToBack;
    }
}