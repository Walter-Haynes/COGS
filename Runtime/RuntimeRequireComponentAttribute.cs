﻿using System;
using UnityEngine;

namespace Lazlo.Gocs
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public sealed class RuntimeRequireComponentAttribute : Attribute
	{
		public Type componentType { get; }

		public RuntimeRequireComponentAttribute(Type componentType)
		{
			if (componentType == null)
			{
				throw new ArgumentNullException(nameof(componentType));
			}

			if (!typeof(Component).IsAssignableFrom(componentType))
			{
				throw new ArgumentException("Type must be a component.", nameof(componentType));
			}

			this.componentType = componentType;
		}
	}
}