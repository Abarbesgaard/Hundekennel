using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WPF_Hundekennel.Model
{
    public class Health
    {
        public string HipDysplacia { get; set; }
        public string ElbowDysplacia { get; set; }
        public string Spondylose { get; set; }
        public string HeartCondition { get; set; }


        public Health(string hipDysplacia, string elbowDysplacia, string spondylose, string heartCondition) 
        {
            HipDysplacia = hipDysplacia;
            ElbowDysplacia= elbowDysplacia;
            Spondylose = spondylose;
            HeartCondition = heartCondition;
        }
    }
}
