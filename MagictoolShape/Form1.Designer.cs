
using System.Windows.Forms;

namespace MagictoolShape
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
            this.infoPanel = new System.Windows.Forms.Panel();
            this.itemListBox = new Nevron.Nov.WinFormControls.NListBoxControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.createBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.btnPanel.SuspendLayout();
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
            this.textureCopyBtn.Location = new System.Drawing.Point(511, 29);
            this.textureCopyBtn.Name = "textureCopyBtn";
            this.textureCopyBtn.Size = new System.Drawing.Size(144, 28);
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
            this.numberCopyBtn.Location = new System.Drawing.Point(374, 29);
            this.numberCopyBtn.Name = "numberCopyBtn";
            this.numberCopyBtn.Size = new System.Drawing.Size(131, 28);
            this.numberCopyBtn.TabIndex = 11;
            this.numberCopyBtn.Text = "클립보드에 값 복사";
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
            this.imageRatioText.TextChanged += new System.EventHandler(this.imageRatioText_TextChanged);
            this.imageRatioText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imageRatioText_KeyPress);
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
            this.infoPanel.Location = new System.Drawing.Point(0, 391);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(673, 120);
            this.infoPanel.TabIndex = 14;
            // 
            // itemListBox
            // 
            this.itemListBox.AutoSize = false;
            this.itemListBox.DesignTimeState = null;
            this.itemListBox.Location = new System.Drawing.Point(542, 30);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(115, 355);
            this.itemListBox.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "파일";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.saveToolStripMenuItem.Text = "저장";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem2.Text = "불러오기";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "종료";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "저장 파일(*.bin)|*.bin";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(3, 0);
            this.createBtn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(89, 23);
            this.createBtn.TabIndex = 20;
            this.createBtn.Text = "새로 만들기";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(3, 26);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(89, 23);
            this.addBtn.TabIndex = 21;
            this.addBtn.Text = "추가";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(3, 55);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(89, 23);
            this.modifyBtn.TabIndex = 22;
            this.modifyBtn.Text = "수정";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(3, 84);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(89, 23);
            this.deleteBtn.TabIndex = 23;
            this.deleteBtn.Text = "삭제";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.createBtn);
            this.btnPanel.Controls.Add(this.deleteBtn);
            this.btnPanel.Controls.Add(this.addBtn);
            this.btnPanel.Controls.Add(this.modifyBtn);
            this.btnPanel.Location = new System.Drawing.Point(437, 30);
            this.btnPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(99, 117);
            this.btnPanel.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 549);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MagictoolShape";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

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
        private Panel infoPanel;
        private Nevron.Nov.WinFormControls.NListBoxControl itemListBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button deleteBtn;
        private PrintDialog printDialog1;
        private Panel btnPanel;
    }
}

