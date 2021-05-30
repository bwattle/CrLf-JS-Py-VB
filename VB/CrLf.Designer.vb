<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrLf
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrLf))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMsg3 = New System.Windows.Forms.Button()
        Me.btnMsg1 = New System.Windows.Forms.Button()
        Me.btnMsg2 = New System.Windows.Forms.Button()
        Me.btnMsg4 = New System.Windows.Forms.Button()
        Me.btnMsg5 = New System.Windows.Forms.Button()
        Me.btnMsg6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'btnMsg3
        '
        resources.ApplyResources(Me.btnMsg3, "btnMsg3")
        Me.btnMsg3.Name = "btnMsg3"
        Me.btnMsg3.UseVisualStyleBackColor = True
        '
        'btnMsg1
        '
        resources.ApplyResources(Me.btnMsg1, "btnMsg1")
        Me.btnMsg1.Name = "btnMsg1"
        Me.btnMsg1.UseVisualStyleBackColor = True
        '
        'btnMsg2
        '
        resources.ApplyResources(Me.btnMsg2, "btnMsg2")
        Me.btnMsg2.Name = "btnMsg2"
        Me.btnMsg2.UseVisualStyleBackColor = True
        '
        'btnMsg4
        '
        resources.ApplyResources(Me.btnMsg4, "btnMsg4")
        Me.btnMsg4.Name = "btnMsg4"
        Me.btnMsg4.UseVisualStyleBackColor = True
        '
        'btnMsg5
        '
        resources.ApplyResources(Me.btnMsg5, "btnMsg5")
        Me.btnMsg5.Name = "btnMsg5"
        Me.btnMsg5.UseVisualStyleBackColor = True
        '
        'btnMsg6
        '
        resources.ApplyResources(Me.btnMsg6, "btnMsg6")
        Me.btnMsg6.Name = "btnMsg6"
        Me.btnMsg6.UseVisualStyleBackColor = True
        '
        'CrLf
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.btnMsg6)
        Me.Controls.Add(Me.btnMsg5)
        Me.Controls.Add(Me.btnMsg4)
        Me.Controls.Add(Me.btnMsg2)
        Me.Controls.Add(Me.btnMsg1)
        Me.Controls.Add(Me.btnMsg3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CrLf"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMsg3 As Button
    Friend WithEvents btnMsg1 As Button
    Friend WithEvents btnMsg2 As Button
    Friend WithEvents btnMsg4 As Button
    Friend WithEvents btnMsg5 As Button
    Friend WithEvents btnMsg6 As Button
End Class
