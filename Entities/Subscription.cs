using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Entities.Annotations;

namespace Entities
{
    public class Subscription : INotifyPropertyChanged
    {
		public decimal Code { get; set; }
	    public string EditionCode { get; set; }
		public int Abonent { get; set; }
		public int Period { get; set; }
		public decimal Cost { get; set; }
	    public event PropertyChangedEventHandler PropertyChanged;

	    [NotifyPropertyChangedInvocator]
	    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	    {
		    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	    }
    }
}
