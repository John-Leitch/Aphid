
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
                                    public const string Country = "BE";
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
                            
                                        var cur = (Math.Abs(51.21979 - lat) + Math.Abs(4.32664 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(50.81268 - lat) + Math.Abs(3.33848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.93306 - lat) + Math.Abs(5.5753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91954 - lat) + Math.Abs(3.44859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.26511 - lat) + Math.Abs(3.15506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.83316 - lat) + Math.Abs(5.10376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86955 - lat) + Math.Abs(3.81052 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8726 - lat) + Math.Abs(2.98725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.99064 - lat) + Math.Abs(5.36819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.11994 - lat) + Math.Abs(3.56496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.26825 - lat) + Math.Abs(4.71296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.90409 - lat) + Math.Abs(3.65305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.98318 - lat) + Math.Abs(4.46079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.18963 - lat) + Math.Abs(3.80777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.06566 - lat) + Math.Abs(4.0403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.32901 - lat) + Math.Abs(3.18188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.14236 - lat) + Math.Abs(3.1368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.88365 - lat) + Math.Abs(4.47298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.21488 - lat) + Math.Abs(4.66164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.3279 - lat) + Math.Abs(4.88059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.39214 - lat) + Math.Abs(4.59546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.20452 - lat) + Math.Abs(4.5225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.05782 - lat) + Math.Abs(3.27359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.06041 - lat) + Math.Abs(4.36019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.22787 - lat) + Math.Abs(4.51895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.9 - lat) + Math.Abs(3.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.00526 - lat) + Math.Abs(3.97683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8395 - lat) + Math.Abs(4.49427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8 - lat) + Math.Abs(3.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.00526 - lat) + Math.Abs(3.88341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09049 - lat) + Math.Abs(4.91544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.78069 - lat) + Math.Abs(3.03854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.2983 - lat) + Math.Abs(3.08213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.90812 - lat) + Math.Abs(4.30613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.08133 - lat) + Math.Abs(5.11413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.84096 - lat) + Math.Abs(5.33867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6605 - lat) + Math.Abs(5.97034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.71717 - lat) + Math.Abs(4.60138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.71469 - lat) + Math.Abs(4.3991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.62186 - lat) + Math.Abs(5.00528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6976 - lat) + Math.Abs(5.25524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.88898 - lat) + Math.Abs(3.42756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.53907 - lat) + Math.Abs(5.20846 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.62627 - lat) + Math.Abs(4.69837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.25401 - lat) + Math.Abs(4.43796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.41488 - lat) + Math.Abs(6.11207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.16852 - lat) + Math.Abs(3.87183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.10572 - lat) + Math.Abs(4.08573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.1525 - lat) + Math.Abs(3.605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.30856 - lat) + Math.Abs(4.8896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.20243 - lat) + Math.Abs(4.77259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.7376 - lat) + Math.Abs(5.69907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.56824 - lat) + Math.Abs(5.53259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.92814 - lat) + Math.Abs(4.42938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.57708 - lat) + Math.Abs(5.25945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.56667 - lat) + Math.Abs(4.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.28407 - lat) + Math.Abs(5.91502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.07316 - lat) + Math.Abs(2.66803 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.58907 - lat) + Math.Abs(5.86241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.60743 - lat) + Math.Abs(5.3174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.911 - lat) + Math.Abs(5.57848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.32254 - lat) + Math.Abs(4.94471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.69059 - lat) + Math.Abs(4.2009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.57026 - lat) + Math.Abs(5.69521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.37128 - lat) + Math.Abs(5.87146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.99231 - lat) + Math.Abs(4.70807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.60715 - lat) + Math.Abs(3.38932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.0656 - lat) + Math.Abs(3.10085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.78054 - lat) + Math.Abs(5.46484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.68326 - lat) + Math.Abs(5.51349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.47493 - lat) + Math.Abs(5.37755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.80745 - lat) + Math.Abs(4.9378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.99931 - lat) + Math.Abs(3.32707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.33933 - lat) + Math.Abs(4.28604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.53323 - lat) + Math.Abs(5.81245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.06513 - lat) + Math.Abs(5.08856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.82372 - lat) + Math.Abs(4.51418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86654 - lat) + Math.Abs(4.16682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.09501 - lat) + Math.Abs(5.52895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.12794 - lat) + Math.Abs(4.21372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.08038 - lat) + Math.Abs(5.21638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.40667 - lat) + Math.Abs(5.80838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.2099 - lat) + Math.Abs(4.03651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91851 - lat) + Math.Abs(4.50989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.395 - lat) + Math.Abs(5.93124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.97456 - lat) + Math.Abs(3.01469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.33189 - lat) + Math.Abs(4.37127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.50922 - lat) + Math.Abs(5.6595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.48375 - lat) + Math.Abs(5.86674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.61385 - lat) + Math.Abs(5.74679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.33699 - lat) + Math.Abs(5.36705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.52865 - lat) + Math.Abs(4.60087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.57904 - lat) + Math.Abs(4.07129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.81679 - lat) + Math.Abs(5.18647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.77926 - lat) + Math.Abs(4.24355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.16509 - lat) + Math.Abs(4.1437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.81158 - lat) + Math.Abs(4.16965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.01459 - lat) + Math.Abs(3.63779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.81867 - lat) + Math.Abs(3.84436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.28216 - lat) + Math.Abs(3.54644 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.9197 - lat) + Math.Abs(3.86225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.24202 - lat) + Math.Abs(3.52441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.21399 - lat) + Math.Abs(3.24949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.06691 - lat) + Math.Abs(4.53469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.21914 - lat) + Math.Abs(4.12374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.74645 - lat) + Math.Abs(4.35754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.05645 - lat) + Math.Abs(4.20957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.64877 - lat) + Math.Abs(3.92363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.58362 - lat) + Math.Abs(5.50115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.53135 - lat) + Math.Abs(4.26301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.25251 - lat) + Math.Abs(4.50268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.24107 - lat) + Math.Abs(4.58336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.12615 - lat) + Math.Abs(4.34114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.74335 - lat) + Math.Abs(2.90992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.28146 - lat) + Math.Abs(6.12724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.62837 - lat) + Math.Abs(5.53243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.61196 - lat) + Math.Abs(5.65688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.02668 - lat) + Math.Abs(5.37401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.44816 - lat) + Math.Abs(3.81886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.01723 - lat) + Math.Abs(5.51926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.08153 - lat) + Math.Abs(4.42217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.5545 - lat) + Math.Abs(3.30535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.04039 - lat) + Math.Abs(3.39416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.53771 - lat) + Math.Abs(5.49031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.95302 - lat) + Math.Abs(4.71665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.74574 - lat) + Math.Abs(3.6005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.61667 - lat) + Math.Abs(5.46667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.50365 - lat) + Math.Abs(4.11163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.94653 - lat) + Math.Abs(3.12269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.1631 - lat) + Math.Abs(5.2216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.71229 - lat) + Math.Abs(4.52529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.34795 - lat) + Math.Abs(4.76053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.80995 - lat) + Math.Abs(5.60131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.26652 - lat) + Math.Abs(5.08242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.23423 - lat) + Math.Abs(5.50414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.68069 - lat) + Math.Abs(5.32785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.65147 - lat) + Math.Abs(4.10683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.37274 - lat) + Math.Abs(4.9921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.18983 - lat) + Math.Abs(4.56533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.63395 - lat) + Math.Abs(4.90119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6672 - lat) + Math.Abs(6.11535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.40737 - lat) + Math.Abs(3.68351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.36879 - lat) + Math.Abs(3.93602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.44067 - lat) + Math.Abs(3.8653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.07409 - lat) + Math.Abs(4.28844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.05337 - lat) + Math.Abs(4.63263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.37581 - lat) + Math.Abs(4.86506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85386 - lat) + Math.Abs(2.72659 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.54916 - lat) + Math.Abs(5.02101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.50518 - lat) + Math.Abs(4.36887 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.73656 - lat) + Math.Abs(5.95922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.99279 - lat) + Math.Abs(3.26317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.19612 - lat) + Math.Abs(4.54374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.62426 - lat) + Math.Abs(4.81354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.50819 - lat) + Math.Abs(3.59373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.88914 - lat) + Math.Abs(3.86098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.57375 - lat) + Math.Abs(5.8049 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.75922 - lat) + Math.Abs(4.15983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.1303 - lat) + Math.Abs(5.45952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.68619 - lat) + Math.Abs(3.33789 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.90395 - lat) + Math.Abs(5.13537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.21038 - lat) + Math.Abs(5.41557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.77436 - lat) + Math.Abs(4.53461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.71184 - lat) + Math.Abs(5.6468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.4387 - lat) + Math.Abs(5.4657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.31978 - lat) + Math.Abs(4.9841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.83522 - lat) + Math.Abs(4.66421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.18489 - lat) + Math.Abs(3.00035 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85168 - lat) + Math.Abs(3.60891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.66535 - lat) + Math.Abs(4.56679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.71749 - lat) + Math.Abs(5.3488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.96724 - lat) + Math.Abs(4.18442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.04258 - lat) + Math.Abs(5.58346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.92093 - lat) + Math.Abs(3.33799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.3 - lat) + Math.Abs(4.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.15432 - lat) + Math.Abs(3.23128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.95261 - lat) + Math.Abs(3.79826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.21551 - lat) + Math.Abs(2.927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.11565 - lat) + Math.Abs(2.68217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.24148 - lat) + Math.Abs(4.84069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.58994 - lat) + Math.Abs(5.74662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.14391 - lat) + Math.Abs(4.8598 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.4357 - lat) + Math.Abs(5.12375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.55702 - lat) + Math.Abs(4.98466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.59833 - lat) + Math.Abs(4.32848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.82776 - lat) + Math.Abs(4.02657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.16096 - lat) + Math.Abs(4.67008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.13008 - lat) + Math.Abs(2.75135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8638 - lat) + Math.Abs(5.19467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.11096 - lat) + Math.Abs(4.33428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.03531 - lat) + Math.Abs(3.54574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.84074 - lat) + Math.Abs(5.43535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.22807 - lat) + Math.Abs(5.4427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.95686 - lat) + Math.Abs(3.59425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.12849 - lat) + Math.Abs(5.34274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.50675 - lat) + Math.Abs(5.41905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.4669 - lat) + Math.Abs(4.86746 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.55835 - lat) + Math.Abs(5.70525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.74497 - lat) + Math.Abs(3.20639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.16697 - lat) + Math.Abs(4.45127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.45502 - lat) + Math.Abs(4.24519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8919 - lat) + Math.Abs(3.06117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.63427 - lat) + Math.Abs(4.61061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.45413 - lat) + Math.Abs(3.95229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.0271 - lat) + Math.Abs(4.16519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.19188 - lat) + Math.Abs(5.11662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.17409 - lat) + Math.Abs(3.93001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.44614 - lat) + Math.Abs(5.29532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.18532 - lat) + Math.Abs(2.82077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.95136 - lat) + Math.Abs(3.28804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.32119 - lat) + Math.Abs(4.66232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.59201 - lat) + Math.Abs(5.81879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.76581 - lat) + Math.Abs(2.89764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.35851 - lat) + Math.Abs(4.86513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.99447 - lat) + Math.Abs(3.74621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.95129 - lat) + Math.Abs(4.23197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.32449 - lat) + Math.Abs(4.16489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.79722 - lat) + Math.Abs(3.12245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.00232 - lat) + Math.Abs(3.80526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.60581 - lat) + Math.Abs(5.48045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.93934 - lat) + Math.Abs(4.32655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.1321 - lat) + Math.Abs(5.07842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.02574 - lat) + Math.Abs(4.47762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.83195 - lat) + Math.Abs(5.73655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.52303 - lat) + Math.Abs(4.94059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.46707 - lat) + Math.Abs(5.2428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.22678 - lat) + Math.Abs(5.34416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.29219 - lat) + Math.Abs(5.67562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.50312 - lat) + Math.Abs(4.23589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.42686 - lat) + Math.Abs(6.02794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.20737 - lat) + Math.Abs(3.44511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91061 - lat) + Math.Abs(4.44174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.96545 - lat) + Math.Abs(5.69452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09802 - lat) + Math.Abs(5.78379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.98772 - lat) + Math.Abs(5.19121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.88278 - lat) + Math.Abs(4.83896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.10168 - lat) + Math.Abs(3.61298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.66829 - lat) + Math.Abs(4.61443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.68126 - lat) + Math.Abs(6.00712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.00468 - lat) + Math.Abs(4.30304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.23074 - lat) + Math.Abs(5.31349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.10364 - lat) + Math.Abs(3.99339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09644 - lat) + Math.Abs(3.83194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.35258 - lat) + Math.Abs(4.26716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.12707 - lat) + Math.Abs(4.49669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.76781 - lat) + Math.Abs(4.33688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.71222 - lat) + Math.Abs(5.03654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.61222 - lat) + Math.Abs(5.9412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.24197 - lat) + Math.Abs(4.82313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.13128 - lat) + Math.Abs(4.57041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.28477 - lat) + Math.Abs(5.79236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.63373 - lat) + Math.Abs(5.56749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86892 - lat) + Math.Abs(4.08743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.03333 - lat) + Math.Abs(3.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.98107 - lat) + Math.Abs(5.25612 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87959 - lat) + Math.Abs(4.70093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.71104 - lat) + Math.Abs(3.83579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.11667 - lat) + Math.Abs(5.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.55696 - lat) + Math.Abs(3.89946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.88626 - lat) + Math.Abs(3.23747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.79985 - lat) + Math.Abs(5.53652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85785 - lat) + Math.Abs(3.12409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.03859 - lat) + Math.Abs(3.74458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.84356 - lat) + Math.Abs(4.09112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.96626 - lat) + Math.Abs(3.98594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.00464 - lat) + Math.Abs(4.13457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.18361 - lat) + Math.Abs(5.57547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.75267 - lat) + Math.Abs(5.082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.89318 - lat) + Math.Abs(5.6468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.48657 - lat) + Math.Abs(4.18785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.73091 - lat) + Math.Abs(4.48577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.71809 - lat) + Math.Abs(6.01107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.39478 - lat) + Math.Abs(4.61444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.03078 - lat) + Math.Abs(3.85077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85143 - lat) + Math.Abs(3.2824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.90168 - lat) + Math.Abs(3.52588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.17048 - lat) + Math.Abs(4.31444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86155 - lat) + Math.Abs(4.46946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.82803 - lat) + Math.Abs(3.26487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.8589 - lat) + Math.Abs(5.38974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.88982 - lat) + Math.Abs(4.54353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.90862 - lat) + Math.Abs(5.05968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.02951 - lat) + Math.Abs(3.04112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.13213 - lat) + Math.Abs(4.44706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.11642 - lat) + Math.Abs(2.63772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09047 - lat) + Math.Abs(2.9783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.35 - lat) + Math.Abs(3.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.13932 - lat) + Math.Abs(3.41282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.14543 - lat) + Math.Abs(5.74207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.00295 - lat) + Math.Abs(4.63434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.24118 - lat) + Math.Abs(4.96651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.2172 - lat) + Math.Abs(3.61519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.0097 - lat) + Math.Abs(4.36303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.31377 - lat) + Math.Abs(4.43539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.9421 - lat) + Math.Abs(4.55103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.38442 - lat) + Math.Abs(4.47556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.531 - lat) + Math.Abs(3.90942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.7076 - lat) + Math.Abs(5.53127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.72357 - lat) + Math.Abs(4.86914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.55876 - lat) + Math.Abs(5.96764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.18185 - lat) + Math.Abs(3.08935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91396 - lat) + Math.Abs(3.21378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.64396 - lat) + Math.Abs(4.26476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.92081 - lat) + Math.Abs(3.25571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.69151 - lat) + Math.Abs(4.79816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85114 - lat) + Math.Abs(2.88569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09572 - lat) + Math.Abs(3.01549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.51894 - lat) + Math.Abs(5.23284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.07451 - lat) + Math.Abs(4.79081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.78939 - lat) + Math.Abs(4.5831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.15446 - lat) + Math.Abs(4.4707 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.18619 - lat) + Math.Abs(5.00762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.97824 - lat) + Math.Abs(2.9505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.03427 - lat) + Math.Abs(5.37429 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.13235 - lat) + Math.Abs(5.78962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.26742 - lat) + Math.Abs(5.44609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.40029 - lat) + Math.Abs(4.76034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.98333 - lat) + Math.Abs(3.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.92097 - lat) + Math.Abs(4.75747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.84714 - lat) + Math.Abs(5.48767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.7673 - lat) + Math.Abs(4.46835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.7756 - lat) + Math.Abs(4.88952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.17611 - lat) + Math.Abs(4.34844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.52576 - lat) + Math.Abs(5.00719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.03664 - lat) + Math.Abs(5.28013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.88681 - lat) + Math.Abs(3.89014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.64083 - lat) + Math.Abs(5.79353 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.66415 - lat) + Math.Abs(5.62346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.05159 - lat) + Math.Abs(4.88231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.54731 - lat) + Math.Abs(5.09774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.72423 - lat) + Math.Abs(4.03481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.94013 - lat) + Math.Abs(5.16636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.1401 - lat) + Math.Abs(4.75572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.17655 - lat) + Math.Abs(4.83248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.90861 - lat) + Math.Abs(4.67056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.78086 - lat) + Math.Abs(5.2358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.43263 - lat) + Math.Abs(3.68411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.60291 - lat) + Math.Abs(4.98848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.14484 - lat) + Math.Abs(4.33874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.05591 - lat) + Math.Abs(5.38244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.07537 - lat) + Math.Abs(4.72827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.75383 - lat) + Math.Abs(5.3021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.38931 - lat) + Math.Abs(5.23816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.21849 - lat) + Math.Abs(4.82446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.93106 - lat) + Math.Abs(5.33781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85343 - lat) + Math.Abs(3.30935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.67142 - lat) + Math.Abs(5.07898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.3402 - lat) + Math.Abs(5.15619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.42675 - lat) + Math.Abs(5.53304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09822 - lat) + Math.Abs(4.13705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.73385 - lat) + Math.Abs(4.23454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.94837 - lat) + Math.Abs(5.11096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.72329 - lat) + Math.Abs(5.61999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.90634 - lat) + Math.Abs(4.00093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.97737 - lat) + Math.Abs(4.63777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.19043 - lat) + Math.Abs(4.73562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.93409 - lat) + Math.Abs(4.37213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.73901 - lat) + Math.Abs(4.69829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.186 - lat) + Math.Abs(5.93917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.79443 - lat) + Math.Abs(4.11378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87267 - lat) + Math.Abs(4.95615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.15612 - lat) + Math.Abs(2.96387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.74792 - lat) + Math.Abs(5.13422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.40146 - lat) + Math.Abs(5.07457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.33789 - lat) + Math.Abs(4.52731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.77343 - lat) + Math.Abs(3.88223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.05 - lat) + Math.Abs(3.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.965 - lat) + Math.Abs(5.50082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.61173 - lat) + Math.Abs(4.45152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.56149 - lat) + Math.Abs(4.69889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.89431 - lat) + Math.Abs(5.11199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6699 - lat) + Math.Abs(5.17364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.16557 - lat) + Math.Abs(4.98917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.98037 - lat) + Math.Abs(4.93674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.92917 - lat) + Math.Abs(3.66184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.75389 - lat) + Math.Abs(3.97121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.15106 - lat) + Math.Abs(4.32742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.66783 - lat) + Math.Abs(3.62047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.40578 - lat) + Math.Abs(3.89603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.73863 - lat) + Math.Abs(5.82224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.39517 - lat) + Math.Abs(4.69623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.57424 - lat) + Math.Abs(4.99861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.69983 - lat) + Math.Abs(5.3074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.25127 - lat) + Math.Abs(4.60636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.43452 - lat) + Math.Abs(4.7596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.73733 - lat) + Math.Abs(3.73876 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.48351 - lat) + Math.Abs(4.55006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.61516 - lat) + Math.Abs(5.68062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.59994 - lat) + Math.Abs(5.44471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6654 - lat) + Math.Abs(5.39978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.40157 - lat) + Math.Abs(5.61092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.85116 - lat) + Math.Abs(5.66405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.43006 - lat) + Math.Abs(4.54152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.66252 - lat) + Math.Abs(5.26005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.11306 - lat) + Math.Abs(3.70976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6279 - lat) + Math.Abs(6.03647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.67385 - lat) + Math.Abs(5.60019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.41016 - lat) + Math.Abs(4.10477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.70485 - lat) + Math.Abs(3.26785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.46791 - lat) + Math.Abs(4.46901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.53596 - lat) + Math.Abs(5.56775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.30688 - lat) + Math.Abs(4.11129 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.29292 - lat) + Math.Abs(5.55815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.58156 - lat) + Math.Abs(5.39916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.68373 - lat) + Math.Abs(4.03284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.73512 - lat) + Math.Abs(3.67985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.59076 - lat) + Math.Abs(4.91175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.18703 - lat) + Math.Abs(3.55654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.15662 - lat) + Math.Abs(4.44504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.56822 - lat) + Math.Abs(4.1658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.35291 - lat) + Math.Abs(5.45631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09554 - lat) + Math.Abs(4.50903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.78733 - lat) + Math.Abs(4.31471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.39583 - lat) + Math.Abs(3.77792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.64827 - lat) + Math.Abs(5.32 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.13356 - lat) + Math.Abs(4.73545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.61004 - lat) + Math.Abs(5.8534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.25807 - lat) + Math.Abs(4.91166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.84799 - lat) + Math.Abs(4.25972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.03248 - lat) + Math.Abs(2.86384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.98923 - lat) + Math.Abs(5.05062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.90769 - lat) + Math.Abs(5.41875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.89727 - lat) + Math.Abs(4.43354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.22134 - lat) + Math.Abs(4.46595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.05952 - lat) + Math.Abs(3.79899 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.23855 - lat) + Math.Abs(5.11448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.99339 - lat) + Math.Abs(3.64747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09793 - lat) + Math.Abs(2.59368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.96429 - lat) + Math.Abs(3.41617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.02869 - lat) + Math.Abs(4.10106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.88506 - lat) + Math.Abs(4.07601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.98175 - lat) + Math.Abs(3.53096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.27261 - lat) + Math.Abs(3.03446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85337 - lat) + Math.Abs(3.35416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.02161 - lat) + Math.Abs(5.11811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.25147 - lat) + Math.Abs(3.28144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.71315 - lat) + Math.Abs(5.72774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.71703 - lat) + Math.Abs(5.39802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.05284 - lat) + Math.Abs(4.49495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.63378 - lat) + Math.Abs(4.56851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.46379 - lat) + Math.Abs(4.3747 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.56804 - lat) + Math.Abs(4.95712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.47488 - lat) + Math.Abs(5.57711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.4141 - lat) + Math.Abs(3.85569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.40069 - lat) + Math.Abs(5.35154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.29449 - lat) + Math.Abs(5.10015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.73833 - lat) + Math.Abs(5.34104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.04856 - lat) + Math.Abs(4.31712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.58787 - lat) + Math.Abs(3.80711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.67753 - lat) + Math.Abs(4.7212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.5828 - lat) + Math.Abs(5.6341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.40338 - lat) + Math.Abs(4.52826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.60857 - lat) + Math.Abs(4.64198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.42842 - lat) + Math.Abs(3.95001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.41136 - lat) + Math.Abs(4.44448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.4713 - lat) + Math.Abs(4.28227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.17047 - lat) + Math.Abs(4.41028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.71229 - lat) + Math.Abs(3.45733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.42689 - lat) + Math.Abs(6.20504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.58454 - lat) + Math.Abs(5.07663 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.40731 - lat) + Math.Abs(6.25749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.0159 - lat) + Math.Abs(4.20173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.85045 - lat) + Math.Abs(4.34878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.50524 - lat) + Math.Abs(4.43209 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.20892 - lat) + Math.Abs(3.22424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.59577 - lat) + Math.Abs(3.85363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.14152 - lat) + Math.Abs(5.5969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.23489 - lat) + Math.Abs(2.97559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.35024 - lat) + Math.Abs(4.63829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.2912 - lat) + Math.Abs(4.49182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.61745 - lat) + Math.Abs(5.13302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.60979 - lat) + Math.Abs(4.14658 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6799 - lat) + Math.Abs(4.27385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.68363 - lat) + Math.Abs(4.36784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.83511 - lat) + Math.Abs(4.8345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.43417 - lat) + Math.Abs(3.7944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.79324 - lat) + Math.Abs(5.06703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.19661 - lat) + Math.Abs(4.48543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09716 - lat) + Math.Abs(4.24364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.80505 - lat) + Math.Abs(5.34366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.97929 - lat) + Math.Abs(4.57443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09242 - lat) + Math.Abs(4.3717 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.02261 - lat) + Math.Abs(4.54714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.15959 - lat) + Math.Abs(4.49195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.17337 - lat) + Math.Abs(5.57994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.67255 - lat) + Math.Abs(5.72508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.31306 - lat) + Math.Abs(3.13227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.41155 - lat) + Math.Abs(4.16469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87325 - lat) + Math.Abs(5.5184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.94085 - lat) + Math.Abs(5.01591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.82876 - lat) + Math.Abs(4.75949 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.62251 - lat) + Math.Abs(5.66508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.21187 - lat) + Math.Abs(4.25633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91667 - lat) + Math.Abs(4.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.85596 - lat) + Math.Abs(5.25539 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.08364 - lat) + Math.Abs(5.66689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.86403 - lat) + Math.Abs(4.62918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.4746 - lat) + Math.Abs(3.64961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.69829 - lat) + Math.Abs(5.21236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.03333 - lat) + Math.Abs(4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.1176 - lat) + Math.Abs(4.65835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.04954 - lat) + Math.Abs(5.22606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.55047 - lat) + Math.Abs(3.73484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.94074 - lat) + Math.Abs(4.969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.01942 - lat) + Math.Abs(4.78377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.76589 - lat) + Math.Abs(4.3002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.31927 - lat) + Math.Abs(4.85304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.13981 - lat) + Math.Abs(3.33896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.78195 - lat) + Math.Abs(4.7718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.11042 - lat) + Math.Abs(4.95554 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.23699 - lat) + Math.Abs(4.23926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.00347 - lat) + Math.Abs(5.71844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.75883 - lat) + Math.Abs(5.60989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.69503 - lat) + Math.Abs(4.49218 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.16837 - lat) + Math.Abs(5.17027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.63131 - lat) + Math.Abs(5.97433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.40504 - lat) + Math.Abs(4.89226 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.47411 - lat) + Math.Abs(5.67684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.66774 - lat) + Math.Abs(5.46329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.77618 - lat) + Math.Abs(3.44502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.70189 - lat) + Math.Abs(5.85812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.56652 - lat) + Math.Abs(5.80492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.75035 - lat) + Math.Abs(5.78634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.62937 - lat) + Math.Abs(3.77801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.36934 - lat) + Math.Abs(5.02204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.22598 - lat) + Math.Abs(3.75085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.91011 - lat) + Math.Abs(4.19836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.00755 - lat) + Math.Abs(5.58453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(49.68333 - lat) + Math.Abs(5.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.32267 - lat) + Math.Abs(5.08289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.9757 - lat) + Math.Abs(3.19736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.837 - lat) + Math.Abs(3.47786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.22047 - lat) + Math.Abs(4.40026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.56765 - lat) + Math.Abs(3.4492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.48323 - lat) + Math.Abs(5.519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.6623 - lat) + Math.Abs(5.52029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.31039 - lat) + Math.Abs(4.87827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.40704 - lat) + Math.Abs(4.27136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.48941 - lat) + Math.Abs(5.09513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.35357 - lat) + Math.Abs(6.17002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.54829 - lat) + Math.Abs(5.30974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.01238 - lat) + Math.Abs(2.71117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87553 - lat) + Math.Abs(5.30558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.41158 - lat) + Math.Abs(4.58671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.13412 - lat) + Math.Abs(4.38678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.98715 - lat) + Math.Abs(4.83695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.09017 - lat) + Math.Abs(3.44693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.93604 - lat) + Math.Abs(4.0355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.69211 - lat) + Math.Abs(3.63562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.60067 - lat) + Math.Abs(4.634 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.80903 - lat) + Math.Abs(4.16219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.08067 - lat) + Math.Abs(5.00556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(51.01041 - lat) + Math.Abs(4.97492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.87117 - lat) + Math.Abs(5.272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(50.89832 - lat) + Math.Abs(5.27623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zwijndrecht", "VLG", 51.21979, 4.32664);
case 1: return new CityInfo("Zwevegem", "VLG", 50.81268, 3.33848);
case 2: return new CityInfo("Zutendaal", "VLG", 50.93306, 5.5753);
case 3: return new CityInfo("Zulte", "VLG", 50.91954, 3.44859);
case 4: return new CityInfo("Zuienkerke", "VLG", 51.26511, 3.15506);
case 5: return new CityInfo("Zoutleeuw", "VLG", 50.83316, 5.10376);
case 6: return new CityInfo("Zottegem", "VLG", 50.86955, 3.81052);
case 7: return new CityInfo("Zonnebeke", "VLG", 50.8726, 2.98725);
case 8: return new CityInfo("Zonhoven", "VLG", 50.99064, 5.36819);
case 9: return new CityInfo("Zomergem", "VLG", 51.11994, 3.56496);
case 10: return new CityInfo("Zoersel", "VLG", 51.26825, 4.71296);
case 11: return new CityInfo("Zingem", "VLG", 50.90409, 3.65305);
case 12: return new CityInfo("Zemst", "VLG", 50.98318, 4.46079);
case 13: return new CityInfo("Zelzate", "VLG", 51.18963, 3.80777);
case 14: return new CityInfo("Zele", "VLG", 51.06566, 4.0403);
case 15: return new CityInfo("Zeebrugge", "VLG", 51.32901, 3.18188);
case 16: return new CityInfo("Zedelgem", "VLG", 51.14236, 3.1368);
case 17: return new CityInfo("Zaventem", "VLG", 50.88365, 4.47298);
case 18: return new CityInfo("Zandhoven", "VLG", 51.21488, 4.66164);
case 19: return new CityInfo("Yvoir", "WAL", 50.3279, 4.88059);
case 20: return new CityInfo("Wuustwezel", "VLG", 51.39214, 4.59546);
case 21: return new CityInfo("Wommelgem", "VLG", 51.20452, 4.5225);
case 22: return new CityInfo("Wingene", "VLG", 51.05782, 3.27359);
case 23: return new CityInfo("Willebroek", "VLG", 51.06041, 4.36019);
case 24: return new CityInfo("Wijnegem", "VLG", 51.22787, 4.51895);
case 25: return new CityInfo("Wielsbeke", "VLG", 50.9, 3.36667);
case 26: return new CityInfo("Wichelen", "VLG", 51.00526, 3.97683);
case 27: return new CityInfo("Wezembeek-Oppem", "VLG", 50.8395, 4.49427);
case 28: return new CityInfo("Wevelgem", "VLG", 50.8, 3.16667);
case 29: return new CityInfo("Wetteren", "VLG", 51.00526, 3.88341);
case 30: return new CityInfo("Westerlo", "VLG", 51.09049, 4.91544);
case 31: return new CityInfo("Wervik", "VLG", 50.78069, 3.03854);
case 32: return new CityInfo("Wenduine", "VLG", 51.2983, 3.08213);
case 33: return new CityInfo("Wemmel", "VLG", 50.90812, 4.30613);
case 34: return new CityInfo("Wellin", "WAL", 50.08133, 5.11413);
case 35: return new CityInfo("Wellen", "VLG", 50.84096, 5.33867);
case 36: return new CityInfo("Welkenraedt", "WAL", 50.6605, 5.97034);
case 37: return new CityInfo("Wavre", "WAL", 50.71717, 4.60138);
case 38: return new CityInfo("Waterloo", "WAL", 50.71469, 4.3991);
case 39: return new CityInfo("Wasseiges", "WAL", 50.62186, 5.00528);
case 40: return new CityInfo("Waremme", "WAL", 50.6976, 5.25524);
case 41: return new CityInfo("Waregem", "VLG", 50.88898, 3.42756);
case 42: return new CityInfo("Wanze", "WAL", 50.53907, 5.20846);
case 43: return new CityInfo("Walhain-Saint-Paul", "WAL", 50.62627, 4.69837);
case 44: return new CityInfo("Walcourt", "WAL", 50.25401, 4.43796);
case 45: return new CityInfo("Waimes", "WAL", 50.41488, 6.11207);
case 46: return new CityInfo("Wachtebeke", "VLG", 51.16852, 3.87183);
case 47: return new CityInfo("Waasmunster", "VLG", 51.10572, 4.08573);
case 48: return new CityInfo("Waarschoot", "VLG", 51.1525, 3.605);
case 49: return new CityInfo("Vosselaar", "VLG", 51.30856, 4.8896);
case 50: return new CityInfo("Vorselaar", "VLG", 51.20243, 4.77259);
case 51: return new CityInfo("Visé", "WAL", 50.7376, 5.69907);
case 52: return new CityInfo("Virton", "WAL", 49.56824, 5.53259);
case 53: return new CityInfo("Vilvoorde", "VLG", 50.92814, 4.42938);
case 54: return new CityInfo("Villers-le-Bouillet", "WAL", 50.57708, 5.25945);
case 55: return new CityInfo("Villers-la-Ville", "WAL", 50.56667, 4.51667);
case 56: return new CityInfo("Vielsalm", "WAL", 50.28407, 5.91502);
case 57: return new CityInfo("Veurne", "VLG", 51.07316, 2.66803);
case 58: return new CityInfo("Verviers", "WAL", 50.58907, 5.86241);
case 59: return new CityInfo("Verlaine", "WAL", 50.60743, 5.3174);
case 60: return new CityInfo("Vaux-sur-Sûre", "WAL", 49.911, 5.57848);
case 61: return new CityInfo("Turnhout", "VLG", 51.32254, 4.94471);
case 62: return new CityInfo("Tubize", "WAL", 50.69059, 4.2009);
case 63: return new CityInfo("Trooz", "WAL", 50.57026, 5.69521);
case 64: return new CityInfo("Trois-Ponts", "WAL", 50.37128, 5.87146);
case 65: return new CityInfo("Tremelo", "VLG", 50.99231, 4.70807);
case 66: return new CityInfo("Tournai", "WAL", 50.60715, 3.38932);
case 67: return new CityInfo("Torhout", "VLG", 51.0656, 3.10085);
case 68: return new CityInfo("Tongeren", "VLG", 50.78054, 5.46484);
case 69: return new CityInfo("Tintigny", "WAL", 49.68326, 5.51349);
case 70: return new CityInfo("Tinlot", "WAL", 50.47493, 5.37755);
case 71: return new CityInfo("Tienen", "VLG", 50.80745, 4.9378);
case 72: return new CityInfo("Tielt", "VLG", 50.99931, 3.32707);
case 73: return new CityInfo("Thuin", "WAL", 50.33933, 4.28604);
case 74: return new CityInfo("Theux", "WAL", 50.53323, 5.81245);
case 75: return new CityInfo("Tessenderlo", "VLG", 51.06513, 5.08856);
case 76: return new CityInfo("Tervuren", "VLG", 50.82372, 4.51418);
case 77: return new CityInfo("Ternat", "VLG", 50.86654, 4.16682);
case 78: return new CityInfo("Tenneville", "WAL", 50.09501, 5.52895);
case 79: return new CityInfo("Temse", "VLG", 51.12794, 4.21372);
case 80: return new CityInfo("Tellin", "WAL", 50.08038, 5.21638);
case 81: return new CityInfo("Stoumont", "WAL", 50.40667, 5.80838);
case 82: return new CityInfo("Stekene", "VLG", 51.2099, 4.03651);
case 83: return new CityInfo("Steenokkerzeel", "VLG", 50.91851, 4.50989);
case 84: return new CityInfo("Stavelot", "WAL", 50.395, 5.93124);
case 85: return new CityInfo("Staden", "VLG", 50.97456, 3.01469);
case 86: return new CityInfo("Stabroek", "VLG", 51.33189, 4.37127);
case 87: return new CityInfo("Sprimont", "WAL", 50.50922, 5.6595);
case 88: return new CityInfo("Spa", "WAL", 50.48375, 5.86674);
case 89: return new CityInfo("Soumagne", "WAL", 50.61385, 5.74679);
case 90: return new CityInfo("Somme-Leuze", "WAL", 50.33699, 5.36705);
case 91: return new CityInfo("Sombreffe", "WAL", 50.52865, 4.60087);
case 92: return new CityInfo("Soignies", "WAL", 50.57904, 4.07129);
case 93: return new CityInfo("Sint-Truiden", "VLG", 50.81679, 5.18647);
case 94: return new CityInfo("Sint-Pieters-Leeuw", "VLG", 50.77926, 4.24355);
case 95: return new CityInfo("Sint-Niklaas", "VLG", 51.16509, 4.1437);
case 96: return new CityInfo("Sint-Martens-Lennik", "VLG", 50.81158, 4.16965);
case 97: return new CityInfo("Sint-Martens-Latem", "VLG", 51.01459, 3.63779);
case 98: return new CityInfo("Sint-Maria-Lierde", "VLG", 50.81867, 3.84436);
case 99: return new CityInfo("Sint-Margriete", "VLG", 51.28216, 3.54644);
case 100: return new CityInfo("Sint-Lievens-Houtem", "VLG", 50.9197, 3.86225);
case 101: return new CityInfo("Sint-Laureins", "VLG", 51.24202, 3.52441);
case 102: return new CityInfo("Sint-Kruis", "VLG", 51.21399, 3.24949);
case 103: return new CityInfo("Sint-Katelijne-Waver", "VLG", 51.06691, 4.53469);
case 104: return new CityInfo("Sint-Gillis-Waas", "VLG", 51.21914, 4.12374);
case 105: return new CityInfo("Sint-Genesius-Rode", "VLG", 50.74645, 4.35754);
case 106: return new CityInfo("Sint-Amands", "VLG", 51.05645, 4.20957);
case 107: return new CityInfo("Silly", "WAL", 50.64877, 3.92363);
case 108: return new CityInfo("Seraing", "WAL", 50.58362, 5.50115);
case 109: return new CityInfo("Seneffe", "WAL", 50.53135, 4.26301);
case 110: return new CityInfo("Schoten", "VLG", 51.25251, 4.50268);
case 111: return new CityInfo("Schilde", "VLG", 51.24107, 4.58336);
case 112: return new CityInfo("Schelle", "VLG", 51.12615, 4.34114);
case 113: return new CityInfo("Saint-Yvon", "WAL", 50.74335, 2.90992);
case 114: return new CityInfo("Saint-Vith", "WAL", 50.28146, 6.12724);
case 115: return new CityInfo("Saint-Nicolas", "WAL", 50.62837, 5.53243);
case 116: return new CityInfo("Saint-Léger", "WAL", 49.61196, 5.65688);
case 117: return new CityInfo("Saint-Hubert", "WAL", 50.02668, 5.37401);
case 118: return new CityInfo("Saint-Ghislain", "WAL", 50.44816, 3.81886);
case 119: return new CityInfo("Sainte-Ode", "WAL", 50.01723, 5.51926);
case 120: return new CityInfo("Rumst", "VLG", 51.08153, 4.42217);
case 121: return new CityInfo("Rumes", "WAL", 50.5545, 3.30535);
case 122: return new CityInfo("Ruiselede", "VLG", 51.04039, 3.39416);
case 123: return new CityInfo("Rouvroy", "WAL", 49.53771, 5.49031);
case 124: return new CityInfo("Rotselaar", "VLG", 50.95302, 4.71665);
case 125: return new CityInfo("Ronse", "VLG", 50.74574, 3.6005);
case 126: return new CityInfo("Mons-lez-Liège", "WAL", 50.61667, 5.46667);
case 127: return new CityInfo("Roeulx", "WAL", 50.50365, 4.11163);
case 128: return new CityInfo("Roeselare", "VLG", 50.94653, 3.12269);
case 129: return new CityInfo("Rochefort", "WAL", 50.1631, 5.2216);
case 130: return new CityInfo("Rixensart", "WAL", 50.71229, 4.52529);
case 131: return new CityInfo("Rijkevorsel", "VLG", 51.34795, 4.76053);
case 132: return new CityInfo("Riemst", "VLG", 50.80995, 5.60131);
case 133: return new CityInfo("Retie", "VLG", 51.26652, 5.08242);
case 134: return new CityInfo("Rendeux", "WAL", 50.23423, 5.50414);
case 135: return new CityInfo("Remicourt", "WAL", 50.68069, 5.32785);
case 136: return new CityInfo("Rebecq-Rognon", "WAL", 50.65147, 4.10683);
case 137: return new CityInfo("Ravels", "VLG", 51.37274, 4.9921);
case 138: return new CityInfo("Ranst", "VLG", 51.18983, 4.56533);
case 139: return new CityInfo("Ramillies", "WAL", 50.63395, 4.90119);
case 140: return new CityInfo("Raeren", "WAL", 50.6672, 6.11535);
case 141: return new CityInfo("Quiévrain", "WAL", 50.40737, 3.68351);
case 142: return new CityInfo("Quévy-le-Petit", "WAL", 50.36879, 3.93602);
case 143: return new CityInfo("Quaregnon", "WAL", 50.44067, 3.8653);
case 144: return new CityInfo("Puurs", "VLG", 51.07409, 4.28844);
case 145: return new CityInfo("Putte", "VLG", 51.05337, 4.63263);
case 146: return new CityInfo("Profondeville", "WAL", 50.37581, 4.86506);
case 147: return new CityInfo("Poperinge", "VLG", 50.85386, 2.72659);
case 148: return new CityInfo("Pontillas", "WAL", 50.54916, 5.02101);
case 149: return new CityInfo("Pont-à-Celles", "WAL", 50.50518, 4.36887);
case 150: return new CityInfo("Plombières", "WAL", 50.73656, 5.95922);
case 151: return new CityInfo("Pittem", "VLG", 50.99279, 3.26317);
case 152: return new CityInfo("Philippeville", "WAL", 50.19612, 4.54374);
case 153: return new CityInfo("Perwez", "WAL", 50.62426, 4.81354);
case 154: return new CityInfo("Péruwelz", "WAL", 50.50819, 3.59373);
case 155: return new CityInfo("Perre", "VLG", 50.88914, 3.86098);
case 156: return new CityInfo("Pepinster", "WAL", 50.57375, 5.8049);
case 157: return new CityInfo("Pepingen", "VLG", 50.75922, 4.15983);
case 158: return new CityInfo("Peer", "VLG", 51.1303, 5.45952);
case 159: return new CityInfo("Pecq", "WAL", 50.68619, 3.33789);
case 160: return new CityInfo("Paliseul", "WAL", 49.90395, 5.13537);
case 161: return new CityInfo("Overpelt", "VLG", 51.21038, 5.41557);
case 162: return new CityInfo("Overijse", "VLG", 50.77436, 4.53461);
case 163: return new CityInfo("Oupeye", "WAL", 50.71184, 5.6468);
case 164: return new CityInfo("Ouffet", "WAL", 50.4387, 5.4657);
case 165: return new CityInfo("Oud-Turnhout", "VLG", 51.31978, 4.9841);
case 166: return new CityInfo("Oud-Heverlee", "VLG", 50.83522, 4.66421);
case 167: return new CityInfo("Oudenburg", "VLG", 51.18489, 3.00035);
case 168: return new CityInfo("Oudenaarde", "VLG", 50.85168, 3.60891);
case 169: return new CityInfo("Ottignies", "WAL", 50.66535, 4.56679);
case 170: return new CityInfo("Oreye", "WAL", 50.71749, 5.3488);
case 171: return new CityInfo("Opwijk", "VLG", 50.96724, 4.18442);
case 172: return new CityInfo("Opglabbeek", "VLG", 51.04258, 5.58346);
case 173: return new CityInfo("Oostrozebeke", "VLG", 50.92093, 3.33799);
case 174: return new CityInfo("Oostmalle", "VLG", 51.3, 4.73333);
case 175: return new CityInfo("Oostkamp", "VLG", 51.15432, 3.23128);
case 176: return new CityInfo("Oosterzele", "VLG", 50.95261, 3.79826);
case 177: return new CityInfo("Ostend", "VLG", 51.21551, 2.927);
case 178: return new CityInfo("Oostduinkerke", "VLG", 51.11565, 2.68217);
case 179: return new CityInfo("Onhaye", "WAL", 50.24148, 4.84069);
case 180: return new CityInfo("Olne", "WAL", 50.58994, 5.74662);
case 181: return new CityInfo("Olen", "VLG", 51.14391, 4.8598);
case 182: return new CityInfo("Ohey", "WAL", 50.4357, 5.12375);
case 183: return new CityInfo("Noville-les-Bois", "WAL", 50.55702, 4.98466);
case 184: return new CityInfo("Nivelles", "WAL", 50.59833, 4.32848);
case 185: return new CityInfo("Ninove", "VLG", 50.82776, 4.02657);
case 186: return new CityInfo("Nijlen", "VLG", 51.16096, 4.67008);
case 187: return new CityInfo("Nieuwpoort", "VLG", 51.13008, 2.75135);
case 188: return new CityInfo("Nieuwerkerken", "VLG", 50.8638, 5.19467);
case 189: return new CityInfo("Niel", "VLG", 51.11096, 4.33428);
case 190: return new CityInfo("Nevele", "VLG", 51.03531, 3.54574);
case 191: return new CityInfo("Neufchâteau", "WAL", 49.84074, 5.43535);
case 192: return new CityInfo("Neerpelt", "VLG", 51.22807, 5.4427);
case 193: return new CityInfo("Nazareth", "VLG", 50.95686, 3.59425);
case 194: return new CityInfo("Nassogne", "WAL", 50.12849, 5.34274);
case 195: return new CityInfo("Nandrin", "WAL", 50.50675, 5.41905);
case 196: return new CityInfo("Namur", "WAL", 50.4669, 4.86746);
case 197: return new CityInfo("Musson", "WAL", 49.55835, 5.70525);
case 198: return new CityInfo("Mouscron", "WAL", 50.74497, 3.20639);
case 199: return new CityInfo("Mortsel", "VLG", 51.16697, 4.45127);
case 200: return new CityInfo("Morlanwelz-Mariemont", "WAL", 50.45502, 4.24519);
case 201: return new CityInfo("Moorslede", "VLG", 50.8919, 3.06117);
case 202: return new CityInfo("Mont-Saint-Guibert", "WAL", 50.63427, 4.61061);
case 203: return new CityInfo("Mons", "WAL", 50.45413, 3.95229);
case 204: return new CityInfo("Momignies", "WAL", 50.0271, 4.16519);
case 205: return new CityInfo("Mol", "VLG", 51.19188, 5.11662);
case 206: return new CityInfo("Moerbeke", "VLG", 51.17409, 3.93001);
case 207: return new CityInfo("Modave", "WAL", 50.44614, 5.29532);
case 208: return new CityInfo("Middelkerke", "VLG", 51.18532, 2.82077);
case 209: return new CityInfo("Meulebeke", "VLG", 50.95136, 3.28804);
case 210: return new CityInfo("Mettet", "WAL", 50.32119, 4.66232);
case 211: return new CityInfo("Messancy", "WAL", 49.59201, 5.81879);
case 212: return new CityInfo("Messines", "VLG", 50.76581, 2.89764);
case 213: return new CityInfo("Merksplas", "VLG", 51.35851, 4.86513);
case 214: return new CityInfo("Merelbeke", "VLG", 50.99447, 3.74621);
case 215: return new CityInfo("Merchtem", "VLG", 50.95129, 4.23197);
case 216: return new CityInfo("Merbes-le-Château", "WAL", 50.32449, 4.16489);
case 217: return new CityInfo("Menen", "VLG", 50.79722, 3.12245);
case 218: return new CityInfo("Melle", "VLG", 51.00232, 3.80526);
case 219: return new CityInfo("Meix-devant-Virton", "WAL", 49.60581, 5.48045);
case 220: return new CityInfo("Meise", "VLG", 50.93934, 4.32655);
case 221: return new CityInfo("Meerhout", "VLG", 51.1321, 5.07842);
case 222: return new CityInfo("Mechelen", "VLG", 51.02574, 4.47762);
case 223: return new CityInfo("Martelange", "WAL", 49.83195, 5.73655);
case 224: return new CityInfo("Marchovelette", "WAL", 50.52303, 4.94059);
case 225: return new CityInfo("Marchin", "WAL", 50.46707, 5.2428);
case 226: return new CityInfo("Marche-en-Famenne", "WAL", 50.22678, 5.34416);
case 227: return new CityInfo("Manhay", "WAL", 50.29219, 5.67562);
case 228: return new CityInfo("Manage", "WAL", 50.50312, 4.23589);
case 229: return new CityInfo("Malmédy", "WAL", 50.42686, 6.02794);
case 230: return new CityInfo("Maldegem", "VLG", 51.20737, 3.44511);
case 231: return new CityInfo("Machelen", "VLG", 50.91061, 4.44174);
case 232: return new CityInfo("Maasmechelen", "VLG", 50.96545, 5.69452);
case 233: return new CityInfo("Maaseik", "VLG", 51.09802, 5.78379);
case 234: return new CityInfo("Lummen", "VLG", 50.98772, 5.19121);
case 235: return new CityInfo("Lubbeek", "VLG", 50.88278, 4.83896);
case 236: return new CityInfo("Lovendegem", "VLG", 51.10168, 3.61298);
case 237: return new CityInfo("Louvain-la-Neuve", "WAL", 50.66829, 4.61443);
case 238: return new CityInfo("Lontzen", "WAL", 50.68126, 6.00712);
case 239: return new CityInfo("Londerzeel", "VLG", 51.00468, 4.30304);
case 240: return new CityInfo("Lommel", "VLG", 51.23074, 5.31349);
case 241: return new CityInfo("Lokeren", "VLG", 51.10364, 3.99339);
case 242: return new CityInfo("Lochristi", "VLG", 51.09644, 3.83194);
case 243: return new CityInfo("Lobbes", "WAL", 50.35258, 4.26716);
case 244: return new CityInfo("Lint", "VLG", 51.12707, 4.49669);
case 245: return new CityInfo("Linkebeek", "VLG", 50.76781, 4.33688);
case 246: return new CityInfo("Lincent", "WAL", 50.71222, 5.03654);
case 247: return new CityInfo("Limbourg", "WAL", 50.61222, 5.9412);
case 248: return new CityInfo("Lille", "VLG", 51.24197, 4.82313);
case 249: return new CityInfo("Lier", "VLG", 51.13128, 4.57041);
case 250: return new CityInfo("Lierneux", "WAL", 50.28477, 5.79236);
case 251: return new CityInfo("Liège", "WAL", 50.63373, 5.56749);
case 252: return new CityInfo("Liedekerke", "VLG", 50.86892, 4.08743);
case 253: return new CityInfo("Lichtervelde", "VLG", 51.03333, 3.15);
case 254: return new CityInfo("Libin", "WAL", 49.98107, 5.25612);
case 255: return new CityInfo("Leuven", "VLG", 50.87959, 4.70093);
case 256: return new CityInfo("Lessines", "WAL", 50.71104, 3.83579);
case 257: return new CityInfo("Leopoldsburg", "VLG", 51.11667, 5.25);
case 258: return new CityInfo("Lens", "WAL", 50.55696, 3.89946);
case 259: return new CityInfo("Lendelede", "VLG", 50.88626, 3.23747);
case 260: return new CityInfo("Léglise", "WAL", 49.79985, 5.53652);
case 261: return new CityInfo("Ledegem", "VLG", 50.85785, 3.12409);
case 262: return new CityInfo("Ledeberg", "VLG", 51.03859, 3.74458);
case 263: return new CityInfo("Ledeberg", "VLG", 50.84356, 4.09112);
case 264: return new CityInfo("Lede", "VLG", 50.96626, 3.98594);
case 265: return new CityInfo("Lebbeke", "VLG", 51.00464, 4.13457);
case 266: return new CityInfo("La Roche-en-Ardenne", "WAL", 50.18361, 5.57547);
case 267: return new CityInfo("Landen", "VLG", 50.75267, 5.082);
case 268: return new CityInfo("Lanaken", "VLG", 50.89318, 5.6468);
case 269: return new CityInfo("La Louvière", "WAL", 50.48657, 4.18785);
case 270: return new CityInfo("La Hulpe", "WAL", 50.73091, 4.48577);
case 271: return new CityInfo("La Calamine", "WAL", 50.71809, 6.01107);
case 272: return new CityInfo("La Bruyère", "WAL", 50.39478, 4.61444);
case 273: return new CityInfo("Laarne", "VLG", 51.03078, 3.85077);
case 274: return new CityInfo("Kuurne", "VLG", 50.85143, 3.2824);
case 275: return new CityInfo("Kruishoutem", "VLG", 50.90168, 3.52588);
case 276: return new CityInfo("Kruibeke", "VLG", 51.17048, 4.31444);
case 277: return new CityInfo("Kraainem", "VLG", 50.86155, 4.46946);
case 278: return new CityInfo("Kortrijk", "VLG", 50.82803, 3.26487);
case 279: return new CityInfo("Kortessem", "VLG", 50.8589, 5.38974);
case 280: return new CityInfo("Kortenberg", "VLG", 50.88982, 4.54353);
case 281: return new CityInfo("Kortenaken", "VLG", 50.90862, 5.05968);
case 282: return new CityInfo("Kortemark", "VLG", 51.02951, 3.04112);
case 283: return new CityInfo("Kontich", "VLG", 51.13213, 4.44706);
case 284: return new CityInfo("Koksijde", "VLG", 51.11642, 2.63772);
case 285: return new CityInfo("Koekelare", "VLG", 51.09047, 2.9783);
case 286: return new CityInfo("Knokke-Heist", "VLG", 51.35, 3.26667);
case 287: return new CityInfo("Knesselare", "VLG", 51.13932, 3.41282);
case 288: return new CityInfo("Kinrooi", "VLG", 51.14543, 5.74207);
case 289: return new CityInfo("Keerbergen", "VLG", 51.00295, 4.63434);
case 290: return new CityInfo("Kasterlee", "VLG", 51.24118, 4.96651);
case 291: return new CityInfo("Kaprijke", "VLG", 51.2172, 3.61519);
case 292: return new CityInfo("Kapelle-op-den-Bos", "VLG", 51.0097, 4.36303);
case 293: return new CityInfo("Kapellen", "VLG", 51.31377, 4.43539);
case 294: return new CityInfo("Kampenhout", "VLG", 50.9421, 4.55103);
case 295: return new CityInfo("Kalmthout", "VLG", 51.38442, 4.47556);
case 296: return new CityInfo("Jurbise", "WAL", 50.531, 3.90942);
case 297: return new CityInfo("Juprelle", "WAL", 50.7076, 5.53127);
case 298: return new CityInfo("Jodoigne", "WAL", 50.72357, 4.86914);
case 299: return new CityInfo("Jalhay", "WAL", 50.55876, 5.96764);
case 300: return new CityInfo("Jabbeke", "VLG", 51.18185, 3.08935);
case 301: return new CityInfo("Izegem", "VLG", 50.91396, 3.21378);
case 302: return new CityInfo("Ittre", "WAL", 50.64396, 4.26476);
case 303: return new CityInfo("Ingelmunster", "VLG", 50.92081, 3.25571);
case 304: return new CityInfo("Incourt", "WAL", 50.69151, 4.79816);
case 305: return new CityInfo("Ieper", "VLG", 50.85114, 2.88569);
case 306: return new CityInfo("Ichtegem", "VLG", 51.09572, 3.01549);
case 307: return new CityInfo("Huy", "WAL", 50.51894, 5.23284);
case 308: return new CityInfo("Hulshout", "VLG", 51.07451, 4.79081);
case 309: return new CityInfo("Huldenberg", "VLG", 50.78939, 4.5831);
case 310: return new CityInfo("Hove", "VLG", 51.15446, 4.4707);
case 311: return new CityInfo("Houyet", "WAL", 50.18619, 5.00762);
case 312: return new CityInfo("Houthulst", "VLG", 50.97824, 2.9505);
case 313: return new CityInfo("Houthalen", "VLG", 51.03427, 5.37429);
case 314: return new CityInfo("Houffalize", "WAL", 50.13235, 5.78962);
case 315: return new CityInfo("Hotton", "WAL", 50.26742, 5.44609);
case 316: return new CityInfo("Hoogstraten", "VLG", 51.40029, 4.76034);
case 317: return new CityInfo("Hooglede", "VLG", 50.98333, 3.08333);
case 318: return new CityInfo("Holsbeek", "VLG", 50.92097, 4.75747);
case 319: return new CityInfo("Hoeselt", "VLG", 50.84714, 5.48767);
case 320: return new CityInfo("Hoeilaart", "VLG", 50.7673, 4.46835);
case 321: return new CityInfo("Hoegaarden", "VLG", 50.7756, 4.88952);
case 322: return new CityInfo("Hoboken", "VLG", 51.17611, 4.34844);
case 323: return new CityInfo("Hingeon", "WAL", 50.52576, 5.00719);
case 324: return new CityInfo("Heusden", "VLG", 51.03664, 5.28013);
case 325: return new CityInfo("Herzele", "VLG", 50.88681, 3.89014);
case 326: return new CityInfo("Herve", "WAL", 50.64083, 5.79353);
case 327: return new CityInfo("Herstal", "WAL", 50.66415, 5.62346);
case 328: return new CityInfo("Herselt", "VLG", 51.05159, 4.88231);
case 329: return new CityInfo("Héron", "WAL", 50.54731, 5.09774);
case 330: return new CityInfo("Herne", "VLG", 50.72423, 4.03481);
case 331: return new CityInfo("Herk-de-Stad", "VLG", 50.94013, 5.16636);
case 332: return new CityInfo("Herenthout", "VLG", 51.1401, 4.75572);
case 333: return new CityInfo("Herentals", "VLG", 51.17655, 4.83248);
case 334: return new CityInfo("Herent", "VLG", 50.90861, 4.67056);
case 335: return new CityInfo("Herbeumont", "WAL", 49.78086, 5.2358);
case 336: return new CityInfo("Hensies", "WAL", 50.43263, 3.68411);
case 337: return new CityInfo("Hemptinne", "WAL", 50.60291, 4.98848);
case 338: return new CityInfo("Hemiksem", "VLG", 51.14484, 4.33874);
case 339: return new CityInfo("Helchteren", "VLG", 51.05591, 5.38244);
case 340: return new CityInfo("Heist-op-den-Berg", "VLG", 51.07537, 4.72827);
case 341: return new CityInfo("Heers", "VLG", 50.75383, 5.3021);
case 342: return new CityInfo("Havelange", "WAL", 50.38931, 5.23816);
case 343: return new CityInfo("Hastière-Lavaux", "WAL", 50.21849, 4.82446);
case 344: return new CityInfo("Hasselt", "VLG", 50.93106, 5.33781);
case 345: return new CityInfo("Harelbeke", "VLG", 50.85343, 3.30935);
case 346: return new CityInfo("Hannut", "WAL", 50.67142, 5.07898);
case 347: return new CityInfo("Hamois", "WAL", 50.3402, 5.15619);
case 348: return new CityInfo("Hamoir", "WAL", 50.42675, 5.53304);
case 349: return new CityInfo("Hamme", "VLG", 51.09822, 4.13705);
case 350: return new CityInfo("Halle", "VLG", 50.73385, 4.23454);
case 351: return new CityInfo("Halen", "VLG", 50.94837, 5.11096);
case 352: return new CityInfo("Habay-la-Vieille", "WAL", 49.72329, 5.61999);
case 353: return new CityInfo("Haaltert", "VLG", 50.90634, 4.00093);
case 354: return new CityInfo("Haacht", "VLG", 50.97737, 4.63777);
case 355: return new CityInfo("Grobbendonk", "VLG", 51.19043, 4.73562);
case 356: return new CityInfo("Grimbergen", "VLG", 50.93409, 4.37213);
case 357: return new CityInfo("Grez-Doiceau", "WAL", 50.73901, 4.69829);
case 358: return new CityInfo("Gouvy", "WAL", 50.186, 5.93917);
case 359: return new CityInfo("Gooik", "VLG", 50.79443, 4.11378);
case 360: return new CityInfo("Glabbeek", "VLG", 50.87267, 4.95615);
case 361: return new CityInfo("Gistel", "VLG", 51.15612, 2.96387);
case 362: return new CityInfo("Gingelom", "VLG", 50.74792, 5.13422);
case 363: return new CityInfo("Gesves", "WAL", 50.40146, 5.07457);
case 364: return new CityInfo("Gerpinnes", "WAL", 50.33789, 4.52731);
case 365: return new CityInfo("Geraardsbergen", "VLG", 50.77343, 3.88223);
case 366: return new CityInfo("Gent", "VLG", 51.05, 3.71667);
case 367: return new CityInfo("Genk", "VLG", 50.965, 5.50082);
case 368: return new CityInfo("Genappe", "WAL", 50.61173, 4.45152);
case 369: return new CityInfo("Gembloux", "WAL", 50.56149, 4.69889);
case 370: return new CityInfo("Geetbets", "VLG", 50.89431, 5.11199);
case 371: return new CityInfo("Geer", "WAL", 50.6699, 5.17364);
case 372: return new CityInfo("Geel", "VLG", 51.16557, 4.98917);
case 373: return new CityInfo("Gedinne", "WAL", 49.98037, 4.93674);
case 374: return new CityInfo("Gavere", "VLG", 50.92917, 3.66184);
case 375: return new CityInfo("Galmaarden", "VLG", 50.75389, 3.97121);
case 376: return new CityInfo("Froidchapelle", "WAL", 50.15106, 4.32742);
case 377: return new CityInfo("Frasnes-lez-Buissenal", "WAL", 50.66783, 3.62047);
case 378: return new CityInfo("Frameries", "WAL", 50.40578, 3.89603);
case 379: return new CityInfo("Sint-Pieters-Voeren", "VLG", 50.73863, 5.82224);
case 380: return new CityInfo("Fosses-la-Ville", "WAL", 50.39517, 4.69623);
case 381: return new CityInfo("Forville", "WAL", 50.57424, 4.99861);
case 382: return new CityInfo("Florenville", "WAL", 49.69983, 5.3074);
case 383: return new CityInfo("Florennes", "WAL", 50.25127, 4.60636);
case 384: return new CityInfo("Floreffe", "WAL", 50.43452, 4.7596);
case 385: return new CityInfo("Flobecq", "WAL", 50.73733, 3.73876);
case 386: return new CityInfo("Fleurus", "WAL", 50.48351, 4.55006);
case 387: return new CityInfo("Fléron", "WAL", 50.61516, 5.68062);
case 388: return new CityInfo("Flémalle-Haute", "WAL", 50.59994, 5.44471);
case 389: return new CityInfo("Fexhe-le-Haut-Clocher", "WAL", 50.6654, 5.39978);
case 390: return new CityInfo("Ferrières", "WAL", 50.40157, 5.61092);
case 391: return new CityInfo("Fauvillers", "WAL", 49.85116, 5.66405);
case 392: return new CityInfo("Farciennes", "WAL", 50.43006, 4.54152);
case 393: return new CityInfo("Faimes", "WAL", 50.66252, 5.26005);
case 394: return new CityInfo("Evergem", "VLG", 51.11306, 3.70976);
case 395: return new CityInfo("Eupen", "WAL", 50.6279, 6.03647);
case 396: return new CityInfo("Étalle", "WAL", 49.67385, 5.60019);
case 397: return new CityInfo("Estinnes-au-Val", "WAL", 50.41016, 4.10477);
case 398: return new CityInfo("Estaimpuis", "WAL", 50.70485, 3.26785);
case 399: return new CityInfo("Essen", "VLG", 51.46791, 4.46901);
case 400: return new CityInfo("Esneux", "WAL", 50.53596, 5.56775);
case 401: return new CityInfo("Erquelinnes", "WAL", 50.30688, 4.11129);
case 402: return new CityInfo("Érezée", "WAL", 50.29292, 5.55815);
case 403: return new CityInfo("Engis", "WAL", 50.58156, 5.39916);
case 404: return new CityInfo("Enghien", "WAL", 50.68373, 4.03284);
case 405: return new CityInfo("Ellezelles", "WAL", 50.73512, 3.67985);
case 406: return new CityInfo("Éghezée", "WAL", 50.59076, 4.91175);
case 407: return new CityInfo("Eeklo", "VLG", 51.18703, 3.55654);
case 408: return new CityInfo("Edegem", "VLG", 51.15662, 4.44504);
case 409: return new CityInfo("Écaussinnes-d'Enghien", "WAL", 50.56822, 4.1658);
case 410: return new CityInfo("Durbuy", "WAL", 50.35291, 5.45631);
case 411: return new CityInfo("Duffel", "VLG", 51.09554, 4.50903);
case 412: return new CityInfo("Drogenbos", "VLG", 50.78733, 4.31471);
case 413: return new CityInfo("Dour", "WAL", 50.39583, 3.77792);
case 414: return new CityInfo("Donceel", "WAL", 50.64827, 5.32);
case 415: return new CityInfo("Doische", "WAL", 50.13356, 4.73545);
case 416: return new CityInfo("Dison", "WAL", 50.61004, 5.8534);
case 417: return new CityInfo("Dinant", "WAL", 50.25807, 4.91166);
case 418: return new CityInfo("Dilbeek", "VLG", 50.84799, 4.25972);
case 419: return new CityInfo("Diksmuide", "VLG", 51.03248, 2.86384);
case 420: return new CityInfo("Diest", "VLG", 50.98923, 5.05062);
case 421: return new CityInfo("Diepenbeek", "VLG", 50.90769, 5.41875);
case 422: return new CityInfo("Diegem", "VLG", 50.89727, 4.43354);
case 423: return new CityInfo("Deurne", "VLG", 51.22134, 4.46595);
case 424: return new CityInfo("Destelbergen", "VLG", 51.05952, 3.79899);
case 425: return new CityInfo("Dessel", "VLG", 51.23855, 5.11448);
case 426: return new CityInfo("De Pinte", "VLG", 50.99339, 3.64747);
case 427: return new CityInfo("De Panne", "VLG", 51.09793, 2.59368);
case 428: return new CityInfo("Dentergem", "VLG", 50.96429, 3.41617);
case 429: return new CityInfo("Dendermonde", "VLG", 51.02869, 4.10106);
case 430: return new CityInfo("Denderleeuw", "VLG", 50.88506, 4.07601);
case 431: return new CityInfo("Deinze", "VLG", 50.98175, 3.53096);
case 432: return new CityInfo("De Haan", "VLG", 51.27261, 3.03446);
case 433: return new CityInfo("Deerlijk", "VLG", 50.85337, 3.35416);
case 434: return new CityInfo("Daverdisse", "WAL", 50.02161, 5.11811);
case 435: return new CityInfo("Damme", "VLG", 51.25147, 3.28144);
case 436: return new CityInfo("Dalhem", "WAL", 50.71315, 5.72774);
case 437: return new CityInfo("Crisnée", "WAL", 50.71703, 5.39802);
case 438: return new CityInfo("Couvin", "WAL", 50.05284, 4.49495);
case 439: return new CityInfo("Court-Saint-Étienne", "WAL", 50.63378, 4.56851);
case 440: return new CityInfo("Courcelles", "WAL", 50.46379, 4.3747);
case 441: return new CityInfo("Cortil-Wodon", "WAL", 50.56804, 4.95712);
case 442: return new CityInfo("Comblain-au-Pont", "WAL", 50.47488, 5.57711);
case 443: return new CityInfo("Colfontaine", "WAL", 50.4141, 3.85569);
case 444: return new CityInfo("Clavier", "WAL", 50.40069, 5.35154);
case 445: return new CityInfo("Ciney", "WAL", 50.29449, 5.10015);
case 446: return new CityInfo("Chiny", "WAL", 49.73833, 5.34104);
case 447: return new CityInfo("Chimay", "WAL", 50.04856, 4.31712);
case 448: return new CityInfo("Chièvres", "WAL", 50.58787, 3.80711);
case 449: return new CityInfo("Chaumont-Gistoux", "WAL", 50.67753, 4.7212);
case 450: return new CityInfo("Chaudfontaine", "WAL", 50.5828, 5.6341);
case 451: return new CityInfo("Châtelet", "WAL", 50.40338, 4.52826);
case 452: return new CityInfo("Chastre-Villeroux-Blanmont", "WAL", 50.60857, 4.64198);
case 453: return new CityInfo("Chasse Royale", "WAL", 50.42842, 3.95001);
case 454: return new CityInfo("Charleroi", "WAL", 50.41136, 4.44448);
case 455: return new CityInfo("Chapelle-lez-Herlaimont", "WAL", 50.4713, 4.28227);
case 456: return new CityInfo("Cerfontaine", "WAL", 50.17047, 4.41028);
case 457: return new CityInfo("Celles", "WAL", 50.71229, 3.45733);
case 458: return new CityInfo("Butgenbach", "WAL", 50.42689, 6.20504);
case 459: return new CityInfo("Burdinne", "WAL", 50.58454, 5.07663);
case 460: return new CityInfo("Bullange", "WAL", 50.40731, 6.25749);
case 461: return new CityInfo("Buggenhout", "VLG", 51.0159, 4.20173);
case 462: return new CityInfo("Brussels", "BRU", 50.85045, 4.34878);
case 463: return new CityInfo("Brunehault", "WAL", 50.50524, 4.43209);
case 464: return new CityInfo("Brugge", "VLG", 51.20892, 3.22424);
case 465: return new CityInfo("Brugelette", "WAL", 50.59577, 3.85363);
case 466: return new CityInfo("Bree", "VLG", 51.14152, 5.5969);
case 467: return new CityInfo("Bredene", "VLG", 51.23489, 2.97559);
case 468: return new CityInfo("Brecht", "VLG", 51.35024, 4.63829);
case 469: return new CityInfo("Brasschaat", "VLG", 51.2912, 4.49182);
case 470: return new CityInfo("Braives", "WAL", 50.61745, 5.13302);
case 471: return new CityInfo("Braine-le-Comte", "WAL", 50.60979, 4.14658);
case 472: return new CityInfo("Braine-le-Château", "WAL", 50.6799, 4.27385);
case 473: return new CityInfo("Braine-l'Alleud", "WAL", 50.68363, 4.36784);
case 474: return new CityInfo("Boutersem", "VLG", 50.83511, 4.8345);
case 475: return new CityInfo("Boussu", "WAL", 50.43417, 3.7944);
case 476: return new CityInfo("Bouillon", "WAL", 49.79324, 5.06703);
case 477: return new CityInfo("Borsbeek", "VLG", 51.19661, 4.48543);
case 478: return new CityInfo("Bornem", "VLG", 51.09716, 4.24364);
case 479: return new CityInfo("Borgloon", "VLG", 50.80505, 5.34366);
case 480: return new CityInfo("Boortmeerbeek", "VLG", 50.97929, 4.57443);
case 481: return new CityInfo("Boom", "VLG", 51.09242, 4.3717);
case 482: return new CityInfo("Bonheiden", "VLG", 51.02261, 4.54714);
case 483: return new CityInfo("Boechout", "VLG", 51.15959, 4.49195);
case 484: return new CityInfo("Bocholt", "VLG", 51.17337, 5.57994);
case 485: return new CityInfo("Blégny", "WAL", 50.67255, 5.72508);
case 486: return new CityInfo("Blankenberge", "VLG", 51.31306, 3.13227);
case 487: return new CityInfo("Binche", "WAL", 50.41155, 4.16469);
case 488: return new CityInfo("Bilzen", "VLG", 50.87325, 5.5184);
case 489: return new CityInfo("Bièvre", "WAL", 49.94085, 5.01591);
case 490: return new CityInfo("Bierbeek", "VLG", 50.82876, 4.75949);
case 491: return new CityInfo("Beyne-Heusay", "WAL", 50.62251, 5.66508);
case 492: return new CityInfo("Beveren", "VLG", 51.21187, 4.25633);
case 493: return new CityInfo("Bever", "VLG", 50.91667, 4.31667);
case 494: return new CityInfo("Bertrix", "WAL", 49.85596, 5.25539);
case 495: return new CityInfo("Bertogne", "WAL", 50.08364, 5.66689);
case 496: return new CityInfo("Bertem", "VLG", 50.86403, 4.62918);
case 497: return new CityInfo("Bernissart", "WAL", 50.4746, 3.64961);
case 498: return new CityInfo("Berloz", "WAL", 50.69829, 5.21236);
case 499: return new CityInfo("Berlare", "VLG", 51.03333, 4);
case 500: return new CityInfo("Berlaar", "VLG", 51.1176, 4.65835);
case 501: return new CityInfo("Beringen", "VLG", 51.04954, 5.22606);
case 502: return new CityInfo("Beloeil", "WAL", 50.55047, 3.73484);
case 503: return new CityInfo("Bekkevoort", "VLG", 50.94074, 4.969);
case 504: return new CityInfo("Begijnendijk", "VLG", 51.01942, 4.78377);
case 505: return new CityInfo("Beersel", "VLG", 50.76589, 4.3002);
case 506: return new CityInfo("Beerse", "VLG", 51.31927, 4.85304);
case 507: return new CityInfo("Beernem", "VLG", 51.13981, 3.33896);
case 508: return new CityInfo("Beauvechain", "WAL", 50.78195, 4.7718);
case 509: return new CityInfo("Beauraing", "WAL", 50.11042, 4.95554);
case 510: return new CityInfo("Beaumont", "WAL", 50.23699, 4.23926);
case 511: return new CityInfo("Bastogne", "WAL", 50.00347, 5.71844);
case 512: return new CityInfo("Bassenge", "WAL", 50.75883, 5.60989);
case 513: return new CityInfo("Basse Lasne", "WAL", 50.69503, 4.49218);
case 514: return new CityInfo("Balen", "VLG", 51.16837, 5.17027);
case 515: return new CityInfo("Baelen", "WAL", 50.63131, 5.97433);
case 516: return new CityInfo("Baarle-Hertog", "VLG", 51.40504, 4.89226);
case 517: return new CityInfo("Aywaille", "WAL", 50.47411, 5.67684);
case 518: return new CityInfo("Awans", "WAL", 50.66774, 5.46329);
case 519: return new CityInfo("Avelgem", "VLG", 50.77618, 3.44502);
case 520: return new CityInfo("Aubel", "WAL", 50.70189, 5.85812);
case 521: return new CityInfo("Aubange", "WAL", 49.56652, 5.80492);
case 522: return new CityInfo("Attert", "WAL", 49.75035, 5.78634);
case 523: return new CityInfo("Ath", "WAL", 50.62937, 3.77801);
case 524: return new CityInfo("Assesse", "WAL", 50.36934, 5.02204);
case 525: return new CityInfo("Assenede", "VLG", 51.22598, 3.75085);
case 526: return new CityInfo("Asse", "VLG", 50.91011, 4.19836);
case 527: return new CityInfo("As", "VLG", 51.00755, 5.58453);
case 528: return new CityInfo("Arlon", "WAL", 49.68333, 5.81667);
case 529: return new CityInfo("Arendonk", "VLG", 51.32267, 5.08289);
case 530: return new CityInfo("Ardooie", "VLG", 50.9757, 3.19736);
case 531: return new CityInfo("Anzegem", "VLG", 50.837, 3.47786);
case 532: return new CityInfo("Antwerpen", "VLG", 51.22047, 4.40026);
case 533: return new CityInfo("Antoing", "WAL", 50.56765, 3.4492);
case 534: return new CityInfo("Anthisnes", "WAL", 50.48323, 5.519);
case 535: return new CityInfo("Ans", "WAL", 50.6623, 5.52029);
case 536: return new CityInfo("Anhée", "WAL", 50.31039, 4.87827);
case 537: return new CityInfo("Anderlues", "WAL", 50.40704, 4.27136);
case 538: return new CityInfo("Andenne", "WAL", 50.48941, 5.09513);
case 539: return new CityInfo("Amblève", "WAL", 50.35357, 6.17002);
case 540: return new CityInfo("Amay", "WAL", 50.54829, 5.30974);
case 541: return new CityInfo("Alveringem", "VLG", 51.01238, 2.71117);
case 542: return new CityInfo("Alken", "VLG", 50.87553, 5.30558);
case 543: return new CityInfo("Aiseau", "WAL", 50.41158, 4.58671);
case 544: return new CityInfo("Aartselaar", "VLG", 51.13412, 4.38678);
case 545: return new CityInfo("Aarschot", "VLG", 50.98715, 4.83695);
case 546: return new CityInfo("Aalter", "VLG", 51.09017, 3.44693);
case 547: return new CityInfo("Aalst", "VLG", 50.93604, 4.0355);
case 548: return new CityInfo("Frasnes-lez-Anvaing", "WAL", 50.69211, 3.63562);
case 549: return new CityInfo("Chastre", "WAL", 50.60067, 4.634);
case 550: return new CityInfo("Lennik", "VLG", 50.80903, 4.16219);
case 551: return new CityInfo("Laakdal", "VLG", 51.08067, 5.00556);
case 552: return new CityInfo("Scherpenheuvel-Zichem", "VLG", 51.01041, 4.97492);
case 553: return new CityInfo("Sint-Joris", "VLG", 50.87117, 5.272);
default: return new CityInfo("Terkoest", "VLG", 50.89832, 5.27623);

                                    }                                        
                                }
                            
                        }
                    }
                