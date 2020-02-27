
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
                                    public const string Country = "MW";
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
                            
                                        var cur = (Math.Abs(-9.93333 - lat) + Math.Abs(33.93333 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-9.70237 - lat) + Math.Abs(33.26969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.38596 - lat) + Math.Abs(35.3188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.06775 - lat) + Math.Abs(35.14046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.7804 - lat) + Math.Abs(34.4587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.01863 - lat) + Math.Abs(33.85746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.80635 - lat) + Math.Abs(35.65067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.52775 - lat) + Math.Abs(33.9149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.82027 - lat) + Math.Abs(34.63586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.91995 - lat) + Math.Abs(35.26199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.92744 - lat) + Math.Abs(34.29614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.60659 - lat) + Math.Abs(34.29073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.06667 - lat) + Math.Abs(34.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.39805 - lat) + Math.Abs(34.65343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.46556 - lat) + Math.Abs(34.02071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.9 - lat) + Math.Abs(33.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.60262 - lat) + Math.Abs(34.52479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.03163 - lat) + Math.Abs(35.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.53194 - lat) + Math.Abs(33.74008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.08239 - lat) + Math.Abs(34.91652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.79841 - lat) + Math.Abs(32.88019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.47815 - lat) + Math.Abs(35.26448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.16849 - lat) + Math.Abs(35.30002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.00693 - lat) + Math.Abs(35.30947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.06665 - lat) + Math.Abs(35.22543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.60602 - lat) + Math.Abs(34.10628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.96692 - lat) + Math.Abs(33.78725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.03333 - lat) + Math.Abs(33.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.65399 - lat) + Math.Abs(33.93754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.3779 - lat) + Math.Abs(34.33322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.67461 - lat) + Math.Abs(35.14071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.99329 - lat) + Math.Abs(34.51566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.03352 - lat) + Math.Abs(34.80091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.78499 - lat) + Math.Abs(35.00854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.97928 - lat) + Math.Abs(34.95575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.78721 - lat) + Math.Abs(35.03046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Karonga", "N", -9.93333, 33.93333);
case 1: return new CityInfo("Chitipa", "N", -9.70237, 33.26969);
case 2: return new CityInfo("Zomba", "S", -15.38596, 35.3188);
case 3: return new CityInfo("Thyolo", "S", -16.06775, 35.14046);
case 4: return new CityInfo("Salima", "C", -13.7804, 34.4587);
case 5: return new CityInfo("Rumphi", "N", -11.01863, 33.85746);
case 6: return new CityInfo("Phalombe", "S", -15.80635, 35.65067);
case 7: return new CityInfo("Ntchisi", "C", -13.52775, 33.9149);
case 8: return new CityInfo("Ntcheu", "C", -14.82027, 34.63586);
case 9: return new CityInfo("Nsanje", "S", -16.91995, 35.26199);
case 10: return new CityInfo("Nkhotakota", "C", -12.92744, 34.29614);
case 11: return new CityInfo("Nkhata Bay", "N", -11.60659, 34.29073);
case 12: return new CityInfo("Likoma", "N", -12.06667, 34.73333);
case 13: return new CityInfo("Neno", "S", -15.39805, 34.65343);
case 14: return new CityInfo("Mzuzu", "N", -11.46556, 34.02071);
case 15: return new CityInfo("Mzimba", "N", -11.9, 33.6);
case 16: return new CityInfo("Mwanza", "S", -15.60262, 34.52479);
case 17: return new CityInfo("Mulanje", "S", -16.03163, 35.5);
case 18: return new CityInfo("Mponela", "C", -13.53194, 33.74008);
case 19: return new CityInfo("Monkey Bay", "S", -14.08239, 34.91652);
case 20: return new CityInfo("Mchinji", "C", -13.79841, 32.88019);
case 21: return new CityInfo("Mangochi", "S", -14.47815, 35.26448);
case 22: return new CityInfo("Machinga", "S", -15.16849, 35.30002);
case 23: return new CityInfo("Luchenza", "S", -16.00693, 35.30947);
case 24: return new CityInfo("Liwonde", "S", -15.06665, 35.22543);
case 25: return new CityInfo("Livingstonia", "N", -10.60602, 34.10628);
case 26: return new CityInfo("Lilongwe", "C", -13.96692, 33.78725);
case 27: return new CityInfo("Kasungu", "C", -13.03333, 33.48333);
case 28: return new CityInfo("Dowa", "C", -13.65399, 33.93754);
case 29: return new CityInfo("Dedza", "C", -14.3779, 34.33322);
case 30: return new CityInfo("Chiradzulu", "S", -15.67461, 35.14071);
case 31: return new CityInfo("Chipoka", "C", -13.99329, 34.51566);
case 32: return new CityInfo("Chikwawa", "S", -16.03352, 34.80091);
case 33: return new CityInfo("Blantyre", "S", -15.78499, 35.00854);
case 34: return new CityInfo("Balaka", "S", -14.97928, 34.95575);
default: return new CityInfo("Makata", "S", -15.78721, 35.03046);

                                    }                                        
                                }
                            
                        }
                    }
                