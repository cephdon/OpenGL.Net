
// Copyright (C) 2009-2016 Luca Piccioni
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
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenGL.Objects
{
	/// <summary>
	/// Texture.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Textures are object holding a set of data, that can be accessed within a shader using a set of coordinates. Textures classes
	/// derives from <see cref="Texture"/>, which define a base implementation without specifying the texture dimensionality.
	/// </para>
	/// <para>
	/// Texture can be one dimensional (<see cref="Texture1d"/>), two dimensional (<see cref="Texture2d"/>), three dimensional
	/// (<see cref="Texture3d"/>), cube mapped (<see cref="TextureCube"/>).
	/// </para>
	/// </remarks>
	[DebuggerDisplay("Texture: Pixel={PixelLayout}")]
	public abstract class Texture : GraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a Texture.
		/// </summary>
		protected Texture()
		{
			// Link sampler parameters (not really a sampler)
			LinkResource(_Sampler);
		}

		#endregion

		#region Texture Properties

		/// <summary>
		/// Texture pixel format (internal format).
		/// </summary>
		public PixelLayout PixelLayout
		{
			get
			{
				if (_Mipmaps == null)
					return (PixelLayout.None);

				if (_Mipmaps[MipmapBaseLevel] == null)
					throw new InvalidOperationException("undefined base level");

				return (_Mipmaps[MipmapBaseLevel].InternalFormat);
			}
		}

		/// <summary>
		/// Texture size, in pixels, of the base level of the texture.
		/// </summary>
		public virtual Vertex3ui BaseSize
		{
			get
			{
				if (_Mipmaps == null)
					return (Vertex3ui.Zero);
				if (_Mipmaps[0] != null)
					return (_Mipmaps[0].Size);

				for (int i = 0; i < _Mipmaps.Length; i++) {
					if (_Mipmaps[i] == null)
						continue;

					return (_Mipmaps[i].Size * (uint)Math.Pow(2.0, i));
				}

				return (Vertex3ui.Zero);
			}
		}

		/// <summary>
		/// Texture size, in pixels, of the base level of the texture.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the mipmap level specified by <see cref="MipmapBaseLevel"/> is not defined.
		/// </exception>
		public Vertex3ui Size
		{
			get
			{
				if (_Mipmaps == null)
					return (Vertex3ui.Zero);

				if (_Mipmaps[MipmapBaseLevel] == null)
					throw new InvalidOperationException("undefined base level");

				return (_Mipmaps[MipmapBaseLevel].Size);
			}
		}

		/// <summary>
		/// Texture width, in pixels, of the base level of the texture.
		/// </summary>
		public uint Width { get { return (Size.x); } }

		/// <summary>
		/// Texture height, in pixels, of the base level of the texture.
		/// </summary>
		/// <remarks>
		/// In case the Texture implementation does not have two or more dimension, it shall return 1.
		/// </remarks>
		public uint Height { get { return (Size.y); } }

		/// <summary>
		/// Texture depth, in pixels, of the base level of the texture.
		/// </summary>
		/// <remarks>
		/// In case the Texture implementation does not have three or more dimension, it shall return 1.
		/// </remarks>
		public uint Depth { get { return (Size.z); } }

		/// <summary>
		/// Define texture mipmap level properties.
		/// </summary>
		/// <param name="pixelFormat">
		/// The <see cref="PixelLayout"/> that specify the texture mipmap internal format.
		/// </param>
		/// <param name="w">
		/// A <see cref="UInt32"/> that specify the width of the texture mipmap.
		/// </param>
		/// <param name="h">
		/// A <see cref="UInt32"/> that specify the height of the texture mipmap.
		/// </param>
		/// <param name="z">
		/// A <see cref="UInt32"/> that specify the depth of the texture mipmap.
		/// </param>
		/// <param name="lod">
		/// A <see cref="UInt32"/> that specify the level texture mipmap.
		/// </param>
		protected void DefineExtents(PixelLayout pixelFormat, uint w, uint h, uint z, uint lod)
		{
			if (pixelFormat == PixelLayout.None)
				throw new ArgumentException("invalid pixel format", "pixelFormat");
			// Define mipmaps array
			if (_Mipmaps == null)
				_Mipmaps = new Mipmap[GetMipmapLevels(w, h, z, lod)];

			if (_Mipmaps[lod] == null)
				_Mipmaps[lod] = new Mipmap();
			_Mipmaps[lod].InternalFormat = pixelFormat;
			_Mipmaps[lod].Size = new Vertex3ui(w, h, z);
		}

		/// <summary>
		/// Get whether this Texture is immutable (GL_ARB_texture_storage support).
		/// </summary>
		public bool Immutable
		{
			get { return (_Immutable); }
			set
			{
				if (ObjectName != InvalidObjectName)
					throw new InvalidOperationException("object already defined");
				_Immutable = value;
			}
		}

		/// <summary>
		/// Flag indicating whether this Texture is immutable (GL_ARB_texture_storage).
		/// </summary>
		private bool _Immutable;

		#endregion

		#region Capability Support

		/// <summary>
		/// Check whether the texture extents are compatible with context capabilities.
		/// </summary>
		/// <param name="caps">
		/// A <see cref="GraphicsCapabilities"/> determining the underlying texture capabilities.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the texture height.
		/// </param>
		/// <param name="depth">
		/// A <see cref="UInt32"/> that specify the texture depth.
		/// </param>
		/// <param name="format">
		/// A <see cref="OpenGL.PixelLayout"/> that specify the texture internal format.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="caps"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/>, <paramref name="height"/> or <paramref name="depth"/> is greater than
		/// the maximum allowed for the specific texture target.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by <paramref name="caps"/>, and <paramref name="width"/>, <paramref name="height"/>
		/// or <paramref name="depth"/> is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		private void CheckCapabilities(uint width, uint height, uint depth, PixelLayout format)
		{
			// Texture maximum size
			switch (TextureTarget) {
				case TextureTarget.Texture1d:
					if (width > Gl.CurrentLimits.MaxTexture2DSize)
						throw new ArgumentException(String.Format("width greater than maximum allowed ({0})", Gl.CurrentLimits.MaxTexture2DSize));
					break;
				case TextureTarget.Texture2d:
					if (width > Gl.CurrentLimits.MaxTexture2DSize)
						throw new ArgumentException(String.Format("width greater than maximum allowed ({0})", Gl.CurrentLimits.MaxTexture2DSize));
					if (height > Gl.CurrentLimits.MaxTexture2DSize)
						throw new ArgumentException(String.Format("height greater than maximum allowed ({0})", Gl.CurrentLimits.MaxTexture2DSize));
					break;
				case TextureTarget.TextureRectangle:
					if (width > Gl.CurrentLimits.MaxTextureRectSize)
						throw new ArgumentException(String.Format("width greater than maximum allowed ({0})", Gl.CurrentLimits.MaxTextureRectSize));
					if (height > Gl.CurrentLimits.MaxTextureRectSize)
						throw new ArgumentException(String.Format("height greater than maximum allowed ({0})", Gl.CurrentLimits.MaxTextureRectSize));
					break;
				case TextureTarget.Texture3d:
					if (width > Gl.CurrentLimits.MaxTexture3DSize)
						throw new ArgumentException(String.Format("width greater than maximum allowed ({0})", Gl.CurrentLimits.MaxTexture3DSize));
					if (height > Gl.CurrentLimits.MaxTexture3DSize)
						throw new ArgumentException(String.Format("height greater than maximum allowed ({0})", Gl.CurrentLimits.MaxTexture3DSize));
					if (depth > Gl.CurrentLimits.MaxTexture3DSize)
						throw new ArgumentException(String.Format("depth greater than maximum allowed ({0})", Gl.CurrentLimits.MaxTexture3DSize));
					break;
				case TextureTarget.TextureCubeMap:
					if (width > Gl.CurrentLimits.MaxTextureCubeSize)
						throw new ArgumentException(String.Format("width greater than maximum allowed ({0})", Gl.CurrentLimits.MaxTextureCubeSize));
					if (height > Gl.CurrentLimits.MaxTextureCubeSize)
						throw new ArgumentException(String.Format("height greater than maximum allowed ({0})", Gl.CurrentLimits.MaxTextureCubeSize));
					break;
				default:
					throw new NotImplementedException("not implemented checks on texture " + GetType());
			}
			// Texture not-power-of-two
			if (Gl.CurrentExtensions.TextureNonPowerOfTwo_ARB == false) {
				if (IsPowerOfTwo(width) == false)
					throw new ArgumentException(String.Format("NPOT texture width not supported (width is {0})", width));
				if (IsPowerOfTwo(height) == false)
					throw new ArgumentException(String.Format("NPOT texture height not supported (height is {0})", height));
				if (IsPowerOfTwo(depth) == false)
					throw new ArgumentException(String.Format("NPOT texture depth not supported (height is {0})", height));
			}
			// Texture internal format
			if (format.IsSupportedInternalFormat() == false)
				throw new ArgumentException(String.Format("not supported texture internal format {0}", format), "format");
		}

		/// <summary>
		/// Determine whether an integer is a power-of-two value.
		/// </summary>
		/// <param name="x">
		/// A <see cref="UInt32"/> that specify the value to test.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="x"/> is a power-of-two value.
		/// </returns>
		private static bool IsPowerOfTwo(uint x)
		{
			return (x & (x - 1)) == 0;
		}

		/// <summary>
		/// Download Texture data to an Image instance.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for downloading texture data.
		/// </param>
		/// <param name="pixelType">
		/// A <see cref="OpenGL.PixelLayout"/> determining the pixel format of the downloaded data.
		/// </param>
		/// <param name="target">
		/// A <see cref="TextureTarget"/> that specify the texture target.
		/// </param>
		/// <param name="level">
		/// A <see cref="UInt32"/> that specify the texture level.
		/// </param>
		/// <returns>
		/// It return the <see cref="Image"/> holding the content of this texture.
		/// </returns>
		protected Image Get(GraphicsContext ctx, PixelLayout pixelType, TextureTarget target, uint level)
		{
			CheckCurrentContext(ctx);

			// Bind this Texture
			ctx.Bind(this);

			// Get texture extents
			int width, height;

			Gl.GetTexLevelParameter(TextureTarget, (int)level, GetTextureParameter.TextureWidth, out width);
			Gl.GetTexLevelParameter(TextureTarget, (int)level, GetTextureParameter.TextureHeight, out height);
			if ((width <= 0) || (height <= 0))
				throw new InvalidOperationException(String.Format("invalid texture extents {0}x{1}", width, height));

			// Create image
			Image image = new Image(pixelType, (uint)width, (uint)height);

			// Set pixel transfer
			foreach (int alignment in new int[] { 8, 4, 2, 1 }) {
				if (image.Stride % alignment == 0) {
					Gl.PixelStore(PixelStoreParameter.PackAlignment, alignment);
					break;
				}
			}

			// Download texture contents
			Gl.GetTexImage(target, (int)level, pixelType.GetGlFormat(), pixelType.GetPixelType(), image.ImageBuffer);

			return (image);
		}

		#endregion

		#region Mipmapping

		/// <summary>
		/// Get the level indicating the base mipmap level.
		/// </summary>
		public uint BaseLevel
		{
			get
			{
				return ((uint)Array.FindIndex(_Mipmaps, delegate (Mipmap item) { return (item != null); }));
			}
		}

		/// <summary>
		/// Get the level indicating the maximum mipmap level.
		/// </summary>
		public uint MaxLevel
		{
			get
			{
				return ((uint)Array.FindLastIndex(_Mipmaps, delegate (Mipmap item) { return (item != null); }));
			}
		}

		/// <summary>
		/// Determine whether a specific mipmap level is defined.
		/// </summary>
		/// <param name="level">
		/// A <see cref="UInt32"/> that specify the mipmap level to test.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the mipmap level <paramref name="level"/> is defined.
		/// </returns>
		public bool HasMipMapLevel(uint level)
		{
			return (_Mipmaps[level] != null);
		}

		/// <summary>
		/// Get or set the level indicating the base mipmap level used for drawing.
		/// </summary>
		public uint MipmapBaseLevel
		{
			get
			{
				return (_MipmapMinLevel >= 0 ? (uint)_MipmapMinLevel : 0);
			}
			set
			{
				if (value > MipmapMaxLevel)
					throw new InvalidOperationException("exceed maximum mipmap level");
				if (_MipmapMinLevel != (int)value)
					_MipmapMinLevelDirty = true;
				_MipmapMinLevel = (int)value;
			}
		}

		/// <summary>
		/// Get or set the level indicating the maximum mipmap level used for drawing.
		/// </summary>
		public uint MipmapMaxLevel
		{
			get
			{
				return (_MipmapMaxLevel >= 0 ? (uint)_MipmapMaxLevel : MipmapLevels);
			}
			set
			{
				if (value < MipmapBaseLevel)
					throw new InvalidOperationException("exceeded mipmap base level");
				if (value > MipmapLevels)
					throw new InvalidOperationException("exceeded mipmap levels count");
				if (_MipmapMaxLevel != (int)value)
					_MipmapMaxLevelDirty = true;
				_MipmapMaxLevel = (int)value;
			}
		}

		/// <summary>
		/// Get whether this Texture is mipmap-complete.
		/// </summary>
		public bool IsMipmapComplete
		{
			get
			{
				if (_Mipmaps == null)
					return (false);

				Debug.Assert(_Mipmaps.Length == MipmapLevels);

				uint mipmapBaseLevel = MipmapBaseLevel;
				
				for (uint i = MipmapBaseLevel; i < MipmapMaxLevel; i++) {
					// Mipmap level must be defined
					if (_Mipmaps[i] == null)
						return (false);
					// Same internal format (compare with the base level)
					if (_Mipmaps[i].InternalFormat != _Mipmaps[mipmapBaseLevel].InternalFormat)
						return (false);
					// The dimensions of the images follow the sequence described by GetMipmapSize
					if (_Mipmaps[i].Size != GetMipmapSize(i))
						return (false);
				}

				return (true);
			}
		}

		/// <summary>
		/// Mipmap properties.
		/// </summary>
		protected class Mipmap
		{
			/// <summary>
			/// Internal format of the mipmap.
			/// </summary>
			public PixelLayout InternalFormat;

			/// <summary>
			/// Size of the mipmap (width, height and depth components).
			/// </summary>
			public Vertex3ui Size;
		}

		/// <summary>
		/// Texture mipmaps level count (including the base level).
		/// </summary>
		/// <remarks>
		/// <para>
		/// If this texture is not defined, this property shall return 0.
		/// </para>
		/// <para>
		/// If texture target doesn't support mipmapping, this property shall return 1, if it is defined.
		/// </para>
		/// </remarks>
		protected virtual uint MipmapLevels
		{
			get
			{
				Vertex3ui baseSize = BaseSize;

				return (GetMipmapLevels(baseSize.x, baseSize.y, baseSize.z, 0));
			}
		}

		/// <summary>
		/// Get the texture mipmaps level count, given ipotethic texture size.
		/// </summary>
		/// <param name="w">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="h">
		/// A <see cref="UInt32"/> that specify the texture height.
		/// </param>
		/// <param name="z">
		/// A <see cref="UInt32"/> that specify the texture depth.
		/// </param>
		/// <returns></returns>
		protected static uint GetMipmapLevels(uint w, uint h, uint z, uint lod)
		{
			lod = (uint)Math.Pow(2.0, lod);
			w *= lod; h *= lod; z *= lod;

			uint maxSize = Math.Max(Math.Max(w, h), z);

			if (maxSize > 0)
				return (1 + (uint)Math.Floor(Math.Log(maxSize, 2.0)));
			else
				return (0);
		}

		/// <summary>
		/// Compute a texture mipmap size.
		/// </summary>
		/// <param name="lod">
		/// A <see cref="UInt32"/> that specify the mipmap level.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3ui"/> that contains the mipmap width, height and depth.
		/// </returns>
		protected Vertex3ui GetMipmapSize(uint lod)
		{
			Vertex3ui mipmapSize = BaseSize / (uint)Math.Pow(2.0, lod);

			mipmapSize.x = Math.Max(1, mipmapSize.x);
			mipmapSize.y = Math.Max(1, mipmapSize.y);
			mipmapSize.z = Math.Max(1, mipmapSize.z);

			return (mipmapSize);
		}

		internal void ApplyMipmapLevels(GraphicsContext ctx, bool force)
		{
			Debug.Assert(_MipmapMinLevel <= _MipmapMaxLevel);
			if (_MipmapMinLevel >= 0 || _MipmapMinLevelDirty)
				Gl.TexParameter(TextureTarget, (TextureParameterName)Gl.TEXTURE_BASE_LEVEL, _MipmapMinLevel);
			_MipmapMinLevelDirty = false;

			if (_MipmapMaxLevel >= 0 || _MipmapMaxLevelDirty)
				Gl.TexParameter(TextureTarget, (TextureParameterName)Gl.TEXTURE_MAX_LEVEL, _MipmapMaxLevel);
			_MipmapMaxLevelDirty = false;
		}

		/// <summary>
		/// Mipmaps properties.
		/// </summary>
		private Mipmap[] _Mipmaps;

		/// <summary>
		/// The index of the lowest (base) define mipmap level.
		/// </summary>
		private int _MipmapMinLevel = -1;

		/// <summary>
		/// Flag for indicating whether <see cref="_MipmapMinLevel"/> has changed.
		/// </summary>
		private bool _MipmapMinLevelDirty;

		/// <summary>
		/// The index of the highest (base) define mipmap level.
		/// </summary>
		private int _MipmapMaxLevel = -1;

		/// <summary>
		/// Flag for indicating whether <see cref="_MipmapMaxLevel"/> has changed.
		/// </summary>
		private bool _MipmapMaxLevelDirty;

		#endregion

		#region Automatic Mipmap Generation

		/// <summary>
		/// Request the creation of this Texture mipmaps.
		/// </summary>
		/// <remarks>
		/// This routine shall be called before Texture creation. In the case it is called after the texture has
		/// been created, it has not effect untill the texture is updated.
		/// </remarks>
		public void RequestMipmapsCreation()
		{
			_RequiresMipMaps = true;
		}

		/// <summary>
		/// Generate mipmaps for this Texture.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for generating texture mipmaps.
		/// </param>
		protected virtual void GenerateMipmaps(GraphicsContext ctx)
		{
			GenerateMipmaps(ctx, TextureTarget);
		}

		/// <summary>
		/// Generate mipmaps for this Texture, replacing mipmaps level from 1 to <see cref="MipmapLevels"/> - 1.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for mipmapping definition.
		/// </param>
		/// <param name="target">
		/// A <see cref="TextureTarget"/> indicating the target for generating
		/// bitmaps.
		/// </param>
		protected void GenerateMipmaps(GraphicsContext ctx, TextureTarget target)
		{
			CheckCurrentContext(ctx);

			// Bind this Texture
			ctx.Bind(this);
			// Generate mipmaps
			Gl.GenerateMipmap((int)target);

			Debug.Assert(_Mipmaps.Length >= MipmapLevels);
			for (uint i = MipmapBaseLevel + 1; i < MipmapLevels; i++) {
				if (_Mipmaps[i] == null)
					_Mipmaps[i] = new Mipmap();
				_Mipmaps[i].InternalFormat = _Mipmaps[MipmapBaseLevel].InternalFormat;
				_Mipmaps[i].Size = GetMipmapSize(i);
			}
		}

		/// <summary>
		/// Flag indicating whether this Texture shall ghave mipmaps created automatically at creationg time.
		/// </summary>
		private bool _RequiresMipMaps;

		#endregion

		#region Sampler

		/// <summary>
		/// The texture sampler.
		/// </summary>
		public Sampler Sampler
		{
			get
			{
				return (_SamplerObject ?? _Sampler);
			}
		}

		/// <summary>
		/// Texture sampler parameters.
		/// </summary>
		private readonly Sampler _Sampler = new Sampler(false);

		/// <summary>
		/// The <see cref="Sampler"/> overriding this Texture sampler parameters.
		/// </summary>
		private Sampler _SamplerObject;

		#endregion

		#region Swizzle

		/// <summary>
		/// Texture swizzled components.
		/// </summary>
		public enum Swizzle
		{
			/// <summary>
			/// Zero.
			/// </summary>
			Zero = Gl.ZERO,
			/// <summary>
			/// One.
			/// </summary>
			One = Gl.ONE,
			/// <summary>
			/// Red.
			/// </summary>
			Red = Gl.RED,
			/// <summary>
			/// Green.
			/// </summary>
			Green = Gl.GREEN,
			/// <summary>
			/// Blue.
			/// </summary>
			Blue = Gl.BLUE,
			/// <summary>
			/// Alpha.
			/// </summary>
			Alpha = Gl.ALPHA
		}

		/// <summary>
		/// Get or set the swizzle map for red component.
		/// </summary>
		public Swizzle SizzleRed { get { return (_TextelSwizzle[0]); } set { _TextelSwizzle[0] = value; } }

		/// <summary>
		/// Get or set the swizzle map for green component.
		/// </summary>
		public Swizzle SizzleGreen { get { return (_TextelSwizzle[1]); } set { _TextelSwizzle[1] = value; } }

		/// <summary>
		/// Get or set the swizzle map for blue component.
		/// </summary>
		public Swizzle SizzleBlue { get { return (_TextelSwizzle[2]); } set { _TextelSwizzle[2] = value; } }

		/// <summary>
		/// Get or set the swizzle map for alpha component.
		/// </summary>
		public Swizzle SizzleAlpha { get { return (_TextelSwizzle[3]); } set { _TextelSwizzle[3] = value; } }
		
		/// <summary>
		/// Apply texture swizzle, if required and supported.
		/// </summary>
		/// <param name="ctx"></param>
		internal void ApplySwizzle(GraphicsContext ctx)
		{
			if ((_TextelSwizzleRGBA != null) && (Gl.CurrentExtensions.TextureSwizzle_ARB)) {
				// Set components swizzle setup
				Gl.TexParameter(TextureTarget, (TextureParameterName)Gl.TEXTURE_SWIZZLE_RGBA, _TextelSwizzleRGBA);
			}
		}

		/// <summary>
		/// Texture textel swizzle setup.
		/// </summary>
		/// <remarks>
		/// When this member is set to null, no textel components swizzle is required.
		/// </remarks>
		private int[] _TextelSwizzleRGBA;

		/// <summary>
		/// Texture textel swizzle setup.
		/// </summary>
		/// <remarks>
		/// When this member is set to null, not textel components swizzle
		/// is required.
		/// </remarks>
		private readonly Swizzle[] _TextelSwizzle = new Swizzle[] { Swizzle.Red, Swizzle.Green, Swizzle.Blue, Swizzle.Alpha };

		#endregion

		#region Shader Uniform Binding

		/// <summary>
		/// Uniform sampler type for managing this Texture.
		/// </summary>
		internal abstract int SamplerType { get; }

		#endregion

		#region Technique

		/// <summary>
		/// Get whether the Texture has data to be updated.
		/// </summary>
		public bool IsDirty { get { return (_Techniques.Count > 0); } }

		/// <summary>
		/// Technique for creating Texture2d objects.
		/// </summary>
		protected abstract class Technique : IDisposable
		{
			/// <summary>
			/// Construct a Technique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture"/> affected by this Technique.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="texture"/> is null.
			/// </exception>
			public Technique(Texture texture)
			{
				if (texture == null)
					throw new ArgumentNullException("texture");
				_Texture = texture;
			}

			/// <summary>
			/// The <see cref="Texture"/> affected by this Technique.
			/// </summary>
			protected readonly Texture _Texture;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public abstract void Create(GraphicsContext ctx);

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public virtual void Dispose() { }
		}

		/// <summary>
		/// Set the technique used for creating and updating this Texture.
		/// </summary>
		/// <param name="technique">
		/// The <see cref="Technique"/> that specify the method creating/updating this Texture.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="technique"/> is null.
		/// </exception>
		protected void SetTechnique(Technique technique)
		{
			if (technique == null)
				throw new ArgumentNullException("technique");

			// Set technique
			_Techniques.Add(technique);
		}

		/// <summary>
		/// Technique used for creating this texture.
		/// </summary>
		private readonly List<Technique> _Techniques = new List<Technique>();

		/// <summary>
		/// Flag for releasing data on upload.
		/// </summary>
		private bool _TechniquesAutoRelease;

		#endregion

		#region Texture Units

		/// <summary>
		/// Determine the derived Texture target.
		/// </summary>
		/// <remarks>
		/// In the case a this Texture is defined by multiple targets (i.e. cube map textures), this property
		/// shall returns always 0.
		/// </remarks>
		public abstract TextureTarget TextureTarget { get; }

		/// <summary>
		/// Get the index of the default texture unit associated with this Texture. It is <see cref="UInt32.MaxValue"/>
		/// to indicate that no texture unit is associated with this Texture.
		/// </summary>
		public uint DefaultTextureUnit { get { return (_ActiveTextureUnits.Count > 0 ? _ActiveTextureUnits[0] : UInt32.MaxValue); } }

		/// <summary>
		/// Get the index of the texture unit associated with this Texture. IN the case the Texture has no texture unit associated,
		/// bound this Texture onto the most appropriate texture unit.
		/// </summary>
		/// <param name="ctx"></param>
		/// <returns></returns>
		public uint GetTextureUnit(GraphicsContext ctx)
		{
			uint textureUnitIndex = DefaultTextureUnit;

			if (textureUnitIndex == UInt32.MaxValue) {
				ctx.Bind(this);
				textureUnitIndex = DefaultTextureUnit;
			}

			return (textureUnitIndex);
		}

		/// <summary>
		/// Get the identifier of the binding point.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		internal int GetBindingTarget(GraphicsContext ctx)
		{
			// Cannot lazy binding on textures if GL_EXT_texture_object is not supported
			if (ctx.Extensions.TextureObject_EXT == false)
				return (0);

			// All-in-one implementation for all targets
			switch ((int)TextureTarget) {
				case Gl.TEXTURE_1D:
					return (Gl.TEXTURE_BINDING_1D);
				case Gl.TEXTURE_2D:
					return (Gl.TEXTURE_BINDING_2D);
				case Gl.TEXTURE_3D:
					return (Gl.TEXTURE_BINDING_3D);

				case Gl.TEXTURE_CUBE_MAP:
					return (Gl.TEXTURE_BINDING_CUBE_MAP);

				case Gl.TEXTURE_RECTANGLE:
					return (Gl.TEXTURE_BINDING_RECTANGLE);

				case Gl.TEXTURE_1D_ARRAY:
					return (Gl.TEXTURE_BINDING_1D_ARRAY);
				case Gl.TEXTURE_2D_ARRAY:
					return (Gl.TEXTURE_BINDING_2D_ARRAY);
				case Gl.TEXTURE_CUBE_MAP_ARRAY:
					return (Gl.TEXTURE_BINDING_CUBE_MAP_ARRAY);

				case Gl.TEXTURE_2D_MULTISAMPLE:
					return (Gl.TEXTURE_BINDING_2D_MULTISAMPLE);
				case Gl.TEXTURE_2D_MULTISAMPLE_ARRAY:
					return (Gl.TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY);

				default:
					throw new NotSupportedException(String.Format("texture target 0x{0:X2} not supported", (int)TextureTarget));
			}
		}

		/// <summary>
		/// Index of the active texture units on which this texture is bound.
		/// </summary>
		internal readonly List<uint> _ActiveTextureUnits = new List<uint>();

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Texture object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("0B0FA1F6-76B2-4B6A-B2B2-319D9E330FB1");

		/// <summary>
		/// Texture object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

		/// <summary>
		/// Determine whether this Texture really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this Texture exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this Texture (or is sharing with the creator).
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		public override bool Exists(GraphicsContext ctx)
		{
			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return (!ctx.Extensions.TextureObject_EXT || Gl.IsTexture(ObjectName));
		}

		/// <summary>
		/// Create a Texture name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this Texture.
		/// </returns>
		protected override uint CreateName(GraphicsContext ctx)
		{
			// Generate texture name
			return (Gl.GenTexture());
		}

		/// <summary>
		/// Delete a Texture name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="UInt32"/> that specify the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			// Delete texture name
			Gl.DeleteTextures(name);
		}

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);

			// Base implementation
			base.CreateObject(ctx);

			// Selects the texture unit for this texture
			ctx.Bind(this);

			// Determine whether to release texture data
			_TechniquesAutoRelease = ctx.Extensions.TextureObject_EXT;

			if (_Techniques.Count > 0) {
				// In the case of no techniques, texture will exists but it will be undefined
				foreach (Technique technique in _Techniques) {
					// Create/update texture using technique
					technique.Create(ctx);
					// Technique no more useful: dispose it
					if (_TechniquesAutoRelease)
						technique.Dispose();
				}

				if (_TechniquesAutoRelease)
					_Techniques.Clear();
			}

			// Generate mipmaps, if requested
			if (_RequiresMipMaps)
				GenerateMipmaps(ctx);
		}

		#endregion
	}
}
