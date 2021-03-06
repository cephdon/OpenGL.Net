
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_matrix_get", Api = "gles1")]
		public const int MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898D;

		/// <summary>
		/// Value of GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_matrix_get", Api = "gles1")]
		public const int PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898E;

		/// <summary>
		/// Value of GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_matrix_get", Api = "gles1")]
		public const int TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898F;

	}

}
