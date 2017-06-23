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
    public class Author : INotifyPropertyChanged
    {
		public int AuthorCode { get; set; }
		public string SecondName { get; set; }
		public DateTime BirthDate { get; set; } = DateTime.Now;
	    public event PropertyChangedEventHandler PropertyChanged;

	    [NotifyPropertyChangedInvocator]
	    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	    {
		    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	    }
    }
}
