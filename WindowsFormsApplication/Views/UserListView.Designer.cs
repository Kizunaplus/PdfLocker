namespace Kizuna.Plus.PdfLocker.Views
{
    partial class UserListView
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.UserData = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyButton = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.folderSelectbutton = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).BeginInit();
            this.SuspendLayout();
            // 
            // UserData
            // 
            this.UserData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.PasswordColumn,
            this.IdColumn,
            this.DescriptionColumn});
            this.UserData.Location = new System.Drawing.Point(0, 30);
            this.UserData.Name = "UserData";
            this.UserData.RowTemplate.Height = 21;
            this.UserData.Size = new System.Drawing.Size(390, 193);
            this.UserData.TabIndex = 3;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "名称";
            this.NameColumn.Name = "NameColumn";
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.DataPropertyName = "Password";
            this.PasswordColumn.HeaderText = "パスワード";
            this.PasswordColumn.Name = "PasswordColumn";
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.DataPropertyName = "Descript";
            this.DescriptionColumn.HeaderText = "備考";
            this.DescriptionColumn.Name = "DescriptionColumn";
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(312, 229);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "適用";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // FilePath
            // 
            this.FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.FilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.FilePath.Location = new System.Drawing.Point(98, 5);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(258, 19);
            this.FilePath.TabIndex = 1;
            // 
            // folderSelectbutton
            // 
            this.folderSelectbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folderSelectbutton.CausesValidation = false;
            this.folderSelectbutton.Location = new System.Drawing.Point(362, 3);
            this.folderSelectbutton.Name = "folderSelectbutton";
            this.folderSelectbutton.Size = new System.Drawing.Size(25, 23);
            this.folderSelectbutton.TabIndex = 2;
            this.folderSelectbutton.Text = "...";
            this.folderSelectbutton.UseVisualStyleBackColor = true;
            this.folderSelectbutton.Click += new System.EventHandler(this.folderSelectbutton_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(3, 8);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(89, 12);
            this.filePathLabel.TabIndex = 0;
            this.filePathLabel.Text = "対象フォルダパス :";
            // 
            // UserListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.folderSelectbutton);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.UserData);
            this.Name = "UserListView";
            this.Size = new System.Drawing.Size(390, 257);
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserData;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button folderSelectbutton;
        private System.Windows.Forms.Label filePathLabel;
    }
}
