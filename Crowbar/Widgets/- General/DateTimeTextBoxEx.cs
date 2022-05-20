﻿//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;

namespace Crowbar
{
	public class DateTimeTextBoxEx : TextBoxEx
	{
#region Create and Destroy

		public DateTimeTextBoxEx() : base()
		{

			this.theTextBinding = null;

			this.DataBindings.CollectionChanged += DataBindings_CollectionChanged;
		}

		protected override void Dispose(bool disposing)
		{
			if (!this.IsDisposed)
			{
				if (disposing)
				{
					this.DataBindings.CollectionChanged -= DataBindings_CollectionChanged;
					if (this.theTextBinding != null)
					{
						this.RemoveBinding();
					}
					//Me.Free()
				}
			}
			base.Dispose(disposing);
		}

#endregion

#region Private Methods

		private void UpdateValue()
		{
			this.DataBindings["Text"].ReadValue();
		}

		private void InsertBinding(Binding aBinding)
		{
			aBinding.Format += this.Binding_Format;
			//'NOTE: Use Binding_Parse() instead of OnValidating() because OnValidating() is called after value has been saved to data source. 
			//AddHandler aBinding.Parse, AddressOf Me.Binding_Parse
			this.theTextBinding = aBinding;
			this.UpdateValue();
		}

		private void RemoveBinding()
		{
			this.theTextBinding.Format -= this.Binding_Format;
			//RemoveHandler Me.theTextBinding.Parse, AddressOf Me.Binding_Parse
			this.theTextBinding = null;
		}

		private void Binding_Format(object sender, ConvertEventArgs e)
		{
			if (e.DesiredType != typeof(string) || !(e.Value is long))
			{
				return;
			}

			long iUnixTimeStamp = Convert.ToInt64(e.Value);

			e.Value = this.GetFormattedValue(iUnixTimeStamp);
		}

		//Private Sub Binding_Parse(ByVal sender As Object, ByVal e As ConvertEventArgs)
		//	If e.DesiredType IsNot GetType(UnitlessProperty) Then
		//		Exit Sub
		//	End If

		//	Dim aBinding As Binding = CType(sender, Binding)
		//	Dim dataSourceType As Type = aBinding.DataSource.GetType()
		//	Dim dataMember As System.Reflection.PropertyInfo = dataSourceType.GetProperty(aBinding.BindingMemberInfo.BindingField)

		//	Dim aUnitlessProperty As UnitlessProperty
		//	aUnitlessProperty = CType(dataMember.GetValue(aBinding.DataSource, Nothing), UnitlessProperty)

		//	e.Value = Me.GetParsedValue(CStr(e.Value), aUnitlessProperty)
		//End Sub

		private string GetFormattedValue(long iUnixTimeStamp)
		{
			string valueString = MathModule.UnixTimeStampToDateTime(iUnixTimeStamp).ToShortDateString() + " " + MathModule.UnixTimeStampToDateTime(iUnixTimeStamp).ToShortTimeString();
			return valueString;
		}

		//Private Function GetParsedValue(ByVal valueString As String, ByVal aUnitlessProperty As UnitlessProperty) As UnitlessProperty
		//	Dim aValue As Double
		//	Try
		//		aValue = Double.Parse(valueString)
		//		If aValue < aUnitlessProperty.MinimumValue Then
		//			aValue = aUnitlessProperty.MinimumValue
		//		ElseIf aValue > aUnitlessProperty.MaximumValue Then
		//			aValue = aUnitlessProperty.MaximumValue
		//		End If
		//	Catch
		//		aValue = 0
		//	End Try
		//	aUnitlessProperty.Value = aValue

		//	Return aUnitlessProperty
		//End Function

#endregion

#region Core Event Handlers

#endregion

#region Widget Event Handlers

		protected void DataBindings_CollectionChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Add)
			{
				Binding aBinding = (Binding)e.Element;
				if (aBinding.PropertyName == "Text")
				{
					this.InsertBinding(aBinding);
				}
			}
			else if (e.Action == CollectionChangeAction.Remove)
			{
				Binding aBinding = (Binding)e.Element;
				if (aBinding == this.theTextBinding)
				{
					this.RemoveBinding();
				}
			}
			else if (e.Action == CollectionChangeAction.Refresh)
			{
				if (this.theTextBinding != null)
				{
					this.RemoveBinding();
				}
				foreach (Binding aBinding in this.DataBindings)
				{
					if (aBinding.PropertyName == "Text")
					{
						this.InsertBinding(aBinding);
					}
				}
			}
		}

#endregion

#region Data

		private Binding theTextBinding;

#endregion

	}

}