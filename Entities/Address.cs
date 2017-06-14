﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Entities.Annotations;

namespace Entities
{
	public class Address : INotifyPropertyChanged
	{
		public int ID { get; set; }
		public int RegionCode { get; set; }
		public string Street { get; set; }
		public int House { get; set; }
		public char Letter { get; set; }
		public int FlatNumber { get; set; }
		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
