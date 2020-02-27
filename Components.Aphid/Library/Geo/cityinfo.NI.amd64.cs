
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
                                    public const string Country = "NI";
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
                            
                                        var cur = (Math.Abs(13.48383 - lat) + Math.Abs(-86.49305 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(13.62679 - lat) + Math.Abs(-85.8254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.74189 - lat) + Math.Abs(-83.9717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.23333 - lat) + Math.Abs(-85.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.0483 - lat) + Math.Abs(-84.99362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.96353 - lat) + Math.Abs(-86.81517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.51667 - lat) + Math.Abs(-86.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.12449 - lat) + Math.Abs(-86.00833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.56284 - lat) + Math.Abs(-86.49254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.7673 - lat) + Math.Abs(-87.13323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.43927 - lat) + Math.Abs(-85.93891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.08194 - lat) + Math.Abs(-86.01739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.19732 - lat) + Math.Abs(-86.09706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.02263 - lat) + Math.Abs(-86.20493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.4203 - lat) + Math.Abs(-85.79798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.73028 - lat) + Math.Abs(-85.96474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.53151 - lat) + Math.Abs(-86.2871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.522 - lat) + Math.Abs(-86.85938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48082 - lat) + Math.Abs(-86.58208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.04387 - lat) + Math.Abs(-86.90506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.73321 - lat) + Math.Abs(-84.77725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.85321 - lat) + Math.Abs(-86.0963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.1861 - lat) + Math.Abs(-86.92267 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.06938 - lat) + Math.Abs(-85.09059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.26438 - lat) + Math.Abs(-85.08235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.80299 - lat) + Math.Abs(-86.16312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.74321 - lat) + Math.Abs(-86.21413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.80116 - lat) + Math.Abs(-86.36994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.74665 - lat) + Math.Abs(-86.70934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.53262 - lat) + Math.Abs(-85.71074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.3054 - lat) + Math.Abs(-86.18641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.92344 - lat) + Math.Abs(-85.83898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.84854 - lat) + Math.Abs(-86.43839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.21248 - lat) + Math.Abs(-86.11089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.12943 - lat) + Math.Abs(-85.11523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.27611 - lat) + Math.Abs(-86.87782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.93236 - lat) + Math.Abs(-86.34805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.40255 - lat) + Math.Abs(-84.89991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.90949 - lat) + Math.Abs(-86.20351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.4138 - lat) + Math.Abs(-86.6111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.3783 - lat) + Math.Abs(-85.66646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.54476 - lat) + Math.Abs(-86.16499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.90624 - lat) + Math.Abs(-86.07343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.25292 - lat) + Math.Abs(-85.87049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.94684 - lat) + Math.Abs(-83.73467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.17603 - lat) + Math.Abs(-86.61234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.5975 - lat) + Math.Abs(-85.76174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.28841 - lat) + Math.Abs(-86.65539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.54204 - lat) + Math.Abs(-85.53942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.45584 - lat) + Math.Abs(-85.80308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.92957 - lat) + Math.Abs(-86.19521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.50497 - lat) + Math.Abs(-86.29942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.19921 - lat) + Math.Abs(-86.77101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.82613 - lat) + Math.Abs(-87.44557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.67755 - lat) + Math.Abs(-86.31486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.76023 - lat) + Math.Abs(-85.85018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.1236 - lat) + Math.Abs(-84.77795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.43716 - lat) + Math.Abs(-85.82632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.93435 - lat) + Math.Abs(-85.22354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.15965 - lat) + Math.Abs(-84.21952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.56695 - lat) + Math.Abs(-86.026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.50683 - lat) + Math.Abs(-86.90292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.85042 - lat) + Math.Abs(-87.17167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.03507 - lat) + Math.Abs(-83.38882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.37984 - lat) + Math.Abs(-86.48075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.40708 - lat) + Math.Abs(-83.56452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.49416 - lat) + Math.Abs(-85.8568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.54422 - lat) + Math.Abs(-86.97982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.36844 - lat) + Math.Abs(-85.67335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.45566 - lat) + Math.Abs(-86.40622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.63208 - lat) + Math.Abs(-86.47516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.82247 - lat) + Math.Abs(-84.19629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.68758 - lat) + Math.Abs(-84.45616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.90518 - lat) + Math.Abs(-86.09446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.00386 - lat) + Math.Abs(-86.12128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.92411 - lat) + Math.Abs(-86.12072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.75696 - lat) + Math.Abs(-86.05286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.26593 - lat) + Math.Abs(-86.56474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.76224 - lat) + Math.Abs(-85.62915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7585 - lat) + Math.Abs(-86.01843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.17611 - lat) + Math.Abs(-84.95522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.06999 - lat) + Math.Abs(-84.53503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.66034 - lat) + Math.Abs(-86.43841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.54006 - lat) + Math.Abs(-85.69795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.62118 - lat) + Math.Abs(-85.08052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.83734 - lat) + Math.Abs(-85.46218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.23512 - lat) + Math.Abs(-86.42809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.92559 - lat) + Math.Abs(-85.91747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.97444 - lat) + Math.Abs(-86.09417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.91445 - lat) + Math.Abs(-86.14458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.78687 - lat) + Math.Abs(-86.51416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.13282 - lat) + Math.Abs(-86.2504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.59374 - lat) + Math.Abs(-86.67952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.65328 - lat) + Math.Abs(-86.61297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.43787 - lat) + Math.Abs(-86.87804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.96881 - lat) + Math.Abs(-86.23534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.34302 - lat) + Math.Abs(-86.62184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.67692 - lat) + Math.Abs(-86.57193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.82311 - lat) + Math.Abs(-86.12781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.34 - lat) + Math.Abs(-86.67528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.21635 - lat) + Math.Abs(-85.16595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.34294 - lat) + Math.Abs(-83.67123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.1129 - lat) + Math.Abs(-84.18588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.73426 - lat) + Math.Abs(-86.19279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.19528 - lat) + Math.Abs(-86.16659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.93711 - lat) + Math.Abs(-86.18976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.24096 - lat) + Math.Abs(-83.74517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.93072 - lat) + Math.Abs(-83.57724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.10629 - lat) + Math.Abs(-85.36452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.74593 - lat) + Math.Abs(-87.4516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.84962 - lat) + Math.Abs(-86.19903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.09103 - lat) + Math.Abs(-86.00234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.92221 - lat) + Math.Abs(-86.12346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.92988 - lat) + Math.Abs(-85.95602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.09185 - lat) + Math.Abs(-86.35384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.66446 - lat) + Math.Abs(-85.78734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.66348 - lat) + Math.Abs(-87.16663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.88687 - lat) + Math.Abs(-86.53903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.8328 - lat) + Math.Abs(-86.16526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.77756 - lat) + Math.Abs(-86.37374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.54333 - lat) + Math.Abs(-87.16517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.72676 - lat) + Math.Abs(-86.38057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.41667 - lat) + Math.Abs(-85.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.99008 - lat) + Math.Abs(-86.30954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.01844 - lat) + Math.Abs(-84.39811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.19046 - lat) + Math.Abs(-85.28737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.67859 - lat) + Math.Abs(-84.70269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.85672 - lat) + Math.Abs(-86.21552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.87631 - lat) + Math.Abs(-86.05184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.85812 - lat) + Math.Abs(-86.23922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.8842 - lat) + Math.Abs(-86.05508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.72106 - lat) + Math.Abs(-86.50619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.26875 - lat) + Math.Abs(-85.38205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.17575 - lat) + Math.Abs(-83.06145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.4825 - lat) + Math.Abs(-87.17304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.36502 - lat) + Math.Abs(-86.39846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.28345 - lat) + Math.Abs(-85.51081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7229 - lat) + Math.Abs(-86.13852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.73143 - lat) + Math.Abs(-86.12402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.6406 - lat) + Math.Abs(-86.30815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.22956 - lat) + Math.Abs(-86.86808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.62937 - lat) + Math.Abs(-87.13105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.57758 - lat) + Math.Abs(-87.02705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.91197 - lat) + Math.Abs(-86.07383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.98009 - lat) + Math.Abs(-86.50571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.19639 - lat) + Math.Abs(-85.5089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.38383 - lat) + Math.Abs(-85.51277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.46916 - lat) + Math.Abs(-85.81661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.02885 - lat) + Math.Abs(-84.59103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.29746 - lat) + Math.Abs(-85.15155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.78571 - lat) + Math.Abs(-85.12269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.05 - lat) + Math.Abs(-84.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.47224 - lat) + Math.Abs(-85.6586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.01366 - lat) + Math.Abs(-83.76353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.50299 - lat) + Math.Abs(-85.88935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.56615 - lat) + Math.Abs(-85.5784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.97028 - lat) + Math.Abs(-85.17113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.0537 - lat) + Math.Abs(-86.59004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.15889 - lat) + Math.Abs(-86.34417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.17 - lat) + Math.Abs(-85.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.34809 - lat) + Math.Abs(-85.94451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.61494 - lat) + Math.Abs(-85.81676 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.61868 - lat) + Math.Abs(-85.82519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.91781 - lat) + Math.Abs(-84.64827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.33581 - lat) + Math.Abs(-85.37054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.49952 - lat) + Math.Abs(-84.81519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.13652 - lat) + Math.Abs(-85.73738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.23695 - lat) + Math.Abs(-85.55817 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yalagüina", "09", 13.48383, -86.49305);
case 1: return new CityInfo("Wiwilí", "13", 13.62679, -85.8254);
case 2: return new CityInfo("Waspán", "17", 14.74189, -83.9717);
case 3: return new CityInfo("Waslala", "17", 13.23333, -85.38333);
case 4: return new CityInfo("Villa Sandino", "04", 12.0483, -84.99362);
case 5: return new CityInfo("Villanueva", "03", 12.96353, -86.81517);
case 6: return new CityInfo("Valle San Francisco", "10", 12.51667, -86.28333);
case 7: return new CityInfo("LLano de La Cruz", "07", 13.12449, -86.00833);
case 8: return new CityInfo("Totogalpa", "09", 13.56284, -86.49254);
case 9: return new CityInfo("Tonalá", "03", 12.7673, -87.13323);
case 10: return new CityInfo("Tola", "15", 11.43927, -85.93891);
case 11: return new CityInfo("Tisma", "11", 12.08194, -86.01739);
case 12: return new CityInfo("Tipitapa", "10", 12.19732, -86.09706);
case 13: return new CityInfo("Ticuantepe", "10", 12.02263, -86.20493);
case 14: return new CityInfo("Teustepe", "01", 12.4203, -85.79798);
case 15: return new CityInfo("Terrabona", "12", 12.73028, -85.96474);
case 16: return new CityInfo("Telpaneca", "09", 13.53151, -86.2871);
case 17: return new CityInfo("Telica", "08", 12.522, -86.85938);
case 18: return new CityInfo("Somoto", "09", 13.48082, -86.58208);
case 19: return new CityInfo("Somotillo", "03", 13.04387, -86.90506);
case 20: return new CityInfo("Siuna", "17", 13.73321, -84.77725);
case 21: return new CityInfo("Sébaco", "12", 12.85321, -86.0963);
case 22: return new CityInfo("Santo Tomás del Norte", "03", 13.1861, -86.92267);
case 23: return new CityInfo("Santo Tomás", "04", 12.06938, -85.09059);
case 24: return new CityInfo("Santo Domingo", "04", 12.26438, -85.08235);
case 25: return new CityInfo("Santa Teresa", "02", 11.80299, -86.16312);
case 26: return new CityInfo("Santa Teresa", "02", 11.74321, -86.21413);
case 27: return new CityInfo("Santa Rosa del Peñón", "08", 12.80116, -86.36994);
case 28: return new CityInfo("Santa María", "13", 13.74665, -86.70934);
case 29: return new CityInfo("Santa Lucía", "01", 12.53262, -85.71074);
case 30: return new CityInfo("San Sebastián de Yalí", "07", 13.3054, -86.18641);
case 31: return new CityInfo("San Ramón", "12", 12.92344, -85.83898);
case 32: return new CityInfo("San Rafael del Sur", "10", 11.84854, -86.43839);
case 33: return new CityInfo("San Rafael del Norte", "07", 13.21248, -86.11089);
case 34: return new CityInfo("San Pedro de Lóvago", "04", 12.12943, -85.11523);
case 35: return new CityInfo("San Pedro del Norte", "03", 13.27611, -86.87782);
case 36: return new CityInfo("San Nicolás", "05", 12.93236, -86.34805);
case 37: return new CityInfo("San Miguelito", "14", 11.40255, -84.89991);
case 38: return new CityInfo("San Marcos", "02", 11.90949, -86.20351);
case 39: return new CityInfo("San Lucas", "09", 13.4138, -86.6111);
case 40: return new CityInfo("San Lorenzo", "01", 12.3783, -85.66646);
case 41: return new CityInfo("San Juan de Río Coco", "09", 13.54476, -86.16499);
case 42: return new CityInfo("San Juan de Oriente", "11", 11.90624, -86.07343);
case 43: return new CityInfo("San Juan del Sur", "15", 11.25292, -85.87049);
case 44: return new CityInfo("Greytown", "14", 10.94684, -83.73467);
case 45: return new CityInfo("San Juan de Limay", "05", 13.17603, -86.61234);
case 46: return new CityInfo("San José de los Remates", "01", 12.5975, -85.76174);
case 47: return new CityInfo("San José de Cusmapa", "09", 13.28841, -86.65539);
case 48: return new CityInfo("San José de Bocay", "07", 13.54204, -85.53942);
case 49: return new CityInfo("San Jorge", "15", 11.45584, -85.80308);
case 50: return new CityInfo("San Isidro", "12", 12.92957, -86.19521);
case 51: return new CityInfo("San Francisco Libre", "10", 12.50497, -86.29942);
case 52: return new CityInfo("San Francisco del Norte", "03", 13.19921, -86.77101);
case 53: return new CityInfo("San Francisco", "03", 12.82613, -87.44557);
case 54: return new CityInfo("San Fernando", "13", 13.67755, -86.31486);
case 55: return new CityInfo("San Dionisio", "12", 12.76023, -85.85018);
case 56: return new CityInfo("San Carlos", "14", 11.1236, -84.77795);
case 57: return new CityInfo("Rivas", "15", 11.43716, -85.82632);
case 58: return new CityInfo("Río Blanco", "12", 12.93435, -85.22354);
case 59: return new CityInfo("El Rama", "18", 12.15965, -84.21952);
case 60: return new CityInfo("Quilalí", "13", 13.56695, -86.026);
case 61: return new CityInfo("Quezalguaque", "08", 12.50683, -86.90292);
case 62: return new CityInfo("Puerto Morazán", "03", 12.85042, -87.17167);
case 63: return new CityInfo("Puerto Cabezas", "17", 14.03507, -83.38882);
case 64: return new CityInfo("Pueblo Nuevo", "05", 13.37984, -86.48075);
case 65: return new CityInfo("Prinzapolka", "17", 13.40708, -83.56452);
case 66: return new CityInfo("Potosí", "15", 11.49416, -85.8568);
case 67: return new CityInfo("Posoltega", "03", 12.54422, -86.97982);
case 68: return new CityInfo("El Cuá", "07", 13.36844, -85.67335);
case 69: return new CityInfo("Palacagüina", "09", 13.45566, -86.40622);
case 70: return new CityInfo("Ocotal", "13", 13.63208, -86.47516);
case 71: return new CityInfo("El Tortuguero", "18", 12.82247, -84.19629);
case 72: return new CityInfo("Nueva Guinea", "18", 11.68758, -84.45616);
case 73: return new CityInfo("Niquinohomo", "11", 11.90518, -86.09446);
case 74: return new CityInfo("Nindirí", "11", 12.00386, -86.12128);
case 75: return new CityInfo("Nandasmo", "11", 11.92411, -86.12072);
case 76: return new CityInfo("Nandaime", "06", 11.75696, -86.05286);
case 77: return new CityInfo("Nagarote", "08", 12.26593, -86.56474);
case 78: return new CityInfo("Muy Muy", "12", 12.76224, -85.62915);
case 79: return new CityInfo("Murra", "13", 13.7585, -86.01843);
case 80: return new CityInfo("Mulukukú", "17", 13.17611, -84.95522);
case 81: return new CityInfo("Muelle de los Bueyes", "18", 12.06999, -84.53503);
case 82: return new CityInfo("Mozonte", "13", 13.66034, -86.43841);
case 83: return new CityInfo("Moyogalpa", "15", 11.54006, -85.69795);
case 84: return new CityInfo("Morrito", "14", 11.62118, -85.08052);
case 85: return new CityInfo("Matiguás", "12", 12.83734, -85.46218);
case 86: return new CityInfo("Mateare", "10", 12.23512, -86.42809);
case 87: return new CityInfo("Matagalpa", "12", 12.92559, -85.91747);
case 88: return new CityInfo("Masaya", "11", 11.97444, -86.09417);
case 89: return new CityInfo("Masatepe", "11", 11.91445, -86.14458);
case 90: return new CityInfo("Masachapa", "10", 11.78687, -86.51416);
case 91: return new CityInfo("Managua", "10", 12.13282, -86.2504);
case 92: return new CityInfo("Malpaisillo", "08", 12.59374, -86.67952);
case 93: return new CityInfo("Macuelizo", "13", 13.65328, -86.61297);
case 94: return new CityInfo("León", "08", 12.43787, -86.87804);
case 95: return new CityInfo("La Trinidad", "05", 12.96881, -86.23534);
case 96: return new CityInfo("Las Sabanas", "09", 13.34302, -86.62184);
case 97: return new CityInfo("Larreynaga", "08", 12.67692, -86.57193);
case 98: return new CityInfo("La Paz de Carazo", "02", 11.82311, -86.12781);
case 99: return new CityInfo("La Paz Centro", "08", 12.34, -86.67528);
case 100: return new CityInfo("La Libertad", "04", 12.21635, -85.16595);
case 101: return new CityInfo("Laguna de Perlas", "18", 12.34294, -83.67123);
case 102: return new CityInfo("La Cruz de Río Grande", "18", 13.1129, -84.18588);
case 103: return new CityInfo("La Conquista", "02", 11.73426, -86.19279);
case 104: return new CityInfo("La Concordia", "07", 13.19528, -86.16659);
case 105: return new CityInfo("La Concepción", "11", 11.93711, -86.18976);
case 106: return new CityInfo("Kukrahill", "18", 12.24096, -83.74517);
case 107: return new CityInfo("Karawala", "18", 12.93072, -83.57724);
case 108: return new CityInfo("Juigalpa", "04", 12.10629, -85.36452);
case 109: return new CityInfo("Jiquilillo", "03", 12.74593, -87.4516);
case 110: return new CityInfo("Jinotepe", "02", 11.84962, -86.19903);
case 111: return new CityInfo("Jinotega", "07", 13.09103, -86.00234);
case 112: return new CityInfo("Jalapa", "13", 13.92221, -86.12346);
case 113: return new CityInfo("Granada", "06", 11.92988, -85.95602);
case 114: return new CityInfo("Estelí", "05", 13.09185, -86.35384);
case 115: return new CityInfo("Esquipulas", "12", 12.66446, -85.78734);
case 116: return new CityInfo("El Viejo", "03", 12.66348, -87.16663);
case 117: return new CityInfo("El Sauce", "08", 12.88687, -86.53903);
case 118: return new CityInfo("El Rosario", "02", 11.8328, -86.16526);
case 119: return new CityInfo("El Rosario", "02", 11.77756, -86.37374);
case 120: return new CityInfo("El Realejo", "03", 12.54333, -87.16517);
case 121: return new CityInfo("El Jicaral", "08", 12.72676, -86.38057);
case 122: return new CityInfo("El Cuá", "07", 13.41667, -85.75);
case 123: return new CityInfo("El Crucero", "10", 11.99008, -86.30954);
case 124: return new CityInfo("El Castillo de La Concepción", "14", 11.01844, -84.39811);
case 125: return new CityInfo("El Ayote", "04", 12.19046, -85.28737);
case 126: return new CityInfo("El Almendro", "14", 11.67859, -84.70269);
case 127: return new CityInfo("Dolores", "02", 11.85672, -86.21552);
case 128: return new CityInfo("Diriomo", "06", 11.87631, -86.05184);
case 129: return new CityInfo("Diriamba", "02", 11.85812, -86.23922);
case 130: return new CityInfo("Diriá", "06", 11.8842, -86.05508);
case 131: return new CityInfo("Dipilto", "13", 13.72106, -86.50619);
case 132: return new CityInfo("Cuapa", "04", 12.26875, -85.38205);
case 133: return new CityInfo("Corn Island", "18", 12.17575, -83.06145);
case 134: return new CityInfo("Corinto", "03", 12.4825, -87.17304);
case 135: return new CityInfo("Condega", "05", 13.36502, -86.39846);
case 136: return new CityInfo("Comalapa", "04", 12.28345, -85.51081);
case 137: return new CityInfo("El Jícaro", "13", 13.7229, -86.13852);
case 138: return new CityInfo("Ciudad Darío", "12", 12.73143, -86.12402);
case 139: return new CityInfo("Ciudad Antigua", "13", 13.6406, -86.30815);
case 140: return new CityInfo("Cinco Pinos", "03", 13.22956, -86.86808);
case 141: return new CityInfo("Chinandega", "03", 12.62937, -87.13105);
case 142: return new CityInfo("Chichigalpa", "03", 12.57758, -87.02705);
case 143: return new CityInfo("Catarina", "11", 11.91197, -86.07383);
case 144: return new CityInfo("Villa El Carmen", "10", 11.98009, -86.50571);
case 145: return new CityInfo("Cárdenas", "15", 11.19639, -85.5089);
case 146: return new CityInfo("Camoapa", "01", 12.38383, -85.51277);
case 147: return new CityInfo("Buenos Aires", "15", 11.46916, -85.81661);
case 148: return new CityInfo("Bonanza", "17", 14.02885, -84.59103);
case 149: return new CityInfo("Bocay", "07", 14.29746, -85.15155);
case 150: return new CityInfo("Bocana de Paiwas", "18", 12.78571, -85.12269);
case 151: return new CityInfo("Boca de Sábalos", "14", 11.05, -84.46667);
case 152: return new CityInfo("Boaco", "01", 12.47224, -85.6586);
case 153: return new CityInfo("Bluefields", "18", 12.01366, -83.76353);
case 154: return new CityInfo("Belén", "15", 11.50299, -85.88935);
case 155: return new CityInfo("Altagracia", "15", 11.56615, -85.5784);
case 156: return new CityInfo("Acoyapa", "04", 11.97028, -85.17113);
case 157: return new CityInfo("Achuapa", "08", 13.0537, -86.59004);
case 158: return new CityInfo("Ciudad Sandino", "10", 12.15889, -86.34417);
case 159: return new CityInfo("Las Praderas", "07", 13.17, -85.85);
case 160: return new CityInfo("Santa Maía de Pantasma", "07", 13.34809, -85.94451);
case 161: return new CityInfo("Wiwilí de Jinotega", "07", 13.61494, -85.81676);
case 162: return new CityInfo("Wiwili", "07", 13.61868, -85.82519);
case 163: return new CityInfo("El Coral", "04", 11.91781, -84.64827);
case 164: return new CityInfo("Waslala", "17", 13.33581, -85.37054);
case 165: return new CityInfo("El Ayote", "18", 12.49952, -84.81519);
case 166: return new CityInfo("La Dalia", "12", 13.13652, -85.73738);
default: return new CityInfo("Rancho Grande", "12", 13.23695, -85.55817);

                                    }                                        
                                }
                            
                        }
                    }
                