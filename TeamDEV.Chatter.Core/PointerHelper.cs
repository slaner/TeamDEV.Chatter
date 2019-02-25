namespace TeamDEV.Chatter.Core {
    static class PointerHelper {
        public unsafe static void CopyTo(short value, byte[] destination, int startIndex) {
            fixed (byte* pBase = &destination[startIndex]) {
                *(short *) pBase = value;
            }
        }
        public unsafe static void CopyTo(ushort value, byte[] destination, int startIndex) {
            fixed (byte* pBase = &destination[startIndex]) {
                *(ushort *) pBase = value;
            }
        }
        public unsafe static void CopyTo(int value, byte[] destination, int startIndex) {
            fixed (byte* pBase = &destination[startIndex]) {
                *(int *) pBase = value;
            }
        }
        public unsafe static void CopyTo(uint value, byte[] destination, int startIndex) {
            fixed (byte* pBase = &destination[startIndex]) {
                *(uint *) pBase = value;
            }
        }
        public unsafe static void CopyTo(long value, byte[] destination, int startIndex) {
            fixed (byte* pBase = &destination[startIndex]) {
                *(long *) pBase = value;
            }
        }
        public unsafe static void CopyTo(ulong value, byte[] destination, int startIndex) {
            fixed (byte* pBase = &destination[startIndex]) {
                *(ulong *) pBase = value;
            }
        }
    }
}