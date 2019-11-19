using System;

namespace PrototypeRealWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			ColorManager colorManager = new ColorManager();

			colorManager["red"] = new Color(255, 0, 0);
			colorManager["green"] = new Color(0, 255, 0);
			colorManager["blue"] = new Color(0, 0, 255);

			colorManager["angry"] = new Color(255,54,0);
			colorManager["peace"] = new Color(128, 211, 128);
			colorManager["flame"] = new Color(211, 34, 20);

			Color color1 = colorManager["red"].Clone() as Color;
			Color color2 = colorManager["peace"].Clone() as Color;
			Color color3 = colorManager["flame"].Clone() as Color;

			Console.ReadKey();
		}
	}
}
