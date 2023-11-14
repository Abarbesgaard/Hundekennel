using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundekennel.Model
{
    /// <summary>
    /// Hundens helbred
    /// </summary>
    public class Health
    {
        #region Properties
        /// <summary>
        /// Hoftedysplasi
        /// </summary>
        public string? HipDysplacia { get; set; }
        /// <summary>
        /// Albue Dysplasi
        /// </summary>
        public string? ElbowDysplacia { get; set; }
        /// <summary>
        /// Spondylose
        /// </summary>
        public string? Spondylose { get; set; }
        /// <summary>
        /// Hjertefejl
        /// </summary>
        public string? HeartCondition { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for hundens helbred
        /// </summary>
        /// <param name="hipDysplacia">Hoftedysplaci</param>
        /// <param name="elbowDysplacia">AlbueDysplaci</param>
        /// <param name="spondylose">Spondylose</param>
        /// <param name="heartCondition">Hjertefejl</param>
        public Health(string hipDysplacia, string elbowDysplacia, string spondylose, string heartCondition)
        {
            HipDysplacia = hipDysplacia;
            ElbowDysplacia = elbowDysplacia;
            Spondylose = spondylose;
            HeartCondition = heartCondition;
        }
        #endregion
    }
}
