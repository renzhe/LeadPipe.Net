﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectExtensions.cs" company="Lead Pipe Software">
//   Copyright (c) Lead Pipe Software All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace LeadPipe.Net.Extensions
{
	/// <summary>
	/// The object extensions.
	/// </summary>
	public static class ObjectExtensions
	{
		#region Public Methods and Operators

		/// <summary>
		/// Gets a property value.
		/// </summary>
		/// <param name="obj">The source.</param>
		/// <param name="property">The property.</param>
		/// <returns>The value of the property.</returns>
		public static object GetPropertyValue(this object obj, string property)
		{
			return TypeDescriptor.GetProperties(obj)[property].GetValue(obj);
		}

		/// <summary>
		/// Determines whether the specified object is not null.
		/// </summary>
		/// <typeparam name="T">The type of the object to check.</typeparam>
		/// <param name="obj">The object to check.</param>
		/// <returns>
		///   <c>true</c> if the specified object is not null; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNotNull<T>(this T obj)
		{
			return obj != null;
		}

		/// <summary>
		/// Determines whether the specified object is null.
		/// </summary>
		/// <typeparam name="T">The type of the object to check.</typeparam>
		/// <param name="obj">The object to check.</param>
		/// <returns>
		///   <c>true</c> if the specified object is null; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNull<T>(this T obj)
		{
			return obj == null;
		}

		/// <summary>
		/// Returns the first non-null value of an object.
		/// </summary>
		/// <remarks>
		/// This is comparable to Coalesce in SQL Server.
		/// </remarks>
		/// <typeparam name="T">The type of the object to check.</typeparam>
		/// <param name="obj">The object to check.</param>
		/// <param name="otherValues">The other values.</param>
		/// <returns>The first non-null value of an object.</returns>
		public static T OrElse<T>(this T obj, params T[] otherValues)
		{
			return obj.IsNotNull()
				? obj
				: otherValues.FirstOrDefault(value => value.IsNotNull());
		}

		/// <summary>
		/// Returns the object as a dictionary of properties and values.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <returns>A dictionary of properties and values.</returns>
		public static IDictionary<string, object> ToDictionary(this object obj)
		{
			IDictionary<string, object> result = new Dictionary<string, object>();

			var properties = TypeDescriptor.GetProperties(obj);

			foreach (PropertyDescriptor property in properties)
			{
				result.Add(property.Name, property.GetValue(obj));
			}

			return result;
		}

		#endregion
	}
}