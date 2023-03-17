namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvAccessQualifier : uint
    {
        SpvAccessQualifierReadOnly = 0,
        SpvAccessQualifierWriteOnly = 1,
        SpvAccessQualifierReadWrite = 2,
        SpvAccessQualifierMax = 0x7fffffff,
    }
}
