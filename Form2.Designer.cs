
namespace Memo_game
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(142, 56);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 22);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ИМЯ:";
            // 
            // rating
            // 
            this.rating.BackColor = System.Drawing.Color.CadetBlue;
            this.rating.Location = new System.Drawing.Point(126, 138);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(125, 31);
            this.rating.TabIndex = 2;
            this.rating.Text = "РЕЙТИНГ";
            this.rating.UseVisualStyleBackColor = false;
            this.rating.Click += new System.EventHandler(this.rating_Click);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.DarkCyan;
            this.start_button.Location = new System.Drawing.Point(126, 186);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(125, 31);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "СТАРТ";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(392, 306);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rating;
        private System.Windows.Forms.Button start_button;
    }
}