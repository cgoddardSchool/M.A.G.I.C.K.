namespace So_You_Wanna_Make_A_Dnd_Character
{
    partial class CharacterShow
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
            this.CreatePdfBtn = new System.Windows.Forms.Button();
            this.MainFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePdfBtn
            // 
            this.CreatePdfBtn.Location = new System.Drawing.Point(12, 12);
            this.CreatePdfBtn.Name = "CreatePdfBtn";
            this.CreatePdfBtn.Size = new System.Drawing.Size(136, 82);
            this.CreatePdfBtn.TabIndex = 1;
            this.CreatePdfBtn.Text = "Create Pdf";
            this.CreatePdfBtn.UseVisualStyleBackColor = true;
            // 
            // MainFormBtn
            // 
            this.MainFormBtn.Location = new System.Drawing.Point(165, 12);
            this.MainFormBtn.Name = "MainFormBtn";
            this.MainFormBtn.Size = new System.Drawing.Size(202, 82);
            this.MainFormBtn.TabIndex = 2;
            this.MainFormBtn.Text = "Create Another Character";
            this.MainFormBtn.UseVisualStyleBackColor = true;
            this.MainFormBtn.Click += new System.EventHandler(this.MainFormBtn_Click);
            // 
            // CharacterShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 106);
            this.Controls.Add(this.MainFormBtn);
            this.Controls.Add(this.CreatePdfBtn);
            this.Name = "CharacterShow";
            this.Text = "Character Completed";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreatePdfBtn;
        private System.Windows.Forms.Button MainFormBtn;
    }
}