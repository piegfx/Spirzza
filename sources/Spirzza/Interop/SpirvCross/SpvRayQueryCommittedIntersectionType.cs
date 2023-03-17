namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvRayQueryCommittedIntersectionType : uint
    {
        SpvRayQueryCommittedIntersectionTypeRayQueryCommittedIntersectionNoneKHR = 0,
        SpvRayQueryCommittedIntersectionTypeRayQueryCommittedIntersectionTriangleKHR = 1,
        SpvRayQueryCommittedIntersectionTypeRayQueryCommittedIntersectionGeneratedKHR = 2,
        SpvRayQueryCommittedIntersectionTypeMax = 0x7fffffff,
    }
}
