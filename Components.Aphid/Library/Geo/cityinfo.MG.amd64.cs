
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
                                    public const string Country = "MG";
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
                            
                                        var cur = (Math.Abs(-18.1492 - lat) + Math.Abs(49.40234 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-22.81667 - lat) + Math.Abs(47.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.55 - lat) + Math.Abs(47.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.7 - lat) + Math.Abs(47.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.35 - lat) + Math.Abs(49.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.46667 - lat) + Math.Abs(49.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.35 - lat) + Math.Abs(47.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.76969 - lat) + Math.Abs(46.04653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.3 - lat) + Math.Abs(45.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.79706 - lat) + Math.Abs(47.65165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.3 - lat) + Math.Abs(44.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.35 - lat) + Math.Abs(43.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.03249 - lat) + Math.Abs(46.98329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.16667 - lat) + Math.Abs(46.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.9 - lat) + Math.Abs(47.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.91667 - lat) + Math.Abs(49.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.66667 - lat) + Math.Abs(46.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.38333 - lat) + Math.Abs(47.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.26667 - lat) + Math.Abs(50.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.9 - lat) + Math.Abs(47.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.9 - lat) + Math.Abs(44.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.6 - lat) + Math.Abs(48.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.45 - lat) + Math.Abs(49 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.61667 - lat) + Math.Abs(49.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.63333 - lat) + Math.Abs(47.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.48333 - lat) + Math.Abs(45.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.58333 - lat) + Math.Abs(48.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.9 - lat) + Math.Abs(47.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.28869 - lat) + Math.Abs(44.31782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.94948 - lat) + Math.Abs(48.23007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.95873 - lat) + Math.Abs(46.90553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.52905 - lat) + Math.Abs(45.45559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.43333 - lat) + Math.Abs(46.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.03333 - lat) + Math.Abs(47.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.13333 - lat) + Math.Abs(47.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.11064 - lat) + Math.Abs(46.64383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.05 - lat) + Math.Abs(48.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.43527 - lat) + Math.Abs(49.73794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.01667 - lat) + Math.Abs(47.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.91667 - lat) + Math.Abs(47.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.43333 - lat) + Math.Abs(44.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.85744 - lat) + Math.Abs(48.82824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.4 - lat) + Math.Abs(47.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.23034 - lat) + Math.Abs(48.34173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.16864 - lat) + Math.Abs(49.76622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.14862 - lat) + Math.Abs(48.01055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.06354 - lat) + Math.Abs(44.02951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.68475 - lat) + Math.Abs(49.50869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.9 - lat) + Math.Abs(48.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.53333 - lat) + Math.Abs(48.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.71667 - lat) + Math.Abs(46.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.08333 - lat) + Math.Abs(45.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.95 - lat) + Math.Abs(46.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.2 - lat) + Math.Abs(45.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.88333 - lat) + Math.Abs(47.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.15 - lat) + Math.Abs(46.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.40293 - lat) + Math.Abs(46.12576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.4 - lat) + Math.Abs(47.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.3 - lat) + Math.Abs(47.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.45267 - lat) + Math.Abs(47.08569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.43333 - lat) + Math.Abs(46.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.38095 - lat) + Math.Abs(49.40826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.4 - lat) + Math.Abs(46.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.82223 - lat) + Math.Abs(47.82615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.23333 - lat) + Math.Abs(47.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.51667 - lat) + Math.Abs(47.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.72065 - lat) + Math.Abs(44.38069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.45 - lat) + Math.Abs(45.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.83333 - lat) + Math.Abs(46.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.66667 - lat) + Math.Abs(45.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.06667 - lat) + Math.Abs(48.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.69787 - lat) + Math.Abs(44.54587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.16667 - lat) + Math.Abs(45.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.25 - lat) + Math.Abs(43.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.54329 - lat) + Math.Abs(48.74981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.01667 - lat) + Math.Abs(47.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.08333 - lat) + Math.Abs(48.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.87959 - lat) + Math.Abs(47.98751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.31732 - lat) + Math.Abs(49.29188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.95 - lat) + Math.Abs(48.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.86586 - lat) + Math.Abs(47.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.55 - lat) + Math.Abs(44.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.65 - lat) + Math.Abs(47.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.91368 - lat) + Math.Abs(47.53613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.90033 - lat) + Math.Abs(50.27876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.31667 - lat) + Math.Abs(49.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.7 - lat) + Math.Abs(47.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.31667 - lat) + Math.Abs(47.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.28333 - lat) + Math.Abs(44.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.4 - lat) + Math.Abs(47.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.85 - lat) + Math.Abs(47.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.18785 - lat) + Math.Abs(47.59016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.39718 - lat) + Math.Abs(48.26663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.01009 - lat) + Math.Abs(48.57313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.95443 - lat) + Math.Abs(49.1094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.65 - lat) + Math.Abs(49.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22.9 - lat) + Math.Abs(47.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.66667 - lat) + Math.Abs(43.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.81667 - lat) + Math.Abs(49.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.5876 - lat) + Math.Abs(48.22391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.6937 - lat) + Math.Abs(44.74581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.75 - lat) + Math.Abs(50.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.17838 - lat) + Math.Abs(46.08722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.53034 - lat) + Math.Abs(47.24344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.78333 - lat) + Math.Abs(47.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.7 - lat) + Math.Abs(47.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.08333 - lat) + Math.Abs(47.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.33333 - lat) + Math.Abs(49.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.98333 - lat) + Math.Abs(49.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.03333 - lat) + Math.Abs(46.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.33333 - lat) + Math.Abs(45.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-22 - lat) + Math.Abs(47.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.2 - lat) + Math.Abs(49.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.83333 - lat) + Math.Abs(48.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.93333 - lat) + Math.Abs(47.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.38333 - lat) + Math.Abs(47.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.55284 - lat) + Math.Abs(46.80365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.46667 - lat) + Math.Abs(46.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.5 - lat) + Math.Abs(48.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.669 - lat) + Math.Abs(48.453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-21.83333 - lat) + Math.Abs(46.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.11667 - lat) + Math.Abs(46 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.96667 - lat) + Math.Abs(47.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.63988 - lat) + Math.Abs(47.1565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Toamasina", "31", -18.1492, 49.40234);
case 1: return new CityInfo("Vondrozo", "25", -22.81667, 47.28333);
case 2: return new CityInfo("Vohipaho", "25", -23.55, 47.5);
case 3: return new CityInfo("Vohimanitra", "23", -21.7, 47.7);
case 4: return new CityInfo("Vohibinany", "31", -17.35, 49.03333);
case 5: return new CityInfo("Vavatenina", "32", -17.46667, 49.2);
case 6: return new CityInfo("Vangaindrano", "25", -23.35, 47.6);
case 7: return new CityInfo("Tsiroanomandidy", "14", -18.76969, 46.04653);
case 8: return new CityInfo("Tsiombe", "52", -25.3, 45.48333);
case 9: return new CityInfo("Tsaratanana", "43", -16.79706, 47.65165);
case 10: return new CityInfo("Tranovaho", "52", -25.3, 44.96667);
case 11: return new CityInfo("Toliara", "51", -23.35, 43.66667);
case 12: return new CityInfo("Tôlanaro", "53", -25.03249, 46.98329);
case 13: return new CityInfo("Soavinandriana", "13", -19.16667, 46.73333);
case 14: return new CityInfo("Soanindrariny", "12", -19.9, 47.23333);
case 15: return new CityInfo("Soanierana Ivongo", "32", -16.91667, 49.58333);
case 16: return new CityInfo("Sitampiky", "41", -16.66667, 46.1);
case 17: return new CityInfo("Savana", "23", -22.38333, 47.9);
case 18: return new CityInfo("Sambava", "72", -14.26667, 50.16667);
case 19: return new CityInfo("Sambaina", "11", -18.9, 47.78333);
case 20: return new CityInfo("Sakaraha", "51", -22.9, 44.53333);
case 21: return new CityInfo("Sahavato", "23", -20.6, 48.33333);
case 22: return new CityInfo("Sahatavy", "32", -17.45, 49);
case 23: return new CityInfo("Sadjoavato", "71", -12.61667, 49.35);
case 24: return new CityInfo("Sadabe", "11", -18.63333, 47.7);
case 25: return new CityInfo("Ranohira", "24", -22.48333, 45.4);
case 26: return new CityInfo("Nosy Varika", "23", -20.58333, 48.53333);
case 27: return new CityInfo("Nandihizana", "11", -18.9, 47.71667);
case 28: return new CityInfo("Morondava", "54", -20.28869, 44.31782);
case 29: return new CityInfo("Moramanga", "33", -18.94948, 48.23007);
case 30: return new CityInfo("Miarinarivo", "13", -18.95873, 46.90553);
case 31: return new CityInfo("Miandrivazo", "54", -19.52905, 45.45559);
case 32: return new CityInfo("Miandrarivo", "12", -19.43333, 46.75);
case 33: return new CityInfo("Miadanandriana", "11", -19.03333, 47.78333);
case 34: return new CityInfo("Merikanjaka", "11", -19.13333, 47.85);
case 35: return new CityInfo("Marovoay", "41", -16.11064, 46.64383);
case 36: return new CityInfo("Marolambo", "31", -20.05, 48.11667);
case 37: return new CityInfo("Maroantsetra", "32", -15.43527, 49.73794);
case 38: return new CityInfo("Mantasoa", "11", -19.01667, 47.83333);
case 39: return new CityInfo("Manjakandriana", "11", -18.91667, 47.8);
case 40: return new CityInfo("Manja", "54", -21.43333, 44.33333);
case 41: return new CityInfo("Mandritsara", "42", -15.85744, 48.82824);
case 42: return new CityInfo("Manato", "25", -22.4, 47.48333);
case 43: return new CityInfo("Mananjary", "23", -21.23034, 48.34173);
case 44: return new CityInfo("Mananara", "32", -16.16864, 49.76622);
case 45: return new CityInfo("Manakara", "23", -22.14862, 48.01055);
case 46: return new CityInfo("Maintirano", "44", -18.06354, 44.02951);
case 47: return new CityInfo("Mahavelona", "31", -17.68475, 49.50869);
case 48: return new CityInfo("Mahanoro", "31", -19.9, 48.8);
case 49: return new CityInfo("Mahalina", "71", -12.53333, 48.81667);
case 50: return new CityInfo("Mahajanga", "41", -15.71667, 46.31667);
case 51: return new CityInfo("Mahabe", "44", -17.08333, 45.33333);
case 52: return new CityInfo("Maevatanana", "43", -16.95, 46.83333);
case 53: return new CityInfo("Kopoky", "52", -25.2, 45.2);
case 54: return new CityInfo("Ikongo", "23", -21.88333, 47.43333);
case 55: return new CityInfo("Ikalamavony", "21", -21.15, 46.58333);
case 56: return new CityInfo("Ihosy", "24", -22.40293, 46.12576);
case 57: return new CityInfo("Ifatsy", "23", -22.4, 47.75);
case 58: return new CityInfo("Ifanadiana", "23", -21.3, 47.63333);
case 59: return new CityInfo("Fianarantsoa", "21", -21.45267, 47.08569);
case 60: return new CityInfo("Fenoarivo Be", "14", -18.43333, 46.56667);
case 61: return new CityInfo("Fenoarivo Atsinanana", "32", -17.38095, 49.40826);
case 62: return new CityInfo("Faratsiho", "12", -19.4, 46.95);
case 63: return new CityInfo("Farafangana", "25", -22.82223, 47.82615);
case 64: return new CityInfo("Fandriana", "22", -20.23333, 47.38333);
case 65: return new CityInfo("Fandrandava", "21", -21.51667, 47.25);
case 66: return new CityInfo("Betioky", "51", -23.72065, 44.38069);
case 67: return new CityInfo("Beteza", "52", -24.45, 45.11667);
case 68: return new CityInfo("Betafo", "12", -19.83333, 46.85);
case 69: return new CityInfo("Beroroha", "51", -21.66667, 45.16667);
case 70: return new CityInfo("Bemaitso", "33", -17.06667, 48.5);
case 71: return new CityInfo("Belo sur Tsiribihina", "54", -19.69787, 44.54587);
case 72: return new CityInfo("Beloha", "52", -25.16667, 45.05);
case 73: return new CityInfo("Behompy", "51", -23.25, 43.85);
case 74: return new CityInfo("Bealanana", "42", -14.54329, 48.74981);
case 75: return new CityInfo("Arivonimamo", "13", -19.01667, 47.18333);
case 76: return new CityInfo("Antsohimbondrona", "71", -13.08333, 48.85);
case 77: return new CityInfo("Antsohihy", "42", -14.87959, 47.98751);
case 78: return new CityInfo("Antsiranana", "71", -12.31732, 49.29188);
case 79: return new CityInfo("Antsirabe Afovoany", "42", -15.95, 48.96667);
case 80: return new CityInfo("Antsirabe", "12", -19.86586, 47.03333);
case 81: return new CityInfo("Antanimena", "51", -23.55, 44.1);
case 82: return new CityInfo("Antanifotsy", "12", -19.65, 47.31667);
case 83: return new CityInfo("Antananarivo", "11", -18.91368, 47.53613);
case 84: return new CityInfo("Antalaha", "72", -14.90033, 50.27876);
case 85: return new CityInfo("Antakotako", "32", -15.31667, 49.8);
case 86: return new CityInfo("Ankazondandy", "11", -18.7, 47.78333);
case 87: return new CityInfo("Ankazobe", "11", -18.31667, 47.11667);
case 88: return new CityInfo("Ankazoabo", "51", -22.28333, 44.51667);
case 89: return new CityInfo("Anjozorobe", "11", -18.4, 47.86667);
case 90: return new CityInfo("Anjepy", "11", -18.85, 47.71667);
case 91: return new CityInfo("Andramasina", "11", -19.18785, 47.59016);
case 92: return new CityInfo("Hell-Ville", "71", -13.39718, 48.26663);
case 93: return new CityInfo("Andilamena", "33", -17.01009, 48.57313);
case 94: return new CityInfo("Andovoranto", "31", -18.95443, 49.1094);
case 95: return new CityInfo("Andapa", "72", -14.65, 49.65);
case 96: return new CityInfo("Anandravy", "21", -22.9, 47.36667);
case 97: return new CityInfo("Anakao", "51", -23.66667, 43.65);
case 98: return new CityInfo("Ampasimanolotra", "31", -18.81667, 49.06667);
case 99: return new CityInfo("Amparafaravola", "33", -17.5876, 48.22391);
case 100: return new CityInfo("Ampanihy", "51", -24.6937, 44.74581);
case 101: return new CityInfo("Ampahana", "72", -14.75, 50.21667);
case 102: return new CityInfo("Ambovombe", "52", -25.17838, 46.08722);
case 103: return new CityInfo("Ambositra", "22", -20.53034, 47.24344);
case 104: return new CityInfo("Ambohitseheno", "11", -18.78333, 47.8);
case 105: return new CityInfo("Ambohitrolomahitsy", "11", -18.7, 47.68333);
case 106: return new CityInfo("Ambohitrandriamanitra", "11", -19.08333, 47.78333);
case 107: return new CityInfo("Ambodivoara", "72", -14.33333, 49.98333);
case 108: return new CityInfo("Ambodifotatra", "32", -16.98333, 49.85);
case 109: return new CityInfo("Amboasary", "53", -25.03333, 46.38333);
case 110: return new CityInfo("Amboasary", "53", -24.33333, 45.95);
case 111: return new CityInfo("Amboanjo", "23", -22, 47.85);
case 112: return new CityInfo("Ambilobe", "71", -13.2, 49.05);
case 113: return new CityInfo("Ambatondrazaka", "33", -17.83333, 48.41667);
case 114: return new CityInfo("Ambatolaona", "11", -18.93333, 47.9);
case 115: return new CityInfo("Ambatolampy", "12", -19.38333, 47.41667);
case 116: return new CityInfo("Ambatofinandrahana", "22", -20.55284, 46.80365);
case 117: return new CityInfo("Ambato Boeny", "41", -16.46667, 46.71667);
case 118: return new CityInfo("Ambarakaraka", "71", -13.5, 48.86667);
case 119: return new CityInfo("Ambanja", "71", -13.669, 48.453);
case 120: return new CityInfo("Ambalavao", "21", -21.83333, 46.93333);
case 121: return new CityInfo("Ambalasoa", "53", -23.11667, 46);
case 122: return new CityInfo("Alarobia", "11", -18.96667, 47.73333);
default: return new CityInfo("Antsampanimahazo", "12", -19.63988, 47.1565);

                                    }                                        
                                }
                            
                        }
                    }
                