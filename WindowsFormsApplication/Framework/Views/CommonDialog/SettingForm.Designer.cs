namespace Kizuna.Plus.WinMvcForm.Framework.Views.CommonDialog
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.oKButton = new System.Windows.Forms.Button();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.menuImageList = new System.Windows.Forms.ImageList(this.components);
            this.menuPanel = new Kizuna.Plus.WinMvcForm.Framework.Views.CommonControl.ImageMenuControl();
            this.homeButton = new System.Windows.Forms.Button();
            this.settingPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(467, 9);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(386, 9);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // oKButton
            // 
            this.oKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.oKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.oKButton.Location = new System.Drawing.Point(305, 9);
            this.oKButton.Name = "oKButton";
            this.oKButton.Size = new System.Drawing.Size(75, 23);
            this.oKButton.TabIndex = 2;
            this.oKButton.Text = "OK";
            this.oKButton.UseVisualStyleBackColor = true;
            this.oKButton.Click += new System.EventHandler(this.oKButton_Click);
            // 
            // settingPanel
            // 
            this.settingPanel.Controls.Add(this.label5);
            this.settingPanel.Controls.Add(this.textBox3);
            this.settingPanel.Controls.Add(this.label4);
            this.settingPanel.Controls.Add(this.label3);
            this.settingPanel.Controls.Add(this.textBox2);
            this.settingPanel.Controls.Add(this.textBox1);
            this.settingPanel.Controls.Add(this.label2);
            this.settingPanel.Controls.Add(this.label1);
            this.settingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingPanel.Location = new System.Drawing.Point(0, 54);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(554, 376);
            this.settingPanel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 84);
            this.label5.TabIndex = 7;
            this.label5.Text = "出力フォーマットで使用する日付のフォーマットが指定可能です。\r\n2014年12月31日 08時45分32秒の場合\r\n設定値       結果\r\nyyyyMM   " +
                "      201412\r\nyyMM            1412\r\nyyyyMMdd    20141231\r\nHH_mm      08_45";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(127, 229);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(415, 19);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "yyyyMM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "日付フォーマット :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 156);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(127, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(415, 19);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(127, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(415, 19);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "出力ファイル名 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDFオーナパスワード :";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.applyButton);
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.oKButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 430);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(554, 44);
            this.buttonPanel.TabIndex = 5;
            // 
            // menuImageList
            // 
            this.menuImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuImageList.ImageStream")));
            this.menuImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuImageList.Images.SetKeyName(0, "homeButton");
            this.menuImageList.Images.SetKeyName(1, "rootButton");
            // 
            // menuPanel
            // 
            this.menuPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.menuPanel.BackColor = System.Drawing.SystemColors.Window;
            this.menuPanel.Controls.Add(this.homeButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.ImageList = this.menuImageList;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(554, 54);
            this.menuPanel.TabIndex = 4;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.homeButton.ImageKey = "homeButton";
            this.homeButton.ImageList = this.menuImageList;
            this.homeButton.Location = new System.Drawing.Point(3, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.homeButton.Size = new System.Drawing.Size(48, 48);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "全般";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 474);
            this.Controls.Add(this.settingPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.buttonPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "設定";
            this.settingPanel.ResumeLayout(false);
            this.settingPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button oKButton;
        private System.Windows.Forms.Panel settingPanel;
        private Kizuna.Plus.WinMvcForm.Framework.Views.CommonControl.ImageMenuControl menuPanel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.ImageList menuImageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}