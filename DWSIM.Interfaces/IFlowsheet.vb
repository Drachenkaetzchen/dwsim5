﻿Public Interface IFlowsheet

    Enum MessageType
        Information
        Warning
        GeneralError
        Tip
        Other
    End Enum

    ReadOnly Property Reactions As Dictionary(Of String, IReaction)

    ReadOnly Property ReactionSets As Dictionary(Of String, IReactionSet)

    ReadOnly Property SimulationObjects As Dictionary(Of String, ISimulationObject)

    ReadOnly Property GraphicObjects As Dictionary(Of String, IGraphicObject)

    ReadOnly Property PropertyPackages As Dictionary(Of String, IPropertyPackage)

    ReadOnly Property Settings As Dictionary(Of String, Object)

    ReadOnly Property SelectedCompounds As Dictionary(Of String, ICompoundConstantProperties)

    Sub ShowMessage(ByVal text As String, ByVal mtype As MessageType)

    Sub ShowDebugInfo(ByVal text As String, ByVal level As Integer)

    Sub CheckStatus()

    Function GetTranslatedString(text As String, locale As String) As String

    Function GetTranslatedString(text As String) As String

    ReadOnly Property FlowsheetOptions As IFlowsheetOptions

    Function GetFlowsheetSimulationObject(tag As String) As ISimulationObject

    Function GetSelectedFlowsheetSimulationObject(tag As String) As ISimulationObject

    Sub DisplayForm(form As Object)

End Interface
