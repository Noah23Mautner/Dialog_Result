namespace DIALOG_RESULT
{
    partial class Form1
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
            this.txtdialogresolt = new System.Windows.Forms.TextBox();
            this.btnotvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdialogresolt
            // 
            this.txtdialogresolt.Location = new System.Drawing.Point(57, 47);
            this.txtdialogresolt.Multiline = true;
            this.txtdialogresolt.Name = "txtdialogresolt";
            this.txtdialogresolt.Size = new System.Drawing.Size(183, 72);
            this.txtdialogresolt.TabIndex = 0;
            // 
            // btnotvori
            // 
            this.btnotvori.Location = new System.Drawing.Point(57, 144);
            this.btnotvori.Name = "btnotvori";
            this.btnotvori.Size = new System.Drawing.Size(183, 37);
            this.btnotvori.TabIndex = 1;
            this.btnotvori.Text = "otvori massagebox";
            this.btnotvori.UseVisualStyleBackColor = true;
            this.btnotvori.Click += new System.EventHandler(this.btnotvori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 247);
            this.Controls.Add(this.btnotvori);
            this.Controls.Add(this.txtdialogresolt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdialogresolt;
        private System.Windows.Forms.Button btnotvori;
    }
}

