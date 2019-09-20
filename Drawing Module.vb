Module Drawing_Module
    Public Const c_strKeyName As String = "HKEY_CURRENT_USER\Software\CleverSoftware\PictureViewer\"
    Public g_PictureBoxCopy As Object
    Public g_strFileName As String

    Public Sub OpenPicture()
        Try
            ' Show the open file dialog box.
            If ViewerForm.ofdSelectPicture.ShowDialog = DialogResult.OK Then
                ' Reset the picture box first
                ViewerForm.picShowPicture.Bounds = g_PictureBoxCopy

                g_strFileName = ViewerForm.ofdSelectPicture.FileName

                ' Load the picture into the picture box.
                ViewerForm.picShowPicture.Image = _
                Image.FromFile(g_strFileName)
                ' Show the name of the file in the statusbar.
                ViewerForm.sbrMyStatusStrip.Items(0).Text = _
                g_strFileName
                UpdateLog(g_strFileName)
            End If
        Catch objException As System.OutOfMemoryException
            MessageBox.Show("The file you have chosen is not an image file.", _
            "Invalid File", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub UpdateLog(ByVal strFileName2 As String)
        Dim objFile As New System.IO.StreamWriter( _
        System.AppDomain.CurrentDomain.BaseDirectory() & "\PictureLog.txt", _
        True)
        objFile.WriteLine(Today() & " " & TimeOfDay & " " & strFileName2)
        objFile.Close()
        objFile.Dispose()
    End Sub

    Public Sub DrawBorder(ByRef objPicturebox As PictureBox)
        Dim objGraphics As Graphics
        objGraphics = objPicturebox.Parent.CreateGraphics
        objGraphics.Clear(System.Drawing.SystemColors.Control)
        objGraphics.DrawRectangle(System.Drawing.Pens.Blue, objPicturebox.Left - 1, _
        objPicturebox.Top - 1, _
        objPicturebox.Width + 1, objPicturebox.Height + 1)
        objGraphics.Dispose()
    End Sub

    Public Sub ZoomOut()
        ViewerForm.picShowPicture.Width = ViewerForm.picShowPicture.Width * 1.5
        ViewerForm.picShowPicture.Height = ViewerForm.picShowPicture.Height * 1.5

        If ViewerForm.picShowPicture.Height > 2000 Then
            ViewerForm.picShowPicture.Width = 1540
            ViewerForm.picShowPicture.Height = 800
        End If
    End Sub

    Public Sub ZoomIn()
        ViewerForm.picShowPicture.Width = ViewerForm.picShowPicture.Width / 1.5
        ViewerForm.picShowPicture.Height = ViewerForm.picShowPicture.Height / 1.5

        If ViewerForm.picShowPicture.Height < 200 Then
            ViewerForm.picShowPicture.Width = 1540
            ViewerForm.picShowPicture.Height = 800
        End If
    End Sub

    Public Sub PictureRotate()
        If g_strFileName <> vbNull Then
            Exit Sub
        End If
        ViewerForm.picShowPicture.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        ViewerForm.picShowPicture.Refresh()
    End Sub

    Public Sub FileProperties(ByVal ofdSelectPicture As Object)
        Dim strProperties As String
        Dim lngAttributes As Long
        If g_strFileName = "" Then Exit Sub
        ' Get the dates.
        strProperties = "Created: " & _
        System.IO.File.GetCreationTime(g_strFileName)
        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Accessed: " & _
        System.IO.File.GetLastAccessTime(g_strFileName)
        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Modified: " & _
        System.IO.File.GetLastWriteTime(g_strFileName)
        ' Get the file attributes.
        lngAttributes = System.IO.File.GetAttributes(g_strFileName)
        ' Use a binary AND to extract the specific attributes.
        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Normal: " & _
        CBool(lngAttributes And IO.FileAttributes.Normal)
        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Hidden: " & _
        CBool(lngAttributes And IO.FileAttributes.Hidden)
        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "ReadOnly: " & _
        CBool(lngAttributes And IO.FileAttributes.ReadOnly)
        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "System: " & _
        CBool(lngAttributes And IO.FileAttributes.System)
        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Temporary File: " & _
        CBool(lngAttributes And IO.FileAttributes.Temporary)
        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Archive: " & _
        CBool(lngAttributes And IO.FileAttributes.Archive)
        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Dimensions: " & _
        ViewerForm.picShowPicture.Image.Width & "x" & ViewerForm.picShowPicture.Image.Height
        ' Get the file size.
        Const lngConvertion As Single = 1049748.3444
        ' Converting the file size.
        Dim intSize As Integer = FileLen(g_strFileName)
        Dim intFileSize As Single
        intFileSize = intSize / lngConvertion
        ' Display the file size.
        strProperties = strProperties & vbCrLf
        strProperties = strProperties & "Size: " & _
        intFileSize & " MB"
        MessageBox.Show(strProperties, "Picture Viewer")
    End Sub
End Module
