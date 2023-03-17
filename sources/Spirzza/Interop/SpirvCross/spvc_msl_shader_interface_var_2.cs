namespace Spirzza.Interop.SpirvCross
{
    public partial struct spvc_msl_shader_interface_var_2
    {
        [NativeTypeName("unsigned int")]
        public uint location;

        public spvc_msl_shader_variable_format format;

        public SpvBuiltIn builtin;

        [NativeTypeName("unsigned int")]
        public uint vecsize;

        public spvc_msl_shader_variable_rate rate;
    }
}
