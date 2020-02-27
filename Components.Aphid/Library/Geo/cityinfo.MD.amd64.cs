
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
                                    public const string Country = "MD";
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
                            
                                        var cur = (Math.Abs(46.82874 - lat) + Math.Abs(29.52174 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(48.17215 - lat) + Math.Abs(27.30337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4252 - lat) + Math.Abs(28.42676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68492 - lat) + Math.Abs(28.40613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3326 - lat) + Math.Abs(28.44797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86606 - lat) + Math.Abs(29.46636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09009 - lat) + Math.Abs(29.0757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25524 - lat) + Math.Abs(29.12406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21079 - lat) + Math.Abs(27.80047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14826 - lat) + Math.Abs(28.96491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84274 - lat) + Math.Abs(29.62909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5011 - lat) + Math.Abs(28.36536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90273 - lat) + Math.Abs(28.66816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91557 - lat) + Math.Abs(28.96673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51287 - lat) + Math.Abs(29.66193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14216 - lat) + Math.Abs(28.60774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09643 - lat) + Math.Abs(28.86791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.6558 - lat) + Math.Abs(28.04734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15659 - lat) + Math.Abs(28.28489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81608 - lat) + Math.Abs(28.79718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.72927 - lat) + Math.Abs(29.70446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69107 - lat) + Math.Abs(28.97458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.94792 - lat) + Math.Abs(27.56376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.76817 - lat) + Math.Abs(29.01 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.74928 - lat) + Math.Abs(28.96583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.73253 - lat) + Math.Abs(29.9617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38494 - lat) + Math.Abs(28.82446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.38274 - lat) + Math.Abs(27.43805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.13278 - lat) + Math.Abs(28.63558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87839 - lat) + Math.Abs(29.23483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08159 - lat) + Math.Abs(28.17138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50525 - lat) + Math.Abs(28.27687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23727 - lat) + Math.Abs(29.38498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.86897 - lat) + Math.Abs(28.24109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4823 - lat) + Math.Abs(28.25301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63632 - lat) + Math.Abs(28.14296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13835 - lat) + Math.Abs(28.86156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.64844 - lat) + Math.Abs(29.80403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83047 - lat) + Math.Abs(28.59064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3017 - lat) + Math.Abs(29.11755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.78296 - lat) + Math.Abs(29.61682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.63674 - lat) + Math.Abs(29.41114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94346 - lat) + Math.Abs(28.78233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15413 - lat) + Math.Abs(29.30008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.77513 - lat) + Math.Abs(27.51891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.85482 - lat) + Math.Abs(28.37679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.89137 - lat) + Math.Abs(28.29312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57667 - lat) + Math.Abs(27.71264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48167 - lat) + Math.Abs(28.19722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26562 - lat) + Math.Abs(29.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03555 - lat) + Math.Abs(27.81293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.24268 - lat) + Math.Abs(27.6101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6164 - lat) + Math.Abs(29.91926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75818 - lat) + Math.Abs(28.20716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21307 - lat) + Math.Abs(29.15926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29456 - lat) + Math.Abs(28.6565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52685 - lat) + Math.Abs(28.76441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.00556 - lat) + Math.Abs(28.8575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.06169 - lat) + Math.Abs(28.83078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27743 - lat) + Math.Abs(28.2027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03233 - lat) + Math.Abs(28.69899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2556 - lat) + Math.Abs(28.30987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90425 - lat) + Math.Abs(28.19929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19064 - lat) + Math.Abs(28.45802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36554 - lat) + Math.Abs(28.6625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.36289 - lat) + Math.Abs(27.07787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.35628 - lat) + Math.Abs(27.70293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83156 - lat) + Math.Abs(29.47769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3317 - lat) + Math.Abs(28.96365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.76314 - lat) + Math.Abs(27.92932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43285 - lat) + Math.Abs(27.79912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0746 - lat) + Math.Abs(28.73685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13 - lat) + Math.Abs(28.88937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81353 - lat) + Math.Abs(28.07004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Tiraspolul Nou", "58", 46.82874, 29.52174);
case 1: return new CityInfo("Edineţ", "73", 48.17215, 27.30337);
case 2: return new CityInfo("Iargara", "65", 46.4252, 28.42676);
case 3: return new CityInfo("Vulcăneşti", "51", 45.68492, 28.40613);
case 4: return new CityInfo("Vişniovca", "65", 46.3326, 28.44797);
case 5: return new CityInfo("Varniţa", "59", 46.86606, 29.46636);
case 6: return new CityInfo("Vadul lui Vodă", "57", 47.09009, 29.0757);
case 7: return new CityInfo("Ustia", "72", 47.25524, 29.12406);
case 8: return new CityInfo("Ungheni", "92", 47.21079, 27.80047);
case 9: return new CityInfo("Tvardița", "90", 46.14826, 28.96491);
case 10: return new CityInfo("Tiraspol", "58", 46.84274, 29.62909);
case 11: return new CityInfo("Teleneşti", "91", 47.5011, 28.36536);
case 12: return new CityInfo("Taraclia", "90", 45.90273, 28.66816);
case 13: return new CityInfo("Sîngera", "57", 46.91557, 28.96673);
case 14: return new CityInfo("Ştefan Vodă", "88", 46.51287, 29.66193);
case 15: return new CityInfo("Strășeni", "89", 47.14216, 28.60774);
case 16: return new CityInfo("Stăuceni", "57", 47.09643, 28.86791);
case 17: return new CityInfo("Bilicenii Vechi", "85", 47.6558, 28.04734);
case 18: return new CityInfo("Soroca", "87", 48.15659, 28.28489);
case 19: return new CityInfo("Şoldăneşti", "86", 47.81608, 28.79718);
case 20: return new CityInfo("Slobozia", "58", 46.72927, 29.70446);
case 21: return new CityInfo("Saharna", "83", 47.69107, 28.97458);
case 22: return new CityInfo("Rîşcani", "84", 47.94792, 27.56376);
case 23: return new CityInfo("Rîbniţa", "58", 47.76817, 29.01);
case 24: return new CityInfo("Rezina", "83", 47.74928, 28.96583);
case 25: return new CityInfo("Pervomaisc", "58", 46.73253, 29.9617);
case 26: return new CityInfo("Orhei", "82", 47.38494, 28.82446);
case 27: return new CityInfo("Ocniţa", "81", 48.38274, 27.43805);
case 28: return new CityInfo("Ocniţa", "58", 48.13278, 28.63558);
case 29: return new CityInfo("Anenii Noi", "59", 46.87839, 29.23483);
case 30: return new CityInfo("Nisporeni", "80", 47.08159, 28.17138);
case 31: return new CityInfo("Mîndreşti", "91", 47.50525, 28.27687);
case 32: return new CityInfo("Maiac", "58", 47.23727, 29.38498);
case 33: return new CityInfo("Mărculeşti", "75", 47.86897, 28.24109);
case 34: return new CityInfo("Leova", "79", 46.4823, 28.25301);
case 35: return new CityInfo("Sîngerei", "85", 47.63632, 28.14296);
case 36: return new CityInfo("Cricova", "57", 47.13835, 28.86156);
case 37: return new CityInfo("Crasnoe", "58", 46.64844, 29.80403);
case 38: return new CityInfo("Hînceşti", "77", 46.83047, 28.59064);
case 39: return new CityInfo("Cocieri", "72", 47.3017, 29.11755);
case 40: return new CityInfo("Chiţcani", "67", 46.78296, 29.61682);
case 41: return new CityInfo("Căuşeni", "67", 46.63674, 29.41114);
case 42: return new CityInfo("Ialoveni", "78", 46.94346, 28.78233);
case 43: return new CityInfo("Hryhoriopol", "58", 47.15413, 29.30008);
case 44: return new CityInfo("Glodeni", "76", 47.77513, 27.51891);
case 45: return new CityInfo("Ghindești", "75", 47.85482, 28.37679);
case 46: return new CityInfo("Floreşti", "75", 47.89137, 28.29312);
case 47: return new CityInfo("Fălești", "74", 47.57667, 27.71264);
case 48: return new CityInfo("Giurgiuleşti", "64", 45.48167, 28.19722);
case 49: return new CityInfo("Dubăsari", "58", 47.26562, 29.16667);
case 50: return new CityInfo("Drochia", "71", 48.03555, 27.81293);
case 51: return new CityInfo("Donduşeni", "70", 48.24268, 27.6101);
case 52: return new CityInfo("Dnestrovsc", "58", 46.6164, 29.91926);
case 53: return new CityInfo("Dancu", "77", 46.75818, 28.20716);
case 54: return new CityInfo("Criuleni", "69", 47.21307, 29.15926);
case 55: return new CityInfo("Comrat", "51", 46.29456, 28.6565);
case 56: return new CityInfo("Cimişlia", "68", 46.52685, 28.76441);
case 57: return new CityInfo("Chisinau", "57", 47.00556, 28.8575);
case 58: return new CityInfo("Ceadîr-Lunga", "51", 46.06169, 28.83078);
case 59: return new CityInfo("Cantemir", "65", 46.27743, 28.2027);
case 60: return new CityInfo("Camenca", "58", 48.03233, 28.69899);
case 61: return new CityInfo("Călăraşi", "66", 47.2556, 28.30987);
case 62: return new CityInfo("Cahul", "64", 45.90425, 28.19929);
case 63: return new CityInfo("Bucovăţ", "89", 47.19064, 28.45802);
case 64: return new CityInfo("Bugeac", "51", 46.36554, 28.6625);
case 65: return new CityInfo("Briceni", "63", 48.36289, 27.07787);
case 66: return new CityInfo("Briceni", "70", 48.35628, 27.70293);
case 67: return new CityInfo("Bender", "62", 46.83156, 29.47769);
case 68: return new CityInfo("Basarabeasca", "61", 46.3317, 28.96365);
case 69: return new CityInfo("Bălţi", "60", 47.76314, 27.92932);
case 70: return new CityInfo("Otaci", "81", 48.43285, 27.79912);
case 71: return new CityInfo("Vatra", "57", 47.0746, 28.73685);
case 72: return new CityInfo("Ciorescu", "57", 47.13, 28.88937);
default: return new CityInfo("Biruinţa", "85", 47.81353, 28.07004);

                                    }                                        
                                }
                            
                        }
                    }
                