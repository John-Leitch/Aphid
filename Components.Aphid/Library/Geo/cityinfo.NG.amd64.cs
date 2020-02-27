
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
                                    public const string Country = "NG";
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
                            
                                        var cur = (Math.Abs(11.43522 - lat) + Math.Abs(5.23494 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(12.77675 - lat) + Math.Abs(6.78404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.80726 - lat) + Math.Abs(6.15238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.78453 - lat) + Math.Abs(8.29056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.99064 - lat) + Math.Abs(11.74763 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.11128 - lat) + Math.Abs(7.7227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.05313 - lat) + Math.Abs(8.48574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.61432 - lat) + Math.Abs(10.17647 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.10033 - lat) + Math.Abs(8.88524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.50671 - lat) + Math.Abs(9.6104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.4496 - lat) + Math.Abs(10.3672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.69707 - lat) + Math.Abs(10.2735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.20839 - lat) + Math.Abs(12.48146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.92675 - lat) + Math.Abs(6.26764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.83505 - lat) + Math.Abs(4.74244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.83333 - lat) + Math.Abs(9.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.76794 - lat) + Math.Abs(3.398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.36308 - lat) + Math.Abs(9.04235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.5071 - lat) + Math.Abs(10.7459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.11161 - lat) + Math.Abs(9.82604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.38623 - lat) + Math.Abs(12.71992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.72217 - lat) + Math.Abs(5.01329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.38522 - lat) + Math.Abs(11.69678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.73035 - lat) + Math.Abs(6.07305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.29048 - lat) + Math.Abs(5.42373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.87139 - lat) + Math.Abs(9.77786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.80937 - lat) + Math.Abs(8.84422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.90222 - lat) + Math.Abs(4.41917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.09424 - lat) + Math.Abs(9.95605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.3764 - lat) + Math.Abs(5.79536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.51737 - lat) + Math.Abs(5.75006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.56384 - lat) + Math.Abs(8.88534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.94153 - lat) + Math.Abs(8.60315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.03054 - lat) + Math.Abs(5.10433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.68781 - lat) + Math.Abs(7.19579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.7291 - lat) + Math.Abs(8.79138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.78481 - lat) + Math.Abs(9.06799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.05127 - lat) + Math.Abs(7.9335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.00485 - lat) + Math.Abs(7.61028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.54692 - lat) + Math.Abs(6.22649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.38429 - lat) + Math.Abs(5.60984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.90016 - lat) + Math.Abs(6.84312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.85397 - lat) + Math.Abs(7.09906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.7 - lat) + Math.Abs(6.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.65832 - lat) + Math.Abs(8.05868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.94211 - lat) + Math.Abs(6.92931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.09171 - lat) + Math.Abs(8.49531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.33558 - lat) + Math.Abs(7.15187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.26549 - lat) + Math.Abs(6.30962 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.50789 - lat) + Math.Abs(7.09743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.68786 - lat) + Math.Abs(7.24334 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.52491 - lat) + Math.Abs(7.49461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.21407 - lat) + Math.Abs(6.96657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.83122 - lat) + Math.Abs(5.82494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.48956 - lat) + Math.Abs(6.00407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.80865 - lat) + Math.Abs(8.08098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.507 - lat) + Math.Abs(9.34804 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.93576 - lat) + Math.Abs(7.0793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.31592 - lat) + Math.Abs(7.42086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.65581 - lat) + Math.Abs(6.38494 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.45509 - lat) + Math.Abs(13.22233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.59367 - lat) + Math.Abs(5.54391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.24848 - lat) + Math.Abs(8.40109 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.29559 - lat) + Math.Abs(7.98654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.11733 - lat) + Math.Abs(12.04611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.3876 - lat) + Math.Abs(7.07751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.05889 - lat) + Math.Abs(9.0691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.22135 - lat) + Math.Abs(13.48783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.05789 - lat) + Math.Abs(8.27309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.0706 - lat) + Math.Abs(6.1906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.55336 - lat) + Math.Abs(3.44654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.22712 - lat) + Math.Abs(9.28306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.40592 - lat) + Math.Abs(4.64605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.56841 - lat) + Math.Abs(6.06225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.96843 - lat) + Math.Abs(11.67945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.26667 - lat) + Math.Abs(9.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.08821 - lat) + Math.Abs(4.0152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.57569 - lat) + Math.Abs(9.1088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.76017 - lat) + Math.Abs(9.55172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.46667 - lat) + Math.Abs(3.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.50153 - lat) + Math.Abs(3.35808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.53011 - lat) + Math.Abs(8.95593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.66686 - lat) + Math.Abs(9.22828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.18059 - lat) + Math.Abs(7.17939 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.82675 - lat) + Math.Abs(12.6238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.06269 - lat) + Math.Abs(5.24322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.98133 - lat) + Math.Abs(8.05749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.53589 - lat) + Math.Abs(5.16005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.03921 - lat) + Math.Abs(4.84593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.53891 - lat) + Math.Abs(3.3742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.07296 - lat) + Math.Abs(6.50574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.87866 - lat) + Math.Abs(9.53464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.89647 - lat) + Math.Abs(12.00572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.82329 - lat) + Math.Abs(4.97637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.05154 - lat) + Math.Abs(7.992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.21824 - lat) + Math.Abs(12.06059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.21374 - lat) + Math.Abs(4.57941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.66762 - lat) + Math.Abs(3.39393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.62727 - lat) + Math.Abs(4.99295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.8485 - lat) + Math.Abs(3.64633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.50673 - lat) + Math.Abs(12.33315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.50574 - lat) + Math.Abs(11.3631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.72655 - lat) + Math.Abs(6.78374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.02094 - lat) + Math.Abs(7.11244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.89405 - lat) + Math.Abs(5.67666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.54753 - lat) + Math.Abs(9.22258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.5353 - lat) + Math.Abs(9.65223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.96163 - lat) + Math.Abs(8.36017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.34873 - lat) + Math.Abs(9.63989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.06513 - lat) + Math.Abs(5.5961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.15915 - lat) + Math.Abs(6.19666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.41075 - lat) + Math.Abs(7.41456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.3595 - lat) + Math.Abs(10.6732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.17372 - lat) + Math.Abs(7.12113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.90231 - lat) + Math.Abs(5.93117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.56387 - lat) + Math.Abs(6.32355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.44788 - lat) + Math.Abs(7.30918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.8626 - lat) + Math.Abs(7.23469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.65862 - lat) + Math.Abs(8.26505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.55237 - lat) + Math.Abs(7.82253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.63681 - lat) + Math.Abs(8.75694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.90844 - lat) + Math.Abs(9.61688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.74025 - lat) + Math.Abs(8.74128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.15143 - lat) + Math.Abs(9.16216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.9672 - lat) + Math.Abs(8.2476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.8503 - lat) + Math.Abs(7.70974 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.10389 - lat) + Math.Abs(5.25556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.39637 - lat) + Math.Abs(5.48631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.55684 - lat) + Math.Abs(8.58065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.26938 - lat) + Math.Abs(14.46552 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.41227 - lat) + Math.Abs(8.68748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.12257 - lat) + Math.Abs(5.50762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.71391 - lat) + Math.Abs(11.08108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.77742 - lat) + Math.Abs(7.0134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.98433 - lat) + Math.Abs(10.95229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.72851 - lat) + Math.Abs(5.75561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.22885 - lat) + Math.Abs(6.19139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.40756 - lat) + Math.Abs(9.21481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.94504 - lat) + Math.Abs(11.51176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.32541 - lat) + Math.Abs(9.4352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.43685 - lat) + Math.Abs(6.63357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.95753 - lat) + Math.Abs(6.85305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.85257 - lat) + Math.Abs(3.93125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79976 - lat) + Math.Abs(5.33242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.05 - lat) + Math.Abs(4.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.2809 - lat) + Math.Abs(5.0194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.94851 - lat) + Math.Abs(3.50561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.1962 - lat) + Math.Abs(5.58681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.48363 - lat) + Math.Abs(7.03325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.19414 - lat) + Math.Abs(5.02264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.18267 - lat) + Math.Abs(6.19902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.33908 - lat) + Math.Abs(6.84636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.98858 - lat) + Math.Abs(5.12291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.10168 - lat) + Math.Abs(7.65945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.43818 - lat) + Math.Abs(5.87829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.45341 - lat) + Math.Abs(5.8693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.20639 - lat) + Math.Abs(3.40786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.68867 - lat) + Math.Abs(3.23202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.94783 - lat) + Math.Abs(4.78836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.58538 - lat) + Math.Abs(4.62263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.77104 - lat) + Math.Abs(4.55698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.55504 - lat) + Math.Abs(3.34363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.5411 - lat) + Math.Abs(7.26845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.82171 - lat) + Math.Abs(8.23504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.61667 - lat) + Math.Abs(7.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.79565 - lat) + Math.Abs(7.03513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.55 - lat) + Math.Abs(3.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.63747 - lat) + Math.Abs(5.89013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.74716 - lat) + Math.Abs(4.8761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.80604 - lat) + Math.Abs(6.08016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.51388 - lat) + Math.Abs(7.53794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.56851 - lat) + Math.Abs(7.55262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.78223 - lat) + Math.Abs(7.43319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.88209 - lat) + Math.Abs(6.67585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.14978 - lat) + Math.Abs(6.78569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.09316 - lat) + Math.Abs(4.83528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.75833 - lat) + Math.Abs(5.72227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.13857 - lat) + Math.Abs(5.1026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.34388 - lat) + Math.Abs(6.65684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.6 - lat) + Math.Abs(4.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.46186 - lat) + Math.Abs(6.20624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.03911 - lat) + Math.Abs(7.81225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.77743 - lat) + Math.Abs(7.21794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.21667 - lat) + Math.Abs(3.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.74215 - lat) + Math.Abs(7.08368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.59679 - lat) + Math.Abs(8.63728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.21626 - lat) + Math.Abs(7.56022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.54077 - lat) + Math.Abs(7.74858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.84918 - lat) + Math.Abs(8.12564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.192 - lat) + Math.Abs(7.89531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.82917 - lat) + Math.Abs(7.35056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.58263 - lat) + Math.Abs(4.71622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.55122 - lat) + Math.Abs(6.23589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.81667 - lat) + Math.Abs(4.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.95 - lat) + Math.Abs(4.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.03453 - lat) + Math.Abs(3.34759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.13895 - lat) + Math.Abs(7.13915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.64314 - lat) + Math.Abs(5.75943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.73488 - lat) + Math.Abs(5.39447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.46012 - lat) + Math.Abs(5.80174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.84526 - lat) + Math.Abs(8.41914 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.05842 - lat) + Math.Abs(6.86124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.25563 - lat) + Math.Abs(7.27025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.61455 - lat) + Math.Abs(7.81191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.17811 - lat) + Math.Abs(6.52461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.71044 - lat) + Math.Abs(6.80936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.78636 - lat) + Math.Abs(6.95017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.89635 - lat) + Math.Abs(7.06229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.72247 - lat) + Math.Abs(7.19859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.6584 - lat) + Math.Abs(8.79923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.15209 - lat) + Math.Abs(6.86343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.13373 - lat) + Math.Abs(4.24014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.73948 - lat) + Math.Abs(4.16102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.67295 - lat) + Math.Abs(7.37441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.59383 - lat) + Math.Abs(6.21798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.14911 - lat) + Math.Abs(4.72074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.13375 - lat) + Math.Abs(8.33814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.83095 - lat) + Math.Abs(8.03839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.35835 - lat) + Math.Abs(7.75184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.84035 - lat) + Math.Abs(3.76285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.25057 - lat) + Math.Abs(5.54979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.23251 - lat) + Math.Abs(3.52819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.7899 - lat) + Math.Abs(5.7117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.64813 - lat) + Math.Abs(5.54948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.18045 - lat) + Math.Abs(7.9824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.66819 - lat) + Math.Abs(9.16453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.07672 - lat) + Math.Abs(8.33241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.71131 - lat) + Math.Abs(6.79084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.88333 - lat) + Math.Abs(7.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.91624 - lat) + Math.Abs(7.51849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.84672 - lat) + Math.Abs(6.1529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.36922 - lat) + Math.Abs(8.77383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.45296 - lat) + Math.Abs(6.72882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.91657 - lat) + Math.Abs(7.96314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.46374 - lat) + Math.Abs(12.03062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.25704 - lat) + Math.Abs(7.57569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.2681 - lat) + Math.Abs(6.92062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.85783 - lat) + Math.Abs(7.39577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.00243 - lat) + Math.Abs(6.87262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.01962 - lat) + Math.Abs(6.91729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.75917 - lat) + Math.Abs(7.10384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.15038 - lat) + Math.Abs(6.83042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.73478 - lat) + Math.Abs(7.74897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.07837 - lat) + Math.Abs(9.56886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.75543 - lat) + Math.Abs(7.81721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.87695 - lat) + Math.Abs(10.45536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.28871 - lat) + Math.Abs(12.24026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.48388 - lat) + Math.Abs(7.41446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.34053 - lat) + Math.Abs(14.1867 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.22884 - lat) + Math.Abs(4.62363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.33957 - lat) + Math.Abs(4.4688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.88644 - lat) + Math.Abs(4.50854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.09511 - lat) + Math.Abs(7.02426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.53673 - lat) + Math.Abs(6.40332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.03405 - lat) + Math.Abs(7.56843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.71226 - lat) + Math.Abs(8.5406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53895 - lat) + Math.Abs(7.70821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.09596 - lat) + Math.Abs(11.33261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.64138 - lat) + Math.Abs(10.77355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.52799 - lat) + Math.Abs(3.35411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.12949 - lat) + Math.Abs(7.67023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.26858 - lat) + Math.Abs(13.26701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.87405 - lat) + Math.Abs(6.48754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.10387 - lat) + Math.Abs(5.8928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.52843 - lat) + Math.Abs(3.91156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.67059 - lat) + Math.Abs(13.61224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.5206 - lat) + Math.Abs(9.09769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.29482 - lat) + Math.Abs(5.05412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.38299 - lat) + Math.Abs(4.26031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.16586 - lat) + Math.Abs(4.9637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.3137 - lat) + Math.Abs(10.46664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.73115 - lat) + Math.Abs(12.14626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.61524 - lat) + Math.Abs(6.54776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.17765 - lat) + Math.Abs(8.65782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.2388 - lat) + Math.Abs(9.71362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.62042 - lat) + Math.Abs(13.38928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.44888 - lat) + Math.Abs(2.84289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.73236 - lat) + Math.Abs(6.88869 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.1731 - lat) + Math.Abs(7.63017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.73432 - lat) + Math.Abs(7.50238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.05421 - lat) + Math.Abs(12.05794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.13639 - lat) + Math.Abs(10.04924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.23549 - lat) + Math.Abs(7.67426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.98044 - lat) + Math.Abs(7.94703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.3336 - lat) + Math.Abs(6.40372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.36532 - lat) + Math.Abs(13.8293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.56704 - lat) + Math.Abs(6.24407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.85426 - lat) + Math.Abs(7.87526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.71667 - lat) + Math.Abs(6.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.78935 - lat) + Math.Abs(7.62061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.4683 - lat) + Math.Abs(11.29294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.56427 - lat) + Math.Abs(9.95727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.73375 - lat) + Math.Abs(8.52139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.49611 - lat) + Math.Abs(3.38778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.4714 - lat) + Math.Abs(7.41026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.37734 - lat) + Math.Abs(7.88098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.08225 - lat) + Math.Abs(4.36907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.6843 - lat) + Math.Abs(6.47889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.99672 - lat) + Math.Abs(13.21665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.80783 - lat) + Math.Abs(9.44516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.02707 - lat) + Math.Abs(7.93844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.84692 - lat) + Math.Abs(13.15712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.17986 - lat) + Math.Abs(8.2304 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.55338 - lat) + Math.Abs(4.98138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.11451 - lat) + Math.Abs(12.8262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.92417 - lat) + Math.Abs(13.60066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.77725 - lat) + Math.Abs(8.28801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.7798 - lat) + Math.Abs(10.4479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.10444 - lat) + Math.Abs(7.21333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.88942 - lat) + Math.Abs(13.62832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79688 - lat) + Math.Abs(6.74048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.38584 - lat) + Math.Abs(8.57286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.71052 - lat) + Math.Abs(9.34029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.39637 - lat) + Math.Abs(6.02791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.40948 - lat) + Math.Abs(4.09152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.20827 - lat) + Math.Abs(11.27541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.04439 - lat) + Math.Abs(6.57089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.14164 - lat) + Math.Abs(9.79101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.60816 - lat) + Math.Abs(11.79315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.44154 - lat) + Math.Abs(9.23955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.46791 - lat) + Math.Abs(4.06594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.45407 - lat) + Math.Abs(3.39467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.85299 - lat) + Math.Abs(5.41641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.4939 - lat) + Math.Abs(8.51532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.90361 - lat) + Math.Abs(9.29086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.45745 - lat) + Math.Abs(8.00684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.50296 - lat) + Math.Abs(11.84331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.14082 - lat) + Math.Abs(6.82196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.21969 - lat) + Math.Abs(5.26596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.88346 - lat) + Math.Abs(7.01858 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.70773 - lat) + Math.Abs(6.43402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.20103 - lat) + Math.Abs(5.59498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.86864 - lat) + Math.Abs(6.71042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.53283 - lat) + Math.Abs(6.44222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.4656 - lat) + Math.Abs(7.97848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.6663 - lat) + Math.Abs(7.48478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.77232 - lat) + Math.Abs(8.42631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.5026 - lat) + Math.Abs(8.27092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.04807 - lat) + Math.Abs(11.21055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.89002 - lat) + Math.Abs(8.503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.15498 - lat) + Math.Abs(10.63468 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.92475 - lat) + Math.Abs(13.56617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.87952 - lat) + Math.Abs(7.22756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.45767 - lat) + Math.Abs(7.63808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.65265 - lat) + Math.Abs(7.28397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.0912 - lat) + Math.Abs(6.79782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.55107 - lat) + Math.Abs(3.22841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.40319 - lat) + Math.Abs(5.4708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.84686 - lat) + Math.Abs(4.09835 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.65331 - lat) + Math.Abs(13.41787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.00084 - lat) + Math.Abs(5.45523 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.78442 - lat) + Math.Abs(9.6069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.08297 - lat) + Math.Abs(3.85196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.7021 - lat) + Math.Abs(8.13481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.76653 - lat) + Math.Abs(8.50981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.69273 - lat) + Math.Abs(10.25456 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.40556 - lat) + Math.Abs(10.40451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.33338 - lat) + Math.Abs(9.93891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.528 - lat) + Math.Abs(8.66108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.51966 - lat) + Math.Abs(4.2603 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.23933 - lat) + Math.Abs(9.91105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84651 - lat) + Math.Abs(7.87354 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.12861 - lat) + Math.Abs(4.73433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.14724 - lat) + Math.Abs(8.79601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.64846 - lat) + Math.Abs(8.41178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.57601 - lat) + Math.Abs(8.15096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.59371 - lat) + Math.Abs(6.58648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.47431 - lat) + Math.Abs(9.73671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.16938 - lat) + Math.Abs(9.28465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.99082 - lat) + Math.Abs(7.60177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.76076 - lat) + Math.Abs(6.312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.17756 - lat) + Math.Abs(9.75241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.28507 - lat) + Math.Abs(10.35027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3143 - lat) + Math.Abs(11.18731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.2471 - lat) + Math.Abs(10.561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.7836 - lat) + Math.Abs(8.01504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.00012 - lat) + Math.Abs(8.51672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.54637 - lat) + Math.Abs(7.82254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.93114 - lat) + Math.Abs(7.41115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.85172 - lat) + Math.Abs(3.65478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.81998 - lat) + Math.Abs(11.30871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.32666 - lat) + Math.Abs(4.2004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.32281 - lat) + Math.Abs(7.68462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.08346 - lat) + Math.Abs(7.74092 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.55339 - lat) + Math.Abs(3.81814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.6053 - lat) + Math.Abs(3.94101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.1197 - lat) + Math.Abs(6.30101 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.60776 - lat) + Math.Abs(8.39043 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.4911 - lat) + Math.Abs(7.69771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.18662 - lat) + Math.Abs(6.25485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.64589 - lat) + Math.Abs(7.69068 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.68856 - lat) + Math.Abs(9.76051 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.38304 - lat) + Math.Abs(11.09567 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.58126 - lat) + Math.Abs(8.2926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.1961 - lat) + Math.Abs(10.0462 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.52641 - lat) + Math.Abs(7.43879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.87342 - lat) + Math.Abs(7.95407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.85606 - lat) + Math.Abs(8.1702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.82719 - lat) + Math.Abs(6.07502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.92849 - lat) + Math.Abs(8.89212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.763 - lat) + Math.Abs(3.91935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.27949 - lat) + Math.Abs(12.45819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.17328 - lat) + Math.Abs(7.77424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.09378 - lat) + Math.Abs(7.22624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.22336 - lat) + Math.Abs(4.37971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.11972 - lat) + Math.Abs(4.8236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.99105 - lat) + Math.Abs(9.10811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.6698 - lat) + Math.Abs(9.928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.89367 - lat) + Math.Abs(11.3596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.37093 - lat) + Math.Abs(10.77373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.8985 - lat) + Math.Abs(10.80688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.98022 - lat) + Math.Abs(11.44002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.07629 - lat) + Math.Abs(9.62757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.75682 - lat) + Math.Abs(12.15537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.95457 - lat) + Math.Abs(5.23314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.84325 - lat) + Math.Abs(5.97061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.63527 - lat) + Math.Abs(4.18156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.99999 - lat) + Math.Abs(3.08827 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.46395 - lat) + Math.Abs(7.33078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.20131 - lat) + Math.Abs(7.98373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.93123 - lat) + Math.Abs(3.22147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.0245 - lat) + Math.Abs(8.32358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.89147 - lat) + Math.Abs(8.02187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.8575 - lat) + Math.Abs(9.96394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.36838 - lat) + Math.Abs(5.24684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.15002 - lat) + Math.Abs(7.80131 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.31584 - lat) + Math.Abs(6.47599 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.59586 - lat) + Math.Abs(6.00028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.38186 - lat) + Math.Abs(8.03736 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.45361 - lat) + Math.Abs(5.91047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.97022 - lat) + Math.Abs(3.59626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.46478 - lat) + Math.Abs(5.42333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.99345 - lat) + Math.Abs(3.68148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.27445 - lat) + Math.Abs(5.83528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.28823 - lat) + Math.Abs(5.81837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.20066 - lat) + Math.Abs(6.40487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.08747 - lat) + Math.Abs(4.39264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.49418 - lat) + Math.Abs(4.87036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.904 - lat) + Math.Abs(4.68705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.87377 - lat) + Math.Abs(5.07691 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.52499 - lat) + Math.Abs(2.84246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.52152 - lat) + Math.Abs(4.44477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.91002 - lat) + Math.Abs(3.66557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.50212 - lat) + Math.Abs(4.82582 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.84855 - lat) + Math.Abs(4.32981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.64138 - lat) + Math.Abs(8.05162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.49664 - lat) + Math.Abs(4.54214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.09343 - lat) + Math.Abs(5.14233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.84036 - lat) + Math.Abs(4.48557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.67033 - lat) + Math.Abs(6.62907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.73064 - lat) + Math.Abs(5.29777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.62789 - lat) + Math.Abs(4.74161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.21309 - lat) + Math.Abs(4.86902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.10992 - lat) + Math.Abs(4.66059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.62129 - lat) + Math.Abs(4.24531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.59881 - lat) + Math.Abs(5.1047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.88901 - lat) + Math.Abs(3.01416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.35067 - lat) + Math.Abs(5.11333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.01714 - lat) + Math.Abs(4.90421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.2444 - lat) + Math.Abs(4.17181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.45254 - lat) + Math.Abs(3.43584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.54433 - lat) + Math.Abs(3.26379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.88426 - lat) + Math.Abs(8.48379 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.81171 - lat) + Math.Abs(7.61401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.18194 - lat) + Math.Abs(7.71481 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.12504 - lat) + Math.Abs(7.65716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.61526 - lat) + Math.Abs(3.5069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.96669 - lat) + Math.Abs(8.70632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.79148 - lat) + Math.Abs(5.50865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.91283 - lat) + Math.Abs(4.66741 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.36983 - lat) + Math.Abs(4.1863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.49748 - lat) + Math.Abs(5.23041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.86579 - lat) + Math.Abs(3.71518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.77993 - lat) + Math.Abs(7.71484 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.59651 - lat) + Math.Abs(3.34205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.52591 - lat) + Math.Abs(5.75342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.17511 - lat) + Math.Abs(8.22466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.78978 - lat) + Math.Abs(8.5316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.39452 - lat) + Math.Abs(5.25919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.81514 - lat) + Math.Abs(5.06716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.81944 - lat) + Math.Abs(3.91731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.68287 - lat) + Math.Abs(4.81769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.97198 - lat) + Math.Abs(3.99938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.77837 - lat) + Math.Abs(4.03386 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.58225 - lat) + Math.Abs(7.09896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.85475 - lat) + Math.Abs(6.85944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.56585 - lat) + Math.Abs(5.35455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.79792 - lat) + Math.Abs(7.96794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.6685 - lat) + Math.Abs(5.12627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.01798 - lat) + Math.Abs(7.02027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.45123 - lat) + Math.Abs(8.60805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.43383 - lat) + Math.Abs(3.28788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.34842 - lat) + Math.Abs(4.81135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.83784 - lat) + Math.Abs(3.75628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.74921 - lat) + Math.Abs(4.13113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.35894 - lat) + Math.Abs(4.8652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.41172 - lat) + Math.Abs(5.05805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.50251 - lat) + Math.Abs(5.06258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.29366 - lat) + Math.Abs(6.10432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.80603 - lat) + Math.Abs(7.71443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.85992 - lat) + Math.Abs(4.47621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.92973 - lat) + Math.Abs(5.77368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.81491 - lat) + Math.Abs(3.19518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.18419 - lat) + Math.Abs(4.70046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.4824 - lat) + Math.Abs(4.56032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.78942 - lat) + Math.Abs(5.24852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.03005 - lat) + Math.Abs(8.01716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.26812 - lat) + Math.Abs(5.71296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.63187 - lat) + Math.Abs(2.7472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.23292 - lat) + Math.Abs(3.86152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.84598 - lat) + Math.Abs(5.18314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.47103 - lat) + Math.Abs(3.7574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.1127 - lat) + Math.Abs(5.1159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.11345 - lat) + Math.Abs(6.73866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.7067 - lat) + Math.Abs(6.7718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.78737 - lat) + Math.Abs(4.72958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.40655 - lat) + Math.Abs(8.23329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.18122 - lat) + Math.Abs(9.74431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.48536 - lat) + Math.Abs(5.14501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.91854 - lat) + Math.Abs(7.39895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.37756 - lat) + Math.Abs(3.90591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.2668 - lat) + Math.Abs(7.64916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.23305 - lat) + Math.Abs(12.92805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.89863 - lat) + Math.Abs(13.0545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.30426 - lat) + Math.Abs(11.49905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.45347 - lat) + Math.Abs(10.04115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.08313 - lat) + Math.Abs(13.69595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.23672 - lat) + Math.Abs(6.92302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.78169 - lat) + Math.Abs(8.33722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.67479 - lat) + Math.Abs(11.0669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.48333 - lat) + Math.Abs(3.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.91597 - lat) + Math.Abs(7.9337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.27727 - lat) + Math.Abs(9.88385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.23295 - lat) + Math.Abs(10.28572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.22899 - lat) + Math.Abs(8.45807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.50204 - lat) + Math.Abs(4.64295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.94342 - lat) + Math.Abs(7.08165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.35819 - lat) + Math.Abs(5.23812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.90663 - lat) + Math.Abs(11.92753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.17024 - lat) + Math.Abs(6.66412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.7281 - lat) + Math.Abs(10.41989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.14484 - lat) + Math.Abs(5.11776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.6269 - lat) + Math.Abs(9.38807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.64231 - lat) + Math.Abs(4.35545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.8053 - lat) + Math.Abs(13.45824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.49959 - lat) + Math.Abs(11.93396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.94284 - lat) + Math.Abs(13.17831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.49749 - lat) + Math.Abs(12.78089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.44226 - lat) + Math.Abs(5.67234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.63958 - lat) + Math.Abs(10.70422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.91294 - lat) + Math.Abs(7.66531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.48451 - lat) + Math.Abs(12.31264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.16756 - lat) + Math.Abs(12.73684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.28969 - lat) + Math.Abs(11.16729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.31568 - lat) + Math.Abs(7.44957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.36526 - lat) + Math.Abs(12.54621 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.29575 - lat) + Math.Abs(4.97467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.39083 - lat) + Math.Abs(10.19987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.10157 - lat) + Math.Abs(8.75029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.72556 - lat) + Math.Abs(11.25652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.15738 - lat) + Math.Abs(13.30004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.89439 - lat) + Math.Abs(11.92649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.45961 - lat) + Math.Abs(9.20455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.47734 - lat) + Math.Abs(4.35351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.32275 - lat) + Math.Abs(9.00108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.8204 - lat) + Math.Abs(8.85955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.86064 - lat) + Math.Abs(9.0027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53535 - lat) + Math.Abs(10.44615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.87398 - lat) + Math.Abs(11.04057 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.68566 - lat) + Math.Abs(8.36986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.64974 - lat) + Math.Abs(8.80328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.17506 - lat) + Math.Abs(11.16458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.43456 - lat) + Math.Abs(9.19028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84717 - lat) + Math.Abs(8.13021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43497 - lat) + Math.Abs(12.05107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.66312 - lat) + Math.Abs(9.72639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.96358 - lat) + Math.Abs(5.74337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.37299 - lat) + Math.Abs(14.2069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.13379 - lat) + Math.Abs(10.53785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.76963 - lat) + Math.Abs(8.9912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.49149 - lat) + Math.Abs(13.21191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.40848 - lat) + Math.Abs(9.52881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7543 - lat) + Math.Abs(5.65723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.1093 - lat) + Math.Abs(10.4441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.52351 - lat) + Math.Abs(7.31174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.09076 - lat) + Math.Abs(6.49828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.44838 - lat) + Math.Abs(4.72077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.22175 - lat) + Math.Abs(12.64975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.28674 - lat) + Math.Abs(11.30772 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.71361 - lat) + Math.Abs(3.91722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.72108 - lat) + Math.Abs(7.02991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.44094 - lat) + Math.Abs(8.08432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.39895 - lat) + Math.Abs(7.96155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.84262 - lat) + Math.Abs(7.85252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.08956 - lat) + Math.Abs(7.45341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.80293 - lat) + Math.Abs(8.25341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.53365 - lat) + Math.Abs(3.41796 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.58412 - lat) + Math.Abs(3.98336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.65643 - lat) + Math.Abs(8.25206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.96694 - lat) + Math.Abs(7.23664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.17146 - lat) + Math.Abs(7.00525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.9827 - lat) + Math.Abs(7.45534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.44132 - lat) + Math.Abs(7.49883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.12734 - lat) + Math.Abs(5.54387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.43636 - lat) + Math.Abs(5.45925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.884 - lat) + Math.Abs(6.8601 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.1009 - lat) + Math.Abs(6.81411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.743 - lat) + Math.Abs(6.14029 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.64231 - lat) + Math.Abs(7.92438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.05805 - lat) + Math.Abs(5.78048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.61423 - lat) + Math.Abs(3.90019 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.90292 - lat) + Math.Abs(4.31419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.6155 - lat) + Math.Abs(5.98238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.65915 - lat) + Math.Abs(7.75961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.3772 - lat) + Math.Abs(4.04975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.21667 - lat) + Math.Abs(5.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.55629 - lat) + Math.Abs(5.78459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.65649 - lat) + Math.Abs(4.92235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.63105 - lat) + Math.Abs(8.05814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.85926 - lat) + Math.Abs(8.72301 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.73635 - lat) + Math.Abs(4.43536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.48799 - lat) + Math.Abs(3.38166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.60086 - lat) + Math.Abs(3.48818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.09117 - lat) + Math.Abs(7.2337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.63108 - lat) + Math.Abs(7.83024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.45392 - lat) + Math.Abs(7.49723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.82862 - lat) + Math.Abs(8.1398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.85009 - lat) + Math.Abs(8.199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.75618 - lat) + Math.Abs(9.33896 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.56473 - lat) + Math.Abs(9.88084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.2361 - lat) + Math.Abs(4.90727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.82379 - lat) + Math.Abs(10.77221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.72175 - lat) + Math.Abs(10.04526 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39307 - lat) + Math.Abs(8.35544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.48135 - lat) + Math.Abs(9.91903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.22629 - lat) + Math.Abs(10.15132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.03609 - lat) + Math.Abs(13.91815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.77015 - lat) + Math.Abs(7.15473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.36872 - lat) + Math.Abs(9.96223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.45566 - lat) + Math.Abs(12.15249 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.68967 - lat) + Math.Abs(7.0438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.74807 - lat) + Math.Abs(6.76618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.21187 - lat) + Math.Abs(11.3871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.10452 - lat) + Math.Abs(8.32999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.83727 - lat) + Math.Abs(8.59699 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.03299 - lat) + Math.Abs(8.32351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.5541 - lat) + Math.Abs(11.406 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.9992 - lat) + Math.Abs(10.41062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.49536 - lat) + Math.Abs(11.49977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.29621 - lat) + Math.Abs(6.4952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.26157 - lat) + Math.Abs(7.33409 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.29782 - lat) + Math.Abs(7.79492 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.74449 - lat) + Math.Abs(12.18545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.3771 - lat) + Math.Abs(7.56097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.53485 - lat) + Math.Abs(8.15224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.85313 - lat) + Math.Abs(5.34572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.4588 - lat) + Math.Abs(7.12602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.15534 - lat) + Math.Abs(12.75638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.435 - lat) + Math.Abs(8.51531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.67893 - lat) + Math.Abs(10.70792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.74697 - lat) + Math.Abs(11.96083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.10518 - lat) + Math.Abs(12.50854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.67824 - lat) + Math.Abs(11.33517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.64809 - lat) + Math.Abs(4.06177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.61667 - lat) + Math.Abs(11.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.47651 - lat) + Math.Abs(5.20625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.86949 - lat) + Math.Abs(12.84657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.67155 - lat) + Math.Abs(7.72929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.95775 - lat) + Math.Abs(6.92083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.95893 - lat) + Math.Abs(8.32695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.27995 - lat) + Math.Abs(7.38045 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.35328 - lat) + Math.Abs(5.50826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.39106 - lat) + Math.Abs(8.72341 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.88224 - lat) + Math.Abs(9.68058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.00065 - lat) + Math.Abs(9.51596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.69924 - lat) + Math.Abs(8.54127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.26848 - lat) + Math.Abs(6.55288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.79399 - lat) + Math.Abs(8.86397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.1372 - lat) + Math.Abs(5.46821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.73614 - lat) + Math.Abs(6.86236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.49056 - lat) + Math.Abs(7.34139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.34764 - lat) + Math.Abs(11.6099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.31231 - lat) + Math.Abs(6.24091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.27503 - lat) + Math.Abs(12.56856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.67629 - lat) + Math.Abs(7.36519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.65321 - lat) + Math.Abs(7.8841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.4516 - lat) + Math.Abs(7.17074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.16073 - lat) + Math.Abs(5.92375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.29921 - lat) + Math.Abs(8.99467 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.43333 - lat) + Math.Abs(5.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.35572 - lat) + Math.Abs(7.89303 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.28428 - lat) + Math.Abs(8.92062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.56109 - lat) + Math.Abs(9.50154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.66904 - lat) + Math.Abs(9.60528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.84413 - lat) + Math.Abs(5.15001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.939 - lat) + Math.Abs(4.78227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.75103 - lat) + Math.Abs(4.2298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.61285 - lat) + Math.Abs(12.19458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.6746 - lat) + Math.Abs(13.33952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.7907 - lat) + Math.Abs(10.23614 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.45207 - lat) + Math.Abs(9.47856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.45389 - lat) + Math.Abs(4.1975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.01537 - lat) + Math.Abs(6.78036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.66374 - lat) + Math.Abs(6.54003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.7823 - lat) + Math.Abs(4.81135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.22294 - lat) + Math.Abs(4.90888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.66987 - lat) + Math.Abs(7.80865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.89024 - lat) + Math.Abs(11.21794 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.86545 - lat) + Math.Abs(11.22624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.08044 - lat) + Math.Abs(6.0099 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.23385 - lat) + Math.Abs(8.24063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.26676 - lat) + Math.Abs(4.43114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.80919 - lat) + Math.Abs(12.49151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.33815 - lat) + Math.Abs(5.62575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.55874 - lat) + Math.Abs(7.63359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.28444 - lat) + Math.Abs(5.93472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.85868 - lat) + Math.Abs(10.97187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.66768 - lat) + Math.Abs(8.262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.83772 - lat) + Math.Abs(8.74513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.31032 - lat) + Math.Abs(9.84388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.75551 - lat) + Math.Abs(7.24809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.90611 - lat) + Math.Abs(7.60586 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.94249 - lat) + Math.Abs(8.74042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.61565 - lat) + Math.Abs(6.4185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.53812 - lat) + Math.Abs(8.8927 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.93605 - lat) + Math.Abs(11.68242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.37444 - lat) + Math.Abs(10.72884 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.52134 - lat) + Math.Abs(13.68952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.47029 - lat) + Math.Abs(4.68119 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.71141 - lat) + Math.Abs(5.87367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.55559 - lat) + Math.Abs(7.42419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.85152 - lat) + Math.Abs(11.43169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.23087 - lat) + Math.Abs(10.62444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.1577 - lat) + Math.Abs(8.1358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.40351 - lat) + Math.Abs(4.22571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.99917 - lat) + Math.Abs(7.58361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.89169 - lat) + Math.Abs(7.90938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.0563 - lat) + Math.Abs(6.143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.41502 - lat) + Math.Abs(2.88132 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.77256 - lat) + Math.Abs(9.01525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.15482 - lat) + Math.Abs(11.7709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.42949 - lat) + Math.Abs(3.81495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.67478 - lat) + Math.Abs(10.19069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.82648 - lat) + Math.Abs(6.93374 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.76764 - lat) + Math.Abs(4.39515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.21269 - lat) + Math.Abs(7.07199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.07278 - lat) + Math.Abs(7.47739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.10445 - lat) + Math.Abs(9.14011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.18805 - lat) + Math.Abs(4.72318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.89027 - lat) + Math.Abs(4.59965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.06756 - lat) + Math.Abs(6.2636 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.01277 - lat) + Math.Abs(6.74768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.65086 - lat) + Math.Abs(12.90883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.52583 - lat) + Math.Abs(12.29115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.19824 - lat) + Math.Abs(6.73187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.38941 - lat) + Math.Abs(7.91235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.74482 - lat) + Math.Abs(4.52514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.06527 - lat) + Math.Abs(5.25398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.70483 - lat) + Math.Abs(5.04054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.35156 - lat) + Math.Abs(4.18335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.4488 - lat) + Math.Abs(3.35901 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.40249 - lat) + Math.Abs(7.63196 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.11347 - lat) + Math.Abs(5.92681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.96245 - lat) + Math.Abs(8.39233 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.46875 - lat) + Math.Abs(6.92893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.35509 - lat) + Math.Abs(9.70121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.73016 - lat) + Math.Abs(7.1151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.97032 - lat) + Math.Abs(6.10915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.67597 - lat) + Math.Abs(7.07184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.78917 - lat) + Math.Abs(7.83829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.33063 - lat) + Math.Abs(7.65247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.26688 - lat) + Math.Abs(10.33238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.28835 - lat) + Math.Abs(4.47139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.29627 - lat) + Math.Abs(8.48278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.67403 - lat) + Math.Abs(9.14059 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.61667 - lat) + Math.Abs(4.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.35753 - lat) + Math.Abs(6.59066 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.88688 - lat) + Math.Abs(7.35686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.91077 - lat) + Math.Abs(8.40655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.25256 - lat) + Math.Abs(5.19312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.70902 - lat) + Math.Abs(7.31826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.43787 - lat) + Math.Abs(3.9309 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.28899 - lat) + Math.Abs(10.9732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.91677 - lat) + Math.Abs(7.67615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.28075 - lat) + Math.Abs(4.02557 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.31246 - lat) + Math.Abs(8.35515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.1264 - lat) + Math.Abs(8.1898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.96826 - lat) + Math.Abs(9.03679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.93118 - lat) + Math.Abs(4.12654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.23333 - lat) + Math.Abs(4.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.56229 - lat) + Math.Abs(6.65497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.04427 - lat) + Math.Abs(7.20864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.17416 - lat) + Math.Abs(6.82535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.24281 - lat) + Math.Abs(3.02639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.54286 - lat) + Math.Abs(3.22263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.0828 - lat) + Math.Abs(6.64981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.70611 - lat) + Math.Abs(4.58125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.10045 - lat) + Math.Abs(7.061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.01634 - lat) + Math.Abs(7.08782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.62105 - lat) + Math.Abs(8.10163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.50442 - lat) + Math.Abs(3.42134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.62314 - lat) + Math.Abs(3.61419 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.10512 - lat) + Math.Abs(6.69381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.61563 - lat) + Math.Abs(3.33337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.25375 - lat) + Math.Abs(6.1942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.07668 - lat) + Math.Abs(8.66551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.30669 - lat) + Math.Abs(7.54862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.58862 - lat) + Math.Abs(4.8343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.0085 - lat) + Math.Abs(6.31821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.96945 - lat) + Math.Abs(6.04254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.31313 - lat) + Math.Abs(4.52738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.89258 - lat) + Math.Abs(7.93534 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.79004 - lat) + Math.Abs(7.31187 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.86226 - lat) + Math.Abs(7.90626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.97694 - lat) + Math.Abs(7.16262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.59546 - lat) + Math.Abs(2.94176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.51004 - lat) + Math.Abs(6.4798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.62329 - lat) + Math.Abs(5.22087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.89002 - lat) + Math.Abs(9.23351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.73971 - lat) + Math.Abs(7.01117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.33465 - lat) + Math.Abs(6.98863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.69132 - lat) + Math.Abs(8.94337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.05785 - lat) + Math.Abs(7.49508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.29489 - lat) + Math.Abs(6.02995 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.85763 - lat) + Math.Abs(6.64519 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.79023 - lat) + Math.Abs(6.10473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.73171 - lat) + Math.Abs(6.77223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.54781 - lat) + Math.Abs(6.52588 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.5677 - lat) + Math.Abs(6.9863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.48676 - lat) + Math.Abs(4.39531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.15571 - lat) + Math.Abs(3.34509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.86808 - lat) + Math.Abs(7.50907 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.32485 - lat) + Math.Abs(8.11368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.98236 - lat) + Math.Abs(7.78922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.47372 - lat) + Math.Abs(6.94453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.19031 - lat) + Math.Abs(6.99357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.10658 - lat) + Math.Abs(7.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.45197 - lat) + Math.Abs(3.33115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.57806 - lat) + Math.Abs(3.38686 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.64423 - lat) + Math.Abs(3.32488 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.76145 - lat) + Math.Abs(6.74957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.40724 - lat) + Math.Abs(10.01345 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.27441 - lat) + Math.Abs(12.00852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.62066 - lat) + Math.Abs(6.19928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.58331 - lat) + Math.Abs(8.2044 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.4293 - lat) + Math.Abs(7.81787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.38137 - lat) + Math.Abs(8.45733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.49539 - lat) + Math.Abs(4.89904 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.93554 - lat) + Math.Abs(5.6661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.61712 - lat) + Math.Abs(7.86639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.02309 - lat) + Math.Abs(7.53895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.30857 - lat) + Math.Abs(7.71106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.73634 - lat) + Math.Abs(6.21984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.60183 - lat) + Math.Abs(6.24276 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.7569 - lat) + Math.Abs(6.94613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.08536 - lat) + Math.Abs(6.46633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.46783 - lat) + Math.Abs(6.96594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.84945 - lat) + Math.Abs(11.0733 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.37229 - lat) + Math.Abs(7.27178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.51155 - lat) + Math.Abs(8.12984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.15537 - lat) + Math.Abs(8.03735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.12729 - lat) + Math.Abs(9.01981 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.4697 - lat) + Math.Abs(3.28299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.89456 - lat) + Math.Abs(4.00715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.01807 - lat) + Math.Abs(4.67253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.49869 - lat) + Math.Abs(4.08093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.97213 - lat) + Math.Abs(5.77886 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.83368 - lat) + Math.Abs(5.82688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.27827 - lat) + Math.Abs(6.99335 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.33424 - lat) + Math.Abs(7.26114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.5592 - lat) + Math.Abs(6.89459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.86621 - lat) + Math.Abs(8.70146 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.66812 - lat) + Math.Abs(8.45825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.00943 - lat) + Math.Abs(7.66147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.47192 - lat) + Math.Abs(6.14979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.50921 - lat) + Math.Abs(7.51006 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.86265 - lat) + Math.Abs(7.54622 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.04644 - lat) + Math.Abs(7.77273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.0954 - lat) + Math.Abs(8.15157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.58182 - lat) + Math.Abs(7.01651 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.47569 - lat) + Math.Abs(7.27161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.54435 - lat) + Math.Abs(6.7609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.62048 - lat) + Math.Abs(7.34985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.73262 - lat) + Math.Abs(7.01364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.91301 - lat) + Math.Abs(7.31936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.15979 - lat) + Math.Abs(7.32235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.24268 - lat) + Math.Abs(7.40623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.3571 - lat) + Math.Abs(7.38765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.99125 - lat) + Math.Abs(7.39445 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.40632 - lat) + Math.Abs(7.56816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.68836 - lat) + Math.Abs(6.31525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.57064 - lat) + Math.Abs(7.97955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.77022 - lat) + Math.Abs(7.931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.87231 - lat) + Math.Abs(7.56459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.7516 - lat) + Math.Abs(8.23056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.75275 - lat) + Math.Abs(8.1677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.73037 - lat) + Math.Abs(9.78512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.02167 - lat) + Math.Abs(9.61384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.94321 - lat) + Math.Abs(9.24126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.37128 - lat) + Math.Abs(9.6192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.78187 - lat) + Math.Abs(11.27882 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.09969 - lat) + Math.Abs(12.1079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.92589 - lat) + Math.Abs(13.23062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.70298 - lat) + Math.Abs(11.25757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.71677 - lat) + Math.Abs(7.263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.79309 - lat) + Math.Abs(7.12061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.89333 - lat) + Math.Abs(7.00228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zuru", "40", 11.43522, 5.23494);
case 1: return new CityInfo("Zurmi", "57", 12.77675, 6.78404);
case 2: return new CityInfo("Zungeru", "31", 9.80726, 6.15238);
case 3: return new CityInfo("Zonkwa", "23", 9.78453, 8.29056);
case 4: return new CityInfo("Zing", "43", 8.99064, 11.74763);
case 5: return new CityInfo("Zaria", "23", 11.11128, 7.7227);
case 6: return new CityInfo("Zango", "24", 13.05313, 8.48574);
case 7: return new CityInfo("Zalanga", "46", 10.61432, 10.17647);
case 8: return new CityInfo("Zakirai", "29", 12.10033, 8.88524);
case 9: return new CityInfo("Zaki Biam", "26", 7.50671, 9.6104);
case 10: return new CityInfo("Zadawa", "46", 11.4496, 10.3672);
case 11: return new CityInfo("Yuli", "46", 9.69707, 10.2735);
case 12: return new CityInfo("Yola", "35", 9.20839, 12.48146);
case 13: return new CityInfo("Yenagoa", "52", 4.92675, 6.26764);
case 14: return new CityInfo("Yelwa", "40", 10.83505, 4.74244);
case 15: return new CityInfo("Yelwa", "49", 8.83333, 9.63333);
case 16: return new CityInfo("Yashikira", "30", 9.76794, 3.398);
case 17: return new CityInfo("Yandev", "26", 7.36308, 9.04235);
case 18: return new CityInfo("Yanda Bayo", "46", 11.5071, 10.7459);
case 19: return new CityInfo("Yamrat", "46", 10.11161, 9.82604);
case 20: return new CityInfo("Yajiwa", "27", 11.38623, 12.71992);
case 21: return new CityInfo("Yabo", "51", 12.72217, 5.01329);
case 22: return new CityInfo("Wuyo", "27", 10.38522, 11.69678);
case 23: return new CityInfo("Wushishi", "31", 9.73035, 6.07305);
case 24: return new CityInfo("Wurno", "51", 13.29048, 5.42373);
case 25: return new CityInfo("Wukari", "43", 7.87139, 9.77786);
case 26: return new CityInfo("Wudil", "29", 11.80937, 8.84422);
case 27: return new CityInfo("Wawa", "31", 9.90222, 4.41917);
case 28: return new CityInfo("Wase", "49", 9.09424, 9.95605);
case 29: return new CityInfo("Wasagu", "40", 11.3764, 5.79536);
case 30: return new CityInfo("Warri", "36", 5.51737, 5.75006);
case 31: return new CityInfo("Wannune", "26", 7.56384, 8.88534);
case 32: return new CityInfo("Wamba", "56", 8.94153, 8.60315);
case 33: return new CityInfo("Wamako", "51", 13.03054, 5.10433);
case 34: return new CityInfo("Wagini", "24", 12.68781, 7.19579);
case 35: return new CityInfo("Vom", "49", 9.7291, 8.79138);
case 36: return new CityInfo("Vandeikya", "26", 6.78481, 9.06799);
case 37: return new CityInfo("Uyo", "21", 5.05127, 7.9335);
case 38: return new CityInfo("Utu Etim Ekpo", "21", 5.00485, 7.61028);
case 39: return new CityInfo("Ozoro", "36", 5.54692, 6.22649);
case 40: return new CityInfo("Uselu", "37", 6.38429, 5.60984);
case 41: return new CityInfo("Uruobo-Okija", "25", 5.90016, 6.84312);
case 42: return new CityInfo("Urualla", "28", 5.85397, 7.09906);
case 43: return new CityInfo("Uromi", "37", 6.7, 6.33333);
case 44: return new CityInfo("Uquo", "21", 4.65832, 8.05868);
case 45: return new CityInfo("Ukpor", "25", 5.94211, 6.92931);
case 46: return new CityInfo("Ungogo", "29", 12.09171, 8.49531);
case 47: return new CityInfo("Umuneke-Ngor", "28", 5.33558, 7.15187);
case 48: return new CityInfo("Umunede", "36", 6.26549, 6.30962);
case 49: return new CityInfo("Umulona", "47", 6.50789, 7.09743);
case 50: return new CityInfo("Umuelemai", "28", 5.68786, 7.24334);
case 51: return new CityInfo("Umuahia", "45", 5.52491, 7.49461);
case 52: return new CityInfo("Ukpo", "25", 6.21407, 6.96657);
case 53: return new CityInfo("Ukata", "31", 10.83122, 5.82494);
case 54: return new CityInfo("Ughelli", "36", 5.48956, 6.00407);
case 55: return new CityInfo("Ugep", "22", 5.80865, 8.08098);
case 56: return new CityInfo("Ugba", "26", 7.507, 9.34804);
case 57: return new CityInfo("Uga", "25", 5.93576, 7.0793);
case 58: return new CityInfo("Udi", "47", 6.31592, 7.42086);
case 59: return new CityInfo("Ubiaja", "37", 6.65581, 6.38494);
case 60: return new CityInfo("Uba", "27", 10.45509, 13.22233);
case 61: return new CityInfo("Tureta", "51", 12.59367, 5.54391);
case 62: return new CityInfo("Tudun Wada", "29", 11.24848, 8.40109);
case 63: return new CityInfo("Tsanyawa", "29", 12.29559, 7.98654);
case 64: return new CityInfo("Toungo", "35", 8.11733, 12.04611);
case 65: return new CityInfo("Toto", "56", 8.3876, 7.07751);
case 66: return new CityInfo("Toro", "46", 10.05889, 9.0691);
case 67: return new CityInfo("Tokombere", "27", 11.22135, 13.48783);
case 68: return new CityInfo("Tofa", "29", 12.05789, 8.27309);
case 69: return new CityInfo("Tegina", "31", 10.0706, 6.1906);
case 70: return new CityInfo("Tede", "32", 8.55336, 3.44654);
case 71: return new CityInfo("Taura", "39", 12.22712, 9.28306);
case 72: return new CityInfo("Tambuwal", "51", 12.40592, 4.64605);
case 73: return new CityInfo("Talata Mafara", "57", 12.56841, 6.06225);
case 74: return new CityInfo("Talasse", "55", 9.96843, 11.67945);
case 75: return new CityInfo("Takum", "26", 7.26667, 9.98333);
case 76: return new CityInfo("Bunza", "40", 12.08821, 4.0152);
case 77: return new CityInfo("Takai", "29", 11.57569, 9.1088);
case 78: return new CityInfo("Tafawa Balewa", "46", 9.76017, 9.55172);
case 79: return new CityInfo("Suya", "30", 9.46667, 3.18333);
case 80: return new CityInfo("Surulere", "05", 6.50153, 3.35808);
case 81: return new CityInfo("Sumaila", "29", 11.53011, 8.95593);
case 82: return new CityInfo("Sule Tankarkar", "39", 12.66686, 9.22828);
case 83: return new CityInfo("Suleja", "31", 9.18059, 7.17939);
case 84: return new CityInfo("Song", "35", 9.82675, 12.6238);
case 85: return new CityInfo("Sokoto", "51", 13.06269, 5.24322);
case 86: return new CityInfo("Soba", "23", 10.98133, 8.05749);
case 87: return new CityInfo("Siluko", "37", 6.53589, 5.16005);
case 88: return new CityInfo("Silame", "51", 13.03921, 4.84593);
case 89: return new CityInfo("Somolu", "05", 6.53891, 3.3742);
case 90: return new CityInfo("Shinkafi", "57", 13.07296, 6.50574);
case 91: return new CityInfo("Shendam", "49", 8.87866, 9.53464);
case 92: return new CityInfo("Shelleng", "35", 9.89647, 12.00572);
case 93: return new CityInfo("Share", "30", 8.82329, 4.97637);
case 94: return new CityInfo("Shanono", "29", 12.05154, 7.992);
case 95: return new CityInfo("Shani", "27", 10.21824, 12.06059);
case 96: return new CityInfo("Shanga", "40", 11.21374, 4.57941);
case 97: return new CityInfo("Saki", "32", 8.66762, 3.39393);
case 98: return new CityInfo("Shagari", "51", 12.62727, 4.99295);
case 99: return new CityInfo("Shagamu", "16", 6.8485, 3.64633);
case 100: return new CityInfo("Shaffa", "27", 10.50673, 12.33315);
case 101: return new CityInfo("Serti", "43", 7.50574, 11.3631);
case 102: return new CityInfo("Sauri", "57", 11.72655, 6.78374);
case 103: return new CityInfo("Sarkin Pawa", "31", 10.02094, 7.11244);
case 104: return new CityInfo("Sapele", "36", 5.89405, 5.67666);
case 105: return new CityInfo("Sankwala", "22", 6.54753, 9.22258);
case 106: return new CityInfo("Sankera", "26", 7.5353, 9.65223);
case 107: return new CityInfo("Sandamu", "24", 12.96163, 8.36017);
case 108: return new CityInfo("Samamiya", "39", 11.34873, 9.63989);
case 109: return new CityInfo("Sakaba", "40", 11.06513, 5.5961);
case 110: return new CityInfo("Sagbama", "52", 5.15915, 6.19666);
case 111: return new CityInfo("Safana", "24", 12.41075, 7.41456);
case 112: return new CityInfo("Sade", "46", 11.3595, 10.6732);
case 113: return new CityInfo("Sabuwa", "24", 11.17372, 7.12113);
case 114: return new CityInfo("Sabongida-Ora", "37", 6.90231, 5.93117);
case 115: return new CityInfo("Sabon Birni", "51", 13.56387, 6.32355);
case 116: return new CityInfo("Runka", "24", 12.44788, 7.30918);
case 117: return new CityInfo("Ruma", "24", 12.8626, 7.23469);
case 118: return new CityInfo("Roni", "39", 12.65862, 8.26505);
case 119: return new CityInfo("Rogo", "29", 11.55237, 7.82253);
case 120: return new CityInfo("Riyom", "49", 9.63681, 8.75694);
case 121: return new CityInfo("Riti", "43", 7.90844, 9.61688);
case 122: return new CityInfo("Ririwai", "29", 10.74025, 8.74128);
case 123: return new CityInfo("Ringim", "39", 12.15143, 9.16216);
case 124: return new CityInfo("Rimin Gado", "29", 11.9672, 8.2476);
case 125: return new CityInfo("Rimi", "24", 12.8503, 7.70974);
case 126: return new CityInfo("Rijau", "31", 11.10389, 5.25556);
case 127: return new CityInfo("Ribah", "40", 11.39637, 5.48631);
case 128: return new CityInfo("Rano", "29", 11.55684, 8.58065);
case 129: return new CityInfo("Rann", "27", 12.26938, 14.46552);
case 130: return new CityInfo("Saminaka", "23", 10.41227, 8.68748);
case 131: return new CityInfo("Rabah", "51", 13.12257, 5.50762);
case 132: return new CityInfo("Potiskum", "44", 11.71391, 11.08108);
case 133: return new CityInfo("Port Harcourt", "50", 4.77742, 7.0134);
case 134: return new CityInfo("Pindiga", "55", 9.98433, 10.95229);
case 135: return new CityInfo("Patigi", "30", 8.72851, 5.75561);
case 136: return new CityInfo("Patani", "36", 5.22885, 6.19139);
case 137: return new CityInfo("Panyam", "49", 9.40756, 9.21481);
case 138: return new CityInfo("Pantisawa", "43", 8.94504, 11.51176);
case 139: return new CityInfo("Pankshin", "49", 9.32541, 9.4352);
case 140: return new CityInfo("Paiko", "31", 9.43685, 6.63357);
case 141: return new CityInfo("Ozubulu", "25", 5.95753, 6.85305);
case 142: return new CityInfo("Oyo", "32", 7.85257, 3.93125);
case 143: return new CityInfo("Oye-Ekiti", "54", 7.79976, 5.33242);
case 144: return new CityInfo("Oyan", "42", 8.05, 4.76667);
case 145: return new CityInfo("Owu-Isin", "30", 8.2809, 5.0194);
case 146: return new CityInfo("Owode", "16", 6.94851, 3.50561);
case 147: return new CityInfo("Owo", "48", 7.1962, 5.58681);
case 148: return new CityInfo("Owerri", "28", 5.48363, 7.03325);
case 149: return new CityInfo("Owena", "48", 7.19414, 5.02264);
case 150: return new CityInfo("Owa-Oyibu", "36", 6.18267, 6.19902);
case 151: return new CityInfo("Otuocha", "25", 6.33908, 6.84636);
case 152: return new CityInfo("Otun-Ekiti", "54", 7.98858, 5.12291);
case 153: return new CityInfo("Otukpa", "26", 7.10168, 7.65945);
case 154: return new CityInfo("Otu-Jeremi", "36", 5.43818, 5.87829);
case 155: return new CityInfo("Otor-Udu", "36", 5.45341, 5.8693);
case 156: return new CityInfo("Otu", "32", 8.20639, 3.40786);
case 157: return new CityInfo("Ota", "16", 6.68867, 3.23202);
case 158: return new CityInfo("Otan Ayegbaju", "42", 7.94783, 4.78836);
case 159: return new CityInfo("Osu", "42", 7.58538, 4.62263);
case 160: return new CityInfo("Osogbo", "42", 7.77104, 4.55698);
case 161: return new CityInfo("Oshodi", "05", 6.55504, 3.34363);
case 162: return new CityInfo("Afor-Oru", "28", 5.5411, 7.26845);
case 163: return new CityInfo("Oron", "21", 4.82171, 8.23504);
case 164: return new CityInfo("Orodo", "28", 5.61667, 7.03333);
case 165: return new CityInfo("Orlu", "28", 5.79565, 7.03513);
case 166: return new CityInfo("Orita Eruwa", "32", 7.55, 3.43333);
case 167: return new CityInfo("Orerokpe", "36", 5.63747, 5.89013);
case 168: return new CityInfo("Ore", "48", 6.74716, 4.8761);
case 169: return new CityInfo("Oporoma", "52", 4.80604, 6.08016);
case 170: return new CityInfo("Opobo", "50", 4.51388, 7.53794);
case 171: return new CityInfo("Ikot Abasi", "21", 4.56851, 7.55262);
case 172: return new CityInfo("Opi", "47", 6.78223, 7.43319);
case 173: return new CityInfo("Onyedega", "41", 6.88209, 6.67585);
case 174: return new CityInfo("Onitsha", "25", 6.14978, 6.78569);
case 175: return new CityInfo("Ondo", "48", 7.09316, 4.83528);
case 176: return new CityInfo("Omuo-Ekiti", "54", 7.75833, 5.72227);
case 177: return new CityInfo("Omu-Aran", "30", 8.13857, 5.1026);
case 178: return new CityInfo("Omoku", "50", 5.34388, 6.65684);
case 179: return new CityInfo("Olupona", "42", 7.6, 4.18333);
case 180: return new CityInfo("Oleh", "36", 5.46186, 6.20624);
case 181: return new CityInfo("Okpoga", "26", 7.03911, 7.81225);
case 182: return new CityInfo("Okwe", "28", 5.77743, 7.21794);
case 183: return new CityInfo("Okuta", "30", 9.21667, 3.18333);
case 184: return new CityInfo("Okrika", "50", 4.74215, 7.08368);
case 185: return new CityInfo("Okpoma", "22", 6.59679, 8.63728);
case 186: return new CityInfo("Okpo", "41", 7.21626, 7.56022);
case 187: return new CityInfo("Okoroete", "21", 4.54077, 7.74858);
case 188: return new CityInfo("Okopedi", "21", 4.84918, 8.12564);
case 189: return new CityInfo("Oko Ita", "21", 5.192, 7.89531);
case 190: return new CityInfo("Okigwe", "28", 5.82917, 7.35056);
case 191: return new CityInfo("Oke-Oyi", "30", 8.58263, 4.71622);
case 192: return new CityInfo("Okene", "41", 7.55122, 6.23589);
case 193: return new CityInfo("Oke Mesi", "42", 7.81667, 4.91667);
case 194: return new CityInfo("Oke Ila", "54", 7.95, 4.98333);
case 195: return new CityInfo("Okeho", "32", 8.03453, 3.34759);
case 196: return new CityInfo("Okehi", "50", 5.13895, 7.13915);
case 197: return new CityInfo("Oke-Agbe", "48", 7.64314, 5.75943);
case 198: return new CityInfo("Okada", "37", 6.73488, 5.39447);
case 199: return new CityInfo("Oka", "48", 7.46012, 5.80174);
case 200: return new CityInfo("Oju", "26", 6.84526, 8.41914);
case 201: return new CityInfo("Ojoto", "25", 6.05842, 6.86124);
case 202: return new CityInfo("Oji River", "47", 6.25563, 7.27025);
case 203: return new CityInfo("Ohafia-Ifigh", "45", 5.61455, 7.81191);
case 204: return new CityInfo("Ogwashi-Uku", "36", 6.17811, 6.52461);
case 205: return new CityInfo("Oguta", "28", 5.71044, 6.80936);
case 206: return new CityInfo("Ogurugu", "41", 6.78636, 6.95017);
case 207: return new CityInfo("Oguma", "41", 7.89635, 7.06229);
case 208: return new CityInfo("Ogu", "50", 4.72247, 7.19859);
case 209: return new CityInfo("Ogoja", "22", 6.6584, 8.79923);
case 210: return new CityInfo("Ogidi", "25", 6.15209, 6.86343);
case 211: return new CityInfo("Ogbomoso", "32", 8.13373, 4.24014);
case 212: return new CityInfo("Ogbere", "16", 6.73948, 4.16102);
case 213: return new CityInfo("Ogbede", "47", 6.67295, 7.37441);
case 214: return new CityInfo("Ogaminana", "41", 7.59383, 6.21798);
case 215: return new CityInfo("Offa", "30", 8.14911, 4.72074);
case 216: return new CityInfo("Odukpani", "22", 5.13375, 8.33814);
case 217: return new CityInfo("Odot", "21", 4.83095, 8.03839);
case 218: return new CityInfo("Odoro Ikpe", "21", 5.35835, 7.75184);
case 219: return new CityInfo("Odogbolu", "16", 6.84035, 3.76285);
case 220: return new CityInfo("Odo-Ere", "41", 8.25057, 5.54979);
case 221: return new CityInfo("Odeda", "16", 7.23251, 3.52819);
case 222: return new CityInfo("Ode", "48", 7.7899, 5.7117);
case 223: return new CityInfo("Ode-Ekiti", "54", 7.64813, 5.54948);
case 224: return new CityInfo("Ochobo", "26", 7.18045, 7.9824);
case 225: return new CityInfo("Obudu", "22", 6.66819, 9.16453);
case 226: return new CityInfo("Obubra", "22", 6.07672, 8.33241);
case 227: return new CityInfo("Obonoma", "50", 4.71131, 6.79084);
case 228: return new CityInfo("Obolo-Eke (1)", "47", 6.88333, 7.63333);
case 229: return new CityInfo("Obollo-Afor", "47", 6.91624, 7.51849);
case 230: return new CityInfo("Obiaruku", "36", 5.84672, 6.1529);
case 231: return new CityInfo("Obi", "56", 8.36922, 8.77383);
case 232: return new CityInfo("Nzam", "25", 6.45296, 6.72882);
case 233: return new CityInfo("Nung Udoe", "21", 4.91657, 7.96314);
case 234: return new CityInfo("Numan", "35", 9.46374, 12.03062);
case 235: return new CityInfo("Nto Edino", "21", 5.25704, 7.57569);
case 236: return new CityInfo("Nteje", "25", 6.2681, 6.92062);
case 237: return new CityInfo("Nsukka", "47", 6.85783, 7.39577);
case 238: return new CityInfo("Isiokpo", "50", 5.00243, 6.87262);
case 239: return new CityInfo("Nnewi", "25", 6.01962, 6.91729);
case 240: return new CityInfo("Nkwerre", "28", 5.75917, 7.10384);
case 241: return new CityInfo("Nkpor", "25", 6.15038, 6.83042);
case 242: return new CityInfo("Mkpat Enin", "21", 4.73478, 7.74897);
case 243: return new CityInfo("Ningi", "46", 11.07837, 9.56886);
case 244: return new CityInfo("Nguzu Edda", "53", 5.75543, 7.81721);
case 245: return new CityInfo("Nguru", "44", 12.87695, 10.45536);
case 246: return new CityInfo("Ngurore", "35", 9.28871, 12.24026);
case 247: return new CityInfo("Ngo", "50", 4.48388, 7.41446);
case 248: return new CityInfo("Ngala", "27", 12.34053, 14.1867);
case 249: return new CityInfo("Wara", "40", 10.22884, 4.62363);
case 250: return new CityInfo("New Shagunnu", "31", 10.33957, 4.4688);
case 251: return new CityInfo("New Bussa", "31", 9.88644, 4.50854);
case 252: return new CityInfo("Neni", "25", 6.09511, 7.02426);
case 253: return new CityInfo("Nembe", "52", 4.53673, 6.40332);
case 254: return new CityInfo("Ndeaboh", "47", 6.03405, 7.56843);
case 255: return new CityInfo("Nasarawa Egon", "56", 8.71226, 8.5406);
case 256: return new CityInfo("Nasarawa", "56", 8.53895, 7.70821);
case 257: return new CityInfo("Nafada", "55", 11.09596, 11.33261);
case 258: return new CityInfo("Mutum Biyu", "43", 8.64138, 10.77355);
case 259: return new CityInfo("Mushin", "05", 6.52799, 3.35411);
case 260: return new CityInfo("Musawa", "24", 12.12949, 7.67023);
case 261: return new CityInfo("Mubi", "35", 10.26858, 13.26701);
case 262: return new CityInfo("Moriki", "57", 12.87405, 6.48754);
case 263: return new CityInfo("Mopa", "41", 8.10387, 5.8928);
case 264: return new CityInfo("Moniya", "32", 7.52843, 3.91156);
case 265: return new CityInfo("Monguno", "27", 12.67059, 13.61224);
case 266: return new CityInfo("Mangu", "49", 9.5206, 9.09769);
case 267: return new CityInfo("Mokwa", "31", 9.29482, 5.05412);
case 268: return new CityInfo("Modakeke", "42", 7.38299, 4.26031);
case 269: return new CityInfo("Bolorunduro", "48", 7.16586, 4.9637);
case 270: return new CityInfo("Misau", "46", 11.3137, 10.46664);
case 271: return new CityInfo("Miringa", "27", 10.73115, 12.14626);
case 272: return new CityInfo("Minna", "31", 9.61524, 6.54776);
case 273: return new CityInfo("Minjibir", "29", 12.17765, 8.65782);
case 274: return new CityInfo("Miga", "39", 12.2388, 9.71362);
case 275: return new CityInfo("Michika", "35", 10.62042, 13.38928);
case 276: return new CityInfo("Imeko", "16", 7.44888, 2.84289);
case 277: return new CityInfo("Mgbidi", "28", 5.73236, 6.88869);
case 278: return new CityInfo("Mberubu", "47", 6.1731, 7.63017);
case 279: return new CityInfo("Mbalano", "45", 5.73432, 7.50238);
case 280: return new CityInfo("Mayo-Belwa", "35", 9.05421, 12.05794);
case 281: return new CityInfo("Machina", "44", 13.13639, 10.04924);
case 282: return new CityInfo("Matazu", "24", 12.23549, 7.67426);
case 283: return new CityInfo("Mashi", "24", 12.98044, 7.94703);
case 284: return new CityInfo("Maru", "57", 12.3336, 6.40372);
case 285: return new CityInfo("Marte", "27", 12.36532, 13.8293);
case 286: return new CityInfo("Maradun", "57", 12.56704, 6.24407);
case 287: return new CityInfo("Mani", "24", 12.85426, 7.87526);
case 288: return new CityInfo("Mando", "23", 10.71667, 6.56667);
case 289: return new CityInfo("Malumfashi", "24", 11.78935, 7.62061);
case 290: return new CityInfo("Mallam Sidi", "55", 10.4683, 11.29294);
case 291: return new CityInfo("Mallammaduri", "39", 12.56427, 9.95727);
case 292: return new CityInfo("Makurdi", "26", 7.73375, 8.52139);
case 293: return new CityInfo("Makoko", "05", 6.49611, 3.38778);
case 294: return new CityInfo("Makera", "23", 10.4714, 7.41026);
case 295: return new CityInfo("Makarfi", "23", 11.37734, 7.88098);
case 296: return new CityInfo("Maiyama", "40", 12.08225, 4.36907);
case 297: return new CityInfo("Maikunkele", "31", 9.6843, 6.47889);
case 298: return new CityInfo("Maiha", "35", 9.99672, 13.21665);
case 299: return new CityInfo("Maigatari", "39", 12.80783, 9.44516);
case 300: return new CityInfo("Maigana", "23", 11.02707, 7.93844);
case 301: return new CityInfo("Maiduguri", "27", 11.84692, 13.15712);
case 302: return new CityInfo("Mai’Adua", "24", 13.17986, 8.2304);
case 303: return new CityInfo("Mahuta", "40", 11.55338, 4.98138);
case 304: return new CityInfo("Magumeri", "27", 12.11451, 12.8262);
case 305: return new CityInfo("Mafa", "27", 11.92417, 13.60066);
case 306: return new CityInfo("Madobi", "29", 11.77725, 8.28801);
case 307: return new CityInfo("Madara", "46", 11.7798, 10.4479);
case 308: return new CityInfo("Madala", "11", 9.10444, 7.21333);
case 309: return new CityInfo("Madagali", "35", 10.88942, 13.62832);
case 310: return new CityInfo("Lokoja", "41", 7.79688, 6.74048);
case 311: return new CityInfo("Lere", "23", 10.38584, 8.57286);
case 312: return new CityInfo("Lere", "46", 9.71052, 9.34029);
case 313: return new CityInfo("Lemu", "31", 9.39637, 6.02791);
case 314: return new CityInfo("Lekki", "05", 6.40948, 4.09152);
case 315: return new CityInfo("Lau", "43", 9.20827, 11.27541);
case 316: return new CityInfo("Lapai", "31", 9.04439, 6.57089);
case 317: return new CityInfo("Langtang", "49", 9.14164, 9.79101);
case 318: return new CityInfo("Lamurde", "35", 9.60816, 11.79315);
case 319: return new CityInfo("Lame", "46", 10.44154, 9.23955);
case 320: return new CityInfo("Lalupon", "32", 7.46791, 4.06594);
case 321: return new CityInfo("Lagos", "05", 6.45407, 3.39467);
case 322: return new CityInfo("Lafiagi", "30", 8.85299, 5.41641);
case 323: return new CityInfo("Lafia", "56", 8.4939, 8.51532);
case 324: return new CityInfo("Kwolla", "49", 8.90361, 9.29086);
case 325: return new CityInfo("Kwoi", "23", 9.45745, 8.00684);
case 326: return new CityInfo("Kwaya Kusar", "27", 10.50296, 11.84331);
case 327: return new CityInfo("Kwatarkwashi", "57", 12.14082, 6.82196);
case 328: return new CityInfo("Kware", "51", 13.21969, 5.26596);
case 329: return new CityInfo("Kwali", "11", 8.88346, 7.01858);
case 330: return new CityInfo("Kwale", "36", 5.70773, 6.43402);
case 331: return new CityInfo("Kutigi", "31", 9.20103, 5.59498);
case 332: return new CityInfo("Kuta", "31", 9.86864, 6.71042);
case 333: return new CityInfo("Kusheriki", "31", 10.53283, 6.44222);
case 334: return new CityInfo("Kusada", "24", 12.4656, 7.97848);
case 335: return new CityInfo("Kurfi", "24", 12.6663, 7.48478);
case 336: return new CityInfo("Kura", "29", 11.77232, 8.42631);
case 337: return new CityInfo("Kunchi", "29", 12.5026, 8.27092);
case 338: return new CityInfo("Kumo", "55", 10.04807, 11.21055);
case 339: return new CityInfo("Kumbotso", "29", 11.89002, 8.503);
case 340: return new CityInfo("Kumagunnam", "44", 13.15498, 10.63468);
case 341: return new CityInfo("Kukawa", "27", 12.92475, 13.56617);
case 342: return new CityInfo("Kuje", "11", 8.87952, 7.22756);
case 343: return new CityInfo("Kujama", "23", 10.45767, 7.63808);
case 344: return new CityInfo("Kpor", "50", 4.65265, 7.28397);
case 345: return new CityInfo("Koton-Karfe", "41", 8.0912, 6.79782);
case 346: return new CityInfo("Kosubosu", "30", 9.55107, 3.22841);
case 347: return new CityInfo("Kontagora", "31", 10.40319, 5.4708);
case 348: return new CityInfo("Konkwesso", "31", 10.84686, 4.09835);
case 349: return new CityInfo("Konduga", "27", 11.65331, 13.41787);
case 350: return new CityInfo("Koko", "36", 6.00084, 5.45523);
case 351: return new CityInfo("Kiyawa", "39", 11.78442, 9.6069);
case 352: return new CityInfo("Kisi", "32", 9.08297, 3.85196);
case 353: return new CityInfo("Kiru", "29", 11.7021, 8.13481);
case 354: return new CityInfo("Karkarna", "39", 12.76653, 8.50981);
case 355: return new CityInfo("Kiri Kasamma", "39", 12.69273, 10.25456);
case 356: return new CityInfo("Kirfi", "46", 10.40556, 10.40451);
case 357: return new CityInfo("Auyo", "39", 12.33338, 9.93891);
case 358: return new CityInfo("Kibiya", "29", 11.528, 8.66108);
case 359: return new CityInfo("Kende", "40", 11.51966, 4.2603);
case 360: return new CityInfo("Kafin Hausa", "39", 12.23933, 9.91105);
case 361: return new CityInfo("Keffi", "56", 8.84651, 7.87354);
case 362: return new CityInfo("Kebbe", "51", 12.12861, 4.73433);
case 363: return new CityInfo("Keana", "56", 8.14724, 8.79601);
case 364: return new CityInfo("Kazaure", "39", 12.64846, 8.41178);
case 365: return new CityInfo("Kauru", "23", 10.57601, 8.15096);
case 366: return new CityInfo("Kaura Namoda", "57", 12.59371, 6.58648);
case 367: return new CityInfo("Kaugama", "39", 12.47431, 9.73671);
case 368: return new CityInfo("Katsina-Ala", "26", 7.16938, 9.28465);
case 369: return new CityInfo("Katsina", "24", 12.99082, 7.60177);
case 370: return new CityInfo("Katcha", "31", 8.76076, 6.312);
case 371: return new CityInfo("Warji", "46", 11.17756, 9.75241);
case 372: return new CityInfo("Katagum", "46", 12.28507, 10.35027);
case 373: return new CityInfo("Karim Lamido", "43", 9.3143, 11.18731);
case 374: return new CityInfo("Kari", "46", 11.2471, 10.561);
case 375: return new CityInfo("Karaye", "29", 11.7836, 8.01504);
case 376: return new CityInfo("Kano", "29", 12.00012, 8.51672);
case 377: return new CityInfo("Kankia", "24", 12.54637, 7.82254);
case 378: return new CityInfo("Kankara", "24", 11.93114, 7.41115);
case 379: return new CityInfo("Kamba", "40", 11.85172, 3.65478);
case 380: return new CityInfo("Kaltungo", "55", 9.81998, 11.30871);
case 381: return new CityInfo("Kalgo", "40", 12.32666, 4.2004);
case 382: return new CityInfo("Kajuru", "23", 10.32281, 7.68462);
case 383: return new CityInfo("Kaita", "24", 13.08346, 7.74092);
case 384: return new CityInfo("Kangiwa", "40", 12.55339, 3.81814);
case 385: return new CityInfo("Kaiama", "30", 9.6053, 3.94101);
case 386: return new CityInfo("Kaiama", "52", 5.1197, 6.30101);
case 387: return new CityInfo("Kagoro", "23", 9.60776, 8.39043);
case 388: return new CityInfo("Kagarko", "23", 9.4911, 7.69771);
case 389: return new CityInfo("Kagara", "31", 10.18662, 6.25485);
case 390: return new CityInfo("Kafur", "24", 11.64589, 7.69068);
case 391: return new CityInfo("Kafin Madaki", "46", 10.68856, 9.76051);
case 392: return new CityInfo("Kafarati", "55", 10.38304, 11.09567);
case 393: return new CityInfo("Kafanchan", "23", 9.58126, 8.2926);
case 394: return new CityInfo("Lissam", "43", 7.1961, 10.0462);
case 395: return new CityInfo("Kaduna", "23", 10.52641, 7.43879);
case 396: return new CityInfo("Kachia", "23", 9.87342, 7.95407);
case 397: return new CityInfo("Kabo", "29", 11.85606, 8.1702);
case 398: return new CityInfo("Kabba", "41", 7.82719, 6.07502);
case 399: return new CityInfo("Jos", "49", 9.92849, 8.89212);
case 400: return new CityInfo("Jobele", "32", 7.763, 3.91935);
case 401: return new CityInfo("Jimeta", "35", 9.27949, 12.45819);
case 402: return new CityInfo("Jikamshi", "24", 12.17328, 7.77424);
case 403: return new CityInfo("Jibia", "24", 13.09378, 7.22624);
case 404: return new CityInfo("Jega", "40", 12.22336, 4.37971);
case 405: return new CityInfo("Jebba", "30", 9.11972, 4.8236);
case 406: return new CityInfo("Angware", "49", 9.99105, 9.10811);
case 407: return new CityInfo("Jama’are", "46", 11.6698, 9.928);
case 408: return new CityInfo("Jalingo", "43", 8.89367, 11.3596);
case 409: return new CityInfo("Jakusko", "44", 12.37093, 10.77373);
case 410: return new CityInfo("Jajimaji", "44", 12.8985, 10.80688);
case 411: return new CityInfo("Lajere", "44", 11.98022, 11.44002);
case 412: return new CityInfo("Jahun", "39", 12.07629, 9.62757);
case 413: return new CityInfo("Jada", "35", 8.75682, 12.15537);
case 414: return new CityInfo("Iye-Ekiti", "54", 7.95457, 5.23314);
case 415: return new CityInfo("Iyara", "41", 7.84325, 5.97061);
case 416: return new CityInfo("Iwo", "42", 7.63527, 4.18156);
case 417: return new CityInfo("Iwere-Ile", "32", 7.99999, 3.08827);
case 418: return new CityInfo("Itu", "28", 5.46395, 7.33078);
case 419: return new CityInfo("Itu", "21", 5.20131, 7.98373);
case 420: return new CityInfo("Itori", "16", 6.93123, 3.22147);
case 421: return new CityInfo("Obarike-Ito", "26", 7.0245, 8.32358);
case 422: return new CityInfo("Itigidi", "22", 5.89147, 8.02187);
case 423: return new CityInfo("Itas", "46", 11.8575, 9.96394);
case 424: return new CityInfo("Ita-Ogbolu", "48", 7.36838, 5.24684);
case 425: return new CityInfo("Isu", "53", 6.15002, 7.80131);
case 426: return new CityInfo("Issele-Uku", "36", 6.31584, 6.47599);
case 427: return new CityInfo("Isiokolo", "36", 5.59586, 6.00028);
case 428: return new CityInfo("Isieke", "53", 6.38186, 8.03736);
case 429: return new CityInfo("Isua", "48", 7.45361, 5.91047);
case 430: return new CityInfo("Iseyin", "32", 7.97022, 3.59626);
case 431: return new CityInfo("Ise-Ekiti", "54", 7.46478, 5.42333);
case 432: return new CityInfo("Isara", "16", 6.99345, 3.68148);
case 433: return new CityInfo("Isanlu-Itedoijowa", "41", 8.27445, 5.83528);
case 434: return new CityInfo("Isanlu", "41", 8.28823, 5.81837);
case 435: return new CityInfo("Isa", "51", 13.20066, 6.40487);
case 436: return new CityInfo("Iresa-Adu", "32", 8.08747, 4.39264);
case 437: return new CityInfo("Ode-Irele", "48", 6.49418, 4.87036);
case 438: return new CityInfo("Iragbiji", "42", 7.904, 4.68705);
case 439: return new CityInfo("Ipoti", "54", 7.87377, 5.07691);
case 440: return new CityInfo("Ipokia", "16", 6.52499, 2.84246);
case 441: return new CityInfo("Ipetumodu", "42", 7.52152, 4.44477);
case 442: return new CityInfo("Iperu", "16", 6.91002, 3.66557);
case 443: return new CityInfo("Iperindo", "42", 7.50212, 4.82582);
case 444: return new CityInfo("Inisa", "42", 7.84855, 4.32981);
case 445: return new CityInfo("Ingawa", "24", 12.64138, 8.05162);
case 446: return new CityInfo("Ilorin", "30", 8.49664, 4.54214);
case 447: return new CityInfo("Iloffa", "30", 8.09343, 5.14233);
case 448: return new CityInfo("Ilobu", "42", 7.84036, 4.48557);
case 449: return new CityInfo("Illushi", "37", 6.67033, 6.62907);
case 450: return new CityInfo("Illela", "51", 13.73064, 5.29777);
case 451: return new CityInfo("Ilesa", "42", 7.62789, 4.74161);
case 452: return new CityInfo("Ile-Oluji", "48", 7.21309, 4.86902);
case 453: return new CityInfo("Ilemona", "30", 8.10992, 4.66059);
case 454: return new CityInfo("Ile-Ogbo", "42", 7.62129, 4.24531);
case 455: return new CityInfo("Ilawe-Ekiti", "54", 7.59881, 5.1047);
case 456: return new CityInfo("Ilaro", "16", 6.88901, 3.01416);
case 457: return new CityInfo("Ilare", "48", 7.35067, 5.11333);
case 458: return new CityInfo("Ila Orangun", "42", 8.01714, 4.90421);
case 459: return new CityInfo("Ikoyi-Ile", "32", 8.2444, 4.17181);
case 460: return new CityInfo("Ikoyi", "05", 6.45254, 3.43584);
case 461: return new CityInfo("Ikotun", "05", 6.54433, 3.26379);
case 462: return new CityInfo("Ikot Nakanda", "22", 4.88426, 8.48379);
case 463: return new CityInfo("Ikot Ibritam", "21", 4.81171, 7.61401);
case 464: return new CityInfo("Ikot Ekpene", "21", 5.18194, 7.71481);
case 465: return new CityInfo("Afaha Ikot Ebak", "21", 5.12504, 7.65716);
case 466: return new CityInfo("Ikorodu", "05", 6.61526, 3.5069);
case 467: return new CityInfo("Ikom", "22", 5.96669, 8.70632);
case 468: return new CityInfo("Ikole-Ekiti", "54", 7.79148, 5.50865);
case 469: return new CityInfo("Ikirun", "42", 7.91283, 4.66741);
case 470: return new CityInfo("Ikire", "42", 7.36983, 4.1863);
case 471: return new CityInfo("Ikere-Ekiti", "54", 7.49748, 5.23041);
case 472: return new CityInfo("Ikenne", "16", 6.86579, 3.71518);
case 473: return new CityInfo("Ikem", "47", 6.77993, 7.71484);
case 474: return new CityInfo("Ikeja", "05", 6.59651, 3.34205);
case 475: return new CityInfo("Ikare", "48", 7.52591, 5.75342);
case 476: return new CityInfo("Ikara", "23", 11.17511, 8.22466);
case 477: return new CityInfo("Ikang", "22", 4.78978, 8.5316);
case 478: return new CityInfo("Iju", "48", 7.39452, 5.25919);
case 479: return new CityInfo("Ijero-Ekiti", "54", 7.81514, 5.06716);
case 480: return new CityInfo("Ijebu-Ode", "16", 6.81944, 3.91731);
case 481: return new CityInfo("Ijebu-Jesa", "42", 7.68287, 4.81769);
case 482: return new CityInfo("Ijebu-Igbo", "16", 6.97198, 3.99938);
case 483: return new CityInfo("Ijebu-Ife", "16", 6.77837, 4.03386);
case 484: return new CityInfo("Iho", "28", 5.58225, 7.09896);
case 485: return new CityInfo("Ihiala", "25", 5.85475, 6.85944);
case 486: return new CityInfo("Iguobazuwa", "37", 6.56585, 5.35455);
case 487: return new CityInfo("Igumale", "26", 6.79792, 7.96794);
case 488: return new CityInfo("Igede-Ekiti", "54", 7.6685, 5.12627);
case 489: return new CityInfo("Igbo-Ukwu", "25", 6.01798, 7.02027);
case 490: return new CityInfo("Igbor", "26", 7.45123, 8.60805);
case 491: return new CityInfo("Igbo-Ora", "32", 7.43383, 3.28788);
case 492: return new CityInfo("Igbokoda", "48", 6.34842, 4.81135);
case 493: return new CityInfo("Igboho", "32", 8.83784, 3.75628);
case 494: return new CityInfo("Igbeti", "32", 8.74921, 4.13113);
case 495: return new CityInfo("Igbekebo", "48", 6.35894, 4.8652);
case 496: return new CityInfo("Igbara-Oke", "48", 7.41172, 5.05805);
case 497: return new CityInfo("Igbara-Odo", "54", 7.50251, 5.06258);
case 498: return new CityInfo("Igarra", "37", 7.29366, 6.10432);
case 499: return new CityInfo("Igabi", "23", 10.80603, 7.71443);
case 500: return new CityInfo("Ifon", "42", 7.85992, 4.47621);
case 501: return new CityInfo("Ifon", "48", 6.92973, 5.77368);
case 502: return new CityInfo("Ifo", "16", 6.81491, 3.19518);
case 503: return new CityInfo("Ifetedo", "42", 7.18419, 4.70046);
case 504: return new CityInfo("Ile-Ife", "42", 7.4824, 4.56032);
case 505: return new CityInfo("Ifaki", "54", 7.78942, 5.24852);
case 506: return new CityInfo("Idu", "21", 5.03005, 8.01716);
case 507: return new CityInfo("Idogbo", "37", 6.26812, 5.71296);
case 508: return new CityInfo("Idiroko", "16", 6.63187, 2.7472);
case 509: return new CityInfo("Idi-Ayunre", "32", 7.23292, 3.86152);
case 510: return new CityInfo("Ido-Ekiti", "54", 7.84598, 5.18314);
case 511: return new CityInfo("Ido", "32", 7.47103, 3.7574);
case 512: return new CityInfo("Idanre", "48", 7.1127, 5.1159);
case 513: return new CityInfo("Idah", "41", 7.11345, 6.73866);
case 514: return new CityInfo("Icheu", "41", 7.7067, 6.7718);
case 515: return new CityInfo("Ibokun", "42", 7.78737, 4.72958);
case 516: return new CityInfo("Iboko", "53", 6.40655, 8.23329);
case 517: return new CityInfo("Ibi", "43", 8.18122, 9.74431);
case 518: return new CityInfo("Ibeto", "31", 10.48536, 5.14501);
case 519: return new CityInfo("Ibagwa-Aka", "47", 6.91854, 7.39895);
case 520: return new CityInfo("Ibadan", "32", 7.37756, 3.90591);
case 521: return new CityInfo("Hunkuyi", "23", 11.2668, 7.64916);
case 522: return new CityInfo("Hong", "35", 10.23305, 12.92805);
case 523: return new CityInfo("Holma", "35", 9.89863, 13.0545);
case 524: return new CityInfo("Hinna", "55", 10.30426, 11.49905);
case 525: return new CityInfo("Hadejia", "39", 12.45347, 10.04115);
case 526: return new CityInfo("Gwoza", "27", 11.08313, 13.69595);
case 527: return new CityInfo("Ugwolawo", "41", 7.23672, 6.92302);
case 528: return new CityInfo("Gwiwa", "39", 12.78169, 8.33722);
case 529: return new CityInfo("Gwio Kura", "44", 12.67479, 11.0669);
case 530: return new CityInfo("Gwasero", "30", 9.48333, 3.5);
case 531: return new CityInfo("Gwarzo", "29", 11.91597, 7.9337);
case 532: return new CityInfo("Gwaram", "39", 11.27727, 9.88385);
case 533: return new CityInfo("Gwaram", "46", 10.23295, 10.28572);
case 534: return new CityInfo("Gwantu", "23", 9.22899, 8.45807);
case 535: return new CityInfo("Gwandu", "40", 12.50204, 4.64295);
case 536: return new CityInfo("Gwagwalada", "11", 8.94342, 7.08165);
case 537: return new CityInfo("Gwadabawa", "51", 13.35819, 5.23812);
case 538: return new CityInfo("Guyuk", "35", 9.90663, 11.92753);
case 539: return new CityInfo("Gusau", "57", 12.17024, 6.66412);
case 540: return new CityInfo("Guri", "39", 12.7281, 10.41989);
case 541: return new CityInfo("Gummi", "57", 12.14484, 5.11776);
case 542: return new CityInfo("Gumel", "39", 12.6269, 9.38807);
case 543: return new CityInfo("Gulma", "40", 12.64231, 4.35545);
case 544: return new CityInfo("Gulak", "35", 10.8053, 13.45824);
case 545: return new CityInfo("Gujba", "44", 11.49959, 11.93396);
case 546: return new CityInfo("Gudumbali", "27", 12.94284, 13.17831);
case 547: return new CityInfo("Gubio", "27", 12.49749, 12.78089);
case 548: return new CityInfo("Goronyo", "51", 13.44226, 5.67234);
case 549: return new CityInfo("Gorgoram", "44", 12.63958, 10.70422);
case 550: return new CityInfo("Gora", "24", 11.91294, 7.66531);
case 551: return new CityInfo("Goniri", "44", 11.48451, 12.31264);
case 552: return new CityInfo("Gombi", "35", 10.16756, 12.73684);
case 553: return new CityInfo("Gombe", "55", 10.28969, 11.16729);
case 554: return new CityInfo("Giwa", "23", 11.31568, 7.44957);
case 555: return new CityInfo("Girei", "35", 9.36526, 12.54621);
case 556: return new CityInfo("Gidan Madi", "51", 13.29575, 4.97467);
case 557: return new CityInfo("Giade", "46", 11.39083, 10.19987);
case 558: return new CityInfo("Gezawa", "29", 12.10157, 8.75029);
case 559: return new CityInfo("Gembu", "43", 6.72556, 11.25652);
case 560: return new CityInfo("Gella", "35", 10.15738, 13.30004);
case 561: return new CityInfo("Geidam", "44", 12.89439, 11.92649);
case 562: return new CityInfo("Buruku", "26", 7.45961, 9.20455);
case 563: return new CityInfo("Gbongan", "42", 7.47734, 4.35351);
case 564: return new CityInfo("Gboko", "26", 7.32275, 9.00108);
case 565: return new CityInfo("Gbajimba", "26", 7.8204, 8.85955);
case 566: return new CityInfo("Gaya", "29", 11.86064, 9.0027);
case 567: return new CityInfo("Gassol", "43", 8.53535, 10.44615);
case 568: return new CityInfo("Gashua", "44", 12.87398, 11.04057);
case 569: return new CityInfo("Garun Malam", "29", 11.68566, 8.36986);
case 570: return new CityInfo("Garko", "29", 11.64974, 8.80328);
case 571: return new CityInfo("Garko", "55", 10.17506, 11.16458);
case 572: return new CityInfo("Garki", "39", 12.43456, 9.19028);
case 573: return new CityInfo("Garaku", "56", 8.84717, 8.13021);
case 574: return new CityInfo("Ganye", "35", 8.43497, 12.05107);
case 575: return new CityInfo("Gantsa", "39", 11.66312, 9.72639);
case 576: return new CityInfo("Gandi", "51", 12.96358, 5.74337);
case 577: return new CityInfo("Gamboru", "27", 12.37299, 14.2069);
case 578: return new CityInfo("Gamawa", "46", 12.13379, 10.53785);
case 579: return new CityInfo("Gakem", "22", 6.76963, 8.9912);
case 580: return new CityInfo("Gajiram", "27", 12.49149, 13.21191);
case 581: return new CityInfo("Gagarawa", "39", 12.40848, 9.52881);
case 582: return new CityInfo("Gada", "51", 13.7543, 5.65723);
case 583: return new CityInfo("Gabarin", "46", 11.1093, 10.4441);
case 584: return new CityInfo("Funtua", "24", 11.52351, 7.31174);
case 585: return new CityInfo("Fugar", "37", 7.09076, 6.49828);
case 586: return new CityInfo("Fufu", "30", 8.44838, 4.72077);
case 587: return new CityInfo("Fufore", "35", 9.22175, 12.64975);
case 588: return new CityInfo("Fika", "44", 11.28674, 11.30772);
case 589: return new CityInfo("Fiditi", "32", 7.71361, 3.91722);
case 590: return new CityInfo("Faskari", "24", 11.72108, 7.02991);
case 591: return new CityInfo("Ezza-Ohu", "53", 6.44094, 8.08432);
case 592: return new CityInfo("Ezzamgbo", "53", 6.39895, 7.96155);
case 593: return new CityInfo("Etinan", "21", 4.84262, 7.85252);
case 594: return new CityInfo("Ete", "47", 7.08956, 7.45341);
case 595: return new CityInfo("Esuk Oron", "21", 4.80293, 8.25341);
case 596: return new CityInfo("Eruwa", "32", 7.53365, 3.41796);
case 597: return new CityInfo("Epe", "05", 6.58412, 3.98336);
case 598: return new CityInfo("Enwang", "21", 4.65643, 8.25206);
case 599: return new CityInfo("Umunze", "25", 5.96694, 7.23664);
case 600: return new CityInfo("Enugu-Ukwu", "25", 6.17146, 7.00525);
case 601: return new CityInfo("Enugu-Ezike", "47", 6.9827, 7.45534);
case 602: return new CityInfo("Enugu", "47", 6.44132, 7.49883);
case 603: return new CityInfo("Enagi", "31", 9.12734, 5.54387);
case 604: return new CityInfo("Emure-Ekiti", "54", 7.43636, 5.45925);
case 605: return new CityInfo("Emuoha", "50", 4.884, 6.8601);
case 606: return new CityInfo("Elele", "50", 5.1009, 6.81411);
case 607: return new CityInfo("Ekpoma", "37", 6.743, 6.14029);
case 608: return new CityInfo("Eket", "21", 4.64231, 7.92438);
case 609: return new CityInfo("Ekeremor", "52", 5.05805, 5.78048);
case 610: return new CityInfo("Ejirin", "05", 6.61423, 3.90019);
case 611: return new CityInfo("Ejigbo", "42", 7.90292, 4.31419);
case 612: return new CityInfo("Ehor", "37", 6.6155, 5.98238);
case 613: return new CityInfo("Eha Amufu", "47", 6.65915, 7.75961);
case 614: return new CityInfo("Egbeda", "32", 7.3772, 4.04975);
case 615: return new CityInfo("Egbe", "41", 8.21667, 5.51667);
case 616: return new CityInfo("Effurun", "36", 5.55629, 5.78459);
case 617: return new CityInfo("Efon-Alaaye", "54", 7.65649, 4.92235);
case 618: return new CityInfo("Effium", "53", 6.63105, 8.05814);
case 619: return new CityInfo("Effraya", "22", 5.85926, 8.72301);
case 620: return new CityInfo("Ede", "42", 7.73635, 4.43536);
case 621: return new CityInfo("Ebute-Metta", "05", 6.48799, 3.38166);
case 622: return new CityInfo("Ebute Ikorodu", "05", 6.60086, 3.48818);
case 623: return new CityInfo("Eberi", "50", 5.09117, 7.2337);
case 624: return new CityInfo("Ebem Ohafia", "45", 5.63108, 7.83024);
case 625: return new CityInfo("Dutsin-Ma", "24", 12.45392, 7.49723);
case 626: return new CityInfo("Dutsi", "24", 12.82862, 8.1398);
case 627: return new CityInfo("Dutsen Wai", "23", 10.85009, 8.199);
case 628: return new CityInfo("Dutse", "39", 11.75618, 9.33896);
case 629: return new CityInfo("Malam Madori", "39", 12.56473, 9.88084);
case 630: return new CityInfo("Duku", "31", 11.2361, 4.90727);
case 631: return new CityInfo("Dukku", "55", 10.82379, 10.77221);
case 632: return new CityInfo("Donga", "43", 7.72175, 10.04526);
case 633: return new CityInfo("Doma", "56", 8.39307, 8.35544);
case 634: return new CityInfo("Disina", "46", 11.48135, 9.91903);
case 635: return new CityInfo("Dindima", "46", 10.22629, 10.15132);
case 636: return new CityInfo("Dikwa", "27", 12.03609, 13.91815);
case 637: return new CityInfo("Dikenafai", "28", 5.77015, 7.15473);
case 638: return new CityInfo("Dengi", "49", 9.36872, 9.96223);
case 639: return new CityInfo("Demsa", "35", 9.45566, 12.15249);
case 640: return new CityInfo("Dekina", "41", 7.68967, 7.0438);
case 641: return new CityInfo("Degema", "50", 4.74807, 6.76618);
case 642: return new CityInfo("Deba", "55", 10.21187, 11.3871);
case 643: return new CityInfo("Dawakin Tofa", "29", 12.10452, 8.32999);
case 644: return new CityInfo("Dawakin Kudu", "29", 11.83727, 8.59699);
case 645: return new CityInfo("Daura", "24", 13.03299, 8.32351);
case 646: return new CityInfo("Daura", "44", 11.5541, 11.406);
case 647: return new CityInfo("Darazo", "46", 10.9992, 10.41062);
case 648: return new CityInfo("Dapchi", "44", 12.49536, 11.49977);
case 649: return new CityInfo("Dan Sadau", "57", 11.29621, 6.4952);
case 650: return new CityInfo("Dan Musa", "24", 12.26157, 7.33409);
case 651: return new CityInfo("Dankama", "24", 13.29782, 7.79492);
case 652: return new CityInfo("Dankalwa", "44", 11.74449, 12.18545);
case 653: return new CityInfo("Danja", "24", 11.3771, 7.56097);
case 654: return new CityInfo("Dan Gora", "29", 11.53485, 8.15224);
case 655: return new CityInfo("Dange", "51", 12.85313, 5.34572);
case 656: return new CityInfo("Dandume", "24", 11.4588, 7.12602);
case 657: return new CityInfo("Damboa", "27", 11.15534, 12.75638);
case 658: return new CityInfo("Dambatta", "29", 12.435, 8.51531);
case 659: return new CityInfo("Dambam", "46", 11.67893, 10.70792);
case 660: return new CityInfo("Damaturu", "44", 11.74697, 11.96083);
case 661: return new CityInfo("Damasak", "27", 13.10518, 12.50854);
case 662: return new CityInfo("Damagum", "44", 11.67824, 11.33517);
case 663: return new CityInfo("Dakingari", "40", 11.64809, 4.06177);
case 664: return new CityInfo("Dadiya", "55", 9.61667, 11.43333);
case 665: return new CityInfo("Dabai", "40", 11.47651, 5.20625);
case 666: return new CityInfo("Chibok", "27", 10.86949, 12.84657);
case 667: return new CityInfo("Charanchi", "24", 12.67155, 7.72929);
case 668: return new CityInfo("Tsafe", "57", 11.95775, 6.92083);
case 669: return new CityInfo("Calabar", "22", 4.95893, 8.32695);
case 670: return new CityInfo("Bwari", "11", 9.27995, 7.38045);
case 671: return new CityInfo("Burutu", "36", 5.35328, 5.50826);
case 672: return new CityInfo("Burumburum", "23", 11.39106, 8.72341);
case 673: return new CityInfo("Bununu", "46", 9.88224, 9.68058);
case 674: return new CityInfo("Dass", "46", 10.00065, 9.51596);
case 675: return new CityInfo("Bunkure", "29", 11.69924, 8.54127);
case 676: return new CityInfo("Bungudu", "57", 12.26848, 6.55288);
case 677: return new CityInfo("Bukuru", "49", 9.79399, 8.86397);
case 678: return new CityInfo("Bukkuyum", "57", 12.1372, 5.46821);
case 679: return new CityInfo("Buguma", "50", 4.73614, 6.86236);
case 680: return new CityInfo("Buga", "56", 8.49056, 7.34139);
case 681: return new CityInfo("Briyel", "27", 10.34764, 11.6099);
case 682: return new CityInfo("Twon-Brass", "52", 4.31231, 6.24091);
case 683: return new CityInfo("Bornu Yassu", "27", 12.27503, 12.56856);
case 684: return new CityInfo("Bori", "50", 4.67629, 7.36519);
case 685: return new CityInfo("Ugbokpo", "26", 7.65321, 7.8841);
case 686: return new CityInfo("Bonny", "50", 4.4516, 7.17074);
case 687: return new CityInfo("Bomadi", "36", 5.16073, 5.92375);
case 688: return new CityInfo("Bokkos", "49", 9.29921, 8.99467);
case 689: return new CityInfo("Bokani", "31", 9.43333, 5.2);
case 690: return new CityInfo("Boju", "26", 7.35572, 7.89303);
case 691: return new CityInfo("Boje", "22", 6.28428, 8.92062);
case 692: return new CityInfo("Boi", "46", 9.56109, 9.50154);
case 693: return new CityInfo("Bogoro", "46", 9.66904, 9.60528);
case 694: return new CityInfo("Bodinga", "51", 12.84413, 5.15001);
case 695: return new CityInfo("Bode Saadu", "30", 8.939, 4.78227);
case 696: return new CityInfo("Bode Osi", "42", 7.75103, 4.2298);
case 697: return new CityInfo("Biu", "27", 10.61285, 12.19458);
case 698: return new CityInfo("Mallam Fatori", "27", 13.6746, 13.33952);
case 699: return new CityInfo("Birniwa", "39", 12.7907, 10.23614);
case 700: return new CityInfo("Birnin Kudu", "39", 11.45207, 9.47856);
case 701: return new CityInfo("Birnin Kebbi", "40", 12.45389, 4.1975);
case 702: return new CityInfo("Sofo-Birnin-Gwari", "23", 11.01537, 6.78036);
case 703: return new CityInfo("Birnin Gwari", "23", 10.66374, 6.54003);
case 704: return new CityInfo("Bin Yauri", "40", 10.7823, 4.81135);
case 705: return new CityInfo("Binji", "51", 13.22294, 4.90888);
case 706: return new CityInfo("Bindawa", "24", 12.66987, 7.80865);
case 707: return new CityInfo("Billiri", "55", 9.89024, 11.21794);
case 708: return new CityInfo("Billiri", "55", 9.86545, 11.22624);
case 709: return new CityInfo("Bida", "31", 9.08044, 6.0099);
case 710: return new CityInfo("Bichi", "29", 12.23385, 8.24063);
case 711: return new CityInfo("Besse", "40", 11.26676, 4.43114);
case 712: return new CityInfo("Benisheikh", "27", 11.80919, 12.49151);
case 713: return new CityInfo("Benin City", "37", 6.33815, 5.62575);
case 714: return new CityInfo("Bende", "45", 5.55874, 7.63359);
case 715: return new CityInfo("Bena", "40", 11.28444, 5.93472);
case 716: return new CityInfo("Beli", "43", 7.85868, 10.97187);
case 717: return new CityInfo("Bebeji", "29", 11.66768, 8.262);
case 718: return new CityInfo("Baure", "24", 12.83772, 8.74513);
case 719: return new CityInfo("Bauchi", "46", 10.31032, 9.84388);
case 720: return new CityInfo("Batsari", "24", 12.75551, 7.24809);
case 721: return new CityInfo("Batagarawa", "24", 12.90611, 7.60586);
case 722: return new CityInfo("Bassa", "49", 9.94249, 8.74042);
case 723: return new CityInfo("Baro", "31", 8.61565, 6.4185);
case 724: return new CityInfo("Barkin Ladi", "49", 9.53812, 8.8927);
case 725: return new CityInfo("Bara", "44", 10.93605, 11.68242);
case 726: return new CityInfo("Bara", "55", 10.37444, 10.72884);
case 727: return new CityInfo("Bama", "27", 11.52134, 13.68952);
case 728: return new CityInfo("Balle", "51", 13.47029, 4.68119);
case 729: return new CityInfo("Bakura", "57", 12.71141, 5.87367);
case 730: return new CityInfo("Bakori", "24", 11.55559, 7.42419);
case 731: return new CityInfo("Bajoga", "55", 10.85152, 11.43169);
case 732: return new CityInfo("Baissa", "43", 7.23087, 10.62444);
case 733: return new CityInfo("Bagwai", "29", 12.1577, 8.1358);
case 734: return new CityInfo("Bagudo", "40", 11.40351, 4.22571);
case 735: return new CityInfo("Bugana", "41", 7.99917, 7.58361);
case 736: return new CityInfo("Obagaji", "26", 7.89169, 7.90938);
case 737: return new CityInfo("Badeggi", "31", 9.0563, 6.143);
case 738: return new CityInfo("Badagry", "05", 6.41502, 2.88132);
case 739: return new CityInfo("Babura", "39", 12.77256, 9.01525);
case 740: return new CityInfo("Babban Gida", "44", 12.15482, 11.7709);
case 741: return new CityInfo("Babana", "31", 10.42949, 3.81495);
case 742: return new CityInfo("Azare", "46", 11.67478, 10.19069);
case 743: return new CityInfo("Awo-Idemili", "28", 5.82648, 6.93374);
case 744: return new CityInfo("Awo", "42", 7.76764, 4.39515);
case 745: return new CityInfo("Awka", "25", 6.21269, 7.07199);
case 746: return new CityInfo("Awgu", "47", 6.07278, 7.47739);
case 747: return new CityInfo("Awe", "56", 8.10445, 9.14011);
case 748: return new CityInfo("Auna", "31", 10.18805, 4.72318);
case 749: return new CityInfo("Augie", "40", 12.89027, 4.59965);
case 750: return new CityInfo("Auchi", "37", 7.06756, 6.2636);
case 751: return new CityInfo("Atani", "25", 6.01277, 6.74768);
case 752: return new CityInfo("Askira", "27", 10.65086, 12.90883);
case 753: return new CityInfo("Azare", "27", 10.52583, 12.29115);
case 754: return new CityInfo("Asaba", "36", 6.19824, 6.73187);
case 755: return new CityInfo("Arochukwu", "45", 5.38941, 7.91235);
case 756: return new CityInfo("Argungu", "40", 12.74482, 4.52514);
case 757: return new CityInfo("Araromi-Opin", "30", 8.06527, 5.25398);
case 758: return new CityInfo("Aramoko-Ekiti", "54", 7.70483, 5.04054);
case 759: return new CityInfo("Apomu", "42", 7.35156, 4.18335);
case 760: return new CityInfo("Apapa", "05", 6.4488, 3.35901);
case 761: return new CityInfo("Ankpa", "41", 7.40249, 7.63196);
case 762: return new CityInfo("Anka", "57", 12.11347, 5.92681);
case 763: return new CityInfo("Anchau", "23", 10.96245, 8.39233);
case 764: return new CityInfo("Anaku", "25", 6.46875, 6.92893);
case 765: return new CityInfo("Amper", "49", 9.35509, 9.70121);
case 766: return new CityInfo("Amaigbo", "28", 5.73016, 7.1151);
case 767: return new CityInfo("Amassoma", "52", 4.97032, 6.10915);
case 768: return new CityInfo("Umundugba", "28", 5.67597, 7.07184);
case 769: return new CityInfo("Amaigbo", "45", 5.78917, 7.83829);
case 770: return new CityInfo("Amagunze", "47", 6.33063, 7.65247);
case 771: return new CityInfo("Alkaleri", "46", 10.26688, 10.33238);
case 772: return new CityInfo("Aliero", "40", 12.28835, 4.47139);
case 773: return new CityInfo("Aliade", "26", 7.29627, 8.48278);
case 774: return new CityInfo("Albasu", "29", 11.67403, 9.14059);
case 775: return new CityInfo("Alapa", "32", 8.61667, 4.38333);
case 776: return new CityInfo("Akwukwu-Igbo", "36", 6.35753, 6.59066);
case 777: return new CityInfo("Akwete", "45", 4.88688, 7.35686);
case 778: return new CityInfo("Akwanga", "56", 8.91077, 8.40655);
case 779: return new CityInfo("Akure", "48", 7.25256, 5.19312);
case 780: return new CityInfo("Aku", "47", 6.70902, 7.31826);
case 781: return new CityInfo("Akodo", "05", 6.43787, 3.9309);
case 782: return new CityInfo("Akko", "55", 10.28899, 10.9732);
case 783: return new CityInfo("Ake-Eze", "47", 5.91677, 7.67615);
case 784: return new CityInfo("Akanran", "32", 7.28075, 4.02557);
case 785: return new CityInfo("Akamkpa", "22", 5.31246, 8.35515);
case 786: return new CityInfo("Akankpa", "22", 5.1264, 8.1898);
case 787: return new CityInfo("Ajingi", "29", 11.96826, 9.03679);
case 788: return new CityInfo("Ajaawa", "32", 7.93118, 4.12654);
case 789: return new CityInfo("Ajasse Ipo", "30", 8.23333, 4.81667);
case 790: return new CityInfo("Ajaokuta", "41", 7.56229, 6.65497);
case 791: return new CityInfo("Ajalli", "25", 6.04427, 7.20864);
case 792: return new CityInfo("Ajaka", "41", 7.17416, 6.82535);
case 793: return new CityInfo("Ayetoro", "16", 7.24281, 3.02639);
case 794: return new CityInfo("Ayete", "32", 7.54286, 3.22263);
case 795: return new CityInfo("Ahoada", "50", 5.0828, 6.64981);
case 796: return new CityInfo("Agwara", "31", 10.70611, 4.58125);
case 797: return new CityInfo("Agulu", "25", 6.10045, 7.061);
case 798: return new CityInfo("Aguata", "25", 6.01634, 7.08782);
case 799: return new CityInfo("Akpet Central", "22", 5.62105, 8.10163);
case 800: return new CityInfo("Ago-Are", "32", 8.50442, 3.42134);
case 801: return new CityInfo("Ago-Amodu", "32", 8.62314, 3.61419);
case 802: return new CityInfo("Agenebode", "37", 7.10512, 6.69381);
case 803: return new CityInfo("Agege", "05", 6.61563, 3.33337);
case 804: return new CityInfo("Agbor", "36", 6.25375, 6.1942);
case 805: return new CityInfo("Tse-Agberagba", "26", 7.07668, 8.66551);
case 806: return new CityInfo("Agbani", "47", 6.30669, 7.54862);
case 807: return new CityInfo("Agbabu", "48", 6.58862, 4.8343);
case 808: return new CityInfo("Agaie", "31", 9.0085, 6.31821);
case 809: return new CityInfo("Afuze", "37", 6.96945, 6.04254);
case 810: return new CityInfo("Afon", "30", 8.31313, 4.52738);
case 811: return new CityInfo("Afikpo", "53", 5.89258, 7.93534);
case 812: return new CityInfo("Afam", "50", 4.79004, 7.31187);
case 813: return new CityInfo("Afaha Offiong", "21", 4.86226, 7.90626);
case 814: return new CityInfo("Adoru", "41", 6.97694, 7.16262);
case 815: return new CityInfo("Ado-Odo", "16", 6.59546, 2.94176);
case 816: return new CityInfo("Adogo", "41", 7.51004, 6.4798);
case 817: return new CityInfo("Ado-Ekiti", "54", 7.62329, 5.22087);
case 818: return new CityInfo("Adikpo", "26", 6.89002, 9.23351);
case 819: return new CityInfo("Adani", "47", 6.73971, 7.01117);
case 820: return new CityInfo("Achalla", "25", 6.33465, 6.98863);
case 821: return new CityInfo("Abuochiche", "22", 6.69132, 8.94337);
case 822: return new CityInfo("Abuja", "11", 9.05785, 7.49508);
case 823: return new CityInfo("Abudu", "37", 6.29489, 6.02995);
case 824: return new CityInfo("Abua", "50", 4.85763, 6.64519);
case 825: return new CityInfo("Abraka", "36", 5.79023, 6.10473);
case 826: return new CityInfo("Abonnema", "50", 4.73171, 6.77223);
case 827: return new CityInfo("Aboh", "36", 5.54781, 6.52588);
case 828: return new CityInfo("Abocho", "41", 7.5677, 6.9863);
case 829: return new CityInfo("Abigi", "16", 6.48676, 4.39531);
case 830: return new CityInfo("Abeokuta", "16", 7.15571, 3.34509);
case 831: return new CityInfo("Abejukolo", "41", 7.86808, 7.50907);
case 832: return new CityInfo("Abakaliki", "53", 6.32485, 8.11368);
case 833: return new CityInfo("Abak", "21", 4.98236, 7.78922);
case 834: return new CityInfo("Abaji", "11", 8.47372, 6.94453);
case 835: return new CityInfo("Abagana", "25", 6.19031, 6.99357);
case 836: return new CityInfo("Aba", "45", 5.10658, 7.36667);
case 837: return new CityInfo("Ajegunle", "05", 6.45197, 3.33115);
case 838: return new CityInfo("Ojota", "05", 6.57806, 3.38686);
case 839: return new CityInfo("Ifako", "05", 6.64423, 3.32488);
case 840: return new CityInfo("Degema Hulk", "50", 4.76145, 6.74957);
case 841: return new CityInfo("Yana", "46", 11.40724, 10.01345);
case 842: return new CityInfo("Buni Yadi", "44", 11.27441, 12.00852);
case 843: return new CityInfo("Obangede", "41", 7.62066, 6.19928);
case 844: return new CityInfo("Naka", "26", 7.58331, 8.2044);
case 845: return new CityInfo("Ezillo", "53", 6.4293, 7.81787);
case 846: return new CityInfo("Koguna", "29", 12.38137, 8.45733);
case 847: return new CityInfo("Nasko", "31", 10.49539, 4.89904);
case 848: return new CityInfo("Oghara", "36", 5.93554, 5.6661);
case 849: return new CityInfo("Abat", "21", 4.61712, 7.86639);
case 850: return new CityInfo("Urua Inyang", "21", 5.02309, 7.53895);
case 851: return new CityInfo("Ibiaku Ntok Okpo", "21", 5.30857, 7.71106);
case 852: return new CityInfo("Irrua", "37", 6.73634, 6.21984);
case 853: return new CityInfo("Igueben", "37", 6.60183, 6.24276);
case 854: return new CityInfo("Umumma", "28", 5.7569, 6.94613);
case 855: return new CityInfo("Akinima", "50", 5.08536, 6.46633);
case 856: return new CityInfo("Umuguma", "28", 5.46783, 6.96594);
case 857: return new CityInfo("Sabon Garin Nangere", "44", 11.84945, 11.0733);
case 858: return new CityInfo("Aguobu-Owa", "47", 6.37229, 7.27178);
case 859: return new CityInfo("Ugbodo", "53", 6.51155, 8.12984);
case 860: return new CityInfo("Onueke", "53", 6.15537, 8.03735);
case 861: return new CityInfo("Lessel", "26", 7.12729, 9.01981);
case 862: return new CityInfo("Festac Town", "05", 6.4697, 3.28299);
case 863: return new CityInfo("Atan", "16", 6.89456, 4.00715);
case 864: return new CityInfo("Okuku", "42", 8.01807, 4.67253);
case 865: return new CityInfo("Iyana-Ofa", "32", 7.49869, 4.08093);
case 866: return new CityInfo("Mashegu", "31", 9.97213, 5.77886);
case 867: return new CityInfo("Bangi", "31", 10.83368, 5.82688);
case 868: return new CityInfo("Gawu Babangida", "31", 9.27827, 6.99335);
case 869: return new CityInfo("Sabon Wuse", "31", 9.33424, 7.26114);
case 870: return new CityInfo("Birnin Magaji", "57", 12.5592, 6.89459);
case 871: return new CityInfo("Warawa", "29", 11.86621, 8.70146);
case 872: return new CityInfo("Kaura", "23", 9.66812, 8.45825);
case 873: return new CityInfo("Karu", "56", 9.00943, 7.66147);
case 874: return new CityInfo("Akpafa", "41", 7.47192, 6.14979);
case 875: return new CityInfo("Nkwo Nike", "47", 6.50921, 7.51006);
case 876: return new CityInfo("Isiaka", "53", 5.86265, 7.54622);
case 877: return new CityInfo("Obiozara", "53", 6.04644, 7.77273);
case 878: return new CityInfo("Onuebonyi Echara", "53", 6.0954, 8.15157);
case 879: return new CityInfo("Nwaorieubi", "28", 5.58182, 7.01651);
case 880: return new CityInfo("Aboh", "28", 5.47569, 7.27161);
case 881: return new CityInfo("Egbema", "28", 5.54435, 6.7609);
case 882: return new CityInfo("Isinweke", "28", 5.62048, 7.34985);
case 883: return new CityInfo("Nnenasa", "28", 5.73262, 7.01364);
case 884: return new CityInfo("Oke-Ikpe", "45", 4.91301, 7.31936);
case 885: return new CityInfo("Osisioma", "45", 5.15979, 7.32235);
case 886: return new CityInfo("Omoba", "45", 5.24268, 7.40623);
case 887: return new CityInfo("Okpuala-Ngwa", "45", 5.3571, 7.38765);
case 888: return new CityInfo("Nkwoagu Isuochi", "45", 5.99125, 7.39445);
case 889: return new CityInfo("Isiala Oboro", "45", 5.40632, 7.56816);
case 890: return new CityInfo("Ogbia", "52", 4.68836, 6.31525);
case 891: return new CityInfo("Upenekang", "21", 4.57064, 7.97955);
case 892: return new CityInfo("Ikot Edibon", "21", 4.77022, 7.931);
case 893: return new CityInfo("Ikot Akpa Nkuk", "21", 4.87231, 7.56459);
case 894: return new CityInfo("Eyofin", "21", 4.7516, 8.23056);
case 895: return new CityInfo("Urue Offong", "21", 4.75275, 8.1677);
case 896: return new CityInfo("Mabudi", "49", 8.73037, 9.78512);
case 897: return new CityInfo("Tunkus", "49", 9.02167, 9.61384);
case 898: return new CityInfo("Baap", "49", 8.94321, 9.24126);
case 899: return new CityInfo("Kwal", "49", 9.37128, 9.6192);
case 900: return new CityInfo("Boh", "55", 9.78187, 11.27882);
case 901: return new CityInfo("Kanamma", "44", 13.09969, 12.1079);
case 902: return new CityInfo("Khaddamari", "27", 11.92589, 13.23062);
case 903: return new CityInfo("Sunkani", "43", 8.70298, 11.25757);
case 904: return new CityInfo("Saakpenwa", "50", 4.71677, 7.263);
case 905: return new CityInfo("Nchia", "50", 4.79309, 7.12061);
default: return new CityInfo("Rumuodomaya", "50", 4.89333, 7.00228);

                                    }                                        
                                }
                            
                        }
                    }
                