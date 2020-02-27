
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
                                    public const string Country = "HN";
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
                            
                                        var cur = (Math.Abs(15.82562 - lat) + Math.Abs(-87.92968 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(14.6 - lat) + Math.Abs(-86.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.63333 - lat) + Math.Abs(-86.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.26667 - lat) + Math.Abs(-87.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.94389 - lat) + Math.Abs(-86.85278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.1375 - lat) + Math.Abs(-87.12778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.06667 - lat) + Math.Abs(-87.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.33333 - lat) + Math.Abs(-87.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.53333 - lat) + Math.Abs(-88.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.28333 - lat) + Math.Abs(-88.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.01667 - lat) + Math.Abs(-87.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.41667 - lat) + Math.Abs(-84.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.43333 - lat) + Math.Abs(-84.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.9 - lat) + Math.Abs(-88.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.31667 - lat) + Math.Abs(-88 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.03333 - lat) + Math.Abs(-87.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.16667 - lat) + Math.Abs(-86.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.31667 - lat) + Math.Abs(-87.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.50381 - lat) + Math.Abs(-87.82625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.91667 - lat) + Math.Abs(-88.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.5 - lat) + Math.Abs(-87.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.15 - lat) + Math.Abs(-87.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.51667 - lat) + Math.Abs(-87.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.75 - lat) + Math.Abs(-87.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.91667 - lat) + Math.Abs(-85.95417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.35 - lat) + Math.Abs(-86.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.95 - lat) + Math.Abs(-88.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.13333 - lat) + Math.Abs(-88.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.86667 - lat) + Math.Abs(-87.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.3 - lat) + Math.Abs(-88.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.55 - lat) + Math.Abs(-87.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.75 - lat) + Math.Abs(-87.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.68333 - lat) + Math.Abs(-86 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.01667 - lat) + Math.Abs(-83.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.21667 - lat) + Math.Abs(-86.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.41667 - lat) + Math.Abs(-86.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.33333 - lat) + Math.Abs(-87.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.77425 - lat) + Math.Abs(-87.46731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.0818 - lat) + Math.Abs(-87.20681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.36667 - lat) + Math.Abs(-86.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7 - lat) + Math.Abs(-87.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.7 - lat) + Math.Abs(-85.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.75 - lat) + Math.Abs(-88.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.15 - lat) + Math.Abs(-87.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.4 - lat) + Math.Abs(-87.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.91667 - lat) + Math.Abs(-87.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.25 - lat) + Math.Abs(-88.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.2 - lat) + Math.Abs(-87.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.45 - lat) + Math.Abs(-89.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.83333 - lat) + Math.Abs(-86.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.6 - lat) + Math.Abs(-87.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.48333 - lat) + Math.Abs(-88.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.45 - lat) + Math.Abs(-85.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.46667 - lat) + Math.Abs(-86.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.88333 - lat) + Math.Abs(-88.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.35 - lat) + Math.Abs(-87.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.38333 - lat) + Math.Abs(-89 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.76667 - lat) + Math.Abs(-88.77917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.95 - lat) + Math.Abs(-85.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.16667 - lat) + Math.Abs(-87.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.91667 - lat) + Math.Abs(-88.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.86748 - lat) + Math.Abs(-89.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.76667 - lat) + Math.Abs(-85.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.41667 - lat) + Math.Abs(-89.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.1 - lat) + Math.Abs(-87.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.51667 - lat) + Math.Abs(-89.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.38333 - lat) + Math.Abs(-88.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.36667 - lat) + Math.Abs(-88.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.98333 - lat) + Math.Abs(-87.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.75 - lat) + Math.Abs(-88.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.86667 - lat) + Math.Abs(-86.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.25806 - lat) + Math.Abs(-87.34833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.91944 - lat) + Math.Abs(-88.23611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.30056 - lat) + Math.Abs(-87.11389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.65 - lat) + Math.Abs(-87.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.93167 - lat) + Math.Abs(-87.27139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.25 - lat) + Math.Abs(-87.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.75 - lat) + Math.Abs(-88.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.50417 - lat) + Math.Abs(-88.025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.25 - lat) + Math.Abs(-87.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15 - lat) + Math.Abs(-88.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.93333 - lat) + Math.Abs(-88.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.71667 - lat) + Math.Abs(-87.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.55 - lat) + Math.Abs(-86.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.98333 - lat) + Math.Abs(-86.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43333 - lat) + Math.Abs(-86.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.3 - lat) + Math.Abs(-88.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.4 - lat) + Math.Abs(-88.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.33333 - lat) + Math.Abs(-87.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.98333 - lat) + Math.Abs(-88.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.08333 - lat) + Math.Abs(-88.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.75 - lat) + Math.Abs(-87.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.73333 - lat) + Math.Abs(-86.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.42417 - lat) + Math.Abs(-87.44722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.58333 - lat) + Math.Abs(-87.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.93333 - lat) + Math.Abs(-88.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.78333 - lat) + Math.Abs(-88.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.26667 - lat) + Math.Abs(-87.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.21667 - lat) + Math.Abs(-87.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.3 - lat) + Math.Abs(-88.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.93333 - lat) + Math.Abs(-85.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.48333 - lat) + Math.Abs(-87.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.03333 - lat) + Math.Abs(-88.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.83333 - lat) + Math.Abs(-87.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.48333 - lat) + Math.Abs(-87.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.9 - lat) + Math.Abs(-88.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.73333 - lat) + Math.Abs(-88.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.03333 - lat) + Math.Abs(-88.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.31667 - lat) + Math.Abs(-87.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.25 - lat) + Math.Abs(-87.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.05 - lat) + Math.Abs(-88.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.96667 - lat) + Math.Abs(-88.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.63333 - lat) + Math.Abs(-87.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.17667 - lat) + Math.Abs(-87.13639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.65 - lat) + Math.Abs(-87.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.01667 - lat) + Math.Abs(-87.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.75 - lat) + Math.Abs(-88.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.43333 - lat) + Math.Abs(-88.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.9 - lat) + Math.Abs(-86.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.66139 - lat) + Math.Abs(-87.53278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.51667 - lat) + Math.Abs(-88.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.63333 - lat) + Math.Abs(-86.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.65 - lat) + Math.Abs(-87.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.36667 - lat) + Math.Abs(-86.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.68333 - lat) + Math.Abs(-89.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.21231 - lat) + Math.Abs(-85.76996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.32923 - lat) + Math.Abs(-86.56446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.05 - lat) + Math.Abs(-86.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.01667 - lat) + Math.Abs(-88 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.88444 - lat) + Math.Abs(-87.70306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.63333 - lat) + Math.Abs(-87.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.11667 - lat) + Math.Abs(-88.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.6 - lat) + Math.Abs(-87.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.33333 - lat) + Math.Abs(-87.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.51667 - lat) + Math.Abs(-88.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.81667 - lat) + Math.Abs(-88.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.2 - lat) + Math.Abs(-87.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.81667 - lat) + Math.Abs(-86.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.75 - lat) + Math.Abs(-85.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.83333 - lat) + Math.Abs(-86.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.80778 - lat) + Math.Abs(-87.25917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.6 - lat) + Math.Abs(-86.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.31759 - lat) + Math.Abs(-86.53793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.03333 - lat) + Math.Abs(-87.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.83333 - lat) + Math.Abs(-86.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.63333 - lat) + Math.Abs(-88.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.76667 - lat) + Math.Abs(-87.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.73333 - lat) + Math.Abs(-87.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.96667 - lat) + Math.Abs(-89.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.16667 - lat) + Math.Abs(-87.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.82583 - lat) + Math.Abs(-87.46528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.35 - lat) + Math.Abs(-88.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.88333 - lat) + Math.Abs(-88.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.66667 - lat) + Math.Abs(-87.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.5 - lat) + Math.Abs(-87.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.1 - lat) + Math.Abs(-86.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.43333 - lat) + Math.Abs(-87.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.76667 - lat) + Math.Abs(-85.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.73333 - lat) + Math.Abs(-85.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.9 - lat) + Math.Abs(-85.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.2 - lat) + Math.Abs(-87.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.26667 - lat) + Math.Abs(-83.77222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.01667 - lat) + Math.Abs(-85.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.7 - lat) + Math.Abs(-87.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.28333 - lat) + Math.Abs(-88.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15 - lat) + Math.Abs(-88.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.38333 - lat) + Math.Abs(-87.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.03333 - lat) + Math.Abs(-88.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.5806 - lat) + Math.Abs(-86.13664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.63333 - lat) + Math.Abs(-88.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.26667 - lat) + Math.Abs(-88.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.23333 - lat) + Math.Abs(-87.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.55 - lat) + Math.Abs(-87.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.38333 - lat) + Math.Abs(-88.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.23333 - lat) + Math.Abs(-87.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.68333 - lat) + Math.Abs(-86.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.26667 - lat) + Math.Abs(-88.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.59222 - lat) + Math.Abs(-87.36167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.53333 - lat) + Math.Abs(-88.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.1 - lat) + Math.Abs(-87.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.5 - lat) + Math.Abs(-84.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.51667 - lat) + Math.Abs(-87.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.31667 - lat) + Math.Abs(-83.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.83333 - lat) + Math.Abs(-89.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.81667 - lat) + Math.Abs(-86.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.01667 - lat) + Math.Abs(-87.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48167 - lat) + Math.Abs(-87.105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7 - lat) + Math.Abs(-86.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.76667 - lat) + Math.Abs(-88.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.48131 - lat) + Math.Abs(-86.57415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7 - lat) + Math.Abs(-88.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.6 - lat) + Math.Abs(-87.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.93389 - lat) + Math.Abs(-87.29583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.01667 - lat) + Math.Abs(-86.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.41667 - lat) + Math.Abs(-87.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.38333 - lat) + Math.Abs(-88.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.98333 - lat) + Math.Abs(-88.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.43333 - lat) + Math.Abs(-89.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.91667 - lat) + Math.Abs(-88.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.11667 - lat) + Math.Abs(-88.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.46667 - lat) + Math.Abs(-87.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.26667 - lat) + Math.Abs(-87.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.79556 - lat) + Math.Abs(-86.49845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.03333 - lat) + Math.Abs(-89.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.35 - lat) + Math.Abs(-86.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.95 - lat) + Math.Abs(-88.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.20472 - lat) + Math.Abs(-87.13889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.38333 - lat) + Math.Abs(-88.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53611 - lat) + Math.Abs(-87.4875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.56667 - lat) + Math.Abs(-86.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.11667 - lat) + Math.Abs(-86.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.31667 - lat) + Math.Abs(-87.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.58333 - lat) + Math.Abs(-87.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.20056 - lat) + Math.Abs(-87.37417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.26667 - lat) + Math.Abs(-87.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.8 - lat) + Math.Abs(-87.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.58333 - lat) + Math.Abs(-87.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.55 - lat) + Math.Abs(-87.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.43333 - lat) + Math.Abs(-89.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.78333 - lat) + Math.Abs(-87.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.08333 - lat) + Math.Abs(-87.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.51667 - lat) + Math.Abs(-87.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.6 - lat) + Math.Abs(-87.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.28806 - lat) + Math.Abs(-87.30972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.15 - lat) + Math.Abs(-88.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.88333 - lat) + Math.Abs(-87.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.91667 - lat) + Math.Abs(-86.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.06667 - lat) + Math.Abs(-86.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.73333 - lat) + Math.Abs(-86.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.86667 - lat) + Math.Abs(-88.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.91667 - lat) + Math.Abs(-88.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.55 - lat) + Math.Abs(-88.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.15 - lat) + Math.Abs(-88.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.05 - lat) + Math.Abs(-88.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.9 - lat) + Math.Abs(-88.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.28694 - lat) + Math.Abs(-87.33444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.95 - lat) + Math.Abs(-87.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.65 - lat) + Math.Abs(-88.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.1 - lat) + Math.Abs(-87.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.39667 - lat) + Math.Abs(-88.55972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.46667 - lat) + Math.Abs(-89.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53583 - lat) + Math.Abs(-87.09194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.06667 - lat) + Math.Abs(-87.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.78333 - lat) + Math.Abs(-88.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.36667 - lat) + Math.Abs(-87.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.01667 - lat) + Math.Abs(-88.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.05 - lat) + Math.Abs(-88.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.71667 - lat) + Math.Abs(-87 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.13333 - lat) + Math.Abs(-88.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.81667 - lat) + Math.Abs(-88.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.1 - lat) + Math.Abs(-87.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.71667 - lat) + Math.Abs(-87.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.01667 - lat) + Math.Abs(-87.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.87649 - lat) + Math.Abs(-88.07473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.06667 - lat) + Math.Abs(-85.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.8 - lat) + Math.Abs(-88.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.06667 - lat) + Math.Abs(-87.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.28333 - lat) + Math.Abs(-87.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.78333 - lat) + Math.Abs(-87.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.32528 - lat) + Math.Abs(-87.39556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.23333 - lat) + Math.Abs(-87.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.25 - lat) + Math.Abs(-86.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.36667 - lat) + Math.Abs(-87.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.35 - lat) + Math.Abs(-87.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.11667 - lat) + Math.Abs(-88.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.11667 - lat) + Math.Abs(-88.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.31944 - lat) + Math.Abs(-87.67917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.62083 - lat) + Math.Abs(-87.6525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.31667 - lat) + Math.Abs(-87.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.61667 - lat) + Math.Abs(-87.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.2 - lat) + Math.Abs(-87.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.43333 - lat) + Math.Abs(-87.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.8 - lat) + Math.Abs(-88.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.75 - lat) + Math.Abs(-87.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.81667 - lat) + Math.Abs(-88.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.48333 - lat) + Math.Abs(-89 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.63333 - lat) + Math.Abs(-88 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.03333 - lat) + Math.Abs(-88.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.58333 - lat) + Math.Abs(-87.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.2 - lat) + Math.Abs(-88.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7 - lat) + Math.Abs(-86.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.61667 - lat) + Math.Abs(-88.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.08333 - lat) + Math.Abs(-86.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.88333 - lat) + Math.Abs(-87.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.25 - lat) + Math.Abs(-87.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.06667 - lat) + Math.Abs(-87.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.28333 - lat) + Math.Abs(-88.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.28333 - lat) + Math.Abs(-87.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.05 - lat) + Math.Abs(-86.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.63333 - lat) + Math.Abs(-85.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.41667 - lat) + Math.Abs(-88.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.05091 - lat) + Math.Abs(-89.09818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.31111 - lat) + Math.Abs(-88.18056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.46667 - lat) + Math.Abs(-87.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.05 - lat) + Math.Abs(-88.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.66667 - lat) + Math.Abs(-89.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.65 - lat) + Math.Abs(-86.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.8 - lat) + Math.Abs(-85.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.45361 - lat) + Math.Abs(-87.41333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7 - lat) + Math.Abs(-86.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.61667 - lat) + Math.Abs(-86.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.75971 - lat) + Math.Abs(-86.78221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.8 - lat) + Math.Abs(-85.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.71667 - lat) + Math.Abs(-86.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.66667 - lat) + Math.Abs(-86.21944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.76667 - lat) + Math.Abs(-86.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.98333 - lat) + Math.Abs(-86.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.35444 - lat) + Math.Abs(-88.63556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.28333 - lat) + Math.Abs(-86.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14 - lat) + Math.Abs(-88.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53167 - lat) + Math.Abs(-87.43889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.48333 - lat) + Math.Abs(-87.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.95 - lat) + Math.Abs(-85.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7 - lat) + Math.Abs(-87.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7 - lat) + Math.Abs(-87.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.01667 - lat) + Math.Abs(-86.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15 - lat) + Math.Abs(-83.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.31667 - lat) + Math.Abs(-88.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.06667 - lat) + Math.Abs(-88.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.71667 - lat) + Math.Abs(-87.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.88333 - lat) + Math.Abs(-86.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.71667 - lat) + Math.Abs(-86.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.11667 - lat) + Math.Abs(-88.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.91667 - lat) + Math.Abs(-86.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.44795 - lat) + Math.Abs(-85.89431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.95 - lat) + Math.Abs(-88.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.02521 - lat) + Math.Abs(-86.07076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.5 - lat) + Math.Abs(-87.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.53333 - lat) + Math.Abs(-86.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.01667 - lat) + Math.Abs(-88.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.59028 - lat) + Math.Abs(-88.58194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.58333 - lat) + Math.Abs(-87.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.35 - lat) + Math.Abs(-86.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.85 - lat) + Math.Abs(-85.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.03333 - lat) + Math.Abs(-88.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.28333 - lat) + Math.Abs(-87.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.73333 - lat) + Math.Abs(-87.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.23333 - lat) + Math.Abs(-88.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.01667 - lat) + Math.Abs(-87.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.51667 - lat) + Math.Abs(-88.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46639 - lat) + Math.Abs(-87.51528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.76667 - lat) + Math.Abs(-87.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.11667 - lat) + Math.Abs(-87 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.38333 - lat) + Math.Abs(-88.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.99944 - lat) + Math.Abs(-87.195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.93333 - lat) + Math.Abs(-87.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.06667 - lat) + Math.Abs(-87.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.03333 - lat) + Math.Abs(-87.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.51667 - lat) + Math.Abs(-87.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.63333 - lat) + Math.Abs(-87.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.5285 - lat) + Math.Abs(-87.66571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.46667 - lat) + Math.Abs(-86.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.9 - lat) + Math.Abs(-86.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.8 - lat) + Math.Abs(-87.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.28333 - lat) + Math.Abs(-86.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.58333 - lat) + Math.Abs(-87.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.66667 - lat) + Math.Abs(-87.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.68333 - lat) + Math.Abs(-87.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.28333 - lat) + Math.Abs(-87.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.4 - lat) + Math.Abs(-87.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.83333 - lat) + Math.Abs(-87.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.75 - lat) + Math.Abs(-86.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.58333 - lat) + Math.Abs(-87.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.76167 - lat) + Math.Abs(-87.34583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.28333 - lat) + Math.Abs(-87.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.28333 - lat) + Math.Abs(-87.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.7 - lat) + Math.Abs(-86.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.93333 - lat) + Math.Abs(-86.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.08333 - lat) + Math.Abs(-88.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.13889 - lat) + Math.Abs(-87.03222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7 - lat) + Math.Abs(-87.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.86667 - lat) + Math.Abs(-86.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.08333 - lat) + Math.Abs(-87.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.03333 - lat) + Math.Abs(-88.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.41667 - lat) + Math.Abs(-86.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14 - lat) + Math.Abs(-86.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.15417 - lat) + Math.Abs(-87.13083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.76667 - lat) + Math.Abs(-88.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.31667 - lat) + Math.Abs(-87.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.86667 - lat) + Math.Abs(-88.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.4 - lat) + Math.Abs(-87.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.4 - lat) + Math.Abs(-88.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.11667 - lat) + Math.Abs(-87.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.15 - lat) + Math.Abs(-87.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.45 - lat) + Math.Abs(-86.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.48333 - lat) + Math.Abs(-86.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48944 - lat) + Math.Abs(-87.44389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.83333 - lat) + Math.Abs(-86.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.76667 - lat) + Math.Abs(-87.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.6 - lat) + Math.Abs(-87.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.55 - lat) + Math.Abs(-87.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.4 - lat) + Math.Abs(-88.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.75 - lat) + Math.Abs(-87.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.66667 - lat) + Math.Abs(-87.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.25 - lat) + Math.Abs(-88.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.95 - lat) + Math.Abs(-88.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.13333 - lat) + Math.Abs(-87.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.75 - lat) + Math.Abs(-88.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46667 - lat) + Math.Abs(-87.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7 - lat) + Math.Abs(-88.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.28889 - lat) + Math.Abs(-87.03472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.06667 - lat) + Math.Abs(-88.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.3 - lat) + Math.Abs(-88.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.13333 - lat) + Math.Abs(-87.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.06667 - lat) + Math.Abs(-86.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.86667 - lat) + Math.Abs(-87.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.03333 - lat) + Math.Abs(-86.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.06667 - lat) + Math.Abs(-87.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.7 - lat) + Math.Abs(-87.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.08333 - lat) + Math.Abs(-88.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.63333 - lat) + Math.Abs(-86.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.1 - lat) + Math.Abs(-85.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.85 - lat) + Math.Abs(-88.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.86667 - lat) + Math.Abs(-88.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.03333 - lat) + Math.Abs(-86.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.66667 - lat) + Math.Abs(-88.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.88333 - lat) + Math.Abs(-86.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.85 - lat) + Math.Abs(-85.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.65 - lat) + Math.Abs(-88.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.4 - lat) + Math.Abs(-86.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.46667 - lat) + Math.Abs(-86.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.41667 - lat) + Math.Abs(-88.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.56667 - lat) + Math.Abs(-88.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.8 - lat) + Math.Abs(-86.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.75 - lat) + Math.Abs(-85.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.58333 - lat) + Math.Abs(-88.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.83333 - lat) + Math.Abs(-89.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.61667 - lat) + Math.Abs(-86.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.21667 - lat) + Math.Abs(-87 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.8 - lat) + Math.Abs(-88.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.16667 - lat) + Math.Abs(-88.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.16667 - lat) + Math.Abs(-88.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.6 - lat) + Math.Abs(-87.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.45139 - lat) + Math.Abs(-87.6375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.3 - lat) + Math.Abs(-88.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.4 - lat) + Math.Abs(-88.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.21667 - lat) + Math.Abs(-87.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.41667 - lat) + Math.Abs(-87.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.30028 - lat) + Math.Abs(-87.19083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.61444 - lat) + Math.Abs(-87.95302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.75 - lat) + Math.Abs(-87.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.4 - lat) + Math.Abs(-86.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.23333 - lat) + Math.Abs(-88.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.1 - lat) + Math.Abs(-88.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.81667 - lat) + Math.Abs(-87.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.66667 - lat) + Math.Abs(-87.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.8 - lat) + Math.Abs(-88.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.6 - lat) + Math.Abs(-87.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.26667 - lat) + Math.Abs(-88.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.11667 - lat) + Math.Abs(-88.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.51667 - lat) + Math.Abs(-86.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.28333 - lat) + Math.Abs(-87.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.98333 - lat) + Math.Abs(-88.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.55 - lat) + Math.Abs(-86.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14 - lat) + Math.Abs(-88.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.33333 - lat) + Math.Abs(-88.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.16667 - lat) + Math.Abs(-88.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.48333 - lat) + Math.Abs(-88.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.46667 - lat) + Math.Abs(-86.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.03333 - lat) + Math.Abs(-88.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.75 - lat) + Math.Abs(-84.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.74765 - lat) + Math.Abs(-85.73559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.83333 - lat) + Math.Abs(-88.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.48333 - lat) + Math.Abs(-88.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.13333 - lat) + Math.Abs(-87.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.8 - lat) + Math.Abs(-84.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.76667 - lat) + Math.Abs(-87.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.48333 - lat) + Math.Abs(-86.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.88851 - lat) + Math.Abs(-87.85547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.34333 - lat) + Math.Abs(-88.55139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.71667 - lat) + Math.Abs(-88.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.26667 - lat) + Math.Abs(-88.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.11174 - lat) + Math.Abs(-87.17557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.94087 - lat) + Math.Abs(-83.83229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.48333 - lat) + Math.Abs(-84.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.93333 - lat) + Math.Abs(-88.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.68333 - lat) + Math.Abs(-87.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.5 - lat) + Math.Abs(-88.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.46667 - lat) + Math.Abs(-86.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.63333 - lat) + Math.Abs(-87.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.78333 - lat) + Math.Abs(-86 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.35 - lat) + Math.Abs(-86.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.95 - lat) + Math.Abs(-86.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.74222 - lat) + Math.Abs(-87.71028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.85 - lat) + Math.Abs(-88.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.4 - lat) + Math.Abs(-89.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.29222 - lat) + Math.Abs(-87.65389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.79611 - lat) + Math.Abs(-87.46889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.51222 - lat) + Math.Abs(-87.72444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.38333 - lat) + Math.Abs(-87.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.56667 - lat) + Math.Abs(-87.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.33528 - lat) + Math.Abs(-88.55306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46889 - lat) + Math.Abs(-87.55111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43528 - lat) + Math.Abs(-87.23167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.88333 - lat) + Math.Abs(-88.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.25 - lat) + Math.Abs(-87.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.9 - lat) + Math.Abs(-87.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.91667 - lat) + Math.Abs(-87.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.45 - lat) + Math.Abs(-87.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.64972 - lat) + Math.Abs(-87.0225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.23628 - lat) + Math.Abs(-88.75142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Puerto Cortez", "06", 15.82562, -87.92968);
case 1: return new CityInfo("Zopilotepe", "15", 14.6, -86.26667);
case 2: return new CityInfo("Zamora", "03", 15.63333, -86.06667);
case 3: return new CityInfo("Zambrano", "08", 14.26667, -87.4);
case 4: return new CityInfo("Yuscarán", "07", 13.94389, -86.85278);
case 5: return new CityInfo("Yoro", "18", 15.1375, -87.12778);
case 6: return new CityInfo("Yorito", "18", 15.06667, -87.28333);
case 7: return new CityInfo("Yarumela", "12", 14.33333, -87.63333);
case 8: return new CityInfo("Yaruchel", "14", 14.53333, -88.81667);
case 9: return new CityInfo("Yamaranguila", "10", 14.28333, -88.25);
case 10: return new CityInfo("Yaguacire", "08", 14.01667, -87.21667);
case 11: return new CityInfo("Wawina", "09", 15.41667, -84.43333);
case 12: return new CityInfo("Waksma", "09", 15.43333, -84.4);
case 13: return new CityInfo("Vivistorio", "05", 14.9, -88.73333);
case 14: return new CityInfo("Villanueva", "06", 15.31667, -88);
case 15: return new CityInfo("Villa Nueva", "08", 14.03333, -87.13333);
case 16: return new CityInfo("Villa de San Francisco", "08", 14.16667, -86.96667);
case 17: return new CityInfo("Villa de San Antonio", "04", 14.31667, -87.61667);
case 18: return new CityInfo("Victoria", "18", 15.50381, -87.82625);
case 19: return new CityInfo("Veracruz", "05", 14.91667, -88.78333);
case 20: return new CityInfo("Valle de Ángeles", "04", 14.5, -87.63333);
case 21: return new CityInfo("Valle de Ángeles", "08", 14.15, -87.03333);
case 22: return new CityInfo("Vallecillo", "08", 14.51667, -87.4);
case 23: return new CityInfo("Urrutia", "08", 14.75, -87.03333);
case 24: return new CityInfo("Trujillo", "03", 15.91667, -85.95417);
case 25: return new CityInfo("Trojas", "18", 15.35, -86.7);
case 26: return new CityInfo("Trinidad de Copán", "05", 14.95, -88.75);
case 27: return new CityInfo("Trinidad", "16", 15.13333, -88.23333);
case 28: return new CityInfo("Travesía", "06", 15.86667, -87.9);
case 29: return new CityInfo("Tras Cerros", "16", 15.3, -88.66667);
case 30: return new CityInfo("Toyós", "18", 15.55, -87.65);
case 31: return new CityInfo("Tornabé", "01", 15.75, -87.55);
case 32: return new CityInfo("Tocoa", "03", 15.68333, -86);
case 33: return new CityInfo("Tikiraya", "09", 15.01667, -83.63333);
case 34: return new CityInfo("Teupasenti", "07", 14.21667, -86.7);
case 35: return new CityInfo("Tepusteca", "18", 15.41667, -86.31667);
case 36: return new CityInfo("Tepanguare", "12", 14.33333, -87.75);
case 37: return new CityInfo("Tela", "01", 15.77425, -87.46731);
case 38: return new CityInfo("Tegucigalpa", "08", 14.0818, -87.20681);
case 39: return new CityInfo("Teguajinal", "18", 15.36667, -86.6);
case 40: return new CityInfo("Taulabé", "04", 14.7, -87.96667);
case 41: return new CityInfo("Taujica", "03", 15.7, -85.91667);
case 42: return new CityInfo("Taragual", "13", 14.75, -88.48333);
case 43: return new CityInfo("Támara", "08", 14.15, -87.33333);
case 44: return new CityInfo("Talanga", "08", 14.4, -87.08333);
case 45: return new CityInfo("Sulaco", "18", 14.91667, -87.26667);
case 46: return new CityInfo("Sula", "16", 15.25, -88.56667);
case 47: return new CityInfo("Subirana", "18", 15.2, -87.45);
case 48: return new CityInfo("Sinuapa", "14", 14.45, -89.18333);
case 49: return new CityInfo("Silca", "15", 14.83333, -86.53333);
case 50: return new CityInfo("Siguatepeque", "04", 14.6, -87.83333);
case 51: return new CityInfo("Sensenti", "14", 14.48333, -88.93333);
case 52: return new CityInfo("Savannah Bight", "11", 16.45, -85.85);
case 53: return new CityInfo("Sabá", "03", 15.46667, -86.25);
case 54: return new CityInfo("San Vicente Centenario", "16", 14.88333, -88.28333);
case 55: return new CityInfo("Santiago Puringla", "12", 14.35, -87.9);
case 56: return new CityInfo("Santa Teresa", "14", 14.38333, -89);
case 57: return new CityInfo("Santa Rosa de Copán", "05", 14.76667, -88.77917);
case 58: return new CityInfo("Santa Rosa de Aguán", "03", 15.95, -85.71667);
case 59: return new CityInfo("Santa Rita", "18", 15.16667, -87.28333);
case 60: return new CityInfo("Santa Rita", "16", 14.91667, -88.21667);
case 61: return new CityInfo("Santa Rita, Copan", "05", 14.86748, -89.1);
case 62: return new CityInfo("Santa María del Real", "15", 14.76667, -85.95);
case 63: return new CityInfo("Santa Lucía", "14", 14.41667, -89.2);
case 64: return new CityInfo("Santa Lucía", "08", 14.1, -87.11667);
case 65: return new CityInfo("Santa Fe", "14", 14.51667, -89.23333);
case 66: return new CityInfo("Santa Elena", "06", 15.38333, -88.13333);
case 67: return new CityInfo("Santa Cruz Minas", "16", 15.36667, -88.3);
case 68: return new CityInfo("Santa Cruz de Yojoa", "06", 14.98333, -87.9);
case 69: return new CityInfo("Santa Cruz", "05", 14.75, -88.98333);
case 70: return new CityInfo("Santa Cruz", "07", 13.86667, -86.63333);
case 71: return new CityInfo("Santa Cruz", "02", 13.25806, -87.34833);
case 72: return new CityInfo("Santa Bárbara", "16", 14.91944, -88.23611);
case 73: return new CityInfo("Santa Ana de Yusguare", "02", 13.30056, -87.11389);
case 74: return new CityInfo("Santa Ana", "01", 15.65, -87.06667);
case 75: return new CityInfo("Santa Ana", "08", 13.93167, -87.27139);
case 76: return new CityInfo("San Sebastián", "04", 14.25, -87.63333);
case 77: return new CityInfo("San Pedro Zacapa", "16", 14.75, -88.11667);
case 78: return new CityInfo("San Pedro Sula", "06", 15.50417, -88.025);
case 79: return new CityInfo("San Pedro de Tutule", "12", 14.25, -87.85);
case 80: return new CityInfo("San Nicolás", "05", 15, -88.75);
case 81: return new CityInfo("San Nicolás", "16", 14.93333, -88.31667);
case 82: return new CityInfo("San Nicolás", "04", 14.71667, -87.35);
case 83: return new CityInfo("San Nicolás", "15", 14.55, -86.25);
case 84: return new CityInfo("San Matías", "07", 13.98333, -86.63333);
case 85: return new CityInfo("San Marcos de Colón", "02", 13.43333, -86.8);
case 86: return new CityInfo("San Marcos", "16", 15.3, -88.41667);
case 87: return new CityInfo("San Marcos", "14", 14.4, -88.95);
case 88: return new CityInfo("San Manuel", "06", 15.33333, -87.91667);
case 89: return new CityInfo("San Luis de Planes", "16", 14.98333, -88.13333);
case 90: return new CityInfo("San Luis", "16", 15.08333, -88.38333);
case 91: return new CityInfo("San Luis", "04", 14.75, -87.41667);
case 92: return new CityInfo("San Lucas", "07", 13.73333, -86.95);
case 93: return new CityInfo("San Lorenzo", "17", 13.42417, -87.44722);
case 94: return new CityInfo("San Juan Pueblo", "01", 15.58333, -87.23333);
case 95: return new CityInfo("San Juan de Planes", "05", 14.93333, -88.78333);
case 96: return new CityInfo("San Juan de Opoa", "05", 14.78333, -88.7);
case 97: return new CityInfo("San Juan de Flores", "08", 14.26667, -87.03333);
case 98: return new CityInfo("San Juancito", "08", 14.21667, -87.06667);
case 99: return new CityInfo("San José de Tarros", "16", 15.3, -88.7);
case 100: return new CityInfo("San José de Río Tinto", "15", 14.93333, -85.7);
case 101: return new CityInfo("San José de Pane", "04", 14.48333, -87.83333);
case 102: return new CityInfo("San José de Oriente", "16", 15.03333, -88.11667);
case 103: return new CityInfo("San José del Potrero", "04", 14.83333, -87.28333);
case 104: return new CityInfo("San José del Boquerón", "06", 15.48333, -87.86667);
case 105: return new CityInfo("San José de Copán", "05", 14.9, -88.71667);
case 106: return new CityInfo("San José de Comayagua", "04", 14.73333, -88.03333);
case 107: return new CityInfo("San José de Colinas", "16", 15.03333, -88.3);
case 108: return new CityInfo("San José", "18", 15.31667, -87.16667);
case 109: return new CityInfo("San José", "12", 14.25, -87.95);
case 110: return new CityInfo("San Joaquín", "05", 15.05, -88.9);
case 111: return new CityInfo("San Jerónimo", "05", 14.96667, -88.86667);
case 112: return new CityInfo("San Jerónimo", "04", 14.63333, -87.6);
case 113: return new CityInfo("San Jerónimo", "02", 13.17667, -87.13639);
case 114: return new CityInfo("San Ignacio", "08", 14.65, -87.03333);
case 115: return new CityInfo("San Francisco de Yojoa", "06", 15.01667, -87.96667);
case 116: return new CityInfo("San Francisco de Ojuera", "16", 14.75, -88.18333);
case 117: return new CityInfo("San Francisco del Valle", "14", 14.43333, -88.95);
case 118: return new CityInfo("San Francisco de la Paz", "15", 14.9, -86.2);
case 119: return new CityInfo("San Francisco de Coray", "17", 13.66139, -87.53278);
case 120: return new CityInfo("San Francisco de Cones", "14", 14.51667, -88.9);
case 121: return new CityInfo("San Francisco de Becerra", "15", 14.63333, -86.1);
case 122: return new CityInfo("San Francisco", "01", 15.65, -87.05);
case 123: return new CityInfo("San Francisco", "02", 13.36667, -86.9);
case 124: return new CityInfo("San Fernando", "14", 14.68333, -89.11667);
case 125: return new CityInfo("San Esteban", "15", 15.21231, -85.76996);
case 126: return new CityInfo("Sandy Bay", "11", 16.32923, -86.56446);
case 127: return new CityInfo("San Diego", "07", 14.05, -86.46667);
case 128: return new CityInfo("San Buenaventura", "06", 15.01667, -88);
case 129: return new CityInfo("San Antonio del Norte", "12", 13.88444, -87.70306);
case 130: return new CityInfo("San Antonio de la Cuesta", "04", 14.63333, -87.6);
case 131: return new CityInfo("San Antonio de Cortés", "06", 15.11667, -88.03333);
case 132: return new CityInfo("San Antonio", "01", 15.6, -87.15);
case 133: return new CityInfo("San Antonio", "18", 15.33333, -87.15);
case 134: return new CityInfo("San Antonio", "14", 14.51667, -88.96667);
case 135: return new CityInfo("San Agustín", "05", 14.81667, -88.93333);
case 136: return new CityInfo("San Agustín", "02", 13.2, -87.11667);
case 137: return new CityInfo("Sambo Creek", "01", 15.81667, -86.68333);
case 138: return new CityInfo("Salamá", "03", 15.75, -85.96667);
case 139: return new CityInfo("Salamá", "15", 14.83333, -86.58333);
case 140: return new CityInfo("Sabanagrande", "08", 13.80778, -87.25917);
case 141: return new CityInfo("Sabana Abajo", "15", 14.6, -86.58333);
case 142: return new CityInfo("Coxen Hole", "11", 16.31759, -86.53793);
case 143: return new CityInfo("Río Lindo", "06", 15.03333, -87.98333);
case 144: return new CityInfo("Río Esteban", "03", 15.83333, -86.3);
case 145: return new CityInfo("Río Chiquito", "06", 15.63333, -88.25);
case 146: return new CityInfo("Río Bonito", "04", 14.76667, -87.88333);
case 147: return new CityInfo("Río Blanquito", "06", 15.73333, -87.9);
case 148: return new CityInfo("Río Amarillo", "05", 14.96667, -89.13333);
case 149: return new CityInfo("Río Abajo", "08", 14.16667, -87.21667);
case 150: return new CityInfo("Reitoca", "08", 13.82583, -87.46528);
case 151: return new CityInfo("Quimistán", "16", 15.35, -88.4);
case 152: return new CityInfo("Quezailica", "05", 14.88333, -88.73333);
case 153: return new CityInfo("Quebrada Seca", "06", 15.66667, -87.95);
case 154: return new CityInfo("Quebradas", "08", 14.5, -87.35);
case 155: return new CityInfo("Quebrada Larga", "07", 14.1, -86.36667);
case 156: return new CityInfo("Quebrada de Yoro", "18", 15.43333, -87.78333);
case 157: return new CityInfo("Quebrada de Arena", "03", 15.76667, -85.91667);
case 158: return new CityInfo("Punuare", "15", 14.73333, -85.96667);
case 159: return new CityInfo("Punta Piedra", "03", 15.9, -85.28333);
case 160: return new CityInfo("Punta Ocote", "18", 15.2, -87.28333);
case 161: return new CityInfo("Puerto Lempira", "09", 15.26667, -83.77222);
case 162: return new CityInfo("Puerto Castilla", "03", 16.01667, -85.96667);
case 163: return new CityInfo("Puerto Alto", "06", 15.7, -87.86667);
case 164: return new CityInfo("Pueblo Nuevo", "06", 15.28333, -88.01667);
case 165: return new CityInfo("Pueblo Nuevo", "05", 15, -88.75);
case 166: return new CityInfo("Pueblo Nuevo", "08", 14.38333, -87.28333);
case 167: return new CityInfo("Protección", "16", 15.03333, -88.65);
case 168: return new CityInfo("Prieta", "03", 15.5806, -86.13664);
case 169: return new CityInfo("Potrerillos", "06", 15.63333, -88.3);
case 170: return new CityInfo("Potrerillos", "16", 15.26667, -88.43333);
case 171: return new CityInfo("Potrerillos", "06", 15.23333, -87.96667);
case 172: return new CityInfo("Potrerillos", "04", 14.55, -87.86667);
case 173: return new CityInfo("Pinalejo", "16", 15.38333, -88.4);
case 174: return new CityInfo("Pimienta Vieja", "06", 15.23333, -87.96667);
case 175: return new CityInfo("Piedras Amarillas", "01", 15.68333, -86.56667);
case 176: return new CityInfo("Petoa", "16", 15.26667, -88.28333);
case 177: return new CityInfo("Pespire", "02", 13.59222, -87.36167);
case 178: return new CityInfo("Peña Blanca", "06", 15.53333, -88.05);
case 179: return new CityInfo("Paujiles", "18", 15.1, -87.35);
case 180: return new CityInfo("Paptalaya", "09", 15.5, -84.31667);
case 181: return new CityInfo("Palo Pintado", "04", 14.51667, -87.68333);
case 182: return new CityInfo("Palkaka", "09", 15.31667, -83.86667);
case 183: return new CityInfo("Ostumán", "05", 14.83333, -89.16667);
case 184: return new CityInfo("Oropolí", "07", 13.81667, -86.81667);
case 185: return new CityInfo("Oropéndolas", "06", 15.01667, -87.93333);
case 186: return new CityInfo("Orocuina", "02", 13.48167, -87.105);
case 187: return new CityInfo("Orica", "08", 14.7, -86.95);
case 188: return new CityInfo("Omoa", "06", 15.76667, -88.03333);
case 189: return new CityInfo("Olanchito", "18", 15.48131, -86.57415);
case 190: return new CityInfo("Ojos de Agua", "05", 14.7, -88.81667);
case 191: return new CityInfo("Ojos de Agua", "04", 14.6, -87.93333);
case 192: return new CityInfo("Ojojona", "08", 13.93389, -87.29583);
case 193: return new CityInfo("Ojo de Agua", "07", 14.01667, -86.35);
case 194: return new CityInfo("Ocote Paulino", "18", 15.41667, -87.6);
case 195: return new CityInfo("Nuevo Chamelecón", "06", 15.38333, -88.01667);
case 196: return new CityInfo("Nuevo Celilac", "16", 14.98333, -88.33333);
case 197: return new CityInfo("Nueva Ocotepeque", "14", 14.43333, -89.18333);
case 198: return new CityInfo("Nueva Jalapa", "16", 14.91667, -88.33333);
case 199: return new CityInfo("Nueva Granada", "06", 15.11667, -88.1);
case 200: return new CityInfo("Nueva Florida", "18", 15.46667, -87.5);
case 201: return new CityInfo("Nueva Esperanza", "18", 15.26667, -87.6);
case 202: return new CityInfo("Nueva Armenia", "01", 15.79556, -86.49845);
case 203: return new CityInfo("Nueva Armenia", "05", 15.03333, -89.1);
case 204: return new CityInfo("Nombre de Jesús", "18", 15.35, -86.68333);
case 205: return new CityInfo("Naranjito", "16", 14.95, -88.68333);
case 206: return new CityInfo("Namasigüe", "02", 13.20472, -87.13889);
case 207: return new CityInfo("Naco", "16", 15.38333, -88.18333);
case 208: return new CityInfo("Nacaome", "17", 13.53611, -87.4875);
case 209: return new CityInfo("Morolica", "02", 13.56667, -86.9);
case 210: return new CityInfo("Morocelí", "07", 14.11667, -86.86667);
case 211: return new CityInfo("Morazán", "18", 15.31667, -87.6);
case 212: return new CityInfo("Monterrey", "06", 15.58333, -87.88333);
case 213: return new CityInfo("Monjarás", "02", 13.20056, -87.37417);
case 214: return new CityInfo("Mojimán", "18", 15.26667, -87.6);
case 215: return new CityInfo("Minas de Oro", "04", 14.8, -87.35);
case 216: return new CityInfo("Mezapa", "01", 15.58333, -87.65);
case 217: return new CityInfo("Mezapa", "01", 15.55, -87.38333);
case 218: return new CityInfo("Mercedes", "14", 14.43333, -89.15);
case 219: return new CityInfo("Meámbar", "04", 14.78333, -87.76667);
case 220: return new CityInfo("Mateo", "08", 14.08333, -87.31667);
case 221: return new CityInfo("Matarras", "01", 15.51667, -87.4);
case 222: return new CityInfo("Mata de Plátano", "08", 14.6, -87.28333);
case 223: return new CityInfo("Marcovia", "02", 13.28806, -87.30972);
case 224: return new CityInfo("Marcala", "12", 14.15, -88.03333);
case 225: return new CityInfo("Marale", "08", 14.88333, -87.15);
case 226: return new CityInfo("Manto", "15", 14.91667, -86.38333);
case 227: return new CityInfo("Mangulile", "15", 15.06667, -86.8);
case 228: return new CityInfo("Mandasta", "07", 13.73333, -86.91667);
case 229: return new CityInfo("Magdalena", "10", 13.86667, -88.3);
case 230: return new CityInfo("Macholoa", "16", 14.91667, -88.3);
case 231: return new CityInfo("Lucerna", "14", 14.55, -88.93333);
case 232: return new CityInfo("Los Tangos", "05", 15.15, -88.68333);
case 233: return new CityInfo("Los Planes", "12", 14.05, -88.01667);
case 234: return new CityInfo("Los Naranjos", "06", 14.9, -88.05);
case 235: return new CityInfo("Los Llanitos", "02", 13.28694, -87.33444);
case 236: return new CityInfo("Los Caminos", "06", 14.95, -87.96667);
case 237: return new CityInfo("Los Arroyos", "05", 14.65, -88.88333);
case 238: return new CityInfo("Lomitas", "18", 15.1, -87.21667);
case 239: return new CityInfo("Loma Alta", "16", 15.39667, -88.55972);
case 240: return new CityInfo("Llano Largo", "14", 14.46667, -89.01667);
case 241: return new CityInfo("Liure", "07", 13.53583, -87.09194);
case 242: return new CityInfo("Lepaterique", "08", 14.06667, -87.46667);
case 243: return new CityInfo("Lepaera", "13", 14.78333, -88.58333);
case 244: return new CityInfo("Lejamaní", "04", 14.36667, -87.7);
case 245: return new CityInfo("La Zumbadora", "05", 15.01667, -88.9);
case 246: return new CityInfo("La Virtud", "13", 14.05, -88.7);
case 247: return new CityInfo("La Unión", "01", 15.71667, -87);
case 248: return new CityInfo("La Unión", "16", 15.13333, -88.55);
case 249: return new CityInfo("La Unión", "13", 14.81667, -88.4);
case 250: return new CityInfo("La Trinidad", "18", 15.1, -87.2);
case 251: return new CityInfo("La Trinidad", "04", 14.71667, -87.66667);
case 252: return new CityInfo("Las Vegas", "18", 15.01667, -87.45);
case 253: return new CityInfo("Las Vegas, Santa Barbara", "16", 14.87649, -88.07473);
case 254: return new CityInfo("Las Trojes", "07", 14.06667, -85.98333);
case 255: return new CityInfo("Las Tejeras", "13", 14.8, -88.6);
case 256: return new CityInfo("Las Tapias", "08", 14.06667, -87.28333);
case 257: return new CityInfo("Las Mercedes", "04", 14.28333, -87.56667);
case 258: return new CityInfo("Las Lajas", "04", 14.78333, -87.75);
case 259: return new CityInfo("San José de Las Conchas", "02", 13.32528, -87.39556);
case 260: return new CityInfo("La Sarrosa", "18", 15.23333, -87.83333);
case 261: return new CityInfo("Las Ánimas", "07", 14.25, -86.56667);
case 262: return new CityInfo("La Sabana", "06", 15.36667, -87.93333);
case 263: return new CityInfo("La Rosa", "18", 15.35, -87.06667);
case 264: return new CityInfo("La Reina", "16", 15.11667, -88.63333);
case 265: return new CityInfo("La Playona", "05", 15.11667, -88.98333);
case 266: return new CityInfo("La Paz", "12", 14.31944, -87.67917);
case 267: return new CityInfo("Langue", "17", 13.62083, -87.6525);
case 268: return new CityInfo("La Mina", "18", 15.31667, -87.83333);
case 269: return new CityInfo("La Masica", "01", 15.61667, -87.11667);
case 270: return new CityInfo("Lamaní", "04", 14.2, -87.61667);
case 271: return new CityInfo("La Lima", "06", 15.43333, -87.91667);
case 272: return new CityInfo("La Libertad", "13", 14.8, -88.58333);
case 273: return new CityInfo("La Libertad", "04", 14.75, -87.61667);
case 274: return new CityInfo("La Laguna del Pedernal", "13", 14.81667, -88.56667);
case 275: return new CityInfo("La Labor", "14", 14.48333, -89);
case 276: return new CityInfo("La Jutosa", "06", 15.63333, -88);
case 277: return new CityInfo("La Jigua", "05", 15.03333, -88.8);
case 278: return new CityInfo("La Huesa", "06", 15.58333, -87.88333);
case 279: return new CityInfo("Laguna Verde", "16", 15.2, -88.16667);
case 280: return new CityInfo("Laguna Seca", "15", 14.7, -86.1);
case 281: return new CityInfo("Lagunas", "13", 14.61667, -88.48333);
case 282: return new CityInfo("La Guata", "15", 15.08333, -86.38333);
case 283: return new CityInfo("La Guama", "06", 14.88333, -87.93333);
case 284: return new CityInfo("La Guacamaya", "18", 15.25, -87.8);
case 285: return new CityInfo("La Florida", "12", 14.06667, -87.98333);
case 286: return new CityInfo("La Flecha", "16", 15.28333, -88.48333);
case 287: return new CityInfo("La Estancia", "18", 15.28333, -87.55);
case 288: return new CityInfo("La Estancia", "15", 15.05, -86.35);
case 289: return new CityInfo("La Esperanza", "03", 15.63333, -85.76667);
case 290: return new CityInfo("La Esperanza", "06", 15.41667, -88.18333);
case 291: return new CityInfo("La Esperanza", "05", 15.05091, -89.09818);
case 292: return new CityInfo("La Esperanza", "10", 14.31111, -88.18056);
case 293: return new CityInfo("La Ermita", "08", 14.46667, -87.06667);
case 294: return new CityInfo("La Entrada", "05", 15.05, -88.73333);
case 295: return new CityInfo("La Encarnación", "14", 14.66667, -89.08333);
case 296: return new CityInfo("La Empalizada", "15", 14.65, -86.13333);
case 297: return new CityInfo("La Curva", "03", 15.8, -85.76667);
case 298: return new CityInfo("La Criba", "17", 13.45361, -87.41333);
case 299: return new CityInfo("La Concepción", "15", 14.7, -86.23333);
case 300: return new CityInfo("La Colorada", "01", 15.61667, -86.81667);
case 301: return new CityInfo("La Ceiba", "01", 15.75971, -86.78221);
case 302: return new CityInfo("La Brea", "03", 15.8, -85.96667);
case 303: return new CityInfo("Jutiquile", "15", 14.71667, -86.08333);
case 304: return new CityInfo("Juticalpa", "15", 14.66667, -86.21944);
case 305: return new CityInfo("Jutiapa", "01", 15.76667, -86.51667);
case 306: return new CityInfo("Jutiapa", "07", 13.98333, -86.4);
case 307: return new CityInfo("Joconal", "16", 15.35444, -88.63556);
case 308: return new CityInfo("Jocón", "18", 15.28333, -86.96667);
case 309: return new CityInfo("Jiquinlaca", "10", 14, -88.35);
case 310: return new CityInfo("Jícaro Galán", "17", 13.53167, -87.43889);
case 311: return new CityInfo("Jesús de Otoro", "10", 14.48333, -87.98333);
case 312: return new CityInfo("Jericó", "03", 15.95, -85.96667);
case 313: return new CityInfo("Jardines", "04", 14.7, -87.98333);
case 314: return new CityInfo("Jamalteca", "04", 14.7, -87.58333);
case 315: return new CityInfo("Jacaleapa", "07", 14.01667, -86.66667);
case 316: return new CityInfo("Iralaya", "09", 15, -83.23333);
case 317: return new CityInfo("Intibucá", "10", 14.31667, -88.16667);
case 318: return new CityInfo("Ilama", "16", 15.06667, -88.21667);
case 319: return new CityInfo("Hicaque", "01", 15.71667, -87.36667);
case 320: return new CityInfo("Güinope", "07", 13.88333, -86.93333);
case 321: return new CityInfo("Guayape", "15", 14.71667, -86.83333);
case 322: return new CityInfo("Guatemalita", "13", 14.11667, -88.61667);
case 323: return new CityInfo("Guarizama", "15", 14.91667, -86.33333);
case 324: return new CityInfo("Guanaja", "11", 16.44795, -85.89431);
case 325: return new CityInfo("Gualjoco", "16", 14.95, -88.23333);
case 326: return new CityInfo("Gualaco", "15", 15.02521, -86.07076);
case 327: return new CityInfo("Guaimitas", "18", 15.5, -87.71667);
case 328: return new CityInfo("Guaimaca", "08", 14.53333, -86.81667);
case 329: return new CityInfo("Guacamaya", "16", 15.01667, -88.15);
case 330: return new CityInfo("Gracias", "13", 14.59028, -88.58194);
case 331: return new CityInfo("Goascorán", "17", 13.58333, -87.61667);
case 332: return new CityInfo("French Harbor", "11", 16.35, -86.43333);
case 333: return new CityInfo("Francia", "03", 15.85, -85.58333);
case 334: return new CityInfo("Florida", "05", 15.03333, -88.83333);
case 335: return new CityInfo("Flores", "04", 14.28333, -87.56667);
case 336: return new CityInfo("Esquías", "04", 14.73333, -87.36667);
case 337: return new CityInfo("Erandique", "13", 14.23333, -88.46667);
case 338: return new CityInfo("El Zapote", "06", 15.01667, -87.85);
case 339: return new CityInfo("El Zapotal del Norte", "06", 15.51667, -88.05);
case 340: return new CityInfo("El Tular", "17", 13.46639, -87.51528);
case 341: return new CityInfo("El Triunfo de la Cruz", "01", 15.76667, -87.43333);
case 342: return new CityInfo("El Triunfo", "02", 13.11667, -87);
case 343: return new CityInfo("El Tránsito", "14", 14.38333, -88.91667);
case 344: return new CityInfo("El Tizatillo", "08", 13.99944, -87.195);
case 345: return new CityInfo("El Tigre", "06", 14.93333, -87.98333);
case 346: return new CityInfo("El Terrero", "08", 14.06667, -87.06667);
case 347: return new CityInfo("El Tablón", "08", 14.03333, -87.16667);
case 348: return new CityInfo("El Suyatal", "08", 14.51667, -87.21667);
case 349: return new CityInfo("El Socorro", "04", 14.63333, -87.91667);
case 350: return new CityInfo("El Sauce", "04", 14.5285, -87.66571);
case 351: return new CityInfo("El Rusio", "15", 14.46667, -86.36667);
case 352: return new CityInfo("El Rosario", "15", 14.9, -86.68333);
case 353: return new CityInfo("El Rosario", "04", 14.8, -87.76667);
case 354: return new CityInfo("El Rodeo", "07", 14.28333, -86.6);
case 355: return new CityInfo("El Rincón", "04", 14.58333, -87.93333);
case 356: return new CityInfo("El Rancho", "06", 15.66667, -87.95);
case 357: return new CityInfo("El Rancho", "04", 14.68333, -87.5);
case 358: return new CityInfo("El Puente", "02", 13.28333, -87.11667);
case 359: return new CityInfo("El Progreso", "18", 15.4, -87.8);
case 360: return new CityInfo("El Porvenir", "06", 15.83333, -87.93333);
case 361: return new CityInfo("El Porvenir", "01", 15.75, -86.93333);
case 362: return new CityInfo("El Porvenir", "04", 14.58333, -87.88333);
case 363: return new CityInfo("El Porvenir", "08", 13.76167, -87.34583);
case 364: return new CityInfo("El Portillo de González", "18", 15.28333, -87.6);
case 365: return new CityInfo("El Plan", "06", 15.28333, -87.96667);
case 366: return new CityInfo("El Pino", "01", 15.7, -86.93333);
case 367: return new CityInfo("El Pescadero", "07", 13.93333, -86.55);
case 368: return new CityInfo("El Perico", "06", 15.08333, -88.1);
case 369: return new CityInfo("El Perico", "02", 13.13889, -87.03222);
case 370: return new CityInfo("El Pedernal", "08", 14.7, -87.11667);
case 371: return new CityInfo("El Paraíso", "07", 13.86667, -86.55);
case 372: return new CityInfo("El Olivar", "06", 15.08333, -87.88333);
case 373: return new CityInfo("El Ocotón", "05", 15.03333, -88.88333);
case 374: return new CityInfo("El Ocote", "18", 15.41667, -86.56667);
case 375: return new CityInfo("El Obraje", "07", 14, -86.43333);
case 376: return new CityInfo("El Obraje", "02", 13.15417, -87.13083);
case 377: return new CityInfo("El Níspero", "16", 14.76667, -88.33333);
case 378: return new CityInfo("El Negrito", "18", 15.31667, -87.7);
case 379: return new CityInfo("El Mochito", "16", 14.86667, -88.08333);
case 380: return new CityInfo("El Milagro", "06", 15.4, -87.96667);
case 381: return new CityInfo("El Marañón", "06", 15.4, -88.05);
case 382: return new CityInfo("El Lolo", "08", 14.11667, -87.26667);
case 383: return new CityInfo("El Llano", "06", 15.15, -87.88333);
case 384: return new CityInfo("El Juncal", "18", 15.45, -86.43333);
case 385: return new CityInfo("Elíxir", "03", 15.48333, -86.3);
case 386: return new CityInfo("El Guayabo", "17", 13.48944, -87.44389);
case 387: return new CityInfo("El Guayabito", "15", 14.83333, -86.03333);
case 388: return new CityInfo("El Guapinol", "08", 13.76667, -87.46667);
case 389: return new CityInfo("El Guantillo", "08", 14.6, -87.3);
case 390: return new CityInfo("El Guante", "08", 14.55, -87.1);
case 391: return new CityInfo("El Granzal", "14", 14.4, -88.86667);
case 392: return new CityInfo("El Escaño de Tepale", "08", 14.75, -87.06667);
case 393: return new CityInfo("El Escanito", "08", 14.66667, -87.1);
case 394: return new CityInfo("El Ermitano", "16", 15.25, -88.68333);
case 395: return new CityInfo("El Edén", "06", 14.95, -88.01667);
case 396: return new CityInfo("El Durazno", "08", 14.13333, -87.26667);
case 397: return new CityInfo("El Derrumbo", "05", 14.75, -88.78333);
case 398: return new CityInfo("El Cubolero", "17", 13.46667, -87.66667);
case 399: return new CityInfo("El Corpus", "05", 14.7, -88.91667);
case 400: return new CityInfo("Corpus", "02", 13.28889, -87.03472);
case 401: return new CityInfo("El Corozal", "16", 15.06667, -88.61667);
case 402: return new CityInfo("El Ciruelo", "16", 15.3, -88.5);
case 403: return new CityInfo("El Chimbo", "08", 14.13333, -87.11667);
case 404: return new CityInfo("El Chichicaste", "07", 14.06667, -86.3);
case 405: return new CityInfo("El Buen Pastor", "04", 14.86667, -87.78333);
case 406: return new CityInfo("El Benque", "07", 14.03333, -86.46667);
case 407: return new CityInfo("El Bálsamo", "18", 15.06667, -87.46667);
case 408: return new CityInfo("El Agua Dulcita", "04", 14.7, -87.75);
case 409: return new CityInfo("El Achiotal", "13", 14.08333, -88.75);
case 410: return new CityInfo("Duyure", "02", 13.63333, -86.81667);
case 411: return new CityInfo("Dulce Nombre de Culmí", "15", 15.1, -85.53333);
case 412: return new CityInfo("Dulce Nombre", "05", 14.85, -88.83333);
case 413: return new CityInfo("Dolores", "05", 14.86667, -88.83333);
case 414: return new CityInfo("Danlí", "07", 14.03333, -86.58333);
case 415: return new CityInfo("Cuyamel", "06", 15.66667, -88.2);
case 416: return new CityInfo("Cuyalí", "07", 13.88333, -86.55);
case 417: return new CityInfo("Cusuna", "03", 15.85, -85.23333);
case 418: return new CityInfo("Cucuyagua", "05", 14.65, -88.86667);
case 419: return new CityInfo("Coyoles Central", "18", 15.4, -86.66667);
case 420: return new CityInfo("Coyoles", "18", 15.46667, -86.68333);
case 421: return new CityInfo("Correderos", "16", 15.41667, -88.45);
case 422: return new CityInfo("Corquín", "05", 14.56667, -88.86667);
case 423: return new CityInfo("Corozal", "01", 15.8, -86.71667);
case 424: return new CityInfo("Corocito", "03", 15.75, -85.78333);
case 425: return new CityInfo("Corinto", "06", 15.58333, -88.36667);
case 426: return new CityInfo("Copán", "05", 14.83333, -89.15);
case 427: return new CityInfo("Concordia", "15", 14.61667, -86.65);
case 428: return new CityInfo("Concepción de María", "02", 13.21667, -87);
case 429: return new CityInfo("Concepción del Sur", "16", 14.8, -88.16667);
case 430: return new CityInfo("Concepción del Norte", "16", 15.16667, -88.13333);
case 431: return new CityInfo("Concepción de la Barranca", "05", 15.16667, -88.71667);
case 432: return new CityInfo("Concepción de Guasistagua", "04", 14.6, -87.65);
case 433: return new CityInfo("Comayagua", "04", 14.45139, -87.6375);
case 434: return new CityInfo("Cololaca", "13", 14.3, -88.88333);
case 435: return new CityInfo("Cofradía", "06", 15.4, -88.15);
case 436: return new CityInfo("Cofradía", "08", 14.21667, -87.18333);
case 437: return new CityInfo("Chotepe", "06", 15.41667, -87.98333);
case 438: return new CityInfo("Ciudad Choluteca", "02", 13.30028, -87.19083);
case 439: return new CityInfo("Choloma", "06", 15.61444, -87.95302);
case 440: return new CityInfo("Chivana", "06", 15.75, -87.98333);
case 441: return new CityInfo("Chirinos", "18", 15.4, -86.58333);
case 442: return new CityInfo("Chiquila", "16", 15.23333, -88.58333);
case 443: return new CityInfo("Chalmeca", "05", 15.1, -88.68333);
case 444: return new CityInfo("Cerro Grande", "08", 13.81667, -87.25);
case 445: return new CityInfo("Cerro Blanco", "04", 14.66667, -87.78333);
case 446: return new CityInfo("Ceguaca", "16", 14.8, -88.2);
case 447: return new CityInfo("Cedros", "08", 14.6, -87.11667);
case 448: return new CityInfo("Casa Quemada", "16", 15.26667, -88.55);
case 449: return new CityInfo("Casa Quemada", "06", 15.11667, -88.08333);
case 450: return new CityInfo("Carbajales", "18", 15.51667, -86.35);
case 451: return new CityInfo("Cane", "12", 14.28333, -87.66667);
case 452: return new CityInfo("Cañaveral", "06", 14.98333, -88.01667);
case 453: return new CityInfo("Campamento", "15", 14.55, -86.65);
case 454: return new CityInfo("Camasca", "10", 14, -88.38333);
case 455: return new CityInfo("Camalote", "16", 15.33333, -88.33333);
case 456: return new CityInfo("Callejones", "16", 15.16667, -88.65);
case 457: return new CityInfo("Buenos Aires", "06", 15.48333, -88.18333);
case 458: return new CityInfo("Buenos Aires", "18", 15.46667, -86.4);
case 459: return new CityInfo("Buenos Aires", "05", 15.03333, -88.96667);
case 460: return new CityInfo("Brus Laguna", "09", 15.75, -84.48333);
case 461: return new CityInfo("Bonito Oriental", "03", 15.74765, -85.73559);
case 462: return new CityInfo("Berlín", "16", 14.83333, -88.5);
case 463: return new CityInfo("Belén Gualcho", "14", 14.48333, -88.8);
case 464: return new CityInfo("Bejuco", "06", 15.13333, -87.93333);
case 465: return new CityInfo("Barra Patuca", "09", 15.8, -84.28333);
case 466: return new CityInfo("Baracoa", "06", 15.76667, -87.85);
case 467: return new CityInfo("Bálsamo Oriental", "18", 15.48333, -86.33333);
case 468: return new CityInfo("Baja Mar", "06", 15.88851, -87.85547);
case 469: return new CityInfo("Azacualpa", "16", 15.34333, -88.55139);
case 470: return new CityInfo("Azacualpa", "16", 14.71667, -88.1);
case 471: return new CityInfo("Azacualpa", "10", 14.26667, -88.38333);
case 472: return new CityInfo("Ayapa", "18", 15.11174, -87.17557);
case 473: return new CityInfo("Auka", "09", 14.94087, -83.83229);
case 474: return new CityInfo("Auas", "09", 15.48333, -84.33333);
case 475: return new CityInfo("Atima", "16", 14.93333, -88.48333);
case 476: return new CityInfo("Atenas de San Cristóbal", "01", 15.68333, -87.31667);
case 477: return new CityInfo("Armenta", "06", 15.5, -88.05);
case 478: return new CityInfo("Armenia", "18", 15.46667, -86.36667);
case 479: return new CityInfo("Arizona", "01", 15.63333, -87.31667);
case 480: return new CityInfo("Arimís", "15", 14.78333, -86);
case 481: return new CityInfo("Arenal", "18", 15.35, -86.83333);
case 482: return new CityInfo("Araulí", "07", 13.95, -86.55);
case 483: return new CityInfo("Aramecina", "17", 13.74222, -87.71028);
case 484: return new CityInfo("Arada", "16", 14.85, -88.3);
case 485: return new CityInfo("Antigua Ocotepeque", "14", 14.4, -89.2);
case 486: return new CityInfo("Amapala", "17", 13.29222, -87.65389);
case 487: return new CityInfo("Alubarén", "08", 13.79611, -87.46889);
case 488: return new CityInfo("La Alianza", "17", 13.51222, -87.72444);
case 489: return new CityInfo("Ajuterique", "04", 14.38333, -87.7);
case 490: return new CityInfo("Aguas del Padre", "04", 14.56667, -87.88333);
case 491: return new CityInfo("Agualote", "16", 15.33528, -88.55306);
case 492: return new CityInfo("Agua Fría", "17", 13.46889, -87.55111);
case 493: return new CityInfo("Agua Caliente de Linaca", "02", 13.43528, -87.23167);
case 494: return new CityInfo("Agua Caliente", "05", 14.88333, -88.81667);
case 495: return new CityInfo("Agua Blanca Sur", "18", 15.25, -87.88333);
case 496: return new CityInfo("Agua Azul Rancho", "06", 14.9, -87.95);
case 497: return new CityInfo("Agua Azul", "06", 14.91667, -87.96667);
case 498: return new CityInfo("Agalteca", "08", 14.45, -87.26667);
case 499: return new CityInfo("Texíguat", "07", 13.64972, -87.0225);
default: return new CityInfo("La Ruidosa", "05", 15.23628, -88.75142);

                                    }                                        
                                }
                            
                        }
                    }
                