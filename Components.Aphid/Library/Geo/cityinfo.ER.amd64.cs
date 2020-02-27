
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
                                    public const string Country = "ER";
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
                            
                                        var cur = (Math.Abs(15.11 - lat) + Math.Abs(36.6575 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(15.60811 - lat) + Math.Abs(39.47455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.77792 - lat) + Math.Abs(38.45107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.93088 - lat) + Math.Abs(41.6938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.07 - lat) + Math.Abs(39.0475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.10582 - lat) + Math.Abs(37.59067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.33805 - lat) + Math.Abs(38.93184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.00917 - lat) + Math.Abs(42.73944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.54798 - lat) + Math.Abs(37.88291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.88722 - lat) + Math.Abs(38.81528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.84444 - lat) + Math.Abs(39.37722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.50914 - lat) + Math.Abs(38.87825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.55438 - lat) + Math.Abs(38.50292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Teseney", "04", 15.11, 36.6575);
case 1: return new CityInfo("Massawa", "06", 15.60811, 39.47455);
case 2: return new CityInfo("Keren", "01", 15.77792, 38.45107);
case 3: return new CityInfo("Edd", "03", 13.93088, 41.6938);
case 4: return new CityInfo("Dek’emhāre", "02", 15.07, 39.0475);
case 5: return new CityInfo("Barentu", "04", 15.10582, 37.59067);
case 6: return new CityInfo("Asmara", "05", 15.33805, 38.93184);
case 7: return new CityInfo("Assab", "03", 13.00917, 42.73944);
case 8: return new CityInfo("Ak’ordat", "04", 15.54798, 37.88291);
case 9: return new CityInfo("Mendefera", "02", 14.88722, 38.81528);
case 10: return new CityInfo("Adi Keyh", "02", 14.84444, 39.37722);
case 11: return new CityInfo("Quandeba", "05", 15.50914, 38.87825);
default: return new CityInfo("Mai-Mne", "02", 14.55438, 38.50292);

                                    }                                        
                                }
                            
                        }
                    }
                