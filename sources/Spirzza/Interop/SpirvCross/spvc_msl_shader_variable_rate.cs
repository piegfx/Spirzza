namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum spvc_msl_shader_variable_rate : uint
    {
        SPVC_MSL_SHADER_VARIABLE_RATE_PER_VERTEX = 0,
        SPVC_MSL_SHADER_VARIABLE_RATE_PER_PRIMITIVE = 1,
        SPVC_MSL_SHADER_VARIABLE_RATE_PER_PATCH = 2,
        SPVC_MSL_SHADER_VARIABLE_RATE_INT_MAX = 0x7fffffff,
    }
}
