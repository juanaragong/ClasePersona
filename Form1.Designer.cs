namespace WinFormsApp2
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
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtnumTelefono = new TextBox();
            label5 = new Label();
            txtDomicilio = new TextBox();
            label4 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtIne = new TextBox();
            label1 = new Label();
            lbVDatos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtnumTelefono);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIne);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(35, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(736, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la persona";
            // 
            // button4
            // 
            button4.Location = new Point(629, 188);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 13;
            button4.Text = "Visualizar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(529, 188);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(429, 188);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(329, 188);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtnumTelefono
            // 
            txtnumTelefono.Location = new Point(546, 128);
            txtnumTelefono.Name = "txtnumTelefono";
            txtnumTelefono.Size = new Size(125, 27);
            txtnumTelefono.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 135);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 8;
            label5.Text = "Teledono";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(116, 124);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(307, 27);
            txtDomicilio.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 135);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 6;
            label4.Text = "Domicilio";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(546, 91);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 90);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(307, 27);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 90);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtIne
            // 
            txtIne.Location = new Point(116, 35);
            txtIne.Name = "txtIne";
            txtIne.Size = new Size(125, 27);
            txtIne.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 39);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero INE";
            // 
            // lbVDatos
            // 
            lbVDatos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lbVDatos.GridLines = true;
            lbVDatos.Location = new Point(46, 291);
            lbVDatos.Name = "lbVDatos";
            lbVDatos.Size = new Size(725, 121);
            lbVDatos.TabIndex = 1;
            lbVDatos.UseCompatibleStateImageBehavior = false;
            lbVDatos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ine";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Edad";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Domicilio";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefono";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbVDatos);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtnumTelefono;
        private Label label5;
        private TextBox txtDomicilio;
        private Label label4;
        private TextBox txtEdad;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtIne;
        private Label label1;
        private Button button4;
        private ListView lbVDatos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}
