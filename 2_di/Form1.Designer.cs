namespace _2_di
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrudDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrudDB
            // 
            this.btnCrudDB.Location = new System.Drawing.Point(12, 12);
            this.btnCrudDB.Name = "btnCrudDB";
            this.btnCrudDB.Size = new System.Drawing.Size(136, 42);
            this.btnCrudDB.TabIndex = 0;
            this.btnCrudDB.Text = "Product - CRUD  DB";
            this.btnCrudDB.UseVisualStyleBackColor = true;
            this.btnCrudDB.Click += new System.EventHandler(this.btnCrudDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrudDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCrudDB;
    }
}