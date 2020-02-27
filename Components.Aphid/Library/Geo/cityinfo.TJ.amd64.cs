
                    namespace Components.RoslynJit
                    {
                        using System;
                        using System.Collections.Generic;

                        public static class GeneratedContainer
                        {
                            
                                public readonly struct CityInfo
                                {
                                    public readonly string Name;
                                    public readonly string State;
                                    public const string Country = "TJ";
                                    public readonly double Latitude;
                                    public readonly double Longitude;

                                    public CityInfo(
                                        string name,
                                        in string state,
                                        double latitude,
                                        double longitude)
                                    {
                                        Name = name;
                                        State = state;
                                        Latitude = latitude;
                                        Longitude = longitude;
                                    }
                                }
                            
                                public static CityInfo GetClosestCity(double lat, double lng)
                                {
                                    double tmp;
                            
                                        var cur = (Math.Abs(38.31408 - lat) + Math.Abs(69.03784 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(37.80396 - lat) + Math.Abs(69.64417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.85125 - lat) + Math.Abs(70.58012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.77369 - lat) + Math.Abs(68.81776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.37078 - lat) + Math.Abs(71.45474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.71485 - lat) + Math.Abs(68.83456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.9142 - lat) + Math.Abs(69.00328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69529 - lat) + Math.Abs(70.48422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58221 - lat) + Math.Abs(68.13347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.83827 - lat) + Math.Abs(68.89847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.12405 - lat) + Math.Abs(70.84009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.0467 - lat) + Math.Abs(69.58822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84137 - lat) + Math.Abs(70.04865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.57085 - lat) + Math.Abs(68.33498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.77447 - lat) + Math.Abs(68.80929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.26206 - lat) + Math.Abs(68.13849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94487 - lat) + Math.Abs(71.55745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.25827 - lat) + Math.Abs(71.82591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.78257 - lat) + Math.Abs(69.87081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.83399 - lat) + Math.Abs(68.78186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.23634 - lat) + Math.Abs(69.09911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.49524 - lat) + Math.Abs(67.60931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49219 - lat) + Math.Abs(69.40356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.5582 - lat) + Math.Abs(68.81952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.55632 - lat) + Math.Abs(69.01354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76627 - lat) + Math.Abs(68.80126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.16033 - lat) + Math.Abs(68.66605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.71731 - lat) + Math.Abs(69.70885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.38917 - lat) + Math.Abs(69.32272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.01084 - lat) + Math.Abs(70.15082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.17023 - lat) + Math.Abs(73.96674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.66101 - lat) + Math.Abs(69.62849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.44173 - lat) + Math.Abs(68.77458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10714 - lat) + Math.Abs(70.03213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.94636 - lat) + Math.Abs(68.80878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91459 - lat) + Math.Abs(69.78454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.86776 - lat) + Math.Abs(69.96642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58823 - lat) + Math.Abs(68.65886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81908 - lat) + Math.Abs(68.85905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.34194 - lat) + Math.Abs(69.97531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.48974 - lat) + Math.Abs(71.55304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.74457 - lat) + Math.Abs(68.62702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.23585 - lat) + Math.Abs(71.52412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.87136 - lat) + Math.Abs(68.92233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.45373 - lat) + Math.Abs(70.78902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.40973 - lat) + Math.Abs(68.18644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.72484 - lat) + Math.Abs(71.61331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.52504 - lat) + Math.Abs(68.55124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.02871 - lat) + Math.Abs(70.37446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.56703 - lat) + Math.Abs(68.44668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.96238 - lat) + Math.Abs(69.12966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.54731 - lat) + Math.Abs(69.3198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.21966 - lat) + Math.Abs(71.19155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49167 - lat) + Math.Abs(68.53106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.34812 - lat) + Math.Abs(68.66398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.53575 - lat) + Math.Abs(68.77905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.09578 - lat) + Math.Abs(69.33998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.61453 - lat) + Math.Abs(69.70525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.52027 - lat) + Math.Abs(68.12825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84783 - lat) + Math.Abs(68.83125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.46613 - lat) + Math.Abs(68.80533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.30838 - lat) + Math.Abs(69.67672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.39406 - lat) + Math.Abs(68.53766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.51271 - lat) + Math.Abs(68.23163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.69331 - lat) + Math.Abs(69.73692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.40195 - lat) + Math.Abs(67.99446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.17603 - lat) + Math.Abs(68.84679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.57017 - lat) + Math.Abs(69.64175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.04605 - lat) + Math.Abs(70.54117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16713 - lat) + Math.Abs(69.50163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31628 - lat) + Math.Abs(69.73743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15709 - lat) + Math.Abs(68.74659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21524 - lat) + Math.Abs(70.57193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99827 - lat) + Math.Abs(70.42749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1522 - lat) + Math.Abs(69.37076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.57648 - lat) + Math.Abs(69.37962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20798 - lat) + Math.Abs(70.46882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.28256 - lat) + Math.Abs(69.62216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.49155 - lat) + Math.Abs(69.70245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.29414 - lat) + Math.Abs(70.43122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12649 - lat) + Math.Abs(70.62526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21571 - lat) + Math.Abs(69.72867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52286 - lat) + Math.Abs(69.33307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.66992 - lat) + Math.Abs(70.3502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65425 - lat) + Math.Abs(69.59811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64928 - lat) + Math.Abs(69.98472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.23417 - lat) + Math.Abs(69.69481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.41691 - lat) + Math.Abs(69.28677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.60931 - lat) + Math.Abs(68.58094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yovon", "02", 38.31408, 69.03784);
case 1: return new CityInfo("Vose’", "02", 37.80396, 69.64417);
case 2: return new CityInfo("Vorukh", "03", 39.85125, 70.58012);
case 3: return new CityInfo("Varzob", "RR", 38.77369, 68.81776);
case 4: return new CityInfo("Vanj", "01", 38.37078, 71.45474);
case 5: return new CityInfo("Vakhsh", "02", 37.71485, 68.83456);
case 6: return new CityInfo("Istaravshan", "03", 39.9142, 69.00328);
case 7: return new CityInfo("Tavildara", "RR", 38.69529, 70.48422);
case 8: return new CityInfo("Tartiki", "02", 37.58221, 68.13347);
case 9: return new CityInfo("Tagob", "RR", 38.83827, 68.89847);
case 10: return new CityInfo("Tajikobod", "RR", 39.12405, 70.84009);
case 11: return new CityInfo("Sovet", "02", 38.0467, 69.58822);
case 12: return new CityInfo("Shŭrobod", "02", 37.84137, 70.04865);
case 13: return new CityInfo("Shahrinav", "RR", 38.57085, 68.33498);
case 14: return new CityInfo("Shahriston", "03", 39.77447, 68.80929);
case 15: return new CityInfo("Shahritus", "02", 37.26206, 68.13849);
case 16: return new CityInfo("Rŭshon", "01", 37.94487, 71.55745);
case 17: return new CityInfo("Roshtqal’a", "01", 37.25827, 71.82591);
case 18: return new CityInfo("Roghun", "RR", 38.78257, 69.87081);
case 19: return new CityInfo("Qŭrghonteppa", "02", 37.83399, 68.78186);
case 20: return new CityInfo("Panj", "02", 37.23634, 69.09911);
case 21: return new CityInfo("Panjakent", "03", 39.49524, 67.60931);
case 22: return new CityInfo("Farkhor", "02", 37.49219, 69.40356);
case 23: return new CityInfo("Orzu", "02", 37.5582, 68.81952);
case 24: return new CityInfo("Vahdat", "RR", 38.55632, 69.01354);
case 25: return new CityInfo("Ismoili Somoní", "02", 37.76627, 68.80126);
case 26: return new CityInfo("Obikiik", "02", 38.16033, 68.66605);
case 27: return new CityInfo("Obigarm", "RR", 38.71731, 69.70885);
case 28: return new CityInfo("Norak", "02", 38.38917, 69.32272);
case 29: return new CityInfo("Novobod", "RR", 39.01084, 70.15082);
case 30: return new CityInfo("Murghob", "01", 38.17023, 73.96674);
case 31: return new CityInfo("Moskva", "02", 37.66101, 69.62849);
case 32: return new CityInfo("Somoniyon", "RR", 38.44173, 68.77458);
case 33: return new CityInfo("Mŭ’minobod", "02", 38.10714, 70.03213);
case 34: return new CityInfo("Abdurahmoni Jomí", "02", 37.94636, 68.80878);
case 35: return new CityInfo("Kŭlob", "02", 37.91459, 69.78454);
case 36: return new CityInfo("Darband", "RR", 38.86776, 69.96642);
case 37: return new CityInfo("Kolkhozobod", "02", 37.58823, 68.65886);
case 38: return new CityInfo("Kirov", "02", 37.81908, 68.85905);
case 39: return new CityInfo("Khovaling", "02", 38.34194, 69.97531);
case 40: return new CityInfo("Khorugh", "01", 37.48974, 71.55304);
case 41: return new CityInfo("Khodzha-Maston", "RR", 38.74457, 68.62702);
case 42: return new CityInfo("Karakenja", "RR", 39.23585, 71.52412);
case 43: return new CityInfo("Sarband", "02", 37.87136, 68.92233);
case 44: return new CityInfo("Qalaikhumb", "01", 38.45373, 70.78902);
case 45: return new CityInfo("Qubodiyon", "02", 37.40973, 68.18644);
case 46: return new CityInfo("Ishqoshim", "01", 36.72484, 71.61331);
case 47: return new CityInfo("Hisor", "RR", 38.52504, 68.55124);
case 48: return new CityInfo("Rasht", "RR", 39.02871, 70.37446);
case 49: return new CityInfo("Gharavŭtí", "02", 37.56703, 68.44668);
case 50: return new CityInfo("Ghonchí", "03", 39.96238, 69.12966);
case 51: return new CityInfo("Fayzobod", "RR", 38.54731, 69.3198);
case 52: return new CityInfo("Jirghatol", "RR", 39.21966, 71.19155);
case 53: return new CityInfo("Jilikŭl", "02", 37.49167, 68.53106);
case 54: return new CityInfo("Dŭstí", "02", 37.34812, 68.66398);
case 55: return new CityInfo("Dushanbe", "04", 38.53575, 68.77905);
case 56: return new CityInfo("Danghara", "02", 38.09578, 69.33998);
case 57: return new CityInfo("Chubek", "02", 37.61453, 69.70525);
case 58: return new CityInfo("Boshchorbogh", "02", 37.52027, 68.12825);
case 59: return new CityInfo("Bŭstonqal’a", "02", 37.84783, 68.83125);
case 60: return new CityInfo("Boshkengash", "04", 38.46613, 68.80533);
case 61: return new CityInfo("Baljuvon", "02", 38.30838, 69.67672);
case 62: return new CityInfo("Ayní", "03", 39.39406, 68.53766);
case 63: return new CityInfo("Tursunzoda", "RR", 38.51271, 68.23163);
case 64: return new CityInfo("Roghun", "RR", 38.69331, 69.73692);
case 65: return new CityInfo("Bahorí", "02", 37.40195, 67.99446);
case 66: return new CityInfo("Zafarobod", "03", 40.17603, 68.84679);
case 67: return new CityInfo("Taboshar", "03", 40.57017, 69.64175);
case 68: return new CityInfo("Shŭrob", "03", 40.04605, 70.54117);
case 69: return new CityInfo("Proletar", "03", 40.16713, 69.50163);
case 70: return new CityInfo("Palos", "03", 40.31628, 69.73743);
case 71: return new CityInfo("Pakhtakoron", "03", 40.15709, 68.74659);
case 72: return new CityInfo("Neftobod", "03", 40.21524, 70.57193);
case 73: return new CityInfo("Navgarzan", "03", 40.99827, 70.42749);
case 74: return new CityInfo("Nov", "03", 40.1522, 69.37076);
case 75: return new CityInfo("Quruqsoy", "03", 40.57648, 69.37962);
case 76: return new CityInfo("Kim", "03", 40.20798, 70.46882);
case 77: return new CityInfo("Khujand", "03", 40.28256, 69.62216);
case 78: return new CityInfo("Konsoy", "03", 40.49155, 69.70245);
case 79: return new CityInfo("Konibodom", "03", 40.29414, 70.43122);
case 80: return new CityInfo("Isfara", "03", 40.12649, 70.62526);
case 81: return new CityInfo("Ghafurov", "03", 40.21571, 69.72867);
case 82: return new CityInfo("Bŭston", "03", 40.52286, 69.33307);
case 83: return new CityInfo("Shaydon", "03", 40.66992, 70.3502);
case 84: return new CityInfo("Oltintopkan", "03", 40.65425, 69.59811);
case 85: return new CityInfo("Adrasmon", "03", 40.64928, 69.98472);
case 86: return new CityInfo("Buston", "03", 40.23417, 69.69481);
case 87: return new CityInfo("Mehron", "03", 39.41691, 69.28677);
default: return new CityInfo("Moskovskiy", "02", 37.60931, 68.58094);

                                    }                                        
                                }
                            
                        }
                    }
                