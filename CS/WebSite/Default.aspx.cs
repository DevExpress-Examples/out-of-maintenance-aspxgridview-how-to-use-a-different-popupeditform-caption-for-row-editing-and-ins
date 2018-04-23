using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridView;

public partial class _Default: System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }
    protected void gridView_BeforeGetCallbackResult(object sender, EventArgs e) {
        ASPxGridView grid = sender as ASPxGridView;
        if (grid.IsNewRowEditing)
            grid.SettingsText.PopupEditFormCaption = "Add new row";
        else
            grid.SettingsText.PopupEditFormCaption = "Edit row";
    }
}