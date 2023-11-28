Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

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
            CType(splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            splitContainerControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' splitContainerControl1
            ' 
            splitContainerControl1.DataBindings.Add(New Binding("SplitterPosition", Global.SaveRestoreSplitterPosition.Settings.Default, "SavedSplitterPosition", True, DataSourceUpdateMode.OnPropertyChanged))
            splitContainerControl1.Dock = DockStyle.Fill
            splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            splitContainerControl1.Name = "splitContainerControl1"
            ' 
            ' splitContainerControl1.Panel1
            ' 
            splitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.Lime
            splitContainerControl1.Panel1.Appearance.Options.UseBackColor = True
            splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1"
            ' 
            ' splitContainerControl1.Panel2
            ' 
            splitContainerControl1.Panel2.Appearance.BackColor = System.Drawing.Color.Red
            splitContainerControl1.Panel2.Appearance.Options.UseBackColor = True
            splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2"
            splitContainerControl1.Size = New System.Drawing.Size(256, 160)
            splitContainerControl1.SplitterPosition = Global.SaveRestoreSplitterPosition.Settings.Default.SavedSplitterPosition
            splitContainerControl1.TabIndex = 0
            splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' UserControl1
            ' 
            Me.Controls.Add(splitContainerControl1)
            Name = "UserControl1"
            Size = New System.Drawing.Size(256, 160)
            CType(splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            splitContainerControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub
#End Region
    End Class
End Namespace
