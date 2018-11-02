using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darkness.UI.ViewModel
{
    public class Data
    {
        string _id;
        string _name;
        string _value;

        #region Properties
        public string ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Value { get => _value; set => _value = value; }
        #endregion

        #region Constructors
        public Data(string id, string name, string value)
        {
            _id = id;
            _name = name;
            _value = value;
        }
        #endregion
    }

    public class DataViewModel : ViewModel
    {
        #region Fields
        Data _data;
        #endregion

        #region Bindable Properties
        public string ID
        {
            get => _data.ID;
            set
            {
                _data.ID = value;
                NotifyPropertyChanged();
            }
        }
        public string Name
        {
            get => _data.Name;
            set
            {
                _data.Name = value;
                NotifyPropertyChanged();
            }
        }
        public string Value
        {
            get => _data.Value;
            set
            {
                _data.Value = value;
                NotifyPropertyChanged();
            }
        }
        #endregion

        #region Constructors
        public DataViewModel(string id, string name, string value)
        {
            _data = new Data(id, name, value);
        }
        #endregion
    }

    public class CommonTableViewModel : ViewModel
    {
        #region Fields
        ICollection<DataViewModel> _data = new List<DataViewModel>()
        {
            new DataViewModel("Color1", "green", "#FF00FF00"),
            new DataViewModel("Color1", "red", "#FFFF0000"),
            new DataViewModel("Color1", "blue", "#FF0000FF"),
        };
        #endregion

        #region Bindable Properties
        public ICollection<DataViewModel> Data
        {
            get => _data;
            set
            {
                _data = value;
                NotifyPropertyChanged();
            }
        }
        #endregion

        #region Drag and Drop

        #endregion
    }
}
