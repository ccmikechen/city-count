Imports System.IO
Public Class Form1
    Dim sw As New StreamWriter("out.txt")
    Dim sr As StreamReader
    Dim N, I, J, S, ans, a1, a2 As Integer
    Dim T As String
    Sub check()
        ans = 0
        N = sr.ReadLine
        Dim R(N, N) As String
        For k1 = 1 To 4
            Dim m As String = sr.ReadLine
            For k2 = 1 To 4
                R(k1, k2) = Mid(m, k2, 1)
            Next
        Next

        I = sr.ReadLine
        J = sr.ReadLine
        S = sr.ReadLine
        run(R, I, 0)
        sw.WriteLine(ans)

        For k = 1 To N
            T = k
            run2(R, k, k)
            For k2 = 1 To 4
                If InStr(T, k2) = 0 Then sw.WriteLine(k & vbCrLf & k2) : Exit Sub
            Next
        Next
        sw.WriteLine(0 & vbCrLf & 0)
    End Sub

    Sub run(ByVal R(,) As String, ByVal A As Integer, ByVal B As Integer)
        If B = S + 1 Then
            If A = J Then ans += 1
            Exit Sub
        End If
        For k = 1 To N
            If R(A, k) = "1" Then run(R, k, B + 1)
        Next

    End Sub

    Sub run2(ByVal R(,) As String, ByVal A As Integer, ByVal F As String)
        For k = 1 To N
            If InStr(F, k) = 0 Then
                If R(A, k) = "1" Then
                    T &= k
                    run2(R, k, F & k)
                End If
            End If
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sr = New StreamReader("in1.txt")
        check()
        sw.WriteLine()
        sr = New StreamReader("in2.txt")
        check()
        sw.Flush() : End
    End Sub
End Class
