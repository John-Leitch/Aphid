
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
                                    public const string Country = "SY";
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
                            
                                        var cur = (Math.Abs(34.93998 - lat) + Math.Abs(36.32212 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(35.86865 - lat) + Math.Abs(39.27803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.88981 - lat) + Math.Abs(36.48336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.03247 - lat) + Math.Abs(36.5742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.23349 - lat) + Math.Abs(40.3166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.96921 - lat) + Math.Abs(36.65729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.00119 - lat) + Math.Abs(36.18683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.0431 - lat) + Math.Abs(37.46442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.26592 - lat) + Math.Abs(36.71219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.83395 - lat) + Math.Abs(35.96973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88902 - lat) + Math.Abs(35.88659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.65556 - lat) + Math.Abs(40.37079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.25884 - lat) + Math.Abs(36.38461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.47229 - lat) + Math.Abs(37.09471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.66842 - lat) + Math.Abs(36.25995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.75678 - lat) + Math.Abs(41.39943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.87632 - lat) + Math.Abs(36.524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.80776 - lat) + Math.Abs(37.25378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.69648 - lat) + Math.Abs(38.95382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.14849 - lat) + Math.Abs(36.03288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.84072 - lat) + Math.Abs(36.73092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.99832 - lat) + Math.Abs(36.78579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.73709 - lat) + Math.Abs(36.06654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.5624 - lat) + Math.Abs(38.28402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.34814 - lat) + Math.Abs(37.5309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.56579 - lat) + Math.Abs(37.2127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.29193 - lat) + Math.Abs(36.74848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.36674 - lat) + Math.Abs(36.39359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.85305 - lat) + Math.Abs(40.59987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.59822 - lat) + Math.Abs(36.1877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.58838 - lat) + Math.Abs(38.29788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.8104 - lat) + Math.Abs(36.15787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.59011 - lat) + Math.Abs(37.00472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.75059 - lat) + Math.Abs(38.07676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.77863 - lat) + Math.Abs(36.42366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.82944 - lat) + Math.Abs(36.15933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.50069 - lat) + Math.Abs(36.59945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.50509 - lat) + Math.Abs(36.24377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.62336 - lat) + Math.Abs(36.93659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.89773 - lat) + Math.Abs(36.69653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.85514 - lat) + Math.Abs(36.62896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.69473 - lat) + Math.Abs(36.37146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.28198 - lat) + Math.Abs(36.01947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.90403 - lat) + Math.Abs(36.72501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.86447 - lat) + Math.Abs(36.80591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.59596 - lat) + Math.Abs(39.1299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.13865 - lat) + Math.Abs(36.45244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.492 - lat) + Math.Abs(36.71114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01127 - lat) + Math.Abs(37.05324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.87271 - lat) + Math.Abs(36.57271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.42531 - lat) + Math.Abs(36.22552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82099 - lat) + Math.Abs(36.11773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.31248 - lat) + Math.Abs(36.92562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.15595 - lat) + Math.Abs(37.20908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.77974 - lat) + Math.Abs(37.68357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.53879 - lat) + Math.Abs(36.91909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.24486 - lat) + Math.Abs(37.71607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.85034 - lat) + Math.Abs(40.07055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.75623 - lat) + Math.Abs(36.3883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.67598 - lat) + Math.Abs(36.66415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.29203 - lat) + Math.Abs(36.01592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.13849 - lat) + Math.Abs(36.61247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.029 - lat) + Math.Abs(41.54596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.43757 - lat) + Math.Abs(36.07888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.82439 - lat) + Math.Abs(35.95193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.99233 - lat) + Math.Abs(36.06018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.15558 - lat) + Math.Abs(36.74284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03357 - lat) + Math.Abs(36.01455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.41465 - lat) + Math.Abs(36.39085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.54832 - lat) + Math.Abs(36.21563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.37867 - lat) + Math.Abs(36.99294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.89044 - lat) + Math.Abs(36.0399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.71084 - lat) + Math.Abs(36.02751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.5318 - lat) + Math.Abs(36.07003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.63346 - lat) + Math.Abs(40.84054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.37615 - lat) + Math.Abs(36.6897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.81521 - lat) + Math.Abs(37.08677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.2479 - lat) + Math.Abs(36.5725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.78735 - lat) + Math.Abs(36.4721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.32836 - lat) + Math.Abs(35.92144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.0653 - lat) + Math.Abs(36.3406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.96577 - lat) + Math.Abs(38.04165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.87462 - lat) + Math.Abs(36.25099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.23203 - lat) + Math.Abs(35.75572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.74607 - lat) + Math.Abs(40.75304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.48259 - lat) + Math.Abs(37.19709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.52815 - lat) + Math.Abs(37.95495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.84529 - lat) + Math.Abs(36.54514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.50795 - lat) + Math.Abs(36.85719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.24168 - lat) + Math.Abs(37.05843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.7552 - lat) + Math.Abs(39.59835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.69032 - lat) + Math.Abs(36.10354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.56246 - lat) + Math.Abs(36.74292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.01152 - lat) + Math.Abs(36.67183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.6483 - lat) + Math.Abs(36.67693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.16685 - lat) + Math.Abs(37.53815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.38972 - lat) + Math.Abs(36.48773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.7441 - lat) + Math.Abs(36.164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.78656 - lat) + Math.Abs(36.03825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.30088 - lat) + Math.Abs(40.28916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.70122 - lat) + Math.Abs(36.55658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.84324 - lat) + Math.Abs(36.45493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.80454 - lat) + Math.Abs(36.00077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.73376 - lat) + Math.Abs(36.20455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.44208 - lat) + Math.Abs(36.65095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.78159 - lat) + Math.Abs(37.49919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.18378 - lat) + Math.Abs(35.89158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.2311 - lat) + Math.Abs(38.02172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.66945 - lat) + Math.Abs(37.73251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.92639 - lat) + Math.Abs(35.9897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82653 - lat) + Math.Abs(36.05167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.66941 - lat) + Math.Abs(36.07546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.37425 - lat) + Math.Abs(36.6033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.1168 - lat) + Math.Abs(36.51522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.61376 - lat) + Math.Abs(36.56449 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.89469 - lat) + Math.Abs(36.49582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.51168 - lat) + Math.Abs(36.37273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.29264 - lat) + Math.Abs(37.2559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.92789 - lat) + Math.Abs(36.124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20922 - lat) + Math.Abs(36.43104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.83444 - lat) + Math.Abs(37.32396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.56909 - lat) + Math.Abs(36.31551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.81418 - lat) + Math.Abs(36.31983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.80709 - lat) + Math.Abs(36.73861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.48995 - lat) + Math.Abs(36.17473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.61182 - lat) + Math.Abs(37.4478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.16054 - lat) + Math.Abs(38.23337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.4862 - lat) + Math.Abs(36.34614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.8175 - lat) + Math.Abs(38.01111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.39496 - lat) + Math.Abs(36.6889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.36211 - lat) + Math.Abs(35.92759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.8706 - lat) + Math.Abs(36.25453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.53719 - lat) + Math.Abs(36.36635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.01809 - lat) + Math.Abs(36.12828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.93062 - lat) + Math.Abs(36.63393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.41197 - lat) + Math.Abs(36.75867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.54793 - lat) + Math.Abs(36.64356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.72682 - lat) + Math.Abs(36.72339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.90035 - lat) + Math.Abs(36.0401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.44885 - lat) + Math.Abs(36.56001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.28861 - lat) + Math.Abs(37.08527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.21176 - lat) + Math.Abs(36.52078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.38808 - lat) + Math.Abs(36.13439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.93745 - lat) + Math.Abs(36.62243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.55869 - lat) + Math.Abs(36.36515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.07437 - lat) + Math.Abs(36.08677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.13179 - lat) + Math.Abs(36.75783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.26014 - lat) + Math.Abs(36.60581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.20124 - lat) + Math.Abs(37.16117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.67337 - lat) + Math.Abs(36.39734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.99024 - lat) + Math.Abs(37.05086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.18235 - lat) + Math.Abs(36.22534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.60638 - lat) + Math.Abs(37.08745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.49846 - lat) + Math.Abs(36.00955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.9491 - lat) + Math.Abs(36.18179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.89514 - lat) + Math.Abs(36.14303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.64389 - lat) + Math.Abs(36.69376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.57175 - lat) + Math.Abs(36.4027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.5102 - lat) + Math.Abs(36.29128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.43842 - lat) + Math.Abs(36.56551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01498 - lat) + Math.Abs(40.51028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.15694 - lat) + Math.Abs(37.70778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.33588 - lat) + Math.Abs(40.14084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.09541 - lat) + Math.Abs(36.76791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.46585 - lat) + Math.Abs(36.42044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.28247 - lat) + Math.Abs(36.85216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.9918 - lat) + Math.Abs(36.39361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.07279 - lat) + Math.Abs(40.65199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.45835 - lat) + Math.Abs(36.23256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.61889 - lat) + Math.Abs(36.10213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.75466 - lat) + Math.Abs(36.12958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.52013 - lat) + Math.Abs(36.48256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.76947 - lat) + Math.Abs(36.81969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01883 - lat) + Math.Abs(36.17083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.69694 - lat) + Math.Abs(41.03528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.95664 - lat) + Math.Abs(36.7138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.81151 - lat) + Math.Abs(36.19649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.07204 - lat) + Math.Abs(35.91375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98099 - lat) + Math.Abs(37.20096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.18188 - lat) + Math.Abs(35.94871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.97358 - lat) + Math.Abs(37.30234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.47101 - lat) + Math.Abs(36.33076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.68482 - lat) + Math.Abs(36.33867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.06771 - lat) + Math.Abs(36.98012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.72488 - lat) + Math.Abs(36.1005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.58662 - lat) + Math.Abs(37.04628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3855 - lat) + Math.Abs(38.86228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.56445 - lat) + Math.Abs(36.10098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.90292 - lat) + Math.Abs(36.23711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.39441 - lat) + Math.Abs(36.03012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.33169 - lat) + Math.Abs(36.09973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.61529 - lat) + Math.Abs(36.18285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.65599 - lat) + Math.Abs(35.88871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.89095 - lat) + Math.Abs(38.35347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.90704 - lat) + Math.Abs(36.40444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.6117 - lat) + Math.Abs(39.8181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.12751 - lat) + Math.Abs(36.21444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.45846 - lat) + Math.Abs(36.74816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.61033 - lat) + Math.Abs(36.3107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.83758 - lat) + Math.Abs(38.54828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.70896 - lat) + Math.Abs(36.56951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.53366 - lat) + Math.Abs(40.95819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88533 - lat) + Math.Abs(38.8711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.78108 - lat) + Math.Abs(36.14298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.78398 - lat) + Math.Abs(36.47695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98151 - lat) + Math.Abs(35.94414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.07186 - lat) + Math.Abs(36.18316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.86453 - lat) + Math.Abs(36.4139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.73481 - lat) + Math.Abs(36.05318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.07696 - lat) + Math.Abs(37.37251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.81182 - lat) + Math.Abs(39.26268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.26375 - lat) + Math.Abs(37.37402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.99174 - lat) + Math.Abs(36.0835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.77411 - lat) + Math.Abs(35.88202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.05756 - lat) + Math.Abs(40.73478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.85604 - lat) + Math.Abs(35.85854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.74424 - lat) + Math.Abs(36.70394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.92667 - lat) + Math.Abs(36.73241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.95283 - lat) + Math.Abs(39.00788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.08363 - lat) + Math.Abs(36.5031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.81374 - lat) + Math.Abs(36.60964 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.51051 - lat) + Math.Abs(36.48569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.02403 - lat) + Math.Abs(36.72848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.10417 - lat) + Math.Abs(40.93 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82202 - lat) + Math.Abs(36.69613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.73848 - lat) + Math.Abs(36.60071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.5078 - lat) + Math.Abs(36.58029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.54337 - lat) + Math.Abs(36.59776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.12595 - lat) + Math.Abs(35.82461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.22956 - lat) + Math.Abs(37.24066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.45644 - lat) + Math.Abs(36.05909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.05215 - lat) + Math.Abs(41.23142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.09855 - lat) + Math.Abs(36.15984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.73931 - lat) + Math.Abs(36.77473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.63205 - lat) + Math.Abs(36.33934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.48522 - lat) + Math.Abs(36.37561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.12902 - lat) + Math.Abs(36.39402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01982 - lat) + Math.Abs(40.45154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.17701 - lat) + Math.Abs(42.14006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.53168 - lat) + Math.Abs(35.79011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.3581 - lat) + Math.Abs(36.2419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.78769 - lat) + Math.Abs(36.28559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.9866 - lat) + Math.Abs(41.82015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.88469 - lat) + Math.Abs(36.29108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.51324 - lat) + Math.Abs(35.8744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.39042 - lat) + Math.Abs(41.14983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.76004 - lat) + Math.Abs(36.32127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.50237 - lat) + Math.Abs(40.74772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.74932 - lat) + Math.Abs(36.30994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.315 - lat) + Math.Abs(37.08632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.71455 - lat) + Math.Abs(35.95163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.86409 - lat) + Math.Abs(37.3968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.59824 - lat) + Math.Abs(36.03006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.39671 - lat) + Math.Abs(36.45491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.39332 - lat) + Math.Abs(36.65067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.15618 - lat) + Math.Abs(40.42716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82924 - lat) + Math.Abs(36.22863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.63679 - lat) + Math.Abs(35.96022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.37051 - lat) + Math.Abs(37.5157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.13907 - lat) + Math.Abs(36.82504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.92133 - lat) + Math.Abs(40.56007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.47296 - lat) + Math.Abs(37.72113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.19503 - lat) + Math.Abs(36.06571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.51072 - lat) + Math.Abs(37.33571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.72078 - lat) + Math.Abs(36.55631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.51194 - lat) + Math.Abs(36.86954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.58739 - lat) + Math.Abs(36.09262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.21254 - lat) + Math.Abs(36.76998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.23605 - lat) + Math.Abs(36.14371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.43806 - lat) + Math.Abs(38.11984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.45226 - lat) + Math.Abs(40.91854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.69508 - lat) + Math.Abs(40.83138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.74058 - lat) + Math.Abs(37.0448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.81138 - lat) + Math.Abs(42.06206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.23154 - lat) + Math.Abs(40.77214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.08638 - lat) + Math.Abs(36.20605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.84113 - lat) + Math.Abs(36.92837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.53228 - lat) + Math.Abs(38.00818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.56743 - lat) + Math.Abs(39.9202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.45759 - lat) + Math.Abs(36.30419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.83917 - lat) + Math.Abs(38.74288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.31025 - lat) + Math.Abs(36.11523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.27181 - lat) + Math.Abs(36.50395 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.5635 - lat) + Math.Abs(36.72841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.58288 - lat) + Math.Abs(36.53389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("‘Ayn Ḩalāqīm", "10", 34.93998, 36.32212);
case 1: return new CityInfo("Al Karāmah", "04", 35.86865, 39.27803);
case 2: return new CityInfo("‘Arīqah", "05", 32.88981, 36.48336);
case 3: return new CityInfo("Aş Şūrah aş Şaghīrah", "05", 33.03247, 36.5742);
case 4: return new CityInfo("Mūḩ Ḩasan", "07", 35.23349, 40.3166);
case 5: return new CityInfo("Yabrūd", "08", 33.96921, 36.65729);
case 6: return new CityInfo("Wādī al ‘Uyūn", "10", 35.00119, 36.18683);
case 7: return new CityInfo("‘Uqayribāt", "10", 35.0431, 37.46442);
case 8: return new CityInfo("Ţayyibat al Imām", "10", 35.26592, 36.71219);
case 9: return new CityInfo("Tasīl", "06", 32.83395, 35.96973);
case 10: return new CityInfo("Tartouss", "14", 34.88902, 35.88659);
case 11: return new CityInfo("Tall Tamr", "01", 36.65556, 40.37079);
case 12: return new CityInfo("Tall Salḩab", "10", 35.25884, 36.38461);
case 13: return new CityInfo("Tall Rif‘at", "09", 36.47229, 37.09471);
case 14: return new CityInfo("Tallkalakh", "11", 34.66842, 36.25995);
case 15: return new CityInfo("Tall Ḩamīs", "01", 36.75678, 41.39943);
case 16: return new CityInfo("Talldaww", "11", 34.87632, 36.524);
case 17: return new CityInfo("Tall aḑ Ḑamān", "09", 35.80776, 37.25378);
case 18: return new CityInfo("Tall Abyaḑ", "04", 36.69648, 38.95382);
case 19: return new CityInfo("Tālīn", "14", 35.14849, 36.03288);
case 20: return new CityInfo("Tallbīsah", "11", 34.84072, 36.73092);
case 21: return new CityInfo("Taftanāz", "12", 35.99832, 36.78579);
case 22: return new CityInfo("Ţafas", "06", 32.73709, 36.06654);
case 23: return new CityInfo("Tadmur", "11", 34.5624, 38.28402);
case 24: return new CityInfo("Tādif", "09", 36.34814, 37.5309);
case 25: return new CityInfo("Şūrān", "09", 36.56579, 37.2127);
case 26: return new CityInfo("Souran", "10", 35.29193, 36.74848);
case 27: return new CityInfo("As Suqaylibīyah", "10", 35.36674, 36.39359);
case 28: return new CityInfo("Subaykhān", "07", 34.85305, 40.59987);
case 29: return new CityInfo("Şlinfah", "02", 35.59822, 36.1877);
case 30: return new CityInfo("Şirrīn ash Shamālīyah", "09", 36.58838, 38.29788);
case 31: return new CityInfo("Sirghāyā", "08", 33.8104, 36.15787);
case 32: return new CityInfo("Sinjār", "12", 35.59011, 37.00472);
case 33: return new CityInfo("Shuyūkh Taḩtānī", "09", 36.75059, 38.07676);
case 34: return new CityInfo("Shīn", "11", 34.77863, 36.42366);
case 35: return new CityInfo("Ash Shaykh Miskīn", "06", 32.82944, 36.15933);
case 36: return new CityInfo("Shaykh al Ḩadīd", "09", 36.50069, 36.59945);
case 37: return new CityInfo("Shaţḩah", "10", 35.50509, 36.24377);
case 38: return new CityInfo("Sharān", "09", 36.62336, 36.93659);
case 39: return new CityInfo("Shaqqā", "05", 32.89773, 36.69653);
case 40: return new CityInfo("Shahbā", "05", 32.85514, 36.62896);
case 41: return new CityInfo("Şaydnāyā", "08", 33.69473, 36.37146);
case 42: return new CityInfo("Sa‘sa‘", "08", 33.28198, 36.01947);
case 43: return new CityInfo("Sarmīn", "12", 35.90403, 36.72501);
case 44: return new CityInfo("Sarāqib", "12", 35.86447, 36.80591);
case 45: return new CityInfo("Sulūk", "04", 36.59596, 39.1299);
case 46: return new CityInfo("Salqīn", "12", 36.13865, 36.45244);
case 47: return new CityInfo("Şalkhad", "05", 32.492, 36.71114);
case 48: return new CityInfo("As Salamīyah", "10", 35.01127, 37.05324);
case 49: return new CityInfo("Şalākhid", "05", 32.87271, 36.57271);
case 50: return new CityInfo("Sahnaiya", "08", 33.42531, 36.22552);
case 51: return new CityInfo("Satita", "14", 34.82099, 36.11773);
case 52: return new CityInfo("Şadad", "11", 34.31248, 36.92562);
case 53: return new CityInfo("Şabbūrah", "10", 35.15595, 37.20908);
case 54: return new CityInfo("As Sab‘ Biyār", "08", 33.77974, 37.68357);
case 55: return new CityInfo("Ar Riqāmā", "11", 34.53879, 36.91909);
case 56: return new CityInfo("Rasm al Ḩarmal", "09", 36.24486, 37.71607);
case 57: return new CityInfo("Ra’s al ‘Ayn", "01", 36.85034, 40.07055);
case 58: return new CityInfo("Rankūs", "08", 33.75623, 36.3883);
case 59: return new CityInfo("Radjun", "09", 36.67598, 36.66415);
case 60: return new CityInfo("Al Quţaylibīyah", "02", 35.29203, 36.01592);
case 61: return new CityInfo("Qarqania", "12", 36.13849, 36.61247);
case 62: return new CityInfo("Al Qaḩţānīyah", "01", 37.029, 41.54596);
case 63: return new CityInfo("Qaţanā", "08", 33.43757, 36.07888);
case 64: return new CityInfo("Qasţal Ma‘āf", "02", 35.82439, 35.95193);
case 65: return new CityInfo("Jāsim", "06", 32.99233, 36.06018);
case 66: return new CityInfo("Qārah", "08", 34.15558, 36.74284);
case 67: return new CityInfo("Al Qamşīyah", "14", 35.03357, 36.01455);
case 68: return new CityInfo("Qal‘at al Maḑīq", "10", 35.41465, 36.39085);
case 69: return new CityInfo("Qadsayyā", "08", 33.54832, 36.21563);
case 70: return new CityInfo("Nubl", "09", 36.37867, 36.99294);
case 71: return new CityInfo("Nawá", "06", 32.89044, 36.0399);
case 72: return new CityInfo("Al Muzayrīb", "06", 32.71084, 36.02751);
case 73: return new CityInfo("Al Muzayri‘ah", "02", 35.5318, 36.07003);
case 74: return new CityInfo("Al Jalā’", "07", 34.63346, 40.84054);
case 75: return new CityInfo("Mūrak", "10", 35.37615, 36.6897);
case 76: return new CityInfo("Mukharram al Fawqānī", "11", 34.81521, 37.08677);
case 77: return new CityInfo("Muḩradah", "10", 35.2479, 36.5725);
case 78: return new CityInfo("Muḩambal", "12", 35.78735, 36.4721);
case 79: return new CityInfo("Mazra‘at Bayt Jinn", "08", 33.32836, 35.92144);
case 80: return new CityInfo("Maşyāf", "10", 35.0653, 36.3406);
case 81: return new CityInfo("Maskanah", "09", 35.96577, 38.04165);
case 82: return new CityInfo("Mashtá al Ḩulw", "14", 34.87462, 36.25099);
case 83: return new CityInfo("Mas‘adah", "03", 33.23203, 35.75572);
case 84: return new CityInfo("Markadah", "01", 35.74607, 40.75304);
case 85: return new CityInfo("Māri‘", "09", 36.48259, 37.19709);
case 86: return new CityInfo("Manbij", "09", 36.52815, 37.95495);
case 87: return new CityInfo("Ma‘lūlā", "08", 33.84529, 36.54514);
case 88: return new CityInfo("Malaḩ", "05", 32.50795, 36.85719);
case 89: return new CityInfo("Mahīn", "11", 34.24168, 37.05843);
case 90: return new CityInfo("Ma‘dān", "04", 35.7552, 39.59835);
case 91: return new CityInfo("Medaya", "08", 33.69032, 36.10354);
case 92: return new CityInfo("Al Ma‘baţlī", "09", 36.56246, 36.74292);
case 93: return new CityInfo("Ma‘arratmişrīn", "12", 36.01152, 36.67183);
case 94: return new CityInfo("Ma‘arrat an Nu‘mān", "12", 35.6483, 36.67693);
case 95: return new CityInfo("Kuwayris Sharqī", "09", 36.16685, 37.53815);
case 96: return new CityInfo("Kurnāz", "10", 35.38972, 36.48773);
case 97: return new CityInfo("Kinnsibbā", "02", 35.7441, 36.164);
case 98: return new CityInfo("Rabī‘ah", "02", 35.78656, 36.03825);
case 99: return new CityInfo("Khushām", "07", 35.30088, 40.28916);
case 100: return new CityInfo("Khirbat Tīn Nūr", "11", 34.70122, 36.55658);
case 101: return new CityInfo("Al Qabw", "11", 34.84324, 36.45493);
case 102: return new CityInfo("Khirbat al Ma‘azzah", "14", 34.80454, 36.00077);
case 103: return new CityInfo("Khirbat Ghazālah", "06", 32.73376, 36.20455);
case 104: return new CityInfo("Khān Shaykhūn", "12", 35.44208, 36.65095);
case 105: return new CityInfo("Khanāşir", "09", 35.78159, 37.49919);
case 106: return new CityInfo("Khān Arnabah", "03", 33.18378, 35.89158);
case 107: return new CityInfo("Al Khafsah", "09", 36.2311, 38.02172);
case 108: return new CityInfo("Al Ghandūrah", "09", 36.66945, 37.73251);
case 109: return new CityInfo("Kassab", "02", 35.92639, 35.9897);
case 110: return new CityInfo("Ra’s al Khashūfah", "14", 34.82653, 36.05167);
case 111: return new CityInfo("Al Karīmah", "14", 34.66941, 36.07546);
case 112: return new CityInfo("Kafr Zaytā", "10", 35.37425, 36.6033);
case 113: return new CityInfo("Kafr Takhārīm", "12", 36.1168, 36.51522);
case 114: return new CityInfo("Kafranbel", "12", 35.61376, 36.56449);
case 115: return new CityInfo("Kafr Lāhā", "11", 34.89469, 36.49582);
case 116: return new CityInfo("Kafr Baţnā", "08", 33.51168, 36.37273);
case 117: return new CityInfo("Kafr Şaghīr", "09", 36.29264, 37.2559);
case 118: return new CityInfo("Junaynat Raslān", "14", 34.92789, 36.124);
case 119: return new CityInfo("Jubb Ramlah", "10", 35.20922, 36.43104);
case 120: return new CityInfo("Jubb al Jarrāḩ", "11", 34.83444, 37.32396);
case 121: return new CityInfo("Al Jīzah", "06", 32.56909, 36.31551);
case 122: return new CityInfo("Jisr ash Shughūr", "12", 35.81418, 36.31983);
case 123: return new CityInfo("Jayrūd", "08", 33.80709, 36.73861);
case 124: return new CityInfo("Jawbat Burghāl", "02", 35.48995, 36.17473);
case 125: return new CityInfo("Tchoban Bey", "09", 36.61182, 37.4478);
case 126: return new CityInfo("Al Jarnīyah", "04", 36.16054, 38.23337);
case 127: return new CityInfo("Jaramānā", "08", 33.4862, 36.34614);
case 128: return new CityInfo("Jarābulus", "09", 36.8175, 38.01111);
case 129: return new CityInfo("Jindayris", "09", 36.39496, 36.6889);
case 130: return new CityInfo("Jablah", "02", 35.36211, 35.92759);
case 131: return new CityInfo("Izra‘", "06", 32.8706, 36.25453);
case 132: return new CityInfo("‘Irbīn", "08", 33.53719, 36.36635);
case 133: return new CityInfo("Inkhil", "06", 33.01809, 36.12828);
case 134: return new CityInfo("Idlib", "12", 35.93062, 36.63393);
case 135: return new CityInfo("Hisya", "11", 34.41197, 36.75867);
case 136: return new CityInfo("Ḩīsh", "12", 35.54793, 36.64356);
case 137: return new CityInfo("Homs", "11", 34.72682, 36.72339);
case 138: return new CityInfo("Ḩimmīn", "14", 34.90035, 36.0401);
case 139: return new CityInfo("Ḩarrān al ‘Awāmīd", "08", 33.44885, 36.56001);
case 140: return new CityInfo("Ḩuraytān", "09", 36.28861, 37.08527);
case 141: return new CityInfo("Ḩārim", "12", 36.21176, 36.52078);
case 142: return new CityInfo("Ḩarf al Musaytirah", "02", 35.38808, 36.13439);
case 143: return new CityInfo("Ḩarbinafsah", "10", 34.93745, 36.62243);
case 144: return new CityInfo("Ḩarastā", "08", 33.55869, 36.36515);
case 145: return new CityInfo("Ḩammām Wāşil", "14", 35.07437, 36.08677);
case 146: return new CityInfo("Ḩamāh", "10", 35.13179, 36.75783);
case 147: return new CityInfo("Ḩalfāyā", "10", 35.26014, 36.60581);
case 148: return new CityInfo("Aleppo", "09", 36.20124, 37.16117);
case 149: return new CityInfo("Ḩadīdah", "11", 34.67337, 36.39734);
case 150: return new CityInfo("Al Ḩāḑir", "09", 35.99024, 37.05086);
case 151: return new CityInfo("Ghabāghib", "06", 33.18235, 36.22534);
case 152: return new CityInfo("Al Furqlus", "11", 34.60638, 37.08745);
case 153: return new CityInfo("Al Fākhūrah", "02", 35.49846, 36.00955);
case 154: return new CityInfo("Duwayr Raslān", "14", 34.9491, 36.18179);
case 155: return new CityInfo("Ad Duraykīsh", "14", 34.89514, 36.14303);
case 156: return new CityInfo("Aḑ Ḑumayr", "08", 33.64389, 36.69376);
case 157: return new CityInfo("Douma", "08", 33.57175, 36.4027);
case 158: return new CityInfo("Damascus", "13", 33.5102, 36.29128);
case 159: return new CityInfo("Dhībīn", "05", 32.43842, 36.56551);
case 160: return new CityInfo("Dhībān", "07", 35.01498, 40.51028);
case 161: return new CityInfo("Dayr Ḩāfir", "09", 36.15694, 37.70778);
case 162: return new CityInfo("Deir ez-Zor", "07", 35.33588, 40.14084);
case 163: return new CityInfo("Dayr ‘Aţīyah", "08", 34.09541, 36.76791);
case 164: return new CityInfo("Dayr al ‘Aşāfīr", "08", 33.46585, 36.42044);
case 165: return new CityInfo("Dārat ‘Izzah", "09", 36.28247, 36.85216);
case 166: return new CityInfo("Darkūsh", "12", 35.9918, 36.39361);
case 167: return new CityInfo("Ad Darbāsīyah", "01", 37.07279, 40.65199);
case 168: return new CityInfo("Dārayyā", "08", 33.45835, 36.23256);
case 169: return new CityInfo("Dar‘ā", "06", 32.61889, 36.10213);
case 170: return new CityInfo("Dā‘il", "06", 32.75466, 36.12958);
case 171: return new CityInfo("Buşrá ash Shām", "06", 32.52013, 36.48256);
case 172: return new CityInfo("Bulbul", "09", 36.76947, 36.81969);
case 173: return new CityInfo("Brummānat al Mashāyikh", "14", 35.01883, 36.17083);
case 174: return new CityInfo("Bi’r al Ḩulw al Wardīyah", "01", 36.69694, 41.03528);
case 175: return new CityInfo("Binnish", "12", 35.95664, 36.7138);
case 176: return new CityInfo("Bdāmā", "12", 35.81151, 36.19649);
case 177: return new CityInfo("Ar Rawḑah", "14", 35.07204, 35.91375);
case 178: return new CityInfo("Barrī ash Sharqī", "10", 34.98099, 37.20096);
case 179: return new CityInfo("Bāniyās", "14", 35.18188, 35.94871);
case 180: return new CityInfo("Banān", "09", 35.97358, 37.30234);
case 181: return new CityInfo("Babīlā", "08", 33.47101, 36.33076);
case 182: return new CityInfo("Az Ziyārah", "10", 35.68482, 36.33867);
case 183: return new CityInfo("Az Zarbah", "09", 36.06771, 36.98012);
case 184: return new CityInfo("Az Zabadānī", "08", 33.72488, 36.1005);
case 185: return new CityInfo("I‘zāz", "09", 36.58662, 37.04628);
case 186: return new CityInfo("‘Ayn ‘Īsá", "04", 36.3855, 38.86228);
case 187: return new CityInfo("‘Ayn at Tīnah", "02", 35.56445, 36.10098);
case 188: return new CityInfo("Sabbah", "14", 34.90292, 36.23711);
case 189: return new CityInfo("‘Ayn Shiqāq", "02", 35.39441, 36.03012);
case 190: return new CityInfo("‘Ayn ash Sharqīyah", "02", 35.33169, 36.09973);
case 191: return new CityInfo("‘Ayn al Fījah", "08", 33.61529, 36.18285);
case 192: return new CityInfo("‘Ayn al Bayḑā", "02", 35.65599, 35.88871);
case 193: return new CityInfo("‘Ayn al ‘Arab", "09", 36.89095, 38.35347);
case 194: return new CityInfo("‘Awaj", "10", 34.90704, 36.40444);
case 195: return new CityInfo("At Tibnī", "07", 35.6117, 39.8181);
case 196: return new CityInfo("Aţ Ţawāḩīn", "14", 35.12751, 36.21444);
case 197: return new CityInfo("At Tamāni‘ah", "12", 35.45846, 36.74816);
case 198: return new CityInfo("At Tall", "08", 33.61033, 36.3107);
case 199: return new CityInfo("Ath Thawrah", "04", 35.83758, 38.54828);
case 200: return new CityInfo("As-Suwayda", "05", 32.70896, 36.56951);
case 201: return new CityInfo("As Sūsah", "07", 34.53366, 40.95819);
case 202: return new CityInfo("As Sukhnah", "11", 34.88533, 38.8711);
case 203: return new CityInfo("As Sīsnīyah", "14", 34.78108, 36.14298);
case 204: return new CityInfo("Al Mazra‘ah", "05", 32.78398, 36.47695);
case 205: return new CityInfo("As Sawdā", "14", 34.98151, 35.94414);
case 206: return new CityInfo("Aş Şanamayn", "06", 33.07186, 36.18316);
case 207: return new CityInfo("‘Assāl al Ward", "08", 33.86453, 36.4139);
case 208: return new CityInfo("Aş Şafşāfah", "14", 34.73481, 36.05318);
case 209: return new CityInfo("As Safīrah", "09", 36.07696, 37.37251);
case 210: return new CityInfo("As Sabkhah", "04", 35.81182, 39.26268);
case 211: return new CityInfo("As Si‘in", "10", 35.26375, 37.37402);
case 212: return new CityInfo("Ash Shaykh Badr", "14", 34.99174, 36.0835);
case 213: return new CityInfo("Ash Shajarah", "06", 32.77411, 35.88202);
case 214: return new CityInfo("Ash Shaddādah", "01", 36.05756, 40.73478);
case 215: return new CityInfo("Arwād", "14", 34.85604, 35.85854);
case 216: return new CityInfo("Ar Ruḩaybah", "08", 33.74424, 36.70394);
case 217: return new CityInfo("Ar Rastan", "11", 34.92667, 36.73241);
case 218: return new CityInfo("Ar Raqqah", "04", 35.95283, 39.00788);
case 219: return new CityInfo("Armanāz", "12", 36.08363, 36.5031);
case 220: return new CityInfo("Arīḩā", "12", 35.81374, 36.60964);
case 221: return new CityInfo("An Nashābīyah", "08", 33.51051, 36.48569);
case 222: return new CityInfo("An Nabk", "08", 34.02403, 36.72848);
case 223: return new CityInfo("Amude", "01", 37.10417, 40.93);
case 224: return new CityInfo("Al Ghanţū", "11", 34.82202, 36.69613);
case 225: return new CityInfo("Al Quţayfah", "08", 33.73848, 36.60071);
case 226: return new CityInfo("Al Quşayr", "11", 34.5078, 36.58029);
case 227: return new CityInfo("Al Qurayyā", "05", 32.54337, 36.59776);
case 228: return new CityInfo("Al Qunayţirah", "03", 33.12595, 35.82461);
case 229: return new CityInfo("Al Qaryatayn", "11", 34.22956, 37.24066);
case 230: return new CityInfo("Al Qardāḩah", "02", 35.45644, 36.05909);
case 231: return new CityInfo("Al Qāmishlī", "01", 37.05215, 41.23142);
case 232: return new CityInfo("Al Qadmūs", "14", 35.09855, 36.15984);
case 233: return new CityInfo("Al Mushannaf", "05", 32.73931, 36.77473);
case 234: return new CityInfo("Al Musayfirah", "06", 32.63205, 36.33934);
case 235: return new CityInfo("Al Mulayḩah", "08", 33.48522, 36.37561);
case 236: return new CityInfo("Mismīyah", "06", 33.12902, 36.39402);
case 237: return new CityInfo("Al Mayādīn", "07", 35.01982, 40.45154);
case 238: return new CityInfo("Al Mālikīyah", "01", 37.17701, 42.14006);
case 239: return new CityInfo("Latakia", "02", 35.53168, 35.79011);
case 240: return new CityInfo("Al Kiswah", "08", 33.3581, 36.2419);
case 241: return new CityInfo("An Nāşirah", "11", 34.78769, 36.28559);
case 242: return new CityInfo("Al Jawādīyah", "01", 36.9866, 41.82015);
case 243: return new CityInfo("Al Jānūdīyah", "12", 35.88469, 36.29108);
case 244: return new CityInfo("Al Hinādī", "02", 35.51324, 35.8744);
case 245: return new CityInfo("Al Ḩawl", "01", 36.39042, 41.14983);
case 246: return new CityInfo("Al Ḩawāsh", "11", 34.76004, 36.32127);
case 247: return new CityInfo("Al Ḩasakah", "01", 36.50237, 40.74772);
case 248: return new CityInfo("Al Ḩarāk", "06", 32.74932, 36.30994);
case 249: return new CityInfo("Al Ḩamrā’", "10", 35.315, 37.08632);
case 250: return new CityInfo("Al Ḩamīdīyah", "14", 34.71455, 35.95163);
case 251: return new CityInfo("Al Ḩājib", "09", 35.86409, 37.3968);
case 252: return new CityInfo("Al Ḩaffah", "02", 35.59824, 36.03006);
case 253: return new CityInfo("Al Ghizlānīyah", "08", 33.39671, 36.45491);
case 254: return new CityInfo("Al Ghāriyah", "05", 32.39332, 36.65067);
case 255: return new CityInfo("Al Buşayrah", "07", 35.15618, 40.42716);
case 256: return new CityInfo("Al Bāriqīyah", "14", 34.82924, 36.22863);
case 257: return new CityInfo("Al Bahlūlīyah", "02", 35.63679, 35.96022);
case 258: return new CityInfo("Al Bāb", "09", 36.37051, 37.5157);
case 259: return new CityInfo("Al Atārib", "09", 36.13907, 36.82504);
case 260: return new CityInfo("Al ‘Ashārah", "07", 34.92133, 40.56007);
case 261: return new CityInfo("Al ‘Arīmah", "09", 36.47296, 37.72113);
case 262: return new CityInfo("Al ‘Annāzah", "14", 35.19503, 36.06571);
case 263: return new CityInfo("Akhtarīn", "09", 36.51072, 37.33571);
case 264: return new CityInfo("Iḩsim", "12", 35.72078, 36.55631);
case 265: return new CityInfo("‘Afrīn", "09", 36.51194, 36.86954);
case 266: return new CityInfo("Ad Dīmās", "08", 33.58739, 36.09262);
case 267: return new CityInfo("Ad Dānā", "12", 36.21254, 36.76998);
case 268: return new CityInfo("Ad Dālīyah", "02", 35.23605, 36.14371);
case 269: return new CityInfo("Abū Qalqal", "09", 36.43806, 38.11984);
case 270: return new CityInfo("Ālbū Kamāl", "07", 34.45226, 40.91854);
case 271: return new CityInfo("Hajīn", "07", 34.69508, 40.83138);
case 272: return new CityInfo("Abū az̧ Z̧uhūr", "12", 35.74058, 37.0448);
case 273: return new CityInfo("Al Ya‘rubīyah", "01", 36.81138, 42.06206);
case 274: return new CityInfo("‘Arīshah", "01", 36.23154, 40.77214);
case 275: return new CityInfo("Kaff al-Jaa", "14", 35.08638, 36.20605);
case 276: return new CityInfo("‘Ayn an Nasr", "11", 34.84113, 36.92837);
case 277: return new CityInfo("Nāḩiyat as Sab‘ Biyār", "08", 33.53228, 38.00818);
case 278: return new CityInfo("Al Kasrah", "07", 35.56743, 39.9202);
case 279: return new CityInfo("Al Ḩajar al Aswad", "08", 33.45759, 36.30419);
case 280: return new CityInfo("Al Manşūrah", "04", 35.83917, 38.74288);
case 281: return new CityInfo("Bayt Yāshūţ", "02", 35.31025, 36.11523);
case 282: return new CityInfo("Tremseh", "10", 35.27181, 36.50395);
case 283: return new CityInfo("Qenterê", "09", 36.5635, 36.72841);
default: return new CityInfo("Kafr Mūsá Al-Hmidiya", "11", 34.58288, 36.53389);

                                    }                                        
                                }
                            
                        }
                    }
                