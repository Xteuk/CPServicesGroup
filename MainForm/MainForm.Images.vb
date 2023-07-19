Partial Public Class MainForm

    Private Sub ComputeImages()

        StartupImages.Images.Add("?", My.Resources.unknown)
        StartupImages.Images.Add("Running", My.Resources._play)
        StartupImages.Images.Add("Paused", My.Resources._pause)
        StartupImages.Images.Add("Stopped", My.Resources._stop)
        StartupImages.Images.Add("PausePending", My.Resources.timer)
        StartupImages.Images.Add("StartPending", My.Resources.timer)
        StartupImages.Images.Add("ContinuePending", My.Resources.timer)
        StartupImages.Images.Add("StopPending", My.Resources.timer)
        StartupImages.Images.Add("Pending", My.Resources.timer)
        StartupImages.Images.Add("Unknown", My.Resources.unknown)

        StatusImages.Images.Add("?", My.Resources.unknown)
        StatusImages.Images.Add("Multiple", My.Resources.multiple)
        StatusImages.Images.Add("Auto", My.Resources.automatic)
        StatusImages.Images.Add("Disabled", My.Resources.disabled)
        StatusImages.Images.Add("Manual", My.Resources.main)
        StatusImages.Images.Add("System", My.Resources.system)
        StatusImages.Images.Add("Unknown", My.Resources.unknown)
        StatusImages.Images.Add("Error", My.Resources._error)

        For Each key As String In StatusImages.Images.Keys
            StartupImages.Images.Add(key, StatusImages.Images(key))
        Next

        For Each input As String In StartupImages.Images.Keys
            Dim img2 As Image = StartupImages.Images(input)

            Dim img As New Bitmap(32, 16, Imaging.PixelFormat.Format32bppArgb)
            With Graphics.FromImage(img)
                .DrawImage(img2, 8, 0)
            End With
            Images32Width.Images.Add(input, img)

            For Each output As String In StatusImages.Images.Keys
                Dim img1 As Image = StatusImages.Images(output)
                If img1 Is Nothing Then Continue For

                img = New Bitmap(32, 16, Imaging.PixelFormat.Format32bppArgb)
                With Graphics.FromImage(img)
                    .DrawImage(img1, 8, 0)
                End With
                Images32Width.Images.Add(output, img)

                If img1 Is Nothing Or img2 Is Nothing Then Continue For

                img = New Bitmap(32, 16, Imaging.PixelFormat.Format32bppArgb)
                With Graphics.FromImage(img)
                    .DrawImage(img1, 0, 0)
                    .DrawImage(img2, 16, 0)
                End With
                Images32Width.Images.Add(input & output, img)

            Next
        Next

    End Sub


End Class
