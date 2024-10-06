
namespace SocketsExam
{
    partial class ServerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScissorsBTN = new System.Windows.Forms.Button();
            this.PaperBTN = new System.Windows.Forms.Button();
            this.RockBTN = new System.Windows.Forms.Button();
            this.WinLabel = new System.Windows.Forms.Label();
            this.Wins = new System.Windows.Forms.Label();
            this.LosesLabel = new System.Windows.Forms.Label();
            this.Loses = new System.Windows.Forms.Label();
            this.MoveLabel = new System.Windows.Forms.Label();
            this.Your = new System.Windows.Forms.PictureBox();
            this.EminemLabel = new System.Windows.Forms.Label();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.vs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Your)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // ScissorsBTN
            // 
            this.ScissorsBTN.BackgroundImage = global::SocketsExam.Properties.Resources.ножицы;
            this.ScissorsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ScissorsBTN.Location = new System.Drawing.Point(548, 195);
            this.ScissorsBTN.Name = "ScissorsBTN";
            this.ScissorsBTN.Size = new System.Drawing.Size(240, 214);
            this.ScissorsBTN.TabIndex = 2;
            this.ScissorsBTN.UseVisualStyleBackColor = true;
            this.ScissorsBTN.Click += new System.EventHandler(this.ScissorsBTN_Click);
            // 
            // PaperBTN
            // 
            this.PaperBTN.BackgroundImage = global::SocketsExam.Properties.Resources.бумаха;
            this.PaperBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PaperBTN.Location = new System.Drawing.Point(292, 195);
            this.PaperBTN.Name = "PaperBTN";
            this.PaperBTN.Size = new System.Drawing.Size(240, 214);
            this.PaperBTN.TabIndex = 1;
            this.PaperBTN.UseVisualStyleBackColor = true;
            this.PaperBTN.Click += new System.EventHandler(this.PaperBTN_Click);
            // 
            // RockBTN
            // 
            this.RockBTN.BackgroundImage = global::SocketsExam.Properties.Resources.Камэнь;
            this.RockBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RockBTN.Location = new System.Drawing.Point(32, 195);
            this.RockBTN.Name = "RockBTN";
            this.RockBTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RockBTN.Size = new System.Drawing.Size(240, 214);
            this.RockBTN.TabIndex = 0;
            this.RockBTN.UseVisualStyleBackColor = true;
            this.RockBTN.Click += new System.EventHandler(this.RockBTN_Click);
            // 
            // WinLabel
            // 
            this.WinLabel.AutoSize = true;
            this.WinLabel.Location = new System.Drawing.Point(289, 151);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(43, 17);
            this.WinLabel.TabIndex = 3;
            this.WinLabel.Text = "Wins:";
            // 
            // Wins
            // 
            this.Wins.AutoSize = true;
            this.Wins.Location = new System.Drawing.Point(338, 150);
            this.Wins.Name = "Wins";
            this.Wins.Size = new System.Drawing.Size(16, 17);
            this.Wins.TabIndex = 4;
            this.Wins.Text = "0";
            // 
            // LosesLabel
            // 
            this.LosesLabel.AutoSize = true;
            this.LosesLabel.Location = new System.Drawing.Point(460, 151);
            this.LosesLabel.Name = "LosesLabel";
            this.LosesLabel.Size = new System.Drawing.Size(50, 17);
            this.LosesLabel.TabIndex = 5;
            this.LosesLabel.Text = "Loses:";
            // 
            // Loses
            // 
            this.Loses.AutoSize = true;
            this.Loses.Location = new System.Drawing.Point(516, 151);
            this.Loses.Name = "Loses";
            this.Loses.Size = new System.Drawing.Size(16, 17);
            this.Loses.TabIndex = 6;
            this.Loses.Text = "0";
            // 
            // MoveLabel
            // 
            this.MoveLabel.AutoSize = true;
            this.MoveLabel.Location = new System.Drawing.Point(225, 13);
            this.MoveLabel.Name = "MoveLabel";
            this.MoveLabel.Size = new System.Drawing.Size(80, 17);
            this.MoveLabel.TabIndex = 7;
            this.MoveLabel.Text = "Your Move:";
            // 
            // Your
            // 
            this.Your.BackColor = System.Drawing.SystemColors.Control;
            this.Your.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Your.Location = new System.Drawing.Point(217, 43);
            this.Your.Name = "Your";
            this.Your.Size = new System.Drawing.Size(101, 75);
            this.Your.TabIndex = 8;
            this.Your.TabStop = false;
            // 
            // EminemLabel
            // 
            this.EminemLabel.AutoSize = true;
            this.EminemLabel.Location = new System.Drawing.Point(467, 12);
            this.EminemLabel.Name = "EminemLabel";
            this.EminemLabel.Size = new System.Drawing.Size(103, 17);
            this.EminemLabel.TabIndex = 9;
            this.EminemLabel.Text = "Enemy\'s Move:";
            // 
            // Enemy
            // 
            this.Enemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Enemy.Location = new System.Drawing.Point(467, 43);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(103, 75);
            this.Enemy.TabIndex = 10;
            this.Enemy.TabStop = false;
            // 
            // vs
            // 
            this.vs.AutoSize = true;
            this.vs.Location = new System.Drawing.Point(380, 68);
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(26, 17);
            this.vs.TabIndex = 11;
            this.vs.Text = "VS";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vs);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.EminemLabel);
            this.Controls.Add(this.Your);
            this.Controls.Add(this.MoveLabel);
            this.Controls.Add(this.Loses);
            this.Controls.Add(this.LosesLabel);
            this.Controls.Add(this.Wins);
            this.Controls.Add(this.WinLabel);
            this.Controls.Add(this.ScissorsBTN);
            this.Controls.Add(this.PaperBTN);
            this.Controls.Add(this.RockBTN);
            this.Name = "ServerForm";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.Your)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RockBTN;
        private System.Windows.Forms.Button PaperBTN;
        private System.Windows.Forms.Button ScissorsBTN;
        private System.Windows.Forms.Label WinLabel;
        private System.Windows.Forms.Label Wins;
        private System.Windows.Forms.Label LosesLabel;
        private System.Windows.Forms.Label Loses;
        private System.Windows.Forms.Label MoveLabel;
        private System.Windows.Forms.PictureBox Your;
        private System.Windows.Forms.Label EminemLabel;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.Label vs;
    }
}

