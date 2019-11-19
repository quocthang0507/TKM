using System;

namespace BridgePattern
{
	/// <summary>
	/// Lớp Abstraction: Điều khiển từ xa
	/// </summary>
	class RemoteControl
	{
		/// <summary>
		/// Đối tượng thực hiện các yêu cầu từ Điều khiển từ xa
		/// </summary>
		public Device device { get; set; }

		/// <summary>
		/// Bật/ tắt nguồn thiết bị
		/// </summary>
		public virtual void Power()
		{
			device.isEnabled = !device.isEnabled;
			Console.WriteLine(device.isEnabled ? device.Name + " turns on." : device.Name + " turns off");
		}

		/// <summary>
		/// Giảm âm lượng
		/// </summary>
		public virtual void DownVolumn()
		{
			if (device.Volume > 0)
			{
				device.Volume--;
				Console.WriteLine(string.Format("Volume of {0}: {1}", device.Name, device.Volume));
			}
		}

		/// <summary>
		/// Tăng âm lượng
		/// </summary>
		public virtual void UpVolumn()
		{
			if (device.Volume < 10)
			{
				device.Volume++;
				Console.WriteLine(string.Format("Volume of {0}: {1}", device.Name, device.Volume));
			}
		}
	}

	/// <summary>
	/// Lớp RefinedAbstraction: Điều khiển từ xa đa chức năng, mở rộng từ lớp Abstraction
	/// </summary>
	class AdvancedRemoteControl : RemoteControl
	{
		public void Mute()
		{
			device.Volume = 0;
			Console.WriteLine(string.Format("Volume of {0}: {1}", device.Name, device.Volume));
		}
	}

	/// <summary>
	/// Lớp Implementation: Thiết bị
	/// </summary>
	abstract class Device
	{
		public string Name { get; set; }
		public bool isEnabled { get; set; }
		public int Volume { get; set; }
		public int Channel { get; set; }
	}

	/// <summary>
	/// Mở rộng lớp Implementation: Radio
	/// </summary>
	class Radio : Device
	{
		public Radio()
		{

		}

		public Radio(string Name, bool isEnabled, int Volume, int Channel)
		{
			this.Name = Name;
			this.isEnabled = isEnabled;
			this.Volume = Volume;
			this.Channel = Channel;
		}
	}

	/// <summary>
	/// Mở rộng lớp Implementation: Tivi
	/// </summary>
	class Television : Device
	{
		public Television()
		{

		}

		public Television(string Name, bool isEnabled, int Volume, int Channel)
		{
			this.Name = Name;
			this.isEnabled = isEnabled;
			this.Volume = Volume;
			this.Channel = Channel;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			// Khởi tạo một Điều khiển từ xa đa năng
			RemoteControl remote = new AdvancedRemoteControl();
			// Điều khiển tivi, đang tắt, âm lượng là 5, kênh hiện tại là 5
			remote.device = new Television("SAMSUNG Smart TV 4K UHD 55 inch", false, 5, 5);
			remote.Power();
			// Điều khiển radio, đang tắt, âm lượng là 4, kênh hiện tại là 1
			remote.device = new Radio("Cassette Toshiba TY-CWU11", false, 4, 1);
			remote.Power();
			Console.ReadKey();
		}
	}
}
