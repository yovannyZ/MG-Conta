Public Class TDiferidoCC
    'FE_AÑO, FE_MES, COD_DOC, NRO_DOC, COD_PER, COD_CC, COD_CUENTA, POR_DIF


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


    Private _porDif As Decimal
    Public Property PorDif() As Decimal
        Get
            Return _porDif
        End Get
        Set(ByVal value As Decimal)
            _porDif = value
        End Set
    End Property



End Class
