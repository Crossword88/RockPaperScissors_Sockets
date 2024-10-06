
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.vs = new System.Windows.Forms.Label();
            this.EminemLabel = new System.Windows.Forms.Label();
            this.MoveLabel = new System.Windows.Forms.Label();
            this.Loses = new System.Windows.Forms.Label();
            this.LosesLabel = new System.Windows.Forms.Label();
            this.Wins = new System.Windows.Forms.Label();
            this.WinLabel = new System.Windows.Forms.Label();
            this.ScissorsBTN = new System.Windows.Forms.Button();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Your = new System.Windows.Forms.PictureBox();
            this.PaperBTN = new System.Windows.Forms.Button();
            this.RockBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Your)).BeginInit();
            this.SuspendLayout();
            // 
            // vs
            // 
            this.vs.AutoSize = true;
            this.vs.Location = new System.Drawing.Point(370, 83);
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(26, 17);
            this.vs.TabIndex = 23;
            this.vs.Text = "VS";
            // 
            // EminemLabel
            // 
            this.EminemLabel.AutoSize = true;
            this.EminemLabel.Location = new System.Drawing.Point(457, 27);
            this.EminemLabel.Name = "EminemLabel";
            this.EminemLabel.Size = new System.Drawing.Size(103, 17);
            this.EminemLabel.TabIndex = 21;
            this.EminemLabel.Text = "Enemy\'s Move:";
            // 
            // MoveLabel
            // 
            this.MoveLabel.AutoSize = true;
            this.MoveLabel.Location = new System.Drawing.Point(215, 28);
            this.MoveLabel.Name = "MoveLabel";
            this.MoveLabel.Size = new System.Drawing.Size(80, 17);
            this.MoveLabel.TabIndex = 19;
            this.MoveLabel.Text = "Your Move:";
            // 
            // Loses
            // 
            this.Loses.AutoSize = true;
            this.Loses.Location = new System.Drawing.Point(506, 166);
            this.Loses.Name = "Loses";
            this.Loses.Size = new System.Drawing.Size(16, 17);
            this.Loses.TabIndex = 18;
            this.Loses.Text = "0";
            // 
            // LosesLabel
            // 
            this.LosesLabel.AutoSize = true;
            this.LosesLabel.Location = new System.Drawing.Point(450, 166);
            this.LosesLabel.Name = "LosesLabel";
            this.LosesLabel.Size = new System.Drawing.Size(50, 17);
            this.LosesLabel.TabIndex = 17;
            this.LosesLabel.Text = "Loses:";
            // 
            // Wins
            // 
            this.Wins.AutoSize = true;
            this.Wins.Location = new System.Drawing.Point(328, 165);
            this.Wins.Name = "Wins";
            this.Wins.Size = new System.Drawing.Size(16, 17);
            this.Wins.TabIndex = 16;
            this.Wins.Text = "0";
            // 
            // WinLabel
            // 
            this.WinLabel.AutoSize = true;
            this.WinLabel.Location = new System.Drawing.Point(279, 166);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(43, 17);
            this.WinLabel.TabIndex = 15;
            this.WinLabel.Text = "Wins:";
            // 
            // ScissorsBTN
            // 
            this.ScissorsBTN.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ножицы;
            this.ScissorsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ScissorsBTN.Location = new System.Drawing.Point(538, 210);
            this.ScissorsBTN.Name = "ScissorsBTN";
            this.ScissorsBTN.Size = new System.Drawing.Size(240, 214);
            this.ScissorsBTN.TabIndex = 14;
            this.ScissorsBTN.UseVisualStyleBackColor = true;
            this.ScissorsBTN.Click += new System.EventHandler(this.ScissorsBTN_Click);
            // 
            // Enemy
            // 
            this.Enemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Enemy.Location = new System.Drawing.Point(457, 58);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(103, 75);
            this.Enemy.TabIndex = 22;
            this.Enemy.TabStop = false;
            // 
            // Your
            // 
            this.Your.BackColor = System.Drawing.SystemColors.Control;
            this.Your.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Your.Location = new System.Drawing.Point(207, 58);
            this.Your.Name = "Your";
            this.Your.Size = new System.Drawing.Size(101, 75);
            this.Your.TabIndex = 20;
            this.Your.TabStop = false;
            // 
            // PaperBTN
            // 
            this.PaperBTN.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.бумаха;
            this.PaperBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PaperBTN.Location = new System.Drawing.Point(282, 210);
            this.PaperBTN.Name = "PaperBTN";
            this.PaperBTN.Size = new System.Drawing.Size(240, 214);
            this.PaperBTN.TabIndex = 13;
            this.PaperBTN.UseVisualStyleBackColor = true;
            this.PaperBTN.Click += new System.EventHandler(this.PaperBTN_Click);
            // 
            // RockBTN
            // 
            this.RockBTN.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Камэнь;
            this.RockBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RockBTN.Location = new System.Drawing.Point(22, 210);
            this.RockBTN.Name = "RockBTN";
            this.RockBTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RockBTN.Size = new System.Drawing.Size(240, 214);
            this.RockBTN.TabIndex = 12;
            this.RockBTN.UseVisualStyleBackColor = true;
            this.RockBTN.Click += new System.EventHandler(this.RockBTN_Click);
            // 
            // Form1
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Your)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vs;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.Label EminemLabel;
        private System.Windows.Forms.PictureBox Your;
        private System.Windows.Forms.Label MoveLabel;
        private System.Windows.Forms.Label Loses;
        private System.Windows.Forms.Label LosesLabel;
        private System.Windows.Forms.Label Wins;
        private System.Windows.Forms.Label WinLabel;
        private System.Windows.Forms.Button ScissorsBTN;
        private System.Windows.Forms.Button PaperBTN;
        private System.Windows.Forms.Button RockBTN;
    }
}

