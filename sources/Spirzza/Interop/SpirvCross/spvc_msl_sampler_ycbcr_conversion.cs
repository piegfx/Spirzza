namespace Spirzza.Interop.SpirvCross
{
    public partial struct spvc_msl_sampler_ycbcr_conversion
    {
        [NativeTypeName("unsigned int")]
        public uint planes;

        public spvc_msl_format_resolution resolution;

        public spvc_msl_sampler_filter chroma_filter;

        public spvc_msl_chroma_location x_chroma_offset;

        public spvc_msl_chroma_location y_chroma_offset;

        [NativeTypeName("spvc_msl_component_swizzle[4]")]
        public _swizzle_e__FixedBuffer swizzle;

        public spvc_msl_sampler_ycbcr_model_conversion ycbcr_model;

        public spvc_msl_sampler_ycbcr_range ycbcr_range;

        [NativeTypeName("unsigned int")]
        public uint bpc;

        public partial struct _swizzle_e__FixedBuffer
        {
            public spvc_msl_component_swizzle e0;
            public spvc_msl_component_swizzle e1;
            public spvc_msl_component_swizzle e2;
            public spvc_msl_component_swizzle e3;

            public unsafe ref spvc_msl_component_swizzle this[int index]
            {
                get
                {
                    fixed (spvc_msl_component_swizzle* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
