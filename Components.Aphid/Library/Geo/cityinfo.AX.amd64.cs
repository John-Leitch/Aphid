
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
                                    public const string Country = "AX";
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
                            
                                        var cur = (Math.Abs(60.25 - lat) + Math.Abs(20.38333 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(60.25 - lat) + Math.Abs(20.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.13023 - lat) + Math.Abs(20.66683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.28333 - lat) + Math.Abs(20.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.11695 - lat) + Math.Abs(20.25819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.07178 - lat) + Math.Abs(20.08472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.26013 - lat) + Math.Abs(20.77892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(59.92051 - lat) + Math.Abs(20.90883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.01667 - lat) + Math.Abs(20.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.41165 - lat) + Math.Abs(21.04534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.09726 - lat) + Math.Abs(19.93481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.14902 - lat) + Math.Abs(19.951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.21667 - lat) + Math.Abs(19.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.37453 - lat) + Math.Abs(19.84455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.26667 - lat) + Math.Abs(19.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.21249 - lat) + Math.Abs(19.61442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vårdö", "213", 60.25, 20.38333);
case 1: return new CityInfo("Sund", "212", 60.25, 20.11667);
case 2: return new CityInfo("Sottunga", "213", 60.13023, 20.66683);
case 3: return new CityInfo("Saltvik", "212", 60.28333, 20.05);
case 4: return new CityInfo("Lumparland", "212", 60.11695, 20.25819);
case 5: return new CityInfo("Lemland", "212", 60.07178, 20.08472);
case 6: return new CityInfo("Kumlinge", "213", 60.26013, 20.77892);
case 7: return new CityInfo("Kökar", "213", 59.92051, 20.90883);
case 8: return new CityInfo("Föglö", "213", 60.01667, 20.41667);
case 9: return new CityInfo("Brändö", "213", 60.41165, 21.04534);
case 10: return new CityInfo("Mariehamn", "211", 60.09726, 19.93481);
case 11: return new CityInfo("Jomala", "212", 60.14902, 19.951);
case 12: return new CityInfo("Hammarland", "212", 60.21667, 19.75);
case 13: return new CityInfo("Geta", "212", 60.37453, 19.84455);
case 14: return new CityInfo("Finström", "212", 60.26667, 19.93333);
default: return new CityInfo("Eckerö", "212", 60.21249, 19.61442);

                                    }                                        
                                }
                            
                        }
                    }
                