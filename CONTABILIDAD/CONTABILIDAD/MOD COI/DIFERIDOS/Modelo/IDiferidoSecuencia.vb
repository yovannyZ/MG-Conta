Public Class IDiferidoSecuencia
    'FE_AÑO, FE_MES, COD_DOC, NRO_DOC, COD_PER, AÑO_DIF, MES_DIF
    Private _feAño As String
    Private _feMes As String
    Private _codDoc As String
    Private _nroDoc As String
    Private _codPer As String
    Private _añoDif As String
    Private _mesDif As String

    Public Property FeAño() As String
        Get
            Return _feAño
        End Get
        Set(ByVal value As String)
            _feAño = value
        End Set
    End Property

    Public Property FeMes() As String
        Get
            Return _feMes
        End Get
        Set(ByVal value As String)
            _feMes = value
        End Set
    End Property

    Public Property CodDoc() As String
        Get
            Return _codDoc
        End Get
        Set(ByVal value As String)
            _codDoc = value
        End Set
    End Property

    Public Property NroDoc() As String
        Get
            Return _nroDoc
        End Get
        Set(ByVal value As String)
            _nroDoc = value
        End Set
    End Property

    Public Property CodPer() As String
        Get
            Return _codPer
        End Get
        Set(ByVal value As String)
            _codPer = value
        End Set
    End Property

    Public Property AñoDis() As String
        Get
            Return _añoDif
        End Get
        Set(ByVal value As String)
            _añoDif = value
        End Set
    End Property

    Public Property MesDis() As String
        Get
            Return _mesDif
        End Get
        Set(ByVal value As String)
            _mesDif = value
        End Set
    End Property


End Class
