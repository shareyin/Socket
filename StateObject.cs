using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;//�¼ӵ�
using System.Net.Sockets;//�¼ӵ�
using System.Threading;
using System.Text;

namespace Sock_Conn
{
	/// <summary>
	/// 
	/// </summary>
	public class StateObject
	{
		public Socket workSocket = null;              // Client socket.
		public const int BufferSize = 256;            // Size of receive buffer.
		public byte[] buffer = new byte[BufferSize];  // Receive buffer.
		public StringBuilder sb = new StringBuilder();// Received data string.

		public StateObject()
		{
			// 
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
	}
}
