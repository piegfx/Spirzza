namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvSelectionControlMask : uint
    {
        SpvSelectionControlMaskNone = 0,
        SpvSelectionControlFlattenMask = 0x00000001,
        SpvSelectionControlDontFlattenMask = 0x00000002,
    }
}
