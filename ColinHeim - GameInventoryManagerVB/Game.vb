Option Explicit On
Option Strict On
Option Infer Off
Public Class Game

    'declare variables for Name, Publisher, Year, Sealed/Unsealed, and Region

    Private strGameName As String
    Private strGamePublisher As String
    Private intGameYear As Integer
    Private boolSealed As Boolean
    Private strGameRegion As String

    ' default constructor
    ' Defines a default constructor for the Game class that initializes strGameName, strGamePublisher, intGameYear, boolSealed, strGameRegion
    Public Sub New()
        strGameName = ""
        strGamePublisher = ""
        intGameYear = 0
        boolSealed = False
        strGameRegion = ""
    End Sub

    ' parameterized constructor
    ' assigns the values of strGameName, strGamePublisher, intGameYear, boolSealed, strGameRegion using the values passed to the constructor
    Public Sub New(Name As String, Publisher As String, Year As Integer, Sealed As Boolean, Region As String)
        strGameName = Name
        strGamePublisher = Publisher
        intGameYear = Year
        boolSealed = Sealed
        strGameRegion = Region
    End Sub


    'Name with get and set accessors.
    Public Property Name As String
        Get
            Return strGameName
        End Get
        Set(value As String)
            If Not String.IsNullOrWhiteSpace(value) Then
                strGameName = value
            Else
                Throw New ArgumentException("Game name cannot be blank.")
            End If
        End Set
    End Property



    'Publisher with get and set accessors.
    Public Property Publisher As String
        Get
            Return strGamePublisher
        End Get
        Set(value As String)
            If Not String.IsNullOrWhiteSpace(value) Then
                strGamePublisher = value
            Else
                Throw New ArgumentException("Publisher name cannot be blank.")
            End If
        End Set
    End Property

    'Year with get and set accessors.
    Public Property Year As Integer
        Get
            Return intGameYear
        End Get
        Set(value As Integer) 'set value of intGameYear
            If value > 2000 AndAlso value < 2013 Then 'the first ps2 game was made in 2000 and the last ps2 game was made in 2013
                intGameYear = value
            Else
                Throw New ArgumentException("Year must be greater than 1970.")
            End If
        End Set
    End Property

    'Sealed with get and set accessors.
    Public Property Sealed As Boolean
        Get
            Return boolSealed
        End Get
        Set(value As Boolean)
            boolSealed = value
        End Set
    End Property

    'Region with get and set accessors.
    Public Property Region As String
        Get
            Return strGameRegion
        End Get
        Set(value As String)
            If Not String.IsNullOrWhiteSpace(value) Then
                strGameRegion = value
            Else
                Throw New ArgumentException("Game region cannot be blank.")
            End If
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return strGameName + "(" + Year.ToString() + ")"
    End Function

End Class
