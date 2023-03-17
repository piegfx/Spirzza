namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvKernelProfilingInfoMask : uint
    {
        SpvKernelProfilingInfoMaskNone = 0,
        SpvKernelProfilingInfoCmdExecTimeMask = 0x00000001,
    }
}
