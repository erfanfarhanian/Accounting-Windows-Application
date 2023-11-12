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
    public partial class frmPaymentOrDepositDocByDate : DevExpress.XtraEditors.XtraForm
    {
        public frmPaymentOrDepositDocByDate()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtRegistrationDate.Value == null || txtDueDate.Value == null)
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (frmPaymentDocuments.isPaymentDoc)
            {
                StiReport report = new StiReport();
                report.Load(@"ReportFiles\RptPaymentDocumentByDate.mrt");
                report.Compile();
                report["RegistrationDate"] = txtRegistrationDate.GetText("yyyy/MM/dd");
                report["DueDate"] = txtDueDate.GetText("yyyy/MM/dd");
                report.ShowWithRibbonGUI();
            }
            else if (!frmPaymentDocuments.isPaymentDoc)
            {
                StiReport report = new StiReport();
                report.Load(@"ReportFiles\RptDepositDocumentByDate.mrt");
                report.Compile();
                report["RegistrationDate"] = txtRegistrationDate.GetText("yyyy/MM/dd");
                report["DueDate"] = txtDueDate.GetText("yyyy/MM/dd");
                report.ShowWithRibbonGUI();
            }
        }
    }
}