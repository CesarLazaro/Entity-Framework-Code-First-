namespace CodeFirst
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
            this.MostrarP = new System.Windows.Forms.Panel();
            this.btnModificicar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowCustomer = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.TimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MostrarP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MostrarP
            // 
            this.MostrarP.BackColor = System.Drawing.Color.Bisque;
            this.MostrarP.Controls.Add(this.button1);
            this.MostrarP.Controls.Add(this.label1);
            this.MostrarP.Controls.Add(this.ShowCustomer);
            this.MostrarP.Controls.Add(this.button2);
            this.MostrarP.Controls.Add(this.txtBuscar);
            this.MostrarP.Location = new System.Drawing.Point(385, 6);
            this.MostrarP.Name = "MostrarP";
            this.MostrarP.Size = new System.Drawing.Size(503, 299);
            this.MostrarP.TabIndex = 42;
            // 
            // btnModificicar
            // 
            this.btnModificicar.Enabled = false;
            this.btnModificicar.Location = new System.Drawing.Point(129, 14);
            this.btnModificicar.Name = "btnModificicar";
            this.btnModificicar.Size = new System.Drawing.Size(101, 39);
            this.btnModificicar.TabIndex = 38;
            this.btnModificicar.Text = "MODIFICAR";
            this.btnModificicar.UseVisualStyleBackColor = true;
            this.btnModificicar.Click += new System.EventHandler(this.btnModificicar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(238, 14);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 39);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(27, 14);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(101, 39);
            this.btnInsertar.TabIndex = 36;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "MOSTAR TODOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "SELECCIONE EL ID";
            // 
            // ShowCustomer
            // 
            this.ShowCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowCustomer.Location = new System.Drawing.Point(23, 79);
            this.ShowCustomer.MultiSelect = false;
            this.ShowCustomer.Name = "ShowCustomer";
            this.ShowCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowCustomer.Size = new System.Drawing.Size(469, 205);
            this.ShowCustomer.TabIndex = 1;
            this.ShowCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowCustomer_CellClick);
            this.ShowCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowCustomer_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(180, 45);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(142, 20);
            this.txtBuscar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "StartDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 20);
            this.txtName.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.TimeStartDate);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 226);
            this.panel1.TabIndex = 43;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(129, 77);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(170, 99);
            this.txtDescription.TabIndex = 7;
            // 
            // TimeStartDate
            // 
            this.TimeStartDate.Location = new System.Drawing.Point(121, 194);
            this.TimeStartDate.Name = "TimeStartDate";
            this.TimeStartDate.Size = new System.Drawing.Size(200, 20);
            this.TimeStartDate.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.btnModificicar);
            this.panel2.Controls.Add(this.btnInsertar);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Location = new System.Drawing.Point(12, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 68);
            this.panel2.TabIndex = 44;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(129, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(153, 20);
            this.txtID.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(900, 338);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MostrarP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MostrarP.ResumeLayout(false);
            this.MostrarP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MostrarP;
        private System.Windows.Forms.Button btnModificicar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ShowCustomer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker TimeStartDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
    }
}

