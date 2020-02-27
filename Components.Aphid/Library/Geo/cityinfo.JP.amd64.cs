
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
                                    public const string Country = "JP";
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
                            
                                        var cur = (Math.Abs(33.73333 - lat) + Math.Abs(135.98333 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(35.44272 - lat) + Math.Abs(139.36931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.65524 - lat) + Math.Abs(135.00687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.29483 - lat) + Math.Abs(139.57812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.22699 - lat) + Math.Abs(133.77791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.4879 - lat) + Math.Abs(139.39101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.01573 - lat) + Math.Abs(139.92909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.8 - lat) + Math.Abs(137.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.72873 - lat) + Math.Abs(130.983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3 - lat) + Math.Abs(139.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.15 - lat) + Math.Abs(139.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.2347 - lat) + Math.Abs(130.47942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.39611 - lat) + Math.Abs(135.85768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89232 - lat) + Math.Abs(139.84184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.25 - lat) + Math.Abs(138.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.68333 - lat) + Math.Abs(138.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.11567 - lat) + Math.Abs(139.19429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.88333 - lat) + Math.Abs(139.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.46667 - lat) + Math.Abs(123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.43333 - lat) + Math.Abs(133.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.28361 - lat) + Math.Abs(139.66722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.43333 - lat) + Math.Abs(139.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.96667 - lat) + Math.Abs(136.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.11626 - lat) + Math.Abs(136.19768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.87009 - lat) + Math.Abs(135.7027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.50439 - lat) + Math.Abs(130.59952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.56667 - lat) + Math.Abs(137.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.42146 - lat) + Math.Abs(133.24224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.91667 - lat) + Math.Abs(134.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.82255 - lat) + Math.Abs(139.83905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.61667 - lat) + Math.Abs(135.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.96667 - lat) + Math.Abs(132.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.16667 - lat) + Math.Abs(130.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.51667 - lat) + Math.Abs(135.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35 - lat) + Math.Abs(134.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.36344 - lat) + Math.Abs(139.07975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.18333 - lat) + Math.Abs(131.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.01667 - lat) + Math.Abs(130.68911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.86877 - lat) + Math.Abs(138.31952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.8 - lat) + Math.Abs(139.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.40304 - lat) + Math.Abs(134.77118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.06667 - lat) + Math.Abs(134.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.40458 - lat) + Math.Abs(136.89912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.56667 - lat) + Math.Abs(139.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.68333 - lat) + Math.Abs(130.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.12342 - lat) + Math.Abs(131.80401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.20142 - lat) + Math.Abs(130.02171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.11358 - lat) + Math.Abs(130.00292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.67056 - lat) + Math.Abs(139.88861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.8 - lat) + Math.Abs(137.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.56826 - lat) + Math.Abs(130.51009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.68333 - lat) + Math.Abs(139.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.89044 - lat) + Math.Abs(135.80325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.61667 - lat) + Math.Abs(139.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.75856 - lat) + Math.Abs(136.13108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.89964 - lat) + Math.Abs(130.68898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.40265 - lat) + Math.Abs(138.28161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.94306 - lat) + Math.Abs(131.25111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.05215 - lat) + Math.Abs(133.99885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.16667 - lat) + Math.Abs(136.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.24528 - lat) + Math.Abs(131.69165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.72167 - lat) + Math.Abs(139.82167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.45 - lat) + Math.Abs(136.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.64547 - lat) + Math.Abs(136.0558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.1 - lat) + Math.Abs(131.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.07539 - lat) + Math.Abs(131.86907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.27668 - lat) + Math.Abs(131.15628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.67307 - lat) + Math.Abs(131.03776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.67012 - lat) + Math.Abs(136.7403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.6645 - lat) + Math.Abs(138.92518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.73333 - lat) + Math.Abs(136.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.08333 - lat) + Math.Abs(137.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.29991 - lat) + Math.Abs(137.90108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.54008 - lat) + Math.Abs(134.82038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.78244 - lat) + Math.Abs(135.46932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.81667 - lat) + Math.Abs(137.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.76667 - lat) + Math.Abs(137.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.70933 - lat) + Math.Abs(136.93425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.7 - lat) + Math.Abs(137.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.5 - lat) + Math.Abs(134.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.36667 - lat) + Math.Abs(130.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.48047 - lat) + Math.Abs(134.17017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.50065 - lat) + Math.Abs(135.60211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.25411 - lat) + Math.Abs(138.89813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.18583 - lat) + Math.Abs(127.68192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.6895 - lat) + Math.Abs(139.69171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.05 - lat) + Math.Abs(131.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.06667 - lat) + Math.Abs(134.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.79916 - lat) + Math.Abs(139.46903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88333 - lat) + Math.Abs(136.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.35 - lat) + Math.Abs(137.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.13333 - lat) + Math.Abs(138.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.83333 - lat) + Math.Abs(129.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.47642 - lat) + Math.Abs(138.99513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.38333 - lat) + Math.Abs(139.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.4833 - lat) + Math.Abs(136.84186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.58333 - lat) + Math.Abs(135.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.9 - lat) + Math.Abs(139.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.5542 - lat) + Math.Abs(135.79297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.98426 - lat) + Math.Abs(137.99721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.86437 - lat) + Math.Abs(134.552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98333 - lat) + Math.Abs(139.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.25 - lat) + Math.Abs(139.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.48333 - lat) + Math.Abs(130.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.36667 - lat) + Math.Abs(136.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.35 - lat) + Math.Abs(130.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.36667 - lat) + Math.Abs(139.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.72526 - lat) + Math.Abs(139.5383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.72922 - lat) + Math.Abs(139.53813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82242 - lat) + Math.Abs(135.76604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.73333 - lat) + Math.Abs(135.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.51745 - lat) + Math.Abs(133.94574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.94716 - lat) + Math.Abs(130.57446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3 - lat) + Math.Abs(139.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.85 - lat) + Math.Abs(136.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.19009 - lat) + Math.Abs(130.02084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.33833 - lat) + Math.Abs(132.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.90393 - lat) + Math.Abs(136.16687 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.96667 - lat) + Math.Abs(131.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.13333 - lat) + Math.Abs(137.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.84833 - lat) + Math.Abs(135.61678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.33333 - lat) + Math.Abs(139.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.79936 - lat) + Math.Abs(135.35697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.75 - lat) + Math.Abs(137.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.13333 - lat) + Math.Abs(131.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.33333 - lat) + Math.Abs(134.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.51667 - lat) + Math.Abs(135.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.78333 - lat) + Math.Abs(133.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.91667 - lat) + Math.Abs(136.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.5567 - lat) + Math.Abs(131.44506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.31667 - lat) + Math.Abs(137.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.66667 - lat) + Math.Abs(137.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.63333 - lat) + Math.Abs(130.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.275 - lat) + Math.Abs(133.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88333 - lat) + Math.Abs(136.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.65 - lat) + Math.Abs(138.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.03799 - lat) + Math.Abs(138.11308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.39471 - lat) + Math.Abs(133.29128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.34322 - lat) + Math.Abs(134.88911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.93333 - lat) + Math.Abs(132.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.76143 - lat) + Math.Abs(135.51567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.84608 - lat) + Math.Abs(139.23039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.03107 - lat) + Math.Abs(139.72636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.65 - lat) + Math.Abs(131.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.83643 - lat) + Math.Abs(139.79957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.67534 - lat) + Math.Abs(133.75091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.25 - lat) + Math.Abs(136.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.06667 - lat) + Math.Abs(139.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.85 - lat) + Math.Abs(133.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98333 - lat) + Math.Abs(138.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.76354 - lat) + Math.Abs(139.02199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.01839 - lat) + Math.Abs(139.66034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.78333 - lat) + Math.Abs(134.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.03757 - lat) + Math.Abs(138.84867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.1 - lat) + Math.Abs(137.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.9 - lat) + Math.Abs(137.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.55543 - lat) + Math.Abs(133.27297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.71399 - lat) + Math.Abs(130.4313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.18333 - lat) + Math.Abs(139.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.95 - lat) + Math.Abs(130.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3 - lat) + Math.Abs(139.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.67652 - lat) + Math.Abs(138.94456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.2152 - lat) + Math.Abs(135.1501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.77957 - lat) + Math.Abs(137.07576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.81667 - lat) + Math.Abs(138.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.78333 - lat) + Math.Abs(130.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.33333 - lat) + Math.Abs(136.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.83333 - lat) + Math.Abs(139.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.65341 - lat) + Math.Abs(131.05797 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.32333 - lat) + Math.Abs(134.17333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.476 - lat) + Math.Abs(131.10114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.48333 - lat) + Math.Abs(139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.95 - lat) + Math.Abs(139.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.77819 - lat) + Math.Abs(135.59512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.23333 - lat) + Math.Abs(137.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.14858 - lat) + Math.Abs(130.46548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.81667 - lat) + Math.Abs(130.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.48333 - lat) + Math.Abs(136.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.07254 - lat) + Math.Abs(139.72615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.16834 - lat) + Math.Abs(129.72502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.06667 - lat) + Math.Abs(135.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.61561 - lat) + Math.Abs(130.55105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.31667 - lat) + Math.Abs(139.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.61667 - lat) + Math.Abs(138.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88444 - lat) + Math.Abs(135.22694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.5 - lat) + Math.Abs(135.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.21667 - lat) + Math.Abs(138.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.91667 - lat) + Math.Abs(139.855 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.53774 - lat) + Math.Abs(133.23094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.32278 - lat) + Math.Abs(133.8356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.26667 - lat) + Math.Abs(139.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.1 - lat) + Math.Abs(139.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.58333 - lat) + Math.Abs(135.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.95694 - lat) + Math.Abs(139.38889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.95 - lat) + Math.Abs(131.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.68503 - lat) + Math.Abs(138.20461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.23333 - lat) + Math.Abs(130.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.94647 - lat) + Math.Abs(136.18498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.65 - lat) + Math.Abs(138.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.07817 - lat) + Math.Abs(138.43939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.8804 - lat) + Math.Abs(130.87161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3 - lat) + Math.Abs(139.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.60359 - lat) + Math.Abs(138.21719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.06667 - lat) + Math.Abs(136.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.46667 - lat) + Math.Abs(135.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.61851 - lat) + Math.Abs(138.97396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35 - lat) + Math.Abs(135.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.20754 - lat) + Math.Abs(132.22063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3 - lat) + Math.Abs(139.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.69374 - lat) + Math.Abs(135.50218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.41667 - lat) + Math.Abs(133.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.00139 - lat) + Math.Abs(131.18361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.98106 - lat) + Math.Abs(136.48727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.85 - lat) + Math.Abs(134.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.28333 - lat) + Math.Abs(132.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.03333 - lat) + Math.Abs(130.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.92139 - lat) + Math.Abs(129.95389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.78389 - lat) + Math.Abs(139.24306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.43181 - lat) + Math.Abs(139.27534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.5 - lat) + Math.Abs(137.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.06779 - lat) + Math.Abs(130.62439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36 - lat) + Math.Abs(139.55722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.95 - lat) + Math.Abs(137.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.65 - lat) + Math.Abs(133.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.05659 - lat) + Math.Abs(138.0451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.20566 - lat) + Math.Abs(130.37527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.3 - lat) + Math.Abs(138.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.23333 - lat) + Math.Abs(131.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.31558 - lat) + Math.Abs(139.31625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.85091 - lat) + Math.Abs(139.51998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.1 - lat) + Math.Abs(131.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.05342 - lat) + Math.Abs(139.26612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.35 - lat) + Math.Abs(136.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.25556 - lat) + Math.Abs(139.15972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.19025 - lat) + Math.Abs(132.50846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01756 - lat) + Math.Abs(136.94947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.81667 - lat) + Math.Abs(129.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.49576 - lat) + Math.Abs(135.74604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.93744 - lat) + Math.Abs(137.50059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.1 - lat) + Math.Abs(138.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.63333 - lat) + Math.Abs(139.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.53333 - lat) + Math.Abs(136.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.74051 - lat) + Math.Abs(130.72263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.94897 - lat) + Math.Abs(139.86793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.58333 - lat) + Math.Abs(131.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98419 - lat) + Math.Abs(134.97407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.86667 - lat) + Math.Abs(137.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.73333 - lat) + Math.Abs(131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.71562 - lat) + Math.Abs(135.33199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.7 - lat) + Math.Abs(138.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3015 - lat) + Math.Abs(139.25581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.75 - lat) + Math.Abs(139.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.80024 - lat) + Math.Abs(139.1224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98333 - lat) + Math.Abs(133.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.96047 - lat) + Math.Abs(133.30522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.88637 - lat) + Math.Abs(139.00589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.6 - lat) + Math.Abs(131.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.36667 - lat) + Math.Abs(129.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.19933 - lat) + Math.Abs(134.60932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.68505 - lat) + Math.Abs(135.80485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.05 - lat) + Math.Abs(136.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.75965 - lat) + Math.Abs(137.36215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.48333 - lat) + Math.Abs(137.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.59811 - lat) + Math.Abs(131.1883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.58717 - lat) + Math.Abs(138.84083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.75 - lat) + Math.Abs(138.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.98333 - lat) + Math.Abs(132.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.81688 - lat) + Math.Abs(130.70962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.21667 - lat) + Math.Abs(127.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.18147 - lat) + Math.Abs(136.90641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.61502 - lat) + Math.Abs(127.98543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.39516 - lat) + Math.Abs(130.42548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.75 - lat) + Math.Abs(129.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.8563 - lat) + Math.Abs(139.90266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.45 - lat) + Math.Abs(138.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.65 - lat) + Math.Abs(138.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.38333 - lat) + Math.Abs(136.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.61667 - lat) + Math.Abs(136.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.70611 - lat) + Math.Abs(139.55944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.28662 - lat) + Math.Abs(134.16832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.69257 - lat) + Math.Abs(139.17127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23333 - lat) + Math.Abs(139.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.96545 - lat) + Math.Abs(135.70415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.06667 - lat) + Math.Abs(138.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.93556 - lat) + Math.Abs(139.30444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.06667 - lat) + Math.Abs(135.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.73333 - lat) + Math.Abs(135.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.83333 - lat) + Math.Abs(137.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.36667 - lat) + Math.Abs(137.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8 - lat) + Math.Abs(132.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.53333 - lat) + Math.Abs(135.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.91667 - lat) + Math.Abs(131.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.4269 - lat) + Math.Abs(130.57151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.73333 - lat) + Math.Abs(131.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.29907 - lat) + Math.Abs(132.32186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.70811 - lat) + Math.Abs(130.65297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.53333 - lat) + Math.Abs(138.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.01667 - lat) + Math.Abs(139.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.41667 - lat) + Math.Abs(137.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.11667 - lat) + Math.Abs(138.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82691 - lat) + Math.Abs(135.47057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.53333 - lat) + Math.Abs(136.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.49527 - lat) + Math.Abs(139.44279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.21667 - lat) + Math.Abs(130.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.96667 - lat) + Math.Abs(136.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.21706 - lat) + Math.Abs(136.15185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8 - lat) + Math.Abs(134.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.4 - lat) + Math.Abs(133.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.41667 - lat) + Math.Abs(139.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.22245 - lat) + Math.Abs(139.38205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.51667 - lat) + Math.Abs(136.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.23333 - lat) + Math.Abs(137.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.48333 - lat) + Math.Abs(133.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.77995 - lat) + Math.Abs(139.90144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.65 - lat) + Math.Abs(130.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.56667 - lat) + Math.Abs(135.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.66667 - lat) + Math.Abs(131.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.1534 - lat) + Math.Abs(136.27029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.31865 - lat) + Math.Abs(138.27329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.28333 - lat) + Math.Abs(133.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.26667 - lat) + Math.Abs(130.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.77437 - lat) + Math.Abs(138.14831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75 - lat) + Math.Abs(138.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.45 - lat) + Math.Abs(135.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.31667 - lat) + Math.Abs(136.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.4 - lat) + Math.Abs(139.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.55916 - lat) + Math.Abs(130.20148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.54028 - lat) + Math.Abs(139.45083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.02107 - lat) + Math.Abs(135.75385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.71667 - lat) + Math.Abs(130.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01667 - lat) + Math.Abs(135.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.31667 - lat) + Math.Abs(130.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.35 - lat) + Math.Abs(136.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.27123 - lat) + Math.Abs(130.4236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.13333 - lat) + Math.Abs(139.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.23222 - lat) + Math.Abs(132.56658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.43333 - lat) + Math.Abs(133.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.58333 - lat) + Math.Abs(133.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.80589 - lat) + Math.Abs(130.69181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.13497 - lat) + Math.Abs(139.39004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.06739 - lat) + Math.Abs(139.67498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34 - lat) + Math.Abs(131.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8 - lat) + Math.Abs(137.35889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.23461 - lat) + Math.Abs(130.53517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89035 - lat) + Math.Abs(139.78916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(30.38796 - lat) + Math.Abs(130.64924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.06868 - lat) + Math.Abs(139.51684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.33165 - lat) + Math.Abs(136.87042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.31667 - lat) + Math.Abs(138.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35 - lat) + Math.Abs(136.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34 - lat) + Math.Abs(134.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.40263 - lat) + Math.Abs(136.45088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.28333 - lat) + Math.Abs(136.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.70222 - lat) + Math.Abs(139.47556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.73333 - lat) + Math.Abs(130.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.18333 - lat) + Math.Abs(139.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.73333 - lat) + Math.Abs(130.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.66667 - lat) + Math.Abs(138.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.18497 - lat) + Math.Abs(139.13191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.55 - lat) + Math.Abs(133.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.6913 - lat) + Math.Abs(135.183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.98333 - lat) + Math.Abs(130.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.21667 - lat) + Math.Abs(136.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.41998 - lat) + Math.Abs(131.61837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.85181 - lat) + Math.Abs(130.85034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.65 - lat) + Math.Abs(139.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.16667 - lat) + Math.Abs(135.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.46667 - lat) + Math.Abs(135.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.38329 - lat) + Math.Abs(139.93254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.1 - lat) + Math.Abs(139.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.4 - lat) + Math.Abs(139.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.98333 - lat) + Math.Abs(130.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.11667 - lat) + Math.Abs(139.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.52056 - lat) + Math.Abs(139.71722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.59993 - lat) + Math.Abs(130.81495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.81667 - lat) + Math.Abs(135.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.80521 - lat) + Math.Abs(139.71072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.90861 - lat) + Math.Abs(139.48528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.06173 - lat) + Math.Abs(136.50101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.98308 - lat) + Math.Abs(139.74966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.24762 - lat) + Math.Abs(136.97229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.36667 - lat) + Math.Abs(138.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.86224 - lat) + Math.Abs(139.97732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.10611 - lat) + Math.Abs(130.09056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.50896 - lat) + Math.Abs(135.7929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.58333 - lat) + Math.Abs(135.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.41667 - lat) + Math.Abs(130.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.50597 - lat) + Math.Abs(133.50391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.36667 - lat) + Math.Abs(136.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98333 - lat) + Math.Abs(136.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.4425 - lat) + Math.Abs(129.96972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.30895 - lat) + Math.Abs(130.37383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.55 - lat) + Math.Abs(139.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.38333 - lat) + Math.Abs(130.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.1276 - lat) + Math.Abs(133.64598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.55808 - lat) + Math.Abs(133.41796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.13333 - lat) + Math.Abs(136.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.41097 - lat) + Math.Abs(138.99621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.78333 - lat) + Math.Abs(130.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.6 - lat) + Math.Abs(136.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82022 - lat) + Math.Abs(138.12775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.06803 - lat) + Math.Abs(134.35033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.53745 - lat) + Math.Abs(133.58967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.66442 - lat) + Math.Abs(139.03502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.69423 - lat) + Math.Abs(139.55495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.43333 - lat) + Math.Abs(139.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.7 - lat) + Math.Abs(137.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.85 - lat) + Math.Abs(136.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35 - lat) + Math.Abs(135.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.87214 - lat) + Math.Abs(139.1099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.30889 - lat) + Math.Abs(139.55028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.76943 - lat) + Math.Abs(134.82905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.76667 - lat) + Math.Abs(138.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.41667 - lat) + Math.Abs(136.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.96536 - lat) + Math.Abs(140.64474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.73333 - lat) + Math.Abs(130.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.45 - lat) + Math.Abs(135.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.15166 - lat) + Math.Abs(135.21398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.56667 - lat) + Math.Abs(130.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.7381 - lat) + Math.Abs(135.57442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.36667 - lat) + Math.Abs(132.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.41667 - lat) + Math.Abs(135.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.5 - lat) + Math.Abs(135.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.48333 - lat) + Math.Abs(135.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.08333 - lat) + Math.Abs(130.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.96474 - lat) + Math.Abs(139.69644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.7 - lat) + Math.Abs(137.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.28333 - lat) + Math.Abs(136.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.16297 - lat) + Math.Abs(132.22 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.05 - lat) + Math.Abs(139.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.25 - lat) + Math.Abs(135.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.72528 - lat) + Math.Abs(139.21778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.12647 - lat) + Math.Abs(127.66918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.03333 - lat) + Math.Abs(137.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.96667 - lat) + Math.Abs(139.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.78427 - lat) + Math.Abs(135.40126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8 - lat) + Math.Abs(137.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.42333 - lat) + Math.Abs(127.82139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.06752 - lat) + Math.Abs(134.44208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.11667 - lat) + Math.Abs(139.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.34478 - lat) + Math.Abs(124.15717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.31667 - lat) + Math.Abs(139.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.39932 - lat) + Math.Abs(139.31019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.48333 - lat) + Math.Abs(136.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.65 - lat) + Math.Abs(138.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.84111 - lat) + Math.Abs(130.04306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.37995 - lat) + Math.Abs(136.94295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.55 - lat) + Math.Abs(133.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.28333 - lat) + Math.Abs(133.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.25 - lat) + Math.Abs(136.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.82756 - lat) + Math.Abs(137.95378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.27362 - lat) + Math.Abs(129.87877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.71667 - lat) + Math.Abs(139.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.68333 - lat) + Math.Abs(135.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.82208 - lat) + Math.Abs(135.4298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.02849 - lat) + Math.Abs(133.80616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.61667 - lat) + Math.Abs(130.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.63654 - lat) + Math.Abs(130.68678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.85 - lat) + Math.Abs(138.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.51965 - lat) + Math.Abs(137.82074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3 - lat) + Math.Abs(136.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.23333 - lat) + Math.Abs(130.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.81641 - lat) + Math.Abs(135.56828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.6 - lat) + Math.Abs(133.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3396 - lat) + Math.Abs(137.88254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.61234 - lat) + Math.Abs(135.73754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.2378 - lat) + Math.Abs(139.19023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.45993 - lat) + Math.Abs(130.16713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.05 - lat) + Math.Abs(131.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.21667 - lat) + Math.Abs(130.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.3213 - lat) + Math.Abs(130.94098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.66667 - lat) + Math.Abs(136.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.4 - lat) + Math.Abs(132.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.32785 - lat) + Math.Abs(139.33735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.43333 - lat) + Math.Abs(132.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.80379 - lat) + Math.Abs(125.30222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.81352 - lat) + Math.Abs(135.64914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.36853 - lat) + Math.Abs(129.55247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.58333 - lat) + Math.Abs(130.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.67306 - lat) + Math.Abs(139.40028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35 - lat) + Math.Abs(136.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.85609 - lat) + Math.Abs(136.9885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.81667 - lat) + Math.Abs(134.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.25 - lat) + Math.Abs(136.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.37081 - lat) + Math.Abs(131.53025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.66667 - lat) + Math.Abs(135.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88333 - lat) + Math.Abs(136.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.96277 - lat) + Math.Abs(138.78543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.27651 - lat) + Math.Abs(139.57733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.35 - lat) + Math.Abs(132.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.83314 - lat) + Math.Abs(139.7425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.31667 - lat) + Math.Abs(135.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.16667 - lat) + Math.Abs(139.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.85194 - lat) + Math.Abs(139.31806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88333 - lat) + Math.Abs(136.93333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.71667 - lat) + Math.Abs(130.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.7 - lat) + Math.Abs(137.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8 - lat) + Math.Abs(137.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88333 - lat) + Math.Abs(132.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.88333 - lat) + Math.Abs(136.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.18945 - lat) + Math.Abs(139.02649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.53333 - lat) + Math.Abs(135.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.4 - lat) + Math.Abs(131.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.33294 - lat) + Math.Abs(127.87403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.37111 - lat) + Math.Abs(139.22361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.65583 - lat) + Math.Abs(139.32389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.12861 - lat) + Math.Abs(136.0976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.14074 - lat) + Math.Abs(139.46011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.35937 - lat) + Math.Abs(127.86735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.00856 - lat) + Math.Abs(132.2257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.31859 - lat) + Math.Abs(138.94343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.73333 - lat) + Math.Abs(139.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.45 - lat) + Math.Abs(135.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.35 - lat) + Math.Abs(135.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.41667 - lat) + Math.Abs(136.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.88153 - lat) + Math.Abs(135.1696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.26265 - lat) + Math.Abs(127.76147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.42291 - lat) + Math.Abs(136.76039 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.83333 - lat) + Math.Abs(137.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3108 - lat) + Math.Abs(139.81877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.70129 - lat) + Math.Abs(139.98648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.48333 - lat) + Math.Abs(133.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.75 - lat) + Math.Abs(137.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.25765 - lat) + Math.Abs(134.71535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.6 - lat) + Math.Abs(130.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.55751 - lat) + Math.Abs(136.86945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.76627 - lat) + Math.Abs(130.47461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.06443 - lat) + Math.Abs(136.22257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.69732 - lat) + Math.Abs(128.84561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3 - lat) + Math.Abs(135.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.1 - lat) + Math.Abs(139.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.2 - lat) + Math.Abs(139.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.34926 - lat) + Math.Abs(139.47666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.25 - lat) + Math.Abs(139.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.24624 - lat) + Math.Abs(139.07204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.21667 - lat) + Math.Abs(138.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.86667 - lat) + Math.Abs(138.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.16667 - lat) + Math.Abs(138.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.5735 - lat) + Math.Abs(133.23513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.7 - lat) + Math.Abs(138.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.71378 - lat) + Math.Abs(135.62033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.65924 - lat) + Math.Abs(139.54837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35 - lat) + Math.Abs(137.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.9944 - lat) + Math.Abs(138.15428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.49631 - lat) + Math.Abs(130.5156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.33638 - lat) + Math.Abs(139.40434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.99028 - lat) + Math.Abs(139.07639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.30948 - lat) + Math.Abs(127.77024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.27945 - lat) + Math.Abs(131.49751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3 - lat) + Math.Abs(135.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.22309 - lat) + Math.Abs(136.19236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.08834 - lat) + Math.Abs(139.05325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.72807 - lat) + Math.Abs(135.30264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.33333 - lat) + Math.Abs(139.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.00059 - lat) + Math.Abs(138.2259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.33011 - lat) + Math.Abs(138.89585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.95828 - lat) + Math.Abs(137.08054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.91667 - lat) + Math.Abs(134.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.41804 - lat) + Math.Abs(130.65413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.71667 - lat) + Math.Abs(135.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.01667 - lat) + Math.Abs(130.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.75136 - lat) + Math.Abs(134.38734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.5 - lat) + Math.Abs(133.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.80361 - lat) + Math.Abs(134.46806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.97145 - lat) + Math.Abs(139.61382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.33583 - lat) + Math.Abs(127.80139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.48621 - lat) + Math.Abs(131.2421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.955 - lat) + Math.Abs(131.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.38333 - lat) + Math.Abs(131.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.97113 - lat) + Math.Abs(139.6491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.87266 - lat) + Math.Abs(139.51369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.85295 - lat) + Math.Abs(139.41212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.73667 - lat) + Math.Abs(139.32361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.80472 - lat) + Math.Abs(139.60194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.78944 - lat) + Math.Abs(139.62333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.815 - lat) + Math.Abs(139.6853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.35043 - lat) + Math.Abs(139.87029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.14 - lat) + Math.Abs(139.61917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.23333 - lat) + Math.Abs(135.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.75139 - lat) + Math.Abs(132.70139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.22375 - lat) + Math.Abs(132.56001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.91667 - lat) + Math.Abs(133.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.5 - lat) + Math.Abs(132.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.83916 - lat) + Math.Abs(132.76574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.78757 - lat) + Math.Abs(132.71124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.01654 - lat) + Math.Abs(133.57844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.07001 - lat) + Math.Abs(133.00023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.97661 - lat) + Math.Abs(132.77767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.16667 - lat) + Math.Abs(140.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.65 - lat) + Math.Abs(140.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91 - lat) + Math.Abs(140.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.31691 - lat) + Math.Abs(140.55034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.7 - lat) + Math.Abs(140.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.85 - lat) + Math.Abs(140.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.42738 - lat) + Math.Abs(141.21487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.23333 - lat) + Math.Abs(140.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.46667 - lat) + Math.Abs(141.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.65 - lat) + Math.Abs(140.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.035 - lat) + Math.Abs(140.85111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.54465 - lat) + Math.Abs(141.13461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.96667 - lat) + Math.Abs(140.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.2 - lat) + Math.Abs(140.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.9 - lat) + Math.Abs(140.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.31667 - lat) + Math.Abs(141.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.35 - lat) + Math.Abs(140.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.39306 - lat) + Math.Abs(140.88611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.55 - lat) + Math.Abs(140.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.35361 - lat) + Math.Abs(140.36972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.0025 - lat) + Math.Abs(140.19111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.71667 - lat) + Math.Abs(140.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.3 - lat) + Math.Abs(141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.28333 - lat) + Math.Abs(140.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.69414 - lat) + Math.Abs(140.98442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.71667 - lat) + Math.Abs(140.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.00333 - lat) + Math.Abs(140.61833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.8 - lat) + Math.Abs(140.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.31667 - lat) + Math.Abs(141.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75861 - lat) + Math.Abs(140.30083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.26667 - lat) + Math.Abs(140.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.88333 - lat) + Math.Abs(140.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.71667 - lat) + Math.Abs(140.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.3725 - lat) + Math.Abs(140.2725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.9 - lat) + Math.Abs(140.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.33092 - lat) + Math.Abs(140.97691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.36667 - lat) + Math.Abs(141.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.86667 - lat) + Math.Abs(140.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.4466 - lat) + Math.Abs(141.44794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.55 - lat) + Math.Abs(140.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.85 - lat) + Math.Abs(140.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.45 - lat) + Math.Abs(140.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.28333 - lat) + Math.Abs(140.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.05 - lat) + Math.Abs(140.73361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.24761 - lat) + Math.Abs(140.39289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.07167 - lat) + Math.Abs(141.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.60333 - lat) + Math.Abs(140.40194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.31409 - lat) + Math.Abs(140.58389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.51667 - lat) + Math.Abs(140.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.58333 - lat) + Math.Abs(140.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.16667 - lat) + Math.Abs(140.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.6 - lat) + Math.Abs(140.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.78333 - lat) + Math.Abs(140.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.48333 - lat) + Math.Abs(141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.05 - lat) + Math.Abs(140.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10361 - lat) + Math.Abs(140.035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.51391 - lat) + Math.Abs(140.40063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.51667 - lat) + Math.Abs(140.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.93333 - lat) + Math.Abs(140 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.7 - lat) + Math.Abs(141.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.43333 - lat) + Math.Abs(140.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.42583 - lat) + Math.Abs(140.29608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13333 - lat) + Math.Abs(141.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.64691 - lat) + Math.Abs(141.94057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.35 - lat) + Math.Abs(140.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.43333 - lat) + Math.Abs(140.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.37357 - lat) + Math.Abs(141.06105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.46667 - lat) + Math.Abs(140.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.91667 - lat) + Math.Abs(140.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.26667 - lat) + Math.Abs(140.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.96667 - lat) + Math.Abs(140.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.4 - lat) + Math.Abs(140.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.55 - lat) + Math.Abs(141.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.28333 - lat) + Math.Abs(141.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.78671 - lat) + Math.Abs(140.74901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.90112 - lat) + Math.Abs(141.57746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.0969 - lat) + Math.Abs(140.1003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.14621 - lat) + Math.Abs(140.31507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.38333 - lat) + Math.Abs(140.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89767 - lat) + Math.Abs(140.49943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.38333 - lat) + Math.Abs(140.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.65 - lat) + Math.Abs(140.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.15389 - lat) + Math.Abs(140.27361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.27694 - lat) + Math.Abs(141.86801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.58926 - lat) + Math.Abs(140.56724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.97451 - lat) + Math.Abs(140.77202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.35 - lat) + Math.Abs(140.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.10472 - lat) + Math.Abs(140.85944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.05 - lat) + Math.Abs(140.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.93333 - lat) + Math.Abs(140.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.18333 - lat) + Math.Abs(140.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.41667 - lat) + Math.Abs(141.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.15 - lat) + Math.Abs(140.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.56667 - lat) + Math.Abs(140.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.91667 - lat) + Math.Abs(141.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.51667 - lat) + Math.Abs(140.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.15 - lat) + Math.Abs(140.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81667 - lat) + Math.Abs(140.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.6 - lat) + Math.Abs(140.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.43889 - lat) + Math.Abs(140.40056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.73333 - lat) + Math.Abs(140.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.38333 - lat) + Math.Abs(141.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.57167 - lat) + Math.Abs(140.95556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.44722 - lat) + Math.Abs(140.5771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.46667 - lat) + Math.Abs(140.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.75 - lat) + Math.Abs(140.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.91667 - lat) + Math.Abs(140.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.95 - lat) + Math.Abs(140.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.81667 - lat) + Math.Abs(140.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.76667 - lat) + Math.Abs(140.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.73333 - lat) + Math.Abs(140.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.6 - lat) + Math.Abs(140.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.71667 - lat) + Math.Abs(140.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.03333 - lat) + Math.Abs(140.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.71667 - lat) + Math.Abs(140.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.86667 - lat) + Math.Abs(140.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.82634 - lat) + Math.Abs(144.09638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.03778 - lat) + Math.Abs(141.95778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40944 - lat) + Math.Abs(141.67389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.51667 - lat) + Math.Abs(142.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.63694 - lat) + Math.Abs(141.60333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.21694 - lat) + Math.Abs(141.51694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.28944 - lat) + Math.Abs(141.21694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.55278 - lat) + Math.Abs(141.90639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.22268 - lat) + Math.Abs(140.36611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.48639 - lat) + Math.Abs(141.90556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.33389 - lat) + Math.Abs(142.36694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.55 - lat) + Math.Abs(141.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.35 - lat) + Math.Abs(142.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.65899 - lat) + Math.Abs(145.13197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.06667 - lat) + Math.Abs(141.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.93444 - lat) + Math.Abs(141.64278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.99167 - lat) + Math.Abs(143.20028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.18944 - lat) + Math.Abs(141.00222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27178 - lat) + Math.Abs(140.55756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.91722 - lat) + Math.Abs(143.20444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20838 - lat) + Math.Abs(140.0274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.45215 - lat) + Math.Abs(141.17914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.32361 - lat) + Math.Abs(145.575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.35056 - lat) + Math.Abs(142.45778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.8944 - lat) + Math.Abs(140.69386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71069 - lat) + Math.Abs(140.59048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.27096 - lat) + Math.Abs(143.36025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.31722 - lat) + Math.Abs(140.98806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.3525 - lat) + Math.Abs(143.3525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68682 - lat) + Math.Abs(141.38969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.20389 - lat) + Math.Abs(140.77028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.25581 - lat) + Math.Abs(141.88818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37139 - lat) + Math.Abs(141.82111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.975 - lat) + Math.Abs(144.37472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64581 - lat) + Math.Abs(140.58354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18778 - lat) + Math.Abs(141.76889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81609 - lat) + Math.Abs(140.37539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.80306 - lat) + Math.Abs(143.89083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.84 - lat) + Math.Abs(142.77111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.82013 - lat) + Math.Abs(140.64482 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.97444 - lat) + Math.Abs(140.50889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.20028 - lat) + Math.Abs(141.75972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.23972 - lat) + Math.Abs(141.35389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21965 - lat) + Math.Abs(141.28986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.97583 - lat) + Math.Abs(141.56722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59306 - lat) + Math.Abs(140.4725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.18361 - lat) + Math.Abs(140.78722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.77583 - lat) + Math.Abs(140.73667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5 - lat) + Math.Abs(141.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.35 - lat) + Math.Abs(142.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.70806 - lat) + Math.Abs(142.03917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.10806 - lat) + Math.Abs(141.55056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.46806 - lat) + Math.Abs(140.86806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.81944 - lat) + Math.Abs(141.65222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.32472 - lat) + Math.Abs(141.85861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.50972 - lat) + Math.Abs(142.18556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.77063 - lat) + Math.Abs(142.36489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81667 - lat) + Math.Abs(140.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.55139 - lat) + Math.Abs(142.05306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.02127 - lat) + Math.Abs(144.26971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80444 - lat) + Math.Abs(140.44139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.93726 - lat) + Math.Abs(131.08008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.21294 - lat) + Math.Abs(135.62244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.25592 - lat) + Math.Abs(132.68343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.56922 - lat) + Math.Abs(136.91162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.80447 - lat) + Math.Abs(136.54645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.97259 - lat) + Math.Abs(136.12455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.76615 - lat) + Math.Abs(135.62759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.39659 - lat) + Math.Abs(140.53479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.316 - lat) + Math.Abs(139.98238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.15326 - lat) + Math.Abs(140.24635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.09047 - lat) + Math.Abs(140.21047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.98411 - lat) + Math.Abs(140.00929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.25449 - lat) + Math.Abs(140.37962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.56447 - lat) + Math.Abs(140.40269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89685 - lat) + Math.Abs(140.66666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.00705 - lat) + Math.Abs(140.49623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.25052 - lat) + Math.Abs(140.11565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.06997 - lat) + Math.Abs(139.86705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.5513 - lat) + Math.Abs(140.52821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.95633 - lat) + Math.Abs(140.32356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.28815 - lat) + Math.Abs(137.88705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.52715 - lat) + Math.Abs(138.08943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.46972 - lat) + Math.Abs(140.41441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.31947 - lat) + Math.Abs(139.1096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.02745 - lat) + Math.Abs(135.99971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.41347 - lat) + Math.Abs(136.01612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.9802 - lat) + Math.Abs(136.15752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.48562 - lat) + Math.Abs(135.69698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.53472 - lat) + Math.Abs(135.70925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.51274 - lat) + Math.Abs(136.89352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.66667 - lat) + Math.Abs(136.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.76835 - lat) + Math.Abs(137.12572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.90123 - lat) + Math.Abs(137.44955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.6436 - lat) + Math.Abs(139.46844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.74242 - lat) + Math.Abs(139.42635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.72085 - lat) + Math.Abs(139.37999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.76298 - lat) + Math.Abs(139.44575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.84373 - lat) + Math.Abs(139.88347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.82088 - lat) + Math.Abs(139.55791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.62047 - lat) + Math.Abs(136.94321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.75758 - lat) + Math.Abs(136.71162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.3 - lat) + Math.Abs(136.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.43459 - lat) + Math.Abs(137.26009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.34058 - lat) + Math.Abs(129.69504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.53567 - lat) + Math.Abs(130.47861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.52594 - lat) + Math.Abs(130.4611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.49142 - lat) + Math.Abs(139.94546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.62908 - lat) + Math.Abs(140.97868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.25902 - lat) + Math.Abs(127.73012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.37609 - lat) + Math.Abs(127.85908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.03553 - lat) + Math.Abs(139.96143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.44492 - lat) + Math.Abs(139.28448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.79016 - lat) + Math.Abs(125.31109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.91664 - lat) + Math.Abs(139.36233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.03333 - lat) + Math.Abs(139.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.818 - lat) + Math.Abs(139.368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.03322 - lat) + Math.Abs(139.53775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.95996 - lat) + Math.Abs(139.40283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.71541 - lat) + Math.Abs(140.55309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.62756 - lat) + Math.Abs(140.41762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.79283 - lat) + Math.Abs(140.92941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.43055 - lat) + Math.Abs(140.60335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.26973 - lat) + Math.Abs(135.41045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.90389 - lat) + Math.Abs(136.12214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.11344 - lat) + Math.Abs(136.57205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.41323 - lat) + Math.Abs(139.86622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.65233 - lat) + Math.Abs(140.16084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.35582 - lat) + Math.Abs(138.36093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.71657 - lat) + Math.Abs(137.93745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.83479 - lat) + Math.Abs(140.16361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.23005 - lat) + Math.Abs(140.40492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.73531 - lat) + Math.Abs(140.12445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.74483 - lat) + Math.Abs(140.40386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.13927 - lat) + Math.Abs(141.1685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.89979 - lat) + Math.Abs(141.12989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.29081 - lat) + Math.Abs(141.31334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.58866 - lat) + Math.Abs(140.973 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.40886 - lat) + Math.Abs(141.17901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.75 - lat) + Math.Abs(141 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03907 - lat) + Math.Abs(138.95143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.97159 - lat) + Math.Abs(138.94643 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.70291 - lat) + Math.Abs(138.11978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.70053 - lat) + Math.Abs(137.52253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.17388 - lat) + Math.Abs(138.90691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.59882 - lat) + Math.Abs(138.21934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.27077 - lat) + Math.Abs(139.93949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.44116 - lat) + Math.Abs(140.48961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.871 - lat) + Math.Abs(139.84926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.3895 - lat) + Math.Abs(140.05813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.87869 - lat) + Math.Abs(139.99767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19956 - lat) + Math.Abs(140.39388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80357 - lat) + Math.Abs(140.40299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58728 - lat) + Math.Abs(140.57107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62049 - lat) + Math.Abs(141.21067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.24702 - lat) + Math.Abs(136.87832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.13676 - lat) + Math.Abs(137.05238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.038 - lat) + Math.Abs(136.99931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.00267 - lat) + Math.Abs(136.8642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.16349 - lat) + Math.Abs(136.73222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.329 - lat) + Math.Abs(136.68051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20169 - lat) + Math.Abs(136.63505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.40435 - lat) + Math.Abs(137.05595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.48199 - lat) + Math.Abs(137.02166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.48384 - lat) + Math.Abs(136.67443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.73691 - lat) + Math.Abs(136.95852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.44722 - lat) + Math.Abs(137.38332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.14447 - lat) + Math.Abs(127.76697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.77392 - lat) + Math.Abs(139.22192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.14828 - lat) + Math.Abs(138.23642 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.08259 - lat) + Math.Abs(138.87413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.01497 - lat) + Math.Abs(138.27324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.02496 - lat) + Math.Abs(138.35931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.06646 - lat) + Math.Abs(139.37436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.24488 - lat) + Math.Abs(138.96234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.5676 - lat) + Math.Abs(135.5974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.55276 - lat) + Math.Abs(135.59097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.33333 - lat) + Math.Abs(135.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.44108 - lat) + Math.Abs(135.58283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.34835 - lat) + Math.Abs(135.26842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.73333 - lat) + Math.Abs(135.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.81626 - lat) + Math.Abs(140.63472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.90807 - lat) + Math.Abs(139.65657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.77871 - lat) + Math.Abs(140.66903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.75459 - lat) + Math.Abs(139.46852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.48933 - lat) + Math.Abs(138.68832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.08267 - lat) + Math.Abs(142.20137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.45737 - lat) + Math.Abs(132.4328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.74087 - lat) + Math.Abs(130.76288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(28.3769 - lat) + Math.Abs(129.49379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.15928 - lat) + Math.Abs(141.19629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.01481 - lat) + Math.Abs(135.67755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.20103 - lat) + Math.Abs(132.49967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.51278 - lat) + Math.Abs(130.52389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.45861 - lat) + Math.Abs(130.19306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.02954 - lat) + Math.Abs(135.75666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.61153 - lat) + Math.Abs(131.13002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.60247 - lat) + Math.Abs(131.17599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.48833 - lat) + Math.Abs(132.35417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60176 - lat) + Math.Abs(141.32662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.52934 - lat) + Math.Abs(141.30553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.69818 - lat) + Math.Abs(137.86185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.10311 - lat) + Math.Abs(139.10951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.93097 - lat) + Math.Abs(135.69203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.01446 - lat) + Math.Abs(130.73565 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.69763 - lat) + Math.Abs(138.58819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.44032 - lat) + Math.Abs(138.79586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.20634 - lat) + Math.Abs(129.29076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61545 - lat) + Math.Abs(140.70362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.72634 - lat) + Math.Abs(139.90392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.89357 - lat) + Math.Abs(141.576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.616 - lat) + Math.Abs(138.46344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.97888 - lat) + Math.Abs(130.44572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.35634 - lat) + Math.Abs(130.74966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.75797 - lat) + Math.Abs(136.13468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.21052 - lat) + Math.Abs(136.33475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.05192 - lat) + Math.Abs(136.66958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.57895 - lat) + Math.Abs(136.53706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.34967 - lat) + Math.Abs(136.69945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.7756 - lat) + Math.Abs(134.82551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.83458 - lat) + Math.Abs(138.39606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.86142 - lat) + Math.Abs(139.51532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.84666 - lat) + Math.Abs(136.98355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.8028 - lat) + Math.Abs(141.13466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.79427 - lat) + Math.Abs(132.89011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.10053 - lat) + Math.Abs(136.01778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.22792 - lat) + Math.Abs(130.64873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.60658 - lat) + Math.Abs(135.77033 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.47276 - lat) + Math.Abs(139.45101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.67152 - lat) + Math.Abs(138.69827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.64188 - lat) + Math.Abs(139.90402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.78396 - lat) + Math.Abs(132.96324 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.81447 - lat) + Math.Abs(139.66018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.27709 - lat) + Math.Abs(130.10928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.95935 - lat) + Math.Abs(131.3673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.19187 - lat) + Math.Abs(130.01281 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.76298 - lat) + Math.Abs(134.79229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.7091 - lat) + Math.Abs(139.41891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.16736 - lat) + Math.Abs(131.00012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.08199 - lat) + Math.Abs(131.39957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.56707 - lat) + Math.Abs(139.24167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.38738 - lat) + Math.Abs(130.54865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.28028 - lat) + Math.Abs(130.19503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.17325 - lat) + Math.Abs(137.05667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.7957 - lat) + Math.Abs(130.55895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.21052 - lat) + Math.Abs(133.6746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.04138 - lat) + Math.Abs(134.22443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.6833 - lat) + Math.Abs(139.43848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.08991 - lat) + Math.Abs(139.5195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.10276 - lat) + Math.Abs(139.7788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.74824 - lat) + Math.Abs(139.36243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(27.09688 - lat) + Math.Abs(142.20377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.73668 - lat) + Math.Abs(135.83994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.88114 - lat) + Math.Abs(135.3986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.79329 - lat) + Math.Abs(135.68596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.42272 - lat) + Math.Abs(131.64093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.1473 - lat) + Math.Abs(136.19408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.40861 - lat) + Math.Abs(132.73682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.75202 - lat) + Math.Abs(139.51169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.76232 - lat) + Math.Abs(139.31952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.72045 - lat) + Math.Abs(140.01148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.48486 - lat) + Math.Abs(138.81123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.67452 - lat) + Math.Abs(139.48216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.84815 - lat) + Math.Abs(139.55521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.20537 - lat) + Math.Abs(130.49183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.26686 - lat) + Math.Abs(134.22958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.43515 - lat) + Math.Abs(139.4256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.08089 - lat) + Math.Abs(135.11905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.77429 - lat) + Math.Abs(130.59208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.18307 - lat) + Math.Abs(136.7997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.1771 - lat) + Math.Abs(139.26029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.72603 - lat) + Math.Abs(139.48508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.73355 - lat) + Math.Abs(139.54761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.04322 - lat) + Math.Abs(140.11276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.75064 - lat) + Math.Abs(134.86954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.06972 - lat) + Math.Abs(133.64902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.92422 - lat) + Math.Abs(135.02609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.18681 - lat) + Math.Abs(131.21624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.24483 - lat) + Math.Abs(137.17323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.77952 - lat) + Math.Abs(139.53014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.84396 - lat) + Math.Abs(135.80561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.1053 - lat) + Math.Abs(136.73378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(38.70882 - lat) + Math.Abs(141.15578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.76971 - lat) + Math.Abs(140.00238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.04766 - lat) + Math.Abs(130.84442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.06716 - lat) + Math.Abs(130.61182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.75967 - lat) + Math.Abs(134.37035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.78674 - lat) + Math.Abs(134.23542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.1039 - lat) + Math.Abs(136.26274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.46238 - lat) + Math.Abs(131.14174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.43946 - lat) + Math.Abs(131.33675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.23863 - lat) + Math.Abs(132.47967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.07831 - lat) + Math.Abs(132.85234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.83184 - lat) + Math.Abs(134.54338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.78286 - lat) + Math.Abs(129.7209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.50476 - lat) + Math.Abs(133.44475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.54731 - lat) + Math.Abs(138.90959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.56943 - lat) + Math.Abs(133.64937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.67416 - lat) + Math.Abs(132.68188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.38817 - lat) + Math.Abs(132.63176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.09205 - lat) + Math.Abs(134.28452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.55723 - lat) + Math.Abs(130.65285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.68463 - lat) + Math.Abs(138.50979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.72072 - lat) + Math.Abs(139.98779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.47769 - lat) + Math.Abs(134.93065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.82188 - lat) + Math.Abs(139.68545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.08971 - lat) + Math.Abs(137.08998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.54225 - lat) + Math.Abs(130.18421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.1956 - lat) + Math.Abs(131.37829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.72854 - lat) + Math.Abs(139.2318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.9754 - lat) + Math.Abs(133.54895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.13525 - lat) + Math.Abs(130.05718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.68184 - lat) + Math.Abs(140.04152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.03126 - lat) + Math.Abs(139.92651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.51183 - lat) + Math.Abs(140.35257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.41368 - lat) + Math.Abs(140.02135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.88571 - lat) + Math.Abs(136.17073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.53488 - lat) + Math.Abs(130.74228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.12102 - lat) + Math.Abs(130.50007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.71706 - lat) + Math.Abs(130.64117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(37.11954 - lat) + Math.Abs(140.26211 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.3943 - lat) + Math.Abs(136.66898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.65534 - lat) + Math.Abs(136.61018 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.58306 - lat) + Math.Abs(136.7585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.17137 - lat) + Math.Abs(142.39517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.25908 - lat) + Math.Abs(134.81392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.92633 - lat) + Math.Abs(134.84533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.27396 - lat) + Math.Abs(134.77512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.94716 - lat) + Math.Abs(135.21389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.98107 - lat) + Math.Abs(134.56398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.16034 - lat) + Math.Abs(135.03914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.42902 - lat) + Math.Abs(136.54564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1035;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.02269 - lat) + Math.Abs(136.90887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1036;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.21024 - lat) + Math.Abs(134.33653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1037;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.34689 - lat) + Math.Abs(130.45612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1038;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.38999 - lat) + Math.Abs(130.28343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1039;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.64637 - lat) + Math.Abs(130.99068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1040;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.43417 - lat) + Math.Abs(139.39419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1041;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.68407 - lat) + Math.Abs(133.84369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1042;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.58345 - lat) + Math.Abs(133.78189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1043;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.33282 - lat) + Math.Abs(134.14169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1044;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.89271 - lat) + Math.Abs(130.77567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1045;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.62217 - lat) + Math.Abs(130.66177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1046;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.8045 - lat) + Math.Abs(135.76681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1047;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.60623 - lat) + Math.Abs(135.04429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1048;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.1098 - lat) + Math.Abs(135.49164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1049;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.68418 - lat) + Math.Abs(128.8068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1050;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.67334 - lat) + Math.Abs(130.26747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1051;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.9839 - lat) + Math.Abs(129.6809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1052;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.77111 - lat) + Math.Abs(130.24841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1053;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.97152 - lat) + Math.Abs(131.52832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1054;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.80986 - lat) + Math.Abs(134.02153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1055;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.10643 - lat) + Math.Abs(133.72009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1056;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.65919 - lat) + Math.Abs(134.14238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1057;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.379 - lat) + Math.Abs(135.31981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1058;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.49524 - lat) + Math.Abs(135.55069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1059;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.29036 - lat) + Math.Abs(129.88998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1060;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.32393 - lat) + Math.Abs(130.34051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1061;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.99921 - lat) + Math.Abs(136.09674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1062;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.33613 - lat) + Math.Abs(133.18382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1063;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.97952 - lat) + Math.Abs(139.99466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1064;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.05493 - lat) + Math.Abs(134.13963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1065;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.92541 - lat) + Math.Abs(133.85674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1066;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.03858 - lat) + Math.Abs(134.29207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1067;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.63295 - lat) + Math.Abs(139.49967 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1068;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.70014 - lat) + Math.Abs(139.51109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1069;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.63424 - lat) + Math.Abs(139.57546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1070;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.03246 - lat) + Math.Abs(131.16028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1071;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.08053 - lat) + Math.Abs(131.82564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1072;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.59465 - lat) + Math.Abs(138.50275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1073;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.63526 - lat) + Math.Abs(138.63853 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1074;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.72422 - lat) + Math.Abs(138.77106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1075;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.75052 - lat) + Math.Abs(139.42959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1076;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20825 - lat) + Math.Abs(140.78327 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1077;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.2431 - lat) + Math.Abs(132.89989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1078;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.5547 - lat) + Math.Abs(131.72796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1079;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.72934 - lat) + Math.Abs(130.29305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1080;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.53484 - lat) + Math.Abs(133.60302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1081;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.783 - lat) + Math.Abs(130.49114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1082;
                                        }
                                    
                                        if ((tmp = (Math.Abs(33.41439 - lat) + Math.Abs(130.71877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1083;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.4892 - lat) + Math.Abs(130.39433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1084;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.03759 - lat) + Math.Abs(141.60004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1085;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.48204 - lat) + Math.Abs(136.58684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1086;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.7093 - lat) + Math.Abs(140.74654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1087;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.42695 - lat) + Math.Abs(135.24552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1088;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.68361 - lat) + Math.Abs(139.56002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1089;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.77497 - lat) + Math.Abs(137.73774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1090;
                                        }
                                    
                                        if ((tmp = (Math.Abs(34.89141 - lat) + Math.Abs(136.53049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1091;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Shingū", "43", 33.73333, 135.98333);
case 1: return new CityInfo("Atsugi", "19", 35.44272, 139.36931);
case 2: return new CityInfo("Akashi", "13", 34.65524, 135.00687);
case 3: return new CityInfo("Zushi", "19", 35.29483, 139.57812);
case 4: return new CityInfo("Zentsujichó", "17", 34.22699, 133.77791);
case 5: return new CityInfo("Zama", "19", 35.4879, 139.39101);
case 6: return new CityInfo("Yuza", "44", 39.01573, 139.92909);
case 7: return new CityInfo("Gero", "09", 35.8, 137.23333);
case 8: return new CityInfo("Yukuhashi", "07", 33.72873, 130.983);
case 9: return new CityInfo("Yūki", "14", 36.3, 139.88333);
case 10: return new CityInfo("Yugawara", "19", 35.15, 139.06667);
case 11: return new CityInfo("Yudomari", "18", 30.2347, 130.47942);
case 12: return new CityInfo("Yoshino-chō", "28", 34.39611, 135.85768);
case 13: return new CityInfo("Yoshikawa", "34", 35.89232, 139.84184);
case 14: return new CityInfo("Yoshii", "10", 36.25, 138.98333);
case 15: return new CityInfo("Yoshida-kasugachō", "29", 37.68333, 138.88333);
case 16: return new CityInfo("Yorii", "34", 36.11567, 139.19429);
case 17: return new CityInfo("Yono", "34", 35.88333, 139.63333);
case 18: return new CityInfo("Yonakuni", "47", 24.46667, 123);
case 19: return new CityInfo("Yonago", "41", 35.43333, 133.33333);
case 20: return new CityInfo("Yokosuka", "19", 35.28361, 139.66722);
case 21: return new CityInfo("Yokohama", "19", 35.43333, 139.65);
case 22: return new CityInfo("Yokkaichi", "23", 34.96667, 136.61667);
case 23: return new CityInfo("Youkaichi", "35", 35.11626, 136.19768);
case 24: return new CityInfo("Yawata", "22", 34.87009, 135.7027);
case 25: return new CityInfo("Honmachi", "21", 32.50439, 130.59952);
case 26: return new CityInfo("Yatsuomachi-higashikumisaka", "42", 36.56667, 137.13333);
case 27: return new CityInfo("Yasugichō", "36", 35.42146, 133.24224);
case 28: return new CityInfo("Yashiro", "13", 34.91667, 134.96667);
case 29: return new CityInfo("Yashio", "34", 35.82255, 139.83905);
case 30: return new CityInfo("Yao", "32", 34.61667, 135.6);
case 31: return new CityInfo("Yanai", "45", 33.96667, 132.11667);
case 32: return new CityInfo("Yanagawa", "07", 33.16667, 130.4);
case 33: return new CityInfo("Yamato-Takada", "28", 34.51667, 135.75);
case 34: return new CityInfo("Yamazakichō-nakabirose", "13", 35, 134.55);
case 35: return new CityInfo("Yamakita", "19", 35.36344, 139.07975);
case 36: return new CityInfo("Yamaguchi", "45", 34.18333, 131.46667);
case 37: return new CityInfo("Yamaga", "21", 33.01667, 130.68911);
case 38: return new CityInfo("Yaizu", "37", 34.86877, 138.31952);
case 39: return new CityInfo("Yaita", "38", 36.8, 139.93333);
case 40: return new CityInfo("Yabu", "13", 35.40304, 134.77118);
case 41: return new CityInfo("Wakimachi", "39", 34.06667, 134.15);
case 42: return new CityInfo("Wajima", "15", 37.40458, 136.89912);
case 43: return new CityInfo("Utsunomiya", "38", 36.56667, 139.88333);
case 44: return new CityInfo("Uto", "21", 32.68333, 130.66667);
case 45: return new CityInfo("Usuki", "30", 33.12342, 131.80401);
case 46: return new CityInfo("Ushibukamachi", "21", 32.20142, 130.02171);
case 47: return new CityInfo("Ureshinomachi-shimojuku", "33", 33.11358, 130.00292);
case 48: return new CityInfo("Urayasu", "40", 35.67056, 139.88861);
case 49: return new CityInfo("Uozu", "42", 36.8, 137.4);
case 50: return new CityInfo("Umi", "07", 33.56826, 130.51009);
case 51: return new CityInfo("Ujiie", "38", 36.68333, 139.96667);
case 52: return new CityInfo("Uji", "22", 34.89044, 135.80325);
case 53: return new CityInfo("Uenohara", "46", 35.61667, 139.11667);
case 54: return new CityInfo("Ueno-ebisumachi", "23", 34.75856, 136.13108);
case 55: return new CityInfo("Uekimachi-mōno", "21", 32.89964, 130.68898);
case 56: return new CityInfo("Ueda", "26", 36.40265, 138.28161);
case 57: return new CityInfo("Ube", "45", 33.94306, 131.25111);
case 58: return new CityInfo("Tsuyama", "31", 35.05215, 133.99885);
case 59: return new CityInfo("Tsushima", "01", 35.16667, 136.71667);
case 60: return new CityInfo("Tsurusaki", "30", 33.24528, 131.69165);
case 61: return new CityInfo("Tsuruoka", "44", 38.72167, 139.82167);
case 62: return new CityInfo("Tsurugi-asahimachi", "15", 36.45, 136.63333);
case 63: return new CityInfo("Tsuruga", "06", 35.64547, 136.0558);
case 64: return new CityInfo("Tsuma", "25", 32.1, 131.4);
case 65: return new CityInfo("Tsukumiura", "30", 33.07539, 131.86907);
case 66: return new CityInfo("Tsukawaki", "30", 33.27668, 131.15628);
case 67: return new CityInfo("Tsuiki", "07", 33.67307, 131.03776);
case 68: return new CityInfo("Tsubata", "15", 36.67012, 136.7403);
case 69: return new CityInfo("Tsubame", "29", 37.6645, 138.92518);
case 70: return new CityInfo("Tsu", "23", 34.73333, 136.51667);
case 71: return new CityInfo("Toyota", "01", 35.08333, 137.15);
case 72: return new CityInfo("Toyoshina", "26", 36.29991, 137.90108);
case 73: return new CityInfo("Toyooka", "13", 35.54008, 134.82038);
case 74: return new CityInfo("Toyonaka", "32", 34.78244, 135.46932);
case 75: return new CityInfo("Toyokawa", "01", 34.81667, 137.4);
case 76: return new CityInfo("Toyohashi", "01", 34.76667, 137.38333);
case 77: return new CityInfo("Toyohama", "01", 34.70933, 136.93425);
case 78: return new CityInfo("Toyama", "42", 36.7, 137.21667);
case 79: return new CityInfo("Tottori", "41", 35.5, 134.23333);
case 80: return new CityInfo("Tosu", "33", 33.36667, 130.51667);
case 81: return new CityInfo("Tonoshō", "17", 34.48047, 134.17017);
case 82: return new CityInfo("Tondabayashichō", "32", 34.50065, 135.60211);
case 83: return new CityInfo("Tomioka", "10", 36.25411, 138.89813);
case 84: return new CityInfo("Tomigusuku", "47", 26.18583, 127.68192);
case 85: return new CityInfo("Tokyo", "40", 35.6895, 139.69171);
case 86: return new CityInfo("Tokuyama", "45", 34.05, 131.81667);
case 87: return new CityInfo("Tokushima", "39", 34.06667, 134.56667);
case 88: return new CityInfo("Tokorozawa", "34", 35.79916, 139.46903);
case 89: return new CityInfo("Tokoname", "01", 34.88333, 136.85);
case 90: return new CityInfo("Toki", "09", 35.35, 137.18333);
case 91: return new CityInfo("Tōkamachi", "29", 37.13333, 138.76667);
case 92: return new CityInfo("Togitsu", "27", 32.83333, 129.85);
case 93: return new CityInfo("Tochio-honchō", "29", 37.47642, 138.99513);
case 94: return new CityInfo("Tochigi", "38", 36.38333, 139.73333);
case 95: return new CityInfo("Toba", "23", 34.4833, 136.84186);
case 96: return new CityInfo("Tenri", "28", 34.58333, 135.83333);
case 97: return new CityInfo("Tennō", "02", 39.9, 139.96667);
case 98: return new CityInfo("Tawaramoto", "28", 34.5542, 135.79297);
case 99: return new CityInfo("Tatsuno", "26", 35.98426, 137.99721);
case 100: return new CityInfo("Tatsunochō-tominaga", "13", 34.86437, 134.552);
case 101: return new CityInfo("Tateyama", "04", 34.98333, 139.86667);
case 102: return new CityInfo("Tatebayashi", "10", 36.25, 139.53333);
case 103: return new CityInfo("Tarumizu", "18", 31.48333, 130.7);
case 104: return new CityInfo("Tarui", "09", 35.36667, 136.53333);
case 105: return new CityInfo("Tanushimarumachi-toyoki", "07", 33.35, 130.68333);
case 106: return new CityInfo("Tanuma", "38", 36.36667, 139.58333);
case 107: return new CityInfo("Nishi-Tokyo-shi", "40", 35.72526, 139.5383);
case 108: return new CityInfo("Tanashichō", "40", 35.72922, 139.53813);
case 109: return new CityInfo("Tanabe", "22", 34.82242, 135.76604);
case 110: return new CityInfo("Tanabe", "43", 33.73333, 135.36667);
case 111: return new CityInfo("Tamano", "31", 34.51745, 133.94574);
case 112: return new CityInfo("Tamana", "21", 32.94716, 130.57446);
case 113: return new CityInfo("Tamamura", "10", 36.3, 139.11667);
case 114: return new CityInfo("Taketoyo", "01", 34.85, 136.91667);
case 115: return new CityInfo("Takeochō-takeo", "33", 33.19009, 130.02084);
case 116: return new CityInfo("Takehara", "11", 34.33833, 132.91667);
case 117: return new CityInfo("Takefu", "06", 35.90393, 136.16687);
case 118: return new CityInfo("Takedamachi", "30", 32.96667, 131.4);
case 119: return new CityInfo("Takayama", "09", 36.13333, 137.25);
case 120: return new CityInfo("Takatsuki", "32", 34.84833, 135.61678);
case 121: return new CityInfo("Takasaki", "10", 36.33333, 139.01667);
case 122: return new CityInfo("Takarazuka", "13", 34.79936, 135.35697);
case 123: return new CityInfo("Takaoka", "42", 36.75, 137.01667);
case 124: return new CityInfo("Takanabe", "25", 32.13333, 131.5);
case 125: return new CityInfo("Takamatsu", "17", 34.33333, 134.05);
case 126: return new CityInfo("Takaishi", "32", 34.51667, 135.43333);
case 127: return new CityInfo("Takahashi", "31", 34.78333, 133.61667);
case 128: return new CityInfo("Takahama", "01", 34.91667, 136.98333);
case 129: return new CityInfo("Bungo-Takada-shi", "30", 33.5567, 131.44506);
case 130: return new CityInfo("Tajimi", "09", 35.31667, 137.13333);
case 131: return new CityInfo("Tahara", "01", 34.66667, 137.26667);
case 132: return new CityInfo("Tagawa", "07", 33.63333, 130.8);
case 133: return new CityInfo("Tadotsu", "17", 34.275, 133.75);
case 134: return new CityInfo("Suzuka", "23", 34.88333, 136.58333);
case 135: return new CityInfo("Suzaka", "26", 36.65, 138.31667);
case 136: return new CityInfo("Suwa", "26", 36.03799, 138.11308);
case 137: return new CityInfo("Susaki", "20", 33.39471, 133.29128);
case 138: return new CityInfo("Sumoto", "13", 34.34322, 134.88911);
case 139: return new CityInfo("Sukumo", "20", 32.93333, 132.73333);
case 140: return new CityInfo("Suita", "32", 34.76143, 135.51567);
case 141: return new CityInfo("Suibara", "29", 37.84608, 139.23039);
case 142: return new CityInfo("Sugito", "34", 36.03107, 139.72636);
case 143: return new CityInfo("Sueyoshichō-ninokata", "18", 31.65, 131.01667);
case 144: return new CityInfo("Sōka", "34", 35.83643, 139.79957);
case 145: return new CityInfo("Sōja", "31", 34.67534, 133.75091);
case 146: return new CityInfo("Sobue", "01", 35.25, 136.71667);
case 147: return new CityInfo("Shōbu", "34", 36.06667, 139.6);
case 148: return new CityInfo("Shōbara", "11", 34.85, 133.01667);
case 149: return new CityInfo("Shizuoka", "37", 34.98333, 138.38333);
case 150: return new CityInfo("Shirone", "29", 37.76354, 139.02199);
case 151: return new CityInfo("Shiraoka", "34", 36.01839, 139.66034);
case 152: return new CityInfo("Shirahamachō-usazakiminami", "13", 34.78333, 134.71667);
case 153: return new CityInfo("Shiozawa", "29", 37.03757, 138.84867);
case 154: return new CityInfo("Shiojiri", "26", 36.1, 137.96667);
case 155: return new CityInfo("Shinshiro", "01", 34.9, 137.5);
case 156: return new CityInfo("Shin’ichi", "11", 34.55543, 133.27297);
case 157: return new CityInfo("Shingū", "07", 33.71399, 130.4313);
case 158: return new CityInfo("Shimo-tsuma", "14", 36.18333, 139.96667);
case 159: return new CityInfo("Shimonoseki", "45", 33.95, 130.95);
case 160: return new CityInfo("Shimodate", "14", 36.3, 139.98333);
case 161: return new CityInfo("Shimoda", "37", 34.67652, 138.94456);
case 162: return new CityInfo("Minato", "43", 34.2152, 135.1501);
case 163: return new CityInfo("Nishishinminato", "42", 36.77957, 137.07576);
case 164: return new CityInfo("Shimada", "37", 34.81667, 138.18333);
case 165: return new CityInfo("Shimabara", "27", 32.78333, 130.36667);
case 166: return new CityInfo("Shima", "23", 34.33333, 136.83333);
case 167: return new CityInfo("Shiki", "34", 35.83333, 139.58333);
case 168: return new CityInfo("Shiida", "07", 33.65341, 131.05797);
case 169: return new CityInfo("Shido", "17", 34.32333, 134.17333);
case 170: return new CityInfo("Shibushi", "18", 31.476, 131.10114);
case 171: return new CityInfo("Shibukawa", "10", 36.48333, 139);
case 172: return new CityInfo("Shibata", "29", 37.95, 139.33333);
case 173: return new CityInfo("Settsu", "32", 34.77819, 135.59512);
case 174: return new CityInfo("Seto", "01", 35.23333, 137.1);
case 175: return new CityInfo("Setakamachi-takayanagi", "07", 33.14858, 130.46548);
case 176: return new CityInfo("Satsumasendai", "18", 31.81667, 130.3);
case 177: return new CityInfo("Sekimachi", "09", 35.48333, 136.91667);
case 178: return new CityInfo("Satte", "34", 36.07254, 139.72615);
case 179: return new CityInfo("Sasebo", "27", 33.16834, 129.72502);
case 180: return new CityInfo("Sasayama", "13", 35.06667, 135.21667);
case 181: return new CityInfo("Sasaguri", "07", 33.61561, 130.55105);
case 182: return new CityInfo("Sano", "38", 36.31667, 139.58333);
case 183: return new CityInfo("Sanjō", "29", 37.61667, 138.95);
case 184: return new CityInfo("Sandachō", "13", 34.88444, 135.22694);
case 185: return new CityInfo("Sakurai", "28", 34.5, 135.85);
case 186: return new CityInfo("Saku", "26", 36.21667, 138.48333);
case 187: return new CityInfo("Sakata", "44", 38.91667, 139.855);
case 188: return new CityInfo("Sakaiminato", "41", 35.53774, 133.23094);
case 189: return new CityInfo("Sakaidechō", "17", 34.32278, 133.8356);
case 190: return new CityInfo("Sakai-nakajima", "10", 36.26667, 139.25);
case 191: return new CityInfo("Sakai", "14", 36.1, 139.8);
case 192: return new CityInfo("Sakai", "32", 34.58333, 135.46667);
case 193: return new CityInfo("Sakado", "34", 35.95694, 139.38889);
case 194: return new CityInfo("Saiki", "30", 32.95, 131.9);
case 195: return new CityInfo("Sagara", "37", 34.68503, 138.20461);
case 196: return new CityInfo("Saga", "33", 33.23333, 130.3);
case 197: return new CityInfo("Sabae", "06", 35.94647, 136.18498);
case 198: return new CityInfo("Ryūō", "46", 35.65, 138.5);
case 199: return new CityInfo("Ryōtsu-minato", "29", 38.07817, 138.43939);
case 200: return new CityInfo("Ōzu", "21", 32.8804, 130.87161);
case 201: return new CityInfo("Oyama", "38", 36.3, 139.8);
case 202: return new CityInfo("Ōyama", "37", 34.60359, 138.21719);
case 203: return new CityInfo("Owase", "23", 34.06667, 136.2);
case 204: return new CityInfo("Ōuda", "28", 34.46667, 135.93333);
case 205: return new CityInfo("Ōtsuki", "46", 35.61851, 138.97396);
case 206: return new CityInfo("Ōtsu", "35", 35, 135.86667);
case 207: return new CityInfo("Ōtake", "11", 34.20754, 132.22063);
case 208: return new CityInfo("Ōta", "10", 36.3, 139.36667);
case 209: return new CityInfo("Osaka", "32", 34.69374, 135.50218);
case 210: return new CityInfo("Onomichi", "11", 34.41667, 133.2);
case 211: return new CityInfo("Onoda", "45", 34.00139, 131.18361);
case 212: return new CityInfo("Ono", "06", 35.98106, 136.48727);
case 213: return new CityInfo("Ono", "13", 34.85, 134.93333);
case 214: return new CityInfo("Ōno-hara", "11", 34.28333, 132.26667);
case 215: return new CityInfo("Ōmuta", "07", 33.03333, 130.45);
case 216: return new CityInfo("Ōmura", "27", 32.92139, 129.95389);
case 217: return new CityInfo("Ōme", "40", 35.78389, 139.24306);
case 218: return new CityInfo("Ōmamachō-ōmama", "10", 36.43181, 139.27534);
case 219: return new CityInfo("Ōmachi", "26", 36.5, 137.86667);
case 220: return new CityInfo("Ōkuchi-shinohara", "18", 32.06779, 130.62439);
case 221: return new CityInfo("Okegawa", "34", 36, 139.55722);
case 222: return new CityInfo("Okazaki", "01", 34.95, 137.16667);
case 223: return new CityInfo("Okayama", "31", 34.65, 133.93333);
case 224: return new CityInfo("Okaya", "26", 36.05659, 138.0451);
case 225: return new CityInfo("Ōkawa", "07", 33.20566, 130.37527);
case 226: return new CityInfo("Ojiya", "29", 37.3, 138.8);
case 227: return new CityInfo("Ōita", "30", 33.23333, 131.6);
case 228: return new CityInfo("Ōiso", "19", 35.31558, 139.31625);
case 229: return new CityInfo("Ōi", "34", 35.85091, 139.51998);
case 230: return new CityInfo("Ogōri-shimogō", "45", 34.1, 131.4);
case 231: return new CityInfo("Ogawa", "34", 36.05342, 139.26612);
case 232: return new CityInfo("Ōgaki", "09", 35.35, 136.61667);
case 233: return new CityInfo("Odawara", "19", 35.25556, 139.15972);
case 234: return new CityInfo("Ōdachō-ōda", "36", 35.19025, 132.50846);
case 235: return new CityInfo("Ōbu", "01", 35.01756, 136.94947);
case 236: return new CityInfo("Obita", "27", 32.81667, 129.88333);
case 237: return new CityInfo("Obama", "06", 35.49576, 135.74604);
case 238: return new CityInfo("Nyūzen", "42", 36.93744, 137.50059);
case 239: return new CityInfo("Numazu", "37", 35.1, 138.86667);
case 240: return new CityInfo("Numata", "10", 36.63333, 139.05);
case 241: return new CityInfo("Nonoichi", "15", 36.53333, 136.61667);
case 242: return new CityInfo("Nōgata", "07", 33.74051, 130.72263);
case 243: return new CityInfo("Noda", "04", 35.94897, 139.86793);
case 244: return new CityInfo("Nobeoka", "25", 32.58333, 131.66667);
case 245: return new CityInfo("Nishiwaki", "13", 34.98419, 134.97407);
case 246: return new CityInfo("Nishio", "01", 34.86667, 137.05);
case 247: return new CityInfo("Nishinoomote", "18", 30.73333, 131);
case 248: return new CityInfo("Nishinomiya-hama", "13", 34.71562, 135.33199);
case 249: return new CityInfo("Nirasaki", "46", 35.7, 138.45);
case 250: return new CityInfo("Ninomiya", "19", 35.3015, 139.25581);
case 251: return new CityInfo("Nikkō", "38", 36.75, 139.61667);
case 252: return new CityInfo("Niitsu-honchō", "29", 37.80024, 139.1224);
case 253: return new CityInfo("Niimi", "31", 34.98333, 133.46667);
case 254: return new CityInfo("Niihama", "05", 33.96047, 133.30522);
case 255: return new CityInfo("Niigata", "29", 37.88637, 139.00589);
case 256: return new CityInfo("Nichinan", "25", 31.6, 131.36667);
case 257: return new CityInfo("Naze", "18", 28.36667, 129.48333);
case 258: return new CityInfo("Narutochō-mitsuishi", "39", 34.19933, 134.60932);
case 259: return new CityInfo("Nara-shi", "28", 34.68505, 135.80485);
case 260: return new CityInfo("Nanao", "15", 37.05, 136.96667);
case 261: return new CityInfo("Namerikawa", "42", 36.75965, 137.36215);
case 262: return new CityInfo("Nakatsugawa", "09", 35.48333, 137.5);
case 263: return new CityInfo("Nakatsu", "30", 33.59811, 131.1883);
case 264: return new CityInfo("Nakanojōmachi", "10", 36.58717, 138.84083);
case 265: return new CityInfo("Nakano", "26", 36.75, 138.36667);
case 266: return new CityInfo("Nakamura", "20", 32.98333, 132.93333);
case 267: return new CityInfo("Nakama", "07", 33.81688, 130.70962);
case 268: return new CityInfo("Naha", "47", 26.21667, 127.68333);
case 269: return new CityInfo("Nagoya", "01", 35.18147, 136.90641);
case 270: return new CityInfo("Nago", "47", 26.61502, 127.98543);
case 271: return new CityInfo("Nagata", "18", 30.39516, 130.42548);
case 272: return new CityInfo("Nagasaki", "27", 32.75, 129.88333);
case 273: return new CityInfo("Nagareyama", "04", 35.8563, 139.90266);
case 274: return new CityInfo("Nagaoka", "29", 37.45, 138.85);
case 275: return new CityInfo("Nagano", "26", 36.65, 138.18333);
case 276: return new CityInfo("Nagahama", "35", 35.38333, 136.26667);
case 277: return new CityInfo("Nabari", "23", 34.61667, 136.08333);
case 278: return new CityInfo("Musashino", "40", 35.70611, 139.55944);
case 279: return new CityInfo("Muroto-misakicho", "20", 33.28662, 134.16832);
case 280: return new CityInfo("Muramatsu", "29", 37.69257, 139.17127);
case 281: return new CityInfo("Murakami", "29", 38.23333, 139.48333);
case 282: return new CityInfo("Mukō", "22", 34.96545, 135.70415);
case 283: return new CityInfo("Muikamachi", "29", 37.06667, 138.88333);
case 284: return new CityInfo("Morohongō", "34", 35.93556, 139.30444);
case 285: return new CityInfo("Moriyama", "35", 35.06667, 135.98333);
case 286: return new CityInfo("Moriguchi", "32", 34.73333, 135.56667);
case 287: return new CityInfo("Mori", "37", 34.83333, 137.93333);
case 288: return new CityInfo("Mizunami", "09", 35.36667, 137.25);
case 289: return new CityInfo("Miyoshi", "11", 34.8, 132.85);
case 290: return new CityInfo("Miyazu", "22", 35.53333, 135.18333);
case 291: return new CityInfo("Miyazaki", "25", 31.91667, 131.41667);
case 292: return new CityInfo("Miyanoura", "18", 30.4269, 130.57151);
case 293: return new CityInfo("Miyakonojō", "25", 31.73333, 131.06667);
case 294: return new CityInfo("Miyajima", "11", 34.29907, 132.32186);
case 295: return new CityInfo("Miyata", "07", 33.70811, 130.65297);
case 296: return new CityInfo("Mitsuke", "29", 37.53333, 138.93333);
case 297: return new CityInfo("Mitsukaidō", "14", 36.01667, 139.98333);
case 298: return new CityInfo("Mitake", "09", 35.41667, 137.13333);
case 299: return new CityInfo("Mishima", "37", 35.11667, 138.91667);
case 300: return new CityInfo("Mino", "32", 34.82691, 135.47057);
case 301: return new CityInfo("Mino", "09", 35.53333, 136.91667);
case 302: return new CityInfo("Minamirinkan", "19", 35.49527, 139.44279);
case 303: return new CityInfo("Minamata", "21", 32.21667, 130.4);
case 304: return new CityInfo("Minakuchichō-matoba", "35", 34.96667, 136.16667);
case 305: return new CityInfo("Mikuni", "06", 36.21706, 136.15185);
case 306: return new CityInfo("Miki", "13", 34.8, 134.98333);
case 307: return new CityInfo("Mihara", "11", 34.4, 133.08333);
case 308: return new CityInfo("Mibu", "38", 36.41667, 139.8);
case 309: return new CityInfo("Menuma", "34", 36.22245, 139.38205);
case 310: return new CityInfo("Matsutō", "15", 36.51667, 136.56667);
case 311: return new CityInfo("Matsumoto", "26", 36.23333, 137.96667);
case 312: return new CityInfo("Matsue", "36", 35.48333, 133.05);
case 313: return new CityInfo("Matsudo", "04", 35.77995, 139.90144);
case 314: return new CityInfo("Matsubase", "21", 32.65, 130.66667);
case 315: return new CityInfo("Matsubara", "32", 34.56667, 135.55);
case 316: return new CityInfo("Masuda", "36", 34.66667, 131.85);
case 317: return new CityInfo("Maruoka", "06", 36.1534, 136.27029);
case 318: return new CityInfo("Kamimaruko", "26", 36.31865, 138.27329);
case 319: return new CityInfo("Marugame", "17", 34.28333, 133.78333);
case 320: return new CityInfo("Makurazaki", "18", 31.26667, 130.31667);
case 321: return new CityInfo("Makinohara", "37", 34.77437, 138.14831);
case 322: return new CityInfo("Maki", "29", 37.75, 138.88333);
case 323: return new CityInfo("Maizuru", "22", 35.45, 135.33333);
case 324: return new CityInfo("Maibara", "35", 35.31667, 136.28333);
case 325: return new CityInfo("Maebashi", "10", 36.4, 139.08333);
case 326: return new CityInfo("Maebaru-chūō", "07", 33.55916, 130.20148);
case 327: return new CityInfo("Machida", "40", 35.54028, 139.45083);
case 328: return new CityInfo("Kyoto", "22", 35.02107, 135.75385);
case 329: return new CityInfo("Kushikino", "18", 31.71667, 130.26667);
case 330: return new CityInfo("Kusatsu", "35", 35.01667, 135.96667);
case 331: return new CityInfo("Kurume", "07", 33.31667, 130.51667);
case 332: return new CityInfo("Kuroda", "01", 35.35, 136.78333);
case 333: return new CityInfo("Kurio", "18", 30.27123, 130.4236);
case 334: return new CityInfo("Kurihashi", "34", 36.13333, 139.7);
case 335: return new CityInfo("Kure", "11", 34.23222, 132.56658);
case 336: return new CityInfo("Kurayoshi", "41", 35.43333, 133.81667);
case 337: return new CityInfo("Kurashiki", "31", 34.58333, 133.76667);
case 338: return new CityInfo("Kumamoto", "21", 32.80589, 130.69181);
case 339: return new CityInfo("Kumagaya", "34", 36.13497, 139.39004);
case 340: return new CityInfo("Kukichūō", "34", 36.06739, 139.67498);
case 341: return new CityInfo("Kudamatsu", "45", 34, 131.86667);
case 342: return new CityInfo("Kozakai-chō", "01", 34.8, 137.35889);
case 343: return new CityInfo("Koshima", "18", 30.23461, 130.53517);
case 344: return new CityInfo("Koshigaya", "34", 35.89035, 139.78916);
case 345: return new CityInfo("Koseda", "18", 30.38796, 130.64924);
case 346: return new CityInfo("Kōnosu", "34", 36.06868, 139.51684);
case 347: return new CityInfo("Kōnan", "01", 35.33165, 136.87042);
case 348: return new CityInfo("Komoro", "26", 36.31667, 138.43333);
case 349: return new CityInfo("Komono", "23", 35, 136.51667);
case 350: return new CityInfo("Komatsushimachō", "39", 34, 134.58333);
case 351: return new CityInfo("Komatsu", "15", 36.40263, 136.45088);
case 352: return new CityInfo("Komaki", "01", 35.28333, 136.91667);
case 353: return new CityInfo("Kokubunji", "40", 35.70222, 139.47556);
case 354: return new CityInfo("Kokubu-matsuki", "18", 31.73333, 130.76667);
case 355: return new CityInfo("Koga", "14", 36.18333, 139.71667);
case 356: return new CityInfo("Koga", "07", 33.73333, 130.46667);
case 357: return new CityInfo("Kōfu", "46", 35.66667, 138.56667);
case 358: return new CityInfo("Kodamachō-kodamaminami", "34", 36.18497, 139.13191);
case 359: return new CityInfo("Kochi", "20", 33.55, 133.53333);
case 360: return new CityInfo("Kobe", "13", 34.6913, 135.183);
case 361: return new CityInfo("Kobayashi", "25", 31.98333, 130.98333);
case 362: return new CityInfo("Kiyosu", "01", 35.21667, 136.83333);
case 363: return new CityInfo("Kitsuki", "30", 33.41998, 131.61837);
case 364: return new CityInfo("Kitakyushu", "07", 33.85181, 130.85034);
case 365: return new CityInfo("Kitakata", "08", 37.65, 139.86667);
case 366: return new CityInfo("Kitahama", "35", 35.16667, 135.91667);
case 367: return new CityInfo("Kishiwada", "32", 34.46667, 135.36667);
case 368: return new CityInfo("Kisarazu", "04", 35.38329, 139.93254);
case 369: return new CityInfo("Kisai", "34", 36.1, 139.58333);
case 370: return new CityInfo("Kiryū", "10", 36.4, 139.33333);
case 371: return new CityInfo("Kikuchi", "21", 32.98333, 130.81667);
case 372: return new CityInfo("Kazo", "34", 36.11667, 139.6);
case 373: return new CityInfo("Kawasaki", "19", 35.52056, 139.71722);
case 374: return new CityInfo("Kawasaki", "07", 33.59993, 130.81495);
case 375: return new CityInfo("Kawanishi", "13", 34.81667, 135.41667);
case 376: return new CityInfo("Kawaguchi", "34", 35.80521, 139.71072);
case 377: return new CityInfo("Kawagoe", "34", 35.90861, 139.48528);
case 378: return new CityInfo("Katsuyama", "06", 36.06173, 136.50101);
case 379: return new CityInfo("Kasukabe", "34", 35.98308, 139.74966);
case 380: return new CityInfo("Kasugai", "01", 35.24762, 136.97229);
case 381: return new CityInfo("Kashiwazaki", "29", 37.36667, 138.55);
case 382: return new CityInfo("Kashiwa", "04", 35.86224, 139.97732);
case 383: return new CityInfo("Kashima", "33", 33.10611, 130.09056);
case 384: return new CityInfo("Kashihara-shi", "28", 34.50896, 135.7929);
case 385: return new CityInfo("Kashihara", "32", 34.58333, 135.61667);
case 386: return new CityInfo("Kaseda-shirakame", "18", 31.41667, 130.31667);
case 387: return new CityInfo("Kasaoka", "31", 34.50597, 133.50391);
case 388: return new CityInfo("Kasamatsuchō", "09", 35.36667, 136.76667);
case 389: return new CityInfo("Kariya", "01", 34.98333, 136.98333);
case 390: return new CityInfo("Karatsu", "33", 33.4425, 129.96972);
case 391: return new CityInfo("Kanzakimachi-kanzaki", "33", 33.30895, 130.37383);
case 392: return new CityInfo("Kanuma", "38", 36.55, 139.73333);
case 393: return new CityInfo("Kanoya", "18", 31.38333, 130.85);
case 394: return new CityInfo("Kan’onjichō", "17", 34.1276, 133.64598);
case 395: return new CityInfo("Kannabechō-yahiro", "11", 34.55808, 133.41796);
case 396: return new CityInfo("Kanie", "01", 35.13333, 136.8);
case 397: return new CityInfo("Kanekomachi", "10", 36.41097, 138.99621);
case 398: return new CityInfo("Kanda", "07", 33.78333, 130.98333);
case 399: return new CityInfo("Kanazawa", "15", 36.6, 136.61667);
case 400: return new CityInfo("Kanaya", "37", 34.82022, 138.12775);
case 401: return new CityInfo("Kamojimachō-jōgejima", "39", 34.06803, 134.35033);
case 402: return new CityInfo("Kamogatachō-kamogata", "31", 34.53745, 133.58967);
case 403: return new CityInfo("Kamo", "29", 37.66442, 139.03502);
case 404: return new CityInfo("Kamirenjaku", "40", 35.69423, 139.55495);
case 405: return new CityInfo("Kaminokawa", "38", 36.43333, 139.91667);
case 406: return new CityInfo("Kamiichi", "42", 36.7, 137.36667);
case 407: return new CityInfo("Kameyama", "23", 34.85, 136.45);
case 408: return new CityInfo("Kameoka", "22", 35, 135.58333);
case 409: return new CityInfo("Kameda-honchō", "29", 37.87214, 139.1099);
case 410: return new CityInfo("Kamakura", "19", 35.30889, 139.55028);
case 411: return new CityInfo("Kakogawachō-honmachi", "13", 34.76943, 134.82905);
case 412: return new CityInfo("Kakegawa", "37", 34.76667, 138.01667);
case 413: return new CityInfo("Kakamigahara", "09", 35.41667, 136.86667);
case 414: return new CityInfo("Kashima-shi", "14", 35.96536, 140.64474);
case 415: return new CityInfo("Kajiki", "18", 31.73333, 130.66667);
case 416: return new CityInfo("Kaizuka", "32", 34.45, 135.35);
case 417: return new CityInfo("Kainan", "43", 34.15166, 135.21398);
case 418: return new CityInfo("Kagoshima", "18", 31.56667, 130.55);
case 419: return new CityInfo("Kadoma", "32", 34.7381, 135.57442);
case 420: return new CityInfo("Izumo", "36", 35.36667, 132.76667);
case 421: return new CityInfo("Izumisano", "32", 34.41667, 135.31667);
case 422: return new CityInfo("Izumiōtsu", "32", 34.5, 135.4);
case 423: return new CityInfo("Izumi", "32", 34.48333, 135.43333);
case 424: return new CityInfo("Izumi", "18", 32.08333, 130.36667);
case 425: return new CityInfo("Iwatsuki", "34", 35.96474, 139.69644);
case 426: return new CityInfo("Iwata", "37", 34.7, 137.85);
case 427: return new CityInfo("Iwakura", "01", 35.28333, 136.86667);
case 428: return new CityInfo("Iwakuni", "45", 34.16297, 132.22);
case 429: return new CityInfo("Iwai", "14", 36.05, 139.9);
case 430: return new CityInfo("Iwade", "43", 34.25, 135.31667);
case 431: return new CityInfo("Itsukaichi", "40", 35.72528, 139.21778);
case 432: return new CityInfo("Itoman", "47", 26.12647, 127.66918);
case 433: return new CityInfo("Itoigawa", "29", 37.03333, 137.85);
case 434: return new CityInfo("Itō", "37", 34.96667, 139.08333);
case 435: return new CityInfo("Itami", "13", 34.78427, 135.40126);
case 436: return new CityInfo("Ishiki", "01", 34.8, 137.01667);
case 437: return new CityInfo("Ishikawa", "47", 26.42333, 127.82139);
case 438: return new CityInfo("Ishii", "39", 34.06752, 134.44208);
case 439: return new CityInfo("Ishige", "14", 36.11667, 139.96667);
case 440: return new CityInfo("Ishigaki", "47", 24.34478, 124.15717);
case 441: return new CityInfo("Isesaki", "10", 36.31667, 139.2);
case 442: return new CityInfo("Isehara", "19", 35.39932, 139.31019);
case 443: return new CityInfo("Ise", "23", 34.48333, 136.7);
case 444: return new CityInfo("Isawa", "46", 35.65, 138.63333);
case 445: return new CityInfo("Isahaya", "27", 32.84111, 130.04306);
case 446: return new CityInfo("Inuyama", "01", 35.37995, 136.94295);
case 447: return new CityInfo("Ino", "20", 33.55, 133.43333);
case 448: return new CityInfo("Innoshima", "11", 34.28333, 133.18333);
case 449: return new CityInfo("Inazawa", "01", 35.25, 136.78333);
case 450: return new CityInfo("Ina", "26", 35.82756, 137.95378);
case 451: return new CityInfo("Imarichō-kō", "33", 33.27362, 129.87877);
case 452: return new CityInfo("Imaichi", "38", 36.71667, 139.68333);
case 453: return new CityInfo("Ikoma", "28", 34.68333, 135.7);
case 454: return new CityInfo("Ikeda", "32", 34.82208, 135.4298);
case 455: return new CityInfo("Ikedachō", "39", 34.02849, 133.80616);
case 456: return new CityInfo("Ijūin", "18", 31.61667, 130.4);
case 457: return new CityInfo("Iizuka", "07", 33.63654, 130.68678);
case 458: return new CityInfo("Iiyama", "26", 36.85, 138.36667);
case 459: return new CityInfo("Iida", "26", 35.51965, 137.82074);
case 460: return new CityInfo("Ichinomiya", "01", 35.3, 136.8);
case 461: return new CityInfo("Ibusuki", "18", 31.23333, 130.65);
case 462: return new CityInfo("Ibaraki", "32", 34.81641, 135.56828);
case 463: return new CityInfo("Ibara", "31", 34.6, 133.46667);
case 464: return new CityInfo("Hotaka", "26", 36.3396, 137.88254);
case 465: return new CityInfo("Hōryūji", "28", 34.61234, 135.73754);
case 466: return new CityInfo("Honjō", "34", 36.2378, 139.19023);
case 467: return new CityInfo("Hondomachi-hondo", "21", 32.45993, 130.16713);
case 468: return new CityInfo("Hōfu", "45", 34.05, 131.56667);
case 469: return new CityInfo("Hitoyoshi", "21", 32.21667, 130.75);
case 470: return new CityInfo("Hita", "30", 33.3213, 130.94098);
case 471: return new CityInfo("Hisai-motomachi", "23", 34.66667, 136.46667);
case 472: return new CityInfo("Hiroshima", "11", 34.4, 132.45);
case 473: return new CityInfo("Hiratsuka", "19", 35.32785, 139.33735);
case 474: return new CityInfo("Hiratachō", "36", 35.43333, 132.81667);
case 475: return new CityInfo("Hirara", "47", 24.80379, 125.30222);
case 476: return new CityInfo("Hirakata", "32", 34.81352, 135.64914);
case 477: return new CityInfo("Hirado", "27", 33.36853, 129.55247);
case 478: return new CityInfo("Hioki", "18", 31.58333, 130.35);
case 479: return new CityInfo("Hino", "40", 35.67306, 139.40028);
case 480: return new CityInfo("Hino", "35", 35, 136.25);
case 481: return new CityInfo("Himimachi", "42", 36.85609, 136.9885);
case 482: return new CityInfo("Himeji", "13", 34.81667, 134.7);
case 483: return new CityInfo("Hikone", "35", 35.25, 136.25);
case 484: return new CityInfo("Hiji", "30", 33.37081, 131.53025);
case 485: return new CityInfo("Higashi-ōsaka", "32", 34.66667, 135.58333);
case 486: return new CityInfo("Hekinan", "01", 34.88333, 136.98333);
case 487: return new CityInfo("Heda", "37", 34.96277, 138.78543);
case 488: return new CityInfo("Hayama", "19", 35.27651, 139.57733);
case 489: return new CityInfo("Hatsukaichi", "11", 34.35, 132.33333);
case 490: return new CityInfo("Hatogaya-honchō", "34", 35.83314, 139.7425);
case 491: return new CityInfo("Hashimoto", "43", 34.31667, 135.61667);
case 492: return new CityInfo("Hanyū", "34", 36.16667, 139.53333);
case 493: return new CityInfo("Hannō", "34", 35.85194, 139.31806);
case 494: return new CityInfo("Handa", "01", 34.88333, 136.93333);
case 495: return new CityInfo("Hamanoichi", "18", 31.71667, 130.73333);
case 496: return new CityInfo("Hamamatsu", "37", 34.7, 137.73333);
case 497: return new CityInfo("Hamakita", "37", 34.8, 137.78333);
case 498: return new CityInfo("Hamada", "36", 34.88333, 132.08333);
case 499: return new CityInfo("Hakui", "15", 36.88333, 136.78333);
case 500: return new CityInfo("Hakone", "19", 35.18945, 139.02649);
case 501: return new CityInfo("Haibara-akanedai", "28", 34.53333, 135.95);
case 502: return new CityInfo("Hagi", "45", 34.4, 131.41667);
case 503: return new CityInfo("Katsuren-haebaru", "47", 26.33294, 127.87403);
case 504: return new CityInfo("Hadano", "19", 35.37111, 139.22361);
case 505: return new CityInfo("Hachiōji", "40", 35.65583, 139.32389);
case 506: return new CityInfo("Ōmihachiman", "35", 35.12861, 136.0976);
case 507: return new CityInfo("Gyōda", "34", 36.14074, 139.46011);
case 508: return new CityInfo("Gushikawa", "47", 26.35937, 127.86735);
case 509: return new CityInfo("Gōtsuchō", "36", 35.00856, 132.2257);
case 510: return new CityInfo("Gotenba", "37", 35.31859, 138.94343);
case 511: return new CityInfo("Gosen", "29", 37.73333, 139.16667);
case 512: return new CityInfo("Gose", "28", 34.45, 135.73333);
case 513: return new CityInfo("Gojō", "28", 34.35, 135.7);
case 514: return new CityInfo("Gōdo", "09", 35.41667, 136.6);
case 515: return new CityInfo("Gobō", "43", 33.88153, 135.1696);
case 516: return new CityInfo("Ginowan", "47", 26.26265, 127.76147);
case 517: return new CityInfo("Gifu-shi", "09", 35.42291, 136.76039);
case 518: return new CityInfo("Gamagōri", "01", 34.83333, 137.23333);
case 519: return new CityInfo("Futtsu", "04", 35.3108, 139.81877);
case 520: return new CityInfo("Honchō", "04", 35.70129, 139.98648);
case 521: return new CityInfo("Fukuyama", "11", 34.48333, 133.36667);
case 522: return new CityInfo("Fukuroi", "37", 34.75, 137.91667);
case 523: return new CityInfo("Fukura", "13", 34.25765, 134.71535);
case 524: return new CityInfo("Fukuoka", "07", 33.6, 130.41667);
case 525: return new CityInfo("Fukumitsu", "42", 36.55751, 136.86945);
case 526: return new CityInfo("Nishifukuma", "07", 33.76627, 130.47461);
case 527: return new CityInfo("Fukui-shi", "06", 36.06443, 136.22257);
case 528: return new CityInfo("Fukuechō", "27", 32.69732, 128.84561);
case 529: return new CityInfo("Fukuchiyama", "22", 35.3, 135.11667);
case 530: return new CityInfo("Fukiage-fujimi", "34", 36.1, 139.45);
case 531: return new CityInfo("Fukayachō", "34", 36.2, 139.28333);
case 532: return new CityInfo("Fujisawa", "19", 35.34926, 139.47666);
case 533: return new CityInfo("Fujioka", "38", 36.25, 139.65);
case 534: return new CityInfo("Fujioka", "10", 36.24624, 139.07204);
case 535: return new CityInfo("Fujinomiya", "37", 35.21667, 138.61667);
case 536: return new CityInfo("Fujieda", "37", 34.86667, 138.26667);
case 537: return new CityInfo("Fuji", "37", 35.16667, 138.68333);
case 538: return new CityInfo("Fuchūchō", "11", 34.5735, 133.23513);
case 539: return new CityInfo("Enzan", "46", 35.7, 138.73333);
case 540: return new CityInfo("Daitōchō", "32", 34.71378, 135.62033);
case 541: return new CityInfo("Chōfu", "40", 35.65924, 139.54837);
case 542: return new CityInfo("Chiryū", "01", 35, 137.03333);
case 543: return new CityInfo("Chino", "26", 35.9944, 138.15428);
case 544: return new CityInfo("Chikushino-shi", "07", 33.49631, 130.5156);
case 545: return new CityInfo("Chigasaki", "19", 35.33638, 139.40434);
case 546: return new CityInfo("Chichibu", "34", 35.99028, 139.07639);
case 547: return new CityInfo("Chatan", "47", 26.30948, 127.77024);
case 548: return new CityInfo("Beppu", "30", 33.27945, 131.49751);
case 549: return new CityInfo("Ayabe", "22", 35.3, 135.25);
case 550: return new CityInfo("Awara", "06", 36.22309, 136.19236);
case 551: return new CityInfo("Atami", "37", 35.08834, 139.05325);
case 552: return new CityInfo("Ashiya", "13", 34.72807, 135.30264);
case 553: return new CityInfo("Ashikaga", "38", 36.33333, 139.45);
case 554: return new CityInfo("Arai", "29", 37.00059, 138.2259);
case 555: return new CityInfo("Annaka", "10", 36.33011, 138.89585);
case 556: return new CityInfo("Anjō", "01", 34.95828, 137.08054);
case 557: return new CityInfo("Anan", "39", 33.91667, 134.65);
case 558: return new CityInfo("Amagi", "07", 33.41804, 130.65413);
case 559: return new CityInfo("Amagasaki", "13", 34.71667, 135.41667);
case 560: return new CityInfo("Akune", "18", 32.01667, 130.2);
case 561: return new CityInfo("Kariya", "13", 34.75136, 134.38734);
case 562: return new CityInfo("Aki", "20", 33.5, 133.9);
case 563: return new CityInfo("Aioi", "13", 34.80361, 134.46806);
case 564: return new CityInfo("Ageoshimo", "34", 35.97145, 139.61382);
case 565: return new CityInfo("Okinawa", "47", 26.33583, 127.80139);
case 566: return new CityInfo("Kushima", "25", 31.48621, 131.2421);
case 567: return new CityInfo("Hikari", "45", 33.955, 131.95);
case 568: return new CityInfo("Nagato", "45", 34.38333, 131.2);
case 569: return new CityInfo("Hasuda", "34", 35.97113, 139.6491);
case 570: return new CityInfo("Kamifukuoka", "34", 35.87266, 139.51369);
case 571: return new CityInfo("Sayama", "34", 35.85295, 139.41212);
case 572: return new CityInfo("Fussa", "40", 35.73667, 139.32361);
case 573: return new CityInfo("Asaka", "34", 35.80472, 139.60194);
case 574: return new CityInfo("Wako", "34", 35.78944, 139.62333);
case 575: return new CityInfo("Shimotoda", "34", 35.815, 139.6853);
case 576: return new CityInfo("Kimitsu", "04", 35.35043, 139.87029);
case 577: return new CityInfo("Miura", "19", 35.14, 139.61917);
case 578: return new CityInfo("Wakayama", "43", 34.23333, 135.16667);
case 579: return new CityInfo("Iyo", "05", 33.75139, 132.70139);
case 580: return new CityInfo("Uwajima", "05", 33.22375, 132.56001);
case 581: return new CityInfo("Saijō", "05", 33.91667, 133.18333);
case 582: return new CityInfo("Ōzu", "05", 33.5, 132.55);
case 583: return new CityInfo("Matsuyama", "05", 33.83916, 132.76574);
case 584: return new CityInfo("Masaki-chō", "05", 33.78757, 132.71124);
case 585: return new CityInfo("Kawanoechō", "05", 34.01654, 133.57844);
case 586: return new CityInfo("Imabari-shi", "05", 34.07001, 133.00023);
case 587: return new CityInfo("Hōjō", "05", 33.97661, 132.77767);
case 588: return new CityInfo("Yuzawa", "02", 39.16667, 140.5);
case 589: return new CityInfo("Yotsukaidō", "04", 35.65, 140.16667);
case 590: return new CityInfo("Yonezawa", "44", 37.91, 140.11667);
case 591: return new CityInfo("Yokote", "02", 39.31691, 140.55034);
case 592: return new CityInfo("Yōkaichiba", "04", 35.7, 140.55);
case 593: return new CityInfo("Yanagawamachi-saiwaichō", "08", 37.85, 140.6);
case 594: return new CityInfo("Yamoto", "24", 38.42738, 141.21487);
case 595: return new CityInfo("Yamagata", "44", 38.23333, 140.36667);
case 596: return new CityInfo("Yamada", "16", 39.46667, 141.95);
case 597: return new CityInfo("Yachimata", "04", 35.65, 140.31667);
case 598: return new CityInfo("Watari", "24", 38.035, 140.85111);
case 599: return new CityInfo("Wakuya", "24", 38.54465, 141.13461);
case 600: return new CityInfo("Ushiku", "14", 35.96667, 140.13333);
case 601: return new CityInfo("Tsukuba", "14", 36.2, 140.1);
case 602: return new CityInfo("Toride", "14", 35.9, 140.08333);
case 603: return new CityInfo("Tōno", "16", 39.31667, 141.53333);
case 604: return new CityInfo("Tomobe", "14", 36.35, 140.3);
case 605: return new CityInfo("Tomiya", "24", 38.39306, 140.88611);
case 606: return new CityInfo("Tōgane", "04", 35.55, 140.36667);
case 607: return new CityInfo("Tendō", "44", 38.35361, 140.36972);
case 608: return new CityInfo("Takahata", "44", 38.0025, 140.19111);
case 609: return new CityInfo("Takahagi", "14", 36.71667, 140.71667);
case 610: return new CityInfo("Tagajō-shi", "24", 38.3, 141);
case 611: return new CityInfo("Sukagawa", "08", 37.28333, 140.38333);
case 612: return new CityInfo("Shizukuishi", "16", 39.69414, 140.98442);
case 613: return new CityInfo("Shisui", "04", 35.71667, 140.26667);
case 614: return new CityInfo("Shiroishi", "24", 38.00333, 140.61833);
case 615: return new CityInfo("Shiroi", "04", 35.8, 140.06667);
case 616: return new CityInfo("Shiogama", "24", 38.31667, 141.03333);
case 617: return new CityInfo("Shinjō", "44", 38.75861, 140.30083);
case 618: return new CityInfo("Sendai", "24", 38.26667, 140.86667);
case 619: return new CityInfo("Sawara", "04", 35.88333, 140.5);
case 620: return new CityInfo("Sakura", "04", 35.71667, 140.23333);
case 621: return new CityInfo("Sagae", "44", 38.3725, 140.2725);
case 622: return new CityInfo("Ryūgasaki", "14", 35.9, 140.18333);
case 623: return new CityInfo("Rifu", "24", 38.33092, 140.97691);
case 624: return new CityInfo("Ōtsuchi", "16", 39.36667, 141.9);
case 625: return new CityInfo("Ōtawara", "38", 36.86667, 140.03333);
case 626: return new CityInfo("Onagawa Chō", "24", 38.4466, 141.44794);
case 627: return new CityInfo("Ōmiya", "14", 36.55, 140.41667);
case 628: return new CityInfo("Omigawa", "04", 35.85, 140.61667);
case 629: return new CityInfo("Ōmagari", "02", 39.45, 140.48333);
case 630: return new CityInfo("Okunoya", "14", 36.28333, 140.41667);
case 631: return new CityInfo("Ōkawara", "24", 38.05, 140.73361);
case 632: return new CityInfo("Ōhara", "04", 35.24761, 140.39289);
case 633: return new CityInfo("Ōfunato", "16", 39.07167, 141.71667);
case 634: return new CityInfo("Obanazawa", "44", 38.60333, 140.40194);
case 635: return new CityInfo("Ōarai", "14", 36.31409, 140.58389);
case 636: return new CityInfo("Ōami", "04", 35.51667, 140.31667);
case 637: return new CityInfo("Nihommatsu", "08", 37.58333, 140.43333);
case 638: return new CityInfo("Natori-shi", "24", 38.16667, 140.88333);
case 639: return new CityInfo("Narutō", "04", 35.6, 140.41667);
case 640: return new CityInfo("Narita", "04", 35.78333, 140.31667);
case 641: return new CityInfo("Namie", "08", 37.48333, 141);
case 642: return new CityInfo("Naka", "14", 36.05, 140.16667);
case 643: return new CityInfo("Nagai", "44", 38.10361, 140.035);
case 644: return new CityInfo("Motomiya", "08", 37.51391, 140.40063);
case 645: return new CityInfo("Motegi", "38", 36.51667, 140.18333);
case 646: return new CityInfo("Moriya", "14", 35.93333, 140);
case 647: return new CityInfo("Morioka", "16", 39.7, 141.15);
case 648: return new CityInfo("Mooka", "38", 36.43333, 140.01667);
case 649: return new CityInfo("Mobara", "04", 35.42583, 140.29608);
case 650: return new CityInfo("Mizusawa", "16", 39.13333, 141.13333);
case 651: return new CityInfo("Miyako", "16", 39.64691, 141.94057);
case 652: return new CityInfo("Mito", "14", 36.35, 140.45);
case 653: return new CityInfo("Miharu", "08", 37.43333, 140.48333);
case 654: return new CityInfo("Matsushima", "24", 38.37357, 141.06105);
case 655: return new CityInfo("Mashiko", "38", 36.46667, 140.1);
case 656: return new CityInfo("Marumori", "24", 37.91667, 140.76667);
case 657: return new CityInfo("Makabe", "14", 36.26667, 140.1);
case 658: return new CityInfo("Kuroiso", "38", 36.96667, 140.05);
case 659: return new CityInfo("Kōriyama", "08", 37.4, 140.38333);
case 660: return new CityInfo("Kogota", "24", 38.55, 141.05);
case 661: return new CityInfo("Kitakami", "16", 39.28333, 141.11667);
case 662: return new CityInfo("Kitaibaraki", "14", 36.78671, 140.74901);
case 663: return new CityInfo("Kesennuma", "24", 38.90112, 141.57746);
case 664: return new CityInfo("Kamogawa", "04", 35.0969, 140.1003);
case 665: return new CityInfo("Katsuura", "04", 35.14621, 140.31507);
case 666: return new CityInfo("Katsuta", "14", 36.38333, 140.53333);
case 667: return new CityInfo("Katori-shi", "04", 35.89767, 140.49943);
case 668: return new CityInfo("Kasama", "14", 36.38333, 140.26667);
case 669: return new CityInfo("Karasuyama", "38", 36.65, 140.15);
case 670: return new CityInfo("Kaminoyama", "44", 38.15389, 140.27361);
case 671: return new CityInfo("Kamaishi", "16", 39.27694, 141.86801);
case 672: return new CityInfo("Kakunodatemachi", "02", 39.58926, 140.56724);
case 673: return new CityInfo("Kakuda", "24", 37.97451, 140.77202);
case 674: return new CityInfo("Iwase", "14", 36.35, 140.1);
case 675: return new CityInfo("Iwanuma", "24", 38.10472, 140.85944);
case 676: return new CityInfo("Iwaki", "08", 37.05, 140.88333);
case 677: return new CityInfo("Itako", "14", 35.93333, 140.55);
case 678: return new CityInfo("Ishioka", "14", 36.18333, 140.26667);
case 679: return new CityInfo("Ishinomaki", "24", 38.41667, 141.3);
case 680: return new CityInfo("Ishikawa", "08", 37.15, 140.45);
case 681: return new CityInfo("Inawashiro", "08", 37.56667, 140.11667);
case 682: return new CityInfo("Ichinoseki", "16", 38.91667, 141.13333);
case 683: return new CityInfo("Ichihara", "04", 35.51667, 140.08333);
case 684: return new CityInfo("Hokota", "14", 36.15, 140.51667);
case 685: return new CityInfo("Hobaramachi", "08", 37.81667, 140.55);
case 686: return new CityInfo("Hitachi", "14", 36.6, 140.65);
case 687: return new CityInfo("Higashine", "44", 38.43889, 140.40056);
case 688: return new CityInfo("Hasaki", "04", 35.73333, 140.83333);
case 689: return new CityInfo("Hanamaki", "16", 39.38333, 141.11667);
case 690: return new CityInfo("Furukawa", "24", 38.57167, 140.95556);
case 691: return new CityInfo("Funehikimachi-funehiki", "08", 37.44722, 140.5771);
case 692: return new CityInfo("Funaishikawa", "14", 36.46667, 140.56667);
case 693: return new CityInfo("Fukushima", "08", 37.75, 140.46667);
case 694: return new CityInfo("Fujishiro", "14", 35.91667, 140.11667);
case 695: return new CityInfo("Edosaki", "14", 35.95, 140.31667);
case 696: return new CityInfo("Date", "08", 37.81667, 140.5);
case 697: return new CityInfo("Daigo", "14", 36.76667, 140.35);
case 698: return new CityInfo("Choshi", "04", 35.73333, 140.83333);
case 699: return new CityInfo("Chiba", "04", 35.6, 140.11667);
case 700: return new CityInfo("Asahi", "04", 35.71667, 140.65);
case 701: return new CityInfo("Ami", "14", 36.03333, 140.2);
case 702: return new CityInfo("Akita", "02", 39.71667, 140.11667);
case 703: return new CityInfo("Abiko", "04", 35.86667, 140.01667);
case 704: return new CityInfo("Motomachi", "12", 43.82634, 144.09638);
case 705: return new CityInfo("Yūbari", "12", 43.03778, 141.95778);
case 706: return new CityInfo("Wakkanai", "12", 45.40944, 141.67389);
case 707: return new CityInfo("Utashinai", "12", 43.51667, 142.05);
case 708: return new CityInfo("Tomakomai", "12", 42.63694, 141.60333);
case 709: return new CityInfo("Tōbetsu", "12", 43.21694, 141.51694);
case 710: return new CityInfo("Mutsu", "03", 41.28944, 141.21694);
case 711: return new CityInfo("Takikawa", "12", 43.55278, 141.90639);
case 712: return new CityInfo("Takanosu", "02", 40.22268, 140.36611);
case 713: return new CityInfo("Sunagawa", "12", 43.48639, 141.90556);
case 714: return new CityInfo("Shizunai-furukawachō", "12", 42.33389, 142.36694);
case 715: return new CityInfo("Shiraoi", "12", 42.55, 141.35);
case 716: return new CityInfo("Shimo-furano", "12", 43.35, 142.38333);
case 717: return new CityInfo("Shibetsu", "12", 43.65899, 145.13197);
case 718: return new CityInfo("Sapporo", "12", 43.06667, 141.35);
case 719: return new CityInfo("Rumoi", "12", 43.93444, 141.64278);
case 720: return new CityInfo("Otofuke", "12", 42.99167, 143.20028);
case 721: return new CityInfo("Otaru", "12", 43.18944, 141.00222);
case 722: return new CityInfo("Ōdate", "02", 40.27178, 140.55756);
case 723: return new CityInfo("Obihiro", "12", 42.91722, 143.20444);
case 724: return new CityInfo("Noshiro", "02", 40.20838, 140.0274);
case 725: return new CityInfo("Noboribetsu", "12", 42.45215, 141.17914);
case 726: return new CityInfo("Nemuro", "12", 43.32361, 145.575);
case 727: return new CityInfo("Nayoro", "12", 44.35056, 142.45778);
case 728: return new CityInfo("Honchō", "12", 41.8944, 140.69386);
case 729: return new CityInfo("Namioka", "03", 40.71069, 140.59048);
case 730: return new CityInfo("Mobetsu", "12", 44.27096, 143.36025);
case 731: return new CityInfo("Muroran", "12", 42.31722, 140.98806);
case 732: return new CityInfo("Mombetsu", "12", 44.3525, 143.3525);
case 733: return new CityInfo("Misawa", "03", 40.68682, 141.38969);
case 734: return new CityInfo("Yoichi", "12", 43.20389, 140.77028);
case 735: return new CityInfo("Mikasa", "12", 43.25581, 141.88818);
case 736: return new CityInfo("Makubetsu", "12", 45.37139, 141.82111);
case 737: return new CityInfo("Kushiro", "12", 42.975, 144.37472);
case 738: return new CityInfo("Kuroishi", "03", 40.64581, 140.58354);
case 739: return new CityInfo("Kuji", "16", 40.18778, 141.76889);
case 740: return new CityInfo("Shimokizukuri", "03", 40.81609, 140.37539);
case 741: return new CityInfo("Kitami", "12", 43.80306, 143.89083);
case 742: return new CityInfo("Kamikawa", "12", 43.84, 142.77111);
case 743: return new CityInfo("Kamiiso", "12", 41.82013, 140.64482);
case 744: return new CityInfo("Iwanai", "12", 42.97444, 140.50889);
case 745: return new CityInfo("Iwamizawa", "12", 43.20028, 141.75972);
case 746: return new CityInfo("Ishikari", "12", 43.23972, 141.35389);
case 747: return new CityInfo("Ichinohe", "16", 40.21965, 141.28986);
case 748: return new CityInfo("Kitahiroshima", "12", 42.97583, 141.56722);
case 749: return new CityInfo("Hirosaki", "03", 40.59306, 140.4725);
case 750: return new CityInfo("Hanawa", "02", 40.18361, 140.78722);
case 751: return new CityInfo("Hakodate", "12", 41.77583, 140.73667);
case 752: return new CityInfo("Hachinohe", "03", 40.5, 141.5);
case 753: return new CityInfo("Furano", "12", 43.35, 142.38333);
case 754: return new CityInfo("Fukagawa", "12", 43.70806, 142.03917);
case 755: return new CityInfo("Ebetsu", "12", 43.10806, 141.55056);
case 756: return new CityInfo("Date", "12", 42.46806, 140.86806);
case 757: return new CityInfo("Chitose", "12", 42.81944, 141.65222);
case 758: return new CityInfo("Bibai", "12", 43.32472, 141.85861);
case 759: return new CityInfo("Ashibetsu", "12", 43.50972, 142.18556);
case 760: return new CityInfo("Asahikawa", "12", 43.77063, 142.36489);
case 761: return new CityInfo("Aomori", "03", 40.81667, 140.73333);
case 762: return new CityInfo("Akabira", "12", 43.55139, 142.05306);
case 763: return new CityInfo("Abashiri", "12", 44.02127, 144.26971);
case 764: return new CityInfo("Goshogawara", "03", 40.80444, 140.44139);
case 765: return new CityInfo("Aso", "21", 32.93726, 131.08008);
case 766: return new CityInfo("Kōya", "43", 34.21294, 135.62244);
case 767: return new CityInfo("Kihoku-chō", "05", 33.25592, 132.68343);
case 768: return new CityInfo("Nanto-shi", "42", 36.56922, 136.91162);
case 769: return new CityInfo("Kawage", "23", 34.80447, 136.54645);
case 770: return new CityInfo("Asahi", "06", 35.97259, 136.12455);
case 771: return new CityInfo("Neyagawa", "32", 34.76615, 135.62759);
case 772: return new CityInfo("Hitachi-Naka", "14", 36.39659, 140.53479);
case 773: return new CityInfo("Chikusei", "14", 36.316, 139.98238);
case 774: return new CityInfo("Kasumigaura", "14", 36.15326, 140.24635);
case 775: return new CityInfo("Tsuchiura", "14", 36.09047, 140.21047);
case 776: return new CityInfo("Tsukubamirai", "14", 35.98411, 140.00929);
case 777: return new CityInfo("Omitama", "14", 36.25449, 140.37962);
case 778: return new CityInfo("Hitachiomiya", "14", 36.56447, 140.40269);
case 779: return new CityInfo("Kamisu", "14", 35.89685, 140.66666);
case 780: return new CityInfo("Namegata", "14", 36.00705, 140.49623);
case 781: return new CityInfo("Sakuragawa", "14", 36.25052, 140.11565);
case 782: return new CityInfo("Bandō", "14", 36.06997, 139.86705);
case 783: return new CityInfo("Hitachi-ota", "14", 36.5513, 140.52821);
case 784: return new CityInfo("Inashiki", "14", 35.95633, 140.32356);
case 785: return new CityInfo("Azumino", "26", 36.28815, 137.88705);
case 786: return new CityInfo("Chikuma", "26", 36.52715, 138.08943);
case 787: return new CityInfo("Murayama", "44", 38.46972, 140.41441);
case 788: return new CityInfo("Minamiashigara", "19", 35.31947, 139.1096);
case 789: return new CityInfo("Rittō", "35", 35.02745, 135.99971);
case 790: return new CityInfo("Takashima", "35", 35.41347, 136.01612);
case 791: return new CityInfo("Kōka", "35", 34.9802, 136.15752);
case 792: return new CityInfo("Katsuragi", "28", 34.48562, 135.69698);
case 793: return new CityInfo("Kashiba", "28", 34.53472, 135.70925);
case 794: return new CityInfo("Nanto", "42", 36.51274, 136.89352);
case 795: return new CityInfo("Oyabe", "42", 36.66667, 136.85);
case 796: return new CityInfo("Imizu", "42", 36.76835, 137.12572);
case 797: return new CityInfo("Kurobe-shi", "42", 36.90123, 137.44955);
case 798: return new CityInfo("Tama", "40", 35.6436, 139.46844);
case 799: return new CityInfo("Musashimurayama", "40", 35.74242, 139.42635);
case 800: return new CityInfo("Akishima", "40", 35.72085, 139.37999);
case 801: return new CityInfo("Higashiyamato", "40", 35.76298, 139.44575);
case 802: return new CityInfo("Misato", "34", 35.84373, 139.88347);
case 803: return new CityInfo("Niiza", "34", 35.82088, 139.55791);
case 804: return new CityInfo("Tonami", "42", 36.62047, 136.94321);
case 805: return new CityInfo("Kahoku", "15", 36.75758, 136.71162);
case 806: return new CityInfo("Kaga", "15", 36.3, 136.33333);
case 807: return new CityInfo("Suzu", "15", 37.43459, 137.26009);
case 808: return new CityInfo("Matsuura", "27", 33.34058, 129.69504);
case 809: return new CityInfo("Ōnojō", "07", 33.53567, 130.47861);
case 810: return new CityInfo("Kasuga", "07", 33.52594, 130.4611);
case 811: return new CityInfo("Aizu-Wakamatsu", "08", 37.49142, 139.94546);
case 812: return new CityInfo("Minami-Sōma", "08", 37.62908, 140.97868);
case 813: return new CityInfo("Urasoe", "47", 26.25902, 127.73012);
case 814: return new CityInfo("Uruma", "47", 26.37609, 127.85908);
case 815: return new CityInfo("Jōsō", "14", 36.03553, 139.96143);
case 816: return new CityInfo("Midori", "10", 36.44492, 139.28448);
case 817: return new CityInfo("Miyakojima", "47", 24.79016, 125.31109);
case 818: return new CityInfo("Hidaka", "34", 35.91664, 139.36233);
case 819: return new CityInfo("Higashi-Matsuyama", "34", 36.03333, 139.41667);
case 820: return new CityInfo("Iruma", "34", 35.818, 139.368);
case 821: return new CityInfo("Kitamoto", "34", 36.03322, 139.53775);
case 822: return new CityInfo("Tsurugashima", "34", 35.95996, 139.40283);
case 823: return new CityInfo("Sōsa", "04", 35.71541, 140.55309);
case 824: return new CityInfo("Sanmu", "04", 35.62756, 140.41762);
case 825: return new CityInfo("Sōma", "08", 37.79283, 140.92941);
case 826: return new CityInfo("Tamura", "08", 37.43055, 140.60335);
case 827: return new CityInfo("Kinokawa", "43", 34.26973, 135.41045);
case 828: return new CityInfo("Kumano", "23", 33.90389, 136.12214);
case 829: return new CityInfo("Inabe", "23", 35.11344, 136.57205);
case 830: return new CityInfo("Shimotsuke", "38", 36.41323, 139.86622);
case 831: return new CityInfo("Nasukarasuyama", "38", 36.65233, 140.16084);
case 832: return new CityInfo("Tōmi", "26", 36.35582, 138.36093);
case 833: return new CityInfo("Komagane", "26", 35.71657, 137.93745);
case 834: return new CityInfo("Inzai", "04", 35.83479, 140.16361);
case 835: return new CityInfo("Isumi", "04", 35.23005, 140.40492);
case 836: return new CityInfo("Yachiyo", "04", 35.73531, 140.12445);
case 837: return new CityInfo("Tomisato", "04", 35.74483, 140.40386);
case 838: return new CityInfo("Ōshū", "16", 39.13927, 141.1685);
case 839: return new CityInfo("Hachimantai", "16", 39.89979, 141.12989);
case 840: return new CityInfo("Ninohe", "16", 40.29081, 141.31334);
case 841: return new CityInfo("Ōsaki", "24", 38.58866, 140.973);
case 842: return new CityInfo("Higashimatsushima", "24", 38.40886, 141.17901);
case 843: return new CityInfo("Kurihara", "24", 38.75, 141);
case 844: return new CityInfo("Izunokuni", "37", 35.03907, 138.95143);
case 845: return new CityInfo("Izu", "37", 34.97159, 138.94643);
case 846: return new CityInfo("Kikugawa", "37", 34.70291, 138.11978);
case 847: return new CityInfo("Kosai", "37", 34.70053, 137.52253);
case 848: return new CityInfo("Susono", "37", 35.17388, 138.90691);
case 849: return new CityInfo("Omaezaki", "37", 34.59882, 138.21934);
case 850: return new CityInfo("Nikaho", "02", 39.27077, 139.93949);
case 851: return new CityInfo("Daisen", "02", 39.44116, 140.48961);
case 852: return new CityInfo("Oga", "02", 39.871, 139.84926);
case 853: return new CityInfo("Yurihonjō", "02", 39.3895, 140.05813);
case 854: return new CityInfo("Katagami", "02", 39.87869, 139.99767);
case 855: return new CityInfo("Kita-Akita", "02", 40.19956, 140.39388);
case 856: return new CityInfo("Tsugaru", "03", 40.80357, 140.40299);
case 857: return new CityInfo("Hirakawa", "03", 40.58728, 140.57107);
case 858: return new CityInfo("Towada", "03", 40.62049, 141.21067);
case 859: return new CityInfo("Kitanagoya", "01", 35.24702, 136.87832);
case 860: return new CityInfo("Nisshin", "01", 35.13676, 137.05238);
case 861: return new CityInfo("Toyoake", "01", 35.038, 136.99931);
case 862: return new CityInfo("Chita", "01", 35.00267, 136.8642);
case 863: return new CityInfo("Aisai", "01", 35.16349, 136.73222);
case 864: return new CityInfo("Hashima", "09", 35.329, 136.68051);
case 865: return new CityInfo("Kaizu", "09", 35.20169, 136.63505);
case 866: return new CityInfo("Kani", "09", 35.40435, 137.05595);
case 867: return new CityInfo("Minokamo", "09", 35.48199, 137.02166);
case 868: return new CityInfo("Motosu", "09", 35.48384, 136.67443);
case 869: return new CityInfo("Gujō", "09", 35.73691, 136.95852);
case 870: return new CityInfo("Ena", "09", 35.44722, 137.38332);
case 871: return new CityInfo("Nanjō", "47", 26.14447, 127.76697);
case 872: return new CityInfo("Agano", "29", 37.77392, 139.22192);
case 873: return new CityInfo("Jōetsu", "29", 37.14828, 138.23642);
case 874: return new CityInfo("Minamiuonuma", "29", 37.08259, 138.87413);
case 875: return new CityInfo("Myoko", "29", 37.01497, 138.27324);
case 876: return new CityInfo("Sado", "29", 38.02496, 138.35931);
case 877: return new CityInfo("Tainai", "29", 38.06646, 139.37436);
case 878: return new CityInfo("Uonuma", "29", 37.24488, 138.96234);
case 879: return new CityInfo("Fujiidera", "32", 34.5676, 135.5974);
case 880: return new CityInfo("Habikino", "32", 34.55276, 135.59097);
case 881: return new CityInfo("Hannan", "32", 34.33333, 135.25);
case 882: return new CityInfo("Kawachi-Nagano", "32", 34.44108, 135.58283);
case 883: return new CityInfo("Sennan", "32", 34.34835, 135.26842);
case 884: return new CityInfo("Shijōnawate", "32", 34.73333, 135.68333);
case 885: return new CityInfo("Hokuto", "12", 41.81626, 140.63472);
case 886: return new CityInfo("Saitama", "34", 35.90807, 139.65657);
case 887: return new CityInfo("Niseko Town", "12", 42.77871, 140.66903);
case 888: return new CityInfo("Higashimurayama", "40", 35.75459, 139.46852);
case 889: return new CityInfo("Fujikawaguchiko", "46", 35.48933, 138.68832);
case 890: return new CityInfo("Hutami", "40", 27.08267, 142.20137);
case 891: return new CityInfo("Yawatahama", "05", 33.45737, 132.4328);
case 892: return new CityInfo("Kirishima", "18", 31.74087, 130.76288);
case 893: return new CityInfo("Amami", "18", 28.3769, 129.49379);
case 894: return new CityInfo("Rishiri Town", "12", 45.15928, 141.19629);
case 895: return new CityInfo("Arashiyama", "22", 35.01481, 135.67755);
case 896: return new CityInfo("Oda", "36", 35.20103, 132.49967);
case 897: return new CityInfo("Dazaifu", "07", 33.51278, 130.52389);
case 898: return new CityInfo("Amakusa", "21", 32.45861, 130.19306);
case 899: return new CityInfo("Kamigyō-ku", "22", 35.02954, 135.75666);
case 900: return new CityInfo("Buzen", "07", 33.61153, 131.13002);
case 901: return new CityInfo("Yoshitomi", "07", 33.60247, 131.17599);
case 902: return new CityInfo("Ikata-chō", "05", 33.48833, 132.35417);
case 903: return new CityInfo("Inuotose", "03", 40.60176, 141.32662);
case 904: return new CityInfo("Furudate", "03", 40.52934, 141.30553);
case 905: return new CityInfo("Hakuba", "26", 36.69818, 137.86185);
case 906: return new CityInfo("Nagatoro", "34", 36.10311, 139.10951);
case 907: return new CityInfo("Nagaoka", "22", 34.93097, 135.69203);
case 908: return new CityInfo("Yotsueda", "18", 32.01446, 130.73565);
case 909: return new CityInfo("Kofu", "46", 35.69763, 138.58819);
case 910: return new CityInfo("Fujiyoshida", "46", 35.44032, 138.79586);
case 911: return new CityInfo("Tsushima", "27", 34.20634, 129.29076);
case 912: return new CityInfo("Kuroishi", "03", 40.61545, 140.70362);
case 913: return new CityInfo("Ichikawa-minami", "04", 35.72634, 139.90392);
case 914: return new CityInfo("Eniwa", "12", 42.89357, 141.576);
case 915: return new CityInfo("Minami-Alps", "46", 35.616, 138.46344);
case 916: return new CityInfo("Arao", "21", 32.97888, 130.44572);
case 917: return new CityInfo("Ukiha", "07", 33.35634, 130.74966);
case 918: return new CityInfo("Iga", "23", 34.75797, 136.13468);
case 919: return new CityInfo("Kihoku", "23", 34.21052, 136.33475);
case 920: return new CityInfo("Kuwana", "23", 35.05192, 136.66958);
case 921: return new CityInfo("Matsusaka", "23", 34.57895, 136.53706);
case 922: return new CityInfo("Minamiise", "23", 34.34967, 136.69945);
case 923: return new CityInfo("Yonedacho Sendo", "13", 34.7756, 134.82551);
case 924: return new CityInfo("Hokuto", "46", 35.83458, 138.39606);
case 925: return new CityInfo("Fujimino", "34", 35.86142, 139.51532);
case 926: return new CityInfo("Himi", "42", 36.84666, 136.98355);
case 927: return new CityInfo("Takizawa", "16", 39.8028, 141.13466);
case 928: return new CityInfo("Tōon", "05", 33.79427, 132.89011);
case 929: return new CityInfo("Yasu", "35", 35.10053, 136.01778);
case 930: return new CityInfo("Yame", "07", 33.22792, 130.64873);
case 931: return new CityInfo("Yamatokōriyama", "28", 34.60658, 135.77033);
case 932: return new CityInfo("Yamato", "19", 35.47276, 139.45101);
case 933: return new CityInfo("Yamanashi", "46", 35.67152, 138.69827);
case 934: return new CityInfo("Urayasu", "04", 35.64188, 139.90402);
case 935: return new CityInfo("Tosashimizu", "20", 32.78396, 132.96324);
case 936: return new CityInfo("Toda", "34", 35.81447, 139.66018);
case 937: return new CityInfo("Taku", "33", 33.27709, 130.10928);
case 938: return new CityInfo("Taketa", "30", 32.95935, 131.3673);
case 939: return new CityInfo("Takeo", "33", 33.19187, 130.01281);
case 940: return new CityInfo("Takasago", "13", 34.76298, 134.79229);
case 941: return new CityInfo("Tachikawa", "40", 35.7091, 139.41891);
case 942: return new CityInfo("Shimonoseki", "45", 34.16736, 131.00012);
case 943: return new CityInfo("Saito", "25", 32.08199, 131.39957);
case 944: return new CityInfo("Sagamihara", "19", 35.56707, 139.24167);
case 945: return new CityInfo("Ogōri", "07", 33.38738, 130.54865);
case 946: return new CityInfo("Ogi", "33", 33.28028, 130.19503);
case 947: return new CityInfo("Nagakute", "01", 35.17325, 137.05667);
case 948: return new CityInfo("Munakata", "07", 33.7957, 130.55895);
case 949: return new CityInfo("Mitoyo", "17", 34.21052, 133.6746);
case 950: return new CityInfo("Mimasaka", "31", 35.04138, 134.22443);
case 951: return new CityInfo("Kunitachi", "40", 35.6833, 139.43848);
case 952: return new CityInfo("Miyake", "40", 34.08991, 139.5195);
case 953: return new CityInfo("Hachijō", "40", 33.10276, 139.7788);
case 954: return new CityInfo("Ōshima", "40", 34.74824, 139.36243);
case 955: return new CityInfo("Ogasawara", "40", 27.09688, 142.20377);
case 956: return new CityInfo("Kizugawa", "22", 34.73668, 135.83994);
case 957: return new CityInfo("Kawanishi", "13", 34.88114, 135.3986);
case 958: return new CityInfo("Katano", "32", 34.79329, 135.68596);
case 959: return new CityInfo("Hyūga", "25", 32.42272, 131.64093);
case 960: return new CityInfo("Sakai", "06", 36.1473, 136.19408);
case 961: return new CityInfo("Higashihiroshima", "11", 34.40861, 132.73682);
case 962: return new CityInfo("Higashikurume", "40", 35.75202, 139.51169);
case 963: return new CityInfo("Hamura", "40", 35.76232, 139.31952);
case 964: return new CityInfo("Funabashi", "04", 35.72045, 140.01148);
case 965: return new CityInfo("Fuji-yoshida", "46", 35.48486, 138.81123);
case 966: return new CityInfo("Fuchū", "40", 35.67452, 139.48216);
case 967: return new CityInfo("Fujimi", "34", 35.84815, 139.55521);
case 968: return new CityInfo("Chikugo", "07", 33.20537, 130.49183);
case 969: return new CityInfo("Sanuki", "17", 34.26686, 134.22958);
case 970: return new CityInfo("Ayase", "19", 35.43515, 139.4256);
case 971: return new CityInfo("Arida", "43", 34.08089, 135.11905);
case 972: return new CityInfo("Aira", "18", 31.77429, 130.59208);
case 973: return new CityInfo("Ama", "01", 35.18307, 136.7997);
case 974: return new CityInfo("Fukaya", "34", 36.1771, 139.26029);
case 975: return new CityInfo("Kodaira", "40", 35.72603, 139.48508);
case 976: return new CityInfo("Nishitōkyō", "40", 35.73355, 139.54761);
case 977: return new CityInfo("Nanyō", "44", 38.04322, 140.11276);
case 978: return new CityInfo("Kakogawa", "13", 34.75064, 134.86954);
case 979: return new CityInfo("Kan’onji", "17", 34.06972, 133.64902);
case 980: return new CityInfo("Katō", "13", 34.92422, 135.02609);
case 981: return new CityInfo("Mine", "45", 34.18681, 131.21624);
case 982: return new CityInfo("Hida", "09", 36.24483, 137.17323);
case 983: return new CityInfo("Kiyose", "40", 35.77952, 139.53014);
case 984: return new CityInfo("Jōyō", "22", 34.84396, 135.80561);
case 985: return new CityInfo("Yatomi", "01", 35.1053, 136.73378);
case 986: return new CityInfo("Tome", "24", 38.70882, 141.15578);
case 987: return new CityInfo("Kamagaya", "04", 35.76971, 140.00238);
case 988: return new CityInfo("Ebino", "25", 32.04766, 130.84442);
case 989: return new CityInfo("Isa", "18", 32.06716, 130.61182);
case 990: return new CityInfo("Ako", "13", 34.75967, 134.37035);
case 991: return new CityInfo("Bizen", "31", 34.78674, 134.23542);
case 992: return new CityInfo("Higashiōmi", "35", 35.1039, 136.26274);
case 993: return new CityInfo("Nakatsu", "30", 33.46238, 131.14174);
case 994: return new CityInfo("Usa", "30", 33.43946, 131.33675);
case 995: return new CityInfo("Etajima", "11", 34.23863, 132.47967);
case 996: return new CityInfo("Shimanto", "20", 33.07831, 132.85234);
case 997: return new CityInfo("Tatsuno", "13", 34.83184, 134.54338);
case 998: return new CityInfo("Iki", "27", 33.78286, 129.7209);
case 999: return new CityInfo("Tosa", "20", 33.50476, 133.44475);
case 1000: return new CityInfo("Tsuru", "46", 35.54731, 138.90959);
case 1001: return new CityInfo("Nankoku", "20", 33.56943, 133.64937);
case 1002: return new CityInfo("Aki-takata", "11", 34.67416, 132.68188);
case 1003: return new CityInfo("Seiyo", "05", 33.38817, 132.63176);
case 1004: return new CityInfo("Awa", "39", 34.09205, 134.28452);
case 1005: return new CityInfo("Yatsushiro", "21", 32.55723, 130.65285);
case 1006: return new CityInfo("Kai", "46", 35.68463, 138.50979);
case 1007: return new CityInfo("Sakura", "38", 36.72072, 139.98779);
case 1008: return new CityInfo("Awaji", "13", 34.47769, 134.93065);
case 1009: return new CityInfo("Warabi", "34", 35.82188, 139.68545);
case 1010: return new CityInfo("Miyoshi", "01", 35.08971, 137.08998);
case 1011: return new CityInfo("Itoshima", "07", 33.54225, 130.18421);
case 1012: return new CityInfo("Yufu", "30", 33.1956, 131.37829);
case 1013: return new CityInfo("Akiruno", "40", 35.72854, 139.2318);
case 1014: return new CityInfo("Shikokuchūō", "05", 33.9754, 133.54895);
case 1015: return new CityInfo("Ureshino", "33", 33.13525, 130.05718);
case 1016: return new CityInfo("Narashino", "04", 35.68184, 140.04152);
case 1017: return new CityInfo("Minamibōsō", "04", 35.03126, 139.92651);
case 1018: return new CityInfo("Ōamishirasato", "04", 35.51183, 140.35257);
case 1019: return new CityInfo("Sodegaura", "04", 35.41368, 140.02135);
case 1020: return new CityInfo("Echizen", "06", 35.88571, 136.17073);
case 1021: return new CityInfo("Kama", "07", 33.53488, 130.74228);
case 1022: return new CityInfo("Miyama", "07", 33.12102, 130.50007);
case 1023: return new CityInfo("Miyawaka", "07", 33.71706, 130.64117);
case 1024: return new CityInfo("Shirakawa", "08", 37.11954, 140.26211);
case 1025: return new CityInfo("Mizuho", "09", 35.3943, 136.66898);
case 1026: return new CityInfo("Motosu", "09", 35.65534, 136.61018);
case 1027: return new CityInfo("Yamagata", "09", 35.58306, 136.7585);
case 1028: return new CityInfo("Shibetsu", "12", 44.17137, 142.39517);
case 1029: return new CityInfo("Asago", "13", 35.25908, 134.81392);
case 1030: return new CityInfo("Kasai", "13", 34.92633, 134.84533);
case 1031: return new CityInfo("Minamiawaji", "13", 34.27396, 134.77512);
case 1032: return new CityInfo("Sanda", "13", 34.94716, 135.21389);
case 1033: return new CityInfo("Shisō", "13", 34.98107, 134.56398);
case 1034: return new CityInfo("Tanba", "13", 35.16034, 135.03914);
case 1035: return new CityInfo("Nomi", "15", 36.42902, 136.54564);
case 1036: return new CityInfo("Tōkai", "01", 35.02269, 136.90887);
case 1037: return new CityInfo("Higashikagawa", "17", 34.21024, 134.33653);
case 1038: return new CityInfo("Minamikyushu", "18", 31.34689, 130.45612);
case 1039: return new CityInfo("Minamisatsuma", "18", 31.38999, 130.28343);
case 1040: return new CityInfo("Soo", "18", 31.64637, 130.99068);
case 1041: return new CityInfo("Ebina", "19", 35.43417, 139.39419);
case 1042: return new CityInfo("Kami", "20", 33.68407, 133.84369);
case 1043: return new CityInfo("Kōnan", "20", 33.58345, 133.78189);
case 1044: return new CityInfo("Muroto", "20", 33.33282, 134.14169);
case 1045: return new CityInfo("Kōshi", "21", 32.89271, 130.77567);
case 1046: return new CityInfo("Uki", "21", 32.62217, 130.66177);
case 1047: return new CityInfo("Kyōtanabe", "22", 34.8045, 135.76681);
case 1048: return new CityInfo("Kyōtango", "22", 35.60623, 135.04429);
case 1049: return new CityInfo("Nantan", "22", 35.1098, 135.49164);
case 1050: return new CityInfo("Gotō", "27", 32.68418, 128.8068);
case 1051: return new CityInfo("Minamishimabara", "27", 32.67334, 130.26747);
case 1052: return new CityInfo("Saikai", "27", 32.9839, 129.6809);
case 1053: return new CityInfo("Unzen", "27", 32.77111, 130.24841);
case 1054: return new CityInfo("Bungo-ōno", "30", 32.97152, 131.52832);
case 1055: return new CityInfo("Akaiwa", "31", 34.80986, 134.02153);
case 1056: return new CityInfo("Maniwa", "31", 35.10643, 133.72009);
case 1057: return new CityInfo("Setouchi", "31", 34.65919, 134.14238);
case 1058: return new CityInfo("Izumisano", "32", 34.379, 135.31981);
case 1059: return new CityInfo("Ōsaka-sayama", "32", 34.49524, 135.55069);
case 1060: return new CityInfo("Imari", "33", 33.29036, 129.88998);
case 1061: return new CityInfo("Kanzaki", "33", 33.32393, 130.34051);
case 1062: return new CityInfo("Konan", "35", 34.99921, 136.09674);
case 1063: return new CityInfo("Yasugi", "36", 35.33613, 133.18382);
case 1064: return new CityInfo("Nasushiobara", "38", 36.97952, 139.99466);
case 1065: return new CityInfo("Mima", "39", 34.05493, 134.13963);
case 1066: return new CityInfo("Miyoshi", "39", 33.92541, 133.85674);
case 1067: return new CityInfo("Yoshinogawa", "39", 34.03858, 134.29207);
case 1068: return new CityInfo("Inagi", "40", 35.63295, 139.49967);
case 1069: return new CityInfo("Koganei", "40", 35.70014, 139.51109);
case 1070: return new CityInfo("Komae", "40", 35.63424, 139.57546);
case 1071: return new CityInfo("Sanyōonoda", "45", 34.03246, 131.16028);
case 1072: return new CityInfo("Shūnan", "45", 34.08053, 131.82564);
case 1073: return new CityInfo("Chūō", "46", 35.59465, 138.50275);
case 1074: return new CityInfo("Fuefuki", "46", 35.63526, 138.63853);
case 1075: return new CityInfo("Kōshū", "46", 35.72422, 138.77106);
case 1076: return new CityInfo("Higashiyamato", "40", 35.75052, 139.42959);
case 1077: return new CityInfo("Kazuno", "02", 40.20825, 140.78327);
case 1078: return new CityInfo("Unnan", "36", 35.2431, 132.89989);
case 1079: return new CityInfo("Kunisaki", "30", 33.5547, 131.72796);
case 1080: return new CityInfo("Ichikikushikino", "18", 31.72934, 130.29305);
case 1081: return new CityInfo("Asakuchi", "31", 34.53484, 133.60302);
case 1082: return new CityInfo("Fukutsu", "07", 33.783, 130.49114);
case 1083: return new CityInfo("Asakura", "07", 33.41439, 130.71877);
case 1084: return new CityInfo("Kamiamakusa", "21", 32.4892, 130.39433);
case 1085: return new CityInfo("Rikuzentakata", "16", 39.03759, 141.60004);
case 1086: return new CityInfo("Hakusan", "15", 36.48204, 136.58684);
case 1087: return new CityInfo("Semboku", "02", 39.7093, 140.74654);
case 1088: return new CityInfo("Tajiri", "32", 34.42695, 135.24552);
case 1089: return new CityInfo("Mitaka", "40", 35.68361, 139.56002);
case 1090: return new CityInfo("Handayama", "37", 34.77497, 137.73774);
default: return new CityInfo("Kasado", "23", 34.89141, 136.53049);

                                    }                                        
                                }
                            
                        }
                    }
                