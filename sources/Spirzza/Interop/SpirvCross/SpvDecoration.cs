namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvDecoration : uint
    {
        SpvDecorationRelaxedPrecision = 0,
        SpvDecorationSpecId = 1,
        SpvDecorationBlock = 2,
        SpvDecorationBufferBlock = 3,
        SpvDecorationRowMajor = 4,
        SpvDecorationColMajor = 5,
        SpvDecorationArrayStride = 6,
        SpvDecorationMatrixStride = 7,
        SpvDecorationGLSLShared = 8,
        SpvDecorationGLSLPacked = 9,
        SpvDecorationCPacked = 10,
        SpvDecorationBuiltIn = 11,
        SpvDecorationNoPerspective = 13,
        SpvDecorationFlat = 14,
        SpvDecorationPatch = 15,
        SpvDecorationCentroid = 16,
        SpvDecorationSample = 17,
        SpvDecorationInvariant = 18,
        SpvDecorationRestrict = 19,
        SpvDecorationAliased = 20,
        SpvDecorationVolatile = 21,
        SpvDecorationConstant = 22,
        SpvDecorationCoherent = 23,
        SpvDecorationNonWritable = 24,
        SpvDecorationNonReadable = 25,
        SpvDecorationUniform = 26,
        SpvDecorationUniformId = 27,
        SpvDecorationSaturatedConversion = 28,
        SpvDecorationStream = 29,
        SpvDecorationLocation = 30,
        SpvDecorationComponent = 31,
        SpvDecorationIndex = 32,
        SpvDecorationBinding = 33,
        SpvDecorationDescriptorSet = 34,
        SpvDecorationOffset = 35,
        SpvDecorationXfbBuffer = 36,
        SpvDecorationXfbStride = 37,
        SpvDecorationFuncParamAttr = 38,
        SpvDecorationFPRoundingMode = 39,
        SpvDecorationFPFastMathMode = 40,
        SpvDecorationLinkageAttributes = 41,
        SpvDecorationNoContraction = 42,
        SpvDecorationInputAttachmentIndex = 43,
        SpvDecorationAlignment = 44,
        SpvDecorationMaxByteOffset = 45,
        SpvDecorationAlignmentId = 46,
        SpvDecorationMaxByteOffsetId = 47,
        SpvDecorationNoSignedWrap = 4469,
        SpvDecorationNoUnsignedWrap = 4470,
        SpvDecorationExplicitInterpAMD = 4999,
        SpvDecorationOverrideCoverageNV = 5248,
        SpvDecorationPassthroughNV = 5250,
        SpvDecorationViewportRelativeNV = 5252,
        SpvDecorationSecondaryViewportRelativeNV = 5256,
        SpvDecorationPerPrimitiveEXT = 5271,
        SpvDecorationPerPrimitiveNV = 5271,
        SpvDecorationPerViewNV = 5272,
        SpvDecorationPerTaskNV = 5273,
        SpvDecorationPerVertexKHR = 5285,
        SpvDecorationPerVertexNV = 5285,
        SpvDecorationNonUniform = 5300,
        SpvDecorationNonUniformEXT = 5300,
        SpvDecorationRestrictPointer = 5355,
        SpvDecorationRestrictPointerEXT = 5355,
        SpvDecorationAliasedPointer = 5356,
        SpvDecorationAliasedPointerEXT = 5356,
        SpvDecorationBindlessSamplerNV = 5398,
        SpvDecorationBindlessImageNV = 5399,
        SpvDecorationBoundSamplerNV = 5400,
        SpvDecorationBoundImageNV = 5401,
        SpvDecorationSIMTCallINTEL = 5599,
        SpvDecorationReferencedIndirectlyINTEL = 5602,
        SpvDecorationClobberINTEL = 5607,
        SpvDecorationSideEffectsINTEL = 5608,
        SpvDecorationVectorComputeVariableINTEL = 5624,
        SpvDecorationFuncParamIOKindINTEL = 5625,
        SpvDecorationVectorComputeFunctionINTEL = 5626,
        SpvDecorationStackCallINTEL = 5627,
        SpvDecorationGlobalVariableOffsetINTEL = 5628,
        SpvDecorationCounterBuffer = 5634,
        SpvDecorationHlslCounterBufferGOOGLE = 5634,
        SpvDecorationHlslSemanticGOOGLE = 5635,
        SpvDecorationUserSemantic = 5635,
        SpvDecorationUserTypeGOOGLE = 5636,
        SpvDecorationFunctionRoundingModeINTEL = 5822,
        SpvDecorationFunctionDenormModeINTEL = 5823,
        SpvDecorationRegisterINTEL = 5825,
        SpvDecorationMemoryINTEL = 5826,
        SpvDecorationNumbanksINTEL = 5827,
        SpvDecorationBankwidthINTEL = 5828,
        SpvDecorationMaxPrivateCopiesINTEL = 5829,
        SpvDecorationSinglepumpINTEL = 5830,
        SpvDecorationDoublepumpINTEL = 5831,
        SpvDecorationMaxReplicatesINTEL = 5832,
        SpvDecorationSimpleDualPortINTEL = 5833,
        SpvDecorationMergeINTEL = 5834,
        SpvDecorationBankBitsINTEL = 5835,
        SpvDecorationForcePow2DepthINTEL = 5836,
        SpvDecorationBurstCoalesceINTEL = 5899,
        SpvDecorationCacheSizeINTEL = 5900,
        SpvDecorationDontStaticallyCoalesceINTEL = 5901,
        SpvDecorationPrefetchINTEL = 5902,
        SpvDecorationStallEnableINTEL = 5905,
        SpvDecorationFuseLoopsInFunctionINTEL = 5907,
        SpvDecorationAliasScopeINTEL = 5914,
        SpvDecorationNoAliasINTEL = 5915,
        SpvDecorationBufferLocationINTEL = 5921,
        SpvDecorationIOPipeStorageINTEL = 5944,
        SpvDecorationFunctionFloatingPointModeINTEL = 6080,
        SpvDecorationSingleElementVectorINTEL = 6085,
        SpvDecorationVectorComputeCallableFunctionINTEL = 6087,
        SpvDecorationMediaBlockIOINTEL = 6140,
        SpvDecorationMax = 0x7fffffff,
    }
}
