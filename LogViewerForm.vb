Public Class LogViewerForm

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub LogViewerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim objFile As New System.IO.StreamReader( _
            System.AppDomain.CurrentDomain.BaseDirectory() & _
            "\PictureLog.txt")
            txtLog.Text = objFile.ReadToEnd()
            objFile.Close()
            objFile.Dispose()
        Catch ex As Exception
            txtLog.Text = "The log file could not be found."
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory() & "\PictureLog.txt") Then
            If MessageBox.Show("Are you sure you want to delete the log file?", _
            "MyApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
            Windows.Forms.DialogResult.Yes Then
                System.IO.File.Delete(System.AppDomain.CurrentDomain.BaseDirectory() & "\PictureLog.txt")
            End If
        End If
        Me.Close()
    End Sub
End Class