namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvExecutionMode : uint
    {
        SpvExecutionModeInvocations = 0,
        SpvExecutionModeSpacingEqual = 1,
        SpvExecutionModeSpacingFractionalEven = 2,
        SpvExecutionModeSpacingFractionalOdd = 3,
        SpvExecutionModeVertexOrderCw = 4,
        SpvExecutionModeVertexOrderCcw = 5,
        SpvExecutionModePixelCenterInteger = 6,
        SpvExecutionModeOriginUpperLeft = 7,
        SpvExecutionModeOriginLowerLeft = 8,
        SpvExecutionModeEarlyFragmentTests = 9,
        SpvExecutionModePointMode = 10,
        SpvExecutionModeXfb = 11,
        SpvExecutionModeDepthReplacing = 12,
        SpvExecutionModeDepthGreater = 14,
        SpvExecutionModeDepthLess = 15,
        SpvExecutionModeDepthUnchanged = 16,
        SpvExecutionModeLocalSize = 17,
        SpvExecutionModeLocalSizeHint = 18,
        SpvExecutionModeInputPoints = 19,
        SpvExecutionModeInputLines = 20,
        SpvExecutionModeInputLinesAdjacency = 21,
        SpvExecutionModeTriangles = 22,
        SpvExecutionModeInputTrianglesAdjacency = 23,
        SpvExecutionModeQuads = 24,
        SpvExecutionModeIsolines = 25,
        SpvExecutionModeOutputVertices = 26,
        SpvExecutionModeOutputPoints = 27,
        SpvExecutionModeOutputLineStrip = 28,
        SpvExecutionModeOutputTriangleStrip = 29,
        SpvExecutionModeVecTypeHint = 30,
        SpvExecutionModeContractionOff = 31,
        SpvExecutionModeInitializer = 33,
        SpvExecutionModeFinalizer = 34,
        SpvExecutionModeSubgroupSize = 35,
        SpvExecutionModeSubgroupsPerWorkgroup = 36,
        SpvExecutionModeSubgroupsPerWorkgroupId = 37,
        SpvExecutionModeLocalSizeId = 38,
        SpvExecutionModeLocalSizeHintId = 39,
        SpvExecutionModeSubgroupUniformControlFlowKHR = 4421,
        SpvExecutionModePostDepthCoverage = 4446,
        SpvExecutionModeDenormPreserve = 4459,
        SpvExecutionModeDenormFlushToZero = 4460,
        SpvExecutionModeSignedZeroInfNanPreserve = 4461,
        SpvExecutionModeRoundingModeRTE = 4462,
        SpvExecutionModeRoundingModeRTZ = 4463,
        SpvExecutionModeEarlyAndLateFragmentTestsAMD = 5017,
        SpvExecutionModeStencilRefReplacingEXT = 5027,
        SpvExecutionModeStencilRefUnchangedFrontAMD = 5079,
        SpvExecutionModeStencilRefGreaterFrontAMD = 5080,
        SpvExecutionModeStencilRefLessFrontAMD = 5081,
        SpvExecutionModeStencilRefUnchangedBackAMD = 5082,
        SpvExecutionModeStencilRefGreaterBackAMD = 5083,
        SpvExecutionModeStencilRefLessBackAMD = 5084,
        SpvExecutionModeOutputLinesEXT = 5269,
        SpvExecutionModeOutputLinesNV = 5269,
        SpvExecutionModeOutputPrimitivesEXT = 5270,
        SpvExecutionModeOutputPrimitivesNV = 5270,
        SpvExecutionModeDerivativeGroupQuadsNV = 5289,
        SpvExecutionModeDerivativeGroupLinearNV = 5290,
        SpvExecutionModeOutputTrianglesEXT = 5298,
        SpvExecutionModeOutputTrianglesNV = 5298,
        SpvExecutionModePixelInterlockOrderedEXT = 5366,
        SpvExecutionModePixelInterlockUnorderedEXT = 5367,
        SpvExecutionModeSampleInterlockOrderedEXT = 5368,
        SpvExecutionModeSampleInterlockUnorderedEXT = 5369,
        SpvExecutionModeShadingRateInterlockOrderedEXT = 5370,
        SpvExecutionModeShadingRateInterlockUnorderedEXT = 5371,
        SpvExecutionModeSharedLocalMemorySizeINTEL = 5618,
        SpvExecutionModeRoundingModeRTPINTEL = 5620,
        SpvExecutionModeRoundingModeRTNINTEL = 5621,
        SpvExecutionModeFloatingPointModeALTINTEL = 5622,
        SpvExecutionModeFloatingPointModeIEEEINTEL = 5623,
        SpvExecutionModeMaxWorkgroupSizeINTEL = 5893,
        SpvExecutionModeMaxWorkDimINTEL = 5894,
        SpvExecutionModeNoGlobalOffsetINTEL = 5895,
        SpvExecutionModeNumSIMDWorkitemsINTEL = 5896,
        SpvExecutionModeSchedulerTargetFmaxMhzINTEL = 5903,
        SpvExecutionModeNamedBarrierCountINTEL = 6417,
        SpvExecutionModeMax = 0x7fffffff,
    }
}
