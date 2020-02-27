
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
                                    public const string Country = "NZ";
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
                            
                                        var cur = (Math.Abs(-42.95 - lat) + Math.Abs(171.56667 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-46.33333 - lat) + Math.Abs(168.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.31667 - lat) + Math.Abs(172.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.83333 - lat) + Math.Abs(175.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.2 - lat) + Math.Abs(175.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.28333 - lat) + Math.Abs(174.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.28664 - lat) + Math.Abs(174.77557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.76667 - lat) + Math.Abs(174.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.4 - lat) + Math.Abs(174.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.93333 - lat) + Math.Abs(175.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.33333 - lat) + Math.Abs(168.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.4 - lat) + Math.Abs(173.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.24806 - lat) + Math.Abs(174.73489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.75 - lat) + Math.Abs(170.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.27025 - lat) + Math.Abs(174.08062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.47753 - lat) + Math.Abs(175.66834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.31667 - lat) + Math.Abs(173.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.15 - lat) + Math.Abs(177.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.3 - lat) + Math.Abs(172.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.4 - lat) + Math.Abs(175.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.76667 - lat) + Math.Abs(175.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.99037 - lat) + Math.Abs(175.80837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.13333 - lat) + Math.Abs(167.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.36667 - lat) + Math.Abs(178.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.23333 - lat) + Math.Abs(175.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.473 - lat) + Math.Abs(175.50934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.98333 - lat) + Math.Abs(175.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.91667 - lat) + Math.Abs(171.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-44.39672 - lat) + Math.Abs(171.25364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.4 - lat) + Math.Abs(175.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.46667 - lat) + Math.Abs(177.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.8 - lat) + Math.Abs(175.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.41667 - lat) + Math.Abs(167.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.68333 - lat) + Math.Abs(176.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.06667 - lat) + Math.Abs(177.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.03333 - lat) + Math.Abs(176.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.85 - lat) + Math.Abs(172.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.01667 - lat) + Math.Abs(175.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-34.99604 - lat) + Math.Abs(173.46665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.81667 - lat) + Math.Abs(172.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.25 - lat) + Math.Abs(172.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.66667 - lat) + Math.Abs(174.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.22011 - lat) + Math.Abs(175.42445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.26153 - lat) + Math.Abs(174.12257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.88333 - lat) + Math.Abs(178.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.29262 - lat) + Math.Abs(175.42514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.58333 - lat) + Math.Abs(172.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.08333 - lat) + Math.Abs(173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.33333 - lat) + Math.Abs(173.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.43594 - lat) + Math.Abs(176.34117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.11667 - lat) + Math.Abs(171.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.13333 - lat) + Math.Abs(170.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.75 - lat) + Math.Abs(172.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.8 - lat) + Math.Abs(174.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.2 - lat) + Math.Abs(174.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.58333 - lat) + Math.Abs(172.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.85 - lat) + Math.Abs(170.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.13333 - lat) + Math.Abs(173.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.13333 - lat) + Math.Abs(174.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-44.26667 - lat) + Math.Abs(171.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.46667 - lat) + Math.Abs(175.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-44.7 - lat) + Math.Abs(169.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.01667 - lat) + Math.Abs(175.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-44.5 - lat) + Math.Abs(171.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.91667 - lat) + Math.Abs(175.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.65 - lat) + Math.Abs(174.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.56069 - lat) + Math.Abs(169.47068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.35636 - lat) + Math.Abs(175.61113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.28067 - lat) + Math.Abs(174.09103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.81667 - lat) + Math.Abs(176.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.3 - lat) + Math.Abs(172.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.86667 - lat) + Math.Abs(170.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.18333 - lat) + Math.Abs(175.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.15 - lat) + Math.Abs(168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.88333 - lat) + Math.Abs(176.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.2 - lat) + Math.Abs(173.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.31667 - lat) + Math.Abs(173.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.2 - lat) + Math.Abs(174.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.35 - lat) + Math.Abs(173.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.8 - lat) + Math.Abs(174.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.61667 - lat) + Math.Abs(174.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.28333 - lat) + Math.Abs(175.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.06667 - lat) + Math.Abs(174.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.27078 - lat) + Math.Abs(173.28404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.4926 - lat) + Math.Abs(176.91233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.46667 - lat) + Math.Abs(176.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.83659 - lat) + Math.Abs(174.43298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.8 - lat) + Math.Abs(172.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.38333 - lat) + Math.Abs(174.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.63333 - lat) + Math.Abs(171.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.1 - lat) + Math.Abs(174.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.75 - lat) + Math.Abs(174.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.88333 - lat) + Math.Abs(176.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.25 - lat) + Math.Abs(173.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.68333 - lat) + Math.Abs(177.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.99282 - lat) + Math.Abs(174.87986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.96807 - lat) + Math.Abs(174.79875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.71667 - lat) + Math.Abs(175.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.55 - lat) + Math.Abs(174.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.1 - lat) + Math.Abs(176.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.76667 - lat) + Math.Abs(176.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.21667 - lat) + Math.Abs(174.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.65 - lat) + Math.Abs(172.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.76667 - lat) + Math.Abs(172.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.33288 - lat) + Math.Abs(168.71476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.245 - lat) + Math.Abs(174.79422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.22676 - lat) + Math.Abs(173.94739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.3 - lat) + Math.Abs(175.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.28333 - lat) + Math.Abs(174.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.06667 - lat) + Math.Abs(174.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.1 - lat) + Math.Abs(176.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.38333 - lat) + Math.Abs(174.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.55 - lat) + Math.Abs(175.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.16667 - lat) + Math.Abs(174.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.41667 - lat) + Math.Abs(173.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.1 - lat) + Math.Abs(173.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.4 - lat) + Math.Abs(168.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.93656 - lat) + Math.Abs(175.56835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.4 - lat) + Math.Abs(175.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.28333 - lat) + Math.Abs(173.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.6381 - lat) + Math.Abs(176.84918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.28066 - lat) + Math.Abs(174.05434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.51667 - lat) + Math.Abs(172.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.78333 - lat) + Math.Abs(175.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-44.1 - lat) + Math.Abs(170.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.98333 - lat) + Math.Abs(176.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.31667 - lat) + Math.Abs(168.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.95 - lat) + Math.Abs(174.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.87416 - lat) + Math.Abs(170.50361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.45 - lat) + Math.Abs(171.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.93333 - lat) + Math.Abs(173.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.48333 - lat) + Math.Abs(172.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.7611 - lat) + Math.Abs(175.49634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.18651 - lat) + Math.Abs(169.31545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.53333 - lat) + Math.Abs(172.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.9 - lat) + Math.Abs(176.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.61667 - lat) + Math.Abs(172.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.17487 - lat) + Math.Abs(175.38463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.30586 - lat) + Math.Abs(174.76257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.38333 - lat) + Math.Abs(173.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.16667 - lat) + Math.Abs(174.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.84853 - lat) + Math.Abs(174.76349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.46667 - lat) + Math.Abs(175.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.15589 - lat) + Math.Abs(172.72975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.16667 - lat) + Math.Abs(173.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.45556 - lat) + Math.Abs(173.85833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.42917 - lat) + Math.Abs(174.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.59167 - lat) + Math.Abs(174.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.75833 - lat) + Math.Abs(174.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.46667 - lat) + Math.Abs(175.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.63333 - lat) + Math.Abs(175.275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.75833 - lat) + Math.Abs(175.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.03333 - lat) + Math.Abs(177.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.65333 - lat) + Math.Abs(178.00417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.41222 - lat) + Math.Abs(175.51528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.95972 - lat) + Math.Abs(175.6575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.71667 - lat) + Math.Abs(170.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.46667 - lat) + Math.Abs(171.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.75262 - lat) + Math.Abs(171.6037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.6 - lat) + Math.Abs(168.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.35 - lat) + Math.Abs(168.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.15 - lat) + Math.Abs(168.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.68611 - lat) + Math.Abs(176.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.00158 - lat) + Math.Abs(174.23836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.12083 - lat) + Math.Abs(169.96944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.275 - lat) + Math.Abs(169.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.23389 - lat) + Math.Abs(169.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.36667 - lat) + Math.Abs(175.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.38333 - lat) + Math.Abs(175.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.06573 - lat) + Math.Abs(174.94393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.95855 - lat) + Math.Abs(176.98545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.00915 - lat) + Math.Abs(177.28706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.13832 - lat) + Math.Abs(175.54011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.95353 - lat) + Math.Abs(-176.55973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-46.10282 - lat) + Math.Abs(168.94357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.03023 - lat) + Math.Abs(168.66271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-44.93837 - lat) + Math.Abs(168.81007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.03837 - lat) + Math.Abs(169.20008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.54056 - lat) + Math.Abs(169.31466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-44.09061 - lat) + Math.Abs(171.24458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-45.09758 - lat) + Math.Abs(170.97087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.89834 - lat) + Math.Abs(171.73011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.37832 - lat) + Math.Abs(172.64013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-43.80384 - lat) + Math.Abs(172.96817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.11485 - lat) + Math.Abs(173.26366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.73167 - lat) + Math.Abs(174.32391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-35.90818 - lat) + Math.Abs(174.45019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.0482 - lat) + Math.Abs(174.90019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.0582 - lat) + Math.Abs(174.97019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.72602 - lat) + Math.Abs(174.74064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.72819 - lat) + Math.Abs(174.75019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.9982 - lat) + Math.Abs(174.86019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.88333 - lat) + Math.Abs(174.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.8882 - lat) + Math.Abs(174.86019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.93754 - lat) + Math.Abs(174.65584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.8106 - lat) + Math.Abs(175.76237 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.87822 - lat) + Math.Abs(175.4402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-38.13874 - lat) + Math.Abs(176.24516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.29067 - lat) + Math.Abs(174.00801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.51603 - lat) + Math.Abs(173.9528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.22827 - lat) + Math.Abs(174.87019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-41.13827 - lat) + Math.Abs(175.0502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-39.53333 - lat) + Math.Abs(176.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-37.66738 - lat) + Math.Abs(175.15554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-36.87495 - lat) + Math.Abs(174.66991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-42.60552 - lat) + Math.Abs(171.70301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-40.40309 - lat) + Math.Abs(175.58302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Arthur’s Pass", "E9", -42.95, 171.56667);
case 1: return new CityInfo("Wyndham", "F8", -46.33333, 168.85);
case 2: return new CityInfo("Woodend", "E9", -43.31667, 172.66667);
case 3: return new CityInfo("Whitianga", "G1", -36.83333, 175.7);
case 4: return new CityInfo("Whangamata", "G1", -37.2, 175.86667);
case 5: return new CityInfo("Wellsford", "E7", -36.28333, 174.51667);
case 6: return new CityInfo("Wellington", "G2", -41.28664, 174.77557);
case 7: return new CityInfo("Waverley", "F9", -39.76667, 174.63333);
case 8: return new CityInfo("Warkworth", "E7", -36.4, 174.66667);
case 9: return new CityInfo("Wanganui", "F3", -39.93333, 175.05);
case 10: return new CityInfo("Wallacetown", "F8", -46.33333, 168.28333);
case 11: return new CityInfo("Wakefield", "TAS", -41.4, 173.05);
case 12: return new CityInfo("Waiuku", "E7", -37.24806, 174.73489);
case 13: return new CityInfo("Waitati", "F7", -45.75, 170.56667);
case 14: return new CityInfo("Waitangi", "F6", -35.27025, 174.08062);
case 15: return new CityInfo("Waiouru", "F3", -39.47753, 175.66834);
case 16: return new CityInfo("Waimate North", "F6", -35.31667, 173.88333);
case 17: return new CityInfo("Waimana", "E8", -38.15, 177.08333);
case 18: return new CityInfo("Waikuku", "E9", -43.3, 172.68333);
case 19: return new CityInfo("Waihi Beach", "E8", -37.4, 175.93333);
case 20: return new CityInfo("Waharoa", "G1", -37.76667, 175.76667);
case 21: return new CityInfo("Turangi", "G1", -38.99037, 175.80837);
case 22: return new CityInfo("Tuatapere", "F8", -46.13333, 167.68333);
case 23: return new CityInfo("Tolaga Bay", "F1", -38.36667, 178.3);
case 24: return new CityInfo("Tokoroa", "G1", -38.23333, 175.86667);
case 25: return new CityInfo("Tokomaru", "F3", -40.473, 175.50934);
case 26: return new CityInfo("Tirau", "G1", -37.98333, 175.75);
case 27: return new CityInfo("Tinwald", "E9", -43.91667, 171.71667);
case 28: return new CityInfo("Timaru", "E9", -44.39672, 171.25364);
case 29: return new CityInfo("Te Kauwhata", "G1", -37.4, 175.15);
case 30: return new CityInfo("Te Karaka", "F1", -38.46667, 177.86667);
case 31: return new CityInfo("Te Horo", "G2", -40.8, 175.1);
case 32: return new CityInfo("Te Anau", "F8", -45.41667, 167.71667);
case 33: return new CityInfo("Taupo", "G1", -38.68333, 176.08333);
case 34: return new CityInfo("Taneatua", "E8", -38.06667, 177.01667);
case 35: return new CityInfo("Takapau", "F2", -40.03333, 176.35);
case 36: return new CityInfo("Takaka", "TAS", -40.85, 172.8);
case 37: return new CityInfo("Tairua", "G1", -37.01667, 175.85);
case 38: return new CityInfo("Taipa", "F6", -34.99604, 173.46665);
case 39: return new CityInfo("Southbridge", "E9", -43.81667, 172.25);
case 40: return new CityInfo("Sefton", "E9", -43.25, 172.66667);
case 41: return new CityInfo("Seddon", "F4", -41.66667, 174.08333);
case 42: return new CityInfo("Sanson", "F3", -40.22011, 175.42445);
case 43: return new CityInfo("Russell", "F6", -35.26153, 174.12257);
case 44: return new CityInfo("Ruatoria", "F1", -37.88333, 178.33333);
case 45: return new CityInfo("Rongotea", "F3", -40.29262, 175.42514);
case 46: return new CityInfo("Rolleston", "E9", -43.58333, 172.38333);
case 47: return new CityInfo("Riwaka", "TAS", -41.08333, 173);
case 48: return new CityInfo("Richmond", "TAS", -41.33333, 173.18333);
case 49: return new CityInfo("Reporoa", "E8", -38.43594, 176.34117);
case 50: return new CityInfo("Reefton", "G3", -42.11667, 171.86667);
case 51: return new CityInfo("Ranfurly", "F7", -45.13333, 170.1);
case 52: return new CityInfo("Rakaia", "E9", -43.75, 172.01667);
case 53: return new CityInfo("Raglan", "G1", -37.8, 174.88333);
case 54: return new CityInfo("Pukekohe East", "E7", -37.2, 174.95);
case 55: return new CityInfo("Prebbleton", "E9", -43.58333, 172.51667);
case 56: return new CityInfo("Portobello", "F7", -45.85, 170.65);
case 57: return new CityInfo("Motueka", "TAS", -41.13333, 173.01667);
case 58: return new CityInfo("Porirua", "G2", -41.13333, 174.85);
case 59: return new CityInfo("Pleasant Point", "E9", -44.26667, 171.13333);
case 60: return new CityInfo("Piopio", "G1", -38.46667, 175.01667);
case 61: return new CityInfo("Wanaka", "F7", -44.7, 169.15);
case 62: return new CityInfo("Pauanui", "G1", -37.01667, 175.86667);
case 63: return new CityInfo("Pareora", "E9", -44.5, 171.2);
case 64: return new CityInfo("Paraparaumu", "G2", -40.91667, 175.01667);
case 65: return new CityInfo("Parakai", "E7", -36.65, 174.43333);
case 66: return new CityInfo("Papatowai", "F7", -46.56069, 169.47068);
case 67: return new CityInfo("Palmerston North", "F3", -40.35636, 175.61113);
case 68: return new CityInfo("Paihia", "F6", -35.28067, 174.09103);
case 69: return new CityInfo("Paengaroa", "E8", -37.81667, 176.41667);
case 70: return new CityInfo("Oxford", "E9", -43.3, 172.18333);
case 71: return new CityInfo("Outram", "F7", -45.86667, 170.23333);
case 72: return new CityInfo("Otorohanga", "G1", -38.18333, 175.2);
case 73: return new CityInfo("Otautau", "F8", -46.15, 168);
case 74: return new CityInfo("Otane", "F2", -39.88333, 176.63333);
case 75: return new CityInfo("Okato", "F9", -39.2, 173.88333);
case 76: return new CityInfo("Okaihau", "F6", -35.31667, 173.78333);
case 77: return new CityInfo("Ohariu", "G2", -41.2, 174.76667);
case 78: return new CityInfo("Ohaeawai", "F6", -35.35, 173.88333);
case 79: return new CityInfo("North Shore", "E7", -36.8, 174.75);
case 80: return new CityInfo("Ngunguru", "F6", -35.61667, 174.5);
case 81: return new CityInfo("Ngatea", "G1", -37.28333, 175.5);
case 82: return new CityInfo("New Plymouth", "F9", -39.06667, 174.08333);
case 83: return new CityInfo("Nelson", "F5", -41.27078, 173.28404);
case 84: return new CityInfo("Napier", "F2", -39.4926, 176.91233);
case 85: return new CityInfo("Murupara", "E8", -38.46667, 176.7);
case 86: return new CityInfo("Muriwai Beach", "E7", -36.83659, 174.43298);
case 87: return new CityInfo("Murchison", "TAS", -41.8, 172.33333);
case 88: return new CityInfo("Moerewa", "F6", -35.38333, 174.03333);
case 89: return new CityInfo("Methven", "E9", -43.63333, 171.65);
case 90: return new CityInfo("Maungaturoto", "F6", -36.1, 174.36667);
case 91: return new CityInfo("Maungatapere", "F6", -35.75, 174.2);
case 92: return new CityInfo("Matata", "E8", -37.88333, 176.75);
case 93: return new CityInfo("Mapua", "TAS", -41.25, 173.1);
case 94: return new CityInfo("Manutuke", "F1", -38.68333, 177.91667);
case 95: return new CityInfo("Manukau City", "E7", -36.99282, 174.87986);
case 96: return new CityInfo("Mangere", "E7", -36.96807, 174.79875);
case 97: return new CityInfo("Manakau", "F3", -40.71667, 175.21667);
case 98: return new CityInfo("Manaia", "F9", -39.55, 174.13333);
case 99: return new CityInfo("Mamaku", "E8", -38.1, 176.08333);
case 100: return new CityInfo("Maketu", "E8", -37.76667, 176.45);
case 101: return new CityInfo("Lower Hutt", "G2", -41.21667, 174.91667);
case 102: return new CityInfo("Lincoln", "E9", -43.65, 172.48333);
case 103: return new CityInfo("Leeston", "E9", -43.76667, 172.3);
case 104: return new CityInfo("Kingston", "F7", -45.33288, 168.71476);
case 105: return new CityInfo("Khandallah", "G2", -41.245, 174.79422);
case 106: return new CityInfo("Kerikeri", "F6", -35.22676, 173.94739);
case 107: return new CityInfo("Kerepehi", "G1", -37.3, 175.53333);
case 108: return new CityInfo("Kelburn", "G2", -41.28333, 174.76667);
case 109: return new CityInfo("Kawhia", "G1", -38.06667, 174.81667);
case 110: return new CityInfo("Kawerau", "E8", -38.1, 176.7);
case 111: return new CityInfo("Kawakawa", "F6", -35.38333, 174.06667);
case 112: return new CityInfo("Katikati", "E8", -37.55, 175.91667);
case 113: return new CityInfo("Kaiwaka", "F6", -36.16667, 174.45);
case 114: return new CityInfo("Kaikoura", "E9", -42.41667, 173.68333);
case 115: return new CityInfo("Kaeo", "F6", -35.1, 173.78333);
case 116: return new CityInfo("Invercargill", "F8", -46.4, 168.35);
case 117: return new CityInfo("Hunterville", "F3", -39.93656, 175.56835);
case 118: return new CityInfo("Himatangi", "F3", -40.4, 175.31667);
case 119: return new CityInfo("Havelock", "F4", -41.28333, 173.76667);
case 120: return new CityInfo("Hastings", "F2", -39.6381, 176.84918);
case 121: return new CityInfo("Haruru", "F6", -35.28066, 174.05434);
case 122: return new CityInfo("Hanmer Springs", "E9", -42.51667, 172.81667);
case 123: return new CityInfo("Hamilton", "G1", -37.78333, 175.28333);
case 124: return new CityInfo("Fairlie", "E9", -44.1, 170.83333);
case 125: return new CityInfo("Edgecumbe", "E8", -37.98333, 176.83333);
case 126: return new CityInfo("Edendale", "F8", -46.31667, 168.78333);
case 127: return new CityInfo("East Tamaki", "E7", -36.95, 174.9);
case 128: return new CityInfo("Dunedin", "F7", -45.87416, 170.50361);
case 129: return new CityInfo("Dobson", "G3", -42.45, 171.3);
case 130: return new CityInfo("Dargaville", "F6", -35.93333, 173.88333);
case 131: return new CityInfo("Darfield", "E9", -43.48333, 172.11667);
case 132: return new CityInfo("Coromandel", "G1", -36.7611, 175.49634);
case 133: return new CityInfo("Clyde", "F7", -45.18651, 169.31545);
case 134: return new CityInfo("Christchurch", "E9", -43.53333, 172.63333);
case 135: return new CityInfo("Castlepoint", "G2", -40.9, 176.21667);
case 136: return new CityInfo("Burnham", "E9", -43.61667, 172.31667);
case 137: return new CityInfo("Bulls", "F3", -40.17487, 175.38463);
case 138: return new CityInfo("Brooklyn", "G2", -41.30586, 174.76257);
case 139: return new CityInfo("Brightwater", "TAS", -41.38333, 173.11667);
case 140: return new CityInfo("Bombay", "E7", -37.16667, 174.98333);
case 141: return new CityInfo("Auckland", "E7", -36.84853, 174.76349);
case 142: return new CityInfo("Athenree", "E8", -37.46667, 175.91667);
case 143: return new CityInfo("Amberley", "E9", -43.15589, 172.72975);
case 144: return new CityInfo("Ahipara", "F6", -35.16667, 173.16667);
case 145: return new CityInfo("Opunake", "F9", -39.45556, 173.85833);
case 146: return new CityInfo("Eltham", "F9", -39.42917, 174.3);
case 147: return new CityInfo("Hawera", "F9", -39.59167, 174.28333);
case 148: return new CityInfo("Patea", "F9", -39.75833, 174.48333);
case 149: return new CityInfo("Foxton", "F3", -40.46667, 175.3);
case 150: return new CityInfo("Levin", "F3", -40.63333, 175.275);
case 151: return new CityInfo("Otaki", "G2", -40.75833, 175.15);
case 152: return new CityInfo("Wairoa", "F2", -39.03333, 177.36667);
case 153: return new CityInfo("Gisborne", "F1", -38.65333, 178.00417);
case 154: return new CityInfo("Waipawa", "G2", -41.41222, 175.51528);
case 155: return new CityInfo("Masterton", "G2", -40.95972, 175.6575);
case 156: return new CityInfo("Hokitika", "G3", -42.71667, 170.96667);
case 157: return new CityInfo("Greymouth", "G3", -42.46667, 171.2);
case 158: return new CityInfo("Westport", "G3", -41.75262, 171.6037);
case 159: return new CityInfo("Bluff", "F8", -46.6, 168.33333);
case 160: return new CityInfo("Riverton", "F8", -46.35, 168.01667);
case 161: return new CityInfo("Winton", "F8", -46.15, 168.33333);
case 162: return new CityInfo("Tauranga", "E8", -37.68611, 176.16667);
case 163: return new CityInfo("Waitara", "F9", -39.00158, 174.23836);
case 164: return new CityInfo("Milton", "F7", -46.12083, 169.96944);
case 165: return new CityInfo("Kaitangata", "F7", -46.275, 169.85);
case 166: return new CityInfo("Balclutha", "F7", -46.23389, 169.75);
case 167: return new CityInfo("Paeroa", "G1", -37.36667, 175.66667);
case 168: return new CityInfo("Waihi", "G1", -37.38333, 175.83333);
case 169: return new CityInfo("Papakura", "E7", -37.06573, 174.94393);
case 170: return new CityInfo("Whakatane", "E8", -37.95855, 176.98545);
case 171: return new CityInfo("Opotiki", "E8", -38.00915, 177.28706);
case 172: return new CityInfo("Thames", "G1", -37.13832, 175.54011);
case 173: return new CityInfo("Waitangi", "10", -43.95353, -176.55973);
case 174: return new CityInfo("Gore", "F8", -46.10282, 168.94357);
case 175: return new CityInfo("Queenstown", "F7", -45.03023, 168.66271);
case 176: return new CityInfo("Arrowtown", "F7", -44.93837, 168.81007);
case 177: return new CityInfo("Cromwell", "F7", -45.03837, 169.20008);
case 178: return new CityInfo("Roxburgh", "F7", -45.54056, 169.31466);
case 179: return new CityInfo("Geraldine", "E9", -44.09061, 171.24458);
case 180: return new CityInfo("Oamaru", "F7", -45.09758, 170.97087);
case 181: return new CityInfo("Ashburton", "E9", -43.89834, 171.73011);
case 182: return new CityInfo("Kaiapoi", "E9", -43.37832, 172.64013);
case 183: return new CityInfo("Akaroa", "E9", -43.80384, 172.96817);
case 184: return new CityInfo("Kaitaia", "F6", -35.11485, 173.26366);
case 185: return new CityInfo("Whangarei", "F6", -35.73167, 174.32391);
case 186: return new CityInfo("Ruakaka", "F6", -35.90818, 174.45019);
case 187: return new CityInfo("Takanini", "E7", -37.0482, 174.90019);
case 188: return new CityInfo("Red Hill", "E7", -37.0582, 174.97019);
case 189: return new CityInfo("Rothesay Bay", "E7", -36.72602, 174.74064);
case 190: return new CityInfo("Murrays Bay", "E7", -36.72819, 174.75019);
case 191: return new CityInfo("Wiri", "E7", -36.9982, 174.86019);
case 192: return new CityInfo("Pakuranga", "E7", -36.88333, 174.91667);
case 193: return new CityInfo("Tamaki", "E7", -36.8882, 174.86019);
case 194: return new CityInfo("Titirangi", "E7", -36.93754, 174.65584);
case 195: return new CityInfo("Matamata", "G1", -37.8106, 175.76237);
case 196: return new CityInfo("Cambridge", "G1", -37.87822, 175.4402);
case 197: return new CityInfo("Rotorua", "E8", -38.13874, 176.24516);
case 198: return new CityInfo("Picton", "F4", -41.29067, 174.00801);
case 199: return new CityInfo("Blenheim", "F4", -41.51603, 173.9528);
case 200: return new CityInfo("Petone", "G2", -41.22827, 174.87019);
case 201: return new CityInfo("Upper Hutt", "G2", -41.13827, 175.0502);
case 202: return new CityInfo("Taradale", "F2", -39.53333, 176.85);
case 203: return new CityInfo("Ngaruawahia", "G1", -37.66738, 175.15554);
case 204: return new CityInfo("Rosebank", "E7", -36.87495, 174.66991);
case 205: return new CityInfo("Gloriavale Christian Church", "G3", -42.60552, 171.70301);
default: return new CityInfo("Linton Military Camp", "F3", -40.40309, 175.58302);

                                    }                                        
                                }
                            
                        }
                    }
                