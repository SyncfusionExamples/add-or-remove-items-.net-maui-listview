using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    #region Contacts
    public class Contacts : INotifyPropertyChanged
    {
        #region Fields

        private string contactName;
        private string contactNumber;
        private ImageSource contactImage;

        #endregion

        #region Constructor
        public Contacts(string name, string number)
        {
            contactName = name;
            contactNumber = number;
        }

        public Contacts()
        {

        }
        #endregion

        #region Properties
        public string ContactName
        {
            get { return contactName; }
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    this.RaisedOnPropertyChanged("ContactName");
                }
            }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (contactNumber != value)
                {
                    contactNumber = value;
                    this.RaisedOnPropertyChanged("ContactNumber");
                }
            }
        }

        public ImageSource ContactImage
        {
            get { return contactImage; }
            set
            {
                if (contactImage != value)
                {
                    contactImage = value;
                    this.RaisedOnPropertyChanged("ContactImage");
                }
            }
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
        #endregion
    }

    #endregion
}
