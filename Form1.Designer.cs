
namespace WinFormForma2D
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
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lblDiagrama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(12, 21);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(75, 23);
            this.btnCirculo.TabIndex = 0;
            this.btnCirculo.Text = "C";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(12, 68);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(75, 23);
            this.btnRectangulo.TabIndex = 1;
            this.btnRectangulo.Text = "R";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(12, 116);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(75, 23);
            this.btnTriangulo.TabIndex = 2;
            this.btnTriangulo.Text = "T";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(160, 48);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(124, 134);
            this.lstItems.TabIndex = 3;
            // 
            // lblDiagrama
            // 
            this.lblDiagrama.AutoSize = true;
            this.lblDiagrama.Location = new System.Drawing.Point(157, 21);
            this.lblDiagrama.Name = "lblDiagrama";
            this.lblDiagrama.Size = new System.Drawing.Size(55, 13);
            this.lblDiagrama.TabIndex = 4;
            this.lblDiagrama.Text = "Diagrama:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 223);
            this.Controls.Add(this.lblDiagrama);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.btnCirculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label lblDiagrama;
    }
}

