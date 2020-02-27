
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
                                    public const string Country = "AO";
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
                            
                                        var cur = (Math.Abs(-9.66078 - lat) + Math.Abs(20.39155 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-8.41915 - lat) + Math.Abs(20.74466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.55 - lat) + Math.Abs(20.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.70727 - lat) + Math.Abs(22.22466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.65 - lat) + Math.Abs(20.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.06715 - lat) + Math.Abs(20.70148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.60874 - lat) + Math.Abs(15.06131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.1349 - lat) + Math.Abs(12.36894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.23116 - lat) + Math.Abs(12.8666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.29782 - lat) + Math.Abs(14.91162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.26703 - lat) + Math.Abs(14.2401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.54015 - lat) + Math.Abs(16.34096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.83682 - lat) + Math.Abs(13.23432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.57848 - lat) + Math.Abs(13.66425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.18812 - lat) + Math.Abs(15.37495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.55 - lat) + Math.Abs(12.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.35669 - lat) + Math.Abs(15.11719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.20605 - lat) + Math.Abs(13.84371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.73366 - lat) + Math.Abs(14.97995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.06667 - lat) + Math.Abs(15.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.19611 - lat) + Math.Abs(12.15222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.6585 - lat) + Math.Abs(17.69099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.78333 - lat) + Math.Abs(19.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.91717 - lat) + Math.Abs(13.4925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.90667 - lat) + Math.Abs(15.25333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.3644 - lat) + Math.Abs(13.53601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.38333 - lat) + Math.Abs(16.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.77611 - lat) + Math.Abs(15.73917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.16667 - lat) + Math.Abs(17.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.43002 - lat) + Math.Abs(13.54677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.15 - lat) + Math.Abs(17.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.01667 - lat) + Math.Abs(17.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.73333 - lat) + Math.Abs(15.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.8525 - lat) + Math.Abs(15.56056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.57626 - lat) + Math.Abs(13.40547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.30261 - lat) + Math.Abs(15.43358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.93244 - lat) + Math.Abs(14.99238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Saurimo", "18", -9.66078, 20.39155);
case 1: return new CityInfo("Lucapa", "17", -8.41915, 20.74466);
case 2: return new CityInfo("Lumeje", "14", -11.55, 20.78333);
case 3: return new CityInfo("Luau", "14", -10.70727, 22.22466);
case 4: return new CityInfo("Léua", "14", -11.65, 20.45);
case 5: return new CityInfo("Cazaji", "18", -11.06715, 20.70148);
case 6: return new CityInfo("Uíge", "15", -7.60874, 15.06131);
case 7: return new CityInfo("Soio", "16", -6.1349, 12.36894);
case 8: return new CityInfo("N'zeto", "16", -7.23116, 12.8666);
case 9: return new CityInfo("N’dalatando", "05", -9.29782, 14.91162);
case 10: return new CityInfo("Mbanza Kongo", "16", -6.26703, 14.2401);
case 11: return new CityInfo("Malanje", "12", -9.54015, 16.34096);
case 12: return new CityInfo("Luanda", "20", -8.83682, 13.23432);
case 13: return new CityInfo("Caxito", "19", -8.57848, 13.66425);
case 14: return new CityInfo("Camabatela", "05", -8.18812, 15.37495);
case 15: return new CityInfo("Cabinda", "03", -5.55, 12.2);
case 16: return new CityInfo("Uacu Cungo", "06", -11.35669, 15.11719);
case 17: return new CityInfo("Sumbe", "06", -11.20605, 13.84371);
case 18: return new CityInfo("Quibala", "06", -10.73366, 14.97995);
case 19: return new CityInfo("Ondjiva", "07", -17.06667, 15.73333);
case 20: return new CityInfo("Namibe", "13", -15.19611, 12.15222);
case 21: return new CityInfo("Menongue", "04", -14.6585, 17.69099);
case 22: return new CityInfo("Luena", "14", -11.78333, 19.91667);
case 23: return new CityInfo("Lubango", "09", -14.91717, 13.4925);
case 24: return new CityInfo("Longonjo", "08", -12.90667, 15.25333);
case 25: return new CityInfo("Lobito", "01", -12.3644, 13.53601);
case 26: return new CityInfo("Cuito", "02", -12.38333, 16.93333);
case 27: return new CityInfo("Huambo", "08", -12.77611, 15.73917);
case 28: return new CityInfo("Chissamba", "02", -12.16667, 17.33333);
case 29: return new CityInfo("Catumbela", "01", -12.43002, 13.54677);
case 30: return new CityInfo("Catabola", "02", -12.15, 17.28333);
case 31: return new CityInfo("Camacupa", "02", -12.01667, 17.48333);
case 32: return new CityInfo("Caconda", "09", -13.73333, 15.06667);
case 33: return new CityInfo("Caála", "08", -12.8525, 15.56056);
case 34: return new CityInfo("Benguela", "01", -12.57626, 13.40547);
case 35: return new CityInfo("Chela", "08", -12.30261, 15.43358);
default: return new CityInfo("Chinjenje", "08", -12.93244, 14.99238);

                                    }                                        
                                }
                            
                        }
                    }
                