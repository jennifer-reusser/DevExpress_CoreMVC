//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevExpress_CoreMVC.Reports {
    
    public partial class AXDocOverview : DevExpress.XtraReports.UI.XtraReport {
        private void InitializeComponent() {
            DevExpress.XtraReports.ReportInitializer reportInitializer = new DevExpress.XtraReports.ReportInitializer(this, "DevExpress_CoreMVC.Reports.AXDocOverview.vsrepx");

            // Controls
            this.TopMargin = reportInitializer.GetControl<DevExpress.XtraReports.UI.TopMarginBand>("TopMargin");
            this.BottomMargin = reportInitializer.GetControl<DevExpress.XtraReports.UI.BottomMarginBand>("BottomMargin");
            this.Detail = reportInitializer.GetControl<DevExpress.XtraReports.UI.DetailBand>("Detail");
            this.PageHeader = reportInitializer.GetControl<DevExpress.XtraReports.UI.PageHeaderBand>("PageHeader");
            this.pageInfo2 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRPageInfo>("pageInfo2");
            this.pageInfo1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRPageInfo>("pageInfo1");
            this.groupType = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRSubreport>("groupType");
            this.groupType.ReportSource = new DevExpress_CoreMVC.Reports.AXGroupTypes();
            this.globalUDL = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRSubreport>("globalUDL");
            this.globalUDL.ReportSource = new DevExpress_CoreMVC.Reports.AXGlobalUDLList();
            this.appList = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRSubreport>("appList");
            this.appList.ReportSource = new DevExpress_CoreMVC.Reports.AXApplicationList();
            this.label1 = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRLabel>("label1");
            this.specialGroups = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRSubreport>("specialGroups");
            this.specialGroups.ReportSource = new DevExpress_CoreMVC.Reports.AXSpecialGroups();
            this.changeLog = reportInitializer.GetControl<DevExpress.XtraReports.UI.XRSubreport>("changeLog");
            this.changeLog.ReportSource = new DevExpress_CoreMVC.Reports.AXSpecialGroupsChangeLog();

            // Data Sources
            this.sqlDataSource1 = reportInitializer.GetDataSource<DevExpress.DataAccess.Sql.SqlDataSource>("sqlDataSource1");

            // Styles
            this.PageInfo = reportInitializer.GetStyle("PageInfo");
        }
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRSubreport groupType;
        private DevExpress.XtraReports.UI.XRSubreport globalUDL;
        private DevExpress.XtraReports.UI.XRSubreport appList;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRSubreport specialGroups;
        private DevExpress.XtraReports.UI.XRSubreport changeLog;
    }
}
