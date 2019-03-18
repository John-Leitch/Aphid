namespace Components.Cypress.IA32
{
    public enum Opcode : byte
    {
        PushEax = 0x50,
        PushEcx = 0x51,
        PushEdx = 0x52,
        PushEbx = 0x53,
        PushEsx = 0x54,
        PushEbp = 0x55,
        PushEsi = 0x56,
        PushEdi = 0x57,
        Mov = 0x8b,
    }
}
