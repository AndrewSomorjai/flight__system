Imports System.Data.OleDb
Public Class Form3
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents pbSeat13b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat13a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat12d As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat12c As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat12b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat12a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat11d As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat11c As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat11b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat11a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat10d As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat10c As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat10b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat10a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat9d As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat9c As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat9b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat9a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat8d As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat8c As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat8b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat8a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat7d As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat7c As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat7b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat7a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat6d As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat6c As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat6b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat6a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat5d As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat5c As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat5b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat5a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat4d As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat4c As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat4b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat4a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat3d As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat3c As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat3b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat3a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat2d As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat2c As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat2b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat2a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat1c As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat1b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat1a As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pbSeat1d As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form3))
        Me.pbSeat13b = New System.Windows.Forms.PictureBox
        Me.pbSeat13a = New System.Windows.Forms.PictureBox
        Me.pbSeat12d = New System.Windows.Forms.PictureBox
        Me.pbSeat12c = New System.Windows.Forms.PictureBox
        Me.pbSeat12b = New System.Windows.Forms.PictureBox
        Me.pbSeat12a = New System.Windows.Forms.PictureBox
        Me.pbSeat11d = New System.Windows.Forms.PictureBox
        Me.pbSeat11c = New System.Windows.Forms.PictureBox
        Me.pbSeat11b = New System.Windows.Forms.PictureBox
        Me.pbSeat11a = New System.Windows.Forms.PictureBox
        Me.pbSeat10d = New System.Windows.Forms.PictureBox
        Me.pbSeat10c = New System.Windows.Forms.PictureBox
        Me.pbSeat10b = New System.Windows.Forms.PictureBox
        Me.pbSeat10a = New System.Windows.Forms.PictureBox
        Me.pbSeat9d = New System.Windows.Forms.PictureBox
        Me.pbSeat9c = New System.Windows.Forms.PictureBox
        Me.pbSeat9b = New System.Windows.Forms.PictureBox
        Me.pbSeat9a = New System.Windows.Forms.PictureBox
        Me.pbSeat8d = New System.Windows.Forms.PictureBox
        Me.pbSeat8c = New System.Windows.Forms.PictureBox
        Me.pbSeat8b = New System.Windows.Forms.PictureBox
        Me.pbSeat8a = New System.Windows.Forms.PictureBox
        Me.pbSeat7d = New System.Windows.Forms.PictureBox
        Me.pbSeat7c = New System.Windows.Forms.PictureBox
        Me.pbSeat7b = New System.Windows.Forms.PictureBox
        Me.pbSeat7a = New System.Windows.Forms.PictureBox
        Me.pbSeat6d = New System.Windows.Forms.PictureBox
        Me.pbSeat6c = New System.Windows.Forms.PictureBox
        Me.pbSeat6b = New System.Windows.Forms.PictureBox
        Me.pbSeat6a = New System.Windows.Forms.PictureBox
        Me.pbSeat5d = New System.Windows.Forms.PictureBox
        Me.pbSeat5c = New System.Windows.Forms.PictureBox
        Me.pbSeat5b = New System.Windows.Forms.PictureBox
        Me.pbSeat5a = New System.Windows.Forms.PictureBox
        Me.pbSeat4d = New System.Windows.Forms.PictureBox
        Me.pbSeat4c = New System.Windows.Forms.PictureBox
        Me.pbSeat4b = New System.Windows.Forms.PictureBox
        Me.pbSeat4a = New System.Windows.Forms.PictureBox
        Me.pbSeat3d = New System.Windows.Forms.PictureBox
        Me.pbSeat3c = New System.Windows.Forms.PictureBox
        Me.pbSeat3b = New System.Windows.Forms.PictureBox
        Me.pbSeat3a = New System.Windows.Forms.PictureBox
        Me.pbSeat2d = New System.Windows.Forms.PictureBox
        Me.pbSeat2c = New System.Windows.Forms.PictureBox
        Me.pbSeat2b = New System.Windows.Forms.PictureBox
        Me.pbSeat2a = New System.Windows.Forms.PictureBox
        Me.pbSeat1d = New System.Windows.Forms.PictureBox
        Me.pbSeat1c = New System.Windows.Forms.PictureBox
        Me.pbSeat1b = New System.Windows.Forms.PictureBox
        Me.pbSeat1a = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'pbSeat13b
        '
        Me.pbSeat13b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat13b.Location = New System.Drawing.Point(702, 562)
        Me.pbSeat13b.Name = "pbSeat13b"
        Me.pbSeat13b.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat13b.TabIndex = 107
        Me.pbSeat13b.TabStop = False
        '
        'pbSeat13a
        '
        Me.pbSeat13a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat13a.Location = New System.Drawing.Point(688, 562)
        Me.pbSeat13a.Name = "pbSeat13a"
        Me.pbSeat13a.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat13a.TabIndex = 106
        Me.pbSeat13a.TabStop = False
        '
        'pbSeat12d
        '
        Me.pbSeat12d.BackColor = System.Drawing.Color.Lime
        Me.pbSeat12d.Location = New System.Drawing.Point(746, 538)
        Me.pbSeat12d.Name = "pbSeat12d"
        Me.pbSeat12d.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat12d.TabIndex = 105
        Me.pbSeat12d.TabStop = False
        '
        'pbSeat12c
        '
        Me.pbSeat12c.BackColor = System.Drawing.Color.Lime
        Me.pbSeat12c.Location = New System.Drawing.Point(732, 538)
        Me.pbSeat12c.Name = "pbSeat12c"
        Me.pbSeat12c.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat12c.TabIndex = 104
        Me.pbSeat12c.TabStop = False
        '
        'pbSeat12b
        '
        Me.pbSeat12b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat12b.Location = New System.Drawing.Point(702, 538)
        Me.pbSeat12b.Name = "pbSeat12b"
        Me.pbSeat12b.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat12b.TabIndex = 103
        Me.pbSeat12b.TabStop = False
        '
        'pbSeat12a
        '
        Me.pbSeat12a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat12a.Location = New System.Drawing.Point(688, 538)
        Me.pbSeat12a.Name = "pbSeat12a"
        Me.pbSeat12a.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat12a.TabIndex = 102
        Me.pbSeat12a.TabStop = False
        '
        'pbSeat11d
        '
        Me.pbSeat11d.BackColor = System.Drawing.Color.Lime
        Me.pbSeat11d.Location = New System.Drawing.Point(746, 514)
        Me.pbSeat11d.Name = "pbSeat11d"
        Me.pbSeat11d.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat11d.TabIndex = 101
        Me.pbSeat11d.TabStop = False
        '
        'pbSeat11c
        '
        Me.pbSeat11c.BackColor = System.Drawing.Color.Lime
        Me.pbSeat11c.Location = New System.Drawing.Point(732, 514)
        Me.pbSeat11c.Name = "pbSeat11c"
        Me.pbSeat11c.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat11c.TabIndex = 100
        Me.pbSeat11c.TabStop = False
        '
        'pbSeat11b
        '
        Me.pbSeat11b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat11b.Location = New System.Drawing.Point(702, 514)
        Me.pbSeat11b.Name = "pbSeat11b"
        Me.pbSeat11b.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat11b.TabIndex = 99
        Me.pbSeat11b.TabStop = False
        '
        'pbSeat11a
        '
        Me.pbSeat11a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat11a.Location = New System.Drawing.Point(688, 514)
        Me.pbSeat11a.Name = "pbSeat11a"
        Me.pbSeat11a.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat11a.TabIndex = 98
        Me.pbSeat11a.TabStop = False
        '
        'pbSeat10d
        '
        Me.pbSeat10d.BackColor = System.Drawing.Color.Lime
        Me.pbSeat10d.Location = New System.Drawing.Point(746, 490)
        Me.pbSeat10d.Name = "pbSeat10d"
        Me.pbSeat10d.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat10d.TabIndex = 97
        Me.pbSeat10d.TabStop = False
        '
        'pbSeat10c
        '
        Me.pbSeat10c.BackColor = System.Drawing.Color.Lime
        Me.pbSeat10c.Location = New System.Drawing.Point(732, 490)
        Me.pbSeat10c.Name = "pbSeat10c"
        Me.pbSeat10c.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat10c.TabIndex = 96
        Me.pbSeat10c.TabStop = False
        '
        'pbSeat10b
        '
        Me.pbSeat10b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat10b.Location = New System.Drawing.Point(702, 490)
        Me.pbSeat10b.Name = "pbSeat10b"
        Me.pbSeat10b.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat10b.TabIndex = 95
        Me.pbSeat10b.TabStop = False
        '
        'pbSeat10a
        '
        Me.pbSeat10a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat10a.Location = New System.Drawing.Point(688, 490)
        Me.pbSeat10a.Name = "pbSeat10a"
        Me.pbSeat10a.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat10a.TabIndex = 94
        Me.pbSeat10a.TabStop = False
        '
        'pbSeat9d
        '
        Me.pbSeat9d.BackColor = System.Drawing.Color.Lime
        Me.pbSeat9d.Location = New System.Drawing.Point(746, 464)
        Me.pbSeat9d.Name = "pbSeat9d"
        Me.pbSeat9d.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat9d.TabIndex = 93
        Me.pbSeat9d.TabStop = False
        '
        'pbSeat9c
        '
        Me.pbSeat9c.BackColor = System.Drawing.Color.Lime
        Me.pbSeat9c.Location = New System.Drawing.Point(732, 464)
        Me.pbSeat9c.Name = "pbSeat9c"
        Me.pbSeat9c.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat9c.TabIndex = 92
        Me.pbSeat9c.TabStop = False
        '
        'pbSeat9b
        '
        Me.pbSeat9b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat9b.Location = New System.Drawing.Point(702, 464)
        Me.pbSeat9b.Name = "pbSeat9b"
        Me.pbSeat9b.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat9b.TabIndex = 91
        Me.pbSeat9b.TabStop = False
        '
        'pbSeat9a
        '
        Me.pbSeat9a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat9a.Location = New System.Drawing.Point(688, 464)
        Me.pbSeat9a.Name = "pbSeat9a"
        Me.pbSeat9a.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat9a.TabIndex = 90
        Me.pbSeat9a.TabStop = False
        '
        'pbSeat8d
        '
        Me.pbSeat8d.BackColor = System.Drawing.Color.Lime
        Me.pbSeat8d.Location = New System.Drawing.Point(746, 440)
        Me.pbSeat8d.Name = "pbSeat8d"
        Me.pbSeat8d.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat8d.TabIndex = 89
        Me.pbSeat8d.TabStop = False
        '
        'pbSeat8c
        '
        Me.pbSeat8c.BackColor = System.Drawing.Color.Lime
        Me.pbSeat8c.Location = New System.Drawing.Point(732, 440)
        Me.pbSeat8c.Name = "pbSeat8c"
        Me.pbSeat8c.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat8c.TabIndex = 88
        Me.pbSeat8c.TabStop = False
        '
        'pbSeat8b
        '
        Me.pbSeat8b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat8b.Location = New System.Drawing.Point(702, 440)
        Me.pbSeat8b.Name = "pbSeat8b"
        Me.pbSeat8b.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat8b.TabIndex = 87
        Me.pbSeat8b.TabStop = False
        '
        'pbSeat8a
        '
        Me.pbSeat8a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat8a.Location = New System.Drawing.Point(688, 440)
        Me.pbSeat8a.Name = "pbSeat8a"
        Me.pbSeat8a.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat8a.TabIndex = 86
        Me.pbSeat8a.TabStop = False
        '
        'pbSeat7d
        '
        Me.pbSeat7d.BackColor = System.Drawing.Color.Lime
        Me.pbSeat7d.Location = New System.Drawing.Point(746, 410)
        Me.pbSeat7d.Name = "pbSeat7d"
        Me.pbSeat7d.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat7d.TabIndex = 85
        Me.pbSeat7d.TabStop = False
        '
        'pbSeat7c
        '
        Me.pbSeat7c.BackColor = System.Drawing.Color.Lime
        Me.pbSeat7c.Location = New System.Drawing.Point(732, 410)
        Me.pbSeat7c.Name = "pbSeat7c"
        Me.pbSeat7c.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat7c.TabIndex = 84
        Me.pbSeat7c.TabStop = False
        '
        'pbSeat7b
        '
        Me.pbSeat7b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat7b.Location = New System.Drawing.Point(702, 410)
        Me.pbSeat7b.Name = "pbSeat7b"
        Me.pbSeat7b.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat7b.TabIndex = 83
        Me.pbSeat7b.TabStop = False
        '
        'pbSeat7a
        '
        Me.pbSeat7a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat7a.Location = New System.Drawing.Point(688, 410)
        Me.pbSeat7a.Name = "pbSeat7a"
        Me.pbSeat7a.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat7a.TabIndex = 82
        Me.pbSeat7a.TabStop = False
        '
        'pbSeat6d
        '
        Me.pbSeat6d.BackColor = System.Drawing.Color.Lime
        Me.pbSeat6d.Location = New System.Drawing.Point(746, 386)
        Me.pbSeat6d.Name = "pbSeat6d"
        Me.pbSeat6d.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat6d.TabIndex = 81
        Me.pbSeat6d.TabStop = False
        '
        'pbSeat6c
        '
        Me.pbSeat6c.BackColor = System.Drawing.Color.Lime
        Me.pbSeat6c.Location = New System.Drawing.Point(732, 386)
        Me.pbSeat6c.Name = "pbSeat6c"
        Me.pbSeat6c.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat6c.TabIndex = 80
        Me.pbSeat6c.TabStop = False
        '
        'pbSeat6b
        '
        Me.pbSeat6b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat6b.Location = New System.Drawing.Point(702, 386)
        Me.pbSeat6b.Name = "pbSeat6b"
        Me.pbSeat6b.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat6b.TabIndex = 79
        Me.pbSeat6b.TabStop = False
        '
        'pbSeat6a
        '
        Me.pbSeat6a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat6a.Location = New System.Drawing.Point(688, 386)
        Me.pbSeat6a.Name = "pbSeat6a"
        Me.pbSeat6a.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat6a.TabIndex = 78
        Me.pbSeat6a.TabStop = False
        '
        'pbSeat5d
        '
        Me.pbSeat5d.BackColor = System.Drawing.Color.Lime
        Me.pbSeat5d.Location = New System.Drawing.Point(746, 360)
        Me.pbSeat5d.Name = "pbSeat5d"
        Me.pbSeat5d.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat5d.TabIndex = 77
        Me.pbSeat5d.TabStop = False
        '
        'pbSeat5c
        '
        Me.pbSeat5c.BackColor = System.Drawing.Color.Lime
        Me.pbSeat5c.Location = New System.Drawing.Point(732, 360)
        Me.pbSeat5c.Name = "pbSeat5c"
        Me.pbSeat5c.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat5c.TabIndex = 76
        Me.pbSeat5c.TabStop = False
        '
        'pbSeat5b
        '
        Me.pbSeat5b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat5b.Location = New System.Drawing.Point(702, 360)
        Me.pbSeat5b.Name = "pbSeat5b"
        Me.pbSeat5b.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat5b.TabIndex = 75
        Me.pbSeat5b.TabStop = False
        '
        'pbSeat5a
        '
        Me.pbSeat5a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat5a.Location = New System.Drawing.Point(688, 360)
        Me.pbSeat5a.Name = "pbSeat5a"
        Me.pbSeat5a.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat5a.TabIndex = 74
        Me.pbSeat5a.TabStop = False
        '
        'pbSeat4d
        '
        Me.pbSeat4d.BackColor = System.Drawing.Color.Lime
        Me.pbSeat4d.Location = New System.Drawing.Point(746, 336)
        Me.pbSeat4d.Name = "pbSeat4d"
        Me.pbSeat4d.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat4d.TabIndex = 73
        Me.pbSeat4d.TabStop = False
        '
        'pbSeat4c
        '
        Me.pbSeat4c.BackColor = System.Drawing.Color.Lime
        Me.pbSeat4c.Location = New System.Drawing.Point(732, 336)
        Me.pbSeat4c.Name = "pbSeat4c"
        Me.pbSeat4c.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat4c.TabIndex = 72
        Me.pbSeat4c.TabStop = False
        '
        'pbSeat4b
        '
        Me.pbSeat4b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat4b.Location = New System.Drawing.Point(702, 336)
        Me.pbSeat4b.Name = "pbSeat4b"
        Me.pbSeat4b.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat4b.TabIndex = 71
        Me.pbSeat4b.TabStop = False
        '
        'pbSeat4a
        '
        Me.pbSeat4a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat4a.Location = New System.Drawing.Point(688, 336)
        Me.pbSeat4a.Name = "pbSeat4a"
        Me.pbSeat4a.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat4a.TabIndex = 70
        Me.pbSeat4a.TabStop = False
        '
        'pbSeat3d
        '
        Me.pbSeat3d.BackColor = System.Drawing.Color.Lime
        Me.pbSeat3d.Location = New System.Drawing.Point(746, 312)
        Me.pbSeat3d.Name = "pbSeat3d"
        Me.pbSeat3d.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat3d.TabIndex = 69
        Me.pbSeat3d.TabStop = False
        '
        'pbSeat3c
        '
        Me.pbSeat3c.BackColor = System.Drawing.Color.Lime
        Me.pbSeat3c.Location = New System.Drawing.Point(732, 312)
        Me.pbSeat3c.Name = "pbSeat3c"
        Me.pbSeat3c.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat3c.TabIndex = 68
        Me.pbSeat3c.TabStop = False
        '
        'pbSeat3b
        '
        Me.pbSeat3b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat3b.Location = New System.Drawing.Point(702, 312)
        Me.pbSeat3b.Name = "pbSeat3b"
        Me.pbSeat3b.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat3b.TabIndex = 67
        Me.pbSeat3b.TabStop = False
        '
        'pbSeat3a
        '
        Me.pbSeat3a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat3a.Location = New System.Drawing.Point(688, 312)
        Me.pbSeat3a.Name = "pbSeat3a"
        Me.pbSeat3a.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat3a.TabIndex = 66
        Me.pbSeat3a.TabStop = False
        '
        'pbSeat2d
        '
        Me.pbSeat2d.BackColor = System.Drawing.Color.Lime
        Me.pbSeat2d.Location = New System.Drawing.Point(746, 288)
        Me.pbSeat2d.Name = "pbSeat2d"
        Me.pbSeat2d.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat2d.TabIndex = 65
        Me.pbSeat2d.TabStop = False
        '
        'pbSeat2c
        '
        Me.pbSeat2c.BackColor = System.Drawing.Color.Lime
        Me.pbSeat2c.Location = New System.Drawing.Point(732, 288)
        Me.pbSeat2c.Name = "pbSeat2c"
        Me.pbSeat2c.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat2c.TabIndex = 64
        Me.pbSeat2c.TabStop = False
        '
        'pbSeat2b
        '
        Me.pbSeat2b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat2b.Location = New System.Drawing.Point(702, 288)
        Me.pbSeat2b.Name = "pbSeat2b"
        Me.pbSeat2b.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat2b.TabIndex = 63
        Me.pbSeat2b.TabStop = False
        '
        'pbSeat2a
        '
        Me.pbSeat2a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat2a.Location = New System.Drawing.Point(688, 288)
        Me.pbSeat2a.Name = "pbSeat2a"
        Me.pbSeat2a.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat2a.TabIndex = 62
        Me.pbSeat2a.TabStop = False
        '
        'pbSeat1d
        '
        Me.pbSeat1d.BackColor = System.Drawing.Color.Lime
        Me.pbSeat1d.Location = New System.Drawing.Point(746, 262)
        Me.pbSeat1d.Name = "pbSeat1d"
        Me.pbSeat1d.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat1d.TabIndex = 61
        Me.pbSeat1d.TabStop = False
        '
        'pbSeat1c
        '
        Me.pbSeat1c.BackColor = System.Drawing.Color.Lime
        Me.pbSeat1c.Location = New System.Drawing.Point(732, 262)
        Me.pbSeat1c.Name = "pbSeat1c"
        Me.pbSeat1c.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat1c.TabIndex = 60
        Me.pbSeat1c.TabStop = False
        '
        'pbSeat1b
        '
        Me.pbSeat1b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat1b.Location = New System.Drawing.Point(702, 264)
        Me.pbSeat1b.Name = "pbSeat1b"
        Me.pbSeat1b.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat1b.TabIndex = 59
        Me.pbSeat1b.TabStop = False
        '
        'pbSeat1a
        '
        Me.pbSeat1a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat1a.Location = New System.Drawing.Point(686, 264)
        Me.pbSeat1a.Name = "pbSeat1a"
        Me.pbSeat1a.Size = New System.Drawing.Size(11, 14)
        Me.pbSeat1a.TabIndex = 58
        Me.pbSeat1a.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(638, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 582)
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(888, 598)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 56)
        Me.Button2.TabIndex = 108
        Me.Button2.Text = "EXIT"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(774, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(136, 22)
        Me.TextBox1.TabIndex = 109
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(638, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 28)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Flight Number"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(638, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 28)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Seat Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(774, 44)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(136, 22)
        Me.TextBox2.TabIndex = 112
        Me.TextBox2.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(888, 540)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 56)
        Me.Button1.TabIndex = 113
        Me.Button1.Text = "PICK SEAT"
        '
        'Form3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.Yellow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(992, 664)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pbSeat13b)
        Me.Controls.Add(Me.pbSeat13a)
        Me.Controls.Add(Me.pbSeat12d)
        Me.Controls.Add(Me.pbSeat12c)
        Me.Controls.Add(Me.pbSeat12b)
        Me.Controls.Add(Me.pbSeat12a)
        Me.Controls.Add(Me.pbSeat11d)
        Me.Controls.Add(Me.pbSeat11c)
        Me.Controls.Add(Me.pbSeat11b)
        Me.Controls.Add(Me.pbSeat11a)
        Me.Controls.Add(Me.pbSeat10d)
        Me.Controls.Add(Me.pbSeat10c)
        Me.Controls.Add(Me.pbSeat10b)
        Me.Controls.Add(Me.pbSeat10a)
        Me.Controls.Add(Me.pbSeat9d)
        Me.Controls.Add(Me.pbSeat9c)
        Me.Controls.Add(Me.pbSeat9b)
        Me.Controls.Add(Me.pbSeat9a)
        Me.Controls.Add(Me.pbSeat8d)
        Me.Controls.Add(Me.pbSeat8c)
        Me.Controls.Add(Me.pbSeat8b)
        Me.Controls.Add(Me.pbSeat8a)
        Me.Controls.Add(Me.pbSeat7d)
        Me.Controls.Add(Me.pbSeat7c)
        Me.Controls.Add(Me.pbSeat7b)
        Me.Controls.Add(Me.pbSeat7a)
        Me.Controls.Add(Me.pbSeat6d)
        Me.Controls.Add(Me.pbSeat6c)
        Me.Controls.Add(Me.pbSeat6b)
        Me.Controls.Add(Me.pbSeat6a)
        Me.Controls.Add(Me.pbSeat5d)
        Me.Controls.Add(Me.pbSeat5c)
        Me.Controls.Add(Me.pbSeat5b)
        Me.Controls.Add(Me.pbSeat5a)
        Me.Controls.Add(Me.pbSeat4d)
        Me.Controls.Add(Me.pbSeat4c)
        Me.Controls.Add(Me.pbSeat4b)
        Me.Controls.Add(Me.pbSeat4a)
        Me.Controls.Add(Me.pbSeat3d)
        Me.Controls.Add(Me.pbSeat3c)
        Me.Controls.Add(Me.pbSeat3b)
        Me.Controls.Add(Me.pbSeat3a)
        Me.Controls.Add(Me.pbSeat2d)
        Me.Controls.Add(Me.pbSeat2c)
        Me.Controls.Add(Me.pbSeat2b)
        Me.Controls.Add(Me.pbSeat2a)
        Me.Controls.Add(Me.pbSeat1d)
        Me.Controls.Add(Me.pbSeat1c)
        Me.Controls.Add(Me.pbSeat1b)
        Me.Controls.Add(Me.pbSeat1a)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "727"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddHandler pbSeat1a.Click, AddressOf whatever
        AddHandler pbSeat1b.Click, AddressOf whatever
        AddHandler pbSeat1c.Click, AddressOf whatever
        AddHandler pbSeat1d.Click, AddressOf whatever
        AddHandler pbSeat2a.Click, AddressOf whatever
        AddHandler pbSeat2b.Click, AddressOf whatever
        AddHandler pbSeat2c.Click, AddressOf whatever
        AddHandler pbSeat2d.Click, AddressOf whatever
        AddHandler pbSeat3a.Click, AddressOf whatever
        AddHandler pbSeat3b.Click, AddressOf whatever
        AddHandler pbSeat3c.Click, AddressOf whatever
        AddHandler pbSeat3d.Click, AddressOf whatever
        AddHandler pbSeat4a.Click, AddressOf whatever
        AddHandler pbSeat4b.Click, AddressOf whatever
        AddHandler pbSeat4c.Click, AddressOf whatever
        AddHandler pbSeat4d.Click, AddressOf whatever
        AddHandler pbSeat5a.Click, AddressOf whatever
        AddHandler pbSeat5b.Click, AddressOf whatever
        AddHandler pbSeat5c.Click, AddressOf whatever
        AddHandler pbSeat5d.Click, AddressOf whatever
        AddHandler pbSeat6a.Click, AddressOf whatever
        AddHandler pbSeat6b.Click, AddressOf whatever
        AddHandler pbSeat6c.Click, AddressOf whatever
        AddHandler pbSeat6d.Click, AddressOf whatever
        AddHandler pbSeat7a.Click, AddressOf whatever
        AddHandler pbSeat7b.Click, AddressOf whatever
        AddHandler pbSeat7c.Click, AddressOf whatever
        AddHandler pbSeat7d.Click, AddressOf whatever
        AddHandler pbSeat8a.Click, AddressOf whatever
        AddHandler pbSeat8b.Click, AddressOf whatever
        AddHandler pbSeat8c.Click, AddressOf whatever
        AddHandler pbSeat8d.Click, AddressOf whatever
        AddHandler pbSeat9a.Click, AddressOf whatever
        AddHandler pbSeat9b.Click, AddressOf whatever
        AddHandler pbSeat9c.Click, AddressOf whatever
        AddHandler pbSeat9d.Click, AddressOf whatever
        AddHandler pbSeat10a.Click, AddressOf whatever
        AddHandler pbSeat10b.Click, AddressOf whatever
        AddHandler pbSeat10c.Click, AddressOf whatever
        AddHandler pbSeat10d.Click, AddressOf whatever
        AddHandler pbSeat11a.Click, AddressOf whatever
        AddHandler pbSeat11b.Click, AddressOf whatever
        AddHandler pbSeat11c.Click, AddressOf whatever
        AddHandler pbSeat11d.Click, AddressOf whatever
        AddHandler pbSeat12a.Click, AddressOf whatever
        AddHandler pbSeat12b.Click, AddressOf whatever
        AddHandler pbSeat12c.Click, AddressOf whatever
        AddHandler pbSeat12d.Click, AddressOf whatever
        AddHandler pbSeat13a.Click, AddressOf whatever
        AddHandler pbSeat13b.Click, AddressOf whatever



    Dim strPlaneType As String = "727"
    Dim objConnection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\cis430.mdb;")
    Dim objcommand As New OleDbCommand("select seatnbr from reservations", objConnection)
    Dim objAdapter As New OleDbDataAdapter
    Dim objDataSet As New DataSet
    'get the seat numbers out of the query results
    Dim objRow As DataRow
    Dim strcontrolname As String

    Dim objcontrol As Control





        objcommand.Connection.Open()
        objAdapter.SelectCommand = objcommand
        objAdapter.Fill(objDataSet)



        PictureBox1.Image = Image.FromFile("c:\canad.JPG")

    'dim strselect case picturebox1.
        For Each objRow In objDataSet.Tables(0).Rows
    'control name is 'pbseat' followed by actual seat number
            strcontrolname = "pbSeat" & objRow(0)
            objcontrol = getControl(strcontrolname)
            objcontrol.BackColor = System.Drawing.Color.Gray

        Next



    End Sub

    Private Function getControl(ByVal strcontrolname As String) As Control
        Dim objcontrol As Control

        For Each objcontrol In Me.Controls
            If objcontrol.Name = strcontrolname Then
                Return objcontrol
            End If
        Next
        Return Nothing

    End Function

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
    Private Sub whatever(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objcontrol As Control
        Dim strcontrolname As String


        strcontrolname = sender.name
        objcontrol = getControl(strcontrolname)
        objcontrol.BackColor = System.Drawing.Color.Orange

        TextBox2.Text = sender.name
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub


    Public Property CustomerName() As String
        Get
            Return TextBox1.Text
        End Get
        Set(ByVal Value As String)
            TextBox1.Text = Value
        End Set
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        Dim myForm6 As New Form6
        myForm6.SeatNum = TextBox2.Text
        myForm6.FlightNum = TextBox1.Text
        myForm6.Visible = True
        Me.Visible = False
     
    End Sub
End Class