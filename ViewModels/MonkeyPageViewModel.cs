using MonkeysMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MonkeysMVVM.ViewModels
{
    public class MonkeyPageViewModel:ViewModel
    {

        private string country;
        public string Country { get { return country; } set {  country = value; OnPropertyChanged(); ((Command)SearchByCountryCommand).ChangeCanExecute(); } }
        private int count;
        public int Count { get { return count; } set { count = value; OnPropertyChanged(); } }

        public ICommand SearchByCountryCommand { get; set; }

        private Monkey monkey;
        public string Name { get { return monkey.Name; } }
        public string ImageUrl { get { return monkey.ImageUrl; } }

        public MonkeyPageViewModel()
        {
            monkey = new Monkey() { Name = "אין קופים כרגע" };
            SearchByCountryCommand = new Command(FindMonkeys,() => Country!=null);
        }

        private void FindMonkeys()
        {
            
        }
    }
}
