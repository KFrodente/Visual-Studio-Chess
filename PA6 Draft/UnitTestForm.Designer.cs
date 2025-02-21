namespace PA6_Draft
{
    partial class UnitTestForm
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
            this.Test1Label = new System.Windows.Forms.Label();
            this.Test2Label = new System.Windows.Forms.Label();
            this.Test3Label = new System.Windows.Forms.Label();
            this.Test4Label = new System.Windows.Forms.Label();
            this.Test1PF = new System.Windows.Forms.Label();
            this.Test2PF = new System.Windows.Forms.Label();
            this.Test3PF = new System.Windows.Forms.Label();
            this.Test4PF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Test1Label
            // 
            this.Test1Label.AutoSize = true;
            this.Test1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test1Label.Location = new System.Drawing.Point(46, 66);
            this.Test1Label.Name = "Test1Label";
            this.Test1Label.Size = new System.Drawing.Size(73, 25);
            this.Test1Label.TabIndex = 0;
            this.Test1Label.Text = "Test 1:";
            // 
            // Test2Label
            // 
            this.Test2Label.AutoSize = true;
            this.Test2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test2Label.Location = new System.Drawing.Point(46, 149);
            this.Test2Label.Name = "Test2Label";
            this.Test2Label.Size = new System.Drawing.Size(73, 25);
            this.Test2Label.TabIndex = 1;
            this.Test2Label.Text = "Test 2:";
            this.Test2Label.Click += new System.EventHandler(this.Test2Label_Click);
            // 
            // Test3Label
            // 
            this.Test3Label.AutoSize = true;
            this.Test3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test3Label.Location = new System.Drawing.Point(46, 231);
            this.Test3Label.Name = "Test3Label";
            this.Test3Label.Size = new System.Drawing.Size(73, 25);
            this.Test3Label.TabIndex = 2;
            this.Test3Label.Text = "Test 3:";
            // 
            // Test4Label
            // 
            this.Test4Label.AutoSize = true;
            this.Test4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test4Label.Location = new System.Drawing.Point(46, 315);
            this.Test4Label.Name = "Test4Label";
            this.Test4Label.Size = new System.Drawing.Size(73, 25);
            this.Test4Label.TabIndex = 3;
            this.Test4Label.Text = "Test 4:";
            // 
            // Test1PF
            // 
            this.Test1PF.AutoSize = true;
            this.Test1PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test1PF.Location = new System.Drawing.Point(162, 66);
            this.Test1PF.Name = "Test1PF";
            this.Test1PF.Size = new System.Drawing.Size(23, 25);
            this.Test1PF.TabIndex = 4;
            this.Test1PF.Text = "a";
            this.Test1PF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Test2PF
            // 
            this.Test2PF.AutoSize = true;
            this.Test2PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test2PF.Location = new System.Drawing.Point(162, 149);
            this.Test2PF.Name = "Test2PF";
            this.Test2PF.Size = new System.Drawing.Size(23, 25);
            this.Test2PF.TabIndex = 5;
            this.Test2PF.Text = "a";
            this.Test2PF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Test3PF
            // 
            this.Test3PF.AutoSize = true;
            this.Test3PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test3PF.Location = new System.Drawing.Point(162, 231);
            this.Test3PF.Name = "Test3PF";
            this.Test3PF.Size = new System.Drawing.Size(23, 25);
            this.Test3PF.TabIndex = 6;
            this.Test3PF.Text = "a";
            this.Test3PF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Test4PF
            // 
            this.Test4PF.AutoSize = true;
            this.Test4PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test4PF.Location = new System.Drawing.Point(162, 315);
            this.Test4PF.Name = "Test4PF";
            this.Test4PF.Size = new System.Drawing.Size(23, 25);
            this.Test4PF.TabIndex = 7;
            this.Test4PF.Text = "a";
            this.Test4PF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.Test4PF);
            this.Controls.Add(this.Test3PF);
            this.Controls.Add(this.Test2PF);
            this.Controls.Add(this.Test1PF);
            this.Controls.Add(this.Test4Label);
            this.Controls.Add(this.Test3Label);
            this.Controls.Add(this.Test2Label);
            this.Controls.Add(this.Test1Label);
            this.Name = "UnitTestForm";
            this.Text = "UnitTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Test1Label;
        private System.Windows.Forms.Label Test2Label;
        private System.Windows.Forms.Label Test3Label;
        private System.Windows.Forms.Label Test4Label;
        public System.Windows.Forms.Label Test1PF;
        public System.Windows.Forms.Label Test2PF;
        public System.Windows.Forms.Label Test3PF;
        public System.Windows.Forms.Label Test4PF;
    }
}