
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
                                    public const string Country = "BJ";
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
                            
                                        var cur = (Math.Abs(7.22097 - lat) + Math.Abs(2.38335 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(8.88649 - lat) + Math.Abs(2.59753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.62118 - lat) + Math.Abs(1.26651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.49245 - lat) + Math.Abs(2.40193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.36667 - lat) + Math.Abs(2.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.7539 - lat) + Math.Abs(2.10365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.03424 - lat) + Math.Abs(2.4866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.92807 - lat) + Math.Abs(1.97558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.73618 - lat) + Math.Abs(2.65866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.49646 - lat) + Math.Abs(2.60359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.98008 - lat) + Math.Abs(2.6649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.33716 - lat) + Math.Abs(2.63031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.38774 - lat) + Math.Abs(2.21423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.08411 - lat) + Math.Abs(2.48343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.36307 - lat) + Math.Abs(2.08506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.94009 - lat) + Math.Abs(3.21075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.30416 - lat) + Math.Abs(1.37962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.86819 - lat) + Math.Abs(3.38327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.63869 - lat) + Math.Abs(1.71674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.36332 - lat) + Math.Abs(2.59978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.13417 - lat) + Math.Abs(2.93861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.76667 - lat) + Math.Abs(2.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.41667 - lat) + Math.Abs(2.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.56583 - lat) + Math.Abs(1.72444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.28036 - lat) + Math.Abs(1.82251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.18131 - lat) + Math.Abs(2.29295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.79911 - lat) + Math.Abs(1.78073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.70853 - lat) + Math.Abs(1.66598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.75 - lat) + Math.Abs(2.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.22097 - lat) + Math.Abs(2.34017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.36536 - lat) + Math.Abs(2.41833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.40764 - lat) + Math.Abs(1.88198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.17826 - lat) + Math.Abs(2.0667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.19916 - lat) + Math.Abs(2.25855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.22827 - lat) + Math.Abs(2.66335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.00814 - lat) + Math.Abs(1.6654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.29845 - lat) + Math.Abs(2.43856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.64756 - lat) + Math.Abs(2.70695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.66239 - lat) + Math.Abs(2.04249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.93333 - lat) + Math.Abs(1.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.32454 - lat) + Math.Abs(3.05886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.66547 - lat) + Math.Abs(2.15138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.71853 - lat) + Math.Abs(2.47759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.44852 - lat) + Math.Abs(2.35566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.18286 - lat) + Math.Abs(1.99119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.8862 - lat) + Math.Abs(2.4806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.46216 - lat) + Math.Abs(1.99362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zagnanado", "18", 7.22097, 2.38335);
case 1: return new CityInfo("Tchaourou", "10", 8.88649, 2.59753);
case 2: return new CityInfo("Tanguiéta", "08", 10.62118, 1.26651);
case 3: return new CityInfo("So-Ava", "09", 6.49245, 2.40193);
case 4: return new CityInfo("Semi", "16", 6.36667, 2.61667);
case 5: return new CityInfo("Sé", "09", 6.7539, 2.10365);
case 6: return new CityInfo("Savé", "11", 8.03424, 2.4866);
case 7: return new CityInfo("Savalou", "11", 7.92807, 1.97558);
case 8: return new CityInfo("Sakété", "17", 6.73618, 2.65866);
case 9: return new CityInfo("Porto-Novo", "16", 6.49646, 2.60359);
case 10: return new CityInfo("Pobé", "17", 6.98008, 2.6649);
case 11: return new CityInfo("Parakou", "10", 9.33716, 2.63031);
case 12: return new CityInfo("Pahou", "09", 6.38774, 2.21423);
case 13: return new CityInfo("Ouinhi", "18", 7.08411, 2.48343);
case 14: return new CityInfo("Ouidah", "09", 6.36307, 2.08506);
case 15: return new CityInfo("Nikki", "10", 9.94009, 3.21075);
case 16: return new CityInfo("Natitingou", "08", 10.30416, 1.37962);
case 17: return new CityInfo("Malanville", "07", 11.86819, 3.38327);
case 18: return new CityInfo("Lokossa", "15", 6.63869, 1.71674);
case 19: return new CityInfo("Kétou", "17", 7.36332, 2.59978);
case 20: return new CityInfo("Kandi", "07", 11.13417, 2.93861);
case 21: return new CityInfo("Hinvi", "09", 6.76667, 2.16667);
case 22: return new CityInfo("Hévié", "09", 6.41667, 2.25);
case 23: return new CityInfo("Guilmaro", "08", 10.56583, 1.72444);
case 24: return new CityInfo("Grand-Popo", "15", 6.28036, 1.82251);
case 25: return new CityInfo("Goumori", "07", 11.18131, 2.29295);
case 26: return new CityInfo("Dogbo", "12", 6.79911, 1.78073);
case 27: return new CityInfo("Djougou", "13", 9.70853, 1.66598);
case 28: return new CityInfo("Dassa-Zoumé", "11", 7.75, 2.18333);
case 29: return new CityInfo("Cové", "18", 7.22097, 2.34017);
case 30: return new CityInfo("Cotonou", "14", 6.36536, 2.41833);
case 31: return new CityInfo("Comé", "11", 6.40764, 1.88198);
case 32: return new CityInfo("Bohicon", "18", 7.17826, 2.0667);
case 33: return new CityInfo("Bétérou", "10", 9.19916, 2.25855);
case 34: return new CityInfo("Bembèrèkè", "10", 10.22827, 2.66335);
case 35: return new CityInfo("Bassila", "13", 9.00814, 1.6654);
case 36: return new CityInfo("Banikoara", "07", 11.29845, 2.43856);
case 37: return new CityInfo("Banigbé", "17", 6.64756, 2.70695);
case 38: return new CityInfo("Avakpa", "09", 6.66239, 2.04249);
case 39: return new CityInfo("Aplahoué", "12", 6.93333, 1.68333);
case 40: return new CityInfo("Angara-Débou", "07", 11.32454, 3.05886);
case 41: return new CityInfo("Allada", "09", 6.66547, 2.15138);
case 42: return new CityInfo("Adjohon", "16", 6.71853, 2.47759);
case 43: return new CityInfo("Abomey-Calavi", "09", 6.44852, 2.35566);
case 44: return new CityInfo("Abomey", "18", 7.18286, 1.99119);
case 45: return new CityInfo("Houinvigue", "16", 6.8862, 2.4806);
default: return new CityInfo("Kpomassè", "09", 6.46216, 1.99362);

                                    }                                        
                                }
                            
                        }
                    }
                