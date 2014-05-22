﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TerraMap.Data;

namespace TerraMap.Data
{
	public class ObjectInfoViewModel : INotifyPropertyChanged
	{
		private ItemInfo itemInfo;

		public ItemInfo ItemInfo
		{
			get { return itemInfo; }
			set
			{
				itemInfo = value;
				RaisePropertyChanged();
			}
		}

		private TileInfo tileInfo;

		public TileInfo TileInfo
		{
			get { return tileInfo; }
			set
			{
				tileInfo = value;
				RaisePropertyChanged();
			}
		}

		private string name;

		public string Name
		{
			get { return name; }
			set
			{
				name = value;
				RaisePropertyChanged();
			}
		}

		private bool isSelected;

		public bool IsSelected
		{
			get { return isSelected; }
			set
			{
				isSelected = value;
				RaisePropertyChanged();
			}
		}

		protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (this.PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
