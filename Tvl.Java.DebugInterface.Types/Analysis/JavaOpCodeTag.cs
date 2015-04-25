﻿namespace Tvl.Java.DebugInterface.Types.Analysis
{
    public enum JavaOpCodeTag : byte
    {
        Aaload = 0x32,
        Aastore = 0x53,
        Aconst_null = 0x01,
        Aload = 0x19,
        Aload_0 = 0x2A,
        Aload_1 = 0x2B,
        Aload_2 = 0x2C,
        Aload_3 = 0x2D,
        Anewarray = 0xBD,
        Areturn = 0xB0,
        Arraylength = 0xBE,
        Astore = 0x3A,
        Astore_0 = 0x4B,
        Astore_1 = 0x4C,
        Astore_2 = 0x4D,
        Astore_3 = 0x4E,
        Athrow = 0xBF,
        Baload = 0x33,
        Bastore = 0x54,
        Bipush = 0x10,
        Breakpoint = 0xCA,
        Caload = 0x34,
        Castore = 0x55,
        Checkcast = 0xC0,
        D2f = 0x90,
        D2i = 0x8E,
        D2l = 0x8F,
        Dadd = 0x63,
        Daload = 0x31,
        Dastore = 0x52,
        Dcmpg = 0x98,
        Dcmpl = 0x97,
        Dconst_0 = 0x0E,
        Dconst_1 = 0x0F,
        Ddiv = 0x6F,
        Dload = 0x18,
        Dload_0 = 0x26,
        Dload_1 = 0x27,
        Dload_2 = 0x28,
        Dload_3 = 0x29,
        Dmul = 0x6B,
        Dneg = 0x77,
        Drem = 0x73,
        Dreturn = 0xAF,
        Dstore = 0x39,
        Dstore_0 = 0x47,
        Dstore_1 = 0x48,
        Dstore_2 = 0x49,
        Dstore_3 = 0x4A,
        Dsub = 0x67,
        Dup = 0x59,
        Dup_x1 = 0x5A,
        Dup_x2 = 0x5B,
        Dup2 = 0x5C,
        Dup2_x1 = 0x5D,
        Dup2_x2 = 0x5E,
        F2d = 0x8D,
        F2i = 0x8B,
        F2l = 0x8C,
        Fadd = 0x62,
        Faload = 0x30,
        Fastore = 0x51,
        Fcmpg = 0x96,
        Fcmpl = 0x95,
        Fconst_0 = 0x0B,
        Fconst_1 = 0x0C,
        Fconst_2 = 0x0D,
        Fdiv = 0x6E,
        Fload = 0x17,
        Fload_0 = 0x22,
        Fload_1 = 0x23,
        Fload_2 = 0x24,
        Fload_3 = 0x25,
        Fmul = 0x6A,
        Fneg = 0x76,
        Frem = 0x72,
        Freturn = 0xAE,
        Fstore = 0x38,
        Fstore_0 = 0x43,
        Fstore_1 = 0x44,
        Fstore_2 = 0x45,
        Fstore_3 = 0x46,
        Fsub = 0x66,
        Getfield = 0xB4,
        Getstatic = 0xB2,
        Goto = 0xA7,
        Goto_w = 0xC8,
        I2b = 0x91,
        I2c = 0x92,
        I2d = 0x87,
        I2f = 0x86,
        I2l = 0x85,
        I2s = 0x93,
        Iadd = 0x60,
        Iaload = 0x2E,
        Iand = 0x7E,
        Iastore = 0x4F,
        Iconst_0 = 0x03,
        Iconst_1 = 0x04,
        Iconst_2 = 0x05,
        Iconst_3 = 0x06,
        Iconst_4 = 0x07,
        Iconst_5 = 0x08,
        Iconst_m1 = 0x02,
        Idiv = 0x6C,
        If_acmpeq = 0xA5,
        If_acmpne = 0xA6,
        If_icmpeq = 0x9F,
        If_icmpge = 0xA2,
        If_icmpgt = 0xA3,
        If_icmple = 0xA4,
        If_icmplt = 0xA1,
        If_icmpne = 0xA0,
        Ifeq = 0x99,
        Ifge = 0x9C,
        Ifgt = 0x9D,
        Ifle = 0x9E,
        Iflt = 0x9B,
        Ifne = 0x9A,
        Ifnonnull = 0xC7,
        Ifnull = 0xC6,
        Iinc = 0x84,
        Iload = 0x15,
        Iload_0 = 0x1A,
        Iload_1 = 0x1B,
        Iload_2 = 0x1C,
        Iload_3 = 0x1D,
        Impdep1 = 0xFE,
        Impdep2 = 0xFF,
        Imul = 0x68,
        Ineg = 0x74,
        Instanceof = 0xC1,
        Invokeinterface = 0xB9,
        Invokespecial = 0xB7,
        Invokestatic = 0xB8,
        Invokevirtual = 0xB6,
        Ior = 0x80,
        Irem = 0x70,
        Ireturn = 0xAC,
        Ishl = 0x78,
        Ishr = 0x7A,
        Istore = 0x36,
        Istore_0 = 0x3B,
        Istore_1 = 0x3C,
        Istore_2 = 0x3D,
        Istore_3 = 0x3E,
        Isub = 0x64,
        Iushr = 0x7C,
        Ixor = 0x82,
        Jsr = 0xA8,
        Jsr_w = 0xC9,
        L2d = 0x8A,
        L2f = 0x89,
        L2i = 0x88,
        Ladd = 0x61,
        Laload = 0x2F,
        Land = 0x7F,
        Lastore = 0x50,
        Lcmp = 0x94,
        Lconst_0 = 0x09,
        Lconst_1 = 0x0A,
        Ldc = 0x12,
        Ldc_w = 0x13,
        Ldc2_w = 0x14,
        Ldiv = 0x6D,
        Lload = 0x16,
        Lload_0 = 0x1E,
        Lload_1 = 0x1F,
        Lload_2 = 0x20,
        Lload_3 = 0x21,
        Lmul = 0x69,
        Lneg = 0x75,
        Lookupswitch = 0xAB,
        Lor = 0x81,
        Lrem = 0x71,
        Lreturn = 0xAD,
        Lshl = 0x79,
        Lshr = 0x7B,
        Lstore = 0x37,
        Lstore_0 = 0x3F,
        Lstore_1 = 0x40,
        Lstore_2 = 0x41,
        Lstore_3 = 0x42,
        Lsub = 0x65,
        Lushr = 0x7D,
        Lxor = 0x83,
        Monitorenter = 0xC2,
        Monitorexit = 0xC3,
        Multianewarray = 0xC5,
        New = 0xBB,
        Newarray = 0xBC,
        Nop = 0x00,
        Pop = 0x57,
        Pop2 = 0x58,
        Putfield = 0xB5,
        Putstatic = 0xB3,
        Ret = 0xA9,
        Return = 0xB1,
        Saload = 0x35,
        Sastore = 0x56,
        Sipush = 0x11,
        Swap = 0x5F,
        Tableswitch = 0xAA,
        Wide = 0xC4,
        Xxxunusedxxx1 = 0xBA,
    }
}
