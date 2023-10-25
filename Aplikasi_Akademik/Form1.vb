Public Class FormUtama
    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim konfirmasi = MsgBox("Apakah Anda yakin akan keluar Aplikasi?", MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                                "Konfirmasi")

        If konfirmasi = DialogResult.Yes Then
            End
        End If

    End Sub
End Class
