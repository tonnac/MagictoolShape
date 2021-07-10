
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
            this.button1 = new System.Windows.Forms.Button();
            this.NumText = new System.Windows.Forms.TextBox();
            this.decimalText = new System.Windows.Forms.TextBox();
            this.binarylabel = new System.Windows.Forms.Label();
            this.hexadecimallabel = new System.Windows.Forms.Label();
            this.decimallabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox2.Location = new System.Drawing.Point(211, 560);
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
            this.textBox3.Location = new System.Drawing.Point(375, 560);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(655, 26);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumText
            // 
            this.NumText.Location = new System.Drawing.Point(810, 123);
            this.NumText.Name = "NumText";
            this.NumText.Size = new System.Drawing.Size(100, 21);
            this.NumText.TabIndex = 5;
            // 
            // decimalText
            // 
            this.decimalText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.decimalText.Location = new System.Drawing.Point(12, 560);
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
            this.binarylabel.Location = new System.Drawing.Point(375, 534);
            this.binarylabel.Name = "binarylabel";
            this.binarylabel.Size = new System.Drawing.Size(64, 23);
            this.binarylabel.TabIndex = 7;
            this.binarylabel.Text = "2진수";
            // 
            // hexadecimallabel
            // 
            this.hexadecimallabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.hexadecimallabel.Location = new System.Drawing.Point(211, 534);
            this.hexadecimallabel.Name = "hexadecimallabel";
            this.hexadecimallabel.Size = new System.Drawing.Size(64, 23);
            this.hexadecimallabel.TabIndex = 8;
            this.hexadecimallabel.Text = "16진수";
            // 
            // decimallabel
            // 
            this.decimallabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.decimallabel.Location = new System.Drawing.Point(12, 534);
            this.decimallabel.Name = "decimallabel";
            this.decimallabel.Size = new System.Drawing.Size(64, 23);
            this.decimallabel.TabIndex = 9;
            this.decimallabel.Text = "10진수";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 740);
            this.Controls.Add(this.decimallabel);
            this.Controls.Add(this.hexadecimallabel);
            this.Controls.Add(this.binarylabel);
            this.Controls.Add(this.decimalText);
            this.Controls.Add(this.NumText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label decimallabel;

        private System.Windows.Forms.Label hexadecimallabel;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label binarylabel;
        private System.Windows.Forms.Label @decimal;

        private System.Windows.Forms.TextBox decimalText;

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NumText;
    }
}

