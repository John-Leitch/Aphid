
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
                                    public const string Country = "CA";
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
                            
                                        var cur = (Math.Abs(51.64982 - lat) + Math.Abs(-121.28594 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(49.05798 - lat) + Math.Abs(-122.25257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65007 - lat) + Math.Abs(-72.56582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.05007 - lat) + Math.Abs(-71.08235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.23298 - lat) + Math.Abs(-121.76926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.30011 - lat) + Math.Abs(-114.03528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.85012 - lat) + Math.Abs(-79.03288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.21913 - lat) + Math.Abs(-135.01071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.88324 - lat) + Math.Abs(-72.44867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81685 - lat) + Math.Abs(-64.06542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.63343 - lat) + Math.Abs(-65.06544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.15011 - lat) + Math.Abs(-79.86635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.55009 - lat) + Math.Abs(-71.6491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.10469 - lat) + Math.Abs(-97.55961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83345 - lat) + Math.Abs(-64.19874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.10009 - lat) + Math.Abs(-83.09985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.70011 - lat) + Math.Abs(-79.39963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.56688 - lat) + Math.Abs(-78.11624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35008 - lat) + Math.Abs(-72.93244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.31681 - lat) + Math.Abs(-79.88295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.31637 - lat) + Math.Abs(-122.85263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.4815 - lat) + Math.Abs(-79.81722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61685 - lat) + Math.Abs(-61.99858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.24966 - lat) + Math.Abs(-123.16934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(73.03752 - lat) + Math.Abs(-85.15057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.44979 - lat) + Math.Abs(-119.20235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.43341 - lat) + Math.Abs(-76.34939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76678 - lat) + Math.Abs(-71.9324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.72372 - lat) + Math.Abs(-121.28207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.63336 - lat) + Math.Abs(-105.98446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.71687 - lat) + Math.Abs(-113.28537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.63341 - lat) + Math.Abs(-75.94936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.75667 - lat) + Math.Abs(-91.62409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.92774 - lat) + Math.Abs(-82.41669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.00011 - lat) + Math.Abs(-79.46632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.76679 - lat) + Math.Abs(-80.98302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55008 - lat) + Math.Abs(-81.09975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.21679 - lat) + Math.Abs(-68.14894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41397 - lat) + Math.Abs(-73.91586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.03342 - lat) + Math.Abs(-79.2996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05752 - lat) + Math.Abs(-77.85702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.17622 - lat) + Math.Abs(-115.56982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43349 - lat) + Math.Abs(-77.63279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.13345 - lat) + Math.Abs(-114.40211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.40011 - lat) + Math.Abs(-79.66634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.18308 - lat) + Math.Abs(-120.1192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.78342 - lat) + Math.Abs(-112.46854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.18342 - lat) + Math.Abs(-76.78273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.59989 - lat) + Math.Abs(-53.26478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.22781 - lat) + Math.Abs(-58.84162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.43341 - lat) + Math.Abs(-73.86586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31341 - lat) + Math.Abs(-73.8725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.35013 - lat) + Math.Abs(-113.41871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.0622 - lat) + Math.Abs(-96.51669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.21664 - lat) + Math.Abs(-119.43605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34106 - lat) + Math.Abs(-72.43224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.11678 - lat) + Math.Abs(-72.98244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.08341 - lat) + Math.Abs(-62.88197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.16682 - lat) + Math.Abs(-77.38277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31588 - lat) + Math.Abs(-75.83012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.88339 - lat) + Math.Abs(-81.08303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.56839 - lat) + Math.Abs(-73.20568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.08336 - lat) + Math.Abs(-73.18245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05015 - lat) + Math.Abs(-64.73208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0668 - lat) + Math.Abs(-108.00135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.12135 - lat) + Math.Abs(-79.81104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.70011 - lat) + Math.Abs(-114.2353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.38342 - lat) + Math.Abs(-113.7853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.10012 - lat) + Math.Abs(-78.81626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66678 - lat) + Math.Abs(-73.88249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4832 - lat) + Math.Abs(-53.5648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.3832 - lat) + Math.Abs(-53.8981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.46679 - lat) + Math.Abs(-81.59977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61678 - lat) + Math.Abs(-73.83249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66678 - lat) + Math.Abs(-73.74918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.23062 - lat) + Math.Abs(-100.05586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.83345 - lat) + Math.Abs(-113.41872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.64989 - lat) + Math.Abs(-53.11474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.26684 - lat) + Math.Abs(-110.73505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.63339 - lat) + Math.Abs(-81.86648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.14994 - lat) + Math.Abs(-55.34819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.59104 - lat) + Math.Abs(-73.43605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46844 - lat) + Math.Abs(-64.73905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.4334 - lat) + Math.Abs(-75.1493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.66569 - lat) + Math.Abs(-63.95055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.3847 - lat) + Math.Abs(-123.33622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.86676 - lat) + Math.Abs(-111.36843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.03341 - lat) + Math.Abs(-79.31633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.68341 - lat) + Math.Abs(-79.76633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.84692 - lat) + Math.Abs(-99.95306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.1334 - lat) + Math.Abs(-80.34967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.1334 - lat) + Math.Abs(-80.26636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.37856 - lat) + Math.Abs(-64.51882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.59132 - lat) + Math.Abs(-75.68705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31678 - lat) + Math.Abs(-72.64912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.58341 - lat) + Math.Abs(-111.88509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45008 - lat) + Math.Abs(-73.46583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68342 - lat) + Math.Abs(-74.4159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.73339 - lat) + Math.Abs(-81.24975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.10292 - lat) + Math.Abs(-80.42869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.61668 - lat) + Math.Abs(-57.61516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.38621 - lat) + Math.Abs(-79.83713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.26636 - lat) + Math.Abs(-122.95263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.22972 - lat) + Math.Abs(-125.76084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36679 - lat) + Math.Abs(-79.98297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.81011 - lat) + Math.Abs(-121.3246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.15012 - lat) + Math.Abs(-78.83286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.05011 - lat) + Math.Abs(-114.08529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.26683 - lat) + Math.Abs(-113.81874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65148 - lat) + Math.Abs(-74.63536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.3601 - lat) + Math.Abs(-80.31269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.03596 - lat) + Math.Abs(-82.1616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.01634 - lat) + Math.Abs(-125.24459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98832 - lat) + Math.Abs(-100.14365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.01684 - lat) + Math.Abs(-112.83525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38338 - lat) + Math.Abs(-73.51587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.08335 - lat) + Math.Abs(-115.35206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.63328 - lat) + Math.Abs(-102.43425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.5668 - lat) + Math.Abs(-75.78265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.09736 - lat) + Math.Abs(-66.68514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70626 - lat) + Math.Abs(-80.92109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.86893 - lat) + Math.Abs(-99.36021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.73319 - lat) + Math.Abs(-53.21478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.19998 - lat) + Math.Abs(-113.3019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45008 - lat) + Math.Abs(-73.29916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13341 - lat) + Math.Abs(-76.14938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.63334 - lat) + Math.Abs(-102.26765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.4992 - lat) + Math.Abs(-98.00156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.16674 - lat) + Math.Abs(-101.80088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.45006 - lat) + Math.Abs(-105.81787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.28337 - lat) + Math.Abs(-103.58423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.56681 - lat) + Math.Abs(-114.102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3168 - lat) + Math.Abs(-75.0826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.04963 - lat) + Math.Abs(-123.886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.32317 - lat) + Math.Abs(-117.65831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.51659 - lat) + Math.Abs(-53.08135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.11633 - lat) + Math.Abs(-123.8527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45008 - lat) + Math.Abs(-73.28246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43339 - lat) + Math.Abs(-72.06583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57286 - lat) + Math.Abs(-59.13808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78344 - lat) + Math.Abs(-74.84919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71678 - lat) + Math.Abs(-73.48247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23459 - lat) + Math.Abs(-63.1256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8165 - lat) + Math.Abs(-119.68571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38338 - lat) + Math.Abs(-73.74919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.41224 - lat) + Math.Abs(-82.18494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.91633 - lat) + Math.Abs(-123.71937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.07109 - lat) + Math.Abs(-73.89095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.54225 - lat) + Math.Abs(-64.23891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.03341 - lat) + Math.Abs(-113.81867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.69988 - lat) + Math.Abs(-121.63627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.91684 - lat) + Math.Abs(-74.36586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.16638 - lat) + Math.Abs(-121.95257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.11679 - lat) + Math.Abs(-68.39896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.5501 - lat) + Math.Abs(-75.29101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1805 - lat) + Math.Abs(-53.96982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.03332 - lat) + Math.Abs(-113.58524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.08309 - lat) + Math.Abs(-121.58597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(70.47233 - lat) + Math.Abs(-68.58987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.7167 - lat) + Math.Abs(-112.61854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.7464 - lat) + Math.Abs(-112.93246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13339 - lat) + Math.Abs(-71.79907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.95977 - lat) + Math.Abs(-78.16515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.18341 - lat) + Math.Abs(-114.46871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.46525 - lat) + Math.Abs(-110.18154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.4834 - lat) + Math.Abs(-80.21638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.43293 - lat) + Math.Abs(-123.48591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49989 - lat) + Math.Abs(-52.99806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.80011 - lat) + Math.Abs(-79.48291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50011 - lat) + Math.Abs(-76.08267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85008 - lat) + Math.Abs(-73.23245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41536 - lat) + Math.Abs(-71.62962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41675 - lat) + Math.Abs(-71.6324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.18341 - lat) + Math.Abs(-79.69964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.29963 - lat) + Math.Abs(-124.41946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.2846 - lat) + Math.Abs(-122.78217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.95001 - lat) + Math.Abs(-57.95202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22652 - lat) + Math.Abs(-63.21809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.01809 - lat) + Math.Abs(-74.72815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.88338 - lat) + Math.Abs(-82.43313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30008 - lat) + Math.Abs(-74.18253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46536 - lat) + Math.Abs(-73.66585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.68657 - lat) + Math.Abs(-124.9936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20008 - lat) + Math.Abs(-72.74913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.63141 - lat) + Math.Abs(-63.43218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96677 - lat) + Math.Abs(-73.46586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.58623 - lat) + Math.Abs(-101.37797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.49991 - lat) + Math.Abs(-115.76879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.09987 - lat) + Math.Abs(-116.50211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.43341 - lat) + Math.Abs(-114.03528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.61634 - lat) + Math.Abs(-125.03613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.33339 - lat) + Math.Abs(-106.76792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78337 - lat) + Math.Abs(-72.0158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.67134 - lat) + Math.Abs(-63.57719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.36633 - lat) + Math.Abs(-124.51947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.14941 - lat) + Math.Abs(-100.05023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20006 - lat) + Math.Abs(-72.13239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.26676 - lat) + Math.Abs(-105.98449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.75984 - lat) + Math.Abs(-120.2403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.10012 - lat) + Math.Abs(-77.49949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.16671 - lat) + Math.Abs(-57.43163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.91679 - lat) + Math.Abs(-81.41646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.19082 - lat) + Math.Abs(-100.49477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36678 - lat) + Math.Abs(-73.54917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.14399 - lat) + Math.Abs(-122.9068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53294 - lat) + Math.Abs(-124.8195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.20012 - lat) + Math.Abs(-77.04944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53455 - lat) + Math.Abs(-73.90168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.36683 - lat) + Math.Abs(-113.73533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.66681 - lat) + Math.Abs(-114.13529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.07844 - lat) + Math.Abs(-64.68735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.62188 - lat) + Math.Abs(-65.7586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90007 - lat) + Math.Abs(-71.34907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.8786 - lat) + Math.Abs(-72.23142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.49452 - lat) + Math.Abs(-73.82419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.98339 - lat) + Math.Abs(-81.06643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.4473 - lat) + Math.Abs(-73.75335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.59111 - lat) + Math.Abs(-81.33917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21682 - lat) + Math.Abs(-114.98544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88336 - lat) + Math.Abs(-72.48241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78334 - lat) + Math.Abs(-92.75032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.78293 - lat) + Math.Abs(-123.70266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13338 - lat) + Math.Abs(-72.79913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.63955 - lat) + Math.Abs(-93.23526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48338 - lat) + Math.Abs(-71.66577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.10087 - lat) + Math.Abs(-79.43785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.17385 - lat) + Math.Abs(-124.01745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.55014 - lat) + Math.Abs(-113.46871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.58345 - lat) + Math.Abs(-116.43559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.05007 - lat) + Math.Abs(-114.8854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.90017 - lat) + Math.Abs(-110.9017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38336 - lat) + Math.Abs(-82.63315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.93307 - lat) + Math.Abs(-119.36907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.5834 - lat) + Math.Abs(-79.86636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.5498 - lat) + Math.Abs(-119.15234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81686 - lat) + Math.Abs(-79.8664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.73345 - lat) + Math.Abs(-63.78201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25837 - lat) + Math.Abs(-81.76649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.17509 - lat) + Math.Abs(-82.82483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.65001 - lat) + Math.Abs(-102.08426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.13337 - lat) + Math.Abs(-102.98422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.1501 - lat) + Math.Abs(-108.75144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.65421 - lat) + Math.Abs(-79.56711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.06675 - lat) + Math.Abs(-118.38606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.73339 - lat) + Math.Abs(-117.20262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.49979 - lat) + Math.Abs(-119.55239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.81685 - lat) + Math.Abs(-63.6154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28338 - lat) + Math.Abs(-72.98244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70011 - lat) + Math.Abs(-75.44929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.78345 - lat) + Math.Abs(-67.08204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.49996 - lat) + Math.Abs(-115.06871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.76703 - lat) + Math.Abs(-101.87433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.65001 - lat) + Math.Abs(-103.53431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19998 - lat) + Math.Abs(-81.66664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85011 - lat) + Math.Abs(-76.73272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.90012 - lat) + Math.Abs(-78.93286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.61667 - lat) + Math.Abs(-93.4003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.25698 - lat) + Math.Abs(-128.6374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.23947 - lat) + Math.Abs(-123.47371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71671 - lat) + Math.Abs(-113.41857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.72676 - lat) + Math.Abs(-111.38103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.43863 - lat) + Math.Abs(-134.88543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.80533 - lat) + Math.Abs(-122.7002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.71684 - lat) + Math.Abs(-113.2187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.00439 - lat) + Math.Abs(-111.88871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.24988 - lat) + Math.Abs(-120.85292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.40007 - lat) + Math.Abs(-116.80238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.03338 - lat) + Math.Abs(-73.91591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.94541 - lat) + Math.Abs(-66.66558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.34123 - lat) + Math.Abs(-124.35541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.11654 - lat) + Math.Abs(-117.55222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.7832 - lat) + Math.Abs(-54.21482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.33342 - lat) + Math.Abs(-76.16607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.34992 - lat) + Math.Abs(-54.48141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.85342 - lat) + Math.Abs(-123.50032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.0778 - lat) + Math.Abs(-96.7073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.83341 - lat) + Math.Abs(-64.48194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47723 - lat) + Math.Abs(-75.70164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.83345 - lat) + Math.Abs(-113.33531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.39539 - lat) + Math.Abs(-123.50555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.63362 - lat) + Math.Abs(-96.99066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.62602 - lat) + Math.Abs(-95.87836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19695 - lat) + Math.Abs(-59.95698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.75009 - lat) + Math.Abs(-81.71648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.75012 - lat) + Math.Abs(-68.08213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.74171 - lat) + Math.Abs(-81.71339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.29995 - lat) + Math.Abs(-116.9689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.03342 - lat) + Math.Abs(-79.19959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45532 - lat) + Math.Abs(-52.77552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40008 - lat) + Math.Abs(-72.73243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09995 - lat) + Math.Abs(-55.76504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.88335 - lat) + Math.Abs(-119.13585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30014 - lat) + Math.Abs(-64.56546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.16667 - lat) + Math.Abs(-118.80271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.93324 - lat) + Math.Abs(-55.66492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.03309 - lat) + Math.Abs(-118.4356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.23333 - lat) + Math.Abs(-120.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.49 - lat) + Math.Abs(-80.99001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.88336 - lat) + Math.Abs(-106.55122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.91681 - lat) + Math.Abs(-79.36633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.25012 - lat) + Math.Abs(-76.94944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.15012 - lat) + Math.Abs(-79.01628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63319 - lat) + Math.Abs(-53.49809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.73343 - lat) + Math.Abs(-87.16668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.97413 - lat) + Math.Abs(-64.93169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.41674 - lat) + Math.Abs(-102.93432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.18339 - lat) + Math.Abs(-117.6027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.40668 - lat) + Math.Abs(-96.85873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.54594 - lat) + Math.Abs(-80.25599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.10007 - lat) + Math.Abs(-108.48471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.75216 - lat) + Math.Abs(-137.51082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.25011 - lat) + Math.Abs(-79.84963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48064 - lat) + Math.Abs(-73.66307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52876 - lat) + Math.Abs(-65.85354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91922 - lat) + Math.Abs(-123.04458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.63343 - lat) + Math.Abs(-111.90181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.15009 - lat) + Math.Abs(-81.03303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.06685 - lat) + Math.Abs(-64.16544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3038 - lat) + Math.Abs(-60.32576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48325 - lat) + Math.Abs(-55.79833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.8499 - lat) + Math.Abs(-54.01481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.90009 - lat) + Math.Abs(-80.88302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14834 - lat) + Math.Abs(-64.39892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.24342 - lat) + Math.Abs(-63.60264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60009 - lat) + Math.Abs(-74.61595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.81555 - lat) + Math.Abs(-115.79993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.8753 - lat) + Math.Abs(-97.40896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.68351 - lat) + Math.Abs(-83.66654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05008 - lat) + Math.Abs(-73.58248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(58.51688 - lat) + Math.Abs(-117.13605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.4334 - lat) + Math.Abs(-116.4858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.58341 - lat) + Math.Abs(-113.86867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.40009 - lat) + Math.Abs(-117.58567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.38299 - lat) + Math.Abs(-121.44144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53448 - lat) + Math.Abs(-124.66923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.21451 - lat) + Math.Abs(-84.77617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.39976 - lat) + Math.Abs(-126.67008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45008 - lat) + Math.Abs(-74.14922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85003 - lat) + Math.Abs(-102.38425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.20005 - lat) + Math.Abs(-105.1255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08339 - lat) + Math.Abs(-74.16593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.33341 - lat) + Math.Abs(-79.21632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.61679 - lat) + Math.Abs(-81.29975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.7106 - lat) + Math.Abs(-96.98893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.53336 - lat) + Math.Abs(-103.66775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.03339 - lat) + Math.Abs(-80.88302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.30011 - lat) + Math.Abs(-79.64964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(68.36166 - lat) + Math.Abs(-133.72817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.51666 - lat) + Math.Abs(-116.03538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.74697 - lat) + Math.Abs(-68.51727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.76688 - lat) + Math.Abs(-80.68307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.32372 - lat) + Math.Abs(-113.60475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.38324 - lat) + Math.Abs(-115.30204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.88341 - lat) + Math.Abs(-80.09965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.88633 - lat) + Math.Abs(-118.05625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.0164 - lat) + Math.Abs(-73.4236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.66648 - lat) + Math.Abs(-120.3192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.56668 - lat) + Math.Abs(-101.90093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3001 - lat) + Math.Abs(-75.91606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.41694 - lat) + Math.Abs(-82.43308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95011 - lat) + Math.Abs(-76.01606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.88307 - lat) + Math.Abs(-119.48568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.16669 - lat) + Math.Abs(-103.5343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.76741 - lat) + Math.Abs(-94.48985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43343 - lat) + Math.Abs(-63.64871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0771 - lat) + Math.Abs(-64.49605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91682 - lat) + Math.Abs(-109.13479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.25011 - lat) + Math.Abs(-79.46632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00011 - lat) + Math.Abs(-66.88218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.78344 - lat) + Math.Abs(-111.85175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.18332 - lat) + Math.Abs(-99.66364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.67071 - lat) + Math.Abs(-115.9776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.18339 - lat) + Math.Abs(-81.63307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.46681 - lat) + Math.Abs(-109.16818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.96514 - lat) + Math.Abs(-79.59011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85007 - lat) + Math.Abs(-72.0658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.22976 - lat) + Math.Abs(-76.48098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.10003 - lat) + Math.Abs(-102.6343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45008 - lat) + Math.Abs(-73.86586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.14461 - lat) + Math.Abs(-80.03767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.42537 - lat) + Math.Abs(-80.5112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.05244 - lat) + Math.Abs(-128.65342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(67.82743 - lat) + Math.Abs(-115.09649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28339 - lat) + Math.Abs(-74.73255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.94626 - lat) + Math.Abs(-66.91137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.30009 - lat) + Math.Abs(-69.56294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.51688 - lat) + Math.Abs(-96.50029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81698 - lat) + Math.Abs(-73.9592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21678 - lat) + Math.Abs(-72.51581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89788 - lat) + Math.Abs(-73.9723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.2536 - lat) + Math.Abs(-96.06116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65008 - lat) + Math.Abs(-74.33253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.7669 - lat) + Math.Abs(-111.96861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89837 - lat) + Math.Abs(-73.77308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58338 - lat) + Math.Abs(-70.88234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08338 - lat) + Math.Abs(-73.36585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.46681 - lat) + Math.Abs(-113.7353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15009 - lat) + Math.Abs(-74.69925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15699 - lat) + Math.Abs(-74.74129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.99016 - lat) + Math.Abs(-123.81699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.82495 - lat) + Math.Abs(-124.05461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.73345 - lat) + Math.Abs(-63.38198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.43342 - lat) + Math.Abs(-78.26623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.16678 - lat) + Math.Abs(-81.93309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25009 - lat) + Math.Abs(-74.93257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.76686 - lat) + Math.Abs(-112.80195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.67169 - lat) + Math.Abs(-96.82232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.84999 - lat) + Math.Abs(-101.71763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.44963 - lat) + Math.Abs(-123.50261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.3668 - lat) + Math.Abs(-106.96793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.10107 - lat) + Math.Abs(-122.65883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.85006 - lat) + Math.Abs(-105.03443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96677 - lat) + Math.Abs(-73.21585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.98345 - lat) + Math.Abs(-63.48199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.5668 - lat) + Math.Abs(-89.35013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41678 - lat) + Math.Abs(-73.49917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.10013 - lat) + Math.Abs(-105.28422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.80019 - lat) + Math.Abs(-79.19964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.68339 - lat) + Math.Abs(-71.6658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.94995 - lat) + Math.Abs(-55.59811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.82318 - lat) + Math.Abs(-73.4294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43337 - lat) + Math.Abs(-72.7824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13336 - lat) + Math.Abs(-72.28239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.56995 - lat) + Math.Abs(-73.692 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88338 - lat) + Math.Abs(-73.28245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.05009 - lat) + Math.Abs(-82.59981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.05018 - lat) + Math.Abs(-76.98273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.26683 - lat) + Math.Abs(-74.34914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.26682 - lat) + Math.Abs(-113.55201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85008 - lat) + Math.Abs(-73.48246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30008 - lat) + Math.Abs(-74.04922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28338 - lat) + Math.Abs(-74.23254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.69999 - lat) + Math.Abs(-112.81856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.24993 - lat) + Math.Abs(-55.04816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38338 - lat) + Math.Abs(-73.9492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3334 - lat) + Math.Abs(-75.24931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90012 - lat) + Math.Abs(-66.58218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.35012 - lat) + Math.Abs(-78.73286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00007 - lat) + Math.Abs(-70.41572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.58171 - lat) + Math.Abs(-80.72815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.45218 - lat) + Math.Abs(-123.2376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.7334 - lat) + Math.Abs(-80.94973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97927 - lat) + Math.Abs(-81.9248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43338 - lat) + Math.Abs(-81.14975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27237 - lat) + Math.Abs(-110.02256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.49976 - lat) + Math.Abs(-120.80253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.98339 - lat) + Math.Abs(-81.23304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53121 - lat) + Math.Abs(-73.51806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.73919 - lat) + Math.Abs(-96.87232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68338 - lat) + Math.Abs(-73.78249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61675 - lat) + Math.Abs(-71.93239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25594 - lat) + Math.Abs(-72.94145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.18339 - lat) + Math.Abs(-81.39976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.24979 - lat) + Math.Abs(-118.96904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.65009 - lat) + Math.Abs(-104.86783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.37847 - lat) + Math.Abs(-64.31658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13544 - lat) + Math.Abs(-64.90504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.75018 - lat) + Math.Abs(-78.99962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.33637 - lat) + Math.Abs(-123.09374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.33344 - lat) + Math.Abs(-109.93484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.50842 - lat) + Math.Abs(-77.47448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26678 - lat) + Math.Abs(-72.14909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.41668 - lat) + Math.Abs(-112.86856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.13348 - lat) + Math.Abs(-78.13283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36677 - lat) + Math.Abs(-73.34915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.12152 - lat) + Math.Abs(-85.8403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38341 - lat) + Math.Abs(-75.96605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.91683 - lat) + Math.Abs(-117.61945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33345 - lat) + Math.Abs(-111.1684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.91678 - lat) + Math.Abs(-109.48481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.50172 - lat) + Math.Abs(-113.36274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.21939 - lat) + Math.Abs(-122.60193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.7501 - lat) + Math.Abs(-86.43322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.43338 - lat) + Math.Abs(-73.16585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.3168 - lat) + Math.Abs(-80.64971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.86682 - lat) + Math.Abs(-79.2663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.28339 - lat) + Math.Abs(-106.66792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16663 - lat) + Math.Abs(-55.14829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.74965 - lat) + Math.Abs(-73.59956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2286 - lat) + Math.Abs(-73.01917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.75018 - lat) + Math.Abs(-77.63277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31681 - lat) + Math.Abs(-78.69957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.95015 - lat) + Math.Abs(-115.13547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.59274 - lat) + Math.Abs(-135.89984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.13348 - lat) + Math.Abs(-108.43471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.60725 - lat) + Math.Abs(-80.61081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.03928 - lat) + Math.Abs(-110.67661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.86673 - lat) + Math.Abs(-104.61768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.26811 - lat) + Math.Abs(-100.99669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31726 - lat) + Math.Abs(-73.9371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91671 - lat) + Math.Abs(-102.80099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31678 - lat) + Math.Abs(-73.74919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.11225 - lat) + Math.Abs(-120.7942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.36679 - lat) + Math.Abs(-72.01583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.2334 - lat) + Math.Abs(-75.46603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.38293 - lat) + Math.Abs(-123.53591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.94284 - lat) + Math.Abs(-65.07022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71659 - lat) + Math.Abs(-63.17932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.7501 - lat) + Math.Abs(-79.88296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.05009 - lat) + Math.Abs(-81.11644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.15012 - lat) + Math.Abs(-78.44954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.10013 - lat) + Math.Abs(-113.4687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.51681 - lat) + Math.Abs(-79.88294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.24532 - lat) + Math.Abs(-99.84364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65008 - lat) + Math.Abs(-74.08251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02895 - lat) + Math.Abs(-65.50186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.13298 - lat) + Math.Abs(-122.30258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.5789 - lat) + Math.Abs(-79.6583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.26682 - lat) + Math.Abs(-79.08287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.41667 - lat) + Math.Abs(-73.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09454 - lat) + Math.Abs(-64.7965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16681 - lat) + Math.Abs(-62.64866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6501 - lat) + Math.Abs(-74.93258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55011 - lat) + Math.Abs(-75.4993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50884 - lat) + Math.Abs(-73.58781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63202 - lat) + Math.Abs(-73.5075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45286 - lat) + Math.Abs(-73.64918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51675 - lat) + Math.Abs(-73.64918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.33338 - lat) + Math.Abs(-73.16585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.56515 - lat) + Math.Abs(-73.1868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21274 - lat) + Math.Abs(-74.58438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.26689 - lat) + Math.Abs(-80.61624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.40005 - lat) + Math.Abs(-105.53445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.20559 - lat) + Math.Abs(-95.30629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.13332 - lat) + Math.Abs(-101.66766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.27931 - lat) + Math.Abs(-80.6345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.1919 - lat) + Math.Abs(-98.10136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90009 - lat) + Math.Abs(-74.24922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.80014 - lat) + Math.Abs(-113.65203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.35499 - lat) + Math.Abs(-97.36567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.9001 - lat) + Math.Abs(-75.18261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.13341 - lat) + Math.Abs(-79.3163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.90009 - lat) + Math.Abs(-81.48306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51659 - lat) + Math.Abs(-52.78135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99666 - lat) + Math.Abs(-67.24028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(61.03346 - lat) + Math.Abs(-123.38639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.24987 - lat) + Math.Abs(-117.80226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.16638 - lat) + Math.Abs(-123.94003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.35008 - lat) + Math.Abs(-113.76866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.25012 - lat) + Math.Abs(-76.94944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18648 - lat) + Math.Abs(-73.40468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1668 - lat) + Math.Abs(-89.41683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.22892 - lat) + Math.Abs(-99.46642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.49985 - lat) + Math.Abs(-117.28553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.33619 - lat) + Math.Abs(-75.7225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.08339 - lat) + Math.Abs(-80.99973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58344 - lat) + Math.Abs(-62.64863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.38339 - lat) + Math.Abs(-80.6997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.24635 - lat) + Math.Abs(-127.5923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.05011 - lat) + Math.Abs(-79.46631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.87932 - lat) + Math.Abs(-66.66828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.20678 - lat) + Math.Abs(-122.91092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.10012 - lat) + Math.Abs(-79.06627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21676 - lat) + Math.Abs(-72.61582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.36678 - lat) + Math.Abs(-104.00092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.60559 - lat) + Math.Abs(-97.04234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96682 - lat) + Math.Abs(-66.53218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.8334 - lat) + Math.Abs(-80.38297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.83328 - lat) + Math.Abs(-72.53209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.28201 - lat) + Math.Abs(-126.8329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.77972 - lat) + Math.Abs(-108.2967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3168 - lat) + Math.Abs(-79.46633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.84133 - lat) + Math.Abs(-123.68596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.7251 - lat) + Math.Abs(-80.96723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.66634 - lat) + Math.Abs(-123.41933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.31636 - lat) + Math.Abs(-123.06934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.76681 - lat) + Math.Abs(-79.4163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.38342 - lat) + Math.Abs(-77.98281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47675 - lat) + Math.Abs(-73.61432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36678 - lat) + Math.Abs(-73.9325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.05007 - lat) + Math.Abs(-73.43245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75012 - lat) + Math.Abs(-79.04961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.0168 - lat) + Math.Abs(-75.08259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.44964 - lat) + Math.Abs(-123.3026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.45011 - lat) + Math.Abs(-79.68292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46489 - lat) + Math.Abs(-74.08892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.35 - lat) + Math.Abs(-119.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.72885 - lat) + Math.Abs(-113.98281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.78341 - lat) + Math.Abs(-114.10199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.18306 - lat) + Math.Abs(-119.5524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.9168 - lat) + Math.Abs(-80.09967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.60868 - lat) + Math.Abs(-79.42068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13338 - lat) + Math.Abs(-73.99922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83512 - lat) + Math.Abs(-66.47917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14887 - lat) + Math.Abs(-75.59778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.90012 - lat) + Math.Abs(-78.84957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.03306 - lat) + Math.Abs(-119.45237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41117 - lat) + Math.Abs(-75.69812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53338 - lat) + Math.Abs(-73.21585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50008 - lat) + Math.Abs(-107.05128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.56717 - lat) + Math.Abs(-80.94349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.23335 - lat) + Math.Abs(-102.1676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73345 - lat) + Math.Abs(-63.86542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(57.95014 - lat) + Math.Abs(-117.48608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.30641 - lat) + Math.Abs(-81.27265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.14642 - lat) + Math.Abs(-65.69996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6168 - lat) + Math.Abs(-75.01599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.15993 - lat) + Math.Abs(-81.68464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.31947 - lat) + Math.Abs(-124.31575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40567 - lat) + Math.Abs(-64.32585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34732 - lat) + Math.Abs(-80.03527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01671 - lat) + Math.Abs(-57.59837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.23715 - lat) + Math.Abs(-117.29176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.76647 - lat) + Math.Abs(-119.73568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.16685 - lat) + Math.Abs(-102.9341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.31641 - lat) + Math.Abs(-122.80273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81681 - lat) + Math.Abs(-77.11616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.13342 - lat) + Math.Abs(-113.8687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.48062 - lat) + Math.Abs(-119.58584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.90011 - lat) + Math.Abs(-76.24939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89452 - lat) + Math.Abs(-77.28007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.30012 - lat) + Math.Abs(-78.31623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.86678 - lat) + Math.Abs(-82.14981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.90012 - lat) + Math.Abs(-79.13289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.00012 - lat) + Math.Abs(-77.13275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.67875 - lat) + Math.Abs(-62.70936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.8833 - lat) + Math.Abs(-112.78516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90008 - lat) + Math.Abs(-74.13251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.07034 - lat) + Math.Abs(-72.81125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.46678 - lat) + Math.Abs(-104.41778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.48328 - lat) + Math.Abs(-113.95195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38338 - lat) + Math.Abs(-73.9825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.56641 - lat) + Math.Abs(-96.21808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.22119 - lat) + Math.Abs(-122.68965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.5326 - lat) + Math.Abs(-74.99369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.3001 - lat) + Math.Abs(-80.61639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90064 - lat) + Math.Abs(-64.24186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50008 - lat) + Math.Abs(-73.9659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44868 - lat) + Math.Abs(-73.81669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.50009 - lat) + Math.Abs(-71.78241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6768 - lat) + Math.Abs(-113.58147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.88332 - lat) + Math.Abs(-72.08247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.97282 - lat) + Math.Abs(-98.29263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.24133 - lat) + Math.Abs(-124.8028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.03339 - lat) + Math.Abs(-66.86545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.90012 - lat) + Math.Abs(-79.23288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.26637 - lat) + Math.Abs(-122.76932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61685 - lat) + Math.Abs(-61.34853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.01682 - lat) + Math.Abs(-78.39953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.59 - lat) + Math.Abs(-127.08638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.28124 - lat) + Math.Abs(-122.82457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.6168 - lat) + Math.Abs(-80.46638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.66679 - lat) + Math.Abs(-81.21644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.10015 - lat) + Math.Abs(-64.41546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.0334 - lat) + Math.Abs(-79.34961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83278 - lat) + Math.Abs(-124.52368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.56611 - lat) + Math.Abs(-96.19868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.94998 - lat) + Math.Abs(-102.66766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.71681 - lat) + Math.Abs(-75.51604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86678 - lat) + Math.Abs(-74.08251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.20008 - lat) + Math.Abs(-105.76772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.00012 - lat) + Math.Abs(-77.24946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.9166 - lat) + Math.Abs(-122.75301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.31507 - lat) + Math.Abs(-130.32098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.45802 - lat) + Math.Abs(-120.51076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76684 - lat) + Math.Abs(-61.29853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.35014 - lat) + Math.Abs(-110.26828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66168 - lat) + Math.Abs(-125.05686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47083 - lat) + Math.Abs(-75.50556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.97842 - lat) + Math.Abs(-122.4931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.18342 - lat) + Math.Abs(-77.56618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.11203 - lat) + Math.Abs(-117.35304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.654 - lat) + Math.Abs(-119.20236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.80906 - lat) + Math.Abs(-92.08534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.05007 - lat) + Math.Abs(-73.71587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.44998 - lat) + Math.Abs(-112.65185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.60873 - lat) + Math.Abs(-81.20763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.26682 - lat) + Math.Abs(-113.802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.01678 - lat) + Math.Abs(-93.82736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.06676 - lat) + Math.Abs(-93.73373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.45008 - lat) + Math.Abs(-104.6178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.78338 - lat) + Math.Abs(-105.00112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46681 - lat) + Math.Abs(-76.68272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.74222 - lat) + Math.Abs(-73.45008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.99712 - lat) + Math.Abs(-118.1953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44336 - lat) + Math.Abs(-73.24602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68073 - lat) + Math.Abs(-64.88044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66677 - lat) + Math.Abs(-72.1491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.1834 - lat) + Math.Abs(-75.83266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.17003 - lat) + Math.Abs(-123.13683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.87111 - lat) + Math.Abs(-79.43725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.47899 - lat) + Math.Abs(-113.5047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.43339 - lat) + Math.Abs(-81.89978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47927 - lat) + Math.Abs(-74.30238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6334 - lat) + Math.Abs(-114.23532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.03081 - lat) + Math.Abs(-100.24029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41679 - lat) + Math.Abs(-74.86596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.5168 - lat) + Math.Abs(-72.23244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.22999 - lat) + Math.Abs(-101.3565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35699 - lat) + Math.Abs(-71.99676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.00699 - lat) + Math.Abs(-72.09628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.61899 - lat) + Math.Abs(-80.14441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.36683 - lat) + Math.Abs(-114.9188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63338 - lat) + Math.Abs(-73.79919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5501 - lat) + Math.Abs(-108.00136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.08313 - lat) + Math.Abs(-117.80224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.66679 - lat) + Math.Abs(-106.33446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.43338 - lat) + Math.Abs(-73.04914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.23656 - lat) + Math.Abs(-79.02311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.64703 - lat) + Math.Abs(-124.9467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.2501 - lat) + Math.Abs(-75.36602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.91875 - lat) + Math.Abs(-64.38455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.41675 - lat) + Math.Abs(-71.06573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96679 - lat) + Math.Abs(-74.33253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.02539 - lat) + Math.Abs(-66.86155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.5001 - lat) + Math.Abs(-75.74935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65008 - lat) + Math.Abs(-73.29916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.55009 - lat) + Math.Abs(-71.33238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.07647 - lat) + Math.Abs(-73.55636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7168 - lat) + Math.Abs(-75.06599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0737 - lat) + Math.Abs(-67.05312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36294 - lat) + Math.Abs(-64.74985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.22602 - lat) + Math.Abs(-58.65017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72977 - lat) + Math.Abs(-72.92244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53338 - lat) + Math.Abs(-73.28246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50011 - lat) + Math.Abs(-75.98264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.46679 - lat) + Math.Abs(-71.6491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46685 - lat) + Math.Abs(-79.43296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53341 - lat) + Math.Abs(-73.34916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71502 - lat) + Math.Abs(-74.08376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41678 - lat) + Math.Abs(-72.99914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70288 - lat) + Math.Abs(-73.55417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.56679 - lat) + Math.Abs(-71.36578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73338 - lat) + Math.Abs(-74.13251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.06677 - lat) + Math.Abs(-70.51573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36678 - lat) + Math.Abs(-73.56588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93336 - lat) + Math.Abs(-72.43241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53341 - lat) + Math.Abs(-72.99914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78338 - lat) + Math.Abs(-73.14915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31868 - lat) + Math.Abs(-74.22171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95008 - lat) + Math.Abs(-74.13251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.05009 - lat) + Math.Abs(-74.28252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40618 - lat) + Math.Abs(-73.9456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.12402 - lat) + Math.Abs(-66.49243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76468 - lat) + Math.Abs(-73.81156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20007 - lat) + Math.Abs(-73.61587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40008 - lat) + Math.Abs(-73.58248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31836 - lat) + Math.Abs(-72.56632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.13368 - lat) + Math.Abs(-72.80083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23338 - lat) + Math.Abs(-73.51588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58338 - lat) + Math.Abs(-73.33246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96677 - lat) + Math.Abs(-73.71587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60338 - lat) + Math.Abs(-73.72698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60008 - lat) + Math.Abs(-73.09914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53338 - lat) + Math.Abs(-73.9325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25008 - lat) + Math.Abs(-73.79919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9334 - lat) + Math.Abs(-74.91597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.06677 - lat) + Math.Abs(-70.94905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81678 - lat) + Math.Abs(-73.89919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81676 - lat) + Math.Abs(-72.49911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63922 - lat) + Math.Abs(-73.82757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.565 - lat) + Math.Abs(-73.90554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.11679 - lat) + Math.Abs(-74.48253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.65007 - lat) + Math.Abs(-72.44906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16977 - lat) + Math.Abs(-73.42525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30007 - lat) + Math.Abs(-73.38245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.50009 - lat) + Math.Abs(-71.76581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83337 - lat) + Math.Abs(-72.56582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93338 - lat) + Math.Abs(-74.0159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.53338 - lat) + Math.Abs(-71.08236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63076 - lat) + Math.Abs(-72.95699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70013 - lat) + Math.Abs(-65.08204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43345 - lat) + Math.Abs(-79.29965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.94867 - lat) + Math.Abs(-73.57026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28338 - lat) + Math.Abs(-73.41587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3806 - lat) + Math.Abs(-74.0121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30713 - lat) + Math.Abs(-73.26259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78036 - lat) + Math.Abs(-74.00365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27076 - lat) + Math.Abs(-66.05616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95817 - lat) + Math.Abs(-73.22025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96677 - lat) + Math.Abs(-71.36577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53338 - lat) + Math.Abs(-73.9992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50008 - lat) + Math.Abs(-73.66585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40008 - lat) + Math.Abs(-74.13256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58773 - lat) + Math.Abs(-73.59501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.10006 - lat) + Math.Abs(-72.3658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65068 - lat) + Math.Abs(-72.76348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85008 - lat) + Math.Abs(-73.76588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68335 - lat) + Math.Abs(-72.0491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31678 - lat) + Math.Abs(-73.51587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.56758 - lat) + Math.Abs(-73.62168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.67702 - lat) + Math.Abs(-73.91881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.58944 - lat) + Math.Abs(-71.55247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35723 - lat) + Math.Abs(-73.47706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50277 - lat) + Math.Abs(-72.9089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00351 - lat) + Math.Abs(-72.74689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50005 - lat) + Math.Abs(-72.1991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30009 - lat) + Math.Abs(-74.29924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.58339 - lat) + Math.Abs(-72.33244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25011 - lat) + Math.Abs(-76.01605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46698 - lat) + Math.Abs(-73.60948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26678 - lat) + Math.Abs(-73.61588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86677 - lat) + Math.Abs(-71.81581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88686 - lat) + Math.Abs(-74.17943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90008 - lat) + Math.Abs(-74.16591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93338 - lat) + Math.Abs(-70.48233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.01677 - lat) + Math.Abs(-73.34915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.73336 - lat) + Math.Abs(-72.56581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61118 - lat) + Math.Abs(-73.51527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25009 - lat) + Math.Abs(-74.24924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25008 - lat) + Math.Abs(-74.13253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03905 - lat) + Math.Abs(-65.04628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.20411 - lat) + Math.Abs(-75.64344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.19986 - lat) + Math.Abs(-117.2689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6998 - lat) + Math.Abs(-119.30237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.94963 - lat) + Math.Abs(-123.76939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.97866 - lat) + Math.Abs(-82.40407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.13238 - lat) + Math.Abs(-106.66892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51677 - lat) + Math.Abs(-84.33325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.89981 - lat) + Math.Abs(-119.4524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.81684 - lat) + Math.Abs(-74.58248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.55009 - lat) + Math.Abs(-81.39976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.47512 - lat) + Math.Abs(-123.75903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.1436 - lat) + Math.Abs(-96.88452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.39302 - lat) + Math.Abs(-77.23951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.20011 - lat) + Math.Abs(-66.38208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.34998 - lat) + Math.Abs(-118.78602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65005 - lat) + Math.Abs(-108.4181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56675 - lat) + Math.Abs(-72.74913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60011 - lat) + Math.Abs(-76.4827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21981 - lat) + Math.Abs(-64.54107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23344 - lat) + Math.Abs(-64.56545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.76325 - lat) + Math.Abs(-65.32355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.0787 - lat) + Math.Abs(-80.20408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21679 - lat) + Math.Abs(-106.40109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00007 - lat) + Math.Abs(-70.83234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40008 - lat) + Math.Abs(-71.89908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.51684 - lat) + Math.Abs(-113.3187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.83312 - lat) + Math.Abs(-118.98565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.8334 - lat) + Math.Abs(-80.29967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.06676 - lat) + Math.Abs(-91.98358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.28344 - lat) + Math.Abs(-114.76896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.78036 - lat) + Math.Abs(-127.17428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.90452 - lat) + Math.Abs(-76.02333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.11687 - lat) + Math.Abs(-112.46863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.37463 - lat) + Math.Abs(-123.72762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.04178 - lat) + Math.Abs(-73.11358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3501 - lat) + Math.Abs(-62.24862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.6172 - lat) + Math.Abs(-100.2612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.31679 - lat) + Math.Abs(-81.51647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.8334 - lat) + Math.Abs(-79.38293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20007 - lat) + Math.Abs(-82.34984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.73332 - lat) + Math.Abs(-114.88532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.78327 - lat) + Math.Abs(-118.83607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.49995 - lat) + Math.Abs(-56.06492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65015 - lat) + Math.Abs(-64.04873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.53344 - lat) + Math.Abs(-113.91874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.69925 - lat) + Math.Abs(-123.15631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.6744 - lat) + Math.Abs(-97.11124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.63344 - lat) + Math.Abs(-113.63533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.37039 - lat) + Math.Abs(-55.59743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.17126 - lat) + Math.Abs(-79.24267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.65861 - lat) + Math.Abs(-98.34244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.5168 - lat) + Math.Abs(-80.6497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.52579 - lat) + Math.Abs(-96.68451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.55001 - lat) + Math.Abs(-58.5818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.50001 - lat) + Math.Abs(-58.4318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.31683 - lat) + Math.Abs(-112.71861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.9128 - lat) + Math.Abs(-97.54237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.30012 - lat) + Math.Abs(-77.54948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.26559 - lat) + Math.Abs(-97.34037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.13441 - lat) + Math.Abs(-97.32676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.26681 - lat) + Math.Abs(-79.53292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.53343 - lat) + Math.Abs(-114.00205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.98347 - lat) + Math.Abs(-111.28507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.36679 - lat) + Math.Abs(-80.94972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.05011 - lat) + Math.Abs(-113.38523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.77361 - lat) + Math.Abs(-81.18038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.59977 - lat) + Math.Abs(-119.66911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39593 - lat) + Math.Abs(-63.78762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8001 - lat) + Math.Abs(-114.63532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.76651 - lat) + Math.Abs(-119.26907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9334 - lat) + Math.Abs(-65.81545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.10635 - lat) + Math.Abs(-122.82509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72266 - lat) + Math.Abs(-65.50663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.10008 - lat) + Math.Abs(-72.61582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.71681 - lat) + Math.Abs(-115.40226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1058 - lat) + Math.Abs(-101.26759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.28337 - lat) + Math.Abs(-107.80135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.311 - lat) + Math.Abs(-114.08375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78703 - lat) + Math.Abs(-112.14603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.31679 - lat) + Math.Abs(-80.83302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.72122 - lat) + Math.Abs(-79.09712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49376 - lat) + Math.Abs(-79.71529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.47011 - lat) + Math.Abs(-63.72159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.51634 - lat) + Math.Abs(-128.60345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86449 - lat) + Math.Abs(-74.06627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70004 - lat) + Math.Abs(-73.64732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.82509 - lat) + Math.Abs(-101.25413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25006 - lat) + Math.Abs(-83.5666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.7435 - lat) + Math.Abs(-97.85579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.11682 - lat) + Math.Abs(-79.19958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.70012 - lat) + Math.Abs(-113.26863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.38202 - lat) + Math.Abs(-89.25018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6001 - lat) + Math.Abs(-75.24931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.46686 - lat) + Math.Abs(-81.33312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85002 - lat) + Math.Abs(-104.05096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25007 - lat) + Math.Abs(-81.66647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.36684 - lat) + Math.Abs(-112.66862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66659 - lat) + Math.Abs(-52.73135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.70011 - lat) + Math.Abs(-79.4163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.02437 - lat) + Math.Abs(-79.80553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.09983 - lat) + Math.Abs(-117.70223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.43339 - lat) + Math.Abs(-74.38254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34515 - lat) + Math.Abs(-72.5477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36685 - lat) + Math.Abs(-63.26538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01667 - lat) + Math.Abs(-123.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(69.44472 - lat) + Math.Abs(-133.03422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.13027 - lat) + Math.Abs(-120.99415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.47512 - lat) + Math.Abs(-77.31616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.71686 - lat) + Math.Abs(-111.75181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.0828 - lat) + Math.Abs(-96.6589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.94153 - lat) + Math.Abs(-125.54635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.45014 - lat) + Math.Abs(-109.16816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.64989 - lat) + Math.Abs(-53.21478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.04958 - lat) + Math.Abs(-128.90613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.10012 - lat) + Math.Abs(-79.11628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50008 - lat) + Math.Abs(-72.31581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03338 - lat) + Math.Abs(-74.21592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6501 - lat) + Math.Abs(-75.66604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.0974 - lat) + Math.Abs(-77.79737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.06673 - lat) + Math.Abs(-117.28585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00008 - lat) + Math.Abs(-74.18251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.24966 - lat) + Math.Abs(-123.11934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.01657 - lat) + Math.Abs(-124.01982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.4399 - lat) + Math.Abs(-75.66498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68338 - lat) + Math.Abs(-73.43246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40008 - lat) + Math.Abs(-74.03251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.8361 - lat) + Math.Abs(-79.49827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.06678 - lat) + Math.Abs(-112.11853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.50015 - lat) + Math.Abs(-112.05182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08338 - lat) + Math.Abs(-73.13245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78338 - lat) + Math.Abs(-73.34916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.35409 - lat) + Math.Abs(-110.85849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.26729 - lat) + Math.Abs(-119.27337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.0261 - lat) + Math.Abs(-126.36157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.4359 - lat) + Math.Abs(-123.35155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.05007 - lat) + Math.Abs(-71.96579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.10014 - lat) + Math.Abs(-111.76844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33345 - lat) + Math.Abs(-79.43297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.15012 - lat) + Math.Abs(-79.3996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.8508 - lat) + Math.Abs(-100.93262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.21682 - lat) + Math.Abs(-79.13288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53322 - lat) + Math.Abs(-54.78145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.40008 - lat) + Math.Abs(-113.25189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63319 - lat) + Math.Abs(-52.94806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.94999 - lat) + Math.Abs(-103.80102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.83482 - lat) + Math.Abs(-110.85342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6668 - lat) + Math.Abs(-75.83265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.6152 - lat) + Math.Abs(-82.51398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.31679 - lat) + Math.Abs(-106.56791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.13171 - lat) + Math.Abs(-97.54738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95007 - lat) + Math.Abs(-71.9824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.5168 - lat) + Math.Abs(-80.01637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48333 - lat) + Math.Abs(-78.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.73346 - lat) + Math.Abs(-76.16604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.9334 - lat) + Math.Abs(-80.28296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35008 - lat) + Math.Abs(-72.51582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.4668 - lat) + Math.Abs(-80.51639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.95008 - lat) + Math.Abs(-81.88309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.66677 - lat) + Math.Abs(-105.46788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.06349 - lat) + Math.Abs(-128.70893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.78345 - lat) + Math.Abs(-63.5987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.98877 - lat) + Math.Abs(-84.77411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.47959 - lat) + Math.Abs(-123.89239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.98342 - lat) + Math.Abs(-79.24958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.47691 - lat) + Math.Abs(-80.76209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.39274 - lat) + Math.Abs(-65.92313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.14995 - lat) + Math.Abs(-119.13602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.28333 - lat) + Math.Abs(-123.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.15016 - lat) + Math.Abs(-113.86876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.60009 - lat) + Math.Abs(-81.59976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48341 - lat) + Math.Abs(-73.59918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.96683 - lat) + Math.Abs(-113.36869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.66675 - lat) + Math.Abs(-103.85109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.11817 - lat) + Math.Abs(-122.95396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.43338 - lat) + Math.Abs(-104.36778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.15015 - lat) + Math.Abs(-115.68548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(60.71611 - lat) + Math.Abs(-135.05375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.88311 - lat) + Math.Abs(-119.30238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01636 - lat) + Math.Abs(-122.8026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.41683 - lat) + Math.Abs(-108.70142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.14153 - lat) + Math.Abs(-122.14451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0834 - lat) + Math.Abs(-75.34933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.98345 - lat) + Math.Abs(-64.13204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.56678 - lat) + Math.Abs(-71.99909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.30008 - lat) + Math.Abs(-83.01654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.88793 - lat) + Math.Abs(-81.31145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.1817 - lat) + Math.Abs(-97.94104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.8844 - lat) + Math.Abs(-97.14704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08345 - lat) + Math.Abs(-64.36546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.13339 - lat) + Math.Abs(-80.7497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.18 - lat) + Math.Abs(-116.5525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.76674 - lat) + Math.Abs(-104.18436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26676 - lat) + Math.Abs(-72.83243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.83345 - lat) + Math.Abs(-66.11557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.45411 - lat) + Math.Abs(-114.37248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.2167 - lat) + Math.Abs(-102.46766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.86632 - lat) + Math.Abs(-124.20271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.20011 - lat) + Math.Abs(-79.2663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.99038 - lat) + Math.Abs(-68.67777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21785 - lat) + Math.Abs(-70.77873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.6464 - lat) + Math.Abs(-63.57291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56494 - lat) + Math.Abs(-52.70931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.04428 - lat) + Math.Abs(-70.89529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96031 - lat) + Math.Abs(-71.03219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56593 - lat) + Math.Abs(-69.86631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81228 - lat) + Math.Abs(-71.21454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91976 - lat) + Math.Abs(-71.08253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80326 - lat) + Math.Abs(-71.17793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98043 - lat) + Math.Abs(-70.55493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69823 - lat) + Math.Abs(-71.58275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69058 - lat) + Math.Abs(-71.89011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.44879 - lat) + Math.Abs(-68.52396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.82699 - lat) + Math.Abs(-69.54243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.67833 - lat) + Math.Abs(-69.72229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1351 - lat) + Math.Abs(-60.1831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.15314 - lat) + Math.Abs(-125.90744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.87946 - lat) + Math.Abs(-118.08041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79392 - lat) + Math.Abs(-71.35191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3737 - lat) + Math.Abs(-68.32512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21418 - lat) + Math.Abs(-70.26969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.11353 - lat) + Math.Abs(-70.66526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.85244 - lat) + Math.Abs(-71.62056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15001 - lat) + Math.Abs(-69.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44109 - lat) + Math.Abs(-70.49858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.10749 - lat) + Math.Abs(-66.128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.46737 - lat) + Math.Abs(-60.20319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.91657 - lat) + Math.Abs(-69.50054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.00751 - lat) + Math.Abs(-66.67272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.61814 - lat) + Math.Abs(-65.65112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.82857 - lat) + Math.Abs(-67.52197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.2 - lat) + Math.Abs(-80.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58563 - lat) + Math.Abs(-75.4208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.46382 - lat) + Math.Abs(-67.43134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.94395 - lat) + Math.Abs(-64.57111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1035;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.06013 - lat) + Math.Abs(-139.43328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1036;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.19844 - lat) + Math.Abs(-123.40565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1037;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.8994 - lat) + Math.Abs(-73.7772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1038;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.34935 - lat) + Math.Abs(-64.67926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1039;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.9583 - lat) + Math.Abs(-65.5006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1040;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.04573 - lat) + Math.Abs(-65.49259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1041;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.16059 - lat) + Math.Abs(-65.85823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1042;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09371 - lat) + Math.Abs(-71.30539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1043;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.00956 - lat) + Math.Abs(-65.33621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1044;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.09838 - lat) + Math.Abs(-66.10036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1045;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68065 - lat) + Math.Abs(-68.8781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1046;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.2297 - lat) + Math.Abs(-69.80061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1047;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.73808 - lat) + Math.Abs(-69.08478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1048;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.58388 - lat) + Math.Abs(-68.19214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1049;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6856 - lat) + Math.Abs(-121.942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1050;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62922 - lat) + Math.Abs(-70.9734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1051;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.654 - lat) + Math.Abs(-70.15268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1052;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43401 - lat) + Math.Abs(-71.01168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1053;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21856 - lat) + Math.Abs(-71.76201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1054;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.21119 - lat) + Math.Abs(-66.18164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1055;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.77223 - lat) + Math.Abs(-79.25666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1056;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.35191 - lat) + Math.Abs(-69.40724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1057;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.53153 - lat) + Math.Abs(-64.00849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1058;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87662 - lat) + Math.Abs(-71.61541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1059;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.67244 - lat) + Math.Abs(-63.47506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1060;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.36386 - lat) + Math.Abs(-119.34997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1061;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.8625 - lat) + Math.Abs(-119.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1062;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.18317 - lat) + Math.Abs(-68.98693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1063;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.24495 - lat) + Math.Abs(-80.25144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1064;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51444 - lat) + Math.Abs(-64.91806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1065;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23669 - lat) + Math.Abs(-60.21767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1066;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29986 - lat) + Math.Abs(-67.51669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1067;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.41648 - lat) + Math.Abs(-71.24884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1068;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.67159 - lat) + Math.Abs(-71.78812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1069;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.74064 - lat) + Math.Abs(-71.45131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1070;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68042 - lat) + Math.Abs(-71.7239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1071;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36733 - lat) + Math.Abs(-70.03484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1072;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3 - lat) + Math.Abs(-70.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1073;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.41 - lat) + Math.Abs(-71.78 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1074;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.08938 - lat) + Math.Abs(-123.08241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1075;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.07791 - lat) + Math.Abs(-121.86756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1076;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.08668 - lat) + Math.Abs(-121.93743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1077;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.16473 - lat) + Math.Abs(-122.64042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1078;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.05801 - lat) + Math.Abs(-122.47087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1079;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16317 - lat) + Math.Abs(-67.9246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1080;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21304 - lat) + Math.Abs(-67.92847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1081;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.29897 - lat) + Math.Abs(-78.55989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1082;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.62552 - lat) + Math.Abs(-79.43095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1083;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.73366 - lat) + Math.Abs(-123.61739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1084;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.69053 - lat) + Math.Abs(-79.32794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1085;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.24832 - lat) + Math.Abs(-76.95069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1086;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.25122 - lat) + Math.Abs(-76.94424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1087;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.95129 - lat) + Math.Abs(-114.56028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1088;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68037 - lat) + Math.Abs(-71.22327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1089;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66346 - lat) + Math.Abs(-71.57335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1090;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.21806 - lat) + Math.Abs(-79.98716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1091;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88026 - lat) + Math.Abs(-71.51464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1092;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69314 - lat) + Math.Abs(-71.06927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1093;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58624 - lat) + Math.Abs(-71.20892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1094;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46315 - lat) + Math.Abs(-69.22666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1095;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75468 - lat) + Math.Abs(-71.69566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1096;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17163 - lat) + Math.Abs(-71.87462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1097;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.36672 - lat) + Math.Abs(-123.16652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1098;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.84431 - lat) + Math.Abs(-69.87837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1099;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6198 - lat) + Math.Abs(-74.6915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.76672 - lat) + Math.Abs(-79.39909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.44353 - lat) + Math.Abs(-67.61536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51813 - lat) + Math.Abs(-69.80301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37441 - lat) + Math.Abs(-70.91881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21358 - lat) + Math.Abs(-71.07674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1749 - lat) + Math.Abs(-65.98595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.80509 - lat) + Math.Abs(-99.63175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.7607 - lat) + Math.Abs(-69.47745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.77599 - lat) + Math.Abs(-63.67865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.43514 - lat) + Math.Abs(-75.7803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.4708 - lat) + Math.Abs(-113.38119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.45787 - lat) + Math.Abs(-113.3817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.44667 - lat) + Math.Abs(-113.38197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.46441 - lat) + Math.Abs(-113.36235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.47942 - lat) + Math.Abs(-113.38142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66617 - lat) + Math.Abs(-72.62512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16949 - lat) + Math.Abs(-73.31494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09502 - lat) + Math.Abs(-73.35176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.82364 - lat) + Math.Abs(-64.99838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39149 - lat) + Math.Abs(-68.2711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.74424 - lat) + Math.Abs(-64.70804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.45639 - lat) + Math.Abs(-113.42751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.71649 - lat) + Math.Abs(-54.16981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25407 - lat) + Math.Abs(-68.60589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(62.8025 - lat) + Math.Abs(-116.04639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57275 - lat) + Math.Abs(-75.12757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.89028 - lat) + Math.Abs(-71.37222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.81852 - lat) + Math.Abs(-123.49061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.80925 - lat) + Math.Abs(-65.73246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.73657 - lat) + Math.Abs(-64.84123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.85468 - lat) + Math.Abs(-64.66494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68713 - lat) + Math.Abs(-65.73386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69863 - lat) + Math.Abs(-65.88047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63537 - lat) + Math.Abs(-65.75864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69624 - lat) + Math.Abs(-65.77344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52955 - lat) + Math.Abs(-65.26898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50019 - lat) + Math.Abs(-64.93902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45314 - lat) + Math.Abs(-64.98185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47558 - lat) + Math.Abs(-75.48401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1792 - lat) + Math.Abs(-113.87981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.22228 - lat) + Math.Abs(-118.80415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.41628 - lat) + Math.Abs(-110.21304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.84213 - lat) + Math.Abs(-114.00493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.05593 - lat) + Math.Abs(-122.42299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.0088 - lat) + Math.Abs(-119.39672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.27588 - lat) + Math.Abs(-124.12782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(54.65135 - lat) + Math.Abs(-97.76848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1452 - lat) + Math.Abs(-64.78615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88308 - lat) + Math.Abs(-66.76905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05519 - lat) + Math.Abs(-64.58795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.94522 - lat) + Math.Abs(-60.61617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.05917 - lat) + Math.Abs(-93.73568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66773 - lat) + Math.Abs(-81.00028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05154 - lat) + Math.Abs(-78.52245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.54498 - lat) + Math.Abs(-68.39658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22029 - lat) + Math.Abs(-74.38606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.19572 - lat) + Math.Abs(-68.25813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.37549 - lat) + Math.Abs(-68.69415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.29209 - lat) + Math.Abs(-73.26154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.04807 - lat) + Math.Abs(-123.83395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05231 - lat) + Math.Abs(-64.95355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.62202 - lat) + Math.Abs(-124.02484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.741 - lat) + Math.Abs(-66.76041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.55189 - lat) + Math.Abs(-124.79881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26886 - lat) + Math.Abs(-64.60047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40457 - lat) + Math.Abs(-69.95025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70802 - lat) + Math.Abs(-71.45986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.45767 - lat) + Math.Abs(-123.46088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.07651 - lat) + Math.Abs(-64.66818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.51187 - lat) + Math.Abs(-71.59648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.32937 - lat) + Math.Abs(-122.66395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27888 - lat) + Math.Abs(-65.12442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98808 - lat) + Math.Abs(-66.75876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36922 - lat) + Math.Abs(-64.97122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3278 - lat) + Math.Abs(-65.01139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49887 - lat) + Math.Abs(-64.98691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95286 - lat) + Math.Abs(-66.59038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(55.12245 - lat) + Math.Abs(-118.77316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.74639 - lat) + Math.Abs(-64.91151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.28209 - lat) + Math.Abs(-124.28164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.11307 - lat) + Math.Abs(-64.86358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.01682 - lat) + Math.Abs(-118.4921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.13631 - lat) + Math.Abs(-121.94244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.8738 - lat) + Math.Abs(-66.12687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.16446 - lat) + Math.Abs(-122.23755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(56.6515 - lat) + Math.Abs(-111.1426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0686 - lat) + Math.Abs(-70.5417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.71216 - lat) + Math.Abs(-123.55872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.14438 - lat) + Math.Abs(-122.1121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1189;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("100 Mile House", "02", 51.64982, -121.28594);
case 1: return new CityInfo("Abbotsford", "02", 49.05798, -122.25257);
case 2: return new CityInfo("Acton Vale", "10", 45.65007, -72.56582);
case 3: return new CityInfo("Adstock", "10", 46.05007, -71.08235);
case 4: return new CityInfo("Agassiz", "02", 49.23298, -121.76926);
case 5: return new CityInfo("Airdrie", "01", 51.30011, -114.03528);
case 6: return new CityInfo("Ajax", "08", 43.85012, -79.03288);
case 7: return new CityInfo("Aklavik", "13", 68.21913, -135.01071);
case 8: return new CityInfo("Albanel", "10", 48.88324, -72.44867);
case 9: return new CityInfo("Alberton", "09", 46.81685, -64.06542);
case 10: return new CityInfo("Aldouane", "04", 46.63343, -65.06544);
case 11: return new CityInfo("Alliston", "08", 44.15011, -79.86635);
case 12: return new CityInfo("Alma", "10", 48.55009, -71.6491);
case 13: return new CityInfo("Altona", "03", 49.10469, -97.55961);
case 14: return new CityInfo("Amherst", "07", 45.83345, -64.19874);
case 15: return new CityInfo("Amherstburg", "08", 42.10009, -83.09985);
case 16: return new CityInfo("Amigo Beach", "08", 44.70011, -79.39963);
case 17: return new CityInfo("Amos", "10", 48.56688, -78.11624);
case 18: return new CityInfo("Ange-Gardien", "10", 45.35008, -72.93244);
case 19: return new CityInfo("Angus", "08", 44.31681, -79.88295);
case 20: return new CityInfo("Anmore", "02", 49.31637, -122.85263);
case 21: return new CityInfo("Anten Mills", "08", 44.4815, -79.81722);
case 22: return new CityInfo("Antigonish", "07", 45.61685, -61.99858);
case 23: return new CityInfo("Arbutus Ridge", "02", 49.24966, -123.16934);
case 24: return new CityInfo("Arctic Bay", "14", 73.03752, -85.15057);
case 25: return new CityInfo("Armstrong", "02", 50.44979, -119.20235);
case 26: return new CityInfo("Arnprior", "08", 45.43341, -76.34939);
case 27: return new CityInfo("Asbestos", "10", 45.76678, -71.9324);
case 28: return new CityInfo("Ashcroft", "02", 50.72372, -121.28207);
case 29: return new CityInfo("Assiniboia", "11", 49.63336, -105.98446);
case 30: return new CityInfo("Athabasca", "01", 54.71687, -113.28537);
case 31: return new CityInfo("Athens", "08", 44.63341, -75.94936);
case 32: return new CityInfo("Atikokan", "08", 48.75667, -91.62409);
case 33: return new CityInfo("Attawapiskat", "08", 52.92774, -82.41669);
case 34: return new CityInfo("Aurora", "08", 44.00011, -79.46632);
case 35: return new CityInfo("Aylmer", "08", 42.76679, -80.98302);
case 36: return new CityInfo("Azilda", "08", 46.55008, -81.09975);
case 37: return new CityInfo("Baie-Comeau", "10", 49.21679, -68.14894);
case 38: return new CityInfo("Baie-D'Urfé", "10", 45.41397, -73.91586);
case 39: return new CityInfo("Ballantrae", "08", 44.03342, -79.2996);
case 40: return new CityInfo("Bancroft", "08", 45.05752, -77.85702);
case 41: return new CityInfo("Banff", "01", 51.17622, -115.56982);
case 42: return new CityInfo("Barraute", "10", 48.43349, -77.63279);
case 43: return new CityInfo("Barrhead", "01", 54.13345, -114.40211);
case 44: return new CityInfo("Barrie", "08", 44.40011, -79.66634);
case 45: return new CityInfo("Barrière", "02", 51.18308, -120.1192);
case 46: return new CityInfo("Bassano", "01", 50.78342, -112.46854);
case 47: return new CityInfo("Bath", "08", 44.18342, -76.78273);
case 48: return new CityInfo("Bay Roberts", "05", 47.59989, -53.26478);
case 49: return new CityInfo("Bay St. George South", "05", 48.22781, -58.84162);
case 50: return new CityInfo("Beaconsfield", "10", 45.43341, -73.86586);
case 51: return new CityInfo("Beauharnois", "10", 45.31341, -73.8725);
case 52: return new CityInfo("Beaumont", "01", 53.35013, -113.41871);
case 53: return new CityInfo("Beausejour", "03", 50.0622, -96.51669);
case 54: return new CityInfo("Beaverlodge", "01", 55.21664, -119.43605);
case 55: return new CityInfo("Bécancour", "10", 46.34106, -72.43224);
case 56: return new CityInfo("Bedford", "10", 45.11678, -72.98244);
case 57: return new CityInfo("Belfast", "09", 46.08341, -62.88197);
case 58: return new CityInfo("Belleville", "08", 44.16682, -77.38277);
case 59: return new CityInfo("Bells Corners", "08", 45.31588, -75.83012);
case 60: return new CityInfo("Belmont", "08", 42.88339, -81.08303);
case 61: return new CityInfo("Beloeil", "10", 45.56839, -73.20568);
case 62: return new CityInfo("Berthierville", "10", 46.08336, -73.18245);
case 63: return new CityInfo("Berwick", "07", 45.05015, -64.73208);
case 64: return new CityInfo("Biggar", "11", 52.0668, -108.00135);
case 65: return new CityInfo("Binbrook", "08", 43.12135, -79.81104);
case 66: return new CityInfo("Black Diamond", "01", 50.70011, -114.2353);
case 67: return new CityInfo("Blackfalds", "01", 52.38342, -113.7853);
case 68: return new CityInfo("Blackstock", "08", 44.10012, -78.81626);
case 69: return new CityInfo("Blainville", "10", 45.66678, -73.88249);
case 70: return new CityInfo("Blaketown", "05", 47.4832, -53.5648);
case 71: return new CityInfo("Bloomfield", "05", 48.3832, -53.8981);
case 72: return new CityInfo("Bluewater", "08", 43.46679, -81.59977);
case 73: return new CityInfo("Boisbriand", "10", 45.61678, -73.83249);
case 74: return new CityInfo("Bois-des-Filion", "10", 45.66678, -73.74918);
case 75: return new CityInfo("Boissevain", "03", 49.23062, -100.05586);
case 76: return new CityInfo("Bon Accord", "01", 53.83345, -113.41872);
case 77: return new CityInfo("Bonavista", "05", 48.64989, -53.11474);
case 78: return new CityInfo("Bonnyville", "01", 54.26684, -110.73505);
case 79: return new CityInfo("Bothwell", "08", 42.63339, -81.86648);
case 80: return new CityInfo("Botwood", "05", 49.14994, -55.34819);
case 81: return new CityInfo("Boucherville", "10", 45.59104, -73.43605);
case 82: return new CityInfo("Bouctouche", "04", 46.46844, -64.73905);
case 83: return new CityInfo("Bourget", "08", 45.4334, -75.1493);
case 84: return new CityInfo("Boutiliers Point", "07", 44.66569, -63.95055);
case 85: return new CityInfo("Bowen Island", "02", 49.3847, -123.33622);
case 86: return new CityInfo("Bow Island", "01", 49.86676, -111.36843);
case 87: return new CityInfo("Bracebridge", "08", 45.03341, -79.31633);
case 88: return new CityInfo("Brampton", "08", 43.68341, -79.76633);
case 89: return new CityInfo("Brandon", "03", 49.84692, -99.95306);
case 90: return new CityInfo("Brant", "08", 43.1334, -80.34967);
case 91: return new CityInfo("Brantford", "08", 43.1334, -80.26636);
case 92: return new CityInfo("Bridgewater", "07", 44.37856, -64.51882);
case 93: return new CityInfo("Brockville", "08", 44.59132, -75.68705);
case 94: return new CityInfo("Bromont", "10", 45.31678, -72.64912);
case 95: return new CityInfo("Brooks", "01", 50.58341, -111.88509);
case 96: return new CityInfo("Brossard", "10", 45.45008, -73.46583);
case 97: return new CityInfo("Brownsburg-Chatham", "10", 45.68342, -74.4159);
case 98: return new CityInfo("Brussels", "08", 43.73339, -81.24975);
case 99: return new CityInfo("Burford", "08", 43.10292, -80.42869);
case 100: return new CityInfo("Burgeo", "05", 47.61668, -57.61516);
case 101: return new CityInfo("Burlington", "08", 43.38621, -79.83713);
case 102: return new CityInfo("Burnaby", "02", 49.26636, -122.95263);
case 103: return new CityInfo("Burns Lake", "02", 54.22972, -125.76084);
case 104: return new CityInfo("Cache Bay", "08", 46.36679, -79.98297);
case 105: return new CityInfo("Cache Creek", "02", 50.81011, -121.3246);
case 106: return new CityInfo("Caesarea", "08", 44.15012, -78.83286);
case 107: return new CityInfo("Calgary", "01", 51.05011, -114.08529);
case 108: return new CityInfo("Calmar", "01", 53.26683, -113.81874);
case 109: return new CityInfo("Calumet", "10", 45.65148, -74.63536);
case 110: return new CityInfo("Cambridge", "08", 43.3601, -80.31269);
case 111: return new CityInfo("Camlachie", "08", 43.03596, -82.1616);
case 112: return new CityInfo("Campbell River", "02", 50.01634, -125.24459);
case 113: return new CityInfo("Camperville", "03", 51.98832, -100.14365);
case 114: return new CityInfo("Camrose", "01", 53.01684, -112.83525);
case 115: return new CityInfo("Candiac", "10", 45.38338, -73.51587);
case 116: return new CityInfo("Canmore", "01", 51.08335, -115.35206);
case 117: return new CityInfo("Canora", "11", 51.63328, -102.43425);
case 118: return new CityInfo("Cantley", "10", 45.5668, -75.78265);
case 119: return new CityInfo("Cap-Chat", "10", 49.09736, -66.68514);
case 120: return new CityInfo("Capreol", "08", 46.70626, -80.92109);
case 121: return new CityInfo("Carberry", "03", 49.86893, -99.36021);
case 122: return new CityInfo("Carbonear", "05", 47.73319, -53.21478);
case 123: return new CityInfo("Cardston", "01", 49.19998, -113.3019);
case 124: return new CityInfo("Carignan", "10", 45.45008, -73.29916);
case 125: return new CityInfo("Carleton Place", "08", 45.13341, -76.14938);
case 126: return new CityInfo("Carlyle", "11", 49.63334, -102.26765);
case 127: return new CityInfo("Carman", "03", 49.4992, -98.00156);
case 128: return new CityInfo("Carnduff", "11", 49.16674, -101.80088);
case 129: return new CityInfo("Caronport", "11", 50.45006, -105.81787);
case 130: return new CityInfo("Carrot River", "11", 53.28337, -103.58423);
case 131: return new CityInfo("Carstairs", "01", 51.56681, -114.102);
case 132: return new CityInfo("Casselman", "08", 45.3168, -75.0826);
case 133: return new CityInfo("Cassidy", "02", 49.04963, -123.886);
case 134: return new CityInfo("Castlegar", "02", 49.32317, -117.65831);
case 135: return new CityInfo("Catalina", "05", 48.51659, -53.08135);
case 136: return new CityInfo("Cedar", "02", 49.11633, -123.8527);
case 137: return new CityInfo("Chambly", "10", 45.45008, -73.28246);
case 138: return new CityInfo("Chambord", "10", 48.43339, -72.06583);
case 139: return new CityInfo("Channel-Port aux Basques", "05", 47.57286, -59.13808);
case 140: return new CityInfo("Chapais", "10", 49.78344, -74.84919);
case 141: return new CityInfo("Charlemagne", "10", 45.71678, -73.48247);
case 142: return new CityInfo("Charlottetown", "09", 46.23459, -63.1256);
case 143: return new CityInfo("Chase", "02", 50.8165, -119.68571);
case 144: return new CityInfo("Châteauguay", "10", 45.38338, -73.74919);
case 145: return new CityInfo("Chatham", "08", 42.41224, -82.18494);
case 146: return new CityInfo("Chemainus", "02", 48.91633, -123.71937);
case 147: return new CityInfo("Chertsey", "10", 46.07109, -73.89095);
case 148: return new CityInfo("Chester", "07", 44.54225, -64.23891);
case 149: return new CityInfo("Chestermere", "01", 51.03341, -113.81867);
case 150: return new CityInfo("Chetwynd", "02", 55.69988, -121.63627);
case 151: return new CityInfo("Chibougamau", "10", 49.91684, -74.36586);
case 152: return new CityInfo("Chilliwack", "02", 49.16638, -121.95257);
case 153: return new CityInfo("Chute-aux-Outardes", "10", 49.11679, -68.39896);
case 154: return new CityInfo("Clarence-Rockland", "08", 45.5501, -75.29101);
case 155: return new CityInfo("Clarenville-Shoal Harbour", "05", 48.1805, -53.96982);
case 156: return new CityInfo("Claresholm", "01", 50.03332, -113.58524);
case 157: return new CityInfo("Clinton", "02", 51.08309, -121.58597);
case 158: return new CityInfo("Clyde River", "14", 70.47233, -68.58987);
case 159: return new CityInfo("Coaldale", "01", 49.7167, -112.61854);
case 160: return new CityInfo("Coalhurst", "01", 49.7464, -112.93246);
case 161: return new CityInfo("Coaticook", "10", 45.13339, -71.79907);
case 162: return new CityInfo("Cobourg", "08", 43.95977, -78.16515);
case 163: return new CityInfo("Cochrane", "01", 51.18341, -114.46871);
case 164: return new CityInfo("Cold Lake", "01", 54.46525, -110.18154);
case 165: return new CityInfo("Collingwood", "08", 44.4834, -80.21638);
case 166: return new CityInfo("Colwood", "02", 48.43293, -123.48591);
case 167: return new CityInfo("Conception Bay South", "05", 47.49989, -52.99806);
case 168: return new CityInfo("Concord", "08", 43.80011, -79.48291);
case 169: return new CityInfo("Constance Bay", "08", 45.50011, -76.08267);
case 170: return new CityInfo("Contrecoeur", "10", 45.85008, -73.23245);
case 171: return new CityInfo("Cookshire", "10", 45.41536, -71.62962);
case 172: return new CityInfo("Cookshire-Eaton", "10", 45.41675, -71.6324);
case 173: return new CityInfo("Cookstown", "08", 44.18341, -79.69964);
case 174: return new CityInfo("Coombs", "02", 49.29963, -124.41946);
case 175: return new CityInfo("Coquitlam", "02", 49.2846, -122.78217);
case 176: return new CityInfo("Corner Brook", "05", 48.95001, -57.95202);
case 177: return new CityInfo("Cornwall", "09", 46.22652, -63.21809);
case 178: return new CityInfo("Cornwall", "08", 45.01809, -74.72815);
case 179: return new CityInfo("Corunna", "08", 42.88338, -82.43313);
case 180: return new CityInfo("Coteau-du-Lac", "10", 45.30008, -74.18253);
case 181: return new CityInfo("Côte-Saint-Luc", "10", 45.46536, -73.66585);
case 182: return new CityInfo("Courtenay", "02", 49.68657, -124.9936);
case 183: return new CityInfo("Cowansville", "10", 45.20008, -72.74913);
case 184: return new CityInfo("Cow Bay", "07", 44.63141, -63.43218);
case 185: return new CityInfo("Crabtree", "10", 45.96677, -73.46586);
case 186: return new CityInfo("Cranberry Portage", "03", 54.58623, -101.37797);
case 187: return new CityInfo("Cranbrook", "02", 49.49991, -115.76879);
case 188: return new CityInfo("Creston", "02", 49.09987, -116.50211);
case 189: return new CityInfo("Crossfield", "01", 51.43341, -114.03528);
case 190: return new CityInfo("Cumberland", "02", 49.61634, -125.03613);
case 191: return new CityInfo("Dalmeny", "11", 52.33339, -106.76792);
case 192: return new CityInfo("Danville", "10", 45.78337, -72.0158);
case 193: return new CityInfo("Dartmouth", "07", 44.67134, -63.57719);
case 194: return new CityInfo("Dashwood", "02", 49.36633, -124.51947);
case 195: return new CityInfo("Dauphin", "03", 51.14941, -100.05023);
case 196: return new CityInfo("Daveluyville", "10", 46.20006, -72.13239);
case 197: return new CityInfo("Davidson", "11", 51.26676, -105.98449);
case 198: return new CityInfo("Dawson Creek", "02", 55.75984, -120.2403);
case 199: return new CityInfo("Deep River", "08", 46.10012, -77.49949);
case 200: return new CityInfo("Deer Lake", "05", 49.16671, -57.43163);
case 201: return new CityInfo("Delaware", "08", 42.91679, -81.41646);
case 202: return new CityInfo("Deloraine", "03", 49.19082, -100.49477);
case 203: return new CityInfo("Delson", "10", 45.36678, -73.54917);
case 204: return new CityInfo("Delta", "02", 49.14399, -122.9068);
case 205: return new CityInfo("Denman Island", "02", 49.53294, -124.8195);
case 206: return new CityInfo("Deseronto", "08", 44.20012, -77.04944);
case 207: return new CityInfo("Deux-Montagnes", "10", 45.53455, -73.90168);
case 208: return new CityInfo("Devon", "01", 53.36683, -113.73533);
case 209: return new CityInfo("Didsbury", "01", 51.66681, -114.13529);
case 210: return new CityInfo("Dieppe", "04", 46.07844, -64.68735);
case 211: return new CityInfo("Digby", "07", 44.62188, -65.7586);
case 212: return new CityInfo("Disraeli", "10", 45.90007, -71.34907);
case 213: return new CityInfo("Dolbeau-Mistassini", "10", 48.8786, -72.23142);
case 214: return new CityInfo("Dollard-Des Ormeaux", "10", 45.49452, -73.82419);
case 215: return new CityInfo("Dorchester", "08", 42.98339, -81.06643);
case 216: return new CityInfo("Dorval", "10", 45.4473, -73.75335);
case 217: return new CityInfo("Dowling", "08", 46.59111, -81.33917);
case 218: return new CityInfo("Drayton Valley", "01", 53.21682, -114.98544);
case 219: return new CityInfo("Drummondville", "10", 45.88336, -72.48241);
case 220: return new CityInfo("Dryden", "08", 49.78334, -92.75032);
case 221: return new CityInfo("Duncan", "02", 48.78293, -123.70266);
case 222: return new CityInfo("Dunham", "10", 45.13338, -72.79913);
case 223: return new CityInfo("Ear Falls", "08", 50.63955, -93.23526);
case 224: return new CityInfo("East Angus", "10", 45.48338, -71.66577);
case 225: return new CityInfo("East Gwillimbury", "08", 44.10087, -79.43785);
case 226: return new CityInfo("East Wellington", "02", 49.17385, -124.01745);
case 227: return new CityInfo("Edmonton", "01", 53.55014, -113.46871);
case 228: return new CityInfo("Edson", "01", 53.58345, -116.43559);
case 229: return new CityInfo("Elkford", "02", 50.05007, -114.8854);
case 230: return new CityInfo("Elk Point", "01", 53.90017, -110.9017);
case 231: return new CityInfo("Elliot Lake", "08", 46.38336, -82.63315);
case 232: return new CityInfo("Ellison", "02", 49.93307, -119.36907);
case 233: return new CityInfo("Elmvale", "08", 44.5834, -79.86636);
case 234: return new CityInfo("Enderby", "02", 50.5498, -119.15234);
case 235: return new CityInfo("Englehart", "08", 47.81686, -79.8664);
case 236: return new CityInfo("English Corner", "07", 44.73345, -63.78201);
case 237: return new CityInfo("Espanola", "08", 46.25837, -81.76649);
case 238: return new CityInfo("Essex", "08", 42.17509, -82.82483);
case 239: return new CityInfo("Esterhazy", "11", 50.65001, -102.08426);
case 240: return new CityInfo("Estevan", "11", 49.13337, -102.98422);
case 241: return new CityInfo("Eston", "11", 51.1501, -108.75144);
case 242: return new CityInfo("Etobicoke", "08", 43.65421, -79.56711);
case 243: return new CityInfo("Fairview", "01", 56.06675, -118.38606);
case 244: return new CityInfo("Falher", "01", 55.73339, -117.20262);
case 245: return new CityInfo("Falkland", "02", 50.49979, -119.55239);
case 246: return new CityInfo("Fall River", "07", 44.81685, -63.6154);
case 247: return new CityInfo("Farnham", "10", 45.28338, -72.98244);
case 248: return new CityInfo("Ferme-Neuve", "10", 46.70011, -75.44929);
case 249: return new CityInfo("Fermont", "10", 52.78345, -67.08204);
case 250: return new CityInfo("Fernie", "02", 49.49996, -115.06871);
case 251: return new CityInfo("Flin Flon", "03", 54.76703, -101.87433);
case 252: return new CityInfo("Foam Lake", "11", 51.65001, -103.53431);
case 253: return new CityInfo("Fort Albany", "08", 52.19998, -81.66664);
case 254: return new CityInfo("Fort-Coulonge", "10", 45.85011, -76.73272);
case 255: return new CityInfo("Fort Erie", "08", 42.90012, -78.93286);
case 256: return new CityInfo("Fort Frances", "08", 48.61667, -93.4003);
case 257: return new CityInfo("Fort Good Hope", "13", 66.25698, -128.6374);
case 258: return new CityInfo("Fort Liard", "13", 60.23947, -123.47371);
case 259: return new CityInfo("Fort Macleod", "01", 49.71671, -113.41857);
case 260: return new CityInfo("Fort McMurray", "01", 56.72676, -111.38103);
case 261: return new CityInfo("Fort McPherson", "13", 67.43863, -134.88543);
case 262: return new CityInfo("Fort Nelson", "02", 58.80533, -122.7002);
case 263: return new CityInfo("Fort Saskatchewan", "01", 53.71684, -113.2187);
case 264: return new CityInfo("Fort Smith", "13", 60.00439, -111.88871);
case 265: return new CityInfo("Fort St. John", "02", 56.24988, -120.85292);
case 266: return new CityInfo("Fox Creek", "01", 54.40007, -116.80238);
case 267: return new CityInfo("Franklin", "10", 45.03338, -73.91591);
case 268: return new CityInfo("Fredericton", "04", 45.94541, -66.66558);
case 269: return new CityInfo("French Creek", "02", 49.34123, -124.35541);
case 270: return new CityInfo("Fruitvale", "02", 49.11654, -117.55222);
case 271: return new CityInfo("Gambo", "05", 48.7832, -54.21482);
case 272: return new CityInfo("Gananoque", "08", 44.33342, -76.16607);
case 273: return new CityInfo("Gander Bay North", "05", 49.34992, -54.48141);
case 274: return new CityInfo("Ganges", "02", 48.85342, -123.50032);
case 275: return new CityInfo("Garson", "03", 50.0778, -96.7073);
case 276: return new CityInfo("Gaspé", "10", 48.83341, -64.48194);
case 277: return new CityInfo("Gatineau", "10", 45.47723, -75.70164);
case 278: return new CityInfo("Gibbons", "01", 53.83345, -113.33531);
case 279: return new CityInfo("Gibsons", "02", 49.39539, -123.50555);
case 280: return new CityInfo("Gimli", "03", 50.63362, -96.99066);
case 281: return new CityInfo("Gjoa Haven", "14", 68.62602, -95.87836);
case 282: return new CityInfo("Glace Bay", "07", 46.19695, -59.95698);
case 283: return new CityInfo("Glencoe", "08", 42.75009, -81.71648);
case 284: return new CityInfo("Godefroy", "10", 51.75012, -68.08213);
case 285: return new CityInfo("Goderich", "08", 43.74171, -81.71339);
case 286: return new CityInfo("Golden", "02", 51.29995, -116.9689);
case 287: return new CityInfo("Goodwood", "08", 44.03342, -79.19959);
case 288: return new CityInfo("Goulds", "05", 47.45532, -52.77552);
case 289: return new CityInfo("Granby", "10", 45.40008, -72.73243);
case 290: return new CityInfo("Grand Bank", "05", 47.09995, -55.76504);
case 291: return new CityInfo("Grande Cache", "01", 53.88335, -119.13585);
case 292: return new CityInfo("Grande-Digue", "04", 46.30014, -64.56546);
case 293: return new CityInfo("Grande Prairie", "01", 55.16667, -118.80271);
case 294: return new CityInfo("Grand Falls-Windsor", "05", 48.93324, -55.66492);
case 295: return new CityInfo("Grand Forks", "02", 49.03309, -118.4356);
case 296: return new CityInfo("Grand Haven", "02", 56.23333, -120.9);
case 297: return new CityInfo("Greater Sudbury", "08", 46.49, -80.99001);
case 298: return new CityInfo("Gravelbourg", "11", 49.88336, -106.55122);
case 299: return new CityInfo("Gravenhurst", "08", 44.91681, -79.36633);
case 300: return new CityInfo("Greater Napanee", "08", 44.25012, -76.94944);
case 301: return new CityInfo("Greenbank", "08", 44.15012, -79.01628);
case 302: return new CityInfo("Green's Harbour", "05", 47.63319, -53.49809);
case 303: return new CityInfo("Greenstone", "08", 49.73343, -87.16668);
case 304: return new CityInfo("Greenwood", "07", 44.97413, -64.93169);
case 305: return new CityInfo("Grenfell", "11", 50.41674, -102.93432);
case 306: return new CityInfo("Grimshaw", "01", 56.18339, -117.6027);
case 307: return new CityInfo("Grunthal", "03", 49.40668, -96.85873);
case 308: return new CityInfo("Guelph", "08", 43.54594, -80.25599);
case 309: return new CityInfo("Gull Lake", "11", 50.10007, -108.48471);
case 310: return new CityInfo("Haines Junction", "12", 60.75216, -137.51082);
case 311: return new CityInfo("Hamilton", "08", 43.25011, -79.84963);
case 312: return new CityInfo("Hampstead", "10", 45.48064, -73.66307);
case 313: return new CityInfo("Hampton", "04", 45.52876, -65.85354);
case 314: return new CityInfo("Hanceville", "02", 51.91922, -123.04458);
case 315: return new CityInfo("Hanna", "01", 51.63343, -111.90181);
case 316: return new CityInfo("Hanover", "08", 44.15009, -81.03303);
case 317: return new CityInfo("Hantsport", "07", 45.06685, -64.16544);
case 318: return new CityInfo("Happy Valley-Goose Bay", "05", 53.3038, -60.32576);
case 319: return new CityInfo("Harbour Breton", "05", 47.48325, -55.79833);
case 320: return new CityInfo("Hare Bay", "05", 48.8499, -54.01481);
case 321: return new CityInfo("Harriston", "08", 43.90009, -80.88302);
case 322: return new CityInfo("Haute-Aboujagane", "04", 46.14834, -64.39892);
case 323: return new CityInfo("Havre-Saint-Pierre", "10", 50.24342, -63.60264);
case 324: return new CityInfo("Hawkesbury", "08", 45.60009, -74.61595);
case 325: return new CityInfo("Hay River", "13", 60.81555, -115.79993);
case 326: return new CityInfo("Headingley", "03", 49.8753, -97.40896);
case 327: return new CityInfo("Hearst", "08", 49.68351, -83.66654);
case 328: return new CityInfo("Hemmingford", "10", 45.05008, -73.58248);
case 329: return new CityInfo("High Level", "01", 58.51688, -117.13605);
case 330: return new CityInfo("High Prairie", "01", 55.4334, -116.4858);
case 331: return new CityInfo("High River", "01", 50.58341, -113.86867);
case 332: return new CityInfo("Hinton", "01", 53.40009, -117.58567);
case 333: return new CityInfo("Hope", "02", 49.38299, -121.44144);
case 334: return new CityInfo("Hornby Island", "02", 49.53448, -124.66923);
case 335: return new CityInfo("Hornepayne", "08", 49.21451, -84.77617);
case 336: return new CityInfo("Houston", "02", 54.39976, -126.67008);
case 337: return new CityInfo("Hudson", "10", 45.45008, -74.14922);
case 338: return new CityInfo("Hudson Bay", "11", 52.85003, -102.38425);
case 339: return new CityInfo("Humboldt", "11", 52.20005, -105.1255);
case 340: return new CityInfo("Huntingdon", "10", 45.08339, -74.16593);
case 341: return new CityInfo("Huntsville", "08", 45.33341, -79.21632);
case 342: return new CityInfo("Huron East", "08", 43.61679, -81.29975);
case 343: return new CityInfo("Ile des Chênes", "03", 49.7106, -96.98893);
case 344: return new CityInfo("Indian Head", "11", 50.53336, -103.66775);
case 345: return new CityInfo("Ingersoll", "08", 43.03339, -80.88302);
case 346: return new CityInfo("Innisfil", "08", 44.30011, -79.64964);
case 347: return new CityInfo("Inuvik", "13", 68.36166, -133.72817);
case 348: return new CityInfo("Invermere", "02", 50.51666, -116.03538);
case 349: return new CityInfo("Iqaluit", "14", 63.74697, -68.51727);
case 350: return new CityInfo("Iroquois Falls", "08", 48.76688, -80.68307);
case 351: return new CityInfo("Irricana", "01", 51.32372, -113.60475);
case 352: return new CityInfo("Jaffray", "02", 49.38324, -115.30204);
case 353: return new CityInfo("Jarvis", "08", 42.88341, -80.09965);
case 354: return new CityInfo("Jasper Park Lodge", "01", 52.88633, -118.05625);
case 355: return new CityInfo("Joliette", "10", 46.0164, -73.4236);
case 356: return new CityInfo("Kamloops", "02", 50.66648, -120.3192);
case 357: return new CityInfo("Kamsack", "11", 51.56668, -101.90093);
case 358: return new CityInfo("Kanata", "08", 45.3001, -75.91606);
case 359: return new CityInfo("Kapuskasing", "08", 49.41694, -82.43308);
case 360: return new CityInfo("Kazabazua", "10", 45.95011, -76.01606);
case 361: return new CityInfo("Kelowna", "02", 49.88307, -119.48568);
case 362: return new CityInfo("Kelvington", "11", 52.16669, -103.5343);
case 363: return new CityInfo("Kenora", "08", 49.76741, -94.48985);
case 364: return new CityInfo("Kensington", "09", 46.43343, -63.64871);
case 365: return new CityInfo("Kentville", "07", 45.0771, -64.49605);
case 366: return new CityInfo("Kerrobert", "11", 51.91682, -109.13479);
case 367: return new CityInfo("Keswick", "08", 44.25011, -79.46632);
case 368: return new CityInfo("Keswick Ridge", "04", 46.00011, -66.88218);
case 369: return new CityInfo("Killam", "01", 52.78344, -111.85175);
case 370: return new CityInfo("Killarney", "03", 49.18332, -99.66364);
case 371: return new CityInfo("Kimberley", "02", 49.67071, -115.9776);
case 372: return new CityInfo("Kincardine", "08", 44.18339, -81.63307);
case 373: return new CityInfo("Kindersley", "11", 51.46681, -109.16818);
case 374: return new CityInfo("King", "08", 43.96514, -79.59011);
case 375: return new CityInfo("Kingsey Falls", "10", 45.85007, -72.0658);
case 376: return new CityInfo("Kingston", "08", 44.22976, -76.48098);
case 377: return new CityInfo("Kipling", "11", 50.10003, -102.6343);
case 378: return new CityInfo("Kirkland", "10", 45.45008, -73.86586);
case 379: return new CityInfo("Kirkland Lake", "08", 48.14461, -80.03767);
case 380: return new CityInfo("Kitchener", "08", 43.42537, -80.5112);
case 381: return new CityInfo("Kitimat", "02", 54.05244, -128.65342);
case 382: return new CityInfo("Kugluktuk", "14", 67.82743, -115.09649);
case 383: return new CityInfo("Labelle", "10", 46.28339, -74.73255);
case 384: return new CityInfo("Labrador City", "05", 52.94626, -66.91137);
case 385: return new CityInfo("Labrieville", "10", 49.30009, -69.56294);
case 386: return new CityInfo("La Broquerie", "03", 49.51688, -96.50029);
case 387: return new CityInfo("Lac-Alouette", "10", 45.81698, -73.9592);
case 388: return new CityInfo("Lac-Brome", "10", 45.21678, -72.51581);
case 389: return new CityInfo("Lac-Connelly", "10", 45.89788, -73.9723);
case 390: return new CityInfo("Lac du Bonnet", "03", 50.2536, -96.06116);
case 391: return new CityInfo("Lachute", "10", 45.65008, -74.33253);
case 392: return new CityInfo("Lac La Biche", "01", 54.7669, -111.96861);
case 393: return new CityInfo("Lac-Lapierre", "10", 45.89837, -73.77308);
case 394: return new CityInfo("Lac-Mégantic", "10", 45.58338, -70.88234);
case 395: return new CityInfo("Lacolle", "10", 45.08338, -73.36585);
case 396: return new CityInfo("Lacombe", "01", 52.46681, -113.7353);
case 397: return new CityInfo("La Conception", "10", 46.15009, -74.69925);
case 398: return new CityInfo("Lac-Simon", "10", 46.15699, -74.74129);
case 399: return new CityInfo("Ladysmith", "02", 48.99016, -123.81699);
case 400: return new CityInfo("Lake Cowichan", "02", 48.82495, -124.05461);
case 401: return new CityInfo("Lake Echo", "07", 44.73345, -63.38198);
case 402: return new CityInfo("Lakefield", "08", 44.43342, -78.26623);
case 403: return new CityInfo("Lambton Shores", "08", 43.16678, -81.93309);
case 404: return new CityInfo("La Minerve", "10", 46.25009, -74.93257);
case 405: return new CityInfo("Lamont", "01", 53.76686, -112.80195);
case 406: return new CityInfo("Landmark", "03", 49.67169, -96.82232);
case 407: return new CityInfo("Langenburg", "11", 50.84999, -101.71763);
case 408: return new CityInfo("Langford", "02", 48.44963, -123.50261);
case 409: return new CityInfo("Langham", "11", 52.3668, -106.96793);
case 410: return new CityInfo("Langley", "02", 49.10107, -122.65883);
case 411: return new CityInfo("Lanigan", "11", 51.85006, -105.03443);
case 412: return new CityInfo("Lanoraie", "10", 45.96677, -73.21585);
case 413: return new CityInfo("Lantz", "07", 44.98345, -63.48199);
case 414: return new CityInfo("Lappe", "08", 48.5668, -89.35013);
case 415: return new CityInfo("La Prairie", "10", 45.41678, -73.49917);
case 416: return new CityInfo("La Ronge", "11", 55.10013, -105.28422);
case 417: return new CityInfo("La Sarre", "10", 48.80019, -79.19964);
case 418: return new CityInfo("L'Ascension-de-Notre-Seigneur", "10", 48.68339, -71.6658);
case 419: return new CityInfo("La Scie", "05", 49.94995, -55.59811);
case 420: return new CityInfo("L'Assomption", "10", 45.82318, -73.4294);
case 421: return new CityInfo("La Tuque", "10", 47.43337, -72.7824);
case 422: return new CityInfo("Laurentides", "10", 47.13336, -72.28239);
case 423: return new CityInfo("Laval", "10", 45.56995, -73.692);
case 424: return new CityInfo("Lavaltrie", "10", 45.88338, -73.28245);
case 425: return new CityInfo("Leamington", "08", 42.05009, -82.59981);
case 426: return new CityInfo("Lebel-sur-Quévillon", "10", 49.05018, -76.98273);
case 427: return new CityInfo("Leblanc", "10", 48.26683, -74.34914);
case 428: return new CityInfo("Leduc", "01", 53.26682, -113.55201);
case 429: return new CityInfo("L'Épiphanie", "10", 45.85008, -73.48246);
case 430: return new CityInfo("Les Cèdres", "10", 45.30008, -74.04922);
case 431: return new CityInfo("Les Coteaux", "10", 45.28338, -74.23254);
case 432: return new CityInfo("Lethbridge", "01", 49.69999, -112.81856);
case 433: return new CityInfo("Lewisporte", "05", 49.24993, -55.04816);
case 434: return new CityInfo("L'Île-Perrot", "10", 45.38338, -73.9492);
case 435: return new CityInfo("Limoges", "08", 45.3334, -75.24931);
case 436: return new CityInfo("Lincoln", "04", 45.90012, -66.58218);
case 437: return new CityInfo("Lindsay", "08", 44.35012, -78.73286);
case 438: return new CityInfo("Linière", "10", 46.00007, -70.41572);
case 439: return new CityInfo("Linwood", "08", 43.58171, -80.72815);
case 440: return new CityInfo("Lions Bay", "02", 49.45218, -123.2376);
case 441: return new CityInfo("Listowel", "08", 43.7334, -80.94973);
case 442: return new CityInfo("Little Current", "08", 45.97927, -81.9248);
case 443: return new CityInfo("Lively", "08", 46.43338, -81.14975);
case 444: return new CityInfo("Lloydminster", "01", 53.27237, -110.02256);
case 445: return new CityInfo("Logan Lake", "02", 50.49976, -120.80253);
case 446: return new CityInfo("London", "08", 42.98339, -81.23304);
case 447: return new CityInfo("Longueuil", "10", 45.53121, -73.51806);
case 448: return new CityInfo("Lorette", "03", 49.73919, -96.87232);
case 449: return new CityInfo("Lorraine", "10", 45.68338, -73.78249);
case 450: return new CityInfo("Lotbinière", "10", 46.61675, -71.93239);
case 451: return new CityInfo("Louiseville", "10", 46.25594, -72.94145);
case 452: return new CityInfo("Lucan", "08", 43.18339, -81.39976);
case 453: return new CityInfo("Lumby", "02", 50.24979, -118.96904);
case 454: return new CityInfo("Lumsden", "11", 50.65009, -104.86783);
case 455: return new CityInfo("Lunenburg", "07", 44.37847, -64.31658);
case 456: return new CityInfo("Lutes Mountain", "04", 46.13544, -64.90504);
case 457: return new CityInfo("Macamic", "10", 48.75018, -78.99962);
case 458: return new CityInfo("Mackenzie", "02", 55.33637, -123.09374);
case 459: return new CityInfo("Macklin", "11", 52.33344, -109.93484);
case 460: return new CityInfo("Madoc", "08", 44.50842, -77.47448);
case 461: return new CityInfo("Magog", "10", 45.26678, -72.14909);
case 462: return new CityInfo("Magrath", "01", 49.41668, -112.86856);
case 463: return new CityInfo("Malartic", "10", 48.13348, -78.13283);
case 464: return new CityInfo("Mandeville", "10", 46.36677, -73.34915);
case 465: return new CityInfo("Manitouwadge", "08", 49.12152, -85.8403);
case 466: return new CityInfo("Maniwaki", "10", 46.38341, -75.96605);
case 467: return new CityInfo("Manning", "01", 56.91683, -117.61945);
case 468: return new CityInfo("Mannville", "01", 53.33345, -111.1684);
case 469: return new CityInfo("Maple Creek", "11", 49.91678, -109.48481);
case 470: return new CityInfo("Maple Ridge", "01", 53.50172, -113.36274);
case 471: return new CityInfo("Maple Ridge", "02", 49.21939, -122.60193);
case 472: return new CityInfo("Marathon", "08", 48.7501, -86.43322);
case 473: return new CityInfo("Marieville", "10", 45.43338, -73.16585);
case 474: return new CityInfo("Markdale", "08", 44.3168, -80.64971);
case 475: return new CityInfo("Markham", "08", 43.86682, -79.2663);
case 476: return new CityInfo("Martensville", "11", 52.28339, -106.66792);
case 477: return new CityInfo("Marystown", "05", 47.16663, -55.14829);
case 478: return new CityInfo("Mascouche", "10", 45.74965, -73.59956);
case 479: return new CityInfo("Maskinongé", "10", 46.2286, -73.01917);
case 480: return new CityInfo("Matagami", "10", 49.75018, -77.63277);
case 481: return new CityInfo("Mattawa", "08", 46.31681, -78.69957);
case 482: return new CityInfo("Mayerthorpe", "01", 53.95015, -115.13547);
case 483: return new CityInfo("Mayo", "12", 63.59274, -135.89984);
case 484: return new CityInfo("Meadow Lake", "11", 54.13348, -108.43471);
case 485: return new CityInfo("Meaford", "08", 44.60725, -80.61081);
case 486: return new CityInfo("Medicine Hat", "01", 50.03928, -110.67661);
case 487: return new CityInfo("Melfort", "11", 52.86673, -104.61768);
case 488: return new CityInfo("Melita", "03", 49.26811, -100.99669);
case 489: return new CityInfo("Melocheville", "10", 45.31726, -73.9371);
case 490: return new CityInfo("Melville", "11", 50.91671, -102.80099);
case 491: return new CityInfo("Mercier", "10", 45.31678, -73.74919);
case 492: return new CityInfo("Merritt", "02", 50.11225, -120.7942);
case 493: return new CityInfo("Métabetchouan", "10", 48.36679, -72.01583);
case 494: return new CityInfo("Metcalfe", "08", 45.2334, -75.46603);
case 495: return new CityInfo("Metchosin", "02", 48.38293, -123.53591);
case 496: return new CityInfo("Middleton", "07", 44.94284, -65.07022);
case 497: return new CityInfo("Middleton", "07", 45.71659, -63.17932);
case 498: return new CityInfo("Midland", "08", 44.7501, -79.88296);
case 499: return new CityInfo("Mildmay", "08", 44.05009, -81.11644);
case 500: return new CityInfo("Millbrook", "08", 44.15012, -78.44954);
case 501: return new CityInfo("Millet", "01", 53.10013, -113.4687);
case 502: return new CityInfo("Milton", "08", 43.51681, -79.88294);
case 503: return new CityInfo("Minnedosa", "03", 50.24532, -99.84364);
case 504: return new CityInfo("Mirabel", "10", 45.65008, -74.08251);
case 505: return new CityInfo("Miramichi", "04", 47.02895, -65.50186);
case 506: return new CityInfo("Mission", "02", 49.13298, -122.30258);
case 507: return new CityInfo("Mississauga", "08", 43.5789, -79.6583);
case 508: return new CityInfo("Mississauga Beach", "08", 43.26682, -79.08287);
case 509: return new CityInfo("Mistissini", "10", 50.41667, -73.88333);
case 510: return new CityInfo("Moncton", "04", 46.09454, -64.7965);
case 511: return new CityInfo("Montague", "09", 46.16681, -62.64866);
case 512: return new CityInfo("Montebello", "10", 45.6501, -74.93258);
case 513: return new CityInfo("Mont-Laurier", "10", 46.55011, -75.4993);
case 514: return new CityInfo("Montréal", "10", 45.50884, -73.58781);
case 515: return new CityInfo("Montréal-Est", "10", 45.63202, -73.5075);
case 516: return new CityInfo("Montréal-Ouest", "10", 45.45286, -73.64918);
case 517: return new CityInfo("Mont-Royal", "10", 45.51675, -73.64918);
case 518: return new CityInfo("Mont-Saint-Grégoire", "10", 45.33338, -73.16585);
case 519: return new CityInfo("Mont-Saint-Hilaire", "10", 45.56515, -73.1868);
case 520: return new CityInfo("Mont-Tremblant", "10", 46.21274, -74.58438);
case 521: return new CityInfo("Moose Factory", "08", 51.26689, -80.61624);
case 522: return new CityInfo("Moose Jaw", "11", 50.40005, -105.53445);
case 523: return new CityInfo("Moose Lake", "03", 49.20559, -95.30629);
case 524: return new CityInfo("Moosomin", "11", 50.13332, -101.66766);
case 525: return new CityInfo("Moosonee", "08", 51.27931, -80.6345);
case 526: return new CityInfo("Morden", "03", 49.1919, -98.10136);
case 527: return new CityInfo("Morin-Heights", "10", 45.90009, -74.24922);
case 528: return new CityInfo("Morinville", "01", 53.80014, -113.65203);
case 529: return new CityInfo("Morris", "03", 49.35499, -97.36567);
case 530: return new CityInfo("Morrisburg", "08", 44.9001, -75.18261);
case 531: return new CityInfo("Mount Albert", "08", 44.13341, -79.3163);
case 532: return new CityInfo("Mount Brydges", "08", 42.90009, -81.48306);
case 533: return new CityInfo("Mount Pearl", "05", 47.51659, -52.78135);
case 534: return new CityInfo("Nackawic", "04", 45.99666, -67.24028);
case 535: return new CityInfo("Nahanni Butte", "13", 61.03346, -123.38639);
case 536: return new CityInfo("Nakusp", "02", 50.24987, -117.80226);
case 537: return new CityInfo("Nanaimo", "02", 49.16638, -123.94003);
case 538: return new CityInfo("Nanton", "01", 50.35008, -113.76866);
case 539: return new CityInfo("Napanee", "08", 44.25012, -76.94944);
case 540: return new CityInfo("Napierville", "10", 45.18648, -73.40468);
case 541: return new CityInfo("Neebing", "08", 48.1668, -89.41683);
case 542: return new CityInfo("Neepawa", "03", 50.22892, -99.46642);
case 543: return new CityInfo("Nelson", "02", 49.49985, -117.28553);
case 544: return new CityInfo("Nepean", "08", 45.33619, -75.7225);
case 545: return new CityInfo("Neustadt", "08", 44.08339, -80.99973);
case 546: return new CityInfo("New Glasgow", "07", 45.58344, -62.64863);
case 547: return new CityInfo("New Hamburg", "08", 43.38339, -80.6997);
case 548: return new CityInfo("New Hazelton", "02", 55.24635, -127.5923);
case 549: return new CityInfo("Newmarket", "08", 44.05011, -79.46631);
case 550: return new CityInfo("New Maryland", "04", 45.87932, -66.66828);
case 551: return new CityInfo("New Westminster", "02", 49.20678, -122.91092);
case 552: return new CityInfo("Niagara Falls", "08", 43.10012, -79.06627);
case 553: return new CityInfo("Nicolet", "10", 46.21676, -72.61582);
case 554: return new CityInfo("Nipawin", "11", 53.36678, -104.00092);
case 555: return new CityInfo("Niverville", "03", 49.60559, -97.04234);
case 556: return new CityInfo("Noonan", "04", 45.96682, -66.53218);
case 557: return new CityInfo("Norfolk County", "08", 42.8334, -80.38297);
case 558: return new CityInfo("Normandin", "10", 48.83328, -72.53209);
case 559: return new CityInfo("Norman Wells", "13", 65.28201, -126.8329);
case 560: return new CityInfo("North Battleford", "11", 52.77972, -108.2967);
case 561: return new CityInfo("North Bay", "08", 46.3168, -79.46633);
case 562: return new CityInfo("North Cowichan", "02", 48.84133, -123.68596);
case 563: return new CityInfo("North Perth", "08", 43.7251, -80.96723);
case 564: return new CityInfo("North Saanich", "02", 48.66634, -123.41933);
case 565: return new CityInfo("North Vancouver", "02", 49.31636, -123.06934);
case 566: return new CityInfo("North York", "08", 43.76681, -79.4163);
case 567: return new CityInfo("Norwood", "08", 44.38342, -77.98281);
case 568: return new CityInfo("Notre-Dame-de-Grâce", "10", 45.47675, -73.61432);
case 569: return new CityInfo("Notre-Dame-de-l'Île-Perrot", "10", 45.36678, -73.9325);
case 570: return new CityInfo("Notre-Dame-des-Prairies", "10", 46.05007, -73.43245);
case 571: return new CityInfo("Notre-Dame-du-Lac", "10", 46.75012, -79.04961);
case 572: return new CityInfo("Notre-Dame-du-Mont-Carmel", "10", 46.0168, -75.08259);
case 573: return new CityInfo("Oak Bay", "02", 48.44964, -123.3026);
case 574: return new CityInfo("Oakville", "08", 43.45011, -79.68292);
case 575: return new CityInfo("Oka", "10", 45.46489, -74.08892);
case 576: return new CityInfo("Okanagan Falls", "02", 49.35, -119.56667);
case 577: return new CityInfo("Okotoks", "01", 50.72885, -113.98281);
case 578: return new CityInfo("Olds", "01", 51.78341, -114.10199);
case 579: return new CityInfo("Oliver", "02", 49.18306, -119.5524);
case 580: return new CityInfo("Orangeville", "08", 43.9168, -80.09967);
case 581: return new CityInfo("Orillia", "08", 44.60868, -79.42068);
case 582: return new CityInfo("Ormstown", "10", 45.13338, -73.99922);
case 583: return new CityInfo("Oromocto", "04", 45.83512, -66.47917);
case 584: return new CityInfo("Osgoode", "08", 45.14887, -75.59778);
case 585: return new CityInfo("Oshawa", "08", 43.90012, -78.84957);
case 586: return new CityInfo("Osoyoos", "02", 49.03306, -119.45237);
case 587: return new CityInfo("Ottawa", "08", 45.41117, -75.69812);
case 588: return new CityInfo("Otterburn Park", "10", 45.53338, -73.21585);
case 589: return new CityInfo("Outlook", "11", 51.50008, -107.05128);
case 590: return new CityInfo("Owen Sound", "08", 44.56717, -80.94349);
case 591: return new CityInfo("Oxbow", "11", 49.23335, -102.1676);
case 592: return new CityInfo("Oxford", "07", 45.73345, -63.86542);
case 593: return new CityInfo("Paddle Prairie", "01", 57.95014, -117.48608);
case 594: return new CityInfo("Paisley", "08", 44.30641, -81.27265);
case 595: return new CityInfo("Pangnirtung", "14", 66.14642, -65.69996);
case 596: return new CityInfo("Papineauville", "10", 45.6168, -75.01599);
case 597: return new CityInfo("Parkhill", "08", 43.15993, -81.68464);
case 598: return new CityInfo("Parksville", "02", 49.31947, -124.31575);
case 599: return new CityInfo("Parrsboro", "07", 45.40567, -64.32585);
case 600: return new CityInfo("Parry Sound", "08", 45.34732, -80.03527);
case 601: return new CityInfo("Pasadena", "05", 49.01671, -57.59837);
case 602: return new CityInfo("Peace River", "01", 56.23715, -117.29176);
case 603: return new CityInfo("Peachland", "02", 49.76647, -119.73568);
case 604: return new CityInfo("Pelican Narrows", "11", 55.16685, -102.9341);
case 605: return new CityInfo("Pemberton", "02", 50.31641, -122.80273);
case 606: return new CityInfo("Pembroke", "08", 45.81681, -77.11616);
case 607: return new CityInfo("Penhold", "01", 52.13342, -113.8687);
case 608: return new CityInfo("Penticton", "02", 49.48062, -119.58584);
case 609: return new CityInfo("Perth", "08", 44.90011, -76.24939);
case 610: return new CityInfo("Petawawa", "08", 45.89452, -77.28007);
case 611: return new CityInfo("Peterborough", "08", 44.30012, -78.31623);
case 612: return new CityInfo("Petrolia", "08", 42.86678, -82.14981);
case 613: return new CityInfo("Pickering", "08", 43.90012, -79.13289);
case 614: return new CityInfo("Picton", "08", 44.00012, -77.13275);
case 615: return new CityInfo("Pictou", "07", 45.67875, -62.70936);
case 616: return new CityInfo("Picture Butte", "01", 49.8833, -112.78516);
case 617: return new CityInfo("Piedmont", "10", 45.90008, -74.13251);
case 618: return new CityInfo("Pierreville", "10", 46.07034, -72.81125);
case 619: return new CityInfo("Pilot Butte", "11", 50.46678, -104.41778);
case 620: return new CityInfo("Pincher Creek", "01", 49.48328, -113.95195);
case 621: return new CityInfo("Pincourt", "10", 45.38338, -73.9825);
case 622: return new CityInfo("Pine Falls", "03", 50.56641, -96.21808);
case 623: return new CityInfo("Pitt Meadows", "02", 49.22119, -122.68965);
case 624: return new CityInfo("Plantagenet", "08", 45.5326, -74.99369);
case 625: return new CityInfo("Plattsville", "08", 43.3001, -80.61639);
case 626: return new CityInfo("Point de Bute", "04", 45.90064, -64.24186);
case 627: return new CityInfo("Pointe-Calumet", "10", 45.50008, -73.9659);
case 628: return new CityInfo("Pointe-Claire", "10", 45.44868, -73.81669);
case 629: return new CityInfo("Pointe-du-Lac", "10", 48.50009, -71.78241);
case 630: return new CityInfo("Ponoka", "01", 52.6768, -113.58147);
case 631: return new CityInfo("Pont Rouge", "10", 48.88332, -72.08247);
case 632: return new CityInfo("Portage la Prairie", "03", 49.97282, -98.29263);
case 633: return new CityInfo("Port Alberni", "02", 49.24133, -124.8028);
case 634: return new CityInfo("Port-Cartier", "10", 50.03339, -66.86545);
case 635: return new CityInfo("Port Colborne", "08", 42.90012, -79.23288);
case 636: return new CityInfo("Port Coquitlam", "02", 49.26637, -122.76932);
case 637: return new CityInfo("Port Hawkesbury", "07", 45.61685, -61.34853);
case 638: return new CityInfo("Port Hope", "08", 44.01682, -78.39953);
case 639: return new CityInfo("Port McNeill", "02", 50.59, -127.08638);
case 640: return new CityInfo("Port Moody", "02", 49.28124, -122.82457);
case 641: return new CityInfo("Port Rowan", "08", 42.6168, -80.46638);
case 642: return new CityInfo("Port Stanley", "08", 42.66679, -81.21644);
case 643: return new CityInfo("Port Williams", "07", 45.10015, -64.41546);
case 644: return new CityInfo("Powassan", "08", 46.0334, -79.34961);
case 645: return new CityInfo("Powell River", "02", 49.83278, -124.52368);
case 646: return new CityInfo("Powerview", "03", 50.56611, -96.19868);
case 647: return new CityInfo("Preeceville", "11", 51.94998, -102.66766);
case 648: return new CityInfo("Prescott", "08", 44.71681, -75.51604);
case 649: return new CityInfo("Prévost", "10", 45.86678, -74.08251);
case 650: return new CityInfo("Prince Albert", "11", 53.20008, -105.76772);
case 651: return new CityInfo("Prince Edward", "08", 44.00012, -77.24946);
case 652: return new CityInfo("Prince George", "02", 53.9166, -122.75301);
case 653: return new CityInfo("Prince Rupert", "02", 54.31507, -130.32098);
case 654: return new CityInfo("Princeton", "02", 49.45802, -120.51076);
case 655: return new CityInfo("Princeville", "07", 45.76684, -61.29853);
case 656: return new CityInfo("Provost", "01", 52.35014, -110.26828);
case 657: return new CityInfo("Puntledge", "02", 49.66168, -125.05686);
case 658: return new CityInfo("Queenswood Heights", "08", 45.47083, -75.50556);
case 659: return new CityInfo("Quesnel", "02", 52.97842, -122.4931);
case 660: return new CityInfo("Quinte West", "08", 44.18342, -77.56618);
case 661: return new CityInfo("Gamèti", "13", 64.11203, -117.35304);
case 662: return new CityInfo("Ranchero", "02", 50.654, -119.20236);
case 663: return new CityInfo("Rankin Inlet", "14", 62.80906, -92.08534);
case 664: return new CityInfo("Rawdon", "10", 46.05007, -73.71587);
case 665: return new CityInfo("Raymond", "01", 49.44998, -112.65185);
case 666: return new CityInfo("Rayside-Balfour", "08", 46.60873, -81.20763);
case 667: return new CityInfo("Red Deer", "01", 52.26682, -113.802);
case 668: return new CityInfo("Red Lake", "08", 51.01678, -93.82736);
case 669: return new CityInfo("Red Lake", "08", 51.06676, -93.73373);
case 670: return new CityInfo("Regina", "11", 50.45008, -104.6178);
case 671: return new CityInfo("Regina Beach", "11", 50.78338, -105.00112);
case 672: return new CityInfo("Renfrew", "08", 45.46681, -76.68272);
case 673: return new CityInfo("Repentigny", "10", 45.74222, -73.45008);
case 674: return new CityInfo("Revelstoke", "02", 50.99712, -118.1953);
case 675: return new CityInfo("Richelieu", "10", 45.44336, -73.24602);
case 676: return new CityInfo("Richibucto", "04", 46.68073, -64.88044);
case 677: return new CityInfo("Richmond", "10", 45.66677, -72.1491);
case 678: return new CityInfo("Richmond", "08", 45.1834, -75.83266);
case 679: return new CityInfo("Richmond", "02", 49.17003, -123.13683);
case 680: return new CityInfo("Richmond Hill", "08", 43.87111, -79.43725);
case 681: return new CityInfo("Rideau Park", "01", 53.47899, -113.5047);
case 682: return new CityInfo("Ridgetown", "08", 42.43339, -81.89978);
case 683: return new CityInfo("Rigaud", "10", 45.47927, -74.30238);
case 684: return new CityInfo("Rimbey", "01", 52.6334, -114.23532);
case 685: return new CityInfo("Rivers", "03", 50.03081, -100.24029);
case 686: return new CityInfo("Rivière-Rouge", "10", 46.41679, -74.86596);
case 687: return new CityInfo("Roberval", "10", 48.5168, -72.23244);
case 688: return new CityInfo("Roblin", "03", 51.22999, -101.3565);
case 689: return new CityInfo("Rock Forest", "10", 45.35699, -71.99676);
case 690: return new CityInfo("Rock Island", "10", 45.00699, -72.09628);
case 691: return new CityInfo("Rockwood", "08", 43.61899, -80.14441);
case 692: return new CityInfo("Rocky Mountain House", "01", 52.36683, -114.9188);
case 693: return new CityInfo("Rosemère", "10", 45.63338, -73.79919);
case 694: return new CityInfo("Rosetown", "11", 51.5501, -108.00136);
case 695: return new CityInfo("Rossland", "02", 49.08313, -117.80224);
case 696: return new CityInfo("Rosthern", "11", 52.66679, -106.33446);
case 697: return new CityInfo("Rougemont", "10", 45.43338, -73.04914);
case 698: return new CityInfo("Rouyn-Noranda", "10", 48.23656, -79.02311);
case 699: return new CityInfo("Royston", "02", 49.64703, -124.9467);
case 700: return new CityInfo("Russell", "08", 45.2501, -75.36602);
case 701: return new CityInfo("Sackville", "04", 45.91875, -64.38455);
case 702: return new CityInfo("Saguenay", "10", 48.41675, -71.06573);
case 703: return new CityInfo("Saint-Adolphe-d'Howard", "10", 45.96679, -74.33253);
case 704: return new CityInfo("Saint-Alexandre", "10", 50.02539, -66.86155);
case 705: return new CityInfo("Saint-Alexandre", "10", 45.5001, -75.74935);
case 706: return new CityInfo("Saint-Amable", "10", 45.65008, -73.29916);
case 707: return new CityInfo("Saint-Ambroise", "10", 48.55009, -71.33238);
case 708: return new CityInfo("Saint-Ambroise", "10", 46.07647, -73.55636);
case 709: return new CityInfo("Saint-André-Avellin", "10", 45.7168, -75.06599);
case 710: return new CityInfo("Saint Andrews", "04", 45.0737, -67.05312);
case 711: return new CityInfo("Saint-Antoine", "04", 46.36294, -64.74985);
case 712: return new CityInfo("Saint-Augustin", "10", 51.22602, -58.65017);
case 713: return new CityInfo("Saint-Barnabé-Sud", "10", 45.72977, -72.92244);
case 714: return new CityInfo("Saint-Basile-le-Grand", "10", 45.53338, -73.28246);
case 715: return new CityInfo("Saint-Boniface", "10", 46.50011, -75.98264);
case 716: return new CityInfo("Saint-Bruno", "10", 48.46679, -71.6491);
case 717: return new CityInfo("Saint-Bruno-de-Guigues", "10", 47.46685, -79.43296);
case 718: return new CityInfo("Saint-Bruno-de-Montarville", "10", 45.53341, -73.34916);
case 719: return new CityInfo("Saint-Canut", "10", 45.71502, -74.08376);
case 720: return new CityInfo("Saint-Césaire", "10", 45.41678, -72.99914);
case 721: return new CityInfo("Saint-Charles", "10", 45.70288, -73.55417);
case 722: return new CityInfo("Saint-Charles-de-Bourget", "10", 48.56679, -71.36578);
case 723: return new CityInfo("Saint-Colomban", "10", 45.73338, -74.13251);
case 724: return new CityInfo("Saint-Côme--Linière", "10", 46.06677, -70.51573);
case 725: return new CityInfo("Saint-Constant", "10", 45.36678, -73.56588);
case 726: return new CityInfo("Saint-Cyrille-de-Wendover", "10", 45.93336, -72.43241);
case 727: return new CityInfo("Saint-Damase", "10", 45.53341, -72.99914);
case 728: return new CityInfo("Saint-Denis-sur-Richelieu", "10", 45.78338, -73.14915);
case 729: return new CityInfo("Saint-Donat-de-Montcalm", "10", 46.31868, -74.22171);
case 730: return new CityInfo("Sainte-Adèle", "10", 45.95008, -74.13251);
case 731: return new CityInfo("Sainte-Agathe-des-Monts", "10", 46.05009, -74.28252);
case 732: return new CityInfo("Sainte-Anne-de-Bellevue", "10", 45.40618, -73.9456);
case 733: return new CityInfo("Sainte-Anne-des-Monts", "10", 49.12402, -66.49243);
case 734: return new CityInfo("Sainte-Anne-des-Plaines", "10", 45.76468, -73.81156);
case 735: return new CityInfo("Sainte-Béatrix", "10", 46.20007, -73.61587);
case 736: return new CityInfo("Sainte-Catherine", "10", 45.40008, -73.58248);
case 737: return new CityInfo("Sainte-Catherine", "10", 46.31836, -72.56632);
case 738: return new CityInfo("Sainte-Croix", "10", 45.13368, -72.80083);
case 739: return new CityInfo("Saint-Édouard", "10", 45.23338, -73.51588);
case 740: return new CityInfo("Sainte-Julie", "10", 45.58338, -73.33246);
case 741: return new CityInfo("Sainte-Julienne", "10", 45.96677, -73.71587);
case 742: return new CityInfo("Saint-Elzéar", "10", 45.60338, -73.72698);
case 743: return new CityInfo("Sainte-Madeleine", "10", 45.60008, -73.09914);
case 744: return new CityInfo("Sainte-Marthe-sur-le-Lac", "10", 45.53338, -73.9325);
case 745: return new CityInfo("Sainte-Martine", "10", 45.25008, -73.79919);
case 746: return new CityInfo("Saint-Émile-de-Suffolk", "10", 45.9334, -74.91597);
case 747: return new CityInfo("Saint-Éphrem-de-Beauce", "10", 46.06677, -70.94905);
case 748: return new CityInfo("Sainte-Sophie", "10", 45.81678, -73.89919);
case 749: return new CityInfo("Sainte-Thècle", "10", 46.81676, -72.49911);
case 750: return new CityInfo("Sainte-Thérèse", "10", 45.63922, -73.82757);
case 751: return new CityInfo("Saint-Eustache", "10", 45.565, -73.90554);
case 752: return new CityInfo("Saint-Faustin", "10", 46.11679, -74.48253);
case 753: return new CityInfo("Saint-Félicien", "10", 48.65007, -72.44906);
case 754: return new CityInfo("Saint-Félix-de-Valois", "10", 46.16977, -73.42525);
case 755: return new CityInfo("Saint-Gabriel", "10", 46.30007, -73.38245);
case 756: return new CityInfo("Saint-Gédéon", "10", 48.50009, -71.76581);
case 757: return new CityInfo("Saint-Germain-de-Grantham", "10", 45.83337, -72.56582);
case 758: return new CityInfo("Saint-Hippolyte", "10", 45.93338, -74.0159);
case 759: return new CityInfo("Saint-Honoré", "10", 48.53338, -71.08236);
case 760: return new CityInfo("Saint-Hyacinthe", "10", 45.63076, -72.95699);
case 761: return new CityInfo("Saint-Ignace", "04", 46.70013, -65.08204);
case 762: return new CityInfo("Saint-Isidore", "10", 47.43345, -79.29965);
case 763: return new CityInfo("Saint-Jacques", "10", 45.94867, -73.57026);
case 764: return new CityInfo("Saint-Jacques-le-Mineur", "10", 45.28338, -73.41587);
case 765: return new CityInfo("Saint-Jean-Baptiste", "10", 45.3806, -74.0121);
case 766: return new CityInfo("Saint-Jean-sur-Richelieu", "10", 45.30713, -73.26259);
case 767: return new CityInfo("Saint-Jérôme", "10", 45.78036, -74.00365);
case 768: return new CityInfo("Saint John", "04", 45.27076, -66.05616);
case 769: return new CityInfo("Saint-Joseph", "10", 45.95817, -73.22025);
case 770: return new CityInfo("Saint-Joseph-de-Coleraine", "10", 45.96677, -71.36577);
case 771: return new CityInfo("Saint-Joseph-du-Lac", "10", 45.53338, -73.9992);
case 772: return new CityInfo("Saint-Laurent", "10", 45.50008, -73.66585);
case 773: return new CityInfo("Saint-Lazare", "10", 45.40008, -74.13256);
case 774: return new CityInfo("Saint-Léonard", "10", 45.58773, -73.59501);
case 775: return new CityInfo("Saint-Léonard-d'Aston", "10", 46.10006, -72.3658);
case 776: return new CityInfo("Saint-Liboire", "10", 45.65068, -72.76348);
case 777: return new CityInfo("Saint-Lin-Laurentides", "10", 45.85008, -73.76588);
case 778: return new CityInfo("Saint-Marc-des-Carrières", "10", 46.68335, -72.0491);
case 779: return new CityInfo("Saint-Mathieu", "10", 45.31678, -73.51587);
case 780: return new CityInfo("Saint-Michel", "10", 45.56758, -73.62168);
case 781: return new CityInfo("Saint-Michel-des-Saints", "10", 46.67702, -73.91881);
case 782: return new CityInfo("Saint-Nazaire", "10", 48.58944, -71.55247);
case 783: return new CityInfo("Saint-Philippe-de-La Prairie", "10", 45.35723, -73.47706);
case 784: return new CityInfo("Saint-Pie", "10", 45.50277, -72.9089);
case 785: return new CityInfo("Saint-Pie-V", "10", 46.00351, -72.74689);
case 786: return new CityInfo("Saint-Pierre-les-Becquets", "10", 46.50005, -72.1991);
case 787: return new CityInfo("Saint-Polycarpe", "10", 45.30009, -74.29924);
case 788: return new CityInfo("Saint-Prime", "10", 48.58339, -72.33244);
case 789: return new CityInfo("Saint-Raphaël", "10", 46.25011, -76.01605);
case 790: return new CityInfo("Saint-Raymond", "10", 45.46698, -73.60948);
case 791: return new CityInfo("Saint-Rémi", "10", 45.26678, -73.61588);
case 792: return new CityInfo("Saint-Rémi-de-Tingwick", "10", 45.86677, -71.81581);
case 793: return new CityInfo("Saint-Sauveur", "10", 45.88686, -74.17943);
case 794: return new CityInfo("Saint-Sauveur-des-Monts", "10", 45.90008, -74.16591);
case 795: return new CityInfo("Saint-Théophile", "10", 45.93338, -70.48233);
case 796: return new CityInfo("Saint-Thomas", "10", 46.01677, -73.34915);
case 797: return new CityInfo("Saint-Tite", "10", 46.73336, -72.56581);
case 798: return new CityInfo("Saint-Victor", "10", 45.61118, -73.51527);
case 799: return new CityInfo("Saint-Zotique", "10", 45.25009, -74.24924);
case 800: return new CityInfo("Salaberry-de-Valleyfield", "10", 45.25008, -74.13253);
case 801: return new CityInfo("Salisbury", "04", 46.03905, -65.04628);
case 802: return new CityInfo("Salluit", "10", 62.20411, -75.64344);
case 803: return new CityInfo("Salmo", "02", 49.19986, -117.2689);
case 804: return new CityInfo("Salmon Arm", "02", 50.6998, -119.30237);
case 805: return new CityInfo("Saltair", "02", 48.94963, -123.76939);
case 806: return new CityInfo("Sarnia", "08", 42.97866, -82.40407);
case 807: return new CityInfo("Saskatoon", "11", 52.13238, -106.66892);
case 808: return new CityInfo("Sault Ste. Marie", "08", 46.51677, -84.33325);
case 809: return new CityInfo("Scotch Creek", "02", 50.89981, -119.4524);
case 810: return new CityInfo("Scott", "10", 49.81684, -74.58248);
case 811: return new CityInfo("Seaforth", "08", 43.55009, -81.39976);
case 812: return new CityInfo("Sechelt", "02", 49.47512, -123.75903);
case 813: return new CityInfo("Selkirk", "03", 50.1436, -96.88452);
case 814: return new CityInfo("Senneterre", "10", 48.39302, -77.23951);
case 815: return new CityInfo("Sept-Îles", "10", 50.20011, -66.38208);
case 816: return new CityInfo("Sexsmith", "01", 55.34998, -118.78602);
case 817: return new CityInfo("Shaunavon", "11", 49.65005, -108.4181);
case 818: return new CityInfo("Shawinigan", "10", 46.56675, -72.74913);
case 819: return new CityInfo("Shawville", "10", 45.60011, -76.4827);
case 820: return new CityInfo("Shediac", "04", 46.21981, -64.54107);
case 821: return new CityInfo("Shediac Cape", "04", 46.23344, -64.56545);
case 822: return new CityInfo("Shelburne", "07", 43.76325, -65.32355);
case 823: return new CityInfo("Shelburne", "08", 44.0787, -80.20408);
case 824: return new CityInfo("Shellbrook", "11", 53.21679, -106.40109);
case 825: return new CityInfo("Shenley", "10", 46.00007, -70.83234);
case 826: return new CityInfo("Sherbrooke", "10", 45.40008, -71.89908);
case 827: return new CityInfo("Sherwood Park", "01", 53.51684, -113.3187);
case 828: return new CityInfo("Sicamous", "02", 50.83312, -118.98565);
case 829: return new CityInfo("Simcoe", "08", 42.8334, -80.29967);
case 830: return new CityInfo("Sioux Lookout", "08", 50.06676, -91.98358);
case 831: return new CityInfo("Slave Lake", "01", 55.28344, -114.76896);
case 832: return new CityInfo("Smithers", "02", 54.78036, -127.17428);
case 833: return new CityInfo("Smiths Falls", "08", 44.90452, -76.02333);
case 834: return new CityInfo("Smoky Lake", "01", 54.11687, -112.46863);
case 835: return new CityInfo("Sooke", "02", 48.37463, -123.72762);
case 836: return new CityInfo("Sorel-Tracy", "10", 46.04178, -73.11358);
case 837: return new CityInfo("Souris", "09", 46.3501, -62.24862);
case 838: return new CityInfo("Souris", "03", 49.6172, -100.2612);
case 839: return new CityInfo("South Huron", "08", 43.31679, -81.51647);
case 840: return new CityInfo("South River", "08", 45.8334, -79.38293);
case 841: return new CityInfo("Spanish", "08", 46.20007, -82.34984);
case 842: return new CityInfo("Sparwood", "02", 49.73332, -114.88532);
case 843: return new CityInfo("Spirit River", "01", 55.78327, -118.83607);
case 844: return new CityInfo("Springdale", "05", 49.49995, -56.06492);
case 845: return new CityInfo("Springhill", "07", 45.65015, -64.04873);
case 846: return new CityInfo("Spruce Grove", "01", 53.53344, -113.91874);
case 847: return new CityInfo("Squamish", "02", 49.69925, -123.15631);
case 848: return new CityInfo("St. Adolphe", "03", 49.6744, -97.11124);
case 849: return new CityInfo("St. Albert", "01", 53.63344, -113.63533);
case 850: return new CityInfo("St. Anthony", "05", 51.37039, -55.59743);
case 851: return new CityInfo("St. Catharines", "08", 43.17126, -79.24267);
case 852: return new CityInfo("St. Claude", "03", 49.65861, -98.34244);
case 853: return new CityInfo("St. Clements", "08", 43.5168, -80.6497);
case 854: return new CityInfo("Steinbach", "03", 49.52579, -96.68451);
case 855: return new CityInfo("Stephenville", "05", 48.55001, -58.5818);
case 856: return new CityInfo("Stephenville Crossing", "05", 48.50001, -58.4318);
case 857: return new CityInfo("Stettler", "01", 52.31683, -112.71861);
case 858: return new CityInfo("St. François Xavier", "03", 49.9128, -97.54237);
case 859: return new CityInfo("Stirling", "08", 44.30012, -77.54948);
case 860: return new CityInfo("St. Jean Baptiste", "03", 49.26559, -97.34037);
case 861: return new CityInfo("Stonewall", "03", 50.13441, -97.32676);
case 862: return new CityInfo("Stoney Point", "08", 44.26681, -79.53292);
case 863: return new CityInfo("Stony Plain", "01", 53.53343, -114.00205);
case 864: return new CityInfo("St. Paul", "01", 53.98347, -111.28507);
case 865: return new CityInfo("Stratford", "08", 43.36679, -80.94972);
case 866: return new CityInfo("Strathmore", "01", 51.05011, -113.38523);
case 867: return new CityInfo("St. Thomas", "08", 42.77361, -81.18038);
case 868: return new CityInfo("Summerland", "02", 49.59977, -119.66911);
case 869: return new CityInfo("Summerside", "09", 46.39593, -63.78762);
case 870: return new CityInfo("Sundre", "01", 51.8001, -114.63532);
case 871: return new CityInfo("Sunnybrae", "02", 50.76651, -119.26907);
case 872: return new CityInfo("Sunny Corner", "04", 46.9334, -65.81545);
case 873: return new CityInfo("Surrey", "02", 49.10635, -122.82509);
case 874: return new CityInfo("Sussex", "04", 45.72266, -65.50663);
case 875: return new CityInfo("Sutton", "10", 45.10008, -72.61582);
case 876: return new CityInfo("Swan Hills", "01", 54.71681, -115.40226);
case 877: return new CityInfo("Swan River", "03", 52.1058, -101.26759);
case 878: return new CityInfo("Swift Current", "11", 50.28337, -107.80135);
case 879: return new CityInfo("Sylvan Lake", "01", 52.311, -114.08375);
case 880: return new CityInfo("Taber", "01", 49.78703, -112.14603);
case 881: return new CityInfo("Tavistock", "08", 43.31679, -80.83302);
case 882: return new CityInfo("Témiscaming", "10", 46.72122, -79.09712);
case 883: return new CityInfo("Temiskaming Shores", "08", 47.49376, -79.71529);
case 884: return new CityInfo("Terence Bay", "07", 44.47011, -63.72159);
case 885: return new CityInfo("Terrace", "02", 54.51634, -128.60345);
case 886: return new CityInfo("Terrasse-des-Pins", "10", 45.86449, -74.06627);
case 887: return new CityInfo("Terrebonne", "10", 45.70004, -73.64732);
case 888: return new CityInfo("The Pas", "03", 53.82509, -101.25413);
case 889: return new CityInfo("Thessalon", "08", 46.25006, -83.5666);
case 890: return new CityInfo("Thompson", "03", 55.7435, -97.85579);
case 891: return new CityInfo("Thorold", "08", 43.11682, -79.19958);
case 892: return new CityInfo("Three Hills", "01", 51.70012, -113.26863);
case 893: return new CityInfo("Thunder Bay", "08", 48.38202, -89.25018);
case 894: return new CityInfo("Thurso", "10", 45.6001, -75.24931);
case 895: return new CityInfo("Timmins", "08", 48.46686, -81.33312);
case 896: return new CityInfo("Tisdale", "11", 52.85002, -104.05096);
case 897: return new CityInfo("Tobermory", "08", 45.25007, -81.66647);
case 898: return new CityInfo("Tofield", "01", 53.36684, -112.66862);
case 899: return new CityInfo("Torbay", "05", 47.66659, -52.73135);
case 900: return new CityInfo("Toronto", "08", 43.70011, -79.4163);
case 901: return new CityInfo("Tottenham", "08", 44.02437, -79.80553);
case 902: return new CityInfo("Trail", "02", 49.09983, -117.70223);
case 903: return new CityInfo("Très-Saint-Rédempteur", "10", 45.43339, -74.38254);
case 904: return new CityInfo("Trois-Rivières", "10", 46.34515, -72.5477);
case 905: return new CityInfo("Truro", "07", 45.36685, -63.26538);
case 906: return new CityInfo("Tsawwassen", "02", 49.01667, -123.08333);
case 907: return new CityInfo("Tuktoyaktuk", "13", 69.44472, -133.03422);
case 908: return new CityInfo("Tumbler Ridge", "02", 55.13027, -120.99415);
case 909: return new CityInfo("Tweed", "08", 44.47512, -77.31616);
case 910: return new CityInfo("Two Hills", "01", 53.71686, -111.75181);
case 911: return new CityInfo("Tyndall", "03", 50.0828, -96.6589);
case 912: return new CityInfo("Ucluelet", "02", 48.94153, -125.54635);
case 913: return new CityInfo("Unity", "11", 52.45014, -109.16816);
case 914: return new CityInfo("Upper Island Cove", "05", 47.64989, -53.21478);
case 915: return new CityInfo("Upper Liard", "12", 60.04958, -128.90613);
case 916: return new CityInfo("Uxbridge", "08", 44.10012, -79.11628);
case 917: return new CityInfo("Valcourt", "10", 45.50008, -72.31581);
case 918: return new CityInfo("Val-David", "10", 46.03338, -74.21592);
case 919: return new CityInfo("Val-des-Monts", "10", 45.6501, -75.66604);
case 920: return new CityInfo("Val-d'Or", "10", 48.0974, -77.79737);
case 921: return new CityInfo("Valleyview", "01", 55.06673, -117.28585);
case 922: return new CityInfo("Val-Morin", "10", 46.00008, -74.18251);
case 923: return new CityInfo("Vancouver", "02", 49.24966, -123.11934);
case 924: return new CityInfo("Vanderhoof", "02", 54.01657, -124.01982);
case 925: return new CityInfo("Vanier", "08", 45.4399, -75.66498);
case 926: return new CityInfo("Varennes", "10", 45.68338, -73.43246);
case 927: return new CityInfo("Vaudreuil-Dorion", "10", 45.40008, -74.03251);
case 928: return new CityInfo("Vaughan", "08", 43.8361, -79.49827);
case 929: return new CityInfo("Vauxhall", "01", 50.06678, -112.11853);
case 930: return new CityInfo("Vegreville", "01", 53.50015, -112.05182);
case 931: return new CityInfo("Venise-en-Québec", "10", 45.08338, -73.13245);
case 932: return new CityInfo("Verchères", "10", 45.78338, -73.34916);
case 933: return new CityInfo("Vermilion", "01", 53.35409, -110.85849);
case 934: return new CityInfo("Vernon", "02", 50.26729, -119.27337);
case 935: return new CityInfo("Vernon", "02", 50.0261, -126.36157);
case 936: return new CityInfo("Victoria", "02", 48.4359, -123.35155);
case 937: return new CityInfo("Victoriaville", "10", 46.05007, -71.96579);
case 938: return new CityInfo("Viking", "01", 53.10014, -111.76844);
case 939: return new CityInfo("Ville-Marie", "10", 47.33345, -79.43297);
case 940: return new CityInfo("Vineland", "08", 43.15012, -79.3996);
case 941: return new CityInfo("Virden", "03", 49.8508, -100.93262);
case 942: return new CityInfo("Virgil", "08", 43.21682, -79.13288);
case 943: return new CityInfo("Virgin Arm-Carter's Cove", "05", 49.53322, -54.78145);
case 944: return new CityInfo("Vulcan", "01", 50.40008, -113.25189);
case 945: return new CityInfo("Wabana", "05", 47.63319, -52.94806);
case 946: return new CityInfo("Wadena", "11", 51.94999, -103.80102);
case 947: return new CityInfo("Wainwright", "01", 52.83482, -110.85342);
case 948: return new CityInfo("Wakefield", "10", 45.6668, -75.83265);
case 949: return new CityInfo("Walpole Island", "08", 42.6152, -82.51398);
case 950: return new CityInfo("Warman", "11", 52.31679, -106.56791);
case 951: return new CityInfo("Warren", "03", 50.13171, -97.54738);
case 952: return new CityInfo("Warwick", "10", 45.95007, -71.9824);
case 953: return new CityInfo("Wasaga Beach", "08", 44.5168, -80.01637);
case 954: return new CityInfo("Waskaganish", "10", 51.48333, -78.75);
case 955: return new CityInfo("Waswanipi", "10", 49.73346, -76.16604);
case 956: return new CityInfo("Waterford", "08", 42.9334, -80.28296);
case 957: return new CityInfo("Waterloo", "10", 45.35008, -72.51582);
case 958: return new CityInfo("Waterloo", "08", 43.4668, -80.51639);
case 959: return new CityInfo("Watford", "08", 42.95008, -81.88309);
case 960: return new CityInfo("Watrous", "11", 51.66677, -105.46788);
case 961: return new CityInfo("Watson Lake", "12", 60.06349, -128.70893);
case 962: return new CityInfo("Waverley", "07", 44.78345, -63.5987);
case 963: return new CityInfo("Wawa", "08", 47.98877, -84.77411);
case 964: return new CityInfo("Welcome Beach", "02", 49.47959, -123.89239);
case 965: return new CityInfo("Welland", "08", 42.98342, -79.24958);
case 966: return new CityInfo("Wellesley", "08", 43.47691, -80.76209);
case 967: return new CityInfo("Wells", "04", 45.39274, -65.92313);
case 968: return new CityInfo("Wembley", "01", 55.14995, -119.13602);
case 969: return new CityInfo("West End", "02", 49.28333, -123.13333);
case 970: return new CityInfo("Westlock", "01", 54.15016, -113.86876);
case 971: return new CityInfo("West Lorne", "08", 42.60009, -81.59976);
case 972: return new CityInfo("Westmount", "10", 45.48341, -73.59918);
case 973: return new CityInfo("Wetaskiwin", "01", 52.96683, -113.36869);
case 974: return new CityInfo("Weyburn", "11", 49.66675, -103.85109);
case 975: return new CityInfo("Whistler", "02", 50.11817, -122.95396);
case 976: return new CityInfo("White City", "11", 50.43338, -104.36778);
case 977: return new CityInfo("Whitecourt", "01", 54.15015, -115.68548);
case 978: return new CityInfo("Whitehorse", "12", 60.71611, -135.05375);
case 979: return new CityInfo("White Lake", "02", 50.88311, -119.30238);
case 980: return new CityInfo("White Rock", "02", 49.01636, -122.8026);
case 981: return new CityInfo("Wilkie", "11", 52.41683, -108.70142);
case 982: return new CityInfo("Williams Lake", "02", 52.14153, -122.14451);
case 983: return new CityInfo("Winchester", "08", 45.0834, -75.34933);
case 984: return new CityInfo("Windsor", "07", 44.98345, -64.13204);
case 985: return new CityInfo("Windsor", "10", 45.56678, -71.99909);
case 986: return new CityInfo("Windsor", "08", 42.30008, -83.01654);
case 987: return new CityInfo("Wingham", "08", 43.88793, -81.31145);
case 988: return new CityInfo("Winkler", "03", 49.1817, -97.94104);
case 989: return new CityInfo("Winnipeg", "03", 49.8844, -97.14704);
case 990: return new CityInfo("Wolfville", "07", 45.08345, -64.36546);
case 991: return new CityInfo("Woodstock", "08", 43.13339, -80.7497);
case 992: return new CityInfo("Wynndel", "02", 49.18, -116.5525);
case 993: return new CityInfo("Wynyard", "11", 51.76674, -104.18436);
case 994: return new CityInfo("Yamachiche", "10", 46.26676, -72.83243);
case 995: return new CityInfo("Yarmouth", "07", 43.83345, -66.11557);
case 996: return new CityInfo("Yellowknife", "13", 62.45411, -114.37248);
case 997: return new CityInfo("Yorkton", "11", 51.2167, -102.46766);
case 998: return new CityInfo("Youbou", "02", 48.86632, -124.20271);
case 999: return new CityInfo("Zephyr", "08", 44.20011, -79.2663);
case 1000: return new CityInfo("Lac-des-Aigles", "10", 47.99038, -68.67777);
case 1001: return new CityInfo("Beauceville", "10", 46.21785, -70.77873);
case 1002: return new CityInfo("Halifax", "07", 44.6464, -63.57291);
case 1003: return new CityInfo("St. John's", "05", 47.56494, -52.70931);
case 1004: return new CityInfo("Beaupré", "10", 47.04428, -70.89529);
case 1005: return new CityInfo("Château-Richer", "10", 46.96031, -71.03219);
case 1006: return new CityInfo("Kamouraska", "10", 47.56593, -69.86631);
case 1007: return new CityInfo("Québec", "10", 46.81228, -71.21454);
case 1008: return new CityInfo("L'Ange-Gardien", "10", 46.91976, -71.08253);
case 1009: return new CityInfo("Lévis", "10", 46.80326, -71.17793);
case 1010: return new CityInfo("Montmagny", "10", 46.98043, -70.55493);
case 1011: return new CityInfo("Neuville", "10", 46.69823, -71.58275);
case 1012: return new CityInfo("Portneuf", "10", 46.69058, -71.89011);
case 1013: return new CityInfo("Rimouski", "10", 48.44879, -68.52396);
case 1014: return new CityInfo("Rivière-du-Loup", "10", 47.82699, -69.54243);
case 1015: return new CityInfo("Saint-André", "10", 47.67833, -69.72229);
case 1016: return new CityInfo("Sydney", "07", 46.1351, -60.1831);
case 1017: return new CityInfo("Tofino", "02", 49.15314, -125.90744);
case 1018: return new CityInfo("Jasper", "01", 52.87946, -118.08041);
case 1019: return new CityInfo("L'Ancienne-Lorette", "10", 46.79392, -71.35191);
case 1020: return new CityInfo("Edmundston", "04", 47.3737, -68.32512);
case 1021: return new CityInfo("St-Jean-Port-Joli", "10", 47.21418, -70.26969);
case 1022: return new CityInfo("Saint-Georges", "10", 46.11353, -70.66526);
case 1023: return new CityInfo("Sainte Catherine de la Jacques Cartier", "10", 46.85244, -71.62056);
case 1024: return new CityInfo("Tadoussac", "10", 48.15001, -69.71667);
case 1025: return new CityInfo("Baie-Saint-Paul", "10", 47.44109, -70.49858);
case 1026: return new CityInfo("Carleton-sur-Mer", "10", 48.10749, -66.128);
case 1027: return new CityInfo("Hopedale", "05", 55.46737, -60.20319);
case 1028: return new CityInfo("Cacouna", "10", 47.91657, -69.50054);
case 1029: return new CityInfo("Campbellton", "04", 48.00751, -66.67272);
case 1030: return new CityInfo("Bathurst", "04", 47.61814, -65.65112);
case 1031: return new CityInfo("Matane", "10", 48.82857, -67.52197);
case 1032: return new CityInfo("Paris", "08", 43.2, -80.38333);
case 1033: return new CityInfo("Buckingham", "10", 45.58563, -75.4208);
case 1034: return new CityInfo("Amqui", "10", 48.46382, -67.43134);
case 1035: return new CityInfo("Miscou", "04", 47.94395, -64.57111);
case 1036: return new CityInfo("Dawson City", "12", 64.06013, -139.43328);
case 1037: return new CityInfo("Deline", "13", 65.19844, -123.40565);
case 1038: return new CityInfo("Weymontachie", "10", 47.8994, -73.7772);
case 1039: return new CityInfo("Chandler", "10", 48.34935, -64.67926);
case 1040: return new CityInfo("Murdochville", "10", 48.9583, -65.5006);
case 1041: return new CityInfo("Bonaventure", "10", 48.04573, -65.49259);
case 1042: return new CityInfo("New-Richmond", "10", 48.16059, -65.85823);
case 1043: return new CityInfo("Thetford-Mines", "10", 46.09371, -71.30539);
case 1044: return new CityInfo("New Carlisle", "10", 48.00956, -65.33621);
case 1045: return new CityInfo("Carleton", "10", 48.09838, -66.10036);
case 1046: return new CityInfo("Cabano", "10", 47.68065, -68.8781);
case 1047: return new CityInfo("Sacré-Coeur", "10", 48.2297, -69.80061);
case 1048: return new CityInfo("Forestville", "10", 48.73808, -69.08478);
case 1049: return new CityInfo("Mont-Joli", "10", 48.58388, -68.19214);
case 1050: return new CityInfo("Lillooet", "02", 50.6856, -121.942);
case 1051: return new CityInfo("Saint-Anselme", "10", 46.62922, -70.9734);
case 1052: return new CityInfo("La Malbaie", "10", 47.654, -70.15268);
case 1053: return new CityInfo("Sainte-Marie", "10", 46.43401, -71.01168);
case 1054: return new CityInfo("Plessisville", "10", 46.21856, -71.76201);
case 1055: return new CityInfo("Maliotenam", "10", 50.21119, -66.18164);
case 1056: return new CityInfo("Scarborough", "08", 43.77223, -79.25666);
case 1057: return new CityInfo("Les Escoumins", "10", 48.35191, -69.40724);
case 1058: return new CityInfo("Churchill Falls", "05", 53.53153, -64.00849);
case 1059: return new CityInfo("Fossambault-sur-le-Lac", "10", 46.87662, -71.61541);
case 1060: return new CityInfo("Cole Harbour", "07", 44.67244, -63.47506);
case 1061: return new CityInfo("Okanagan", "02", 50.36386, -119.34997);
case 1062: return new CityInfo("West Kelowna", "02", 49.8625, -119.58333);
case 1063: return new CityInfo("Saint-Mathieu-de-Rioux", "10", 48.18317, -68.98693);
case 1064: return new CityInfo("St. George", "08", 43.24495, -80.25144);
case 1065: return new CityInfo("Tracadie-Sheila", "04", 47.51444, -64.91806);
case 1066: return new CityInfo("Sydney Mines", "07", 46.23669, -60.21767);
case 1067: return new CityInfo("Hartland", "04", 46.29986, -67.51669);
case 1068: return new CityInfo("Jonquière", "10", 48.41648, -71.24884);
case 1069: return new CityInfo("Cap-Santé", "10", 46.67159, -71.78812);
case 1070: return new CityInfo("Saint-Augustin-de-Desmaures", "10", 46.74064, -71.45131);
case 1071: return new CityInfo("Donnacona", "10", 46.68042, -71.7239);
case 1072: return new CityInfo("La Pocatière", "10", 47.36733, -70.03484);
case 1073: return new CityInfo("Saint-Joseph-de-Beauce", "10", 46.3, -70.86667);
case 1074: return new CityInfo("Metabetchouan-Lac-a-la-Croix", "10", 48.41, -71.78);
case 1075: return new CityInfo("Ladner", "02", 49.08938, -123.08241);
case 1076: return new CityInfo("Bell Acres", "02", 49.07791, -121.86756);
case 1077: return new CityInfo("Baker Trails", "02", 49.08668, -121.93743);
case 1078: return new CityInfo("Walnut Grove", "02", 49.16473, -122.64042);
case 1079: return new CityInfo("Aldergrove", "02", 49.05801, -122.47087);
case 1080: return new CityInfo("Saint-Léonard", "04", 47.16317, -67.9246);
case 1081: return new CityInfo("Harrison Brook", "04", 47.21304, -67.92847);
case 1082: return new CityInfo("Omemee", "08", 44.29897, -78.55989);
case 1083: return new CityInfo("Patrick Fogarty Catholic Secondary School", "08", 44.62552, -79.43095);
case 1084: return new CityInfo("Cowichan Bay", "02", 48.73366, -123.61739);
case 1085: return new CityInfo("East York", "08", 43.69053, -79.32794);
case 1086: return new CityInfo("Napanee Downtown", "08", 44.24832, -76.95069);
case 1087: return new CityInfo("Skatepark", "08", 44.25122, -76.94424);
case 1088: return new CityInfo("Bragg Creek", "01", 50.95129, -114.56028);
case 1089: return new CityInfo("Breakeyville", "10", 46.68037, -71.22327);
case 1090: return new CityInfo("Saint-Antoine-de-Tilly", "10", 46.66346, -71.57335);
case 1091: return new CityInfo("Ancaster", "08", 43.21806, -79.98716);
case 1092: return new CityInfo("Shannon", "10", 46.88026, -71.51464);
case 1093: return new CityInfo("Saint-Henri", "10", 46.69314, -71.06927);
case 1094: return new CityInfo("Saint-Lambert-de-Lauzon", "10", 46.58624, -71.20892);
case 1095: return new CityInfo("Pohénégamook", "10", 47.46315, -69.22666);
case 1096: return new CityInfo("Pont-Rouge", "10", 46.75468, -71.69566);
case 1097: return new CityInfo("Princeville", "10", 46.17163, -71.87462);
case 1098: return new CityInfo("West Vancouver", "02", 49.36672, -123.16652);
case 1099: return new CityInfo("Saint-Siméon", "10", 47.84431, -69.87837);
case 1100: return new CityInfo("L'Orignal", "08", 45.6198, -74.6915);
case 1101: return new CityInfo("Willowdale", "08", 43.76672, -79.39909);
case 1102: return new CityInfo("Florenceville-Bristol", "04", 46.44353, -67.61536);
case 1103: return new CityInfo("Saint-Pascal", "10", 47.51813, -69.80301);
case 1104: return new CityInfo("Vallée-Jonction", "10", 46.37441, -70.91881);
case 1105: return new CityInfo("East Broughton", "10", 46.21358, -71.07674);
case 1106: return new CityInfo("Maria", "10", 48.1749, -65.98595);
case 1107: return new CityInfo("Shilo", "03", 49.80509, -99.63175);
case 1108: return new CityInfo("Saint-Antonin", "10", 47.7607, -69.47745);
case 1109: return new CityInfo("Lower Sackville", "07", 44.77599, -63.67865);
case 1110: return new CityInfo("le Plateau", "10", 45.43514, -75.7803);
case 1111: return new CityInfo("Wild Rose", "01", 53.4708, -113.38119);
case 1112: return new CityInfo("Silver Berry", "01", 53.45787, -113.3817);
case 1113: return new CityInfo("Laurel", "01", 53.44667, -113.38197);
case 1114: return new CityInfo("Tamarack", "01", 53.46441, -113.36235);
case 1115: return new CityInfo("Larkspur", "01", 53.47942, -113.38142);
case 1116: return new CityInfo("Hérouxville", "10", 46.66617, -72.62512);
case 1117: return new CityInfo("Saint-Norbert", "10", 46.16949, -73.31494);
case 1118: return new CityInfo("Sainte-Élisabeth", "10", 46.09502, -73.35176);
case 1119: return new CityInfo("Maisonnette", "04", 47.82364, -64.99838);
case 1120: return new CityInfo("Saint-Basile", "04", 47.39149, -68.2711);
case 1121: return new CityInfo("Shippagan", "04", 47.74424, -64.70804);
case 1122: return new CityInfo("Mill Woods Town Centre", "01", 53.45639, -113.42751);
case 1123: return new CityInfo("Fogo Island", "05", 49.71649, -54.16981);
case 1124: return new CityInfo("Clair", "04", 47.25407, -68.60589);
case 1125: return new CityInfo("Behchokǫ̀", "13", 62.8025, -116.04639);
case 1126: return new CityInfo("Wendover", "08", 45.57275, -75.12757);
case 1127: return new CityInfo("La Haute-Saint-Charles", "10", 46.89028, -71.37222);
case 1128: return new CityInfo("Salt Spring Island", "02", 48.81852, -123.49061);
case 1129: return new CityInfo("Petit-Rocher-Nord", "04", 47.80925, -65.73246);
case 1130: return new CityInfo("Saint-Simon", "04", 47.73657, -64.84123);
case 1131: return new CityInfo("Sainte-Cécile", "04", 47.85468, -64.66494);
case 1132: return new CityInfo("Dunlop", "04", 47.68713, -65.73386);
case 1133: return new CityInfo("Nicholas Denys", "04", 47.69863, -65.88047);
case 1134: return new CityInfo("North Tetagouche", "04", 47.63537, -65.75864);
case 1135: return new CityInfo("Robertville", "04", 47.69624, -65.77344);
case 1136: return new CityInfo("Saint-Sauveur", "04", 47.52955, -65.26898);
case 1137: return new CityInfo("Saumarez", "04", 47.50019, -64.93902);
case 1138: return new CityInfo("Leech", "04", 47.45314, -64.98185);
case 1139: return new CityInfo("Fallingbrook", "09", 45.47558, -75.48401);
case 1140: return new CityInfo("Springbrook", "01", 52.1792, -113.87981);
case 1141: return new CityInfo("Westlake", "01", 55.22228, -118.80415);
case 1142: return new CityInfo("Grand Centre", "01", 54.41628, -110.21304);
case 1143: return new CityInfo("Heritage Pointe", "01", 50.84213, -114.00493);
case 1144: return new CityInfo("Aldergrove East", "02", 49.05593, -122.42299);
case 1145: return new CityInfo("Duck Lake", "02", 50.0088, -119.39672);
case 1146: return new CityInfo("Fairwinds", "02", 49.27588, -124.12782);
case 1147: return new CityInfo("Cross Lake 19A", "03", 54.65135, -97.76848);
case 1148: return new CityInfo("McEwen", "04", 46.1452, -64.78615);
case 1149: return new CityInfo("Starlight Village", "04", 45.88308, -66.76905);
case 1150: return new CityInfo("Hayes Subdivision", "07", 45.05519, -64.58795);
case 1151: return new CityInfo("Eskasoni 3", "07", 45.94522, -60.61617);
case 1152: return new CityInfo("Golden", "08", 51.05917, -93.73568);
case 1153: return new CityInfo("Valley East", "08", 46.66773, -81.00028);
case 1154: return new CityInfo("Haliburton Village", "08", 45.05154, -78.52245);
case 1155: return new CityInfo("Luceville", "10", 48.54498, -68.39658);
case 1156: return new CityInfo("Manawan", "10", 47.22029, -74.38606);
case 1157: return new CityInfo("Hauterive", "10", 49.19572, -68.25813);
case 1158: return new CityInfo("Le Bic", "10", 48.37549, -68.69415);
case 1159: return new CityInfo("Parc-Boutin", "10", 45.29209, -73.26154);
case 1160: return new CityInfo("North Oyster/Yellow Point", "02", 49.04807, -123.83395);
case 1161: return new CityInfo("Baie Ste. Anne", "04", 47.05231, -64.95355);
case 1162: return new CityInfo("South Pender Harbour", "02", 49.62202, -124.02484);
case 1163: return new CityInfo("Fundy Bay", "04", 44.741, -66.76041);
case 1164: return new CityInfo("Denman Island Trust Area", "02", 49.55189, -124.79881);
case 1165: return new CityInfo("Shediac Bridge-Shediac River", "04", 46.26886, -64.60047);
case 1166: return new CityInfo("Saint-Pacôme", "10", 47.40457, -69.95025);
case 1167: return new CityInfo("Weedon Centre", "10", 45.70802, -71.45986);
case 1168: return new CityInfo("Six Mile", "02", 48.45767, -123.46088);
case 1169: return new CityInfo("Greater Lakeburn", "04", 46.07651, -64.66818);
case 1170: return new CityInfo("Saint-Flavien", "10", 46.51187, -71.59648);
case 1171: return new CityInfo("Mount Currie 6", "02", 50.32937, -122.66395);
case 1172: return new CityInfo("Fairisle", "04", 47.27888, -65.12442);
case 1173: return new CityInfo("Carlisle Road", "04", 45.98808, -66.75876);
case 1174: return new CityInfo("Brantville", "04", 47.36922, -64.97122);
case 1175: return new CityInfo("Tabusintac", "04", 47.3278, -65.01139);
case 1176: return new CityInfo("Saint Irénée and Alderwood", "04", 47.49887, -64.98691);
case 1177: return new CityInfo("Pepper Creek", "04", 45.95286, -66.59038);
case 1178: return new CityInfo("Wedgewood", "01", 55.12245, -118.77316);
case 1179: return new CityInfo("Haut-Sheila", "04", 47.74639, -64.91151);
case 1180: return new CityInfo("Englishman River South", "02", 49.28209, -124.28164);
case 1181: return new CityInfo("Evergreen Park", "04", 46.11307, -64.86358);
case 1182: return new CityInfo("Sion", "02", 49.01682, -118.4921);
case 1183: return new CityInfo("Skowkale 10", "02", 49.13631, -121.94244);
case 1184: return new CityInfo("Lorne", "04", 47.8738, -66.12687);
case 1185: return new CityInfo("Hatzic Island", "02", 49.16446, -122.23755);
case 1186: return new CityInfo("Saprae Creek", "01", 56.6515, -111.1426);
case 1187: return new CityInfo("Saint-Bernard-de-l'Île-aux-Coudres", "10", 47.0686, -70.5417);
case 1188: return new CityInfo("Cherry Point", "02", 48.71216, -123.55872);
default: return new CityInfo("Fox Mountain", "02", 52.14438, -122.1121);

                                    }                                        
                                }
                            
                        }
                    }
                