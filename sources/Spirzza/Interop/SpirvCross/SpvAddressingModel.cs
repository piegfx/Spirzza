namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvAddressingModel : uint
    {
        SpvAddressingModelLogical = 0,
        SpvAddressingModelPhysical32 = 1,
        SpvAddressingModelPhysical64 = 2,
        SpvAddressingModelPhysicalStorageBuffer64 = 5348,
        SpvAddressingModelPhysicalStorageBuffer64EXT = 5348,
        SpvAddressingModelMax = 0x7fffffff,
    }
}
