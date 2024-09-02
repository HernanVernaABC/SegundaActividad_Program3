namespace SegundaActividad
{
    partial class VentanaDB
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
            this.lblContenidoDB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContenidoDB
            // 
            this.lblContenidoDB.AutoSize = true;
            this.lblContenidoDB.Location = new System.Drawing.Point(13, 13);
            this.lblContenidoDB.Name = "lblContenidoDB";
            this.lblContenidoDB.Size = new System.Drawing.Size(73, 13);
            this.lblContenidoDB.TabIndex = 0;
            this.lblContenidoDB.Text = "Contenido DB";
            this.lblContenidoDB.Click += new System.EventHandler(this.lblContenidoDB_Click);
            // 
            // VentanaDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContenidoDB);
            this.Name = "VentanaDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Base de Datos";
            this.Load += new System.EventHandler(this.VentanaDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContenidoDB;
    }
}