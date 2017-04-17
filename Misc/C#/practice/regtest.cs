using System;
using Microsoft.Win32;
class regTest
{
	public static void Main(String[] args)
	{
		RegistryKey regKey;
		Object value;
		regKey = Registry.LocalMachine;
		regKey = regKey.OpenSubKey("HARDWAREDESCRIPTIONSystemCentralProcessor ");
		value = regKey.GetValue("VendorIdentifier");
		Console.WriteLine("The central processor of this machine is: {0}.", value);
	}
} 
