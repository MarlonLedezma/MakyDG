namespace MakyDG.Forms
{
    partial class Actualizacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizacion));
            this.lblActualizacion = new System.Windows.Forms.Label();
            this.Progreso = new MakyDG.Controles.CustomProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblActualizacion
            // 
            this.lblActualizacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActualizacion.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizacion.Location = new System.Drawing.Point(0, 0);
            this.lblActualizacion.Name = "lblActualizacion";
            this.lblActualizacion.Size = new System.Drawing.Size(615, 48);
            this.lblActualizacion.TabIndex = 0;
            this.lblActualizacion.Text = "Buscando Actualizacion...";
            this.lblActualizacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Progreso
            // 
            this.Progreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Progreso.ChannelColor = System.Drawing.Color.Transparent;
            this.Progreso.ChannelHeight = 10;
            this.Progreso.ForeBackColor = System.Drawing.Color.White;
            this.Progreso.ForeColor = System.Drawing.Color.Black;
            this.Progreso.Location = new System.Drawing.Point(6, 48);
            this.Progreso.Name = "Progreso";
            this.Progreso.ShowMaximun = true;
            this.Progreso.ShowValue = MakyDG.Controles.TextPosition.Right;
            this.Progreso.Size = new System.Drawing.Size(597, 29);
            this.Progreso.SliderColor = System.Drawing.Color.DarkOrange;
            this.Progreso.SliderHeight = 10;
            this.Progreso.SymbolAfter = "%";
            this.Progreso.SymbolBefore = "";
            this.Progreso.TabIndex = 1;
            // 
            // Actualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 87);
            this.Controls.Add(this.Progreso);
            this.Controls.Add(this.lblActualizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Actualizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblActualizacion;
        private Controles.CustomProgressBar Progreso;
        private System.Windows.Forms.Timer timer;
    }
}