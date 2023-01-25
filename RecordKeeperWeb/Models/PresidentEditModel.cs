using RecordKeeperBizObjects;
namespace RecordKeeperWeb.Models
{
    public class PresidentEditModel : bizPresident
    {
        public List<bizParty> PartyList()
        {
            return bizParty.GetAll();
        }
    }
}
