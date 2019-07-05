namespace YahtzeeGame
{
    partial class EndGameDialogue
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
            this.pnlPopup = new System.Windows.Forms.TableLayoutPanel();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.pnlPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPopup
            // 
            this.pnlPopup.ColumnCount = 2;
            this.pnlPopup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlPopup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlPopup.Controls.Add(this.btnYes, 0, 1);
            this.pnlPopup.Controls.Add(this.btnNo, 1, 1);
            this.pnlPopup.Controls.Add(this.lblText, 0, 0);
            this.pnlPopup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPopup.Location = new System.Drawing.Point(0, 0);
            this.pnlPopup.Name = "pnlPopup";
            this.pnlPopup.RowCount = 2;
            this.pnlPopup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.pnlPopup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlPopup.Size = new System.Drawing.Size(434, 261);
            this.pnlPopup.TabIndex = 0;
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(10, 192);
            this.btnYes.Margin = new System.Windows.Forms.Padding(10);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(197, 59);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(227, 192);
            this.btnNo.Margin = new System.Windows.Forms.Padding(10);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(197, 59);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblText
            // 
            this.pnlPopup.SetColumnSpan(this.lblText, 2);
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(3, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(428, 182);
            this.lblText.TabIndex = 2;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndGameDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.pnlPopup);
            this.Name = "EndGameDialogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over!";
            this.pnlPopup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlPopup;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblText;
    }
}