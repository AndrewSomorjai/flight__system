Imports System.Data.OleDb
Public Class Form4
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
    Friend WithEvents pbSeat29b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat29a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat28b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat28a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat27b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat27a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat26b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat26a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat25b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat25a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat24b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat24a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat23b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat23a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat22b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat22a As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat21b As System.Windows.Forms.PictureBox
    Friend WithEvents pbSeat21a As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form4))
        Me.pbSeat29b = New System.Windows.Forms.PictureBox
        Me.pbSeat29a = New System.Windows.Forms.PictureBox
        Me.pbSeat28b = New System.Windows.Forms.PictureBox
        Me.pbSeat28a = New System.Windows.Forms.PictureBox
        Me.pbSeat27b = New System.Windows.Forms.PictureBox
        Me.pbSeat27a = New System.Windows.Forms.PictureBox
        Me.pbSeat26b = New System.Windows.Forms.PictureBox
        Me.pbSeat26a = New System.Windows.Forms.PictureBox
        Me.pbSeat25b = New System.Windows.Forms.PictureBox
        Me.pbSeat25a = New System.Windows.Forms.PictureBox
        Me.pbSeat24b = New System.Windows.Forms.PictureBox
        Me.pbSeat24a = New System.Windows.Forms.PictureBox
        Me.pbSeat23b = New System.Windows.Forms.PictureBox
        Me.pbSeat23a = New System.Windows.Forms.PictureBox
        Me.pbSeat22b = New System.Windows.Forms.PictureBox
        Me.pbSeat22a = New System.Windows.Forms.PictureBox
        Me.pbSeat21b = New System.Windows.Forms.PictureBox
        Me.pbSeat21a = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'pbSeat29b
        '
        Me.pbSeat29b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat29b.Location = New System.Drawing.Point(112, 510)
        Me.pbSeat29b.Name = "pbSeat29b"
        Me.pbSeat29b.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat29b.TabIndex = 38
        Me.pbSeat29b.TabStop = False
        '
        'pbSeat29a
        '
        Me.pbSeat29a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat29a.Location = New System.Drawing.Point(80, 510)
        Me.pbSeat29a.Name = "pbSeat29a"
        Me.pbSeat29a.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat29a.TabIndex = 37
        Me.pbSeat29a.TabStop = False
        '
        'pbSeat28b
        '
        Me.pbSeat28b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat28b.Location = New System.Drawing.Point(112, 486)
        Me.pbSeat28b.Name = "pbSeat28b"
        Me.pbSeat28b.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat28b.TabIndex = 36
        Me.pbSeat28b.TabStop = False
        '
        'pbSeat28a
        '
        Me.pbSeat28a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat28a.Location = New System.Drawing.Point(80, 486)
        Me.pbSeat28a.Name = "pbSeat28a"
        Me.pbSeat28a.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat28a.TabIndex = 35
        Me.pbSeat28a.TabStop = False
        '
        'pbSeat27b
        '
        Me.pbSeat27b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat27b.Location = New System.Drawing.Point(112, 462)
        Me.pbSeat27b.Name = "pbSeat27b"
        Me.pbSeat27b.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat27b.TabIndex = 34
        Me.pbSeat27b.TabStop = False
        '
        'pbSeat27a
        '
        Me.pbSeat27a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat27a.Location = New System.Drawing.Point(80, 462)
        Me.pbSeat27a.Name = "pbSeat27a"
        Me.pbSeat27a.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat27a.TabIndex = 33
        Me.pbSeat27a.TabStop = False
        '
        'pbSeat26b
        '
        Me.pbSeat26b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat26b.Location = New System.Drawing.Point(112, 430)
        Me.pbSeat26b.Name = "pbSeat26b"
        Me.pbSeat26b.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat26b.TabIndex = 32
        Me.pbSeat26b.TabStop = False
        '
        'pbSeat26a
        '
        Me.pbSeat26a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat26a.Location = New System.Drawing.Point(80, 430)
        Me.pbSeat26a.Name = "pbSeat26a"
        Me.pbSeat26a.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat26a.TabIndex = 31
        Me.pbSeat26a.TabStop = False
        '
        'pbSeat25b
        '
        Me.pbSeat25b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat25b.Location = New System.Drawing.Point(112, 406)
        Me.pbSeat25b.Name = "pbSeat25b"
        Me.pbSeat25b.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat25b.TabIndex = 30
        Me.pbSeat25b.TabStop = False
        '
        'pbSeat25a
        '
        Me.pbSeat25a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat25a.Location = New System.Drawing.Point(80, 406)
        Me.pbSeat25a.Name = "pbSeat25a"
        Me.pbSeat25a.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat25a.TabIndex = 29
        Me.pbSeat25a.TabStop = False
        '
        'pbSeat24b
        '
        Me.pbSeat24b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat24b.Location = New System.Drawing.Point(112, 382)
        Me.pbSeat24b.Name = "pbSeat24b"
        Me.pbSeat24b.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat24b.TabIndex = 28
        Me.pbSeat24b.TabStop = False
        '
        'pbSeat24a
        '
        Me.pbSeat24a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat24a.Location = New System.Drawing.Point(80, 382)
        Me.pbSeat24a.Name = "pbSeat24a"
        Me.pbSeat24a.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat24a.TabIndex = 27
        Me.pbSeat24a.TabStop = False
        '
        'pbSeat23b
        '
        Me.pbSeat23b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat23b.Location = New System.Drawing.Point(112, 358)
        Me.pbSeat23b.Name = "pbSeat23b"
        Me.pbSeat23b.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat23b.TabIndex = 26
        Me.pbSeat23b.TabStop = False
        '
        'pbSeat23a
        '
        Me.pbSeat23a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat23a.Location = New System.Drawing.Point(80, 358)
        Me.pbSeat23a.Name = "pbSeat23a"
        Me.pbSeat23a.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat23a.TabIndex = 25
        Me.pbSeat23a.TabStop = False
        '
        'pbSeat22b
        '
        Me.pbSeat22b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat22b.Location = New System.Drawing.Point(112, 334)
        Me.pbSeat22b.Name = "pbSeat22b"
        Me.pbSeat22b.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat22b.TabIndex = 24
        Me.pbSeat22b.TabStop = False
        '
        'pbSeat22a
        '
        Me.pbSeat22a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat22a.Location = New System.Drawing.Point(80, 334)
        Me.pbSeat22a.Name = "pbSeat22a"
        Me.pbSeat22a.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat22a.TabIndex = 23
        Me.pbSeat22a.TabStop = False
        '
        'pbSeat21b
        '
        Me.pbSeat21b.BackColor = System.Drawing.Color.Lime
        Me.pbSeat21b.Location = New System.Drawing.Point(112, 310)
        Me.pbSeat21b.Name = "pbSeat21b"
        Me.pbSeat21b.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat21b.TabIndex = 22
        Me.pbSeat21b.TabStop = False
        '
        'pbSeat21a
        '
        Me.pbSeat21a.BackColor = System.Drawing.Color.Lime
        Me.pbSeat21a.Location = New System.Drawing.Point(80, 310)
        Me.pbSeat21a.Name = "pbSeat21a"
        Me.pbSeat21a.Size = New System.Drawing.Size(16, 16)
        Me.pbSeat21a.TabIndex = 21
        Me.pbSeat21a.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 596)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(892, 598)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 56)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "EXIT"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(198, 22)
        Me.TextBox1.TabIndex = 40
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 28)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Flight Number"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(210, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 28)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Seat Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(206, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(198, 22)
        Me.TextBox2.TabIndex = 112
        Me.TextBox2.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(892, 538)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 56)
        Me.Button1.TabIndex = 114
        Me.Button1.Text = "PICK SEAT"
        '
        'Form4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.Yellow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(992, 664)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pbSeat29b)
        Me.Controls.Add(Me.pbSeat29a)
        Me.Controls.Add(Me.pbSeat28b)
        Me.Controls.Add(Me.pbSeat28a)
        Me.Controls.Add(Me.pbSeat27b)
        Me.Controls.Add(Me.pbSeat27a)
        Me.Controls.Add(Me.pbSeat26b)
        Me.Controls.Add(Me.pbSeat26a)
        Me.Controls.Add(Me.pbSeat25b)
        Me.Controls.Add(Me.pbSeat25a)
        Me.Controls.Add(Me.pbSeat24b)
        Me.Controls.Add(Me.pbSeat24a)
        Me.Controls.Add(Me.pbSeat23b)
        Me.Controls.Add(Me.pbSeat23a)
        Me.Controls.Add(Me.pbSeat22b)
        Me.Controls.Add(Me.pbSeat22a)
        Me.Controls.Add(Me.pbSeat21b)
        Me.Controls.Add(Me.pbSeat21a)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beech"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler pbSeat21a.Click, AddressOf whatever
        AddHandler pbSeat21b.Click, AddressOf whatever
        AddHandler pbSeat22a.Click, AddressOf whatever
        AddHandler pbSeat22b.Click, AddressOf whatever
        AddHandler pbSeat23a.Click, AddressOf whatever
        AddHandler pbSeat23b.Click, AddressOf whatever
        AddHandler pbSeat24a.Click, AddressOf whatever
        AddHandler pbSeat24b.Click, AddressOf whatever
        AddHandler pbSeat25a.Click, AddressOf whatever
        AddHandler pbSeat25b.Click, AddressOf whatever
        AddHandler pbSeat26a.Click, AddressOf whatever
        AddHandler pbSeat26b.Click, AddressOf whatever
        AddHandler pbSeat27a.Click, AddressOf whatever
        AddHandler pbSeat27b.Click, AddressOf whatever
        AddHandler pbSeat28a.Click, AddressOf whatever
        AddHandler pbSeat28b.Click, AddressOf whatever
        AddHandler pbSeat29a.Click, AddressOf whatever
        AddHandler pbSeat29b.Click, AddressOf whatever
    
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



        PictureBox1.Image = Image.FromFile("c:\beh.gif")

        'dim strselect case picturebox1.
        For Each objRow In objDataSet.Tables(0).Rows
            'control name is 'pbseat' followed by actual seat number
            strcontrolname = "pbSeat2" & objRow(0)
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

    Private Sub whatever(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objcontrol As Control
        Dim strcontrolname As String


        strcontrolname = sender.name
        objcontrol = getControl(strcontrolname)
        objcontrol.BackColor = System.Drawing.Color.Orange
        TextBox2.Text = sender.name
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

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
