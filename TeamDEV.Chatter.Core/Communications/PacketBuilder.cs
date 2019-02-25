using System;
using System.Collections.Generic;
using System.Text;

namespace TeamDEV.Chatter.Core.Communications {
    public static class PacketBuilder {
        public static byte[] BuildTextPacket(string text) {
            byte[] textBytes = Encoding.Unicode.GetBytes(text);
            PacketHeader header = new PacketHeader {
                DataType = DataTypes.Text,
                DataLength = (ulong) textBytes.LongLength,
                Timestamp = (ulong) DateTime.Now.Ticks
            };

            List<byte> packet = new List<byte>();
            packet.AddRange(header.ToByteArray());
            packet.AddRange(textBytes);
            return packet.ToArray();
        }
    }
}