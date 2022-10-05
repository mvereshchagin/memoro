namespace Memoro
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
            this.tbNewAss = new System.Windows.Forms.TextBox();
            this.addAssBtn = new System.Windows.Forms.Button();
            this.tbNewWord = new System.Windows.Forms.TextBox();
            this.addWordBtn = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.lbAss = new System.Windows.Forms.ListBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWords = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNewAss
            // 
            this.tbNewAss.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewAss.Location = new System.Drawing.Point(7, 17);
            this.tbNewAss.Name = "tbNewAss";
            this.tbNewAss.Size = new System.Drawing.Size(154, 23);
            this.tbNewAss.TabIndex = 25;
            this.tbNewAss.TextChanged += new System.EventHandler(this.tbNewAss_TextChanged);
            // 
            // addAssBtn
            // 
            this.addAssBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addAssBtn.Location = new System.Drawing.Point(167, 18);
            this.addAssBtn.Name = "addAssBtn";
            this.addAssBtn.Size = new System.Drawing.Size(44, 23);
            this.addAssBtn.TabIndex = 24;
            this.addAssBtn.Text = "+";
            this.addAssBtn.UseVisualStyleBackColor = true;
            this.addAssBtn.Click += new System.EventHandler(this.addAssBtn_Click);
            // 
            // tbNewWord
            // 
            this.tbNewWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewWord.Location = new System.Drawing.Point(6, 20);
            this.tbNewWord.Name = "tbNewWord";
            this.tbNewWord.Size = new System.Drawing.Size(154, 23);
            this.tbNewWord.TabIndex = 23;
            this.tbNewWord.TextChanged += new System.EventHandler(this.tbNewWord_TextChanged);
            // 
            // addWordBtn
            // 
            this.addWordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addWordBtn.Location = new System.Drawing.Point(166, 18);
            this.addWordBtn.Name = "addWordBtn";
            this.addWordBtn.Size = new System.Drawing.Size(44, 25);
            this.addWordBtn.TabIndex = 22;
            this.addWordBtn.Text = "+";
            this.addWordBtn.UseVisualStyleBackColor = true;
            this.addWordBtn.Click += new System.EventHandler(this.AddWordBtn_Click);
            // 
            // btConnect
            // 
            this.btConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btConnect.Location = new System.Drawing.Point(12, 480);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(472, 34);
            this.btConnect.TabIndex = 21;
            this.btConnect.Text = "Подключиться";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lbAss
            // 
            this.lbAss.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAss.FormattingEnabled = true;
            this.lbAss.ItemHeight = 15;
            this.lbAss.Location = new System.Drawing.Point(6, 16);
            this.lbAss.Name = "lbAss";
            this.lbAss.Size = new System.Drawing.Size(204, 214);
            this.lbAss.TabIndex = 19;
            this.lbAss.SelectedIndexChanged += new System.EventHandler(this.lbAss_SelectedIndexChanged);
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(146, 418);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(338, 23);
            this.tbName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Имя пользователя:";
            // 
            // lbWords
            // 
            this.lbWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWords.FormattingEnabled = true;
            this.lbWords.ItemHeight = 15;
            this.lbWords.Location = new System.Drawing.Point(6, 16);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(204, 214);
            this.lbWords.TabIndex = 14;
            this.lbWords.SelectedIndexChanged += new System.EventHandler(this.lbWords_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbWords);
            this.groupBox1.Location = new System.Drawing.Point(28, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 244);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Слова";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbAss);
            this.groupBox2.Location = new System.Drawing.Point(279, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 244);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ассоциации";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbNewWord);
            this.groupBox3.Controls.Add(this.addWordBtn);
            this.groupBox3.Location = new System.Drawing.Point(28, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 50);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавление слов:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tbNewAss);
            this.groupBox4.Controls.Add(this.addAssBtn);
            this.groupBox4.Location = new System.Drawing.Point(279, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 50);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Добавление ассоциаций:";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Form1
            // 
            this.AcceptButton = this.addWordBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.addAssBtn;
            this.ClientSize = new System.Drawing.Size(530, 534);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(546, 573);
            this.Name = "Form1";
            this.Text = "Memoro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNewAss;
        private Button addAssBtn;
        private TextBox tbNewWord;
        private Button addWordBtn;
        private Button btConnect;
        private ListBox lbAss;
        private TextBox tbName;
        private Label label2;
        private ListBox lbWords;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}