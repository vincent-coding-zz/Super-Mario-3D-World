namespace Super_Mario_3D_World
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disconnectionBtn = new System.Windows.Forms.Button();
            this.connectionBtn = new System.Windows.Forms.Button();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainGroup = new System.Windows.Forms.GroupBox();
            this.star5Btn = new System.Windows.Forms.Button();
            this.star3Btn = new System.Windows.Forms.Button();
            this.timerBtn = new System.Windows.Forms.Button();
            this.PointsBtn = new System.Windows.Forms.Button();
            this.coins2Btn = new System.Windows.Forms.Button();
            this.coinsBtn = new System.Windows.Forms.Button();
            this.lifeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.versionsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.mainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disconnectionBtn);
            this.groupBox1.Controls.Add(this.connectionBtn);
            this.groupBox1.Controls.Add(this.ipTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // disconnectionBtn
            // 
            this.disconnectionBtn.Enabled = false;
            this.disconnectionBtn.Location = new System.Drawing.Point(396, 15);
            this.disconnectionBtn.Name = "disconnectionBtn";
            this.disconnectionBtn.Size = new System.Drawing.Size(108, 23);
            this.disconnectionBtn.TabIndex = 3;
            this.disconnectionBtn.Text = "Disconnection";
            this.disconnectionBtn.UseVisualStyleBackColor = true;
            this.disconnectionBtn.Click += new System.EventHandler(this.disconnectionBtn_Click);
            // 
            // connectionBtn
            // 
            this.connectionBtn.Location = new System.Drawing.Point(283, 15);
            this.connectionBtn.Name = "connectionBtn";
            this.connectionBtn.Size = new System.Drawing.Size(108, 23);
            this.connectionBtn.TabIndex = 2;
            this.connectionBtn.Text = "Connection";
            this.connectionBtn.UseVisualStyleBackColor = true;
            this.connectionBtn.Click += new System.EventHandler(this.connectionBtn_Click);
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(59, 15);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(218, 22);
            this.ipTextBox.TabIndex = 1;
            this.ipTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WiiU Ip";
            // 
            // mainGroup
            // 
            this.mainGroup.Controls.Add(this.versionsLabel);
            this.mainGroup.Controls.Add(this.label2);
            this.mainGroup.Controls.Add(this.star5Btn);
            this.mainGroup.Controls.Add(this.star3Btn);
            this.mainGroup.Controls.Add(this.timerBtn);
            this.mainGroup.Controls.Add(this.PointsBtn);
            this.mainGroup.Controls.Add(this.coins2Btn);
            this.mainGroup.Controls.Add(this.coinsBtn);
            this.mainGroup.Controls.Add(this.lifeBtn);
            this.mainGroup.Enabled = false;
            this.mainGroup.Location = new System.Drawing.Point(12, 70);
            this.mainGroup.Name = "mainGroup";
            this.mainGroup.Size = new System.Drawing.Size(510, 145);
            this.mainGroup.TabIndex = 1;
            this.mainGroup.TabStop = false;
            this.mainGroup.Text = "Main";
            // 
            // star5Btn
            // 
            this.star5Btn.Location = new System.Drawing.Point(9, 109);
            this.star5Btn.Name = "star5Btn";
            this.star5Btn.Size = new System.Drawing.Size(232, 23);
            this.star5Btn.TabIndex = 6;
            this.star5Btn.Text = "5 Stars";
            this.star5Btn.UseVisualStyleBackColor = true;
            this.star5Btn.Click += new System.EventHandler(this.star5Btn_Click);
            // 
            // star3Btn
            // 
            this.star3Btn.Location = new System.Drawing.Point(272, 80);
            this.star3Btn.Name = "star3Btn";
            this.star3Btn.Size = new System.Drawing.Size(232, 23);
            this.star3Btn.TabIndex = 5;
            this.star3Btn.Text = "3 Stars";
            this.star3Btn.UseVisualStyleBackColor = true;
            this.star3Btn.Click += new System.EventHandler(this.star3Btn_Click);
            // 
            // timerBtn
            // 
            this.timerBtn.Location = new System.Drawing.Point(9, 80);
            this.timerBtn.Name = "timerBtn";
            this.timerBtn.Size = new System.Drawing.Size(232, 23);
            this.timerBtn.TabIndex = 4;
            this.timerBtn.Text = "Timers";
            this.timerBtn.UseVisualStyleBackColor = true;
            this.timerBtn.Click += new System.EventHandler(this.timerBtn_Click);
            // 
            // PointsBtn
            // 
            this.PointsBtn.Location = new System.Drawing.Point(9, 51);
            this.PointsBtn.Name = "PointsBtn";
            this.PointsBtn.Size = new System.Drawing.Size(232, 23);
            this.PointsBtn.TabIndex = 3;
            this.PointsBtn.Text = "999 999 Points";
            this.PointsBtn.UseVisualStyleBackColor = true;
            this.PointsBtn.Click += new System.EventHandler(this.PointsBtn_Click);
            // 
            // coins2Btn
            // 
            this.coins2Btn.Location = new System.Drawing.Point(272, 51);
            this.coins2Btn.Name = "coins2Btn";
            this.coins2Btn.Size = new System.Drawing.Size(232, 23);
            this.coins2Btn.TabIndex = 2;
            this.coins2Btn.Text = "999 999 999 Coins";
            this.coins2Btn.UseVisualStyleBackColor = true;
            this.coins2Btn.Click += new System.EventHandler(this.coins2Btn_Click);
            // 
            // coinsBtn
            // 
            this.coinsBtn.Location = new System.Drawing.Point(272, 21);
            this.coinsBtn.Name = "coinsBtn";
            this.coinsBtn.Size = new System.Drawing.Size(232, 23);
            this.coinsBtn.TabIndex = 1;
            this.coinsBtn.Text = "999 Coins";
            this.coinsBtn.UseVisualStyleBackColor = true;
            this.coinsBtn.Click += new System.EventHandler(this.coinsBtn_Click);
            // 
            // lifeBtn
            // 
            this.lifeBtn.Location = new System.Drawing.Point(9, 22);
            this.lifeBtn.Name = "lifeBtn";
            this.lifeBtn.Size = new System.Drawing.Size(232, 23);
            this.lifeBtn.TabIndex = 0;
            this.lifeBtn.Text = "999 Lifes";
            this.lifeBtn.UseVisualStyleBackColor = true;
            this.lifeBtn.Click += new System.EventHandler(this.lifeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "By vincent-coding";
            // 
            // versionsLabel
            // 
            this.versionsLabel.AutoSize = true;
            this.versionsLabel.Location = new System.Drawing.Point(269, 114);
            this.versionsLabel.Name = "versionsLabel";
            this.versionsLabel.Size = new System.Drawing.Size(69, 13);
            this.versionsLabel.TabIndex = 8;
            this.versionsLabel.Text = "Version : 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(534, 222);
            this.Controls.Add(this.mainGroup);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Mario 3D  World - By vincent_coding";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainGroup.ResumeLayout(false);
            this.mainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox mainGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button disconnectionBtn;
        private System.Windows.Forms.Button connectionBtn;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Button lifeBtn;
        private System.Windows.Forms.Button coinsBtn;
        private System.Windows.Forms.Button coins2Btn;
        private System.Windows.Forms.Button PointsBtn;
        private System.Windows.Forms.Button timerBtn;
        private System.Windows.Forms.Button star5Btn;
        private System.Windows.Forms.Button star3Btn;
        private System.Windows.Forms.Label versionsLabel;
        private System.Windows.Forms.Label label2;
    }
}

