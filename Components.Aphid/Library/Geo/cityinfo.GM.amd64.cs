
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
                                    public const string Country = "GM";
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
                            
                                        var cur = (Math.Abs(13.55 - lat) + Math.Abs(-15.7 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(13.38333 - lat) + Math.Abs(-15.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.41667 - lat) + Math.Abs(-15.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.69094 - lat) + Math.Abs(-14.87884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.36667 - lat) + Math.Abs(-14.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43333 - lat) + Math.Abs(-14.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.63333 - lat) + Math.Abs(-14.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46667 - lat) + Math.Abs(-14.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43333 - lat) + Math.Abs(-15.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.41778 - lat) + Math.Abs(-16.03694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.50528 - lat) + Math.Abs(-16.17444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46667 - lat) + Math.Abs(-15.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.5 - lat) + Math.Abs(-14.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.38333 - lat) + Math.Abs(-13.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.45 - lat) + Math.Abs(-14.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.61667 - lat) + Math.Abs(-14.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53333 - lat) + Math.Abs(-15.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.41033 - lat) + Math.Abs(-16.70815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.36667 - lat) + Math.Abs(-13.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.20583 - lat) + Math.Abs(-16.30556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43333 - lat) + Math.Abs(-15.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.23333 - lat) + Math.Abs(-15.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43333 - lat) + Math.Abs(-15.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.38333 - lat) + Math.Abs(-15.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43833 - lat) + Math.Abs(-16.67806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.55 - lat) + Math.Abs(-14.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53333 - lat) + Math.Abs(-15.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.28333 - lat) + Math.Abs(-14.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46667 - lat) + Math.Abs(-15.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.3 - lat) + Math.Abs(-15.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.58333 - lat) + Math.Abs(-15.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53333 - lat) + Math.Abs(-15.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.23333 - lat) + Math.Abs(-14.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.51639 - lat) + Math.Abs(-16.04917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.38333 - lat) + Math.Abs(-14.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.61667 - lat) + Math.Abs(-15.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.33333 - lat) + Math.Abs(-13.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.56667 - lat) + Math.Abs(-15.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.35 - lat) + Math.Abs(-15.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.25 - lat) + Math.Abs(-15.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.49278 - lat) + Math.Abs(-16.52333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.23333 - lat) + Math.Abs(-15.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.41667 - lat) + Math.Abs(-15.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.51667 - lat) + Math.Abs(-14.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.44325 - lat) + Math.Abs(-15.5357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43333 - lat) + Math.Abs(-14.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7 - lat) + Math.Abs(-14.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.5 - lat) + Math.Abs(-15.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.35222 - lat) + Math.Abs(-16.43389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53333 - lat) + Math.Abs(-14.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.67085 - lat) + Math.Abs(-14.88977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53333 - lat) + Math.Abs(-15.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.26667 - lat) + Math.Abs(-14.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.33333 - lat) + Math.Abs(-15.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48333 - lat) + Math.Abs(-13.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.50722 - lat) + Math.Abs(-16.06722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.4898 - lat) + Math.Abs(-16.08879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.36667 - lat) + Math.Abs(-14.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.32889 - lat) + Math.Abs(-16.015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.5 - lat) + Math.Abs(-15.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.55 - lat) + Math.Abs(-15.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.78333 - lat) + Math.Abs(-14.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.66667 - lat) + Math.Abs(-15.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43333 - lat) + Math.Abs(-15.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.4 - lat) + Math.Abs(-15.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.41667 - lat) + Math.Abs(-15.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.41667 - lat) + Math.Abs(-15.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.3 - lat) + Math.Abs(-15.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.58333 - lat) + Math.Abs(-15.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48333 - lat) + Math.Abs(-15.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.4 - lat) + Math.Abs(-15.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.24412 - lat) + Math.Abs(-15.84546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.61667 - lat) + Math.Abs(-15.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.38028 - lat) + Math.Abs(-16.13833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.35 - lat) + Math.Abs(-15.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.55 - lat) + Math.Abs(-14.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.65 - lat) + Math.Abs(-14.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.36667 - lat) + Math.Abs(-14.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.56667 - lat) + Math.Abs(-15.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53333 - lat) + Math.Abs(-14.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.52278 - lat) + Math.Abs(-16.02778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.20194 - lat) + Math.Abs(-16.73389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.3 - lat) + Math.Abs(-14.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.54039 - lat) + Math.Abs(-14.76374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43333 - lat) + Math.Abs(-14.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.8 - lat) + Math.Abs(-15.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.56667 - lat) + Math.Abs(-15.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48389 - lat) + Math.Abs(-16.53472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.35 - lat) + Math.Abs(-15.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.38333 - lat) + Math.Abs(-15.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.55 - lat) + Math.Abs(-15.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46667 - lat) + Math.Abs(-14.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.76667 - lat) + Math.Abs(-14.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.36667 - lat) + Math.Abs(-15.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.33333 - lat) + Math.Abs(-13.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.38333 - lat) + Math.Abs(-14.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.5 - lat) + Math.Abs(-14.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.25 - lat) + Math.Abs(-14.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.55 - lat) + Math.Abs(-15.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.56667 - lat) + Math.Abs(-15.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.31667 - lat) + Math.Abs(-14.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.55 - lat) + Math.Abs(-16.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.38333 - lat) + Math.Abs(-14.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.41667 - lat) + Math.Abs(-15.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.55 - lat) + Math.Abs(-15.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43333 - lat) + Math.Abs(-15.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53333 - lat) + Math.Abs(-14.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.27136 - lat) + Math.Abs(-16.64944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.5 - lat) + Math.Abs(-13.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7 - lat) + Math.Abs(-15.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.30995 - lat) + Math.Abs(-14.21373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48278 - lat) + Math.Abs(-16.54556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48333 - lat) + Math.Abs(-15.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.46667 - lat) + Math.Abs(-14.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.58333 - lat) + Math.Abs(-15.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.43333 - lat) + Math.Abs(-14.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.45274 - lat) + Math.Abs(-16.57803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.55 - lat) + Math.Abs(-14.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48333 - lat) + Math.Abs(-15.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.47806 - lat) + Math.Abs(-16.68194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.3 - lat) + Math.Abs(-14.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.31667 - lat) + Math.Abs(-15.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.33333 - lat) + Math.Abs(-14.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.40417 - lat) + Math.Abs(-16.65583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yallal", "07", 13.55, -15.7);
case 1: return new CityInfo("Wurokang", "02", 13.38333, -15.81667);
case 2: return new CityInfo("Wellingara Ba", "02", 13.41667, -15.4);
case 3: return new CityInfo("Wassu", "03", 13.69094, -14.87884);
case 4: return new CityInfo("Walliba Kunda", "04", 13.36667, -14.01667);
case 5: return new CityInfo("Tuba-Wuli", "04", 13.43333, -14.25);
case 6: return new CityInfo("Tuba Koto", "03", 13.63333, -14.9);
case 7: return new CityInfo("Tuba", "03", 13.46667, -14.68333);
case 8: return new CityInfo("Toniataba", "02", 13.43333, -15.58333);
case 9: return new CityInfo("Tankular", "02", 13.41778, -16.03694);
case 10: return new CityInfo("Tambana", "07", 13.50528, -16.17444);
case 11: return new CityInfo("Sutukung", "02", 13.46667, -15.26667);
case 12: return new CityInfo("Sutukoba", "04", 13.5, -14.01667);
case 13: return new CityInfo("Sun Kunda", "04", 13.38333, -13.85);
case 14: return new CityInfo("Sulolor", "03", 13.45, -14.66667);
case 15: return new CityInfo("Sukuta", "03", 13.61667, -14.91667);
case 16: return new CityInfo("Sukuta", "02", 13.53333, -15.2);
case 17: return new CityInfo("Sukuta", "05", 13.41033, -16.70815);
case 18: return new CityInfo("Sudowol", "04", 13.36667, -13.96667);
case 19: return new CityInfo("Somita", "05", 13.20583, -16.30556);
case 20: return new CityInfo("Soma", "02", 13.43333, -15.53333);
case 21: return new CityInfo("Sintet", "05", 13.23333, -15.81667);
case 22: return new CityInfo("Si Kunda", "02", 13.43333, -15.56667);
case 23: return new CityInfo("Sibito", "02", 13.38333, -15.73333);
case 24: return new CityInfo("Serekunda", "01", 13.43833, -16.67806);
case 25: return new CityInfo("Saruja", "03", 13.55, -14.91667);
case 26: return new CityInfo("Sara Kunda", "07", 13.53333, -15.41667);
case 27: return new CityInfo("Sanunding", "04", 13.28333, -14.11667);
case 28: return new CityInfo("Sankwia", "02", 13.46667, -15.51667);
case 29: return new CityInfo("Sankandi", "02", 13.3, -15.83333);
case 30: return new CityInfo("Sami", "03", 13.58333, -15.2);
case 31: return new CityInfo("Sambang", "03", 13.53333, -15.33333);
case 32: return new CityInfo("Sabi", "04", 13.23333, -14.2);
case 33: return new CityInfo("Saba", "07", 13.51639, -16.04917);
case 34: return new CityInfo("Perai", "04", 13.38333, -14.03333);
case 35: return new CityInfo("Pateh Sam", "03", 13.61667, -15.06667);
case 36: return new CityInfo("Nyamanari", "04", 13.33333, -13.86667);
case 37: return new CityInfo("No Kunda", "07", 13.56667, -15.83333);
case 38: return new CityInfo("Nioro", "02", 13.35, -15.75);
case 39: return new CityInfo("Nema Kunku", "05", 13.25, -15.88333);
case 40: return new CityInfo("Medina Kanuma", "07", 13.49278, -16.52333);
case 41: return new CityInfo("Mayork", "05", 13.23333, -15.96667);
case 42: return new CityInfo("Massembe", "02", 13.41667, -15.63333);
case 43: return new CityInfo("Mara Magai", "03", 13.51667, -14.91667);
case 44: return new CityInfo("Mansa Konko", "02", 13.44325, -15.5357);
case 45: return new CityInfo("Madina Tunjang", "03", 13.43333, -14.75);
case 46: return new CityInfo("Madina", "03", 13.7, -14.88333);
case 47: return new CityInfo("Madina", "02", 13.5, -15.25);
case 48: return new CityInfo("Lamin", "07", 13.35222, -16.43389);
case 49: return new CityInfo("Kunting", "03", 13.53333, -14.66667);
case 50: return new CityInfo("Kuntaur", "03", 13.67085, -14.88977);
case 51: return new CityInfo("Kumbijae", "07", 13.53333, -15.43333);
case 52: return new CityInfo("Kumbija", "04", 13.26667, -14.18333);
case 53: return new CityInfo("Kuli Kunda", "02", 13.33333, -15.91667);
case 54: return new CityInfo("Koina", "04", 13.48333, -13.86667);
case 55: return new CityInfo("Kinteh Kunda", "07", 13.50722, -16.06722);
case 56: return new CityInfo("Kerewan", "07", 13.4898, -16.08879);
case 57: return new CityInfo("Kerewan", "04", 13.36667, -14.21667);
case 58: return new CityInfo("Keneba", "02", 13.32889, -16.015);
case 59: return new CityInfo("Katchang", "07", 13.5, -15.75);
case 60: return new CityInfo("Katamina", "03", 13.55, -15.28333);
case 61: return new CityInfo("Kass Wollof", "03", 13.78333, -14.93333);
case 62: return new CityInfo("Karantaba", "03", 13.66667, -15.03333);
case 63: return new CityInfo("Karantaba", "02", 13.43333, -15.51667);
case 64: return new CityInfo("Kaiaf", "02", 13.4, -15.61667);
case 65: return new CityInfo("Jiroff", "02", 13.41667, -15.7);
case 66: return new CityInfo("Jiffin", "02", 13.41667, -15.58333);
case 67: return new CityInfo("Jifarong", "02", 13.3, -15.86667);
case 68: return new CityInfo("Jeriko", "07", 13.58333, -15.66667);
case 69: return new CityInfo("Jenoi", "02", 13.48333, -15.56667);
case 70: return new CityInfo("Jassong", "02", 13.4, -15.31667);
case 71: return new CityInfo("Jarrol", "05", 13.24412, -15.84546);
case 72: return new CityInfo("Jarreng", "03", 13.61667, -15.18333);
case 73: return new CityInfo("Janneh Kunda", "02", 13.38028, -16.13833);
case 74: return new CityInfo("Jali", "02", 13.35, -15.96667);
case 75: return new CityInfo("Jakhaly", "03", 13.55, -14.96667);
case 76: return new CityInfo("Jakaba", "03", 13.65, -14.88333);
case 77: return new CityInfo("Jababa", "04", 13.36667, -14.36667);
case 78: return new CityInfo("India", "07", 13.56667, -15.75);
case 79: return new CityInfo("Gunjur Kuta", "04", 13.53333, -14.11667);
case 80: return new CityInfo("Gunjur", "07", 13.52278, -16.02778);
case 81: return new CityInfo("Gunjur", "05", 13.20194, -16.73389);
case 82: return new CityInfo("Giroba Kunda", "04", 13.3, -14.2);
case 83: return new CityInfo("Georgetown", "03", 13.54039, -14.76374);
case 84: return new CityInfo("Galleh Manda", "03", 13.43333, -14.78333);
case 85: return new CityInfo("Fass", "03", 13.8, -15.06667);
case 86: return new CityInfo("Farafenni", "07", 13.56667, -15.6);
case 87: return new CityInfo("Essau", "07", 13.48389, -16.53472);
case 88: return new CityInfo("Dumbutu", "02", 13.35, -15.83333);
case 89: return new CityInfo("Dongoro Ba", "02", 13.38333, -15.28333);
case 90: return new CityInfo("Dobo", "07", 13.55, -15.96667);
case 91: return new CityInfo("Dobbo", "03", 13.46667, -14.63333);
case 92: return new CityInfo("Dingirie", "03", 13.76667, -14.91667);
case 93: return new CityInfo("Diganteh", "02", 13.36667, -15.43333);
case 94: return new CityInfo("Diabugu Basilla", "04", 13.33333, -13.95);
case 95: return new CityInfo("Diabugu", "04", 13.38333, -14.4);
case 96: return new CityInfo("Denton", "03", 13.5, -14.93333);
case 97: return new CityInfo("Demba Kunda", "04", 13.25, -14.26667);
case 98: return new CityInfo("Daru Rilwan", "07", 13.55, -15.98333);
case 99: return new CityInfo("Dankunku", "03", 13.56667, -15.31667);
case 100: return new CityInfo("Daba Kunda", "04", 13.31667, -14.3);
case 101: return new CityInfo("Chilla", "07", 13.55, -16.28333);
case 102: return new CityInfo("Cha Kunda", "03", 13.38333, -14.53333);
case 103: return new CityInfo("Bureng", "02", 13.41667, -15.28333);
case 104: return new CityInfo("Buniadu", "03", 13.55, -15.33333);
case 105: return new CityInfo("Buiba Mandinka", "02", 13.43333, -15.45);
case 106: return new CityInfo("Brikama Nding", "03", 13.53333, -14.93333);
case 107: return new CityInfo("Brikama", "05", 13.27136, -16.64944);
case 108: return new CityInfo("Brifu", "04", 13.5, -13.93333);
case 109: return new CityInfo("Bati Ndar", "03", 13.7, -15.2);
case 110: return new CityInfo("Basse Santa Su", "04", 13.30995, -14.21373);
case 111: return new CityInfo("Barra", "07", 13.48278, -16.54556);
case 112: return new CityInfo("Baro Kunda", "02", 13.48333, -15.26667);
case 113: return new CityInfo("Banto Nding", "04", 13.46667, -14.08333);
case 114: return new CityInfo("Bantang Killing", "07", 13.58333, -15.7);
case 115: return new CityInfo("Bansang", "03", 13.43333, -14.65);
case 116: return new CityInfo("Banjul", "01", 13.45274, -16.57803);
case 117: return new CityInfo("Bani", "03", 13.55, -14.73333);
case 118: return new CityInfo("Bambali", "07", 13.48333, -15.33333);
case 119: return new CityInfo("Bakau", "01", 13.47806, -16.68194);
case 120: return new CityInfo("Bakadagy", "04", 13.3, -14.38333);
case 121: return new CityInfo("Bajana", "02", 13.31667, -15.88333);
case 122: return new CityInfo("Badari", "04", 13.33333, -14.1);
default: return new CityInfo("Abuko", "05", 13.40417, -16.65583);

                                    }                                        
                                }
                            
                        }
                    }
                