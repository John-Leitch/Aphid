
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
                                    public const string Country = "LC";
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
                            
                                        var cur = (Math.Abs(13.71667 - lat) + Math.Abs(-60.95 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(13.85616 - lat) + Math.Abs(-61.0566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.87545 - lat) + Math.Abs(-60.89717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.81667 - lat) + Math.Abs(-60.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.75 - lat) + Math.Abs(-60.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.06667 - lat) + Math.Abs(-60.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.91409 - lat) + Math.Abs(-60.89132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.77273 - lat) + Math.Abs(-61.04931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.9957 - lat) + Math.Abs(-61.00614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.09956 - lat) + Math.Abs(-60.94346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.90224 - lat) + Math.Abs(-61.06459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.02429 - lat) + Math.Abs(-60.97445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.94619 - lat) + Math.Abs(-61.03879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vieux Fort", "10", 13.71667, -60.95);
case 1: return new CityInfo("Soufrière", "09", 13.85616, -61.0566);
case 2: return new CityInfo("Praslin", "08", 13.87545, -60.89717);
case 3: return new CityInfo("Micoud", "08", 13.81667, -60.9);
case 4: return new CityInfo("Laborie", "07", 13.75, -60.98333);
case 5: return new CityInfo("Gros Islet", "06", 14.06667, -60.95);
case 6: return new CityInfo("Dennery", "05", 13.91409, -60.89132);
case 7: return new CityInfo("Choiseul", "04", 13.77273, -61.04931);
case 8: return new CityInfo("Castries", "03", 13.9957, -61.00614);
case 9: return new CityInfo("Cap Estate", "06", 14.09956, -60.94346);
case 10: return new CityInfo("Canaries", "01", 13.90224, -61.06459);
case 11: return new CityInfo("Bisee", "03", 14.02429, -60.97445);
default: return new CityInfo("Anse La Raye", "01", 13.94619, -61.03879);

                                    }                                        
                                }
                            
                        }
                    }
                