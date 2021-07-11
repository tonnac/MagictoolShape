
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.testMakePanelBtn = new System.Windows.Forms.Button();
            this.itemListBox = new Nevron.Nov.WinFormControls.NListBoxControl();
            this.addButton = new Nevron.Nov.WinFormControls.NButtonControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            this.textBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            this.decimalText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            this.binarylabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.binarylabel.Location = new System.Drawing.Point(14, 63);
            this.binarylabel.Name = "binarylabel";
            this.binarylabel.Size = new System.Drawing.Size(64, 23);
            this.binarylabel.TabIndex = 7;
            this.binarylabel.Text = "2진수";
            // 
            // hexadecimallabel
            // 
            this.hexadecimallabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.hexadecimallabel.Location = new System.Drawing.Point(209, 4);
            this.hexadecimallabel.Name = "hexadecimallabel";
            this.hexadecimallabel.Size = new System.Drawing.Size(64, 23);
            this.hexadecimallabel.TabIndex = 8;
            this.hexadecimallabel.Text = "16진수";
            // 
            // decimallabel
            // 
            this.decimallabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.decimallabel.Location = new System.Drawing.Point(14, 4);
            this.decimallabel.Name = "decimallabel";
            this.decimallabel.Size = new System.Drawing.Size(64, 23);
            this.decimallabel.TabIndex = 9;
            this.decimallabel.Text = "10진수";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripStatusLabel1});
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
            this.imageRatioLabel.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(374, 17);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // testMakePanelBtn
            // 
            this.testMakePanelBtn.Location = new System.Drawing.Point(374, 47);
            this.testMakePanelBtn.Name = "testMakePanelBtn";
            this.testMakePanelBtn.Size = new System.Drawing.Size(75, 23);
            this.testMakePanelBtn.TabIndex = 16;
            this.testMakePanelBtn.Text = "Test";
            this.testMakePanelBtn.UseVisualStyleBackColor = true;
            this.testMakePanelBtn.Click += new System.EventHandler(this.testMakePanelBtn_Click);
            // 
            // itemListBox
            // 
            this.itemListBox.AutoSize = false;
            this.itemListBox.DesignTimeState = null;
            this.itemListBox.Location = new System.Drawing.Point(542, 13);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(115, 372);
            this.itemListBox.TabIndex = 17;
            // 
            // addButton
            // 
            this.addButton.AutoSize = false;
            this.addButton.DesignTimeState = resources.GetString("addButton.DesignTimeState");
            this.addButton.Location = new System.Drawing.Point(374, 77);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 18;
            this.addButton.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.addButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.saveToolStripMenuItem, this.toolStripMenuItem2, this.toolStripSeparator1, this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "파일";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.saveToolStripMenuItem.Text = "저장";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 549);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.testMakePanelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private Button saveBtn;
        private System.Windows.Forms.Button testMakePanelBtn;
        private Nevron.Nov.WinFormControls.NListBoxControl itemListBox;
        private Nevron.Nov.WinFormControls.NButtonControl addButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private OpenFileDialog openFileDialog1;
    }
}

