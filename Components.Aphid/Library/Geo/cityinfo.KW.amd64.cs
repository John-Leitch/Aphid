
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
                                    public const string Country = "KW";
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
                            
                                        var cur = (Math.Abs(29.26917 - lat) + Math.Abs(47.97806 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(29.33278 - lat) + Math.Abs(48.02861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.3032 - lat) + Math.Abs(48.04881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.4425 - lat) + Math.Abs(48.27472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.33389 - lat) + Math.Abs(48.07611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.34722 - lat) + Math.Abs(47.96167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.31167 - lat) + Math.Abs(48.07417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.14583 - lat) + Math.Abs(48.09472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.63917 - lat) + Math.Abs(47.93056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.09611 - lat) + Math.Abs(48.13278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.145 - lat) + Math.Abs(48.13028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.36972 - lat) + Math.Abs(47.97833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.3375 - lat) + Math.Abs(47.65806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.22528 - lat) + Math.Abs(48.10167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.0825 - lat) + Math.Abs(48.13028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.17389 - lat) + Math.Abs(48.12111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.2775 - lat) + Math.Abs(47.95861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.07694 - lat) + Math.Abs(48.08389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.365 - lat) + Math.Abs(48.00139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.29583 - lat) + Math.Abs(48.07861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.295 - lat) + Math.Abs(47.93306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.25722 - lat) + Math.Abs(48.05722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.18979 - lat) + Math.Abs(48.08716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.2393 - lat) + Math.Abs(48.08862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.19746 - lat) + Math.Abs(48.10278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.19076 - lat) + Math.Abs(48.11355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Janūb as Surrah", "07", 29.26917, 47.97806);
case 1: return new CityInfo("Ḩawallī", "08", 29.33278, 48.02861);
case 2: return new CityInfo("Bayān", "08", 29.3032, 48.04881);
case 3: return new CityInfo("Az Zawr", "02", 29.4425, 48.27472);
case 4: return new CityInfo("As Sālimīyah", "08", 29.33389, 48.07611);
case 5: return new CityInfo("Ash Shāmīyah", "02", 29.34722, 47.96167);
case 6: return new CityInfo("Ar Rumaythīyah", "08", 29.31167, 48.07417);
case 7: return new CityInfo("Ar Riqqah", "04", 29.14583, 48.09472);
case 8: return new CityInfo("Al Wafrah", "04", 28.63917, 47.93056);
case 9: return new CityInfo("Al Manqaf", "04", 29.09611, 48.13278);
case 10: return new CityInfo("Al Mahbūlah", "04", 29.145, 48.13028);
case 11: return new CityInfo("Kuwait City", "02", 29.36972, 47.97833);
case 12: return new CityInfo("Al Jahrā’", "05", 29.3375, 47.65806);
case 13: return new CityInfo("Al Funayţīs", "09", 29.22528, 48.10167);
case 14: return new CityInfo("Al Faḩāḩīl", "04", 29.0825, 48.13028);
case 15: return new CityInfo("Al Finţās", "04", 29.17389, 48.12111);
case 16: return new CityInfo("Al Farwānīyah", "07", 29.2775, 47.95861);
case 17: return new CityInfo("Al Aḩmadī", "04", 29.07694, 48.08389);
case 18: return new CityInfo("Ad Dasmah", "02", 29.365, 48.00139);
case 19: return new CityInfo("Salwá", "08", 29.29583, 48.07861);
case 20: return new CityInfo("Ar Rābiyah", "02", 29.295, 47.93306);
case 21: return new CityInfo("Şabāḩ as Sālim", "09", 29.25722, 48.05722);
case 22: return new CityInfo("Mubārak al Kabīr", "09", 29.18979, 48.08716);
case 23: return new CityInfo("Al-Masayel", "09", 29.2393, 48.08862);
case 24: return new CityInfo("Abu Fatira", "09", 29.19746, 48.10278);
default: return new CityInfo("Abu Al Hasaniya", "09", 29.19076, 48.11355);

                                    }                                        
                                }
                            
                        }
                    }
                