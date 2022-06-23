Public Class Frm_Principal01
    Dim ContaCorrente1 As New ContaCorrente(150)
    Dim ContaCorrente2 As New ContaCorrente(110)

    Public Sub New()
        InitializeComponent()

        Me.Text = "1 - Primeira Calsse"
        Lbl_Principal.Text = "1 - Primeira Classe"
        Txt_Status1.ReadOnly = True
        Txt_Extrato1.ReadOnly = True
        Txt_Saldo1.ReadOnly = True
        Txt_Status2.ReadOnly = True
        Txt_Extrato2.ReadOnly = True
        Txt_Saldo2.ReadOnly = True


        GrpBox_Conta1.Text = "Bruno"
        'Conta1
        Lbl_SaqueOuDeposito1.Text = "Sacar / Deposito"
        Lbl_Saldo1.Text = "Saldo"
        Lbl_Status1.Text = "Staus da ordem"
        Btn_Depositar1.Text = "Depositar"
        Btn_Saque1.Text = "Sacar"
        Btn_Trasferir1.Text = "Transferir"

        GrpBox_Conta2.Text = "Gabriel"
        'Conta2
        Lbl_SaqueOuDeposito2.Text = "Sacar / Deposito"
        Lbl_Saldo2.Text = "Saldo"
        Lbl_Status2.Text = "Staus da ordem"
        Btn_Depositar2.Text = "Depositar"
        Btn_Saque2.Text = "Sacar"
        Btn_Trasferir2.Text = "Transferir"

        'Iniciar os valores das classes 1 e 2
        Dim Bruno As New ByteBank.Cliente("Bruno", "48467831898") With { 'Uma maneira mais elegante de fazer
            .Profissao = "Analista de sistemas",
            .Cidade = "Piracicaba"
        }

        ContaCorrente1.Titular = Bruno
        ContaCorrente1.Agencia = 123
        ContaCorrente1.Conta = 12345



        Dim Gabriel As New ByteBank.Cliente("Gabriel", "44465845187") 'Uma maneira normal de fazer
        Gabriel.Profissao = "Tecnico em qualquer coisa"
        Gabriel.Cidade = "Piracicaba"

        ContaCorrente2.Titular = Gabriel
        ContaCorrente2.Agencia = 456
        ContaCorrente2.Conta = 56789

        Lbl_BemVindoConta1.Text = "Bem Vindo " + ContaCorrente1.Titular.Nome + " Conta: " + ContaCorrente1.Conta.ToString _
        + " Agencia: " + ContaCorrente1.Agencia.ToString + " CPF: " + ContaCorrente1.Titular.CPF
        Lbl_BemVindoConta2.Text = "Bem Vindo " + ContaCorrente2.Titular.Nome + " Conta: " + ContaCorrente2.Conta.ToString _
        + " Agencia: " + ContaCorrente2.Agencia.ToString + " CPF: " + ContaCorrente2.Titular.CPF

        Txt_Saldo1.Text = ContaCorrente1.Saldo.ToString
        Txt_Saldo2.Text = ContaCorrente2.Saldo.ToString
        Lbl_NumeroClientes.Text = "Numero de clientes: " + ByteBank.Cliente.NumeroCliente.ToString

    End Sub

    Private Sub Btn_Saque_Click(sender As Object, e As EventArgs) Handles Btn_Saque1.Click
        Txt_Status1.Text = ""
        Dim ValorSacar As Double = Val(Txt_Valor1.Text)
        Dim RetornoSaque As Boolean = ContaCorrente1.Sacar(ValorSacar)

        If RetornoSaque = False Then
            Txt_Status1.Text = "Saque não é possível ser feito"
        Else
            Txt_Status1.Text = "Saque realizado com sucesso"
            ContaCorrente1.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString + " Saldo " + ContaCorrente1.Saldo.ToString + vbCrLf
        End If
        Txt_Saldo1.Text = ContaCorrente1.Saldo.ToString
        Txt_Extrato1.Text = ContaCorrente1.Extrato

        Txt_Valor1.Text = ""
    End Sub

    Private Sub Btn_Depositar_Click(sender As Object, e As EventArgs) Handles Btn_Depositar1.Click
        Txt_Status1.Text = ""
        Dim ValorDepositar As Double = Val(Txt_Valor1.Text)
        Dim RetornoDeposito As Boolean = ContaCorrente1.Depositar(ValorDepositar)

        If RetornoDeposito = False Then
            Txt_Status1.Text = "Deposito invalido"
            'Escrever no extrato em vermelho a tentativa de saque e deposito negados
        Else
            Txt_Status1.Text = "Deposito realizado com sucesso"
            ContaCorrente1.Extrato += Now.ToString + " Deposito de " + ValorDepositar.ToString + " Saldo " + ContaCorrente1.Saldo.ToString + vbCrLf
        End If
        Txt_Saldo1.Text = ContaCorrente1.Saldo.ToString
        Txt_Extrato1.Text = ContaCorrente1.Extrato

        Txt_Valor1.Text = ""
    End Sub

    Private Sub Btn_Saque2_Click(sender As Object, e As EventArgs) Handles Btn_Saque2.Click
        Txt_Status2.Text = ""
        Dim ValorSacar As Double = Val(Txt_Valor2.Text)
        Dim RetornoSaque As Boolean = ContaCorrente2.Sacar(ValorSacar)

        If RetornoSaque = False Then
            Txt_Status2.Text = "Saque não é possível ser feito"
        Else
            Txt_Status2.Text = "Saque realizado com sucesso"
            ContaCorrente2.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString + " Saldo " + ContaCorrente2.Saldo.ToString + vbCrLf
        End If
        Txt_Saldo2.Text = ContaCorrente2.Saldo.ToString
        Txt_Extrato2.Text = ContaCorrente2.Extrato

        Txt_Valor2.Text = ""
    End Sub

    Private Sub Btn_Depositar2_Click(sender As Object, e As EventArgs) Handles Btn_Depositar2.Click
        Txt_Status2.Text = ""
        Dim ValorDepositar As Double = Val(Txt_Valor2.Text)
        Dim RetornoDeposito As Boolean = ContaCorrente2.Depositar(ValorDepositar)

        If RetornoDeposito = False Then
            Txt_Status2.Text = "Deposito invalido"
            'Escrever no extrato em vermelho a tentativa de saque e deposito negados
        Else
            Txt_Status2.Text = "Deposito realizado com sucesso"
            ContaCorrente2.Extrato += Now.ToString + " Deposito de " + ValorDepositar.ToString + " Saldo " + ContaCorrente2.Saldo.ToString + vbCrLf
        End If
        Txt_Saldo2.Text = ContaCorrente2.Saldo.ToString
        Txt_Extrato2.Text = ContaCorrente2.Extrato

        Txt_Valor2.Text = ""
    End Sub

    Private Sub Btn_Trasferir1_Click(sender As Object, e As EventArgs) Handles Btn_Trasferir1.Click
        Dim ValorTransferencia As Double = Val(Txt_Valor1.Text)
        Dim RetornoTransferencia As Boolean = ContaCorrente1.Transferir(ContaCorrente1, ValorTransferencia, ContaCorrente2)
        If RetornoTransferencia = False Then
            Txt_Status1.Text = "Transferencia invalida"
        Else
            Txt_Status1.Text = "Transferencia enviada com sucesso"
            Txt_Status2.Text = "Transferencia recebida com sucesso"
            ContaCorrente1.Extrato += Now.ToString + " Transferencia enviada de " + ValorTransferencia.ToString + " Saldo " + ContaCorrente1.Saldo.ToString + vbCrLf
            ContaCorrente2.Extrato += Now.ToString + " Transferencia recebida de " + ValorTransferencia.ToString + " Saldo " + ContaCorrente2.Saldo.ToString + vbCrLf
        End If
        Txt_Saldo1.Text = ContaCorrente1.Saldo.ToString
        Txt_Extrato1.Text = ContaCorrente1.Extrato
        Txt_Saldo2.Text = ContaCorrente2.Saldo.ToString
        Txt_Extrato2.Text = ContaCorrente2.Extrato

        Txt_Valor1.Text = ""
    End Sub

    Private Sub Btn_Trasferir2_Click(sender As Object, e As EventArgs) Handles Btn_Trasferir2.Click
        Dim ValorTransferencia As Double = Val(Txt_Valor2.Text)
        Dim RetornoTransferencia As Boolean = ContaCorrente2.Transferir(ContaCorrente2, ValorTransferencia, ContaCorrente1)
        If RetornoTransferencia = False Then
            Txt_Status2.Text = "Transferencia invalida"
        Else
            Txt_Status2.Text = "Transferencia enviada com sucesso"
            Txt_Status1.Text = "Transferencia recebida com sucesso"
            ContaCorrente2.Extrato += Now.ToString + " Transferencia enviada de " + ValorTransferencia.ToString + " Saldo " + ContaCorrente2.Saldo.ToString + vbCrLf
            ContaCorrente1.Extrato += Now.ToString + " Transferencia recebida de " + ValorTransferencia.ToString + " Saldo " + ContaCorrente1.Saldo.ToString + vbCrLf
        End If
        Txt_Saldo2.Text = ContaCorrente2.Saldo.ToString
        Txt_Extrato2.Text = ContaCorrente2.Extrato
        Txt_Saldo1.Text = ContaCorrente1.Saldo.ToString
        Txt_Extrato1.Text = ContaCorrente1.Extrato

        Txt_Valor2.Text = ""
    End Sub
End Class