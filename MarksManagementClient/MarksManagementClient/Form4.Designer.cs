namespace MarksManagementClient
{
    partial class Form4
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
            this.addmarks = new System.Windows.Forms.Button();
            this.mar_u = new System.Windows.Forms.NumericUpDown();
            this.sub_u = new System.Windows.Forms.NumericUpDown();
            this.sem_u = new System.Windows.Forms.NumericUpDown();
            this.DelSem = new System.Windows.Forms.NumericUpDown();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mar_u)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_u)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sem_u)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelSem)).BeginInit();
            this.SuspendLayout();
            // 
            // addmarks
            // 
            this.addmarks.Location = new System.Drawing.Point(805, 58);
            this.addmarks.Name = "addmarks";
            this.addmarks.Size = new System.Drawing.Size(142, 42);
            this.addmarks.TabIndex = 51;
            this.addmarks.Text = "Add New Marks";
            this.addmarks.UseVisualStyleBackColor = true;
            // 
            // mar_u
            // 
            this.mar_u.Location = new System.Drawing.Point(787, 459);
            this.mar_u.Name = "mar_u";
            this.mar_u.Size = new System.Drawing.Size(100, 26);
            this.mar_u.TabIndex = 50;
            // 
            // sub_u
            // 
            this.sub_u.Location = new System.Drawing.Point(787, 418);
            this.sub_u.Name = "sub_u";
            this.sub_u.Size = new System.Drawing.Size(100, 26);
            this.sub_u.TabIndex = 49;
            // 
            // sem_u
            // 
            this.sem_u.Location = new System.Drawing.Point(787, 376);
            this.sem_u.Name = "sem_u";
            this.sem_u.Size = new System.Drawing.Size(100, 26);
            this.sem_u.TabIndex = 48;
            // 
            // DelSem
            // 
            this.DelSem.Location = new System.Drawing.Point(735, 235);
            this.DelSem.Name = "DelSem";
            this.DelSem.Size = new System.Drawing.Size(120, 26);
            this.DelSem.TabIndex = 47;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(914, 414);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(103, 36);
            this.UpdateButton.TabIndex = 46;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(731, 462);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 45;
            this.label16.Text = "Marks";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(720, 422);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 44;
            this.label15.Text = "Subject";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(705, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 43;
            this.label14.Text = "Semester";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(688, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(313, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Enter the following details to update marks:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(889, 229);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(103, 36);
            this.DeleteButton.TabIndex = 41;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(688, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(343, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Enter the semester number to delete the entry :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Your marks :";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(44, 201);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(638, 284);
            this.listView1.TabIndex = 39;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(462, 91);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(76, 32);
            this.SearchButton.TabIndex = 38;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchID
            // 
            this.SearchID.Location = new System.Drawing.Point(260, 94);
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(182, 26);
            this.SearchID.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(501, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Welcome!!";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "Enter the ID to be searched :";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 505);
            this.Controls.Add(this.addmarks);
            this.Controls.Add(this.mar_u);
            this.Controls.Add(this.sub_u);
            this.Controls.Add(this.sem_u);
            this.Controls.Add(this.DelSem);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.mar_u)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_u)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sem_u)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelSem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addmarks;
        private System.Windows.Forms.NumericUpDown mar_u;
        private System.Windows.Forms.NumericUpDown sub_u;
        private System.Windows.Forms.NumericUpDown sem_u;
        private System.Windows.Forms.NumericUpDown DelSem;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}