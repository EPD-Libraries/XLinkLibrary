using Revrs;
using XLinkLibrary;
using XLinkLibrary.Structures;

byte[] data = File.ReadAllBytes(args[0]);

RevrsReader reader = RevrsReader.Native(data);
XLinkView xLink = new(ref reader);

Console.WriteLine($"{nameof(XLinkHeader.Magic)}: {xLink.Header.Magic}");
Console.WriteLine($"{nameof(XLinkHeader.DataSize)}: {xLink.Header.DataSize}");
Console.WriteLine($"{nameof(XLinkHeader.Version)}: {xLink.Header.Version}");
Console.WriteLine($"{nameof(XLinkHeader.NumResParam)}: {xLink.Header.NumResParam}");
Console.WriteLine($"{nameof(XLinkHeader.NumResAssetParam)}: {xLink.Header.NumResAssetParam}");
Console.WriteLine($"{nameof(XLinkHeader.NumResTriggerOverwriteParam)}: {xLink.Header.NumResTriggerOverwriteParam}");
Console.WriteLine($"{nameof(XLinkHeader.TriggerOverwriteParamTablePos)}: {xLink.Header.TriggerOverwriteParamTablePos}");
Console.WriteLine($"{nameof(XLinkHeader.LocalPropertyNameRefTablePos)}: {xLink.Header.LocalPropertyNameRefTablePos}");
Console.WriteLine($"{nameof(XLinkHeader.NumLocalPropertyNameRefTable)}: {xLink.Header.NumLocalPropertyNameRefTable}");
Console.WriteLine($"{nameof(XLinkHeader.NumLocalPropertyEnumNameRefTable)}: {xLink.Header.NumLocalPropertyEnumNameRefTable}");
Console.WriteLine($"{nameof(XLinkHeader.NumDirectValueTable)}: {xLink.Header.NumDirectValueTable}");
Console.WriteLine($"{nameof(XLinkHeader.NumRandomTable)}: {xLink.Header.NumRandomTable}");
Console.WriteLine($"{nameof(XLinkHeader.NumCurveTable)}: {xLink.Header.NumCurveTable}");
Console.WriteLine($"{nameof(XLinkHeader.NumCurvePointTable)}: {xLink.Header.NumCurvePointTable}");
Console.WriteLine($"{nameof(XLinkHeader.ExRegionPos)}: {xLink.Header.ExRegionPos}");
Console.WriteLine($"{nameof(XLinkHeader.UserCount)}: {xLink.Header.UserCount}");
Console.WriteLine($"{nameof(XLinkHeader.ConditionTablePos)}: {xLink.Header.ConditionTablePos}");
Console.WriteLine($"{nameof(XLinkHeader.NameTablePos)}: {xLink.Header.NameTablePos}");