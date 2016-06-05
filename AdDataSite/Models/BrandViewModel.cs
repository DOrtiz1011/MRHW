using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace AdDataSite.Models
{
    public class BrandViewModel : IExtensibleDataObject, INotifyPropertyChanged
    {
        public string BrandName { get; set; }
        public decimal TotalCoverage { get; set; }

        [NonSerialized()]
        private ExtensionDataObject extensionDataField;

        [Browsable(false)]
        public ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataField;
            }
            set
            {
                extensionDataField = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
