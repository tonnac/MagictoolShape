
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    using System.Collections.Generic;
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textureCopyBtn = new System.Windows.Forms.Button();
            this.decimalText = new System.Windows.Forms.TextBox();
            this.binarylabel = new System.Windows.Forms.Label();
            this.hexadecimallabel = new System.Windows.Forms.Label();
            this.decimallabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.numberCopyBtn = new System.Windows.Forms.Button();
            this.imageRatioLabel = new System.Windows.Forms.Label();
            this.imageRatioText = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox2.Location = new System.Drawing.Point(211, 415);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(158, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox3.Location = new System.Drawing.Point(12, 470);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(644, 26);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textureCopyBtn
            // 
            this.textureCopyBtn.Location = new System.Drawing.Point(512, 415);
            this.textureCopyBtn.Name = "textureCopyBtn";
            this.textureCopyBtn.Size = new System.Drawing.Size(144, 25);
            this.textureCopyBtn.TabIndex = 4;
            this.textureCopyBtn.Text = "클립보드에 이미지복사";
            this.textureCopyBtn.UseVisualStyleBackColor = true;
            this.textureCopyBtn.Click += new System.EventHandler(this.imageCopyBtn_Click);
            // 
            // decimalText
            // 
            this.decimalText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.decimalText.Location = new System.Drawing.Point(12, 415);
            this.decimalText.Name = "decimalText";
            this.decimalText.Size = new System.Drawing.Size(193, 26);
            this.decimalText.TabIndex = 6;
            this.decimalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.decimalText.TextChanged += new System.EventHandler(this.decimalText_TextChanged);
            this.decimalText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimalText_KeyPress);
            // 
            // binarylabel
            // 
            this.binarylabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.binarylabel.Location = new System.Drawing.Point(12, 444);
            this.binarylabel.Name = "binarylabel";
            this.binarylabel.Size = new System.Drawing.Size(64, 23);
            this.binarylabel.TabIndex = 7;
            this.binarylabel.Text = "2진수";
            // 
            // hexadecimallabel
            // 
            this.hexadecimallabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.hexadecimallabel.Location = new System.Drawing.Point(211, 389);
            this.hexadecimallabel.Name = "hexadecimallabel";
            this.hexadecimallabel.Size = new System.Drawing.Size(64, 23);
            this.hexadecimallabel.TabIndex = 8;
            this.hexadecimallabel.Text = "16진수";
            // 
            // decimallabel
            // 
            this.decimallabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.decimallabel.Location = new System.Drawing.Point(12, 389);
            this.decimallabel.Name = "decimallabel";
            this.decimallabel.Size = new System.Drawing.Size(64, 23);
            this.decimallabel.TabIndex = 9;
            this.decimallabel.Text = "10진수";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(673, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // numberCopyBtn
            // 
            this.numberCopyBtn.Location = new System.Drawing.Point(375, 415);
            this.numberCopyBtn.Name = "numberCopyBtn";
            this.numberCopyBtn.Size = new System.Drawing.Size(131, 26);
            this.numberCopyBtn.TabIndex = 11;
            this.numberCopyBtn.Text = "클립보드에 번호복사";
            this.numberCopyBtn.UseVisualStyleBackColor = true;
            this.numberCopyBtn.Click += new System.EventHandler(this.numberCopyBtn_Click);
            // 
            // imageRatioLabel
            // 
            this.imageRatioLabel.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.imageRatioLabel.Location = new System.Drawing.Point(512, 388);
            this.imageRatioLabel.Name = "imageRatioLabel";
            this.imageRatioLabel.Size = new System.Drawing.Size(75, 24);
            this.imageRatioLabel.TabIndex = 12;
            this.imageRatioLabel.Text = "크기 비율";
            // 
            // imageRatioText
            // 
            this.imageRatioText.Location = new System.Drawing.Point(593, 388);
            this.imageRatioText.Name = "imageRatioText";
            this.imageRatioText.Size = new System.Drawing.Size(63, 21);
            this.imageRatioText.TabIndex = 5;
            this.imageRatioText.Text = "100";
            this.imageRatioText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 536);
            this.Controls.Add(this.imageRatioLabel);
            this.Controls.Add(this.numberCopyBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.decimallabel);
            this.Controls.Add(this.hexadecimallabel);
            this.Controls.Add(this.binarylabel);
            this.Controls.Add(this.decimalText);
            this.Controls.Add(this.imageRatioText);
            this.Controls.Add(this.textureCopyBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox imageRatioText;
        private System.Windows.Forms.Label decimallabel;
        private System.Windows.Forms.Label hexadecimallabel;
        private System.Windows.Forms.Label imageRatioLabel;
        private System.Windows.Forms.Label binarylabel;

        private System.Windows.Forms.TextBox decimalText;

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button textureCopyBtn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button numberCopyBtn;
    }
}

