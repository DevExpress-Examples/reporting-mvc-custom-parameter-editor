Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraReports.Native

Namespace CustomReportParameterType.Services
	Public Class CustomDataSerializer
		Implements IDataSerializer

		Public Const Name As String = "myCustomDataSerializer"

		Public Function CanDeserialize(
									  ByVal value As String, ByVal typeName As String,
									  ByVal extensionProvider As Object
									  ) As Boolean Implements IDataSerializer.CanDeserialize
			Return typeName = GetType(CustomParameterType).FullName
		End Function

		Public Function CanSerialize(
									ByVal data As Object,
									ByVal extensionProvider As Object
									) As Boolean Implements IDataSerializer.CanSerialize
			Return TypeOf data Is CustomParameterType
		End Function

		Public Function Deserialize(
								   ByVal value As String,
								   ByVal typeName As String,
								   ByVal extensionProvider As Object
								   ) As Object Implements IDataSerializer.Deserialize
			If typeName = GetType(CustomParameterType).FullName Then
				Return New CustomParameterType With {.Value = value}
			End If
			Return Nothing
		End Function

		Public Function Serialize(
								 ByVal data As Object,
								 ByVal extensionProvider As Object
								 ) As String Implements IDataSerializer.Serialize
			Dim parameter = TryCast(data, CustomParameterType)
			Return If(parameter IsNot Nothing, parameter.Value, Nothing)
		End Function
	End Class
End Namespace
