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
    public Pointer TriggerOverwriteParamTablePos;
    public Pointer LocalPropertyNameRefTablePos;
    public uint NumLocalPropertyNameRefTable;
    public uint NumLocalPropertyEnumNameRefTable;
    public uint NumDirectValueTable;
    public uint NumRandomTable;
    public uint NumCurveTable;
    public uint NumCurvePointTable;
    public Pointer ExRegionPos;
    public int UserCount;
    public Pointer ConditionTablePos;
    public Pointer NameTablePos;
}
