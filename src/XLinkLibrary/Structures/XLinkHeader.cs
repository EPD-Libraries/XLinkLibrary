namespace XLinkLibrary.Structures;

public struct XLinkHeader
{
    public const uint MAGIC = 0x4B4E4C58;

    public uint Magic;
    public uint DataSize;
    public uint Version;
    public uint NumResParam;
    public uint NumResAssetParam;
    public uint NumResTriggerOverwriteParam;
    public IntPtr TriggerOverwriteParamTablePos;
    public IntPtr LocalPropertyNameRefTablePos;
    public uint NumLocalPropertyNameRefTable;
    public uint NumLocalPropertyEnumNameRefTable;
    public uint NumDirectValueTable;
    public uint NumRandomTable;
    public uint NumCurveTable;
    public uint NumCurvePointTable;
    public IntPtr ExRegionPos;
    public int UserCount;
    public IntPtr ConditionTablePos;
    public IntPtr NameTablePos;
}
