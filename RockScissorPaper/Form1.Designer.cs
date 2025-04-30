namespace RockScissorPaper
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.userScoreTextBox = new System.Windows.Forms.TextBox();
            this.computerScoreTextBox = new System.Windows.Forms.TextBox();
            this.scissorButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(12, 12);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.logTextBox.Size = new System.Drawing.Size(318, 175);
            this.logTextBox.TabIndex = 0;
            // 
            // userScoreTextBox
            // 
            this.userScoreTextBox.Location = new System.Drawing.Point(12, 208);
            this.userScoreTextBox.Name = "userScoreTextBox";
            this.userScoreTextBox.ReadOnly = true;
            this.userScoreTextBox.Size = new System.Drawing.Size(156, 21);
            this.userScoreTextBox.TabIndex = 1;
            this.userScoreTextBox.Text = "0";
            // 
            // computerScoreTextBox
            // 
            this.computerScoreTextBox.Location = new System.Drawing.Point(174, 208);
            this.computerScoreTextBox.Name = "computerScoreTextBox";
            this.computerScoreTextBox.ReadOnly = true;
            this.computerScoreTextBox.Size = new System.Drawing.Size(156, 21);
            this.computerScoreTextBox.TabIndex = 2;
            this.computerScoreTextBox.Text = "0";
            // 
            // scissorButton
            // 
            this.scissorButton.Location = new System.Drawing.Point(12, 235);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(75, 23);
            this.scissorButton.TabIndex = 3;
            this.scissorButton.Text = "가위";
            this.scissorButton.UseVisualStyleBackColor = true;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.Location = new System.Drawing.Point(93, 235);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(75, 23);
            this.rockButton.TabIndex = 4;
            this.rockButton.Text = "바위";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Location = new System.Drawing.Point(174, 235);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(75, 23);
            this.paperButton.TabIndex = 5;
            this.paperButton.Text = "보";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(255, 235);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "초기화";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "사용자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "컴퓨터";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 269);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.computerScoreTextBox);
            this.Controls.Add(this.userScoreTextBox);
            this.Controls.Add(this.logTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.TextBox userScoreTextBox;
        private System.Windows.Forms.TextBox computerScoreTextBox;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

