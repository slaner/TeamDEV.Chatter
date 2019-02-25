namespace TeamDEV.Chatter.Core.Communications {
    /// <summary>
    /// 데이터 형식을 열거합니다.
    /// </summary>
    public enum DataTypes : byte {
        /// <summary>
        /// 알 수 없는 데이터 형식입니다.
        /// </summary>
        Unknown,

        /// <summary>
        /// 데이터가 텍스트 형식입니다.
        /// </summary>
        Text,

        /// <summary>
        /// 데이터가 이진 형식입니다.
        /// </summary>
        Binary,
    }
}