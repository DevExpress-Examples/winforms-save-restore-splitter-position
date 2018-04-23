Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace SaveRestoreSplitterPosition
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private panel1 As System.Windows.Forms.Panel
		Private BasePanel As System.Windows.Forms.Panel
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
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.BasePanel = New System.Windows.Forms.Panel()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(16, 8)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(168, 23)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Load module"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(192, 8)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(168, 23)
			Me.simpleButton2.TabIndex = 1
			Me.simpleButton2.Text = "Unload module"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.simpleButton2)
			Me.panel1.Controls.Add(Me.simpleButton1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(504, 48)
			Me.panel1.TabIndex = 2
			' 
			' BasePanel
			' 
			Me.BasePanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.BasePanel.Location = New System.Drawing.Point(0, 48)
			Me.BasePanel.Name = "BasePanel"
			Me.BasePanel.Size = New System.Drawing.Size(504, 282)
			Me.BasePanel.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(504, 330)
			Me.Controls.Add(Me.BasePanel)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			CurrentModule = New UserControl1()
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton2.Click
			CurrentModule = Nothing
		End Sub

		Private currentModule_Renamed As UserControl
		Private Property CurrentModule() As UserControl
			Get
				Return currentModule_Renamed
			End Get
			Set(ByVal value As UserControl)
				If currentModule_Renamed IsNot value Then
					If currentModule_Renamed IsNot Nothing Then
						UnloadModule(currentModule_Renamed)
					End If
					If value IsNot Nothing Then
						LoadModule(value)
					End If
					currentModule_Renamed = value
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
		End Sub
	End Class
End Namespace
