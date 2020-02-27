
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
                                    public const string Country = "IM";
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
                            
                                        var cur = (Math.Abs(54.11667 - lat) + Math.Abs(-4.58333 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(54.32273 - lat) + Math.Abs(-4.38526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.07405 - lat) + Math.Abs(-4.73858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.08487 - lat) + Math.Abs(-4.75099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.22209 - lat) + Math.Abs(-4.69099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.20447 - lat) + Math.Abs(-4.69417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.17329 - lat) + Math.Abs(-4.45324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.29877 - lat) + Math.Abs(-4.31844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.31667 - lat) + Math.Abs(-4.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.23017 - lat) + Math.Abs(-4.39985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.28562 - lat) + Math.Abs(-4.58748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.16667 - lat) + Math.Abs(-4.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.35941 - lat) + Math.Abs(-4.52199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.15 - lat) + Math.Abs(-4.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.18333 - lat) + Math.Abs(-4.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.07445 - lat) + Math.Abs(-4.65365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.38256 - lat) + Math.Abs(-4.38921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.0959 - lat) + Math.Abs(-4.62962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.1 - lat) + Math.Abs(-4.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.36667 - lat) + Math.Abs(-4.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.31193 - lat) + Math.Abs(-4.54456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Santon", "9782193", 54.11667, -4.58333);
case 1: return new CityInfo("Ramsey", "9782191", 54.32273, -4.38526);
case 2: return new CityInfo("Port Saint Mary", "9782190", 54.07405, -4.73858);
case 3: return new CityInfo("Port Erin", "9782189", 54.08487, -4.75099);
case 4: return new CityInfo("Peel", "9782188", 54.22209, -4.69099);
case 5: return new CityInfo("Patrick", "9782187", 54.20447, -4.69417);
case 6: return new CityInfo("Onchan", "9782186", 54.17329, -4.45324);
case 7: return new CityInfo("Maughold", "9782184", 54.29877, -4.31844);
case 8: return new CityInfo("Lezayre", "9782176", 54.31667, -4.41667);
case 9: return new CityInfo("Laxey", "9782173", 54.23017, -4.39985);
case 10: return new CityInfo("Kirkmichael", "9782185", 54.28562, -4.58748);
case 11: return new CityInfo("Kirk Braddan", "9782167", 54.16667, -4.51667);
case 12: return new CityInfo("Jurby", "9782172", 54.35941, -4.52199);
case 13: return new CityInfo("Douglas", "9782170", 54.15, -4.48333);
case 14: return new CityInfo("Crosby", "9782183", 54.18333, -4.56667);
case 15: return new CityInfo("Castletown", "9782169", 54.07445, -4.65365);
case 16: return new CityInfo("Bride", "9782168", 54.38256, -4.38921);
case 17: return new CityInfo("Ballasalla", "9782182", 54.0959, -4.62962);
case 18: return new CityInfo("Ballabeg", "9782165", 54.1, -4.68333);
case 19: return new CityInfo("Andreas", "9782164", 54.36667, -4.43333);
default: return new CityInfo("Ballaugh", "9782166", 54.31193, -4.54456);

                                    }                                        
                                }
                            
                        }
                    }
                