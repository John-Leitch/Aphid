
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
                                    public const string Country = "TD";
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
                            
                                        var cur = (Math.Abs(15.11667 - lat) + Math.Abs(22.25 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(13.94563 - lat) + Math.Abs(20.5468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.22484 - lat) + Math.Abs(21.41034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.18535 - lat) + Math.Abs(21.58114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.52791 - lat) + Math.Abs(20.92749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.0297 - lat) + Math.Abs(20.2827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46648 - lat) + Math.Abs(22.19875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.82916 - lat) + Math.Abs(20.8324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.1429 - lat) + Math.Abs(18.3923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3642 - lat) + Math.Abs(14.9046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.2954 - lat) + Math.Abs(19.6966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.78333 - lat) + Math.Abs(17.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.10672 - lat) + Math.Abs(15.0444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.64143 - lat) + Math.Abs(16.48941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.56667 - lat) + Math.Abs(16.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.18441 - lat) + Math.Abs(18.69303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.3404 - lat) + Math.Abs(17.7663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.0598 - lat) + Math.Abs(17.9355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.7639 - lat) + Math.Abs(14.1539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.4039 - lat) + Math.Abs(16.1705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.996 - lat) + Math.Abs(15.72927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.47554 - lat) + Math.Abs(15.43647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.12116 - lat) + Math.Abs(15.3103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3972 - lat) + Math.Abs(16.30066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.45149 - lat) + Math.Abs(18.94493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.91256 - lat) + Math.Abs(17.55392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.30859 - lat) + Math.Abs(15.80658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.91762 - lat) + Math.Abs(15.55011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.6294 - lat) + Math.Abs(15.5132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.36267 - lat) + Math.Abs(17.36597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.9257 - lat) + Math.Abs(19.10428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.80617 - lat) + Math.Abs(15.8669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.65 - lat) + Math.Abs(16.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.48473 - lat) + Math.Abs(16.71076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.28056 - lat) + Math.Abs(15.37222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46706 - lat) + Math.Abs(14.71363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.37813 - lat) + Math.Abs(17.05876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.9801 - lat) + Math.Abs(18.2138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3202 - lat) + Math.Abs(16.1552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.98327 - lat) + Math.Abs(16.31991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.6698 - lat) + Math.Abs(15.3813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.26681 - lat) + Math.Abs(16.93898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.6761 - lat) + Math.Abs(16.566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.35494 - lat) + Math.Abs(17.00121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.2154 - lat) + Math.Abs(18.3353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.8375 - lat) + Math.Abs(17.4275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.06589 - lat) + Math.Abs(22.84308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.17869 - lat) + Math.Abs(14.17869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Iriba", "02", 15.11667, 22.25);
case 1: return new CityInfo("Goz Béïda", "12", 13.94563, 20.5468);
case 2: return new CityInfo("Goz Beïda", "25", 12.22484, 21.41034);
case 3: return new CityInfo("Fada", "28", 17.18535, 21.58114);
case 4: return new CityInfo("Biltine", "02", 14.52791, 20.92749);
case 5: return new CityInfo("Am Timan", "13", 11.0297, 20.2827);
case 6: return new CityInfo("Adré", "12", 13.46648, 22.19875);
case 7: return new CityInfo("Abéché", "12", 13.82916, 20.8324);
case 8: return new CityInfo("Sarh", "17", 9.1429, 18.3923);
case 9: return new CityInfo("Pala", "20", 9.3642, 14.9046);
case 10: return new CityInfo("Oum Hadjer", "01", 13.2954, 19.6966);
case 11: return new CityInfo("Ngama", "15", 11.78333, 17.16667);
case 12: return new CityInfo("N'Djamena", "21", 12.10672, 15.0444);
case 13: return new CityInfo("Moussoro", "22", 13.64143, 16.48941);
case 14: return new CityInfo("Moundou", "08", 8.56667, 16.08333);
case 15: return new CityInfo("Mongo", "05", 12.18441, 18.69303);
case 16: return new CityInfo("Moïssala", "19", 8.3404, 17.7663);
case 17: return new CityInfo("Melfi", "05", 11.0598, 17.9355);
case 18: return new CityInfo("Mboursou Léré", "20", 9.7639, 14.1539);
case 19: return new CityInfo("Massenya", "15", 11.4039, 16.1705);
case 20: return new CityInfo("Massakory", "18", 12.996, 15.72927);
case 21: return new CityInfo("Massaguet", "18", 12.47554, 15.43647);
case 22: return new CityInfo("Mao", "06", 14.12116, 15.3103);
case 23: return new CityInfo("Laï", "14", 9.3972, 16.30066);
case 24: return new CityInfo("Kyabé", "17", 9.45149, 18.94493);
case 25: return new CityInfo("Koumra", "19", 8.91256, 17.55392);
case 26: return new CityInfo("Kelo", "14", 9.30859, 15.80658);
case 27: return new CityInfo("Guelendeng", "16", 10.91762, 15.55011);
case 28: return new CityInfo("Gounou Gaya", "16", 9.6294, 15.5132);
case 29: return new CityInfo("Goundi", "19", 9.36267, 17.36597);
case 30: return new CityInfo("Faya-Largeau", "23", 17.9257, 19.10428);
case 31: return new CityInfo("Dourbali", "15", 11.80617, 15.8669);
case 32: return new CityInfo("Doba", "09", 8.65, 16.85);
case 33: return new CityInfo("Bousso", "15", 10.48473, 16.71076);
case 34: return new CityInfo("Bongor", "16", 10.28056, 15.37222);
case 35: return new CityInfo("Bol", "07", 13.46706, 14.71363);
case 36: return new CityInfo("Bokoro", "18", 12.37813, 17.05876);
case 37: return new CityInfo("Bitkine", "05", 11.9801, 18.2138);
case 38: return new CityInfo("Béré", "14", 9.3202, 16.1552);
case 39: return new CityInfo("Benoy", "08", 8.98327, 16.31991);
case 40: return new CityInfo("Beïnamar", "08", 8.6698, 15.3813);
case 41: return new CityInfo("Béboto", "09", 8.26681, 16.93898);
case 42: return new CityInfo("Bébédja", "09", 8.6761, 16.566);
case 43: return new CityInfo("Bardaï", "26", 21.35494, 17.00121);
case 44: return new CityInfo("Ati", "01", 13.2154, 18.3353);
case 45: return new CityInfo("Aozou", "26", 21.8375, 17.4275);
case 46: return new CityInfo("Am Djarass", "27", 16.06589, 22.84308);
default: return new CityInfo("Vadanakallu", "07", 14.17869, 14.17869);

                                    }                                        
                                }
                            
                        }
                    }
                