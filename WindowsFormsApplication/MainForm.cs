﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kizuna.Plus.WinMvcForm.Framework.Views.Forms;

namespace WindowsFormsApplication
{
    public partial class MainForm : AbstractForm
    {
        public MainForm()
        {
            InitializeComponent();

            SetVisibleEnableControl(false, false, new Component[]{
            FilePrintPToolStripMenuItem,
            FilePrintPreviewVToolStripMenuItem,
            FileN3ToolStripMenuItemSeparator,
            EditEToolStripMenuItem,
            ToolCustomizeCToolStripMenuItem,
            HelpContentsCToolStripMenuItem,
            HelpSearchSToolStripMenuItem,
            HelpIndexIToolStripMenuItem,
            HelpN1ToolStripMenuItemSeparator});
        }
    }
}
