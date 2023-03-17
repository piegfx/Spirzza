using System;

namespace Spirzza.Interop.SpirvCross
{
    public partial struct spvc_buffer_range
    {
        [NativeTypeName("unsigned int")]
        public uint index;

        [NativeTypeName("size_t")]
        public UIntPtr offset;

        [NativeTypeName("size_t")]
        public UIntPtr range;
    }
}
