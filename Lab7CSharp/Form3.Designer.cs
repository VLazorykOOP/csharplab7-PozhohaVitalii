namespace Lab7CSharp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open FILE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(105, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save FILE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADDRESS";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(501, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(825, 436);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(6, 21);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(122, 20);
            this.redRadioButton.TabIndex = 4;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "redRadioButton";
            this.redRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blueRadioButton);
            this.groupBox1.Controls.Add(this.greenRadioButton);
            this.groupBox1.Controls.Add(this.redRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(37, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(6, 48);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(137, 20);
            this.greenRadioButton.TabIndex = 5;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "greenRadioButton";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.AutoSize = true;
            this.blueRadioButton.Location = new System.Drawing.Point(6, 74);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(128, 20);
            this.blueRadioButton.TabIndex = 6;
            this.blueRadioButton.TabStop = true;
            this.blueRadioButton.Text = "blueRadioButton";
            this.blueRadioButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(58, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 60);
            this.button3.TabIndex = 6;
            this.button3.Text = "apply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.applyEffectButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 497);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton blueRadioButton;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.Button button3;
    }
}