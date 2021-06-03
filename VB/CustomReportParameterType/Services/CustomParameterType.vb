Imports System
Imports System.ComponentModel
Imports System.Globalization

Namespace CustomReportParameterType.Services
	<TypeConverter(GetType(CustomParameterTypeConverter))>
	Public Class CustomParameterType
		Public Property Value() As String
		Public Overrides Function ToString() As String
			Return Value
		End Function
	End Class

	Public Class CustomParameterTypeConverter
		Inherits TypeConverter

		Public Overrides Function ConvertTo(
										   ByVal context As ITypeDescriptorContext,
										   ByVal culture As CultureInfo,
										   ByVal value As Object,
										   ByVal destinationType As Type) As Object
			If destinationType Is GetType(String) Then
				Return DirectCast(value, CustomParameterType).Value
			End If
			Return MyBase.ConvertTo(context, culture, value, destinationType)
		End Function
		Public Overrides Function CanConvertTo(
											  ByVal context As ITypeDescriptorContext,
											  ByVal destinationType As Type
											  ) As Boolean
			Return destinationType Is GetType(String) OrElse
				MyBase.CanConvertTo(context, destinationType)
		End Function

		Public Overrides Function CanConvertFrom(
												ByVal context As ITypeDescriptorContext,
												ByVal sourceType As Type
												) As Boolean
			Return sourceType Is GetType(String) OrElse
				MyBase.CanConvertFrom(context, sourceType)
		End Function
		Public Overrides Function ConvertFrom(
											 ByVal context As ITypeDescriptorContext,
											 ByVal culture As CultureInfo,
											 ByVal value As Object
											 ) As Object
			Dim valueString = TryCast(value, String)
			If valueString IsNot Nothing Then
				Return New CustomParameterType With {.Value = valueString}
			End If
			Return MyBase.ConvertFrom(context, culture, value)
		End Function
	End Class
End Namespace
