Attribute VB_Name = "RibbonModifier"
Option Explicit
Option Private Module

Private Type THelper
    UIRibbon As IRibbonUI
    RibbonMonitorer As RibbonUIUpdater
    RibbonUpdater As RibbonUIUpdater
End Type

Private this As THelper

Public Sub InitializeSubSuperScriptingAddin2(ByRef ribbon As IRibbonUI) 'Callback for customUI.onLoad

    Stop

    Debug.Print 1 / 0

    Set this.RibbonMonitorer = New RibbonUIUpdater
    Set this.RibbonUpdater = New RibbonUIUpdater

    Set this.UIRibbon = ribbon
    SubSuperScript.InitializeScriptCharacters
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
    Stop
    Set RibbonMonitorer = this.RibbonMonitorer
End Property
