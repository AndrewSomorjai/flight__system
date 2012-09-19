Imports System.data.oledb

Public Class Form5
    Inherits System.Windows.Forms.Form
    Dim myForm3 As New Form3
    Dim myForm4 As New Form4
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form5))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(320, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(576, 128)
        Me.DataGrid1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(168, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(136, 22)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(168, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(136, 22)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(168, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(136, 22)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = ""
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(704, 600)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 56)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "FIND FLIGHT"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Departure Airport,City"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(24, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Arrival Airport,City"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(24, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date of Flight"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(896, 600)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 56)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "EXIT"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(168, 112)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(136, 22)
        Me.TextBox4.TabIndex = 28
        Me.TextBox4.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Pick Flight After Query"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(800, 600)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 56)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "PICK FLIGHT"
        '
        'Form5
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(992, 664)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FIND A FLIGHT"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'information needed to connection to the database
        Dim objConnection As OleDbConnection
        Try
            Dim strConnString As String = "Provider=Microsoft.jet.oledb.4.0;" & _
                                            "Data Source=C:\cis430database.mdb;"

            Dim objDataSet As New DataSet


            'create the connection with the information it needs to connect to db
            objConnection = New OleDbConnection(strConnString)
            Dim objcmd As New OleDbCommand("findflight", objConnection)


            objcmd.CommandType = CommandType.StoredProcedure

            'create parameter or class to handle or provide airline parameter

            Dim objParam As OleDbParameter



            objParam = New OleDbParameter("@Depart", TextBox1.Text)
            objParam.Direction = ParameterDirection.Input
            objcmd.Parameters.Add(objParam)

            objParam = New OleDbParameter("@Arrival", TextBox2.Text)
            objParam.Direction = ParameterDirection.Input
            objcmd.Parameters.Add(objParam)

            objParam = New OleDbParameter("@OnDate", TextBox3.Text)
            objParam.Direction = ParameterDirection.Input
            objcmd.Parameters.Add(objParam)

            Dim objadapter As New OleDbDataAdapter(objcmd)

            'have the adapter fill the dataset with the results of its query
            objadapter.Fill(objDataSet)
            DataGrid1.DataSource = objDataSet.Tables(0)

        Catch objexception As ArgumentException
            MsgBox(objexception.Message)
        Catch objoledbexception As OleDbException
            MsgBox(objoledbexception.Message)
        Finally
            objConnection.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim objConnection As OleDbConnection
        Dim objReader As OleDbDataReader
        Dim arrplane() As String
        Dim strConnString As String = "Provider=Microsoft.jet.oledb.4.0;" & _
                                        "Data Source=C:\cis430database.mdb;"

        Dim objDataSet As New DataSet
       
        Dim objstring As String

        'create the connection with the information it needs to connect to db
        objConnection = New OleDbConnection(strConnString)
        Dim objcmd As New OleDbCommand("findplane", objConnection)
        objcmd.CommandType = CommandType.StoredProcedure

        'create parameter or class to handle or provide airline parameter

        Dim objParam As OleDbParameter

        objParam = New OleDbParameter("@Depart", TextBox1.Text)
        objParam.Direction = ParameterDirection.Input
        objcmd.Parameters.Add(objParam)

        objParam = New OleDbParameter("@Arrival", TextBox2.Text)
        objParam.Direction = ParameterDirection.Input
        objcmd.Parameters.Add(objParam)

        objParam = New OleDbParameter("@OnDate", TextBox3.Text)
        objParam.Direction = ParameterDirection.Input
        objcmd.Parameters.Add(objParam)

        objParam = New OleDbParameter("@flightnumber", TextBox4.Text)
        objParam.Direction = ParameterDirection.Input
        objcmd.Parameters.Add(objParam)

        objcmd.Connection.Open()
        objReader = objcmd.ExecuteReader()

        While objReader.Read()
            'read next row of the query results
            If arrplane Is Nothing Then
                ReDim arrplane(0)
            Else
                ReDim Preserve arrplane(arrplane.Length)
            End If
            arrplane(arrplane.Length - 1) = objReader("plane")

           
        End While

        ',TextBox4)


        Dim objadapter As New OleDbDataAdapter(objcmd)

        'have the adapter fill the dataset with the results of its query
        'objadapter.Fill(objDataSet)
        'DataGrid1.DataSource = objDataSet.Tables(0)

        'objflight.getplane = arrplane(0)
        Dim plane As String
        plane = arrplane(0)

        If plane = "beech" Then

            myForm4.CustomerName = TextBox4.Text
            myForm4.Show()

        ElseIf plane = "727" Then
            myForm3.CustomerName = TextBox4.Text
            myForm3.Show()
        Else
            MsgBox("Data Mismatch, Reenter Flight Information for User")
        End If

    End Sub
End Class
