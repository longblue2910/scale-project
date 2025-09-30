using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Electric_Scale.frm
{
    public partial class frmReportView : Form
    {
        public frmReportView()
        {
            InitializeComponent();
        }

        private void _ppv_PreviewButtonClick(object sender, C1.Win.C1PrintPreview.PreviewToolBarButtonClickEventArgs e)
        {
            if (e.Action == C1.Win.C1PrintPreview.ToolBarButtonActionEnum.FilePrint)
            {
                this._ppv.Print();
                this.Dispose();
            }
        }
        
        private void _ppv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                this._ppv.Print();
                this.Dispose();
            }
        }
    }
}