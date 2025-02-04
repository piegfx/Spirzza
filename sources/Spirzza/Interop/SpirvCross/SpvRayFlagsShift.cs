namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvRayFlagsShift : uint
    {
        SpvRayFlagsOpaqueKHRShift = 0,
        SpvRayFlagsNoOpaqueKHRShift = 1,
        SpvRayFlagsTerminateOnFirstHitKHRShift = 2,
        SpvRayFlagsSkipClosestHitShaderKHRShift = 3,
        SpvRayFlagsCullBackFacingTrianglesKHRShift = 4,
        SpvRayFlagsCullFrontFacingTrianglesKHRShift = 5,
        SpvRayFlagsCullOpaqueKHRShift = 6,
        SpvRayFlagsCullNoOpaqueKHRShift = 7,
        SpvRayFlagsSkipTrianglesKHRShift = 8,
        SpvRayFlagsSkipAABBsKHRShift = 9,
        SpvRayFlagsMax = 0x7fffffff,
    }
}
