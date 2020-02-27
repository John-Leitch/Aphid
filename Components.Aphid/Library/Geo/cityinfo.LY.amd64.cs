
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
                                    public const string Country = "LY";
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
                            
                                        var cur = (Math.Abs(31.75598 - lat) + Math.Abs(25.0866 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(32.08963 - lat) + Math.Abs(23.95385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.66818 - lat) + Math.Abs(20.25205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.03333 - lat) + Math.Abs(21.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.76704 - lat) + Math.Abs(22.63669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.11486 - lat) + Math.Abs(20.06859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.9522 - lat) + Math.Abs(20.12022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.10806 - lat) + Math.Abs(21.28694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.20487 - lat) + Math.Abs(23.2857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.53414 - lat) + Math.Abs(20.57911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.75684 - lat) + Math.Abs(22.24106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.49257 - lat) + Math.Abs(20.82909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.1989 - lat) + Math.Abs(23.29093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.74262 - lat) + Math.Abs(24.51676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.76272 - lat) + Math.Abs(21.75506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.19 - lat) + Math.Abs(20.59653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.75545 - lat) + Math.Abs(20.22625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.9312 - lat) + Math.Abs(12.08199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.46739 - lat) + Math.Abs(14.56874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.94699 - lat) + Math.Abs(11.86668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.06329 - lat) + Math.Abs(12.52859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.1614 - lat) + Math.Abs(16.13904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.43501 - lat) + Math.Abs(13.6332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.88743 - lat) + Math.Abs(13.18733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.88167 - lat) + Math.Abs(13.35056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.20892 - lat) + Math.Abs(16.58866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.75668 - lat) + Math.Abs(12.57159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.79335 - lat) + Math.Abs(12.48845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.03766 - lat) + Math.Abs(14.42832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.86848 - lat) + Math.Abs(10.9812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.91552 - lat) + Math.Abs(13.91839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.44934 - lat) + Math.Abs(12.9853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.37535 - lat) + Math.Abs(15.09254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.61667 - lat) + Math.Abs(14 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.40624 - lat) + Math.Abs(19.57386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.22054 - lat) + Math.Abs(19.20454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.95506 - lat) + Math.Abs(12.02901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.12684 - lat) + Math.Abs(15.94772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.75222 - lat) + Math.Abs(12.72778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.96334 - lat) + Math.Abs(10.18003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.17222 - lat) + Math.Abs(13.02028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.13366 - lat) + Math.Abs(9.50072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.54956 - lat) + Math.Abs(14.27139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.74554 - lat) + Math.Abs(13.98354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.93155 - lat) + Math.Abs(12.25291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.7571 - lat) + Math.Abs(12.72764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.59034 - lat) + Math.Abs(12.77511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.75718 - lat) + Math.Abs(12.37633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.95139 - lat) + Math.Abs(14.64861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.64861 - lat) + Math.Abs(14.26191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.05 - lat) + Math.Abs(14.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.53194 - lat) + Math.Abs(13.0175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.44707 - lat) + Math.Abs(13.05173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.05926 - lat) + Math.Abs(16.65905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Al Bardīyah", "79", 31.75598, 25.0866);
case 1: return new CityInfo("Tobruk", "79", 32.08963, 23.95385);
case 2: return new CityInfo("Qaryat Sulūq", "69", 31.66818, 20.25205);
case 3: return new CityInfo("Gialo", "83", 29.03333, 21.55);
case 4: return new CityInfo("Darnah", "70", 32.76704, 22.63669);
case 5: return new CityInfo("Benghazi", "69", 32.11486, 20.06859);
case 6: return new CityInfo("Az Zuwaytīnah", "83", 30.9522, 20.12022);
case 7: return new CityInfo("Awjilah", "83", 29.10806, 21.28694);
case 8: return new CityInfo("At Tāj", "65", 24.20487, 23.2857);
case 9: return new CityInfo("Tūkrah", "66", 32.53414, 20.57911);
case 10: return new CityInfo("Al Qubbah", "70", 32.75684, 22.24106);
case 11: return new CityInfo("Al Marj", "66", 32.49257, 20.82909);
case 12: return new CityInfo("Al Jawf", "65", 24.1989, 23.29093);
case 13: return new CityInfo("Al Jaghbūb", "79", 29.74262, 24.51676);
case 14: return new CityInfo("Al Bayḑā’", "63", 32.76272, 21.75506);
case 15: return new CityInfo("Al Abyār", "66", 32.19, 20.59653);
case 16: return new CityInfo("Ajdabiya", "83", 30.75545, 20.22625);
case 17: return new CityInfo("Zuwārah", "67", 32.9312, 12.08199);
case 18: return new CityInfo("Zliten", "72", 32.46739, 14.56874);
case 19: return new CityInfo("Zalţan", "67", 32.94699, 11.86668);
case 20: return new CityInfo("Yafran", "80", 32.06329, 12.52859);
case 21: return new CityInfo("Waddān", "64", 29.1614, 16.13904);
case 22: return new CityInfo("Tarhuna", "82", 32.43501, 13.6332);
case 23: return new CityInfo("Tripoli", "77", 32.88743, 13.18733);
case 24: return new CityInfo("Tagiura", "77", 32.88167, 13.35056);
case 25: return new CityInfo("Sirte", "76", 31.20892, 16.58866);
case 26: return new CityInfo("Şurmān", "68", 32.75668, 12.57159);
case 27: return new CityInfo("Şabrātah", "68", 32.79335, 12.48845);
case 28: return new CityInfo("Sabhā", "75", 27.03766, 14.42832);
case 29: return new CityInfo("Nālūt", "74", 31.86848, 10.9812);
case 30: return new CityInfo("Murzuq", "73", 25.91552, 13.91839);
case 31: return new CityInfo("Mizdah", "80", 31.44934, 12.9853);
case 32: return new CityInfo("Mişrātah", "72", 32.37535, 15.09254);
case 33: return new CityInfo("Masallātah", "82", 32.61667, 14);
case 34: return new CityInfo("Al Burayqah", "83", 30.40624, 19.57386);
case 35: return new CityInfo("Marādah", "83", 29.22054, 19.20454);
case 36: return new CityInfo("Giado", "80", 31.95506, 12.02901);
case 37: return new CityInfo("Hūn", "64", 29.12684, 15.94772);
case 38: return new CityInfo("Zawiya", "68", 32.75222, 12.72778);
case 39: return new CityInfo("Ghat", "71", 24.96334, 10.18003);
case 40: return new CityInfo("Gharyan", "80", 32.17222, 13.02028);
case 41: return new CityInfo("Ghadāmis", "74", 30.13366, 9.50072);
case 42: return new CityInfo("Brak", "78", 27.54956, 14.27139);
case 43: return new CityInfo("Bani Walid", "72", 31.74554, 13.98354);
case 44: return new CityInfo("Zintan", "80", 31.93155, 12.25291);
case 45: return new CityInfo("Az Zāwīyah", "68", 32.7571, 12.72764);
case 46: return new CityInfo("Ubari", "84", 26.59034, 12.77511);
case 47: return new CityInfo("Al Ajaylat", "67", 32.75718, 12.37633);
case 48: return new CityInfo("Al Qaţrūn", "73", 24.95139, 14.64861);
case 49: return new CityInfo("Al Khums", "82", 32.64861, 14.26191);
case 50: return new CityInfo("Al Jadīd", "75", 27.05, 14.4);
case 51: return new CityInfo("Al ‘Azīzīyah", "81", 32.53194, 13.0175);
case 52: return new CityInfo("Idrī", "78", 27.44707, 13.05173);
default: return new CityInfo("Qasr Abu Hadi", "76", 31.05926, 16.65905);

                                    }                                        
                                }
                            
                        }
                    }
                