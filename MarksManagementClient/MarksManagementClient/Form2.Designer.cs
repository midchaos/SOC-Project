namespace MarksManagementClient
{
    partial class Form2
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
            this.label21 = new System.Windows.Forms.Label();
            this.sub2_a = new System.Windows.Forms.NumericUpDown();
            this.sub1_a = new System.Windows.Forms.NumericUpDown();
            this.sem_a = new System.Windows.Forms.NumericUpDown();
            this.sub3_a = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.confirmaddmarks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sub2_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub1_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sem_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub3_a)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(267, 266);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 20);
            this.label21.TabIndex = 52;
            this.label21.Text = "Physics";
            // 
            // sub2_a
            // 
            this.sub2_a.Location = new System.Drawing.Point(347, 217);
            this.sub2_a.Name = "sub2_a";
            this.sub2_a.Size = new System.Drawing.Size(122, 26);
            this.sub2_a.TabIndex = 51;
            // 
            // sub1_a
            // 
            this.sub1_a.Location = new System.Drawing.Point(347, 174);
            this.sub1_a.Name = "sub1_a";
            this.sub1_a.Size = new System.Drawing.Size(122, 26);
            this.sub1_a.TabIndex = 50;
            // 
            // sem_a
            // 
            this.sem_a.Location = new System.Drawing.Point(347, 130);
            this.sem_a.Name = "sem_a";
            this.sem_a.Size = new System.Drawing.Size(122, 26);
            this.sem_a.TabIndex = 49;
            // 
            // sub3_a
            // 
            this.sub3_a.Location = new System.Drawing.Point(347, 264);
            this.sub3_a.Name = "sub3_a";
            this.sub3_a.Size = new System.Drawing.Size(122, 26);
            this.sub3_a.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(248, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 20);
            this.label17.TabIndex = 48;
            this.label17.Text = "Chemistry";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(274, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 20);
            this.label18.TabIndex = 47;
            this.label18.Text = "Maths";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(259, 135);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 20);
            this.label19.TabIndex = 46;
            this.label19.Text = "Semester";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(222, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(357, 20);
            this.label20.TabIndex = 45;
            this.label20.Text = "Enter the following details to add new sem marks:";
            // 
            // confirmaddmarks
            // 
            this.confirmaddmarks.Location = new System.Drawing.Point(304, 325);
            this.confirmaddmarks.Name = "confirmaddmarks";
            this.confirmaddmarks.Size = new System.Drawing.Size(142, 42);
            this.confirmaddmarks.TabIndex = 44;
            this.confirmaddmarks.Text = "Add New Marks";
            this.confirmaddmarks.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.sub2_a);
            this.Controls.Add(this.sub1_a);
            this.Controls.Add(this.sem_a);
            this.Controls.Add(this.sub3_a);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.confirmaddmarks);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sub2_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub1_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sem_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub3_a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown sub2_a;
        private System.Windows.Forms.NumericUpDown sub1_a;
        private System.Windows.Forms.NumericUpDown sem_a;
        private System.Windows.Forms.NumericUpDown sub3_a;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button confirmaddmarks;
    }
}