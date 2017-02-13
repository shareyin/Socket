using System;
using System.Net;//新加的
using System.Net.Sockets;//新加的
using System.Threading;
using System.Text;


namespace Socket_Bin
{
	/// <summary>
	/// 
	/// </summary>
	public class StateObject
	{
		
		public Socket workSocket = null;       // Client  socket.
		public const int BufferSize = 1024;       // Size of receive buffer.
		public byte[] buffer = new byte[BufferSize]; // Receive buffer.
		public StringBuilder sb = new StringBuilder();  // Received data string.

		public StateObject()
		{
			// 
			// TODO: 在此处添加构造函数逻辑
			//
  

		}
	}
}
