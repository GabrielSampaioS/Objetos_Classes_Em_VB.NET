Public Class ContaCorrente

#Region "Construtores"
    Public Sub New(m_Saldo As Double)
        Saldo = m_Saldo

    End Sub
#End Region

#Region "Propriedade"

    Private m_Agencia As Integer
    Public Property Agencia As Integer
        Get
            Return m_Agencia
        End Get
        Set(value As Integer)
            m_Agencia = value
        End Set
    End Property

    Private m_Conta As Integer
    Public Property Conta As Integer
        Get
            Return m_Conta
        End Get
        Set(value As Integer)
            m_Conta = value
        End Set
    End Property

    Private m_Extrato As String
    Public Property Extrato As String
        Get
            Return m_Extrato
        End Get
        Set(value As String)
            m_Extrato = value
        End Set
    End Property

    Public m_Titular As ByteBank.Cliente
    Public Property Titular As ByteBank.Cliente
        Get
            Return m_Titular
        End Get
        Set(value As ByteBank.Cliente)
            m_Titular = value
        End Set
    End Property

    Private m_Saldo As Double = 100 'Ao instanciar a Class, o saldo de todas seram 100
    Public Property Saldo As Double 'Com isso, a atribuição da variavel é como se ainda fosse uma variavel Public (ebcapsula) Possibilida eu escrever uma regra de negocio
        Get
            Return m_Saldo
        End Get
        Set(value As Double)
            If (value < 0) Then
                m_Saldo = 0
            Else
                m_Saldo = value
            End If
        End Set
    End Property

#End Region

#Region "Método"
    Public Function Sacar(valorSacar As Double) As Boolean
        Dim Retorno As Boolean
        If m_Saldo < valorSacar Or valorSacar <= 0 Then
            Retorno = False
        Else
            m_Saldo -= valorSacar
            Retorno = True
        End If
        Return Retorno
    End Function

    Public Function Depositar(valorDepositar As Double) As Boolean
        Dim Retorno As Boolean
        If valorDepositar <= 0 Then
            Retorno = False
        Else
            m_Saldo += valorDepositar
            Retorno = True
        End If
        Return Retorno
    End Function

    Public Function Transferir(ByRef ContaOrigem As ContaCorrente, ValorTransferencia As Double, ByRef ContaDestino As ContaCorrente)
        Dim Retorno As Boolean
        If ContaOrigem.m_Saldo < ValorTransferencia Or ValorTransferencia <= 0 Then
            Retorno = False
        Else
            ContaOrigem.m_Saldo -= ValorTransferencia
            ContaDestino.m_Saldo += ValorTransferencia
            Retorno = True
        End If
        Return Retorno
    End Function
#End Region

#Region "Funções"
#End Region

End Class