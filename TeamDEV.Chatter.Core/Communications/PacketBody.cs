using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamDEV.Chatter.Core.Communications {
    /// <summary>
    /// 패킷의 데이터를 저장하는 기본 클래스입니다.
    /// </summary>
    public abstract class PacketBody {

        public byte[] Data { get; }
    }
}