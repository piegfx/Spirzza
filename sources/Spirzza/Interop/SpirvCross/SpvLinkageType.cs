namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvLinkageType : uint
    {
        SpvLinkageTypeExport = 0,
        SpvLinkageTypeImport = 1,
        SpvLinkageTypeLinkOnceODR = 2,
        SpvLinkageTypeMax = 0x7fffffff,
    }
}
