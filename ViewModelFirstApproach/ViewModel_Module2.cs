using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelFirstApproach
{
   public class ViewModel_Module2 : ViewModelBase
    {

        private string _TextProp;
        public string TextProp
        {
            get
            {
                return this._TextProp;
            }
            set
            {
                this._TextProp = value;
                this.RaisePropertyChanged("TextProp");
            }
        }

    }
}
    

