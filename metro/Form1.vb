Imports System.IO
Imports System.Net
Imports System.Xml

Public Class Form1

    Dim temperature As Integer
    Dim type As String
    Dim city As String
    Dim ms1 As String
    Dim ms2 As String
    Dim ms3 As String
    Dim gs1 As String
    Dim gs2 As String
    Dim gs3 As String
    Dim es1 As String
    Dim es2 As String
    Dim es3 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Initapp()
    End Sub

    Public Sub Initapp()
        calendar()
        stocks()
        weather()
        desktopandphotos()


        Eightlabelreverse1.Text = My.Settings.OL_NAME
        Class21.Text = My.Settings.TL_BIG
        Class22.Text = My.Settings.TL_SMALL
        If My.Settings.TLName = True Then
            Eightlabelreverse1.Visible = False
        Else
            Eightlabelreverse1.Visible = True
        End If
        Me.BackColor = My.Settings.SM_COLOR
        Try
            PictureBox8.Image = Image.FromFile(My.Settings.SM_PROFILEP)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub desktopandphotos()
        Panel13.BackgroundImage = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Microsoft\Windows\Themes\TranscodedWallpaper")
    End Sub

    Private Sub calendar()
        Label7.Text = DateAndTime.Day(DateAndTime.Now)
        If Label7.Text = "1" Then
            Label7.Text = "01"
        End If
        If Label7.Text = "2" Then
            Label7.Text = "02"
        End If
        If Label7.Text = "3" Then
            Label7.Text = "03"
        End If
        If Label7.Text = "4" Then
            Label7.Text = "04"
        End If
        If Label7.Text = "5" Then
            Label7.Text = "05"
        End If
        If Label7.Text = "6" Then
            Label7.Text = "06"
        End If
        If Label7.Text = "7" Then
            Label7.Text = "07"
        End If
        If Label7.Text = "8" Then
            Label7.Text = "08"
        End If
        If Label7.Text = "9" Then
            Label7.Text = "09"
        End If
        Label8.Text = DateAndTime.MonthName(DateAndTime.Month(DateAndTime.Now))
    End Sub

    Private Sub weather()
        Dim address As String = "http://api.openweathermap.org/data/2.5/weather?q=Bratislava&mode=xml&APPID=f087a4bd2e59b76b49fe81f9de972f7e"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        Dim doc As New XmlDocument
        doc.Load(reader)
        For Each atribut As XmlElement In doc.DocumentElement.GetElementsByTagName("temperature")
            ' Google translator translates attribute to slovak as atribút, interesting...
            temperature = Math.Round(citajxml(atribut, "value") - 273.15, 1)
        Next atribut
        For Each atribut As XmlElement In doc.DocumentElement.GetElementsByTagName("weather")
            type = citajxml(atribut, "value")
        Next atribut
        For Each atribut As XmlElement In doc.DocumentElement.GetElementsByTagName("city")
            city = citajxml(atribut, "name")
        Next atribut
        Label11.Text = temperature.ToString + "°C"
        Label13.Text = city + vbNewLine + StrConv(type, VbStrConv.ProperCase)
    End Sub

    Private Sub stocks()
        If My.Computer.FileSystem.FileExists("msfts1.txt") Then
            My.Computer.FileSystem.DeleteFile("msfts1.txt")
        End If
        My.Computer.Network.DownloadFile("http://download.finance.yahoo.com/d/quotes.csv?s=MSFT&f=c1", "msfts1.txt")
        Using sr As New StreamReader("msfts1.txt")

            ms1 = sr.ReadLine
        End Using

        If My.Computer.FileSystem.FileExists("msfts2.txt") Then
            My.Computer.FileSystem.DeleteFile("msfts2.txt")
        End If
        My.Computer.Network.DownloadFile("http://download.finance.yahoo.com/d/quotes.csv?s=MSFT&f=p2", "msfts2.txt")
        Using sr As New StreamReader("msfts2.txt")

            ms2 = sr.ReadLine

        End Using
        If My.Computer.FileSystem.FileExists("msfts3.txt") Then
            My.Computer.FileSystem.DeleteFile("msfts3.txt")
        End If
        My.Computer.Network.DownloadFile("http://download.finance.yahoo.com/d/quotes.csv?s=MSFT&f=h", "msfts3.txt")
        Using sr As New StreamReader("msfts3.txt")

            ms3 = sr.ReadLine

        End Using

        If My.Computer.FileSystem.FileExists("googs1.txt") Then
            My.Computer.FileSystem.DeleteFile("googs1.txt")
        End If
        My.Computer.Network.DownloadFile("http://download.finance.yahoo.com/d/quotes.csv?s=GOOG&f=c1", "googs1.txt")
        Using sr As New StreamReader("googs1.txt")

            gs1 = sr.ReadLine
        End Using

        If My.Computer.FileSystem.FileExists("googs2.txt") Then
            My.Computer.FileSystem.DeleteFile("googs2.txt")
        End If
        My.Computer.Network.DownloadFile("http://download.finance.yahoo.com/d/quotes.csv?s=GOOG&f=p2", "googs2.txt")
        Using sr As New StreamReader("googs2.txt")

            gs2 = sr.ReadLine

        End Using
        If My.Computer.FileSystem.FileExists("googs3.txt") Then
            My.Computer.FileSystem.DeleteFile("googs3.txt")
        End If
        My.Computer.Network.DownloadFile("http://download.finance.yahoo.com/d/quotes.csv?s=GOOG&f=h", "googs3.txt")
        Using sr As New StreamReader("googs3.txt")

            gs3 = sr.ReadLine

        End Using

        If My.Computer.FileSystem.FileExists("ebays1.txt") Then
            My.Computer.FileSystem.DeleteFile("ebays1.txt")
        End If
        My.Computer.Network.DownloadFile("http://download.finance.yahoo.com/d/quotes.csv?s=EBAY&f=c1", "ebays1.txt")
        Using sr As New StreamReader("ebays1.txt")

            es1 = sr.ReadLine
        End Using

        If My.Computer.FileSystem.FileExists("ebays2.txt") Then
            My.Computer.FileSystem.DeleteFile("ebays2.txt")
        End If
        My.Computer.Network.DownloadFile("http://download.finance.yahoo.com/d/quotes.csv?s=EBAY&f=p2", "ebays2.txt")
        Using sr As New StreamReader("ebays2.txt")

            es2 = sr.ReadLine

        End Using
        If My.Computer.FileSystem.FileExists("ebays3.txt") Then
            My.Computer.FileSystem.DeleteFile("ebays3.txt")
        End If
        My.Computer.Network.DownloadFile("http://download.finance.yahoo.com/d/quotes.csv?s=EBAY&f=h", "ebays3.txt")
        Using sr As New StreamReader("ebays3.txt")

            es3 = sr.ReadLine

        End Using


        Label15.Text = "MSFT " + ms3 + " " + ms1 + " " + ms2
        Label14.Text = "GOOG " + gs3 + " " + gs1 + " " + gs2 + vbNewLine + "EBAY " + es3 + " " + es1 + " " + es2
    End Sub

    Private Function citajxml(ByVal node As XmlNode, ByVal attibutename As String) As String
        Dim ret As String = String.Empty
        If node IsNot Nothing AndAlso node.Attributes IsNot Nothing Then
            Dim attrib As XmlNode = node.Attributes.GetNamedItem(attibutename)
            If attrib IsNot Nothing Then
                ret = attrib.Value
            End If
        End If
        Return ret
    End Function 'GetAttibuteValue

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Panel9.Left = -HScrollBar1.Value
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Form2.Show()

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel14_Click(sender As Object, e As EventArgs) Handles Panel14.Click

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Public Sub setColor(e As Object)
        My.Settings.SM_COLOR = e.ForeColor
        Me.BackColor = My.Settings.SM_COLOR
        My.Settings.Save()
    End Sub


    Private Sub Class19_Click(sender As Object, e As EventArgs) Handles Class19.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel13_Click(sender As Object, e As EventArgs) Handles Panel13.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
