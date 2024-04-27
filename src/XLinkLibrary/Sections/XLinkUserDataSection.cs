using Revrs;

namespace XLinkLibrary.Sections;

public ref struct XLinkUserDataSection
{
    public Span<uint> Hashes;
    public Span<uint> Offsets;

    public XLinkUserDataSection(ref RevrsReader reader, int userCount)
    {
        Hashes = reader.ReadSpan<uint>(userCount);
        Offsets = reader.ReadSpan<uint>(userCount);
    }
}
