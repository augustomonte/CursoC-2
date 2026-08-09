namespace ManejoExceptions
{
    partial class frmExcepciones
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(111, 132);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(154, 26);
            this.txt2.TabIndex = 0;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(111, 66);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(154, 26);
            this.txt1.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(146, 188);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(78, 34);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.TabStop = false;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(156, 248);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(18, 20);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "=";
            // 
            // frmExcepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 461);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExcepciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exceptions";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResult;
    }
}

