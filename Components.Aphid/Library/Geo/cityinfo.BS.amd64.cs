
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
                                    public const string Country = "BS";
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
                            
                                        var cur = (Math.Abs(26.68711 - lat) + Math.Abs(-78.97702 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(25.54717 - lat) + Math.Abs(-76.76405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.06667 - lat) + Math.Abs(-78.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.64967 - lat) + Math.Abs(-74.84157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.05823 - lat) + Math.Abs(-77.34306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.94982 - lat) + Math.Abs(-73.67346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.54352 - lat) + Math.Abs(-73.8778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.54124 - lat) + Math.Abs(-77.0636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.53333 - lat) + Math.Abs(-78.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.60999 - lat) + Math.Abs(-78.27863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.31667 - lat) + Math.Abs(-77.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.16667 - lat) + Math.Abs(-76.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.51616 - lat) + Math.Abs(-75.78665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.53333 - lat) + Math.Abs(-78.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.50216 - lat) + Math.Abs(-76.63633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.19083 - lat) + Math.Abs(-75.72583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.87137 - lat) + Math.Abs(-77.51131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.7545 - lat) + Math.Abs(-74.20415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.05179 - lat) + Math.Abs(-74.53138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.1 - lat) + Math.Abs(-74.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.1 - lat) + Math.Abs(-76.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.6224 - lat) + Math.Abs(-75.67151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.70502 - lat) + Math.Abs(-77.76912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.728 - lat) + Math.Abs(-79.29721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.36667 - lat) + Math.Abs(-72.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("West End", "54", 26.68711, -78.97702);
case 1: return new CityInfo("Spanish Wells", "53", 25.54717, -76.76405);
case 2: return new CityInfo("San Andros", "47", 25.06667, -78.05);
case 3: return new CityInfo("Port Nelson", "49", 23.64967, -74.84157);
case 4: return new CityInfo("Nassau", "23", 25.05823, -77.34306);
case 5: return new CityInfo("Matthew Town", "13", 20.94982, -73.67346);
case 6: return new CityInfo("Masons Bay", "24", 22.54352, -73.8778);
case 7: return new CityInfo("Marsh Harbour", "37", 26.54124, -77.0636);
case 8: return new CityInfo("Lucaya", "25", 26.53333, -78.66667);
case 9: return new CityInfo("High Rock", "41", 26.60999, -78.27863);
case 10: return new CityInfo("Hard Bargain", "45", 26.31667, -77.56667);
case 11: return new CityInfo("Governor’s Harbour", "39", 25.16667, -76.23333);
case 12: return new CityInfo("George Town", "10", 23.51616, -75.78665);
case 13: return new CityInfo("Freeport", "25", 26.53333, -78.7);
case 14: return new CityInfo("Dunmore Town", "22", 25.50216, -76.63633);
case 15: return new CityInfo("Duncan Town", "18", 22.19083, -75.72583);
case 16: return new CityInfo("Cooper’s Town", "46", 26.87137, -77.51131);
case 17: return new CityInfo("Colonel Hill", "40", 22.7545, -74.20415);
case 18: return new CityInfo("Cockburn Town", "35", 24.05179, -74.53138);
case 19: return new CityInfo("Clarence Town", "15", 23.1, -74.98333);
case 20: return new CityInfo("Black Point", "36", 24.1, -76.38333);
case 21: return new CityInfo("Arthur’s Town", "06", 24.6224, -75.67151);
case 22: return new CityInfo("Andros Town", "47", 24.70502, -77.76912);
case 23: return new CityInfo("Alice Town", "05", 25.728, -79.29721);
default: return new CityInfo("Abraham’s Bay", "16", 22.36667, -72.96667);

                                    }                                        
                                }
                            
                        }
                    }
                