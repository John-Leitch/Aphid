
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
                                    public const string Country = "LS";
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
                            
                                        var cur = (Math.Abs(-29.14719 - lat) + Math.Abs(27.74895 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-30.40001 - lat) + Math.Abs(27.70027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.11537 - lat) + Math.Abs(28.68936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.61667 - lat) + Math.Abs(27.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.28939 - lat) + Math.Abs(29.06751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-30.15137 - lat) + Math.Abs(27.47691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.31667 - lat) + Math.Abs(27.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.8866 - lat) + Math.Abs(27.89915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.82299 - lat) + Math.Abs(27.23744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.87185 - lat) + Math.Abs(28.04501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-28.76659 - lat) + Math.Abs(28.24937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-29.52204 - lat) + Math.Abs(28.6084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Teyateyaneng", "10", -29.14719, 27.74895);
case 1: return new CityInfo("Quthing", "18", -30.40001, 27.70027);
case 2: return new CityInfo("Qacha’s Nek", "17", -30.11537, 28.68936);
case 3: return new CityInfo("Nako", "14", -29.61667, 27.76667);
case 4: return new CityInfo("Mokhotlong", "16", -29.28939, 29.06751);
case 5: return new CityInfo("Mohale’s Hoek", "15", -30.15137, 27.47691);
case 6: return new CityInfo("Maseru", "14", -29.31667, 27.48333);
case 7: return new CityInfo("Maputsoe", "12", -28.8866, 27.89915);
case 8: return new CityInfo("Mafeteng", "13", -29.82299, 27.23744);
case 9: return new CityInfo("Leribe", "12", -28.87185, 28.04501);
case 10: return new CityInfo("Butha-Buthe", "11", -28.76659, 28.24937);
default: return new CityInfo("Thaba-Tseka", "19", -29.52204, 28.6084);

                                    }                                        
                                }
                            
                        }
                    }
                