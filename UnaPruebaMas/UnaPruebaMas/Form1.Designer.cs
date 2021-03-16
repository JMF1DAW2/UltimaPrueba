
namespace UnaPruebaMas
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
            this.BIntroducir = new System.Windows.Forms.Button();
            this.tbRESULTADO = new System.Windows.Forms.TextBox();
            this.tbIntroducir = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbIntroducir)).BeginInit();
            this.SuspendLayout();
            // 
            // BIntroducir
            // 
            this.BIntroducir.Location = new System.Drawing.Point(98, 284);
            this.BIntroducir.Name = "BIntroducir";
            this.BIntroducir.Size = new System.Drawing.Size(100, 23);
            this.BIntroducir.TabIndex = 0;
            this.BIntroducir.Text = "Introducir Edad";
            this.BIntroducir.UseVisualStyleBackColor = true;
            this.BIntroducir.Click += new System.EventHandler(this.BIntroducir_Click);
            // 
            // tbRESULTADO
            // 
            this.tbRESULTADO.Location = new System.Drawing.Point(108, 75);
            this.tbRESULTADO.Multiline = true;
            this.tbRESULTADO.Name = "tbRESULTADO";
            this.tbRESULTADO.ReadOnly = true;
            this.tbRESULTADO.Size = new System.Drawing.Size(100, 90);
            this.tbRESULTADO.TabIndex = 2;
            // 
            // tbIntroducir
            // 
            this.tbIntroducir.Location = new System.Drawing.Point(98, 218);
            this.tbIntroducir.Name = "tbIntroducir";
            this.tbIntroducir.Size = new System.Drawing.Size(120, 20);
            this.tbIntroducir.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "BOTON INUTIL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbIntroducir);
            this.Controls.Add(this.tbRESULTADO);
            this.Controls.Add(this.BIntroducir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbIntroducir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BIntroducir;
        private System.Windows.Forms.TextBox tbRESULTADO;
        private System.Windows.Forms.NumericUpDown tbIntroducir;
        private System.Windows.Forms.Button button1;
    }
}

