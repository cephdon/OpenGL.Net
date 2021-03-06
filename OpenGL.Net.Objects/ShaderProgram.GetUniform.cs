﻿
// Copyright (C) 2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;

namespace OpenGL.Objects
{
	public partial class ShaderProgram
	{
		#region Get Uniform (single-precision floating-point vector data)

		/// <summary>
		/// Get uniform value (float variable or bool variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Single"/> holding the returned uniform variabile data.
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out float v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.FLOAT, Gl.BOOL);

			float[] value = new float[4];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			v = value[0];
		}

		/// <summary>
		/// Get uniform value (vec2 variable or bvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Single"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/> holding the returned uniform variabile data (second component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out float x, out float y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.FLOAT_VEC2, Gl.BOOL_VEC2);

			float[] value = new float[4];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
		}

		/// <summary>
		/// Get uniform value (vec3 variable or bvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Single"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/> holding the returned uniform variabile data (third component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out float x, out float y, out float z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.FLOAT_VEC3, Gl.BOOL_VEC3);

			float[] value = new float[4];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
		}

		/// <summary>
		/// Get uniform value (vec4 variable or bvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Single"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/> holding the returned uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="Single"/> holding the returned uniform variabile data (fourth component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out float x, out float y, out float z, out float w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);
			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.FLOAT_VEC4, Gl.BOOL_VEC4);

			float[] value = new float[4];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
			w = value[3];
		}

		#endregion

		#region Get Uniform (integer vector data)

		/// <summary>
		/// Get uniform value (int variable or bool variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Int32"/> holding the returned uniform variabile data.
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out int v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.INT, Gl.BOOL);

			int[] value = new int[1];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			v = value[0];
		}

		/// <summary>
		/// Get uniform value (ivec2 variable or bvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (second component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out int x, out int y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.INT_VEC2, Gl.BOOL_VEC2);

			int[] value = new int[2];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
		}

		/// <summary>
		/// Get uniform value (ivec3 variable or bvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (third component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out int x, out int y, out int z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.INT_VEC3, Gl.BOOL_VEC3);

			int[] value = new int[3];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
		}

		/// <summary>
		/// Get uniform value (ivec4 variable or bvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="Int32"/> holding the returned uniform variabile data (fourth component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out int x, out int y, out int z, out int w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.INT_VEC4, Gl.BOOL_VEC4);

			int[] value = new int[4];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
			w = value[3];
		}

		#endregion

		#region Get Uniform (unsigned integer vector data)

		/// <summary>
		/// Get uniform value (uint variable or bool variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data.
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out uint v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.UNSIGNED_INT, Gl.BOOL);

			uint[] value = new uint[1];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			v = value[0];
		}

		/// <summary>
		/// Get uniform value (uvec2 variable or bvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (second component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out uint x, out uint y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.UNSIGNED_INT_VEC2, Gl.BOOL_VEC2);

			uint[] value = new uint[2];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
		}

		/// <summary>
		/// Get uniform value (uvec3 variable or bvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (third component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out uint x, out uint y, out uint z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.UNSIGNED_INT_VEC3, Gl.BOOL_VEC3);

			uint[] value = new uint[3];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
		}

		/// <summary>
		/// Get uniform value (uvec4 variable or bvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="UInt32"/> holding the returned uniform variabile data (fourth component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out uint x, out uint y, out uint z, out uint w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.UNSIGNED_INT_VEC4, Gl.BOOL_VEC4);

			uint[] value = new uint[4];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
			w = value[3];
		}

		#endregion

		#region Get Uniform (boolean vector data)

		/// <summary>
		/// Get uniform value (boolean variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data.
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out bool v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.BOOL);

			int[] value = new int[1];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			v = value[0] != 0;
		}

		/// <summary>
		/// Get uniform value (boolean variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (second component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out bool x, out bool y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.BOOL_VEC2);

			int[] value = new int[2];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0] != 0;
			y = value[1] != 0;
		}

		/// <summary>
		/// Get uniform value (boolean variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (third component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out bool x, out bool y, out bool z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.BOOL_VEC3);

			int[] value = new int[3];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0] != 0;
			y = value[1] != 0;
			z = value[1] != 0;
		}

		/// <summary>
		/// Get uniform value (boolean variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="Boolean"/> holding the returned uniform variabile data (fourth component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out bool x, out bool y, out bool z, out bool w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.BOOL_VEC4);

			int[] value = new int[4];

			// Get uniform value (using int variant)
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0] != 0;
			y = value[1] != 0;
			z = value[1] != 0;
			w = value[1] != 0;
		}

		#endregion

		#region Get Uniform (double-precision floating-point vector data)

		/// <summary>
		/// Get uniform value (double variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Double"/> holding the returned uniform variabile data.
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out double v)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.DOUBLE);

			double[] value = new double[1];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			v = value[0];
		}

		/// <summary>
		/// Get uniform value (dvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Double"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/> holding the returned uniform variabile data (second component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out double x, out double y)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.DOUBLE_VEC2);

			double[] value = new double[2];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
		}

		/// <summary>
		/// Get uniform value (dvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Double"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Double"/> holding the returned uniform variabile data (third component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out double x, out double y, out double z)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.DOUBLE_VEC3);

			double[] value = new double[3];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
		}

		/// <summary>
		/// Get uniform value (dvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="Double"/> holding the returned uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/> holding the returned uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="Double"/> holding the returned uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="Double"/> holding the returned uniform variabile data (fourth component).
		/// </param>
		public void GetUniform(GraphicsContext ctx, string uniformName, out double x, out double y, out double z, out double w)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			UniformBinding uniform = GetUniform(ctx, uniformName);

			if (uniform == null || uniform.Location == -1)
				throw new InvalidOperationException(String.Format("uniform {0} is not active", uniformName));

			CheckUniformType(uniform, Gl.DOUBLE_VEC4);

			double[] value = new double[4];

			// Set uniform value
			Gl.GetUniform(ObjectName, uniform.Location, value);

			x = value[0];
			y = value[1];
			z = value[2];
			w = value[3];
		}

		#endregion
	}
}
