
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
                                    public const string Country = "GP";
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
                            
                                        var cur = (Math.Abs(16.05866 - lat) + Math.Abs(-61.76667 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(15.97595 - lat) + Math.Abs(-61.64492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.84993 - lat) + Math.Abs(-61.64457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.25236 - lat) + Math.Abs(-61.27332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.33264 - lat) + Math.Abs(-61.6969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.22564 - lat) + Math.Abs(-61.38098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.02515 - lat) + Math.Abs(-61.69975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.41749 - lat) + Math.Abs(-61.53045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.23218 - lat) + Math.Abs(-61.78917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.24125 - lat) + Math.Abs(-61.53614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.37913 - lat) + Math.Abs(-61.48716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.19163 - lat) + Math.Abs(-61.5914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.273 - lat) + Math.Abs(-61.50507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.33164 - lat) + Math.Abs(-61.34656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.20618 - lat) + Math.Abs(-61.49306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.27047 - lat) + Math.Abs(-61.63166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.30413 - lat) + Math.Abs(-61.07375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.88402 - lat) + Math.Abs(-61.3148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.99454 - lat) + Math.Abs(-61.69203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.04495 - lat) + Math.Abs(-61.56425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.13043 - lat) + Math.Abs(-61.76895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.99714 - lat) + Math.Abs(-61.73214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.02037 - lat) + Math.Abs(-61.74611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.26738 - lat) + Math.Abs(-61.58543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.47239 - lat) + Math.Abs(-61.50739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vieux-Habitants", "GP", 16.05866, -61.76667);
case 1: return new CityInfo("Trois-Rivières", "GP", 15.97595, -61.64492);
case 2: return new CityInfo("Petites Anses", "GP", 15.84993, -61.64457);
case 3: return new CityInfo("Saint-François", "GP", 16.25236, -61.27332);
case 4: return new CityInfo("Sainte-Rose", "GP", 16.33264, -61.6969);
case 5: return new CityInfo("Sainte-Anne", "GP", 16.22564, -61.38098);
case 6: return new CityInfo("Saint-Claude", "GP", 16.02515, -61.69975);
case 7: return new CityInfo("Port-Louis", "GP", 16.41749, -61.53045);
case 8: return new CityInfo("Pointe-Noire", "GP", 16.23218, -61.78917);
case 9: return new CityInfo("Pointe-à-Pitre", "GP", 16.24125, -61.53614);
case 10: return new CityInfo("Petit-Canal", "GP", 16.37913, -61.48716);
case 11: return new CityInfo("Petit-Bourg", "GP", 16.19163, -61.5914);
case 12: return new CityInfo("Les Abymes", "GP", 16.273, -61.50507);
case 13: return new CityInfo("Le Moule", "GP", 16.33164, -61.34656);
case 14: return new CityInfo("Le Gosier", "GP", 16.20618, -61.49306);
case 15: return new CityInfo("Lamentin", "GP", 16.27047, -61.63166);
case 16: return new CityInfo("Beauséjour", "GP", 16.30413, -61.07375);
case 17: return new CityInfo("Grand-Bourg", "GP", 15.88402, -61.3148);
case 18: return new CityInfo("Gourbeyre", "GP", 15.99454, -61.69203);
case 19: return new CityInfo("Capesterre-Belle-Eau", "GP", 16.04495, -61.56425);
case 20: return new CityInfo("Bouillante", "GP", 16.13043, -61.76895);
case 21: return new CityInfo("Basse-Terre", "GP", 15.99714, -61.73214);
case 22: return new CityInfo("Baillif", "GP", 16.02037, -61.74611);
case 23: return new CityInfo("Baie-Mahault", "GP", 16.26738, -61.58543);
default: return new CityInfo("Anse-Bertrand", "GP", 16.47239, -61.50739);

                                    }                                        
                                }
                            
                        }
                    }
                