namespace Components.Cypress.IA32
{
    public class SibByte
    {
        public byte Scale { get; set; }

        public byte Index { get; set; }

        public byte Base { get; set; }

        public static SibByte Decode(byte sib) => new SibByte
        {
            Scale = (byte)(sib >> 6),
            Index = (byte)((sib >> 3) & 7),
            Base = (byte)(sib & 7)
        };
    }
}
