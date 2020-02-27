
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
                                    public const string Country = "RE";
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
                            
                                        var cur = (Math.Abs(-21.1 - lat) + Math.Abs(55.3 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-21.0271 - lat) + Math.Abs(55.5395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.3393 - lat) + Math.Abs(55.47811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.36086 - lat) + Math.Abs(55.7679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.00961 - lat) + Math.Abs(55.27134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.28585 - lat) + Math.Abs(55.41124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.17059 - lat) + Math.Abs(55.28824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.3777 - lat) + Math.Abs(55.61691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.90616 - lat) + Math.Abs(55.60788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.12858 - lat) + Math.Abs(55.79616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.89686 - lat) + Math.Abs(55.55056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.88231 - lat) + Math.Abs(55.4504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.03795 - lat) + Math.Abs(55.71546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.96333 - lat) + Math.Abs(55.65031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.35327 - lat) + Math.Abs(55.56427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.2766 - lat) + Math.Abs(55.51766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.24063 - lat) + Math.Abs(55.33685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.93752 - lat) + Math.Abs(55.29415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.92909 - lat) + Math.Abs(55.3348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.23333 - lat) + Math.Abs(55.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.13641 - lat) + Math.Abs(55.47187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.99667 - lat) + Math.Abs(55.67823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.21962 - lat) + Math.Abs(55.31513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Les Trois-Bassins", "RE", -21.1, 55.3);
case 1: return new CityInfo("Salazie", "RE", -21.0271, 55.5395);
case 2: return new CityInfo("Saint-Pierre", "RE", -21.3393, 55.47811);
case 3: return new CityInfo("Saint-Philippe", "RE", -21.36086, 55.7679);
case 4: return new CityInfo("Saint-Paul", "RE", -21.00961, 55.27134);
case 5: return new CityInfo("Saint-Louis", "RE", -21.28585, 55.41124);
case 6: return new CityInfo("Saint-Leu", "RE", -21.17059, 55.28824);
case 7: return new CityInfo("Saint-Joseph", "RE", -21.3777, 55.61691);
case 8: return new CityInfo("Sainte-Suzanne", "RE", -20.90616, 55.60788);
case 9: return new CityInfo("Sainte-Rose", "RE", -21.12858, 55.79616);
case 10: return new CityInfo("Sainte-Marie", "RE", -20.89686, 55.55056);
case 11: return new CityInfo("Saint-Denis", "RE", -20.88231, 55.4504);
case 12: return new CityInfo("Saint-Benoît", "RE", -21.03795, 55.71546);
case 13: return new CityInfo("Saint-André", "RE", -20.96333, 55.65031);
case 14: return new CityInfo("Petite-Île", "RE", -21.35327, 55.56427);
case 15: return new CityInfo("Le Tampon", "RE", -21.2766, 55.51766);
case 16: return new CityInfo("Les Avirons", "RE", -21.24063, 55.33685);
case 17: return new CityInfo("Le Port", "RE", -20.93752, 55.29415);
case 18: return new CityInfo("La Possession", "RE", -20.92909, 55.3348);
case 19: return new CityInfo("Entre-Deux", "RE", -21.23333, 55.46667);
case 20: return new CityInfo("Cilaos", "RE", -21.13641, 55.47187);
case 21: return new CityInfo("Bras-Panon", "RE", -20.99667, 55.67823);
default: return new CityInfo("Piton Saint-Leu", "RE", -21.21962, 55.31513);

                                    }                                        
                                }
                            
                        }
                    }
                