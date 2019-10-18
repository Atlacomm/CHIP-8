namespace CHIP8.Controls
{
    partial class KeyQuery
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPressAKey = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPressAKey
            // 
            this.labelPressAKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressAKey.Location = new System.Drawing.Point(3, 3);
            this.labelPressAKey.Name = "labelPressAKey";
            this.labelPressAKey.Size = new System.Drawing.Size(126, 13);
            this.labelPressAKey.TabIndex = 0;
            this.labelPressAKey.Text = "Press a key...";
            this.labelPressAKey.Visible = false;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(3, 3);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(0, 13);
            this.labelText.TabIndex = 1;
            // 
            // KeyQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelPressAKey);
            this.Controls.Add(this.labelText);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "KeyQuery";
            this.Size = new System.Drawing.Size(128, 20);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyQuery_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KeyQuery_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPressAKey;
        private System.Windows.Forms.Label labelText;
    }
}
