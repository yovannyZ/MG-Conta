Public Class TDiferido
    'FE_AÑO, FE_MES, COD_DOC, NRO_DOC, COD_PER, COD_CC, COD_CUENTA, GLOSA, FECHA_DOC, IMP, COD_D_H, COD_MONEDA, TIPO_CAMBIO, NRO_CUOTA, ST_TRANS

    Private _feAño As String
    Public Property FeAño() As String
        Get
            Return _feAño
        End Get
        Set(ByVal value As String)
            _feAño = value
        End Set
    End Property


    Private _feMes As String
    Public Property FeMes() As String
        Get
            Return _feMes
        End Get
        Set(ByVal value As String)
            _feMes = value
        End Set
    End Property


    Private _codDoc As String
    Public Property CodDoc() As String
        Get
            Return _codDoc
        End Get
        Set(ByVal value As String)
            _codDoc = value
        End Set
    End Property



    Private _nroDoc As String
    Public Property NroDoc() As String
        Get
            Return _nroDoc
        End Get
        Set(ByVal value As String)
            _nroDoc = value
        End Set
    End Property


    Private _codPer As String
    Public Property CodPer() As String
        Get
            Return _codPer
        End Get
        Set(ByVal value As String)
            _codPer = value
        End Set
    End Property


    Private _codCC As String
    Public Property CodCC() As String
        Get
            Return _codCC
        End Get
        Set(ByVal value As String)
            _codCC = value
        End Set
    End Property


    Private _codCuenta As String
    Public Property CodCuenta() As String
        Get
            Return _codCuenta
        End Get
        Set(ByVal value As String)
            _codCuenta = value
        End Set
    End Property


    Private _glosa As String
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property


    Private _fechaDoc As Date
    Public Property FechaDoc() As Date
        Get
            Return _fechaDoc
        End Get
        Set(ByVal value As Date)
            _fechaDoc = value
        End Set
    End Property


    Private _importe As Decimal
    Public Property Importe() As Decimal
        Get
            Return _importe
        End Get
        Set(ByVal value As Decimal)
            _importe = value
        End Set
    End Property


    Private _codDH As String
    Public Property CodDH() As String
        Get
            Return _codDH
        End Get
        Set(ByVal value As String)
            _codDH = value
        End Set
    End Property



    Private _codMoneda As String
    Public Property CodMoneda() As String
        Get
            Return _codMoneda
        End Get
        Set(ByVal value As String)
            _codMoneda = value
        End Set
    End Property


    Private _tipoCambio As Decimal
    Public Property TipoCambio() As Decimal
        Get
            Return _tipoCambio
        End Get
        Set(ByVal value As Decimal)
            _tipoCambio = value
        End Set
    End Property


    Private _nroCuota As Integer
    Public Property NroCuota() As Integer
        Get
            Return _nroCuota
        End Get
        Set(ByVal value As Integer)
            _nroCuota = value
        End Set
    End Property


    Private _stTrans As String
    Public Property StTrans() As String
        Get
            Return _stTrans
        End Get
        Set(ByVal value As String)
            _stTrans = value
        End Set
    End Property

    Private _stCierre As Char
    Public Property StCierre() As Char
        Get
            Return (_stCierre)
        End Get
        Set(ByVal value As Char)
            _stCierre = value
        End Set
    End Property
End Class
