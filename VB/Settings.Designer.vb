'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Namespace SaveRestoreSplitterPosition

    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.9.0.0")>
    Friend NotInheritable Partial Class Settings
        Inherits Global.System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As SaveRestoreSplitterPosition.Settings = CType((Global.System.Configuration.ApplicationSettingsBase.Synchronized(New SaveRestoreSplitterPosition.Settings())), SaveRestoreSplitterPosition.Settings)

        Public Shared ReadOnly Property [Default] As Settings
            Get
                Return SaveRestoreSplitterPosition.Settings.defaultInstance
            End Get
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute()>
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
        <Global.System.Configuration.DefaultSettingValueAttribute("0")>
        Public Property SavedSplitterPosition As Integer
            Get
                Return(CInt((Me("SavedSplitterPosition"))))
            End Get

            Set(ByVal value As Integer)
                Me("SavedSplitterPosition") = value
            End Set
        End Property
    End Class
End Namespace
