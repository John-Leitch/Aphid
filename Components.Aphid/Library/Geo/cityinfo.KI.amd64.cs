
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
                                    public const string Country = "KI";
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
                            
                                        var cur = (Math.Abs(-1.21424 - lat) + Math.Abs(174.75866 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-0.73842 - lat) + Math.Abs(174.45422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.67058 - lat) + Math.Abs(174.44954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.33309 - lat) + Math.Abs(173.01162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.13765 - lat) + Math.Abs(174.67741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.52009 - lat) + Math.Abs(173.00302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.48589 - lat) + Math.Abs(173.82937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.34244 - lat) + Math.Abs(176.43567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-0.63125 - lat) + Math.Abs(174.41433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.65512 - lat) + Math.Abs(176.83302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.05379 - lat) + Math.Abs(173.26354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.17315 - lat) + Math.Abs(172.95972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.178 - lat) + Math.Abs(174.72788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.39078 - lat) + Math.Abs(173.13082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.60909 - lat) + Math.Abs(172.95526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.35797 - lat) + Math.Abs(172.92105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.3454 - lat) + Math.Abs(173.03464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.3278 - lat) + Math.Abs(172.97696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.90806 - lat) + Math.Abs(-159.38832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.98487 - lat) + Math.Abs(-157.47502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.01643 - lat) + Math.Abs(-157.48773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.98329 - lat) + Math.Abs(-157.36526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.50016 - lat) + Math.Abs(175.9798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(0.17708 - lat) + Math.Abs(173.63715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.3644 - lat) + Math.Abs(172.98352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.32342 - lat) + Math.Abs(172.97462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.32924 - lat) + Math.Abs(172.97522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.33015 - lat) + Math.Abs(172.9978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.35317 - lat) + Math.Abs(173.04259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.35621 - lat) + Math.Abs(173.054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.38081 - lat) + Math.Abs(173.13887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.36292 - lat) + Math.Abs(173.16226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.36362 - lat) + Math.Abs(173.13935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.3673 - lat) + Math.Abs(173.12415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.36154 - lat) + Math.Abs(173.08113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.36301 - lat) + Math.Abs(173.10965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Utiroa Village", "01", -1.21424, 174.75866);
case 1: return new CityInfo("Toboiaki Village", "01", -0.73842, 174.45422);
case 2: return new CityInfo("Matang Village", "01", -0.67058, 174.44954);
case 3: return new CityInfo("Teaoraereke Village", "01", 1.33309, 173.01162);
case 4: return new CityInfo("Tanaeang Village", "01", -1.13765, 174.67741);
case 5: return new CityInfo("Taborio Village", "01", 1.52009, 173.00302);
case 6: return new CityInfo("Tabiang Village", "01", 0.48589, 173.82937);
case 7: return new CityInfo("Rungata", "01", -1.34244, 176.43567);
case 8: return new CityInfo("Rotuma Village", "01", -0.63125, 174.41433);
case 9: return new CityInfo("Roreti Village", "01", -2.65512, 176.83302);
case 10: return new CityInfo("Rawannawi Village", "01", 2.05379, 173.26354);
case 11: return new CityInfo("Kuma Village", "01", 3.17315, 172.95972);
case 12: return new CityInfo("Eita Village", "01", -1.178, 174.72788);
case 13: return new CityInfo("Buota Village", "01", 1.39078, 173.13082);
case 14: return new CityInfo("Buariki Village", "01", 1.60909, 172.95526);
case 15: return new CityInfo("Betio Village", "01", 1.35797, 172.92105);
case 16: return new CityInfo("Banraeaba Village", "01", 1.3454, 173.03464);
case 17: return new CityInfo("Tarawa", "01", 1.3278, 172.97696);
case 18: return new CityInfo("Napari Village", "02", 3.90806, -159.38832);
case 19: return new CityInfo("London Village", "02", 1.98487, -157.47502);
case 20: return new CityInfo("Tabwakea Village", "02", 2.01643, -157.48773);
case 21: return new CityInfo("Banana Village", "02", 1.98329, -157.36526);
case 22: return new CityInfo("Bakaka Village", "01", -2.50016, 175.9798);
case 23: return new CityInfo("Buariki Village", "01", 0.17708, 173.63715);
case 24: return new CityInfo("Makin Village", "01", 3.3644, 172.98352);
case 25: return new CityInfo("Kiebu Village", "01", 3.32342, 172.97462);
case 26: return new CityInfo("Bairiki Village", "01", 1.32924, 172.97522);
case 27: return new CityInfo("Nanikai Village", "01", 1.33015, 172.9978);
case 28: return new CityInfo("Ambo Village", "01", 1.35317, 173.04259);
case 29: return new CityInfo("Taborio Village", "01", 1.35621, 173.054);
case 30: return new CityInfo("Bonriki Village", "01", 1.38081, 173.13887);
case 31: return new CityInfo("Temaiku Village", "01", 1.36292, 173.16226);
case 32: return new CityInfo("Nawerewere Village", "01", 1.36362, 173.13935);
case 33: return new CityInfo("Bikenibeu Village", "01", 1.3673, 173.12415);
case 34: return new CityInfo("Eita Village", "01", 1.36154, 173.08113);
default: return new CityInfo("Abarao Village", "01", 1.36301, 173.10965);

                                    }                                        
                                }
                            
                        }
                    }
                