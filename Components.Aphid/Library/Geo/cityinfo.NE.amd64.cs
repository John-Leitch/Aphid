
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
                                    public const string Country = "NE";
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
                            
                                        var cur = (Math.Abs(13.08173 - lat) + Math.Abs(2.91099 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(13.79599 - lat) + Math.Abs(5.25026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.80716 - lat) + Math.Abs(8.9881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.20711 - lat) + Math.Abs(1.45418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.56271 - lat) + Math.Abs(7.04848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.75737 - lat) + Math.Abs(7.9874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.00776 - lat) + Math.Abs(0.75306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.8969 - lat) + Math.Abs(5.7985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.97089 - lat) + Math.Abs(8.88786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.8888 - lat) + Math.Abs(5.2692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.1007 - lat) + Math.Abs(2.3689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.31641 - lat) + Math.Abs(2.08597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.51366 - lat) + Math.Abs(2.1098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.24953 - lat) + Math.Abs(13.10921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.70727 - lat) + Math.Abs(9.15013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.95532 - lat) + Math.Abs(7.67122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.42309 - lat) + Math.Abs(8.47485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.5 - lat) + Math.Abs(7.10174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.21139 - lat) + Math.Abs(12.0241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.99826 - lat) + Math.Abs(8.90991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.30867 - lat) + Math.Abs(7.15602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.073 - lat) + Math.Abs(5.96 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.6132 - lat) + Math.Abs(3.2358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.3043 - lat) + Math.Abs(2.339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7551 - lat) + Math.Abs(5.7749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53926 - lat) + Math.Abs(8.46293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.4605 - lat) + Math.Abs(5.2437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.6576 - lat) + Math.Abs(6.69567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.9835 - lat) + Math.Abs(10.27035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.88435 - lat) + Math.Abs(3.44919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.3521 - lat) + Math.Abs(3.3168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.049 - lat) + Math.Abs(3.1937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.6403 - lat) + Math.Abs(4.02649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.31536 - lat) + Math.Abs(12.61135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.51056 - lat) + Math.Abs(6.765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.42293 - lat) + Math.Abs(6.04278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.68532 - lat) + Math.Abs(12.91643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.73075 - lat) + Math.Abs(0.91739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.73694 - lat) + Math.Abs(7.38528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.0187 - lat) + Math.Abs(8.0168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.50601 - lat) + Math.Abs(7.77863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.97333 - lat) + Math.Abs(7.99111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.4509 - lat) + Math.Abs(6.2793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.22096 - lat) + Math.Abs(7.7614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Birnin Gaouré", "03", 13.08173, 2.91099);
case 1: return new CityInfo("Birni N Konni", "06", 13.79599, 5.25026);
case 2: return new CityInfo("Zinder", "07", 13.80716, 8.9881);
case 3: return new CityInfo("Tillabéri", "09", 14.20711, 1.45418);
case 4: return new CityInfo("Tibiri", "04", 13.56271, 7.04848);
case 5: return new CityInfo("Tessaoua", "04", 13.75737, 7.9874);
case 6: return new CityInfo("Téra", "09", 14.00776, 0.75306);
case 7: return new CityInfo("Tchintabaraden", "06", 15.8969, 5.7985);
case 8: return new CityInfo("Tanout", "07", 14.97089, 8.88786);
case 9: return new CityInfo("Tahoua", "06", 14.8888, 5.2692);
case 10: return new CityInfo("Say", "09", 13.1007, 2.3689);
case 11: return new CityInfo("Ouallam", "09", 14.31641, 2.08597);
case 12: return new CityInfo("Niamey", "08", 13.51366, 2.1098);
case 13: return new CityInfo("Nguigmi", "02", 14.24953, 13.10921);
case 14: return new CityInfo("Mirriah", "07", 13.70727, 9.15013);
case 15: return new CityInfo("Mayahi", "04", 13.95532, 7.67122);
case 16: return new CityInfo("Matamey", "07", 13.42309, 8.47485);
case 17: return new CityInfo("Maradi", "04", 13.5, 7.10174);
case 18: return new CityInfo("Maïné Soroa", "02", 13.21139, 12.0241);
case 19: return new CityInfo("Magaria", "07", 12.99826, 8.90991);
case 20: return new CityInfo("Madarounfa", "04", 13.30867, 7.15602);
case 21: return new CityInfo("Madaoua", "06", 14.073, 5.96);
case 22: return new CityInfo("Loga", "03", 13.6132, 3.2358);
case 23: return new CityInfo("Kollo", "09", 13.3043, 2.339);
case 24: return new CityInfo("Keïta", "06", 14.7551, 5.7749);
case 25: return new CityInfo("Kantché", "07", 13.53926, 8.46293);
case 26: return new CityInfo("Illéla", "06", 14.4605, 5.2437);
case 27: return new CityInfo("Guidan Roumdji", "04", 13.6576, 6.69567);
case 28: return new CityInfo("Gouré", "07", 13.9835, 10.27035);
case 29: return new CityInfo("Gaya", "03", 11.88435, 3.44919);
case 30: return new CityInfo("Filingué", "09", 14.3521, 3.3168);
case 31: return new CityInfo("Dosso", "03", 13.049, 3.1937);
case 32: return new CityInfo("Dogondoutchi", "03", 13.6403, 4.02649);
case 33: return new CityInfo("Diffa", "02", 13.31536, 12.61135);
case 34: return new CityInfo("Dakoro", "04", 14.51056, 6.765);
case 35: return new CityInfo("Bouza", "06", 14.42293, 6.04278);
case 36: return new CityInfo("Bilma", "01", 18.68532, 12.91643);
case 37: return new CityInfo("Ayorou", "09", 14.73075, 0.91739);
case 38: return new CityInfo("Arlit", "01", 18.73694, 7.38528);
case 39: return new CityInfo("Alaghsas", "01", 17.0187, 8.0168);
case 40: return new CityInfo("Aguié", "04", 13.50601, 7.77863);
case 41: return new CityInfo("Agadez", "01", 16.97333, 7.99111);
case 42: return new CityInfo("Abalak", "06", 15.4509, 6.2793);
default: return new CityInfo("Tchirozérine", "01", 17.22096, 7.7614);

                                    }                                        
                                }
                            
                        }
                    }
                