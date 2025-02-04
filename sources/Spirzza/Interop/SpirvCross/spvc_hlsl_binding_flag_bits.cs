namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum spvc_hlsl_binding_flag_bits : uint
    {
        SPVC_HLSL_BINDING_AUTO_NONE_BIT = 0,
        SPVC_HLSL_BINDING_AUTO_PUSH_CONSTANT_BIT = 1 << 0,
        SPVC_HLSL_BINDING_AUTO_CBV_BIT = 1 << 1,
        SPVC_HLSL_BINDING_AUTO_SRV_BIT = 1 << 2,
        SPVC_HLSL_BINDING_AUTO_UAV_BIT = 1 << 3,
        SPVC_HLSL_BINDING_AUTO_SAMPLER_BIT = 1 << 4,
        SPVC_HLSL_BINDING_AUTO_ALL = 0x7fffffff,
    }
}
