namespace VerkiezingRegelaar
{
    partial class Verkiezingen
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
            this.listBoxVerkiezingen = new System.Windows.Forms.ListBox();
            this.ButtonOpenen = new System.Windows.Forms.Button();
            this.buttonNieuw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxVerkiezingen
            // 
            this.listBoxVerkiezingen.FormattingEnabled = true;
            this.listBoxVerkiezingen.ItemHeight = 16;
            this.listBoxVerkiezingen.Location = new System.Drawing.Point(12, 12);
            this.listBoxVerkiezingen.Name = "listBoxVerkiezingen";
            this.listBoxVerkiezingen.Size = new System.Drawing.Size(564, 324);
            this.listBoxVerkiezingen.TabIndex = 0;
            // 
            // ButtonOpenen
            // 
            this.ButtonOpenen.Location = new System.Drawing.Point(582, 12);
            this.ButtonOpenen.Name = "ButtonOpenen";
            this.ButtonOpenen.Size = new System.Drawing.Size(186, 86);
            this.ButtonOpenen.TabIndex = 2;
            this.ButtonOpenen.Text = "Openen";
            this.ButtonOpenen.UseVisualStyleBackColor = true;
            this.ButtonOpenen.Click += new System.EventHandler(this.ButtonOpenen_Click);
            // 
            // buttonNieuw
            // 
            this.buttonNieuw.Location = new System.Drawing.Point(582, 104);
            this.buttonNieuw.Name = "buttonNieuw";
            this.buttonNieuw.Size = new System.Drawing.Size(186, 86);
            this.buttonNieuw.TabIndex = 3;
            this.buttonNieuw.Text = "Nieuwe verkiezing";
            this.buttonNieuw.UseVisualStyleBackColor = true;
            // 
            // Verkiezingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 373);
            this.Controls.Add(this.buttonNieuw);
            this.Controls.Add(this.ButtonOpenen);
            this.Controls.Add(this.listBoxVerkiezingen);
            this.Name = "Verkiezingen";
            this.Text = "Verkiezingen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVerkiezingen;
        private System.Windows.Forms.Button ButtonOpenen;
        private System.Windows.Forms.Button buttonNieuw;
    }
}

