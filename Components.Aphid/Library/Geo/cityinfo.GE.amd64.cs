
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
                                    public const string Country = "GE";
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
                            
                                        var cur = (Math.Abs(41.75183 - lat) + Math.Abs(42.8329 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(42.5088 - lat) + Math.Abs(41.87088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.19432 - lat) + Math.Abs(43.77361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.13181 - lat) + Math.Abs(44.77264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.10916 - lat) + Math.Abs(43.03602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.82458 - lat) + Math.Abs(44.75361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.08495 - lat) + Math.Abs(42.51192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.61608 - lat) + Math.Abs(42.88112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.99556 - lat) + Math.Abs(41.77861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.96553 - lat) + Math.Abs(44.17119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.62088 - lat) + Math.Abs(45.96943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.69472 - lat) + Math.Abs(44.69861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.22764 - lat) + Math.Abs(43.96861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.89315 - lat) + Math.Abs(45.57129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.76659 - lat) + Math.Abs(41.75517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.5946 - lat) + Math.Abs(44.0891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.60444 - lat) + Math.Abs(42.06825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.80365 - lat) + Math.Abs(43.48194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.65058 - lat) + Math.Abs(42.76959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.84035 - lat) + Math.Abs(41.68007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.34772 - lat) + Math.Abs(42.99808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.10833 - lat) + Math.Abs(44.96389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.5445 - lat) + Math.Abs(44.4615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.17979 - lat) + Math.Abs(42.98301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.91978 - lat) + Math.Abs(45.47315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.69411 - lat) + Math.Abs(44.83368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.23 - lat) + Math.Abs(43.91292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.02431 - lat) + Math.Abs(43.55556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.00697 - lat) + Math.Abs(40.9893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.60679 - lat) + Math.Abs(44.5854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.62046 - lat) + Math.Abs(45.92198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.62423 - lat) + Math.Abs(42.18575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.09595 - lat) + Math.Abs(43.08248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.35134 - lat) + Math.Abs(44.7645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.27042 - lat) + Math.Abs(42.0675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.1537 - lat) + Math.Abs(42.33517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.00758 - lat) + Math.Abs(44.40999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.73397 - lat) + Math.Abs(45.33149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.34528 - lat) + Math.Abs(43.41944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.56271 - lat) + Math.Abs(44.9787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.95493 - lat) + Math.Abs(45.81716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.14272 - lat) + Math.Abs(41.67384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.3506 - lat) + Math.Abs(44.68912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.92442 - lat) + Math.Abs(42.00682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.46777 - lat) + Math.Abs(41.67377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.57944 - lat) + Math.Abs(43.4425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.85713 - lat) + Math.Abs(41.83219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.71232 - lat) + Math.Abs(41.46863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26458 - lat) + Math.Abs(43.59161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.84514 - lat) + Math.Abs(44.71875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.81396 - lat) + Math.Abs(41.4813 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.04581 - lat) + Math.Abs(42.7278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.41436 - lat) + Math.Abs(42.37924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.48713 - lat) + Math.Abs(44.80195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.697 - lat) + Math.Abs(44.3845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.67385 - lat) + Math.Abs(41.69401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.14738 - lat) + Math.Abs(40.61472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.78893 - lat) + Math.Abs(42.72226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.09027 - lat) + Math.Abs(42.03239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.82681 - lat) + Math.Abs(46.27667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.49158 - lat) + Math.Abs(42.1109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.26791 - lat) + Math.Abs(42.69459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.2064 - lat) + Math.Abs(42.34606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.65887 - lat) + Math.Abs(44.70006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.82143 - lat) + Math.Abs(41.77921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.64591 - lat) + Math.Abs(42.31458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.32698 - lat) + Math.Abs(42.42379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.31558 - lat) + Math.Abs(41.89871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.20833 - lat) + Math.Abs(43.89264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.47796 - lat) + Math.Abs(43.2858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.58547 - lat) + Math.Abs(41.67193 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.99414 - lat) + Math.Abs(43.59994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.60093 - lat) + Math.Abs(41.94008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.65667 - lat) + Math.Abs(44.64333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.28388 - lat) + Math.Abs(43.20872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.9252 - lat) + Math.Abs(44.42568 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.39972 - lat) + Math.Abs(43.93667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.74292 - lat) + Math.Abs(45.80111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.92694 - lat) + Math.Abs(41.09639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.10547 - lat) + Math.Abs(40.62067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.47797 - lat) + Math.Abs(44.47616 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.98422 - lat) + Math.Abs(44.11578 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21725 - lat) + Math.Abs(43.69313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.4605 - lat) + Math.Abs(45.0928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.38111 - lat) + Math.Abs(40.07944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.62655 - lat) + Math.Abs(41.73808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.27858 - lat) + Math.Abs(40.27124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.71693 - lat) + Math.Abs(42.052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.84569 - lat) + Math.Abs(44.60097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.08583 - lat) + Math.Abs(44.69583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.87167 - lat) + Math.Abs(41.15333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.52514 - lat) + Math.Abs(44.3472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.3309 - lat) + Math.Abs(44.2001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.62933 - lat) + Math.Abs(42.39171 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.73611 - lat) + Math.Abs(44.96472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.46556 - lat) + Math.Abs(46.10528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.02003 - lat) + Math.Abs(42.24114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.52585 - lat) + Math.Abs(42.13213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.29806 - lat) + Math.Abs(43.29889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.72528 - lat) + Math.Abs(41.73278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.84694 - lat) + Math.Abs(43.39771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.44794 - lat) + Math.Abs(44.53838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.15925 - lat) + Math.Abs(40.33985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.64228 - lat) + Math.Abs(41.63392 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.75303 - lat) + Math.Abs(43.52907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.81667 - lat) + Math.Abs(46.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.57389 - lat) + Math.Abs(43.24826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.52111 - lat) + Math.Abs(43.16222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.03111 - lat) + Math.Abs(45.2075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.63901 - lat) + Math.Abs(42.98262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40514 - lat) + Math.Abs(43.48629 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.08056 - lat) + Math.Abs(40.83833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.12597 - lat) + Math.Abs(44.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.92945 - lat) + Math.Abs(43.48762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.65395 - lat) + Math.Abs(42.15163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.03761 - lat) + Math.Abs(43.82382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.67543 - lat) + Math.Abs(42.70308 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.20493 - lat) + Math.Abs(42.20333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.09236 - lat) + Math.Abs(40.6965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.32858 - lat) + Math.Abs(42.59808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.90694 - lat) + Math.Abs(41.95417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.73371 - lat) + Math.Abs(43.47242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.97877 - lat) + Math.Abs(41.07067 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.02137 - lat) + Math.Abs(43.19773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Abastumani", "72", 41.75183, 42.8329);
case 1: return new CityInfo("Zugdidi", "71", 42.5088, 41.87088);
case 2: return new CityInfo("Znaur", "00", 42.19432, 43.77361);
case 3: return new CityInfo("Zhinvali", "69", 42.13181, 44.77264);
case 4: return new CityInfo("Zest’aponi", "66", 42.10916, 43.03602);
case 5: return new CityInfo("Zahesi", "69", 41.82458, 44.75361);
case 6: return new CityInfo("Vani", "66", 42.08495, 42.51192);
case 7: return new CityInfo("Vale", "72", 41.61608, 42.88112);
case 8: return new CityInfo("Urek’i", "65", 41.99556, 41.77861);
case 9: return new CityInfo("Uplistsikhe", "73", 41.96553, 44.17119);
case 10: return new CityInfo("Ts’nori", "67", 41.62088, 45.96943);
case 11: return new CityInfo("Tsqnet’i", "68", 41.69472, 44.69861);
case 12: return new CityInfo("Ts’khinvali", "73", 42.22764, 43.96861);
case 13: return new CityInfo("Ts’inandali", "67", 41.89315, 45.57129);
case 14: return new CityInfo("Tsikhisdziri", "04", 41.76659, 41.75517);
case 15: return new CityInfo("Ts’alk’a", "68", 41.5946, 44.0891);
case 16: return new CityInfo("Ts’alenjikha", "71", 42.60444, 42.06825);
case 17: return new CityInfo("Ts’aghveri", "72", 41.80365, 43.48194);
case 18: return new CityInfo("Tsageri", "70", 42.65058, 42.76959);
case 19: return new CityInfo("Tqvarch'eli", "02", 42.84035, 41.68007);
case 20: return new CityInfo("T’q’ibuli", "66", 42.34772, 42.99808);
case 21: return new CityInfo("Tianeti", "69", 42.10833, 44.96389);
case 22: return new CityInfo("Tetri Ts’q’aro", "68", 41.5445, 44.4615);
case 23: return new CityInfo("Terjola", "66", 42.17979, 42.98301);
case 24: return new CityInfo("Telavi", "67", 41.91978, 45.47315);
case 25: return new CityInfo("Tbilisi", "51", 41.69411, 44.83368);
case 26: return new CityInfo("Tbeti", "00", 42.23, 43.91292);
case 27: return new CityInfo("Surami", "73", 42.02431, 43.55556);
case 28: return new CityInfo("Sokhumi", "02", 43.00697, 40.9893);
case 29: return new CityInfo("Sioni", "69", 42.60679, 44.5854);
case 30: return new CityInfo("Sighnaghi", "67", 41.62046, 45.92198);
case 31: return new CityInfo("Shuakhevi", "04", 41.62423, 42.18575);
case 32: return new CityInfo("Shorap’ani", "66", 42.09595, 43.08248);
case 33: return new CityInfo("Shaumiani", "68", 41.35134, 44.7645);
case 34: return new CityInfo("Senak’i", "71", 42.27042, 42.0675);
case 35: return new CityInfo("Samtredia", "66", 42.1537, 42.33517);
case 36: return new CityInfo("Samtavisi", "73", 42.00758, 44.40999);
case 37: return new CityInfo("Sagarejo", "67", 41.73397, 45.33149);
case 38: return new CityInfo("Sach’khere", "66", 42.34528, 43.41944);
case 39: return new CityInfo("Rustavi", "68", 41.56271, 44.9787);
case 40: return new CityInfo("Q’vareli", "67", 41.95493, 45.81716);
case 41: return new CityInfo("P’ot’i", "71", 42.14272, 41.67384);
case 42: return new CityInfo("Pasanauri", "69", 42.3506, 44.68912);
case 43: return new CityInfo("Ozurgeti", "65", 41.92442, 42.00682);
case 44: return new CityInfo("Orsant’ia", "71", 42.46777, 41.67377);
case 45: return new CityInfo("Oni", "70", 42.57944, 43.4425);
case 46: return new CityInfo("Ochkhamuri", "04", 41.85713, 41.83219);
case 47: return new CityInfo("Och’amch’ire", "02", 42.71232, 41.46863);
case 48: return new CityInfo("Ninotsminda", "72", 41.26458, 43.59161);
case 49: return new CityInfo("Mtskheta", "69", 41.84514, 44.71875);
case 50: return new CityInfo("Mokvi", "02", 42.81396, 41.4813);
case 51: return new CityInfo("Mest’ia", "71", 43.04581, 42.7278);
case 52: return new CityInfo("Mart’vili", "71", 42.41436, 42.37924);
case 53: return new CityInfo("Marneuli", "68", 41.48713, 44.80195);
case 54: return new CityInfo("Manglisi", "68", 41.697, 44.3845);
case 55: return new CityInfo("Makhinjauri", "04", 41.67385, 41.69401);
case 56: return new CityInfo("Likhni", "02", 43.14738, 40.61472);
case 57: return new CityInfo("Lent’ekhi", "70", 42.78893, 42.72226);
case 58: return new CityInfo("Lanchkhuti", "65", 42.09027, 42.03239);
case 59: return new CityInfo("Lagodekhi", "67", 41.82681, 46.27667);
case 60: return new CityInfo("Kveda Chkhorots’q’u", "71", 42.49158, 42.1109);
case 61: return new CityInfo("Kutaisi", "66", 42.26791, 42.69459);
case 62: return new CityInfo("K’ulashi", "66", 42.2064, 42.34606);
case 63: return new CityInfo("Kojori", "68", 41.65887, 44.70006);
case 64: return new CityInfo("Kobuleti", "04", 41.82143, 41.77921);
case 65: return new CityInfo("Khulo", "04", 41.64591, 42.31458);
case 66: return new CityInfo("Khoni", "66", 42.32698, 42.42379);
case 67: return new CityInfo("Khobi", "71", 42.31558, 41.89871);
case 68: return new CityInfo("Khet’agurovi", "22", 42.20833, 43.89264);
case 69: return new CityInfo("Khertvisi", "72", 41.47796, 43.2858);
case 70: return new CityInfo("Khelvachauri", "04", 41.58547, 41.67193);
case 71: return new CityInfo("Khashuri", "73", 41.99414, 43.59994);
case 72: return new CityInfo("Keda", "04", 41.60093, 41.94008);
case 73: return new CityInfo("St’epants’minda", "69", 42.65667, 44.64333);
case 74: return new CityInfo("K’atskhi", "66", 42.28388, 43.20872);
case 75: return new CityInfo("K’asp’i", "73", 41.9252, 44.42568);
case 76: return new CityInfo("Java", "69", 42.39972, 43.93667);
case 77: return new CityInfo("Gurjaani", "67", 41.74292, 45.80111);
case 78: return new CityInfo("Gulrip’shi", "02", 42.92694, 41.09639);
case 79: return new CityInfo("Gudauta", "02", 43.10547, 40.62067);
case 80: return new CityInfo("Gudauri", "69", 42.47797, 44.47616);
case 81: return new CityInfo("Gori", "73", 41.98422, 44.11578);
case 82: return new CityInfo("Gorelovk’a", "72", 41.21725, 43.69313);
case 83: return new CityInfo("Gardabani", "68", 41.4605, 45.0928);
case 84: return new CityInfo("Gantiadi", "02", 43.38111, 40.07944);
case 85: return new CityInfo("Gali", "02", 42.62655, 41.73808);
case 86: return new CityInfo("Gagra", "02", 43.27858, 40.27124);
case 87: return new CityInfo("Jvari", "71", 42.71693, 42.052);
case 88: return new CityInfo("Dzegvi", "69", 41.84569, 44.60097);
case 89: return new CityInfo("Dusheti", "69", 42.08583, 44.69583);
case 90: return new CityInfo("Dranda", "02", 42.87167, 41.15333);
case 91: return new CityInfo("Jvara", "68", 41.52514, 44.3472);
case 92: return new CityInfo("Dmanisi", "68", 41.3309, 44.2001);
case 93: return new CityInfo("Diok’nisi", "04", 41.62933, 42.39171);
case 94: return new CityInfo("Didi Lilo", "68", 41.73611, 44.96472);
case 95: return new CityInfo("Dedoplists’q’aro", "67", 41.46556, 46.10528);
case 96: return new CityInfo("Chokhat’auri", "65", 42.02003, 42.24114);
case 97: return new CityInfo("Chkhorots’q’u", "71", 42.52585, 42.13213);
case 98: return new CityInfo("Chiat’ura", "66", 42.29806, 43.29889);
case 99: return new CityInfo("Chakvi", "04", 41.72528, 41.73278);
case 100: return new CityInfo("Borjomi", "72", 41.84694, 43.39771);
case 101: return new CityInfo("Bolnisi", "68", 41.44794, 44.53838);
case 102: return new CityInfo("Bich’vinta", "02", 43.15925, 40.33985);
case 103: return new CityInfo("Batumi", "04", 41.64228, 41.63392);
case 104: return new CityInfo("Bak’uriani", "72", 41.75303, 43.52907);
case 105: return new CityInfo("Bagdadi", "00", 41.81667, 46.03333);
case 106: return new CityInfo("Asp’indza", "72", 41.57389, 43.24826);
case 107: return new CityInfo("Ambrolauri", "70", 42.52111, 43.16222);
case 108: return new CityInfo("Akhmet’a", "67", 42.03111, 45.2075);
case 109: return new CityInfo("Akhaltsikhe", "72", 41.63901, 42.98262);
case 110: return new CityInfo("Akhalk’alak’i", "72", 41.40514, 43.48629);
case 111: return new CityInfo("Stantsiya Novyy Afon", "02", 43.08056, 40.83833);
case 112: return new CityInfo("Akhalgori", "69", 42.12597, 44.48333);
case 113: return new CityInfo("Akhaldaba", "72", 41.92945, 43.48762);
case 114: return new CityInfo("Akhaldaba", "04", 41.65395, 42.15163);
case 115: return new CityInfo("Agara", "73", 42.03761, 43.82382);
case 116: return new CityInfo("Adigeni", "72", 41.67543, 42.70308);
case 117: return new CityInfo("Abasha", "71", 42.20493, 42.20333);
case 118: return new CityInfo("P’rimorsk’oe", "02", 43.09236, 40.6965);
case 119: return new CityInfo("Ts’q’alt’ubo", "66", 42.32858, 42.59808);
case 120: return new CityInfo("Naruja", "65", 41.90694, 41.95417);
case 121: return new CityInfo("Bak’urianis Andezit’i", "72", 41.73371, 43.47242);
case 122: return new CityInfo("Kelasuri", "02", 42.97877, 41.07067);
default: return new CityInfo("Kharagauli", "66", 42.02137, 43.19773);

                                    }                                        
                                }
                            
                        }
                    }
                