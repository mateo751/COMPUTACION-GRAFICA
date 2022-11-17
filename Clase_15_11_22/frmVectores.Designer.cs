
namespace Clase_15_11_22
{
    partial class frmVectores
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.btnDibujarEje = new System.Windows.Forms.Button();
            this.txtPuntoY = new System.Windows.Forms.Label();
            this.txtPuntoX = new System.Windows.Forms.Label();
            this.btnDibujarVector = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picCanvas);
            this.groupBox3.Location = new System.Drawing.Point(258, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 449);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grafica";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(6, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(400, 400);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numY);
            this.groupBox4.Controls.Add(this.numX);
            this.groupBox4.Controls.Add(this.btnDibujarEje);
            this.groupBox4.Controls.Add(this.txtPuntoY);
            this.groupBox4.Controls.Add(this.txtPuntoX);
            this.groupBox4.Controls.Add(this.btnDibujarVector);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 449);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vector";
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(108, 75);
            this.numY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(83, 20);
            this.numY.TabIndex = 4;
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(108, 49);
            this.numX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(83, 20);
            this.numX.TabIndex = 3;
            // 
            // btnDibujarEje
            // 
            this.btnDibujarEje.Location = new System.Drawing.Point(29, 172);
            this.btnDibujarEje.Name = "btnDibujarEje";
            this.btnDibujarEje.Size = new System.Drawing.Size(76, 33);
            this.btnDibujarEje.TabIndex = 2;
            this.btnDibujarEje.Text = "Dibujar Ejes";
            this.btnDibujarEje.UseVisualStyleBackColor = true;
            this.btnDibujarEje.Click += new System.EventHandler(this.btnDibujarEje_Click);
            // 
            // txtPuntoY
            // 
            this.txtPuntoY.AutoSize = true;
            this.txtPuntoY.Location = new System.Drawing.Point(37, 75);
            this.txtPuntoY.Name = "txtPuntoY";
            this.txtPuntoY.Size = new System.Drawing.Size(48, 13);
            this.txtPuntoY.TabIndex = 2;
            this.txtPuntoY.Text = "Punto Y:";
            // 
            // txtPuntoX
            // 
            this.txtPuntoX.AutoSize = true;
            this.txtPuntoX.Location = new System.Drawing.Point(37, 49);
            this.txtPuntoX.Name = "txtPuntoX";
            this.txtPuntoX.Size = new System.Drawing.Size(48, 13);
            this.txtPuntoX.TabIndex = 1;
            this.txtPuntoX.Text = "Punto X:";
            // 
            // btnDibujarVector
            // 
            this.btnDibujarVector.Location = new System.Drawing.Point(129, 172);
            this.btnDibujarVector.Name = "btnDibujarVector";
            this.btnDibujarVector.Size = new System.Drawing.Size(85, 33);
            this.btnDibujarVector.TabIndex = 0;
            this.btnDibujarVector.Text = "Dibujar Vector";
            this.btnDibujarVector.UseVisualStyleBackColor = true;
            this.btnDibujarVector.Click += new System.EventHandler(this.btnDibujarVector_Click);
            // 
            // frmVectores
            // 
            this.ClientSize = new System.Drawing.Size(703, 473);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmVectores";
            this.Text = "Control de vectores";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion       
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label txtPuntoX;
        private System.Windows.Forms.Button btnDibujarVector;
        private System.Windows.Forms.Button btnDibujarEje;
        private System.Windows.Forms.Label txtPuntoY;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numX;
    }
}

