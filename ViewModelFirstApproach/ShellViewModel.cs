using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelFirstApproach
{
  public  class ShellViewModel:ViewModelBase
    {
      private List<string> _Collection;
      public List<string> Collection
      {
          get
          {
              return this._Collection;
          }
          set
          {
              _Collection = value;
              this.RaisePropertyChanged("Collection");
          }
      }

      public ShellViewModel()
      {
          this.Collection = new List<string>();
          this.Collection.Add("Module1");
          this.Collection.Add("Module2");
         // this.Module1 = new ViewModel_Module1() { TextProp="This is module1"};
      }

      //private ViewModel_Module1 _Module1;
      //public ViewModel_Module1 Module1
      //{ 
      //    get
      //    {
      //        return this._Module1;
      //    }
      //    set
      //    {
      //        this._Module1 = value;
      //        this.RaisePropertyChanged("Module1");
      //    }
      //}
    }
}
