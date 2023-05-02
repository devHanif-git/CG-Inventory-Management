Imports System.ComponentModel
Imports Seagull.BarTender.Print

Public Class initEngine
    Public _btEngine As Engine
    Public WithEvents bgwInitEngine As New BackgroundWorker

    Private Sub bgwInitEngine_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwInitEngine.DoWork
        Me.Invoke(New MethodInvoker(Sub() Me.Hide()))
        ' Create the BarTender engine
        _btEngine = New Engine(True)

    End Sub
    Private Sub initEngine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Left = (Label1.Parent.Width \ 2) - (Label1.Width \ 2) 'horizontal centering
        ' Start the background worker to initialize the BarTender engine
        bgwInitEngine.RunWorkerAsync()
    End Sub
End Class