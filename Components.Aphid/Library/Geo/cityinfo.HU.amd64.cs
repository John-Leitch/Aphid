
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
                                    public const string Country = "HU";
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
                            
                                        var cur = (Math.Abs(48.40906 - lat) + Math.Abs(22.17614 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(47.26667 - lat) + Math.Abs(20.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91667 - lat) + Math.Abs(21.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.85 - lat) + Math.Abs(20.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.12542 - lat) + Math.Abs(22.31325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53333 - lat) + Math.Abs(21.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.00574 - lat) + Math.Abs(22.16761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3 - lat) + Math.Abs(20.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58333 - lat) + Math.Abs(21.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.8 - lat) + Math.Abs(21.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.19527 - lat) + Math.Abs(21.87035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.85378 - lat) + Math.Abs(22.5633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.34407 - lat) + Math.Abs(22.11762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1 - lat) + Math.Abs(20.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.96667 - lat) + Math.Abs(22.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41667 - lat) + Math.Abs(20.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1 - lat) + Math.Abs(20.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18333 - lat) + Math.Abs(20.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.26667 - lat) + Math.Abs(22.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61716 - lat) + Math.Abs(20.04357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.28333 - lat) + Math.Abs(21.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11667 - lat) + Math.Abs(21.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.96667 - lat) + Math.Abs(21.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.93333 - lat) + Math.Abs(21.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48333 - lat) + Math.Abs(20.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38333 - lat) + Math.Abs(20.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4 - lat) + Math.Abs(20.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21667 - lat) + Math.Abs(20.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56667 - lat) + Math.Abs(20.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1 - lat) + Math.Abs(21.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03774 - lat) + Math.Abs(21.07261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.01667 - lat) + Math.Abs(21.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.78333 - lat) + Math.Abs(21 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.93261 - lat) + Math.Abs(20.10349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.2 - lat) + Math.Abs(21.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.61667 - lat) + Math.Abs(20.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98333 - lat) + Math.Abs(20.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05 - lat) + Math.Abs(21.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.01667 - lat) + Math.Abs(21.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03333 - lat) + Math.Abs(21.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.7 - lat) + Math.Abs(21 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45 - lat) + Math.Abs(20.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3 - lat) + Math.Abs(20.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.36667 - lat) + Math.Abs(22.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15 - lat) + Math.Abs(21.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.71667 - lat) + Math.Abs(21.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1048 - lat) + Math.Abs(22.53744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.59499 - lat) + Math.Abs(20.05254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05 - lat) + Math.Abs(20.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.13333 - lat) + Math.Abs(21.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.23333 - lat) + Math.Abs(21.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11667 - lat) + Math.Abs(21.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.08333 - lat) + Math.Abs(21.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18333 - lat) + Math.Abs(20.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15 - lat) + Math.Abs(20.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1 - lat) + Math.Abs(20.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.2 - lat) + Math.Abs(20.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.76667 - lat) + Math.Abs(20.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15993 - lat) + Math.Abs(21.2097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.76667 - lat) + Math.Abs(20.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65834 - lat) + Math.Abs(20.2608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.4 - lat) + Math.Abs(20.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5 - lat) + Math.Abs(20.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5874 - lat) + Math.Abs(20.22408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.03333 - lat) + Math.Abs(21.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.253 - lat) + Math.Abs(20.14824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34306 - lat) + Math.Abs(20.0402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86667 - lat) + Math.Abs(20.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.04561 - lat) + Math.Abs(22.36582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.76667 - lat) + Math.Abs(21.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18333 - lat) + Math.Abs(20.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.61667 - lat) + Math.Abs(21.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.93333 - lat) + Math.Abs(20.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.39492 - lat) + Math.Abs(21.65871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23333 - lat) + Math.Abs(21.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.3245 - lat) + Math.Abs(21.57383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75 - lat) + Math.Abs(21.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4 - lat) + Math.Abs(21.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36087 - lat) + Math.Abs(20.09889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.95 - lat) + Math.Abs(20.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.18171 - lat) + Math.Abs(20.83149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.95 - lat) + Math.Abs(21 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21667 - lat) + Math.Abs(20.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.95 - lat) + Math.Abs(21.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05 - lat) + Math.Abs(20.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.28333 - lat) + Math.Abs(20.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.16667 - lat) + Math.Abs(20.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.38333 - lat) + Math.Abs(20.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18796 - lat) + Math.Abs(20.03372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.32565 - lat) + Math.Abs(21.97069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.93333 - lat) + Math.Abs(20.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06667 - lat) + Math.Abs(20.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08333 - lat) + Math.Abs(20.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.12372 - lat) + Math.Abs(21.46429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.3 - lat) + Math.Abs(20.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53333 - lat) + Math.Abs(20.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31667 - lat) + Math.Abs(21.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.08333 - lat) + Math.Abs(21.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65 - lat) + Math.Abs(20.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.88333 - lat) + Math.Abs(22.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.86667 - lat) + Math.Abs(21.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28333 - lat) + Math.Abs(21.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.06084 - lat) + Math.Abs(22.07485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.01667 - lat) + Math.Abs(20.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.16667 - lat) + Math.Abs(22 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.92323 - lat) + Math.Abs(20.02972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21667 - lat) + Math.Abs(20.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.86667 - lat) + Math.Abs(20.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56667 - lat) + Math.Abs(20.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.48592 - lat) + Math.Abs(20.08722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.99771 - lat) + Math.Abs(22.32617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48 - lat) + Math.Abs(20.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11667 - lat) + Math.Abs(20.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.25 - lat) + Math.Abs(21.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.91862 - lat) + Math.Abs(22.5081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9 - lat) + Math.Abs(21.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.93333 - lat) + Math.Abs(22.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.9 - lat) + Math.Abs(20.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81667 - lat) + Math.Abs(22.18683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.01667 - lat) + Math.Abs(21.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11667 - lat) + Math.Abs(22.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.98333 - lat) + Math.Abs(21.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.73976 - lat) + Math.Abs(21.96445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.91667 - lat) + Math.Abs(22.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.58333 - lat) + Math.Abs(21.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.06667 - lat) + Math.Abs(22.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69315 - lat) + Math.Abs(22.04476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.09477 - lat) + Math.Abs(22.10463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.88622 - lat) + Math.Abs(22.09781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.95539 - lat) + Math.Abs(21.71671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.90383 - lat) + Math.Abs(22.3363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05723 - lat) + Math.Abs(21.88242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.8034 - lat) + Math.Abs(22.06561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.7 - lat) + Math.Abs(22.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.83333 - lat) + Math.Abs(22.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69746 - lat) + Math.Abs(21.91878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.6033 - lat) + Math.Abs(21.97208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55311 - lat) + Math.Abs(22.02401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.98333 - lat) + Math.Abs(20.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.93797 - lat) + Math.Abs(21.86763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68333 - lat) + Math.Abs(20.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79777 - lat) + Math.Abs(20.7179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2 - lat) + Math.Abs(21.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.87491 - lat) + Math.Abs(21.84082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.13266 - lat) + Math.Abs(21.76104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.86547 - lat) + Math.Abs(22.39159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05759 - lat) + Math.Abs(22.30423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.96667 - lat) + Math.Abs(21.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41667 - lat) + Math.Abs(21.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.26667 - lat) + Math.Abs(20.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4 - lat) + Math.Abs(21.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21102 - lat) + Math.Abs(21.15052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.10306 - lat) + Math.Abs(20.77806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52362 - lat) + Math.Abs(20.19038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45 - lat) + Math.Abs(21.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15 - lat) + Math.Abs(21.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47 - lat) + Math.Abs(20.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81667 - lat) + Math.Abs(20.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4 - lat) + Math.Abs(20.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.83333 - lat) + Math.Abs(20.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31667 - lat) + Math.Abs(20.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81667 - lat) + Math.Abs(20.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81667 - lat) + Math.Abs(21.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.78824 - lat) + Math.Abs(22.38038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.78333 - lat) + Math.Abs(21.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.18333 - lat) + Math.Abs(21.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5 - lat) + Math.Abs(21.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.95 - lat) + Math.Abs(20.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.95528 - lat) + Math.Abs(22.32348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26667 - lat) + Math.Abs(20.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.88303 - lat) + Math.Abs(22.02501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.32149 - lat) + Math.Abs(22.19107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15498 - lat) + Math.Abs(20.4956 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.01667 - lat) + Math.Abs(20.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21667 - lat) + Math.Abs(20.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.8 - lat) + Math.Abs(20.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45 - lat) + Math.Abs(20.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.19442 - lat) + Math.Abs(21.28208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43333 - lat) + Math.Abs(21.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.96282 - lat) + Math.Abs(21.98537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38333 - lat) + Math.Abs(21.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83916 - lat) + Math.Abs(20.28879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43333 - lat) + Math.Abs(20.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36667 - lat) + Math.Abs(20.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43333 - lat) + Math.Abs(21.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05 - lat) + Math.Abs(21.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88333 - lat) + Math.Abs(21.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96667 - lat) + Math.Abs(21.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31667 - lat) + Math.Abs(21.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.76667 - lat) + Math.Abs(20.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.73333 - lat) + Math.Abs(20.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47 - lat) + Math.Abs(21.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.93912 - lat) + Math.Abs(22.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18333 - lat) + Math.Abs(20.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21667 - lat) + Math.Abs(22.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21667 - lat) + Math.Abs(20.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.84244 - lat) + Math.Abs(22.00393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5 - lat) + Math.Abs(20.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41667 - lat) + Math.Abs(21.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53333 - lat) + Math.Abs(21.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.8 - lat) + Math.Abs(20.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08333 - lat) + Math.Abs(20.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25 - lat) + Math.Abs(20.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.07532 - lat) + Math.Abs(21.80625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11667 - lat) + Math.Abs(21.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.25 - lat) + Math.Abs(20.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46667 - lat) + Math.Abs(20.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23333 - lat) + Math.Abs(20.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.3113 - lat) + Math.Abs(21.80537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31667 - lat) + Math.Abs(20.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.72962 - lat) + Math.Abs(20.03076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.93333 - lat) + Math.Abs(22.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.88333 - lat) + Math.Abs(21.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.86081 - lat) + Math.Abs(21.93929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.73333 - lat) + Math.Abs(20.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35 - lat) + Math.Abs(21.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.58333 - lat) + Math.Abs(20.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36667 - lat) + Math.Abs(20.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45 - lat) + Math.Abs(20.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05 - lat) + Math.Abs(20.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52038 - lat) + Math.Abs(19.99086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5661 - lat) + Math.Abs(20.01534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51667 - lat) + Math.Abs(20.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36667 - lat) + Math.Abs(20.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15 - lat) + Math.Abs(20.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38333 - lat) + Math.Abs(20.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.3 - lat) + Math.Abs(20.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.12329 - lat) + Math.Abs(21.70953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39303 - lat) + Math.Abs(21.7328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.58278 - lat) + Math.Abs(21.15108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41667 - lat) + Math.Abs(20.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.91834 - lat) + Math.Abs(22.20153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.6 - lat) + Math.Abs(20.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.06667 - lat) + Math.Abs(20.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.9 - lat) + Math.Abs(20.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.96667 - lat) + Math.Abs(20.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.25 - lat) + Math.Abs(21 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38333 - lat) + Math.Abs(21.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45 - lat) + Math.Abs(21.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.6 - lat) + Math.Abs(21.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.85 - lat) + Math.Abs(21.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68333 - lat) + Math.Abs(21.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81667 - lat) + Math.Abs(21.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66667 - lat) + Math.Abs(21.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39295 - lat) + Math.Abs(21.66551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.13333 - lat) + Math.Abs(22.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.65 - lat) + Math.Abs(21.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.93333 - lat) + Math.Abs(20.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.83333 - lat) + Math.Abs(21.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.46667 - lat) + Math.Abs(21.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1 - lat) + Math.Abs(20.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15 - lat) + Math.Abs(21.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.66667 - lat) + Math.Abs(20.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1 - lat) + Math.Abs(21.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.75 - lat) + Math.Abs(20.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3 - lat) + Math.Abs(21.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31667 - lat) + Math.Abs(20.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.27133 - lat) + Math.Abs(22.10009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1 - lat) + Math.Abs(20.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.96667 - lat) + Math.Abs(20.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.98333 - lat) + Math.Abs(22.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26667 - lat) + Math.Abs(20.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.18333 - lat) + Math.Abs(20.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68333 - lat) + Math.Abs(20.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68333 - lat) + Math.Abs(20.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.73333 - lat) + Math.Abs(22.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.33333 - lat) + Math.Abs(21.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.93333 - lat) + Math.Abs(20.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53333 - lat) + Math.Abs(21.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63333 - lat) + Math.Abs(20.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.86667 - lat) + Math.Abs(20.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.90265 - lat) + Math.Abs(20.37329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.3 - lat) + Math.Abs(20.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46667 - lat) + Math.Abs(21.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.83333 - lat) + Math.Abs(20.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.23333 - lat) + Math.Abs(21.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33333 - lat) + Math.Abs(21.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24917 - lat) + Math.Abs(20.01111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.26246 - lat) + Math.Abs(22.06339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.73333 - lat) + Math.Abs(21.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.03333 - lat) + Math.Abs(20.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21802 - lat) + Math.Abs(20.24322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35 - lat) + Math.Abs(21.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11648 - lat) + Math.Abs(21.92624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53167 - lat) + Math.Abs(21.62444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.63333 - lat) + Math.Abs(20.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.71332 - lat) + Math.Abs(20.14241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.03333 - lat) + Math.Abs(21.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.887 - lat) + Math.Abs(20.76811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.8632 - lat) + Math.Abs(20.18701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.83582 - lat) + Math.Abs(22.68096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.59501 - lat) + Math.Abs(20.12342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25 - lat) + Math.Abs(20.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55 - lat) + Math.Abs(20.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.25561 - lat) + Math.Abs(21.89195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95976 - lat) + Math.Abs(20.19753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.1 - lat) + Math.Abs(21.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2 - lat) + Math.Abs(21 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.11667 - lat) + Math.Abs(20.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21667 - lat) + Math.Abs(20.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.73333 - lat) + Math.Abs(21.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.9 - lat) + Math.Abs(20.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05 - lat) + Math.Abs(20.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21667 - lat) + Math.Abs(21.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13333 - lat) + Math.Abs(21.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3 - lat) + Math.Abs(20.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.7 - lat) + Math.Abs(20.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21667 - lat) + Math.Abs(21.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.05 - lat) + Math.Abs(20.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86667 - lat) + Math.Abs(20.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41667 - lat) + Math.Abs(20.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68333 - lat) + Math.Abs(21.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.76667 - lat) + Math.Abs(21.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15 - lat) + Math.Abs(21.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28333 - lat) + Math.Abs(21.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3 - lat) + Math.Abs(21.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.61667 - lat) + Math.Abs(21.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.77066 - lat) + Math.Abs(21.86314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42277 - lat) + Math.Abs(20.00816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48 - lat) + Math.Abs(22.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54297 - lat) + Math.Abs(20.10213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44882 - lat) + Math.Abs(21.989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.21667 - lat) + Math.Abs(20.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.13058 - lat) + Math.Abs(20.85832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.18333 - lat) + Math.Abs(20.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.20595 - lat) + Math.Abs(22.25916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.76218 - lat) + Math.Abs(22.27255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16667 - lat) + Math.Abs(20.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.96431 - lat) + Math.Abs(21.93539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.85 - lat) + Math.Abs(20.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.17642 - lat) + Math.Abs(22.11167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35 - lat) + Math.Abs(20.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.06982 - lat) + Math.Abs(20.88046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42705 - lat) + Math.Abs(20.04219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.17664 - lat) + Math.Abs(22.06273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1899 - lat) + Math.Abs(20.00476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.28333 - lat) + Math.Abs(21.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.79705 - lat) + Math.Abs(20.00324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46667 - lat) + Math.Abs(20.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51758 - lat) + Math.Abs(19.10549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.32566 - lat) + Math.Abs(19.97464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54381 - lat) + Math.Abs(19.61048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54814 - lat) + Math.Abs(18.72011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41084 - lat) + Math.Abs(18.56577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26362 - lat) + Math.Abs(17.87373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87146 - lat) + Math.Abs(17.68473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31667 - lat) + Math.Abs(18.4081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88488 - lat) + Math.Abs(17.95366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.94474 - lat) + Math.Abs(17.07925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84802 - lat) + Math.Abs(16.5875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53795 - lat) + Math.Abs(17.18094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84 - lat) + Math.Abs(16.84389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27453 - lat) + Math.Abs(19.88975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.77703 - lat) + Math.Abs(19.67092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75742 - lat) + Math.Abs(17.31172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.78526 - lat) + Math.Abs(18.9709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86889 - lat) + Math.Abs(18.45389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09327 - lat) + Math.Abs(17.91149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.62106 - lat) + Math.Abs(18.3813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.82468 - lat) + Math.Abs(19.03484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.6459 - lat) + Math.Abs(19.29536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23041 - lat) + Math.Abs(16.72248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23855 - lat) + Math.Abs(18.65484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40705 - lat) + Math.Abs(19.28648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.04928 - lat) + Math.Abs(16.79954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.10782 - lat) + Math.Abs(18.98514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19936 - lat) + Math.Abs(18.13954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81674 - lat) + Math.Abs(19.75668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68429 - lat) + Math.Abs(19.92924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56391 - lat) + Math.Abs(19.51267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36264 - lat) + Math.Abs(18.67931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85957 - lat) + Math.Abs(17.98406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.574 - lat) + Math.Abs(19.53771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.77591 - lat) + Math.Abs(19.13612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.59674 - lat) + Math.Abs(19.01583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08505 - lat) + Math.Abs(17.64393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41429 - lat) + Math.Abs(19.52762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38771 - lat) + Math.Abs(19.35533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33611 - lat) + Math.Abs(19.84454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27477 - lat) + Math.Abs(19.92477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21981 - lat) + Math.Abs(19.38638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.98366 - lat) + Math.Abs(17.10742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60924 - lat) + Math.Abs(19.60279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.12209 - lat) + Math.Abs(19.93714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42931 - lat) + Math.Abs(18.91356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20605 - lat) + Math.Abs(19.5391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.62609 - lat) + Math.Abs(17.73376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42677 - lat) + Math.Abs(18.78248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32178 - lat) + Math.Abs(18.96249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.72277 - lat) + Math.Abs(18.65889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50782 - lat) + Math.Abs(19.66657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91369 - lat) + Math.Abs(17.88918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51922 - lat) + Math.Abs(17.50802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52878 - lat) + Math.Abs(18.71117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54791 - lat) + Math.Abs(18.82816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54824 - lat) + Math.Abs(19.51436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.58494 - lat) + Math.Abs(18.39325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65289 - lat) + Math.Abs(18.31838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.74148 - lat) + Math.Abs(18.64813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37467 - lat) + Math.Abs(17.90594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02095 - lat) + Math.Abs(19.02988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37327 - lat) + Math.Abs(18.84579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.61042 - lat) + Math.Abs(18.5107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66192 - lat) + Math.Abs(18.44416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.95371 - lat) + Math.Abs(19.7461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88152 - lat) + Math.Abs(17.44117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.19496 - lat) + Math.Abs(16.69613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30248 - lat) + Math.Abs(19.85133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3399 - lat) + Math.Abs(19.74648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33609 - lat) + Math.Abs(19.87724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45 - lat) + Math.Abs(19.60923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45206 - lat) + Math.Abs(19.53369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.402 - lat) + Math.Abs(19.63047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33505 - lat) + Math.Abs(19.95276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36096 - lat) + Math.Abs(19.68609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.63333 - lat) + Math.Abs(18.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32968 - lat) + Math.Abs(19.06695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.75161 - lat) + Math.Abs(19.07886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09942 - lat) + Math.Abs(19.47837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.73135 - lat) + Math.Abs(18.03201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.85923 - lat) + Math.Abs(19.69218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68492 - lat) + Math.Abs(18.34061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23088 - lat) + Math.Abs(16.62155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.73259 - lat) + Math.Abs(19.14749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.72439 - lat) + Math.Abs(19.17046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81921 - lat) + Math.Abs(18.8702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.04865 - lat) + Math.Abs(17.80554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.23417 - lat) + Math.Abs(18.92746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34382 - lat) + Math.Abs(19.04335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32228 - lat) + Math.Abs(19.00262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26492 - lat) + Math.Abs(18.97048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45419 - lat) + Math.Abs(19.70143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51947 - lat) + Math.Abs(19.75286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.04016 - lat) + Math.Abs(17.98719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0576 - lat) + Math.Abs(17.97052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91892 - lat) + Math.Abs(19.91846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95261 - lat) + Math.Abs(16.27358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37479 - lat) + Math.Abs(18.62601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66943 - lat) + Math.Abs(19.07561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35014 - lat) + Math.Abs(18.70905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18995 - lat) + Math.Abs(18.41034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47551 - lat) + Math.Abs(18.68305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.08057 - lat) + Math.Abs(19.52019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32949 - lat) + Math.Abs(18.93878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27673 - lat) + Math.Abs(18.37566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51581 - lat) + Math.Abs(18.4948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46423 - lat) + Math.Abs(17.30402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55713 - lat) + Math.Abs(19.66103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97565 - lat) + Math.Abs(19.01178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.53897 - lat) + Math.Abs(18.1095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63333 - lat) + Math.Abs(19.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87575 - lat) + Math.Abs(19.22324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11902 - lat) + Math.Abs(18.36823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.75887 - lat) + Math.Abs(18.44873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97703 - lat) + Math.Abs(17.28209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28181 - lat) + Math.Abs(18.99524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40665 - lat) + Math.Abs(18.82247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68501 - lat) + Math.Abs(16.59049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01485 - lat) + Math.Abs(18.45343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.16374 - lat) + Math.Abs(19.82303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.5814 - lat) + Math.Abs(17.66289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.59246 - lat) + Math.Abs(18.93212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.57889 - lat) + Math.Abs(19.39389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80101 - lat) + Math.Abs(19.00098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90413 - lat) + Math.Abs(18.058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75462 - lat) + Math.Abs(18.5549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85499 - lat) + Math.Abs(18.29752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1105 - lat) + Math.Abs(18.565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.87247 - lat) + Math.Abs(17.84711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34142 - lat) + Math.Abs(17.35132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2552 - lat) + Math.Abs(18.10776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25395 - lat) + Math.Abs(16.93525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.15321 - lat) + Math.Abs(18.33879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.04273 - lat) + Math.Abs(18.64357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.71221 - lat) + Math.Abs(17.16865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.0054 - lat) + Math.Abs(18.54391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.677 - lat) + Math.Abs(18.67933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88692 - lat) + Math.Abs(18.62041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.09872 - lat) + Math.Abs(19.80303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28806 - lat) + Math.Abs(19.74714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.782 - lat) + Math.Abs(19.7421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.92618 - lat) + Math.Abs(19.25723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03695 - lat) + Math.Abs(19.5301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82573 - lat) + Math.Abs(17.61967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.92816 - lat) + Math.Abs(19.1372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42105 - lat) + Math.Abs(17.01795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.99643 - lat) + Math.Abs(17.19821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16095 - lat) + Math.Abs(18.94478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2736 - lat) + Math.Abs(18.83343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02263 - lat) + Math.Abs(18.94056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.57751 - lat) + Math.Abs(17.43247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63224 - lat) + Math.Abs(17.48004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42948 - lat) + Math.Abs(18.22648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55083 - lat) + Math.Abs(19.98823 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13718 - lat) + Math.Abs(18.76704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.64227 - lat) + Math.Abs(19.02784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.06099 - lat) + Math.Abs(18.302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68095 - lat) + Math.Abs(18.43935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.61386 - lat) + Math.Abs(18.90893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69143 - lat) + Math.Abs(18.90503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60964 - lat) + Math.Abs(18.8994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66909 - lat) + Math.Abs(18.88762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.78464 - lat) + Math.Abs(18.87539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.67924 - lat) + Math.Abs(18.81872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63417 - lat) + Math.Abs(18.82886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60744 - lat) + Math.Abs(18.99322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28904 - lat) + Math.Abs(19.54848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.7696 - lat) + Math.Abs(19.69988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16667 - lat) + Math.Abs(18.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39104 - lat) + Math.Abs(19.40981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.04701 - lat) + Math.Abs(18.78734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.58957 - lat) + Math.Abs(18.76099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.61153 - lat) + Math.Abs(17.80632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03438 - lat) + Math.Abs(18.15403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16033 - lat) + Math.Abs(18.42321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.0725 - lat) + Math.Abs(18.23083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48962 - lat) + Math.Abs(19.34162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28755 - lat) + Math.Abs(18.65356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51709 - lat) + Math.Abs(18.82851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.92019 - lat) + Math.Abs(19.69829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.9126 - lat) + Math.Abs(19.97709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.33004 - lat) + Math.Abs(17.4674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54946 - lat) + Math.Abs(17.75535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35333 - lat) + Math.Abs(19.63571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.79528 - lat) + Math.Abs(19.59618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62417 - lat) + Math.Abs(19.95156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6221 - lat) + Math.Abs(18.85569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21369 - lat) + Math.Abs(18.53306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.71981 - lat) + Math.Abs(17.01401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75133 - lat) + Math.Abs(18.4001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.71946 - lat) + Math.Abs(17.48474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14722 - lat) + Math.Abs(18.18833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48671 - lat) + Math.Abs(18.31225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.12991 - lat) + Math.Abs(19.43324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75087 - lat) + Math.Abs(19.47259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68711 - lat) + Math.Abs(19.28239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3137 - lat) + Math.Abs(18.75749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29986 - lat) + Math.Abs(19.23057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.59047 - lat) + Math.Abs(17.68904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.76027 - lat) + Math.Abs(18.55694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86017 - lat) + Math.Abs(19.87836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26175 - lat) + Math.Abs(19.50146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.73585 - lat) + Math.Abs(18.35966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.71637 - lat) + Math.Abs(18.76311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.05514 - lat) + Math.Abs(17.87477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34051 - lat) + Math.Abs(19.05115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81667 - lat) + Math.Abs(17.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.70329 - lat) + Math.Abs(18.25751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96737 - lat) + Math.Abs(18.93288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53128 - lat) + Math.Abs(19.28343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.76543 - lat) + Math.Abs(19.84819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.00503 - lat) + Math.Abs(19.0905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.7928 - lat) + Math.Abs(18.95984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27911 - lat) + Math.Abs(18.45489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65 - lat) + Math.Abs(19.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.03419 - lat) + Math.Abs(19.77857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.41514 - lat) + Math.Abs(19.7441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45347 - lat) + Math.Abs(16.99104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.64093 - lat) + Math.Abs(18.0813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62749 - lat) + Math.Abs(18.65565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60435 - lat) + Math.Abs(16.69732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.04248 - lat) + Math.Abs(18.9059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39232 - lat) + Math.Abs(17.51147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22961 - lat) + Math.Abs(17.35788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36422 - lat) + Math.Abs(16.88177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.86789 - lat) + Math.Abs(17.26994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21806 - lat) + Math.Abs(19.8851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37787 - lat) + Math.Abs(18.20353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.35133 - lat) + Math.Abs(19.44733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9902 - lat) + Math.Abs(18.68621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.59748 - lat) + Math.Abs(19.2407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66999 - lat) + Math.Abs(18.18505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51384 - lat) + Math.Abs(17.09507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81109 - lat) + Math.Abs(18.47789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.93184 - lat) + Math.Abs(18.77177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43133 - lat) + Math.Abs(19.45628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21509 - lat) + Math.Abs(19.38102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22468 - lat) + Math.Abs(18.47076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.97421 - lat) + Math.Abs(19.78049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03267 - lat) + Math.Abs(19.94762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.03809 - lat) + Math.Abs(19.98257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31601 - lat) + Math.Abs(18.79045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.58498 - lat) + Math.Abs(17.41196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53352 - lat) + Math.Abs(18.65627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34998 - lat) + Math.Abs(18.2324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44258 - lat) + Math.Abs(19.36438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.6879 - lat) + Math.Abs(18.95791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.0587 - lat) + Math.Abs(19.26121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.30997 - lat) + Math.Abs(18.55177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.73295 - lat) + Math.Abs(19.67867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.10104 - lat) + Math.Abs(18.00454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43301 - lat) + Math.Abs(16.72583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.99036 - lat) + Math.Abs(18.24357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62403 - lat) + Math.Abs(16.53863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.67013 - lat) + Math.Abs(17.64398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.73574 - lat) + Math.Abs(17.39076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.71778 - lat) + Math.Abs(19.08585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00543 - lat) + Math.Abs(18.62526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.87601 - lat) + Math.Abs(19.99504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02133 - lat) + Math.Abs(19.56171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84201 - lat) + Math.Abs(18.33763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20535 - lat) + Math.Abs(17.45419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.74735 - lat) + Math.Abs(18.49623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02699 - lat) + Math.Abs(19.12575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36091 - lat) + Math.Abs(19.41454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.02967 - lat) + Math.Abs(18.2921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38922 - lat) + Math.Abs(16.541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.80791 - lat) + Math.Abs(19.17821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54668 - lat) + Math.Abs(18.32081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01096 - lat) + Math.Abs(16.60596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63053 - lat) + Math.Abs(17.35717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19278 - lat) + Math.Abs(18.26494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.74318 - lat) + Math.Abs(18.11913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48552 - lat) + Math.Abs(19.57876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.00165 - lat) + Math.Abs(19.92067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.6075 - lat) + Math.Abs(18.21517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48427 - lat) + Math.Abs(19.13913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4725 - lat) + Math.Abs(19.97972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28009 - lat) + Math.Abs(19.48954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4515 - lat) + Math.Abs(19.14017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95744 - lat) + Math.Abs(18.38813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.49028 - lat) + Math.Abs(19.74 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18839 - lat) + Math.Abs(19.0093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43402 - lat) + Math.Abs(19.48479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.71213 - lat) + Math.Abs(19.84458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.62139 - lat) + Math.Abs(19.28528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50289 - lat) + Math.Abs(18.03665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.26444 - lat) + Math.Abs(18.2779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81726 - lat) + Math.Abs(17.36642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.64605 - lat) + Math.Abs(17.39362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.71266 - lat) + Math.Abs(18.80177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.76812 - lat) + Math.Abs(17.24317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54757 - lat) + Math.Abs(19.26247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.93722 - lat) + Math.Abs(19.47806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1968 - lat) + Math.Abs(19.61659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.90618 - lat) + Math.Abs(19.69128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52298 - lat) + Math.Abs(18.30939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52528 - lat) + Math.Abs(19.25194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.04952 - lat) + Math.Abs(19.86143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03398 - lat) + Math.Abs(19.20935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.67133 - lat) + Math.Abs(19.542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.15 - lat) + Math.Abs(19.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.16353 - lat) + Math.Abs(19.69686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69076 - lat) + Math.Abs(17.84136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.59224 - lat) + Math.Abs(17.02886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36667 - lat) + Math.Abs(17.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36167 - lat) + Math.Abs(17.704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24004 - lat) + Math.Abs(18.67564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.95464 - lat) + Math.Abs(18.48259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52981 - lat) + Math.Abs(18.97283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.242 - lat) + Math.Abs(19.36467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23623 - lat) + Math.Abs(17.62014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.83238 - lat) + Math.Abs(19.67762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.56685 - lat) + Math.Abs(19.76065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.5 - lat) + Math.Abs(19.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.64238 - lat) + Math.Abs(19.98038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.78621 - lat) + Math.Abs(17.13603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11937 - lat) + Math.Abs(17.16503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29861 - lat) + Math.Abs(19.32583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.74221 - lat) + Math.Abs(19.72132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14249 - lat) + Math.Abs(16.58148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80454 - lat) + Math.Abs(19.35172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1567 - lat) + Math.Abs(18.8203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53011 - lat) + Math.Abs(19.40205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69286 - lat) + Math.Abs(18.18581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.262 - lat) + Math.Abs(19.327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66533 - lat) + Math.Abs(19.4361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16414 - lat) + Math.Abs(18.35077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69081 - lat) + Math.Abs(19.7893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.49697 - lat) + Math.Abs(18.41841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2568 - lat) + Math.Abs(18.4954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63333 - lat) + Math.Abs(19.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79031 - lat) + Math.Abs(17.18408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.16238 - lat) + Math.Abs(19.43295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.13333 - lat) + Math.Abs(17.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.70638 - lat) + Math.Abs(19.63314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95 - lat) + Math.Abs(18.93917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83661 - lat) + Math.Abs(19.62251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.66667 - lat) + Math.Abs(19.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69758 - lat) + Math.Abs(19.0311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85002 - lat) + Math.Abs(18.23668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36173 - lat) + Math.Abs(18.98119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.8893 - lat) + Math.Abs(17.32615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39861 - lat) + Math.Abs(19.12056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.14513 - lat) + Math.Abs(18.01964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60643 - lat) + Math.Abs(17.64875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55256 - lat) + Math.Abs(17.56356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68333 - lat) + Math.Abs(17.63512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.55603 - lat) + Math.Abs(18.47694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81369 - lat) + Math.Abs(19.86724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81724 - lat) + Math.Abs(19.93619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.81505 - lat) + Math.Abs(19.78925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.74161 - lat) + Math.Abs(19.92876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.78257 - lat) + Math.Abs(19.928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42733 - lat) + Math.Abs(19.40133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.77058 - lat) + Math.Abs(17.2866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38449 - lat) + Math.Abs(19.2214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.37095 - lat) + Math.Abs(19.53057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28612 - lat) + Math.Abs(17.97288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.59657 - lat) + Math.Abs(19.35515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68324 - lat) + Math.Abs(19.13417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28496 - lat) + Math.Abs(16.59575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.20942 - lat) + Math.Abs(18.63607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03194 - lat) + Math.Abs(19.04278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69562 - lat) + Math.Abs(19.38724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.61667 - lat) + Math.Abs(19.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82075 - lat) + Math.Abs(19.23748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.6177 - lat) + Math.Abs(19.1887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45504 - lat) + Math.Abs(19.66001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36528 - lat) + Math.Abs(19.90973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.75552 - lat) + Math.Abs(17.57945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.58996 - lat) + Math.Abs(16.87517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.72017 - lat) + Math.Abs(16.6504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.62173 - lat) + Math.Abs(16.87088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19713 - lat) + Math.Abs(19.18686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.34329 - lat) + Math.Abs(19.23698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.29349 - lat) + Math.Abs(18.2646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.36067 - lat) + Math.Abs(19.84619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60633 - lat) + Math.Abs(17.20024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46476 - lat) + Math.Abs(18.81925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44794 - lat) + Math.Abs(18.75328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.7928 - lat) + Math.Abs(18.74148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50207 - lat) + Math.Abs(19.07218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.99619 - lat) + Math.Abs(19.20231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25352 - lat) + Math.Abs(18.98457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.67261 - lat) + Math.Abs(19.30786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39489 - lat) + Math.Abs(18.91361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25194 - lat) + Math.Abs(18.89623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.93046 - lat) + Math.Abs(18.24202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.83094 - lat) + Math.Abs(18.83481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44389 - lat) + Math.Abs(19.3245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.73267 - lat) + Math.Abs(19.76696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39085 - lat) + Math.Abs(18.96296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.91478 - lat) + Math.Abs(18.97127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.27859 - lat) + Math.Abs(19.06617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96479 - lat) + Math.Abs(18.93974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52852 - lat) + Math.Abs(18.81771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.0874 - lat) + Math.Abs(18.7587 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.644 - lat) + Math.Abs(18.99632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63641 - lat) + Math.Abs(19.13864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.3545 - lat) + Math.Abs(19.09822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80713 - lat) + Math.Abs(18.92763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.79052 - lat) + Math.Abs(19.04125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.72868 - lat) + Math.Abs(18.32235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.72095 - lat) + Math.Abs(18.73641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.09005 - lat) + Math.Abs(19.01106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65552 - lat) + Math.Abs(19.43229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37657 - lat) + Math.Abs(18.13696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03333 - lat) + Math.Abs(17.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42178 - lat) + Math.Abs(18.23953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.93968 - lat) + Math.Abs(19.04317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4095 - lat) + Math.Abs(18.94898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.10316 - lat) + Math.Abs(17.43802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24135 - lat) + Math.Abs(19.09019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86807 - lat) + Math.Abs(18.45042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28428 - lat) + Math.Abs(18.76 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.995 - lat) + Math.Abs(18.91722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52 - lat) + Math.Abs(19.544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.21486 - lat) + Math.Abs(19.54695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.18594 - lat) + Math.Abs(19.31091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25314 - lat) + Math.Abs(17.1006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.61155 - lat) + Math.Abs(17.25012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.97709 - lat) + Math.Abs(17.91819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55 - lat) + Math.Abs(19.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69116 - lat) + Math.Abs(18.71611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.64637 - lat) + Math.Abs(18.96189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31806 - lat) + Math.Abs(17.99208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80165 - lat) + Math.Abs(17.22096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.40098 - lat) + Math.Abs(16.70881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.71543 - lat) + Math.Abs(19.26802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.54234 - lat) + Math.Abs(19.86358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11799 - lat) + Math.Abs(19.69092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18917 - lat) + Math.Abs(19.14667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42194 - lat) + Math.Abs(19.18361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.498 - lat) + Math.Abs(18.14272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.64829 - lat) + Math.Abs(19.82972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39184 - lat) + Math.Abs(18.46501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.01356 - lat) + Math.Abs(17.29108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.25713 - lat) + Math.Abs(17.15027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.2237 - lat) + Math.Abs(19.66828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.17266 - lat) + Math.Abs(19.79952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.77056 - lat) + Math.Abs(18.62826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.10751 - lat) + Math.Abs(17.9882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38486 - lat) + Math.Abs(16.75065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.88352 - lat) + Math.Abs(19.54381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.22748 - lat) + Math.Abs(19.14664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.68704 - lat) + Math.Abs(19.68074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49835 - lat) + Math.Abs(19.04045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46181 - lat) + Math.Abs(18.95845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51083 - lat) + Math.Abs(18.92717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.61667 - lat) + Math.Abs(19.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65174 - lat) + Math.Abs(19.4785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68821 - lat) + Math.Abs(17.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31843 - lat) + Math.Abs(19.92306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29921 - lat) + Math.Abs(18.53024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.65 - lat) + Math.Abs(17.86977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96722 - lat) + Math.Abs(18.51833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.60285 - lat) + Math.Abs(19.68839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.74102 - lat) + Math.Abs(18.96736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49186 - lat) + Math.Abs(18.24743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41345 - lat) + Math.Abs(17.38037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38638 - lat) + Math.Abs(18.82962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32352 - lat) + Math.Abs(18.23312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48419 - lat) + Math.Abs(18.64404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.4706 - lat) + Math.Abs(18.81892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20907 - lat) + Math.Abs(17.1481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.11131 - lat) + Math.Abs(18.12948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.79108 - lat) + Math.Abs(18.43263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.87057 - lat) + Math.Abs(19.40715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.46594 - lat) + Math.Abs(17.09294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.44755 - lat) + Math.Abs(16.7771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.488 - lat) + Math.Abs(18.95419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.96962 - lat) + Math.Abs(19.84076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19373 - lat) + Math.Abs(18.72307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12864 - lat) + Math.Abs(18.77027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96 - lat) + Math.Abs(17.45861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.28225 - lat) + Math.Abs(18.75853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88202 - lat) + Math.Abs(18.90658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.12213 - lat) + Math.Abs(17.7812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.86216 - lat) + Math.Abs(19.57092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.82946 - lat) + Math.Abs(17.82426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.89397 - lat) + Math.Abs(18.13737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.78318 - lat) + Math.Abs(17.69498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.04019 - lat) + Math.Abs(18.10671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.96188 - lat) + Math.Abs(17.87187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.85255 - lat) + Math.Abs(17.88123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.71542 - lat) + Math.Abs(17.49223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.77525 - lat) + Math.Abs(17.64415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.70701 - lat) + Math.Abs(17.32013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.03526 - lat) + Math.Abs(18.02076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(48.07296 - lat) + Math.Abs(19.29614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.38901 - lat) + Math.Abs(17.80321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.32395 - lat) + Math.Abs(18.07509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.654 - lat) + Math.Abs(18.5972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18299 - lat) + Math.Abs(18.95307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.64593 - lat) + Math.Abs(18.3641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.63333 - lat) + Math.Abs(19.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80711 - lat) + Math.Abs(17.51385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.125 - lat) + Math.Abs(19.15621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12648 - lat) + Math.Abs(19.3326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.64361 - lat) + Math.Abs(17.97798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.04155 - lat) + Math.Abs(17.34332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.82733 - lat) + Math.Abs(17.49418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19875 - lat) + Math.Abs(19.78334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.88208 - lat) + Math.Abs(18.9621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.79419 - lat) + Math.Abs(19.69429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.31524 - lat) + Math.Abs(19.15843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.72752 - lat) + Math.Abs(18.26153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.24315 - lat) + Math.Abs(19.61686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.79915 - lat) + Math.Abs(18.68938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.69167 - lat) + Math.Abs(19.20423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.10196 - lat) + Math.Abs(17.55892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.68991 - lat) + Math.Abs(16.51658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.84025 - lat) + Math.Abs(19.45208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.1194 - lat) + Math.Abs(18.86493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.85931 - lat) + Math.Abs(18.16442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.6921 - lat) + Math.Abs(19.97696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.79425 - lat) + Math.Abs(19.38795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.71231 - lat) + Math.Abs(18.01131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.69464 - lat) + Math.Abs(17.54489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.02907 - lat) + Math.Abs(18.52172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.81279 - lat) + Math.Abs(19.99841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49192 - lat) + Math.Abs(19.01493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47603 - lat) + Math.Abs(19.03605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48919 - lat) + Math.Abs(19.07012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.50369 - lat) + Math.Abs(19.06583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52978 - lat) + Math.Abs(19.08068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56182 - lat) + Math.Abs(19.08909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56263 - lat) + Math.Abs(19.11681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51482 - lat) + Math.Abs(19.17028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.45293 - lat) + Math.Abs(19.14943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.44417 - lat) + Math.Abs(19.17595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.39788 - lat) + Math.Abs(19.11492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.42698 - lat) + Math.Abs(19.04016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43047 - lat) + Math.Abs(19.07098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.43674 - lat) + Math.Abs(19.10093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.47997 - lat) + Math.Abs(19.25388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.54157 - lat) + Math.Abs(19.04501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.51984 - lat) + Math.Abs(19.02218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.49705 - lat) + Math.Abs(19.03961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33472 - lat) + Math.Abs(20.20849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.80259 - lat) + Math.Abs(20.20283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.83742 - lat) + Math.Abs(19.00463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.08047 - lat) + Math.Abs(16.8538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.9294 - lat) + Math.Abs(19.10926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.58608 - lat) + Math.Abs(17.4238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.78017 - lat) + Math.Abs(19.58519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28741 - lat) + Math.Abs(17.36003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.72778 - lat) + Math.Abs(17.42784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.53076 - lat) + Math.Abs(18.07526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56008 - lat) + Math.Abs(19.28289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.56031 - lat) + Math.Abs(18.92 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.52821 - lat) + Math.Abs(17.09061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.55707 - lat) + Math.Abs(20.71949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(47.48938 - lat) + Math.Abs(19.07292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Záhony", "18", 48.40906, 22.17614);
case 1: return new CityInfo("Zagyvarékas", "20", 47.26667, 20.13333);
case 2: return new CityInfo("Vésztő", "03", 46.91667, 21.26667);
case 3: return new CityInfo("Verpelét", "11", 47.85, 20.23333);
case 4: return new CityInfo("Vásárosnamény", "18", 48.12542, 22.31325);
case 5: return new CityInfo("Vámospércs", "10", 47.53333, 21.9);
case 6: return new CityInfo("Vaja", "18", 48.00574, 22.16761);
case 7: return new CityInfo("Újszász", "20", 47.3, 20.08333);
case 8: return new CityInfo("Újkígyós", "03", 46.58333, 21.03333);
case 9: return new CityInfo("Újfehértó", "18", 47.8, 21.68333);
case 10: return new CityInfo("Újdombrád", "18", 48.19527, 21.87035);
case 11: return new CityInfo("Tyukod", "18", 47.85378, 22.5633);
case 12: return new CityInfo("Tuzsér", "18", 48.34407, 22.11762);
case 13: return new CityInfo("Túrkeve", "20", 47.1, 20.75);
case 14: return new CityInfo("Tunyogmatolcs", "18", 47.96667, 22.46667);
case 15: return new CityInfo("Tótkomlós", "03", 46.41667, 20.73333);
case 16: return new CityInfo("Tószeg", "20", 47.1, 20.15);
case 17: return new CityInfo("Törökszentmiklós", "20", 47.18333, 20.41667);
case 18: return new CityInfo("Tornyospálca", "18", 48.26667, 22.18333);
case 19: return new CityInfo("Tömörkény", "06", 46.61716, 20.04357);
case 20: return new CityInfo("Tolcsva", "04", 48.28333, 21.45);
case 21: return new CityInfo("Tokaj", "04", 48.11667, 21.41667);
case 22: return new CityInfo("Tiszavasvári", "18", 47.96667, 21.35);
case 23: return new CityInfo("Tiszaújváros", "04", 47.93333, 21.08333);
case 24: return new CityInfo("Tiszaszentimre", "20", 47.48333, 20.73333);
case 25: return new CityInfo("Tiszasüly", "20", 47.38333, 20.4);
case 26: return new CityInfo("Tiszaroff", "20", 47.4, 20.45);
case 27: return new CityInfo("Tiszapüspöki", "20", 47.21667, 20.31667);
case 28: return new CityInfo("Tiszanána", "11", 47.56667, 20.53333);
case 29: return new CityInfo("Tiszanagyfalu", "18", 48.1, 21.48333);
case 30: return new CityInfo("Tiszalúc", "04", 48.03774, 21.07261);
case 31: return new CityInfo("Tiszalök", "18", 48.01667, 21.38333);
case 32: return new CityInfo("Tiszakeszi", "04", 47.78333, 21);
case 33: return new CityInfo("Tiszakécske", "01", 46.93261, 20.10349);
case 34: return new CityInfo("Tiszakarád", "04", 48.2, 21.71667);
case 35: return new CityInfo("Tiszafüred", "20", 47.61667, 20.76667);
case 36: return new CityInfo("Tiszaföldvár", "20", 46.98333, 20.25);
case 37: return new CityInfo("Tiszaeszlár", "18", 48.05, 21.46667);
case 38: return new CityInfo("Tiszadob", "18", 48.01667, 21.16667);
case 39: return new CityInfo("Tiszadada", "18", 48.03333, 21.25);
case 40: return new CityInfo("Tiszacsege", "10", 47.7, 21);
case 41: return new CityInfo("Tiszabura", "20", 47.45, 20.46667);
case 42: return new CityInfo("Tiszabő", "20", 47.3, 20.48333);
case 43: return new CityInfo("Tiszabezdéd", "18", 48.36667, 22.15);
case 44: return new CityInfo("Tiszabercel", "18", 48.15, 21.65);
case 45: return new CityInfo("Téglás", "10", 47.71667, 21.68333);
case 46: return new CityInfo("Tarpa", "18", 48.1048, 22.53744);
case 47: return new CityInfo("Tarnaörs", "11", 47.59499, 20.05254);
case 48: return new CityInfo("Tarnalelesz", "11", 48.05, 20.18333);
case 49: return new CityInfo("Tarcal", "04", 48.13333, 21.35);
case 50: return new CityInfo("Tállya", "04", 48.23333, 21.23333);
case 51: return new CityInfo("Taktaszada", "04", 48.11667, 21.18333);
case 52: return new CityInfo("Taktaharkány", "04", 48.08333, 21.13333);
case 53: return new CityInfo("Szolnok", "20", 47.18333, 20.2);
case 54: return new CityInfo("Szirmabesenyő", "04", 48.15, 20.8);
case 55: return new CityInfo("Szilvásvárad", "11", 48.1, 20.4);
case 56: return new CityInfo("Szikszó", "04", 48.2, 20.93333);
case 57: return new CityInfo("Szihalom", "11", 47.76667, 20.48333);
case 58: return new CityInfo("Szerencs", "04", 48.15993, 21.2097);
case 59: return new CityInfo("Szentistván", "04", 47.76667, 20.66667);
case 60: return new CityInfo("Szentes", "06", 46.65834, 20.2608);
case 61: return new CityInfo("Szendrő", "04", 48.4, 20.73333);
case 62: return new CityInfo("Székkutas", "06", 46.5, 20.53333);
case 63: return new CityInfo("Szegvár", "06", 46.5874, 20.22408);
case 64: return new CityInfo("Szeghalom", "03", 47.03333, 21.16667);
case 65: return new CityInfo("Szeged", "06", 46.253, 20.14824);
case 66: return new CityInfo("Szatymaz", "06", 46.34306, 20.0402);
case 67: return new CityInfo("Szarvas", "03", 46.86667, 20.55);
case 68: return new CityInfo("Szamosszeg", "18", 48.04561, 22.36582);
case 69: return new CityInfo("Szakoly", "18", 47.76667, 21.91667);
case 70: return new CityInfo("Szajol", "20", 47.18333, 20.3);
case 71: return new CityInfo("Szabadkígyós", "03", 46.61667, 21.1);
case 72: return new CityInfo("Sirok", "11", 47.93333, 20.2);
case 73: return new CityInfo("Sátoraljaújhely", "04", 48.39492, 21.65871);
case 74: return new CityInfo("Sárrétudvari", "10", 47.23333, 21.2);
case 75: return new CityInfo("Sárospatak", "04", 48.3245, 21.57383);
case 76: return new CityInfo("Sarkad", "03", 46.75, 21.38333);
case 77: return new CityInfo("Sáránd", "10", 47.4, 21.63333);
case 78: return new CityInfo("Sándorfalva", "06", 46.36087, 20.09889);
case 79: return new CityInfo("Sály", "04", 47.95, 20.66667);
case 80: return new CityInfo("Sajóvámos", "04", 48.18171, 20.83149);
case 81: return new CityInfo("Sajószöged", "04", 47.95, 21);
case 82: return new CityInfo("Sajószentpéter", "04", 48.21667, 20.71667);
case 83: return new CityInfo("Sajóörös", "04", 47.95, 21.03333);
case 84: return new CityInfo("Sajólád", "04", 48.05, 20.9);
case 85: return new CityInfo("Sajókaza", "04", 48.28333, 20.58333);
case 86: return new CityInfo("Sajóbábony", "04", 48.16667, 20.73333);
case 87: return new CityInfo("Rudabánya", "04", 48.38333, 20.63333);
case 88: return new CityInfo("Röszke", "06", 46.18796, 20.03372);
case 89: return new CityInfo("Ricse", "04", 48.32565, 21.97069);
case 90: return new CityInfo("Recsk", "11", 47.93333, 20.11667);
case 91: return new CityInfo("Rákócziújfalu", "20", 47.06667, 20.26667);
case 92: return new CityInfo("Rákóczifalva", "20", 47.08333, 20.23333);
case 93: return new CityInfo("Rakamaz", "18", 48.12372, 21.46429);
case 94: return new CityInfo("Putnok", "04", 48.3, 20.43333);
case 95: return new CityInfo("Pusztaföldvár", "03", 46.53333, 20.8);
case 96: return new CityInfo("Püspökladány", "10", 47.31667, 21.11667);
case 97: return new CityInfo("Prügy", "04", 48.08333, 21.25);
case 98: return new CityInfo("Poroszló", "11", 47.65, 20.66667);
case 99: return new CityInfo("Porcsalma", "18", 47.88333, 22.56667);
case 100: return new CityInfo("Polgár", "10", 47.86667, 21.11667);
case 101: return new CityInfo("Pocsaj", "10", 47.28333, 21.81667);
case 102: return new CityInfo("Petneháza", "18", 48.06084, 22.07485);
case 103: return new CityInfo("Pétervására", "11", 48.01667, 20.1);
case 104: return new CityInfo("Pátroha", "18", 48.16667, 22);
case 105: return new CityInfo("Parád", "11", 47.92323, 20.02972);
case 106: return new CityInfo("Ózd", "04", 48.21667, 20.3);
case 107: return new CityInfo("Ostoros", "11", 47.86667, 20.43333);
case 108: return new CityInfo("Orosháza", "03", 46.56667, 20.66667);
case 109: return new CityInfo("Ópusztaszer", "06", 46.48592, 20.08722);
case 110: return new CityInfo("Ópályi", "18", 47.99771, 22.32617);
case 111: return new CityInfo("Ónod", "04", 48, 20.91667);
case 112: return new CityInfo("Onga", "04", 48.11667, 20.91667);
case 113: return new CityInfo("Olaszliszka", "04", 48.25, 21.43333);
case 114: return new CityInfo("Ököritófülpös", "18", 47.91862, 22.5081);
case 115: return new CityInfo("Okány", "03", 46.9, 21.35);
case 116: return new CityInfo("Ófehértó", "18", 47.93333, 22.05);
case 117: return new CityInfo("Öcsöd", "20", 46.9, 20.4);
case 118: return new CityInfo("Nyírvasvári", "18", 47.81667, 22.18683);
case 119: return new CityInfo("Nyírtelek", "18", 48.01667, 21.63333);
case 120: return new CityInfo("Nyírtass", "18", 48.11667, 22.03333);
case 121: return new CityInfo("Nyírpazony", "18", 47.98333, 21.8);
case 122: return new CityInfo("Nyírmihálydi", "18", 47.73976, 21.96445);
case 123: return new CityInfo("Nyírmeggyes", "18", 47.91667, 22.26667);
case 124: return new CityInfo("Nyírmártonfalva", "10", 47.58333, 21.9);
case 125: return new CityInfo("Nyírmada", "18", 48.06667, 22.2);
case 126: return new CityInfo("Nyírlugos", "18", 47.69315, 22.04476);
case 127: return new CityInfo("Nyírkarász", "18", 48.09477, 22.10463);
case 128: return new CityInfo("Nyírgyulaj", "18", 47.88622, 22.09781);
case 129: return new CityInfo("Nyíregyháza", "18", 47.95539, 21.71671);
case 130: return new CityInfo("Nyírcsaholy", "18", 47.90383, 22.3363);
case 131: return new CityInfo("Nyírbogdány", "18", 48.05723, 21.88242);
case 132: return new CityInfo("Nyírbogát", "18", 47.8034, 22.06561);
case 133: return new CityInfo("Nyírbéltek", "18", 47.7, 22.13333);
case 134: return new CityInfo("Nyírbátor", "18", 47.83333, 22.13333);
case 135: return new CityInfo("Nyíradony", "10", 47.69746, 21.91878);
case 136: return new CityInfo("Nyíracsád", "10", 47.6033, 21.97208);
case 137: return new CityInfo("Nyírábrány", "10", 47.55311, 22.02401);
case 138: return new CityInfo("Nyékládháza", "04", 47.98333, 20.83333);
case 139: return new CityInfo("Napkor", "18", 47.93797, 21.86763);
case 140: return new CityInfo("Nagyszénás", "03", 46.68333, 20.66667);
case 141: return new CityInfo("Kardos", "03", 46.79777, 20.7179);
case 142: return new CityInfo("Nagyrábé", "10", 47.2, 21.33333);
case 143: return new CityInfo("Nagykálló", "18", 47.87491, 21.84082);
case 144: return new CityInfo("Nagyhalász", "18", 48.13266, 21.76104);
case 145: return new CityInfo("Nagyecsed", "18", 47.86547, 22.39159);
case 146: return new CityInfo("Nagydobos", "18", 48.05759, 22.30423);
case 147: return new CityInfo("Nagycserkesz", "18", 47.96667, 21.53333);
case 148: return new CityInfo("Nádudvar", "10", 47.41667, 21.16667);
case 149: return new CityInfo("Múcsony", "04", 48.26667, 20.68333);
case 150: return new CityInfo("Monostorpályi", "10", 47.4, 21.78333);
case 151: return new CityInfo("Monok", "04", 48.21102, 21.15052);
case 152: return new CityInfo("Miskolc", "04", 48.10306, 20.77806);
case 153: return new CityInfo("Mindszent", "06", 46.52362, 20.19038);
case 154: return new CityInfo("Mikepércs", "10", 47.45, 21.63333);
case 155: return new CityInfo("Mezőzombor", "04", 48.15, 21.26667);
case 156: return new CityInfo("Mezőtúr", "20", 47, 20.63333);
case 157: return new CityInfo("Mezőkövesd", "04", 47.81667, 20.58333);
case 158: return new CityInfo("Mezőkovácsháza", "03", 46.4, 20.91667);
case 159: return new CityInfo("Mezőkeresztes", "04", 47.83333, 20.7);
case 160: return new CityInfo("Mezőhegyes", "03", 46.31667, 20.81667);
case 161: return new CityInfo("Mezőcsát", "04", 47.81667, 20.91667);
case 162: return new CityInfo("Mezőberény", "03", 46.81667, 21.03333);
case 163: return new CityInfo("Mérk", "18", 47.78824, 22.38038);
case 164: return new CityInfo("Méhkerék", "03", 46.78333, 21.45);
case 165: return new CityInfo("Megyaszó", "04", 48.18333, 21.05);
case 166: return new CityInfo("Medgyesegyháza", "03", 46.5, 21.03333);
case 167: return new CityInfo("Mátraderecske", "11", 47.95, 20.08333);
case 168: return new CityInfo("Mátészalka", "18", 47.95528, 22.32348);
case 169: return new CityInfo("Maroslele", "06", 46.26667, 20.35);
case 170: return new CityInfo("Máriapócs", "18", 47.88303, 22.02501);
case 171: return new CityInfo("Mándok", "18", 48.32149, 22.19107);
case 172: return new CityInfo("Mályinka", "04", 48.15498, 20.4956);
case 173: return new CityInfo("Mályi", "04", 48.01667, 20.83333);
case 174: return new CityInfo("Makó", "06", 46.21667, 20.48333);
case 175: return new CityInfo("Maklár", "11", 47.8, 20.41667);
case 176: return new CityInfo("Magyarbánhegyes", "03", 46.45, 20.96667);
case 177: return new CityInfo("Mád", "04", 48.19442, 21.28208);
case 178: return new CityInfo("Lőkösháza", "03", 46.43333, 21.23333);
case 179: return new CityInfo("Levelek", "18", 47.96282, 21.98537);
case 180: return new CityInfo("Létavértes", "10", 47.38333, 21.9);
case 181: return new CityInfo("Kunszentmárton", "20", 46.83916, 20.28879);
case 182: return new CityInfo("Kunmadaras", "20", 47.43333, 20.8);
case 183: return new CityInfo("Kunhegyes", "20", 47.36667, 20.63333);
case 184: return new CityInfo("Kunágota", "03", 46.43333, 21.05);
case 185: return new CityInfo("Kótaj", "18", 48.05, 21.71667);
case 186: return new CityInfo("Köröstarcsa", "03", 46.88333, 21.03333);
case 187: return new CityInfo("Körösladány", "03", 46.96667, 21.08333);
case 188: return new CityInfo("Konyár", "10", 47.31667, 21.66667);
case 189: return new CityInfo("Kondoros", "03", 46.76667, 20.8);
case 190: return new CityInfo("Kompolt", "11", 47.73333, 20.25);
case 191: return new CityInfo("Komádi", "10", 47, 21.5);
case 192: return new CityInfo("Kocsord", "18", 47.93912, 22.38333);
case 193: return new CityInfo("Kiszombor", "06", 46.18333, 20.43333);
case 194: return new CityInfo("Kisvárda", "18", 48.21667, 22.08333);
case 195: return new CityInfo("Kisújszállás", "20", 47.21667, 20.76667);
case 196: return new CityInfo("Kisléta", "18", 47.84244, 22.00393);
case 197: return new CityInfo("Kisköre", "11", 47.5, 20.5);
case 198: return new CityInfo("Kevermes", "03", 46.41667, 21.18333);
case 199: return new CityInfo("Kétegyháza", "03", 46.53333, 21.18333);
case 200: return new CityInfo("Kerecsend", "11", 47.8, 20.35);
case 201: return new CityInfo("Kengyel", "20", 47.08333, 20.33333);
case 202: return new CityInfo("Kenderes", "20", 47.25, 20.68333);
case 203: return new CityInfo("Kemecse", "18", 48.07532, 21.80625);
case 204: return new CityInfo("Kék", "18", 48.11667, 21.88333);
case 205: return new CityInfo("Kazincbarcika", "04", 48.25, 20.63333);
case 206: return new CityInfo("Kaszaper", "03", 46.46667, 20.83333);
case 207: return new CityInfo("Kardos", "06", 46.23333, 20.61667);
case 208: return new CityInfo("Karcsa", "04", 48.3113, 21.80537);
case 209: return new CityInfo("Karcag", "20", 47.31667, 20.93333);
case 210: return new CityInfo("Karácsond", "11", 47.72962, 20.03076);
case 211: return new CityInfo("Kántorjánosi", "18", 47.93333, 22.15);
case 212: return new CityInfo("Kálmánháza", "18", 47.88333, 21.58333);
case 213: return new CityInfo("Kállósemjén", "18", 47.86081, 21.93929);
case 214: return new CityInfo("Kál", "11", 47.73333, 20.26667);
case 215: return new CityInfo("Kaba", "10", 47.35, 21.28333);
case 216: return new CityInfo("Jászszentandrás", "20", 47.58333, 20.18333);
case 217: return new CityInfo("Jászladány", "20", 47.36667, 20.16667);
case 218: return new CityInfo("Jászkisér", "20", 47.45, 20.21667);
case 219: return new CityInfo("Jászkarajenő", "16", 47.05, 20.06667);
case 220: return new CityInfo("Jászjákóhalma", "20", 47.52038, 19.99086);
case 221: return new CityInfo("Jászdózsa", "20", 47.5661, 20.01534);
case 222: return new CityInfo("Jászapáti", "20", 47.51667, 20.15);
case 223: return new CityInfo("Jászalsószentgyörgy", "20", 47.36667, 20.1);
case 224: return new CityInfo("Járdánháza", "04", 48.15, 20.25);
case 225: return new CityInfo("Jánoshida", "20", 47.38333, 20.06667);
case 226: return new CityInfo("Izsófalva", "04", 48.3, 20.66667);
case 227: return new CityInfo("Ibrány", "18", 48.12329, 21.70953);
case 228: return new CityInfo("Hosszúpályi", "10", 47.39303, 21.7328);
case 229: return new CityInfo("Hortobágy", "10", 47.58278, 21.15108);
case 230: return new CityInfo("Hódmezővásárhely", "06", 46.41667, 20.33333);
case 231: return new CityInfo("Hodász", "18", 47.91834, 22.20153);
case 232: return new CityInfo("Heves", "11", 47.6, 20.28333);
case 233: return new CityInfo("Hernádnémeti", "04", 48.06667, 20.98333);
case 234: return new CityInfo("Hejőbába", "04", 47.9, 20.95);
case 235: return new CityInfo("Harsány", "04", 47.96667, 20.75);
case 236: return new CityInfo("Halmaj", "04", 48.25, 21);
case 237: return new CityInfo("Hajdúszovát", "10", 47.38333, 21.48333);
case 238: return new CityInfo("Hajdúszoboszló", "10", 47.45, 21.4);
case 239: return new CityInfo("Hajdúsámson", "10", 47.6, 21.76667);
case 240: return new CityInfo("Hajdúnánás", "10", 47.85, 21.43333);
case 241: return new CityInfo("Hajdúhadház", "10", 47.68333, 21.66667);
case 242: return new CityInfo("Hajdúdorog", "10", 47.81667, 21.5);
case 243: return new CityInfo("Hajdúböszörmény", "10", 47.66667, 21.51667);
case 244: return new CityInfo("Hajdúbagos", "10", 47.39295, 21.66551);
case 245: return new CityInfo("Gyulaháza", "18", 48.13333, 22.11667);
case 246: return new CityInfo("Gyula", "03", 46.65, 21.28333);
case 247: return new CityInfo("Gyomaendrőd", "03", 46.93333, 20.83333);
case 248: return new CityInfo("Görbeháza", "10", 47.83333, 21.23333);
case 249: return new CityInfo("Gönc", "04", 48.46667, 21.28333);
case 250: return new CityInfo("Gesztely", "04", 48.1, 20.96667);
case 251: return new CityInfo("Gégény", "18", 48.15, 21.95);
case 252: return new CityInfo("Gádoros", "03", 46.66667, 20.6);
case 253: return new CityInfo("Füzesgyarmat", "03", 47.1, 21.21667);
case 254: return new CityInfo("Füzesabony", "11", 47.75, 20.41667);
case 255: return new CityInfo("Földes", "10", 47.3, 21.36667);
case 256: return new CityInfo("Földeák", "06", 46.31667, 20.5);
case 257: return new CityInfo("Fényeslitke", "18", 48.27133, 22.10009);
case 258: return new CityInfo("Felsőzsolca", "04", 48.1, 20.86667);
case 259: return new CityInfo("Felsőtárkány", "11", 47.96667, 20.41667);
case 260: return new CityInfo("Fehérgyarmat", "18", 47.98333, 22.51667);
case 261: return new CityInfo("Fegyvernek", "20", 47.26667, 20.53333);
case 262: return new CityInfo("Farkaslyuk", "04", 48.18333, 20.31667);
case 263: return new CityInfo("Fábiánsebestyén", "06", 46.68333, 20.46667);
case 264: return new CityInfo("Erdőtelek", "11", 47.68333, 20.31667);
case 265: return new CityInfo("Encsencs", "18", 47.73333, 22.11667);
case 266: return new CityInfo("Encs", "04", 48.33333, 21.13333);
case 267: return new CityInfo("Emőd", "04", 47.93333, 20.81667);
case 268: return new CityInfo("Elek", "03", 46.53333, 21.25);
case 269: return new CityInfo("Egyek", "10", 47.63333, 20.9);
case 270: return new CityInfo("Egerszalók", "11", 47.86667, 20.33333);
case 271: return new CityInfo("Eger", "11", 47.90265, 20.37329);
case 272: return new CityInfo("Edelény", "04", 48.3, 20.73333);
case 273: return new CityInfo("Ebes", "10", 47.46667, 21.5);
case 274: return new CityInfo("Domoszló", "11", 47.83333, 20.11667);
case 275: return new CityInfo("Dombrád", "18", 48.23333, 21.93333);
case 276: return new CityInfo("Dombegyház", "03", 46.33333, 21.13333);
case 277: return new CityInfo("Domaszék", "06", 46.24917, 20.01111);
case 278: return new CityInfo("Döge", "18", 48.26246, 22.06339);
case 279: return new CityInfo("Doboz", "03", 46.73333, 21.25);
case 280: return new CityInfo("Dévaványa", "03", 47.03333, 20.96667);
case 281: return new CityInfo("Deszk", "06", 46.21802, 20.24322);
case 282: return new CityInfo("Derecske", "10", 47.35, 21.56667);
case 283: return new CityInfo("Demecser", "18", 48.11648, 21.92624);
case 284: return new CityInfo("Debrecen", "10", 47.53167, 21.62444);
case 285: return new CityInfo("Csorvás", "03", 46.63333, 20.83333);
case 286: return new CityInfo("Csongrád", "06", 46.71332, 20.14241);
case 287: return new CityInfo("Csökmő", "10", 47.03333, 21.3);
case 288: return new CityInfo("Csincse", "04", 47.887, 20.76811);
case 289: return new CityInfo("Cserkeszőlő", "20", 46.8632, 20.18701);
case 290: return new CityInfo("Csenger", "18", 47.83582, 22.68096);
case 291: return new CityInfo("Csanytelek", "06", 46.59501, 20.12342);
case 292: return new CityInfo("Csanádpalota", "06", 46.25, 20.73333);
case 293: return new CityInfo("Csanádapáca", "03", 46.55, 20.88333);
case 294: return new CityInfo("Cigánd", "04", 48.25561, 21.89195);
case 295: return new CityInfo("Cibakháza", "20", 46.95976, 20.19753);
case 296: return new CityInfo("Buj", "18", 48.1, 21.65);
case 297: return new CityInfo("Bucsa", "03", 47.2, 21);
case 298: return new CityInfo("Borsodnádasd", "04", 48.11667, 20.25);
case 299: return new CityInfo("Boldva", "04", 48.21667, 20.8);
case 300: return new CityInfo("Bököny", "18", 47.73333, 21.75);
case 301: return new CityInfo("Bogács", "04", 47.9, 20.53333);
case 302: return new CityInfo("Bőcs", "04", 48.05, 20.96667);
case 303: return new CityInfo("Biharnagybajom", "10", 47.21667, 21.23333);
case 304: return new CityInfo("Biharkeresztes", "10", 47.13333, 21.71667);
case 305: return new CityInfo("Besenyszög", "20", 47.3, 20.26667);
case 306: return new CityInfo("Besenyőtelek", "11", 47.7, 20.43333);
case 307: return new CityInfo("Berettyóújfalu", "10", 47.21667, 21.55);
case 308: return new CityInfo("Bélapátfalva", "11", 48.05, 20.36667);
case 309: return new CityInfo("Békésszentandrás", "03", 46.86667, 20.48333);
case 310: return new CityInfo("Békéssámson", "03", 46.41667, 20.63333);
case 311: return new CityInfo("Békéscsaba", "03", 46.68333, 21.1);
case 312: return new CityInfo("Békés", "03", 46.76667, 21.13333);
case 313: return new CityInfo("Bekecs", "04", 48.15, 21.18333);
case 314: return new CityInfo("Battonya", "03", 46.28333, 21.01667);
case 315: return new CityInfo("Báránd", "10", 47.3, 21.23333);
case 316: return new CityInfo("Balmazújváros", "10", 47.61667, 21.35);
case 317: return new CityInfo("Balkány", "18", 47.77066, 21.86314);
case 318: return new CityInfo("Balástya", "06", 46.42277, 20.00816);
case 319: return new CityInfo("Baktalórántháza", "18", 48, 22.08333);
case 320: return new CityInfo("Baks", "06", 46.54297, 20.10213);
case 321: return new CityInfo("Bagamér", "10", 47.44882, 21.989);
case 322: return new CityInfo("Aszaló", "04", 48.21667, 20.96667);
case 323: return new CityInfo("Arnót", "04", 48.13058, 20.85832);
case 324: return new CityInfo("Arló", "04", 48.18333, 20.26667);
case 325: return new CityInfo("Aranyosapáti", "18", 48.20595, 22.25916);
case 326: return new CityInfo("Bátorliget", "18", 47.76218, 22.27255);
case 327: return new CityInfo("Apátfalva", "06", 46.16667, 20.58333);
case 328: return new CityInfo("Apagy", "18", 47.96431, 21.93539);
case 329: return new CityInfo("Andornaktálya", "11", 47.85, 20.41667);
case 330: return new CityInfo("Anarcs", "18", 48.17642, 22.11167);
case 331: return new CityInfo("Ambrózfalva", "06", 46.35, 20.73333);
case 332: return new CityInfo("Alsózsolca", "04", 48.06982, 20.88046);
case 333: return new CityInfo("Alattyán", "20", 47.42705, 20.04219);
case 334: return new CityInfo("Ajak", "18", 48.17664, 22.06273);
case 335: return new CityInfo("Abony", "16", 47.1899, 20.00476);
case 336: return new CityInfo("Abaújszántó", "04", 48.28333, 21.2);
case 337: return new CityInfo("Abasár", "11", 47.79705, 20.00324);
case 338: return new CityInfo("Abádszalók", "20", 47.46667, 20.6);
case 339: return new CityInfo("Zugló", "05", 47.51758, 19.10549);
case 340: return new CityInfo("Zsombó", "06", 46.32566, 19.97464);
case 341: return new CityInfo("Zsámbok", "16", 47.54381, 19.61048);
case 342: return new CityInfo("Zsámbék", "16", 47.54814, 18.72011);
case 343: return new CityInfo("Zomba", "21", 46.41084, 18.56577);
case 344: return new CityInfo("Zirc", "23", 47.26362, 17.87373);
case 345: return new CityInfo("Zánka", "23", 46.87146, 17.68473);
case 346: return new CityInfo("Zámoly", "08", 47.31667, 18.4081);
case 347: return new CityInfo("Zamárdi", "17", 46.88488, 17.95366);
case 348: return new CityInfo("Zalaszentgrót", "24", 46.94474, 17.07925);
case 349: return new CityInfo("Zalalövő", "24", 46.84802, 16.5875);
case 350: return new CityInfo("Zalakomár", "24", 46.53795, 17.18094);
case 351: return new CityInfo("Zalaegerszeg", "24", 46.84, 16.84389);
case 352: return new CityInfo("Zákányszék", "06", 46.27453, 19.88975);
case 353: return new CityInfo("Zagyvaszántó", "11", 47.77703, 19.67092);
case 354: return new CityInfo("Vonyarcvashegy", "24", 46.75742, 17.31172);
case 355: return new CityInfo("Visegrád", "16", 47.78526, 18.9709);
case 356: return new CityInfo("Villány", "02", 45.86889, 18.45389);
case 357: return new CityInfo("Veszprém", "23", 47.09327, 17.91149);
case 358: return new CityInfo("Vértesszőlős", "12", 47.62106, 18.3813);
case 359: return new CityInfo("Verőce", "16", 47.82468, 19.03484);
case 360: return new CityInfo("Veresegyház", "16", 47.6459, 19.29536);
case 361: return new CityInfo("Vép", "22", 47.23041, 16.72248);
case 362: return new CityInfo("Velence", "08", 47.23855, 18.65484);
case 363: return new CityInfo("Vecsés", "16", 47.40705, 19.28648);
case 364: return new CityInfo("Vasvár", "22", 47.04928, 16.79954);
case 365: return new CityInfo("Vaskút", "01", 46.10782, 18.98514);
case 366: return new CityInfo("Várpalota", "23", 47.19936, 18.13954);
case 367: return new CityInfo("Városföld", "01", 46.81674, 19.75668);
case 368: return new CityInfo("Vámosgyörk", "11", 47.68429, 19.92924);
case 369: return new CityInfo("Valkó", "16", 47.56391, 19.51267);
case 370: return new CityInfo("Vál", "08", 47.36264, 18.67931);
case 371: return new CityInfo("Vajszló", "02", 45.85957, 17.98406);
case 372: return new CityInfo("Vácszentlászló", "16", 47.574, 19.53771);
case 373: return new CityInfo("Vác", "16", 47.77591, 19.13612);
case 374: return new CityInfo("Üröm", "16", 47.59674, 19.01583);
case 375: return new CityInfo("Úrkút", "23", 47.08505, 17.64393);
case 376: return new CityInfo("Úri", "16", 47.41429, 19.52762);
case 377: return new CityInfo("Üllő", "16", 47.38771, 19.35533);
case 378: return new CityInfo("Üllés", "06", 46.33611, 19.84454);
case 379: return new CityInfo("Újszilvás", "16", 47.27477, 19.92477);
case 380: return new CityInfo("Újhartyán", "16", 47.21981, 19.38638);
case 381: return new CityInfo("Türje", "24", 46.98366, 17.10742);
case 382: return new CityInfo("Tura", "16", 47.60924, 19.60279);
case 383: return new CityInfo("Törtel", "16", 47.12209, 19.93714);
case 384: return new CityInfo("Törökbálint", "16", 47.42931, 18.91356);
case 385: return new CityInfo("Tompa", "01", 46.20605, 19.5391);
case 386: return new CityInfo("Töltéstava", "09", 47.62609, 17.73376);
case 387: return new CityInfo("Tolna", "21", 46.42677, 18.78248);
case 388: return new CityInfo("Tököl", "16", 47.32178, 18.96249);
case 389: return new CityInfo("Tokod", "12", 47.72277, 18.65889);
case 390: return new CityInfo("Tóalmás", "16", 47.50782, 19.66657);
case 391: return new CityInfo("Tihany", "23", 46.91369, 17.88918);
case 392: return new CityInfo("Tét", "09", 47.51922, 17.50802);
case 393: return new CityInfo("Tengelic", "21", 46.52878, 18.71117);
case 394: return new CityInfo("Telki", "16", 47.54791, 18.82816);
case 395: return new CityInfo("Tázlár", "01", 46.54824, 19.51436);
case 396: return new CityInfo("Tatabánya", "12", 47.58494, 18.39325);
case 397: return new CityInfo("Tata", "12", 47.65289, 18.31838);
case 398: return new CityInfo("Tát", "12", 47.74148, 18.64813);
case 399: return new CityInfo("Taszár", "17", 46.37467, 17.90594);
case 400: return new CityInfo("Tass", "01", 47.02095, 19.02988);
case 401: return new CityInfo("Tárnok", "16", 47.37327, 18.84579);
case 402: return new CityInfo("Tarján", "12", 47.61042, 18.5107);
case 403: return new CityInfo("Tardos", "12", 47.66192, 18.44416);
case 404: return new CityInfo("Tar", "14", 47.95371, 19.7461);
case 405: return new CityInfo("Tapolca", "23", 46.88152, 17.44117);
case 406: return new CityInfo("Táplánszentkereszt", "22", 47.19496, 16.69613);
case 407: return new CityInfo("Tápiószőlős", "16", 47.30248, 19.85133);
case 408: return new CityInfo("Tápiószentmárton", "16", 47.3399, 19.74648);
case 409: return new CityInfo("Tápiószele", "16", 47.33609, 19.87724);
case 410: return new CityInfo("Tápiószecső", "16", 47.45, 19.60923);
case 411: return new CityInfo("Sülysáp", "16", 47.45206, 19.53369);
case 412: return new CityInfo("Tápióság", "16", 47.402, 19.63047);
case 413: return new CityInfo("Tápiógyörgye", "16", 47.33505, 19.95276);
case 414: return new CityInfo("Tápióbicske", "16", 47.36096, 19.68609);
case 415: return new CityInfo("Tamási", "21", 46.63333, 18.28333);
case 416: return new CityInfo("Taksony", "16", 47.32968, 19.06695);
case 417: return new CityInfo("Tahitótfalu", "16", 47.75161, 19.07886);
case 418: return new CityInfo("Táborfalva", "16", 47.09942, 19.47837);
case 419: return new CityInfo("Tab", "17", 46.73135, 18.03201);
case 420: return new CityInfo("Szurdokpüspöki", "14", 47.85923, 19.69218);
case 421: return new CityInfo("Szomód", "12", 47.68492, 18.34061);
case 422: return new CityInfo("Szombathely", "22", 47.23088, 16.62155);
case 423: return new CityInfo("Sződliget", "16", 47.73259, 19.14749);
case 424: return new CityInfo("Sződ", "16", 47.72439, 19.17046);
case 425: return new CityInfo("Szob", "16", 47.81921, 18.8702);
case 426: return new CityInfo("Szigetvár", "02", 46.04865, 17.80554);
case 427: return new CityInfo("Szigetújfalu", "16", 47.23417, 18.92746);
case 428: return new CityInfo("Szigetszentmiklós", "16", 47.34382, 19.04335);
case 429: return new CityInfo("Szigethalom", "16", 47.32228, 19.00262);
case 430: return new CityInfo("Szigetcsép", "16", 47.26492, 18.97048);
case 431: return new CityInfo("Szentmártonkáta", "16", 47.45419, 19.70143);
case 432: return new CityInfo("Szentlőrinckáta", "16", 47.51947, 19.75286);
case 433: return new CityInfo("Szentlőrinc", "02", 46.04016, 17.98719);
case 434: return new CityInfo("Szentkirályszabadja", "23", 47.0576, 17.97052);
case 435: return new CityInfo("Szentkirály", "01", 46.91892, 19.91846);
case 436: return new CityInfo("Szentgotthárd", "22", 46.95261, 16.27358);
case 437: return new CityInfo("Szentgálpuszta", "21", 46.37479, 18.62601);
case 438: return new CityInfo("Szentendre", "16", 47.66943, 19.07561);
case 439: return new CityInfo("Szekszárd", "21", 46.35014, 18.70905);
case 440: return new CityInfo("Székesfehérvár", "08", 47.18995, 18.41034);
case 441: return new CityInfo("Szedres", "21", 46.47551, 18.68305);
case 442: return new CityInfo("Szécsény", "14", 48.08057, 19.52019);
case 443: return new CityInfo("Százhalombatta", "16", 47.32949, 18.93878);
case 444: return new CityInfo("Szászvár", "02", 46.27673, 18.37566);
case 445: return new CityInfo("Szárliget", "08", 47.51581, 18.4948);
case 446: return new CityInfo("Szany", "09", 47.46423, 17.30402);
case 447: return new CityInfo("Szank", "01", 46.55713, 19.66103);
case 448: return new CityInfo("Szalkszentmárton", "01", 46.97565, 19.01178);
case 449: return new CityInfo("Szakcs", "21", 46.53897, 18.1095);
case 450: return new CityInfo("Szada", "16", 47.63333, 19.31667);
case 451: return new CityInfo("Szabadszállás", "01", 46.87575, 19.22324);
case 452: return new CityInfo("Szabadbattyán", "08", 47.11902, 18.36823);
case 453: return new CityInfo("Süttő", "12", 47.75887, 18.44873);
case 454: return new CityInfo("Sümeg", "23", 46.97703, 17.28209);
case 455: return new CityInfo("Sükösd", "01", 46.28181, 18.99524);
case 456: return new CityInfo("Sóskút", "16", 47.40665, 18.82247);
case 457: return new CityInfo("Sopron", "09", 47.68501, 16.59049);
case 458: return new CityInfo("Soponya", "08", 47.01485, 18.45343);
case 459: return new CityInfo("Somoskőújfalu", "14", 48.16374, 19.82303);
case 460: return new CityInfo("Somogyvár", "17", 46.5814, 17.66289);
case 461: return new CityInfo("Solymár", "16", 47.59246, 18.93212);
case 462: return new CityInfo("Soltvadkert", "01", 46.57889, 19.39389);
case 463: return new CityInfo("Solt", "01", 46.80101, 19.00098);
case 464: return new CityInfo("Siófok", "17", 46.90413, 18.058);
case 465: return new CityInfo("Simontornya", "21", 46.75462, 18.5549);
case 466: return new CityInfo("Siklós", "02", 45.85499, 18.29752);
case 467: return new CityInfo("Seregélyes", "08", 47.1105, 18.565);
case 468: return new CityInfo("Sellye", "02", 45.87247, 17.84711);
case 469: return new CityInfo("Segesd", "17", 46.34142, 17.35132);
case 470: return new CityInfo("Sásd", "02", 46.2552, 18.10776);
case 471: return new CityInfo("Sárvár", "22", 47.25395, 16.93525);
case 472: return new CityInfo("Sárszentmihály", "08", 47.15321, 18.33879);
case 473: return new CityInfo("Sárosd", "08", 47.04273, 18.64357);
case 474: return new CityInfo("Sármellék", "24", 46.71221, 17.16865);
case 475: return new CityInfo("Sárkeresztúr", "08", 47.0054, 18.54391);
case 476: return new CityInfo("Sárisáp", "12", 47.677, 18.67933);
case 477: return new CityInfo("Sárbogárd", "08", 46.88692, 18.62041);
case 478: return new CityInfo("Salgótarján", "14", 48.09872, 19.80303);
case 479: return new CityInfo("Ruzsa", "06", 46.28806, 19.74714);
case 480: return new CityInfo("Rózsaszentmárton", "11", 47.782, 19.7421);
case 481: return new CityInfo("Romhány", "14", 47.92618, 19.25723);
case 482: return new CityInfo("Rimóc", "14", 48.03695, 19.5301);
case 483: return new CityInfo("Révfülöp", "23", 46.82573, 17.61967);
case 484: return new CityInfo("Rétság", "14", 47.92816, 19.1372);
case 485: return new CityInfo("Répcelak", "22", 47.42105, 17.01795);
case 486: return new CityInfo("Rajka", "09", 47.99643, 17.19821);
case 487: return new CityInfo("Ráckeve", "16", 47.16095, 18.94478);
case 488: return new CityInfo("Ráckeresztúr", "08", 47.2736, 18.83343);
case 489: return new CityInfo("Rácalmás", "08", 47.02263, 18.94056);
case 490: return new CityInfo("Rábaszentmihály", "09", 47.57751, 17.43247);
case 491: return new CityInfo("Rábapatona", "09", 47.63224, 17.48004);
case 492: return new CityInfo("Pusztavám", "08", 47.42948, 18.22648);
case 493: return new CityInfo("Pusztaszer", "06", 46.55083, 19.98823);
case 494: return new CityInfo("Pusztaszabolcs", "08", 47.13718, 18.76704);
case 495: return new CityInfo("Pomáz", "16", 47.64227, 19.02784);
case 496: return new CityInfo("Polgárdi", "08", 47.06099, 18.302);
case 497: return new CityInfo("Pincehely", "21", 46.68095, 18.43935);
case 498: return new CityInfo("Pilisvörösvár", "16", 47.61386, 18.90893);
case 499: return new CityInfo("Pilisszentkereszt", "16", 47.69143, 18.90503);
case 500: return new CityInfo("Pilisszentiván", "16", 47.60964, 18.8994);
case 501: return new CityInfo("Pilisszántó", "16", 47.66909, 18.88762);
case 502: return new CityInfo("Pilismarót", "12", 47.78464, 18.87539);
case 503: return new CityInfo("Piliscsév", "12", 47.67924, 18.81872);
case 504: return new CityInfo("Piliscsaba", "16", 47.63417, 18.82886);
case 505: return new CityInfo("Pilisborosjenő", "16", 47.60744, 18.99322);
case 506: return new CityInfo("Pilis", "16", 47.28904, 19.54848);
case 507: return new CityInfo("Petőfibánya", "11", 47.7696, 19.69988);
case 508: return new CityInfo("Pétfürdő", "23", 47.16667, 18.11667);
case 509: return new CityInfo("Péteri", "16", 47.39104, 19.40981);
case 510: return new CityInfo("Perkáta", "08", 47.04701, 18.78734);
case 511: return new CityInfo("Perbál", "16", 47.58957, 18.76099);
case 512: return new CityInfo("Pér", "09", 47.61153, 17.80632);
case 513: return new CityInfo("Pellérd", "02", 46.03438, 18.15403);
case 514: return new CityInfo("Pécsvárad", "02", 46.16033, 18.42321);
case 515: return new CityInfo("Pécs", "02", 46.0725, 18.23083);
case 516: return new CityInfo("Pécel", "16", 47.48962, 19.34162);
case 517: return new CityInfo("Pázmánd", "08", 47.28755, 18.65356);
case 518: return new CityInfo("Páty", "16", 47.51709, 18.82851);
case 519: return new CityInfo("Pásztó", "14", 47.92019, 19.69829);
case 520: return new CityInfo("Parádsasvár", "11", 47.9126, 19.97709);
case 521: return new CityInfo("Pápa", "23", 47.33004, 17.4674);
case 522: return new CityInfo("Pannonhalma", "09", 47.54946, 17.75535);
case 523: return new CityInfo("Pánd", "16", 47.35333, 19.63571);
case 524: return new CityInfo("Palotás", "14", 47.79528, 19.59618);
case 525: return new CityInfo("Pálmonostora", "01", 46.62417, 19.95156);
case 526: return new CityInfo("Paks", "21", 46.6221, 18.85569);
case 527: return new CityInfo("Pákozd", "08", 47.21369, 18.53306);
case 528: return new CityInfo("Pacsa", "24", 46.71981, 17.01401);
case 529: return new CityInfo("Ozora", "21", 46.75133, 18.4001);
case 530: return new CityInfo("Öttevény", "09", 47.71946, 17.48474);
case 531: return new CityInfo("Ősi", "23", 47.14722, 18.18833);
case 532: return new CityInfo("Oroszlány", "12", 47.48671, 18.31225);
case 533: return new CityInfo("Örkény", "16", 47.12991, 19.43324);
case 534: return new CityInfo("Orgovány", "01", 46.75087, 19.47259);
case 535: return new CityInfo("Őrbottyán", "16", 47.68711, 19.28239);
case 536: return new CityInfo("Őcsény", "21", 46.3137, 18.75749);
case 537: return new CityInfo("Ócsa", "16", 47.29986, 19.23057);
case 538: return new CityInfo("Nyúl", "09", 47.59047, 17.68904);
case 539: return new CityInfo("Nyergesújfalu", "12", 47.76027, 18.55694);
case 540: return new CityInfo("Nyárlőrinc", "01", 46.86017, 19.87836);
case 541: return new CityInfo("Nyáregyháza", "16", 47.26175, 19.50146);
case 542: return new CityInfo("Neszmély", "12", 47.73585, 18.35966);
case 543: return new CityInfo("Németkér", "21", 46.71637, 18.76311);
case 544: return new CityInfo("Nemesvámos", "23", 47.05514, 17.87477);
case 545: return new CityInfo("Nemesnádudvar", "01", 46.34051, 19.05115);
case 546: return new CityInfo("Nemesbük", "24", 46.81667, 17.15);
case 547: return new CityInfo("Naszály", "12", 47.70329, 18.25751);
case 548: return new CityInfo("dunaújváros", "08", 46.96737, 18.93288);
case 549: return new CityInfo("Nagytarcsa", "16", 47.53128, 19.28343);
case 550: return new CityInfo("Nagyréde", "11", 47.76543, 19.84819);
case 551: return new CityInfo("Nagyoroszi", "14", 48.00503, 19.0905);
case 552: return new CityInfo("Nagymaros", "16", 47.7928, 18.95984);
case 553: return new CityInfo("Nagymányok", "21", 46.27911, 18.45489);
case 554: return new CityInfo("Nagykovácsi", "16", 47.65, 19.01667);
case 555: return new CityInfo("Nagykőrös", "16", 47.03419, 19.77857);
case 556: return new CityInfo("Nagykáta", "16", 47.41514, 19.7441);
case 557: return new CityInfo("Nagykanizsa", "24", 46.45347, 16.99104);
case 558: return new CityInfo("Nagyigmánd", "12", 47.64093, 18.0813);
case 559: return new CityInfo("Nagydorog", "21", 46.62749, 18.65565);
case 560: return new CityInfo("Nagycenk", "09", 47.60435, 16.69732);
case 561: return new CityInfo("Nagybaracska", "01", 46.04248, 18.9059);
case 562: return new CityInfo("Nagybajom", "17", 46.39232, 17.51147);
case 563: return new CityInfo("Nagyatád", "17", 46.22961, 17.35788);
case 564: return new CityInfo("Murakeresztúr", "24", 46.36422, 16.88177);
case 565: return new CityInfo("Mosonmagyaróvár", "09", 47.86789, 17.26994);
case 566: return new CityInfo("Mórahalom", "06", 46.21806, 19.8851);
case 567: return new CityInfo("Mór", "08", 47.37787, 18.20353);
case 568: return new CityInfo("Monor", "16", 47.35133, 19.44733);
case 569: return new CityInfo("Mohács", "02", 45.9902, 18.68621);
case 570: return new CityInfo("Mogyoród", "16", 47.59748, 19.2407);
case 571: return new CityInfo("Mocsa", "12", 47.66999, 18.18505);
case 572: return new CityInfo("Mihályi", "09", 47.51384, 17.09507);
case 573: return new CityInfo("Mezőszilas", "08", 46.81109, 18.47789);
case 574: return new CityInfo("Mezőfalva", "08", 46.93184, 18.77177);
case 575: return new CityInfo("Mende", "16", 47.43133, 19.45628);
case 576: return new CityInfo("Mélykút", "01", 46.21509, 19.38102);
case 577: return new CityInfo("Mecseknádasd", "02", 46.22468, 18.47076);
case 578: return new CityInfo("Mátraverebély", "14", 47.97421, 19.78049);
case 579: return new CityInfo("Mátraterenye", "14", 48.03267, 19.94762);
case 580: return new CityInfo("Mátranovák", "14", 48.03809, 19.98257);
case 581: return new CityInfo("Martonvásár", "08", 47.31601, 18.79045);
case 582: return new CityInfo("Marcali", "17", 46.58498, 17.41196);
case 583: return new CityInfo("Mány", "08", 47.53352, 18.65627);
case 584: return new CityInfo("Mágocs", "02", 46.34998, 18.2324);
case 585: return new CityInfo("Maglód", "16", 47.44258, 19.36438);
case 586: return new CityInfo("Madocsa", "21", 46.6879, 18.95791);
case 587: return new CityInfo("Madaras", "01", 46.0587, 19.26121);
case 588: return new CityInfo("Lovasberény", "08", 47.30997, 18.55177);
case 589: return new CityInfo("Lőrinci", "11", 47.73295, 19.67867);
case 590: return new CityInfo("Litér", "23", 47.10104, 18.00454);
case 591: return new CityInfo("Letenye", "24", 46.43301, 16.72583);
case 592: return new CityInfo("Lepsény", "08", 46.99036, 18.24357);
case 593: return new CityInfo("Lenti", "24", 46.62403, 16.53863);
case 594: return new CityInfo("Lengyeltóti", "17", 46.67013, 17.64398);
case 595: return new CityInfo("Lébény", "09", 47.73574, 17.39076);
case 596: return new CityInfo("Leányfalu", "16", 47.71778, 19.08585);
case 597: return new CityInfo("Lánycsók", "02", 46.00543, 18.62526);
case 598: return new CityInfo("Lakitelek", "01", 46.87601, 19.99504);
case 599: return new CityInfo("Lajosmizse", "01", 47.02133, 19.56171);
case 600: return new CityInfo("Lajoskomárom", "08", 46.84201, 18.33763);
case 601: return new CityInfo("Lábod", "17", 46.20535, 17.45419);
case 602: return new CityInfo("Lábatlan", "12", 47.74735, 18.49623);
case 603: return new CityInfo("Kunszentmiklós", "01", 47.02699, 19.12575);
case 604: return new CityInfo("Kunfehértó", "01", 46.36091, 19.41454);
case 605: return new CityInfo("Kozármisleny", "02", 46.02967, 18.2921);
case 606: return new CityInfo("Kőszeg", "22", 47.38922, 16.541);
case 607: return new CityInfo("Kosd", "16", 47.80791, 19.17821);
case 608: return new CityInfo("Környe", "12", 47.54668, 18.32081);
case 609: return new CityInfo("Körmend", "22", 47.01096, 16.60596);
case 610: return new CityInfo("Kóny", "09", 47.63053, 17.35717);
case 611: return new CityInfo("Komló", "02", 46.19278, 18.26494);
case 612: return new CityInfo("Komárom", "12", 47.74318, 18.11913);
case 613: return new CityInfo("Kóka", "16", 47.48552, 19.57876);
case 614: return new CityInfo("Kocsér", "16", 47.00165, 19.92067);
case 615: return new CityInfo("Kocs", "12", 47.6075, 18.21517);
case 616: return new CityInfo("Kőbánya", "05", 47.48427, 19.13913);
case 617: return new CityInfo("Kistelek", "06", 46.4725, 19.97972);
case 618: return new CityInfo("Kisszállás", "01", 46.28009, 19.48954);
case 619: return new CityInfo("Kispest", "05", 47.4515, 19.14017);
case 620: return new CityInfo("Kisláng", "08", 46.95744, 18.38813);
case 621: return new CityInfo("Kiskunmajsa", "01", 46.49028, 19.74);
case 622: return new CityInfo("Kiskunlacháza", "16", 47.18839, 19.0093);
case 623: return new CityInfo("Kiskunhalas", "01", 46.43402, 19.48479);
case 624: return new CityInfo("Kiskunfélegyháza", "01", 46.71213, 19.84458);
case 625: return new CityInfo("Kiskőrös", "01", 46.62139, 19.28528);
case 626: return new CityInfo("Kisbér", "12", 47.50289, 18.03665);
case 627: return new CityInfo("Kincsesbánya", "08", 47.26444, 18.2779);
case 628: return new CityInfo("Kimle", "09", 47.81726, 17.36642);
case 629: return new CityInfo("Kéthely", "17", 46.64605, 17.39362);
case 630: return new CityInfo("Kesztölc", "12", 47.71266, 18.80177);
case 631: return new CityInfo("Keszthely", "24", 46.76812, 17.24317);
case 632: return new CityInfo("Kistarcsa", "16", 47.54757, 19.26247);
case 633: return new CityInfo("Kerekegyháza", "01", 46.93722, 19.47806);
case 634: return new CityInfo("Kelebia", "01", 46.1968, 19.61659);
case 635: return new CityInfo("Kecskemét", "01", 46.90618, 19.69128);
case 636: return new CityInfo("Kecskéd", "12", 47.52298, 18.30939);
case 637: return new CityInfo("Kecel", "01", 46.52528, 19.25194);
case 638: return new CityInfo("Kazár", "14", 48.04952, 19.86143);
case 639: return new CityInfo("Katymár", "01", 46.03398, 19.20935);
case 640: return new CityInfo("Kartal", "16", 47.67133, 19.542);
case 641: return new CityInfo("Karancslapujtő", "14", 48.15, 19.73333);
case 642: return new CityInfo("Karancskeszi", "14", 48.16353, 19.69686);
case 643: return new CityInfo("Karád", "17", 46.69076, 17.84136);
case 644: return new CityInfo("Kapuvár", "09", 47.59224, 17.02886);
case 645: return new CityInfo("Kaposvár", "17", 46.36667, 17.8);
case 646: return new CityInfo("Kaposmérő", "17", 46.36167, 17.704);
case 647: return new CityInfo("Kápolnásnyék", "08", 47.24004, 18.67564);
case 648: return new CityInfo("Káloz", "08", 46.95464, 18.48259);
case 649: return new CityInfo("Kalocsa", "01", 46.52981, 18.97283);
case 650: return new CityInfo("Kakucs", "16", 47.242, 19.36467);
case 651: return new CityInfo("Kadarkút", "17", 46.23623, 17.62014);
case 652: return new CityInfo("Jobbágyi", "14", 47.83238, 19.67762);
case 653: return new CityInfo("Jászszentlászló", "01", 46.56685, 19.76065);
case 654: return new CityInfo("Jászberény", "20", 47.5, 19.91667);
case 655: return new CityInfo("Jászárokszállás", "20", 47.64238, 19.98038);
case 656: return new CityInfo("Jánossomorja", "09", 47.78621, 17.13603);
case 657: return new CityInfo("Jánosháza", "22", 47.11937, 17.16503);
case 658: return new CityInfo("Jánoshalma", "01", 46.29861, 19.32583);
case 659: return new CityInfo("Fülöpjakab", "01", 46.74221, 19.72132);
case 660: return new CityInfo("Ják", "22", 47.14249, 16.58148);
case 661: return new CityInfo("Izsák", "01", 46.80454, 19.35172);
case 662: return new CityInfo("Iváncsa", "08", 47.1567, 18.8203);
case 663: return new CityInfo("Isaszeg", "16", 47.53011, 19.40205);
case 664: return new CityInfo("Iregszemcse", "21", 46.69286, 18.18581);
case 665: return new CityInfo("Inárcs", "16", 47.262, 19.327);
case 666: return new CityInfo("Iklad", "16", 47.66533, 19.4361);
case 667: return new CityInfo("Hosszúhetény", "02", 46.16414, 18.35077);
case 668: return new CityInfo("Hort", "11", 47.69081, 19.7893);
case 669: return new CityInfo("Hőgyész", "21", 46.49697, 18.41841);
case 670: return new CityInfo("Hidas", "02", 46.2568, 18.4954);
case 671: return new CityInfo("Hévízgyörk", "16", 47.63333, 19.51667);
case 672: return new CityInfo("Hévíz", "24", 46.79031, 17.18408);
case 673: return new CityInfo("Hernád", "16", 47.16238, 19.43295);
case 674: return new CityInfo("Herend", "23", 47.13333, 17.75);
case 675: return new CityInfo("Heréd", "11", 47.70638, 19.63314);
case 676: return new CityInfo("Hercegszántó", "01", 45.95, 18.93917);
case 677: return new CityInfo("Helvécia", "01", 46.83661, 19.62251);
case 678: return new CityInfo("Hatvan", "11", 47.66667, 19.68333);
case 679: return new CityInfo("Harta", "01", 46.69758, 19.0311);
case 680: return new CityInfo("Harkány", "02", 45.85002, 18.23668);
case 681: return new CityInfo("Halásztelek", "16", 47.36173, 18.98119);
case 682: return new CityInfo("Halászi", "09", 47.8893, 17.32615);
case 683: return new CityInfo("Hajós", "01", 46.39861, 19.12056);
case 684: return new CityInfo("Hajmáskér", "23", 47.14513, 18.01964);
case 685: return new CityInfo("Győrújbarát", "09", 47.60643, 17.64875);
case 686: return new CityInfo("Győrszemere", "09", 47.55256, 17.56356);
case 687: return new CityInfo("Győr", "09", 47.68333, 17.63512);
case 688: return new CityInfo("Gyönk", "21", 46.55603, 18.47694);
case 689: return new CityInfo("Gyöngyöstarján", "11", 47.81369, 19.86724);
case 690: return new CityInfo("Gyöngyössolymos", "11", 47.81724, 19.93619);
case 691: return new CityInfo("Gyöngyöspata", "11", 47.81505, 19.78925);
case 692: return new CityInfo("Gyöngyöshalász", "11", 47.74161, 19.92876);
case 693: return new CityInfo("Gyöngyös", "11", 47.78257, 19.928);
case 694: return new CityInfo("Gyömrő", "16", 47.42733, 19.40133);
case 695: return new CityInfo("Gyenesdiás", "24", 46.77058, 17.2866);
case 696: return new CityInfo("Gyál", "16", 47.38449, 19.2214);
case 697: return new CityInfo("Gomba", "16", 47.37095, 19.53057);
case 698: return new CityInfo("Gödre", "02", 46.28612, 17.97288);
case 699: return new CityInfo("Gödöllő", "16", 47.59657, 19.35515);
case 700: return new CityInfo("Göd", "16", 47.68324, 19.13417);
case 701: return new CityInfo("Gencsapáti", "22", 47.28496, 16.59575);
case 702: return new CityInfo("Gárdony", "08", 47.20942, 18.63607);
case 703: return new CityInfo("Gara", "01", 46.03194, 19.04278);
case 704: return new CityInfo("Galgamácsa", "16", 47.69562, 19.38724);
case 705: return new CityInfo("Galgahévíz", "16", 47.61667, 19.56667);
case 706: return new CityInfo("Fülöpszállás", "01", 46.82075, 19.23748);
case 707: return new CityInfo("Fót", "16", 47.6177, 19.1887);
case 708: return new CityInfo("Forrópuszta", "16", 47.45504, 19.66001);
case 709: return new CityInfo("Forráskút", "06", 46.36528, 19.90973);
case 710: return new CityInfo("Fonyód", "17", 46.75552, 17.57945);
case 711: return new CityInfo("Fertőszentmiklós", "09", 47.58996, 16.87517);
case 712: return new CityInfo("Fertőrákos", "09", 47.72017, 16.6504);
case 713: return new CityInfo("Fertőd", "09", 47.62173, 16.87088);
case 714: return new CityInfo("Felsőszentiván", "01", 46.19713, 19.18686);
case 715: return new CityInfo("Felsőpakony", "16", 47.34329, 19.23698);
case 716: return new CityInfo("Fehérvárcsurgó", "08", 47.29349, 18.2646);
case 717: return new CityInfo("Farmos", "16", 47.36067, 19.84619);
case 718: return new CityInfo("Farád", "09", 47.60633, 17.20024);
case 719: return new CityInfo("Fadd", "21", 46.46476, 18.81925);
case 720: return new CityInfo("Etyek", "08", 47.44794, 18.75328);
case 721: return new CityInfo("Esztergom", "12", 47.7928, 18.74148);
case 722: return new CityInfo("Erzsébetváros", "05", 47.50207, 19.07218);
case 723: return new CityInfo("Érsekvadkert", "14", 47.99619, 19.20231);
case 724: return new CityInfo("Érsekcsanád", "01", 46.25352, 18.98457);
case 725: return new CityInfo("Erdőkertes", "16", 47.67261, 19.30786);
case 726: return new CityInfo("Érd", "16", 47.39489, 18.91361);
case 727: return new CityInfo("Ercsi", "08", 47.25194, 18.89623);
case 728: return new CityInfo("Enying", "08", 46.93046, 18.24202);
case 729: return new CityInfo("Előszállás", "08", 46.83094, 18.83481);
case 730: return new CityInfo("Ecser", "16", 47.44389, 19.3245);
case 731: return new CityInfo("Ecséd", "11", 47.73267, 19.76696);
case 732: return new CityInfo("Dusnok", "01", 46.39085, 18.96296);
case 733: return new CityInfo("Dunavecse", "01", 46.91478, 18.97127);
case 734: return new CityInfo("Dunavarsány", "16", 47.27859, 19.06617);
case 735: return new CityInfo("Dunaújváros", "08", 46.96479, 18.93974);
case 736: return new CityInfo("Dunaszentgyörgy", "21", 46.52852, 18.81771);
case 737: return new CityInfo("Dunaszekcső", "02", 46.0874, 18.7587);
case 738: return new CityInfo("Dunapataj", "01", 46.644, 18.99632);
case 739: return new CityInfo("Dunakeszi", "16", 47.63641, 19.13864);
case 740: return new CityInfo("Dunaharaszti", "16", 47.3545, 19.09822);
case 741: return new CityInfo("Dunaföldvár", "21", 46.80713, 18.92763);
case 742: return new CityInfo("Dunabogdány", "16", 47.79052, 19.04125);
case 743: return new CityInfo("Dunaalmás", "12", 47.72868, 18.32235);
case 744: return new CityInfo("Dorog", "12", 47.72095, 18.73641);
case 745: return new CityInfo("Dömsöd", "16", 47.09005, 19.01106);
case 746: return new CityInfo("Domony", "16", 47.65552, 19.43229);
case 747: return new CityInfo("Dombóvár", "21", 46.37657, 18.13696);
case 748: return new CityInfo("Nagydobsza", "02", 46.03333, 17.66667);
case 749: return new CityInfo("Döbrököz", "21", 46.42178, 18.23953);
case 750: return new CityInfo("Diósjenő", "14", 47.93968, 19.04317);
case 751: return new CityInfo("Diósd", "16", 47.4095, 18.94898);
case 752: return new CityInfo("Devecser", "23", 47.10316, 17.43802);
case 753: return new CityInfo("Délegyháza", "16", 47.24135, 19.09019);
case 754: return new CityInfo("Dég", "08", 46.86807, 18.45042);
case 755: return new CityInfo("Decs", "21", 46.28428, 18.76);
case 756: return new CityInfo("Dávod", "01", 45.995, 18.91722);
case 757: return new CityInfo("Dány", "16", 47.52, 19.544);
case 758: return new CityInfo("Dánszentmiklós", "16", 47.21486, 19.54695);
case 759: return new CityInfo("Dabas", "16", 47.18594, 19.31091);
case 760: return new CityInfo("Csurgó", "17", 46.25314, 17.1006);
case 761: return new CityInfo("Csorna", "09", 47.61155, 17.25012);
case 762: return new CityInfo("Csopak", "23", 46.97709, 17.91819);
case 763: return new CityInfo("Csömör", "16", 47.55, 19.23333);
case 764: return new CityInfo("Csolnok", "12", 47.69116, 18.71611);
case 765: return new CityInfo("Csobánka", "16", 47.64637, 18.96189);
case 766: return new CityInfo("Csetény", "23", 47.31806, 17.99208);
case 767: return new CityInfo("Cserszegtomaj", "24", 46.80165, 17.22096);
case 768: return new CityInfo("Csepreg", "22", 47.40098, 16.70881);
case 769: return new CityInfo("Csengőd", "01", 46.71543, 19.26802);
case 770: return new CityInfo("Csengele", "06", 46.54234, 19.86358);
case 771: return new CityInfo("Csemő", "16", 47.11799, 19.69092);
case 772: return new CityInfo("Csávoly", "01", 46.18917, 19.14667);
case 773: return new CityInfo("Császártöltés", "01", 46.42194, 19.18361);
case 774: return new CityInfo("Császár", "12", 47.498, 18.14272);
case 775: return new CityInfo("Csány", "11", 47.64829, 19.82972);
case 776: return new CityInfo("Csákvár", "08", 47.39184, 18.46501);
case 777: return new CityInfo("Csabrendek", "23", 47.01356, 17.29108);
case 778: return new CityInfo("Celldömölk", "22", 47.25713, 17.15027);
case 779: return new CityInfo("Ceglédbercel", "16", 47.2237, 19.66828);
case 780: return new CityInfo("Cegléd", "16", 47.17266, 19.79952);
case 781: return new CityInfo("Cece", "08", 46.77056, 18.62826);
case 782: return new CityInfo("Bükkösd", "02", 46.10751, 17.9882);
case 783: return new CityInfo("Bük", "22", 47.38486, 16.75065);
case 784: return new CityInfo("Buják", "14", 47.88352, 19.54381);
case 785: return new CityInfo("Bugyi", "16", 47.22748, 19.14664);
case 786: return new CityInfo("Bugac", "01", 46.68704, 19.68074);
case 787: return new CityInfo("Budapest", "05", 47.49835, 19.04045);
case 788: return new CityInfo("Budaörs", "16", 47.46181, 18.95845);
case 789: return new CityInfo("Budakeszi", "16", 47.51083, 18.92717);
case 790: return new CityInfo("Budakalász", "16", 47.61667, 19.05);
case 791: return new CityInfo("Aszód", "16", 47.65174, 19.4785);
case 792: return new CityInfo("Bősárkány", "09", 47.68821, 17.25);
case 793: return new CityInfo("Bordány", "06", 46.31843, 19.92306);
case 794: return new CityInfo("Bonyhád", "21", 46.29921, 18.53024);
case 795: return new CityInfo("Bőny", "09", 47.65, 17.86977);
case 796: return new CityInfo("Bóly", "02", 45.96722, 18.51833);
case 797: return new CityInfo("Boldog", "11", 47.60285, 19.68839);
case 798: return new CityInfo("Bölcske", "21", 46.74102, 18.96736);
case 799: return new CityInfo("Bokod", "12", 47.49186, 18.24743);
case 800: return new CityInfo("Böhönye", "17", 46.41345, 17.38037);
case 801: return new CityInfo("Bogyiszló", "21", 46.38638, 18.82962);
case 802: return new CityInfo("Bodajk", "08", 47.32352, 18.23312);
case 803: return new CityInfo("Bicske", "08", 47.48419, 18.64404);
case 804: return new CityInfo("Biatorbágy", "16", 47.4706, 18.81892);
case 805: return new CityInfo("Berzence", "17", 46.20907, 17.1481);
case 806: return new CityInfo("Berhida", "23", 47.11131, 18.12948);
case 807: return new CityInfo("Beremend", "02", 45.79108, 18.43263);
case 808: return new CityInfo("Bercel", "14", 47.87057, 19.40715);
case 809: return new CityInfo("Beled", "09", 47.46594, 17.09294);
case 810: return new CityInfo("Becsehely", "24", 46.44755, 16.7771);
case 811: return new CityInfo("Bátya", "01", 46.488, 18.95419);
case 812: return new CityInfo("Bátonyterenye", "14", 47.96962, 19.84076);
case 813: return new CityInfo("Bátaszék", "21", 46.19373, 18.72307);
case 814: return new CityInfo("Báta", "21", 46.12864, 18.77027);
case 815: return new CityInfo("Barcs", "17", 45.96, 17.45861);
case 816: return new CityInfo("Baracska", "08", 47.28225, 18.75853);
case 817: return new CityInfo("Baracs", "08", 46.88202, 18.90658);
case 818: return new CityInfo("Bánd", "23", 47.12213, 17.7812);
case 819: return new CityInfo("Ballószög", "01", 46.86216, 19.57092);
case 820: return new CityInfo("Balatonszárszó", "17", 46.82946, 17.82426);
case 821: return new CityInfo("Balatonszabadi", "17", 46.89397, 18.13737);
case 822: return new CityInfo("Balatonlelle", "17", 46.78318, 17.69498);
case 823: return new CityInfo("Balatonkenese", "23", 47.04019, 18.10671);
case 824: return new CityInfo("Balatonfüred", "23", 46.96188, 17.87187);
case 825: return new CityInfo("Balatonföldvár", "17", 46.85255, 17.88123);
case 826: return new CityInfo("Balatonfenyves", "17", 46.71542, 17.49223);
case 827: return new CityInfo("Balatonboglár", "17", 46.77525, 17.64415);
case 828: return new CityInfo("Balatonberény", "17", 46.70701, 17.32013);
case 829: return new CityInfo("Balatonalmádi", "23", 47.03526, 18.02076);
case 830: return new CityInfo("Balassagyarmat", "14", 48.07296, 19.29614);
case 831: return new CityInfo("Bakonyszentlászló", "09", 47.38901, 17.80321);
case 832: return new CityInfo("Bakonycsernye", "08", 47.32395, 18.07509);
case 833: return new CityInfo("Bajna", "12", 47.654, 18.5972);
case 834: return new CityInfo("Baja", "01", 46.18299, 18.95307);
case 835: return new CityInfo("Baj", "12", 47.64593, 18.3641);
case 836: return new CityInfo("Bag", "16", 47.63333, 19.48333);
case 837: return new CityInfo("Badacsonytomaj", "23", 46.80711, 17.51385);
case 838: return new CityInfo("Bácsbokod", "01", 46.125, 19.15621);
case 839: return new CityInfo("Bácsalmás", "01", 46.12648, 19.3326);
case 840: return new CityInfo("Bábolna", "12", 47.64361, 17.97798);
case 841: return new CityInfo("Babócsa", "17", 46.04155, 17.34332);
case 842: return new CityInfo("Ásványráró", "09", 47.82733, 17.49418);
case 843: return new CityInfo("Ásotthalom", "06", 46.19875, 19.78334);
case 844: return new CityInfo("Apostag", "01", 46.88208, 18.9621);
case 845: return new CityInfo("Apc", "11", 47.79419, 19.69429);
case 846: return new CityInfo("Alsónémedi", "16", 47.31524, 19.15843);
case 847: return new CityInfo("Almásfüzitő", "12", 47.72752, 18.26153);
case 848: return new CityInfo("Albertirsa", "16", 47.24315, 19.61686);
case 849: return new CityInfo("Alap", "08", 46.79915, 18.68938);
case 850: return new CityInfo("Akasztó", "01", 46.69167, 19.20423);
case 851: return new CityInfo("Ajka", "23", 47.10196, 17.55892);
case 852: return new CityInfo("Ágfalva", "09", 47.68991, 16.51658);
case 853: return new CityInfo("Ágasegyháza", "01", 46.84025, 19.45208);
case 854: return new CityInfo("Adony", "08", 47.1194, 18.86493);
case 855: return new CityInfo("Ádánd", "17", 46.85931, 18.16442);
case 856: return new CityInfo("Adács", "11", 47.6921, 19.97696);
case 857: return new CityInfo("Acsa", "16", 47.79425, 19.38795);
case 858: return new CityInfo("Ács", "12", 47.71231, 18.01131);
case 859: return new CityInfo("Abda", "09", 47.69464, 17.54489);
case 860: return new CityInfo("Aba", "08", 47.02907, 18.52172);
case 861: return new CityInfo("Tiszaalpár", "01", 46.81279, 19.99841);
case 862: return new CityInfo("Budapest XII. kerület", "05", 47.49192, 19.01493);
case 863: return new CityInfo("Budapest XI. kerület", "05", 47.47603, 19.03605);
case 864: return new CityInfo("Budapest VIII. kerület", "05", 47.48919, 19.07012);
case 865: return new CityInfo("Budapest VI. kerület", "05", 47.50369, 19.06583);
case 866: return new CityInfo("Budapest XIII. kerület", "05", 47.52978, 19.08068);
case 867: return new CityInfo("Budapest IV. kerület", "05", 47.56182, 19.08909);
case 868: return new CityInfo("Budapest XV. kerület", "05", 47.56263, 19.11681);
case 869: return new CityInfo("Budapest XVI. kerület", "05", 47.51482, 19.17028);
case 870: return new CityInfo("Budapest XIX. kerület", "05", 47.45293, 19.14943);
case 871: return new CityInfo("Budapest XVIII. kerület", "05", 47.44417, 19.17595);
case 872: return new CityInfo("Budapest XXIII. kerület", "05", 47.39788, 19.11492);
case 873: return new CityInfo("Budapest XXII. kerület", "05", 47.42698, 19.04016);
case 874: return new CityInfo("Budapest XXI. kerület", "05", 47.43047, 19.07098);
case 875: return new CityInfo("Budapest XX. kerület", "05", 47.43674, 19.10093);
case 876: return new CityInfo("Budapest XVII. kerület", "05", 47.47997, 19.25388);
case 877: return new CityInfo("Budapest III. kerület", "05", 47.54157, 19.04501);
case 878: return new CityInfo("Budapest II. kerület", "05", 47.51984, 19.02218);
case 879: return new CityInfo("Budapest I. kerület", "05", 47.49705, 19.03961);
case 880: return new CityInfo("Algyő", "06", 46.33472, 20.20849);
case 881: return new CityInfo("Szelevény", "20", 46.80259, 20.20283);
case 882: return new CityInfo("Kismaros", "16", 47.83742, 19.00463);
case 883: return new CityInfo("Alsóújlak", "22", 47.08047, 16.8538);
case 884: return new CityInfo("Tolmács", "14", 47.9294, 19.10926);
case 885: return new CityInfo("Rábacsécsény", "09", 47.58608, 17.4238);
case 886: return new CityInfo("Héhalom", "14", 47.78017, 19.58519);
case 887: return new CityInfo("Ötvöskónyi", "17", 46.28741, 17.36003);
case 888: return new CityInfo("Mosonszentmiklós", "09", 47.72778, 17.42784);
case 889: return new CityInfo("Ete", "12", 47.53076, 18.07526);
case 890: return new CityInfo("Kerepes", "16", 47.56008, 19.28289);
case 891: return new CityInfo("Remeteszőlős", "16", 47.56031, 18.92);
case 892: return new CityInfo("Kisfalud", "09", 47.52821, 17.09061);
case 893: return new CityInfo("Tiszaszőlős", "20", 47.55707, 20.71949);
default: return new CityInfo("Józsefváros", "05", 47.48938, 19.07292);

                                    }                                        
                                }
                            
                        }
                    }
                