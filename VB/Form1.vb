Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace SaveRestoreSplitterPosition

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits Form

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private simpleButton2 As DevExpress.XtraEditors.SimpleButton

        Private panel1 As Panel

        Private BasePanel As Panel

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            panel1 = New Panel()
            BasePanel = New Panel()
            panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' simpleButton1
            ' 
            simpleButton1.Location = New System.Drawing.Point(16, 8)
            simpleButton1.Name = "simpleButton1"
            simpleButton1.Size = New System.Drawing.Size(168, 23)
            simpleButton1.TabIndex = 0
            simpleButton1.Text = "Load module"
            AddHandler simpleButton1.Click, New EventHandler(AddressOf simpleButton1_Click)
            ' 
            ' simpleButton2
            ' 
            simpleButton2.Location = New System.Drawing.Point(192, 8)
            simpleButton2.Name = "simpleButton2"
            simpleButton2.Size = New System.Drawing.Size(168, 23)
            simpleButton2.TabIndex = 1
            simpleButton2.Text = "Unload module"
            AddHandler simpleButton2.Click, New EventHandler(AddressOf simpleButton2_Click)
            ' 
            ' panel1
            ' 
            panel1.Controls.Add(simpleButton2)
            panel1.Controls.Add(simpleButton1)
            panel1.Dock = DockStyle.Top
            panel1.Location = New System.Drawing.Point(0, 0)
            panel1.Name = "panel1"
            panel1.Size = New System.Drawing.Size(504, 48)
            panel1.TabIndex = 2
            ' 
            ' BasePanel
            ' 
            BasePanel.Dock = DockStyle.Fill
            BasePanel.Location = New System.Drawing.Point(0, 48)
            BasePanel.Name = "BasePanel"
            BasePanel.Size = New System.Drawing.Size(504, 282)
            BasePanel.TabIndex = 3
            ' 
            ' Form1
            ' 
            AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            ClientSize = New System.Drawing.Size(504, 330)
            Me.Controls.Add(BasePanel)
            Me.Controls.Add(panel1)
            Name = "Form1"
            Text = "Form1"
            panel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Call Application.Run(New Form1())
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            CurrentModule = New UserControl1()
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            CurrentModule = Nothing
        End Sub

        Private currentModuleField As UserControl

        Private Property CurrentModule As UserControl
            Get
                Return currentModuleField
            End Get

            Set(ByVal value As UserControl)
                If currentModuleField IsNot value Then
                    If currentModuleField IsNot Nothing Then UnloadModule(currentModuleField)
                    If value IsNot Nothing Then LoadModule(value)
                    currentModuleField = value
                End If
            End Set
        End Property

        Private Sub LoadModule(ByVal [module] As UserControl)
            [module].Dock = DockStyle.Fill
            BasePanel.Controls.Add([module])
        End Sub

        Private Sub UnloadModule(ByVal [module] As UserControl)
            BasePanel.Controls.Remove([module])
            [module].Dispose()
            Settings.Default.Save()
        End Sub
    End Class
End Namespace
