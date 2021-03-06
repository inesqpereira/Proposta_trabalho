﻿Public Class Funcionarios
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewFuncionario As Funcionario)
        Me.List.Add(NewFuncionario)
    End Sub

    Public Sub Remove(ByVal oldFuncionario As Funcionario)
        Me.List.Remove(oldFuncionario)
    End Sub

    Default Public Property item(ByVal index As Integer) As Funcionario
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Funcionario)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub

    Public Sub InsertAt(ByVal index As Integer, ByVal NewFuncionario As Funcionario)
        Me.List.Insert(index, NewFuncionario)
    End Sub


End Class
