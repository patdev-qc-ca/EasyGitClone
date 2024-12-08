namespace EasyGitClone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 26);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Lien GitHub";
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.Location = new Point(20, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(544, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.DragDrop += textBox1_DragDrop;
            textBox1.DragEnter += textBox1_DragEnter;
            // 
            // button1
            // 
            button1.Location = new Point(570, 44);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Coller";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 96);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(486, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 78);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Destination ";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(512, 94);
            button2.Name = "button2";
            button2.Size = new Size(133, 25);
            button2.TabIndex = 5;
            button2.Text = "Définir comme parent";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(544, 23);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 128);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 6;
            label3.Text = "Arboretun  Git";
            // 
            // button3
            // 
            button3.Location = new Point(454, 184);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Cloner";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(570, 184);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Quitter";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(535, 184);
            button5.Name = "button5";
            button5.Size = new Size(29, 23);
            button5.TabIndex = 10;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(657, 222);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            DragDrop += textBox1_DragDrop;
            DragEnter += textBox1_DragEnter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
        private TextBox textBox3;
        private Label label3;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
