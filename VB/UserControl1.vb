Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Namespace SaveRestoreSplitterPosition

    ''' <summary>
    ''' Summary description for UserControl1.
    ''' </summary>
    Public Class UserControl1
        Inherits UserControl

        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                Unloading()
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            CType(splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            splitContainerControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' splitContainerControl1
            ' 
            splitContainerControl1.Dock = DockStyle.Fill
            splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            splitContainerControl1.Name = "splitContainerControl1"
            splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1"
            splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2"
            splitContainerControl1.Size = New System.Drawing.Size(256, 160)
            splitContainerControl1.TabIndex = 0
            splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' UserControl1
            ' 
            Me.Controls.Add(splitContainerControl1)
            Name = "UserControl1"
            Size = New System.Drawing.Size(256, 160)
            CType(splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            splitContainerControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Protected Overrides Sub OnLayout(ByVal levent As LayoutEventArgs)
            MyBase.OnLayout(levent)
            If Equals(levent.AffectedProperty, "Bounds") Then Loaded()
        End Sub

        Private isLoaded As Boolean = False

        Public Overridable Sub Loaded()
            If isLoaded Then Return
            isLoaded = True
            LoadSettings()
        End Sub

        Public Overridable Sub Unloading()
            SaveSettings()
        End Sub

        Const SettingsFile As String = "settings.dat"

        Public Overridable Sub SaveSettings()
            Dim sets As Settings = New Settings()
            sets.SplitterPosition = splitContainerControl1.SplitterPosition
            Dim stream As FileStream = New FileStream(SettingsFile, FileMode.Create)
            Dim formatter As BinaryFormatter = New BinaryFormatter()
            formatter.AssemblyFormat = Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple
            formatter.Serialize(stream, sets)
            stream.Close()
            Console.WriteLine("Saved: {0}", sets.SplitterPosition)
        End Sub

        Public Overridable Sub LoadSettings()
            If Not File.Exists(SettingsFile) Then Return
            Dim stream As FileStream = New FileStream(SettingsFile, FileMode.Open)
            Dim formatter As BinaryFormatter = New BinaryFormatter()
            formatter.AssemblyFormat = Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple
            Dim sets As Settings = TryCast(formatter.Deserialize(stream), Settings)
            stream.Close()
            If sets IsNot Nothing Then
                splitContainerControl1.SplitterPosition = sets.SplitterPosition
                Console.WriteLine("Loaded: {0}, New position: {1}", sets.SplitterPosition, splitContainerControl1.SplitterPosition)
            End If
        End Sub
    End Class

    <Serializable>
    Public Class Settings

        Public SplitterPosition As Integer
    End Class
End Namespace
