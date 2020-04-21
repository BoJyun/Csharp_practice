namespace BorrowAndRepay
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Mynamelabel = new System.Windows.Forms.Label();
            this.Friendnamelabel = new System.Windows.Forms.Label();
            this.Mynameinput = new System.Windows.Forms.TextBox();
            this.Friendnameinput = new System.Windows.Forms.TextBox();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mynameLabel2 = new System.Windows.Forms.Label();
            this.MymoneyLbel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FriendnameLabel2 = new System.Windows.Forms.Label();
            this.FriendmoneyLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Borrowbtn = new System.Windows.Forms.Button();
            this.Repaybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mynamelabel
            // 
            this.Mynamelabel.AutoSize = true;
            this.Mynamelabel.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Mynamelabel.Location = new System.Drawing.Point(99, 51);
            this.Mynamelabel.Name = "Mynamelabel";
            this.Mynamelabel.Size = new System.Drawing.Size(215, 28);
            this.Mynamelabel.TabIndex = 0;
            this.Mynamelabel.Text = "請輸入我的名子:";
            // 
            // Friendnamelabel
            // 
            this.Friendnamelabel.AutoSize = true;
            this.Friendnamelabel.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Friendnamelabel.Location = new System.Drawing.Point(43, 104);
            this.Friendnamelabel.Name = "Friendnamelabel";
            this.Friendnamelabel.Size = new System.Drawing.Size(271, 28);
            this.Friendnamelabel.TabIndex = 0;
            this.Friendnamelabel.Text = "請輸入我朋友的名子:";
            // 
            // Mynameinput
            // 
            this.Mynameinput.Location = new System.Drawing.Point(338, 50);
            this.Mynameinput.Multiline = true;
            this.Mynameinput.Name = "Mynameinput";
            this.Mynameinput.Size = new System.Drawing.Size(148, 38);
            this.Mynameinput.TabIndex = 1;
            // 
            // Friendnameinput
            // 
            this.Friendnameinput.Location = new System.Drawing.Point(338, 104);
            this.Friendnameinput.Multiline = true;
            this.Friendnameinput.Name = "Friendnameinput";
            this.Friendnameinput.Size = new System.Drawing.Size(148, 38);
            this.Friendnameinput.TabIndex = 1;
            // 
            // Submitbtn
            // 
            this.Submitbtn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Submitbtn.Location = new System.Drawing.Point(535, 39);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(227, 103);
            this.Submitbtn.TabIndex = 2;
            this.Submitbtn.Text = "確認";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(43, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "我的名子:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(73, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "我的$$:";
            // 
            // mynameLabel2
            // 
            this.mynameLabel2.AutoSize = true;
            this.mynameLabel2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mynameLabel2.Location = new System.Drawing.Point(208, 198);
            this.mynameLabel2.Name = "mynameLabel2";
            this.mynameLabel2.Size = new System.Drawing.Size(96, 28);
            this.mynameLabel2.TabIndex = 0;
            this.mynameLabel2.Text = "無名氏";
            // 
            // MymoneyLbel
            // 
            this.MymoneyLbel.AutoSize = true;
            this.MymoneyLbel.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MymoneyLbel.Location = new System.Drawing.Point(208, 251);
            this.MymoneyLbel.Name = "MymoneyLbel";
            this.MymoneyLbel.Size = new System.Drawing.Size(25, 28);
            this.MymoneyLbel.TabIndex = 0;
            this.MymoneyLbel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(355, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "朋友的名子:";
            // 
            // FriendnameLabel2
            // 
            this.FriendnameLabel2.AutoSize = true;
            this.FriendnameLabel2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FriendnameLabel2.Location = new System.Drawing.Point(530, 198);
            this.FriendnameLabel2.Name = "FriendnameLabel2";
            this.FriendnameLabel2.Size = new System.Drawing.Size(96, 28);
            this.FriendnameLabel2.TabIndex = 0;
            this.FriendnameLabel2.Text = "無名氏";
            // 
            // FriendmoneyLabel
            // 
            this.FriendmoneyLabel.AutoSize = true;
            this.FriendmoneyLabel.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FriendmoneyLabel.Location = new System.Drawing.Point(530, 251);
            this.FriendmoneyLabel.Name = "FriendmoneyLabel";
            this.FriendmoneyLabel.Size = new System.Drawing.Size(77, 28);
            this.FriendmoneyLabel.TabIndex = 0;
            this.FriendmoneyLabel.Text = "20000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(385, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "朋友的$$:";
            // 
            // Borrowbtn
            // 
            this.Borrowbtn.Enabled = false;
            this.Borrowbtn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Borrowbtn.Location = new System.Drawing.Point(78, 308);
            this.Borrowbtn.Name = "Borrowbtn";
            this.Borrowbtn.Size = new System.Drawing.Size(625, 49);
            this.Borrowbtn.TabIndex = 3;
            this.Borrowbtn.Text = "跟xxx借1000$";
            this.Borrowbtn.UseVisualStyleBackColor = true;
            this.Borrowbtn.Click += new System.EventHandler(this.Borrowbtn_Click);
            // 
            // Repaybtn
            // 
            this.Repaybtn.Enabled = false;
            this.Repaybtn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Repaybtn.Location = new System.Drawing.Point(78, 376);
            this.Repaybtn.Name = "Repaybtn";
            this.Repaybtn.Size = new System.Drawing.Size(625, 49);
            this.Repaybtn.TabIndex = 3;
            this.Repaybtn.Text = "還給xxx 1000$";
            this.Repaybtn.UseVisualStyleBackColor = true;
            this.Repaybtn.Click += new System.EventHandler(this.Repaybtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 447);
            this.Controls.Add(this.Repaybtn);
            this.Controls.Add(this.Borrowbtn);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Friendnameinput);
            this.Controls.Add(this.Mynameinput);
            this.Controls.Add(this.Friendnamelabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FriendmoneyLabel);
            this.Controls.Add(this.MymoneyLbel);
            this.Controls.Add(this.FriendnameLabel2);
            this.Controls.Add(this.mynameLabel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mynamelabel);
            this.Name = "Form1";
            this.Text = "借還錢程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mynamelabel;
        private System.Windows.Forms.Label Friendnamelabel;
        private System.Windows.Forms.TextBox Mynameinput;
        private System.Windows.Forms.TextBox Friendnameinput;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mynameLabel2;
        private System.Windows.Forms.Label MymoneyLbel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label FriendnameLabel2;
        private System.Windows.Forms.Label FriendmoneyLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Borrowbtn;
        private System.Windows.Forms.Button Repaybtn;
    }
}

