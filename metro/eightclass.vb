Imports System.ComponentModel

Public Class eightclass

End Class

Public Class eightswitch
    Inherits CheckBox
    Dim customColor As Color = Color.FromArgb(0, 47, 47, 47)
    Dim fortysevn As New System.Drawing.SolidBrush(customColor)
    Public Sub New()
        Me.Size = New Size(50, 19)
        Me.AutoSize = False
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        'MyBase.OnPaint(e)
        e.Graphics.FillRectangle(Brushes.Gray, 0, 0, Me.Width, Me.Height)
        e.Graphics.FillRectangle(Brushes.White, 2, 2, Me.Width - 4, Me.Height - 4)
        e.Graphics.FillRectangle(Brushes.DarkGray, 3, 3, Me.Width - 6, Me.Height - 6)
        If (Me.Checked = True) Then
            e.Graphics.FillRectangle(Brushes.Gray, 0, 0, Me.Width, Me.Height)
            e.Graphics.FillRectangle(Brushes.White, 2, 2, Me.Width - 4, Me.Height - 4)
            e.Graphics.FillRectangle(Brushes.DarkGray, 3, 3, Me.Width - 6, Me.Height - 6)
            e.Graphics.FillRectangle(Brushes.Black, Me.Width - 12, 0, Me.Width, Me.Height)
        Else
            e.Graphics.FillRectangle(Brushes.Gray, 0, 0, Me.Width, Me.Height)
            e.Graphics.FillRectangle(Brushes.White, 2, 2, Me.Width - 4, Me.Height - 4)
            e.Graphics.FillRectangle(Brushes.Gray, 3, 3, Me.Width - 6, Me.Height - 6)
            e.Graphics.FillRectangle(Brushes.Black, 0, 0, 12, Me.Height)
        End If
    End Sub

End Class
Public Class eightradbtn
    Inherits RadioButton
    Private _ForegroundBrush As New SolidBrush(Color.Transparent)
    Private _BackgroundBrush As New SolidBrush(Color.Transparent)
    <Category("Appearance"), Description("The background color of the Label.")>
    <Browsable(True), DefaultValue(GetType(Color), "Transparent")>
    Public Overrides Property ForeColor() As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As Color)
            MyBase.ForeColor = value
            _ForegroundBrush.Color = value
        End Set
    End Property

    <Category("Appearance"), Description("The background color of the Label.")>
    <Browsable(True), DefaultValue(GetType(Color), "Transparent")>
    Public Overrides Property BackColor() As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            MyBase.BackColor = value
            _BackgroundBrush.Color = value
        End Set
    End Property
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.FillRectangle(_BackgroundBrush, 0, 0, Me.Width, Me.Height)
        'MyBase.OnPaint(e)
        'e.Graphics.FillRectangle(_ForegroundBrush, 4, 4, Me.Width - 4, Me.Height - 4)
        If Me.Checked = True Then
            e.Graphics.FillRectangle(_ForegroundBrush, 4, 4, Me.Width - 8, Me.Height - 8)
            e.Graphics.DrawRectangle(Pens.Black, 2, 2, Me.Width - 5, Me.Height - 5)
            e.Graphics.DrawRectangle(Pens.Black, 1, 1, Me.Width - 3, Me.Height - 3)
        Else
            e.Graphics.FillRectangle(_ForegroundBrush, 4, 4, Me.Width - 8, Me.Height - 8)

        End If
    End Sub

End Class

Public Class eightlabel
    Inherits Label
    Private _BackgroundBrush As New SolidBrush(Color.Transparent)
    <Category("Appearance"), Description("The background color of the Label.")>
    <Browsable(True), DefaultValue(GetType(Color), "Transparent")>
    Public Overrides Property ForeColor() As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As Color)
            MyBase.ForeColor = value
            _BackgroundBrush.Color = value
        End Set
    End Property
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        ' always draw it black

        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        e.Graphics.DrawString(Me.Text, Me.Font, _BackgroundBrush, 0, 0)

    End Sub

End Class

Public Class eightlabelcenter
    Inherits Label
    Private _BackgroundBrush As New SolidBrush(Color.Transparent)
    <Category("Appearance"), Description("The background color of the Label.")>
    <Browsable(True), DefaultValue(GetType(Color), "Transparent")>
    Public Overrides Property ForeColor() As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As Color)
            MyBase.ForeColor = value
            _BackgroundBrush.Color = value
        End Set
    End Property
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        ' always draw it black
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Dim textSize = e.Graphics.MeasureString(Me.Text, Me.Font)
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        If e.ClipRectangle.Width > textSize.Width Then
            e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Dim x = Me.Width / 1.87 - textSize.Width
            Dim rect = New Rectangle(x, 0, textSize.Width, textSize.Height)
            e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
            e.Graphics.DrawString(Me.Text, Me.Font, _BackgroundBrush, rect)
        End If

        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit


    End Sub

End Class

Public Class eightlabelreverse
    Inherits Label
    Private _BackgroundBrush As New SolidBrush(Color.Transparent)
    <Category("Appearance"), Description("The background color of the Label.")>
    <Browsable(True), DefaultValue(GetType(Color), "Transparent")>
    Public Overrides Property ForeColor() As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As Color)
            MyBase.ForeColor = value
            _BackgroundBrush.Color = value
        End Set
    End Property
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Dim textSize = e.Graphics.MeasureString(Me.Text + ".", Me.Font)
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        If e.ClipRectangle.Width > textSize.Width Then
            e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Dim x = e.ClipRectangle.Width - textSize.Width
            Dim rect = New Rectangle(x, 0, textSize.Width, textSize.Height)
            e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
            e.Graphics.DrawString(Me.Text, Me.Font, _BackgroundBrush, rect)
        End If

        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit


    End Sub
End Class

