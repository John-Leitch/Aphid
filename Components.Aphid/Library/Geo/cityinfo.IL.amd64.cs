
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
                                    public const string Country = "IL";
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
                            
                                        var cur = (Math.Abs(32.77935 - lat) + Math.Abs(35.70032 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(32.90871 - lat) + Math.Abs(35.63199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.99941 - lat) + Math.Abs(35.81084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.76904 - lat) + Math.Abs(35.21633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.11689 - lat) + Math.Abs(35.11222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.82754 - lat) + Math.Abs(35.13093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.89385 - lat) + Math.Abs(35.01504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.29819 - lat) + Math.Abs(34.91313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.71912 - lat) + Math.Abs(35.09708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.78377 - lat) + Math.Abs(35.11926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.74535 - lat) + Math.Abs(35.28003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.96465 - lat) + Math.Abs(35.496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.98822 - lat) + Math.Abs(34.93176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.03317 - lat) + Math.Abs(34.89091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.70619 - lat) + Math.Abs(35.50435 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.87808 - lat) + Math.Abs(34.73983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.05043 - lat) + Math.Abs(34.75224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.79212 - lat) + Math.Abs(35.32984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.51725 - lat) + Math.Abs(35.15349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.76021 - lat) + Math.Abs(34.97183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.70302 - lat) + Math.Abs(35.22359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.79221 - lat) + Math.Abs(35.53124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.24995 - lat) + Math.Abs(34.91737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.08088 - lat) + Math.Abs(34.78057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.01667 - lat) + Math.Abs(35.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.85301 - lat) + Math.Abs(35.1987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.60606 - lat) + Math.Abs(35.33408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.07216 - lat) + Math.Abs(35.14452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.525 - lat) + Math.Abs(34.59693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.04966 - lat) + Math.Abs(34.8777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.86422 - lat) + Math.Abs(35.29707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.94266 - lat) + Math.Abs(35.34136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.96894 - lat) + Math.Abs(35.54258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.09556 - lat) + Math.Abs(34.95664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.97102 - lat) + Math.Abs(34.78939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.74907 - lat) + Math.Abs(35.09901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.89421 - lat) + Math.Abs(34.81199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.92923 - lat) + Math.Abs(34.86563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.70444 - lat) + Math.Abs(35.1707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.14613 - lat) + Math.Abs(34.8394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.08227 - lat) + Math.Abs(34.81065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.1836 - lat) + Math.Abs(34.87386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.84966 - lat) + Math.Abs(35.06973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.20733 - lat) + Math.Abs(35.57212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.83706 - lat) + Math.Abs(35.0776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.60998 - lat) + Math.Abs(34.76422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.8275 - lat) + Math.Abs(35.08583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.81149 - lat) + Math.Abs(35.11323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.28493 - lat) + Math.Abs(34.98106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.08707 - lat) + Math.Abs(34.88747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.30577 - lat) + Math.Abs(34.90911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.02923 - lat) + Math.Abs(34.85788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.3141 - lat) + Math.Abs(34.62025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.3147 - lat) + Math.Abs(34.89617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.42305 - lat) + Math.Abs(34.58911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.33291 - lat) + Math.Abs(34.85992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.92933 - lat) + Math.Abs(34.79868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.76622 - lat) + Math.Abs(35.04425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.63063 - lat) + Math.Abs(35.34885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.06012 - lat) + Math.Abs(34.91069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.70056 - lat) + Math.Abs(35.29722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.93444 - lat) + Math.Abs(35.31679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.00892 - lat) + Math.Abs(35.09814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.60944 - lat) + Math.Abs(34.80111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.02781 - lat) + Math.Abs(35.25658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.67597 - lat) + Math.Abs(35.23986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.72177 - lat) + Math.Abs(35.10669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.80186 - lat) + Math.Abs(35.15072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.27918 - lat) + Math.Abs(35.5795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.85357 - lat) + Math.Abs(34.84646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.88984 - lat) + Math.Abs(35.40703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.9467 - lat) + Math.Abs(34.8903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.31669 - lat) + Math.Abs(34.93507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.68655 - lat) + Math.Abs(35.42118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.18529 - lat) + Math.Abs(34.82082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.175 - lat) + Math.Abs(34.90694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.08607 - lat) + Math.Abs(35.11348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.98793 - lat) + Math.Abs(34.8516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.83155 - lat) + Math.Abs(35.24848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.91708 - lat) + Math.Abs(35.30501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.95451 - lat) + Math.Abs(35.1623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.11406 - lat) + Math.Abs(34.97624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.64521 - lat) + Math.Abs(35.42147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.81034 - lat) + Math.Abs(35.26009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.7466 - lat) + Math.Abs(35.34242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.72129 - lat) + Math.Abs(35.44122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.86856 - lat) + Math.Abs(35.21171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.9282 - lat) + Math.Abs(35.15705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.02216 - lat) + Math.Abs(35.44694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.1547 - lat) + Math.Abs(34.95372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.68164 - lat) + Math.Abs(35.32365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.7615 - lat) + Math.Abs(35.11402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.01711 - lat) + Math.Abs(35.34835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.01034 - lat) + Math.Abs(34.77918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.15934 - lat) + Math.Abs(34.8932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.16627 - lat) + Math.Abs(34.82536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.81841 - lat) + Math.Abs(34.9885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.44192 - lat) + Math.Abs(34.9039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.07817 - lat) + Math.Abs(34.84858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.07225 - lat) + Math.Abs(34.81253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.81456 - lat) + Math.Abs(34.77998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.78737 - lat) + Math.Abs(34.70659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.05971 - lat) + Math.Abs(34.8732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.04895 - lat) + Math.Abs(35.30893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.26959 - lat) + Math.Abs(34.88759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.76319 - lat) + Math.Abs(35.13422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.2341 - lat) + Math.Abs(34.95023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.26616 - lat) + Math.Abs(35.00893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.9941 - lat) + Math.Abs(35.14805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.72339 - lat) + Math.Abs(35.31622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.45238 - lat) + Math.Abs(35.38443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.19941 - lat) + Math.Abs(35.36253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.40793 - lat) + Math.Abs(34.92433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.98338 - lat) + Math.Abs(35.09837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.59812 - lat) + Math.Abs(34.95153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.55805 - lat) + Math.Abs(34.94821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.83693 - lat) + Math.Abs(35.40029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.07079 - lat) + Math.Abs(35.03269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.86196 - lat) + Math.Abs(35.36365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.69383 - lat) + Math.Abs(35.04686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.69256 - lat) + Math.Abs(35.37123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.97747 - lat) + Math.Abs(35.33345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.80636 - lat) + Math.Abs(35.36486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.77732 - lat) + Math.Abs(35.22069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.32751 - lat) + Math.Abs(34.88878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.73072 - lat) + Math.Abs(34.99293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.49728 - lat) + Math.Abs(35.49632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.00191 - lat) + Math.Abs(34.82977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.08074 - lat) + Math.Abs(34.8338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.78333 - lat) + Math.Abs(34.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.96464 - lat) + Math.Abs(35.38152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.25181 - lat) + Math.Abs(34.7913 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.02379 - lat) + Math.Abs(34.75185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.73898 - lat) + Math.Abs(35.15716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.0243 - lat) + Math.Abs(34.80632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.68889 - lat) + Math.Abs(34.94236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.66926 - lat) + Math.Abs(34.57149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.79213 - lat) + Math.Abs(34.64966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.25882 - lat) + Math.Abs(35.21282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.92814 - lat) + Math.Abs(35.07647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.60907 - lat) + Math.Abs(35.2892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.80592 - lat) + Math.Abs(35.1093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.69464 - lat) + Math.Abs(35.39252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.77802 - lat) + Math.Abs(35.30571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.89443 - lat) + Math.Abs(35.36931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.99385 - lat) + Math.Abs(35.27793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.13203 - lat) + Math.Abs(35.77715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.37284 - lat) + Math.Abs(34.81619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.85154 - lat) + Math.Abs(34.7834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.51888 - lat) + Math.Abs(34.90459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.78199 - lat) + Math.Abs(35.21961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.39547 - lat) + Math.Abs(34.75699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.93221 - lat) + Math.Abs(35.04416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.87111 - lat) + Math.Abs(34.99081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.92973 - lat) + Math.Abs(35.0215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.91764 - lat) + Math.Abs(35.03222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.91982 - lat) + Math.Abs(35.03669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.84876 - lat) + Math.Abs(35.03583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.87581 - lat) + Math.Abs(35.12999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.96396 - lat) + Math.Abs(35.04853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.96236 - lat) + Math.Abs(35.06553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.84927 - lat) + Math.Abs(35.16106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.93927 - lat) + Math.Abs(35.13539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.92609 - lat) + Math.Abs(35.13393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.1065 - lat) + Math.Abs(35.18449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.14677 - lat) + Math.Abs(34.98622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.11926 - lat) + Math.Abs(35.12896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.99866 - lat) + Math.Abs(34.94559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.17409 - lat) + Math.Abs(34.8028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.0284 - lat) + Math.Abs(34.8796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Fīq", "03", 32.77935, 35.70032);
case 1: return new CityInfo("Al Buţayḩah", "03", 32.90871, 35.63199);
case 2: return new CityInfo("Al Khushnīyah", "03", 32.99941, 35.81084);
case 3: return new CityInfo("Jerusalem", "06", 31.76904, 35.21633);
case 4: return new CityInfo("Kiryat Netafim", "", 32.11689, 35.11222);
case 5: return new CityInfo("Har Adar", "06", 31.82754, 35.13093);
case 6: return new CityInfo("Modi‘in Makkabbim Re‘ut", "02", 31.89385, 35.01504);
case 7: return new CityInfo("Ẕur Moshe", "02", 32.29819, 34.91313);
case 8: return new CityInfo("Ẕur Hadassa", "06", 31.71912, 35.09708);
case 9: return new CityInfo("Tzova", "06", 31.78377, 35.11926);
case 10: return new CityInfo("Ẕippori", "03", 32.74535, 35.28003);
case 11: return new CityInfo("Safed", "03", 32.96465, 35.496);
case 12: return new CityInfo("Yeroẖam", "01", 30.98822, 34.93176);
case 13: return new CityInfo("Yehud", "02", 32.03317, 34.89091);
case 14: return new CityInfo("Yavne’el", "03", 32.70619, 35.50435);
case 15: return new CityInfo("Yavné", "02", 31.87808, 34.73983);
case 16: return new CityInfo("Jaffa", "05", 32.05043, 34.75224);
case 17: return new CityInfo("‘Uzeir", "03", 32.79212, 35.32984);
case 18: return new CityInfo("Umm el Faḥm", "04", 32.51725, 35.15349);
case 19: return new CityInfo("Tirat Karmel", "04", 32.76021, 34.97183);
case 20: return new CityInfo("Timrat", "03", 32.70302, 35.22359);
case 21: return new CityInfo("Tiberias", "03", 32.79221, 35.53124);
case 22: return new CityInfo("Tel Mond", "02", 32.24995, 34.91737);
case 23: return new CityInfo("Tel Aviv", "05", 32.08088, 34.78057);
case 24: return new CityInfo("maalot Tarshīhā", "03", 33.01667, 35.26667);
case 25: return new CityInfo("Tamra", "03", 32.85301, 35.1987);
case 26: return new CityInfo("Sūlam", "03", 32.60606, 35.33408);
case 27: return new CityInfo("Shelomi", "03", 33.07216, 35.14452);
case 28: return new CityInfo("Sederot", "01", 31.525, 34.59693);
case 29: return new CityInfo("Savyon", "02", 32.04966, 34.8777);
case 30: return new CityInfo("Sakhnīn", "03", 32.86422, 35.29707);
case 31: return new CityInfo("Sājūr", "03", 32.94266, 35.34136);
case 32: return new CityInfo("Rosh Pinna", "03", 32.96894, 35.54258);
case 33: return new CityInfo("Rosh Ha‘Ayin", "02", 32.09556, 34.95664);
case 34: return new CityInfo("Rishon LeẔiyyon", "02", 31.97102, 34.78939);
case 35: return new CityInfo("Rekhasim", "04", 32.74907, 35.09901);
case 36: return new CityInfo("Reẖovot", "02", 31.89421, 34.81199);
case 37: return new CityInfo("Ramla", "02", 31.92923, 34.86563);
case 38: return new CityInfo("Ramat Yishay", "03", 32.70444, 35.1707);
case 39: return new CityInfo("Ramat HaSharon", "05", 32.14613, 34.8394);
case 40: return new CityInfo("Ramat Gan", "05", 32.08227, 34.81065);
case 41: return new CityInfo("Ra'anana", "02", 32.1836, 34.87386);
case 42: return new CityInfo("Qiryat Yam", "04", 32.84966, 35.06973);
case 43: return new CityInfo("Qiryat Shemona", "03", 33.20733, 35.57212);
case 44: return new CityInfo("Qiryat Moẕqin", "04", 32.83706, 35.0776);
case 45: return new CityInfo("Kiryat Gat", "01", 31.60998, 34.76422);
case 46: return new CityInfo("Qiryat Bialik", "04", 32.8275, 35.08583);
case 47: return new CityInfo("Qiryat Ata", "04", 32.81149, 35.11323);
case 48: return new CityInfo("Qalansuwa", "02", 32.28493, 34.98106);
case 49: return new CityInfo("Petaẖ Tiqwa", "02", 32.08707, 34.88747);
case 50: return new CityInfo("Pardesiyya", "02", 32.30577, 34.90911);
case 51: return new CityInfo("Or Yehuda", "05", 32.02923, 34.85788);
case 52: return new CityInfo("Ofaqim", "01", 31.3141, 34.62025);
case 53: return new CityInfo("Nordiyya", "02", 32.3147, 34.89617);
case 54: return new CityInfo("Netivot", "01", 31.42305, 34.58911);
case 55: return new CityInfo("Netanya", "02", 32.33291, 34.85992);
case 56: return new CityInfo("Ness Ziona", "02", 31.92933, 34.79868);
case 57: return new CityInfo("Nesher", "04", 32.76622, 35.04425);
case 58: return new CityInfo("Nein", "03", 32.63063, 35.34885);
case 59: return new CityInfo("Neẖalim", "02", 32.06012, 34.91069);
case 60: return new CityInfo("Nazareth", "03", 32.70056, 35.29722);
case 61: return new CityInfo("Naḥf", "03", 32.93444, 35.31679);
case 62: return new CityInfo("Nahariyya", "03", 33.00892, 35.09814);
case 63: return new CityInfo("Mitzpe Ramon", "01", 30.60944, 34.80111);
case 64: return new CityInfo("Mi‘ilyā", "03", 33.02781, 35.25658);
case 65: return new CityInfo("Migdal Ha‘Emeq", "03", 32.67597, 35.23986);
case 66: return new CityInfo("Mevo Betar", "06", 31.72177, 35.10669);
case 67: return new CityInfo("Mevasseret Ẕiyyon", "06", 31.80186, 35.15072);
case 68: return new CityInfo("Metulla", "03", 33.27918, 35.5795);
case 69: return new CityInfo("Mazkeret Batya", "02", 31.85357, 34.84646);
case 70: return new CityInfo("Maghār", "03", 32.88984, 35.40703);
case 71: return new CityInfo("Lod", "02", 31.9467, 34.8903);
case 72: return new CityInfo("Kefar Yona", "02", 32.31669, 34.93507);
case 73: return new CityInfo("Kefar Tavor", "03", 32.68655, 35.42118);
case 74: return new CityInfo("Kefar Shemaryahu", "05", 32.18529, 34.82082);
case 75: return new CityInfo("Kfar Saba", "02", 32.175, 34.90694);
case 76: return new CityInfo("Kefar Rosh HaNiqra", "03", 33.08607, 35.11348);
case 77: return new CityInfo("Kefar H̱abad", "02", 31.98793, 34.8516);
case 78: return new CityInfo("Kaukab Abū el Hījā", "03", 32.83155, 35.24848);
case 79: return new CityInfo("Karmi’el", "03", 32.91708, 35.30501);
case 80: return new CityInfo("Kfar Yasif", "03", 32.95451, 35.1623);
case 81: return new CityInfo("Kafr Qāsim", "02", 32.11406, 34.97624);
case 82: return new CityInfo("Kafr Miṣr", "03", 32.64521, 35.42147);
case 83: return new CityInfo("Kafr Mandā", "03", 32.81034, 35.26009);
case 84: return new CityInfo("Kafr Kannā", "03", 32.7466, 35.34242);
case 85: return new CityInfo("Kafr Kammā", "03", 32.72129, 35.44122);
case 86: return new CityInfo("Kābūl", "03", 32.86856, 35.21171);
case 87: return new CityInfo("Judeida Makr", "03", 32.9282, 35.15705);
case 88: return new CityInfo("Jīsh", "03", 33.02216, 35.44694);
case 89: return new CityInfo("Jaljūlya", "02", 32.1547, 34.95372);
case 90: return new CityInfo("Iksāl", "03", 32.68164, 35.32365);
case 91: return new CityInfo("Ibṭīn", "04", 32.7615, 35.11402);
case 92: return new CityInfo("Ḥurfeish", "03", 33.01711, 35.34835);
case 93: return new CityInfo("H̱olon", "05", 32.01034, 34.77918);
case 94: return new CityInfo("Hod HaSharon", "02", 32.15934, 34.8932);
case 95: return new CityInfo("Herzliya", "05", 32.16627, 34.82536);
case 96: return new CityInfo("Haifa", "04", 32.81841, 34.9885);
case 97: return new CityInfo("Hadera", "04", 32.44192, 34.9039);
case 98: return new CityInfo("Giv'at Shmuel", "05", 32.07817, 34.84858);
case 99: return new CityInfo("Givatayim", "05", 32.07225, 34.81253);
case 100: return new CityInfo("Gedera", "02", 31.81456, 34.77998);
case 101: return new CityInfo("Gan Yavne", "02", 31.78737, 34.70659);
case 102: return new CityInfo("Ganei Tikva", "02", 32.05971, 34.8732);
case 103: return new CityInfo("Pasuta", "03", 33.04895, 35.30893);
case 104: return new CityInfo("Even Yehuda", "02", 32.26959, 34.88759);
case 105: return new CityInfo("Even Sappir", "06", 31.76319, 35.13422);
case 106: return new CityInfo("Tirah", "02", 32.2341, 34.95023);
case 107: return new CityInfo("Eṭ Ṭaiyiba", "02", 32.26616, 35.00893);
case 108: return new CityInfo("Esh Sheikh Dannūn", "03", 32.9941, 35.14805);
case 109: return new CityInfo("Er Reina", "03", 32.72339, 35.31622);
case 110: return new CityInfo("‘En Gedi", "01", 31.45238, 35.38443);
case 111: return new CityInfo("‘En Boqeq", "01", 31.19941, 35.36253);
case 112: return new CityInfo("Elyakhin", "02", 32.40793, 34.92433);
case 113: return new CityInfo("El Mazra‘a", "03", 32.98338, 35.09837);
case 114: return new CityInfo("El Fureidīs", "04", 32.59812, 34.95153);
case 115: return new CityInfo("Eilat", "01", 29.55805, 34.94821);
case 116: return new CityInfo("‘Eilabun", "03", 32.83693, 35.40029);
case 117: return new CityInfo("Dimona", "01", 31.07079, 35.03269);
case 118: return new CityInfo("Deir Ḥannā", "03", 32.86196, 35.36365);
case 119: return new CityInfo("Daliyat al Karmel", "04", 32.69383, 35.04686);
case 120: return new CityInfo("Dabbūrīya", "03", 32.69256, 35.37123);
case 121: return new CityInfo("Buqei‘a", "03", 32.97747, 35.33345);
case 122: return new CityInfo("Bu‘eina", "03", 32.80636, 35.36486);
case 123: return new CityInfo("Bīr el Maksūr", "03", 32.77732, 35.22069);
case 124: return new CityInfo("Bet Yiẕẖaq", "02", 32.32751, 34.88878);
case 125: return new CityInfo("Bet Shemesh", "06", 31.73072, 34.99293);
case 126: return new CityInfo("Bet She’an", "03", 32.49728, 35.49632);
case 127: return new CityInfo("Bet Dagan", "02", 32.00191, 34.82977);
case 128: return new CityInfo("Bnei Brak", "05", 32.08074, 34.8338);
case 129: return new CityInfo("Bnei Ayish", "02", 31.78333, 34.75);
case 130: return new CityInfo("Beit Jann", "03", 32.96464, 35.38152);
case 131: return new CityInfo("Beersheba", "01", 31.25181, 34.7913);
case 132: return new CityInfo("Bat Yam", "05", 32.02379, 34.75185);
case 133: return new CityInfo("Basmat Ṭab‘ūn", "03", 32.73898, 35.15716);
case 134: return new CityInfo("Azor", "05", 32.0243, 34.80632);
case 135: return new CityInfo("Atlit", "04", 32.68889, 34.94236);
case 136: return new CityInfo("Ashkelon", "01", 31.66926, 34.57149);
case 137: return new CityInfo("Ashdod", "01", 31.79213, 34.64966);
case 138: return new CityInfo("Arad", "01", 31.25882, 35.21282);
case 139: return new CityInfo("Acre", "03", 32.92814, 35.07647);
case 140: return new CityInfo("Afula", "03", 32.60907, 35.2892);
case 141: return new CityInfo("Abū Ghaush", "06", 31.80592, 35.1093);
case 142: return new CityInfo("Shibli", "03", 32.69464, 35.39252);
case 143: return new CityInfo("Rumat Heib", "03", 32.77802, 35.30571);
case 144: return new CityInfo("Sallama", "03", 32.89443, 35.36931);
case 145: return new CityInfo("Kefar Weradim", "03", 32.99385, 35.27793);
case 146: return new CityInfo("Mārom Golan", "03", 33.13203, 35.77715);
case 147: return new CityInfo("Lehavim", "01", 31.37284, 34.81619);
case 148: return new CityInfo("Midreshet Ben-Gurion", "01", 30.85154, 34.7834);
case 149: return new CityInfo("Caesarea", "04", 32.51888, 34.90459);
case 150: return new CityInfo("West Jerusalem", "06", 31.78199, 35.21961);
case 151: return new CityInfo("Rahat", "01", 31.39547, 34.75699);
case 152: return new CityInfo("Modiin Ilit", "06", 31.93221, 35.04416);
case 153: return new CityInfo("Nof Ayalon", "02", 31.87111, 34.99081);
case 154: return new CityInfo("Hashmonaim", "WE", 31.92973, 35.0215);
case 155: return new CityInfo("Lapid", "02", 31.91764, 35.03222);
case 156: return new CityInfo("Kfar NaOranim", "", 31.91982, 35.03669);
case 157: return new CityInfo("Mevo horon", "", 31.84876, 35.03583);
case 158: return new CityInfo("Beit Horon", "", 31.87581, 35.12999);
case 159: return new CityInfo("Nili", "", 31.96396, 35.04853);
case 160: return new CityInfo("Na'ale", "", 31.96236, 35.06553);
case 161: return new CityInfo("Giv'on HaHadasha", "", 31.84927, 35.16106);
case 162: return new CityInfo("Talmon", "", 31.93927, 35.13539);
case 163: return new CityInfo("Dolev", "", 31.92609, 35.13393);
case 164: return new CityInfo("Ariel", "WE", 32.1065, 35.18449);
case 165: return new CityInfo("Nirit", "02", 32.14677, 34.98622);
case 166: return new CityInfo("Revava", "", 32.11926, 35.12896);
case 167: return new CityInfo("Shoham", "02", 31.99866, 34.94559);
case 168: return new CityInfo("Herzliya Pituah", "05", 32.17409, 34.8028);
default: return new CityInfo("Yehud-Monosson", "05", 32.0284, 34.8796);

                                    }                                        
                                }
                            
                        }
                    }
                