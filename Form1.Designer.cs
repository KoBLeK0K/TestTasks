
namespace TestTask
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
            this.pass_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.check_butt = new System.Windows.Forms.Button();
            this.add_butt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pass_box
            // 
            this.pass_box.Location = new System.Drawing.Point(247, 57);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(100, 23);
            this.pass_box.TabIndex = 0;
            this.pass_box.TextChanged += new System.EventHandler(this.pass_box_TextChanged);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(69, 57);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 23);
            this.name_box.TabIndex = 1;
            this.name_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // check_butt
            // 
            this.check_butt.Enabled = false;
            this.check_butt.Location = new System.Drawing.Point(407, 57);
            this.check_butt.Name = "check_butt";
            this.check_butt.Size = new System.Drawing.Size(75, 23);
            this.check_butt.TabIndex = 2;
            this.check_butt.Text = "Check";
            this.check_butt.UseVisualStyleBackColor = true;
            this.check_butt.Click += new System.EventHandler(this.check_butt_Click);
            // 
            // add_butt
            // 
            this.add_butt.Enabled = false;
            this.add_butt.Location = new System.Drawing.Point(501, 57);
            this.add_butt.Name = "add_butt";
            this.add_butt.Size = new System.Drawing.Size(75, 23);
            this.add_butt.TabIndex = 3;
            this.add_butt.Text = "Add";
            this.add_butt.UseVisualStyleBackColor = true;
            this.add_butt.Click += new System.EventHandler(this.add_butt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_butt);
            this.Controls.Add(this.check_butt);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.pass_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Button check_butt;
        private System.Windows.Forms.Button add_butt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

