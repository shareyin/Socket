using System;
using System.Net;//�¼ӵ�
using System.Net.Sockets;//�¼ӵ�
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
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
  

		}
	}
}
