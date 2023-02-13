<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.pbClient = New System.Windows.Forms.PictureBox()
        Me.pbInvoice = New System.Windows.Forms.PictureBox()
        Me.pbNewUser = New System.Windows.Forms.PictureBox()
        Me.pbOrder = New System.Windows.Forms.PictureBox()
        Me.pbSalesReport = New System.Windows.Forms.PictureBox()
        Me.pbUserProfile = New System.Windows.Forms.PictureBox()
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSalesReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUserProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbClient
        '
        Me.pbClient.Image = CType(resources.GetObject("pbClient.Image"), System.Drawing.Image)
        Me.pbClient.Location = New System.Drawing.Point(104, 109)
        Me.pbClient.Name = "pbClient"
        Me.pbClient.Size = New System.Drawing.Size(166, 90)
        Me.pbClient.TabIndex = 0
        Me.pbClient.TabStop = False
        '
        'pbInvoice
        '
        Me.pbInvoice.Image = CType(resources.GetObject("pbInvoice.Image"), System.Drawing.Image)
        Me.pbInvoice.Location = New System.Drawing.Point(298, 109)
        Me.pbInvoice.Name = "pbInvoice"
        Me.pbInvoice.Size = New System.Drawing.Size(166, 90)
        Me.pbInvoice.TabIndex = 1
        Me.pbInvoice.TabStop = False
        '
        'pbNewUser
        '
        Me.pbNewUser.Image = CType(resources.GetObject("pbNewUser.Image"), System.Drawing.Image)
        Me.pbNewUser.Location = New System.Drawing.Point(298, 224)
        Me.pbNewUser.Name = "pbNewUser"
        Me.pbNewUser.Size = New System.Drawing.Size(166, 90)
        Me.pbNewUser.TabIndex = 2
        Me.pbNewUser.TabStop = False
        '
        'pbOrder
        '
        Me.pbOrder.Image = CType(resources.GetObject("pbOrder.Image"), System.Drawing.Image)
        Me.pbOrder.Location = New System.Drawing.Point(499, 109)
        Me.pbOrder.Name = "pbOrder"
        Me.pbOrder.Size = New System.Drawing.Size(166, 90)
        Me.pbOrder.TabIndex = 3
        Me.pbOrder.TabStop = False
        '
        'pbSalesReport
        '
        Me.pbSalesReport.Image = CType(resources.GetObject("pbSalesReport.Image"), System.Drawing.Image)
        Me.pbSalesReport.Location = New System.Drawing.Point(500, 224)
        Me.pbSalesReport.Name = "pbSalesReport"
        Me.pbSalesReport.Size = New System.Drawing.Size(166, 90)
        Me.pbSalesReport.TabIndex = 4
        Me.pbSalesReport.TabStop = False
        '
        'pbUserProfile
        '
        Me.pbUserProfile.Image = CType(resources.GetObject("pbUserProfile.Image"), System.Drawing.Image)
        Me.pbUserProfile.Location = New System.Drawing.Point(107, 224)
        Me.pbUserProfile.Name = "pbUserProfile"
        Me.pbUserProfile.Size = New System.Drawing.Size(166, 90)
        Me.pbUserProfile.TabIndex = 5
        Me.pbUserProfile.TabStop = False
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbUserProfile)
        Me.Controls.Add(Me.pbSalesReport)
        Me.Controls.Add(Me.pbOrder)
        Me.Controls.Add(Me.pbNewUser)
        Me.Controls.Add(Me.pbInvoice)
        Me.Controls.Add(Me.pbClient)
        Me.Name = "frmConfig"
        Me.Text = "frmConfig"
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNewUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSalesReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUserProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbClient As PictureBox
    Friend WithEvents pbInvoice As PictureBox
    Friend WithEvents pbNewUser As PictureBox
    Friend WithEvents pbOrder As PictureBox
    Friend WithEvents pbSalesReport As PictureBox
    Friend WithEvents pbUserProfile As PictureBox
End Class
