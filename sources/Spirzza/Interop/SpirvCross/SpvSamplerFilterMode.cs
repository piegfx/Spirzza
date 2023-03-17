namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvSamplerFilterMode : uint
    {
        SpvSamplerFilterModeNearest = 0,
        SpvSamplerFilterModeLinear = 1,
        SpvSamplerFilterModeMax = 0x7fffffff,
    }
}
