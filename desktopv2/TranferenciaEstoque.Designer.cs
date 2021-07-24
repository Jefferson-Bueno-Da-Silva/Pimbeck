
namespace desktopv2
{
    partial class TranferenciaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranferenciaEstoque));
            this.H1 = new System.Windows.Forms.Label();
            this.moveToBack = new System.Windows.Forms.PictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.qtdTextBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moveToBack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.H1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.H1.Location = new System.Drawing.Point(57, 29);
            this.H1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(232, 32);
            this.H1.TabIndex = 4;
            this.H1.Text = "Estoque de destino";
            // 
            // moveToBack
            // 
            this.moveToBack.BackColor = System.Drawing.Color.Transparent;
            this.moveToBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.moveToBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveToBack.Image = ((System.Drawing.Image)(resources.GetObject("moveToBack.Image")));
            this.moveToBack.Location = new System.Drawing.Point(24, 29);
            this.moveToBack.Margin = new System.Windows.Forms.Padding(4);
            this.moveToBack.Name = "moveToBack";
            this.moveToBack.Size = new System.Drawing.Size(26, 32);
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
            this.panel17.TabIndex = 44;
            this.panel17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel17_MouseDown);
            this.panel17.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel17_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(24, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 1);
            this.panel1.TabIndex = 93;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.AddEmployee);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.codigoTextBox);
            this.groupBox1.Controls.Add(this.qtdTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(24, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 308);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origem de tranferencia";
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(587, 114);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(201, 23);
            this.comboBox.TabIndex = 108;
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
            this.AddEmployee.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddEmployee.Location = new System.Drawing.Point(225, 175);
            this.AddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(354, 33);
            this.AddEmployee.TabIndex = 107;
            this.AddEmployee.Text = "Transferir";
            this.AddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(530, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 103;
            this.label5.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(8, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 101;
            this.label2.Text = "Codigo:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.codigoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoTextBox.Location = new System.Drawing.Point(64, 112);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codigoTextBox.Multiline = true;
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(202, 23);
            this.codigoTextBox.TabIndex = 100;
            // 
            // qtdTextBox
            // 
            this.qtdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.qtdTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.qtdTextBox.Location = new System.Drawing.Point(310, 112);
            this.qtdTextBox.Name = "qtdTextBox";
            this.qtdTextBox.Size = new System.Drawing.Size(213, 23);
            this.qtdTextBox.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(273, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 97;
            this.label4.Text = "Qtd:";
            // 
            // TranferenciaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(864, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.moveToBack);
            this.Controls.Add(this.H1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TranferenciaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TranferenciaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moveToBack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.PictureBox moveToBack;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.NumericUpDown qtdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.ComboBox comboBox;
    }
}