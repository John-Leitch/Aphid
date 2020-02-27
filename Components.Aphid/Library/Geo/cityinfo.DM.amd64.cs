
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
                                    public const string Country = "DM";
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
                            
                                        var cur = (Math.Abs(15.58093 - lat) + Math.Abs(-61.33149 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(15.56667 - lat) + Math.Abs(-61.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.23374 - lat) + Math.Abs(-61.35881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.43689 - lat) + Math.Abs(-61.43637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.4 - lat) + Math.Abs(-61.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.30174 - lat) + Math.Abs(-61.38808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.36667 - lat) + Math.Abs(-61.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.58333 - lat) + Math.Abs(-61.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.36667 - lat) + Math.Abs(-61.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.25976 - lat) + Math.Abs(-61.37452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.53886 - lat) + Math.Abs(-61.28375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.36357 - lat) + Math.Abs(-61.39701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.32768 - lat) + Math.Abs(-61.24753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.48478 - lat) + Math.Abs(-61.46215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.44397 - lat) + Math.Abs(-61.25723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.59297 - lat) + Math.Abs(-61.34901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.23333 - lat) + Math.Abs(-61.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.28439 - lat) + Math.Abs(-61.37049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Woodford Hill", "02", 15.58093, -61.33149);
case 1: return new CityInfo("Wesley", "02", 15.56667, -61.31667);
case 2: return new CityInfo("Soufrière", "08", 15.23374, -61.35881);
case 3: return new CityInfo("Salisbury", "06", 15.43689, -61.43637);
case 4: return new CityInfo("Saint Joseph", "06", 15.4, -61.43333);
case 5: return new CityInfo("Roseau", "04", 15.30174, -61.38808);
case 6: return new CityInfo("Rosalie", "03", 15.36667, -61.26667);
case 7: return new CityInfo("Portsmouth", "05", 15.58333, -61.46667);
case 8: return new CityInfo("Pont Cassé", "10", 15.36667, -61.35);
case 9: return new CityInfo("Pointe Michel", "07", 15.25976, -61.37452);
case 10: return new CityInfo("Marigot", "02", 15.53886, -61.28375);
case 11: return new CityInfo("Mahaut", "10", 15.36357, -61.39701);
case 12: return new CityInfo("La Plaine", "09", 15.32768, -61.24753);
case 13: return new CityInfo("Colihaut", "11", 15.48478, -61.46215);
case 14: return new CityInfo("Castle Bruce", "03", 15.44397, -61.25723);
case 15: return new CityInfo("Calibishie", "02", 15.59297, -61.34901);
case 16: return new CityInfo("Berekua", "09", 15.23333, -61.31667);
default: return new CityInfo("Castle Comfort", "04", 15.28439, -61.37049);

                                    }                                        
                                }
                            
                        }
                    }
                