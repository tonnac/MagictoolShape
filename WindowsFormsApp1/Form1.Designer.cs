
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
            this.itemPanel = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.itemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(213, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(158, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(14, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(644, 26);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textureCopyBtn
            // 
            this.textureCopyBtn.Location = new System.Drawing.Point(511, 32);
            this.textureCopyBtn.Name = "textureCopyBtn";
            this.textureCopyBtn.Size = new System.Drawing.Size(144, 25);
            this.textureCopyBtn.TabIndex = 4;
            this.textureCopyBtn.Text = "클립보드에 이미지복사";
            this.textureCopyBtn.UseVisualStyleBackColor = true;
            this.textureCopyBtn.Click += new System.EventHandler(this.imageCopyBtn_Click);
            // 
            // decimalText
            // 
            this.decimalText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalText.Location = new System.Drawing.Point(14, 30);
            this.decimalText.Name = "decimalText";
            this.decimalText.ReadOnly = true;
            this.decimalText.Size = new System.Drawing.Size(193, 26);
            this.decimalText.TabIndex = 6;
            this.decimalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.decimalText.TextChanged += new System.EventHandler(this.decimalText_TextChanged);
            this.decimalText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimalText_KeyPress);
            // 
            // binarylabel
            // 
            this.binarylabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binarylabel.Location = new System.Drawing.Point(14, 63);
            this.binarylabel.Name = "binarylabel";
            this.binarylabel.Size = new System.Drawing.Size(64, 23);
            this.binarylabel.TabIndex = 7;
            this.binarylabel.Text = "2진수";
            // 
            // hexadecimallabel
            // 
            this.hexadecimallabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexadecimallabel.Location = new System.Drawing.Point(209, 4);
            this.hexadecimallabel.Name = "hexadecimallabel";
            this.hexadecimallabel.Size = new System.Drawing.Size(64, 23);
            this.hexadecimallabel.TabIndex = 8;
            this.hexadecimallabel.Text = "16진수";
            // 
            // decimallabel
            // 
            this.decimallabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimallabel.Location = new System.Drawing.Point(14, 4);
            this.decimallabel.Name = "decimallabel";
            this.decimallabel.Size = new System.Drawing.Size(64, 23);
            this.decimallabel.TabIndex = 9;
            this.decimallabel.Text = "10진수";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(669, 22);
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
            this.numberCopyBtn.Location = new System.Drawing.Point(374, 32);
            this.numberCopyBtn.Name = "numberCopyBtn";
            this.numberCopyBtn.Size = new System.Drawing.Size(131, 26);
            this.numberCopyBtn.TabIndex = 11;
            this.numberCopyBtn.Text = "클립보드에 번호복사";
            this.numberCopyBtn.UseVisualStyleBackColor = true;
            this.numberCopyBtn.Click += new System.EventHandler(this.numberCopyBtn_Click);
            // 
            // imageRatioLabel
            // 
            this.imageRatioLabel.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageRatioLabel.Location = new System.Drawing.Point(511, 5);
            this.imageRatioLabel.Name = "imageRatioLabel";
            this.imageRatioLabel.Size = new System.Drawing.Size(75, 24);
            this.imageRatioLabel.TabIndex = 12;
            this.imageRatioLabel.Text = "크기 비율";
            // 
            // imageRatioText
            // 
            this.imageRatioText.Location = new System.Drawing.Point(592, 5);
            this.imageRatioText.Name = "imageRatioText";
            this.imageRatioText.Size = new System.Drawing.Size(63, 21);
            this.imageRatioText.TabIndex = 5;
            this.imageRatioText.Text = "100";
            this.imageRatioText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // itemPanel
            // 
            this.itemPanel.AutoScroll = true;
            this.itemPanel.Controls.Add(this.pictureBox6);
            this.itemPanel.Controls.Add(this.pictureBox5);
            this.itemPanel.Controls.Add(this.pictureBox4);
            this.itemPanel.Controls.Add(this.pictureBox3);
            this.itemPanel.Controls.Add(this.pictureBox2);
            this.itemPanel.Controls.Add(this.pictureBox1);
            this.itemPanel.Location = new System.Drawing.Point(454, 13);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(202, 296);
            this.itemPanel.TabIndex = 13;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.Location = new System.Drawing.Point(4, 472);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(129, 164);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox5.Location = new System.Drawing.Point(3, 409);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(129, 164);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox4.Location = new System.Drawing.Point(4, 360);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(129, 164);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(4, 302);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 164);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(4, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 164);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 164);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.hexadecimallabel);
            this.infoPanel.Controls.Add(this.textBox2);
            this.infoPanel.Controls.Add(this.imageRatioLabel);
            this.infoPanel.Controls.Add(this.textBox3);
            this.infoPanel.Controls.Add(this.numberCopyBtn);
            this.infoPanel.Controls.Add(this.textureCopyBtn);
            this.infoPanel.Controls.Add(this.imageRatioText);
            this.infoPanel.Controls.Add(this.decimallabel);
            this.infoPanel.Controls.Add(this.decimalText);
            this.infoPanel.Controls.Add(this.binarylabel);
            this.infoPanel.Location = new System.Drawing.Point(0, 315);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(673, 120);
            this.infoPanel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 549);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.itemPanel);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.itemPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
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
        private Panel itemPanel;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Panel infoPanel;
    }
}

