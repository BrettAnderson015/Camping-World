namespace CampingWorld
{
    partial class Update
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUpdateQuantity = new System.Windows.Forms.TextBox();
            this.tbUpdateDateAcquired = new System.Windows.Forms.TextBox();
            this.tbUpdateCost = new System.Windows.Forms.TextBox();
            this.tbUpdateDescription = new System.Windows.Forms.TextBox();
            this.tbUpdateName = new System.Windows.Forms.TextBox();
            this.tbUpdateID = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Date Acquired";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // tbUpdateQuantity
            // 
            this.tbUpdateQuantity.Location = new System.Drawing.Point(178, 218);
            this.tbUpdateQuantity.Name = "tbUpdateQuantity";
            this.tbUpdateQuantity.Size = new System.Drawing.Size(156, 20);
            this.tbUpdateQuantity.TabIndex = 17;
            // 
            // tbUpdateDateAcquired
            // 
            this.tbUpdateDateAcquired.Location = new System.Drawing.Point(178, 183);
            this.tbUpdateDateAcquired.Name = "tbUpdateDateAcquired";
            this.tbUpdateDateAcquired.Size = new System.Drawing.Size(156, 20);
            this.tbUpdateDateAcquired.TabIndex = 16;
            // 
            // tbUpdateCost
            // 
            this.tbUpdateCost.Location = new System.Drawing.Point(178, 147);
            this.tbUpdateCost.Name = "tbUpdateCost";
            this.tbUpdateCost.Size = new System.Drawing.Size(156, 20);
            this.tbUpdateCost.TabIndex = 15;
            // 
            // tbUpdateDescription
            // 
            this.tbUpdateDescription.Location = new System.Drawing.Point(178, 112);
            this.tbUpdateDescription.Name = "tbUpdateDescription";
            this.tbUpdateDescription.Size = new System.Drawing.Size(156, 20);
            this.tbUpdateDescription.TabIndex = 14;
            // 
            // tbUpdateName
            // 
            this.tbUpdateName.Location = new System.Drawing.Point(178, 75);
            this.tbUpdateName.Name = "tbUpdateName";
            this.tbUpdateName.Size = new System.Drawing.Size(156, 20);
            this.tbUpdateName.TabIndex = 13;
            // 
            // tbUpdateID
            // 
            this.tbUpdateID.Location = new System.Drawing.Point(178, 40);
            this.tbUpdateID.Name = "tbUpdateID";
            this.tbUpdateID.Size = new System.Drawing.Size(156, 20);
            this.tbUpdateID.TabIndex = 12;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(190, 294);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 24;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUpdateQuantity);
            this.Controls.Add(this.tbUpdateDateAcquired);
            this.Controls.Add(this.tbUpdateCost);
            this.Controls.Add(this.tbUpdateDescription);
            this.Controls.Add(this.tbUpdateName);
            this.Controls.Add(this.tbUpdateID);
            this.Name = "Update";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUpdateQuantity;
        private System.Windows.Forms.TextBox tbUpdateDateAcquired;
        private System.Windows.Forms.TextBox tbUpdateCost;
        private System.Windows.Forms.TextBox tbUpdateDescription;
        private System.Windows.Forms.TextBox tbUpdateName;
        private System.Windows.Forms.TextBox tbUpdateID;
        private System.Windows.Forms.Button buttonChange;
    }
}