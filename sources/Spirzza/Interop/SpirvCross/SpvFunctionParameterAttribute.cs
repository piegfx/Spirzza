namespace Spirzza.Interop.SpirvCross
{
    [NativeTypeName("unsigned int")]
    public enum SpvFunctionParameterAttribute : uint
    {
        SpvFunctionParameterAttributeZext = 0,
        SpvFunctionParameterAttributeSext = 1,
        SpvFunctionParameterAttributeByVal = 2,
        SpvFunctionParameterAttributeSret = 3,
        SpvFunctionParameterAttributeNoAlias = 4,
        SpvFunctionParameterAttributeNoCapture = 5,
        SpvFunctionParameterAttributeNoWrite = 6,
        SpvFunctionParameterAttributeNoReadWrite = 7,
        SpvFunctionParameterAttributeMax = 0x7fffffff,
    }
}
