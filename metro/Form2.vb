Imports System.Drawing.Text

Public Class Form2
    Private Sub Trackbar1_CheckedChanged(sender As Object, e As EventArgs) Handles Trackbar1.CheckedChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Trackbar1.Checked = True Then
            Eightlabel1.Text = "On"
            Panel8.Visible = True
            My.Settings.TLName = True
            My.Settings.Save()
        Else
            Eightlabel1.Text = "Off"
            My.Settings.TLName = False
            Panel8.Visible = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = My.Settings.TL_BIG
        TextBox2.Text = My.Settings.TL_SMALL
        checkColor(Eightradbtn1)
        checkColor(Eightradbtn2)
        checkColor(Eightradbtn3)
        checkColor(Eightradbtn4)
        checkColor(Eightradbtn5)
        checkColor(Eightradbtn6)
        checkColor(Eightradbtn7)
        checkColor(Eightradbtn8)
        checkColor(Eightradbtn9)
        checkColor(Eightradbtn10)
        checkColor(Eightradbtn11)
        checkColor(Eightradbtn12)
        checkColor(Eightradbtn13)
        checkColor(Eightradbtn14)
        checkColor(Eightradbtn15)
        checkColor(Eightradbtn16)
        checkColor(Eightradbtn17)
        checkColor(Eightradbtn18)
        checkColor(Eightradbtn19)
        checkColor(Eightradbtn20)
        checkColor(Eightradbtn21)
        checkColor(Eightradbtn22)
        TextBox4.Text = My.Settings.OL_NAME
        TextBox5.Text = My.Settings.SM_PROFILEP
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        My.Settings.TL_BIG = TextBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        My.Settings.TL_SMALL = TextBox2.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        My.Settings.OL_NAME = TextBox4.Text
        My.Settings.Save()
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Form1.Initapp()

        My.Settings.Save()
    End Sub


    Private Sub Panel15_Click(sender As Object, e As EventArgs) Handles Panel15.Click
        Me.Close()
    End Sub

    Private Sub Panel14_Click(sender As Object, e As EventArgs) Handles Panel14.Click
        Form1.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel15_MouseEnter(sender As Object, e As EventArgs) Handles Panel15.MouseEnter
        Panel15.BackColor = Color.FromArgb(224, 67, 67)
        Timer3.Stop()
        Timer2.Start()
    End Sub

    Private Sub Panel15_MouseLeave(sender As Object, e As EventArgs) Handles Panel15.MouseLeave
        Panel15.BackColor = Color.Black
    End Sub

    Private Sub Panel14_MouseEnter(sender As Object, e As EventArgs) Handles Panel14.MouseEnter
        Panel14.BackColor = Color.FromArgb(54, 101, 179)
        Timer2.Start()
        Timer3.Stop()
    End Sub

    Private Sub Panel14_MouseLeave(sender As Object, e As EventArgs) Handles Panel14.MouseLeave
        Panel14.BackColor = Color.Black
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Panel10.Location.Y = 0 Then
            Timer2.Stop()
        Else
            Panel10.Top = Panel10.Top + 1
        End If
    End Sub

    Public Sub checkColor(e As Object)
        If e.ForeColor = My.Settings.SM_COLOR Then
            e.Checked = True
        Else
            e.Checked = False

        End If
    End Sub
    Private Sub Eightradbtn1_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn1.CheckedChanged
        Form1.setColor(Eightradbtn1)
    End Sub

    Private Sub Eightradbtn2_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn2.CheckedChanged
        Form1.setColor(Eightradbtn2)
    End Sub

    Private Sub Eightradbtn3_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn3.CheckedChanged
        Form1.setColor(Eightradbtn3)
    End Sub

    Private Sub Eightradbtn4_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn4.CheckedChanged
        Form1.setColor(Eightradbtn4)
    End Sub

    Private Sub Eightradbtn5_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn5.CheckedChanged
        Form1.setColor(Eightradbtn5)
    End Sub

    Private Sub Eightradbtn6_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn6.CheckedChanged
        Form1.setColor(Eightradbtn6)
    End Sub

    Private Sub Eightradbtn7_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn7.CheckedChanged
        Form1.setColor(Eightradbtn7)
    End Sub

    Private Sub Eightradbtn8_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn8.CheckedChanged
        Form1.setColor(Eightradbtn8)
    End Sub

    Private Sub Eightradbtn9_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn9.CheckedChanged
        Form1.setColor(Eightradbtn9)
    End Sub

    Private Sub Eightradbtn10_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn10.CheckedChanged
        Form1.setColor(Eightradbtn10)
    End Sub

    Private Sub Eightradbtn11_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn11.CheckedChanged
        Form1.setColor(Eightradbtn11)
    End Sub

    Private Sub Eightradbtn12_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn12.CheckedChanged
        Form1.setColor(Eightradbtn12)
    End Sub

    Private Sub Eightradbtn13_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn13.CheckedChanged
        Form1.setColor(Eightradbtn13)
    End Sub

    Private Sub Eightradbtn14_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn14.CheckedChanged
        Form1.setColor(Eightradbtn14)
    End Sub

    Private Sub Eightradbtn15_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn15.CheckedChanged
        Form1.setColor(Eightradbtn15)
    End Sub

    Private Sub Eightradbtn16_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn16.CheckedChanged
        Form1.setColor(Eightradbtn16)
    End Sub

    Private Sub Eightradbtn17_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn17.CheckedChanged
        Form1.setColor(Eightradbtn17)
    End Sub

    Private Sub Eightradbtn18_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn18.CheckedChanged
        Form1.setColor(Eightradbtn18)
    End Sub

    Private Sub Eightradbtn19_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn19.CheckedChanged
        Form1.setColor(Eightradbtn19)
    End Sub

    Private Sub Eightradbtn20_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn20.CheckedChanged
        Form1.setColor(Eightradbtn20)
    End Sub

    Private Sub Eightradbtn21_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn21.CheckedChanged
        Form1.setColor(Eightradbtn21)
    End Sub

    Private Sub Eightradbtn22_CheckedChanged(sender As Object, e As EventArgs) Handles Eightradbtn22.CheckedChanged
        Form1.setColor(Eightradbtn22)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Panel10.Location.Y = -30 Then
            Timer3.Stop()
        Else
            Panel10.Top = Panel10.Top - 1
        End If
    End Sub

    Private Sub Panel16_MouseEnter(sender As Object, e As EventArgs) Handles Panel16.MouseEnter
        Timer2.Start()
    End Sub

    Private Sub Panel10_MouseEnter(sender As Object, e As EventArgs) Handles Panel10.MouseEnter
        Timer2.Start()
    End Sub

    Private Sub Panel10_MouseLeave(sender As Object, e As EventArgs) Handles Panel10.MouseLeave
        Timer3.Start()
    End Sub

    Private Sub Panel11_MouseEnter(sender As Object, e As EventArgs) Handles Panel11.MouseEnter
        Timer2.Start()
    End Sub

    Private Sub Panel12_MouseEnter(sender As Object, e As EventArgs) Handles Panel12.MouseEnter
        Timer2.Start()
    End Sub

    Private Sub Panel13_MouseEnter(sender As Object, e As EventArgs) Handles Panel13.MouseEnter
        Timer2.Start()
    End Sub
    Private Sub Panel11_MouseLeave(sender As Object, e As EventArgs) Handles Panel11.MouseLeave
        Timer3.Start()
    End Sub
    Private Sub Panel12_MouseLeave(sender As Object, e As EventArgs) Handles Panel12.MouseLeave
        Timer3.Start()
    End Sub
    Private Sub Panel13_MouseLeave(sender As Object, e As EventArgs) Handles Panel13.MouseLeave
        Timer3.Start()
    End Sub


    Private Sub Eightlabel5_MouseEnter(sender As Object, e As EventArgs) Handles Eightlabel5.MouseEnter
        Timer2.Start()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Timer2.Start()
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Timer3.Start()
    End Sub

    Private Sub Eightlabel5_MouseLeave(sender As Object, e As EventArgs) Handles Eightlabel5.MouseLeave
        Timer3.Start()
    End Sub

    Private Sub Eightlabel5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox5.Text = OpenFileDialog1.FileName
            My.Settings.SM_PROFILEP = OpenFileDialog1.FileName
            My.Settings.Save()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        My.Settings.SM_PROFILEP = TextBox5.Text
    End Sub
End Class