using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hundekennel.Command
{
    /// <summary>
    /// Generel command til at eksekvere kommandoer baseret på parametre
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Properties
        private Action<Object> _execute;
        private Func<Object, bool> _canExecute;
        #endregion

        #region Event Handler
        /// <summary>
        /// Eventhandler for relay command
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested += value; }
        }
        #endregion

        #region Relay Command Constructor
        /// <summary>
        /// Constructor for Relay Kommandoen
        /// </summary>
        /// <param name="execute">Eksekverer kommandoen</param>
        /// <param name="canExecute">Om kommandoen kan eksekverer</param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        #endregion

        #region Can execute metode
        /// <summary>
        /// Er en metode, der returnerer en bool-værdi. 
        /// </summary>
        /// <param name="parameter">Den kan tage imod ethvert objekt som input.</param>
        /// <returns>True or False.</returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }
        #endregion

        #region Execute
        /// <summary>
        /// Når Execute kaldes, bruger den den tilknyttede metode i _execute for at udføre en bestemt handling <br> med den medfølgende parameter </br>
        /// </summary>
        /// <param name="parameter">Den kan tage imod ethvert objekt som input.</param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
        #endregion
    }
}
