using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CollectionViewIssue.Models;
using Xamarin.Forms;

namespace CollectionViewIssue.ViewModels
{
    class GroupsViewModel : BaseViewModel
    {
        public ObservableCollection<ItemGroup> Groups { get; } = new ObservableCollection<ItemGroup>();

        public ICommand ShowStudents { get; set; }

        public string counter = "2";

        public string Counter
        {
            get => counter;
            set => SetProperty(ref counter, value);
        }

        public GroupsViewModel()
        {
            PrepareData();
            ShowStudents = new Command(PrepareData);
        }

        private void PrepareData()
        {
            var counterInt = 2;
            if (int.TryParse(counter, out int result))
            {
                counterInt = result;
            }

            var list1 = new List<Item>();
            var list2 = new List<Item>();
            for (int i = 0; i < counterInt; i++)
            {
                if (i % 2 == 0)
                {
                    list2.Add(new Item
                    {
                        Description = $"Student {i}",
                        Id = i.ToString(),
                        Text = $"Name {i}"

                    });
                }
                else
                {
                    list1.Add(new Item
                    {
                        Description = $"Student {i}",
                        Id = i.ToString(),
                        Text = $"Name {i}"

                    });
                }


            }

            Groups.Clear();
            Groups.Add(new ItemGroup("Uneven students", "Students with Uneven ids", list1));
            Groups.Add(new ItemGroup("Even students", "Students with even ids", list2));
        }
    }
}
