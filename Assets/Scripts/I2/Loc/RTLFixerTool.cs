using UnityEngine;

namespace I2.Loc
{
    internal class RTLFixerTool
    {
        // Fields
        internal static bool showTashkeel;
        internal static bool useHinduNumbers;
        
        // Methods
        internal static string RemoveTashkeel(string str, out System.Collections.Generic.List<I2.Loc.TashkeelLocation> tashkeelLocation)
        {
            var val_16;
            var val_17;
            System.Collections.Generic.List<T> val_18;
            char val_19;
            I2.Loc.TashkeelLocation val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            string val_25;
            System.Collections.Generic.List<I2.Loc.TashkeelLocation> val_1 = new System.Collections.Generic.List<I2.Loc.TashkeelLocation>();
            tashkeelLocation = val_1;
            val_16 = 1152921512324317984;
            val_17 = 0;
            goto label_2;
            label_66:
            val_19 = str.ToCharArray()[0];
            if(val_19 != 'ً')
            {
                goto label_4;
            }
            
            val_18 = tashkeelLocation;
            val_20 = new I2.Loc.TashkeelLocation();
            val_21 = 1611;
            goto label_56;
            label_4:
            if(val_17 >= val_2.Length)
            {
                    val_19 = mem[val_2[0x0] + 32];
                val_19 = val_2[0x0] + 32;
            }
            
            if(val_19 != 1612)
            {
                goto label_7;
            }
            
            val_18 = tashkeelLocation;
            val_20 = new I2.Loc.TashkeelLocation();
            val_21 = 1612;
            goto label_56;
            label_7:
            if(val_17 >= val_2.Length)
            {
                    val_19 = mem[val_2[0x0] + 32];
                val_19 = val_2[0x0] + 32;
            }
            
            if(val_19 != 1613)
            {
                goto label_10;
            }
            
            val_18 = tashkeelLocation;
            val_20 = new I2.Loc.TashkeelLocation();
            val_21 = 1613;
            goto label_56;
            label_10:
            if(val_17 >= val_2.Length)
            {
                    val_19 = mem[val_2[0x0] + 32];
                val_19 = val_2[0x0] + 32;
            }
            
            if(val_19 != 1614)
            {
                goto label_13;
            }
            
            if(val_19 < 1614)
            {
                goto label_17;
            }
            
            I2.Loc.TashkeelLocation val_3 = val_1.Item[-1];
            if(val_3.tashkeel != 'ّ')
            {
                goto label_17;
            }
            
            val_18 = val_1.Item[-1];
            val_4.tashkeel = 'ﱠ';
            goto label_60;
            label_13:
            if(val_17 >= val_2.Length)
            {
                    val_19 = mem[val_2[0x0] + 32];
                val_19 = val_2[0x0] + 32;
            }
            
            if(val_19 != 1615)
            {
                goto label_22;
            }
            
            if(val_19 < 1615)
            {
                goto label_26;
            }
            
            I2.Loc.TashkeelLocation val_5 = val_1.Item[-1];
            if(val_5.tashkeel != 'ّ')
            {
                goto label_26;
            }
            
            val_18 = val_1.Item[-1];
            val_6.tashkeel = 'ﱡ';
            goto label_60;
            label_17:
            val_18 = tashkeelLocation;
            val_20 = new I2.Loc.TashkeelLocation();
            val_21 = 1614;
            goto label_56;
            label_22:
            if(val_17 >= val_2.Length)
            {
                    val_19 = mem[val_2[0x0] + 32];
                val_19 = val_2[0x0] + 32;
            }
            
            if(val_19 != 1616)
            {
                goto label_32;
            }
            
            if(val_19 < 1616)
            {
                goto label_36;
            }
            
            I2.Loc.TashkeelLocation val_7 = val_1.Item[-1];
            if(val_7.tashkeel != 'ّ')
            {
                goto label_36;
            }
            
            label_63:
            val_18 = val_1.Item[-1];
            val_8.tashkeel = 'ﱢ';
            goto label_60;
            label_26:
            val_18 = tashkeelLocation;
            val_20 = new I2.Loc.TashkeelLocation();
            val_21 = 1615;
            goto label_56;
            label_32:
            if(val_17 >= val_2.Length)
            {
                    val_19 = mem[val_2[0x0] + 32];
                val_19 = val_2[0x0] + 32;
            }
            
            if(val_19 != 1617)
            {
                goto label_42;
            }
            
            if(val_19 < 1617)
            {
                goto label_61;
            }
            
            I2.Loc.TashkeelLocation val_9 = val_1.Item[-1];
            val_18 = val_9.tashkeel;
            val_22 = val_1.Item[-1];
            if(val_18 != 'َ')
            {
                goto label_48;
            }
            
            val_23 = 64608;
            goto label_49;
            label_36:
            val_18 = tashkeelLocation;
            val_20 = new I2.Loc.TashkeelLocation();
            val_21 = 1616;
            goto label_56;
            label_42:
            if(val_17 >= val_2.Length)
            {
                    val_19 = mem[val_2[0x0] + 32];
                val_19 = val_2[0x0] + 32;
            }
            
            if(val_19 != 1618)
            {
                goto label_52;
            }
            
            val_18 = tashkeelLocation;
            val_20 = new I2.Loc.TashkeelLocation();
            val_21 = 1618;
            goto label_56;
            label_52:
            if(val_17 >= val_2.Length)
            {
                    val_19 = mem[val_2[0x0] + 32];
                val_19 = val_2[0x0] + 32;
            }
            
            if(val_19 != 1619)
            {
                goto label_60;
            }
            
            val_18 = tashkeelLocation;
            val_20 = new I2.Loc.TashkeelLocation();
            val_21 = 1619;
            goto label_56;
            label_48:
            val_18 = val_10.tashkeel;
            val_22 = val_1.Item[-1];
            if(val_18 != 'ُ')
            {
                goto label_59;
            }
            
            val_23 = 64609;
            label_49:
            val_11.tashkeel = 'ﱡ';
            val_16 = 1152921512324317984;
            goto label_60;
            label_59:
            val_16 = 1152921512324317984;
            if(val_11.tashkeel != 'ِ')
            {
                goto label_61;
            }
            
            if(tashkeelLocation != null)
            {
                goto label_63;
            }
            
            goto label_63;
            label_61:
            val_18 = tashkeelLocation;
            val_20 = new I2.Loc.TashkeelLocation();
            val_21 = 1617;
            label_56:
            val_20 = new I2.Loc.TashkeelLocation(tashkeel:  'ّ', position:  0);
            val_1.Add(item:  new I2.Loc.TashkeelLocation());
            label_60:
            val_17 = 1;
            label_2:
            if(val_17 < val_2.Length)
            {
                goto label_66;
            }
            
            val_24 = 0;
            val_25 = "";
            goto label_68;
            label_71:
            val_25 = val_25 + str.Split(separator:  new char[12])[0](str.Split(separator:  new char[12])[0]);
            val_24 = 1;
            label_68:
            if(val_24 < val_14.Length)
            {
                goto label_71;
            }
            
            return (string)val_25;
        }
        internal static char[] ReturnTashkeel(char[] letters, System.Collections.Generic.List<I2.Loc.TashkeelLocation> tashkeelLocation)
        {
            var val_6;
            System.Collections.Generic.List<I2.Loc.TashkeelLocation> val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = tashkeelLocation;
            int val_2 = val_9.Count + letters.Length;
            char[] val_3 = new char[0];
            val_10 = 0;
            val_11 = 0;
            val_12 = 0;
            goto label_3;
            label_22:
            val_3[0] = letters[0];
            val_9 = tashkeelLocation;
            List.Enumerator<T> val_4 = val_9.GetEnumerator();
            label_13:
            val_11 = 1;
            do
            {
                if(((-871985264) & 1) == 0)
            {
                goto label_14;
            }
            
                string val_7 = val_6.Id;
            }
            while(val_7.m_firstChar != val_11);
            
            val_3[2] = val_7.m_stringLength;
            goto label_13;
            label_14:
            UniRx.Unit..cctor();
            if(1 != 1)
            {
                    var val_9 = 0;
                val_9 = val_9 ^ 0;
                val_12 = 1 + val_9;
            }
            else
            {
                    val_12 = 0;
            }
            
            val_10 = 1;
            label_3:
            if(val_10 < letters.Length)
            {
                goto label_22;
            }
            
            return (System.Char[])val_3;
        }
        internal static string FixLine(string str)
        {
            System.Char[] val_58;
            System.Char[] val_59;
            var val_60;
            int val_61;
            char val_62;
            var val_63;
            var val_64;
            var val_65;
            char val_66;
            var val_68;
            var val_69;
            System.Collections.Generic.List<T> val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            System.Collections.Generic.List<I2.Loc.TashkeelLocation> val_1 = 0;
            string val_2 = I2.Loc.RTLFixerTool.RemoveTashkeel(str:  str, tashkeelLocation: out  val_1);
            if(val_2 != null)
            {
                    val_58 = val_2.ToCharArray();
            }
            else
            {
                    val_58 = 0.ToCharArray();
            }
            
            val_59 = val_2.ToCharArray();
            val_60 = 0;
            goto label_5;
            label_10:
            val_60 = 1;
            mem2[0] = I2.Loc.ArabicTable.ArabicMapper.Convert(toBeConverted:  val_58[0]);
            label_5:
            if(val_60 < val_4.Length)
            {
                goto label_10;
            }
            
            if(val_4.Length < 1)
            {
                goto label_11;
            }
            
            label_112:
            long val_62 = 0;
            if(val_58[0] != 'ģ')
            {
                goto label_28;
            }
            
            val_61 = val_4.Length;
            if(val_62 >= (val_61 - 1))
            {
                goto label_28;
            }
            
            var val_9 = val_62 + 1;
            if(val_9 >= val_61)
            {
                    val_61 = val_4.Length;
            }
            
            val_62 = val_58[((long)(int)((0 + 1))) << 1];
            if(val_62 != 'ﺇ')
            {
                goto label_16;
            }
            
            val_63 = 65271;
            goto label_26;
            label_16:
            if((long)val_9 >= val_61)
            {
                    val_62 = mem[val_4[((long)(int)((0 + 1))) << 1] + 32];
                val_62 = val_4[((long)(int)((0 + 1))) << 1] + 32;
                val_61 = val_4.Length;
            }
            
            if(val_62 != 65165)
            {
                goto label_20;
            }
            
            val_63 = 65273;
            goto label_26;
            label_20:
            if((long)val_9 >= val_61)
            {
                    val_62 = mem[val_4[((long)(int)((0 + 1))) << 1] + 32];
                val_62 = val_4[((long)(int)((0 + 1))) << 1] + 32;
                val_61 = val_4.Length;
            }
            
            if(val_62 != 65155)
            {
                goto label_24;
            }
            
            val_63 = 65269;
            goto label_26;
            label_24:
            if((long)val_9 >= val_61)
            {
                    val_62 = mem[val_4[((long)(int)((0 + 1))) << 1] + 32];
                val_62 = val_4[((long)(int)((0 + 1))) << 1] + 32;
            }
            
            if(val_62 != 65153)
            {
                goto label_28;
            }
            
            val_63 = 65267;
            label_26:
            mem2[0] = 65267;
            val_64 = 1;
            val_59[((long)(int)((0 + 1))) << 1] = 65535;
            goto label_32;
            label_28:
            val_64 = 0;
            label_32:
            if((I2.Loc.RTLFixerTool.IsIgnoredCharacter(ch:  val_4[0x0] + 32)) == true)
            {
                goto label_73;
            }
            
            if((I2.Loc.RTLFixerTool.IsMiddleLetter(letters:  val_58, index:  0)) == false)
            {
                goto label_39;
            }
            
            char val_61 = val_4[0x0] + 32;
            val_61 = val_61 + 3;
            if(val_62 < val_5.Length)
            {
                goto label_77;
            }
            
            label_76:
            label_77:
            val_59[0] = val_61;
            label_73:
            string val_13 = "" + System.Convert.ToString(value:  val_4[0x0] + 32, toBase:  16)(System.Convert.ToString(value:  val_4[0x0] + 32, toBase:  16)) + " ";
            val_65 = null;
            val_65 = null;
            val_62 = val_64 + val_62;
            if(I2.Loc.RTLFixerTool.useHinduNumbers == false)
            {
                goto label_109;
            }
            
            val_66 = val_58[((long)(int)((val_64 + 0))) << 1];
            if(val_66 != '0')
            {
                goto label_50;
            }
            
            val_68 = 1632;
            goto label_107;
            label_50:
            if(val_62 >= val_4.Length)
            {
                    val_66 = mem[val_4[((long)(int)((val_64 + 0))) << 1] + 32];
                val_66 = val_4[((long)(int)((val_64 + 0))) << 1] + 32;
            }
            
            if(val_66 != 49)
            {
                goto label_55;
            }
            
            val_68 = 1633;
            goto label_107;
            label_39:
            if((I2.Loc.RTLFixerTool.IsFinishingLetter(letters:  val_58, index:  0)) == false)
            {
                goto label_61;
            }
            
            var val_63 = val_4[0x0] + 32;
            val_63 = val_63 + 1;
            if(val_62 >= val_5.Length)
            {
                goto label_76;
            }
            
            goto label_77;
            label_55:
            if(val_62 >= val_4.Length)
            {
                    val_66 = mem[val_4[((long)(int)((val_64 + 0))) << 1] + 32];
                val_66 = val_4[((long)(int)((val_64 + 0))) << 1] + 32;
            }
            
            if(val_66 != 50)
            {
                goto label_67;
            }
            
            val_68 = 1634;
            goto label_107;
            label_61:
            if((I2.Loc.RTLFixerTool.IsLeadingLetter(letters:  val_58, index:  0)) == false)
            {
                goto label_73;
            }
            
            var val_64 = val_4[0x0] + 32;
            val_64 = val_64 + 2;
            if(val_62 >= val_5.Length)
            {
                goto label_76;
            }
            
            goto label_77;
            label_67:
            if(val_62 >= val_4.Length)
            {
                    val_66 = mem[val_4[((long)(int)((val_64 + 0))) << 1] + 32];
                val_66 = val_4[((long)(int)((val_64 + 0))) << 1] + 32;
            }
            
            if(val_66 != 51)
            {
                goto label_79;
            }
            
            val_68 = 1635;
            goto label_107;
            label_79:
            if(val_62 >= val_4.Length)
            {
                    val_66 = mem[val_4[((long)(int)((val_64 + 0))) << 1] + 32];
                val_66 = val_4[((long)(int)((val_64 + 0))) << 1] + 32;
            }
            
            if(val_66 != 52)
            {
                goto label_84;
            }
            
            val_68 = 1636;
            goto label_107;
            label_84:
            if(val_62 >= val_4.Length)
            {
                    val_66 = mem[val_4[((long)(int)((val_64 + 0))) << 1] + 32];
                val_66 = val_4[((long)(int)((val_64 + 0))) << 1] + 32;
            }
            
            if(val_66 != 53)
            {
                goto label_89;
            }
            
            val_68 = 1637;
            goto label_107;
            label_89:
            if(val_62 >= val_4.Length)
            {
                    val_66 = mem[val_4[((long)(int)((val_64 + 0))) << 1] + 32];
                val_66 = val_4[((long)(int)((val_64 + 0))) << 1] + 32;
            }
            
            if(val_66 != 54)
            {
                goto label_94;
            }
            
            val_68 = 1638;
            goto label_107;
            label_94:
            if(val_62 >= val_4.Length)
            {
                    val_66 = mem[val_4[((long)(int)((val_64 + 0))) << 1] + 32];
                val_66 = val_4[((long)(int)((val_64 + 0))) << 1] + 32;
            }
            
            if(val_66 != 55)
            {
                goto label_99;
            }
            
            val_68 = 1639;
            goto label_107;
            label_99:
            if(val_62 >= val_4.Length)
            {
                    val_66 = mem[val_4[((long)(int)((val_64 + 0))) << 1] + 32];
                val_66 = val_4[((long)(int)((val_64 + 0))) << 1] + 32;
            }
            
            if(val_66 != 56)
            {
                goto label_104;
            }
            
            val_68 = 1640;
            goto label_107;
            label_104:
            if(val_62 >= val_4.Length)
            {
                    val_66 = mem[val_4[((long)(int)((val_64 + 0))) << 1] + 32];
                val_66 = val_4[((long)(int)((val_64 + 0))) << 1] + 32;
            }
            
            if(val_66 != 57)
            {
                goto label_109;
            }
            
            val_68 = 1641;
            label_107:
            val_59[((long)(int)((val_64 + 0))) << 1] = '٩';
            label_109:
            if((val_62 + 1) < val_4.Length)
            {
                goto label_112;
            }
            
            label_11:
            val_69 = null;
            val_69 = null;
            if(I2.Loc.RTLFixerTool.showTashkeel != false)
            {
                    val_59 = I2.Loc.RTLFixerTool.ReturnTashkeel(letters:  val_59, tashkeelLocation:  val_1);
            }
            
            System.Collections.Generic.List<System.Char> val_18 = null;
            val_70 = val_18;
            val_18 = new System.Collections.Generic.List<System.Char>();
            System.Collections.Generic.List<System.Char> val_19 = new System.Collections.Generic.List<System.Char>();
            int val_20 = val_17.Length - 1;
            if((val_20 & 2147483648) != 0)
            {
                goto label_119;
            }
            
            goto label_257;
            label_255:
            if((long)val_20 < val_17.Length)
            {
                goto label_121;
            }
            
            label_245:
            label_246:
            val_71 = null;
            label_121:
            if(val_71 == 65535)
            {
                goto label_174;
            }
            
            if((long)val_20 >= val_17.Length)
            {
                    val_71 = null;
            }
            
            label_249:
            val_72 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            val_73 = val_71;
            goto label_214;
            label_257:
            val_64 = (long)val_20 - 1;
            if(((long)val_20 < val_17.Length) || ((System.Char.IsPunctuation(c:  val_59[((long)(int)((val_17.Length - 1))) << 1])) == false))
            {
                goto label_139;
            }
            
            var val_66 = -4294967296;
            val_66 = val_66 + ((val_17.Length) << 32);
            if((long)val_20 >= (val_66 >> 32))
            {
                goto label_139;
            }
            
            int val_22 = val_17.Length - 2;
            if((System.Char.IsPunctuation(c:  val_59[((long)(int)((val_17.Length - 2))) << 1])) == true)
            {
                goto label_135;
            }
            
            if((System.Char.IsPunctuation(c:  val_59[((long)(int)(val_17.Length)) << 1])) == false)
            {
                goto label_139;
            }
            
            label_135:
            val_74 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
            val_74 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            if(val_74 != 40)
            {
                goto label_141;
            }
            
            val_75 = 1152921509642448880;
            val_73 = 41;
            goto label_253;
            label_139:
            if(((long)val_20 < 1) || ((val_17[((long)(int)((val_17.Length - 1))) << 1] + 32) != 32))
            {
                goto label_171;
            }
            
            var val_69 = -4294967296;
            val_69 = val_69 + ((val_17.Length) << 32);
            if((long)val_20 >= (val_69 >> 32))
            {
                goto label_171;
            }
            
            int val_25 = val_17.Length - 2;
            if((System.Char.IsLower(c:  val_59[((long)(int)((val_17.Length - 2))) << 1])) != true)
            {
                    if((System.Char.IsUpper(c:  val_17[((long)(int)((val_17.Length - 2))) << 1] + 32)) != true)
            {
                    if((System.Char.IsNumber(c:  val_17[((long)(int)((val_17.Length - 2))) << 1] + 32)) == false)
            {
                goto label_171;
            }
            
            }
            
            }
            
            if((System.Char.IsLower(c:  val_59[((long)(int)(val_17.Length)) << 1])) != true)
            {
                    if((System.Char.IsUpper(c:  val_17[((long)(int)(val_17.Length)) << 1] + 32)) != true)
            {
                    if((System.Char.IsNumber(c:  val_17[((long)(int)(val_17.Length)) << 1] + 32)) == false)
            {
                goto label_171;
            }
            
            }
            
            }
            
            val_64 = val_64;
            val_19.Add(item:  val_17[((long)(int)((val_17.Length - 1))) << 1] + 32);
            val_70 = val_70;
            goto label_174;
            label_171:
            val_64 = val_64;
            val_70 = val_70;
            if((((System.Char.IsNumber(c:  val_17[((long)(int)((val_17.Length - 1))) << 1] + 32)) != true) && ((System.Char.IsLower(c:  val_17[((long)(int)((val_17.Length - 1))) << 1] + 32)) != true)) && ((System.Char.IsUpper(c:  val_17[((long)(int)((val_17.Length - 1))) << 1] + 32)) != true))
            {
                    if((System.Char.IsSymbol(c:  val_17[((long)(int)((val_17.Length - 1))) << 1] + 32)) != true)
            {
                    if((System.Char.IsPunctuation(c:  val_17[((long)(int)((val_17.Length - 1))) << 1] + 32)) == false)
            {
                goto label_194;
            }
            
            }
            
            }
            
            val_76 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
            val_76 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            if(val_76 != 40)
            {
                goto label_196;
            }
            
            val_77 = 1152921509642448880;
            val_73 = 41;
            goto label_214;
            label_196:
            if((long)val_20 >= val_17.Length)
            {
                    val_76 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
                val_76 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            }
            
            if(val_76 != 41)
            {
                goto label_200;
            }
            
            val_77 = 1152921509642448880;
            val_73 = 40;
            goto label_214;
            label_200:
            if((long)val_20 >= val_17.Length)
            {
                    val_76 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
                val_76 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            }
            
            if(val_76 != 60)
            {
                goto label_204;
            }
            
            val_77 = 1152921509642448880;
            val_73 = 62;
            goto label_214;
            label_141:
            if((long)val_20 >= val_17.Length)
            {
                    val_74 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
                val_74 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            }
            
            if(val_74 != 41)
            {
                goto label_208;
            }
            
            val_75 = 1152921509642448880;
            val_73 = 40;
            goto label_253;
            label_204:
            if((long)val_20 >= val_17.Length)
            {
                    val_76 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
                val_76 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            }
            
            if(val_76 != 62)
            {
                goto label_212;
            }
            
            val_77 = 1152921509642448880;
            val_73 = 60;
            goto label_214;
            label_208:
            if((long)val_20 >= val_17.Length)
            {
                    val_74 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
                val_74 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            }
            
            if(val_74 != 60)
            {
                goto label_216;
            }
            
            val_75 = 1152921509642448880;
            val_73 = 62;
            goto label_253;
            label_212:
            if((long)val_20 >= val_17.Length)
            {
                    val_76 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
                val_76 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            }
            
            if(val_76 == 91)
            {
                goto label_220;
            }
            
            if((long)val_20 >= val_17.Length)
            {
                    val_76 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
                val_76 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            }
            
            if(val_76 == 93)
            {
                goto label_222;
            }
            
            goto label_235;
            label_216:
            if((long)val_20 >= val_17.Length)
            {
                    val_74 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
                val_74 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            }
            
            if(val_74 != 62)
            {
                goto label_225;
            }
            
            val_75 = 1152921509642448880;
            val_73 = 60;
            goto label_253;
            label_194:
            val_78 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
            val_78 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            if((val_78 >> 11) < 27)
            {
                goto label_229;
            }
            
            if((long)val_20 >= val_17.Length)
            {
                    val_78 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
                val_78 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            }
            
            if((val_78 >> 10) < 55)
            {
                goto label_235;
            }
            
            label_229:
            if((long)val_20 >= val_17.Length)
            {
                    val_78 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
                val_78 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            }
            
            if((val_78 >> 10) < 55)
            {
                goto label_233;
            }
            
            if((long)val_20 >= val_17.Length)
            {
                    val_78 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
                val_78 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            }
            
            if((val_78 >> 13) <= 6)
            {
                goto label_235;
            }
            
            label_233:
            val_79 = 1152921512325121712;
            if(val_19.Count < 1)
            {
                goto label_237;
            }
            
            val_80 = 0;
            goto label_238;
            label_243:
            label_242:
            val_18.Add(item:  val_19.Item[val_19.Count + 0]);
            val_79 = 1152921512325121712;
            val_80 = 1;
            label_238:
            if(val_19 == null)
            {
                goto label_240;
            }
            
            if(val_80 >= val_19.Count)
            {
                goto label_241;
            }
            
            int val_46 = val_19.Count;
            goto label_242;
            label_240:
            if(val_80 < val_19.Count)
            {
                goto label_243;
            }
            
            label_241:
            val_19.Clear();
            label_237:
            if((long)val_20 >= val_17.Length)
            {
                goto label_245;
            }
            
            goto label_246;
            label_235:
            if(val_19 != null)
            {
                goto label_249;
            }
            
            goto label_249;
            label_225:
            if((long)val_20 >= val_17.Length)
            {
                    val_74 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
                val_74 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            }
            
            if(val_74 != 91)
            {
                goto label_251;
            }
            
            label_220:
            val_75 = 1152921509642448880;
            val_73 = 93;
            goto label_253;
            label_251:
            if((long)val_20 >= val_17.Length)
            {
                    val_74 = mem[val_17[((long)(int)((val_17.Length - 1))) << 1] + 32];
                val_74 = val_17[((long)(int)((val_17.Length - 1))) << 1] + 32;
            }
            
            if(val_74 != 93)
            {
                goto label_255;
            }
            
            label_222:
            val_75 = 1152921509642448880;
            val_73 = 91;
            label_253:
            label_214:
            val_18.Add(item:  '[');
            label_174:
            if((val_64 & 2147483648) == 0)
            {
                goto label_257;
            }
            
            label_119:
            if(val_19.Count < 1)
            {
                goto label_259;
            }
            
            val_60 = 1152921512325122736;
            val_81 = 0;
            goto label_260;
            label_265:
            val_82 = val_19.Count;
            goto label_261;
            label_264:
            if(val_81 >= val_19.Count)
            {
                goto label_262;
            }
            
            val_82 = val_19.Count;
            label_261:
            val_18.Add(item:  val_19.Item[val_82 + 0]);
            val_81 = 1;
            label_260:
            if(val_19 == null)
            {
                goto label_264;
            }
            
            if(val_81 < val_19.Count)
            {
                goto label_265;
            }
            
            label_262:
            val_19.Clear();
            label_259:
            int val_55 = val_18.Count;
            char[] val_56 = new char[0];
            val_83 = 0;
            goto label_267;
            label_271:
            val_83 = 1;
            val_56[0] = val_18.Item[0];
            label_267:
            if(val_83 < val_56.Length)
            {
                goto label_271;
            }
            
            return (string)0.CreateString(val:  val_56);
        }
        internal static bool IsIgnoredCharacter(char ch)
        {
            var val_20;
            var val_20 = 64341;
            val_20 = val_20 + ch;
            if(val_20 > ('<'))
            {
                goto label_4;
            }
            
            val_20 = 1 << val_20;
            val_20 = val_20 & 1157425172953694209;
            if(val_20 == 0)
            {
                goto label_4;
            }
            
            val_20 = 1;
            goto label_5;
            label_4:
            var val_7 = ((ch & 65535) == 'ﮎ') ? 1 : 0;
            label_5:
            char val_8 = ch + 400;
            bool val_9 = (System.Char.IsPunctuation(c:  ch)) | (System.Char.IsNumber(c:  ch));
            val_8 = val_8 & 65535;
            val_9 = val_9 | (System.Char.IsLower(c:  ch));
            bool val_10 = val_9 | (System.Char.IsUpper(c:  ch));
            val_7 = val_7 | ((val_8 < '') ? 1 : 0);
            var val_13 = (val_7 == 0) ? 1 : 0;
            val_10 = val_10 | (System.Char.IsSymbol(c:  ch));
            if(val_10 == true)
            {
                    return true;
            }
            
            val_13 = val_13 & (((ch & 65535) != 'ﯼ') ? 1 : 0);
            if((val_13 & 1) != 0)
            {
                    return true;
            }
            
            char val_15 = ch & 65535;
            if(val_15 == ('>'))
            {
                    return true;
            }
            
            if(val_15 == 'a')
            {
                    return true;
            }
            
            char val_16 = ch & 65535;
            var val_19 = ((val_16 == '؛') ? 1 : 0) | ((val_16 == ('<')) ? 1 : 0);
            return true;
        }
        internal static bool IsLeadingLetter(char[] letters, int index)
        {
            var val_13;
            char val_14;
            var val_15;
            var val_16;
            char val_17;
            char val_18;
            if(index == 0)
            {
                goto label_1;
            }
            
            val_13 = (long)index - 1;
            val_14 = letters[((long)(int)((index - 1))) << 1];
            if(val_14 == ' ')
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_14 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_14 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_14 == 42)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_14 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_14 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_14 == 65)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_14 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_14 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if((System.Char.IsPunctuation(c:  val_14)) == true)
            {
                goto label_39;
            }
            
            val_15 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
            val_15 = letters[((long)(int)((index - 1))) << 1] + 32;
            if(val_15 == 62)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_15 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_15 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_15 == 60)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_15 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_15 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_15 == 65165)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_15 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_15 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_15 == 65193)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_15 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_15 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_15 == 65195)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_15 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_15 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_15 == 65197)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_15 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_15 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_15 == 65199)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_15 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_15 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_15 == 64394)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_15 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_15 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_15 == 65261)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_15 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_15 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_15 == 65153)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_15 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_15 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_15 == 65155)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_15 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_15 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_15 == 65159)
            {
                goto label_39;
            }
            
            if(val_13 >= letters.Length)
            {
                    val_15 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_15 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            var val_3 = (val_15 == 65157) ? 1 : 0;
            goto label_38;
            label_1:
            label_39:
            val_16 = 1;
            label_38:
            val_17 = letters[((long)(int)(index)) << 1];
            if(val_17 == ' ')
            {
                goto label_61;
            }
            
            if(letters.Length <= index)
            {
                    val_17 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_17 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_17 == 65193)
            {
                goto label_61;
            }
            
            if(letters.Length <= index)
            {
                    val_17 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_17 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_17 == 65195)
            {
                goto label_61;
            }
            
            if(letters.Length <= index)
            {
                    val_17 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_17 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_17 == 65197)
            {
                goto label_61;
            }
            
            if(letters.Length <= index)
            {
                    val_17 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_17 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_17 == 65199)
            {
                goto label_61;
            }
            
            if(letters.Length <= index)
            {
                    val_17 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_17 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_17 == 64394)
            {
                goto label_61;
            }
            
            if(letters.Length <= index)
            {
                    val_17 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_17 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_17 == 65165)
            {
                goto label_61;
            }
            
            if(letters.Length <= index)
            {
                    val_17 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_17 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_17 == 65155)
            {
                goto label_61;
            }
            
            if(letters.Length <= index)
            {
                    val_17 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_17 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_17 == 65159)
            {
                goto label_61;
            }
            
            if(letters.Length <= index)
            {
                    val_17 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_17 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_17 == 65153)
            {
                goto label_61;
            }
            
            if(letters.Length <= index)
            {
                    val_17 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_17 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_17 == 65157)
            {
                goto label_61;
            }
            
            if(letters.Length <= index)
            {
                    val_17 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_17 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_17 != 65261)
            {
                goto label_63;
            }
            
            label_61:
            label_90:
            if((letters.Length - 1) <= index)
            {
                    return (bool)(0 & val_16) & 0;
            }
            
            val_18 = letters[((long)(int)((index + 1))) << 1];
            if(val_18 == ' ')
            {
                    return (bool)(0 & val_16) & 0;
            }
            
            if(((long)index + 1) >= letters.Length)
            {
                    val_18 = mem[letters[((long)(int)((index + 1))) << 1] + 32];
                val_18 = letters[((long)(int)((index + 1))) << 1] + 32;
            }
            
            if((System.Char.IsPunctuation(c:  val_18)) == true)
            {
                    return (bool)(0 & val_16) & 0;
            }
            
            if((System.Char.IsNumber(c:  letters[((long)(int)((index + 1))) << 1] + 32)) == true)
            {
                    return (bool)(0 & val_16) & 0;
            }
            
            if((System.Char.IsSymbol(c:  letters[((long)(int)((index + 1))) << 1] + 32)) == true)
            {
                    return (bool)(0 & val_16) & 0;
            }
            
            if((System.Char.IsLower(c:  letters[((long)(int)((index + 1))) << 1] + 32)) != true)
            {
                    if((System.Char.IsUpper(c:  letters[((long)(int)((index + 1))) << 1] + 32)) == false)
            {
                goto label_86;
            }
            
            }
            
            return (bool)(0 & val_16) & 0;
            label_86:
            var val_13 = ((letters[((long)(int)((index + 1))) << 1] + 32) != 384) ? 1 : 0;
            return (bool)(0 & val_16) & 0;
            label_63:
            if(letters.Length <= index)
            {
                    val_17 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_17 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            var val_14 = (val_17 != 65152) ? 1 : 0;
            goto label_90;
        }
        internal static bool IsFinishingLetter(char[] letters, int index)
        {
            char val_6;
            var val_7;
            var val_8;
            char val_9;
            var val_10;
            if(index == 0)
            {
                goto label_1;
            }
            
            val_6 = letters[((long)(int)((index - 1))) << 1];
            if(val_6 == ' ')
            {
                goto label_37;
            }
            
            if(((long)index - 1) >= letters.Length)
            {
                    val_6 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_6 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_6 == 65193)
            {
                goto label_37;
            }
            
            if(((long)index - 1) >= letters.Length)
            {
                    val_6 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_6 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_6 == 65195)
            {
                goto label_37;
            }
            
            if(((long)index - 1) >= letters.Length)
            {
                    val_6 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_6 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_6 == 65197)
            {
                goto label_37;
            }
            
            if(((long)index - 1) >= letters.Length)
            {
                    val_6 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_6 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_6 == 65199)
            {
                goto label_37;
            }
            
            if(((long)index - 1) >= letters.Length)
            {
                    val_6 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_6 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_6 == 64394)
            {
                goto label_37;
            }
            
            if(((long)index - 1) >= letters.Length)
            {
                    val_6 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_6 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_6 == 65261)
            {
                goto label_37;
            }
            
            if(((long)index - 1) >= letters.Length)
            {
                    val_6 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_6 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_6 == 65165)
            {
                goto label_37;
            }
            
            if(((long)index - 1) >= letters.Length)
            {
                    val_6 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_6 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_6 == 65153)
            {
                goto label_37;
            }
            
            if(((long)index - 1) >= letters.Length)
            {
                    val_6 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_6 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_6 == 65155)
            {
                goto label_37;
            }
            
            if(((long)index - 1) >= letters.Length)
            {
                    val_6 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_6 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_6 == 65159)
            {
                goto label_37;
            }
            
            if(((long)index - 1) >= letters.Length)
            {
                    val_6 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_6 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_6 == 65157)
            {
                goto label_37;
            }
            
            if(((long)index - 1) >= letters.Length)
            {
                    val_6 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_6 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if((val_6 == 65152) || ((System.Char.IsPunctuation(c:  letters[((long)(int)((index - 1))) << 1] + 32)) == true))
            {
                goto label_37;
            }
            
            val_7 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
            val_7 = letters[((long)(int)((index - 1))) << 1] + 32;
            if(val_7 == 62)
            {
                goto label_37;
            }
            
            if(((long)index - 1) >= letters.Length)
            {
                    val_7 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_7 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            var val_3 = (val_7 != 60) ? 1 : 0;
            goto label_36;
            label_1:
            label_37:
            val_8 = 0;
            label_36:
            val_9 = letters[((long)(int)(index)) << 1];
            if(val_9 == ' ')
            {
                    val_10 = 0;
                return (bool)((val_9 != 65152) ? 1 : 0) & val_8;
            }
            
            if(letters.Length <= index)
            {
                    val_9 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_9 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            return (bool)((val_9 != 65152) ? 1 : 0) & val_8;
        }
        internal static bool IsMiddleLetter(char[] letters, int index)
        {
            char val_12;
            char val_13;
            char val_14;
            var val_15;
            char val_16;
            var val_17;
            var val_18;
            var val_19;
            int val_12 = index;
            val_13 = letters;
            if(val_12 == 0)
            {
                goto label_1;
            }
            
            val_14 = val_13[((long)(int)(index)) << 1];
            if(val_14 == 'ﺍ')
            {
                goto label_22;
            }
            
            if(letters.Length <= val_12)
            {
                    val_14 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_14 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_14 == 65193)
            {
                goto label_22;
            }
            
            if(letters.Length <= val_12)
            {
                    val_14 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_14 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_14 == 65195)
            {
                goto label_22;
            }
            
            if(letters.Length <= val_12)
            {
                    val_14 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_14 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_14 == 65197)
            {
                goto label_22;
            }
            
            if(letters.Length <= val_12)
            {
                    val_14 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_14 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_14 == 65199)
            {
                goto label_22;
            }
            
            if(letters.Length <= val_12)
            {
                    val_14 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_14 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_14 == 64394)
            {
                goto label_22;
            }
            
            if(letters.Length <= val_12)
            {
                    val_14 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_14 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_14 == 65261)
            {
                goto label_22;
            }
            
            if(letters.Length <= val_12)
            {
                    val_14 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_14 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_14 == 65153)
            {
                goto label_22;
            }
            
            if(letters.Length <= val_12)
            {
                    val_14 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_14 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_14 == 65155)
            {
                goto label_22;
            }
            
            if(letters.Length <= val_12)
            {
                    val_14 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_14 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_14 == 65159)
            {
                goto label_22;
            }
            
            if(letters.Length <= val_12)
            {
                    val_14 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_14 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            if(val_14 != 65157)
            {
                goto label_24;
            }
            
            label_22:
            val_15 = 0;
            label_85:
            val_16 = val_13[((long)(int)((index - 1))) << 1];
            if(val_16 == 'ﺍ')
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_16 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_16 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_16 == 65193)
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_16 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_16 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_16 == 65195)
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_16 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_16 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_16 == 65197)
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_16 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_16 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_16 == 65199)
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_16 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_16 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_16 == 64394)
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_16 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_16 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_16 == 65261)
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_16 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_16 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_16 == 65153)
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_16 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_16 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_16 == 65155)
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_16 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_16 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_16 == 65159)
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_16 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_16 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_16 == 65157)
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_16 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_16 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_16 == 65152)
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_16 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_16 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            val_16 = val_16;
            if((System.Char.IsPunctuation(c:  val_16)) == true)
            {
                goto label_56;
            }
            
            val_17 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
            val_17 = letters[((long)(int)((index - 1))) << 1] + 32;
            if(val_17 == 62)
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_17 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_17 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_17 == 60)
            {
                goto label_56;
            }
            
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_17 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_17 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            if(val_17 != 32)
            {
                goto label_58;
            }
            
            label_56:
            val_18 = 0;
            goto label_87;
            label_1:
            val_18 = 0;
            val_15 = 0;
            label_87:
            if((letters.Length - 1) <= val_12)
            {
                goto label_71;
            }
            
            val_12 = val_13[((long)(int)((index + 1))) << 1];
            if(val_12 == ' ')
            {
                goto label_71;
            }
            
            if(((long)val_12 + 1) >= letters.Length)
            {
                    val_12 = mem[letters[((long)(int)((index + 1))) << 1] + 32];
                val_12 = letters[((long)(int)((index + 1))) << 1] + 32;
            }
            
            if(val_12 == 13)
            {
                goto label_71;
            }
            
            if(((long)val_12 + 1) >= letters.Length)
            {
                    val_12 = mem[letters[((long)(int)((index + 1))) << 1] + 32];
                val_12 = letters[((long)(int)((index + 1))) << 1] + 32;
            }
            
            if(val_12 == 65152)
            {
                goto label_71;
            }
            
            if(((long)val_12 + 1) >= letters.Length)
            {
                    val_12 = mem[letters[((long)(int)((index + 1))) << 1] + 32];
                val_12 = letters[((long)(int)((index + 1))) << 1] + 32;
            }
            
            if((System.Char.IsNumber(c:  val_12)) == true)
            {
                goto label_71;
            }
            
            val_12 = mem[letters[((long)(int)((index + 1))) << 1] + 32];
            val_12 = letters[((long)(int)((index + 1))) << 1] + 32;
            if((System.Char.IsSymbol(c:  val_12)) == false)
            {
                goto label_75;
            }
            
            label_71:
            label_83:
            val_19 = (val_18 & val_15) & 0;
            if(val_19 != 0)
            {
                    val_12 = val_12 + 1;
                val_13 = val_13[((long)(int)((index + 1))) << 1];
                bool val_8 = System.Char.IsPunctuation(c:  val_13);
                val_19 = val_8 ^ 1;
            }
            
            val_8 = val_19;
            return (bool)val_8;
            label_75:
            var val_13 = ~(System.Char.IsPunctuation(c:  letters[((long)(int)((index + 1))) << 1] + 32));
            val_13 = val_13 & 1;
            goto label_83;
            label_24:
            if(letters.Length <= val_12)
            {
                    val_14 = mem[letters[((long)(int)(index)) << 1] + 32];
                val_14 = letters[((long)(int)(index)) << 1] + 32;
            }
            
            var val_10 = (val_14 != 65152) ? 1 : 0;
            goto label_85;
            label_58:
            if(((long)val_12 - 1) >= letters.Length)
            {
                    val_17 = mem[letters[((long)(int)((index - 1))) << 1] + 32];
                val_17 = letters[((long)(int)((index - 1))) << 1] + 32;
            }
            
            var val_11 = (val_17 != 42) ? 1 : 0;
            goto label_87;
        }
        public RTLFixerTool()
        {
        
        }
        private static RTLFixerTool()
        {
            I2.Loc.RTLFixerTool.showTashkeel = true;
            I2.Loc.RTLFixerTool.useHinduNumbers = false;
        }
    
    }

}
