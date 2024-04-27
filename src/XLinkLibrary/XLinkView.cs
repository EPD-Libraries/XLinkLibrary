using Revrs;
using XLinkLibrary.Sections;
using XLinkLibrary.Structures;

namespace XLinkLibrary;

public ref struct XLinkView
{
    public XLinkHeader Header;
    public XLinkUserDataSection UserData;

    public XLinkView(ref RevrsReader reader)
    {
        Header = reader.Read<XLinkHeader>();
        UserData = new(ref reader, Header.UserCount);
    }
}
