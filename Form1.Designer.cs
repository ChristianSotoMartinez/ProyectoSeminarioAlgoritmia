namespace ProyectoSeminarioAlgoritmia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GraphLayout = new System.Windows.Forms.Panel();
            this.matriz = new System.Windows.Forms.DataGridView();
            this.eliminar_Vertice = new System.Windows.Forms.Button();
            this.Graficar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.agregar_Vertice = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matriz)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphLayout
            // 
            this.GraphLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.GraphLayout.Location = new System.Drawing.Point(0, 0);
            this.GraphLayout.Name = "GraphLayout";
            this.GraphLayout.Size = new System.Drawing.Size(434, 450);
            this.GraphLayout.TabIndex = 0;
            // 
            // matriz
            // 
            this.matriz.AllowUserToAddRows = false;
            this.matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matriz.Location = new System.Drawing.Point(452, 12);
            this.matriz.Name = "matriz";
            this.matriz.RowHeadersWidth = 47;
            this.matriz.Size = new System.Drawing.Size(340, 150);
            this.matriz.TabIndex = 1;
            this.matriz.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.matriz_CellClick);
            this.matriz.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.matriz_CellEndEdit);
            this.matriz.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.matriz_CellFormatting);
            this.matriz.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.matriz_CellValueChanged);
            this.matriz.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.matriz_DefaultValuesNeeded);
            // 
            // eliminar_Vertice
            // 
            this.eliminar_Vertice.Location = new System.Drawing.Point(620, 203);
            this.eliminar_Vertice.Name = "eliminar_Vertice";
            this.eliminar_Vertice.Size = new System.Drawing.Size(89, 30);
            this.eliminar_Vertice.TabIndex = 3;
            this.eliminar_Vertice.Text = "Eliminar Vertice";
            this.eliminar_Vertice.UseVisualStyleBackColor = true;
            // 
            // Graficar
            // 
            this.Graficar.Location = new System.Drawing.Point(516, 239);
            this.Graficar.Name = "Graficar";
            this.Graficar.Size = new System.Drawing.Size(193, 30);
            this.Graficar.TabIndex = 4;
            this.Graficar.Text = "Crear Grafo";
            this.Graficar.UseVisualStyleBackColor = true;
            this.Graficar.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(528, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // agregar_Vertice
            // 
            this.agregar_Vertice.Location = new System.Drawing.Point(516, 203);
            this.agregar_Vertice.Name = "agregar_Vertice";
            this.agregar_Vertice.Size = new System.Drawing.Size(89, 30);
            this.agregar_Vertice.TabIndex = 6;
            this.agregar_Vertice.Text = "Agregar Vertice";
            this.agregar_Vertice.UseVisualStyleBackColor = true;
            this.agregar_Vertice.Click += new System.EventHandler(this.agregar_Vertice_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(516, 168);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(193, 30);
            this.reset.TabIndex = 7;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(528, 301);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(528, 327);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "valor";
            this.label1.TextChanged += new System.EventHandler(this.valor);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fila";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Columna";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.agregar_Vertice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Graficar);
            this.Controls.Add(this.eliminar_Vertice);
            this.Controls.Add(this.matriz);
            this.Controls.Add(this.GraphLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GraphLayout;
        private System.Windows.Forms.DataGridView matriz;
        private System.Windows.Forms.Button eliminar_Vertice;
        private System.Windows.Forms.Button Graficar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button agregar_Vertice;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

