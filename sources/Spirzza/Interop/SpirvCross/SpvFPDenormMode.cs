namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvFPDenormMode : uint
    {
        SpvFPDenormModePreserve = 0,
        SpvFPDenormModeFlushToZero = 1,
        SpvFPDenormModeMax = 0x7fffffff,
    }
}
