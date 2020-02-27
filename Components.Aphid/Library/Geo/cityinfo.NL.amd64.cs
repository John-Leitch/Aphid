
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
                                    public const string Country = "NL";
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
                            
                                        var cur = (Math.Abs(52.5125 - lat) + Math.Abs(6.09444 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(51.8175 - lat) + Math.Abs(4.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88333 - lat) + Math.Abs(4.22083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.17917 - lat) + Math.Abs(5.50417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.24817 - lat) + Math.Abs(6.04746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.3125 - lat) + Math.Abs(4.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.25731 - lat) + Math.Abs(6.0363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.675 - lat) + Math.Abs(5.05417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7075 - lat) + Math.Abs(5.14028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.13833 - lat) + Math.Abs(6.20139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.47167 - lat) + Math.Abs(4.65556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.80917 - lat) + Math.Abs(5.13611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08 - lat) + Math.Abs(4.77222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2625 - lat) + Math.Abs(6.59167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.87532 - lat) + Math.Abs(4.48514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7775 - lat) + Math.Abs(6.10694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.585 - lat) + Math.Abs(4.77917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.68667 - lat) + Math.Abs(4.80833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.09417 - lat) + Math.Abs(6.68194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.79631 - lat) + Math.Abs(4.67122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.24667 - lat) + Math.Abs(6.40278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1734 - lat) + Math.Abs(5.84271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.235 - lat) + Math.Abs(3.90417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.10833 - lat) + Math.Abs(4.50417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.16333 - lat) + Math.Abs(6.86111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.75083 - lat) + Math.Abs(4.36806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33917 - lat) + Math.Abs(6.30417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50167 - lat) + Math.Abs(3.48472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.71333 - lat) + Math.Abs(3.95139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.93115 - lat) + Math.Abs(6.06235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57417 - lat) + Math.Abs(5.55694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.41141 - lat) + Math.Abs(5.39361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.12 - lat) + Math.Abs(4.49583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0575 - lat) + Math.Abs(4.49306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9425 - lat) + Math.Abs(5.30972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9125 - lat) + Math.Abs(5.40278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5925 - lat) + Math.Abs(5.54167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.94167 - lat) + Math.Abs(5.14028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.65 - lat) + Math.Abs(3.91944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21816 - lat) + Math.Abs(5.97841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.18167 - lat) + Math.Abs(4.77917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6725 - lat) + Math.Abs(4.67917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.93 - lat) + Math.Abs(6.07083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.92833 - lat) + Math.Abs(5.71389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.41667 - lat) + Math.Abs(5.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.32417 - lat) + Math.Abs(6.72361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.00667 - lat) + Math.Abs(6.34861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25667 - lat) + Math.Abs(6.62917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.09 - lat) + Math.Abs(5.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.45469 - lat) + Math.Abs(5.81878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0475 - lat) + Math.Abs(6.54583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.55667 - lat) + Math.Abs(4.51806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.33 - lat) + Math.Abs(5.54167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.42421 - lat) + Math.Abs(5.41566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6975 - lat) + Math.Abs(5.67639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.90333 - lat) + Math.Abs(6.25972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.37125 - lat) + Math.Abs(4.53306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53956 - lat) + Math.Abs(3.6581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57333 - lat) + Math.Abs(4.78472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.81 - lat) + Math.Abs(5.24444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.45313 - lat) + Math.Abs(4.81356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.47494 - lat) + Math.Abs(4.80686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.43854 - lat) + Math.Abs(4.82643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3125 - lat) + Math.Abs(3.9125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.4925 - lat) + Math.Abs(4.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.11583 - lat) + Math.Abs(6.59306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48417 - lat) + Math.Abs(4.3875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.52167 - lat) + Math.Abs(4.39028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3 - lat) + Math.Abs(6.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.94357 - lat) + Math.Abs(5.62843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.815 - lat) + Math.Abs(5.00139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08083 - lat) + Math.Abs(5.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.17 - lat) + Math.Abs(4.63611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.97969 - lat) + Math.Abs(5.4471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21667 - lat) + Math.Abs(6.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2721 - lat) + Math.Abs(6.75891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.10883 - lat) + Math.Abs(5.58749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.87545 - lat) + Math.Abs(5.99691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53167 - lat) + Math.Abs(3.81944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.71734 - lat) + Math.Abs(6.49881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.00333 - lat) + Math.Abs(5.79028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.83752 - lat) + Math.Abs(5.65938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27333 - lat) + Math.Abs(7.03056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.155 - lat) + Math.Abs(4.86389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.085 - lat) + Math.Abs(4.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48333 - lat) + Math.Abs(5.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.42897 - lat) + Math.Abs(4.30355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.10452 - lat) + Math.Abs(5.46902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.585 - lat) + Math.Abs(3.74722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.92648 - lat) + Math.Abs(6.41705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.14893 - lat) + Math.Abs(5.80387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9725 - lat) + Math.Abs(6.71944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33 - lat) + Math.Abs(6.52083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1519 - lat) + Math.Abs(5.63359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.14417 - lat) + Math.Abs(7.03472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.75417 - lat) + Math.Abs(4.90278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1125 - lat) + Math.Abs(6.77917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.52833 - lat) + Math.Abs(5.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21833 - lat) + Math.Abs(6.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19667 - lat) + Math.Abs(4.89722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.69167 - lat) + Math.Abs(4.43889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.825 - lat) + Math.Abs(6.05972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85583 - lat) + Math.Abs(6.16389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.52917 - lat) + Math.Abs(3.89722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.49742 - lat) + Math.Abs(5.39223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.08083 - lat) + Math.Abs(6.8625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.65583 - lat) + Math.Abs(5.775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.4875 - lat) + Math.Abs(6.17083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.81667 - lat) + Math.Abs(6.51806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.05814 - lat) + Math.Abs(6.2047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.845 - lat) + Math.Abs(4.7625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.90583 - lat) + Math.Abs(5.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.83333 - lat) + Math.Abs(5.89583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.97417 - lat) + Math.Abs(5.34167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.4936 - lat) + Math.Abs(4.59409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.38667 - lat) + Math.Abs(6.13472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.635 - lat) + Math.Abs(5.15694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.88814 - lat) + Math.Abs(5.6223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.80917 - lat) + Math.Abs(5.725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.61667 - lat) + Math.Abs(5.46806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85083 - lat) + Math.Abs(5.02639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.83583 - lat) + Math.Abs(4.86528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.35917 - lat) + Math.Abs(6.59306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.235 - lat) + Math.Abs(6.65139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.685 - lat) + Math.Abs(5.13472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.35911 - lat) + Math.Abs(5.21482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.46417 - lat) + Math.Abs(3.59167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.78667 - lat) + Math.Abs(4.475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0848 - lat) + Math.Abs(6.66469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.52917 - lat) + Math.Abs(3.44028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.55417 - lat) + Math.Abs(4.79583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.46252 - lat) + Math.Abs(3.58687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95583 - lat) + Math.Abs(5.97222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.14583 - lat) + Math.Abs(6.9875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.89417 - lat) + Math.Abs(4.92917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3325 - lat) + Math.Abs(5.39583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.45583 - lat) + Math.Abs(6.62361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85 - lat) + Math.Abs(6.60833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1275 - lat) + Math.Abs(5.71528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.20853 - lat) + Math.Abs(5.76812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.2325 - lat) + Math.Abs(3.82639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.15954 - lat) + Math.Abs(5.88146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.455 - lat) + Math.Abs(4.64167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.025 - lat) + Math.Abs(5.24444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.81 - lat) + Math.Abs(4.89444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.51833 - lat) + Math.Abs(3.99722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.33583 - lat) + Math.Abs(6.09167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53417 - lat) + Math.Abs(6.13611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.55 - lat) + Math.Abs(6.08889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57667 - lat) + Math.Abs(4.33056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1125 - lat) + Math.Abs(5.71389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6725 - lat) + Math.Abs(6.9875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08167 - lat) + Math.Abs(4.80278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.14574 - lat) + Math.Abs(5.74327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.3075 - lat) + Math.Abs(5.04167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.25167 - lat) + Math.Abs(5.70694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.35167 - lat) + Math.Abs(6.85694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.30381 - lat) + Math.Abs(4.58861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.81917 - lat) + Math.Abs(6.91806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.30833 - lat) + Math.Abs(5.29444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.06917 - lat) + Math.Abs(7.07917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91833 - lat) + Math.Abs(6.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5044 - lat) + Math.Abs(4.65608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.14583 - lat) + Math.Abs(4.40278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.68667 - lat) + Math.Abs(4.94444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.05677 - lat) + Math.Abs(6.28002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.15 - lat) + Math.Abs(5.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1375 - lat) + Math.Abs(6.23056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.88301 - lat) + Math.Abs(5.40218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19667 - lat) + Math.Abs(4.50278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.14 - lat) + Math.Abs(6.26806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.15145 - lat) + Math.Abs(5.84404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3925 - lat) + Math.Abs(6.55833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.565 - lat) + Math.Abs(5.02639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.42917 - lat) + Math.Abs(6.07361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53583 - lat) + Math.Abs(6.07639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6575 - lat) + Math.Abs(5.81806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.47446 - lat) + Math.Abs(5.80224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.97 - lat) + Math.Abs(5.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.25583 - lat) + Math.Abs(6.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.665 - lat) + Math.Abs(4.74861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.87417 - lat) + Math.Abs(5.37222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.045 - lat) + Math.Abs(4.65139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.72667 - lat) + Math.Abs(4.83194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.06083 - lat) + Math.Abs(4.82083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8325 - lat) + Math.Abs(5.25694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.4175 - lat) + Math.Abs(4.06806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6825 - lat) + Math.Abs(5.07083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.38667 - lat) + Math.Abs(5.44444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.825 - lat) + Math.Abs(5.04583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.65333 - lat) + Math.Abs(5.2875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57667 - lat) + Math.Abs(3.61528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27928 - lat) + Math.Abs(5.70036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.46083 - lat) + Math.Abs(6.56528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.40833 - lat) + Math.Abs(6.62222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.07417 - lat) + Math.Abs(6.57778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.92192 - lat) + Math.Abs(5.96701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88428 - lat) + Math.Abs(4.51967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.01088 - lat) + Math.Abs(5.09285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95355 - lat) + Math.Abs(5.90284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6525 - lat) + Math.Abs(5.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.105 - lat) + Math.Abs(6.30972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08917 - lat) + Math.Abs(4.62083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.18667 - lat) + Math.Abs(5.60556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.17 - lat) + Math.Abs(6.14167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1275 - lat) + Math.Abs(4.44861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.22167 - lat) + Math.Abs(4.48472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.07417 - lat) + Math.Abs(4.35972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.68083 - lat) + Math.Abs(5.95417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6425 - lat) + Math.Abs(5.65417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.495 - lat) + Math.Abs(5.07083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.40052 - lat) + Math.Abs(5.47196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.07631 - lat) + Math.Abs(4.2479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.31917 - lat) + Math.Abs(4.57778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.88327 - lat) + Math.Abs(5.92978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.46667 - lat) + Math.Abs(5.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.13333 - lat) + Math.Abs(6.07639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98 - lat) + Math.Abs(4.81944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.4425 - lat) + Math.Abs(3.57361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.12436 - lat) + Math.Abs(4.45736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.445 - lat) + Math.Abs(5.75833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.68961 - lat) + Math.Abs(5.19031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.10583 - lat) + Math.Abs(5.01528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85583 - lat) + Math.Abs(6.20833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0275 - lat) + Math.Abs(7.10833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9125 - lat) + Math.Abs(4.34167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21507 - lat) + Math.Abs(4.93372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85833 - lat) + Math.Abs(5.80833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.78833 - lat) + Math.Abs(5.96528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.35083 - lat) + Math.Abs(4.67778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.87917 - lat) + Math.Abs(4.17917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9925 - lat) + Math.Abs(5.09167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.71833 - lat) + Math.Abs(5.85694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.4825 - lat) + Math.Abs(5.95278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7125 - lat) + Math.Abs(6.02361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.525 - lat) + Math.Abs(5.975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.37 - lat) + Math.Abs(6.16806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.60833 - lat) + Math.Abs(5.7375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.64 - lat) + Math.Abs(5.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.51954 - lat) + Math.Abs(5.96032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.46 - lat) + Math.Abs(4.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.995 - lat) + Math.Abs(5.97361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.07537 - lat) + Math.Abs(5.01234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.41833 - lat) + Math.Abs(5.40278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.76917 - lat) + Math.Abs(5.30278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.61667 - lat) + Math.Abs(5.54861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.23558 - lat) + Math.Abs(5.98832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.71087 - lat) + Math.Abs(6.84869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.03167 - lat) + Math.Abs(6.39583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.02863 - lat) + Math.Abs(5.55891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.10667 - lat) + Math.Abs(6.87917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7775 - lat) + Math.Abs(5.10833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.05583 - lat) + Math.Abs(7.12778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.94333 - lat) + Math.Abs(6.45833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82333 - lat) + Math.Abs(5.37083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.88167 - lat) + Math.Abs(6.9625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.84583 - lat) + Math.Abs(6.89444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.35083 - lat) + Math.Abs(5.45972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.18 - lat) + Math.Abs(4.43194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86523 - lat) + Math.Abs(5.83205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.80658 - lat) + Math.Abs(5.73445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91167 - lat) + Math.Abs(5.79028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.92917 - lat) + Math.Abs(5.90694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.28583 - lat) + Math.Abs(5.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.47954 - lat) + Math.Abs(5.49806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.77083 - lat) + Math.Abs(6.01806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.09083 - lat) + Math.Abs(5.12222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.4025 - lat) + Math.Abs(6.61111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.99083 - lat) + Math.Abs(5.77222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6625 - lat) + Math.Abs(5.60139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.09244 - lat) + Math.Abs(6.16718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54907 - lat) + Math.Abs(4.79931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.35917 - lat) + Math.Abs(6.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.90583 - lat) + Math.Abs(5.78194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9825 - lat) + Math.Abs(5.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.41417 - lat) + Math.Abs(6.72361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.4075 - lat) + Math.Abs(6.67083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2375 - lat) + Math.Abs(4.82639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.52917 - lat) + Math.Abs(4.70972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.18464 - lat) + Math.Abs(5.93177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.79 - lat) + Math.Abs(6.28056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.60917 - lat) + Math.Abs(5.14306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.66083 - lat) + Math.Abs(5.61944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25917 - lat) + Math.Abs(5.78056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85333 - lat) + Math.Abs(5.94861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.23733 - lat) + Math.Abs(5.54612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.15899 - lat) + Math.Abs(5.56277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.83667 - lat) + Math.Abs(4.75556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0775 - lat) + Math.Abs(6.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.74083 - lat) + Math.Abs(5.05278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.24015 - lat) + Math.Abs(6.04591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.23152 - lat) + Math.Abs(6.08952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23667 - lat) + Math.Abs(6.10278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23064 - lat) + Math.Abs(6.86004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.90917 - lat) + Math.Abs(6.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.21167 - lat) + Math.Abs(5.73056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.79667 - lat) + Math.Abs(6.09444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.93032 - lat) + Math.Abs(4.3784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.31667 - lat) + Math.Abs(6.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.4075 - lat) + Math.Abs(6.78472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89083 - lat) + Math.Abs(5.26806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.44889 - lat) + Math.Abs(5.51978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.855 - lat) + Math.Abs(6.10278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.99729 - lat) + Math.Abs(5.94443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.42069 - lat) + Math.Abs(5.50818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.02064 - lat) + Math.Abs(5.64575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.40583 - lat) + Math.Abs(6.95139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.55551 - lat) + Math.Abs(5.0913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.03058 - lat) + Math.Abs(5.99193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21343 - lat) + Math.Abs(5.90961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.495 - lat) + Math.Abs(6.09306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88667 - lat) + Math.Abs(5.42917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.16167 - lat) + Math.Abs(5.84167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53167 - lat) + Math.Abs(4.22083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.44943 - lat) + Math.Abs(5.51926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.63843 - lat) + Math.Abs(5.33729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.60917 - lat) + Math.Abs(4.82083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.28333 - lat) + Math.Abs(6.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.01973 - lat) + Math.Abs(6.0478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86659 - lat) + Math.Abs(6.02471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.165 - lat) + Math.Abs(5.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.33583 - lat) + Math.Abs(3.82778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.38203 - lat) + Math.Abs(5.96523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86833 - lat) + Math.Abs(5.88889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.03333 - lat) + Math.Abs(5.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.64333 - lat) + Math.Abs(4.75417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.03 - lat) + Math.Abs(4.16806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95328 - lat) + Math.Abs(4.51537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.92 - lat) + Math.Abs(6.35417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.9025 - lat) + Math.Abs(7.04861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.87667 - lat) + Math.Abs(7.05972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2975 - lat) + Math.Abs(6.72778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27583 - lat) + Math.Abs(6.69444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.34417 - lat) + Math.Abs(6.13611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.4925 - lat) + Math.Abs(6.11806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.95417 - lat) + Math.Abs(5.84722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.23 - lat) + Math.Abs(5.77361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.20475 - lat) + Math.Abs(6.17981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.18477 - lat) + Math.Abs(6.17031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.17826 - lat) + Math.Abs(5.9273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.18333 - lat) + Math.Abs(6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88417 - lat) + Math.Abs(4.0625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.18583 - lat) + Math.Abs(5.69167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.03083 - lat) + Math.Abs(4.30139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.74521 - lat) + Math.Abs(4.55083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.19417 - lat) + Math.Abs(5.71944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.59917 - lat) + Math.Abs(4.47778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.61333 - lat) + Math.Abs(4.82083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9725 - lat) + Math.Abs(4.77361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21167 - lat) + Math.Abs(6.50694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8775 - lat) + Math.Abs(6.22083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.26234 - lat) + Math.Abs(5.75769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.35167 - lat) + Math.Abs(5.61111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.455 - lat) + Math.Abs(5.61251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.00333 - lat) + Math.Abs(4.78194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.96917 - lat) + Math.Abs(5.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85734 - lat) + Math.Abs(6.07548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.94151 - lat) + Math.Abs(6.06194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.66917 - lat) + Math.Abs(6.69861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.80417 - lat) + Math.Abs(6.06389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7875 - lat) + Math.Abs(6.12083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.37667 - lat) + Math.Abs(5.35278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.06417 - lat) + Math.Abs(6.1875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.58417 - lat) + Math.Abs(4.31944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3225 - lat) + Math.Abs(6.69583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.88525 - lat) + Math.Abs(5.35886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5875 - lat) + Math.Abs(4.0125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.09311 - lat) + Math.Abs(4.27577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.645 - lat) + Math.Abs(6.21111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.61333 - lat) + Math.Abs(4.51389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.61333 - lat) + Math.Abs(4.44444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.98947 - lat) + Math.Abs(6.9504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.03987 - lat) + Math.Abs(5.67844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.00187 - lat) + Math.Abs(5.87656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5375 - lat) + Math.Abs(4.59722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.05347 - lat) + Math.Abs(4.31339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5175 - lat) + Math.Abs(5.27083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.845 - lat) + Math.Abs(4.32917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.39 - lat) + Math.Abs(6.8375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.84917 - lat) + Math.Abs(6.15417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.76917 - lat) + Math.Abs(5.12083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.65083 - lat) + Math.Abs(4.94306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85559 - lat) + Math.Abs(6.02471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.94 - lat) + Math.Abs(5.84306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.05833 - lat) + Math.Abs(6.1125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91688 - lat) + Math.Abs(4.43539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25 - lat) + Math.Abs(5.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.51136 - lat) + Math.Abs(5.49282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3575 - lat) + Math.Abs(5.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.385 - lat) + Math.Abs(5.71111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19083 - lat) + Math.Abs(5.28472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.17333 - lat) + Math.Abs(5.29167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.30083 - lat) + Math.Abs(5.575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0275 - lat) + Math.Abs(4.90833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.03297 - lat) + Math.Abs(5.6589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.85561 - lat) + Math.Abs(4.48319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.27833 - lat) + Math.Abs(3.83611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.30833 - lat) + Math.Abs(3.38611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.89477 - lat) + Math.Abs(5.64526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.8425 - lat) + Math.Abs(4.97222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.22078 - lat) + Math.Abs(6.80547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88531 - lat) + Math.Abs(4.60494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82083 - lat) + Math.Abs(4.77639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.08616 - lat) + Math.Abs(5.88087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.77167 - lat) + Math.Abs(6.80278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.99833 - lat) + Math.Abs(5.86944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.01417 - lat) + Math.Abs(4.325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54833 - lat) + Math.Abs(4.58889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.61667 - lat) + Math.Abs(4.16528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.66 - lat) + Math.Abs(4.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5675 - lat) + Math.Abs(5.45972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.14333 - lat) + Math.Abs(6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.92293 - lat) + Math.Abs(5.74242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.64167 - lat) + Math.Abs(5.35278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.78667 - lat) + Math.Abs(4.70833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.78083 - lat) + Math.Abs(4.72778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7725 - lat) + Math.Abs(4.74583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5275 - lat) + Math.Abs(3.60278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.1175 - lat) + Math.Abs(5.89861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.93157 - lat) + Math.Abs(5.85588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6775 - lat) + Math.Abs(6.00556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27291 - lat) + Math.Abs(5.60354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.67833 - lat) + Math.Abs(5.80833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87154 - lat) + Math.Abs(5.79248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.79667 - lat) + Math.Abs(5.76528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.62667 - lat) + Math.Abs(5.88194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2762 - lat) + Math.Abs(5.65727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.83417 - lat) + Math.Abs(5.98194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.90917 - lat) + Math.Abs(6.3875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.09974 - lat) + Math.Abs(6.2447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.25 - lat) + Math.Abs(6.86806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.84417 - lat) + Math.Abs(5.82639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.69917 - lat) + Math.Abs(5.30417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8767 - lat) + Math.Abs(6.25877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.00167 - lat) + Math.Abs(4.16528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.65594 - lat) + Math.Abs(4.94076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.07667 - lat) + Math.Abs(4.29861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21823 - lat) + Math.Abs(5.48402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.4125 - lat) + Math.Abs(6.0375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54833 - lat) + Math.Abs(3.59444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2352 - lat) + Math.Abs(6.5545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.94583 - lat) + Math.Abs(7.15139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.94467 - lat) + Math.Abs(5.98317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.46152 - lat) + Math.Abs(5.6226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.92083 - lat) + Math.Abs(5.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.84583 - lat) + Math.Abs(6.75556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9475 - lat) + Math.Abs(4.84861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6625 - lat) + Math.Abs(6.88472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.35417 - lat) + Math.Abs(3.55556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.97583 - lat) + Math.Abs(4.31389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.075 - lat) + Math.Abs(6.67083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.96917 - lat) + Math.Abs(5.97917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85417 - lat) + Math.Abs(5.86944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.94333 - lat) + Math.Abs(5.88889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.90667 - lat) + Math.Abs(5.82361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.23327 - lat) + Math.Abs(6.81566 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09917 - lat) + Math.Abs(5.88611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6225 - lat) + Math.Abs(5.43194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.49917 - lat) + Math.Abs(4.56111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.48025 - lat) + Math.Abs(6.15209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91917 - lat) + Math.Abs(4.38889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95838 - lat) + Math.Abs(4.47124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.10461 - lat) + Math.Abs(4.27557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08 - lat) + Math.Abs(5.48889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54667 - lat) + Math.Abs(4.10556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.60083 - lat) + Math.Abs(4.89167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.84333 - lat) + Math.Abs(4.92639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.635 - lat) + Math.Abs(5.12083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.17333 - lat) + Math.Abs(6.97222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.94414 - lat) + Math.Abs(5.77889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.06051 - lat) + Math.Abs(5.67822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85 - lat) + Math.Abs(5.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.205 - lat) + Math.Abs(6.70556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.73583 - lat) + Math.Abs(3.84306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.26833 - lat) + Math.Abs(6.19444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.74583 - lat) + Math.Abs(5.63194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.8025 - lat) + Math.Abs(4.75833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7875 - lat) + Math.Abs(4.79861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29333 - lat) + Math.Abs(6.53472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.2275 - lat) + Math.Abs(3.79861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.225 - lat) + Math.Abs(4.52222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.16417 - lat) + Math.Abs(6.79028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.33167 - lat) + Math.Abs(6.80694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08833 - lat) + Math.Abs(6.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88417 - lat) + Math.Abs(5.17639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.72333 - lat) + Math.Abs(6.24861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7625 - lat) + Math.Abs(6.35417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89921 - lat) + Math.Abs(4.15231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53167 - lat) + Math.Abs(4.55833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.00583 - lat) + Math.Abs(5.9625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.90417 - lat) + Math.Abs(4.24861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.93659 - lat) + Math.Abs(5.89447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.14523 - lat) + Math.Abs(6.10411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9225 - lat) + Math.Abs(4.47917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.91956 - lat) + Math.Abs(5.85176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87667 - lat) + Math.Abs(5.73889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.35167 - lat) + Math.Abs(6.92222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.80083 - lat) + Math.Abs(5.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.08333 - lat) + Math.Abs(5.81806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53083 - lat) + Math.Abs(4.46528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.11775 - lat) + Math.Abs(5.78765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.42083 - lat) + Math.Abs(6.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.98417 - lat) + Math.Abs(6.64861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.19417 - lat) + Math.Abs(5.9875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.20333 - lat) + Math.Abs(4.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1375 - lat) + Math.Abs(6.42083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.87167 - lat) + Math.Abs(4.07083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.55 - lat) + Math.Abs(5.80972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29695 - lat) + Math.Abs(5.94931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91583 - lat) + Math.Abs(6.08472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.03634 - lat) + Math.Abs(4.32501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7975 - lat) + Math.Abs(5.025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.85083 - lat) + Math.Abs(4.59583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5175 - lat) + Math.Abs(4.69722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1925 - lat) + Math.Abs(4.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.22238 - lat) + Math.Abs(5.91717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19 - lat) + Math.Abs(4.44167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19583 - lat) + Math.Abs(4.67083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.59083 - lat) + Math.Abs(4.91944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.79917 - lat) + Math.Abs(5.73194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.14083 - lat) + Math.Abs(6.6625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.35417 - lat) + Math.Abs(5.3875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8725 - lat) + Math.Abs(4.60278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8575 - lat) + Math.Abs(4.42222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88333 - lat) + Math.Abs(5.15278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95917 - lat) + Math.Abs(5.56806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.56583 - lat) + Math.Abs(6.525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.005 - lat) + Math.Abs(6.02917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.28417 - lat) + Math.Abs(6.07778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3625 - lat) + Math.Abs(5.16528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.07333 - lat) + Math.Abs(5.54028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.97667 - lat) + Math.Abs(5.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7325 - lat) + Math.Abs(3.775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.79917 - lat) + Math.Abs(5.8375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.04667 - lat) + Math.Abs(4.725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.74583 - lat) + Math.Abs(5.68194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.79667 - lat) + Math.Abs(5.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.09763 - lat) + Math.Abs(5.75993 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.865 - lat) + Math.Abs(5.89167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95333 - lat) + Math.Abs(5.70833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.57167 - lat) + Math.Abs(6.70972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.69667 - lat) + Math.Abs(4.87361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6875 - lat) + Math.Abs(4.90833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.65967 - lat) + Math.Abs(5.63637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.38583 - lat) + Math.Abs(6.275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5843 - lat) + Math.Abs(5.0981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25917 - lat) + Math.Abs(5.60694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.36 - lat) + Math.Abs(4.39583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.95417 - lat) + Math.Abs(5.87361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.505 - lat) + Math.Abs(4.95972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.87833 - lat) + Math.Abs(5.59028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.59833 - lat) + Math.Abs(4.7125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57632 - lat) + Math.Abs(4.73906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85135 - lat) + Math.Abs(5.65668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.12333 - lat) + Math.Abs(6.03472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54417 - lat) + Math.Abs(4.14306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.02417 - lat) + Math.Abs(4.21944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.78667 - lat) + Math.Abs(5.08056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.03876 - lat) + Math.Abs(4.33153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.01954 - lat) + Math.Abs(4.42946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.79333 - lat) + Math.Abs(4.31389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.50141 - lat) + Math.Abs(6.1117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.76667 - lat) + Math.Abs(4.66111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88833 - lat) + Math.Abs(4.38889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.87152 - lat) + Math.Abs(4.46901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.14667 - lat) + Math.Abs(6.49722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09417 - lat) + Math.Abs(5.89583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.01719 - lat) + Math.Abs(6.56208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21397 - lat) + Math.Abs(6.87555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.145 - lat) + Math.Abs(6.56528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.92389 - lat) + Math.Abs(5.94674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.185 - lat) + Math.Abs(4.725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.04333 - lat) + Math.Abs(5.77639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.83167 - lat) + Math.Abs(4.6875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.32667 - lat) + Math.Abs(5.97917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89083 - lat) + Math.Abs(6.03889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.05579 - lat) + Math.Abs(4.50869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.90353 - lat) + Math.Abs(5.98343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.39167 - lat) + Math.Abs(4.61389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.93863 - lat) + Math.Abs(4.42766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57167 - lat) + Math.Abs(5.94722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.00869 - lat) + Math.Abs(5.86628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.04 - lat) + Math.Abs(5.49444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.76 - lat) + Math.Abs(5.78889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1275 - lat) + Math.Abs(5.06806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.28193 - lat) + Math.Abs(6.11447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57083 - lat) + Math.Abs(4.19861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.20667 - lat) + Math.Abs(5.08056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.26637 - lat) + Math.Abs(5.88704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.71583 - lat) + Math.Abs(4.80556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.58667 - lat) + Math.Abs(4.45972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21417 - lat) + Math.Abs(4.64444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.025 - lat) + Math.Abs(4.86806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.83417 - lat) + Math.Abs(4.80833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.93343 - lat) + Math.Abs(5.95579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.03917 - lat) + Math.Abs(4.84722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.93417 - lat) + Math.Abs(4.63611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.29504 - lat) + Math.Abs(4.90746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.10417 - lat) + Math.Abs(7.00972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85019 - lat) + Math.Abs(5.53544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.96281 - lat) + Math.Abs(6.08351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.95709 - lat) + Math.Abs(5.87095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.12504 - lat) + Math.Abs(5.99888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.99206 - lat) + Math.Abs(5.54913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.30048 - lat) + Math.Abs(5.71849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.81167 - lat) + Math.Abs(3.93472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86539 - lat) + Math.Abs(5.66444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82417 - lat) + Math.Abs(4.4125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.70333 - lat) + Math.Abs(5.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1 - lat) + Math.Abs(5.77222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.33083 - lat) + Math.Abs(3.85972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.63667 - lat) + Math.Abs(4.83472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.39417 - lat) + Math.Abs(4.32639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.765 - lat) + Math.Abs(5.51806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.2975 - lat) + Math.Abs(5.78472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.70613 - lat) + Math.Abs(5.30468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.20113 - lat) + Math.Abs(5.93417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.94579 - lat) + Math.Abs(5.95038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89917 - lat) + Math.Abs(4.7125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.75915 - lat) + Math.Abs(5.07534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.01194 - lat) + Math.Abs(5.69495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.70667 - lat) + Math.Abs(4.94444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.60833 - lat) + Math.Abs(5.87361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82917 - lat) + Math.Abs(5.29861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.99036 - lat) + Math.Abs(5.85868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.93167 - lat) + Math.Abs(5.63194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.845 - lat) + Math.Abs(5.3875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1341 - lat) + Math.Abs(6.05656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.12838 - lat) + Math.Abs(6.22307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.40833 - lat) + Math.Abs(6.90139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.72583 - lat) + Math.Abs(5.08611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2025 - lat) + Math.Abs(7.04583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9125 - lat) + Math.Abs(4.09861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29703 - lat) + Math.Abs(5.07431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.52917 - lat) + Math.Abs(6.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5175 - lat) + Math.Abs(4.79167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.56667 - lat) + Math.Abs(3.55139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5725 - lat) + Math.Abs(4.99583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.585 - lat) + Math.Abs(4.70556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.99164 - lat) + Math.Abs(6.29096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.46583 - lat) + Math.Abs(5.89167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.89751 - lat) + Math.Abs(6.16144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2237 - lat) + Math.Abs(6.5853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.37841 - lat) + Math.Abs(6.05347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.17466 - lat) + Math.Abs(6.05999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.79319 - lat) + Math.Abs(6.13138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.65 - lat) + Math.Abs(4.03611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.15701 - lat) + Math.Abs(6.00609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88 - lat) + Math.Abs(5.82639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.645 - lat) + Math.Abs(4.85972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.22892 - lat) + Math.Abs(6.60141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.55917 - lat) + Math.Abs(5.95556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.75417 - lat) + Math.Abs(6.72222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.085 - lat) + Math.Abs(4.875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.66917 - lat) + Math.Abs(5.11806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98583 - lat) + Math.Abs(5.84583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.44722 - lat) + Math.Abs(5.85443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.47171 - lat) + Math.Abs(5.26897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.27917 - lat) + Math.Abs(4.79583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.64418 - lat) + Math.Abs(4.89784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.14994 - lat) + Math.Abs(4.39319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.44417 - lat) + Math.Abs(4.07778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.32583 - lat) + Math.Abs(3.4875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.79568 - lat) + Math.Abs(5.7101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91917 - lat) + Math.Abs(6.05833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.85465 - lat) + Math.Abs(5.93915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.41667 - lat) + Math.Abs(5.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08636 - lat) + Math.Abs(5.0847 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.035 - lat) + Math.Abs(7.04028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.74333 - lat) + Math.Abs(5.1375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33417 - lat) + Math.Abs(6.59028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95951 - lat) + Math.Abs(4.54533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.52083 - lat) + Math.Abs(6.42083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.08917 - lat) + Math.Abs(6.90556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.42417 - lat) + Math.Abs(5.74861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.3375 - lat) + Math.Abs(6.10972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.58083 - lat) + Math.Abs(5.40694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.31333 - lat) + Math.Abs(6.92917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.82083 - lat) + Math.Abs(5.975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21917 - lat) + Math.Abs(6.34028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.30333 - lat) + Math.Abs(6.39583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.89285 - lat) + Math.Abs(6.04754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.445 - lat) + Math.Abs(5.90139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.05 - lat) + Math.Abs(5.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.93788 - lat) + Math.Abs(6.13089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57917 - lat) + Math.Abs(5.18889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.505 - lat) + Math.Abs(5.31389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.95083 - lat) + Math.Abs(5.90833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.51167 - lat) + Math.Abs(6.0375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82417 - lat) + Math.Abs(5.50278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.28225 - lat) + Math.Abs(6.095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.42255 - lat) + Math.Abs(5.37163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.25 - lat) + Math.Abs(5.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.34417 - lat) + Math.Abs(6.04861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.18 - lat) + Math.Abs(4.46944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.84917 - lat) + Math.Abs(6.85139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.64333 - lat) + Math.Abs(5.70556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0525 - lat) + Math.Abs(5.23611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91 - lat) + Math.Abs(5.56944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33333 - lat) + Math.Abs(6.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.67583 - lat) + Math.Abs(4.90694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.02833 - lat) + Math.Abs(5.78056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.9175 - lat) + Math.Abs(5.88611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.37917 - lat) + Math.Abs(5.78611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.73167 - lat) + Math.Abs(4.4375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.15083 - lat) + Math.Abs(6.30556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.47 - lat) + Math.Abs(5.55278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.06667 - lat) + Math.Abs(6.45833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.88964 - lat) + Math.Abs(6.14153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.26167 - lat) + Math.Abs(4.49306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.234 - lat) + Math.Abs(4.44474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.69833 - lat) + Math.Abs(4.81111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.26167 - lat) + Math.Abs(6.39583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.14059 - lat) + Math.Abs(4.45864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6425 - lat) + Math.Abs(4.53194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50917 - lat) + Math.Abs(4.27917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.90333 - lat) + Math.Abs(4.94167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.01667 - lat) + Math.Abs(4.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.195 - lat) + Math.Abs(6.87361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.22135 - lat) + Math.Abs(6.00523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.77237 - lat) + Math.Abs(6.88713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.76917 - lat) + Math.Abs(5.8125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.70417 - lat) + Math.Abs(5.5625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48331 - lat) + Math.Abs(4.46131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.80917 - lat) + Math.Abs(5.95694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.335 - lat) + Math.Abs(6.66389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.55083 - lat) + Math.Abs(5.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8425 - lat) + Math.Abs(5.85278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.05019 - lat) + Math.Abs(5.5759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.195 - lat) + Math.Abs(5.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.22 - lat) + Math.Abs(5.48611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08689 - lat) + Math.Abs(5.21852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85638 - lat) + Math.Abs(5.56844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.59 - lat) + Math.Abs(4.21806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19667 - lat) + Math.Abs(4.75694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.64833 - lat) + Math.Abs(6.98611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.13167 - lat) + Math.Abs(6.39722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.93583 - lat) + Math.Abs(4.86806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.46667 - lat) + Math.Abs(6.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.24417 - lat) + Math.Abs(6.975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91283 - lat) + Math.Abs(5.92798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19917 - lat) + Math.Abs(5.13889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88915 - lat) + Math.Abs(4.68653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48333 - lat) + Math.Abs(3.65694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.69 - lat) + Math.Abs(5.18194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.15083 - lat) + Math.Abs(4.77639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2075 - lat) + Math.Abs(4.61806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.65083 - lat) + Math.Abs(4.00139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.07917 - lat) + Math.Abs(6.96528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.74 - lat) + Math.Abs(4.89861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.85417 - lat) + Math.Abs(4.14306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.95113 - lat) + Math.Abs(6.06342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.02917 - lat) + Math.Abs(5.08056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.96216 - lat) + Math.Abs(5.77297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.74833 - lat) + Math.Abs(6.96806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.93333 - lat) + Math.Abs(6.15556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.9625 - lat) + Math.Abs(6.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8125 - lat) + Math.Abs(4.34306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.76667 - lat) + Math.Abs(6.60694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.81 - lat) + Math.Abs(5.17778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.15917 - lat) + Math.Abs(6.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.225 - lat) + Math.Abs(6.35278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.16083 - lat) + Math.Abs(6.32778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.40333 - lat) + Math.Abs(5.20833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.44502 - lat) + Math.Abs(5.774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.05207 - lat) + Math.Abs(5.85223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.36833 - lat) + Math.Abs(5.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.95 - lat) + Math.Abs(5.81528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.78333 - lat) + Math.Abs(5.05833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.13417 - lat) + Math.Abs(6.61389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.10083 - lat) + Math.Abs(5.57083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.49167 - lat) + Math.Abs(5.52361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.28583 - lat) + Math.Abs(5.74861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.76322 - lat) + Math.Abs(5.17305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.76518 - lat) + Math.Abs(5.16817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82879 - lat) + Math.Abs(4.85489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.77167 - lat) + Math.Abs(5.74444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50484 - lat) + Math.Abs(5.38579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.29583 - lat) + Math.Abs(5.1625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.99417 - lat) + Math.Abs(4.20972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.955 - lat) + Math.Abs(7.03889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.975 - lat) + Math.Abs(5.86389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.32583 - lat) + Math.Abs(5.12083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.33 - lat) + Math.Abs(5.06944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54 - lat) + Math.Abs(5.70833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7525 - lat) + Math.Abs(5.88194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.12583 - lat) + Math.Abs(5.94861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.04583 - lat) + Math.Abs(4.95278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.02583 - lat) + Math.Abs(4.175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.45833 - lat) + Math.Abs(5.0375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5725 - lat) + Math.Abs(4.88194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.71113 - lat) + Math.Abs(5.36809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.25269 - lat) + Math.Abs(5.92026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.23828 - lat) + Math.Abs(5.71778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.70167 - lat) + Math.Abs(4.62639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.25104 - lat) + Math.Abs(5.59513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.725 - lat) + Math.Abs(5.94861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50167 - lat) + Math.Abs(5.77917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.93555 - lat) + Math.Abs(6.00154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.79667 - lat) + Math.Abs(4.4875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.20667 - lat) + Math.Abs(4.8625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.44 - lat) + Math.Abs(5.61944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.71667 - lat) + Math.Abs(5.075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.195 - lat) + Math.Abs(7.01389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.38215 - lat) + Math.Abs(5.28528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.18184 - lat) + Math.Abs(5.44845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.80667 - lat) + Math.Abs(4.99861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.54917 - lat) + Math.Abs(4.9125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.34667 - lat) + Math.Abs(6.64167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7425 - lat) + Math.Abs(4.44167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.66417 - lat) + Math.Abs(5.41944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.53233 - lat) + Math.Abs(5.01835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7575 - lat) + Math.Abs(4.16528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5 - lat) + Math.Abs(3.61389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.46667 - lat) + Math.Abs(5.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.78 - lat) + Math.Abs(5.79167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.35987 - lat) + Math.Abs(6.06703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.455 - lat) + Math.Abs(6.025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.865 - lat) + Math.Abs(5.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.17333 - lat) + Math.Abs(5.95972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53 - lat) + Math.Abs(5.92778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.95389 - lat) + Math.Abs(5.94069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.17655 - lat) + Math.Abs(4.50885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.69583 - lat) + Math.Abs(6.19444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21797 - lat) + Math.Abs(5.66124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.66244 - lat) + Math.Abs(5.63367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.51417 - lat) + Math.Abs(3.50972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.15917 - lat) + Math.Abs(6.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.46167 - lat) + Math.Abs(6.08611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23645 - lat) + Math.Abs(6.89058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.34417 - lat) + Math.Abs(5.88472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82167 - lat) + Math.Abs(5.5625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.83833 - lat) + Math.Abs(6.39306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8968 - lat) + Math.Abs(5.99051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.72917 - lat) + Math.Abs(5.01111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.41705 - lat) + Math.Abs(5.41618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8875 - lat) + Math.Abs(5.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.96167 - lat) + Math.Abs(5.74167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.51333 - lat) + Math.Abs(6.08472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.14 - lat) + Math.Abs(6.92639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.77167 - lat) + Math.Abs(5.10556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.01333 - lat) + Math.Abs(6.70694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.79583 - lat) + Math.Abs(5.92639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.96083 - lat) + Math.Abs(5.42222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.14417 - lat) + Math.Abs(6.2625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.16333 - lat) + Math.Abs(6.73056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2105 - lat) + Math.Abs(5.72637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.32277 - lat) + Math.Abs(5.80198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.42417 - lat) + Math.Abs(6.48056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.235 - lat) + Math.Abs(6.49861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.92906 - lat) + Math.Abs(5.92738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54083 - lat) + Math.Abs(5.57222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.63333 - lat) + Math.Abs(5.58056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.82083 - lat) + Math.Abs(5.82083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.79583 - lat) + Math.Abs(5.39306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.12865 - lat) + Math.Abs(5.71924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.65 - lat) + Math.Abs(3.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.96811 - lat) + Math.Abs(5.89743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86244 - lat) + Math.Abs(5.65419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.05458 - lat) + Math.Abs(5.40231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.9809 - lat) + Math.Abs(6.2174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.46917 - lat) + Math.Abs(6.52083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.67667 - lat) + Math.Abs(4.79306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.80583 - lat) + Math.Abs(5.54444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.84833 - lat) + Math.Abs(5.68889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.92333 - lat) + Math.Abs(4.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.93417 - lat) + Math.Abs(4.27222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.65833 - lat) + Math.Abs(5.37083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95917 - lat) + Math.Abs(4.21389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.78917 - lat) + Math.Abs(4.55556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3575 - lat) + Math.Abs(6.04861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.13929 - lat) + Math.Abs(5.88627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.155 - lat) + Math.Abs(5.175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.14092 - lat) + Math.Abs(5.07337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.13917 - lat) + Math.Abs(5.04167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.05833 - lat) + Math.Abs(5.40556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.06417 - lat) + Math.Abs(5.37083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.31167 - lat) + Math.Abs(5.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.28917 - lat) + Math.Abs(5.32361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.23417 - lat) + Math.Abs(6.25833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6975 - lat) + Math.Abs(5.20417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.085 - lat) + Math.Abs(5.62222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5648 - lat) + Math.Abs(5.09748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.46167 - lat) + Math.Abs(6.16111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.26083 - lat) + Math.Abs(7.00417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33167 - lat) + Math.Abs(6.74722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.99167 - lat) + Math.Abs(5.04583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9725 - lat) + Math.Abs(4.94861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.67833 - lat) + Math.Abs(5.50694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6275 - lat) + Math.Abs(5.075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2525 - lat) + Math.Abs(6.33889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8738 - lat) + Math.Abs(4.52192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95333 - lat) + Math.Abs(6.14167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1175 - lat) + Math.Abs(6.01944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.15917 - lat) + Math.Abs(6.41111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8625 - lat) + Math.Abs(6.11806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8025 - lat) + Math.Abs(5.46389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.80583 - lat) + Math.Abs(5.43889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25667 - lat) + Math.Abs(4.57222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.26 - lat) + Math.Abs(4.55694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.01835 - lat) + Math.Abs(6.09346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0625 - lat) + Math.Abs(4.91528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.155 - lat) + Math.Abs(5.93889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8327 - lat) + Math.Abs(5.7934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.98509 - lat) + Math.Abs(5.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.56917 - lat) + Math.Abs(4.69444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86718 - lat) + Math.Abs(5.70719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.01167 - lat) + Math.Abs(5.8375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.3525 - lat) + Math.Abs(4.75694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.44219 - lat) + Math.Abs(5.43405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9325 - lat) + Math.Abs(4.83194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.41333 - lat) + Math.Abs(5.82083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.52036 - lat) + Math.Abs(5.59479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.41917 - lat) + Math.Abs(5.67917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1625 - lat) + Math.Abs(5.98889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.94833 - lat) + Math.Abs(5.51806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.56917 - lat) + Math.Abs(5.37222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98667 - lat) + Math.Abs(6.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.9022 - lat) + Math.Abs(6.02523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.24917 - lat) + Math.Abs(5.84722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.83917 - lat) + Math.Abs(5.99167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1325 - lat) + Math.Abs(5.43194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.51 - lat) + Math.Abs(5.97917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.25288 - lat) + Math.Abs(5.7346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54833 - lat) + Math.Abs(4.27639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.86167 - lat) + Math.Abs(5.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5725 - lat) + Math.Abs(5.31528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.84618 - lat) + Math.Abs(5.70912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.78583 - lat) + Math.Abs(5.99306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.50833 - lat) + Math.Abs(5.475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.22417 - lat) + Math.Abs(4.66944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.15833 - lat) + Math.Abs(4.52917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.15833 - lat) + Math.Abs(4.49306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.21032 - lat) + Math.Abs(5.99862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.20139 - lat) + Math.Abs(5.80859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1279 - lat) + Math.Abs(6.23217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.60983 - lat) + Math.Abs(5.54312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.01167 - lat) + Math.Abs(5.42778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89333 - lat) + Math.Abs(5.09167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.36 - lat) + Math.Abs(6.37917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.35083 - lat) + Math.Abs(5.55417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1625 - lat) + Math.Abs(6.37639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91229 - lat) + Math.Abs(6.04591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98667 - lat) + Math.Abs(6.01944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25667 - lat) + Math.Abs(5.22778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19417 - lat) + Math.Abs(6.36528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.95836 - lat) + Math.Abs(5.72173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.98257 - lat) + Math.Abs(6.0024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.64833 - lat) + Math.Abs(4.66528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19333 - lat) + Math.Abs(4.71111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.18768 - lat) + Math.Abs(5.38034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.70417 - lat) + Math.Abs(5.73056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.492 - lat) + Math.Abs(4.75849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.43083 - lat) + Math.Abs(4.91528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.46667 - lat) + Math.Abs(3.55833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.40583 - lat) + Math.Abs(5.14722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.27583 - lat) + Math.Abs(5.70556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08417 - lat) + Math.Abs(6.075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.01333 - lat) + Math.Abs(4.25556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.52833 - lat) + Math.Abs(4.98056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87769 - lat) + Math.Abs(5.93107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7875 - lat) + Math.Abs(5.84028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23417 - lat) + Math.Abs(4.75139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.73167 - lat) + Math.Abs(5.39444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.56917 - lat) + Math.Abs(4.40972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.94234 - lat) + Math.Abs(5.96519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.64665 - lat) + Math.Abs(4.59203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.41583 - lat) + Math.Abs(6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91667 - lat) + Math.Abs(4.60278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.84167 - lat) + Math.Abs(5.08194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.72339 - lat) + Math.Abs(6.51146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.91551 - lat) + Math.Abs(5.44834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48167 - lat) + Math.Abs(3.55417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54954 - lat) + Math.Abs(5.07079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.17333 - lat) + Math.Abs(4.73194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23917 - lat) + Math.Abs(5.10694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.23235 - lat) + Math.Abs(6.56804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.18167 - lat) + Math.Abs(6.24306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.15083 - lat) + Math.Abs(5.66944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21261 - lat) + Math.Abs(6.09209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3575 - lat) + Math.Abs(5.99306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.05167 - lat) + Math.Abs(5.95833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.28667 - lat) + Math.Abs(6.325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.26224 - lat) + Math.Abs(6.07544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27695 - lat) + Math.Abs(6.15293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.79417 - lat) + Math.Abs(4.88889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1825 - lat) + Math.Abs(6.74444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.22833 - lat) + Math.Abs(3.97361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.69917 - lat) + Math.Abs(6.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.665 - lat) + Math.Abs(4.53472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.38667 - lat) + Math.Abs(6.39167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.49833 - lat) + Math.Abs(3.91528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87583 - lat) + Math.Abs(5.88056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.83167 - lat) + Math.Abs(6.85972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48083 - lat) + Math.Abs(4.65417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.26935 - lat) + Math.Abs(6.81613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.72417 - lat) + Math.Abs(6.99028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50964 - lat) + Math.Abs(3.61132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1675 - lat) + Math.Abs(6.0625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.77 - lat) + Math.Abs(4.44583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.17181 - lat) + Math.Abs(6.00433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88583 - lat) + Math.Abs(4.63194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9375 - lat) + Math.Abs(6.23194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.06765 - lat) + Math.Abs(4.22188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.57718 - lat) + Math.Abs(5.76383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.935 - lat) + Math.Abs(5.56944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.27833 - lat) + Math.Abs(6.02361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.29167 - lat) + Math.Abs(6.05417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23333 - lat) + Math.Abs(5.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.68667 - lat) + Math.Abs(3.89861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86583 - lat) + Math.Abs(6.0625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.66833 - lat) + Math.Abs(6.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21755 - lat) + Math.Abs(5.13575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.11018 - lat) + Math.Abs(4.37957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.77167 - lat) + Math.Abs(5.33472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.45833 - lat) + Math.Abs(5.10278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.9721 - lat) + Math.Abs(5.77666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.07844 - lat) + Math.Abs(5.26584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.58667 - lat) + Math.Abs(5.58472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.02917 - lat) + Math.Abs(6.29444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.24218 - lat) + Math.Abs(5.70079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.86 - lat) + Math.Abs(5.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.20333 - lat) + Math.Abs(4.39861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19417 - lat) + Math.Abs(4.42222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.94595 - lat) + Math.Abs(6.01261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.90074 - lat) + Math.Abs(4.48254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.36583 - lat) + Math.Abs(6.63472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.50797 - lat) + Math.Abs(5.93056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57167 - lat) + Math.Abs(3.70417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.555 - lat) + Math.Abs(5.91111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53973 - lat) + Math.Abs(4.47111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.90414 - lat) + Math.Abs(6.00463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.4175 - lat) + Math.Abs(4.90561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86505 - lat) + Math.Abs(6.03643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.9657 - lat) + Math.Abs(5.80301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.4733 - lat) + Math.Abs(5.4672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1035;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.98083 - lat) + Math.Abs(5.94167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1036;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.89833 - lat) + Math.Abs(5.70278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1037;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.07753 - lat) + Math.Abs(5.79254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1038;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95917 - lat) + Math.Abs(5.48472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1039;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.46333 - lat) + Math.Abs(4.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1040;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.90583 - lat) + Math.Abs(5.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1041;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.32167 - lat) + Math.Abs(3.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1042;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.49 - lat) + Math.Abs(5.89722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1043;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.02 - lat) + Math.Abs(5.04306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1044;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.04121 - lat) + Math.Abs(5.63204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1045;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.01009 - lat) + Math.Abs(5.62312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1046;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.65917 - lat) + Math.Abs(6.29167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1047;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.89567 - lat) + Math.Abs(5.95648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1048;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.81083 - lat) + Math.Abs(5.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1049;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.00417 - lat) + Math.Abs(6.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1050;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.28 - lat) + Math.Abs(4.05278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1051;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.36333 - lat) + Math.Abs(5.73194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1052;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.37917 - lat) + Math.Abs(6.47361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1053;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.38833 - lat) + Math.Abs(5.17778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1054;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.52529 - lat) + Math.Abs(4.44277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1055;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.88917 - lat) + Math.Abs(5.85556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1056;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.29917 - lat) + Math.Abs(5.24167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1057;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1917 - lat) + Math.Abs(5.81119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1058;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.4325 - lat) + Math.Abs(4.37639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1059;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.15202 - lat) + Math.Abs(6.14524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1060;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8725 - lat) + Math.Abs(5.79306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1061;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.02833 - lat) + Math.Abs(5.16806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1062;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25 - lat) + Math.Abs(5.07778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1063;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.85583 - lat) + Math.Abs(5.60972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1064;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.99857 - lat) + Math.Abs(6.1726 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1065;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.89245 - lat) + Math.Abs(6.05046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1066;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6425 - lat) + Math.Abs(5.05972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1067;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.71583 - lat) + Math.Abs(4.93889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1068;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.86333 - lat) + Math.Abs(4.3625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1069;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.16917 - lat) + Math.Abs(4.58194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1070;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1825 - lat) + Math.Abs(5.37361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1071;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.92083 - lat) + Math.Abs(6.53889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1072;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6875 - lat) + Math.Abs(4.74444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1073;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.16167 - lat) + Math.Abs(6.76111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1074;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7225 - lat) + Math.Abs(6.47639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1075;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.42417 - lat) + Math.Abs(4.325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1076;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3875 - lat) + Math.Abs(5.12917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1077;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3975 - lat) + Math.Abs(5.26806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1078;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.44819 - lat) + Math.Abs(4.91867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1079;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.875 - lat) + Math.Abs(4.97639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1080;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.36917 - lat) + Math.Abs(3.6625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1081;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.3025 - lat) + Math.Abs(4.68889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1082;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.00665 - lat) + Math.Abs(4.22441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1083;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.98026 - lat) + Math.Abs(5.64963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1084;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.93583 - lat) + Math.Abs(5.91528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1085;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86415 - lat) + Math.Abs(6.07424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1086;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.35833 - lat) + Math.Abs(6.87361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1087;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.36815 - lat) + Math.Abs(5.90073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1088;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.0475 - lat) + Math.Abs(5.82222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1089;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.4394 - lat) + Math.Abs(5.63805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1090;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.175 - lat) + Math.Abs(5.17778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1091;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.15616 - lat) + Math.Abs(4.46025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1092;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.43 - lat) + Math.Abs(5.84167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1093;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.60794 - lat) + Math.Abs(4.7915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1094;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.44333 - lat) + Math.Abs(4.65833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1095;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.67206 - lat) + Math.Abs(5.63444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1096;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57917 - lat) + Math.Abs(4.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1097;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.92387 - lat) + Math.Abs(5.92528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1098;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1175 - lat) + Math.Abs(5.87917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1099;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9775 - lat) + Math.Abs(4.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.9075 - lat) + Math.Abs(4.9625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.105 - lat) + Math.Abs(5.89861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.94212 - lat) + Math.Abs(5.40081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.27115 - lat) + Math.Abs(5.13729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.22333 - lat) + Math.Abs(5.17639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48583 - lat) + Math.Abs(5.1375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.29083 - lat) + Math.Abs(4.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.895 - lat) + Math.Abs(6.49722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.25 - lat) + Math.Abs(5.89861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.975 - lat) + Math.Abs(5.8125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.58811 - lat) + Math.Abs(4.8193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.73417 - lat) + Math.Abs(5.13889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.38417 - lat) + Math.Abs(5.76389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.765 - lat) + Math.Abs(5.84444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.82791 - lat) + Math.Abs(5.70774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25 - lat) + Math.Abs(6.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2339 - lat) + Math.Abs(5.95275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95667 - lat) + Math.Abs(5.75556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82667 - lat) + Math.Abs(5.12917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.885 - lat) + Math.Abs(6.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.18083 - lat) + Math.Abs(5.9625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.72917 - lat) + Math.Abs(5.15556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.77167 - lat) + Math.Abs(5.64167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.83417 - lat) + Math.Abs(5.68056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.15333 - lat) + Math.Abs(6.06389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.65833 - lat) + Math.Abs(4.88472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.83333 - lat) + Math.Abs(5.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19917 - lat) + Math.Abs(6.63611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.26583 - lat) + Math.Abs(6.79306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.05083 - lat) + Math.Abs(6.30972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.84417 - lat) + Math.Abs(4.63889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.88084 - lat) + Math.Abs(5.45626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.66083 - lat) + Math.Abs(5.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.67583 - lat) + Math.Abs(4.43194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.63167 - lat) + Math.Abs(5.23056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.19794 - lat) + Math.Abs(6.57978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48167 - lat) + Math.Abs(5.66111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.23833 - lat) + Math.Abs(6.83889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82667 - lat) + Math.Abs(5.17639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.83333 - lat) + Math.Abs(4.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.38833 - lat) + Math.Abs(6.45139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.39 - lat) + Math.Abs(5.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.31917 - lat) + Math.Abs(6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.92068 - lat) + Math.Abs(5.97373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.43661 - lat) + Math.Abs(6.23282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82602 - lat) + Math.Abs(4.47659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.60252 - lat) + Math.Abs(4.68815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.81917 - lat) + Math.Abs(5.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.15667 - lat) + Math.Abs(7.00972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89333 - lat) + Math.Abs(4.42083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.65583 - lat) + Math.Abs(4.40833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.675 - lat) + Math.Abs(5.98056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.75921 - lat) + Math.Abs(5.49849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.24083 - lat) + Math.Abs(6.04306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.06833 - lat) + Math.Abs(5.87222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.43917 - lat) + Math.Abs(6.03889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3828 - lat) + Math.Abs(5.57145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.05167 - lat) + Math.Abs(4.96944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.65083 - lat) + Math.Abs(5.475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.4861 - lat) + Math.Abs(5.49681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.73569 - lat) + Math.Abs(5.4221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.73362 - lat) + Math.Abs(5.52672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.84136 - lat) + Math.Abs(5.82846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.88365 - lat) + Math.Abs(5.98154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.51917 - lat) + Math.Abs(4.35972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.83583 - lat) + Math.Abs(4.56389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.67144 - lat) + Math.Abs(4.84862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.81769 - lat) + Math.Abs(5.393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.95929 - lat) + Math.Abs(5.91854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.38723 - lat) + Math.Abs(6.04016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.83836 - lat) + Math.Abs(5.72989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98167 - lat) + Math.Abs(4.18056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.34992 - lat) + Math.Abs(4.62301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5075 - lat) + Math.Abs(4.63194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.51108 - lat) + Math.Abs(4.67165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98417 - lat) + Math.Abs(5.75833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.17917 - lat) + Math.Abs(5.89444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.9686 - lat) + Math.Abs(5.61075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.20963 - lat) + Math.Abs(5.8225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.74802 - lat) + Math.Abs(5.26134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.76941 - lat) + Math.Abs(6.24015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.70833 - lat) + Math.Abs(5.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.06468 - lat) + Math.Abs(6.33453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.47417 - lat) + Math.Abs(6.02222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.475 - lat) + Math.Abs(6.06389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.80635 - lat) + Math.Abs(5.83057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.59267 - lat) + Math.Abs(6.09527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.95351 - lat) + Math.Abs(5.82941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.13 - lat) + Math.Abs(5.75278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.17477 - lat) + Math.Abs(5.42244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21333 - lat) + Math.Abs(6.69861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.18333 - lat) + Math.Abs(6.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2075 - lat) + Math.Abs(6.29722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.73416 - lat) + Math.Abs(4.77682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.17209 - lat) + Math.Abs(6.60931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.80167 - lat) + Math.Abs(5.58472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.34167 - lat) + Math.Abs(5.62083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.57583 - lat) + Math.Abs(6.61944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21333 - lat) + Math.Abs(5.94137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.68917 - lat) + Math.Abs(5.86111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.36833 - lat) + Math.Abs(5.25694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.58 - lat) + Math.Abs(5.70972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.52834 - lat) + Math.Abs(4.26785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.30657 - lat) + Math.Abs(5.78379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98917 - lat) + Math.Abs(6.42917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.52417 - lat) + Math.Abs(4.92778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.3825 - lat) + Math.Abs(4.75417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98083 - lat) + Math.Abs(5.12222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.23583 - lat) + Math.Abs(5.95694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.00074 - lat) + Math.Abs(4.77639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.71167 - lat) + Math.Abs(5.19861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.38084 - lat) + Math.Abs(4.63683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.35917 - lat) + Math.Abs(6.38056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6025 - lat) + Math.Abs(5.22222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87981 - lat) + Math.Abs(6.07411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.69682 - lat) + Math.Abs(3.74299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8875 - lat) + Math.Abs(5.92917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.15667 - lat) + Math.Abs(6.73889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.81583 - lat) + Math.Abs(5.21111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.015 - lat) + Math.Abs(5.81806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.81583 - lat) + Math.Abs(5.88889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.09456 - lat) + Math.Abs(5.83745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5825 - lat) + Math.Abs(4.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88264 - lat) + Math.Abs(4.54937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2125 - lat) + Math.Abs(6.27361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.92333 - lat) + Math.Abs(4.82361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.81083 - lat) + Math.Abs(5.73056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21917 - lat) + Math.Abs(6.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.935 - lat) + Math.Abs(6.67222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.93167 - lat) + Math.Abs(6.02639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57551 - lat) + Math.Abs(5.08628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.77667 - lat) + Math.Abs(5.93611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.9095 - lat) + Math.Abs(6.04896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5386 - lat) + Math.Abs(5.09028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.12333 - lat) + Math.Abs(5.15278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.37833 - lat) + Math.Abs(3.50694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53417 - lat) + Math.Abs(3.56111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2625 - lat) + Math.Abs(6.30833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50548 - lat) + Math.Abs(3.59598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.03833 - lat) + Math.Abs(5.775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.75902 - lat) + Math.Abs(5.73882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.36083 - lat) + Math.Abs(5.94306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.56083 - lat) + Math.Abs(4.83056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.5825 - lat) + Math.Abs(5.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85175 - lat) + Math.Abs(6.02793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98083 - lat) + Math.Abs(4.97917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.11943 - lat) + Math.Abs(4.66899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.17734 - lat) + Math.Abs(5.8037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.79417 - lat) + Math.Abs(4.27639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98417 - lat) + Math.Abs(4.67778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.01667 - lat) + Math.Abs(4.70833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.20167 - lat) + Math.Abs(6.20139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.00659 - lat) + Math.Abs(6.06402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.83652 - lat) + Math.Abs(4.97243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23333 - lat) + Math.Abs(6.58611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.52083 - lat) + Math.Abs(5.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50417 - lat) + Math.Abs(3.88889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8175 - lat) + Math.Abs(3.98056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.13917 - lat) + Math.Abs(6.62917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.56593 - lat) + Math.Abs(4.7931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54417 - lat) + Math.Abs(4.94028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.74 - lat) + Math.Abs(6.07917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0275 - lat) + Math.Abs(6.8375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.005 - lat) + Math.Abs(6.76389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.83257 - lat) + Math.Abs(4.83583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.85083 - lat) + Math.Abs(4.89028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.79 - lat) + Math.Abs(5.03056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.99333 - lat) + Math.Abs(6.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.24293 - lat) + Math.Abs(5.89502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.49 - lat) + Math.Abs(5.5625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.23794 - lat) + Math.Abs(6.20367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.40917 - lat) + Math.Abs(5.53889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.69833 - lat) + Math.Abs(5.97361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8775 - lat) + Math.Abs(5.97083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.87333 - lat) + Math.Abs(6.37639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.73583 - lat) + Math.Abs(5.0875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.61833 - lat) + Math.Abs(5.35694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.55583 - lat) + Math.Abs(5.69028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.97417 - lat) + Math.Abs(5.82917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.42167 - lat) + Math.Abs(5.55972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.87968 - lat) + Math.Abs(5.28015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88083 - lat) + Math.Abs(5.28889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.00379 - lat) + Math.Abs(5.93862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.74 - lat) + Math.Abs(5.46389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.13917 - lat) + Math.Abs(6.52639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.72667 - lat) + Math.Abs(6.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.74741 - lat) + Math.Abs(6.68879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.70167 - lat) + Math.Abs(4.85694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.35935 - lat) + Math.Abs(5.46021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.28583 - lat) + Math.Abs(5.55556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.99454 - lat) + Math.Abs(6.89821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.98833 - lat) + Math.Abs(6.85278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.97167 - lat) + Math.Abs(6.79444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.16667 - lat) + Math.Abs(5.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23083 - lat) + Math.Abs(5.71389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.80083 - lat) + Math.Abs(5.20417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.515 - lat) + Math.Abs(4.77639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.60167 - lat) + Math.Abs(4.73889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.19417 - lat) + Math.Abs(6.78056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.10938 - lat) + Math.Abs(6.20642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.525 - lat) + Math.Abs(6.06806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.18546 - lat) + Math.Abs(5.54123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.16741 - lat) + Math.Abs(6.72183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.54583 - lat) + Math.Abs(5.91338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6375 - lat) + Math.Abs(4.46944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33784 - lat) + Math.Abs(5.82533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91169 - lat) + Math.Abs(4.50645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.32167 - lat) + Math.Abs(6.92639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.31 - lat) + Math.Abs(6.44167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.8825 - lat) + Math.Abs(6.86389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.965 - lat) + Math.Abs(5.15556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91667 - lat) + Math.Abs(6.33611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08534 - lat) + Math.Abs(4.37263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.61083 - lat) + Math.Abs(5.29028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.46167 - lat) + Math.Abs(5.1375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6 - lat) + Math.Abs(5.60694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.29833 - lat) + Math.Abs(5.62222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.225 - lat) + Math.Abs(6.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.77583 - lat) + Math.Abs(5.91111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.3475 - lat) + Math.Abs(5.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.57846 - lat) + Math.Abs(5.13885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21833 - lat) + Math.Abs(6.89583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.63667 - lat) + Math.Abs(5.82778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.70333 - lat) + Math.Abs(5.29167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.20833 - lat) + Math.Abs(6.64722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.31583 - lat) + Math.Abs(5.97361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.15583 - lat) + Math.Abs(6.13889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.80083 - lat) + Math.Abs(6.93889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.80071 - lat) + Math.Abs(6.89315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.78755 - lat) + Math.Abs(6.93881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.80667 - lat) + Math.Abs(6.98889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.81167 - lat) + Math.Abs(7.04722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.77917 - lat) + Math.Abs(6.90694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.71083 - lat) + Math.Abs(5.74861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91917 - lat) + Math.Abs(5.84167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.29167 - lat) + Math.Abs(5.78889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.94917 - lat) + Math.Abs(5.77083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.70083 - lat) + Math.Abs(5.14167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.39333 - lat) + Math.Abs(6.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.58083 - lat) + Math.Abs(5.76944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.27 - lat) + Math.Abs(6.53889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0325 - lat) + Math.Abs(6.0875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95833 - lat) + Math.Abs(5.88194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.4475 - lat) + Math.Abs(5.84306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.39656 - lat) + Math.Abs(5.48624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.00167 - lat) + Math.Abs(5.82778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.44083 - lat) + Math.Abs(5.47778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.63917 - lat) + Math.Abs(5.61111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.78 - lat) + Math.Abs(5.7177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1 - lat) + Math.Abs(6.64861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.59583 - lat) + Math.Abs(4.65556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6204 - lat) + Math.Abs(4.62705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.31417 - lat) + Math.Abs(5.97222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.16386 - lat) + Math.Abs(6.98344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0175 - lat) + Math.Abs(6.73472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7325 - lat) + Math.Abs(5.05278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21158 - lat) + Math.Abs(6.06668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3575 - lat) + Math.Abs(5.31806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.56833 - lat) + Math.Abs(5.47361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.60417 - lat) + Math.Abs(5.49861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.105 - lat) + Math.Abs(6.05833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3625 - lat) + Math.Abs(6.45833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.45167 - lat) + Math.Abs(5.54722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.07667 - lat) + Math.Abs(6.39583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25417 - lat) + Math.Abs(5.26111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.255 - lat) + Math.Abs(5.33056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.13583 - lat) + Math.Abs(6.5625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.16667 - lat) + Math.Abs(6.225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.2475 - lat) + Math.Abs(3.44306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33026 - lat) + Math.Abs(6.10033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.06333 - lat) + Math.Abs(5.57778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.03333 - lat) + Math.Abs(5.65833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.51215 - lat) + Math.Abs(5.04805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.96917 - lat) + Math.Abs(5.45694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8075 - lat) + Math.Abs(5.76528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.4732 - lat) + Math.Abs(5.49449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.87141 - lat) + Math.Abs(5.82147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91 - lat) + Math.Abs(5.49583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.83417 - lat) + Math.Abs(6.36944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.36833 - lat) + Math.Abs(5.29722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.32941 - lat) + Math.Abs(4.93964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.94667 - lat) + Math.Abs(6.01389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.10485 - lat) + Math.Abs(4.32494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.09078 - lat) + Math.Abs(4.26038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88833 - lat) + Math.Abs(5.60556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.897 - lat) + Math.Abs(5.41043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.97833 - lat) + Math.Abs(6.90556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.525 - lat) + Math.Abs(5.71806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2 - lat) + Math.Abs(5.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.20213 - lat) + Math.Abs(6.11183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.41833 - lat) + Math.Abs(3.80278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2959 - lat) + Math.Abs(6.04609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.30583 - lat) + Math.Abs(5.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.05176 - lat) + Math.Abs(4.48504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95917 - lat) + Math.Abs(5.81389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.20879 - lat) + Math.Abs(5.94442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.04417 - lat) + Math.Abs(4.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.05333 - lat) + Math.Abs(5.28056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0075 - lat) + Math.Abs(6.175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.69 - lat) + Math.Abs(3.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.13462 - lat) + Math.Abs(6.14153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.11254 - lat) + Math.Abs(6.0989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.59 - lat) + Math.Abs(4.85694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.81 - lat) + Math.Abs(4.67361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.97917 - lat) + Math.Abs(5.79722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23 - lat) + Math.Abs(5.45417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.41833 - lat) + Math.Abs(5.81806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89 - lat) + Math.Abs(6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.03343 - lat) + Math.Abs(5.34571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.56667 - lat) + Math.Abs(5.69444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.01734 - lat) + Math.Abs(6.23927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53843 - lat) + Math.Abs(5.62914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.62667 - lat) + Math.Abs(4.93889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.34624 - lat) + Math.Abs(5.43394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.56333 - lat) + Math.Abs(3.49583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21901 - lat) + Math.Abs(6.94583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.32224 - lat) + Math.Abs(5.99697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.20083 - lat) + Math.Abs(6.24861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.965 - lat) + Math.Abs(6.28889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.06667 - lat) + Math.Abs(5.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0125 - lat) + Math.Abs(6.13889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.9675 - lat) + Math.Abs(5.90694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.74917 - lat) + Math.Abs(4.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.75 - lat) + Math.Abs(4.775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.635 - lat) + Math.Abs(4.36944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.85417 - lat) + Math.Abs(6.31806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.07667 - lat) + Math.Abs(5.84583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.47583 - lat) + Math.Abs(5.175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0525 - lat) + Math.Abs(6.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.15 - lat) + Math.Abs(6.36944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2 - lat) + Math.Abs(6.55556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.33964 - lat) + Math.Abs(4.96256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.09936 - lat) + Math.Abs(6.0341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.67333 - lat) + Math.Abs(6.29028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1945 - lat) + Math.Abs(6.57117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.72667 - lat) + Math.Abs(4.99444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.255 - lat) + Math.Abs(6.16389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.68667 - lat) + Math.Abs(5.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08526 - lat) + Math.Abs(5.17456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.02 - lat) + Math.Abs(6.06111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.71667 - lat) + Math.Abs(5.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.55667 - lat) + Math.Abs(4.84583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.56038 - lat) + Math.Abs(5.04932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82362 - lat) + Math.Abs(4.82165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7075 - lat) + Math.Abs(4.85139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.93353 - lat) + Math.Abs(5.03079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.45417 - lat) + Math.Abs(4.90694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6575 - lat) + Math.Abs(4.8125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.95988 - lat) + Math.Abs(4.75933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.46583 - lat) + Math.Abs(6.49583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.665 - lat) + Math.Abs(5.37222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.05417 - lat) + Math.Abs(4.79722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.62417 - lat) + Math.Abs(5.0125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21954 - lat) + Math.Abs(5.99141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.51901 - lat) + Math.Abs(4.68171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.67167 - lat) + Math.Abs(6.73967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.975 - lat) + Math.Abs(4.24861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.33 - lat) + Math.Abs(6.91806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.00667 - lat) + Math.Abs(4.35556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.90488 - lat) + Math.Abs(4.45315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.26 - lat) + Math.Abs(6.71111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23917 - lat) + Math.Abs(4.79306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.69978 - lat) + Math.Abs(5.26032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0975 - lat) + Math.Abs(4.76111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.04658 - lat) + Math.Abs(5.57247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.12333 - lat) + Math.Abs(4.35839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.19182 - lat) + Math.Abs(5.72431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88417 - lat) + Math.Abs(5.24306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.24901 - lat) + Math.Abs(6.14367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.77417 - lat) + Math.Abs(5.96806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.82454 - lat) + Math.Abs(5.72309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.99381 - lat) + Math.Abs(5.10263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.9496 - lat) + Math.Abs(5.91366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.62583 - lat) + Math.Abs(4.94722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.33083 - lat) + Math.Abs(4.61111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89 - lat) + Math.Abs(5.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.24167 - lat) + Math.Abs(4.5375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.09743 - lat) + Math.Abs(6.06791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.43844 - lat) + Math.Abs(5.50887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.03113 - lat) + Math.Abs(5.67716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.15667 - lat) + Math.Abs(4.87083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.8428 - lat) + Math.Abs(6.04111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54626 - lat) + Math.Abs(5.04465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.11 - lat) + Math.Abs(5.18056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.49299 - lat) + Math.Abs(3.62624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.775 - lat) + Math.Abs(6.20417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29046 - lat) + Math.Abs(5.99785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.51167 - lat) + Math.Abs(6.25694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.68 - lat) + Math.Abs(6.65972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.69917 - lat) + Math.Abs(6.75556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8275 - lat) + Math.Abs(5.00972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.43417 - lat) + Math.Abs(6.5375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.955 - lat) + Math.Abs(5.22778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.73083 - lat) + Math.Abs(5.87917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.33583 - lat) + Math.Abs(4.63472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.66083 - lat) + Math.Abs(5.23194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.30417 - lat) + Math.Abs(5.58889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.99667 - lat) + Math.Abs(5.30833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.50902 - lat) + Math.Abs(4.65843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.59917 - lat) + Math.Abs(3.84861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.66103 - lat) + Math.Abs(6.74046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.41742 - lat) + Math.Abs(5.57463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1941 - lat) + Math.Abs(6.58944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50583 - lat) + Math.Abs(4.86111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.96601 - lat) + Math.Abs(6.97322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.93917 - lat) + Math.Abs(5.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.54833 - lat) + Math.Abs(4.66944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.39667 - lat) + Math.Abs(5.2375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48917 - lat) + Math.Abs(6.03472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88932 - lat) + Math.Abs(4.47758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91667 - lat) + Math.Abs(4.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.92917 - lat) + Math.Abs(4.57778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.84 - lat) + Math.Abs(4.69583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.96417 - lat) + Math.Abs(4.89861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89167 - lat) + Math.Abs(5.29444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.27333 - lat) + Math.Abs(5.16111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2734 - lat) + Math.Abs(6.22942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.68917 - lat) + Math.Abs(3.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.74833 - lat) + Math.Abs(4.70278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.44717 - lat) + Math.Abs(5.79906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.24304 - lat) + Math.Abs(5.37884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.06667 - lat) + Math.Abs(5.19861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.89667 - lat) + Math.Abs(5.73194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.25166 - lat) + Math.Abs(6.14483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.93083 - lat) + Math.Abs(6.83611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.28511 - lat) + Math.Abs(5.75898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.2475 - lat) + Math.Abs(5.56528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.23667 - lat) + Math.Abs(5.5875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.27167 - lat) + Math.Abs(5.575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.04333 - lat) + Math.Abs(5.80972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.94667 - lat) + Math.Abs(5.97083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.56185 - lat) + Math.Abs(5.90343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.09 - lat) + Math.Abs(6.15556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.52101 - lat) + Math.Abs(5.9927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.66167 - lat) + Math.Abs(4.09444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.78667 - lat) + Math.Abs(5.23611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.72667 - lat) + Math.Abs(3.9125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.27466 - lat) + Math.Abs(5.99648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.0029 - lat) + Math.Abs(5.89511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.67417 - lat) + Math.Abs(4.80556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.43417 - lat) + Math.Abs(4.99583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.495 - lat) + Math.Abs(6.15694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48583 - lat) + Math.Abs(6.16389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54801 - lat) + Math.Abs(5.09175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87119 - lat) + Math.Abs(5.82069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.68833 - lat) + Math.Abs(5.25278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.45 - lat) + Math.Abs(5.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.25428 - lat) + Math.Abs(5.78576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21302 - lat) + Math.Abs(5.95167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.53583 - lat) + Math.Abs(6.12222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.51583 - lat) + Math.Abs(3.60556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.90167 - lat) + Math.Abs(4.1625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.17417 - lat) + Math.Abs(5.00139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5175 - lat) + Math.Abs(5.51111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.39583 - lat) + Math.Abs(3.55556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.89 - lat) + Math.Abs(4.80417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.76019 - lat) + Math.Abs(5.94189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.94167 - lat) + Math.Abs(6.62083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.58656 - lat) + Math.Abs(4.77596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.45839 - lat) + Math.Abs(5.62427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.81324 - lat) + Math.Abs(5.86539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8175 - lat) + Math.Abs(5.09028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.14694 - lat) + Math.Abs(5.90446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53583 - lat) + Math.Abs(5.96806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.92333 - lat) + Math.Abs(6.26528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.90921 - lat) + Math.Abs(6.19972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.59083 - lat) + Math.Abs(5.32917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.64667 - lat) + Math.Abs(5.94722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82333 - lat) + Math.Abs(4.88194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.21583 - lat) + Math.Abs(6.04722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.56083 - lat) + Math.Abs(4.54028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.075 - lat) + Math.Abs(4.65556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.33083 - lat) + Math.Abs(6.12778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.55 - lat) + Math.Abs(5.42083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.11667 - lat) + Math.Abs(5.24167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.42333 - lat) + Math.Abs(3.73472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.30917 - lat) + Math.Abs(6.65417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.30136 - lat) + Math.Abs(6.7482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.03167 - lat) + Math.Abs(5.80972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.2975 - lat) + Math.Abs(5.44028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8775 - lat) + Math.Abs(5.6875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.92333 - lat) + Math.Abs(6.79306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2763 - lat) + Math.Abs(6.14926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.11583 - lat) + Math.Abs(6.52222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.08284 - lat) + Math.Abs(6.04578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3325 - lat) + Math.Abs(6.08056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.06555 - lat) + Math.Abs(5.53176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.895 - lat) + Math.Abs(4.57917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.55917 - lat) + Math.Abs(5.625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1617 - lat) + Math.Abs(6.14479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.37833 - lat) + Math.Abs(6.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.60333 - lat) + Math.Abs(5.675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0825 - lat) + Math.Abs(4.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.81583 - lat) + Math.Abs(5.99028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.81833 - lat) + Math.Abs(6.00556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.72667 - lat) + Math.Abs(5.96111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89723 - lat) + Math.Abs(4.49943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.02878 - lat) + Math.Abs(4.6944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.4025 - lat) + Math.Abs(4.62222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.53083 - lat) + Math.Abs(6.10833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.10917 - lat) + Math.Abs(7.07639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.35193 - lat) + Math.Abs(5.86138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8725 - lat) + Math.Abs(4.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.01083 - lat) + Math.Abs(4.53194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85538 - lat) + Math.Abs(6.06789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.02134 - lat) + Math.Abs(5.53359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2725 - lat) + Math.Abs(5.24167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.36833 - lat) + Math.Abs(5.22083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.42501 - lat) + Math.Abs(5.45784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6687 - lat) + Math.Abs(5.60921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.29421 - lat) + Math.Abs(5.87897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.16418 - lat) + Math.Abs(4.53644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.9761 - lat) + Math.Abs(5.92704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21551 - lat) + Math.Abs(5.79574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.28585 - lat) + Math.Abs(5.26534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.49917 - lat) + Math.Abs(3.52639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.62417 - lat) + Math.Abs(5.17778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50667 - lat) + Math.Abs(5.15833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8411 - lat) + Math.Abs(5.67573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.60613 - lat) + Math.Abs(4.78515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3825 - lat) + Math.Abs(6.85972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.455 - lat) + Math.Abs(5.69306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.48333 - lat) + Math.Abs(4.65694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.95 - lat) + Math.Abs(5.29167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.86083 - lat) + Math.Abs(5.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5075 - lat) + Math.Abs(5.39028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.68333 - lat) + Math.Abs(5.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.2437 - lat) + Math.Abs(5.65101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.6775 - lat) + Math.Abs(5.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.52395 - lat) + Math.Abs(6.13655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.64083 - lat) + Math.Abs(5.00139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.945 - lat) + Math.Abs(4.70694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.33667 - lat) + Math.Abs(5.94861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.19243 - lat) + Math.Abs(5.99009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9225 - lat) + Math.Abs(4.78472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.99 - lat) + Math.Abs(4.49861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.76991 - lat) + Math.Abs(5.56827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.85083 - lat) + Math.Abs(5.66944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.31917 - lat) + Math.Abs(5.35833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.495 - lat) + Math.Abs(4.29167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82167 - lat) + Math.Abs(5.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.22009 - lat) + Math.Abs(5.9334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.66917 - lat) + Math.Abs(4.70417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.00417 - lat) + Math.Abs(5.77083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86167 - lat) + Math.Abs(5.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0775 - lat) + Math.Abs(4.54444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.22417 - lat) + Math.Abs(6.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.99833 - lat) + Math.Abs(5.67639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.32083 - lat) + Math.Abs(4.59861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89167 - lat) + Math.Abs(5.89861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.67167 - lat) + Math.Abs(6.06389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.06667 - lat) + Math.Abs(6.56389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.11583 - lat) + Math.Abs(7.16528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.84698 - lat) + Math.Abs(5.65991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.59911 - lat) + Math.Abs(4.76994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.28667 - lat) + Math.Abs(4.59583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.86333 - lat) + Math.Abs(6.51389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.05914 - lat) + Math.Abs(6.07711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.58833 - lat) + Math.Abs(4.97778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.26833 - lat) + Math.Abs(6.03889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.8875 - lat) + Math.Abs(5.19167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.90597 - lat) + Math.Abs(5.9644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.72583 - lat) + Math.Abs(5.82778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.16 - lat) + Math.Abs(5.96389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.90667 - lat) + Math.Abs(6.1875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5289 - lat) + Math.Abs(5.63382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.94083 - lat) + Math.Abs(5.79722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.18917 - lat) + Math.Abs(5.91944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.30083 - lat) + Math.Abs(6.60278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.56583 - lat) + Math.Abs(4.83056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.82417 - lat) + Math.Abs(5.62917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.4894 - lat) + Math.Abs(5.39927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.785 - lat) + Math.Abs(4.86389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.14 - lat) + Math.Abs(5.58472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.77 - lat) + Math.Abs(6.95833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.76152 - lat) + Math.Abs(6.88145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.85667 - lat) + Math.Abs(4.53472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.12417 - lat) + Math.Abs(6.44306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.84218 - lat) + Math.Abs(5.79597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.79 - lat) + Math.Abs(5.80833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.73582 - lat) + Math.Abs(5.1801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.67218 - lat) + Math.Abs(6.73299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.89756 - lat) + Math.Abs(5.57964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.08072 - lat) + Math.Abs(6.25671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.86975 - lat) + Math.Abs(5.45926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.00511 - lat) + Math.Abs(5.8771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50333 - lat) + Math.Abs(5.74028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.3625 - lat) + Math.Abs(6.51389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9075 - lat) + Math.Abs(6.11111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21167 - lat) + Math.Abs(5.2875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.33083 - lat) + Math.Abs(6.09444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.4475 - lat) + Math.Abs(4.92917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.69246 - lat) + Math.Abs(5.09628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.24583 - lat) + Math.Abs(4.98889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.58579 - lat) + Math.Abs(6.65299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0775 - lat) + Math.Abs(6.22778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.26667 - lat) + Math.Abs(3.90833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6175 - lat) + Math.Abs(4.95139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.08 - lat) + Math.Abs(5.31528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.21785 - lat) + Math.Abs(6.1617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.40417 - lat) + Math.Abs(5.74861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.99667 - lat) + Math.Abs(6.5625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.19333 - lat) + Math.Abs(6.04861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.12952 - lat) + Math.Abs(5.47643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98 - lat) + Math.Abs(5.91111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50167 - lat) + Math.Abs(3.675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.86417 - lat) + Math.Abs(4.99444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.88833 - lat) + Math.Abs(5.84028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.47667 - lat) + Math.Abs(6.18056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.32167 - lat) + Math.Abs(6.85833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.95526 - lat) + Math.Abs(6.35053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.1875 - lat) + Math.Abs(5.54028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21 - lat) + Math.Abs(5.96944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.0575 - lat) + Math.Abs(6.71944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23111 - lat) + Math.Abs(5.98497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25891 - lat) + Math.Abs(5.1016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.37475 - lat) + Math.Abs(6.12698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.99583 - lat) + Math.Abs(6.13472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.91583 - lat) + Math.Abs(5.95833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.7809 - lat) + Math.Abs(6.92645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.90833 - lat) + Math.Abs(5.72917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.37403 - lat) + Math.Abs(4.88969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.93917 - lat) + Math.Abs(5.92361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.30083 - lat) + Math.Abs(4.86389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.76667 - lat) + Math.Abs(5.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.74917 - lat) + Math.Abs(5.22083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9275 - lat) + Math.Abs(4.80833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.155 - lat) + Math.Abs(5.3875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.0025 - lat) + Math.Abs(5.45972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.43667 - lat) + Math.Abs(5.97917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86215 - lat) + Math.Abs(5.73226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.80417 - lat) + Math.Abs(5.75972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.22083 - lat) + Math.Abs(5.67917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.05083 - lat) + Math.Abs(6.99444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.675 - lat) + Math.Abs(6.48611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.12917 - lat) + Math.Abs(4.65546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48167 - lat) + Math.Abs(4.95833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.77083 - lat) + Math.Abs(4.95972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.37025 - lat) + Math.Abs(5.21413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.15833 - lat) + Math.Abs(6.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.35667 - lat) + Math.Abs(6.6625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.63167 - lat) + Math.Abs(4.74861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.78667 - lat) + Math.Abs(5.34306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.86583 - lat) + Math.Abs(4.66111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.05024 - lat) + Math.Abs(5.83087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.41407 - lat) + Math.Abs(5.5596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.88 - lat) + Math.Abs(5.63472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.89417 - lat) + Math.Abs(6.08472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.25667 - lat) + Math.Abs(6.45972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.275 - lat) + Math.Abs(6.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.13621 - lat) + Math.Abs(4.45249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.45417 - lat) + Math.Abs(4.58472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9725 - lat) + Math.Abs(5.5875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.14925 - lat) + Math.Abs(5.48346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91667 - lat) + Math.Abs(6.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5275 - lat) + Math.Abs(5.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.2725 - lat) + Math.Abs(4.96944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.235 - lat) + Math.Abs(4.59167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.73167 - lat) + Math.Abs(5.01806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.27333 - lat) + Math.Abs(3.44722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.925 - lat) + Math.Abs(6.58056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.39667 - lat) + Math.Abs(5.47778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.7825 - lat) + Math.Abs(5.12778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.27417 - lat) + Math.Abs(4.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.25917 - lat) + Math.Abs(4.75972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.79 - lat) + Math.Abs(6.71806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.75482 - lat) + Math.Abs(5.13156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.54667 - lat) + Math.Abs(3.50972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.69 - lat) + Math.Abs(4.70417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.20973 - lat) + Math.Abs(5.84318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.6725 - lat) + Math.Abs(6.5375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.3075 - lat) + Math.Abs(4.97222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.30083 - lat) + Math.Abs(6.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.11417 - lat) + Math.Abs(5.28194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.14667 - lat) + Math.Abs(6.7125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87554 - lat) + Math.Abs(6.05981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21397 - lat) + Math.Abs(5.97643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.18767 - lat) + Math.Abs(5.99879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19056 - lat) + Math.Abs(6.01338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19766 - lat) + Math.Abs(6.01115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.20482 - lat) + Math.Abs(5.99304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19993 - lat) + Math.Abs(5.98592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19793 - lat) + Math.Abs(5.9957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.18914 - lat) + Math.Abs(5.97665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19951 - lat) + Math.Abs(5.97691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.20503 - lat) + Math.Abs(5.96789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19777 - lat) + Math.Abs(5.96721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.18977 - lat) + Math.Abs(5.96609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21323 - lat) + Math.Abs(6.01124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.22291 - lat) + Math.Abs(5.98145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.22512 - lat) + Math.Abs(5.99922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21045 - lat) + Math.Abs(5.97407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21304 - lat) + Math.Abs(5.95957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21839 - lat) + Math.Abs(5.95068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21902 - lat) + Math.Abs(5.94163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.22228 - lat) + Math.Abs(5.94738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.23915 - lat) + Math.Abs(5.9636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.20061 - lat) + Math.Abs(5.95365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19624 - lat) + Math.Abs(5.95656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.19082 - lat) + Math.Abs(5.95794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.18546 - lat) + Math.Abs(5.94704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50607 - lat) + Math.Abs(5.40519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.51505 - lat) + Math.Abs(5.38991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.00396 - lat) + Math.Abs(6.12183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.44267 - lat) + Math.Abs(5.41102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.43916 - lat) + Math.Abs(5.41544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.20455 - lat) + Math.Abs(5.80192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.96829 - lat) + Math.Abs(5.97116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.06178 - lat) + Math.Abs(5.13474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.50976 - lat) + Math.Abs(5.63839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.21817 - lat) + Math.Abs(5.82602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.44384 - lat) + Math.Abs(5.52329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.44144 - lat) + Math.Abs(5.49385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.43791 - lat) + Math.Abs(5.50106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.99313 - lat) + Math.Abs(4.47865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.24252 - lat) + Math.Abs(6.51957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.04098 - lat) + Math.Abs(4.36981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.1886 - lat) + Math.Abs(5.82825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.04922 - lat) + Math.Abs(4.65374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.05497 - lat) + Math.Abs(4.65314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.05154 - lat) + Math.Abs(4.64541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.14863 - lat) + Math.Abs(5.4012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.21639 - lat) + Math.Abs(5.46535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.48627 - lat) + Math.Abs(3.95804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9963 - lat) + Math.Abs(5.88026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.99428 - lat) + Math.Abs(5.8908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.9935 - lat) + Math.Abs(5.88387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.98943 - lat) + Math.Abs(5.89597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.90553 - lat) + Math.Abs(4.48706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.92336 - lat) + Math.Abs(4.55315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.13926 - lat) + Math.Abs(5.01758 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(52.256 - lat) + Math.Abs(5.98974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.5638 - lat) + Math.Abs(5.08658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.61285 - lat) + Math.Abs(4.78444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.60959 - lat) + Math.Abs(4.80452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.84209 - lat) + Math.Abs(5.87876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.23931 - lat) + Math.Abs(6.57493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.51654 - lat) + Math.Abs(5.49608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(53.01766 - lat) + Math.Abs(6.58527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1839;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zwolle", "15", 52.5125, 6.09444);
case 1: return new CityInfo("Zwijndrecht", "11", 51.8175, 4.63333);
case 2: return new CityInfo("Zwartewaal", "11", 51.88333, 4.22083);
case 3: return new CityInfo("Zwartebroek", "03", 52.17917, 5.50417);
case 4: return new CityInfo("Zwagerbosch", "02", 53.24817, 6.04746);
case 5: return new CityInfo("Zwaanshoek", "07", 52.3125, 4.61667);
case 6: return new CityInfo("De Westereen", "02", 53.25731, 6.0363);
case 7: return new CityInfo("Zwaagdijk-West", "07", 52.675, 5.05417);
case 8: return new CityInfo("Zwaagdijk-Oost", "07", 52.7075, 5.14028);
case 9: return new CityInfo("Zutphen", "03", 52.13833, 6.20139);
case 10: return new CityInfo("Zundert", "06", 51.47167, 4.65556);
case 11: return new CityInfo("Zuilichem", "03", 51.80917, 5.13611);
case 12: return new CityInfo("Zuidzijde", "11", 52.08, 4.77222);
case 13: return new CityInfo("Zuidwolde", "04", 53.2625, 6.59167);
case 14: return new CityInfo("Zuidwijk", "11", 51.87532, 4.48514);
case 15: return new CityInfo("Zuidveen", "15", 52.7775, 6.10694);
case 16: return new CityInfo("Zuidschermer", "07", 52.585, 4.77917);
case 17: return new CityInfo("Zuid-Scharwoude", "07", 52.68667, 4.80833);
case 18: return new CityInfo("Zuidlaren", "01", 53.09417, 6.68194);
case 19: return new CityInfo("Zuidhoven", "11", 51.79631, 4.67122);
case 20: return new CityInfo("Zuidhorn", "04", 53.24667, 6.40278);
case 21: return new CityInfo("Zuiderburen", "02", 53.1734, 5.84271);
case 22: return new CityInfo("Zuiddorpe", "10", 51.235, 3.90417);
case 23: return new CityInfo("Zuidbuurt", "11", 52.10833, 4.50417);
case 24: return new CityInfo("Zuidbroek", "04", 53.16333, 6.86111);
case 25: return new CityInfo("Zuid-Beijerland", "11", 51.75083, 4.36806);
case 26: return new CityInfo("Zoutkamp", "04", 53.33917, 6.30417);
case 27: return new CityInfo("Zoutelande", "10", 51.50167, 3.48472);
case 28: return new CityInfo("Zonnemaire", "10", 51.71333, 3.95139);
case 29: return new CityInfo("Zonnemaat", "03", 51.93115, 6.06235);
case 30: return new CityInfo("Zondveld", "06", 51.57417, 5.55694);
case 31: return new CityInfo("Zonderwijk", "06", 51.41141, 5.39361);
case 32: return new CityInfo("Zoeterwoude-Dorp", "11", 52.12, 4.49583);
case 33: return new CityInfo("Zoetermeer", "11", 52.0575, 4.49306);
case 34: return new CityInfo("Zoelmond", "03", 51.9425, 5.30972);
case 35: return new CityInfo("Zoelen", "03", 51.9125, 5.40278);
case 36: return new CityInfo("Zijtaart", "06", 51.5925, 5.54167);
case 37: return new CityInfo("Zijderveld", "09", 51.94167, 5.14028);
case 38: return new CityInfo("Zierikzee", "10", 51.65, 3.91944);
case 39: return new CityInfo("Zevenhuizen", "03", 52.21816, 5.97841);
case 40: return new CityInfo("Zevenhoven", "11", 52.18167, 4.77917);
case 41: return new CityInfo("Zevenbergschen Hoek", "06", 51.6725, 4.67917);
case 42: return new CityInfo("Zevenaar", "03", 51.93, 6.07083);
case 43: return new CityInfo("Zetten", "03", 51.92833, 5.71389);
case 44: return new CityInfo("Zesgehuchten", "06", 51.41667, 5.55);
case 45: return new CityInfo("Zenderen", "15", 52.32417, 6.72361);
case 46: return new CityInfo("Zelhem", "03", 52.00667, 6.34861);
case 47: return new CityInfo("Zeldam", "15", 52.25667, 6.62917);
case 48: return new CityInfo("Zeist", "09", 52.09, 5.23333);
case 49: return new CityInfo("Zeilberg", "06", 51.45469, 5.81878);
case 50: return new CityInfo("Zeyen", "01", 53.0475, 6.54583);
case 51: return new CityInfo("Zegge", "06", 51.55667, 4.51806);
case 52: return new CityInfo("Zeewolde", "16", 52.33, 5.54167);
case 53: return new CityInfo("Zeelst", "06", 51.42421, 5.41566);
case 54: return new CityInfo("Zeeland", "06", 51.6975, 5.67639);
case 55: return new CityInfo("Zeddam", "03", 51.90333, 6.25972);
case 56: return new CityInfo("Zandvoort", "07", 52.37125, 4.53306);
case 57: return new CityInfo("Zanddijk", "10", 51.53956, 3.6581);
case 58: return new CityInfo("Zandberg", "06", 51.57333, 4.78472);
case 59: return new CityInfo("Zaltbommel", "03", 51.81, 5.24444);
case 60: return new CityInfo("Zaanstad", "07", 52.45313, 4.81356);
case 61: return new CityInfo("Zaandijk", "07", 52.47494, 4.80686);
case 62: return new CityInfo("Zaandam", "07", 52.43854, 4.82643);
case 63: return new CityInfo("Zaamslag", "10", 51.3125, 3.9125);
case 64: return new CityInfo("Yerseke", "10", 51.4925, 4.05);
case 65: return new CityInfo("Yde", "01", 53.11583, 6.59306);
case 66: return new CityInfo("Wouwse Plantage", "06", 51.48417, 4.3875);
case 67: return new CityInfo("Wouw", "06", 51.52167, 4.39028);
case 68: return new CityInfo("Wâlterswâld", "02", 53.3, 6.03333);
case 69: return new CityInfo("Woudsend", "02", 52.94357, 5.62843);
case 70: return new CityInfo("Woudrichem", "06", 51.815, 5.00139);
case 71: return new CityInfo("Woudenberg", "09", 52.08083, 5.41667);
case 72: return new CityInfo("Woubrugge", "11", 52.17, 4.63611);
case 73: return new CityInfo("Workum", "02", 52.97969, 5.4471);
case 74: return new CityInfo("Wooldrik", "15", 52.21667, 6.91667);
case 75: return new CityInfo("Woolde", "15", 52.2721, 6.75891);
case 76: return new CityInfo("Wommels", "02", 53.10883, 5.58749);
case 77: return new CityInfo("Wolvega", "02", 52.87545, 5.99691);
case 78: return new CityInfo("Wolphaartsdijk", "10", 51.53167, 3.81944);
case 79: return new CityInfo("Wolfsbos", "01", 52.71734, 6.49881);
case 80: return new CityInfo("Wolfheze", "03", 52.00333, 5.79028);
case 81: return new CityInfo("Wolder", "05", 50.83752, 5.65938);
case 82: return new CityInfo("Woldendorp", "04", 53.27333, 7.03056);
case 83: return new CityInfo("Woerdense Verlaat", "11", 52.155, 4.86389);
case 84: return new CityInfo("Woerden", "09", 52.085, 4.88333);
case 85: return new CityInfo("Woenselse Heide", "06", 51.48333, 5.46667);
case 86: return new CityInfo("Woensdrecht", "06", 51.42897, 4.30355);
case 87: return new CityInfo("Witmarsum", "02", 53.10452, 5.46902);
case 88: return new CityInfo("Wissenkerke", "10", 51.585, 3.74722);
case 89: return new CityInfo("Wisch", "03", 51.92648, 6.41705);
case 90: return new CityInfo("Wirdum", "02", 53.14893, 5.80387);
case 91: return new CityInfo("Winterswijk", "03", 51.9725, 6.71944);
case 92: return new CityInfo("Winsum", "04", 53.33, 6.52083);
case 93: return new CityInfo("Winsum", "02", 53.1519, 5.63359);
case 94: return new CityInfo("Winschoten", "04", 53.14417, 7.03472);
case 95: return new CityInfo("Winkel", "07", 52.75417, 4.90278);
case 96: return new CityInfo("Kiel-Windeweer", "04", 53.1125, 6.77917);
case 97: return new CityInfo("Wilsum", "15", 52.52833, 5.96667);
case 98: return new CityInfo("Wilp", "03", 52.21833, 6.15);
case 99: return new CityInfo("Wilnis", "09", 52.19667, 4.89722);
case 100: return new CityInfo("Willemstad", "06", 51.69167, 4.43889);
case 101: return new CityInfo("Willemsoord", "15", 52.825, 6.05972);
case 102: return new CityInfo("Wilhelminaoord", "01", 52.85583, 6.16389);
case 103: return new CityInfo("Wilhelminadorp", "10", 51.52917, 3.89722);
case 104: return new CityInfo("Wilhelminadorp", "06", 51.49742, 5.39223);
case 105: return new CityInfo("Wildervank", "04", 53.08083, 6.8625);
case 106: return new CityInfo("Wilbertoord", "06", 51.65583, 5.775);
case 107: return new CityInfo("Wijthmen", "15", 52.4875, 6.17083);
case 108: return new CityInfo("Wijster", "01", 52.81667, 6.51806);
case 109: return new CityInfo("Wijnjewoude", "02", 53.05814, 6.2047);
case 110: return new CityInfo("Wijngaarden", "11", 51.845, 4.7625);
case 111: return new CityInfo("Wijnandsrade", "05", 50.90583, 5.88333);
case 112: return new CityInfo("Wijlre", "05", 50.83333, 5.89583);
case 113: return new CityInfo("Wijk bij Duurstede", "09", 51.97417, 5.34167);
case 114: return new CityInfo("Wijk aan Zee", "07", 52.4936, 4.59409);
case 115: return new CityInfo("Wijhe", "15", 52.38667, 6.13472);
case 116: return new CityInfo("Wijdenes", "07", 52.635, 5.15694);
case 117: return new CityInfo("Wijckel", "02", 52.88814, 5.6223);
case 118: return new CityInfo("Wijchen", "03", 51.80917, 5.725);
case 119: return new CityInfo("Wijbosch", "06", 51.61667, 5.46806);
case 120: return new CityInfo("Wieringerwerf", "07", 52.85083, 5.02639);
case 121: return new CityInfo("Wieringerwaard", "07", 52.83583, 4.86528);
case 122: return new CityInfo("Wierden", "15", 52.35917, 6.59306);
case 123: return new CityInfo("Wiene", "15", 52.235, 6.65139);
case 124: return new CityInfo("Westwoud", "07", 52.685, 5.13472);
case 125: return new CityInfo("West-Terschelling", "02", 53.35911, 5.21482);
case 126: return new CityInfo("West-Souburg", "10", 51.46417, 3.59167);
case 127: return new CityInfo("Westmaas", "11", 51.78667, 4.475);
case 128: return new CityInfo("Westlaren", "01", 53.0848, 6.66469);
case 129: return new CityInfo("Westkapelle", "10", 51.52917, 3.44028);
case 130: return new CityInfo("West-Graftdijk", "07", 52.55417, 4.79583);
case 131: return new CityInfo("Westerzicht", "10", 51.46252, 3.58687);
case 132: return new CityInfo("Westervoort", "03", 51.95583, 5.97222);
case 133: return new CityInfo("Westerlee", "04", 53.14583, 6.9875);
case 134: return new CityInfo("Westerland", "07", 52.89417, 4.92917);
case 135: return new CityInfo("Westerhoven", "06", 51.3325, 5.39583);
case 136: return new CityInfo("Westerhaar-Vriezenveensewijk", "15", 52.45583, 6.62361);
case 137: return new CityInfo("Westerbork", "01", 52.85, 6.60833);
case 138: return new CityInfo("Westeneng", "03", 52.1275, 5.71528);
case 139: return new CityInfo("Westeinde", "02", 53.20853, 5.76812);
case 140: return new CityInfo("Westdorpe", "10", 51.2325, 3.82639);
case 141: return new CityInfo("Wessem", "05", 51.15954, 5.88146);
case 142: return new CityInfo("Wernhout", "06", 51.455, 4.64167);
case 143: return new CityInfo("Werkhoven", "09", 52.025, 5.24444);
case 144: return new CityInfo("Werkendam", "06", 51.81, 4.89444);
case 145: return new CityInfo("Wemeldinge", "10", 51.51833, 3.99722);
case 146: return new CityInfo("Welsum", "15", 52.33583, 6.09167);
case 147: return new CityInfo("Wellerlooi", "05", 51.53417, 6.13611);
case 148: return new CityInfo("Well", "05", 51.55, 6.08889);
case 149: return new CityInfo("Welberg", "06", 51.57667, 4.33056);
case 150: return new CityInfo("Wekerom", "03", 52.1125, 5.71389);
case 151: return new CityInfo("Weiteveen", "01", 52.6725, 6.9875);
case 152: return new CityInfo("Weijpoort", "11", 52.08167, 4.80278);
case 153: return new CityInfo("Weidum", "02", 53.14574, 5.74327);
case 154: return new CityInfo("Weesp", "07", 52.3075, 5.04167);
case 155: return new CityInfo("Weert", "05", 51.25167, 5.70694);
case 156: return new CityInfo("Weerselo", "15", 52.35167, 6.85694);
case 157: return new CityInfo("Weerestein", "11", 52.30381, 4.58861);
case 158: return new CityInfo("Weerdinge", "01", 52.81917, 6.91806);
case 159: return new CityInfo("Weebosch", "06", 51.30833, 5.29444);
case 160: return new CityInfo("Wedde", "04", 53.06917, 7.07917);
case 161: return new CityInfo("Waubach", "05", 50.91833, 6.05);
case 162: return new CityInfo("Waterakkers", "07", 52.5044, 4.65608);
case 163: return new CityInfo("Wassenaar", "11", 52.14583, 4.40278);
case 164: return new CityInfo("Waspik", "06", 51.68667, 4.94444);
case 165: return new CityInfo("Waskemeer", "02", 53.05677, 6.28002);
case 166: return new CityInfo("Warten", "02", 53.15, 5.9);
case 167: return new CityInfo("Warnsveld", "03", 52.1375, 6.23056);
case 168: return new CityInfo("Warns", "02", 52.88301, 5.40218);
case 169: return new CityInfo("Warmond", "11", 52.19667, 4.50278);
case 170: return new CityInfo("Warken", "03", 52.14, 6.26806);
case 171: return new CityInfo("Warga", "02", 53.15145, 5.84404);
case 172: return new CityInfo("Warffum", "04", 53.3925, 6.55833);
case 173: return new CityInfo("Warder", "07", 52.565, 5.02639);
case 174: return new CityInfo("Wapenveld", "03", 52.42917, 6.07361);
case 175: return new CityInfo("Wanssum", "05", 51.53583, 6.07639);
case 176: return new CityInfo("Wanroij", "06", 51.6575, 5.81806);
case 177: return new CityInfo("Walsberg", "06", 51.47446, 5.80224);
case 178: return new CityInfo("Wageningen", "03", 51.97, 5.66667);
case 179: return new CityInfo("Wagenborgen", "04", 53.25583, 6.93333);
case 180: return new CityInfo("Wagenberg", "06", 51.665, 4.74861);
case 181: return new CityInfo("Wadenoijen", "03", 51.87417, 5.37222);
case 182: return new CityInfo("Waddinxveen", "11", 52.045, 4.65139);
case 183: return new CityInfo("Waarland", "07", 52.72667, 4.83194);
case 184: return new CityInfo("Waarder", "11", 52.06083, 4.82083);
case 185: return new CityInfo("Waardenburg", "03", 51.8325, 5.25694);
case 186: return new CityInfo("Waarde", "10", 51.4175, 4.06806);
case 187: return new CityInfo("Waalwijk", "06", 51.6825, 5.07083);
case 188: return new CityInfo("Waalre", "06", 51.38667, 5.44444);
case 189: return new CityInfo("Vuren", "03", 51.825, 5.04583);
case 190: return new CityInfo("Vught", "06", 51.65333, 5.2875);
case 191: return new CityInfo("Vrouwenpolder", "10", 51.57667, 3.61528);
case 192: return new CityInfo("Vrouwenparochie", "02", 53.27928, 5.70036);
case 193: return new CityInfo("Vroomshoop", "15", 52.46083, 6.56528);
case 194: return new CityInfo("Vriezenveen", "15", 52.40833, 6.62222);
case 195: return new CityInfo("Vries", "01", 53.07417, 6.57778);
case 196: return new CityInfo("Vrieheide", "05", 50.92192, 5.96701);
case 197: return new CityInfo("Vreewijk", "11", 51.88428, 4.51967);
case 198: return new CityInfo("Vreeswijk", "09", 52.01088, 5.09285);
case 199: return new CityInfo("Vredenburg", "03", 51.95355, 5.90284);
case 200: return new CityInfo("Vorstenbosch", "06", 51.6525, 5.55);
case 201: return new CityInfo("Vorden", "03", 52.105, 6.30972);
case 202: return new CityInfo("Voorweg", "11", 52.08917, 4.62083);
case 203: return new CityInfo("Voorthuizen", "03", 52.18667, 5.60556);
case 204: return new CityInfo("Voorst", "03", 52.17, 6.14167);
case 205: return new CityInfo("Voorschoten", "11", 52.1275, 4.44861);
case 206: return new CityInfo("Voorhout", "11", 52.22167, 4.48472);
case 207: return new CityInfo("Voorburg", "11", 52.07417, 4.35972);
case 208: return new CityInfo("Vollenhove", "15", 52.68083, 5.95417);
case 209: return new CityInfo("Volkel", "06", 51.6425, 5.65417);
case 210: return new CityInfo("Volendam", "07", 52.495, 5.07083);
case 211: return new CityInfo("Voldijn", "06", 51.40052, 5.47196);
case 212: return new CityInfo("Vogelwijk", "11", 52.07631, 4.2479);
case 213: return new CityInfo("Vogelenzang", "07", 52.31917, 4.57778);
case 214: return new CityInfo("Voerendaal", "05", 50.88327, 5.92978);
case 215: return new CityInfo("Vlokhoven", "06", 51.46667, 5.48333);
case 216: return new CityInfo("Vlodrop", "05", 51.13333, 6.07639);
case 217: return new CityInfo("Vlist", "11", 51.98, 4.81944);
case 218: return new CityInfo("Vlissingen", "10", 51.4425, 3.57361);
case 219: return new CityInfo("Vlietwijk", "11", 52.12436, 4.45736);
case 220: return new CityInfo("Vlierden", "06", 51.445, 5.75833);
case 221: return new CityInfo("Vliedberg", "06", 51.68961, 5.19031);
case 222: return new CityInfo("Vleuten", "09", 52.10583, 5.01528);
case 223: return new CityInfo("Vledder", "01", 52.85583, 6.20833);
case 224: return new CityInfo("Vlagtwedde", "04", 53.0275, 7.10833);
case 225: return new CityInfo("Vlaardingen", "11", 51.9125, 4.34167);
case 226: return new CityInfo("Vinkeveen", "09", 52.21507, 4.93372);
case 227: return new CityInfo("Vilt", "05", 50.85833, 5.80833);
case 228: return new CityInfo("Vijlen", "05", 50.78833, 5.96528);
case 229: return new CityInfo("Vijfhuizen", "07", 52.35083, 4.67778);
case 230: return new CityInfo("Vierpolders", "11", 51.87917, 4.17917);
case 231: return new CityInfo("Vianen", "09", 51.9925, 5.09167);
case 232: return new CityInfo("Vianen", "06", 51.71833, 5.85694);
case 233: return new CityInfo("Veulen", "05", 51.4825, 5.95278);
case 234: return new CityInfo("Ven-Zelderheide", "05", 51.7125, 6.02361);
case 235: return new CityInfo("Venray", "05", 51.525, 5.975);
case 236: return new CityInfo("Venlo", "05", 51.37, 6.16806);
case 237: return new CityInfo("Venhorst", "06", 51.60833, 5.7375);
case 238: return new CityInfo("Ven", "06", 51.64, 5.55);
case 239: return new CityInfo("Veltum", "05", 51.51954, 5.96032);
case 240: return new CityInfo("Velsen-Zuid", "07", 52.46, 4.65);
case 241: return new CityInfo("Velp", "03", 51.995, 5.97361);
case 242: return new CityInfo("Veldhuizen", "09", 52.07537, 5.01234);
case 243: return new CityInfo("Veldhoven", "06", 51.41833, 5.40278);
case 244: return new CityInfo("Velddriel", "03", 51.76917, 5.30278);
case 245: return new CityInfo("Veghel", "06", 51.61667, 5.54861);
case 246: return new CityInfo("Feanwâlden", "02", 53.23558, 5.98832);
case 247: return new CityInfo("Veenoord", "01", 52.71087, 6.84869);
case 248: return new CityInfo("Veenhuizen", "01", 53.03167, 6.39583);
case 249: return new CityInfo("Veenendaal", "09", 52.02863, 5.55891);
case 250: return new CityInfo("Veendam", "04", 53.10667, 6.87917);
case 251: return new CityInfo("Veen", "06", 51.7775, 5.10833);
case 252: return new CityInfo("Veelerveen", "04", 53.05583, 7.12778);
case 253: return new CityInfo("Varsseveld", "03", 51.94333, 6.45833);
case 254: return new CityInfo("Varik", "03", 51.82333, 5.37083);
case 255: return new CityInfo("Valthermond", "01", 52.88167, 6.9625);
case 256: return new CityInfo("Valthe", "01", 52.84583, 6.89444);
case 257: return new CityInfo("Valkenswaard", "06", 51.35083, 5.45972);
case 258: return new CityInfo("Valkenburg", "11", 52.18, 4.43194);
case 259: return new CityInfo("Valkenburg", "05", 50.86523, 5.83205);
case 260: return new CityInfo("Valendries", "03", 51.80658, 5.73445);
case 261: return new CityInfo("Valburg", "03", 51.91167, 5.79028);
case 262: return new CityInfo("Vaesrade", "05", 50.92917, 5.90694);
case 263: return new CityInfo("Vaassen", "03", 52.28583, 5.96667);
case 264: return new CityInfo("Vaartbroek", "06", 51.47954, 5.49806);
case 265: return new CityInfo("Vaals", "05", 50.77083, 6.01806);
case 266: return new CityInfo("Utrecht", "09", 52.09083, 5.12222);
case 267: return new CityInfo("Usquert", "04", 53.4025, 6.61111);
case 268: return new CityInfo("Urmond", "05", 50.99083, 5.77222);
case 269: return new CityInfo("Urk", "16", 52.6625, 5.60139);
case 270: return new CityInfo("Ureterp", "02", 53.09244, 6.16718);
case 271: return new CityInfo("Ulvenhout", "06", 51.54907, 4.79931);
case 272: return new CityInfo("Ulrum", "04", 53.35917, 6.33333);
case 273: return new CityInfo("Ulestraten", "05", 50.90583, 5.78194);
case 274: return new CityInfo("Uitweg", "09", 51.9825, 5.01667);
case 275: return new CityInfo("Uithuizermeeden", "04", 53.41417, 6.72361);
case 276: return new CityInfo("Uithuizen", "04", 53.4075, 6.67083);
case 277: return new CityInfo("Uithoorn", "07", 52.2375, 4.82639);
case 278: return new CityInfo("Uitgeest", "07", 52.52917, 4.70972);
case 279: return new CityInfo("Ugchelen", "03", 52.18464, 5.93177);
case 280: return new CityInfo("Uffelte", "01", 52.79, 6.28056);
case 281: return new CityInfo("Udenhout", "06", 51.60917, 5.14306);
case 282: return new CityInfo("Uden", "06", 51.66083, 5.61944);
case 283: return new CityInfo("Uddel", "03", 52.25917, 5.78056);
case 284: return new CityInfo("Ubachsberg", "05", 50.85333, 5.94861);
case 285: return new CityInfo("Tzummarum", "02", 53.23733, 5.54612);
case 286: return new CityInfo("Tzum", "02", 53.15899, 5.56277);
case 287: return new CityInfo("'t Zand", "07", 52.83667, 4.75556);
case 288: return new CityInfo("Tynaarlo", "01", 53.0775, 6.61667);
case 289: return new CityInfo("Twisk", "07", 52.74083, 5.05278);
case 290: return new CityInfo("Twijzelerheide", "02", 53.24015, 6.04591);
case 291: return new CityInfo("Twijzel", "02", 53.23152, 6.08952);
case 292: return new CityInfo("Twello", "03", 52.23667, 6.10278);
case 293: return new CityInfo("Twekkelerveld", "15", 52.23064, 6.86004);
case 294: return new CityInfo("Tweede Exloërmond", "01", 52.90917, 6.93333);
case 295: return new CityInfo("Tungelroy", "05", 51.21167, 5.73056);
case 296: return new CityInfo("Tuk", "15", 52.79667, 6.09444);
case 297: return new CityInfo("Tuindorp", "11", 51.93032, 4.3784);
case 298: return new CityInfo("Tuikwerd", "04", 53.31667, 6.9);
case 299: return new CityInfo("Tubbergen", "15", 52.4075, 6.78472);
case 300: return new CityInfo("Tricht", "03", 51.89083, 5.26806);
case 301: return new CityInfo("Tongelre", "06", 51.44889, 5.51978);
case 302: return new CityInfo("Tolkamer", "03", 51.855, 6.10278);
case 303: return new CityInfo("Tjalleberd", "02", 52.99729, 5.94443);
case 304: return new CityInfo("Tivoli", "06", 51.42069, 5.50818);
case 305: return new CityInfo("Tinga", "02", 53.02064, 5.64575);
case 306: return new CityInfo("Tilligte", "15", 52.40583, 6.95139);
case 307: return new CityInfo("Tilburg", "06", 51.55551, 5.0913);
case 308: return new CityInfo("Tijnje", "02", 53.03058, 5.99193);
case 309: return new CityInfo("Tytsjerk", "02", 53.21343, 5.90961);
case 310: return new CityInfo("Tienray", "05", 51.495, 6.09306);
case 311: return new CityInfo("Tiel", "03", 51.88667, 5.42917);
case 312: return new CityInfo("Thorn", "05", 51.16167, 5.84167);
case 313: return new CityInfo("Tholen", "10", 51.53167, 4.22083);
case 314: return new CityInfo("'t Hofke", "06", 51.44943, 5.51926);
case 315: return new CityInfo("Theereheide", "06", 51.63843, 5.33729);
case 316: return new CityInfo("Teteringen", "06", 51.60917, 4.82083);
case 317: return new CityInfo("Terwolde", "03", 52.28333, 6.1);
case 318: return new CityInfo("Terwispel", "02", 53.01973, 6.0478);
case 319: return new CityInfo("Terwinselen", "05", 50.86659, 6.02471);
case 320: return new CityInfo("Terschuur", "03", 52.165, 5.51667);
case 321: return new CityInfo("Terneuzen", "10", 51.33583, 3.82778);
case 322: return new CityInfo("Ternaard", "02", 53.38203, 5.96523);
case 323: return new CityInfo("Termaar", "05", 50.86833, 5.88889);
case 324: return new CityInfo("Terherne", "02", 53.03333, 5.78333);
case 325: return new CityInfo("Terheijden", "06", 51.64333, 4.75417);
case 326: return new CityInfo("Ter Heijde", "11", 52.03, 4.16806);
case 327: return new CityInfo("Terbregge", "11", 51.95328, 4.51537);
case 328: return new CityInfo("Terborg", "03", 51.92, 6.35417);
case 329: return new CityInfo("Ter Apelkanaal", "04", 52.9025, 7.04861);
case 330: return new CityInfo("Ter Apel", "04", 52.87667, 7.05972);
case 331: return new CityInfo("Ten Post", "04", 53.2975, 6.72778);
case 332: return new CityInfo("Ten Boer", "04", 53.27583, 6.69444);
case 333: return new CityInfo("Tegelen", "05", 51.34417, 6.13611);
case 334: return new CityInfo("Swolgen", "05", 51.4925, 6.11806);
case 335: return new CityInfo("Sweikhuizen", "05", 50.95417, 5.84722);
case 336: return new CityInfo("Swartbroek", "05", 51.23, 5.77361);
case 337: return new CityInfo("Surhuizum", "02", 53.20475, 6.17981);
case 338: return new CityInfo("Surhuisterveen", "02", 53.18477, 6.17031);
case 339: return new CityInfo("Suwâld", "02", 53.17826, 5.9273);
case 340: return new CityInfo("Sumar", "02", 53.18333, 6);
case 341: return new CityInfo("Stuifakker", "11", 51.88417, 4.0625);
case 342: return new CityInfo("Stroe", "03", 52.18583, 5.69167);
case 343: return new CityInfo("Strijp", "11", 52.03083, 4.30139);
case 344: return new CityInfo("Strijen", "11", 51.74521, 4.55083);
case 345: return new CityInfo("Stramproy", "05", 51.19417, 5.71944);
case 346: return new CityInfo("Stoof", "06", 51.59917, 4.47778);
case 347: return new CityInfo("Stompetoren", "07", 52.61333, 4.82083);
case 348: return new CityInfo("Stolwijk", "11", 51.9725, 4.77361);
case 349: return new CityInfo("Stokkum", "15", 52.21167, 6.50694);
case 350: return new CityInfo("Stokkum", "03", 51.8775, 6.22083);
case 351: return new CityInfo("Stiens", "02", 53.26234, 5.75769);
case 352: return new CityInfo("Sterksel", "06", 51.35167, 5.61111);
case 353: return new CityInfo("Stepekolk", "06", 51.455, 5.61251);
case 354: return new CityInfo("Stein", "11", 52.00333, 4.78194);
case 355: return new CityInfo("Stein", "05", 50.96917, 5.76667);
case 356: return new CityInfo("Steggerda", "02", 52.85734, 6.07548);
case 357: return new CityInfo("Stegeslag", "03", 51.94151, 6.06194);
case 358: return new CityInfo("Steenwijksmoer", "01", 52.66917, 6.69861);
case 359: return new CityInfo("Steenwijkerwold", "15", 52.80417, 6.06389);
case 360: return new CityInfo("Steenwijk", "15", 52.7875, 6.12083);
case 361: return new CityInfo("Steensel", "06", 51.37667, 5.35278);
case 362: return new CityInfo("Steenderen", "03", 52.06417, 6.1875);
case 363: return new CityInfo("Steenbergen", "06", 51.58417, 4.31944);
case 364: return new CityInfo("Stedum", "04", 53.3225, 6.69583);
case 365: return new CityInfo("Stavoren", "02", 52.88525, 5.35886);
case 366: return new CityInfo("Stavenisse", "10", 51.5875, 4.0125);
case 367: return new CityInfo("Statenkwartier", "11", 52.09311, 4.27577);
case 368: return new CityInfo("Staphorst", "15", 52.645, 6.21111);
case 369: return new CityInfo("Standdaarbuiten", "06", 51.61333, 4.51389);
case 370: return new CityInfo("Stampersgat", "06", 51.61333, 4.44444);
case 371: return new CityInfo("Stadskanaal", "04", 52.98947, 6.9504);
case 372: return new CityInfo("Stadsfenne", "02", 53.03987, 5.67844);
case 373: return new CityInfo("Stadbroek", "05", 51.00187, 5.87656);
case 374: return new CityInfo("Sprundel", "06", 51.5375, 4.59722);
case 375: return new CityInfo("Spoorwijk", "11", 52.05347, 4.31339);
case 376: return new CityInfo("Spoordonk", "06", 51.5175, 5.27083);
case 377: return new CityInfo("Spijkenisse", "11", 51.845, 4.32917);
case 378: return new CityInfo("Spijk", "04", 53.39, 6.8375);
case 379: return new CityInfo("Spijk", "03", 51.84917, 6.15417);
case 380: return new CityInfo("Spijk", "06", 51.76917, 5.12083);
case 381: return new CityInfo("Spierdijk", "07", 52.65083, 4.94306);
case 382: return new CityInfo("Spekholzerheide", "05", 50.85559, 6.02471);
case 383: return new CityInfo("Spaubeek", "05", 50.94, 5.84306);
case 384: return new CityInfo("Spankeren", "03", 52.05833, 6.1125);
case 385: return new CityInfo("Spangen", "11", 51.91688, 4.43539);
case 386: return new CityInfo("Spakenburg", "09", 52.25, 5.36667);
case 387: return new CityInfo("Son", "06", 51.51136, 5.49282);
case 388: return new CityInfo("Someren-Eind", "06", 51.3575, 5.73333);
case 389: return new CityInfo("Someren", "06", 51.385, 5.71111);
case 390: return new CityInfo("Soestdijk", "09", 52.19083, 5.28472);
case 391: return new CityInfo("Soest", "09", 52.17333, 5.29167);
case 392: return new CityInfo("Soerendonk", "06", 51.30083, 5.575);
case 393: return new CityInfo("Snelrewaard", "09", 52.0275, 4.90833);
case 394: return new CityInfo("Sneek", "02", 53.03297, 5.6589);
case 395: return new CityInfo("Smitshoek", "11", 51.85561, 4.48319);
case 396: return new CityInfo("Sluiskil", "10", 51.27833, 3.83611);
case 397: return new CityInfo("Sluis", "10", 51.30833, 3.38611);
case 398: return new CityInfo("Sloten", "02", 52.89477, 5.64526);
case 399: return new CityInfo("Slootdorp", "07", 52.8425, 4.97222);
case 400: return new CityInfo("Slochteren", "04", 53.22078, 6.80547);
case 401: return new CityInfo("Slikkerveer", "11", 51.88531, 4.60494);
case 402: return new CityInfo("Sliedrecht", "11", 51.82083, 4.77639);
case 403: return new CityInfo("Slek", "05", 51.08616, 5.88087);
case 404: return new CityInfo("Sleen", "01", 52.77167, 6.80278);
case 405: return new CityInfo("Sittard", "05", 50.99833, 5.86944);
case 406: return new CityInfo("Sion", "11", 52.01417, 4.325);
case 407: return new CityInfo("Sint Willebrord", "06", 51.54833, 4.58889);
case 408: return new CityInfo("Sint Philipsland", "10", 51.61667, 4.16528);
case 409: return new CityInfo("Sint Pancras", "07", 52.66, 4.78333);
case 410: return new CityInfo("Sint-Oedenrode", "06", 51.5675, 5.45972);
case 411: return new CityInfo("Sint Odiliënberg", "05", 51.14333, 6);
case 412: return new CityInfo("Sint Nicolaasga", "02", 52.92293, 5.74242);
case 413: return new CityInfo("Sint-Michielsgestel", "06", 51.64167, 5.35278);
case 414: return new CityInfo("Sint Maartensvlotbrug", "07", 52.78667, 4.70833);
case 415: return new CityInfo("Sint Maartensbrug", "07", 52.78083, 4.72778);
case 416: return new CityInfo("Sint Maarten", "07", 52.7725, 4.74583);
case 417: return new CityInfo("Sint Laurens", "10", 51.5275, 3.60278);
case 418: return new CityInfo("Sint Joost", "05", 51.1175, 5.89861);
case 419: return new CityInfo("Sintjohannesga", "02", 52.93157, 5.85588);
case 420: return new CityInfo("Sint Jansklooster", "15", 52.6775, 6.00556);
case 421: return new CityInfo("Sint Jacobiparochie", "02", 53.27291, 5.60354);
case 422: return new CityInfo("Sint Hubert", "06", 51.67833, 5.80833);
case 423: return new CityInfo("Sint Gerlach", "05", 50.87154, 5.79248);
case 424: return new CityInfo("Sint Geertruid", "05", 50.79667, 5.76528);
case 425: return new CityInfo("Sint Anthonis", "06", 51.62667, 5.88194);
case 426: return new CityInfo("Sint Annaparochie", "02", 53.2762, 5.65727);
case 427: return new CityInfo("Simpelveld", "05", 50.83417, 5.98194);
case 428: return new CityInfo("Silvolde", "03", 51.90917, 6.3875);
case 429: return new CityInfo("Siegerswoude", "02", 53.09974, 6.2447);
case 430: return new CityInfo("Siddeburen", "04", 53.25, 6.86806);
case 431: return new CityInfo("Sibbe", "05", 50.84417, 5.82639);
case 432: return new CityInfo("'s-Hertogenbosch", "06", 51.69917, 5.30417);
case 433: return new CityInfo("'s-Heerenberg", "03", 51.8767, 6.25877);
case 434: return new CityInfo("'s-Gravenzande", "11", 52.00167, 4.16528);
case 435: return new CityInfo("'s Gravenmoer", "06", 51.65594, 4.94076);
case 436: return new CityInfo("The Hague", "11", 52.07667, 4.29861);
case 437: return new CityInfo("Sexbierum", "02", 53.21823, 5.48402);
case 438: return new CityInfo("Sevenum", "05", 51.4125, 6.0375);
case 439: return new CityInfo("Serooskerke", "10", 51.54833, 3.59444);
case 440: return new CityInfo("Selwerd", "04", 53.2352, 6.5545);
case 441: return new CityInfo("Sellingen", "04", 52.94583, 7.15139);
case 442: return new CityInfo("Schuttersveld", "05", 50.94467, 5.98317);
case 443: return new CityInfo("Schutsboom", "06", 51.46152, 5.6226);
case 444: return new CityInfo("Schoonrewoerd", "09", 51.92083, 5.11667);
case 445: return new CityInfo("Schoonoord", "01", 52.84583, 6.75556);
case 446: return new CityInfo("Schoonhoven", "11", 51.9475, 4.84861);
case 447: return new CityInfo("Schoonebeek", "01", 52.6625, 6.88472);
case 448: return new CityInfo("Schoondijke", "10", 51.35417, 3.55556);
case 449: return new CityInfo("Schipluiden", "11", 51.97583, 4.31389);
case 450: return new CityInfo("Schipborg", "01", 53.075, 6.67083);
case 451: return new CityInfo("Schinveld", "05", 50.96917, 5.97917);
case 452: return new CityInfo("Schin op Geul", "05", 50.85417, 5.86944);
case 453: return new CityInfo("Schinnen", "05", 50.94333, 5.88889);
case 454: return new CityInfo("Schimmert", "05", 50.90667, 5.82361);
case 455: return new CityInfo("Schildwolde", "04", 53.23327, 6.81566);
case 456: return new CityInfo("Schilberg", "05", 51.09917, 5.88611);
case 457: return new CityInfo("Schijndel", "06", 51.6225, 5.43194);
case 458: return new CityInfo("Schijf", "06", 51.49917, 4.56111);
case 459: return new CityInfo("Schiermonnikoog", "02", 53.48025, 6.15209);
case 460: return new CityInfo("Schiedam", "11", 51.91917, 4.38889);
case 461: return new CityInfo("Schiebroek", "11", 51.95838, 4.47124);
case 462: return new CityInfo("Scheveningen", "11", 52.10461, 4.27557);
case 463: return new CityInfo("Scherpenzeel", "03", 52.08, 5.48889);
case 464: return new CityInfo("Scherpenisse", "10", 51.54667, 4.10556);
case 465: return new CityInfo("Schermerhorn", "07", 52.60083, 4.89167);
case 466: return new CityInfo("Schelluinen", "11", 51.84333, 4.92639);
case 467: return new CityInfo("Schellinkhout", "07", 52.635, 5.12083);
case 468: return new CityInfo("Scheemda", "04", 53.17333, 6.97222);
case 469: return new CityInfo("Scharsterbrug", "02", 52.94414, 5.77889);
case 470: return new CityInfo("Scharnegoutum", "02", 53.06051, 5.67822);
case 471: return new CityInfo("Scharn", "05", 50.85, 5.73333);
case 472: return new CityInfo("Scharmer", "04", 53.205, 6.70556);
case 473: return new CityInfo("Scharendijke", "10", 51.73583, 3.84306);
case 474: return new CityInfo("Schalkhaar", "15", 52.26833, 6.19444);
case 475: return new CityInfo("Schaijk", "06", 51.74583, 5.63194);
case 476: return new CityInfo("Schagerbrug", "07", 52.8025, 4.75833);
case 477: return new CityInfo("Schagen", "07", 52.7875, 4.79861);
case 478: return new CityInfo("Sauwerd", "04", 53.29333, 6.53472);
case 479: return new CityInfo("Sas van Gent", "10", 51.2275, 3.79861);
case 480: return new CityInfo("Sassenheim", "11", 52.225, 4.52222);
case 481: return new CityInfo("Sappemeer", "04", 53.16417, 6.79028);
case 482: return new CityInfo("Saasveld", "15", 52.33167, 6.80694);
case 483: return new CityInfo("Ruurlo", "03", 52.08833, 6.45);
case 484: return new CityInfo("Rumpt", "03", 51.88417, 5.17639);
case 485: return new CityInfo("Ruinerwold", "01", 52.72333, 6.24861);
case 486: return new CityInfo("Ruinen", "01", 52.7625, 6.35417);
case 487: return new CityInfo("Rugge", "11", 51.89921, 4.15231);
case 488: return new CityInfo("Rucphen", "06", 51.53167, 4.55833);
case 489: return new CityInfo("Rozendaal", "03", 52.00583, 5.9625);
case 490: return new CityInfo("Rozenburg", "11", 51.90417, 4.24861);
case 491: return new CityInfo("Rottum", "02", 52.93659, 5.89447);
case 492: return new CityInfo("Rottevalle", "02", 53.14523, 6.10411);
case 493: return new CityInfo("Rotterdam", "11", 51.9225, 4.47917);
case 494: return new CityInfo("Rotsterhaule", "02", 52.91956, 5.85176);
case 495: return new CityInfo("Rothem", "05", 50.87667, 5.73889);
case 496: return new CityInfo("Rossum", "15", 52.35167, 6.92222);
case 497: return new CityInfo("Rossum", "03", 51.80083, 5.33333);
case 498: return new CityInfo("Roosteren", "05", 51.08333, 5.81806);
case 499: return new CityInfo("Roosendaal", "06", 51.53083, 4.46528);
case 500: return new CityInfo("Reduzum", "02", 53.11775, 5.78765);
case 501: return new CityInfo("Roodeschool", "04", 53.42083, 6.76667);
case 502: return new CityInfo("Rolde", "01", 52.98417, 6.64861);
case 503: return new CityInfo("Roermond", "05", 51.19417, 5.9875);
case 504: return new CityInfo("Roelofarendsveen", "11", 52.20333, 4.63333);
case 505: return new CityInfo("Roden", "01", 53.1375, 6.42083);
case 506: return new CityInfo("Rockanje", "11", 51.87167, 4.07083);
case 507: return new CityInfo("De Rips", "06", 51.55, 5.80972);
case 508: return new CityInfo("Rinsumageast", "02", 53.29695, 5.94931);
case 509: return new CityInfo("Rimburg", "05", 50.91583, 6.08472);
case 510: return new CityInfo("Rijswijk", "11", 52.03634, 4.32501);
case 511: return new CityInfo("Rijswijk", "06", 51.7975, 5.025);
case 512: return new CityInfo("Rijsoord", "11", 51.85083, 4.59583);
case 513: return new CityInfo("Rijsbergen", "06", 51.5175, 4.69722);
case 514: return new CityInfo("Rijpwetering", "11", 52.1925, 4.58333);
case 515: return new CityInfo("Ryptsjerk", "02", 53.22238, 5.91717);
case 516: return new CityInfo("Rijnsburg", "11", 52.19, 4.44167);
case 517: return new CityInfo("Rijnsaterwoude", "11", 52.19583, 4.67083);
case 518: return new CityInfo("Rijen", "06", 51.59083, 4.91944);
case 519: return new CityInfo("Rijckholt", "05", 50.79917, 5.73194);
case 520: return new CityInfo("Rietmolen", "03", 52.14083, 6.6625);
case 521: return new CityInfo("Riethoven", "06", 51.35417, 5.3875);
case 522: return new CityInfo("Ridderkerk", "11", 51.8725, 4.60278);
case 523: return new CityInfo("Rhoon", "11", 51.8575, 4.42222);
case 524: return new CityInfo("Rhenoy", "03", 51.88333, 5.15278);
case 525: return new CityInfo("Rhenen", "09", 51.95917, 5.56806);
case 526: return new CityInfo("Rheezerveen", "15", 52.56583, 6.525);
case 527: return new CityInfo("Rheden", "03", 52.005, 6.02917);
case 528: return new CityInfo("Reuver", "05", 51.28417, 6.07778);
case 529: return new CityInfo("Reusel", "06", 51.3625, 5.16528);
case 530: return new CityInfo("Renswoude", "09", 52.07333, 5.54028);
case 531: return new CityInfo("Renkum", "03", 51.97667, 5.73333);
case 532: return new CityInfo("Renesse", "10", 51.7325, 3.775);
case 533: return new CityInfo("Reijmerstok", "05", 50.79917, 5.8375);
case 534: return new CityInfo("Reeuwijk", "11", 52.04667, 4.725);
case 535: return new CityInfo("Reek", "06", 51.74583, 5.68194);
case 536: return new CityInfo("Ravenstein", "06", 51.79667, 5.65);
case 537: return new CityInfo("Raerd", "02", 53.09763, 5.75993);
case 538: return new CityInfo("Ransdaal", "05", 50.865, 5.89167);
case 539: return new CityInfo("Randwijk", "03", 51.95333, 5.70833);
case 540: return new CityInfo("Radewijk", "15", 52.57167, 6.70972);
case 541: return new CityInfo("Raamsdonksveer", "06", 51.69667, 4.87361);
case 542: return new CityInfo("Raamsdonk", "06", 51.6875, 4.90833);
case 543: return new CityInfo("Raam", "06", 51.65967, 5.63637);
case 544: return new CityInfo("Raalte", "15", 52.38583, 6.275);
case 545: return new CityInfo("Quirijnstok", "06", 51.5843, 5.0981);
case 546: return new CityInfo("Putten", "03", 52.25917, 5.60694);
case 547: return new CityInfo("Putte", "06", 51.36, 4.39583);
case 548: return new CityInfo("Puth", "05", 50.95417, 5.87361);
case 549: return new CityInfo("Purmerend", "07", 52.505, 4.95972);
case 550: return new CityInfo("Puiflijk", "03", 51.87833, 5.59028);
case 551: return new CityInfo("Prinsenbeek", "06", 51.59833, 4.7125);
case 552: return new CityInfo("Princenhage", "06", 51.57632, 4.73906);
case 553: return new CityInfo("Pottenberg", "05", 50.85135, 5.65668);
case 554: return new CityInfo("Posterholt", "05", 51.12333, 6.03472);
case 555: return new CityInfo("Poortvliet", "10", 51.54417, 4.14306);
case 556: return new CityInfo("Poeldijk", "11", 52.02417, 4.21944);
case 557: return new CityInfo("Poederoijen", "03", 51.78667, 5.08056);
case 558: return new CityInfo("Plaspoelpolder", "11", 52.03876, 4.33153);
case 559: return new CityInfo("Pijnacker", "11", 52.01954, 4.42946);
case 560: return new CityInfo("Piershil", "11", 51.79333, 4.31389);
case 561: return new CityInfo("Pierik", "15", 52.50141, 6.1117);
case 562: return new CityInfo("Petten", "07", 52.76667, 4.66111);
case 563: return new CityInfo("Pernis", "11", 51.88833, 4.38889);
case 564: return new CityInfo("Pendrecht", "11", 51.87152, 4.46901);
case 565: return new CityInfo("Peize", "01", 53.14667, 6.49722);
case 566: return new CityInfo("Peij", "05", 51.09417, 5.89583);
case 567: return new CityInfo("Peelo", "01", 53.01719, 6.56208);
case 568: return new CityInfo("Pathmos", "15", 52.21397, 6.87555);
case 569: return new CityInfo("Paterswolde", "01", 53.145, 6.56528);
case 570: return new CityInfo("Passart", "05", 50.92389, 5.94674);
case 571: return new CityInfo("Papenveer", "11", 52.185, 4.725);
case 572: return new CityInfo("Papenhoven", "05", 51.04333, 5.77639);
case 573: return new CityInfo("Papendrecht", "11", 51.83167, 4.6875);
case 574: return new CityInfo("Panningen", "05", 51.32667, 5.97917);
case 575: return new CityInfo("Pannerden", "03", 51.89083, 6.03889);
case 576: return new CityInfo("Palenstein", "11", 52.05579, 4.50869);
case 577: return new CityInfo("Palemig", "05", 50.90353, 5.98343);
case 578: return new CityInfo("Overveen", "07", 52.39167, 4.61389);
case 579: return new CityInfo("Overschie", "11", 51.93863, 4.42766);
case 580: return new CityInfo("Overloon", "06", 51.57167, 5.94722);
case 581: return new CityInfo("Overhoven", "05", 51.00869, 5.86628);
case 582: return new CityInfo("Overberg", "09", 52.04, 5.49444);
case 583: return new CityInfo("Overasselt", "03", 51.76, 5.78889);
case 584: return new CityInfo("Oud-Zuilen", "09", 52.1275, 5.06806);
case 585: return new CityInfo("Oudwoude", "02", 53.28193, 6.11447);
case 586: return new CityInfo("Oud-Vossemeer", "10", 51.57083, 4.19861);
case 587: return new CityInfo("Oud-Loosdrecht", "07", 52.20667, 5.08056);
case 588: return new CityInfo("Aldtsjerk", "02", 53.26637, 5.88704);
case 589: return new CityInfo("Oudkarspel", "07", 52.71583, 4.80556);
case 590: return new CityInfo("Oud Gastel", "06", 51.58667, 4.45972);
case 591: return new CityInfo("Oude Wetering", "11", 52.21417, 4.64444);
case 592: return new CityInfo("Oudewater", "09", 52.025, 4.86806);
case 593: return new CityInfo("Oudesluis", "07", 52.83417, 4.80833);
case 594: return new CityInfo("Oudeschoot", "02", 52.93343, 5.95579);
case 595: return new CityInfo("Oudeschild", "07", 53.03917, 4.84722);
case 596: return new CityInfo("Ouderkerk aan den IJssel", "11", 51.93417, 4.63611);
case 597: return new CityInfo("Ouderkerk aan de Amstel", "07", 52.29504, 4.90746);
case 598: return new CityInfo("Oude Pekela", "04", 53.10417, 7.00972);
case 599: return new CityInfo("Oudemirdum", "02", 52.85019, 5.53544);
case 600: return new CityInfo("Oudehorne", "02", 52.96281, 6.08351);
case 601: return new CityInfo("Oudehaske", "02", 52.95709, 5.87095);
case 602: return new CityInfo("Oudega", "02", 53.12504, 5.99888);
case 603: return new CityInfo("Oudega", "02", 52.99206, 5.54913);
case 604: return new CityInfo("Oude Bildtzijl", "02", 53.30048, 5.71849);
case 605: return new CityInfo("Ouddorp", "11", 51.81167, 3.93472);
case 606: return new CityInfo("Oud-Caberg", "05", 50.86539, 5.66444);
case 607: return new CityInfo("Oud-Beijerland", "11", 51.82417, 4.4125);
case 608: return new CityInfo("Ottersum", "05", 51.70333, 5.98333);
case 609: return new CityInfo("Otterlo", "03", 52.1, 5.77222);
case 610: return new CityInfo("Othene", "10", 51.33083, 3.85972);
case 611: return new CityInfo("Oterleek", "07", 52.63667, 4.83472);
case 612: return new CityInfo("Ossendrecht", "06", 51.39417, 4.32639);
case 613: return new CityInfo("Oss", "06", 51.765, 5.51806);
case 614: return new CityInfo("Ospel", "05", 51.2975, 5.78472);
case 615: return new CityInfo("Orthen", "06", 51.70613, 5.30468);
case 616: return new CityInfo("Orden", "03", 52.20113, 5.93417);
case 617: return new CityInfo("Oranjewoud", "02", 52.94579, 5.95038);
case 618: return new CityInfo("Opperduit", "11", 51.89917, 4.7125);
case 619: return new CityInfo("Opperdoes", "07", 52.75915, 5.07534);
case 620: return new CityInfo("Oppenhuizen", "02", 53.01194, 5.69495);
case 621: return new CityInfo("Opmeer", "07", 52.70667, 4.94444);
case 622: return new CityInfo("Oploo", "06", 51.60833, 5.87361);
case 623: return new CityInfo("Opijnen", "03", 51.82917, 5.29861);
case 624: return new CityInfo("Ophoven", "05", 50.99036, 5.85868);
case 625: return new CityInfo("Opheusden", "03", 51.93167, 5.63194);
case 626: return new CityInfo("Ophemert", "03", 51.845, 5.3875);
case 627: return new CityInfo("Opeinde", "02", 53.1341, 6.05656);
case 628: return new CityInfo("Ooyerhoek", "03", 52.12838, 6.22307);
case 629: return new CityInfo("Ootmarsum", "15", 52.40833, 6.90139);
case 630: return new CityInfo("Oostwoud", "07", 52.72583, 5.08611);
case 631: return new CityInfo("Oostwold", "04", 53.2025, 7.04583);
case 632: return new CityInfo("Oostvoorne", "11", 51.9125, 4.09861);
case 633: return new CityInfo("Oost-Vlieland", "02", 53.29703, 5.07431);
case 634: return new CityInfo("Oostrum", "05", 51.52917, 6.01667);
case 635: return new CityInfo("Oostknollendam", "07", 52.5175, 4.79167);
case 636: return new CityInfo("Oostkapelle", "10", 51.56667, 3.55139);
case 637: return new CityInfo("Oosthuizen", "07", 52.5725, 4.99583);
case 638: return new CityInfo("Oosterzij", "07", 52.585, 4.70556);
case 639: return new CityInfo("Oosterwolde", "02", 52.99164, 6.29096);
case 640: return new CityInfo("Oosterwolde", "03", 52.46583, 5.89167);
case 641: return new CityInfo("Oosterstreek", "02", 52.89751, 6.16144);
case 642: return new CityInfo("Oosterpark", "04", 53.2237, 6.5853);
case 643: return new CityInfo("Oosternijkerk", "02", 53.37841, 6.05347);
case 644: return new CityInfo("Eastermar", "02", 53.17466, 6.05999);
case 645: return new CityInfo("Oostermeenthe", "15", 52.79319, 6.13138);
case 646: return new CityInfo("Oosterland", "10", 51.65, 4.03611);
case 647: return new CityInfo("Oosterhuizen", "03", 52.15701, 6.00609);
case 648: return new CityInfo("Oosterhout", "03", 51.88, 5.82639);
case 649: return new CityInfo("Oosterhout", "06", 51.645, 4.85972);
case 650: return new CityInfo("Oosterhoogebrug", "04", 53.22892, 6.60141);
case 651: return new CityInfo("Oosterholt", "15", 52.55917, 5.95556);
case 652: return new CityInfo("Oosterhesselen", "01", 52.75417, 6.72222);
case 653: return new CityInfo("Oosterend", "07", 53.085, 4.875);
case 654: return new CityInfo("Oosterblokker", "07", 52.66917, 5.11806);
case 655: return new CityInfo("Oosterbeek", "03", 51.98583, 5.84583);
case 656: return new CityInfo("Oostendorp", "03", 52.44722, 5.85443);
case 657: return new CityInfo("Oostelbeers", "06", 51.47171, 5.26897);
case 658: return new CityInfo("Oosteinde", "07", 52.27917, 4.79583);
case 659: return new CityInfo("Oosteind", "06", 51.64418, 4.89784);
case 660: return new CityInfo("Oostdorp", "11", 52.14994, 4.39319);
case 661: return new CityInfo("Oostdijk", "10", 51.44417, 4.07778);
case 662: return new CityInfo("Oostburg", "10", 51.32583, 3.4875);
case 663: return new CityInfo("Oost", "05", 50.79568, 5.7101);
case 664: return new CityInfo("Ooy", "03", 51.91917, 6.05833);
case 665: return new CityInfo("Ooij", "03", 51.85465, 5.93915);
case 666: return new CityInfo("Ooievaarsnest", "06", 51.41667, 5.43333);
case 667: return new CityInfo("Oog in Al", "09", 52.08636, 5.0847);
case 668: return new CityInfo("Onstwedde", "04", 53.035, 7.04028);
case 669: return new CityInfo("Onderdijk", "07", 52.74333, 5.1375);
case 670: return new CityInfo("Onderdendam", "04", 53.33417, 6.59028);
case 671: return new CityInfo("Ommoord", "11", 51.95951, 4.54533);
case 672: return new CityInfo("Ommen", "15", 52.52083, 6.42083);
case 673: return new CityInfo("Ommelanderwijk", "04", 53.08917, 6.90556);
case 674: return new CityInfo("Ommel", "06", 51.42417, 5.74861);
case 675: return new CityInfo("Olst", "15", 52.3375, 6.10972);
case 676: return new CityInfo("Olland", "06", 51.58083, 5.40694);
case 677: return new CityInfo("Oldenzaal", "15", 52.31333, 6.92917);
case 678: return new CityInfo("Oldemarkt", "15", 52.82083, 5.975);
case 679: return new CityInfo("Oldekerk", "04", 53.21917, 6.34028);
case 680: return new CityInfo("Oldehove", "04", 53.30333, 6.39583);
case 681: return new CityInfo("Oldeholtpade", "02", 52.89285, 6.04754);
case 682: return new CityInfo("Oldebroek", "03", 52.445, 5.90139);
case 683: return new CityInfo("Aldeboarn", "02", 53.05, 5.9);
case 684: return new CityInfo("Oldeberkoop", "02", 52.93788, 6.13089);
case 685: return new CityInfo("Oisterwijk", "06", 51.57917, 5.18889);
case 686: return new CityInfo("Oirschot", "06", 51.505, 5.31389);
case 687: return new CityInfo("Oirsbeek", "05", 50.95083, 5.90833);
case 688: return new CityInfo("Oirlo", "05", 51.51167, 6.0375);
case 689: return new CityInfo("Oijen", "06", 51.82417, 5.50278);
case 690: return new CityInfo("Offenbeek", "05", 51.28225, 6.095);
case 691: return new CityInfo("Oerle", "06", 51.42255, 5.37163);
case 692: return new CityInfo("Oentsjerk", "02", 53.25, 5.9);
case 693: return new CityInfo("Oene", "03", 52.34417, 6.04861);
case 694: return new CityInfo("Oegstgeest", "11", 52.18, 4.46944);
case 695: return new CityInfo("Odoorn", "01", 52.84917, 6.85139);
case 696: return new CityInfo("Odiliapeel", "06", 51.64333, 5.70556);
case 697: return new CityInfo("Odijk", "09", 52.0525, 5.23611);
case 698: return new CityInfo("Ochten", "03", 51.91, 5.56944);
case 699: return new CityInfo("Obergum", "04", 53.33333, 6.51667);
case 700: return new CityInfo("Obdam", "07", 52.67583, 4.90694);
case 701: return new CityInfo("Obbicht", "05", 51.02833, 5.78056);
case 702: return new CityInfo("Nuth", "05", 50.9175, 5.88611);
case 703: return new CityInfo("Nunspeet", "03", 52.37917, 5.78611);
case 704: return new CityInfo("Numansdorp", "11", 51.73167, 4.4375);
case 705: return new CityInfo("Nuis", "04", 53.15083, 6.30556);
case 706: return new CityInfo("Nuenen", "06", 51.47, 5.55278);
case 707: return new CityInfo("Norg", "01", 53.06667, 6.45833);
case 708: return new CityInfo("Noordwolde", "02", 52.88964, 6.14153);
case 709: return new CityInfo("Noordwijkerhout", "11", 52.26167, 4.49306);
case 710: return new CityInfo("Noordwijk-Binnen", "11", 52.234, 4.44474);
case 711: return new CityInfo("Noord-Scharwoude", "07", 52.69833, 4.81111);
case 712: return new CityInfo("Noordhorn", "04", 53.26167, 6.39583);
case 713: return new CityInfo("Noord-Hofland", "11", 52.14059, 4.45864);
case 714: return new CityInfo("Noordhoek", "06", 51.6425, 4.53194);
case 715: return new CityInfo("Noordgeest", "06", 51.50917, 4.27917);
case 716: return new CityInfo("Noordeloos", "11", 51.90333, 4.94167);
case 717: return new CityInfo("Noordeinde", "11", 52.01667, 4.48333);
case 718: return new CityInfo("Noordbroek", "04", 53.195, 6.87361);
case 719: return new CityInfo("Noardburgum", "02", 53.22135, 6.00523);
case 720: return new CityInfo("Noordbarge", "01", 52.77237, 6.88713);
case 721: return new CityInfo("Noorbeek", "05", 50.76917, 5.8125);
case 722: return new CityInfo("Nistelrode", "06", 51.70417, 5.5625);
case 723: return new CityInfo("Nispen", "06", 51.48331, 4.46131);
case 724: return new CityInfo("Nijswiller", "05", 50.80917, 5.95694);
case 725: return new CityInfo("Nijrees", "15", 52.335, 6.66389);
case 726: return new CityInfo("Nijnsel", "06", 51.55083, 5.48333);
case 727: return new CityInfo("Nijmegen", "03", 51.8425, 5.85278);
case 728: return new CityInfo("Nijland", "02", 53.05019, 5.5759);
case 729: return new CityInfo("Nijkerkerveen", "03", 52.195, 5.46667);
case 730: return new CityInfo("Nijkerk", "03", 52.22, 5.48611);
case 731: return new CityInfo("Nijenheim", "09", 52.08689, 5.21852);
case 732: return new CityInfo("Nijemirdum", "02", 52.85638, 5.56844);
case 733: return new CityInfo("Nieuw-Vossemeer", "06", 51.59, 4.21806);
case 734: return new CityInfo("Nieuwveen", "11", 52.19667, 4.75694);
case 735: return new CityInfo("Nieuw-Schoonebeek", "01", 52.64833, 6.98611);
case 736: return new CityInfo("Nieuw-Roden", "01", 53.13167, 6.39722);
case 737: return new CityInfo("Nieuwpoort", "11", 51.93583, 4.86806);
case 738: return new CityInfo("Nieuwoord", "15", 52.46667, 6.55);
case 739: return new CityInfo("Nieuwolda", "04", 53.24417, 6.975);
case 740: return new CityInfo("Nieuw-Lotbroek", "05", 50.91283, 5.92798);
case 741: return new CityInfo("Nieuw-Loosdrecht", "07", 52.19917, 5.13889);
case 742: return new CityInfo("Nieuw-Lekkerland", "11", 51.88915, 4.68653);
case 743: return new CityInfo("Nieuw- en Sint Joosland", "10", 51.48333, 3.65694);
case 744: return new CityInfo("Nieuwkuijk", "06", 51.69, 5.18194);
case 745: return new CityInfo("Nieuwkoop", "11", 52.15083, 4.77639);
case 746: return new CityInfo("Nieuwe Wetering", "11", 52.2075, 4.61806);
case 747: return new CityInfo("Nieuwerkerk", "10", 51.65083, 4.00139);
case 748: return new CityInfo("Nieuwe Pekela", "04", 53.07917, 6.96528);
case 749: return new CityInfo("Nieuwe-Niedorp", "07", 52.74, 4.89861);
case 750: return new CityInfo("Nieuwenhoorn", "11", 51.85417, 4.14306);
case 751: return new CityInfo("Nieuwehorne", "02", 52.95113, 6.06342);
case 752: return new CityInfo("Nieuwegein", "09", 52.02917, 5.08056);
case 753: return new CityInfo("Nieuwdorp", "05", 50.96216, 5.77297);
case 754: return new CityInfo("Nieuw-Dordrecht", "01", 52.74833, 6.96806);
case 755: return new CityInfo("Nieuw-Dijk", "03", 51.93333, 6.15556);
case 756: return new CityInfo("Nieuw-Buinen", "01", 52.9625, 6.95);
case 757: return new CityInfo("Nieuw-Beijerland", "11", 51.8125, 4.34306);
case 758: return new CityInfo("Nieuw-Balinge", "01", 52.76667, 6.60694);
case 759: return new CityInfo("Nieuwaal", "03", 51.81, 5.17778);
case 760: return new CityInfo("Nietap", "01", 53.15917, 6.4);
case 761: return new CityInfo("Niekerk", "04", 53.225, 6.35278);
case 762: return new CityInfo("Niebert", "04", 53.16083, 6.32778);
case 763: return new CityInfo("Netersel", "06", 51.40333, 5.20833);
case 764: return new CityInfo("Nes", "02", 53.44502, 5.774);
case 765: return new CityInfo("Nes", "02", 53.05207, 5.85223);
case 766: return new CityInfo("Neerkant", "06", 51.36833, 5.86667);
case 767: return new CityInfo("Neerbeek", "05", 50.95, 5.81528);
case 768: return new CityInfo("Andel", "06", 51.78333, 5.05833);
case 769: return new CityInfo("Neede", "03", 52.13417, 6.61389);
case 770: return new CityInfo("Nederwoud", "03", 52.10083, 5.57083);
case 771: return new CityInfo("Nederwetten", "06", 51.49167, 5.52361);
case 772: return new CityInfo("Nederweert", "05", 51.28583, 5.74861);
case 773: return new CityInfo("Nederhemert-Noord", "03", 51.76322, 5.17305);
case 774: return new CityInfo("Nederhemert", "03", 51.76518, 5.16817);
case 775: return new CityInfo("Neder-Hardinxveld", "11", 51.82879, 4.85489);
case 776: return new CityInfo("Nederasselt", "03", 51.77167, 5.74444);
case 777: return new CityInfo("Naastenbest", "06", 51.50484, 5.38579);
case 778: return new CityInfo("Naarden", "07", 52.29583, 5.1625);
case 779: return new CityInfo("Naaldwijk", "11", 51.99417, 4.20972);
case 780: return new CityInfo("Mussel", "04", 52.955, 7.03889);
case 781: return new CityInfo("Munstergeleen", "05", 50.975, 5.86389);
case 782: return new CityInfo("Muiderberg", "07", 52.32583, 5.12083);
case 783: return new CityInfo("Muiden", "07", 52.33, 5.06944);
case 784: return new CityInfo("De Mortel", "06", 51.54, 5.70833);
case 785: return new CityInfo("Mook", "05", 51.7525, 5.88194);
case 786: return new CityInfo("Montfort", "05", 51.12583, 5.94861);
case 787: return new CityInfo("Montfoort", "09", 52.04583, 4.95278);
case 788: return new CityInfo("Monster", "11", 52.02583, 4.175);
case 789: return new CityInfo("Monnickendam", "07", 52.45833, 5.0375);
case 790: return new CityInfo("Molenschot", "06", 51.5725, 4.88194);
case 791: return new CityInfo("Molenhoek", "06", 51.71113, 5.36809);
case 792: return new CityInfo("Mûnein", "02", 53.25269, 5.92026);
case 793: return new CityInfo("Moesel", "05", 51.23828, 5.71778);
case 794: return new CityInfo("Moerdijk", "06", 51.70167, 4.62639);
case 795: return new CityInfo("Minnertsga", "02", 53.25104, 5.59513);
case 796: return new CityInfo("Milsbeek", "05", 51.725, 5.94861);
case 797: return new CityInfo("Milheeze", "06", 51.50167, 5.77917);
case 798: return new CityInfo("Mildam", "02", 52.93555, 6.00154);
case 799: return new CityInfo("Mijnsheerenland", "11", 51.79667, 4.4875);
case 800: return new CityInfo("Mijdrecht", "09", 52.20667, 4.8625);
case 801: return new CityInfo("Mierlo", "06", 51.44, 5.61944);
case 802: return new CityInfo("Midwoud", "07", 52.71667, 5.075);
case 803: return new CityInfo("Midwolda", "04", 53.195, 7.01389);
case 804: return new CityInfo("Midsland", "02", 53.38215, 5.28528);
case 805: return new CityInfo("Midlum", "02", 53.18184, 5.44845);
case 806: return new CityInfo("Middenmeer", "07", 52.80667, 4.99861);
case 807: return new CityInfo("Middenbeemster", "07", 52.54917, 4.9125);
case 808: return new CityInfo("Middelstum", "04", 53.34667, 6.64167);
case 809: return new CityInfo("Middelsluis", "11", 51.7425, 4.44167);
case 810: return new CityInfo("Middelrode", "06", 51.66417, 5.41944);
case 811: return new CityInfo("Middelie", "07", 52.53233, 5.01835);
case 812: return new CityInfo("Middelharnis", "11", 51.7575, 4.16528);
case 813: return new CityInfo("Middelburg", "10", 51.5, 3.61389);
case 814: return new CityInfo("Middelbeers", "06", 51.46667, 5.25);
case 815: return new CityInfo("Mheer", "05", 50.78, 5.79167);
case 816: return new CityInfo("Metslawier", "02", 53.35987, 6.06703);
case 817: return new CityInfo("Meterik", "05", 51.455, 6.025);
case 818: return new CityInfo("Meteren", "03", 51.865, 5.28333);
case 819: return new CityInfo("Merum", "05", 51.17333, 5.95972);
case 820: return new CityInfo("Merselo", "05", 51.53, 5.92778);
case 821: return new CityInfo("Merkelbeek", "05", 50.95389, 5.94069);
case 822: return new CityInfo("Merenwijk", "11", 52.17655, 4.50885);
case 823: return new CityInfo("Meppel", "01", 52.69583, 6.19444);
case 824: return new CityInfo("Menaam", "02", 53.21797, 5.66124);
case 825: return new CityInfo("Melle", "06", 51.66244, 5.63367);
case 826: return new CityInfo("Meliskerke", "10", 51.51417, 3.50972);
case 827: return new CityInfo("Melick", "05", 51.15917, 6.01667);
case 828: return new CityInfo("Melderslo", "05", 51.46167, 6.08611);
case 829: return new CityInfo("Mekkelholt", "15", 52.23645, 6.89058);
case 830: return new CityInfo("Meijel", "05", 51.34417, 5.88472);
case 831: return new CityInfo("Megen", "06", 51.82167, 5.5625);
case 832: return new CityInfo("Megchelen", "03", 51.83833, 6.39306);
case 833: return new CityInfo("Meezenbroek", "05", 50.8968, 5.99051);
case 834: return new CityInfo("Meeuwen", "06", 51.72917, 5.01111);
case 835: return new CityInfo("Meerveldhoven", "06", 51.41705, 5.41618);
case 836: return new CityInfo("Meerssen", "05", 50.8875, 5.75);
case 837: return new CityInfo("Meers", "05", 50.96167, 5.74167);
case 838: return new CityInfo("Meerlo", "05", 51.51333, 6.08472);
case 839: return new CityInfo("Meeden", "04", 53.14, 6.92639);
case 840: return new CityInfo("Medemblik", "07", 52.77167, 5.10556);
case 841: return new CityInfo("Meddo", "03", 52.01333, 6.70694);
case 842: return new CityInfo("Mechelen", "05", 50.79583, 5.92639);
case 843: return new CityInfo("Maurik", "03", 51.96083, 5.42222);
case 844: return new CityInfo("Marum", "04", 53.14417, 6.2625);
case 845: return new CityInfo("Martenshoek", "04", 53.16333, 6.73056);
case 846: return new CityInfo("Marsum", "02", 53.2105, 5.72637);
case 847: return new CityInfo("Marrum", "02", 53.32277, 5.80198);
case 848: return new CityInfo("Marle", "15", 52.42417, 6.48056);
case 849: return new CityInfo("Markelo", "15", 52.235, 6.49861);
case 850: return new CityInfo("Mariarade", "05", 50.92906, 5.92738);
case 851: return new CityInfo("Mariahout", "06", 51.54083, 5.57222);
case 852: return new CityInfo("Mariaheide", "06", 51.63333, 5.58056);
case 853: return new CityInfo("Margraten", "05", 50.82083, 5.82083);
case 854: return new CityInfo("Maren-Kessel", "06", 51.79583, 5.39306);
case 855: return new CityInfo("Mantgum", "02", 53.12865, 5.71924);
case 856: return new CityInfo("Malta", "10", 51.65, 3.93333);
case 857: return new CityInfo("Malburgen West", "03", 51.96811, 5.89743);
case 858: return new CityInfo("Malberg", "05", 50.86244, 5.65419);
case 859: return new CityInfo("Makkum", "02", 53.05458, 5.40231);
case 860: return new CityInfo("Makkinga", "02", 52.9809, 6.2174);
case 861: return new CityInfo("Magele", "15", 52.46917, 6.52083);
case 862: return new CityInfo("Made", "06", 51.67667, 4.79306);
case 863: return new CityInfo("Macharen", "06", 51.80583, 5.54444);
case 864: return new CityInfo("Maastricht", "05", 50.84833, 5.68889);
case 865: return new CityInfo("Maassluis", "11", 51.92333, 4.25);
case 866: return new CityInfo("Maasland", "11", 51.93417, 4.27222);
case 867: return new CityInfo("Maaskantje", "06", 51.65833, 5.37083);
case 868: return new CityInfo("Maasdijk", "11", 51.95917, 4.21389);
case 869: return new CityInfo("Maasdam", "11", 51.78917, 4.55556);
case 870: return new CityInfo("Maasbree", "05", 51.3575, 6.04861);
case 871: return new CityInfo("Maasbracht", "05", 51.13929, 5.88627);
case 872: return new CityInfo("Maartensdijk", "09", 52.155, 5.175);
case 873: return new CityInfo("Maarsseveen", "09", 52.14092, 5.07337);
case 874: return new CityInfo("Maarssen", "09", 52.13917, 5.04167);
case 875: return new CityInfo("Maarsbergen", "09", 52.05833, 5.40556);
case 876: return new CityInfo("Maarn", "09", 52.06417, 5.37083);
case 877: return new CityInfo("Maarheeze", "06", 51.31167, 5.61667);
case 878: return new CityInfo("Luyksgestel", "06", 51.28917, 5.32361);
case 879: return new CityInfo("Lutjegast", "04", 53.23417, 6.25833);
case 880: return new CityInfo("Lutjebroek", "07", 52.6975, 5.20417);
case 881: return new CityInfo("Lunteren", "03", 52.085, 5.62222);
case 882: return new CityInfo("Loven", "06", 51.5648, 5.09748);
case 883: return new CityInfo("Lottum", "05", 51.46167, 6.16111);
case 884: return new CityInfo("Losser", "15", 52.26083, 7.00417);
case 885: return new CityInfo("Loppersum", "04", 53.33167, 6.74722);
case 886: return new CityInfo("Lopikerkapel", "09", 51.99167, 5.04583);
case 887: return new CityInfo("Lopik", "09", 51.9725, 4.94861);
case 888: return new CityInfo("Loosbroek", "06", 51.67833, 5.50694);
case 889: return new CityInfo("Loon op Zand", "06", 51.6275, 5.075);
case 890: return new CityInfo("Loo", "15", 52.2525, 6.33889);
case 891: return new CityInfo("Lombardijen", "11", 51.8738, 4.52192);
case 892: return new CityInfo("Loil", "03", 51.95333, 6.14167);
case 893: return new CityInfo("Loenen", "03", 52.1175, 6.01944);
case 894: return new CityInfo("Lochem", "03", 52.15917, 6.41111);
case 895: return new CityInfo("Lobith", "03", 51.8625, 6.11806);
case 896: return new CityInfo("Lithoijen", "06", 51.8025, 5.46389);
case 897: return new CityInfo("Lith", "06", 51.80583, 5.43889);
case 898: return new CityInfo("Lisserbroek", "07", 52.25667, 4.57222);
case 899: return new CityInfo("Lisse", "11", 52.26, 4.55694);
case 900: return new CityInfo("Lippenhuizen", "02", 53.01835, 6.09346);
case 901: return new CityInfo("Linschoten", "09", 52.0625, 4.91528);
case 902: return new CityInfo("Linne", "05", 51.155, 5.93889);
case 903: return new CityInfo("Lindenholt", "03", 51.8327, 5.7934);
case 904: return new CityInfo("Lindenheuvel", "05", 50.98509, 5.81667);
case 905: return new CityInfo("Limmen", "07", 52.56917, 4.69444);
case 906: return new CityInfo("Limmel", "05", 50.86718, 5.70719);
case 907: return new CityInfo("Limbricht", "05", 51.01167, 5.8375);
case 908: return new CityInfo("Lijnden", "07", 52.3525, 4.75694);
case 909: return new CityInfo("Lievendaal", "06", 51.44219, 5.43405);
case 910: return new CityInfo("Liesveld", "11", 51.9325, 4.83194);
case 911: return new CityInfo("Liessel", "06", 51.41333, 5.82083);
case 912: return new CityInfo("Lieshout", "06", 51.52036, 5.59479);
case 913: return new CityInfo("Lierop", "06", 51.41917, 5.67917);
case 914: return new CityInfo("Lieren", "03", 52.1625, 5.98889);
case 915: return new CityInfo("Lienden", "03", 51.94833, 5.51806);
case 916: return new CityInfo("Liempde", "06", 51.56917, 5.37222);
case 917: return new CityInfo("Lichtenvoorde", "03", 51.98667, 6.56667);
case 918: return new CityInfo("Lichtenberg", "05", 50.9022, 6.02523);
case 919: return new CityInfo("Leveroy", "05", 51.24917, 5.84722);
case 920: return new CityInfo("Leuth", "03", 51.83917, 5.99167);
case 921: return new CityInfo("Leusden", "09", 52.1325, 5.43194);
case 922: return new CityInfo("Leunen", "05", 51.51, 5.97917);
case 923: return new CityInfo("Leuken", "05", 51.25288, 5.7346);
case 924: return new CityInfo("Lepelstraat", "06", 51.54833, 4.27639);
case 925: return new CityInfo("Lent", "03", 51.86167, 5.86667);
case 926: return new CityInfo("Lennisheuvel", "06", 51.5725, 5.31528);
case 927: return new CityInfo("Lemmer", "02", 52.84618, 5.70912);
case 928: return new CityInfo("Lemiers", "05", 50.78583, 5.99306);
case 929: return new CityInfo("Lelystad", "16", 52.50833, 5.475);
case 930: return new CityInfo("Leimuiden", "11", 52.22417, 4.66944);
case 931: return new CityInfo("Leiderdorp", "11", 52.15833, 4.52917);
case 932: return new CityInfo("Leiden", "11", 52.15833, 4.49306);
case 933: return new CityInfo("Leeuwen", "05", 51.21032, 5.99862);
case 934: return new CityInfo("Leeuwarden", "02", 53.20139, 5.80859);
case 935: return new CityInfo("Leesten", "03", 52.1279, 6.23217);
case 936: return new CityInfo("Leest", "06", 51.60983, 5.54312);
case 937: return new CityInfo("Leersum", "09", 52.01167, 5.42778);
case 938: return new CityInfo("Leerdam", "09", 51.89333, 5.09167);
case 939: return new CityInfo("Leens", "04", 53.36, 6.37917);
case 940: return new CityInfo("Leende", "06", 51.35083, 5.55417);
case 941: return new CityInfo("Leek", "04", 53.1625, 6.37639);
case 942: return new CityInfo("Lauradorp", "05", 50.91229, 6.04591);
case 943: return new CityInfo("Lathum", "03", 51.98667, 6.01944);
case 944: return new CityInfo("Laren", "07", 52.25667, 5.22778);
case 945: return new CityInfo("Laren", "03", 52.19417, 6.36528);
case 946: return new CityInfo("Langweer", "02", 52.95836, 5.72173);
case 947: return new CityInfo("Langezwaag", "02", 52.98257, 6.0024);
case 948: return new CityInfo("Langeweg", "06", 51.64833, 4.66528);
case 949: return new CityInfo("Langeraar", "11", 52.19333, 4.71111);
case 950: return new CityInfo("Langenoord", "09", 52.18768, 5.38034);
case 951: return new CityInfo("Langenboom", "06", 51.70417, 5.73056);
case 952: return new CityInfo("Langeheit", "07", 52.492, 4.75849);
case 953: return new CityInfo("Landsmeer", "07", 52.43083, 4.91528);
case 954: return new CityInfo("Lammerenburg", "10", 51.46667, 3.55833);
case 955: return new CityInfo("Lage Mierde", "06", 51.40583, 5.14722);
case 956: return new CityInfo("Laar", "05", 51.27583, 5.70556);
case 957: return new CityInfo("Laag-Soeren", "03", 52.08417, 6.075);
case 958: return new CityInfo("Kwintsheul", "11", 52.01333, 4.25556);
case 959: return new CityInfo("Kwadijk", "07", 52.52833, 4.98056);
case 960: return new CityInfo("Kunrade", "05", 50.87769, 5.93107);
case 961: return new CityInfo("Kuinre", "15", 52.7875, 5.84028);
case 962: return new CityInfo("Kudelstaart", "07", 52.23417, 4.75139);
case 963: return new CityInfo("Kruisstraat", "06", 51.73167, 5.39444);
case 964: return new CityInfo("Kruisland", "06", 51.56917, 4.40972);
case 965: return new CityInfo("Kruisberg", "05", 50.94234, 5.96519);
case 966: return new CityInfo("Krooswijk", "06", 51.64665, 4.59203);
case 967: return new CityInfo("Kronenberg", "05", 51.41583, 6);
case 968: return new CityInfo("Krimpen aan den IJssel", "11", 51.91667, 4.60278);
case 969: return new CityInfo("Kreileroord", "07", 52.84167, 5.08194);
case 970: return new CityInfo("Krakeel", "01", 52.72339, 6.51146);
case 971: return new CityInfo("Koudum", "02", 52.91551, 5.44834);
case 972: return new CityInfo("Koudekerke", "10", 51.48167, 3.55417);
case 973: return new CityInfo("Korvel", "06", 51.54954, 5.07079);
case 974: return new CityInfo("Korteraar", "11", 52.17333, 4.73194);
case 975: return new CityInfo("Kortenhoef", "07", 52.23917, 5.10694);
case 976: return new CityInfo("Korrewegwijk", "04", 53.23235, 6.56804);
case 977: return new CityInfo("Kornhorn", "04", 53.18167, 6.24306);
case 978: return new CityInfo("Kootwijkerbroek", "03", 52.15083, 5.66944);
case 979: return new CityInfo("Kootstertille", "02", 53.21261, 6.09209);
case 980: return new CityInfo("Koningslust", "05", 51.3575, 5.99306);
case 981: return new CityInfo("Koningsbosch", "05", 51.05167, 5.95833);
case 982: return new CityInfo("Kommerzijl", "04", 53.28667, 6.325);
case 983: return new CityInfo("Kollumerzwaag", "02", 53.26224, 6.07544);
case 984: return new CityInfo("Kollum", "02", 53.27695, 6.15293);
case 985: return new CityInfo("Kolhorn", "07", 52.79417, 4.88889);
case 986: return new CityInfo("Kolham", "04", 53.1825, 6.74444);
case 987: return new CityInfo("Koewacht", "10", 51.22833, 3.97361);
case 988: return new CityInfo("Koekange", "01", 52.69917, 6.31667);
case 989: return new CityInfo("Klundert", "06", 51.665, 4.53472);
case 990: return new CityInfo("Kloosterburen", "04", 53.38667, 6.39167);
case 991: return new CityInfo("Kloetinge", "10", 51.49833, 3.91528);
case 992: return new CityInfo("Klimmen", "05", 50.87583, 5.88056);
case 993: return new CityInfo("Klijndijk", "01", 52.83167, 6.85972);
case 994: return new CityInfo("Klein-Zundert", "06", 51.48083, 4.65417);
case 995: return new CityInfo("Klein Driene", "15", 52.26935, 6.81613);
case 996: return new CityInfo("Klazienaveen", "01", 52.72417, 6.99028);
case 997: return new CityInfo("Klarenbeek", "10", 51.50964, 3.61132);
case 998: return new CityInfo("Klarenbeek", "03", 52.1675, 6.0625);
case 999: return new CityInfo("Klaaswaal", "11", 51.77, 4.44583);
case 1000: return new CityInfo("Kitskensberg", "05", 51.17181, 6.00433);
case 1001: return new CityInfo("Kinderdijk", "11", 51.88583, 4.63194);
case 1002: return new CityInfo("Kilder", "03", 51.9375, 6.23194);
case 1003: return new CityInfo("Kijkduin", "11", 52.06765, 4.22188);
case 1004: return new CityInfo("Ketelhaven", "16", 52.57718, 5.76383);
case 1005: return new CityInfo("Kesteren", "03", 51.935, 5.56944);
case 1006: return new CityInfo("Kesseleik", "05", 51.27833, 6.02361);
case 1007: return new CityInfo("Kessel", "05", 51.29167, 6.05417);
case 1008: return new CityInfo("Kerschoten", "03", 52.23333, 5.96667);
case 1009: return new CityInfo("Kerkwerve", "10", 51.68667, 3.89861);
case 1010: return new CityInfo("Kerkrade", "05", 50.86583, 6.0625);
case 1011: return new CityInfo("Kerkenveld", "01", 52.66833, 6.5);
case 1012: return new CityInfo("Kerkelanden", "07", 52.21755, 5.13575);
case 1013: return new CityInfo("Kerkehout", "11", 52.11018, 4.37957);
case 1014: return new CityInfo("Kerkdriel", "03", 51.77167, 5.33472);
case 1015: return new CityInfo("Marken", "07", 52.45833, 5.10278);
case 1016: return new CityInfo("Kerensheide", "05", 50.9721, 5.77666);
case 1017: return new CityInfo("Kerckebosch", "09", 52.07844, 5.26584);
case 1018: return new CityInfo("Keldonk", "06", 51.58667, 5.58472);
case 1019: return new CityInfo("Keijenborg", "03", 52.02917, 6.29444);
case 1020: return new CityInfo("Keent", "05", 51.24218, 5.70079);
case 1021: return new CityInfo("Kedichem", "09", 51.86, 5.05);
case 1022: return new CityInfo("Katwijk aan Zee", "11", 52.20333, 4.39861);
case 1023: return new CityInfo("Katwijk aan den Rijn", "11", 52.19417, 4.42222);
case 1024: return new CityInfo("Katlijk", "02", 52.94595, 6.01261);
case 1025: return new CityInfo("Katendrecht", "11", 51.90074, 4.48254);
case 1026: return new CityInfo("Kantens", "04", 53.36583, 6.63472);
case 1027: return new CityInfo("Kamperveen", "15", 52.50797, 5.93056);
case 1028: return new CityInfo("Kamperland", "10", 51.57167, 3.70417);
case 1029: return new CityInfo("Kampen", "15", 52.555, 5.91111);
case 1030: return new CityInfo("Kalsdonk", "06", 51.53973, 4.47111);
case 1031: return new CityInfo("Kakert", "05", 50.90414, 6.00463);
case 1032: return new CityInfo("Kadoelen", "07", 52.4175, 4.90561);
case 1033: return new CityInfo("Kaalheide", "05", 50.86505, 6.03643);
case 1034: return new CityInfo("Joure", "02", 52.9657, 5.80301);
case 1035: return new CityInfo("Jagershoef", "06", 51.4733, 5.4672);
case 1036: return new CityInfo("Jabeek", "05", 50.98083, 5.94167);
case 1037: return new CityInfo("Itteren", "05", 50.89833, 5.70278);
case 1038: return new CityInfo("Jirnsum", "02", 53.07753, 5.79254);
case 1039: return new CityInfo("Ingen", "03", 51.95917, 5.48472);
case 1040: return new CityInfo("Ilpendam", "07", 52.46333, 4.95);
case 1041: return new CityInfo("IJzendoorn", "03", 51.90583, 5.53333);
case 1042: return new CityInfo("IJzendijke", "10", 51.32167, 3.61667);
case 1043: return new CityInfo("Ysselsteyn", "05", 51.49, 5.89722);
case 1044: return new CityInfo("IJsselstein", "09", 52.02, 5.04306);
case 1045: return new CityInfo("Ysbrechtum", "02", 53.04121, 5.63204);
case 1046: return new CityInfo("IJlst", "02", 53.01009, 5.62312);
case 1047: return new CityInfo("IJhorst", "15", 52.65917, 6.29167);
case 1048: return new CityInfo("Husken", "05", 50.89567, 5.95648);
case 1049: return new CityInfo("Hurwenen", "03", 51.81083, 5.31667);
case 1050: return new CityInfo("Hummelo", "03", 52.00417, 6.23333);
case 1051: return new CityInfo("Hulst", "10", 51.28, 4.05278);
case 1052: return new CityInfo("Hulshorst", "03", 52.36333, 5.73194);
case 1053: return new CityInfo("Hulsen", "15", 52.37917, 6.47361);
case 1054: return new CityInfo("Hulsel", "06", 51.38833, 5.17778);
case 1055: return new CityInfo("Hulsdonk", "06", 51.52529, 4.44277);
case 1056: return new CityInfo("Hulsberg", "05", 50.88917, 5.85556);
case 1057: return new CityInfo("Huizen", "07", 52.29917, 5.24167);
case 1058: return new CityInfo("Huizum", "02", 53.1917, 5.81119);
case 1059: return new CityInfo("Huijbergen", "06", 51.4325, 4.37639);
case 1060: return new CityInfo("Houtigehage", "02", 53.15202, 6.14524);
case 1061: return new CityInfo("Houthem", "05", 50.8725, 5.79306);
case 1062: return new CityInfo("Houten", "09", 52.02833, 5.16806);
case 1063: return new CityInfo("Horstermeer", "07", 52.25, 5.07778);
case 1064: return new CityInfo("Horssen", "03", 51.85583, 5.60972);
case 1065: return new CityInfo("Hoornsterzwaag", "02", 52.99857, 6.1726);
case 1066: return new CityInfo("Hopel", "05", 50.89245, 6.05046);
case 1067: return new CityInfo("Hoorn", "07", 52.6425, 5.05972);
case 1068: return new CityInfo("Hoogwoud", "07", 52.71583, 4.93889);
case 1069: return new CityInfo("Hoogvliet", "11", 51.86333, 4.3625);
case 1070: return new CityInfo("Hoogmade", "11", 52.16917, 4.58194);
case 1071: return new CityInfo("Hoogland", "09", 52.1825, 5.37361);
case 1072: return new CityInfo("Hooghalen", "01", 52.92083, 6.53889);
case 1073: return new CityInfo("Hooge Zwaluwe", "06", 51.6875, 4.74444);
case 1074: return new CityInfo("Hoogezand", "04", 53.16167, 6.76111);
case 1075: return new CityInfo("Hoogeveen", "01", 52.7225, 6.47639);
case 1076: return new CityInfo("Hoogerheide", "06", 51.42417, 4.325);
case 1077: return new CityInfo("Hooge Mierde", "06", 51.3875, 5.12917);
case 1078: return new CityInfo("Hoogeloon", "06", 51.3975, 5.26806);
case 1079: return new CityInfo("Hoogbraak", "06", 51.44819, 4.91867);
case 1080: return new CityInfo("Hoogblokland", "11", 51.875, 4.97639);
case 1081: return new CityInfo("Hoofdplaat", "10", 51.36917, 3.6625);
case 1082: return new CityInfo("Hoofddorp", "07", 52.3025, 4.68889);
case 1083: return new CityInfo("Honselersdijk", "11", 52.00665, 4.22441);
case 1084: return new CityInfo("Hommerts", "02", 52.98026, 5.64963);
case 1085: return new CityInfo("Hommert", "05", 50.93583, 5.91528);
case 1086: return new CityInfo("Holz", "05", 50.86415, 6.07424);
case 1087: return new CityInfo("Holwierde", "04", 53.35833, 6.87361);
case 1088: return new CityInfo("Holwerd", "02", 53.36815, 5.90073);
case 1089: return new CityInfo("Holtum", "05", 51.0475, 5.82222);
case 1090: return new CityInfo("Hollum", "02", 53.4394, 5.63805);
case 1091: return new CityInfo("Hollandsche Rading", "09", 52.175, 5.17778);
case 1092: return new CityInfo("Hoge Mors", "11", 52.15616, 4.46025);
case 1093: return new CityInfo("Hoge Enk", "03", 52.43, 5.84167);
case 1094: return new CityInfo("Hoge Vucht", "06", 51.60794, 4.7915);
case 1095: return new CityInfo("Hofgeest", "07", 52.44333, 4.65833);
case 1096: return new CityInfo("Hoeven", "06", 51.67206, 5.63444);
case 1097: return new CityInfo("Hoeven", "06", 51.57917, 4.58333);
case 1098: return new CityInfo("Hoensbroek", "05", 50.92387, 5.92528);
case 1099: return new CityInfo("Hoenderloo", "03", 52.1175, 5.87917);
case 1100: return new CityInfo("Hoek van Holland", "11", 51.9775, 4.13333);
case 1101: return new CityInfo("Hippolytushoef", "07", 52.9075, 4.9625);
case 1102: return new CityInfo("Hingen", "05", 51.105, 5.89861);
case 1103: return new CityInfo("Hindeloopen", "02", 52.94212, 5.40081);
case 1104: return new CityInfo("Hilversumse Meent", "07", 52.27115, 5.13729);
case 1105: return new CityInfo("Hilversum", "07", 52.22333, 5.17639);
case 1106: return new CityInfo("Hilvarenbeek", "06", 51.48583, 5.1375);
case 1107: return new CityInfo("Hillegom", "11", 52.29083, 4.58333);
case 1108: return new CityInfo("Hijken", "01", 52.895, 6.49722);
case 1109: return new CityInfo("Heythuysen", "05", 51.25, 5.89861);
case 1110: return new CityInfo("Heveadorp", "03", 51.975, 5.8125);
case 1111: return new CityInfo("Heusdenhout", "06", 51.58811, 4.8193);
case 1112: return new CityInfo("Heusden", "06", 51.73417, 5.13889);
case 1113: return new CityInfo("Heusden", "06", 51.38417, 5.76389);
case 1114: return new CityInfo("Heumen", "03", 51.765, 5.84444);
case 1115: return new CityInfo("Heugem", "05", 50.82791, 5.70774);
case 1116: return new CityInfo("Het Oostrik", "15", 52.25, 6.21667);
case 1117: return new CityInfo("Het Loo", "03", 52.2339, 5.95275);
case 1118: return new CityInfo("Heteren", "03", 51.95667, 5.75556);
case 1119: return new CityInfo("Herwijnen", "03", 51.82667, 5.12917);
case 1120: return new CityInfo("Herwen", "03", 51.885, 6.1);
case 1121: return new CityInfo("Herten", "05", 51.18083, 5.9625);
case 1122: return new CityInfo("Herpt", "06", 51.72917, 5.15556);
case 1123: return new CityInfo("Herpen", "06", 51.77167, 5.64167);
case 1124: return new CityInfo("Hernen", "03", 51.83417, 5.68056);
case 1125: return new CityInfo("Herkenbosch", "05", 51.15333, 6.06389);
case 1126: return new CityInfo("Hensbroek", "07", 52.65833, 4.88472);
case 1127: return new CityInfo("Hengstdal", "03", 51.83333, 5.88333);
case 1128: return new CityInfo("Hengevelde", "15", 52.19917, 6.63611);
case 1129: return new CityInfo("Hengelo", "15", 52.26583, 6.79306);
case 1130: return new CityInfo("Hengelo", "03", 52.05083, 6.30972);
case 1131: return new CityInfo("Hendrik-Ido-Ambacht", "11", 51.84417, 4.63889);
case 1132: return new CityInfo("Hemelum", "02", 52.88084, 5.45626);
case 1133: return new CityInfo("Hem", "07", 52.66083, 5.18333);
case 1134: return new CityInfo("Helwijk", "06", 51.67583, 4.43194);
case 1135: return new CityInfo("Helvoirt", "06", 51.63167, 5.23056);
case 1136: return new CityInfo("Helpman", "04", 53.19794, 6.57978);
case 1137: return new CityInfo("Helmond", "06", 51.48167, 5.66111);
case 1138: return new CityInfo("Hellum", "04", 53.23833, 6.83889);
case 1139: return new CityInfo("Hellouw", "03", 51.82667, 5.17639);
case 1140: return new CityInfo("Hellevoetsluis", "11", 51.83333, 4.13333);
case 1141: return new CityInfo("Hellendoorn", "15", 52.38833, 6.45139);
case 1142: return new CityInfo("Helenaveen", "06", 51.39, 5.91667);
case 1143: return new CityInfo("Helden", "05", 51.31917, 6);
case 1144: return new CityInfo("Heksenberg", "05", 50.92068, 5.97373);
case 1145: return new CityInfo("Heino", "15", 52.43661, 6.23282);
case 1146: return new CityInfo("Heinenoord", "11", 51.82602, 4.47659);
case 1147: return new CityInfo("Heiloo", "07", 52.60252, 4.68815);
case 1148: return new CityInfo("Heilig Landstichting", "03", 51.81917, 5.88333);
case 1149: return new CityInfo("Heiligerlee", "04", 53.15667, 7.00972);
case 1150: return new CityInfo("Heijplaat", "11", 51.89333, 4.42083);
case 1151: return new CityInfo("Heijningen", "06", 51.65583, 4.40833);
case 1152: return new CityInfo("Heijen", "05", 51.675, 5.98056);
case 1153: return new CityInfo("Heihoek", "06", 51.75921, 5.49849);
case 1154: return new CityInfo("Heide", "05", 51.24083, 6.04306);
case 1155: return new CityInfo("Heide", "05", 51.06833, 5.87222);
case 1156: return new CityInfo("Hegelsom", "05", 51.43917, 6.03889);
case 1157: return new CityInfo("Heeze", "06", 51.3828, 5.57145);
case 1158: return new CityInfo("Heeswijk", "09", 52.05167, 4.96944);
case 1159: return new CityInfo("Heeswijk-Dinther", "06", 51.65083, 5.475);
case 1160: return new CityInfo("Heesterakker", "06", 51.4861, 5.49681);
case 1161: return new CityInfo("Heeseind", "06", 51.73569, 5.4221);
case 1162: return new CityInfo("Heesch", "06", 51.73362, 5.52672);
case 1163: return new CityInfo("Hees", "03", 51.84136, 5.82846);
case 1164: return new CityInfo("Heerlen", "05", 50.88365, 5.98154);
case 1165: return new CityInfo("Heerle", "06", 51.51917, 4.35972);
case 1166: return new CityInfo("Heerjansdam", "11", 51.83583, 4.56389);
case 1167: return new CityInfo("Heerhugowaard", "07", 52.67144, 4.84862);
case 1168: return new CityInfo("Heerewaarden", "03", 51.81769, 5.393);
case 1169: return new CityInfo("Heerenveen", "02", 52.95929, 5.91854);
case 1170: return new CityInfo("Heerde", "03", 52.38723, 6.04016);
case 1171: return new CityInfo("Heer", "05", 50.83836, 5.72989);
case 1172: return new CityInfo("Heenweg", "11", 51.98167, 4.18056);
case 1173: return new CityInfo("Heemstede", "07", 52.34992, 4.62301);
case 1174: return new CityInfo("Heemskerkerduin", "07", 52.5075, 4.63194);
case 1175: return new CityInfo("Heemskerk", "07", 52.51108, 4.67165);
case 1176: return new CityInfo("Heelsum", "03", 51.98417, 5.75833);
case 1177: return new CityInfo("Heel", "05", 51.17917, 5.89444);
case 1178: return new CityInfo("Heeg", "02", 52.9686, 5.61075);
case 1179: return new CityInfo("Heechterp", "02", 53.20963, 5.8225);
case 1180: return new CityInfo("Hedel", "03", 51.74802, 5.26134);
case 1181: return new CityInfo("Havelte", "01", 52.76941, 6.24015);
case 1182: return new CityInfo("Hauwert", "07", 52.70833, 5.1);
case 1183: return new CityInfo("Haulerwijk", "02", 53.06468, 6.33453);
case 1184: return new CityInfo("Hattemerbroek", "03", 52.47417, 6.02222);
case 1185: return new CityInfo("Hattem", "03", 52.475, 6.06389);
case 1186: return new CityInfo("Hatert", "03", 51.80635, 5.83057);
case 1187: return new CityInfo("Hasselt", "15", 52.59267, 6.09527);
case 1188: return new CityInfo("Haskerhorne", "02", 52.95351, 5.82941);
case 1189: return new CityInfo("Harskamp", "03", 52.13, 5.75278);
case 1190: return new CityInfo("Harlingen", "02", 53.17477, 5.42244);
case 1191: return new CityInfo("Harkstede", "04", 53.21333, 6.69861);
case 1192: return new CityInfo("Harkema", "02", 53.18333, 6.13333);
case 1193: return new CityInfo("Harfsen", "03", 52.2075, 6.29722);
case 1194: return new CityInfo("Harenkarspel", "07", 52.73416, 4.77682);
case 1195: return new CityInfo("Haren", "04", 53.17209, 6.60931);
case 1196: return new CityInfo("Haren", "06", 51.80167, 5.58472);
case 1197: return new CityInfo("Harderwijk", "03", 52.34167, 5.62083);
case 1198: return new CityInfo("Hardenberg", "15", 52.57583, 6.61944);
case 1199: return new CityInfo("Hurdegaryp", "02", 53.21333, 5.94137);
case 1200: return new CityInfo("Haps", "06", 51.68917, 5.86111);
case 1201: return new CityInfo("Hapert", "06", 51.36833, 5.25694);
case 1202: return new CityInfo("Handel", "06", 51.58, 5.70972);
case 1203: return new CityInfo("Halsteren", "06", 51.52834, 4.26785);
case 1204: return new CityInfo("Hallum", "02", 53.30657, 5.78379);
case 1205: return new CityInfo("Halle", "03", 51.98917, 6.42917);
case 1206: return new CityInfo("Halfweg", "07", 52.52417, 4.92778);
case 1207: return new CityInfo("Halfweg", "07", 52.3825, 4.75417);
case 1208: return new CityInfo("Hagestein", "09", 51.98083, 5.12222);
case 1209: return new CityInfo("Haelen", "05", 51.23583, 5.95694);
case 1210: return new CityInfo("Haastrecht", "11", 52.00074, 4.77639);
case 1211: return new CityInfo("Haarsteeg", "06", 51.71167, 5.19861);
case 1212: return new CityInfo("Haarlem", "07", 52.38084, 4.63683);
case 1213: return new CityInfo("Haarle", "15", 52.35917, 6.38056);
case 1214: return new CityInfo("Haaren", "06", 51.6025, 5.22222);
case 1215: return new CityInfo("Haanrade", "05", 50.87981, 6.07411);
case 1216: return new CityInfo("Haamstede", "10", 51.69682, 3.74299);
case 1217: return new CityInfo("Haalderen", "03", 51.8875, 5.92917);
case 1218: return new CityInfo("Haaksbergen", "15", 52.15667, 6.73889);
case 1219: return new CityInfo("Haaften", "03", 51.81583, 5.21111);
case 1220: return new CityInfo("Guttecoven", "05", 51.015, 5.81806);
case 1221: return new CityInfo("Gulpen", "05", 50.81583, 5.88889);
case 1222: return new CityInfo("Grou", "02", 53.09456, 5.83745);
case 1223: return new CityInfo("Grootschermer", "07", 52.5825, 4.85);
case 1224: return new CityInfo("Groot IJsselmonde", "11", 51.88264, 4.54937);
case 1225: return new CityInfo("Grootegast", "04", 53.2125, 6.27361);
case 1226: return new CityInfo("Groot-Ammers", "11", 51.92333, 4.82361);
case 1227: return new CityInfo("Gronsveld", "05", 50.81083, 5.73056);
case 1228: return new CityInfo("Groningen", "04", 53.21917, 6.56667);
case 1229: return new CityInfo("Grolloo", "01", 52.935, 6.67222);
case 1230: return new CityInfo("Groessen", "03", 51.93167, 6.02639);
case 1231: return new CityInfo("Groeseind", "06", 51.57551, 5.08628);
case 1232: return new CityInfo("Groesbeek", "03", 51.77667, 5.93611);
case 1233: return new CityInfo("Groenstraat", "05", 50.9095, 6.04896);
case 1234: return new CityInfo("Groenewoud", "06", 51.5386, 5.09028);
case 1235: return new CityInfo("Groenekan", "09", 52.12333, 5.15278);
case 1236: return new CityInfo("Groede", "10", 51.37833, 3.50694);
case 1237: return new CityInfo("Grijpskerke", "10", 51.53417, 3.56111);
case 1238: return new CityInfo("Grijpskerk", "04", 53.2625, 6.30833);
case 1239: return new CityInfo("Griffioen", "10", 51.50548, 3.59598);
case 1240: return new CityInfo("Grevenbicht", "05", 51.03833, 5.775);
case 1241: return new CityInfo("Grave", "06", 51.75902, 5.73882);
case 1242: return new CityInfo("Grashoek", "05", 51.36083, 5.94306);
case 1243: return new CityInfo("Graft", "07", 52.56083, 4.83056);
case 1244: return new CityInfo("Grafhorst", "15", 52.5825, 5.93333);
case 1245: return new CityInfo("Gracht", "05", 50.85175, 6.02793);
case 1246: return new CityInfo("Graaf", "09", 51.98083, 4.97917);
case 1247: return new CityInfo("Gouwsluis", "11", 52.11943, 4.66899);
case 1248: return new CityInfo("Goutum", "02", 53.17734, 5.8037);
case 1249: return new CityInfo("Goudswaard", "11", 51.79417, 4.27639);
case 1250: return new CityInfo("Gouderak", "11", 51.98417, 4.67778);
case 1251: return new CityInfo("Gouda", "11", 52.01667, 4.70833);
case 1252: return new CityInfo("Gorssel", "03", 52.20167, 6.20139);
case 1253: return new CityInfo("Gorredijk", "02", 53.00659, 6.06402);
case 1254: return new CityInfo("Gorinchem", "11", 51.83652, 4.97243);
case 1255: return new CityInfo("Goor", "15", 52.23333, 6.58611);
case 1256: return new CityInfo("Goirle", "06", 51.52083, 5.06667);
case 1257: return new CityInfo("Goes", "10", 51.50417, 3.88889);
case 1258: return new CityInfo("Goedereede", "11", 51.8175, 3.98056);
case 1259: return new CityInfo("Glimmen", "04", 53.13917, 6.62917);
case 1260: return new CityInfo("Ginneken", "06", 51.56593, 4.7931);
case 1261: return new CityInfo("Gilze", "06", 51.54417, 4.94028);
case 1262: return new CityInfo("Giethoorn", "15", 52.74, 6.07917);
case 1263: return new CityInfo("Gieterveen", "01", 53.0275, 6.8375);
case 1264: return new CityInfo("Gieten", "01", 53.005, 6.76389);
case 1265: return new CityInfo("Giessendam", "11", 51.83257, 4.83583);
case 1266: return new CityInfo("Giessenburg", "11", 51.85083, 4.89028);
case 1267: return new CityInfo("Giessen", "06", 51.79, 5.03056);
case 1268: return new CityInfo("Giesbeek", "03", 51.99333, 6.06667);
case 1269: return new CityInfo("Gytsjerk", "02", 53.24293, 5.89502);
case 1270: return new CityInfo("Gerwen", "06", 51.49, 5.5625);
case 1271: return new CityInfo("Gerkesklooster", "02", 53.23794, 6.20367);
case 1272: return new CityInfo("Genoenhuis", "06", 51.40917, 5.53889);
case 1273: return new CityInfo("Gennep", "05", 51.69833, 5.97361);
case 1274: return new CityInfo("Gendt", "03", 51.8775, 5.97083);
case 1275: return new CityInfo("Gendringen", "03", 51.87333, 6.37639);
case 1276: return new CityInfo("Genderen", "06", 51.73583, 5.0875);
case 1277: return new CityInfo("Gemonde", "06", 51.61833, 5.35694);
case 1278: return new CityInfo("Gemert", "06", 51.55583, 5.69028);
case 1279: return new CityInfo("Geleen", "05", 50.97417, 5.82917);
case 1280: return new CityInfo("Geldrop", "06", 51.42167, 5.55972);
case 1281: return new CityInfo("Geldermalsen-West", "03", 51.87968, 5.28015);
case 1282: return new CityInfo("Geldermalsen", "03", 51.88083, 5.28889);
case 1283: return new CityInfo("Geitenkamp", "03", 52.00379, 5.93862);
case 1284: return new CityInfo("Geffen", "06", 51.74, 5.46389);
case 1285: return new CityInfo("Geesteren", "03", 52.13917, 6.52639);
case 1286: return new CityInfo("Geesbrug", "01", 52.72667, 6.63333);
case 1287: return new CityInfo("Gees", "01", 52.74741, 6.68879);
case 1288: return new CityInfo("Geertruidenberg", "06", 51.70167, 4.85694);
case 1289: return new CityInfo("Geenhoven", "06", 51.35935, 5.46021);
case 1290: return new CityInfo("Gastel", "06", 51.28583, 5.55556);
case 1291: return new CityInfo("Gasselternijveenschemond", "01", 52.99454, 6.89821);
case 1292: return new CityInfo("Gasselternijveen", "01", 52.98833, 6.85278);
case 1293: return new CityInfo("Gasselte", "01", 52.97167, 6.79444);
case 1294: return new CityInfo("Garyp", "02", 53.16667, 5.96667);
case 1295: return new CityInfo("Garderen", "03", 52.23083, 5.71389);
case 1296: return new CityInfo("Gameren", "03", 51.80083, 5.20417);
case 1297: return new CityInfo("Galder", "06", 51.515, 4.77639);
case 1298: return new CityInfo("Gageldonk", "06", 51.60167, 4.73889);
case 1299: return new CityInfo("Froombosch", "04", 53.19417, 6.78056);
case 1300: return new CityInfo("Frieschepalen", "02", 53.10938, 6.20642);
case 1301: return new CityInfo("Frankhuis", "15", 52.525, 6.06806);
case 1302: return new CityInfo("Franeker", "02", 53.18546, 5.54123);
case 1303: return new CityInfo("Foxhol", "04", 53.16741, 6.72183);
case 1304: return new CityInfo("Flevowijk", "15", 52.54583, 5.91338);
case 1305: return new CityInfo("Fijnaart", "06", 51.6375, 4.46944);
case 1306: return new CityInfo("Ferwert", "02", 53.33784, 5.82533);
case 1307: return new CityInfo("Feijenoord", "11", 51.91169, 4.50645);
case 1308: return new CityInfo("Farmsum", "04", 53.32167, 6.92639);
case 1309: return new CityInfo("Ezinge", "04", 53.31, 6.44167);
case 1310: return new CityInfo("Exloo", "01", 52.8825, 6.86389);
case 1311: return new CityInfo("Everdingen", "09", 51.965, 5.15556);
case 1312: return new CityInfo("Etten", "03", 51.91667, 6.33611);
case 1313: return new CityInfo("Essesteijn", "11", 52.08534, 4.37263);
case 1314: return new CityInfo("Esch", "06", 51.61083, 5.29028);
case 1315: return new CityInfo("Esbeek", "06", 51.46167, 5.1375);
case 1316: return new CityInfo("Erp", "06", 51.6, 5.60694);
case 1317: return new CityInfo("Ermelo", "03", 52.29833, 5.62222);
case 1318: return new CityInfo("Epse", "03", 52.225, 6.2);
case 1319: return new CityInfo("Epen", "05", 50.77583, 5.91111);
case 1320: return new CityInfo("Epe", "03", 52.3475, 5.98333);
case 1321: return new CityInfo("Enschot", "06", 51.57846, 5.13885);
case 1322: return new CityInfo("Enschede", "15", 52.21833, 6.89583);
case 1323: return new CityInfo("Ens", "16", 52.63667, 5.82778);
case 1324: return new CityInfo("Enkhuizen", "07", 52.70333, 5.29167);
case 1325: return new CityInfo("Engelbert", "04", 53.20833, 6.64722);
case 1326: return new CityInfo("Emst", "03", 52.31583, 5.97361);
case 1327: return new CityInfo("Empe", "03", 52.15583, 6.13889);
case 1328: return new CityInfo("Emmerschans", "01", 52.80083, 6.93889);
case 1329: return new CityInfo("Emmermeer", "01", 52.80071, 6.89315);
case 1330: return new CityInfo("Emmerhout", "01", 52.78755, 6.93881);
case 1331: return new CityInfo("Emmer-Erfscheidenveen", "01", 52.80667, 6.98889);
case 1332: return new CityInfo("Emmer-Compascuum", "01", 52.81167, 7.04722);
case 1333: return new CityInfo("Emmen", "01", 52.77917, 6.90694);
case 1334: return new CityInfo("Emmeloord", "16", 52.71083, 5.74861);
case 1335: return new CityInfo("Elst", "03", 51.91917, 5.84167);
case 1336: return new CityInfo("Elspeet", "03", 52.29167, 5.78889);
case 1337: return new CityInfo("Elsloo", "05", 50.94917, 5.77083);
case 1338: return new CityInfo("Elshout", "06", 51.70083, 5.14167);
case 1339: return new CityInfo("Elshof", "15", 52.39333, 6.2);
case 1340: return new CityInfo("Elsendorp", "06", 51.58083, 5.76944);
case 1341: return new CityInfo("Elsen", "15", 52.27, 6.53889);
case 1342: return new CityInfo("Ellecom", "03", 52.0325, 6.0875);
case 1343: return new CityInfo("Elden", "03", 51.95833, 5.88194);
case 1344: return new CityInfo("Elburg", "03", 52.4475, 5.84306);
case 1345: return new CityInfo("Ekenrooi", "06", 51.39656, 5.48624);
case 1346: return new CityInfo("Einighausen", "05", 51.00167, 5.82778);
case 1347: return new CityInfo("Eindhoven", "06", 51.44083, 5.47778);
case 1348: return new CityInfo("Eikenheuvel", "06", 51.63917, 5.61111);
case 1349: return new CityInfo("Eijsden", "05", 50.78, 5.7177);
case 1350: return new CityInfo("Eibergen", "03", 52.1, 6.64861);
case 1351: return new CityInfo("Egmond-Binnen", "07", 52.59583, 4.65556);
case 1352: return new CityInfo("Egmond aan Zee", "07", 52.6204, 4.62705);
case 1353: return new CityInfo("Egchel", "05", 51.31417, 5.97222);
case 1354: return new CityInfo("Eexta", "04", 53.16386, 6.98344);
case 1355: return new CityInfo("Eext", "01", 53.0175, 6.73472);
case 1356: return new CityInfo("Eethen", "06", 51.7325, 5.05278);
case 1357: return new CityInfo("Jistrum", "02", 53.21158, 6.06668);
case 1358: return new CityInfo("Eersel", "06", 51.3575, 5.31806);
case 1359: return new CityInfo("Eerschot", "06", 51.56833, 5.47361);
case 1360: return new CityInfo("Eerde", "06", 51.60417, 5.49861);
case 1361: return new CityInfo("Eerbeek", "03", 52.105, 6.05833);
case 1362: return new CityInfo("Eenrum", "04", 53.3625, 6.45833);
case 1363: return new CityInfo("Eeneind", "06", 51.45167, 5.54722);
case 1364: return new CityInfo("Een", "01", 53.07667, 6.39583);
case 1365: return new CityInfo("Eemnes", "09", 52.25417, 5.26111);
case 1366: return new CityInfo("Eemdijk", "09", 52.255, 5.33056);
case 1367: return new CityInfo("Eelde", "01", 53.13583, 6.5625);
case 1368: return new CityInfo("Eefde", "03", 52.16667, 6.225);
case 1369: return new CityInfo("Eede", "10", 51.2475, 3.44306);
case 1370: return new CityInfo("Ee", "02", 53.33026, 6.10033);
case 1371: return new CityInfo("Ederveen", "03", 52.06333, 5.57778);
case 1372: return new CityInfo("Ede", "03", 52.03333, 5.65833);
case 1373: return new CityInfo("Edam", "07", 52.51215, 5.04805);
case 1374: return new CityInfo("Eck en Wiel", "03", 51.96917, 5.45694);
case 1375: return new CityInfo("Eckelrade", "05", 50.8075, 5.76528);
case 1376: return new CityInfo("Eckart", "06", 51.4732, 5.49449);
case 1377: return new CityInfo("Echtenerbrug", "02", 52.87141, 5.82147);
case 1378: return new CityInfo("Echteld", "03", 51.91, 5.49583);
case 1379: return new CityInfo("Dwingeloo", "01", 52.83417, 6.36944);
case 1380: return new CityInfo("Duizel", "06", 51.36833, 5.29722);
case 1381: return new CityInfo("Duivendrecht", "07", 52.32941, 4.93964);
case 1382: return new CityInfo("Duiven", "03", 51.94667, 6.01389);
case 1383: return new CityInfo("Duinzigt", "11", 52.10485, 4.32494);
case 1384: return new CityInfo("Duindorp", "11", 52.09078, 4.26038);
case 1385: return new CityInfo("Druten", "03", 51.88833, 5.60556);
case 1386: return new CityInfo("Drumpt", "03", 51.897, 5.41043);
case 1387: return new CityInfo("Drouwenermond", "01", 52.97833, 6.90556);
case 1388: return new CityInfo("Dronten", "16", 52.525, 5.71806);
case 1389: return new CityInfo("Dronryp", "02", 53.2, 5.65);
case 1390: return new CityInfo("Drogeham", "02", 53.20213, 6.11183);
case 1391: return new CityInfo("Driewegen", "10", 51.41833, 3.80278);
case 1392: return new CityInfo("Driezum", "02", 53.2959, 6.04609);
case 1393: return new CityInfo("Driemond", "07", 52.30583, 5.01667);
case 1394: return new CityInfo("Driemanspolder", "11", 52.05176, 4.48504);
case 1395: return new CityInfo("Driel", "03", 51.95917, 5.81389);
case 1396: return new CityInfo("Driehuizen", "03", 52.20879, 5.94442);
case 1397: return new CityInfo("Driebruggen", "11", 52.04417, 4.8);
case 1398: return new CityInfo("Driebergen-Rijsenburg", "09", 52.05333, 5.28056);
case 1399: return new CityInfo("Drempt", "03", 52.0075, 6.175);
case 1400: return new CityInfo("Dreischor", "10", 51.69, 3.98333);
case 1401: return new CityInfo("Drachtstercompagnie", "02", 53.13462, 6.14153);
case 1402: return new CityInfo("Drachten", "02", 53.11254, 6.0989);
case 1403: return new CityInfo("Dorst", "06", 51.59, 4.85694);
case 1404: return new CityInfo("Dordrecht", "11", 51.81, 4.67361);
case 1405: return new CityInfo("Doorwerth", "03", 51.97917, 5.79722);
case 1406: return new CityInfo("Doornsteeg", "03", 52.23, 5.45417);
case 1407: return new CityInfo("Doornspijk", "03", 52.41833, 5.81806);
case 1408: return new CityInfo("Doornenburg", "03", 51.89, 6);
case 1409: return new CityInfo("Doorn", "09", 52.03343, 5.34571);
case 1410: return new CityInfo("Doonheide", "06", 51.56667, 5.69444);
case 1411: return new CityInfo("Donkerbroek", "02", 53.01734, 6.23927);
case 1412: return new CityInfo("Donk", "06", 51.53843, 5.62914);
case 1413: return new CityInfo("Dongen", "06", 51.62667, 4.93889);
case 1414: return new CityInfo("Dommelen", "06", 51.34624, 5.43394);
case 1415: return new CityInfo("Domburg", "10", 51.56333, 3.49583);
case 1416: return new CityInfo("Dolphia", "15", 52.21901, 6.94583);
case 1417: return new CityInfo("Dokkum", "02", 53.32224, 5.99697);
case 1418: return new CityInfo("Doezum", "04", 53.20083, 6.24861);
case 1419: return new CityInfo("Doetinchem", "03", 51.965, 6.28889);
case 1420: return new CityInfo("Doesburg", "03", 52.06667, 5.61667);
case 1421: return new CityInfo("Doesburg", "03", 52.0125, 6.13889);
case 1422: return new CityInfo("Doenrade", "05", 50.9675, 5.90694);
case 1423: return new CityInfo("Dirksland", "11", 51.74917, 4.1);
case 1424: return new CityInfo("Dirkshorn", "07", 52.75, 4.775);
case 1425: return new CityInfo("Dinteloord", "06", 51.635, 4.36944);
case 1426: return new CityInfo("Diever", "01", 52.85417, 6.31806);
case 1427: return new CityInfo("Dieteren", "05", 51.07667, 5.84583);
case 1428: return new CityInfo("Diessen", "06", 51.47583, 5.175);
case 1429: return new CityInfo("Dieren", "03", 52.0525, 6.1);
case 1430: return new CityInfo("Diepswal", "04", 53.15, 6.36944);
case 1431: return new CityInfo("Diepenheim", "15", 52.2, 6.55556);
case 1432: return new CityInfo("Diemen", "07", 52.33964, 4.96256);
case 1433: return new CityInfo("De Wilgen", "02", 53.09936, 6.0341);
case 1434: return new CityInfo("De Wijk", "01", 52.67333, 6.29028);
case 1435: return new CityInfo("De Wijert", "04", 53.1945, 6.57117);
case 1436: return new CityInfo("De Weere", "07", 52.72667, 4.99444);
case 1437: return new CityInfo("Deventer", "15", 52.255, 6.16389);
case 1438: return new CityInfo("Deuteren", "06", 51.68667, 5.26667);
case 1439: return new CityInfo("De Uithof", "09", 52.08526, 5.17456);
case 1440: return new CityInfo("De Steeg", "03", 52.02, 6.06111);
case 1441: return new CityInfo("De Rompert", "06", 51.71667, 5.31667);
case 1442: return new CityInfo("De Rijp", "07", 52.55667, 4.84583);
case 1443: return new CityInfo("De Reit", "06", 51.56038, 5.04932);
case 1444: return new CityInfo("De Peulen", "11", 51.82362, 4.82165);
case 1445: return new CityInfo("De Noord", "07", 52.7075, 4.85139);
case 1446: return new CityInfo("Den Oever", "07", 52.93353, 5.03079);
case 1447: return new CityInfo("Den Ilp", "07", 52.45417, 4.90694);
case 1448: return new CityInfo("Den Hout", "06", 51.6575, 4.8125);
case 1449: return new CityInfo("Den Helder", "07", 52.95988, 4.75933);
case 1450: return new CityInfo("Den Ham", "15", 52.46583, 6.49583);
case 1451: return new CityInfo("Den Dungen", "06", 51.665, 5.37222);
case 1452: return new CityInfo("Den Burg", "07", 53.05417, 4.79722);
case 1453: return new CityInfo("De Moer", "06", 51.62417, 5.0125);
case 1454: return new CityInfo("De Mheen", "03", 52.21954, 5.99141);
case 1455: return new CityInfo("De Maer", "07", 52.51901, 4.68171);
case 1456: return new CityInfo("De Loo", "01", 52.67167, 6.73967);
case 1457: return new CityInfo("De Lier", "11", 51.975, 4.24861);
case 1458: return new CityInfo("Delfzijl", "04", 53.33, 6.91806);
case 1459: return new CityInfo("Delft", "11", 52.00667, 4.35556);
case 1460: return new CityInfo("Delfshaven", "11", 51.90488, 4.45315);
case 1461: return new CityInfo("Delden", "15", 52.26, 6.71111);
case 1462: return new CityInfo("De Kwakel", "07", 52.23917, 4.79306);
case 1463: return new CityInfo("De Kruiskamp", "06", 51.69978, 5.26032);
case 1464: return new CityInfo("De Koog", "07", 53.0975, 4.76111);
case 1465: return new CityInfo("De Klomp", "03", 52.04658, 5.57247);
case 1466: return new CityInfo("De Kieviet", "11", 52.12333, 4.35839);
case 1467: return new CityInfo("Deinum", "02", 53.19182, 5.72431);
case 1468: return new CityInfo("Deil", "03", 51.88417, 5.24306);
case 1469: return new CityInfo("De Hoven", "15", 52.24901, 6.14367);
case 1470: return new CityInfo("De Horst", "03", 51.77417, 5.96806);
case 1471: return new CityInfo("De Heeg", "05", 50.82454, 5.72309);
case 1472: return new CityInfo("De Hagen", "09", 51.99381, 5.10263);
case 1473: return new CityInfo("De Greiden", "02", 52.9496, 5.91366);
case 1474: return new CityInfo("De Goorn", "07", 52.62583, 4.94722);
case 1475: return new CityInfo("De Glip", "07", 52.33083, 4.61111);
case 1476: return new CityInfo("Deest", "03", 51.89, 5.66667);
case 1477: return new CityInfo("De Engel", "11", 52.24167, 4.5375);
case 1478: return new CityInfo("De Drait", "02", 53.09743, 6.06791);
case 1479: return new CityInfo("De Doornakkers", "06", 51.43844, 5.50887);
case 1480: return new CityInfo("De Domp", "02", 53.03113, 5.67716);
case 1481: return new CityInfo("De Cocksdorp", "07", 53.15667, 4.87083);
case 1482: return new CityInfo("De Blesse", "02", 52.8428, 6.04111);
case 1483: return new CityInfo("De Blaak", "06", 51.54626, 5.04465);
case 1484: return new CityInfo("De Bilt", "09", 52.11, 5.18056);
case 1485: return new CityInfo("Dauwendaele", "10", 51.49299, 3.62624);
case 1486: return new CityInfo("Darp", "01", 52.775, 6.20417);
case 1487: return new CityInfo("Damwâld", "02", 53.29046, 5.99785);
case 1488: return new CityInfo("Dalfsen", "15", 52.51167, 6.25694);
case 1489: return new CityInfo("Dalerpeel", "01", 52.68, 6.65972);
case 1490: return new CityInfo("Dalen", "01", 52.69917, 6.75556);
case 1491: return new CityInfo("Dalem", "11", 51.8275, 5.00972);
case 1492: return new CityInfo("Daarle", "15", 52.43417, 6.5375);
case 1493: return new CityInfo("Culemborg", "03", 51.955, 5.22778);
case 1494: return new CityInfo("Cuijk", "06", 51.73083, 5.87917);
case 1495: return new CityInfo("Cruquius", "07", 52.33583, 4.63472);
case 1496: return new CityInfo("Cromvoirt", "06", 51.66083, 5.23194);
case 1497: return new CityInfo("Cranendonck", "06", 51.30417, 5.58889);
case 1498: return new CityInfo("Cothen", "09", 51.99667, 5.30833);
case 1499: return new CityInfo("Commandeurs", "07", 52.50902, 4.65843);
case 1500: return new CityInfo("Colijnsplaat", "10", 51.59917, 3.84861);
case 1501: return new CityInfo("Coevorden", "01", 52.66103, 6.74046);
case 1502: return new CityInfo("Coevering", "06", 51.41742, 5.57463);
case 1503: return new CityInfo("Coendersborg", "04", 53.1941, 6.58944);
case 1504: return new CityInfo("Chaam", "06", 51.50583, 4.86111);
case 1505: return new CityInfo("Ceresdorp", "04", 52.96601, 6.97322);
case 1506: return new CityInfo("Catsop", "05", 50.93917, 5.76667);
case 1507: return new CityInfo("Castricum", "07", 52.54833, 4.66944);
case 1508: return new CityInfo("Casteren", "06", 51.39667, 5.2375);
case 1509: return new CityInfo("Castenray", "05", 51.48917, 6.03472);
case 1510: return new CityInfo("Carnisse", "11", 51.88932, 4.47758);
case 1511: return new CityInfo("Capelle-West", "11", 51.91667, 4.56667);
case 1512: return new CityInfo("Capelle aan den IJssel", "11", 51.92917, 4.57778);
case 1513: return new CityInfo("Callantsoog", "07", 52.84, 4.69583);
case 1514: return new CityInfo("Cabauw", "09", 51.96417, 4.89861);
case 1515: return new CityInfo("Buurmalsen", "03", 51.89167, 5.29444);
case 1516: return new CityInfo("Bussum", "07", 52.27333, 5.16111);
case 1517: return new CityInfo("Burum", "02", 53.2734, 6.22942);
case 1518: return new CityInfo("Burgh", "10", 51.68917, 3.73333);
case 1519: return new CityInfo("Burgerbrug", "07", 52.74833, 4.70278);
case 1520: return new CityInfo("Buren", "02", 53.44717, 5.79906);
case 1521: return new CityInfo("Bunschoten", "09", 52.24304, 5.37884);
case 1522: return new CityInfo("Bunnik", "09", 52.06667, 5.19861);
case 1523: return new CityInfo("Bunde", "05", 50.89667, 5.73194);
case 1524: return new CityInfo("Buitenpost", "02", 53.25166, 6.14483);
case 1525: return new CityInfo("Buinen", "01", 52.93083, 6.83611);
case 1526: return new CityInfo("Budschop", "05", 51.28511, 5.75898);
case 1527: return new CityInfo("Budel-Schoot", "06", 51.2475, 5.56528);
case 1528: return new CityInfo("Budel-Dorplein", "06", 51.23667, 5.5875);
case 1529: return new CityInfo("Budel", "06", 51.27167, 5.575);
case 1530: return new CityInfo("Buchten", "05", 51.04333, 5.80972);
case 1531: return new CityInfo("Brunssum", "05", 50.94667, 5.97083);
case 1532: return new CityInfo("Brunnepe", "15", 52.56185, 5.90343);
case 1533: return new CityInfo("Brummen", "03", 52.09, 6.15556);
case 1534: return new CityInfo("Brukske", "05", 51.52101, 5.9927);
case 1535: return new CityInfo("Bruinisse", "10", 51.66167, 4.09444);
case 1536: return new CityInfo("Bruchem", "03", 51.78667, 5.23611);
case 1537: return new CityInfo("Brouwershaven", "10", 51.72667, 3.9125);
case 1538: return new CityInfo("Broeksterwâld", "02", 53.27466, 5.99648);
case 1539: return new CityInfo("Broeksittard", "05", 51.0029, 5.89511);
case 1540: return new CityInfo("Broek op Langedijk", "07", 52.67417, 4.80556);
case 1541: return new CityInfo("Broek in Waterland", "07", 52.43417, 4.99583);
case 1542: return new CityInfo("Broekhuizenvorst", "05", 51.495, 6.15694);
case 1543: return new CityInfo("Broekhuizen", "05", 51.48583, 6.16389);
case 1544: return new CityInfo("Broekhoven", "06", 51.54801, 5.09175);
case 1545: return new CityInfo("Broekhem", "05", 50.87119, 5.82069);
case 1546: return new CityInfo("Broekerhaven", "07", 52.68833, 5.25278);
case 1547: return new CityInfo("Broekdijk", "03", 52.45, 5.93333);
case 1548: return new CityInfo("Britsum", "02", 53.25428, 5.78576);
case 1549: return new CityInfo("Brinkhorst", "03", 52.21302, 5.95167);
case 1550: return new CityInfo("Brinkhoek", "15", 52.53583, 6.12222);
case 1551: return new CityInfo("Brigdamme", "10", 51.51583, 3.60556);
case 1552: return new CityInfo("Brielle", "11", 51.90167, 4.1625);
case 1553: return new CityInfo("Breukelen", "09", 52.17417, 5.00139);
case 1554: return new CityInfo("Breugel", "06", 51.5175, 5.51111);
case 1555: return new CityInfo("Breskens", "10", 51.39583, 3.55556);
case 1556: return new CityInfo("Breezand", "07", 52.89, 4.80417);
case 1557: return new CityInfo("Bredeweg", "03", 51.76019, 5.94189);
case 1558: return new CityInfo("Bredevoort", "03", 51.94167, 6.62083);
case 1559: return new CityInfo("Breda", "06", 51.58656, 4.77596);
case 1560: return new CityInfo("Brand", "06", 51.45839, 5.62427);
case 1561: return new CityInfo("Brakkenstein", "03", 51.81324, 5.86539);
case 1562: return new CityInfo("Brakel", "03", 51.8175, 5.09028);
case 1563: return new CityInfo("Brachterbeek", "05", 51.14694, 5.90446);
case 1564: return new CityInfo("Brabander", "05", 51.53583, 5.96806);
case 1565: return new CityInfo("Braamt", "03", 51.92333, 6.26528);
case 1566: return new CityInfo("Boijl", "02", 52.90921, 6.19972);
case 1567: return new CityInfo("Boxtel", "06", 51.59083, 5.32917);
case 1568: return new CityInfo("Boxmeer", "06", 51.64667, 5.94722);
case 1569: return new CityInfo("Boven-Hardinxveld", "11", 51.82333, 4.88194);
case 1570: return new CityInfo("Boukoul", "05", 51.21583, 6.04722);
case 1571: return new CityInfo("Bosschenhoofd", "06", 51.56083, 4.54028);
case 1572: return new CityInfo("Boskoop", "11", 52.075, 4.65556);
case 1573: return new CityInfo("Boskamp", "15", 52.33083, 6.12778);
case 1574: return new CityInfo("Boskant", "06", 51.55, 5.42083);
case 1575: return new CityInfo("Bosch en Duin", "09", 52.11667, 5.24167);
case 1576: return new CityInfo("Borssele", "10", 51.42333, 3.73472);
case 1577: return new CityInfo("Bornerbroek", "15", 52.30917, 6.65417);
case 1578: return new CityInfo("Borne", "15", 52.30136, 6.7482);
case 1579: return new CityInfo("Born", "05", 51.03167, 5.80972);
case 1580: return new CityInfo("Borkel", "06", 51.2975, 5.44028);
case 1581: return new CityInfo("Borgharen", "05", 50.8775, 5.6875);
case 1582: return new CityInfo("Borger", "01", 52.92333, 6.79306);
case 1583: return new CityInfo("Borgele", "15", 52.2763, 6.14926);
case 1584: return new CityInfo("Borculo", "03", 52.11583, 6.52222);
case 1585: return new CityInfo("Boornbergum", "02", 53.08284, 6.04578);
case 1586: return new CityInfo("Bong", "05", 51.3325, 6.08056);
case 1587: return new CityInfo("Bolsward", "02", 53.06555, 5.53176);
case 1588: return new CityInfo("Bolnes", "11", 51.895, 4.57917);
case 1589: return new CityInfo("Boerdonk", "06", 51.55917, 5.625);
case 1590: return new CityInfo("Boelenslaan", "02", 53.1617, 6.14479);
case 1591: return new CityInfo("Boekend", "05", 51.37833, 6.11667);
case 1592: return new CityInfo("Boekel", "06", 51.60333, 5.675);
case 1593: return new CityInfo("Bodegraven", "11", 52.0825, 4.75);
case 1594: return new CityInfo("Bocholtzerheide", "05", 50.81583, 5.99028);
case 1595: return new CityInfo("Bocholtz", "05", 50.81833, 6.00556);
case 1596: return new CityInfo("Blokzijl", "15", 52.72667, 5.96111);
case 1597: return new CityInfo("Bloemhof", "11", 51.89723, 4.49943);
case 1598: return new CityInfo("Bloemendaal", "11", 52.02878, 4.6944);
case 1599: return new CityInfo("Bloemendaal", "07", 52.4025, 4.62222);
case 1600: return new CityInfo("Blitterswijck", "05", 51.53083, 6.10833);
case 1601: return new CityInfo("Blijham", "04", 53.10917, 7.07639);
case 1602: return new CityInfo("Blije", "02", 53.35193, 5.86138);
case 1603: return new CityInfo("Bleskensgraaf", "11", 51.8725, 4.78333);
case 1604: return new CityInfo("Bleiswijk", "11", 52.01083, 4.53194);
case 1605: return new CityInfo("Bleijerheide", "05", 50.85538, 6.06789);
case 1606: return new CityInfo("Blauwhuis", "02", 53.02134, 5.53359);
case 1607: return new CityInfo("Blaricum", "07", 52.2725, 5.24167);
case 1608: return new CityInfo("Bladel", "06", 51.36833, 5.22083);
case 1609: return new CityInfo("Blaarthem", "06", 51.42501, 5.45784);
case 1610: return new CityInfo("Bitswijk", "06", 51.6687, 5.60921);
case 1611: return new CityInfo("Burdaard", "02", 53.29421, 5.87897);
case 1612: return new CityInfo("Binnenhof", "11", 52.16418, 4.53644);
case 1613: return new CityInfo("Bingelrade", "05", 50.9761, 5.92704);
case 1614: return new CityInfo("Bilgaard", "02", 53.21551, 5.79574);
case 1615: return new CityInfo("Bijvanck", "07", 52.28585, 5.26534);
case 1616: return new CityInfo("Biggekerke", "10", 51.49917, 3.52639);
case 1617: return new CityInfo("Biezenmortel", "06", 51.62417, 5.17778);
case 1618: return new CityInfo("Biest-Houtakker", "06", 51.50667, 5.15833);
case 1619: return new CityInfo("Biesland", "05", 50.8411, 5.67573);
case 1620: return new CityInfo("Biesdonk", "06", 51.60613, 4.78515);
case 1621: return new CityInfo("Bierum", "04", 53.3825, 6.85972);
case 1622: return new CityInfo("Biddinghuizen", "16", 52.455, 5.69306);
case 1623: return new CityInfo("Beverwijk", "07", 52.48333, 4.65694);
case 1624: return new CityInfo("Beusichem", "03", 51.95, 5.29167);
case 1625: return new CityInfo("Beuningen", "03", 51.86083, 5.76667);
case 1626: return new CityInfo("Best", "06", 51.5075, 5.39028);
case 1627: return new CityInfo("Besoijen", "06", 51.68333, 5.05);
case 1628: return new CityInfo("Berltsum", "02", 53.2437, 5.65101);
case 1629: return new CityInfo("Berlicum", "06", 51.6775, 5.4);
case 1630: return new CityInfo("Berkum", "15", 52.52395, 6.13655);
case 1631: return new CityInfo("Berkhout", "07", 52.64083, 5.00139);
case 1632: return new CityInfo("Berkenwoude", "11", 51.945, 4.70694);
case 1633: return new CityInfo("Beringe", "05", 51.33667, 5.94861);
case 1634: return new CityInfo("Burgum", "02", 53.19243, 5.99009);
case 1635: return new CityInfo("Bergstoep", "11", 51.9225, 4.78472);
case 1636: return new CityInfo("Bergschenhoek", "11", 51.99, 4.49861);
case 1637: return new CityInfo("Berghem", "06", 51.76991, 5.56827);
case 1638: return new CityInfo("Bergharen", "03", 51.85083, 5.66944);
case 1639: return new CityInfo("Bergeijk", "06", 51.31917, 5.35833);
case 1640: return new CityInfo("Bergen op Zoom", "06", 51.495, 4.29167);
case 1641: return new CityInfo("Berg en Dal", "03", 51.82167, 5.91667);
case 1642: return new CityInfo("Berg en Bos", "03", 52.22009, 5.9334);
case 1643: return new CityInfo("Bergen", "07", 52.66917, 4.70417);
case 1644: return new CityInfo("Berg", "05", 51.00417, 5.77083);
case 1645: return new CityInfo("Berg", "05", 50.86167, 5.78333);
case 1646: return new CityInfo("Benthuizen", "11", 52.0775, 4.54444);
case 1647: return new CityInfo("Bentelo", "15", 52.22417, 6.68333);
case 1648: return new CityInfo("Bennekom", "03", 51.99833, 5.67639);
case 1649: return new CityInfo("Bennebroek", "07", 52.32083, 4.59861);
case 1650: return new CityInfo("Bemmel", "03", 51.89167, 5.89861);
case 1651: return new CityInfo("Belt-Schutsloot", "15", 52.67167, 6.06389);
case 1652: return new CityInfo("Beltrum", "03", 52.06667, 6.56389);
case 1653: return new CityInfo("Bellingwolde", "04", 53.11583, 7.16528);
case 1654: return new CityInfo("Belfort", "05", 50.84698, 5.65991);
case 1655: return new CityInfo("Belcrum", "06", 51.59911, 4.76994);
case 1656: return new CityInfo("Beinsdorp", "07", 52.28667, 4.59583);
case 1657: return new CityInfo("Beilen", "01", 52.86333, 6.51389);
case 1658: return new CityInfo("Beetsterzwaag", "02", 53.05914, 6.07711);
case 1659: return new CityInfo("Beets", "07", 52.58833, 4.97778);
case 1660: return new CityInfo("Beesel", "05", 51.26833, 6.03889);
case 1661: return new CityInfo("Beesd", "03", 51.8875, 5.19167);
case 1662: return new CityInfo("Beersdal", "05", 50.90597, 5.9644);
case 1663: return new CityInfo("Beers", "06", 51.72583, 5.82778);
case 1664: return new CityInfo("Beekbergen", "03", 52.16, 5.96389);
case 1665: return new CityInfo("Beek gem Montferland", "03", 51.90667, 6.1875);
case 1666: return new CityInfo("Beek", "06", 51.5289, 5.63382);
case 1667: return new CityInfo("Beek", "05", 50.94083, 5.79722);
case 1668: return new CityInfo("Beegden", "05", 51.18917, 5.91944);
case 1669: return new CityInfo("Bedum", "04", 53.30083, 6.60278);
case 1670: return new CityInfo("Bavel", "06", 51.56583, 4.83056);
case 1671: return new CityInfo("Batenburg", "03", 51.82417, 5.62917);
case 1672: return new CityInfo("Batadorp", "06", 51.4894, 5.39927);
case 1673: return new CityInfo("Barsingerhorn", "07", 52.785, 4.86389);
case 1674: return new CityInfo("Barneveld", "03", 52.14, 5.58472);
case 1675: return new CityInfo("Barger-Oosterveld", "01", 52.77, 6.95833);
case 1676: return new CityInfo("Bargeres", "01", 52.76152, 6.88145);
case 1677: return new CityInfo("Barendrecht", "11", 51.85667, 4.53472);
case 1678: return new CityInfo("Barchem", "03", 52.12417, 6.44306);
case 1679: return new CityInfo("Bantega", "02", 52.84218, 5.79597);
case 1680: return new CityInfo("Banholt", "05", 50.79, 5.80833);
case 1681: return new CityInfo("Bangert", "07", 52.73582, 5.1801);
case 1682: return new CityInfo("Ballast", "01", 52.67218, 6.73299);
case 1683: return new CityInfo("Balk", "02", 52.89756, 5.57964);
case 1684: return new CityInfo("Bakkeveen", "02", 53.08072, 6.25671);
case 1685: return new CityInfo("Bakhuizen", "02", 52.86975, 5.45926);
case 1686: return new CityInfo("Bakenberg", "03", 52.00511, 5.8771);
case 1687: return new CityInfo("Bakel", "06", 51.50333, 5.74028);
case 1688: return new CityInfo("Baflo", "04", 53.3625, 6.51389);
case 1689: return new CityInfo("Babberich", "03", 51.9075, 6.11111);
case 1690: return new CityInfo("Baarn", "09", 52.21167, 5.2875);
case 1691: return new CityInfo("Baarlo", "05", 51.33083, 6.09444);
case 1692: return new CityInfo("Baarle-Nassau", "06", 51.4475, 4.92917);
case 1693: return new CityInfo("Baardwijk", "06", 51.69246, 5.09628);
case 1694: return new CityInfo("Baambrugge", "09", 52.24583, 4.98889);
case 1695: return new CityInfo("Baalder", "15", 52.58579, 6.65299);
case 1696: return new CityInfo("Baak", "03", 52.0775, 6.22778);
case 1697: return new CityInfo("Axel", "10", 51.26667, 3.90833);
case 1698: return new CityInfo("Avenhorn", "07", 52.6175, 4.95139);
case 1699: return new CityInfo("Austerlitz", "09", 52.08, 5.31528);
case 1700: return new CityInfo("Augustinusga", "02", 53.21785, 6.1617);
case 1701: return new CityInfo("Asten", "06", 51.40417, 5.74861);
case 1702: return new CityInfo("Assen", "01", 52.99667, 6.5625);
case 1703: return new CityInfo("Asenray", "05", 51.19333, 6.04861);
case 1704: return new CityInfo("Arum", "02", 53.12952, 5.47643);
case 1705: return new CityInfo("Arnhem", "03", 51.98, 5.91111);
case 1706: return new CityInfo("Arnemuiden", "10", 51.50167, 3.675);
case 1707: return new CityInfo("Arkel", "11", 51.86417, 4.99444);
case 1708: return new CityInfo("Arensgenhout", "05", 50.88833, 5.84028);
case 1709: return new CityInfo("Arcen", "05", 51.47667, 6.18056);
case 1710: return new CityInfo("Appingedam", "04", 53.32167, 6.85833);
case 1711: return new CityInfo("Appelscha", "02", 52.95526, 6.35053);
case 1712: return new CityInfo("Appel", "03", 52.1875, 5.54028);
case 1713: return new CityInfo("Apeldoorn", "03", 52.21, 5.96944);
case 1714: return new CityInfo("Annen", "01", 53.0575, 6.71944);
case 1715: return new CityInfo("Anklaar", "03", 52.23111, 5.98497);
case 1716: return new CityInfo("Ankeveense Rade", "07", 52.25891, 5.1016);
case 1717: return new CityInfo("Anjum", "02", 53.37475, 6.12698);
case 1718: return new CityInfo("Angerlo", "03", 51.99583, 6.13472);
case 1719: return new CityInfo("Angeren", "03", 51.91583, 5.95833);
case 1720: return new CityInfo("Angelslo", "01", 52.7809, 6.92645);
case 1721: return new CityInfo("Andelst", "03", 51.90833, 5.72917);
case 1722: return new CityInfo("Amsterdam", "07", 52.37403, 4.88969);
case 1723: return new CityInfo("Amstenrade", "05", 50.93917, 5.92361);
case 1724: return new CityInfo("Amstelveen", "07", 52.30083, 4.86389);
case 1725: return new CityInfo("Amsteleind", "06", 51.76667, 5.5);
case 1726: return new CityInfo("Ammerzoden", "03", 51.74917, 5.22083);
case 1727: return new CityInfo("Ammerstol", "11", 51.9275, 4.80833);
case 1728: return new CityInfo("Amersfoort", "09", 52.155, 5.3875);
case 1729: return new CityInfo("Amerongen", "09", 52.0025, 5.45972);
case 1730: return new CityInfo("America", "05", 51.43667, 5.97917);
case 1731: return new CityInfo("Amby", "05", 50.86215, 5.73226);
case 1732: return new CityInfo("Alverna", "03", 51.80417, 5.75972);
case 1733: return new CityInfo("Altweerterheide", "05", 51.22083, 5.67917);
case 1734: return new CityInfo("Alteveer", "04", 53.05083, 6.99444);
case 1735: return new CityInfo("Alteveer", "01", 52.675, 6.48611);
case 1736: return new CityInfo("Alphen aan den Rijn", "11", 52.12917, 4.65546);
case 1737: return new CityInfo("Alphen", "06", 51.48167, 4.95833);
case 1738: return new CityInfo("Almkerk", "06", 51.77083, 4.95972);
case 1739: return new CityInfo("Almere Stad", "16", 52.37025, 5.21413);
case 1740: return new CityInfo("Almen", "03", 52.15833, 6.3);
case 1741: return new CityInfo("Almelo", "15", 52.35667, 6.6625);
case 1742: return new CityInfo("Alkmaar", "07", 52.63167, 4.74861);
case 1743: return new CityInfo("Alem", "03", 51.78667, 5.34306);
case 1744: return new CityInfo("Alblasserdam", "11", 51.86583, 4.66111);
case 1745: return new CityInfo("Akkrum", "02", 53.05024, 5.83087);
case 1746: return new CityInfo("Akert", "06", 51.41407, 5.5596);
case 1747: return new CityInfo("Afferden", "03", 51.88, 5.63472);
case 1748: return new CityInfo("Aerdt", "03", 51.89417, 6.08472);
case 1749: return new CityInfo("Aduard", "04", 53.25667, 6.45972);
case 1750: return new CityInfo("Adorp", "04", 53.275, 6.53333);
case 1751: return new CityInfo("Adegeest", "11", 52.13621, 4.45249);
case 1752: return new CityInfo("Achtmaal", "06", 51.45417, 4.58472);
case 1753: return new CityInfo("Achterberg", "09", 51.9725, 5.5875);
case 1754: return new CityInfo("Achlum", "02", 53.14925, 5.48346);
case 1755: return new CityInfo("Abdissenbosch", "05", 50.91667, 6.03333);
case 1756: return new CityInfo("Abcoven", "06", 51.5275, 5.08333);
case 1757: return new CityInfo("Abcoude", "09", 52.2725, 4.96944);
case 1758: return new CityInfo("Abbenes", "07", 52.235, 4.59167);
case 1759: return new CityInfo("Abbekerk", "07", 52.73167, 5.01806);
case 1760: return new CityInfo("Aardenburg", "10", 51.27333, 3.44722);
case 1761: return new CityInfo("Aalten", "03", 51.925, 6.58056);
case 1762: return new CityInfo("Aalst", "06", 51.39667, 5.47778);
case 1763: return new CityInfo("Aalst", "03", 51.7825, 5.12778);
case 1764: return new CityInfo("Aalsmeerderbrug", "07", 52.27417, 4.75);
case 1765: return new CityInfo("Aalsmeer", "07", 52.25917, 4.75972);
case 1766: return new CityInfo("Aalden", "01", 52.79, 6.71806);
case 1767: return new CityInfo("Aalburg", "06", 51.75482, 5.13156);
case 1768: return new CityInfo("Aagtekerke", "10", 51.54667, 3.50972);
case 1769: return new CityInfo("Aagtdorp", "07", 52.69, 4.70417);
case 1770: return new CityInfo("Camminghaburen", "02", 53.20973, 5.84318);
case 1771: return new CityInfo("Nieuw Moscou", "01", 52.6725, 6.5375);
case 1772: return new CityInfo("Amsterdam-Zuidoost", "07", 52.3075, 4.97222);
case 1773: return new CityInfo("Zuid-Berghuizen", "15", 52.30083, 6.93333);
case 1774: return new CityInfo("Sterrenberg", "09", 52.11417, 5.28194);
case 1775: return new CityInfo("Meerwijck", "04", 53.14667, 6.7125);
case 1776: return new CityInfo("Chevremont", "05", 50.87554, 6.05981);
case 1777: return new CityInfo("Welgelegen", "03", 52.21397, 5.97643);
case 1778: return new CityInfo("Matenveld", "03", 52.18767, 5.99879);
case 1779: return new CityInfo("Matenhoeve", "03", 52.19056, 6.01338);
case 1780: return new CityInfo("Matendonk", "03", 52.19766, 6.01115);
case 1781: return new CityInfo("Matenhorst", "03", 52.20482, 5.99304);
case 1782: return new CityInfo("Matendreef", "03", 52.19993, 5.98592);
case 1783: return new CityInfo("Matengaarde", "03", 52.19793, 5.9957);
case 1784: return new CityInfo("Rivierenkwartier", "03", 52.18914, 5.97665);
case 1785: return new CityInfo("Staatsliedenkwartier", "03", 52.19951, 5.97691);
case 1786: return new CityInfo("Brummelhof", "03", 52.20503, 5.96789);
case 1787: return new CityInfo("Vogelkwartier", "03", 52.19777, 5.96721);
case 1788: return new CityInfo("Componistenkwartier", "03", 52.18977, 5.96609);
case 1789: return new CityInfo("Woudhuis", "03", 52.21323, 6.01124);
case 1790: return new CityInfo("Sluisoord", "03", 52.22291, 5.98145);
case 1791: return new CityInfo("Sprenkelaar", "03", 52.22512, 5.99922);
case 1792: return new CityInfo("De Haven", "03", 52.21045, 5.97407);
case 1793: return new CityInfo("Binnenstad", "03", 52.21304, 5.95957);
case 1794: return new CityInfo("Sprengenweg-Noord", "03", 52.21839, 5.95068);
case 1795: return new CityInfo("Sprengenbos", "03", 52.21902, 5.94163);
case 1796: return new CityInfo("Spainkbos", "03", 52.22228, 5.94738);
case 1797: return new CityInfo("Hommelbrink", "03", 52.23915, 5.9636);
case 1798: return new CityInfo("De Heeze", "03", 52.20061, 5.95365);
case 1799: return new CityInfo("Westenenk", "03", 52.19624, 5.95656);
case 1800: return new CityInfo("Winkewijert", "03", 52.19082, 5.95794);
case 1801: return new CityInfo("De Bouwhof", "03", 52.18546, 5.94704);
case 1802: return new CityInfo("Speelheide", "06", 51.50607, 5.40519);
case 1803: return new CityInfo("Salderes", "06", 51.51505, 5.38991);
case 1804: return new CityInfo("Jubbega", "02", 53.00396, 6.12183);
case 1805: return new CityInfo("Meerhoven", "06", 51.44267, 5.41102);
case 1806: return new CityInfo("Grasrijk", "06", 51.43916, 5.41544);
case 1807: return new CityInfo("Hoek", "02", 53.20455, 5.80192);
case 1808: return new CityInfo("De Knipe", "02", 52.96829, 5.97116);
case 1809: return new CityInfo("Lunetten", "09", 52.06178, 5.13474);
case 1810: return new CityInfo("Aarle-Rixtel", "06", 51.50976, 5.63839);
case 1811: return new CityInfo("Kelpen-Oler", "05", 51.21817, 5.82602);
case 1812: return new CityInfo("Muschberg en Geestenberg", "06", 51.44384, 5.52329);
case 1813: return new CityInfo("Villapark", "06", 51.44144, 5.49385);
case 1814: return new CityInfo("Lakerlopen", "06", 51.43791, 5.50106);
case 1815: return new CityInfo("Berkel en Rodenrijs", "11", 51.99313, 4.47865);
case 1816: return new CityInfo("Reitdiep", "04", 53.24252, 6.51957);
case 1817: return new CityInfo("Ypenburg", "11", 52.04098, 4.36981);
case 1818: return new CityInfo("Aldlân-Oost", "02", 53.1886, 5.82825);
case 1819: return new CityInfo("Oranjewijk", "11", 52.04922, 4.65374);
case 1820: return new CityInfo("Vondelwijk", "11", 52.05497, 4.65314);
case 1821: return new CityInfo("Groenswaard", "11", 52.05154, 4.64541);
case 1822: return new CityInfo("Randenbroek", "09", 52.14863, 5.4012);
case 1823: return new CityInfo("Corlaer", "03", 52.21639, 5.46535);
case 1824: return new CityInfo("Kapelle", "10", 51.48627, 3.95804);
case 1825: return new CityInfo("Hoogkamp", "03", 51.9963, 5.88026);
case 1826: return new CityInfo("Gulden Bodem", "03", 51.99428, 5.8908);
case 1827: return new CityInfo("Sterrenberg", "03", 51.9935, 5.88387);
case 1828: return new CityInfo("Burgemeesterswijk", "03", 51.98943, 5.89597);
case 1829: return new CityInfo("Kop van Zuid", "11", 51.90553, 4.48706);
case 1830: return new CityInfo("'s-Gravenland", "11", 51.92336, 4.55315);
case 1831: return new CityInfo("Spechtenkamp", "09", 52.13926, 5.01758);
case 1832: return new CityInfo("Beemte-Broekland", "03", 52.256, 5.98974);
case 1833: return new CityInfo("Besterd", "06", 51.5638, 5.08658);
case 1834: return new CityInfo("Wisselaar", "06", 51.61285, 4.78444);
case 1835: return new CityInfo("Waterdonken", "06", 51.60959, 4.80452);
case 1836: return new CityInfo("Hunnerberg", "03", 51.84209, 5.87876);
case 1837: return new CityInfo("Van Starkenborgh", "04", 53.23931, 6.57493);
case 1838: return new CityInfo("Son en Breugel", "06", 51.51654, 5.49608);
default: return new CityInfo("Marsdijk", "01", 53.01766, 6.58527);

                                    }                                        
                                }
                            
                        }
                    }
                