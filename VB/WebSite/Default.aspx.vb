Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub gridView_BeforeGetCallbackResult(ByVal sender As Object, ByVal e As EventArgs)
		Dim grid As ASPxGridView = TryCast(sender, ASPxGridView)
		If grid.IsNewRowEditing Then
			grid.SettingsText.PopupEditFormCaption = "Add new row"
		Else
			grid.SettingsText.PopupEditFormCaption = "Edit row"
		End If
	End Sub
End Class