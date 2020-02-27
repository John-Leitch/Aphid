
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
                                    public const string Country = "GU";
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
                            
                                        var cur = (Math.Abs(13.46256 - lat) + Math.Abs(144.69331 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(13.38608 - lat) + Math.Abs(144.67226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46334 - lat) + Math.Abs(144.75406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.35513 - lat) + Math.Abs(144.75835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48773 - lat) + Math.Abs(144.78138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.29843 - lat) + Math.Abs(144.66314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53605 - lat) + Math.Abs(144.88855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.40974 - lat) + Math.Abs(144.77697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.26584 - lat) + Math.Abs(144.66908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.27363 - lat) + Math.Abs(144.74845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46559 - lat) + Math.Abs(144.74795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.47191 - lat) + Math.Abs(144.74978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.44741 - lat) + Math.Abs(144.75902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46913 - lat) + Math.Abs(144.79901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.38855 - lat) + Math.Abs(144.65852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.47215 - lat) + Math.Abs(144.71654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.51777 - lat) + Math.Abs(144.8391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.47567 - lat) + Math.Abs(144.74886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.44761 - lat) + Math.Abs(144.80109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46857 - lat) + Math.Abs(144.78214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.47279 - lat) + Math.Abs(144.75802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48754 - lat) + Math.Abs(144.78143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Piti Village", "PI", 13.46256, 144.69331);
case 1: return new CityInfo("Santa Rita Village", "SR", 13.38608, 144.67226);
case 2: return new CityInfo("Sinajana Village", "SJ", 13.46334, 144.75406);
case 3: return new CityInfo("Talofofo Village", "TF", 13.35513, 144.75835);
case 4: return new CityInfo("Tamuning-Tumon-Harmon Village", "TM", 13.48773, 144.78138);
case 5: return new CityInfo("Umatac Village", "UM", 13.29843, 144.66314);
case 6: return new CityInfo("Yigo Village", "YG", 13.53605, 144.88855);
case 7: return new CityInfo("Yona Village", "YN", 13.40974, 144.77697);
case 8: return new CityInfo("Merizo Village", "ME", 13.26584, 144.66908);
case 9: return new CityInfo("Inarajan Village", "IN", 13.27363, 144.74845);
case 10: return new CityInfo("Agana Heights Village", "AH", 13.46559, 144.74795);
case 11: return new CityInfo("Guam Government House", "AN", 13.47191, 144.74978);
case 12: return new CityInfo("Chalan Pago-Ordot Village", "CP", 13.44741, 144.75902);
case 13: return new CityInfo("Barrigada Village", "BA", 13.46913, 144.79901);
case 14: return new CityInfo("Agat Village", "AT", 13.38855, 144.65852);
case 15: return new CityInfo("Asan-Maina Village", "AS", 13.47215, 144.71654);
case 16: return new CityInfo("Dededo Village", "DD", 13.51777, 144.8391);
case 17: return new CityInfo("Hagåtña", "AN", 13.47567, 144.74886);
case 18: return new CityInfo("Mangilao Village", "MA", 13.44761, 144.80109);
case 19: return new CityInfo("Mongmong-Toto-Maite Village", "MT", 13.46857, 144.78214);
case 20: return new CityInfo("Hagåtña Village", "AN", 13.47279, 144.75802);
default: return new CityInfo("Tamuning", "TM", 13.48754, 144.78143);

                                    }                                        
                                }
                            
                        }
                    }
                