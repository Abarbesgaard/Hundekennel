using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hundekennel
{
    /// <summary>
    /// Observable object, arver fra INotifypropertyChanged. 
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Denne metode kaldes for at notificere om ændringer i egenskaber (properties) af et objekt
        /// </summary>
        /// <param name="name"><para>Dette er en attribut, der bruges til at fylde parameteren name automatisk,</para> 
        /// hvis den ikke er angivet ved kald af metoden. Den bruger opkaldsstedets medlemsnavn som standardværdi.</param>
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            Debug.WriteLine($"{name}");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
