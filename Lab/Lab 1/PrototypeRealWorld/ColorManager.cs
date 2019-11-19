using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeRealWorld
{
	class ColorManager
	{
		private Dictionary<string, ColorPrototype> colors = new Dictionary<string, ColorPrototype>();

		public ColorPrototype this[string key]
		{
			get { return colors[key]; }
			set { colors.Add(key, value); }
		}
	}
}
