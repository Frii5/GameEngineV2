namespace GameEngineV2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ProjectilePosLabel = new System.Windows.Forms.Label();
            this.TargetPosLabel = new System.Windows.Forms.Label();
            this.InitialVelocityLabel = new System.Windows.Forms.Label();
            this.InitialAngleLabel = new System.Windows.Forms.Label();
            this.IsTargetHitLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProjectilePosTextBox = new System.Windows.Forms.TextBox();
            this.TargetPosTextBox = new System.Windows.Forms.TextBox();
            this.InitialVelocityTextBox = new System.Windows.Forms.TextBox();
            this.InitialAngleTextBox = new System.Windows.Forms.TextBox();
            this.IsTargetHitTextBox = new System.Windows.Forms.TextBox();
            this.FireButton = new System.Windows.Forms.Button();
            this.GameLoopTimer = new System.Windows.Forms.Timer(this.components);
            this.XPosLabel = new System.Windows.Forms.Label();
            this.YPosLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProjectilePosLabel
            // 
            this.ProjectilePosLabel.AutoSize = true;
            this.ProjectilePosLabel.Location = new System.Drawing.Point(44, 36);
            this.ProjectilePosLabel.Name = "ProjectilePosLabel";
            this.ProjectilePosLabel.Size = new System.Drawing.Size(184, 25);
            this.ProjectilePosLabel.TabIndex = 0;
            this.ProjectilePosLabel.Text = "Projectile Position";
            this.ProjectilePosLabel.Click += new System.EventHandler(this.ProjectilePosLabel_Click);
            // 
            // TargetPosLabel
            // 
            this.TargetPosLabel.AutoSize = true;
            this.TargetPosLabel.Location = new System.Drawing.Point(44, 72);
            this.TargetPosLabel.Name = "TargetPosLabel";
            this.TargetPosLabel.Size = new System.Drawing.Size(157, 25);
            this.TargetPosLabel.TabIndex = 1;
            this.TargetPosLabel.Text = "Target Position";
            this.TargetPosLabel.Click += new System.EventHandler(this.TargetPosLabel_Click);
            // 
            // InitialVelocityLabel
            // 
            this.InitialVelocityLabel.AutoSize = true;
            this.InitialVelocityLabel.Location = new System.Drawing.Point(44, 108);
            this.InitialVelocityLabel.Name = "InitialVelocityLabel";
            this.InitialVelocityLabel.Size = new System.Drawing.Size(144, 25);
            this.InitialVelocityLabel.TabIndex = 2;
            this.InitialVelocityLabel.Text = "Initial Velocity";
            this.InitialVelocityLabel.Click += new System.EventHandler(this.InitialVelocityLabel_Click);
            // 
            // InitialAngleLabel
            // 
            this.InitialAngleLabel.AutoSize = true;
            this.InitialAngleLabel.Location = new System.Drawing.Point(44, 144);
            this.InitialAngleLabel.Name = "InitialAngleLabel";
            this.InitialAngleLabel.Size = new System.Drawing.Size(123, 25);
            this.InitialAngleLabel.TabIndex = 3;
            this.InitialAngleLabel.Text = "Initial Angle";
            this.InitialAngleLabel.Click += new System.EventHandler(this.InitialAngleLabel_Click);
            // 
            // IsTargetHitLabel
            // 
            this.IsTargetHitLabel.AutoSize = true;
            this.IsTargetHitLabel.Location = new System.Drawing.Point(44, 180);
            this.IsTargetHitLabel.Name = "IsTargetHitLabel";
            this.IsTargetHitLabel.Size = new System.Drawing.Size(140, 25);
            this.IsTargetHitLabel.TabIndex = 4;
            this.IsTargetHitLabel.Text = "Is Target Hit?";
            this.IsTargetHitLabel.Click += new System.EventHandler(this.IsTargetHitLabel_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 12;
            // 
            // ProjectilePosTextBox
            // 
            this.ProjectilePosTextBox.Location = new System.Drawing.Point(233, 36);
            this.ProjectilePosTextBox.Name = "ProjectilePosTextBox";
            this.ProjectilePosTextBox.Size = new System.Drawing.Size(93, 31);
            this.ProjectilePosTextBox.TabIndex = 6;
            this.ProjectilePosTextBox.TextChanged += new System.EventHandler(this.ProjectilePosTextBox_TextChanged);
            // 
            // TargetPosTextBox
            // 
            this.TargetPosTextBox.Location = new System.Drawing.Point(233, 72);
            this.TargetPosTextBox.Name = "TargetPosTextBox";
            this.TargetPosTextBox.Size = new System.Drawing.Size(93, 31);
            this.TargetPosTextBox.TabIndex = 7;
            this.TargetPosTextBox.TextChanged += new System.EventHandler(this.TargetPosTextBox_TextChanged);
            // 
            // InitialVelocityTextBox
            // 
            this.InitialVelocityTextBox.Location = new System.Drawing.Point(233, 108);
            this.InitialVelocityTextBox.Name = "InitialVelocityTextBox";
            this.InitialVelocityTextBox.Size = new System.Drawing.Size(93, 31);
            this.InitialVelocityTextBox.TabIndex = 8;
            this.InitialVelocityTextBox.TextChanged += new System.EventHandler(this.InitialVelocityTextBox_TextChanged);
            // 
            // InitialAngleTextBox
            // 
            this.InitialAngleTextBox.Location = new System.Drawing.Point(233, 144);
            this.InitialAngleTextBox.Name = "InitialAngleTextBox";
            this.InitialAngleTextBox.Size = new System.Drawing.Size(93, 31);
            this.InitialAngleTextBox.TabIndex = 9;
            this.InitialAngleTextBox.TextChanged += new System.EventHandler(this.InitialAngleTextBox_TextChanged);
            // 
            // IsTargetHitTextBox
            // 
            this.IsTargetHitTextBox.Location = new System.Drawing.Point(233, 180);
            this.IsTargetHitTextBox.Name = "IsTargetHitTextBox";
            this.IsTargetHitTextBox.Size = new System.Drawing.Size(93, 31);
            this.IsTargetHitTextBox.TabIndex = 10;
            this.IsTargetHitTextBox.TextChanged += new System.EventHandler(this.IsTargetHitTextBox_TextChanged);
            // 
            // FireButton
            // 
            this.FireButton.Location = new System.Drawing.Point(353, 36);
            this.FireButton.Name = "FireButton";
            this.FireButton.Size = new System.Drawing.Size(110, 61);
            this.FireButton.TabIndex = 13;
            this.FireButton.Text = "Fire!";
            this.FireButton.UseVisualStyleBackColor = true;
            this.FireButton.Click += new System.EventHandler(this.FireButton_Click);
            // 
            // GameLoopTimer
            // 
            this.GameLoopTimer.Interval = 1000;
            this.GameLoopTimer.Tick += new System.EventHandler(this.GameLoopTimer_Tick);
            // 
            // XPosLabel
            // 
            this.XPosLabel.AutoSize = true;
            this.XPosLabel.Location = new System.Drawing.Point(694, 42);
            this.XPosLabel.Name = "XPosLabel";
            this.XPosLabel.Size = new System.Drawing.Size(70, 25);
            this.XPosLabel.TabIndex = 14;
            this.XPosLabel.Text = "label1";
            this.XPosLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // YPosLabel
            // 
            this.YPosLabel.AutoSize = true;
            this.YPosLabel.Location = new System.Drawing.Point(694, 87);
            this.YPosLabel.Name = "YPosLabel";
            this.YPosLabel.Size = new System.Drawing.Size(70, 25);
            this.YPosLabel.TabIndex = 15;
            this.YPosLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 747);
            this.Controls.Add(this.YPosLabel);
            this.Controls.Add(this.XPosLabel);
            this.Controls.Add(this.FireButton);
            this.Controls.Add(this.IsTargetHitTextBox);
            this.Controls.Add(this.InitialAngleTextBox);
            this.Controls.Add(this.InitialVelocityTextBox);
            this.Controls.Add(this.TargetPosTextBox);
            this.Controls.Add(this.ProjectilePosTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IsTargetHitLabel);
            this.Controls.Add(this.InitialAngleLabel);
            this.Controls.Add(this.InitialVelocityLabel);
            this.Controls.Add(this.TargetPosLabel);
            this.Controls.Add(this.ProjectilePosLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectilePosLabel;
        private System.Windows.Forms.Label TargetPosLabel;
        private System.Windows.Forms.Label InitialVelocityLabel;
        private System.Windows.Forms.Label InitialAngleLabel;
        private System.Windows.Forms.Label IsTargetHitLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProjectilePosTextBox;
        private System.Windows.Forms.TextBox TargetPosTextBox;
        private System.Windows.Forms.TextBox InitialVelocityTextBox;
        private System.Windows.Forms.TextBox InitialAngleTextBox;
        private System.Windows.Forms.TextBox IsTargetHitTextBox;
        private System.Windows.Forms.Button FireButton;
        private System.Windows.Forms.Timer GameLoopTimer;
        private System.Windows.Forms.Label XPosLabel;
        private System.Windows.Forms.Label YPosLabel;
    }
}

