
// Copyright (C) 2015 Luca Piccioni
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

// Disable "'token' is obsolete" warnings
#pragma warning disable 618
using System;

namespace OpenCL
{
	/// <summary>
	/// Strongly typed enumeration ErrorCode.
	/// </summary>
	public enum ErrorCode : int
	{
		/// <summary>
		/// Strongly typed for value CL_SUCCESS.
		/// </summary>
		Success = Cl.SUCCESS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NOT_FOUND.
		/// </summary>
		DeviceNotFound = Cl.DEVICE_NOT_FOUND,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NOT_AVAILABLE.
		/// </summary>
		DeviceNotAvailable = Cl.DEVICE_NOT_AVAILABLE,

		/// <summary>
		/// Strongly typed for value CL_COMPILER_NOT_AVAILABLE.
		/// </summary>
		CompilerNotAvailable = Cl.COMPILER_NOT_AVAILABLE,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_ALLOCATION_FAILURE.
		/// </summary>
		MemObjectAllocationFailure = Cl.MEM_OBJECT_ALLOCATION_FAILURE,

		/// <summary>
		/// Strongly typed for value CL_OUT_OF_RESOURCES.
		/// </summary>
		OutOfResources = Cl.OUT_OF_RESOURCES,

		/// <summary>
		/// Strongly typed for value CL_OUT_OF_HOST_MEMORY.
		/// </summary>
		OutOfHostMemory = Cl.OUT_OF_HOST_MEMORY,

		/// <summary>
		/// Strongly typed for value CL_PROFILING_INFO_NOT_AVAILABLE.
		/// </summary>
		ProfilingInfoNotAvailable = Cl.PROFILING_INFO_NOT_AVAILABLE,

		/// <summary>
		/// Strongly typed for value CL_MEM_COPY_OVERLAP.
		/// </summary>
		MemCopyOverlap = Cl.MEM_COPY_OVERLAP,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_FORMAT_MISMATCH.
		/// </summary>
		ImageFormatMismatch = Cl.IMAGE_FORMAT_MISMATCH,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_FORMAT_NOT_SUPPORTED.
		/// </summary>
		ImageFormatNotSupported = Cl.IMAGE_FORMAT_NOT_SUPPORTED,

		/// <summary>
		/// Strongly typed for value CL_BUILD_PROGRAM_FAILURE.
		/// </summary>
		BuildProgramFailure = Cl.BUILD_PROGRAM_FAILURE,

		/// <summary>
		/// Strongly typed for value CL_MAP_FAILURE.
		/// </summary>
		MapFailure = Cl.MAP_FAILURE,

		/// <summary>
		/// Strongly typed for value CL_MISALIGNED_SUB_BUFFER_OFFSET.
		/// </summary>
		MisalignedSubBufferOffset = Cl.MISALIGNED_SUB_BUFFER_OFFSET,

		/// <summary>
		/// Strongly typed for value CL_EXEC_STATUS_ERROR_FOR_EVENTS_IN_WAIT_LIST.
		/// </summary>
		ExecStatusErrorForEventsInWaitList = Cl.EXEC_STATUS_ERROR_FOR_EVENTS_IN_WAIT_LIST,

		/// <summary>
		/// Strongly typed for value CL_COMPILE_PROGRAM_FAILURE.
		/// </summary>
		CompileProgramFailure = Cl.COMPILE_PROGRAM_FAILURE,

		/// <summary>
		/// Strongly typed for value CL_LINKER_NOT_AVAILABLE.
		/// </summary>
		LinkerNotAvailable = Cl.LINKER_NOT_AVAILABLE,

		/// <summary>
		/// Strongly typed for value CL_LINK_PROGRAM_FAILURE.
		/// </summary>
		LinkProgramFailure = Cl.LINK_PROGRAM_FAILURE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARTITION_FAILED.
		/// </summary>
		DevicePartitionFailed = Cl.DEVICE_PARTITION_FAILED,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_INFO_NOT_AVAILABLE.
		/// </summary>
		KernelArgInfoNotAvailable = Cl.KERNEL_ARG_INFO_NOT_AVAILABLE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_VALUE.
		/// </summary>
		InvalidValue = Cl.INVALID_VALUE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_DEVICE_TYPE.
		/// </summary>
		InvalidDeviceType = Cl.INVALID_DEVICE_TYPE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_PLATFORM.
		/// </summary>
		InvalidPlatform = Cl.INVALID_PLATFORM,

		/// <summary>
		/// Strongly typed for value CL_INVALID_DEVICE.
		/// </summary>
		InvalidDevice = Cl.INVALID_DEVICE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_CONTEXT.
		/// </summary>
		InvalidContext = Cl.INVALID_CONTEXT,

		/// <summary>
		/// Strongly typed for value CL_INVALID_QUEUE_PROPERTIES.
		/// </summary>
		InvalidQueueProperties = Cl.INVALID_QUEUE_PROPERTIES,

		/// <summary>
		/// Strongly typed for value CL_INVALID_COMMAND_QUEUE.
		/// </summary>
		InvalidCommandQueue = Cl.INVALID_COMMAND_QUEUE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_HOST_PTR.
		/// </summary>
		InvalidHostPtr = Cl.INVALID_HOST_PTR,

		/// <summary>
		/// Strongly typed for value CL_INVALID_MEM_OBJECT.
		/// </summary>
		InvalidMemObject = Cl.INVALID_MEM_OBJECT,

		/// <summary>
		/// Strongly typed for value CL_INVALID_IMAGE_FORMAT_DESCRIPTOR.
		/// </summary>
		InvalidImageFormatDescriptor = Cl.INVALID_IMAGE_FORMAT_DESCRIPTOR,

		/// <summary>
		/// Strongly typed for value CL_INVALID_IMAGE_SIZE.
		/// </summary>
		InvalidImageSize = Cl.INVALID_IMAGE_SIZE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_SAMPLER.
		/// </summary>
		InvalidSampler = Cl.INVALID_SAMPLER,

		/// <summary>
		/// Strongly typed for value CL_INVALID_BINARY.
		/// </summary>
		InvalidBinary = Cl.INVALID_BINARY,

		/// <summary>
		/// Strongly typed for value CL_INVALID_BUILD_OPTIONS.
		/// </summary>
		InvalidBuildOptions = Cl.INVALID_BUILD_OPTIONS,

		/// <summary>
		/// Strongly typed for value CL_INVALID_PROGRAM.
		/// </summary>
		InvalidProgram = Cl.INVALID_PROGRAM,

		/// <summary>
		/// Strongly typed for value CL_INVALID_PROGRAM_EXECUTABLE.
		/// </summary>
		InvalidProgramExecutable = Cl.INVALID_PROGRAM_EXECUTABLE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_KERNEL_NAME.
		/// </summary>
		InvalidKernelName = Cl.INVALID_KERNEL_NAME,

		/// <summary>
		/// Strongly typed for value CL_INVALID_KERNEL_DEFINITION.
		/// </summary>
		InvalidKernelDefinition = Cl.INVALID_KERNEL_DEFINITION,

		/// <summary>
		/// Strongly typed for value CL_INVALID_KERNEL.
		/// </summary>
		InvalidKernel = Cl.INVALID_KERNEL,

		/// <summary>
		/// Strongly typed for value CL_INVALID_ARG_INDEX.
		/// </summary>
		InvalidArgIndex = Cl.INVALID_ARG_INDEX,

		/// <summary>
		/// Strongly typed for value CL_INVALID_ARG_VALUE.
		/// </summary>
		InvalidArgValue = Cl.INVALID_ARG_VALUE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_ARG_SIZE.
		/// </summary>
		InvalidArgSize = Cl.INVALID_ARG_SIZE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_KERNEL_ARGS.
		/// </summary>
		InvalidKernelArgs = Cl.INVALID_KERNEL_ARGS,

		/// <summary>
		/// Strongly typed for value CL_INVALID_WORK_DIMENSION.
		/// </summary>
		InvalidWorkDimension = Cl.INVALID_WORK_DIMENSION,

		/// <summary>
		/// Strongly typed for value CL_INVALID_WORK_GROUP_SIZE.
		/// </summary>
		InvalidWorkGroupSize = Cl.INVALID_WORK_GROUP_SIZE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_WORK_ITEM_SIZE.
		/// </summary>
		InvalidWorkItemSize = Cl.INVALID_WORK_ITEM_SIZE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_GLOBAL_OFFSET.
		/// </summary>
		InvalidGlobalOffset = Cl.INVALID_GLOBAL_OFFSET,

		/// <summary>
		/// Strongly typed for value CL_INVALID_EVENT_WAIT_LIST.
		/// </summary>
		InvalidEventWaitList = Cl.INVALID_EVENT_WAIT_LIST,

		/// <summary>
		/// Strongly typed for value CL_INVALID_EVENT.
		/// </summary>
		InvalidEvent = Cl.INVALID_EVENT,

		/// <summary>
		/// Strongly typed for value CL_INVALID_OPERATION.
		/// </summary>
		InvalidOperation = Cl.INVALID_OPERATION,

		/// <summary>
		/// Strongly typed for value CL_INVALID_GL_OBJECT.
		/// </summary>
		InvalidGlObject = Cl.INVALID_GL_OBJECT,

		/// <summary>
		/// Strongly typed for value CL_INVALID_BUFFER_SIZE.
		/// </summary>
		InvalidBufferSize = Cl.INVALID_BUFFER_SIZE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_MIP_LEVEL.
		/// </summary>
		InvalidMipLevel = Cl.INVALID_MIP_LEVEL,

		/// <summary>
		/// Strongly typed for value CL_INVALID_GLOBAL_WORK_SIZE.
		/// </summary>
		InvalidGlobalWorkSize = Cl.INVALID_GLOBAL_WORK_SIZE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_PROPERTY.
		/// </summary>
		InvalidProperty = Cl.INVALID_PROPERTY,

		/// <summary>
		/// Strongly typed for value CL_INVALID_IMAGE_DESCRIPTOR.
		/// </summary>
		InvalidImageDescriptor = Cl.INVALID_IMAGE_DESCRIPTOR,

		/// <summary>
		/// Strongly typed for value CL_INVALID_COMPILER_OPTIONS.
		/// </summary>
		InvalidCompilerOptions = Cl.INVALID_COMPILER_OPTIONS,

		/// <summary>
		/// Strongly typed for value CL_INVALID_LINKER_OPTIONS.
		/// </summary>
		InvalidLinkerOptions = Cl.INVALID_LINKER_OPTIONS,

		/// <summary>
		/// Strongly typed for value CL_INVALID_DEVICE_PARTITION_COUNT.
		/// </summary>
		InvalidDevicePartitionCount = Cl.INVALID_DEVICE_PARTITION_COUNT,

		/// <summary>
		/// Strongly typed for value CL_INVALID_PIPE_SIZE.
		/// </summary>
		InvalidPipeSize = Cl.INVALID_PIPE_SIZE,

		/// <summary>
		/// Strongly typed for value CL_INVALID_DEVICE_QUEUE.
		/// </summary>
		InvalidDeviceQueue = Cl.INVALID_DEVICE_QUEUE,

	}

	/// <summary>
	/// Strongly typed enumeration Bool.
	/// </summary>
	public enum Bool
	{
		/// <summary>
		/// Strongly typed for value CL_FALSE.
		/// </summary>
		False = Cl.FALSE,

		/// <summary>
		/// Strongly typed for value CL_TRUE.
		/// </summary>
		True = Cl.TRUE,

		/// <summary>
		/// Strongly typed for value CL_BLOCKING.
		/// </summary>
		Blocking = Cl.BLOCKING,

		/// <summary>
		/// Strongly typed for value CL_NON_BLOCKING.
		/// </summary>
		NonBlocking = Cl.NON_BLOCKING,

	}

	/// <summary>
	/// Strongly typed enumeration PlatformInfo.
	/// </summary>
	public enum PlatformInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_PLATFORM_PROFILE.
		/// </summary>
		PlatformProfile = Cl.PLATFORM_PROFILE,

		/// <summary>
		/// Strongly typed for value CL_PLATFORM_VERSION.
		/// </summary>
		PlatformVersion = Cl.PLATFORM_VERSION,

		/// <summary>
		/// Strongly typed for value CL_PLATFORM_NAME.
		/// </summary>
		PlatformName = Cl.PLATFORM_NAME,

		/// <summary>
		/// Strongly typed for value CL_PLATFORM_VENDOR.
		/// </summary>
		PlatformVendor = Cl.PLATFORM_VENDOR,

		/// <summary>
		/// Strongly typed for value CL_PLATFORM_EXTENSIONS.
		/// </summary>
		PlatformExtensions = Cl.PLATFORM_EXTENSIONS,

		/// <summary>
		/// Strongly typed for value CL_PLATFORM_HOST_TIMER_RESOLUTION.
		/// </summary>
		PlatformHostTimerResolution = Cl.PLATFORM_HOST_TIMER_RESOLUTION,

	}

	/// <summary>
	/// Strongly typed enumeration DeviceType.
	/// </summary>
	[Flags()]
	public enum DeviceType : ulong
	{
		/// <summary>
		/// Strongly typed for value CL_DEVICE_TYPE_DEFAULT.
		/// </summary>
		DeviceTypeDefault = Cl.DEVICE_TYPE_DEFAULT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_TYPE_CPU.
		/// </summary>
		DeviceTypeCpu = Cl.DEVICE_TYPE_CPU,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_TYPE_GPU.
		/// </summary>
		DeviceTypeGpu = Cl.DEVICE_TYPE_GPU,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_TYPE_ACCELERATOR.
		/// </summary>
		DeviceTypeAccelerator = Cl.DEVICE_TYPE_ACCELERATOR,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_TYPE_CUSTOM.
		/// </summary>
		DeviceTypeCustom = Cl.DEVICE_TYPE_CUSTOM,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_TYPE_ALL.
		/// </summary>
		DeviceTypeAll = Cl.DEVICE_TYPE_ALL,

	}

	/// <summary>
	/// Strongly typed enumeration DeviceInfo.
	/// </summary>
	public enum DeviceInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_DEVICE_TYPE.
		/// </summary>
		DeviceType = Cl.DEVICE_TYPE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_VENDOR_ID.
		/// </summary>
		DeviceVendorId = Cl.DEVICE_VENDOR_ID,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_COMPUTE_UNITS.
		/// </summary>
		DeviceMaxComputeUnits = Cl.DEVICE_MAX_COMPUTE_UNITS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS.
		/// </summary>
		DeviceMaxWorkItemDimensions = Cl.DEVICE_MAX_WORK_ITEM_DIMENSIONS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_WORK_GROUP_SIZE.
		/// </summary>
		DeviceMaxWorkGroupSize = Cl.DEVICE_MAX_WORK_GROUP_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_WORK_ITEM_SIZES.
		/// </summary>
		DeviceMaxWorkItemSizes = Cl.DEVICE_MAX_WORK_ITEM_SIZES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR.
		/// </summary>
		DevicePreferredVectorWidthChar = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_CHAR,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT.
		/// </summary>
		DevicePreferredVectorWidthShort = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_SHORT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT.
		/// </summary>
		DevicePreferredVectorWidthInt = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_INT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG.
		/// </summary>
		DevicePreferredVectorWidthLong = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_LONG,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT.
		/// </summary>
		DevicePreferredVectorWidthFloat = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE.
		/// </summary>
		DevicePreferredVectorWidthDouble = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_CLOCK_FREQUENCY.
		/// </summary>
		DeviceMaxClockFrequency = Cl.DEVICE_MAX_CLOCK_FREQUENCY,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_ADDRESS_BITS.
		/// </summary>
		DeviceAddressBits = Cl.DEVICE_ADDRESS_BITS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_READ_IMAGE_ARGS.
		/// </summary>
		DeviceMaxReadImageArgs = Cl.DEVICE_MAX_READ_IMAGE_ARGS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_WRITE_IMAGE_ARGS.
		/// </summary>
		DeviceMaxWriteImageArgs = Cl.DEVICE_MAX_WRITE_IMAGE_ARGS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_MEM_ALLOC_SIZE.
		/// </summary>
		DeviceMaxMemAllocSize = Cl.DEVICE_MAX_MEM_ALLOC_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE2D_MAX_WIDTH.
		/// </summary>
		DeviceImage2dMaxWidth = Cl.DEVICE_IMAGE2D_MAX_WIDTH,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE2D_MAX_HEIGHT.
		/// </summary>
		DeviceImage2dMaxHeight = Cl.DEVICE_IMAGE2D_MAX_HEIGHT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE3D_MAX_WIDTH.
		/// </summary>
		DeviceImage3dMaxWidth = Cl.DEVICE_IMAGE3D_MAX_WIDTH,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE3D_MAX_HEIGHT.
		/// </summary>
		DeviceImage3dMaxHeight = Cl.DEVICE_IMAGE3D_MAX_HEIGHT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE3D_MAX_DEPTH.
		/// </summary>
		DeviceImage3dMaxDepth = Cl.DEVICE_IMAGE3D_MAX_DEPTH,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE_SUPPORT.
		/// </summary>
		DeviceImageSupport = Cl.DEVICE_IMAGE_SUPPORT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_PARAMETER_SIZE.
		/// </summary>
		DeviceMaxParameterSize = Cl.DEVICE_MAX_PARAMETER_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_SAMPLERS.
		/// </summary>
		DeviceMaxSamplers = Cl.DEVICE_MAX_SAMPLERS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MEM_BASE_ADDR_ALIGN.
		/// </summary>
		DeviceMemBaseAddrAlign = Cl.DEVICE_MEM_BASE_ADDR_ALIGN,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE.
		/// </summary>
		DeviceMinDataTypeAlignSize = Cl.DEVICE_MIN_DATA_TYPE_ALIGN_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_SINGLE_FP_CONFIG.
		/// </summary>
		DeviceSingleFpConfig = Cl.DEVICE_SINGLE_FP_CONFIG,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_GLOBAL_MEM_CACHE_TYPE.
		/// </summary>
		DeviceGlobalMemCacheType = Cl.DEVICE_GLOBAL_MEM_CACHE_TYPE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE.
		/// </summary>
		DeviceGlobalMemCachelineSize = Cl.DEVICE_GLOBAL_MEM_CACHELINE_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_GLOBAL_MEM_CACHE_SIZE.
		/// </summary>
		DeviceGlobalMemCacheSize = Cl.DEVICE_GLOBAL_MEM_CACHE_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_GLOBAL_MEM_SIZE.
		/// </summary>
		DeviceGlobalMemSize = Cl.DEVICE_GLOBAL_MEM_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE.
		/// </summary>
		DeviceMaxConstantBufferSize = Cl.DEVICE_MAX_CONSTANT_BUFFER_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_CONSTANT_ARGS.
		/// </summary>
		DeviceMaxConstantArgs = Cl.DEVICE_MAX_CONSTANT_ARGS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_LOCAL_MEM_TYPE.
		/// </summary>
		DeviceLocalMemType = Cl.DEVICE_LOCAL_MEM_TYPE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_LOCAL_MEM_SIZE.
		/// </summary>
		DeviceLocalMemSize = Cl.DEVICE_LOCAL_MEM_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_ERROR_CORRECTION_SUPPORT.
		/// </summary>
		DeviceErrorCorrectionSupport = Cl.DEVICE_ERROR_CORRECTION_SUPPORT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PROFILING_TIMER_RESOLUTION.
		/// </summary>
		DeviceProfilingTimerResolution = Cl.DEVICE_PROFILING_TIMER_RESOLUTION,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_ENDIAN_LITTLE.
		/// </summary>
		DeviceEndianLittle = Cl.DEVICE_ENDIAN_LITTLE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_AVAILABLE.
		/// </summary>
		DeviceAvailable = Cl.DEVICE_AVAILABLE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_COMPILER_AVAILABLE.
		/// </summary>
		DeviceCompilerAvailable = Cl.DEVICE_COMPILER_AVAILABLE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_EXECUTION_CAPABILITIES.
		/// </summary>
		DeviceExecutionCapabilities = Cl.DEVICE_EXECUTION_CAPABILITIES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_QUEUE_PROPERTIES, CL_DEVICE_QUEUE_ON_HOST_PROPERTIES.
		/// </summary>
		DeviceQueueProperties = Cl.DEVICE_QUEUE_PROPERTIES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NAME.
		/// </summary>
		DeviceName = Cl.DEVICE_NAME,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_VENDOR.
		/// </summary>
		DeviceVendor = Cl.DEVICE_VENDOR,

		/// <summary>
		/// Strongly typed for value CL_DRIVER_VERSION.
		/// </summary>
		DriverVersion = Cl.DRIVER_VERSION,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PROFILE.
		/// </summary>
		DeviceProfile = Cl.DEVICE_PROFILE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_VERSION.
		/// </summary>
		DeviceVersion = Cl.DEVICE_VERSION,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_EXTENSIONS.
		/// </summary>
		DeviceExtensions = Cl.DEVICE_EXTENSIONS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PLATFORM.
		/// </summary>
		DevicePlatform = Cl.DEVICE_PLATFORM,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_DOUBLE_FP_CONFIG.
		/// </summary>
		DeviceDoubleFpConfig = Cl.DEVICE_DOUBLE_FP_CONFIG,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF.
		/// </summary>
		DevicePreferredVectorWidthHalf = Cl.DEVICE_PREFERRED_VECTOR_WIDTH_HALF,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_HOST_UNIFIED_MEMORY.
		/// </summary>
		DeviceHostUnifiedMemory = Cl.DEVICE_HOST_UNIFIED_MEMORY,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR.
		/// </summary>
		DeviceNativeVectorWidthChar = Cl.DEVICE_NATIVE_VECTOR_WIDTH_CHAR,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT.
		/// </summary>
		DeviceNativeVectorWidthShort = Cl.DEVICE_NATIVE_VECTOR_WIDTH_SHORT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_INT.
		/// </summary>
		DeviceNativeVectorWidthInt = Cl.DEVICE_NATIVE_VECTOR_WIDTH_INT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG.
		/// </summary>
		DeviceNativeVectorWidthLong = Cl.DEVICE_NATIVE_VECTOR_WIDTH_LONG,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT.
		/// </summary>
		DeviceNativeVectorWidthFloat = Cl.DEVICE_NATIVE_VECTOR_WIDTH_FLOAT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE.
		/// </summary>
		DeviceNativeVectorWidthDouble = Cl.DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF.
		/// </summary>
		DeviceNativeVectorWidthHalf = Cl.DEVICE_NATIVE_VECTOR_WIDTH_HALF,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_OPENCL_C_VERSION.
		/// </summary>
		DeviceOpenclCVersion = Cl.DEVICE_OPENCL_C_VERSION,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_LINKER_AVAILABLE.
		/// </summary>
		DeviceLinkerAvailable = Cl.DEVICE_LINKER_AVAILABLE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_BUILT_IN_KERNELS.
		/// </summary>
		DeviceBuiltInKernels = Cl.DEVICE_BUILT_IN_KERNELS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE_MAX_BUFFER_SIZE.
		/// </summary>
		DeviceImageMaxBufferSize = Cl.DEVICE_IMAGE_MAX_BUFFER_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE_MAX_ARRAY_SIZE.
		/// </summary>
		DeviceImageMaxArraySize = Cl.DEVICE_IMAGE_MAX_ARRAY_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARENT_DEVICE.
		/// </summary>
		DeviceParentDevice = Cl.DEVICE_PARENT_DEVICE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARTITION_MAX_SUB_DEVICES.
		/// </summary>
		DevicePartitionMaxSubDevices = Cl.DEVICE_PARTITION_MAX_SUB_DEVICES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARTITION_PROPERTIES.
		/// </summary>
		DevicePartitionProperties = Cl.DEVICE_PARTITION_PROPERTIES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARTITION_AFFINITY_DOMAIN.
		/// </summary>
		DevicePartitionAffinityDomain = Cl.DEVICE_PARTITION_AFFINITY_DOMAIN,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARTITION_TYPE.
		/// </summary>
		DevicePartitionType = Cl.DEVICE_PARTITION_TYPE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_REFERENCE_COUNT.
		/// </summary>
		DeviceReferenceCount = Cl.DEVICE_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_INTEROP_USER_SYNC.
		/// </summary>
		DevicePreferredInteropUserSync = Cl.DEVICE_PREFERRED_INTEROP_USER_SYNC,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PRINTF_BUFFER_SIZE.
		/// </summary>
		DevicePrintfBufferSize = Cl.DEVICE_PRINTF_BUFFER_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE_PITCH_ALIGNMENT.
		/// </summary>
		DeviceImagePitchAlignment = Cl.DEVICE_IMAGE_PITCH_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT.
		/// </summary>
		DeviceImageBaseAddressAlignment = Cl.DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_READ_WRITE_IMAGE_ARGS.
		/// </summary>
		DeviceMaxReadWriteImageArgs = Cl.DEVICE_MAX_READ_WRITE_IMAGE_ARGS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_GLOBAL_VARIABLE_SIZE.
		/// </summary>
		DeviceMaxGlobalVariableSize = Cl.DEVICE_MAX_GLOBAL_VARIABLE_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_QUEUE_ON_DEVICE_PROPERTIES.
		/// </summary>
		DeviceQueueOnDeviceProperties = Cl.DEVICE_QUEUE_ON_DEVICE_PROPERTIES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE.
		/// </summary>
		DeviceQueueOnDevicePreferredSize = Cl.DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_QUEUE_ON_DEVICE_MAX_SIZE.
		/// </summary>
		DeviceQueueOnDeviceMaxSize = Cl.DEVICE_QUEUE_ON_DEVICE_MAX_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_ON_DEVICE_QUEUES.
		/// </summary>
		DeviceMaxOnDeviceQueues = Cl.DEVICE_MAX_ON_DEVICE_QUEUES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_ON_DEVICE_EVENTS.
		/// </summary>
		DeviceMaxOnDeviceEvents = Cl.DEVICE_MAX_ON_DEVICE_EVENTS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_SVM_CAPABILITIES.
		/// </summary>
		DeviceSvmCapabilities = Cl.DEVICE_SVM_CAPABILITIES,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE.
		/// </summary>
		DeviceGlobalVariablePreferredTotalSize = Cl.DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_PIPE_ARGS.
		/// </summary>
		DeviceMaxPipeArgs = Cl.DEVICE_MAX_PIPE_ARGS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS.
		/// </summary>
		DevicePipeMaxActiveReservations = Cl.DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PIPE_MAX_PACKET_SIZE.
		/// </summary>
		DevicePipeMaxPacketSize = Cl.DEVICE_PIPE_MAX_PACKET_SIZE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT.
		/// </summary>
		DevicePreferredPlatformAtomicAlignment = Cl.DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT.
		/// </summary>
		DevicePreferredGlobalAtomicAlignment = Cl.DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT.
		/// </summary>
		DevicePreferredLocalAtomicAlignment = Cl.DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_IL_VERSION.
		/// </summary>
		DeviceIlVersion = Cl.DEVICE_IL_VERSION,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_MAX_NUM_SUB_GROUPS.
		/// </summary>
		DeviceMaxNumSubGroups = Cl.DEVICE_MAX_NUM_SUB_GROUPS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS.
		/// </summary>
		DeviceSubGroupIndependentForwardProgress = Cl.DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS,

	}

	/// <summary>
	/// Strongly typed enumeration DeviceFpConfig.
	/// </summary>
	[Flags()]
	public enum DeviceFpConfig : ulong
	{
		/// <summary>
		/// Strongly typed for value CL_FP_DENORM.
		/// </summary>
		FpDenorm = Cl.FP_DENORM,

		/// <summary>
		/// Strongly typed for value CL_FP_INF_NAN.
		/// </summary>
		FpInfNan = Cl.FP_INF_NAN,

		/// <summary>
		/// Strongly typed for value CL_FP_ROUND_TO_NEAREST.
		/// </summary>
		FpRoundToNearest = Cl.FP_ROUND_TO_NEAREST,

		/// <summary>
		/// Strongly typed for value CL_FP_ROUND_TO_ZERO.
		/// </summary>
		FpRoundToZero = Cl.FP_ROUND_TO_ZERO,

		/// <summary>
		/// Strongly typed for value CL_FP_ROUND_TO_INF.
		/// </summary>
		FpRoundToInf = Cl.FP_ROUND_TO_INF,

		/// <summary>
		/// Strongly typed for value CL_FP_FMA.
		/// </summary>
		FpFma = Cl.FP_FMA,

		/// <summary>
		/// Strongly typed for value CL_FP_SOFT_FLOAT.
		/// </summary>
		FpSoftFloat = Cl.FP_SOFT_FLOAT,

		/// <summary>
		/// Strongly typed for value CL_FP_CORRECTLY_ROUNDED_DIVIDE_SQRT.
		/// </summary>
		FpCorrectlyRoundedDivideSqrt = Cl.FP_CORRECTLY_ROUNDED_DIVIDE_SQRT,

	}

	/// <summary>
	/// Strongly typed enumeration DeviceMemCacheType.
	/// </summary>
	public enum DeviceMemCacheType : uint
	{
		/// <summary>
		/// Strongly typed for value CL_NONE.
		/// </summary>
		None = Cl.NONE,

		/// <summary>
		/// Strongly typed for value CL_READ_ONLY_CACHE.
		/// </summary>
		ReadOnlyCache = Cl.READ_ONLY_CACHE,

		/// <summary>
		/// Strongly typed for value CL_READ_WRITE_CACHE.
		/// </summary>
		ReadWriteCache = Cl.READ_WRITE_CACHE,

	}

	/// <summary>
	/// Strongly typed enumeration DeviceLocalMemType.
	/// </summary>
	public enum DeviceLocalMemType : uint
	{
		/// <summary>
		/// Strongly typed for value CL_LOCAL.
		/// </summary>
		Local = Cl.LOCAL,

		/// <summary>
		/// Strongly typed for value CL_GLOBAL.
		/// </summary>
		Global = Cl.GLOBAL,

	}

	/// <summary>
	/// Strongly typed enumeration DeviceExecCapabilities.
	/// </summary>
	[Flags()]
	public enum DeviceExecCapabilities : ulong
	{
		/// <summary>
		/// Strongly typed for value CL_EXEC_KERNEL.
		/// </summary>
		ExecKernel = Cl.EXEC_KERNEL,

		/// <summary>
		/// Strongly typed for value CL_EXEC_NATIVE_KERNEL.
		/// </summary>
		ExecNativeKernel = Cl.EXEC_NATIVE_KERNEL,

	}

	/// <summary>
	/// Strongly typed enumeration CommandQueueProperties.
	/// </summary>
	[Flags()]
	public enum CommandQueueProperties : ulong
	{
		/// <summary>
		/// Strongly typed for value CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE.
		/// </summary>
		QueueOutOfOrderExecModeEnable = Cl.QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE,

		/// <summary>
		/// Strongly typed for value CL_QUEUE_PROFILING_ENABLE.
		/// </summary>
		QueueProfilingEnable = Cl.QUEUE_PROFILING_ENABLE,

		/// <summary>
		/// Strongly typed for value CL_QUEUE_ON_DEVICE.
		/// </summary>
		QueueOnDevice = Cl.QUEUE_ON_DEVICE,

		/// <summary>
		/// Strongly typed for value CL_QUEUE_ON_DEVICE_DEFAULT.
		/// </summary>
		QueueOnDeviceDefault = Cl.QUEUE_ON_DEVICE_DEFAULT,

	}

	/// <summary>
	/// Strongly typed enumeration ContextInfo.
	/// </summary>
	public enum ContextInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_CONTEXT_REFERENCE_COUNT.
		/// </summary>
		ContextReferenceCount = Cl.CONTEXT_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_CONTEXT_DEVICES.
		/// </summary>
		ContextDevices = Cl.CONTEXT_DEVICES,

		/// <summary>
		/// Strongly typed for value CL_CONTEXT_PROPERTIES.
		/// </summary>
		ContextProperties = Cl.CONTEXT_PROPERTIES,

		/// <summary>
		/// Strongly typed for value CL_CONTEXT_NUM_DEVICES.
		/// </summary>
		ContextNumDevices = Cl.CONTEXT_NUM_DEVICES,

	}

	/// <summary>
	/// Strongly typed enumeration ContextProperties.
	/// </summary>
	public enum ContextProperties
	{
		/// <summary>
		/// Strongly typed for value CL_CONTEXT_PLATFORM.
		/// </summary>
		ContextPlatform = Cl.CONTEXT_PLATFORM,

		/// <summary>
		/// Strongly typed for value CL_CONTEXT_INTEROP_USER_SYNC.
		/// </summary>
		ContextInteropUserSync = Cl.CONTEXT_INTEROP_USER_SYNC,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARTITION_EQUALLY.
		/// </summary>
		DevicePartitionEqually = Cl.DEVICE_PARTITION_EQUALLY,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARTITION_BY_COUNTS.
		/// </summary>
		DevicePartitionByCounts = Cl.DEVICE_PARTITION_BY_COUNTS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARTITION_BY_COUNTS_LIST_END.
		/// </summary>
		DevicePartitionByCountsListEnd = Cl.DEVICE_PARTITION_BY_COUNTS_LIST_END,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN.
		/// </summary>
		DevicePartitionByAffinityDomain = Cl.DEVICE_PARTITION_BY_AFFINITY_DOMAIN,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_AFFINITY_DOMAIN_NUMA, CL_DEVICE_SVM_COARSE_GRAIN_BUFFER.
		/// </summary>
		DeviceAffinityDomainNuma = Cl.DEVICE_AFFINITY_DOMAIN_NUMA,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE, CL_DEVICE_SVM_FINE_GRAIN_BUFFER.
		/// </summary>
		DeviceSvmFineGrainBuffer = Cl.DEVICE_SVM_FINE_GRAIN_BUFFER,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE, CL_DEVICE_SVM_FINE_GRAIN_SYSTEM.
		/// </summary>
		DeviceSvmFineGrainSystem = Cl.DEVICE_SVM_FINE_GRAIN_SYSTEM,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE, CL_DEVICE_SVM_ATOMICS.
		/// </summary>
		DeviceSvmAtomics = Cl.DEVICE_SVM_ATOMICS,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE.
		/// </summary>
		DeviceAffinityDomainL1Cache = Cl.DEVICE_AFFINITY_DOMAIN_L1_CACHE,

		/// <summary>
		/// Strongly typed for value CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE.
		/// </summary>
		DeviceAffinityDomainNextPartitionable = Cl.DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE,

	}

	/// <summary>
	/// Strongly typed enumeration CommandQueueInfo.
	/// </summary>
	public enum CommandQueueInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_QUEUE_CONTEXT.
		/// </summary>
		QueueContext = Cl.QUEUE_CONTEXT,

		/// <summary>
		/// Strongly typed for value CL_QUEUE_DEVICE.
		/// </summary>
		QueueDevice = Cl.QUEUE_DEVICE,

		/// <summary>
		/// Strongly typed for value CL_QUEUE_REFERENCE_COUNT.
		/// </summary>
		QueueReferenceCount = Cl.QUEUE_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_QUEUE_PROPERTIES.
		/// </summary>
		QueueProperties = Cl.QUEUE_PROPERTIES,

		/// <summary>
		/// Strongly typed for value CL_QUEUE_SIZE.
		/// </summary>
		QueueSize = Cl.QUEUE_SIZE,

		/// <summary>
		/// Strongly typed for value CL_QUEUE_DEVICE_DEFAULT.
		/// </summary>
		QueueDeviceDefault = Cl.QUEUE_DEVICE_DEFAULT,

	}

	/// <summary>
	/// Strongly typed enumeration MemMigrationFlags.
	/// </summary>
	[Flags()]
	public enum MemMigrationFlags : ulong
	{
		/// <summary>
		/// Strongly typed for value CL_MIGRATE_MEM_OBJECT_HOST.
		/// </summary>
		MigrateMemObjectHost = Cl.MIGRATE_MEM_OBJECT_HOST,

		/// <summary>
		/// Strongly typed for value CL_MIGRATE_MEM_OBJECT_CONTENT_UNDEFINED.
		/// </summary>
		MigrateMemObjectContentUndefined = Cl.MIGRATE_MEM_OBJECT_CONTENT_UNDEFINED,

	}

	/// <summary>
	/// Strongly typed enumeration ChannelOrder.
	/// </summary>
	public enum ChannelOrder : uint
	{
		/// <summary>
		/// Strongly typed for value CL_R.
		/// </summary>
		R = Cl.R,

		/// <summary>
		/// Strongly typed for value CL_A.
		/// </summary>
		A = Cl.A,

		/// <summary>
		/// Strongly typed for value CL_RG.
		/// </summary>
		Rg = Cl.RG,

		/// <summary>
		/// Strongly typed for value CL_RA.
		/// </summary>
		Ra = Cl.RA,

		/// <summary>
		/// Strongly typed for value CL_RGB.
		/// </summary>
		Rgb = Cl.RGB,

		/// <summary>
		/// Strongly typed for value CL_RGBA.
		/// </summary>
		Rgba = Cl.RGBA,

		/// <summary>
		/// Strongly typed for value CL_BGRA.
		/// </summary>
		Bgra = Cl.BGRA,

		/// <summary>
		/// Strongly typed for value CL_ARGB.
		/// </summary>
		Argb = Cl.ARGB,

		/// <summary>
		/// Strongly typed for value CL_INTENSITY.
		/// </summary>
		Intensity = Cl.INTENSITY,

		/// <summary>
		/// Strongly typed for value CL_LUMINANCE.
		/// </summary>
		Luminance = Cl.LUMINANCE,

		/// <summary>
		/// Strongly typed for value CL_Rx.
		/// </summary>
		Rx = Cl.Rx,

		/// <summary>
		/// Strongly typed for value CL_RGx.
		/// </summary>
		Rgx = Cl.RGx,

		/// <summary>
		/// Strongly typed for value CL_RGBx.
		/// </summary>
		Rgbx = Cl.RGBx,

		/// <summary>
		/// Strongly typed for value CL_DEPTH.
		/// </summary>
		Depth = Cl.DEPTH,

		/// <summary>
		/// Strongly typed for value CL_DEPTH_STENCIL.
		/// </summary>
		DepthStencil = Cl.DEPTH_STENCIL,

		/// <summary>
		/// Strongly typed for value CL_sRGB.
		/// </summary>
		Srgb = Cl.sRGB,

		/// <summary>
		/// Strongly typed for value CL_sRGBx.
		/// </summary>
		Srgbx = Cl.sRGBx,

		/// <summary>
		/// Strongly typed for value CL_sRGBA.
		/// </summary>
		Srgba = Cl.sRGBA,

		/// <summary>
		/// Strongly typed for value CL_sBGRA.
		/// </summary>
		Sbgra = Cl.sBGRA,

		/// <summary>
		/// Strongly typed for value CL_ABGR.
		/// </summary>
		Abgr = Cl.ABGR,

	}

	/// <summary>
	/// Strongly typed enumeration ChannelType.
	/// </summary>
	public enum ChannelType : uint
	{
		/// <summary>
		/// Strongly typed for value CL_SNORM_INT8.
		/// </summary>
		SnormInt8 = Cl.SNORM_INT8,

		/// <summary>
		/// Strongly typed for value CL_SNORM_INT16.
		/// </summary>
		SnormInt16 = Cl.SNORM_INT16,

		/// <summary>
		/// Strongly typed for value CL_UNORM_INT8.
		/// </summary>
		UnormInt8 = Cl.UNORM_INT8,

		/// <summary>
		/// Strongly typed for value CL_UNORM_INT16.
		/// </summary>
		UnormInt16 = Cl.UNORM_INT16,

		/// <summary>
		/// Strongly typed for value CL_UNORM_SHORT_565.
		/// </summary>
		UnormShort565 = Cl.UNORM_SHORT_565,

		/// <summary>
		/// Strongly typed for value CL_UNORM_SHORT_555.
		/// </summary>
		UnormShort555 = Cl.UNORM_SHORT_555,

		/// <summary>
		/// Strongly typed for value CL_UNORM_INT_101010.
		/// </summary>
		UnormInt101010 = Cl.UNORM_INT_101010,

		/// <summary>
		/// Strongly typed for value CL_SIGNED_INT8.
		/// </summary>
		SignedInt8 = Cl.SIGNED_INT8,

		/// <summary>
		/// Strongly typed for value CL_SIGNED_INT16.
		/// </summary>
		SignedInt16 = Cl.SIGNED_INT16,

		/// <summary>
		/// Strongly typed for value CL_SIGNED_INT32.
		/// </summary>
		SignedInt32 = Cl.SIGNED_INT32,

		/// <summary>
		/// Strongly typed for value CL_UNSIGNED_INT8.
		/// </summary>
		UnsignedInt8 = Cl.UNSIGNED_INT8,

		/// <summary>
		/// Strongly typed for value CL_UNSIGNED_INT16.
		/// </summary>
		UnsignedInt16 = Cl.UNSIGNED_INT16,

		/// <summary>
		/// Strongly typed for value CL_UNSIGNED_INT32.
		/// </summary>
		UnsignedInt32 = Cl.UNSIGNED_INT32,

		/// <summary>
		/// Strongly typed for value CL_HALF_FLOAT.
		/// </summary>
		HalfFloat = Cl.HALF_FLOAT,

		/// <summary>
		/// Strongly typed for value CL_FLOAT.
		/// </summary>
		Float = Cl.FLOAT,

		/// <summary>
		/// Strongly typed for value CL_UNORM_INT24.
		/// </summary>
		UnormInt24 = Cl.UNORM_INT24,

		/// <summary>
		/// Strongly typed for value CL_UNORM_INT_101010_2.
		/// </summary>
		UnormInt1010102 = Cl.UNORM_INT_101010_2,

	}

	/// <summary>
	/// Strongly typed enumeration MemObjectType.
	/// </summary>
	public enum MemObjectType : uint
	{
		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_BUFFER.
		/// </summary>
		MemObjectBuffer = Cl.MEM_OBJECT_BUFFER,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_IMAGE2D.
		/// </summary>
		MemObjectImage2d = Cl.MEM_OBJECT_IMAGE2D,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_IMAGE3D.
		/// </summary>
		MemObjectImage3d = Cl.MEM_OBJECT_IMAGE3D,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_IMAGE2D_ARRAY.
		/// </summary>
		MemObjectImage2dArray = Cl.MEM_OBJECT_IMAGE2D_ARRAY,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_IMAGE1D.
		/// </summary>
		MemObjectImage1d = Cl.MEM_OBJECT_IMAGE1D,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_IMAGE1D_ARRAY.
		/// </summary>
		MemObjectImage1dArray = Cl.MEM_OBJECT_IMAGE1D_ARRAY,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_IMAGE1D_BUFFER.
		/// </summary>
		MemObjectImage1dBuffer = Cl.MEM_OBJECT_IMAGE1D_BUFFER,

		/// <summary>
		/// Strongly typed for value CL_MEM_OBJECT_PIPE.
		/// </summary>
		MemObjectPipe = Cl.MEM_OBJECT_PIPE,

	}

	/// <summary>
	/// Strongly typed enumeration MemInfo.
	/// </summary>
	public enum MemInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_MEM_TYPE.
		/// </summary>
		MemType = Cl.MEM_TYPE,

		/// <summary>
		/// Strongly typed for value CL_MEM_FLAGS.
		/// </summary>
		MemFlags = Cl.MEM_FLAGS,

		/// <summary>
		/// Strongly typed for value CL_MEM_SIZE.
		/// </summary>
		MemSize = Cl.MEM_SIZE,

		/// <summary>
		/// Strongly typed for value CL_MEM_HOST_PTR.
		/// </summary>
		MemHostPtr = Cl.MEM_HOST_PTR,

		/// <summary>
		/// Strongly typed for value CL_MEM_MAP_COUNT.
		/// </summary>
		MemMapCount = Cl.MEM_MAP_COUNT,

		/// <summary>
		/// Strongly typed for value CL_MEM_REFERENCE_COUNT.
		/// </summary>
		MemReferenceCount = Cl.MEM_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_MEM_CONTEXT.
		/// </summary>
		MemContext = Cl.MEM_CONTEXT,

		/// <summary>
		/// Strongly typed for value CL_MEM_ASSOCIATED_MEMOBJECT.
		/// </summary>
		MemAssociatedMemobject = Cl.MEM_ASSOCIATED_MEMOBJECT,

		/// <summary>
		/// Strongly typed for value CL_MEM_OFFSET.
		/// </summary>
		MemOffset = Cl.MEM_OFFSET,

		/// <summary>
		/// Strongly typed for value CL_MEM_USES_SVM_POINTER.
		/// </summary>
		MemUsesSvmPointer = Cl.MEM_USES_SVM_POINTER,

	}

	/// <summary>
	/// Strongly typed enumeration ImageInfo.
	/// </summary>
	public enum ImageInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_IMAGE_FORMAT.
		/// </summary>
		ImageFormat = Cl.IMAGE_FORMAT,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_ELEMENT_SIZE.
		/// </summary>
		ImageElementSize = Cl.IMAGE_ELEMENT_SIZE,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_ROW_PITCH.
		/// </summary>
		ImageRowPitch = Cl.IMAGE_ROW_PITCH,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_SLICE_PITCH.
		/// </summary>
		ImageSlicePitch = Cl.IMAGE_SLICE_PITCH,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_WIDTH.
		/// </summary>
		ImageWidth = Cl.IMAGE_WIDTH,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_HEIGHT.
		/// </summary>
		ImageHeight = Cl.IMAGE_HEIGHT,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_DEPTH.
		/// </summary>
		ImageDepth = Cl.IMAGE_DEPTH,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_ARRAY_SIZE.
		/// </summary>
		ImageArraySize = Cl.IMAGE_ARRAY_SIZE,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_BUFFER.
		/// </summary>
		ImageBuffer = Cl.IMAGE_BUFFER,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_NUM_MIP_LEVELS.
		/// </summary>
		ImageNumMipLevels = Cl.IMAGE_NUM_MIP_LEVELS,

		/// <summary>
		/// Strongly typed for value CL_IMAGE_NUM_SAMPLES.
		/// </summary>
		ImageNumSamples = Cl.IMAGE_NUM_SAMPLES,

		/// <summary>
		/// Strongly typed for value CL_PIPE_PACKET_SIZE.
		/// </summary>
		PipePacketSize = Cl.PIPE_PACKET_SIZE,

		/// <summary>
		/// Strongly typed for value CL_PIPE_MAX_PACKETS.
		/// </summary>
		PipeMaxPackets = Cl.PIPE_MAX_PACKETS,

	}

	/// <summary>
	/// Strongly typed enumeration AddressingMode.
	/// </summary>
	public enum AddressingMode : uint
	{
		/// <summary>
		/// Strongly typed for value CL_ADDRESS_NONE.
		/// </summary>
		AddressNone = Cl.ADDRESS_NONE,

		/// <summary>
		/// Strongly typed for value CL_ADDRESS_CLAMP_TO_EDGE.
		/// </summary>
		AddressClampToEdge = Cl.ADDRESS_CLAMP_TO_EDGE,

		/// <summary>
		/// Strongly typed for value CL_ADDRESS_CLAMP.
		/// </summary>
		AddressClamp = Cl.ADDRESS_CLAMP,

		/// <summary>
		/// Strongly typed for value CL_ADDRESS_REPEAT.
		/// </summary>
		AddressRepeat = Cl.ADDRESS_REPEAT,

		/// <summary>
		/// Strongly typed for value CL_ADDRESS_MIRRORED_REPEAT.
		/// </summary>
		AddressMirroredRepeat = Cl.ADDRESS_MIRRORED_REPEAT,

	}

	/// <summary>
	/// Strongly typed enumeration FilterMode.
	/// </summary>
	public enum FilterMode : uint
	{
		/// <summary>
		/// Strongly typed for value CL_FILTER_NEAREST.
		/// </summary>
		FilterNearest = Cl.FILTER_NEAREST,

		/// <summary>
		/// Strongly typed for value CL_FILTER_LINEAR.
		/// </summary>
		FilterLinear = Cl.FILTER_LINEAR,

	}

	/// <summary>
	/// Strongly typed enumeration SamplerInfo.
	/// </summary>
	public enum SamplerInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_SAMPLER_REFERENCE_COUNT.
		/// </summary>
		SamplerReferenceCount = Cl.SAMPLER_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_CONTEXT.
		/// </summary>
		SamplerContext = Cl.SAMPLER_CONTEXT,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_NORMALIZED_COORDS.
		/// </summary>
		SamplerNormalizedCoords = Cl.SAMPLER_NORMALIZED_COORDS,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_ADDRESSING_MODE.
		/// </summary>
		SamplerAddressingMode = Cl.SAMPLER_ADDRESSING_MODE,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_FILTER_MODE.
		/// </summary>
		SamplerFilterMode = Cl.SAMPLER_FILTER_MODE,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_MIP_FILTER_MODE.
		/// </summary>
		SamplerMipFilterMode = Cl.SAMPLER_MIP_FILTER_MODE,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_LOD_MIN.
		/// </summary>
		SamplerLodMin = Cl.SAMPLER_LOD_MIN,

		/// <summary>
		/// Strongly typed for value CL_SAMPLER_LOD_MAX.
		/// </summary>
		SamplerLodMax = Cl.SAMPLER_LOD_MAX,

	}

	/// <summary>
	/// Strongly typed enumeration MapFlags.
	/// </summary>
	[Flags()]
	public enum MapFlags : ulong
	{
		/// <summary>
		/// Strongly typed for value CL_MAP_READ.
		/// </summary>
		MapRead = Cl.MAP_READ,

		/// <summary>
		/// Strongly typed for value CL_MAP_WRITE.
		/// </summary>
		MapWrite = Cl.MAP_WRITE,

		/// <summary>
		/// Strongly typed for value CL_MAP_WRITE_INVALIDATE_REGION.
		/// </summary>
		MapWriteInvalidateRegion = Cl.MAP_WRITE_INVALIDATE_REGION,

	}

	/// <summary>
	/// Strongly typed enumeration ProgramInfo.
	/// </summary>
	public enum ProgramInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_PROGRAM_REFERENCE_COUNT.
		/// </summary>
		ProgramReferenceCount = Cl.PROGRAM_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_CONTEXT.
		/// </summary>
		ProgramContext = Cl.PROGRAM_CONTEXT,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_NUM_DEVICES.
		/// </summary>
		ProgramNumDevices = Cl.PROGRAM_NUM_DEVICES,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_DEVICES.
		/// </summary>
		ProgramDevices = Cl.PROGRAM_DEVICES,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_SOURCE.
		/// </summary>
		ProgramSource = Cl.PROGRAM_SOURCE,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARY_SIZES.
		/// </summary>
		ProgramBinarySizes = Cl.PROGRAM_BINARY_SIZES,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARIES.
		/// </summary>
		ProgramBinaries = Cl.PROGRAM_BINARIES,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_NUM_KERNELS.
		/// </summary>
		ProgramNumKernels = Cl.PROGRAM_NUM_KERNELS,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_KERNEL_NAMES.
		/// </summary>
		ProgramKernelNames = Cl.PROGRAM_KERNEL_NAMES,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_IL.
		/// </summary>
		ProgramIl = Cl.PROGRAM_IL,

	}

	/// <summary>
	/// Strongly typed enumeration ProgramBuildInfo.
	/// </summary>
	public enum ProgramBuildInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BUILD_STATUS.
		/// </summary>
		ProgramBuildStatus = Cl.PROGRAM_BUILD_STATUS,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BUILD_OPTIONS.
		/// </summary>
		ProgramBuildOptions = Cl.PROGRAM_BUILD_OPTIONS,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BUILD_LOG.
		/// </summary>
		ProgramBuildLog = Cl.PROGRAM_BUILD_LOG,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARY_TYPE.
		/// </summary>
		ProgramBinaryType = Cl.PROGRAM_BINARY_TYPE,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE.
		/// </summary>
		ProgramBuildGlobalVariableTotalSize = Cl.PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARY_TYPE_NONE.
		/// </summary>
		ProgramBinaryTypeNone = Cl.PROGRAM_BINARY_TYPE_NONE,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARY_TYPE_COMPILED_OBJECT.
		/// </summary>
		ProgramBinaryTypeCompiledObject = Cl.PROGRAM_BINARY_TYPE_COMPILED_OBJECT,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARY_TYPE_LIBRARY.
		/// </summary>
		ProgramBinaryTypeLibrary = Cl.PROGRAM_BINARY_TYPE_LIBRARY,

		/// <summary>
		/// Strongly typed for value CL_PROGRAM_BINARY_TYPE_EXECUTABLE.
		/// </summary>
		ProgramBinaryTypeExecutable = Cl.PROGRAM_BINARY_TYPE_EXECUTABLE,

	}

	/// <summary>
	/// Strongly typed enumeration BuildStatus.
	/// </summary>
	public enum BuildStatus : int
	{
		/// <summary>
		/// Strongly typed for value CL_BUILD_SUCCESS.
		/// </summary>
		BuildSuccess = Cl.BUILD_SUCCESS,

		/// <summary>
		/// Strongly typed for value CL_BUILD_NONE.
		/// </summary>
		BuildNone = Cl.BUILD_NONE,

		/// <summary>
		/// Strongly typed for value CL_BUILD_ERROR.
		/// </summary>
		BuildError = Cl.BUILD_ERROR,

		/// <summary>
		/// Strongly typed for value CL_BUILD_IN_PROGRESS.
		/// </summary>
		BuildInProgress = Cl.BUILD_IN_PROGRESS,

	}

	/// <summary>
	/// Strongly typed enumeration KernelInfo.
	/// </summary>
	public enum KernelInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_KERNEL_FUNCTION_NAME.
		/// </summary>
		KernelFunctionName = Cl.KERNEL_FUNCTION_NAME,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_NUM_ARGS.
		/// </summary>
		KernelNumArgs = Cl.KERNEL_NUM_ARGS,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_REFERENCE_COUNT.
		/// </summary>
		KernelReferenceCount = Cl.KERNEL_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_CONTEXT.
		/// </summary>
		KernelContext = Cl.KERNEL_CONTEXT,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_PROGRAM.
		/// </summary>
		KernelProgram = Cl.KERNEL_PROGRAM,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ATTRIBUTES.
		/// </summary>
		KernelAttributes = Cl.KERNEL_ATTRIBUTES,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_MAX_NUM_SUB_GROUPS.
		/// </summary>
		KernelMaxNumSubGroups = Cl.KERNEL_MAX_NUM_SUB_GROUPS,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_COMPILE_NUM_SUB_GROUPS.
		/// </summary>
		KernelCompileNumSubGroups = Cl.KERNEL_COMPILE_NUM_SUB_GROUPS,

	}

	/// <summary>
	/// Strongly typed enumeration KernelArgInfo.
	/// </summary>
	public enum KernelArgInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_ADDRESS_QUALIFIER.
		/// </summary>
		KernelArgAddressQualifier = Cl.KERNEL_ARG_ADDRESS_QUALIFIER,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_ACCESS_QUALIFIER.
		/// </summary>
		KernelArgAccessQualifier = Cl.KERNEL_ARG_ACCESS_QUALIFIER,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_TYPE_NAME.
		/// </summary>
		KernelArgTypeName = Cl.KERNEL_ARG_TYPE_NAME,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_TYPE_QUALIFIER.
		/// </summary>
		KernelArgTypeQualifier = Cl.KERNEL_ARG_TYPE_QUALIFIER,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_NAME.
		/// </summary>
		KernelArgName = Cl.KERNEL_ARG_NAME,

	}

	/// <summary>
	/// Strongly typed enumeration KernelArgAddressQualifier.
	/// </summary>
	public enum KernelArgAddressQualifier : uint
	{
		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_ADDRESS_GLOBAL.
		/// </summary>
		KernelArgAddressGlobal = Cl.KERNEL_ARG_ADDRESS_GLOBAL,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_ADDRESS_LOCAL.
		/// </summary>
		KernelArgAddressLocal = Cl.KERNEL_ARG_ADDRESS_LOCAL,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_ADDRESS_CONSTANT.
		/// </summary>
		KernelArgAddressConstant = Cl.KERNEL_ARG_ADDRESS_CONSTANT,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_ADDRESS_PRIVATE.
		/// </summary>
		KernelArgAddressPrivate = Cl.KERNEL_ARG_ADDRESS_PRIVATE,

	}

	/// <summary>
	/// Strongly typed enumeration KernelArgAccessQualifier.
	/// </summary>
	public enum KernelArgAccessQualifier : uint
	{
		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_ACCESS_READ_ONLY.
		/// </summary>
		KernelArgAccessReadOnly = Cl.KERNEL_ARG_ACCESS_READ_ONLY,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_ACCESS_WRITE_ONLY.
		/// </summary>
		KernelArgAccessWriteOnly = Cl.KERNEL_ARG_ACCESS_WRITE_ONLY,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_ACCESS_READ_WRITE.
		/// </summary>
		KernelArgAccessReadWrite = Cl.KERNEL_ARG_ACCESS_READ_WRITE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_ACCESS_NONE.
		/// </summary>
		KernelArgAccessNone = Cl.KERNEL_ARG_ACCESS_NONE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_TYPE_NONE.
		/// </summary>
		KernelArgTypeNone = Cl.KERNEL_ARG_TYPE_NONE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_TYPE_CONST.
		/// </summary>
		KernelArgTypeConst = Cl.KERNEL_ARG_TYPE_CONST,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_TYPE_RESTRICT.
		/// </summary>
		KernelArgTypeRestrict = Cl.KERNEL_ARG_TYPE_RESTRICT,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_TYPE_VOLATILE.
		/// </summary>
		KernelArgTypeVolatile = Cl.KERNEL_ARG_TYPE_VOLATILE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_ARG_TYPE_PIPE.
		/// </summary>
		KernelArgTypePipe = Cl.KERNEL_ARG_TYPE_PIPE,

	}

	/// <summary>
	/// Strongly typed enumeration KernelWorkGroupInfo.
	/// </summary>
	public enum KernelWorkGroupInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_KERNEL_WORK_GROUP_SIZE.
		/// </summary>
		KernelWorkGroupSize = Cl.KERNEL_WORK_GROUP_SIZE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_COMPILE_WORK_GROUP_SIZE.
		/// </summary>
		KernelCompileWorkGroupSize = Cl.KERNEL_COMPILE_WORK_GROUP_SIZE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_LOCAL_MEM_SIZE.
		/// </summary>
		KernelLocalMemSize = Cl.KERNEL_LOCAL_MEM_SIZE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE.
		/// </summary>
		KernelPreferredWorkGroupSizeMultiple = Cl.KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_PRIVATE_MEM_SIZE.
		/// </summary>
		KernelPrivateMemSize = Cl.KERNEL_PRIVATE_MEM_SIZE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_GLOBAL_WORK_SIZE.
		/// </summary>
		KernelGlobalWorkSize = Cl.KERNEL_GLOBAL_WORK_SIZE,

	}

	/// <summary>
	/// Strongly typed enumeration KernelSubGroupInfo.
	/// </summary>
	public enum KernelSubGroupInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE.
		/// </summary>
		KernelMaxSubGroupSizeForNdrange = Cl.KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE.
		/// </summary>
		KernelSubGroupCountForNdrange = Cl.KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_LOCAL_SIZE_FOR_SUB_GROUP_COUNT.
		/// </summary>
		KernelLocalSizeForSubGroupCount = Cl.KERNEL_LOCAL_SIZE_FOR_SUB_GROUP_COUNT,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_EXEC_INFO_SVM_PTRS.
		/// </summary>
		KernelExecInfoSvmPtrs = Cl.KERNEL_EXEC_INFO_SVM_PTRS,

		/// <summary>
		/// Strongly typed for value CL_KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM.
		/// </summary>
		KernelExecInfoSvmFineGrainSystem = Cl.KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM,

	}

	/// <summary>
	/// Strongly typed enumeration EventInfo.
	/// </summary>
	public enum EventInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_EVENT_COMMAND_QUEUE.
		/// </summary>
		EventCommandQueue = Cl.EVENT_COMMAND_QUEUE,

		/// <summary>
		/// Strongly typed for value CL_EVENT_COMMAND_TYPE.
		/// </summary>
		EventCommandType = Cl.EVENT_COMMAND_TYPE,

		/// <summary>
		/// Strongly typed for value CL_EVENT_REFERENCE_COUNT.
		/// </summary>
		EventReferenceCount = Cl.EVENT_REFERENCE_COUNT,

		/// <summary>
		/// Strongly typed for value CL_EVENT_COMMAND_EXECUTION_STATUS.
		/// </summary>
		EventCommandExecutionStatus = Cl.EVENT_COMMAND_EXECUTION_STATUS,

		/// <summary>
		/// Strongly typed for value CL_EVENT_CONTEXT.
		/// </summary>
		EventContext = Cl.EVENT_CONTEXT,

	}

	/// <summary>
	/// Strongly typed enumeration CommandType.
	/// </summary>
	public enum CommandType : uint
	{
		/// <summary>
		/// Strongly typed for value CL_COMMAND_NDRANGE_KERNEL.
		/// </summary>
		CommandNdrangeKernel = Cl.COMMAND_NDRANGE_KERNEL,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_TASK.
		/// </summary>
		CommandTask = Cl.COMMAND_TASK,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_NATIVE_KERNEL.
		/// </summary>
		CommandNativeKernel = Cl.COMMAND_NATIVE_KERNEL,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_READ_BUFFER.
		/// </summary>
		CommandReadBuffer = Cl.COMMAND_READ_BUFFER,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_WRITE_BUFFER.
		/// </summary>
		CommandWriteBuffer = Cl.COMMAND_WRITE_BUFFER,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_COPY_BUFFER.
		/// </summary>
		CommandCopyBuffer = Cl.COMMAND_COPY_BUFFER,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_READ_IMAGE.
		/// </summary>
		CommandReadImage = Cl.COMMAND_READ_IMAGE,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_WRITE_IMAGE.
		/// </summary>
		CommandWriteImage = Cl.COMMAND_WRITE_IMAGE,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_COPY_IMAGE.
		/// </summary>
		CommandCopyImage = Cl.COMMAND_COPY_IMAGE,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_COPY_IMAGE_TO_BUFFER.
		/// </summary>
		CommandCopyImageToBuffer = Cl.COMMAND_COPY_IMAGE_TO_BUFFER,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_COPY_BUFFER_TO_IMAGE.
		/// </summary>
		CommandCopyBufferToImage = Cl.COMMAND_COPY_BUFFER_TO_IMAGE,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_MAP_BUFFER.
		/// </summary>
		CommandMapBuffer = Cl.COMMAND_MAP_BUFFER,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_MAP_IMAGE.
		/// </summary>
		CommandMapImage = Cl.COMMAND_MAP_IMAGE,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_UNMAP_MEM_OBJECT.
		/// </summary>
		CommandUnmapMemObject = Cl.COMMAND_UNMAP_MEM_OBJECT,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_MARKER.
		/// </summary>
		CommandMarker = Cl.COMMAND_MARKER,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_ACQUIRE_GL_OBJECTS.
		/// </summary>
		CommandAcquireGlObjects = Cl.COMMAND_ACQUIRE_GL_OBJECTS,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_RELEASE_GL_OBJECTS.
		/// </summary>
		CommandReleaseGlObjects = Cl.COMMAND_RELEASE_GL_OBJECTS,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_READ_BUFFER_RECT.
		/// </summary>
		CommandReadBufferRect = Cl.COMMAND_READ_BUFFER_RECT,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_WRITE_BUFFER_RECT.
		/// </summary>
		CommandWriteBufferRect = Cl.COMMAND_WRITE_BUFFER_RECT,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_COPY_BUFFER_RECT.
		/// </summary>
		CommandCopyBufferRect = Cl.COMMAND_COPY_BUFFER_RECT,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_USER.
		/// </summary>
		CommandUser = Cl.COMMAND_USER,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_BARRIER.
		/// </summary>
		CommandBarrier = Cl.COMMAND_BARRIER,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_MIGRATE_MEM_OBJECTS.
		/// </summary>
		CommandMigrateMemObjects = Cl.COMMAND_MIGRATE_MEM_OBJECTS,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_FILL_BUFFER.
		/// </summary>
		CommandFillBuffer = Cl.COMMAND_FILL_BUFFER,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_FILL_IMAGE.
		/// </summary>
		CommandFillImage = Cl.COMMAND_FILL_IMAGE,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_SVM_FREE.
		/// </summary>
		CommandSvmFree = Cl.COMMAND_SVM_FREE,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_SVM_MEMCPY.
		/// </summary>
		CommandSvmMemcpy = Cl.COMMAND_SVM_MEMCPY,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_SVM_MEMFILL.
		/// </summary>
		CommandSvmMemfill = Cl.COMMAND_SVM_MEMFILL,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_SVM_MAP.
		/// </summary>
		CommandSvmMap = Cl.COMMAND_SVM_MAP,

		/// <summary>
		/// Strongly typed for value CL_COMMAND_SVM_UNMAP.
		/// </summary>
		CommandSvmUnmap = Cl.COMMAND_SVM_UNMAP,

	}

	/// <summary>
	/// Strongly typed enumeration BufferCreateType.
	/// </summary>
	public enum BufferCreateType : uint
	{
		/// <summary>
		/// Strongly typed for value CL_BUFFER_CREATE_TYPE_REGION.
		/// </summary>
		BufferCreateTypeRegion = Cl.BUFFER_CREATE_TYPE_REGION,

	}

	/// <summary>
	/// Strongly typed enumeration ProfilingInfo.
	/// </summary>
	public enum ProfilingInfo : uint
	{
		/// <summary>
		/// Strongly typed for value CL_PROFILING_COMMAND_QUEUED.
		/// </summary>
		ProfilingCommandQueued = Cl.PROFILING_COMMAND_QUEUED,

		/// <summary>
		/// Strongly typed for value CL_PROFILING_COMMAND_SUBMIT.
		/// </summary>
		ProfilingCommandSubmit = Cl.PROFILING_COMMAND_SUBMIT,

		/// <summary>
		/// Strongly typed for value CL_PROFILING_COMMAND_START.
		/// </summary>
		ProfilingCommandStart = Cl.PROFILING_COMMAND_START,

		/// <summary>
		/// Strongly typed for value CL_PROFILING_COMMAND_END.
		/// </summary>
		ProfilingCommandEnd = Cl.PROFILING_COMMAND_END,

		/// <summary>
		/// Strongly typed for value CL_PROFILING_COMMAND_COMPLETE.
		/// </summary>
		ProfilingCommandComplete = Cl.PROFILING_COMMAND_COMPLETE,

	}


	}