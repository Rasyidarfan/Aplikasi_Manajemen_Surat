Public Class DateTimeHelper
    Public Shared DateAndTime As String
    Public Shared Tanggal As String
    Public Shared Bulan As String
    Public Shared Tahun As String
    Public Shared SelectDate As String
    Public Shared Jam As String
    Public Shared Menit As String
    Public Shared Waktu As String

    Public Shared Sub UpdateDateTimeVariables()
        Tahun = Format(Now, "yyyy")
        Bulan = Format(Now, "MM")
        Tanggal = Format(Now, "dd")
        SelectDate = Tahun & "-" & Bulan & "-" & Tanggal
        Waktu = Format(Now, "HH:mm:ss")
        DateAndTime = SelectDate & " " & Waktu
    End Sub
End Class
