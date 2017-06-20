namespace VerkiezingRegelaar
{
    partial class NieuwVerkiezing
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
            this.checkedListBoxPartijen = new System.Windows.Forms.CheckedListBox();
            this.textBoxNaam = new System.Windows.Forms.TextBox();
            this.numericUpDownZetels = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonToevoegen = new System.Windows.Forms.Button();
            this.buttonAnnuleren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZetels)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxPartijen
            // 
            this.checkedListBoxPartijen.FormattingEnabled = true;
            this.checkedListBoxPartijen.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxPartijen.Name = "checkedListBoxPartijen";
            this.checkedListBoxPartijen.Size = new System.Drawing.Size(395, 276);
            this.checkedListBoxPartijen.TabIndex = 0;
            // 
            // textBoxNaam
            // 
            this.textBoxNaam.Location = new System.Drawing.Point(79, 294);
            this.textBoxNaam.Name = "textBoxNaam";
            this.textBoxNaam.Size = new System.Drawing.Size(328, 22);
            this.textBoxNaam.TabIndex = 2;
            // 
            // numericUpDownZetels
            // 
            this.numericUpDownZetels.Location = new System.Drawing.Point(287, 338);
            this.numericUpDownZetels.Name = "numericUpDownZetels";
            this.numericUpDownZetels.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownZetels.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aantal zetels:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naam:";
            // 
            // buttonToevoegen
            // 
            this.buttonToevoegen.Location = new System.Drawing.Point(266, 366);
            this.buttonToevoegen.Name = "buttonToevoegen";
            this.buttonToevoegen.Size = new System.Drawing.Size(141, 62);
            this.buttonToevoegen.TabIndex = 7;
            this.buttonToevoegen.Text = "Toevoegen";
            this.buttonToevoegen.UseVisualStyleBackColor = true;
            this.buttonToevoegen.Click += new System.EventHandler(this.buttonToevoegen_Click);
            // 
            // buttonAnnuleren
            // 
            this.buttonAnnuleren.Location = new System.Drawing.Point(12, 366);
            this.buttonAnnuleren.Name = "buttonAnnuleren";
            this.buttonAnnuleren.Size = new System.Drawing.Size(141, 62);
            this.buttonAnnuleren.TabIndex = 8;
            this.buttonAnnuleren.Text = "Annuleren";
            this.buttonAnnuleren.UseVisualStyleBackColor = true;
            this.buttonAnnuleren.Click += new System.EventHandler(this.buttonAnnuleren_Click);
            // 
            // NieuwVerkiezing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 447);
            this.Controls.Add(this.buttonAnnuleren);
            this.Controls.Add(this.buttonToevoegen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownZetels);
            this.Controls.Add(this.textBoxNaam);
            this.Controls.Add(this.checkedListBoxPartijen);
            this.Name = "NieuwVerkiezing";
            this.Text = "NieuwVerkiezing";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZetels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxPartijen;
        private System.Windows.Forms.TextBox textBoxNaam;
        private System.Windows.Forms.NumericUpDown numericUpDownZetels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonToevoegen;
        private System.Windows.Forms.Button buttonAnnuleren;
    }
}