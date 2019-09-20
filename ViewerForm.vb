
Public Class ViewerForm

    Const c_defPromptOnExit As Boolean = False

    Private m_strUserName As String
    Private m_blnPromptOnExit As Boolean
    Private m_objPictureBackColor As Color

    Private Sub btnEnlarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnlarge.Click
        Me.Width = Me.Width + 20
        Me.Height = Me.Height + 20

    End Sub

    Private Sub btnShrink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShrink.Click
        Me.Width = Me.Width - 20
        Me.Height = Me.Height - 20

    End Sub

    Private Sub picShowPicture_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picShowPicture.DoubleClick
        ZoomOut()
    End Sub

    Private Sub picShowPicture_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picShowPicture.MouseLeave
        lblX.Text = ""
        lblY.Text = ""
    End Sub

    Private Sub picShowPicture_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picShowPicture.MouseMove
        lblX.Text = "X: " & e.X
        lblY.Text = "Y: " & e.Y

    End Sub

    Private Sub ViewerForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If m_blnPromptOnExit Then
            If MessageBox.Show("Close the Picture Viewer program?", _
            "Picture Viewer", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Question) = _
            Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ViewerForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblX.Text = ""
        lblY.Text = ""
        LoadDefaults()

        g_PictureBoxCopy = picShowPicture.Bounds
    End Sub

    Public Sub LoadDefaults()
        m_blnPromptOnExit = CBool(My.Computer.Registry.GetValue _
        (c_strKeyName, "PromptOnExit", "0"))
        If CStr(My.Computer.Registry.GetValue _
        (c_strKeyName, "BackColor", "Gray")) = "Gray" Then
            m_objPictureBackColor = System.Drawing.SystemColors.Control
        Else
            m_objPictureBackColor = System.Drawing.Color.White
        End If
        picShowPicture.BackColor = m_objPictureBackColor
        mnuConfirmOnExit.Checked = m_blnPromptOnExit
    End Sub

    Private Sub mnuOpenPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpenPicture.Click
        OpenPicture()
    End Sub

    Private Sub mnuConfirmOnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfirmOnExit.Click
        mnuConfirmOnExit.Checked = Not (mnuConfirmOnExit.Checked)
        m_blnPromptOnExit = mnuConfirmOnExit.Checked
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub mnuOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptions.Click
        Optionsform.ShowDialog()
    End Sub

    Private Sub tbbOpenPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbOpenPicture.Click
        OpenPicture()
    End Sub

    

    Private Sub tbbOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbOptions.Click
        Optionsform.ShowDialog()
    End Sub

    Private Sub tbbGetFileAttributes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbGetFileAttributes.Click
        FileProperties(g_strFileName)
    End Sub

    Private Sub mnuGetFileAttributesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGetFileAttributesToolStripMenuItem.Click
        FileProperties(g_strFileName)
    End Sub

    Private Sub tbbShowLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbShowLog.Click
        LogViewerForm.ShowDialog()
    End Sub

    Private Sub mnuViewPictureLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewPictureLogToolStripMenuItem.Click
        LogViewerForm.ShowDialog()
    End Sub

    Private Sub tbbRotate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbRotate.Click
        PictureRotate()
    End Sub

    Private Sub mnuRotate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRotate.Click
        PictureRotate()
    End Sub

    Private Sub tbbZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbZoomOut.Click
        ZoomOut()
    End Sub

    Private Sub tbbZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbZoomIn.Click
        ZoomIn()
    End Sub

    ' When mouse drags item to form, just as it is about to drop
    Private Sub ViewerForm_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    ' When item has been dropped
    Private Sub ViewerForm_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
        ' Take dropped items and hold in array
        Dim strDroppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        imgImage = e.Data.GetData(DataFormats.FileDrop)
        ' Loop through all dropped files, displaying them
        For Each file In strDroppedFiles
            g_strFileName = GetFileName(file)
            Try
                ' Reset the picture box
                Me.picShowPicture.Bounds = g_PictureBoxCopy
                ' Load the picture into the picture box
                picShowPicture.Image = Image.FromFile(file)
                ' Update our log file
                UpdateLog(g_strFileName)
                ' Show the file's name in the status bar
                sbrMyStatusStrip.Items(0).Text = g_strFileName

            Catch ex As Exception
                MessageBox.Show("You recommended to highlight all the images in the directory and drop in the picture box.", "Picture Viewer", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Next
    End Sub

    Public Function GetFileName(ByVal FilePath As String)

        Return System.IO.Path.GetFullPath(FilePath)
    End Function

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        count += 1
        Try
            ' Load the picture into the picture box
            picShowPicture.Image = Image.FromFile(imgImage(count))

            g_strFileName = GetFileName(imgImage(count))

            ' Update our log file
            UpdateLog(g_strFileName)
            ' Show the file's name in the status bar
            sbrMyStatusStrip.Items(0).Text = g_strFileName
        Catch ex As Exception
            MessageBox.Show("You've reached the last picture in the list", "Picture Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        count -= 1
        Try
            ' Load the picture into the picture box
            picShowPicture.Image = Image.FromFile(imgImage(count))

            g_strFileName = GetFileName(imgImage(count))

            ' Update our log file
            UpdateLog(g_strFileName)
            ' Show the file's name in the status bar
            sbrMyStatusStrip.Items(0).Text = g_strFileName
        Catch ex As Exception
            MessageBox.Show("You've reached the last picture in the list", "Picture Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub tbbDeletePicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbDeletePicture.Click
        PicDelete()
    End Sub

    Private Sub mnuDeletePicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeletePicture.Click
        PicDelete()
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuZoomOut.Click
        ZoomOut()
    End Sub

    Private Sub mnuZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuZoomIn.Click
        ZoomIn()
    End Sub
    
    Private Sub tbbDrawBorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbbDrawBorder.Click
        DrawBorder(picShowPicture)
    End Sub

    Private Sub mnuDrawBorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDrawBorder.Click
        DrawBorder(picShowPicture)
    End Sub

    Private Sub ClearBorderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBorderToolStripMenuItem.Click
        ClearBorder()
    End Sub
End Class
