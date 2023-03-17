namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvKernelEnqueueFlags : uint
    {
        SpvKernelEnqueueFlagsNoWait = 0,
        SpvKernelEnqueueFlagsWaitKernel = 1,
        SpvKernelEnqueueFlagsWaitWorkGroup = 2,
        SpvKernelEnqueueFlagsMax = 0x7fffffff,
    }
}
