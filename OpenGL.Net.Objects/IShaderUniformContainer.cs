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
	/// <summary>
	/// Interface implemented by those classes able to store uniform values.
	/// </summary>
	public interface IShaderUniformContainer
	{
		/// <summary>
		/// Determine whether an uniform is active or not.
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> which specify the uniform name.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the specified uniform is currently active.
		/// </returns>
		bool IsActiveUniform(string uniformName);

		#region Set Uniform (single-precision floating-point vector data)

		/// <summary>
		/// Set uniform state variable (floating-point variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Single"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, float v);

		/// <summary>
		/// Set uniform state variable (vec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex2f"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex2f v);

		/// <summary>
		/// Set uniform state variable (vec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3f"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex3f v);

		/// <summary>
		/// Set uniform state variable (vec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex4f v);

		/// <summary>
		/// Set uniform state variable (array of vec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Single[]"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, float[] v);

		/// <summary>
		/// Set uniform state variable (array of vec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex2f[]"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex2f[] v);

		/// <summary>
		/// Set uniform state variable (array of vec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3f[]"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex3f[] v);

		/// <summary>
		/// Set uniform state variable (array of vec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4f[]"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex4f[] v);

		/// <summary>
		/// Set uniform state variable (vec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="ColorRGBAF"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, ColorRGBAF v);

		/// <summary>
		/// Set uniform state variable (array of vec4 variables).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="ColorRGBAF[]"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, ColorRGBAF[] v);

		#endregion

		#region Set Uniform (integer vector data)

		/// <summary>
		/// Set uniform state variable (int variable or bool variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Int32"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, int v);

		/// <summary>
		/// Set uniform state variable (ivec2 variable or bvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex2i"/> holding the uniform variabile data (first component).
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex2i v);

		/// <summary>
		/// Set uniform state variable (ivec3 variable or bvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3i"/> holding the uniform variabile data (first component).
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex3i v);

		/// <summary>
		/// Set uniform state variable (ivec4 variable or bvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4i"/> holding the uniform variabile data (first component).
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex4i v);

		#endregion

		#region Set Uniform (unsigned integer vector variant)

		/// <summary>
		/// Set uniform state variable (uint variable or bool variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="UInt32"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, uint v);

		/// <summary>
		/// Set uniform state variable (uvec2 variable or bvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex2ui"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex2ui v);

		/// <summary>
		/// Set uniform state variable (uvec3 variable or bvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3ui"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex3ui v);

		/// <summary>
		/// Set uniform state variable (uvecu variable or bvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4ui"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex4ui v);

		#endregion

		#region Set Uniform (boolean vector data)

		/// <summary>
		/// Set uniform state variable (boolean variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Boolean"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, bool v);

		/// <summary>
		/// Set uniform state variable (bvec2 variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the uniform variabile data (second component).
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, bool x, bool y);

		/// <summary>
		/// Set uniform state variable (bvec3 variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="UInt32"/> holding the uniform variabile data (third component).
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, bool x, bool y, bool z);

		/// <summary>
		/// Set uniform state variable (bvec4 variable or similar).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="x">
		/// A <see cref="UInt32"/> holding the uniform variabile data (first component).
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/> holding the uniform variabile data (second component).
		/// </param>
		/// <param name="z">
		/// A <see cref="UInt32"/> holding the uniform variabile data (third component).
		/// </param>
		/// <param name="w">
		/// A <see cref="UInt32"/> holding the uniform variabile data (fourth component).
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, bool x, bool y, bool z, bool w);

		#endregion

		#region Set/Get Uniform (single-precision floating-point matrix data)

		/// <summary>
		/// Set uniform state variable (mat* variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Matrix m);

		/// <summary>
		/// Set uniform state variable (mat3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix3x3"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Matrix3x3 m);

		/// <summary>
		/// Set uniform state variable (mat3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix3x3f"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Matrix3x3f m);

		/// <summary>
		/// Set uniform state variable (mat4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Matrix4x4 m);

		/// <summary>
		/// Set uniform state variable (mat4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4f"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Matrix4x4f m);

		#endregion

		#region Set/Get Uniform (sampler-compatible data)

		/// <summary>
		/// Set uniform state variable (sampler1D, sampler2D, sampler3D, samplerCube variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="texture">
		/// A <see cref="Texture"/> holding the uniform variabile data (the texture name).
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Texture texture);

		#endregion

		#region Set Uniform (double-precision floating-point vector data)

		/// <summary>
		/// Set uniform state variable (double variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Double"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, double v);

		/// <summary>
		/// Set uniform state variable (dvec2 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex2d"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex2d v);

		/// <summary>
		/// Set uniform state variable (dvec3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex3d"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex3d v);

		/// Set uniform state variable (dvec4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Vertex4d"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, Vertex4d v);

		#endregion

		#region Set Uniform (double-precision floating-point matrix data)

		/// <summary>
		/// Set uniform state variable (mat3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="MatrixDouble"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, MatrixDouble m);

		/// <summary>
		/// Set uniform state variable (dmat3 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="MatrixDouble3x3"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, MatrixDouble3x3 m);

		/// <summary>
		/// Set uniform state variable (dmat4 variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="m">
		/// A <see cref="MatrixDouble4x4"/> holding the uniform variabile data.
		/// </param>
		void SetUniform(GraphicsContext ctx, string uniformName, MatrixDouble4x4 m);

		#endregion

		#region Set Uniform (generic object)

		/// <summary>
		/// Set uniform state variable (any known object type).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="value">
		/// A <see cref="Object"/> holding the uniform variabile data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="uniformName"/> is null.
		/// </exception>
		void SetUniform(GraphicsContext ctx, string uniformName, object value);

		#endregion
	}
}
