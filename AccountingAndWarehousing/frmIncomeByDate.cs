using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Stimulsoft.Report;

namespace AccountingAndWarehousing
{
    public partial class frmIncomeOrCostByDate : DevExpress.XtraEditors.XtraForm
    {
        public frmIncomeOrCostByDate()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtFromDate.Value == null || txtToDate.Value == null)
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtFromDate.Value > txtToDate.Value)
            {
                MessageBox.Show("لطفا تاریخ شروع و پایان را به درستی وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (frmIncome.isIncome)
            {
                StiReport report = new StiReport();
                report.Load(@"ReportFiles\RptIncomeByDate.mrt");
                report.Compile();
                report["FromDate"] = txtFromDate.GetText("yyyy/MM/dd");
                report["ToDate"] = txtToDate.GetText("yyyy/MM/dd");
                report.ShowWithRibbonGUI();
            }
            else if (!frmIncome.isIncome)
            {
                StiReport report = new StiReport();
                report.Load(@"ReportFiles\RptCostByDate.mrt");
                report.Compile();
                report["FromDate"] = txtFromDate.GetText("yyyy/MM/dd");
                report["ToDate"] = txtToDate.GetText("yyyy/MM/dd");
                report.ShowWithRibbonGUI();
            }
        }

        private void frmIncomeByDate_Load(object sender, EventArgs e)
        {

        }
    }
}