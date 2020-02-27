
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
                                    public const string Country = "TZ";
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
                            
                                        var cur = (Math.Abs(-6.16394 - lat) + Math.Abs(39.19793 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-5.05589 - lat) + Math.Abs(39.72938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.10806 - lat) + Math.Abs(32.93472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.00667 - lat) + Math.Abs(39.29849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.28333 - lat) + Math.Abs(31.52583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.4 - lat) + Math.Abs(39.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.10361 - lat) + Math.Abs(30.39111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.98598 - lat) + Math.Abs(38.75795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.16667 - lat) + Math.Abs(32.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.49194 - lat) + Math.Abs(31.96389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.1 - lat) + Math.Abs(31.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.68333 - lat) + Math.Abs(33 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.36667 - lat) + Math.Abs(36.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.06667 - lat) + Math.Abs(32.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.93333 - lat) + Math.Abs(33.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.3 - lat) + Math.Abs(32.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.06667 - lat) + Math.Abs(32.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.25 - lat) + Math.Abs(33.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.88333 - lat) + Math.Abs(33.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.35 - lat) + Math.Abs(34.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.06893 - lat) + Math.Abs(39.09875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.01622 - lat) + Math.Abs(32.82663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.96667 - lat) + Math.Abs(31.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.85 - lat) + Math.Abs(38.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.51667 - lat) + Math.Abs(33.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.36667 - lat) + Math.Abs(33.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.43333 - lat) + Math.Abs(39.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.25367 - lat) + Math.Abs(34.47596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.81629 - lat) + Math.Abs(34.74358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.63333 - lat) + Math.Abs(32.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.66393 - lat) + Math.Abs(33.42118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.36667 - lat) + Math.Abs(34.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.75 - lat) + Math.Abs(34.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.06667 - lat) + Math.Abs(37.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.7175 - lat) + Math.Abs(30.6325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.7 - lat) + Math.Abs(34.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5 - lat) + Math.Abs(34.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.33333 - lat) + Math.Abs(36.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.42526 - lat) + Math.Abs(38.97473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.55 - lat) + Math.Abs(33.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.21667 - lat) + Math.Abs(33.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.55 - lat) + Math.Abs(33.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.9 - lat) + Math.Abs(34.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.18333 - lat) + Math.Abs(33.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.60333 - lat) + Math.Abs(31.14139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.63333 - lat) + Math.Abs(33.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.14389 - lat) + Math.Abs(31.39472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.79833 - lat) + Math.Abs(31.55111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.95 - lat) + Math.Abs(30.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.33333 - lat) + Math.Abs(36.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.34917 - lat) + Math.Abs(34.77167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.10917 - lat) + Math.Abs(31.04194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.96667 - lat) + Math.Abs(33.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.23973 - lat) + Math.Abs(35.48747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.75 - lat) + Math.Abs(38.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.51222 - lat) + Math.Abs(30.65583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.4 - lat) + Math.Abs(39.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.36667 - lat) + Math.Abs(38.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.6 - lat) + Math.Abs(34.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.13333 - lat) + Math.Abs(33.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.46667 - lat) + Math.Abs(35.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.51667 - lat) + Math.Abs(31.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.55116 - lat) + Math.Abs(36.78377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.11667 - lat) + Math.Abs(33.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.2 - lat) + Math.Abs(36.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.15 - lat) + Math.Abs(37.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.55 - lat) + Math.Abs(33.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.51667 - lat) + Math.Abs(32.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.8 - lat) + Math.Abs(38.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.55 - lat) + Math.Abs(33.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.25 - lat) + Math.Abs(38.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.5 - lat) + Math.Abs(33.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.98333 - lat) + Math.Abs(32.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.96667 - lat) + Math.Abs(34.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.83972 - lat) + Math.Abs(31.65444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.16667 - lat) + Math.Abs(38.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.85 - lat) + Math.Abs(34.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.68333 - lat) + Math.Abs(33.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.01667 - lat) + Math.Abs(34.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.35 - lat) + Math.Abs(35.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.55 - lat) + Math.Abs(34.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.78333 - lat) + Math.Abs(36.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.38333 - lat) + Math.Abs(39.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.53333 - lat) + Math.Abs(37.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.05 - lat) + Math.Abs(36.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.35 - lat) + Math.Abs(36.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.34379 - lat) + Math.Abs(31.06951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.35 - lat) + Math.Abs(37.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.82102 - lat) + Math.Abs(37.66122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.3 - lat) + Math.Abs(36.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9 - lat) + Math.Abs(32.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.8 - lat) + Math.Abs(35.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.78333 - lat) + Math.Abs(34.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.7 - lat) + Math.Abs(38.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.93333 - lat) + Math.Abs(38.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.11799 - lat) + Math.Abs(39.20782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.87506 - lat) + Math.Abs(39.25523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.83 - lat) + Math.Abs(29.65806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.85 - lat) + Math.Abs(33.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3 - lat) + Math.Abs(33.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.40409 - lat) + Math.Abs(36.98309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.96667 - lat) + Math.Abs(39.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.28333 - lat) + Math.Abs(32.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.95 - lat) + Math.Abs(34.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.90577 - lat) + Math.Abs(39.21047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.85 - lat) + Math.Abs(35.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.56667 - lat) + Math.Abs(36.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.9 - lat) + Math.Abs(33.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.8 - lat) + Math.Abs(38.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.8 - lat) + Math.Abs(38.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.38333 - lat) + Math.Abs(34.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.98333 - lat) + Math.Abs(33.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.3 - lat) + Math.Abs(31.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.68333 - lat) + Math.Abs(33.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.63333 - lat) + Math.Abs(32.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.33333 - lat) + Math.Abs(33.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.05 - lat) + Math.Abs(38.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.1988 - lat) + Math.Abs(38.78478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.98333 - lat) + Math.Abs(33.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.93333 - lat) + Math.Abs(36.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.56667 - lat) + Math.Abs(34.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.13333 - lat) + Math.Abs(33.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.73333 - lat) + Math.Abs(38.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.73333 - lat) + Math.Abs(35.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.85 - lat) + Math.Abs(34.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.36667 - lat) + Math.Abs(37.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.15 - lat) + Math.Abs(38.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.45 - lat) + Math.Abs(39.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.68333 - lat) + Math.Abs(36.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.93333 - lat) + Math.Abs(35.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.58333 - lat) + Math.Abs(33.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.01667 - lat) + Math.Abs(35.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.8 - lat) + Math.Abs(39.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.23333 - lat) + Math.Abs(38.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.37697 - lat) + Math.Abs(37.37373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.25 - lat) + Math.Abs(35.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.59833 - lat) + Math.Abs(30.50194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.13333 - lat) + Math.Abs(32.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.78333 - lat) + Math.Abs(38.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.38333 - lat) + Math.Abs(36.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.45 - lat) + Math.Abs(38.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.73319 - lat) + Math.Abs(36.69773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.76667 - lat) + Math.Abs(37.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.78333 - lat) + Math.Abs(37.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.45 - lat) + Math.Abs(33.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.56667 - lat) + Math.Abs(32.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.58333 - lat) + Math.Abs(33.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.25222 - lat) + Math.Abs(31.42028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.76667 - lat) + Math.Abs(37.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.2 - lat) + Math.Abs(36.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.9 - lat) + Math.Abs(35.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.95 - lat) + Math.Abs(39.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.13333 - lat) + Math.Abs(39.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.13333 - lat) + Math.Abs(39.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.17307 - lat) + Math.Abs(33.54152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.98957 - lat) + Math.Abs(39.3768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.13333 - lat) + Math.Abs(37.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.61667 - lat) + Math.Abs(33.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.08333 - lat) + Math.Abs(34.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.9 - lat) + Math.Abs(39.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.43622 - lat) + Math.Abs(37.70337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.91667 - lat) + Math.Abs(37.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.41667 - lat) + Math.Abs(30.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.26667 - lat) + Math.Abs(34.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.88333 - lat) + Math.Abs(35.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.28333 - lat) + Math.Abs(36.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.78333 - lat) + Math.Abs(37.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.83333 - lat) + Math.Abs(36.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.91446 - lat) + Math.Abs(39.66204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.85 - lat) + Math.Abs(34.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.85 - lat) + Math.Abs(39.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.46667 - lat) + Math.Abs(38.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.87694 - lat) + Math.Abs(29.62667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.60361 - lat) + Math.Abs(37.00438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.69916 - lat) + Math.Abs(36.95722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.58639 - lat) + Math.Abs(30.72028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.72178 - lat) + Math.Abs(38.93749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.3 - lat) + Math.Abs(36.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.15 - lat) + Math.Abs(33.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.71667 - lat) + Math.Abs(36.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.76667 - lat) + Math.Abs(38.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.23333 - lat) + Math.Abs(33.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.02028 - lat) + Math.Abs(31.89583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.39972 - lat) + Math.Abs(31.50028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.52483 - lat) + Math.Abs(35.3849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.4 - lat) + Math.Abs(31.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.57667 - lat) + Math.Abs(30.1025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.85 - lat) + Math.Abs(32.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.82052 - lat) + Math.Abs(30.43887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.33333 - lat) + Math.Abs(35.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.15 - lat) + Math.Abs(33.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.61861 - lat) + Math.Abs(31.62 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.06056 - lat) + Math.Abs(31.79361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.28278 - lat) + Math.Abs(30.96417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.83333 - lat) + Math.Abs(32.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.63861 - lat) + Math.Abs(30.46778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.2 - lat) + Math.Abs(35.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.4 - lat) + Math.Abs(33.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.7 - lat) + Math.Abs(34.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2 - lat) + Math.Abs(34.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.9 - lat) + Math.Abs(32.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.76667 - lat) + Math.Abs(35.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.48333 - lat) + Math.Abs(33.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.71667 - lat) + Math.Abs(32.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.6766 - lat) + Math.Abs(36.03658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.66667 - lat) + Math.Abs(34.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.9 - lat) + Math.Abs(34.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.25 - lat) + Math.Abs(33.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.95618 - lat) + Math.Abs(38.97164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.13333 - lat) + Math.Abs(34.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.85 - lat) + Math.Abs(33.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4 - lat) + Math.Abs(33.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.28333 - lat) + Math.Abs(33.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.56667 - lat) + Math.Abs(34.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.13333 - lat) + Math.Abs(36.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.5 - lat) + Math.Abs(37.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.8725 - lat) + Math.Abs(32.2325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.15 - lat) + Math.Abs(36.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.9 - lat) + Math.Abs(39.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.26667 - lat) + Math.Abs(35.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.41667 - lat) + Math.Abs(35.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.11667 - lat) + Math.Abs(34.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.06667 - lat) + Math.Abs(35.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.17221 - lat) + Math.Abs(35.73947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.82349 - lat) + Math.Abs(39.26951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.21667 - lat) + Math.Abs(35.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-8.85637 - lat) + Math.Abs(34.02393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.63778 - lat) + Math.Abs(31.76694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.41667 - lat) + Math.Abs(38.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.63784 - lat) + Math.Abs(38.35396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.58333 - lat) + Math.Abs(31.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.24586 - lat) + Math.Abs(39.76659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.76667 - lat) + Math.Abs(33.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.02361 - lat) + Math.Abs(31.87472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-7.63369 - lat) + Math.Abs(39.05818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.05 - lat) + Math.Abs(33.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.95 - lat) + Math.Abs(32.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.33167 - lat) + Math.Abs(31.81222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.23333 - lat) + Math.Abs(32.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-1.59111 - lat) + Math.Abs(31.14028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.87056 - lat) + Math.Abs(30.52806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.63194 - lat) + Math.Abs(31.30889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.36667 - lat) + Math.Abs(35.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.23333 - lat) + Math.Abs(35.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-2.8 - lat) + Math.Abs(33.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.44222 - lat) + Math.Abs(38.90422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-4.21667 - lat) + Math.Abs(35.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.36667 - lat) + Math.Abs(36.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.3 - lat) + Math.Abs(35.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.75 - lat) + Math.Abs(39.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.68333 - lat) + Math.Abs(35.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.06667 - lat) + Math.Abs(38.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.33333 - lat) + Math.Abs(39.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.95 - lat) + Math.Abs(39.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.68333 - lat) + Math.Abs(39.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.8 - lat) + Math.Abs(39.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.9 - lat) + Math.Abs(38.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.38333 - lat) + Math.Abs(39.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.83333 - lat) + Math.Abs(39.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.95 - lat) + Math.Abs(39.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.3725 - lat) + Math.Abs(38.76251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.26667 - lat) + Math.Abs(40.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.3 - lat) + Math.Abs(39.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.10526 - lat) + Math.Abs(39.61859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.93333 - lat) + Math.Abs(35.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10 - lat) + Math.Abs(38.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.28333 - lat) + Math.Abs(34.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.75 - lat) + Math.Abs(34.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.36667 - lat) + Math.Abs(38.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.71667 - lat) + Math.Abs(38.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.58333 - lat) + Math.Abs(35.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.46667 - lat) + Math.Abs(34.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.86667 - lat) + Math.Abs(39.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.4 - lat) + Math.Abs(40.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.81667 - lat) + Math.Abs(39.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.56667 - lat) + Math.Abs(38.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.9 - lat) + Math.Abs(39.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.08333 - lat) + Math.Abs(34.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-9.99709 - lat) + Math.Abs(39.71649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.65 - lat) + Math.Abs(39.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.71667 - lat) + Math.Abs(39.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.8 - lat) + Math.Abs(35.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.88333 - lat) + Math.Abs(38.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-3.56182 - lat) + Math.Abs(36.97895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-5.72651 - lat) + Math.Abs(39.2987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.17526 - lat) + Math.Abs(35.79266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-6.30122 - lat) + Math.Abs(37.44398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zanzibar", "25", -6.16394, 39.19793);
case 1: return new CityInfo("Wete", "13", -5.05589, 39.72938);
case 2: return new CityInfo("Vwawa", "32", -9.10806, 32.93472);
case 3: return new CityInfo("Vikindu", "02", -7.00667, 39.29849);
case 4: return new CityInfo("Uyovu", "28", -3.28333, 31.52583);
case 5: return new CityInfo("Uwelini", "20", -5.4, 39.68333);
case 6: return new CityInfo("Uvinza", "05", -5.10361, 30.39111);
case 7: return new CityInfo("Utete", "02", -7.98598, 38.75795);
case 8: return new CityInfo("Usoke", "17", -5.16667, 32.35);
case 9: return new CityInfo("Ushirombo", "28", -3.49194, 31.96389);
case 10: return new CityInfo("Usevia", "29", -7.1, 31.23333);
case 11: return new CityInfo("Usagara", "12", -2.68333, 33);
case 12: return new CityInfo("Usa River", "26", -3.36667, 36.85);
case 13: return new CityInfo("Urambo", "17", -5.06667, 32.05);
case 14: return new CityInfo("Ulenje", "09", -8.93333, 33.68333);
case 15: return new CityInfo("Tunduma", "32", -9.3, 32.76667);
case 16: return new CityInfo("Tumbi", "17", -5.06667, 32.73333);
case 17: return new CityInfo("Tukuyu", "09", -9.25, 33.65);
case 18: return new CityInfo("Tinde", "15", -3.88333, 33.2);
case 19: return new CityInfo("Tarime", "08", -1.35, 34.36667);
case 20: return new CityInfo("Tanga", "18", -5.06893, 39.09875);
case 21: return new CityInfo("Tabora", "17", -5.01622, 32.82663);
case 22: return new CityInfo("Sumbawanga", "24", -7.96667, 31.61667);
case 23: return new CityInfo("Soni", "18", -4.85, 38.36667);
case 24: return new CityInfo("Songwa", "15", -3.51667, 33.51667);
case 25: return new CityInfo("Somanda", "31", -3.36667, 33.95);
case 26: return new CityInfo("Sokoni", "21", -6.43333, 39.55);
case 27: return new CityInfo("Sirari", "08", -1.25367, 34.47596);
case 28: return new CityInfo("Singida", "16", -4.81629, 34.74358);
case 29: return new CityInfo("Sikonge", "17", -5.63333, 32.76667);
case 30: return new CityInfo("Shinyanga", "15", -3.66393, 33.42118);
case 31: return new CityInfo("Shelui", "16", -4.36667, 34.2);
case 32: return new CityInfo("Sepuka", "16", -4.75, 34.53333);
case 33: return new CityInfo("Same", "06", -4.06667, 37.73333);
case 34: return new CityInfo("Rulenge", "19", -2.7175, 30.6325);
case 35: return new CityInfo("Rujewa", "09", -8.7, 34.38333);
case 36: return new CityInfo("Puma", "16", -5, 34.73333);
case 37: return new CityInfo("Poli", "26", -3.33333, 36.8);
case 38: return new CityInfo("Pangani", "18", -5.42526, 38.97473);
case 39: return new CityInfo("Old Shinyanga", "15", -3.55, 33.4);
case 40: return new CityInfo("Nzega", "17", -4.21667, 33.18333);
case 41: return new CityInfo("Nyanguge", "12", -2.55, 33.2);
case 42: return new CityInfo("Nyamuswa", "08", -1.9, 34.01667);
case 43: return new CityInfo("Nyalikungu", "31", -3.18333, 33.78333);
case 44: return new CityInfo("Nyakahanga", "19", -1.60333, 31.14139);
case 45: return new CityInfo("Nyakabindi", "31", -2.63333, 33.98333);
case 46: return new CityInfo("Nsunga", "19", -1.14389, 31.39472);
case 47: return new CityInfo("Nshamba", "19", -1.79833, 31.55111);
case 48: return new CityInfo("Nkove", "24", -7.95, 30.85);
case 49: return new CityInfo("Nkoaranga", "26", -3.33333, 36.8);
case 50: return new CityInfo("Njombe", "30", -9.34917, 34.77167);
case 51: return new CityInfo("Nguruka", "05", -5.10917, 31.04194);
case 52: return new CityInfo("Ngudu", "12", -2.96667, 33.33333);
case 53: return new CityInfo("Ngorongoro", "26", -3.23973, 35.48747);
case 54: return new CityInfo("Ngerengere", "10", -6.75, 38.11667);
case 55: return new CityInfo("Ngara", "19", -2.51222, 30.65583);
case 56: return new CityInfo("Nganane", "21", -6.4, 39.55);
case 57: return new CityInfo("Ndungu", "06", -4.36667, 38.05);
case 58: return new CityInfo("Ndago", "16", -4.6, 34.35);
case 59: return new CityInfo("Nansio", "08", -2.13333, 33.05);
case 60: return new CityInfo("Nangwa", "27", -4.46667, 35.45);
case 61: return new CityInfo("Namanyere", "24", -7.51667, 31.05);
case 62: return new CityInfo("Namanga", "26", -2.55116, 36.78377);
case 63: return new CityInfo("Nakatunguru", "08", -2.11667, 33.06667);
case 64: return new CityInfo("Naberera", "27", -4.2, 36.93333);
case 65: return new CityInfo("Mwembe", "06", -4.15, 37.85);
case 66: return new CityInfo("Mwaya", "09", -9.55, 33.95);
case 67: return new CityInfo("Mwanza", "12", -2.51667, 32.9);
case 68: return new CityInfo("Mwanga", "18", -4.8, 38.2);
case 69: return new CityInfo("Mwadui", "15", -3.55, 33.6);
case 70: return new CityInfo("Mvomero", "02", -6.25, 38.66667);
case 71: return new CityInfo("Musoma", "08", -1.5, 33.8);
case 72: return new CityInfo("Muriti", "08", -1.98333, 32.91667);
case 73: return new CityInfo("Mungaa", "16", -4.96667, 34.88333);
case 74: return new CityInfo("Muleba", "19", -1.83972, 31.65444);
case 75: return new CityInfo("Muheza", "18", -5.16667, 38.78333);
case 76: return new CityInfo("Mugumu", "08", -1.85, 34.7);
case 77: return new CityInfo("Mugango", "08", -1.68333, 33.7);
case 78: return new CityInfo("Mtwango", "30", -9.01667, 34.8);
case 79: return new CityInfo("Mto wa Mbu", "26", -3.35, 35.85);
case 80: return new CityInfo("Mtinko", "16", -4.55, 34.85);
case 81: return new CityInfo("Mtimbira", "10", -8.78333, 36.35);
case 82: return new CityInfo("Mtambile", "20", -5.38333, 39.7);
case 83: return new CityInfo("Msowero", "10", -6.53333, 37.2);
case 84: return new CityInfo("Msanga", "03", -6.05, 36.03333);
case 85: return new CityInfo("Mpwapwa", "03", -6.35, 36.48333);
case 86: return new CityInfo("Mpanda", "29", -6.34379, 31.06951);
case 87: return new CityInfo("Moshi", "06", -3.35, 37.33333);
case 88: return new CityInfo("Morogoro", "10", -6.82102, 37.66122);
case 89: return new CityInfo("Monduli", "26", -3.3, 36.45);
case 90: return new CityInfo("Mlowo", "32", -9, 32.98333);
case 91: return new CityInfo("Mlimba", "10", -8.8, 35.81667);
case 92: return new CityInfo("Mlangali", "30", -9.78333, 34.51667);
case 93: return new CityInfo("Mlandizi", "02", -6.7, 38.73333);
case 94: return new CityInfo("Mlalo", "18", -4.93333, 38.93333);
case 95: return new CityInfo("Mkuranga", "02", -7.11799, 39.20782);
case 96: return new CityInfo("Mkokotoni", "22", -5.87506, 39.25523);
case 97: return new CityInfo("Mwandiga", "05", -4.83, 29.65806);
case 98: return new CityInfo("Misungwi", "12", -2.85, 33.08333);
case 99: return new CityInfo("Misasi", "12", -3, 33.08333);
case 100: return new CityInfo("Mikumi", "10", -7.40409, 36.98309);
case 101: return new CityInfo("Micheweni", "13", -4.96667, 39.83333);
case 102: return new CityInfo("Mhango", "15", -3.28333, 32.85);
case 103: return new CityInfo("Mgandu", "16", -5.95, 34.13333);
case 104: return new CityInfo("Mbumi", "02", -7.90577, 39.21047);
case 105: return new CityInfo("Mbulu", "27", -3.85, 35.53333);
case 106: return new CityInfo("Mbuguni", "26", -3.56667, 36.95);
case 107: return new CityInfo("Mbeya", "09", -8.9, 33.45);
case 108: return new CityInfo("Mazinde", "18", -4.8, 38.21667);
case 109: return new CityInfo("Matui", "18", -4.8, 38.25);
case 110: return new CityInfo("Matonga", "31", -2.38333, 34.08333);
case 111: return new CityInfo("Matamba", "30", -8.98333, 33.96667);
case 112: return new CityInfo("Matai", "24", -8.3, 31.51667);
case 113: return new CityInfo("Maswa", "31", -2.68333, 33.98333);
case 114: return new CityInfo("Masumbwe", "28", -3.63333, 32.18333);
case 115: return new CityInfo("Masoko", "09", -9.33333, 33.75);
case 116: return new CityInfo("Maramba", "18", -5.05, 38.61667);
case 117: return new CityInfo("Maneromango", "02", -7.1988, 38.78478);
case 118: return new CityInfo("Malya", "12", -2.98333, 33.51667);
case 119: return new CityInfo("Malinyi", "10", -8.93333, 36.13333);
case 120: return new CityInfo("Malangali", "04", -8.56667, 34.85);
case 121: return new CityInfo("Malampaka", "31", -3.13333, 33.53333);
case 122: return new CityInfo("Makuyuni", "18", -4.73333, 38.1);
case 123: return new CityInfo("Makungu", "04", -8.73333, 35.28333);
case 124: return new CityInfo("Makumbako", "30", -8.85, 34.83333);
case 125: return new CityInfo("Makanya", "06", -4.36667, 37.83333);
case 126: return new CityInfo("Majengo", "18", -5.15, 38.98333);
case 127: return new CityInfo("Mahonda", "21", -6.45, 39.46667);
case 128: return new CityInfo("Mahenge", "10", -8.68333, 36.71667);
case 129: return new CityInfo("Mahanje", "14", -9.93333, 35.33333);
case 130: return new CityInfo("Kihangara", "12", -2.58333, 33.35);
case 131: return new CityInfo("Magugu", "27", -4.01667, 35.76667);
case 132: return new CityInfo("Magomeni", "23", -6.8, 39.25);
case 133: return new CityInfo("Magomeni", "18", -5.23333, 38.11667);
case 134: return new CityInfo("Magole", "10", -6.37697, 37.37373);
case 135: return new CityInfo("Mafinga", "04", -7.25, 35.06667);
case 136: return new CityInfo("Mabamba", "05", -3.59833, 30.50194);
case 137: return new CityInfo("Mabama", "17", -5.13333, 32.53333);
case 138: return new CityInfo("Lushoto", "18", -4.78333, 38.28333);
case 139: return new CityInfo("Lupiro", "10", -8.38333, 36.66667);
case 140: return new CityInfo("Lugoba", "02", -6.45, 38.33333);
case 141: return new CityInfo("Longido", "26", -2.73319, 36.69773);
case 142: return new CityInfo("Liwale", "07", -9.76667, 37.93333);
case 143: return new CityInfo("Lembeni", "06", -3.78333, 37.61667);
case 144: return new CityInfo("Lalago", "31", -3.45, 33.95);
case 145: return new CityInfo("Laela", "24", -8.56667, 32.05);
case 146: return new CityInfo("Kyela", "09", -9.58333, 33.85);
case 147: return new CityInfo("Kyaka", "19", -1.25222, 31.42028);
case 148: return new CityInfo("Kwakoa", "06", -3.76667, 37.71667);
case 149: return new CityInfo("Kongwa", "03", -6.2, 36.41667);
case 150: return new CityInfo("Kondoa", "03", -4.9, 35.78333);
case 151: return new CityInfo("Konde", "13", -4.95, 39.75);
case 152: return new CityInfo("Koani Ndogo", "21", -6.13333, 39.28333);
case 153: return new CityInfo("Koani", "21", -6.13333, 39.28333);
case 154: return new CityInfo("Kiwira", "09", -9.17307, 33.54152);
case 155: return new CityInfo("Kiwengwa", "22", -5.98957, 39.3768);
case 156: return new CityInfo("Kisiwani", "06", -4.13333, 37.95);
case 157: return new CityInfo("Kishapu", "15", -3.61667, 33.86667);
case 158: return new CityInfo("Kisesa", "31", -3.08333, 34.15);
case 159: return new CityInfo("Kisarawe", "02", -6.9, 39.06667);
case 160: return new CityInfo("Kisanga", "10", -7.43622, 37.70337);
case 161: return new CityInfo("Kirya", "27", -3.91667, 37.48333);
case 162: return new CityInfo("Kirando", "24", -7.41667, 30.6);
case 163: return new CityInfo("Kiomboi", "16", -4.26667, 34.36667);
case 164: return new CityInfo("Kintinku", "16", -5.88333, 35.23333);
case 165: return new CityInfo("Kingori", "26", -3.28333, 36.98333);
case 166: return new CityInfo("Kimamba", "10", -6.78333, 37.13333);
case 167: return new CityInfo("Kilosa", "10", -6.83333, 36.98333);
case 168: return new CityInfo("Kilindoni", "02", -7.91446, 39.66204);
case 169: return new CityInfo("Kilimatinde", "16", -5.85, 34.95);
case 170: return new CityInfo("Kijini", "22", -5.85, 39.31667);
case 171: return new CityInfo("Kihurio", "06", -4.46667, 38.06667);
case 172: return new CityInfo("Kigoma", "05", -4.87694, 29.62667);
case 173: return new CityInfo("Kidodi", "10", -7.60361, 37.00438);
case 174: return new CityInfo("Kidatu", "10", -7.69916, 36.95722);
case 175: return new CityInfo("Kibondo", "05", -3.58639, 30.72028);
case 176: return new CityInfo("Kibiti", "02", -7.72178, 38.93749);
case 177: return new CityInfo("Kibaya", "27", -5.3, 36.56667);
case 178: return new CityInfo("Kibara", "08", -2.15, 33.45);
case 179: return new CityInfo("Kibakwe", "03", -6.71667, 36.36667);
case 180: return new CityInfo("Kibaha", "02", -6.76667, 38.91667);
case 181: return new CityInfo("Katumba", "09", -9.23333, 33.61667);
case 182: return new CityInfo("Katoro", "28", -3.02028, 31.89583);
case 183: return new CityInfo("Katoro", "19", -1.39972, 31.50028);
case 184: return new CityInfo("Katesh", "27", -4.52483, 35.3849);
case 185: return new CityInfo("Katerero", "19", -1.4, 31.73333);
case 186: return new CityInfo("Kasulu", "05", -4.57667, 30.1025);
case 187: return new CityInfo("Kasamwa", "28", -2.85, 32.43333);
case 188: return new CityInfo("Karema", "29", -6.82052, 30.43887);
case 189: return new CityInfo("Kiratu", "26", -3.33333, 35.66667);
case 190: return new CityInfo("Kandete", "09", -9.15, 33.8);
case 191: return new CityInfo("Kamachumu", "19", -1.61861, 31.62);
case 192: return new CityInfo("Kaliua", "17", -5.06056, 31.79361);
case 193: return new CityInfo("Kakonko", "05", -3.28278, 30.96417);
case 194: return new CityInfo("Kahama", "15", -3.83333, 32.6);
case 195: return new CityInfo("Kabanga", "19", -2.63861, 30.46778);
case 196: return new CityInfo("Izazi", "04", -7.2, 35.73333);
case 197: return new CityInfo("Itumba", "32", -9.4, 33.18333);
case 198: return new CityInfo("Itigi", "16", -5.7, 34.48333);
case 199: return new CityInfo("Issenye", "08", -2, 34.33333);
case 200: return new CityInfo("Isaka", "15", -3.9, 32.93333);
case 201: return new CityInfo("Iringa", "04", -7.76667, 35.7);
case 202: return new CityInfo("Ipinda", "09", -9.48333, 33.9);
case 203: return new CityInfo("Inyonga", "29", -6.71667, 32.06667);
case 204: return new CityInfo("Ilula", "04", -7.6766, 36.03658);
case 205: return new CityInfo("Ilongero", "16", -4.66667, 34.86667);
case 206: return new CityInfo("Ilembula", "30", -8.9, 34.58333);
case 207: return new CityInfo("Ilembo", "09", -9.25, 33.38333);
case 208: return new CityInfo("Ikwiriri", "02", -7.95618, 38.97164);
case 209: return new CityInfo("Ikungi", "16", -5.13333, 34.76667);
case 210: return new CityInfo("Igurusi", "09", -8.85, 33.85);
case 211: return new CityInfo("Igurubi", "17", -4, 33.7);
case 212: return new CityInfo("Igunga", "17", -4.28333, 33.88333);
case 213: return new CityInfo("Igugunu", "16", -4.56667, 34.63333);
case 214: return new CityInfo("Ifakara", "10", -8.13333, 36.68333);
case 215: return new CityInfo("Hedaru", "06", -4.5, 37.9);
case 216: return new CityInfo("Geita", "28", -2.8725, 32.2325);
case 217: return new CityInfo("Geiro", "10", -6.15, 36.86667);
case 218: return new CityInfo("Gamba", "22", -5.9, 39.3);
case 219: return new CityInfo("Galappo", "27", -4.26667, 35.85);
case 220: return new CityInfo("Endasak", "27", -4.41667, 35.51667);
case 221: return new CityInfo("Dunda", "09", -8.11667, 34.25);
case 222: return new CityInfo("Dongobesh", "27", -4.06667, 35.38333);
case 223: return new CityInfo("Dodoma", "03", -6.17221, 35.73947);
case 224: return new CityInfo("Dar es Salaam", "23", -6.82349, 39.26951);
case 225: return new CityInfo("Dareda", "27", -4.21667, 35.55);
case 226: return new CityInfo("Chimala", "09", -8.85637, 34.02393);
case 227: return new CityInfo("Chato", "28", -2.63778, 31.76694);
case 228: return new CityInfo("Chanika", "18", -5.41667, 38.01667);
case 229: return new CityInfo("Chalinze", "02", -6.63784, 38.35396);
case 230: return new CityInfo("Chala", "24", -7.58333, 31.26667);
case 231: return new CityInfo("Chake Chake", "20", -5.24586, 39.76659);
case 232: return new CityInfo("Butiama", "08", -1.76667, 33.96667);
case 233: return new CityInfo("Buseresere", "28", -3.02361, 31.87472);
case 234: return new CityInfo("Bungu", "02", -7.63369, 39.05818);
case 235: return new CityInfo("Bunda", "08", -2.05, 33.86667);
case 236: return new CityInfo("Bukonyo", "08", -1.95, 32.93333);
case 237: return new CityInfo("Bukoba", "19", -1.33167, 31.81222);
case 238: return new CityInfo("Bukene", "17", -4.23333, 32.88333);
case 239: return new CityInfo("Bugene", "19", -1.59111, 31.14028);
case 240: return new CityInfo("Bugarama", "19", -2.87056, 30.52806);
case 241: return new CityInfo("Biharamulo", "19", -2.63194, 31.30889);
case 242: return new CityInfo("Basotu", "27", -4.36667, 35.08333);
case 243: return new CityInfo("Bashanet", "27", -4.23333, 35.41667);
case 244: return new CityInfo("Bariadi", "31", -2.8, 33.98333);
case 245: return new CityInfo("Bagamoyo", "02", -6.44222, 38.90422);
case 246: return new CityInfo("Babati", "27", -4.21667, 35.75);
case 247: return new CityInfo("Arusha", "26", -3.36667, 36.68333);
case 248: return new CityInfo("Tingi", "14", -11.3, 35.03333);
case 249: return new CityInfo("Tandahimba", "11", -10.75, 39.63333);
case 250: return new CityInfo("Songea", "14", -10.68333, 35.65);
case 251: return new CityInfo("Ruangwa", "07", -10.06667, 38.93333);
case 252: return new CityInfo("Nyangao", "07", -10.33333, 39.28333);
case 253: return new CityInfo("Newala Kisimani", "11", -10.95, 39.28333);
case 254: return new CityInfo("Nanyamba", "11", -10.68333, 39.83333);
case 255: return new CityInfo("Nanhyanga", "11", -10.8, 39.55);
case 256: return new CityInfo("Nangomba", "11", -10.9, 38.5);
case 257: return new CityInfo("Nanganga", "11", -10.38333, 39.15);
case 258: return new CityInfo("Namikupa", "11", -10.83333, 39.6);
case 259: return new CityInfo("Namalenga", "11", -10.95, 39.1);
case 260: return new CityInfo("Nachingwea", "07", -10.3725, 38.76251);
case 261: return new CityInfo("Mtwara", "11", -10.26667, 40.18333);
case 262: return new CityInfo("Mtama", "07", -10.3, 39.36667);
case 263: return new CityInfo("Mingoyo", "07", -10.10526, 39.61859);
case 264: return new CityInfo("Mbinga", "14", -10.93333, 35.01667);
case 265: return new CityInfo("Mbekenyera", "07", -10, 38.98333);
case 266: return new CityInfo("Mbamba Bay", "14", -11.28333, 34.76667);
case 267: return new CityInfo("Matiri", "14", -10.75, 34.9);
case 268: return new CityInfo("Masuguru", "11", -11.36667, 38.41667);
case 269: return new CityInfo("Masasi", "11", -10.71667, 38.8);
case 270: return new CityInfo("Maposeni", "14", -10.58333, 35.4);
case 271: return new CityInfo("Manda", "30", -10.46667, 34.58333);
case 272: return new CityInfo("Mahuta", "11", -10.86667, 39.45);
case 273: return new CityInfo("Madimba", "11", -10.4, 40.33333);
case 274: return new CityInfo("Lulindi", "11", -10.81667, 39.13333);
case 275: return new CityInfo("Lukuledi", "11", -10.56667, 38.8);
case 276: return new CityInfo("Luchingu", "11", -10.9, 39.33333);
case 277: return new CityInfo("Liuli", "14", -11.08333, 34.63333);
case 278: return new CityInfo("Lindi", "07", -9.99709, 39.71649);
case 279: return new CityInfo("Kitangari", "11", -10.65, 39.33333);
case 280: return new CityInfo("Kitama", "11", -10.71667, 39.73333);
case 281: return new CityInfo("Kigonsera", "14", -10.8, 35.05);
case 282: return new CityInfo("Chiungutwa", "11", -10.88333, 38.98333);
case 283: return new CityInfo("Merelani", "26", -3.56182, 36.97895);
case 284: return new CityInfo("Nungwi", "22", -5.72651, 39.2987);
case 285: return new CityInfo("Kisasa", "03", -6.17526, 35.79266);
default: return new CityInfo("Mvomero", "10", -6.30122, 37.44398);

                                    }                                        
                                }
                            
                        }
                    }
                