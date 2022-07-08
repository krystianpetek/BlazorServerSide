using BlazorServerSide.Models;

namespace BlazorServerSide.Database
{
    public class WSKList
    {
        public List<WSK> listWSK = new List<WSK>()
        {
                new WSK(1954, null, null, null, null),
                new WSK(1955, 173, 1288, 42515, 57831),
                new WSK(1956, 2326, 17882, 70799, 115144),
                new WSK(1957,18103,45445,113357,178145){Localization = "WFM"},
                new WSK(1957,18103,45445,1472,4462){Localization = "Nowa dęba"},
                new WSK(1958,40514,83532,171137,236338),
                new WSK(1959,84194,126763,192369,251375),
                new WSK(1960,132985,212064,null,null)
        };
    }
}
