
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
                                    public const string Country = "GY";
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
                            
                                        var cur = (Math.Abs(6.80927 - lat) + Math.Abs(-58.19798 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(5.88333 - lat) + Math.Abs(-57.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.27095 - lat) + Math.Abs(-57.53697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.83712 - lat) + Math.Abs(-58.42941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.24793 - lat) + Math.Abs(-57.5171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.26667 - lat) + Math.Abs(-59.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.57633 - lat) + Math.Abs(-57.80486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.68405 - lat) + Math.Abs(-57.92181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.2 - lat) + Math.Abs(-59.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.00809 - lat) + Math.Abs(-58.30714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.38333 - lat) + Math.Abs(-59.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.80448 - lat) + Math.Abs(-58.15527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.40799 - lat) + Math.Abs(-58.62192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.26439 - lat) + Math.Abs(-58.50769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.39087 - lat) + Math.Abs(-57.60381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vreed-en-Hoop", "14", 6.80927, -58.19798);
case 1: return new CityInfo("Skeldon", "13", 5.88333, -57.13333);
case 2: return new CityInfo("Rosignol", "15", 6.27095, -57.53697);
case 3: return new CityInfo("Parika", "14", 6.83712, -58.42941);
case 4: return new CityInfo("New Amsterdam", "13", 6.24793, -57.5171);
case 5: return new CityInfo("Mahdia", "17", 5.26667, -59.15);
case 6: return new CityInfo("Mahaicony Village", "15", 6.57633, -57.80486);
case 7: return new CityInfo("Mahaica Village", "12", 6.68405, -57.92181);
case 8: return new CityInfo("Mabaruma", "10", 8.2, -59.78333);
case 9: return new CityInfo("Linden", "18", 6.00809, -58.30714);
case 10: return new CityInfo("Lethem", "19", 3.38333, -59.8);
case 11: return new CityInfo("Georgetown", "12", 6.80448, -58.15527);
case 12: return new CityInfo("Bartica", "11", 6.40799, -58.62192);
case 13: return new CityInfo("Anna Regina", "16", 7.26439, -58.50769);
default: return new CityInfo("Fort Wellington", "15", 6.39087, -57.60381);

                                    }                                        
                                }
                            
                        }
                    }
                