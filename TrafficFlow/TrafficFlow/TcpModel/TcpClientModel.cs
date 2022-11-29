using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TrafficFlow.TcpModel
{
    internal class TcpClientModel
    {
        public static void Connect(String server, String message)
        {
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = 13000;

                // Prefer using declaration to ensure the instance is Disposed later.
                using TcpClient client = new TcpClient(server, port);

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer.
                stream.Write(data, 0, data.Length);

                MessageBox.Show($"Client: sent {message}");

                // Receive the server response.

                // Buffer to store the response bytes.
                data = new Byte[256];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                MessageBox.Show($"Client: received {responseData}");

                // Explicit close is not necessary since TcpClient.Dispose() will be
                // called automatically.
                // stream.Close();
                // client.Close();
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show($"Client: ArgumentNullException: {e}");
            }
            catch (SocketException e)
            {
                MessageBox.Show($"Client: SocketException: {e}");
            }

            MessageBox.Show("\nClient: Press Enter to continue...");
        }
    }
}
