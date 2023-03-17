namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvRayQueryCandidateIntersectionType : uint
    {
        SpvRayQueryCandidateIntersectionTypeRayQueryCandidateIntersectionTriangleKHR = 0,
        SpvRayQueryCandidateIntersectionTypeRayQueryCandidateIntersectionAABBKHR = 1,
        SpvRayQueryCandidateIntersectionTypeMax = 0x7fffffff,
    }
}
