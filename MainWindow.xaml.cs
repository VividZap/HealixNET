using System.Collections.ObjectModel;
using System.Windows;
using SelfHealingSDK.Models;

namespace SelfHealingDashboard.ViewModels
{
    public class MainWindowViewModel
    {
        public ObservableCollection<HealingEvent> HealingEvents { get; set; }
     
        public MainWindowViewModel()
        {
            // Load HealingEvents from SDK or file
            HealingEvents = new ObservableCollection<HealingEvent>();
        }
    }
}