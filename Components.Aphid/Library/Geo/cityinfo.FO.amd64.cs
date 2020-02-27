
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
                                    public const string Country = "FO";
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
                            
                                        var cur = (Math.Abs(62.15853 - lat) + Math.Abs(-6.78301 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(62.35999 - lat) + Math.Abs(-6.5313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.15354 - lat) + Math.Abs(-7.17291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.47324 - lat) + Math.Abs(-6.81185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.55557 - lat) + Math.Abs(-6.81109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.00973 - lat) + Math.Abs(-6.77164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.59747 - lat) + Math.Abs(-6.94468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.10729 - lat) + Math.Abs(-6.75721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.07203 - lat) + Math.Abs(-7.30749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.77103 - lat) + Math.Abs(-6.80501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.90285 - lat) + Math.Abs(-6.88234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.83141 - lat) + Math.Abs(-6.6623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.8425 - lat) + Math.Abs(-6.80778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.05372 - lat) + Math.Abs(-7.14982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.11647 - lat) + Math.Abs(-6.71797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.10892 - lat) + Math.Abs(-6.72123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.48135 - lat) + Math.Abs(-6.74497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.20071 - lat) + Math.Abs(-6.74191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.05111 - lat) + Math.Abs(-7.19389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.20992 - lat) + Math.Abs(-6.69284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.30388 - lat) + Math.Abs(-6.64754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.11167 - lat) + Math.Abs(-6.91067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.22655 - lat) + Math.Abs(-6.58901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.3263 - lat) + Math.Abs(-6.32379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.60237 - lat) + Math.Abs(-6.96063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.03407 - lat) + Math.Abs(-6.78127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.50684 - lat) + Math.Abs(-6.75993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.24398 - lat) + Math.Abs(-6.81395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.2993 - lat) + Math.Abs(-7.09245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.99595 - lat) + Math.Abs(-6.77154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.20907 - lat) + Math.Abs(-6.75247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Ytri Skáli", "ST", 62.15853, -6.78301);
case 1: return new CityInfo("Viðareiði", "NO", 62.35999, -6.5313);
case 2: return new CityInfo("Vestmanna", "ST", 62.15354, -7.17291);
case 3: return new CityInfo("Vágur", "SU", 61.47324, -6.81185);
case 4: return new CityInfo("Tvøroyri", "SU", 61.55557, -6.81109);
case 5: return new CityInfo("Tórshavn", "ST", 62.00973, -6.77164);
case 6: return new CityInfo("Toftir", "SU", 61.59747, -6.94468);
case 7: return new CityInfo("Strendur", "ST", 62.10729, -6.75721);
case 8: return new CityInfo("Sørvágur", "VG", 62.07203, -7.30749);
case 9: return new CityInfo("Skúvoy", "SA", 61.77103, -6.80501);
case 10: return new CityInfo("Skopun", "SA", 61.90285, -6.88234);
case 11: return new CityInfo("Skálavík", "SA", 61.83141, -6.6623);
case 12: return new CityInfo("Sandur", "SA", 61.8425, -6.80778);
case 13: return new CityInfo("Sandavágur", "VG", 62.05372, -7.14982);
case 14: return new CityInfo("Saltangará", "OS", 62.11647, -6.71797);
case 15: return new CityInfo("Runavík", "OS", 62.10892, -6.72123);
case 16: return new CityInfo("Porkeri", "SU", 61.48135, -6.74497);
case 17: return new CityInfo("Norðragøta", "OS", 62.20071, -6.74191);
case 18: return new CityInfo("Miðvágur", "VG", 62.05111, -7.19389);
case 19: return new CityInfo("Leirvík", "OS", 62.20992, -6.69284);
case 20: return new CityInfo("Kunoy", "NO", 62.30388, -6.64754);
case 21: return new CityInfo("Kollafjørður", "ST", 62.11167, -6.91067);
case 22: return new CityInfo("Klaksvík", "NO", 62.22655, -6.58901);
case 23: return new CityInfo("Kirkja", "NO", 62.3263, -6.32379);
case 24: return new CityInfo("Hvalba", "SU", 61.60237, -6.96063);
case 25: return new CityInfo("Hoyvík", "ST", 62.03407, -6.78127);
case 26: return new CityInfo("Hov", "SU", 61.50684, -6.75993);
case 27: return new CityInfo("Fuglafjørður", "OS", 62.24398, -6.81395);
case 28: return new CityInfo("Eiði", "OS", 62.2993, -7.09245);
case 29: return new CityInfo("Argir", "ST", 61.99595, -6.77154);
default: return new CityInfo("Eystur", "OS", 62.20907, -6.75247);

                                    }                                        
                                }
                            
                        }
                    }
                