using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;
using System.ComponentModel.DataAnnotations;

namespace RecordKeeperBizObjects
{
    public class bizParty : bizObject<bizParty>
    {
        string partynameval = "";
        string colorval = "";
        int presidentcountval = 0;
        int yearstartval = 0;
        List<bizPresident> lstPresident;

        public bizParty()
        {
        }
        
        public int PartyId
        {
            get => this.PrimaryKeyValue;
            set => this.PrimaryKeyValue = value;
        }
        [Required]
        [Display(Name = "Party Name")]
        public string Party
        {
            get { return partynameval; }
            set
            {
                partynameval = value;
                InvokePropertyChanged();
            }
        }
        [Required]
        [Display(Name = "Color")]
        public string Color
        {
            get { return colorval; }
            set
            {
                colorval = value;
                InvokePropertyChanged();
            }
        }

        [Required]
        [Display(Name = "Year Start")]
        public int YearStarted
        {
            get { return yearstartval; }
            set
            {
                yearstartval = value;
                InvokePropertyChanged();
            }
        }
        public int PresidentCount
        {
            get { return presidentcountval; }
            set
            {
                presidentcountval = value;
                InvokePropertyChanged();
            }
        }
        public List<bizPresident> PresidentList(bool refresh)
        {
            //if repeat this line of code will call sproc x2
            if (refresh == true || lstPresident == null)
            {
                return bizPresident.GetList("Party", this.Party);
            }
            return lstPresident;
        }
    }
}
