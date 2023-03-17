namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvFPOperationMode : uint
    {
        SpvFPOperationModeIEEE = 0,
        SpvFPOperationModeALT = 1,
        SpvFPOperationModeMax = 0x7fffffff,
    }
}
