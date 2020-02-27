
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
                                    public const string Country = "MH";
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
                            
                                        var cur = (Math.Abs(9.82511 - lat) + Math.Abs(169.31065 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(5.92098 - lat) + Math.Abs(169.64335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.21972 - lat) + Math.Abs(169.97967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.08971 - lat) + Math.Abs(171.38027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.70576 - lat) + Math.Abs(171.2275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.77479 - lat) + Math.Abs(167.73919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.34735 - lat) + Math.Abs(162.33733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.58199 - lat) + Math.Abs(168.69636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.1499 - lat) + Math.Abs(171.16869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.06691 - lat) + Math.Abs(171.55413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.27717 - lat) + Math.Abs(168.8203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.0815 - lat) + Math.Abs(171.73502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.92217 - lat) + Math.Abs(166.26344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.22778 - lat) + Math.Abs(169.84739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.93218 - lat) + Math.Abs(165.76416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.16351 - lat) + Math.Abs(166.89408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.76007 - lat) + Math.Abs(168.23072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.59944 - lat) + Math.Abs(168.10282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.27531 - lat) + Math.Abs(170.86461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.31221 - lat) + Math.Abs(167.37662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.64387 - lat) + Math.Abs(169.12109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.75003 - lat) + Math.Abs(168.97513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.45429 - lat) + Math.Abs(170.23674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.16575 - lat) + Math.Abs(166.01022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.08931 - lat) + Math.Abs(171.3805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Likiep", "180", 9.82511, 169.31065);
case 1: return new CityInfo("Jabor", "120", 5.92098, 169.64335);
case 2: return new CityInfo("Ailuk", "030", 10.21972, 169.97967);
case 3: return new CityInfo("Majuro", "190", 7.08971, 171.38027);
case 4: return new CityInfo("Taroa", "300", 8.70576, 171.2275);
case 5: return new CityInfo("Ebaye", "150", 8.77479, 167.73919);
case 6: return new CityInfo("Enewetak", "090", 11.34735, 162.33733);
case 7: return new CityInfo("Ebon", "080", 4.58199, 168.69636);
case 8: return new CityInfo("Aur", "050", 8.1499, 171.16869);
case 9: return new CityInfo("Arno", "040", 7.06691, 171.55413);
case 10: return new CityInfo("Airuk", "010", 7.27717, 168.8203);
case 11: return new CityInfo("Mili", "320", 6.0815, 171.73502);
case 12: return new CityInfo("Lae", "160", 8.92217, 166.26344);
case 13: return new CityInfo("Utrik", "410", 11.22778, 169.84739);
case 14: return new CityInfo("Ujae", "390", 8.93218, 165.76416);
case 15: return new CityInfo("Rongelap", "350", 11.16351, 166.89408);
case 16: return new CityInfo("Loen", "340", 7.76007, 168.23072);
case 17: return new CityInfo("Namdrik", "330", 5.59944, 168.10282);
case 18: return new CityInfo("Mejit", "310", 10.27531, 170.86461);
case 19: return new CityInfo("Lib", "170", 8.31221, 167.37662);
case 20: return new CityInfo("Kili", "140", 5.64387, 169.12109);
case 21: return new CityInfo("Jabat", "110", 7.75003, 168.97513);
case 22: return new CityInfo("Wotje", "430", 9.45429, 170.23674);
case 23: return new CityInfo("Wotho", "420", 10.16575, 166.01022);
default: return new CityInfo("RMI Capitol", "190", 7.08931, 171.3805);

                                    }                                        
                                }
                            
                        }
                    }
                