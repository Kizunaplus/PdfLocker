﻿namespace Kizuna.Plus.WinMvcForm.Framework.Views.Forms
{
    partial class AbstractForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbstractForm));
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.searchControl = new Kizuna.Plus.WinMvcForm.Framework.Views.CommonControl.SearchControl();
            this.debugMessageArea = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileCreateNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileN1ToolStripMenuItemSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.FileSaveSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveAsAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileN2ToolStripMenuItemSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.FilePrintPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilePrintPreviewVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileN3ToolStripMenuItemSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.FileExitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditUndoUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditRedoRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditN1ToolStripMenuItemSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.EditCutTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCopyCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPastePToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditN2ToolStripMenuItemSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.EditSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolCustomizeCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolOptionOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpContentsCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpIndexIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpSearchSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpN1ToolStripMenuItemSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.HelpAboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.nortifyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NortifyExitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainContentPanel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.nortifyContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Controls.Add(this.searchControl);
            this.MainContentPanel.Controls.Add(this.debugMessageArea);
            this.MainContentPanel.Controls.Add(this.statusLabel);
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(0, 0);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(584, 362);
            this.MainContentPanel.TabIndex = 0;
            // 
            // searchControl
            // 
            this.searchControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchControl.Location = new System.Drawing.Point(312, -1);
            this.searchControl.Name = "searchControl";
            this.searchControl.Size = new System.Drawing.Size(273, 30);
            this.searchControl.TabIndex = 2;
            this.searchControl.View = null;
            this.searchControl.Visible = false;
            // 
            // debugMessageArea
            // 
            this.debugMessageArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.debugMessageArea.BackColor = System.Drawing.SystemColors.Window;
            this.debugMessageArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debugMessageArea.Location = new System.Drawing.Point(388, 211);
            this.debugMessageArea.Multiline = true;
            this.debugMessageArea.Name = "debugMessageArea";
            this.debugMessageArea.ReadOnly = true;
            this.debugMessageArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.debugMessageArea.Size = new System.Drawing.Size(184, 139);
            this.debugMessageArea.TabIndex = 1;
            this.debugMessageArea.WordWrap = false;
            this.debugMessageArea.DoubleClick += new System.EventHandler(this.debugMessageArea_DoubleClick);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Location = new System.Drawing.Point(-1, 345);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(2);
            this.statusLabel.Size = new System.Drawing.Size(43, 18);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLabel.UseMnemonic = false;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileFToolStripMenuItem,
            this.EditEToolStripMenuItem,
            this.ToolTToolStripMenuItem,
            this.HelpHToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(584, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            this.mainMenuStrip.Visible = false;
            // 
            // FileFToolStripMenuItem
            // 
            this.FileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileCreateNToolStripMenuItem,
            this.FileOpenOToolStripMenuItem,
            this.FileN1ToolStripMenuItemSeparator,
            this.FileSaveSToolStripMenuItem,
            this.FileSaveAsAToolStripMenuItem,
            this.FileN2ToolStripMenuItemSeparator,
            this.FilePrintPToolStripMenuItem,
            this.FilePrintPreviewVToolStripMenuItem,
            this.FileN3ToolStripMenuItemSeparator,
            this.FileExitXToolStripMenuItem});
            this.FileFToolStripMenuItem.Name = "FileFToolStripMenuItem";
            this.FileFToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.FileFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // FileCreateNToolStripMenuItem
            // 
            this.FileCreateNToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FileCreateNToolStripMenuItem.Image")));
            this.FileCreateNToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileCreateNToolStripMenuItem.Name = "FileCreateNToolStripMenuItem";
            this.FileCreateNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FileCreateNToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.FileCreateNToolStripMenuItem.Tag = "FileNew";
            this.FileCreateNToolStripMenuItem.Text = "新規作成(&N)";
            this.FileCreateNToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // FileOpenOToolStripMenuItem
            // 
            this.FileOpenOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FileOpenOToolStripMenuItem.Image")));
            this.FileOpenOToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileOpenOToolStripMenuItem.Name = "FileOpenOToolStripMenuItem";
            this.FileOpenOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FileOpenOToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.FileOpenOToolStripMenuItem.Tag = "FileOpen";
            this.FileOpenOToolStripMenuItem.Text = "開く(&O)";
            this.FileOpenOToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // FileN1ToolStripMenuItemSeparator
            // 
            this.FileN1ToolStripMenuItemSeparator.Name = "FileN1ToolStripMenuItemSeparator";
            this.FileN1ToolStripMenuItemSeparator.Size = new System.Drawing.Size(192, 6);
            // 
            // FileSaveSToolStripMenuItem
            // 
            this.FileSaveSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FileSaveSToolStripMenuItem.Image")));
            this.FileSaveSToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileSaveSToolStripMenuItem.Name = "FileSaveSToolStripMenuItem";
            this.FileSaveSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FileSaveSToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.FileSaveSToolStripMenuItem.Tag = "FileSave";
            this.FileSaveSToolStripMenuItem.Text = "上書き保存(&S)";
            this.FileSaveSToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // FileSaveAsAToolStripMenuItem
            // 
            this.FileSaveAsAToolStripMenuItem.Name = "FileSaveAsAToolStripMenuItem";
            this.FileSaveAsAToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.FileSaveAsAToolStripMenuItem.Tag = "FileSaveAs";
            this.FileSaveAsAToolStripMenuItem.Text = "名前を付けて保存(&A)";
            this.FileSaveAsAToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // FileN2ToolStripMenuItemSeparator
            // 
            this.FileN2ToolStripMenuItemSeparator.Name = "FileN2ToolStripMenuItemSeparator";
            this.FileN2ToolStripMenuItemSeparator.Size = new System.Drawing.Size(192, 6);
            // 
            // FilePrintPToolStripMenuItem
            // 
            this.FilePrintPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FilePrintPToolStripMenuItem.Image")));
            this.FilePrintPToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilePrintPToolStripMenuItem.Name = "FilePrintPToolStripMenuItem";
            this.FilePrintPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.FilePrintPToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.FilePrintPToolStripMenuItem.Tag = "Printer";
            this.FilePrintPToolStripMenuItem.Text = "印刷(&P)";
            this.FilePrintPToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // FilePrintPreviewVToolStripMenuItem
            // 
            this.FilePrintPreviewVToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FilePrintPreviewVToolStripMenuItem.Image")));
            this.FilePrintPreviewVToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilePrintPreviewVToolStripMenuItem.Name = "FilePrintPreviewVToolStripMenuItem";
            this.FilePrintPreviewVToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.FilePrintPreviewVToolStripMenuItem.Tag = "PrinterPreview";
            this.FilePrintPreviewVToolStripMenuItem.Text = "印刷プレビュー(&V)";
            this.FilePrintPreviewVToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // FileN3ToolStripMenuItemSeparator
            // 
            this.FileN3ToolStripMenuItemSeparator.Name = "FileN3ToolStripMenuItemSeparator";
            this.FileN3ToolStripMenuItemSeparator.Size = new System.Drawing.Size(192, 6);
            // 
            // FileExitXToolStripMenuItem
            // 
            this.FileExitXToolStripMenuItem.Name = "FileExitXToolStripMenuItem";
            this.FileExitXToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.FileExitXToolStripMenuItem.Tag = "WindowClose";
            this.FileExitXToolStripMenuItem.Text = "終了(&X)";
            this.FileExitXToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // EditEToolStripMenuItem
            // 
            this.EditEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditUndoUToolStripMenuItem,
            this.EditRedoRToolStripMenuItem,
            this.EditN1ToolStripMenuItemSeparator,
            this.EditCutTToolStripMenuItem,
            this.EditCopyCToolStripMenuItem,
            this.EditPastePToolStripMenuItem,
            this.EditN2ToolStripMenuItemSeparator,
            this.EditSelectToolStripMenuItem});
            this.EditEToolStripMenuItem.Name = "EditEToolStripMenuItem";
            this.EditEToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.EditEToolStripMenuItem.Text = "編集(&E)";
            // 
            // EditUndoUToolStripMenuItem
            // 
            this.EditUndoUToolStripMenuItem.Name = "EditUndoUToolStripMenuItem";
            this.EditUndoUToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.EditUndoUToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.EditUndoUToolStripMenuItem.Tag = "EditUndo";
            this.EditUndoUToolStripMenuItem.Text = "元に戻す(&U)";
            this.EditUndoUToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // EditRedoRToolStripMenuItem
            // 
            this.EditRedoRToolStripMenuItem.Name = "EditRedoRToolStripMenuItem";
            this.EditRedoRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.EditRedoRToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.EditRedoRToolStripMenuItem.Tag = "EditRedo";
            this.EditRedoRToolStripMenuItem.Text = "やり直し(&R)";
            this.EditRedoRToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // EditN1ToolStripMenuItemSeparator
            // 
            this.EditN1ToolStripMenuItemSeparator.Name = "EditN1ToolStripMenuItemSeparator";
            this.EditN1ToolStripMenuItemSeparator.Size = new System.Drawing.Size(188, 6);
            // 
            // EditCutTToolStripMenuItem
            // 
            this.EditCutTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditCutTToolStripMenuItem.Image")));
            this.EditCutTToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditCutTToolStripMenuItem.Name = "EditCutTToolStripMenuItem";
            this.EditCutTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.EditCutTToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.EditCutTToolStripMenuItem.Tag = "EditCut";
            this.EditCutTToolStripMenuItem.Text = "切り取り(&T)";
            this.EditCutTToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // EditCopyCToolStripMenuItem
            // 
            this.EditCopyCToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditCopyCToolStripMenuItem.Image")));
            this.EditCopyCToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditCopyCToolStripMenuItem.Name = "EditCopyCToolStripMenuItem";
            this.EditCopyCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.EditCopyCToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.EditCopyCToolStripMenuItem.Tag = "EditCopy";
            this.EditCopyCToolStripMenuItem.Text = "コピー(&C)";
            this.EditCopyCToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // EditPastePToolStripMenuItem
            // 
            this.EditPastePToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditPastePToolStripMenuItem.Image")));
            this.EditPastePToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditPastePToolStripMenuItem.Name = "EditPastePToolStripMenuItem";
            this.EditPastePToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.EditPastePToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.EditPastePToolStripMenuItem.Tag = "EditPaste";
            this.EditPastePToolStripMenuItem.Text = "貼り付け(&P)";
            this.EditPastePToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // EditN2ToolStripMenuItemSeparator
            // 
            this.EditN2ToolStripMenuItemSeparator.Name = "EditN2ToolStripMenuItemSeparator";
            this.EditN2ToolStripMenuItemSeparator.Size = new System.Drawing.Size(188, 6);
            // 
            // EditSelectToolStripMenuItem
            // 
            this.EditSelectToolStripMenuItem.Name = "EditSelectToolStripMenuItem";
            this.EditSelectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.EditSelectToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.EditSelectToolStripMenuItem.Tag = "EditSelect";
            this.EditSelectToolStripMenuItem.Text = "すべて選択(&A)";
            this.EditSelectToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // ToolTToolStripMenuItem
            // 
            this.ToolTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolCustomizeCToolStripMenuItem,
            this.ToolOptionOToolStripMenuItem});
            this.ToolTToolStripMenuItem.Name = "ToolTToolStripMenuItem";
            this.ToolTToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ToolTToolStripMenuItem.Text = "ツール(&T)";
            // 
            // ToolCustomizeCToolStripMenuItem
            // 
            this.ToolCustomizeCToolStripMenuItem.Name = "ToolCustomizeCToolStripMenuItem";
            this.ToolCustomizeCToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ToolCustomizeCToolStripMenuItem.Tag = "ToolCustomize";
            this.ToolCustomizeCToolStripMenuItem.Text = "カスタマイズ(&C)";
            this.ToolCustomizeCToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // ToolOptionOToolStripMenuItem
            // 
            this.ToolOptionOToolStripMenuItem.Name = "ToolOptionOToolStripMenuItem";
            this.ToolOptionOToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ToolOptionOToolStripMenuItem.Tag = "ToolOption";
            this.ToolOptionOToolStripMenuItem.Text = "オプション(&O)";
            this.ToolOptionOToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // HelpHToolStripMenuItem
            // 
            this.HelpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpContentsCToolStripMenuItem,
            this.HelpIndexIToolStripMenuItem,
            this.HelpSearchSToolStripMenuItem,
            this.HelpN1ToolStripMenuItemSeparator,
            this.HelpAboutAToolStripMenuItem});
            this.HelpHToolStripMenuItem.Name = "HelpHToolStripMenuItem";
            this.HelpHToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.HelpHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // HelpContentsCToolStripMenuItem
            // 
            this.HelpContentsCToolStripMenuItem.Name = "HelpContentsCToolStripMenuItem";
            this.HelpContentsCToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.HelpContentsCToolStripMenuItem.Tag = "HelpContents";
            this.HelpContentsCToolStripMenuItem.Text = "内容(&C)";
            this.HelpContentsCToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // HelpIndexIToolStripMenuItem
            // 
            this.HelpIndexIToolStripMenuItem.Name = "HelpIndexIToolStripMenuItem";
            this.HelpIndexIToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.HelpIndexIToolStripMenuItem.Tag = "HelpIndex";
            this.HelpIndexIToolStripMenuItem.Text = "インデックス(&I)";
            this.HelpIndexIToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // HelpSearchSToolStripMenuItem
            // 
            this.HelpSearchSToolStripMenuItem.Name = "HelpSearchSToolStripMenuItem";
            this.HelpSearchSToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.HelpSearchSToolStripMenuItem.Tag = "HelpSearch";
            this.HelpSearchSToolStripMenuItem.Text = "検索(&S)";
            this.HelpSearchSToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // HelpN1ToolStripMenuItemSeparator
            // 
            this.HelpN1ToolStripMenuItemSeparator.Name = "HelpN1ToolStripMenuItemSeparator";
            this.HelpN1ToolStripMenuItemSeparator.Size = new System.Drawing.Size(170, 6);
            // 
            // HelpAboutAToolStripMenuItem
            // 
            this.HelpAboutAToolStripMenuItem.Name = "HelpAboutAToolStripMenuItem";
            this.HelpAboutAToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.HelpAboutAToolStripMenuItem.Tag = "HelpAbout";
            this.HelpAboutAToolStripMenuItem.Text = "バージョン情報(&A)...";
            this.HelpAboutAToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.nortifyContextMenuStrip;
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // nortifyContextMenuStrip
            // 
            this.nortifyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NortifyExitXToolStripMenuItem});
            this.nortifyContextMenuStrip.Name = "nortifyContextMenuStrip";
            this.nortifyContextMenuStrip.Size = new System.Drawing.Size(117, 26);
            // 
            // NortifyExitXToolStripMenuItem
            // 
            this.NortifyExitXToolStripMenuItem.Name = "NortifyExitXToolStripMenuItem";
            this.NortifyExitXToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.NortifyExitXToolStripMenuItem.Tag = "WindowClose";
            this.NortifyExitXToolStripMenuItem.Text = "終了(&X)";
            this.NortifyExitXToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // validToolTip
            // 
            this.validToolTip.IsBalloon = true;
            this.validToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.validToolTip.ToolTipTitle = "入力エラー";
            // 
            // AbstractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "AbstractForm";
            this.Text = "AbstractForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AbstractForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainContentPanel.ResumeLayout(false);
            this.MainContentPanel.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.nortifyContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ContextMenuStrip nortifyContextMenuStrip;
        protected System.Windows.Forms.MenuStrip mainMenuStrip;
        protected System.Windows.Forms.ToolStripMenuItem FileFToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem EditEToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem ToolTToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem HelpHToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem NortifyExitXToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem FileCreateNToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem FileOpenOToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem FileSaveSToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem FileSaveAsAToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem FilePrintPToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem FilePrintPreviewVToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem FileExitXToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem EditUndoUToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem EditRedoRToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem EditCutTToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem EditCopyCToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem EditPastePToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem EditSelectToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem ToolCustomizeCToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem ToolOptionOToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem HelpContentsCToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem HelpIndexIToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem HelpSearchSToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem HelpAboutAToolStripMenuItem;
        protected System.Windows.Forms.NotifyIcon notifyIcon;
        protected System.Windows.Forms.Label statusLabel;
        protected System.Windows.Forms.TextBox debugMessageArea;
        protected CommonControl.SearchControl searchControl;
        protected System.Windows.Forms.Panel MainContentPanel;
        protected System.Windows.Forms.ToolStripSeparator FileN1ToolStripMenuItemSeparator;
        protected System.Windows.Forms.ToolStripSeparator FileN2ToolStripMenuItemSeparator;
        protected System.Windows.Forms.ToolStripSeparator FileN3ToolStripMenuItemSeparator;
        protected System.Windows.Forms.ToolStripSeparator EditN1ToolStripMenuItemSeparator;
        protected System.Windows.Forms.ToolStripSeparator EditN2ToolStripMenuItemSeparator;
        protected System.Windows.Forms.ToolStripSeparator HelpN1ToolStripMenuItemSeparator;
        private System.Windows.Forms.ToolTip validToolTip;

    }
}

