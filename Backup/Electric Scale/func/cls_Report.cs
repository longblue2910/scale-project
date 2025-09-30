using System;
using System.Collections.Generic;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data;
using Electric_Scale.func;
using Electric_Scale.frm;

namespace Electric_Scale.func
{
    class cls_Report
    {
        public ReportDocument _rpt;
        public cls_Report()
        {
 
        }
        public cls_Report(ReportDocument rpt, string strSql)
        {
            DataTable tbl;            
            tbl = cls_GlobalUtil.ReturnDataTable(strSql);
            _rpt = rpt;
            _rpt.SetDataSource(tbl);
        }
//        public void open()
//        {
//            frmViewWeightingSheet frm = new frmViewWeightingSheet();
//            frm.crystalReportViewer.ReportSource = _rpt;
//            frm.ShowDialog();
//        }
    }
}
