
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
                                    public const string Country = "AD";
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
                            
                                        var cur = (Math.Abs(42.57688 - lat) + Math.Abs(1.66769 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(42.57952 - lat) + Math.Abs(1.65362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.46372 - lat) + Math.Abs(1.49129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.54277 - lat) + Math.Abs(1.73361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.55623 - lat) + Math.Abs(1.53319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.50729 - lat) + Math.Abs(1.53414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.54499 - lat) + Math.Abs(1.51483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.54391 - lat) + Math.Abs(1.52289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.53474 - lat) + Math.Abs(1.58014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.5676 - lat) + Math.Abs(1.59756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.57205 - lat) + Math.Abs(1.48453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.50779 - lat) + Math.Abs(1.52109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Soldeu", "02", 42.57688, 1.66769);
case 1: return new CityInfo("El Tarter", "02", 42.57952, 1.65362);
case 2: return new CityInfo("Sant Julià de Lòria", "06", 42.46372, 1.49129);
case 3: return new CityInfo("Pas de la Casa", "03", 42.54277, 1.73361);
case 4: return new CityInfo("Ordino", "05", 42.55623, 1.53319);
case 5: return new CityInfo("les Escaldes", "08", 42.50729, 1.53414);
case 6: return new CityInfo("la Massana", "04", 42.54499, 1.51483);
case 7: return new CityInfo("l'Aldosa", "04", 42.54391, 1.52289);
case 8: return new CityInfo("Encamp", "03", 42.53474, 1.58014);
case 9: return new CityInfo("Canillo", "02", 42.5676, 1.59756);
case 10: return new CityInfo("Arinsal", "04", 42.57205, 1.48453);
default: return new CityInfo("Andorra la Vella", "07", 42.50779, 1.52109);

                                    }                                        
                                }
                            
                        }
                    }
                