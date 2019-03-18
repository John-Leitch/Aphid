namespace Components.Cypress.IA32
{
    public enum Mod : byte
    {
        RegisterIndirect = 0x0,
        Displacement8 = 0x1,
        Displacement32 = 0x2,
        RegisterAddressing = 0x3,
    }
}
