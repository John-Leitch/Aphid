
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
                                    public const string Country = "MA";
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
                            
                                        var cur = (Math.Abs(26.73841 - lat) + Math.Abs(-11.67194 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(34.80321 - lat) + Math.Abs(-5.34458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.43 - lat) + Math.Abs(-5.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.6141 - lat) + Math.Abs(-5.45191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.22508 - lat) + Math.Abs(-7.67751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.64445 - lat) + Math.Abs(-5.91826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.94282 - lat) + Math.Abs(-2.7329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.33241 - lat) + Math.Abs(-5.8384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.0221 - lat) + Math.Abs(-9.29397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.24634 - lat) + Math.Abs(-8.52941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.53501 - lat) + Math.Abs(-7.49291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.9065 - lat) + Math.Abs(-4.02696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.97159 - lat) + Math.Abs(-3.15273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.69742 - lat) + Math.Abs(-9.73162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.22836 - lat) + Math.Abs(-8.31611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.55808 - lat) + Math.Abs(-7.48647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.28791 - lat) + Math.Abs(-4.66372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.23619 - lat) + Math.Abs(-3.95453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.3887 - lat) + Math.Abs(-8.69572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.36679 - lat) + Math.Abs(-1.83705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.51472 - lat) + Math.Abs(-5.53278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.20368 - lat) + Math.Abs(-6.4666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.58 - lat) + Math.Abs(-4.73 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.88366 - lat) + Math.Abs(-9.04548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.81794 - lat) + Math.Abs(-5.76812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.62777 - lat) + Math.Abs(-6.94093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.89469 - lat) + Math.Abs(-6.30649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.57845 - lat) + Math.Abs(-5.36837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.92866 - lat) + Math.Abs(-6.90656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.28925 - lat) + Math.Abs(-7.23789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.66991 - lat) + Math.Abs(-4.63392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.57836 - lat) + Math.Abs(-7.20341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.40854 - lat) + Math.Abs(-8.829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.88307 - lat) + Math.Abs(-4.1862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.21 - lat) + Math.Abs(-4.01 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.74409 - lat) + Math.Abs(-7.973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.58153 - lat) + Math.Abs(-9.02664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.47028 - lat) + Math.Abs(-8.87695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.67452 - lat) + Math.Abs(-5.27331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.93769 - lat) + Math.Abs(-4.31856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.9392 - lat) + Math.Abs(-12.92604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.40731 - lat) + Math.Abs(-2.89732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.09368 - lat) + Math.Abs(-6.60607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.53661 - lat) + Math.Abs(-4.64009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.22218 - lat) + Math.Abs(-9.07943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.1299 - lat) + Math.Abs(-2.9279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.43799 - lat) + Math.Abs(-11.10321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.76727 - lat) + Math.Abs(-5.79975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.77548 - lat) + Math.Abs(-9.16796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.93632 - lat) + Math.Abs(-4.7794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.00087 - lat) + Math.Abs(-9.67802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.59 - lat) + Math.Abs(-4.19 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.81 - lat) + Math.Abs(-9.33 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.52917 - lat) + Math.Abs(-7.91262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.04965 - lat) + Math.Abs(-4.42162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.72449 - lat) + Math.Abs(-8.9747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.77477 - lat) + Math.Abs(-9.45951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.71923 - lat) + Math.Abs(-5.1403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.03009 - lat) + Math.Abs(-6.79985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.03462 - lat) + Math.Abs(-8.87688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.65255 - lat) + Math.Abs(-6.41049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.68664 - lat) + Math.Abs(-6.00272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.07452 - lat) + Math.Abs(-4.21583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.06262 - lat) + Math.Abs(-6.5525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.68011 - lat) + Math.Abs(-5.57738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.30494 - lat) + Math.Abs(-6.30404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.82461 - lat) + Math.Abs(-8.51122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.26479 - lat) + Math.Abs(-5.92598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.68692 - lat) + Math.Abs(-5.44538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.65031 - lat) + Math.Abs(-7.47288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.22149 - lat) + Math.Abs(-5.70775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.27209 - lat) + Math.Abs(-7.20095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.90783 - lat) + Math.Abs(-6.05069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.38952 - lat) + Math.Abs(-6.42095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.37975 - lat) + Math.Abs(-10.17299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.02733 - lat) + Math.Abs(-4.88343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.56283 - lat) + Math.Abs(-5.36208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.90226 - lat) + Math.Abs(-7.94169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.65236 - lat) + Math.Abs(-8.42769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.94987 - lat) + Math.Abs(-5.83225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.53544 - lat) + Math.Abs(-7.83243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.00103 - lat) + Math.Abs(-7.61662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.07313 - lat) + Math.Abs(-2.9423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.83186 - lat) + Math.Abs(-4.828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.0531 - lat) + Math.Abs(-6.79846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.08195 - lat) + Math.Abs(-2.22897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.29939 - lat) + Math.Abs(-9.23718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.14119 - lat) + Math.Abs(-4.13631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.28318 - lat) + Math.Abs(-4.26565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.76987 - lat) + Math.Abs(-2.46034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.47737 - lat) + Math.Abs(-5.30235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.58016 - lat) + Math.Abs(-9.70086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.77772 - lat) + Math.Abs(-4.93989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.01325 - lat) + Math.Abs(-6.83255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.53477 - lat) + Math.Abs(-4.96878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.42585 - lat) + Math.Abs(-6.00137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.39467 - lat) + Math.Abs(-9.20897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.94633 - lat) + Math.Abs(-4.99509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.40438 - lat) + Math.Abs(-4.69342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.2 - lat) + Math.Abs(-6.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.20603 - lat) + Math.Abs(-7.86089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.68139 - lat) + Math.Abs(-1.90858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.62777 - lat) + Math.Abs(-9.53959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.8627 - lat) + Math.Abs(-6.57359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.4484 - lat) + Math.Abs(-5.09627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.2 - lat) + Math.Abs(-4.28 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.79584 - lat) + Math.Abs(-5.57849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.91894 - lat) + Math.Abs(-6.89341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.73372 - lat) + Math.Abs(-9.03059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.37981 - lat) + Math.Abs(-7.61932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.16813 - lat) + Math.Abs(-2.93352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.08793 - lat) + Math.Abs(-5.18171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.28785 - lat) + Math.Abs(-7.9683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.48922 - lat) + Math.Abs(-5.13023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.19664 - lat) + Math.Abs(-8.58811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.0109 - lat) + Math.Abs(-3.00938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.68607 - lat) + Math.Abs(-7.38298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.04893 - lat) + Math.Abs(-3.98947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.6852 - lat) + Math.Abs(-4.74512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.94025 - lat) + Math.Abs(-3.53311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.89352 - lat) + Math.Abs(-5.54727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.45161 - lat) + Math.Abs(-7.51995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.57373 - lat) + Math.Abs(-5.95585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.68313 - lat) + Math.Abs(-5.32871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.09914 - lat) + Math.Abs(-4.55219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.61662 - lat) + Math.Abs(-5.27522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.63416 - lat) + Math.Abs(-7.99994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01032 - lat) + Math.Abs(-2.33701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.70217 - lat) + Math.Abs(-6.3494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.19321 - lat) + Math.Abs(-6.15572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.84606 - lat) + Math.Abs(-6.06645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.00044 - lat) + Math.Abs(-5.90378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.88108 - lat) + Math.Abs(-6.9063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.93492 - lat) + Math.Abs(-5.66167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.79639 - lat) + Math.Abs(-5.3188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.26101 - lat) + Math.Abs(-6.5802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.5977 - lat) + Math.Abs(-6.26844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.1071 - lat) + Math.Abs(-2.74693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.37094 - lat) + Math.Abs(-5.2138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.49442 - lat) + Math.Abs(-4.40598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.31 - lat) + Math.Abs(-2.16 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.8783 - lat) + Math.Abs(-5.0515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.22981 - lat) + Math.Abs(-6.27661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.35535 - lat) + Math.Abs(-9.53639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.37324 - lat) + Math.Abs(-5.79384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.15309 - lat) + Math.Abs(-5.62453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.83826 - lat) + Math.Abs(-7.90294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.52666 - lat) + Math.Abs(-5.11019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.83898 - lat) + Math.Abs(-2.86699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.4447 - lat) + Math.Abs(-7.39224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.61588 - lat) + Math.Abs(-5.7404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.95956 - lat) + Math.Abs(-8.2274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.76645 - lat) + Math.Abs(-7.49818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.22568 - lat) + Math.Abs(-3.35361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.48361 - lat) + Math.Abs(-2.04562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.98696 - lat) + Math.Abs(-10.05738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.69227 - lat) + Math.Abs(-4.95256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.54424 - lat) + Math.Abs(-4.80355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.84906 - lat) + Math.Abs(-5.35747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.50213 - lat) + Math.Abs(-6.68771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.10891 - lat) + Math.Abs(-1.22855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.94873 - lat) + Math.Abs(-5.24798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.52921 - lat) + Math.Abs(-4.45562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.0701 - lat) + Math.Abs(-4.95473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.03313 - lat) + Math.Abs(-5.00028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.3 - lat) + Math.Abs(-6.53 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.5125 - lat) + Math.Abs(-9.77 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.4353 - lat) + Math.Abs(-4.23258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.57286 - lat) + Math.Abs(-6.01947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.24573 - lat) + Math.Abs(-6.1326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.25682 - lat) + Math.Abs(-8.50882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.68786 - lat) + Math.Abs(-5.371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.87 - lat) + Math.Abs(-6.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.58319 - lat) + Math.Abs(-2.50612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.14637 - lat) + Math.Abs(-3.85063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.11041 - lat) + Math.Abs(-5.29015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.73443 - lat) + Math.Abs(-7.00505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.98228 - lat) + Math.Abs(-3.04263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.15122 - lat) + Math.Abs(-7.37504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.31247 - lat) + Math.Abs(-6.90494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.51535 - lat) + Math.Abs(-7.81677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.5377 - lat) + Math.Abs(-5.71742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.54351 - lat) + Math.Abs(-8.76275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.16878 - lat) + Math.Abs(-5.2636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.58831 - lat) + Math.Abs(-7.61138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.09171 - lat) + Math.Abs(-7.04786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.96732 - lat) + Math.Abs(-5.57295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.78942 - lat) + Math.Abs(-7.15968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.44976 - lat) + Math.Abs(-7.65239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.7236 - lat) + Math.Abs(-5.1025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.36376 - lat) + Math.Abs(-4.72896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.85995 - lat) + Math.Abs(-8.05555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.15601 - lat) + Math.Abs(-3.62358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.53379 - lat) + Math.Abs(-1.96209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.26554 - lat) + Math.Abs(-9.17865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.72376 - lat) + Math.Abs(-9.21097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.85194 - lat) + Math.Abs(-4.87228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.92 - lat) + Math.Abs(-2.32 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.33725 - lat) + Math.Abs(-6.34983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.26553 - lat) + Math.Abs(-7.58754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.06166 - lat) + Math.Abs(-5.19828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.43443 - lat) + Math.Abs(-5.22126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.96156 - lat) + Math.Abs(-6.57109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.13753 - lat) + Math.Abs(-8.31488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.28952 - lat) + Math.Abs(-8.3425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.95286 - lat) + Math.Abs(-5.20812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.23 - lat) + Math.Abs(-8.86 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.46522 - lat) + Math.Abs(-6.03415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.7825 - lat) + Math.Abs(-9.11968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.90239 - lat) + Math.Abs(-5.94871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.50346 - lat) + Math.Abs(-8.60637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.49238 - lat) + Math.Abs(-9.6355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.67307 - lat) + Math.Abs(-8.18087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.68 - lat) + Math.Abs(-4.17 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.27491 - lat) + Math.Abs(-4.93535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.21673 - lat) + Math.Abs(-8.23184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.0437 - lat) + Math.Abs(-7.21037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.74983 - lat) + Math.Abs(-4.47063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.19153 - lat) + Math.Abs(-8.74873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.11411 - lat) + Math.Abs(-5.17154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.32 - lat) + Math.Abs(-4.18 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.82404 - lat) + Math.Abs(-6.06627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.25165 - lat) + Math.Abs(-3.93723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.65371 - lat) + Math.Abs(-3.86754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.74347 - lat) + Math.Abs(-3.97582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.06914 - lat) + Math.Abs(-5.93961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.28984 - lat) + Math.Abs(-5.33863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.0097 - lat) + Math.Abs(-2.03238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.95368 - lat) + Math.Abs(-2.10027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.16139 - lat) + Math.Abs(-5.84626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.69356 - lat) + Math.Abs(-6.44628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.22492 - lat) + Math.Abs(-7.79601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.42018 - lat) + Math.Abs(-9.59815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.10783 - lat) + Math.Abs(-8.49083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.14111 - lat) + Math.Abs(-8.37221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.8527 - lat) + Math.Abs(-7.03171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.57917 - lat) + Math.Abs(-7.31308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.38 - lat) + Math.Abs(-7.14 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.46586 - lat) + Math.Abs(-7.61199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(29.82 - lat) + Math.Abs(-5.72 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.54259 - lat) + Math.Abs(-9.71115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.69602 - lat) + Math.Abs(-9.82972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.21014 - lat) + Math.Abs(-9.70863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.41211 - lat) + Math.Abs(-5.06836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.36 - lat) + Math.Abs(-4.81 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.55303 - lat) + Math.Abs(-5.24472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.7328 - lat) + Math.Abs(-5.89954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.02722 - lat) + Math.Abs(-5.11643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.90046 - lat) + Math.Abs(-6.77464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.9314 - lat) + Math.Abs(-4.42663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.523 - lat) + Math.Abs(-7.833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.41071 - lat) + Math.Abs(-9.55572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.80622 - lat) + Math.Abs(-2.41297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.09455 - lat) + Math.Abs(-12.05157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.14276 - lat) + Math.Abs(-12.37168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.67478 - lat) + Math.Abs(-8.17424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.99722 - lat) + Math.Abs(-6.74047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.6597 - lat) + Math.Abs(-5.28525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.10506 - lat) + Math.Abs(-3.84028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.6558 - lat) + Math.Abs(-15.60719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.04349 - lat) + Math.Abs(-5.23378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Smara", "11", 26.73841, -11.67194);
case 1: return new CityInfo("Zoumi", "01", 34.80321, -5.34458);
case 2: return new CityInfo("Zinat", "01", 35.43, -5.4);
case 3: return new CityInfo("Saddina", "01", 35.6141, -5.45191);
case 4: return new CityInfo("Setti Fatma", "07", 31.22508, -7.67751);
case 5: return new CityInfo("Zawyat ech Cheïkh", "05", 32.64445, -5.91826);
case 6: return new CityInfo("Zaïo", "02", 34.94282, -2.7329);
case 7: return new CityInfo("Zagora", "08", 30.33241, -5.8384);
case 8: return new CityInfo("Zag", "10", 28.0221, -9.29397);
case 9: return new CityInfo("Youssoufia", "07", 32.24634, -8.52941);
case 10: return new CityInfo("Touama", "07", 31.53501, -7.49291);
case 11: return new CityInfo("Tmourghout", "03", 33.9065, -4.02696);
case 12: return new CityInfo("Tiztoutine", "02", 34.97159, -3.15273);
case 13: return new CityInfo("Tiznit", "09", 29.69742, -9.73162);
case 14: return new CityInfo("Tizguine", "07", 31.22836, -8.31611);
case 15: return new CityInfo("Tit Mellil", "06", 33.55808, -7.48647);
case 16: return new CityInfo("Tissa", "03", 34.28791, -4.66372);
case 17: return new CityInfo("Tirhanimîne", "01", 35.23619, -3.95453);
case 18: return new CityInfo("Tiout", "09", 30.3887, -8.69572);
case 19: return new CityInfo("Tiouli", "02", 34.36679, -1.83705);
case 20: return new CityInfo("Tinghir", "08", 31.51472, -5.53278);
case 21: return new CityInfo("Timoulilt", "05", 32.20368, -6.4666);
case 22: return new CityInfo("Timezgana", "03", 34.58, -4.73);
case 23: return new CityInfo("Timezgadiouine", "07", 30.88366, -9.04548);
case 24: return new CityInfo("Tilmi", "08", 31.81794, -5.76812);
case 25: return new CityInfo("Tifni", "05", 31.62777, -6.94093);
case 26: return new CityInfo("Tiflet", "04", 33.89469, -6.30649);
case 27: return new CityInfo("Tétouan", "01", 35.57845, -5.36837);
case 28: return new CityInfo("Temara", "04", 33.92866, -6.90656);
case 29: return new CityInfo("Telouet", "08", 31.28925, -7.23789);
case 30: return new CityInfo("Tazouta", "03", 33.66991, -4.63392);
case 31: return new CityInfo("Taznakht", "08", 30.57836, -7.20341);
case 32: return new CityInfo("Tazemmourt", "09", 30.40854, -8.829);
case 33: return new CityInfo("Tazarine", "03", 33.88307, -4.1862);
case 34: return new CityInfo("Taza", "03", 34.21, -4.01);
case 35: return new CityInfo("Tata", "09", 29.74409, -7.973);
case 36: return new CityInfo("Tarsouat", "09", 29.58153, -9.02664);
case 37: return new CityInfo("Taroudant", "09", 30.47028, -8.87695);
case 38: return new CityInfo("Teroual", "04", 34.67452, -5.27331);
case 39: return new CityInfo("Targuist", "01", 34.93769, -4.31856);
case 40: return new CityInfo("Tarfaya", "11", 27.9392, -12.92604);
case 41: return new CityInfo("Taourirt", "02", 34.40731, -2.89732);
case 42: return new CityInfo("Taounza", "05", 32.09368, -6.60607);
case 43: return new CityInfo("Taounate", "03", 34.53661, -4.64009);
case 44: return new CityInfo("Taouloukoult", "07", 31.22218, -9.07943);
case 45: return new CityInfo("Taouima", "02", 35.1299, -2.9279);
case 46: return new CityInfo("Tan-Tan", "10", 28.43799, -11.10321);
case 47: return new CityInfo("Tangier", "01", 35.76727, -5.79975);
case 48: return new CityInfo("Tanalt", "09", 29.77548, -9.16796);
case 49: return new CityInfo("Tamorot", "01", 34.93632, -4.7794);
case 50: return new CityInfo("Tamanar", "07", 31.00087, -9.67802);
case 51: return new CityInfo("Talzemt", "03", 33.59, -4.19);
case 52: return new CityInfo("Talmest", "07", 31.81, -9.33);
case 53: return new CityInfo("Taliouine", "09", 30.52917, -7.91262);
case 54: return new CityInfo("Tahla", "03", 34.04965, -4.42162);
case 55: return new CityInfo("Tafraout", "09", 29.72449, -8.9747);
case 56: return new CityInfo("Tadrart", "09", 30.77477, -9.45951);
case 57: return new CityInfo("Tabouda", "03", 34.71923, -5.1403);
case 58: return new CityInfo("Tabia", "05", 32.03009, -6.79985);
case 59: return new CityInfo("Tabia", "09", 30.03462, -8.87688);
case 60: return new CityInfo("Tabant", "05", 31.65255, -6.41049);
case 61: return new CityInfo("Souq Larb’a al Gharb", "04", 34.68664, -6.00272);
case 62: return new CityInfo("Senada", "01", 35.07452, -4.21583);
case 63: return new CityInfo("Skoura", "08", 31.06262, -6.5525);
case 64: return new CityInfo("Sidi Yahya Ou Saad", "05", 32.68011, -5.57738);
case 65: return new CityInfo("Sidi Yahia El Gharb", "04", 34.30494, -6.30404);
case 66: return new CityInfo("Sidi Smai’il", "06", 32.82461, -8.51122);
case 67: return new CityInfo("Sidi Slimane", "04", 34.26479, -5.92598);
case 68: return new CityInfo("Sidi Redouane", "04", 34.68692, -5.44538);
case 69: return new CityInfo("Sidi Rahhal", "07", 31.65031, -7.47288);
case 70: return new CityInfo("Sidi Qacem", "04", 34.22149, -5.70775);
case 71: return new CityInfo("Sidi Moussa", "07", 32.27209, -7.20095);
case 72: return new CityInfo("Sidi Lamine", "05", 32.90783, -6.05069);
case 73: return new CityInfo("Sidi Jaber", "05", 32.38952, -6.42095);
case 74: return new CityInfo("Sidi Ifni", "09", 29.37975, -10.17299);
case 75: return new CityInfo("Sidi Harazem", "03", 34.02733, -4.88343);
case 76: return new CityInfo("Sidi Bousber", "04", 34.56283, -5.36208);
case 77: return new CityInfo("Sidi Bou Othmane", "07", 31.90226, -7.94169);
case 78: return new CityInfo("Sidi Bennour", "06", 32.65236, -8.42769);
case 79: return new CityInfo("Sidi Amar", "05", 32.94987, -5.83225);
case 80: return new CityInfo("Sidi Abdallah", "07", 32.53544, -7.83243);
case 81: return new CityInfo("Settat", "06", 33.00103, -7.61662);
case 82: return new CityInfo("Selouane", "02", 35.07313, -2.9423);
case 83: return new CityInfo("Sefrou", "03", 33.83186, -4.828);
case 84: return new CityInfo("Sale", "04", 34.0531, -6.79846);
case 85: return new CityInfo("Saidia", "02", 35.08195, -2.22897);
case 86: return new CityInfo("Safi", "07", 32.29939, -9.23718);
case 87: return new CityInfo("Rouadi", "01", 35.14119, -4.13631);
case 88: return new CityInfo("Reçani", "08", 31.28318, -4.26565);
case 89: return new CityInfo("Rislane", "02", 34.76987, -2.46034);
case 90: return new CityInfo("Ghouazi", "03", 34.47737, -5.30235);
case 91: return new CityInfo("Reggada", "09", 29.58016, -9.70086);
case 92: return new CityInfo("Ratba", "03", 34.77772, -4.93989);
case 93: return new CityInfo("Rabat", "04", 34.01325, -6.83255);
case 94: return new CityInfo("Ourtzagh", "03", 34.53477, -4.96878);
case 95: return new CityInfo("Oulmes", "04", 33.42585, -6.00137);
case 96: return new CityInfo("Oulad Teïma", "09", 30.39467, -9.20897);
case 97: return new CityInfo("Oulad Tayeb", "03", 33.94633, -4.99509);
case 98: return new CityInfo("Oulad Daoud", "03", 34.40438, -4.69342);
case 99: return new CityInfo("Oulad Ayad", "05", 32.2, -6.8);
case 100: return new CityInfo("Oukaïmedene", "07", 31.20603, -7.86089);
case 101: return new CityInfo("Oujda-Angad", "02", 34.68139, -1.90858);
case 102: return new CityInfo("Ouijjane", "09", 29.62777, -9.53959);
case 103: return new CityInfo("Oued Zem", "05", 32.8627, -6.57359);
case 104: return new CityInfo("Oued Laou", "01", 35.4484, -5.09627);
case 105: return new CityInfo("Oued Amlil", "03", 34.2, -4.28);
case 106: return new CityInfo("Ouezzane", "01", 34.79584, -5.57849);
case 107: return new CityInfo("Ouarzazat", "08", 30.91894, -6.89341);
case 108: return new CityInfo("Oualidia", "06", 32.73372, -9.03059);
case 109: return new CityInfo("Zawyat an Nwaçer", "06", 33.37981, -7.61932);
case 110: return new CityInfo("Nador", "02", 35.16813, -2.93352);
case 111: return new CityInfo("Moulay Yacoub", "03", 34.08793, -5.18171);
case 112: return new CityInfo("Moulay Brahim", "07", 31.28785, -7.9683);
case 113: return new CityInfo("Moulay Bouchta", "03", 34.48922, -5.13023);
case 114: return new CityInfo("Moulay Abdallah", "06", 33.19664, -8.58811);
case 115: return new CityInfo("Al Aaroui", "02", 35.0109, -3.00938);
case 116: return new CityInfo("Mohammedia", "06", 33.68607, -7.38298);
case 117: return new CityInfo("Missour", "03", 33.04893, -3.98947);
case 118: return new CityInfo("Midelt", "05", 32.6852, -4.74512);
case 119: return new CityInfo("Midar", "02", 34.94025, -3.53311);
case 120: return new CityInfo("Meknès", "03", 33.89352, -5.54727);
case 121: return new CityInfo("Mediouna", "06", 33.45161, -7.51995);
case 122: return new CityInfo("Mechraa Bel Ksiri", "04", 34.57373, -5.95585);
case 123: return new CityInfo("Mdiq", "01", 35.68313, -5.32871);
case 124: return new CityInfo("Matmata", "03", 34.09914, -4.55219);
case 125: return new CityInfo("Martil", "01", 35.61662, -5.27522);
case 126: return new CityInfo("Marrakesh", "07", 31.63416, -7.99994);
case 127: return new CityInfo("Madagh", "02", 35.01032, -2.33701);
case 128: return new CityInfo("Ifrane", "05", 31.70217, -6.3494);
case 129: return new CityInfo("Larache", "01", 35.19321, -6.15572);
case 130: return new CityInfo("Lalla Mimouna", "04", 34.84606, -6.06645);
case 131: return new CityInfo("Ksar El Kebir", "01", 35.00044, -5.90378);
case 132: return new CityInfo("Khouribga", "05", 32.88108, -6.9063);
case 133: return new CityInfo("Khenifra", "05", 32.93492, -5.66167);
case 134: return new CityInfo("Kerrouchen", "05", 32.79639, -5.3188);
case 135: return new CityInfo("Kenitra", "04", 34.26101, -6.5802);
case 136: return new CityInfo("Kasba Tadla", "05", 32.5977, -6.26844);
case 137: return new CityInfo("Kariat Arkmane", "02", 35.1071, -2.74693);
case 138: return new CityInfo("Karia Ba Mohamed", "03", 34.37094, -5.2138);
case 139: return new CityInfo("Jorf", "08", 31.49442, -4.40598);
case 140: return new CityInfo("Jerada", "02", 34.31, -2.16);
case 141: return new CityInfo("Itzer", "05", 32.8783, -5.0515);
case 142: return new CityInfo("Isseksi", "05", 32.22981, -6.27661);
case 143: return new CityInfo("Inezgane", "09", 30.35535, -9.53639);
case 144: return new CityInfo("Imider", "08", 31.37324, -5.79384);
case 145: return new CityInfo("Imilchil", "08", 32.15309, -5.62453);
case 146: return new CityInfo("Iguidi", "09", 30.83826, -7.90294);
case 147: return new CityInfo("Ifrane", "03", 33.52666, -5.11019);
case 148: return new CityInfo("Hassi Berkane", "02", 34.83898, -2.86699);
case 149: return new CityInfo("Zerkten", "07", 31.4447, -7.39224);
case 150: return new CityInfo("Had Kourt", "04", 34.61588, -5.7404);
case 151: return new CityInfo("Oulad Frej", "06", 32.95956, -8.2274);
case 152: return new CityInfo("Guisser", "06", 32.76645, -7.49818);
case 153: return new CityInfo("Guercif", "03", 34.22568, -3.35361);
case 154: return new CityInfo("Guenfouda", "02", 34.48361, -2.04562);
case 155: return new CityInfo("Guelmim", "10", 28.98696, -10.05738);
case 156: return new CityInfo("Goulmima", "08", 31.69227, -4.95256);
case 157: return new CityInfo("Galaz", "03", 34.54424, -4.80355);
case 158: return new CityInfo("Fnidek", "01", 35.84906, -5.35747);
case 159: return new CityInfo("Al Fqih Ben Çalah", "05", 32.50213, -6.68771);
case 160: return new CityInfo("Figuig (Centre)", "54", 32.10891, -1.22855);
case 161: return new CityInfo("Fifi", "01", 34.94873, -5.24798);
case 162: return new CityInfo("Fezna", "08", 31.52921, -4.45562);
case 163: return new CityInfo("Fès al Bali", "03", 34.0701, -4.95473);
case 164: return new CityInfo("Fès", "03", 34.03313, -5.00028);
case 165: return new CityInfo("Ezzhiliga", "04", 33.3, -6.53);
case 166: return new CityInfo("Essaouira", "07", 31.5125, -9.77);
case 167: return new CityInfo("Arfoud", "08", 31.4353, -4.23258);
case 168: return new CityInfo("El Ksiba", "05", 32.57286, -6.01947);
case 169: return new CityInfo("Kelaat Mgouna", "08", 31.24573, -6.1326);
case 170: return new CityInfo("El Jadid", "06", 33.25682, -8.50882);
case 171: return new CityInfo("El Hajeb", "03", 33.68786, -5.371);
case 172: return new CityInfo("Ouaoula", "05", 31.87, -6.75);
case 173: return new CityInfo("El Aïoun", "02", 34.58319, -2.50612);
case 174: return new CityInfo("Imzouren", "01", 35.14637, -3.85063);
case 175: return new CityInfo("Derdara", "01", 35.11041, -5.29015);
case 176: return new CityInfo("Demnate", "05", 31.73443, -7.00505);
case 177: return new CityInfo("Debdou", "02", 33.98228, -3.04263);
case 178: return new CityInfo("Riah", "06", 33.15122, -7.37504);
case 179: return new CityInfo("Dar Ould Zidouh", "05", 32.31247, -6.90494);
case 180: return new CityInfo("Dar Bouazza", "06", 33.51535, -7.81677);
case 181: return new CityInfo("Dar Chaoui", "01", 35.5377, -5.71742);
case 182: return new CityInfo("Chichaoua", "07", 31.54351, -8.76275);
case 183: return new CityInfo("Chefchaouene", "01", 35.16878, -5.2636);
case 184: return new CityInfo("Casablanca", "06", 33.58831, -7.61138);
case 185: return new CityInfo("Bzou", "05", 32.09171, -7.04786);
case 186: return new CityInfo("Brikcha", "01", 34.96732, -5.57295);
case 187: return new CityInfo("Bouznika", "06", 33.78942, -7.15968);
case 188: return new CityInfo("Bouskoura", "06", 33.44976, -7.65239);
case 189: return new CityInfo("Boumia", "05", 32.7236, -5.1025);
case 190: return new CityInfo("Boulemane", "03", 33.36376, -4.72896);
case 191: return new CityInfo("Boulaouane", "06", 32.85995, -8.05555);
case 192: return new CityInfo("Boudinar", "02", 35.15601, -3.62358);
case 193: return new CityInfo("Bouarfa", "02", 32.53379, -1.96209);
case 194: return new CityInfo("Bouabout", "07", 31.26554, -9.17865);
case 195: return new CityInfo("Bigoudine", "09", 30.72376, -9.21097);
case 196: return new CityInfo("Bhalil", "03", 33.85194, -4.87228);
case 197: return new CityInfo("Berkane", "02", 34.92, -2.32);
case 198: return new CityInfo("Beni Mellal", "05", 32.33725, -6.34983);
case 199: return new CityInfo("Berrechid", "06", 33.26553, -7.58754);
case 200: return new CityInfo("Bab Taza", "01", 35.06166, -5.19828);
case 201: return new CityInfo("Azrou", "03", 33.43443, -5.22126);
case 202: return new CityInfo("Azilal", "05", 31.96156, -6.57109);
case 203: return new CityInfo("Azgour", "07", 31.13753, -8.31488);
case 204: return new CityInfo("Azemmour", "06", 33.28952, -8.3425);
case 205: return new CityInfo("Assoul", "08", 31.95286, -5.20812);
case 206: return new CityInfo("Assads", "09", 30.23, -8.86);
case 207: return new CityInfo("Asilah", "01", 35.46522, -6.03415);
case 208: return new CityInfo("Argana", "09", 30.7825, -9.11968);
case 209: return new CityInfo("Arbaoua", "04", 34.90239, -5.94871);
case 210: return new CityInfo("Arazane", "09", 30.50346, -8.60637);
case 211: return new CityInfo("Aourir", "09", 30.49238, -9.6355);
case 212: return new CityInfo("Aoulouz", "09", 30.67307, -8.18087);
case 213: return new CityInfo("Aoufous", "08", 31.68, -4.17);
case 214: return new CityInfo("Amouguer", "08", 32.27491, -4.93535);
case 215: return new CityInfo("Amizmiz", "07", 31.21673, -8.23184);
case 216: return new CityInfo("Amerzgane", "08", 31.0437, -7.21037);
case 217: return new CityInfo("Amersid", "05", 32.74983, -4.47063);
case 218: return new CityInfo("Amalou", "09", 30.19153, -8.74873);
case 219: return new CityInfo("Alnif", "08", 31.11411, -5.17154);
case 220: return new CityInfo("Almis Marmoucha", "03", 33.32, -4.18);
case 221: return new CityInfo("Khemisset", "04", 33.82404, -6.06627);
case 222: return new CityInfo("Al Hoceïma", "01", 35.25165, -3.93723);
case 223: return new CityInfo("Aknoul", "03", 34.65371, -3.86754);
case 224: return new CityInfo("Ajdir", "03", 34.74347, -3.97582);
case 225: return new CityInfo("Anergui", "05", 32.06914, -5.93961);
case 226: return new CityInfo("Aïn Leuh", "03", 33.28984, -5.33863);
case 227: return new CityInfo("Aïn Beni Mathar", "02", 34.0097, -2.03238);
case 228: return new CityInfo("Ahfir", "02", 34.95368, -2.10027);
case 229: return new CityInfo("Aguelmous", "05", 33.16139, -5.84626);
case 230: return new CityInfo("Agdz", "08", 30.69356, -6.44628);
case 231: return new CityInfo("Agadir Melloul", "09", 30.22492, -7.79601);
case 232: return new CityInfo("Agadir", "09", 30.42018, -9.59815);
case 233: return new CityInfo("Adassil", "07", 31.10783, -8.49083);
case 234: return new CityInfo("Adar", "09", 30.14111, -8.37221);
case 235: return new CityInfo("Skhirate", "04", 33.8527, -7.03171);
case 236: return new CityInfo("Abadou", "07", 31.57917, -7.31308);
case 237: return new CityInfo("Mellila", "06", 33.38, -7.14);
case 238: return new CityInfo("Tidili Mesfioua", "07", 31.46586, -7.61199);
case 239: return new CityInfo("Mhamid", "08", 29.82, -5.72);
case 240: return new CityInfo("Taghazout", "09", 30.54259, -9.71115);
case 241: return new CityInfo("Tamri", "09", 30.69602, -9.82972);
case 242: return new CityInfo("Smimou", "07", 31.21014, -9.70863);
case 243: return new CityInfo("Tizgane", "01", 35.41211, -5.06836);
case 244: return new CityInfo("Bouarouss", "03", 34.36, -4.81);
case 245: return new CityInfo("Azla", "01", 35.55303, -5.24472);
case 246: return new CityInfo("Boukhalef", "01", 35.7328, -5.89954);
case 247: return new CityInfo("Jebel Tiskaouine", "08", 31.02722, -5.11643);
case 248: return new CityInfo("Boujniba", "05", 32.90046, -6.77464);
case 249: return new CityInfo("Errachidia", "08", 31.9314, -4.42663);
case 250: return new CityInfo("Sidi Abdallah Ghiat", "", 31.523, -7.833);
case 251: return new CityInfo("Dakhla", "EH", 30.41071, -9.55572);
case 252: return new CityInfo("Mosquée", "", 34.80622, -2.41297);
case 253: return new CityInfo("Akhfennir", "11", 28.09455, -12.05157);
case 254: return new CityInfo("Gueltat Zemmour", "11", 25.14276, -12.37168);
case 255: return new CityInfo("Zawit Al Bour", "09", 30.67478, -8.17424);
case 256: return new CityInfo("Salé Al Jadida", "04", 33.99722, -6.74047);
case 257: return new CityInfo("Cap Negro II", "01", 35.6597, -5.28525);
case 258: return new CityInfo("Bni Bouayach", "01", 35.10506, -3.84028);
case 259: return new CityInfo("Imlili", "12", 22.6558, -15.60719);
default: return new CityInfo("Mahroun", "", 35.04349, -5.23378);

                                    }                                        
                                }
                            
                        }
                    }
                