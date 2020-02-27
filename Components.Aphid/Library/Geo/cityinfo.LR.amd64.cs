
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
                                    public const string Country = "LR";
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
                            
                                        var cur = (Math.Abs(6.06846 - lat) + Math.Abs(-8.13559 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(7.57944 - lat) + Math.Abs(-8.53778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.42194 - lat) + Math.Abs(-9.74778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.87064 - lat) + Math.Abs(-10.8211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.19739 - lat) + Math.Abs(-7.87579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.36215 - lat) + Math.Abs(-8.71326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.75329 - lat) + Math.Abs(-11.3671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.45683 - lat) + Math.Abs(-9.58167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.30054 - lat) + Math.Abs(-10.7969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.53104 - lat) + Math.Abs(-10.35368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.3782 - lat) + Math.Abs(-7.71081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.01133 - lat) + Math.Abs(-9.0388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.99543 - lat) + Math.Abs(-9.47122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.30222 - lat) + Math.Abs(-8.53083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.87693 - lat) + Math.Abs(-10.04964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.06667 - lat) + Math.Abs(-10.4875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.44716 - lat) + Math.Abs(-10.61283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.67443 - lat) + Math.Abs(-8.23306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.8275 - lat) + Math.Abs(-8.3428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zwedru", "19", 6.06846, -8.13559);
case 1: return new CityInfo("New Yekepa", "09", 7.57944, -8.53778);
case 2: return new CityInfo("Voinjama", "20", 8.42194, -9.74778);
case 3: return new CityInfo("Tubmanburg", "15", 6.87064, -10.8211);
case 4: return new CityInfo("Fish Town", "22", 5.19739, -7.87579);
case 5: return new CityInfo("Sanniquellie", "09", 7.36215, -8.71326);
case 6: return new CityInfo("Robertsport", "12", 6.75329, -11.3671);
case 7: return new CityInfo("Cestos City", "18", 5.45683, -9.58167);
case 8: return new CityInfo("Monrovia", "14", 6.30054, -10.7969);
case 9: return new CityInfo("Kakata", "17", 6.53104, -10.35368);
case 10: return new CityInfo("Harper", "13", 4.3782, -7.71081);
case 11: return new CityInfo("Greenville", "10", 5.01133, -9.0388);
case 12: return new CityInfo("Gbarnga", "01", 6.99543, -9.47122);
case 13: return new CityInfo("Ganta", "09", 7.30222, -8.53083);
case 14: return new CityInfo("Buchanan", "11", 5.87693, -10.04964);
case 15: return new CityInfo("Bopolu", "21", 7.06667, -10.4875);
case 16: return new CityInfo("Bensonville", "14", 6.44716, -10.61283);
case 17: return new CityInfo("Barclayville", "16", 4.67443, -8.23306);
default: return new CityInfo("Buutuo", "09", 6.8275, -8.3428);

                                    }                                        
                                }
                            
                        }
                    }
                