Attribute VB_Name = "RibbonModifier"
Option Explicit
Option Private Module

Private Type THelper
    UIRibbon As IRibbonUI
    RibbonMonitorer As RibbonUIUpdater
    RibbonUpdater As RibbonUIUpdater
End Type

Private this As THelper

Public Sub InitializeUIAddin(ByRef ribbon As IRibbonUI) 'Callback for customUI.onLoad
    Set this.RibbonMonitorer = New RibbonUIUpdater
    Set this.RibbonUpdater = New RibbonUIUpdater
    
    Set this.UIRibbon = ribbon
End Sub

Public Sub SyncUIControls()
    UIRibbon.Invalidate
End Sub

Public Property Get UIRibbon() As IRibbonUI
    Set UIRibbon = this.UIRibbon
End Property

Public Property Get RibbonUpdater() As RibbonUIUpdater
    If this.RibbonUpdater Is Nothing Then
        Set this.RibbonUpdater = New RibbonUIUpdater
    End If
    Set RibbonUpdater = this.RibbonUpdater
End Property

Public Property Let RibbonUpdater(ByVal newUpdater As RibbonUIUpdater)
    Set RibbonUpdater = newUpdater
End Property

Public Property Get RibbonMonitorer() As RibbonUIUpdater
    RibbonMonitorer = this.RibbonMonitorer
End Property
