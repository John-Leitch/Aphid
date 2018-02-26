using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Cypress.IA32
{
    public static class IA32Disassembler
    {
        // http://wiki.osdev.org/X86-64_Instruction_Encoding
        public static DecodedInstruction[] Disassemble(byte[] bytes)
        {
            var instructions = new List<DecodedInstruction>();

            for (var i = 0; i < bytes.Length; i++)
            {
                var size = 1;
                var decodedInstruction = new DecodedInstruction
                {
                    Opcode = DecodedOpcode.Decode(bytes[i]),
                };

                if (decodedInstruction.Opcode.Opcode == Opcode.Mov)
                {
                    i++;
                    if (i >= bytes.Length)
                    {
                        break;
                    }

                    decodedInstruction.ModRM = DecodedModRMByte.Decode(bytes[i]);
                    size++;

                    // https://www.onlinedisassembler.com/odaweb/
                    // http://wiki.osdev.org/X86-64_Instruction_Encoding
                    switch (decodedInstruction.ModRM.Mod)
                    {
                        case Mod.RegisterIndirect:
                            switch (decodedInstruction.ModRM.Rm)
                            {
                                case 0x4:
                                    i++;
                                    if (i >= bytes.Length)
                                    {
                                        break;
                                    }

                                    decodedInstruction.Sib = SibByte.Decode(bytes[i]);
                                    size++;
                                    break;

                                case 0x5:
                                    i++;
                                    if (i + 3 >= bytes.Length)
                                    {
                                        break;
                                    }

                                    decodedInstruction.Displacement = BitConverter.ToInt32(bytes, i);
                                    size += 4;
                                    i += 3;
                                    break;

                            }
                            break;

                        case Mod.Displacement8:
                            switch (decodedInstruction.ModRM.Rm)
                            {
                                case 0x4:
                                    i++;
                                    if (i >= bytes.Length)
                                    {
                                        break;
                                    }

                                    decodedInstruction.Sib = SibByte.Decode(bytes[i]);
                                    size++;
                                    break;
                            }


                            i++;
                            if (i >= bytes.Length)
                            {
                                break;
                            }

                            decodedInstruction.Displacement = bytes[i];
                            size++;
                            break;

                        case Mod.Displacement32:
                            switch (decodedInstruction.ModRM.Rm)
                            {
                                case 0x4:
                                    i++;
                                    if (i >= bytes.Length)
                                    {
                                        break;
                                    }

                                    decodedInstruction.Sib = SibByte.Decode(bytes[i]);
                                    size++;
                                    break;
                            }

                            i++;
                            if (i + 3 >= bytes.Length)
                            {
                                break;
                            }

                            decodedInstruction.Displacement = BitConverter.ToInt32(bytes, i);
                            size += 4;
                            i += 3;
                            break;

                        case Mod.RegisterAddressing:
                            break;
                    }
                }

                decodedInstruction.Size = size;
                instructions.Add(decodedInstruction);
            }

            return instructions.ToArray();
        }
    }
}
