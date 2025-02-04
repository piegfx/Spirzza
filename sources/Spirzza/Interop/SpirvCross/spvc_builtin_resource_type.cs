namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum spvc_builtin_resource_type : uint
    {
        SPVC_BUILTIN_RESOURCE_TYPE_UNKNOWN = 0,
        SPVC_BUILTIN_RESOURCE_TYPE_STAGE_INPUT = 1,
        SPVC_BUILTIN_RESOURCE_TYPE_STAGE_OUTPUT = 2,
        SPVC_BUILTIN_RESOURCE_TYPE_INT_MAX = 0x7fffffff,
    }
}
