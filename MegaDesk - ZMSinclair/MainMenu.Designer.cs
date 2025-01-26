namespace MegaDesk___ZMSinclair
{
    partial class MainMenu
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
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearchQuotes = new System.Windows.Forms.Button();
            this.btnViewAllQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.AutoSize = true;
            this.btnAddQuote.Location = new System.Drawing.Point(78, 64);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(93, 23);
            this.btnAddQuote.TabIndex = 0;
            this.btnAddQuote.Text = "Add New Quote";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            this.btnAddQuote.Click += new System.EventHandler(this.btnAddQuote_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(78, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearchQuotes
            // 
            this.btnSearchQuotes.AutoSize = true;
            this.btnSearchQuotes.Location = new System.Drawing.Point(78, 155);
            this.btnSearchQuotes.Name = "btnSearchQuotes";
            this.btnSearchQuotes.Size = new System.Drawing.Size(93, 23);
            this.btnSearchQuotes.TabIndex = 2;
            this.btnSearchQuotes.Text = "Search Quotes";
            this.btnSearchQuotes.UseVisualStyleBackColor = true;
            this.btnSearchQuotes.Click += new System.EventHandler(this.btnSearchQuotes_Click);
            // 
            // btnViewAllQuotes
            // 
            this.btnViewAllQuotes.AutoSize = true;
            this.btnViewAllQuotes.Location = new System.Drawing.Point(78, 107);
            this.btnViewAllQuotes.Name = "btnViewAllQuotes";
            this.btnViewAllQuotes.Size = new System.Drawing.Size(93, 23);
            this.btnViewAllQuotes.TabIndex = 3;
            this.btnViewAllQuotes.Text = "View Quotes";
            this.btnViewAllQuotes.UseVisualStyleBackColor = true;
            this.btnViewAllQuotes.Click += new System.EventHandler(this.btnViewAllQuotes_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewAllQuotes);
            this.Controls.Add(this.btnSearchQuotes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddQuote);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearchQuotes;
        private System.Windows.Forms.Button btnViewAllQuotes;
    }
}

