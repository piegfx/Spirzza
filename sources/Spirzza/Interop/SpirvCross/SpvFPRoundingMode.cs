namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvFPRoundingMode : uint
    {
        SpvFPRoundingModeRTE = 0,
        SpvFPRoundingModeRTZ = 1,
        SpvFPRoundingModeRTP = 2,
        SpvFPRoundingModeRTN = 3,
        SpvFPRoundingModeMax = 0x7fffffff,
    }
}
