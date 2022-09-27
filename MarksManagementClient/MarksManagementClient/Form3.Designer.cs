namespace MarksManagementClient
{
    partial class Form3
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
            this.BackHome = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BackHome
            // 
            this.BackHome.Location = new System.Drawing.Point(530, 482);
            this.BackHome.Name = "BackHome";
            this.BackHome.Size = new System.Drawing.Size(102, 40);
            this.BackHome.TabIndex = 22;
            this.BackHome.Text = "Okay";
            this.BackHome.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(65, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(199, 20);
            this.label22.TabIndex = 21;
            this.label22.Text = "Results of the searched ID";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(69, 119);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(973, 357);
            this.listView2.TabIndex = 20;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 612);
            this.Controls.Add(this.BackHome);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.listView2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackHome;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ListView listView2;
    }
}