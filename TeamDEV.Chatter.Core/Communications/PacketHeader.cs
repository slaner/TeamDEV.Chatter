using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TeamDEV.Chatter.Core.Communications {
    /// <summary>
    /// 패킷에 대한 정보를 저장하는 클래스입니다.
    /// </summary>
    public sealed class PacketHeader : IReadOnlyPacketHeader {

        public const int Size = 1 + 8 + 8;

        private readonly byte[] mRawData;
        public PacketHeader() {
            mRawData = new byte[Size];
        }
        
        /// <summary>
        /// 데이터의 형식을 가져오거나 설정합니다.
        /// </summary>
        public DataTypes DataType { get; set; }

        /// <summary>
        /// 데이터의 길이를 가져오거나 설정합니다.
        /// </summary>
        public ulong DataLength { get; set; }

        /// <summary>
        /// 데이터 전송 시간을 가져오거나 설정합니다.
        /// </summary>
        public ulong Timestamp { get; set; }

        public byte[] ToByteArray() {
            mRawData[0] = (byte) DataType;
            PointerHelper.CopyTo(DataLength, mRawData, 1);
            PointerHelper.CopyTo(Timestamp, mRawData, 9);
            return mRawData;
        }
    }
}