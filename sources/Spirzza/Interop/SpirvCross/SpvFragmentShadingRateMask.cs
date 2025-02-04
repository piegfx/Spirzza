namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvFragmentShadingRateMask : uint
    {
        SpvFragmentShadingRateMaskNone = 0,
        SpvFragmentShadingRateVertical2PixelsMask = 0x00000001,
        SpvFragmentShadingRateVertical4PixelsMask = 0x00000002,
        SpvFragmentShadingRateHorizontal2PixelsMask = 0x00000004,
        SpvFragmentShadingRateHorizontal4PixelsMask = 0x00000008,
    }
}
