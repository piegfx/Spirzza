namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvMemoryModel : uint
    {
        SpvMemoryModelSimple = 0,
        SpvMemoryModelGLSL450 = 1,
        SpvMemoryModelOpenCL = 2,
        SpvMemoryModelVulkan = 3,
        SpvMemoryModelVulkanKHR = 3,
        SpvMemoryModelMax = 0x7fffffff,
    }
}
