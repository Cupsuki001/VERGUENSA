namespace WinFormsApp1
{
    partial class Depreciacion
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Vehiculo");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Edificio");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("E.de mobiliario");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("DEPRECIACION", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            this.label2 = new System.Windows.Forms.Label();
            this.MASKEDvalor = new System.Windows.Forms.MaskedTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.TXBresultado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.BTNlimpiar = new System.Windows.Forms.Button();
            this.BTNcalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(198, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "VALOR";
            // 
            // MASKEDvalor
            // 
            this.MASKEDvalor.BackColor = System.Drawing.Color.Lavender;
            this.MASKEDvalor.Location = new System.Drawing.Point(198, 51);
            this.MASKEDvalor.Mask = "999999";
            this.MASKEDvalor.Name = "MASKEDvalor";
            this.MASKEDvalor.Size = new System.Drawing.Size(121, 23);
            this.MASKEDvalor.TabIndex = 13;
            this.MASKEDvalor.ValidatingType = typeof(int);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(18, 33);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "Nodo1";
            treeNode9.Text = "Vehiculo";
            treeNode10.Name = "Nodo2";
            treeNode10.Text = "Edificio";
            treeNode11.Name = "Nodo3";
            treeNode11.Text = "E.de mobiliario";
            treeNode12.Name = "Nodo0";
            treeNode12.Text = "DEPRECIACION";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(121, 102);
            this.treeView1.TabIndex = 15;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(198, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Depreciacion";
            // 
            // TXBresultado
            // 
            this.TXBresultado.BackColor = System.Drawing.Color.Lavender;
            this.TXBresultado.Location = new System.Drawing.Point(198, 162);
            this.TXBresultado.Name = "TXBresultado";
            this.TXBresultado.Size = new System.Drawing.Size(121, 23);
            this.TXBresultado.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 40);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depreciacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "NINGUNA";
            // 
            // BTNsalir
            // 
            this.BTNsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNsalir.Location = new System.Drawing.Point(244, 234);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 23;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = false;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // BTNlimpiar
            // 
            this.BTNlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNlimpiar.Location = new System.Drawing.Point(132, 234);
            this.BTNlimpiar.Name = "BTNlimpiar";
            this.BTNlimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNlimpiar.TabIndex = 21;
            this.BTNlimpiar.Text = "Limpiar";
            this.BTNlimpiar.UseVisualStyleBackColor = false;
            this.BTNlimpiar.Click += new System.EventHandler(this.BTNlimpiar_Click);
            // 
            // BTNcalcular
            // 
            this.BTNcalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNcalcular.Location = new System.Drawing.Point(18, 234);
            this.BTNcalcular.Name = "BTNcalcular";
            this.BTNcalcular.Size = new System.Drawing.Size(75, 23);
            this.BTNcalcular.TabIndex = 20;
            this.BTNcalcular.Text = "Calcular";
            this.BTNcalcular.UseVisualStyleBackColor = false;
            this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcular_Click);
            // 
            // Depreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(337, 291);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNlimpiar);
            this.Controls.Add(this.BTNcalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TXBresultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MASKEDvalor);
            this.Name = "Depreciacion";
            this.Text = "Depreciacion";
            this.Load += new System.EventHandler(this.Depreciacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private MaskedTextBox MASKEDvalor;
        private TreeView treeView1;
        private Label label1;
        private TextBox TXBresultado;
        private GroupBox groupBox1;
        private Label label5;
        private Button BTNsalir;
        private Button BTNlimpiar;
        private Button BTNcalcular;
    }
}