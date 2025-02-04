namespace Spirzza.Interop.SpirvCross
{
    public partial struct spvc_msl_vertex_attribute
    {
        [NativeTypeName("unsigned int")]
        public uint location;

        [NativeTypeName("unsigned int")]
        public uint msl_buffer;

        [NativeTypeName("unsigned int")]
        public uint msl_offset;

        [NativeTypeName("unsigned int")]
        public uint msl_stride;

        public spvc_bool per_instance;

        [NativeTypeName("spvc_msl_vertex_format")]
        public spvc_msl_shader_variable_format format;

        public SpvBuiltIn builtin;
    }
}
