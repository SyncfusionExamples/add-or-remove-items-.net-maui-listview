using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    #region ContactsViewModel
    public class ContactsViewModel
    {
        #region Fields

        Random r = new();

        #endregion

        #region Properties

        public ObservableCollection<Contacts> ContactsInfo { get; set; }
        public Command AddCommand { get; set; }
        public Command DeleteCommand { get; set; }
        #endregion

        #region Constructor

        public ContactsViewModel()
        {
            AddCommand = new Command(OnAddTapped);
            DeleteCommand = new Command(OnDeleteTapped);
            GenerateInfo();
        }
        #endregion

        #region Private method

        private void OnDeleteTapped(object obj)
        {
            if (ContactsInfo.Count > 0)
                ContactsInfo.Remove(ContactsInfo[ContactsInfo.Count - 1]);
            else
                App.Current.MainPage.DisplayAlert("Alert", "There is no item in the list", "OK");
        }

        private void OnAddTapped(object obj)
        {
            var details = new Contacts()
            {
                ContactName = CustomerNames[r.Next(1, 50)],
                ContactNumber = r.Next(100, 400).ToString() + "-" + r.Next(500, 800).ToString() + "-" + r.Next(1000, 2000).ToString(),
                ContactImage = "people_circle" + r.Next(0, 19) + ".png"
            };

            ContactsInfo.Add(details);
        }

        internal void GenerateInfo()
        {
            ContactsInfo = new ObservableCollection<Contacts>();

            for (int i = 0; i < 5; i++)
            {
                var contact = new Contacts(CustomerNames[i], r.Next(720, 799).ToString() + " - " + r.Next(3010, 3999).ToString());
                contact.ContactImage = "people_circle" + (i % 19) + ".png";
                ContactsInfo.Add(contact);
            }
        }

        #endregion

        #region Fields

        internal string[] CustomerNames = new string[] {
            "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Michael",
            "Oscar",
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Jennifer",
            "Liz",
            "Pete",
            "Steve",
            "Vince",
            "Zeke",
            "Aiden",
            "Jackson"    ,
            "Mason  "    ,
            "Liam   "    ,
            "Jacob  "    ,
            "Jayden "    ,
            "Ethan  "    ,
            "Noah   "    ,
            "Lucas  "    ,
            "Logan  "    ,
            "Caleb  "    ,
            "Caden  "    ,
            "Jack   "    ,
            "Ryan   "    ,
            "Connor "    ,
            "Michael"    ,
            "Elijah "    ,
            "Brayden"    ,
            "Benjamin"   ,
            "Nicholas"   ,
            "Alexander"  ,
            "William"    ,
            "Matthew"    ,
            "James  "    ,
            "Landon "    ,
            "Nathan "    ,
            "Dylan  "    ,
            "Evan   "    ,
            "Luke   "    ,
            "Andrew "    ,
            "Gabriel"    ,
            "Gavin  "    ,
            "Joshua "    ,
            "Owen   "    ,
            "Daniel "    ,
            "Carter "    ,
            "Tyler  "    ,
            "Cameron"    ,
            "Christian"  ,
            "Wyatt  "    ,
            "Henry  "    ,
            "Eli    "    ,
            "Joseph "    ,
            "Max    "    ,
            "Isaac  "    ,
            "Samuel "    ,
            "Anthony"    ,
            "Grayson"    ,
            "Zachary"    ,
            "David  "    ,
            "Christopher",
            "John   "    ,
            "Isaiah "    ,
            "Levi   "    ,
            "Jonathan"   ,
            "Oliver "    ,
            "Chase  "    ,
            "Cooper "    ,
            "Tristan"    ,
            "Colton "    ,
            "Austin "    ,
            "Colin  "    ,
            "Charlie"    ,
            "Dominic"    ,
            "Parker "    ,
            "Hunter "    ,
            "Thomas "    ,
            "Alex   "    ,
            "Ian    "    ,
            "Jordan "    ,
            "Cole   "    ,
            "Julian "    ,
            "Aaron  "    ,
            "Carson "    ,
            "Miles  "    ,
            "Blake  "    ,
            "Brody  "    ,
            "Adam   "    ,
            "Sebastian"  ,
            "Adrian "    ,
            "Nolan  "    ,
            "Sean   "    ,
            "Riley  "    ,
            "Bentley"    ,
            "Xavier "    ,
            "Hayden "    ,
            "Jeremiah"   ,
            "Jason  "    ,
            "Jake   "    ,
            "Asher  "    ,
            "Micah  "    ,
            "Jace   "    ,
            "Brandon"    ,
            "Josiah "    ,
            "Hudson "    ,
            "Nathaniel"  ,
            "Bryson "    ,
            "Ryder  "    ,
            "Justin "    ,
            "Bryce  "    ,
        };
        #endregion

    }

    #endregion
}
