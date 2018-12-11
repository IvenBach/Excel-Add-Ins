VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "RibbonUIUpdater"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Private Type THelper
    XLApplication As Application
    XLWorksheet As Worksheet
End Type

Private this As THelper

'@Ignore ProcedureNotUsed
Private Sub xlApplication_SheetActivate(ByVal ws As Object)
    If TypeName(ws) = "Worksheet" Then
        Set RibbonModifier.RibbonUpdater.XLWorksheet = ActiveSheet
    Else
        Set RibbonModifier.RibbonUpdater.XLWorksheet = Nothing
    End If
    
    RibbonModifier.SyncUIControls
End Sub

'@Ignore ParameterNotUsed, ProcedureNotUsed
Private Sub xlWorksheet_SelectionChange(ByVal Target As Range)
    RibbonModifier.SyncUIControls
End Sub

Public Property Get XLApplication() As Application
    Set XLApplication = this.XLApplication
End Property

Public Property Let XLApplication(ByVal app As Application)
    Set this.XLApplication = app
End Property

Public Property Get XLWorksheet() As Worksheet
    Set XLWorksheet = this.XLWorksheet
End Property

Public Property Let XLWorksheet(ByVal ws As Worksheet)
    Set this.XLWorksheet = ws
End Property
