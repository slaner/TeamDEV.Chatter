using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamDEV.Chatter.Core.Communications {
    /// <summary>
    /// 읽기만 가능한 패킷을 구현합니다.
    /// </summary>
    public interface IReadOnlyPacketHeader {
        /// <summary>
        /// 데이터의 형식을 가져옵니다.
        /// </summary>
        DataTypes DataType { get; }

        /// <summary>
        /// 데이터의 길이를 가져옵니다.
        /// </summary>
        ulong DataLength { get; }

        /// <summary>
        /// 데이터 전송 시간을 나타내는 값을 가져옵니다.
        /// </summary>
        ulong Timestamp { get; }
    }
}