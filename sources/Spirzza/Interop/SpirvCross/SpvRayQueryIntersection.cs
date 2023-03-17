namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvRayQueryIntersection : uint
    {
        SpvRayQueryIntersectionRayQueryCandidateIntersectionKHR = 0,
        SpvRayQueryIntersectionRayQueryCommittedIntersectionKHR = 1,
        SpvRayQueryIntersectionMax = 0x7fffffff,
    }
}
