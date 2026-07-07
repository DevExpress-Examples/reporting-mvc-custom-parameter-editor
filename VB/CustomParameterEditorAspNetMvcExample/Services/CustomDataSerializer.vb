Imports System.ComponentModel
Imports DevExpress.Utils.Serializing

<TypeConverter(GetType(CustomParameterTypeConverter))>
Public Class CustomDataSerializer
    Implements IObjectDataSerializer

    Public Const Name As String = "myCustomDataSerializer"

    Public Function CanDeserialize(value As String, typeName As String) As Boolean _
        Implements IObjectDataSerializer.CanDeserialize

        Return typeName = GetType(CustomParameterType).FullName
    End Function

    Public Function CanSerialize(data As Object) As Boolean _
        Implements IObjectDataSerializer.CanSerialize

        Return TypeOf data Is CustomParameterType
    End Function

    Public Function Deserialize(value As String, typeName As String) As Object _
        Implements IObjectDataSerializer.Deserialize

        If typeName = GetType(CustomParameterType).FullName Then
            Return New CustomParameterType With {
                .Value = value
            }
        End If

        Return Nothing
    End Function

    Public Function Serialize(data As Object) As String _
        Implements IObjectDataSerializer.Serialize

        Dim parameter = TryCast(data, CustomParameterType)
        Return If(parameter IsNot Nothing, parameter.Value, Nothing)
    End Function

End Class