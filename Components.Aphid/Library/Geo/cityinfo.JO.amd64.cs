
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
                                    public const string Country = "JO";
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
                            
                                        var cur = (Math.Abs(32.5667 - lat) + Math.Abs(35.77811 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(31.97583 - lat) + Math.Abs(35.69638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.54214 - lat) + Math.Abs(35.60508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.32096 - lat) + Math.Abs(35.47895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.9545 - lat) + Math.Abs(35.81831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.65348 - lat) + Math.Abs(35.68457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.88542 - lat) + Math.Abs(35.8543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.51225 - lat) + Math.Abs(35.91837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.31449 - lat) + Math.Abs(36.62826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.32863 - lat) + Math.Abs(36.36788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.82454 - lat) + Math.Abs(35.87795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.3307 - lat) + Math.Abs(35.59659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.47521 - lat) + Math.Abs(35.73056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.45103 - lat) + Math.Abs(35.60898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.31372 - lat) + Math.Abs(35.83713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.8915 - lat) + Math.Abs(35.6178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.63794 - lat) + Math.Abs(35.82661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.57102 - lat) + Math.Abs(35.68984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.46859 - lat) + Math.Abs(36.24363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.56897 - lat) + Math.Abs(35.91185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.28431 - lat) + Math.Abs(35.80909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.37087 - lat) + Math.Abs(35.84267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.69848 - lat) + Math.Abs(35.77438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.87032 - lat) + Math.Abs(36.00479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.32696 - lat) + Math.Abs(36.50159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.83693 - lat) + Math.Abs(36.00492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.32341 - lat) + Math.Abs(36.09087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.28202 - lat) + Math.Abs(35.82779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.57174 - lat) + Math.Abs(35.73452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.0955 - lat) + Math.Abs(36.33232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.34851 - lat) + Math.Abs(35.93864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.87436 - lat) + Math.Abs(35.82467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.58517 - lat) + Math.Abs(35.80716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.40634 - lat) + Math.Abs(35.77083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.67645 - lat) + Math.Abs(35.74851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.68002 - lat) + Math.Abs(35.732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.71599 - lat) + Math.Abs(35.79392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.19624 - lat) + Math.Abs(35.73405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.27639 - lat) + Math.Abs(35.59938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.29755 - lat) + Math.Abs(35.70212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.74909 - lat) + Math.Abs(35.76922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.43834 - lat) + Math.Abs(35.89677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.09943 - lat) + Math.Abs(35.95783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.09526 - lat) + Math.Abs(35.52314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.65988 - lat) + Math.Abs(35.88782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.68527 - lat) + Math.Abs(35.80102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.598 - lat) + Math.Abs(35.71266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.41752 - lat) + Math.Abs(35.66305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.76 - lat) + Math.Abs(35.79466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.40792 - lat) + Math.Abs(35.70802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.85247 - lat) + Math.Abs(35.93928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.28082 - lat) + Math.Abs(35.89929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.15889 - lat) + Math.Abs(35.69278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.39447 - lat) + Math.Abs(35.73345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.55556 - lat) + Math.Abs(35.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.79819 - lat) + Math.Abs(35.80986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.45144 - lat) + Math.Abs(36.09903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.64492 - lat) + Math.Abs(35.77771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.38433 - lat) + Math.Abs(35.66167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.59354 - lat) + Math.Abs(35.8832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.36805 - lat) + Math.Abs(35.7022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.49889 - lat) + Math.Abs(35.78287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.48701 - lat) + Math.Abs(35.79635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.19571 - lat) + Math.Abs(35.62161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.49816 - lat) + Math.Abs(35.68671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.73256 - lat) + Math.Abs(35.60943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.2193 - lat) + Math.Abs(35.78507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.52253 - lat) + Math.Abs(35.78618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.43775 - lat) + Math.Abs(35.69765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.39109 - lat) + Math.Abs(35.93832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.23649 - lat) + Math.Abs(36.08811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.07275 - lat) + Math.Abs(36.08796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.83269 - lat) + Math.Abs(36.81487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.88209 - lat) + Math.Abs(36.83017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.13371 - lat) + Math.Abs(35.64375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.33466 - lat) + Math.Abs(35.7637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.05726 - lat) + Math.Abs(35.83109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.20588 - lat) + Math.Abs(35.53627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.50528 - lat) + Math.Abs(35.85809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.63979 - lat) + Math.Abs(35.98943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.54304 - lat) + Math.Abs(35.71756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.05056 - lat) + Math.Abs(35.60606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.25125 - lat) + Math.Abs(35.4657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.83752 - lat) + Math.Abs(35.60442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.14844 - lat) + Math.Abs(35.70535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.03917 - lat) + Math.Abs(35.72722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.03608 - lat) + Math.Abs(35.46544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.62023 - lat) + Math.Abs(35.61451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.52134 - lat) + Math.Abs(35.57135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.64391 - lat) + Math.Abs(35.94175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.50152 - lat) + Math.Abs(38.20405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.01727 - lat) + Math.Abs(36.03271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.55873 - lat) + Math.Abs(36.00816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.26923 - lat) + Math.Abs(35.73829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.3063 - lat) + Math.Abs(35.75653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.95522 - lat) + Math.Abs(35.94503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.91037 - lat) + Math.Abs(35.94975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.80045 - lat) + Math.Abs(35.3116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.25083 - lat) + Math.Abs(36.04932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.31407 - lat) + Math.Abs(35.74393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.26586 - lat) + Math.Abs(35.51674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.47041 - lat) + Math.Abs(35.79693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.06722 - lat) + Math.Abs(35.69486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.18434 - lat) + Math.Abs(35.85588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.37066 - lat) + Math.Abs(36.07933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.34289 - lat) + Math.Abs(36.20804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.11815 - lat) + Math.Abs(35.74351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.27685 - lat) + Math.Abs(35.84114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.95439 - lat) + Math.Abs(35.58033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.18248 - lat) + Math.Abs(35.69999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.88715 - lat) + Math.Abs(35.93144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.01071 - lat) + Math.Abs(35.89802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.69893 - lat) + Math.Abs(35.9553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.3184 - lat) + Math.Abs(36.17775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.02606 - lat) + Math.Abs(35.72294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.48454 - lat) + Math.Abs(35.88406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.12901 - lat) + Math.Abs(36.1213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.82131 - lat) + Math.Abs(35.97499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.44017 - lat) + Math.Abs(36.15265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.00468 - lat) + Math.Abs(35.78088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.89603 - lat) + Math.Abs(35.88465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.55839 - lat) + Math.Abs(35.65736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.52667 - lat) + Math.Abs(35.00778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.33326 - lat) + Math.Abs(35.75279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.20217 - lat) + Math.Abs(35.76155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.179 - lat) + Math.Abs(36.30326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.22435 - lat) + Math.Abs(35.21671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.81473 - lat) + Math.Abs(36.10879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.16368 - lat) + Math.Abs(35.76204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.59545 - lat) + Math.Abs(35.79701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.65284 - lat) + Math.Abs(35.51123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.01778 - lat) + Math.Abs(36.04639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.26011 - lat) + Math.Abs(36.4678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.40842 - lat) + Math.Abs(34.97918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.34592 - lat) + Math.Abs(36.23352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.1208 - lat) + Math.Abs(36.28008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.96501 - lat) + Math.Abs(35.90821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.27535 - lat) + Math.Abs(36.83949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.31405 - lat) + Math.Abs(38.70342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zaḩar", "18", 32.5667, 35.77811);
case 1: return new CityInfo("Yarqā", "02", 31.97583, 35.69638);
case 2: return new CityInfo("Waqqāş", "18", 32.54214, 35.60508);
case 3: return new CityInfo("Petra", "19", 30.32096, 35.47895);
case 4: return new CityInfo("Wādī as Sīr", "16", 31.9545, 35.81831);
case 5: return new CityInfo("Umm Qays", "18", 32.65348, 35.68457);
case 6: return new CityInfo("Umm as Summāq", "16", 31.88542, 35.8543);
case 7: return new CityInfo("Umm ar Raşāş", "16", 31.51225, 35.91837);
case 8: return new CityInfo("Umm al Qiţţayn", "15", 32.31449, 36.62826);
case 9: return new CityInfo("Umm al Jimāl", "15", 32.32863, 36.36788);
case 10: return new CityInfo("Umm al Basātīn", "16", 31.82454, 35.87795);
case 11: return new CityInfo("Adhruḩ", "19", 30.3307, 35.59659);
case 12: return new CityInfo("Tibnah", "18", 32.47521, 35.73056);
case 13: return new CityInfo("Ţabaqat Faḩl", "18", 32.45103, 35.60898);
case 14: return new CityInfo("Sūf", "22", 32.31372, 35.83713);
case 15: return new CityInfo("Ash Shūnah al Janūbīyah", "02", 31.8915, 35.6178);
case 16: return new CityInfo("Sammā ar Rawsān", "18", 32.63794, 35.82661);
case 17: return new CityInfo("Şammā", "18", 32.57102, 35.68984);
case 18: return new CityInfo("Samā as Sirḩān", "15", 32.46859, 36.24363);
case 19: return new CityInfo("Sāl", "18", 32.56897, 35.91185);
case 20: return new CityInfo("Sakib", "22", 32.28431, 35.80909);
case 21: return new CityInfo("Şakhrah", "20", 32.37087, 35.84267);
case 22: return new CityInfo("Saḩam al Kaffārāt", "18", 32.69848, 35.77438);
case 23: return new CityInfo("Saḩāb", "16", 31.87032, 36.00479);
case 24: return new CityInfo("Şabḩā", "15", 32.32696, 36.50159);
case 25: return new CityInfo("Rujm ash Shāmī al Gharbī", "16", 31.83693, 36.00492);
case 26: return new CityInfo("Rehab", "15", 32.32341, 36.09087);
case 27: return new CityInfo("Raymūn", "22", 32.28202, 35.82779);
case 28: return new CityInfo("Qumaym", "18", 32.57174, 35.73452);
case 29: return new CityInfo("Qaşr al Ḩallābāt", "17", 32.0955, 36.33232);
case 30: return new CityInfo("Qafqafā", "22", 32.34851, 35.93864);
case 31: return new CityInfo("Nā‘ūr", "16", 31.87436, 35.82467);
case 32: return new CityInfo("Mulayḩ", "23", 31.58517, 35.80716);
case 33: return new CityInfo("Al Mughayyir", "09", 31.40634, 35.77083);
case 34: return new CityInfo("Malkā", "18", 32.67645, 35.74851);
case 35: return new CityInfo("Mā‘īn", "23", 31.68002, 35.732);
case 36: return new CityInfo("Mādabā", "23", 31.71599, 35.79392);
case 37: return new CityInfo("Ma'an", "19", 30.19624, 35.73405);
case 38: return new CityInfo("Kurayyimah", "18", 32.27639, 35.59938);
case 39: return new CityInfo("Kufrinjah", "20", 32.29755, 35.70212);
case 40: return new CityInfo("Al Fayşalīyah", "23", 31.74909, 35.76922);
case 41: return new CityInfo("Kitim", "18", 32.43834, 35.89677);
case 42: return new CityInfo("Bīrayn", "17", 32.09943, 35.95783);
case 43: return new CityInfo("Al Murayghah", "19", 30.09526, 35.52314);
case 44: return new CityInfo("Kharjā", "18", 32.65988, 35.88782);
case 45: return new CityInfo("Kafr Sawm", "18", 32.68527, 35.80102);
case 46: return new CityInfo("Kafr Asad", "18", 32.598, 35.71266);
case 47: return new CityInfo("Kafr Abīl", "18", 32.41752, 35.66305);
case 48: return new CityInfo("Juraynah", "23", 31.76, 35.79466);
case 49: return new CityInfo("Judita", "18", 32.40792, 35.70802);
case 50: return new CityInfo("Jāwā", "16", 31.85247, 35.93928);
case 51: return new CityInfo("Jarash", "22", 32.28082, 35.89929);
case 52: return new CityInfo("‘Izrā", "09", 31.15889, 35.69278);
case 53: return new CityInfo("‘Irjān", "20", 32.39447, 35.73345);
case 54: return new CityInfo("Irbid", "18", 32.55556, 35.85);
case 55: return new CityInfo("Ḩisbān", "16", 31.79819, 35.80986);
case 56: return new CityInfo("Ḩawshā", "15", 32.45144, 36.09903);
case 57: return new CityInfo("Ḩātim", "18", 32.64492, 35.77771);
case 58: return new CityInfo("Ḩalāwah", "20", 32.38433, 35.66167);
case 59: return new CityInfo("Ḩakamā", "18", 32.59354, 35.8832);
case 60: return new CityInfo("Fuqū‘", "09", 31.36805, 35.7022);
case 61: return new CityInfo("Dhībān", "23", 31.49889, 35.78287);
case 62: return new CityInfo("Dayr Yūsuf", "18", 32.48701, 35.79635);
case 63: return new CityInfo("Dayr ‘Allā", "02", 32.19571, 35.62161);
case 64: return new CityInfo("Dayr Abū Sa‘īd", "18", 32.49816, 35.68671);
case 65: return new CityInfo("Buşayrā", "12", 30.73256, 35.60943);
case 66: return new CityInfo("Burmā", "22", 32.2193, 35.78507);
case 67: return new CityInfo("Bayt Yāfā", "18", 32.52253, 35.78618);
case 68: return new CityInfo("Bayt Īdis", "18", 32.43775, 35.69765);
case 69: return new CityInfo("Balīlā", "22", 32.39109, 35.93832);
case 70: return new CityInfo("Bal‘amā", "15", 32.23649, 36.08811);
case 71: return new CityInfo("Zarqa", "17", 32.07275, 36.08796);
case 72: return new CityInfo("Muthallath al Azraq", "17", 31.83269, 36.81487);
case 73: return new CityInfo("Al Azraq ash Shamālī", "17", 31.88209, 36.83017);
case 74: return new CityInfo("‘Ayy", "09", 31.13371, 35.64375);
case 75: return new CityInfo("‘Ayn Jannah", "20", 32.33466, 35.7637);
case 76: return new CityInfo("‘Ayn al Bāshā", "02", 32.05726, 35.83109);
case 77: return new CityInfo("Ayl", "19", 30.20588, 35.53627);
case 78: return new CityInfo("Aydūn", "18", 32.50528, 35.85809);
case 79: return new CityInfo("Aţ Ţurrah", "18", 32.63979, 35.98943);
case 80: return new CityInfo("Aţ Ţayyibah", "18", 32.54304, 35.71756);
case 81: return new CityInfo("Al Khinzīrah", "09", 31.05056, 35.60606);
case 82: return new CityInfo("Aţ Ţayyibah", "19", 30.25125, 35.4657);
case 83: return new CityInfo("Aţ Ţafīlah", "12", 30.83752, 35.60442);
case 84: return new CityInfo("Aş Şubayḩī", "02", 32.14844, 35.70535);
case 85: return new CityInfo("As Salţ", "02", 32.03917, 35.72722);
case 86: return new CityInfo("Safi", "09", 31.03608, 35.46544);
case 87: return new CityInfo("Ash Shūnah ash Shamālīyah", "18", 32.62023, 35.61451);
case 88: return new CityInfo("Ash Shawbak", "19", 30.52134, 35.57135);
case 89: return new CityInfo("Ash Shajarah", "18", 32.64391, 35.94175);
case 90: return new CityInfo("Ar Ruwayshid", "15", 32.50152, 38.20405);
case 91: return new CityInfo("Ar Ruşayfah", "17", 32.01727, 36.03271);
case 92: return new CityInfo("Ar Ramthā", "18", 32.55873, 36.00816);
case 93: return new CityInfo("Ar Rabbah", "09", 31.26923, 35.73829);
case 94: return new CityInfo("‘Anjarah", "20", 32.3063, 35.75653);
case 95: return new CityInfo("Amman", "16", 31.95522, 35.94503);
case 96: return new CityInfo("Ḩayy al Quwaysimah", "16", 31.91037, 35.94975);
case 97: return new CityInfo("Al Quwayrah", "19", 29.80045, 35.3116);
case 98: return new CityInfo("Al Qaţrānah", "09", 31.25083, 36.04932);
case 99: return new CityInfo("Al Qaşr", "09", 31.31407, 35.74393);
case 100: return new CityInfo("Ghawr al Mazra‘ah", "09", 31.26586, 35.51674);
case 101: return new CityInfo("Al Mazār ash Shamālī", "18", 32.47041, 35.79693);
case 102: return new CityInfo("Al Mazār al Janūbī", "09", 31.06722, 35.69486);
case 103: return new CityInfo("Al Maşţabah", "22", 32.18434, 35.85588);
case 104: return new CityInfo("Manshīyat Banī Ḩasan", "15", 32.37066, 36.07933);
case 105: return new CityInfo("Mafraq", "15", 32.34289, 36.20804);
case 106: return new CityInfo("‘Allān", "02", 32.11815, 35.74351);
case 107: return new CityInfo("Al Kittah", "22", 32.27685, 35.84114);
case 108: return new CityInfo("Al Karāmah", "02", 31.95439, 35.58033);
case 109: return new CityInfo("Qīr Moāv", "19", 31.18248, 35.69999);
case 110: return new CityInfo("Al Juwayyidah", "16", 31.88715, 35.93144);
case 111: return new CityInfo("Al Jubayhah", "16", 32.01071, 35.89802);
case 112: return new CityInfo("Al Jīzah", "16", 31.69893, 35.9553);
case 113: return new CityInfo("Al Jafr", "19", 30.3184, 36.17775);
case 114: return new CityInfo("Al Ḩusaynīyah", "09", 31.02606, 35.72294);
case 115: return new CityInfo("Al Ḩişn", "18", 32.48454, 35.88406);
case 116: return new CityInfo("Al Hāshimīyah", "17", 32.12901, 36.1213);
case 117: return new CityInfo("Al Ḩasā", "12", 30.82131, 35.97499);
case 118: return new CityInfo("Al Ḩamrā’", "15", 32.44017, 36.15265);
case 119: return new CityInfo("Al Fuḩayş", "02", 32.00468, 35.78088);
case 120: return new CityInfo("Ḩayy al Bunayyāt", "16", 31.89603, 35.88465);
case 121: return new CityInfo("Al ‘Arīḑ", "23", 31.55839, 35.65736);
case 122: return new CityInfo("Aqaba", "21", 29.52667, 35.00778);
case 123: return new CityInfo("‘Ajlūn", "20", 32.33326, 35.75279);
case 124: return new CityInfo("Adir", "09", 31.20217, 35.76155);
case 125: return new CityInfo("Al Khālidīyah", "15", 32.179, 36.30326);
case 126: return new CityInfo("Ar Rīshah", "21", 30.22435, 35.21671);
case 127: return new CityInfo("Al Muwaqqar", "16", 31.81473, 36.10879);
case 128: return new CityInfo("Karak City", "09", 31.16368, 35.76204);
case 129: return new CityInfo("Al Ḩusaynīyah", "19", 30.59545, 35.79701);
case 130: return new CityInfo("Ad Dīsah", "21", 29.65284, 35.51123);
case 131: return new CityInfo("Russeifa", "17", 32.01778, 36.04639);
case 132: return new CityInfo("Muthallath Şabḩā", "15", 32.26011, 36.4678);
case 133: return new CityInfo("Tala Bay", "21", 29.40842, 34.97918);
case 134: return new CityInfo("Muthallath Jāmi‘at Āl al Bayt", "15", 32.34592, 36.23352);
case 135: return new CityInfo("Az̧ Z̧ulayl", "17", 32.1208, 36.28008);
case 136: return new CityInfo("Al ‘Abdallī", "16", 31.96501, 35.90821);
case 137: return new CityInfo("Dayr al Kahf", "15", 32.27535, 36.83949);
default: return new CityInfo("Rukban", "15", 33.31405, 38.70342);

                                    }                                        
                                }
                            
                        }
                    }
                