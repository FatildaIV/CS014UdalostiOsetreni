namespace CS014UdalostiOsetreni
{
    partial class UdalostiOsetreniForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.souradniceLabel = new System.Windows.Forms.Label();
            this.udalostiListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // souradniceLabel
            // 
            this.souradniceLabel.AutoSize = true;
            this.souradniceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.souradniceLabel.Location = new System.Drawing.Point(638, 412);
            this.souradniceLabel.Name = "souradniceLabel";
            this.souradniceLabel.Size = new System.Drawing.Size(106, 29);
            this.souradniceLabel.TabIndex = 0;
            this.souradniceLabel.Text = "X: ?, Y: ?";
            // 
            // udalostiListBox
            // 
            this.udalostiListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.udalostiListBox.FormattingEnabled = true;
            this.udalostiListBox.ItemHeight = 20;
            this.udalostiListBox.Location = new System.Drawing.Point(454, 12);
            this.udalostiListBox.Name = "udalostiListBox";
            this.udalostiListBox.Size = new System.Drawing.Size(334, 384);
            this.udalostiListBox.TabIndex = 1;
            // 
            // UdalostiOsetreniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.udalostiListBox);
            this.Controls.Add(this.souradniceLabel);
            this.Name = "UdalostiOsetreniForm";
            this.Text = "CS014 Ošetření událostí – Jakub Sirový";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UdalostiOsetreniForm_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UdalostiOsetreniForm_MouseDown);
            this.MouseEnter += new System.EventHandler(this.UdalostiOsetreniForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UdalostiOsetreniForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UdalostiOsetreniForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label souradniceLabel;
        private System.Windows.Forms.ListBox udalostiListBox;
    }
}

