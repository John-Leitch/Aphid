
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
                                    public const string Country = "PS";
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
                            
                                        var cur = (Math.Abs(31.25997 - lat) + Math.Abs(34.2826 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(31.29722 - lat) + Math.Abs(34.24357 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.44861 - lat) + Math.Abs(34.3925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.30675 - lat) + Math.Abs(34.3611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.34018 - lat) + Math.Abs(34.30627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.5272 - lat) + Math.Abs(34.48347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.50161 - lat) + Math.Abs(34.46672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.41834 - lat) + Math.Abs(34.34933 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.5464 - lat) + Math.Abs(34.49514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.5353 - lat) + Math.Abs(34.53579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.34337 - lat) + Math.Abs(34.32337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.29278 - lat) + Math.Abs(34.33061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.43944 - lat) + Math.Abs(34.40306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.31913 - lat) + Math.Abs(34.34005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.54346 - lat) + Math.Abs(35.22274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.45077 - lat) + Math.Abs(35.12958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.3856 - lat) + Math.Abs(35.05122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.13698 - lat) + Math.Abs(35.18595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.37596 - lat) + Math.Abs(35.23166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.24611 - lat) + Math.Abs(35.2265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.67361 - lat) + Math.Abs(35.25662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.4459 - lat) + Math.Abs(35.09443 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.10889 - lat) + Math.Abs(35.26909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.10841 - lat) + Math.Abs(35.23784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.29688 - lat) + Math.Abs(35.27757 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.9733 - lat) + Math.Abs(35.24516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.44566 - lat) + Math.Abs(35.16822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.70701 - lat) + Math.Abs(35.10366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.15949 - lat) + Math.Abs(35.22228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.00889 - lat) + Math.Abs(35.16461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.43234 - lat) + Math.Abs(35.34418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.15363 - lat) + Math.Abs(35.27646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.03538 - lat) + Math.Abs(35.28564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.46884 - lat) + Math.Abs(35.15247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.31156 - lat) + Math.Abs(35.0269 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.32091 - lat) + Math.Abs(35.36989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.51956 - lat) + Math.Abs(35.21966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.34042 - lat) + Math.Abs(35.39604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.57551 - lat) + Math.Abs(35.01223 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.28347 - lat) + Math.Abs(35.38367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.27056 - lat) + Math.Abs(35.29496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.20068 - lat) + Math.Abs(35.21293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.08664 - lat) + Math.Abs(35.29094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.53855 - lat) + Math.Abs(35.04966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.65078 - lat) + Math.Abs(35.06439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.93709 - lat) + Math.Abs(35.20321 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.32828 - lat) + Math.Abs(35.29134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.36342 - lat) + Math.Abs(35.31529 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.03334 - lat) + Math.Abs(35.26545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.97625 - lat) + Math.Abs(35.2613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.31934 - lat) + Math.Abs(35.18418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.50847 - lat) + Math.Abs(35.22752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.57855 - lat) + Math.Abs(35.14017 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.98695 - lat) + Math.Abs(35.04012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.27551 - lat) + Math.Abs(35.08135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.97327 - lat) + Math.Abs(35.04976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.38489 - lat) + Math.Abs(35.11856 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.10447 - lat) + Math.Abs(35.09198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.2097 - lat) + Math.Abs(35.19147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.35608 - lat) + Math.Abs(35.24537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.12877 - lat) + Math.Abs(35.04652 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.20962 - lat) + Math.Abs(35.33034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.08371 - lat) + Math.Abs(35.18079 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.26225 - lat) + Math.Abs(35.11028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.90563 - lat) + Math.Abs(35.06094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.27562 - lat) + Math.Abs(35.19873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.52451 - lat) + Math.Abs(35.2048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.19061 - lat) + Math.Abs(35.29332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.9424 - lat) + Math.Abs(35.10773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.02797 - lat) + Math.Abs(35.01879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.93342 - lat) + Math.Abs(35.29821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.2852 - lat) + Math.Abs(35.14951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.89964 - lat) + Math.Abs(35.20422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.07806 - lat) + Math.Abs(35.04417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.87096 - lat) + Math.Abs(35.19182 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.38679 - lat) + Math.Abs(35.38298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.08543 - lat) + Math.Abs(35.33005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.23829 - lat) + Math.Abs(35.18297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.12214 - lat) + Math.Abs(35.17173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.97734 - lat) + Math.Abs(35.00984 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.83366 - lat) + Math.Abs(35.11894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.07004 - lat) + Math.Abs(35.29432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.0547 - lat) + Math.Abs(35.12908 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.12568 - lat) + Math.Abs(35.10061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.18966 - lat) + Math.Abs(34.97063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.86289 - lat) + Math.Abs(35.20815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.43274 - lat) + Math.Abs(35.08266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.41035 - lat) + Math.Abs(35.28087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.10182 - lat) + Math.Abs(35.28938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.609 - lat) + Math.Abs(35.03455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.94746 - lat) + Math.Abs(35.02031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.67676 - lat) + Math.Abs(35.14375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.41562 - lat) + Math.Abs(35.05888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.68559 - lat) + Math.Abs(35.12081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.22111 - lat) + Math.Abs(35.25444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.8721 - lat) + Math.Abs(35.27596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.38613 - lat) + Math.Abs(35.2878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.39583 - lat) + Math.Abs(35.23807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.04935 - lat) + Math.Abs(35.16593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.34798 - lat) + Math.Abs(35.27446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.10828 - lat) + Math.Abs(35.05096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.18486 - lat) + Math.Abs(35.53898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.11381 - lat) + Math.Abs(35.19536 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.08357 - lat) + Math.Abs(35.36378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.18588 - lat) + Math.Abs(35.23114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.07011 - lat) + Math.Abs(35.2403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.4438 - lat) + Math.Abs(35.20184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.11827 - lat) + Math.Abs(35.15719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.55294 - lat) + Math.Abs(35.12077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.64457 - lat) + Math.Abs(35.16674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.37952 - lat) + Math.Abs(34.91246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.49212 - lat) + Math.Abs(35.09535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.46895 - lat) + Math.Abs(35.00819 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.63406 - lat) + Math.Abs(35.18688 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.44052 - lat) + Math.Abs(35.00001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.47329 - lat) + Math.Abs(34.94461 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.46832 - lat) + Math.Abs(34.93832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.67927 - lat) + Math.Abs(35.23986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.2376 - lat) + Math.Abs(35.40407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.50911 - lat) + Math.Abs(34.94938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.13147 - lat) + Math.Abs(35.02138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.66959 - lat) + Math.Abs(35.21961 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.48081 - lat) + Math.Abs(35.03252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.49161 - lat) + Math.Abs(34.94305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.73721 - lat) + Math.Abs(35.25742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.45203 - lat) + Math.Abs(34.9265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.46247 - lat) + Math.Abs(35.17503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.23647 - lat) + Math.Abs(35.38711 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.88546 - lat) + Math.Abs(35.07185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.48095 - lat) + Math.Abs(34.95063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.45185 - lat) + Math.Abs(35.02714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.34698 - lat) + Math.Abs(35.05009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.43609 - lat) + Math.Abs(34.91697 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.61735 - lat) + Math.Abs(35.14366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.25231 - lat) + Math.Abs(35.37836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.01678 - lat) + Math.Abs(35.30135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.94508 - lat) + Math.Abs(35.07194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.6148 - lat) + Math.Abs(35.04174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.44222 - lat) + Math.Abs(35.14286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.98722 - lat) + Math.Abs(35.15788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.22583 - lat) + Math.Abs(35.07179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.1533 - lat) + Math.Abs(35.04698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.24366 - lat) + Math.Abs(35.06394 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.37398 - lat) + Math.Abs(35.15451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.45661 - lat) + Math.Abs(35.22649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.19351 - lat) + Math.Abs(35.28284 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.22162 - lat) + Math.Abs(35.14471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.9884 - lat) + Math.Abs(35.30932 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.18342 - lat) + Math.Abs(35.09073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.22551 - lat) + Math.Abs(35.04337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.47852 - lat) + Math.Abs(35.25425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.04758 - lat) + Math.Abs(35.12038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.29967 - lat) + Math.Abs(35.10955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.0671 - lat) + Math.Abs(35.08287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.22353 - lat) + Math.Abs(35.08504 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.10188 - lat) + Math.Abs(35.32188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.65051 - lat) + Math.Abs(35.17001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.33541 - lat) + Math.Abs(35.30107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.21431 - lat) + Math.Abs(35.17081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.02986 - lat) + Math.Abs(35.22297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.96192 - lat) + Math.Abs(35.21338 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.20125 - lat) + Math.Abs(35.03416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.45943 - lat) + Math.Abs(35.30086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.13164 - lat) + Math.Abs(35.20403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.42464 - lat) + Math.Abs(35.36421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.45957 - lat) + Math.Abs(35.41516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.50821 - lat) + Math.Abs(35.31317 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.32409 - lat) + Math.Abs(35.22133 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.85727 - lat) + Math.Abs(35.25868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.17326 - lat) + Math.Abs(35.03551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.10361 - lat) + Math.Abs(35.22472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.20081 - lat) + Math.Abs(35.24159 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.19164 - lat) + Math.Abs(35.15836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.37024 - lat) + Math.Abs(35.10708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.3266 - lat) + Math.Abs(35.05262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.55874 - lat) + Math.Abs(34.97436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.15224 - lat) + Math.Abs(35.25673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.70931 - lat) + Math.Abs(35.13475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.83337 - lat) + Math.Abs(35.26315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.11424 - lat) + Math.Abs(35.14192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.58029 - lat) + Math.Abs(35.10178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.20427 - lat) + Math.Abs(35.13077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.16523 - lat) + Math.Abs(34.97748 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.28613 - lat) + Math.Abs(35.02326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.06878 - lat) + Math.Abs(35.15286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.19072 - lat) + Math.Abs(35.16605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.48998 - lat) + Math.Abs(35.40163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.22498 - lat) + Math.Abs(35.02291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.38291 - lat) + Math.Abs(35.17912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.65305 - lat) + Math.Abs(35.15013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.95863 - lat) + Math.Abs(35.22714 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.50777 - lat) + Math.Abs(35.02929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.05632 - lat) + Math.Abs(35.36705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.31341 - lat) + Math.Abs(35.04144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.25326 - lat) + Math.Abs(35.18893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.94862 - lat) + Math.Abs(35.04437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.00282 - lat) + Math.Abs(35.11437 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.96636 - lat) + Math.Abs(35.29261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.13096 - lat) + Math.Abs(35.13963 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.91727 - lat) + Math.Abs(35.12105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.49586 - lat) + Math.Abs(35.35104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.91112 - lat) + Math.Abs(35.26661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.06551 - lat) + Math.Abs(35.02451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.03213 - lat) + Math.Abs(35.14845 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.21734 - lat) + Math.Abs(35.32127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.35244 - lat) + Math.Abs(35.07689 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.99881 - lat) + Math.Abs(35.06844 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.45601 - lat) + Math.Abs(35.36164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.07216 - lat) + Math.Abs(35.09943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.45461 - lat) + Math.Abs(35.26076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.30177 - lat) + Math.Abs(35.19263 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.89682 - lat) + Math.Abs(35.2543 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.18452 - lat) + Math.Abs(35.25015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.98964 - lat) + Math.Abs(35.17412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.96687 - lat) + Math.Abs(34.99425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.96959 - lat) + Math.Abs(35.19408 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.8508 - lat) + Math.Abs(35.2036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.92835 - lat) + Math.Abs(35.07204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.83478 - lat) + Math.Abs(35.14947 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.1146 - lat) + Math.Abs(35.08028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.30798 - lat) + Math.Abs(35.16593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.23105 - lat) + Math.Abs(35.21576 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.89609 - lat) + Math.Abs(35.08178 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.88527 - lat) + Math.Abs(35.11535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.8966 - lat) + Math.Abs(35.17048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.29301 - lat) + Math.Abs(35.2161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.82424 - lat) + Math.Abs(35.14936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.8878 - lat) + Math.Abs(35.04623 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.70095 - lat) + Math.Abs(35.22631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.46968 - lat) + Math.Abs(35.35626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.86958 - lat) + Math.Abs(35.0654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.26089 - lat) + Math.Abs(35.13169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.70487 - lat) + Math.Abs(35.20376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.57011 - lat) + Math.Abs(35.06502 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.71545 - lat) + Math.Abs(35.18788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.85069 - lat) + Math.Abs(35.11248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.92674 - lat) + Math.Abs(35.24098 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.62329 - lat) + Math.Abs(35.10446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.97552 - lat) + Math.Abs(35.11595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.81732 - lat) + Math.Abs(35.17934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.84675 - lat) + Math.Abs(35.15173 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.23719 - lat) + Math.Abs(35.20977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.17689 - lat) + Math.Abs(35.33541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.62443 - lat) + Math.Abs(35.15457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.85911 - lat) + Math.Abs(35.13124 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.19303 - lat) + Math.Abs(35.37127 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.59618 - lat) + Math.Abs(35.0296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.1426 - lat) + Math.Abs(35.28774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.71945 - lat) + Math.Abs(35.14103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.47304 - lat) + Math.Abs(35.0936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.38632 - lat) + Math.Abs(35.48084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.41032 - lat) + Math.Abs(35.07054 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.20434 - lat) + Math.Abs(35.11433 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.51591 - lat) + Math.Abs(35.16416 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.21207 - lat) + Math.Abs(35.28561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.33392 - lat) + Math.Abs(35.1116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.17496 - lat) + Math.Abs(35.05752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.09627 - lat) + Math.Abs(35.03982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.40967 - lat) + Math.Abs(34.97329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.38665 - lat) + Math.Abs(35.32411 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.22297 - lat) + Math.Abs(35.30989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.94918 - lat) + Math.Abs(35.25122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.97127 - lat) + Math.Abs(35.22781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.92653 - lat) + Math.Abs(35.14994 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.90613 - lat) + Math.Abs(35.14254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.14706 - lat) + Math.Abs(35.24513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.12499 - lat) + Math.Abs(35.30999 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.16108 - lat) + Math.Abs(35.28388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.87022 - lat) + Math.Abs(35.12682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.36935 - lat) + Math.Abs(35.07189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.51494 - lat) + Math.Abs(35.18574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.95388 - lat) + Math.Abs(35.2998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.00058 - lat) + Math.Abs(35.20466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.86667 - lat) + Math.Abs(35.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.08537 - lat) + Math.Abs(35.25782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.39671 - lat) + Math.Abs(35.06611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.25124 - lat) + Math.Abs(35.26716 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.17842 - lat) + Math.Abs(35.21569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.57004 - lat) + Math.Abs(35.15606 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.42949 - lat) + Math.Abs(35.27112 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.68939 - lat) + Math.Abs(35.18681 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.4695 - lat) + Math.Abs(35.07781 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.25134 - lat) + Math.Abs(35.062 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.4972 - lat) + Math.Abs(35.32271 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.35922 - lat) + Math.Abs(35.17122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.84945 - lat) + Math.Abs(35.2342 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.40517 - lat) + Math.Abs(35.20189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.86667 - lat) + Math.Abs(35.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.47057 - lat) + Math.Abs(35.20027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.51129 - lat) + Math.Abs(35.36291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.12495 - lat) + Math.Abs(35.34547 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.35916 - lat) + Math.Abs(35.22011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.89212 - lat) + Math.Abs(35.43549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.41072 - lat) + Math.Abs(35.10916 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.4027 - lat) + Math.Abs(35.08455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.26506 - lat) + Math.Abs(35.20135 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.01638 - lat) + Math.Abs(35.12403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.18482 - lat) + Math.Abs(35.0176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.50259 - lat) + Math.Abs(35.16668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.80924 - lat) + Math.Abs(35.25902 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.30792 - lat) + Math.Abs(35.11693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.48563 - lat) + Math.Abs(35.23011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.83886 - lat) + Math.Abs(35.13678 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.42228 - lat) + Math.Abs(35.38476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.0192 - lat) + Math.Abs(35.34783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.93592 - lat) + Math.Abs(35.005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.00018 - lat) + Math.Abs(35.28152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.95403 - lat) + Math.Abs(35.1624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.03504 - lat) + Math.Abs(35.03928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.69405 - lat) + Math.Abs(35.16685 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.52935 - lat) + Math.Abs(35.0938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.85587 - lat) + Math.Abs(35.19706 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.85203 - lat) + Math.Abs(35.18451 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.93848 - lat) + Math.Abs(35.12142 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.46392 - lat) + Math.Abs(35.21938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.19055 - lat) + Math.Abs(35.13709 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.02509 - lat) + Math.Abs(35.44351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.3206 - lat) + Math.Abs(35.20329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.91001 - lat) + Math.Abs(35.21645 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.77078 - lat) + Math.Abs(35.26917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.95069 - lat) + Math.Abs(35.46756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.32571 - lat) + Math.Abs(35.16373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.02232 - lat) + Math.Abs(35.17969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.36074 - lat) + Math.Abs(35.1959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.88709 - lat) + Math.Abs(35.42721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.03144 - lat) + Math.Abs(35.19992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.94883 - lat) + Math.Abs(35.18426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.76215 - lat) + Math.Abs(35.26166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.01637 - lat) + Math.Abs(35.06833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.77667 - lat) + Math.Abs(35.23417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.28137 - lat) + Math.Abs(34.30253 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.34158 - lat) + Math.Abs(34.34592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.37389 - lat) + Math.Abs(34.34085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.56085 - lat) + Math.Abs(34.51863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.45571 - lat) + Math.Abs(34.43719 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.43954 - lat) + Math.Abs(34.38053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.41052 - lat) + Math.Abs(34.37802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.40048 - lat) + Math.Abs(34.33754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.46587 - lat) + Math.Abs(34.41208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.78336 - lat) + Math.Abs(35.23388 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.1714 - lat) + Math.Abs(35.09767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.53123 - lat) + Math.Abs(34.96064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.12167 - lat) + Math.Abs(35.02036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.17916 - lat) + Math.Abs(35.13038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.14222 - lat) + Math.Abs(34.99829 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.03924 - lat) + Math.Abs(35.10316 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.92548 - lat) + Math.Abs(35.31833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.80725 - lat) + Math.Abs(35.3277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.78852 - lat) + Math.Abs(35.26511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.75926 - lat) + Math.Abs(35.285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.71697 - lat) + Math.Abs(35.29007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.71749 - lat) + Math.Abs(35.24227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.7216 - lat) + Math.Abs(35.19243 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.71974 - lat) + Math.Abs(35.17848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.69948 - lat) + Math.Abs(35.18047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.6737 - lat) + Math.Abs(35.20272 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.66516 - lat) + Math.Abs(35.16727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.65387 - lat) + Math.Abs(35.16152 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.64925 - lat) + Math.Abs(35.17478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.61851 - lat) + Math.Abs(35.22115 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.57112 - lat) + Math.Abs(35.23227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.6188 - lat) + Math.Abs(35.02361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.5587 - lat) + Math.Abs(35.1244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.53537 - lat) + Math.Abs(34.97192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.54199 - lat) + Math.Abs(35.14279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.48794 - lat) + Math.Abs(35.11665 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.49737 - lat) + Math.Abs(35.11362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.52057 - lat) + Math.Abs(34.97442 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.47454 - lat) + Math.Abs(35.10742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.47057 - lat) + Math.Abs(35.03151 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.47097 - lat) + Math.Abs(34.99897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.46693 - lat) + Math.Abs(35.13671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.46396 - lat) + Math.Abs(35.15227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.4555 - lat) + Math.Abs(34.99493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.4502 - lat) + Math.Abs(35.04952 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.44538 - lat) + Math.Abs(35.20071 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.4438 - lat) + Math.Abs(35.16352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.41627 - lat) + Math.Abs(35.23948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.43909 - lat) + Math.Abs(35.0162 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.43597 - lat) + Math.Abs(35.15613 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.42544 - lat) + Math.Abs(35.1957 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.42301 - lat) + Math.Abs(35.13278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.42013 - lat) + Math.Abs(35.11516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.35638 - lat) + Math.Abs(34.92072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.4571 - lat) + Math.Abs(35.13661 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.45428 - lat) + Math.Abs(35.14427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.42022 - lat) + Math.Abs(35.23013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.25857 - lat) + Math.Abs(35.33247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.38051 - lat) + Math.Abs(35.50838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.33004 - lat) + Math.Abs(35.38979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.1733 - lat) + Math.Abs(35.53005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.1407 - lat) + Math.Abs(35.48738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.65534 - lat) + Math.Abs(35.17928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.48232 - lat) + Math.Abs(35.01742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(31.86145 - lat) + Math.Abs(35.16861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(32.13165 - lat) + Math.Abs(34.99094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Shūkat aş Şūfī", "GZ", 31.25997, 34.2826);
case 1: return new CityInfo("Rafaḩ", "GZ", 31.29722, 34.24357);
case 2: return new CityInfo("An Nuşayrāt", "GZ", 31.44861, 34.3925);
case 3: return new CityInfo("Khuzā‘ah", "GZ", 31.30675, 34.3611);
case 4: return new CityInfo("Khān Yūnis", "GZ", 31.34018, 34.30627);
case 5: return new CityInfo("Jabālyā", "GZ", 31.5272, 34.48347);
case 6: return new CityInfo("Gaza", "GZ", 31.50161, 34.46672);
case 7: return new CityInfo("Dayr al Balaḩ", "GZ", 31.41834, 34.34933);
case 8: return new CityInfo("Bayt Lāhyā", "GZ", 31.5464, 34.49514);
case 9: return new CityInfo("Bayt Ḩānūn", "GZ", 31.5353, 34.53579);
case 10: return new CityInfo("Banī Suhaylā", "GZ", 31.34337, 34.32337);
case 11: return new CityInfo("Al Fukhkhārī", "GZ", 31.29278, 34.33061);
case 12: return new CityInfo("Al Burayj", "GZ", 31.43944, 34.40306);
case 13: return new CityInfo("‘Abasān al Kabīrah", "GZ", 31.31913, 34.34005);
case 14: return new CityInfo("Zubūbah", "WE", 32.54346, 35.22274);
case 15: return new CityInfo("Zabdah", "WE", 32.45077, 35.12958);
case 16: return new CityInfo("Zaytā", "WE", 32.3856, 35.05122);
case 17: return new CityInfo("Zaytā Jammā‘īn", "WE", 32.13698, 35.18595);
case 18: return new CityInfo("Az Zāwiyah", "WE", 32.37596, 35.23166);
case 19: return new CityInfo("Zawātā", "WE", 32.24611, 35.2265);
case 20: return new CityInfo("Za‘tarah", "WE", 31.67361, 35.25662);
case 21: return new CityInfo("Yuta", "WE", 31.4459, 35.09443);
case 22: return new CityInfo("Yatmā", "WE", 32.10889, 35.26909);
case 23: return new CityInfo("Yāsūf", "WE", 32.10841, 35.23784);
case 24: return new CityInfo("Yāşīd", "WE", 32.29688, 35.27757);
case 25: return new CityInfo("Yabrūd", "WE", 31.9733, 35.24516);
case 26: return new CityInfo("Ya‘bad", "WE", 32.44566, 35.16822);
case 27: return new CityInfo("Wādī Fūkīn", "WE", 31.70701, 35.10366);
case 28: return new CityInfo("‘Ūrīf", "WE", 32.15949, 35.22228);
case 29: return new CityInfo("Umm Şafā", "WE", 32.00889, 35.16461);
case 30: return new CityInfo("Umm at Tūt", "WE", 32.43234, 35.34418);
case 31: return new CityInfo("Ūdalah", "WE", 32.15363, 35.27646);
case 32: return new CityInfo("Turmus‘ayyā", "WE", 32.03538, 35.28564);
case 33: return new CityInfo("Ţūrah al Gharbīyah", "WE", 32.46884, 35.15247);
case 34: return new CityInfo("Ţūlkarm", "WE", 32.31156, 35.0269);
case 35: return new CityInfo("Ţūbās", "WE", 32.32091, 35.36989);
case 36: return new CityInfo("Ti‘innik", "WE", 32.51956, 35.21966);
case 37: return new CityInfo("Tayāsīr", "WE", 32.34042, 35.39604);
case 38: return new CityInfo("Tarqūmyā", "WE", 31.57551, 35.01223);
case 39: return new CityInfo("Ţammūn", "WE", 32.28347, 35.38367);
case 40: return new CityInfo("Ţallūzah", "WE", 32.27056, 35.29496);
case 41: return new CityInfo("Till", "WE", 32.20068, 35.21293);
case 42: return new CityInfo("Talfīt", "WE", 32.08664, 35.29094);
case 43: return new CityInfo("Taffūḩ", "WE", 31.53855, 35.04966);
case 44: return new CityInfo("Şūrīf", "WE", 31.65078, 35.06439);
case 45: return new CityInfo("Surdā", "WE", 31.93709, 35.20321);
case 46: return new CityInfo("Sīrīs", "WE", 32.32828, 35.29134);
case 47: return new CityInfo("Şīr", "WE", 32.36342, 35.31529);
case 48: return new CityInfo("Sinjil", "WE", 32.03334, 35.26545);
case 49: return new CityInfo("Silwād", "WE", 31.97625, 35.2613);
case 50: return new CityInfo("Sīlat az̧ Z̧ahr", "WE", 32.31934, 35.18418);
case 51: return new CityInfo("Sīlat al Ḩārithīyah", "WE", 32.50847, 35.22752);
case 52: return new CityInfo("Sa‘īr", "WE", 31.57855, 35.14017);
case 53: return new CityInfo("Shuqbā", "WE", 31.98695, 35.04012);
case 54: return new CityInfo("Shūfah", "WE", 32.27551, 35.08135);
case 55: return new CityInfo("Shabtīn", "WE", 31.97327, 35.04976);
case 56: return new CityInfo("Şaydā", "WE", 32.38489, 35.11856);
case 57: return new CityInfo("Şarţah", "WE", 32.10447, 35.09198);
case 58: return new CityInfo("Şarrah", "WE", 32.2097, 35.19147);
case 59: return new CityInfo("Şānūr", "WE", 32.35608, 35.24537);
case 60: return new CityInfo("Sannīryā", "WE", 32.12877, 35.04652);
case 61: return new CityInfo("Sālim", "WE", 32.20962, 35.33034);
case 62: return new CityInfo("Salfīt", "WE", 32.08371, 35.18079);
case 63: return new CityInfo("Saffārīn", "WE", 32.26225, 35.11028);
case 64: return new CityInfo("Şaffā", "WE", 31.90563, 35.06094);
case 65: return new CityInfo("Sabasţīyah", "WE", 32.27562, 35.19873);
case 66: return new CityInfo("Rummanah", "WE", 32.52451, 35.2048);
case 67: return new CityInfo("Rūjayb", "WE", 32.19061, 35.29332);
case 68: return new CityInfo("Rās Karkar", "WE", 31.9424, 35.10773);
case 69: return new CityInfo("Rantīs", "WE", 32.02797, 35.01879);
case 70: return new CityInfo("Rammūn", "WE", 31.93342, 35.29821);
case 71: return new CityInfo("Rāmīn", "WE", 32.2852, 35.14951);
case 72: return new CityInfo("Ramallah", "WE", 31.89964, 35.20422);
case 73: return new CityInfo("Rāfāt", "WE", 32.07806, 35.04417);
case 74: return new CityInfo("Rāfāt", "WE", 31.87096, 35.19182);
case 75: return new CityInfo("Rābā", "WE", 32.38679, 35.38298);
case 76: return new CityInfo("Quşrah", "WE", 32.08543, 35.33005);
case 77: return new CityInfo("Qūşīn", "WE", 32.23829, 35.18297);
case 78: return new CityInfo("Qīrah", "WE", 32.12214, 35.17173);
case 79: return new CityInfo("Qibyah", "WE", 31.97734, 35.00984);
case 80: return new CityInfo("Qaţanah", "WE", 31.83366, 35.11894);
case 81: return new CityInfo("Qaryūt", "WE", 32.07004, 35.29432);
case 82: return new CityInfo("Qarāwat Banī Zayd", "WE", 32.0547, 35.12908);
case 83: return new CityInfo("Qarāwat Banī Ḩasan", "WE", 32.12568, 35.10061);
case 84: return new CityInfo("Qalqīlyah", "WE", 32.18966, 34.97063);
case 85: return new CityInfo("Qalandiyā", "WE", 31.86289, 35.20815);
case 86: return new CityInfo("Qaffīn", "WE", 32.43274, 35.08266);
case 87: return new CityInfo("Qabāţīyah", "WE", 32.41035, 35.28087);
case 88: return new CityInfo("Qabalān", "WE", 32.10182, 35.28938);
case 89: return new CityInfo("Nūbā", "WE", 31.609, 35.03455);
case 90: return new CityInfo("Ni‘līn", "WE", 31.94746, 35.02031);
case 91: return new CityInfo("Neve Daniel", "WE", 31.67676, 35.14375);
case 92: return new CityInfo("Nazlat ‘Īsá", "WE", 32.41562, 35.05888);
case 93: return new CityInfo("Naḩḩālīn", "WE", 31.68559, 35.12081);
case 94: return new CityInfo("Nablus", "WE", 32.22111, 35.25444);
case 95: return new CityInfo("Mikhmās", "GZ", 31.8721, 35.27596);
case 96: return new CityInfo("Mislīyah", "WE", 32.38613, 35.2878);
case 97: return new CityInfo("Mirkah", "WE", 32.39583, 35.23807);
case 98: return new CityInfo("Banī Zayd ash Shārqīyah", "WE", 32.04935, 35.16593);
case 99: return new CityInfo("Maythalūn", "WE", 32.34798, 35.27446);
case 100: return new CityInfo("Masḩah", "WE", 32.10828, 35.05096);
case 101: return new CityInfo("Marj Na‘jah", "WE", 32.18486, 35.53898);
case 102: return new CityInfo("Mardā", "WE", 32.11381, 35.19536);
case 103: return new CityInfo("Majdal Banī Fāḑil", "WE", 32.08357, 35.36378);
case 104: return new CityInfo("Mādamā", "WE", 32.18588, 35.23114);
case 105: return new CityInfo("Al Lubban ash Sharqīyah", "WE", 32.07011, 35.2403);
case 106: return new CityInfo("Kufayrit", "WE", 32.4438, 35.20184);
case 107: return new CityInfo("Kifil Ḩāris", "WE", 32.11827, 35.15719);
case 108: return new CityInfo("Qilā‘ Zaytā", "WE", 31.55294, 35.12077);
case 109: return new CityInfo("Umm Salmūnah", "WE", 31.64457, 35.16674);
case 110: return new CityInfo("Ar Ramāḑīn", "WE", 31.37952, 34.91246);
case 111: return new CityInfo("Qalqas", "WE", 31.49212, 35.09535);
case 112: return new CityInfo("Imrīsh", "WE", 31.46895, 35.00819);
case 113: return new CityInfo("Marāḩ Rabbāḩ", "WE", 31.63406, 35.18688);
case 114: return new CityInfo("Kurzah", "WE", 31.44052, 35.00001);
case 115: return new CityInfo("Dayr al ‘Asal at Taḩtā", "WE", 31.47329, 34.94461);
case 116: return new CityInfo("Dayr al ‘Asal al Fawqā", "WE", 31.46832, 34.93832);
case 117: return new CityInfo("Bayt Ta‘mar", "WE", 31.67927, 35.23986);
case 118: return new CityInfo("Bayt Ḩasan", "WE", 32.2376, 35.40407);
case 119: return new CityInfo("Bayt ‘Awwā", "WE", 31.50911, 34.94938);
case 120: return new CityInfo("Bayt Amīn", "WE", 32.13147, 35.02138);
case 121: return new CityInfo("Jannātah", "WE", 31.66959, 35.21961);
case 122: return new CityInfo("Ţarrāmah", "WE", 31.48081, 35.03252);
case 123: return new CityInfo("Sikkah", "WE", 31.49161, 34.94305);
case 124: return new CityInfo("Ash Shaykh Sa‘d", "WE", 31.73721, 35.25742);
case 125: return new CityInfo("Bayt ar Rūsh al Fawqā", "WE", 31.45203, 34.9265);
case 126: return new CityInfo("Nazlat ash Shaykh Zayd", "WE", 32.46247, 35.17503);
case 127: return new CityInfo("An Naşşārīyah", "WE", 32.23647, 35.38711);
case 128: return new CityInfo("Kharbathā al Mişbāḩ", "WE", 31.88546, 35.07185);
case 129: return new CityInfo("Al Majd", "WE", 31.48095, 34.95063);
case 130: return new CityInfo("Karmah", "WE", 31.45185, 35.02714);
case 131: return new CityInfo("Al Jārūshīyah", "WE", 32.34698, 35.05009);
case 132: return new CityInfo("Al Burj", "WE", 31.43609, 34.91697);
case 133: return new CityInfo("Shuyūkh al ‘Arrūb", "WE", 31.61735, 35.14366);
case 134: return new CityInfo("Al ‘Aqrabānīyah", "WE", 32.25231, 35.37836);
case 135: return new CityInfo("Khirbat Abū Falāḩ", "WE", 32.01678, 35.30135);
case 136: return new CityInfo("Kharbathā Banī Ḩārith", "WE", 31.94508, 35.07194);
case 137: return new CityInfo("Khārās", "WE", 31.6148, 35.04174);
case 138: return new CityInfo("Khallat al Mayyah", "WE", 31.44222, 35.14286);
case 139: return new CityInfo("Kūbar", "WE", 31.98722, 35.15788);
case 140: return new CityInfo("Kafr Zībād", "WE", 32.22583, 35.07179);
case 141: return new CityInfo("Kafr Thulth", "WE", 32.1533, 35.04698);
case 142: return new CityInfo("Kafr Şūr", "WE", 32.24366, 35.06394);
case 143: return new CityInfo("Kafr Rā‘ī", "WE", 32.37398, 35.15451);
case 144: return new CityInfo("Kafr Qūd", "WE", 32.45661, 35.22649);
case 145: return new CityInfo("Kafr Qallīl", "WE", 32.19351, 35.28284);
case 146: return new CityInfo("Kafr Qaddūm", "WE", 32.22162, 35.14471);
case 147: return new CityInfo("Kafr Mālik", "WE", 31.9884, 35.30932);
case 148: return new CityInfo("Kafr Lāqif", "WE", 32.18342, 35.09073);
case 149: return new CityInfo("Kafr Jammāl", "WE", 32.22551, 35.04337);
case 150: return new CityInfo("Kafr Dān", "WE", 32.47852, 35.25425);
case 151: return new CityInfo("Kafr ‘Ayn", "WE", 32.04758, 35.12038);
case 152: return new CityInfo("Kafr al Labad", "WE", 32.29967, 35.10955);
case 153: return new CityInfo("Kafr ad Dīk", "WE", 32.0671, 35.08287);
case 154: return new CityInfo("Kafr ‘Abbūsh", "WE", 32.22353, 35.08504);
case 155: return new CityInfo("Jūrīsh", "WE", 32.10188, 35.32188);
case 156: return new CityInfo("Jūrat ash Sham‘ah", "WE", 31.65051, 35.17001);
case 157: return new CityInfo("Al Judayyidah", "WE", 32.33541, 35.30107);
case 158: return new CityInfo("Jīt", "WE", 32.21431, 35.17081);
case 159: return new CityInfo("Jiljīlīyā", "WE", 32.02986, 35.22297);
case 160: return new CityInfo("Jifnā", "WE", 31.96192, 35.21338);
case 161: return new CityInfo("Jayyūs", "WE", 32.20125, 35.03416);
case 162: return new CityInfo("Janīn", "WE", 32.45943, 35.30086);
case 163: return new CityInfo("Jammā‘īn", "WE", 32.13164, 35.20403);
case 164: return new CityInfo("Jalqamūs", "WE", 32.42464, 35.36421);
case 165: return new CityInfo("Jalbūn", "WE", 32.45957, 35.41516);
case 166: return new CityInfo("Al Jalamah", "WE", 32.50821, 35.31317);
case 167: return new CityInfo("Jaba‘", "WE", 32.32409, 35.22133);
case 168: return new CityInfo("Jaba‘", "WE", 31.85727, 35.25868);
case 169: return new CityInfo("‘Aslah", "WE", 32.17326, 35.03551);
case 170: return new CityInfo("Iskākā", "WE", 32.10361, 35.22472);
case 171: return new CityInfo("‘Irāq Būrīn", "WE", 32.20081, 35.24159);
case 172: return new CityInfo("Immātīn", "WE", 32.19164, 35.15836);
case 173: return new CityInfo("‘Illār", "WE", 32.37024, 35.10708);
case 174: return new CityInfo("Iktābah", "WE", 32.3266, 35.05262);
case 175: return new CityInfo("Idhnā", "WE", 31.55874, 34.97436);
case 176: return new CityInfo("Ḩuwwārah", "WE", 32.15224, 35.25673);
case 177: return new CityInfo("Ḩūsān", "WE", 31.70931, 35.13475);
case 178: return new CityInfo("Ḩizmā", "WE", 31.83337, 35.26315);
case 179: return new CityInfo("Ḩāris", "WE", 32.11424, 35.14192);
case 180: return new CityInfo("Ḩalḩūl", "WE", 31.58029, 35.10178);
case 181: return new CityInfo("Ḩajjah", "WE", 32.20427, 35.13077);
case 182: return new CityInfo("Ḩablah", "WE", 32.16523, 34.97748);
case 183: return new CityInfo("Far‘ūn", "WE", 32.28613, 35.02326);
case 184: return new CityInfo("Farkhah", "WE", 32.06878, 35.15286);
case 185: return new CityInfo("Far‘atā", "WE", 32.19072, 35.16605);
case 186: return new CityInfo("Faqqū‘ah", "WE", 32.48998, 35.40163);
case 187: return new CityInfo("Falāmyah", "WE", 32.22498, 35.02291);
case 188: return new CityInfo("Faḩmah", "WE", 32.38291, 35.17912);
case 189: return new CityInfo("Efrata", "WE", 31.65305, 35.15013);
case 190: return new CityInfo("Dūrā al Qar‘", "WE", 31.95863, 35.22714);
case 191: return new CityInfo("Dūrā", "WE", 31.50777, 35.02929);
case 192: return new CityInfo("Domea", "WE", 32.05632, 35.36705);
case 193: return new CityInfo("Dhannābah", "WE", 32.31341, 35.04144);
case 194: return new CityInfo("Dayr Sharaf", "WE", 32.25326, 35.18893);
case 195: return new CityInfo("Dayr Qiddīs", "WE", 31.94862, 35.04437);
case 196: return new CityInfo("Dayr Niz̧ām", "WE", 32.00282, 35.11437);
case 197: return new CityInfo("Dayr Jarīr", "WE", 31.96636, 35.29261);
case 198: return new CityInfo("Dayr Istiyā", "WE", 32.13096, 35.13963);
case 199: return new CityInfo("Dayr Ibzī‘", "WE", 31.91727, 35.12105);
case 200: return new CityInfo("Dayr Ghazālah", "WE", 32.49586, 35.35104);
case 201: return new CityInfo("Dayr Dibwān", "WE", 31.91112, 35.26661);
case 202: return new CityInfo("Dayr Ballūţ", "WE", 32.06551, 35.02451);
case 203: return new CityInfo("Dayr as Sūdān", "WE", 32.03213, 35.14845);
case 204: return new CityInfo("Dayr al Ḩaţab", "WE", 32.21734, 35.32127);
case 205: return new CityInfo("Dayr al Ghuşūn", "WE", 32.35244, 35.07689);
case 206: return new CityInfo("Dayr Abū Mash‘al", "WE", 31.99881, 35.06844);
case 207: return new CityInfo("Dayr Abū Ḑa‘īf", "WE", 32.45601, 35.36164);
case 208: return new CityInfo("Brūqīn", "WE", 32.07216, 35.09943);
case 209: return new CityInfo("Birqīn", "WE", 32.45461, 35.26076);
case 210: return new CityInfo("Burqah", "WE", 32.30177, 35.19263);
case 211: return new CityInfo("Burqah", "WE", 31.89682, 35.2543);
case 212: return new CityInfo("Būrīn", "WE", 32.18452, 35.25015);
case 213: return new CityInfo("Burhām", "WE", 31.98964, 35.17412);
case 214: return new CityInfo("Budrus", "WE", 31.96687, 34.99425);
case 215: return new CityInfo("Bīr Zayt", "WE", 31.96959, 35.19408);
case 216: return new CityInfo("Bīr Nabālā", "WE", 31.8508, 35.2036);
case 217: return new CityInfo("Bil‘īn", "WE", 31.92835, 35.07204);
case 218: return new CityInfo("Biddū", "WE", 31.83478, 35.14947);
case 219: return new CityInfo("Bidyā", "WE", 32.1146, 35.08028);
case 220: return new CityInfo("Bazzāryah", "WE", 32.30798, 35.16593);
case 221: return new CityInfo("Bayt Wazan", "WE", 32.23105, 35.21576);
case 222: return new CityInfo("Bayt ‘Ūr at Taḩtā", "WE", 31.89609, 35.08178);
case 223: return new CityInfo("Bayt ‘Ūr al Fawqā", "WE", 31.88527, 35.11535);
case 224: return new CityInfo("Baytūnyā", "WE", 31.8966, 35.17048);
case 225: return new CityInfo("Bayt Imrīn", "WE", 32.29301, 35.2161);
case 226: return new CityInfo("Bayt Sūrīk", "WE", 31.82424, 35.14936);
case 227: return new CityInfo("Bayt Sīrā", "WE", 31.8878, 35.04623);
case 228: return new CityInfo("Bayt Sāḩūr", "WE", 31.70095, 35.22631);
case 229: return new CityInfo("Bayt Qād", "WE", 32.46968, 35.35626);
case 230: return new CityInfo("Bayt Liqyā", "WE", 31.86958, 35.0654);
case 231: return new CityInfo("Bayt Līd", "WE", 32.26089, 35.13169);
case 232: return new CityInfo("Bethlehem", "WE", 31.70487, 35.20376);
case 233: return new CityInfo("Bayt Kāḩil", "WE", 31.57011, 35.06502);
case 234: return new CityInfo("Bayt Jālā", "WE", 31.71545, 35.18788);
case 235: return new CityInfo("Bayt ‘Anān", "WE", 31.85069, 35.11248);
case 236: return new CityInfo("Baytīn", "WE", 31.92674, 35.24098);
case 237: return new CityInfo("Bayt Ūmmar", "WE", 31.62329, 35.10446);
case 238: return new CityInfo("Al Ittiḩād", "WE", 31.97552, 35.11595);
case 239: return new CityInfo("Bayt Iksā", "WE", 31.81732, 35.17934);
case 240: return new CityInfo("Bayt Ijzā", "WE", 31.84675, 35.15173);
case 241: return new CityInfo("Bayt Ībā", "WE", 32.23719, 35.20977);
case 242: return new CityInfo("Bayt Fūrīk", "WE", 32.17689, 35.33541);
case 243: return new CityInfo("Bayt Fajjār", "WE", 31.62443, 35.15457);
case 244: return new CityInfo("Bayt Duqqū", "WE", 31.85911, 35.13124);
case 245: return new CityInfo("Bayt Dajan", "WE", 32.19303, 35.37127);
case 246: return new CityInfo("Bayt Ūlā", "WE", 31.59618, 35.0296);
case 247: return new CityInfo("Baytā al Fawqā", "WE", 32.1426, 35.28774);
case 248: return new CityInfo("Battīr", "WE", 31.71945, 35.14103);
case 249: return new CityInfo("Barţa‘ah ash Sharqīyah", "WE", 32.47304, 35.0936);
case 250: return new CityInfo("Bardalah", "WE", 32.38632, 35.48084);
case 251: return new CityInfo("Bāqah ash Sharqīyah", "WE", 32.41032, 35.07054);
case 252: return new CityInfo("Bāqat al Ḩaţab", "WE", 32.20434, 35.11433);
case 253: return new CityInfo("Banī Na‘īm", "WE", 31.51591, 35.16416);
case 254: return new CityInfo("Balāţah", "WE", 32.21207, 35.28561);
case 255: return new CityInfo("Bal‘ā", "WE", 32.33392, 35.1116);
case 256: return new CityInfo("‘Azzūn", "WE", 32.17496, 35.05752);
case 257: return new CityInfo("Az Zāwiyah", "WE", 32.09627, 35.03982);
case 258: return new CityInfo("Az̧ Z̧āhirīyah", "WE", 31.40967, 34.97329);
case 259: return new CityInfo("Az Zabābidah", "WE", 32.38665, 35.32411);
case 260: return new CityInfo("‘Azmūţ", "WE", 32.22297, 35.30989);
case 261: return new CityInfo("‘Ayn Yabrūd", "WE", 31.94918, 35.25122);
case 262: return new CityInfo("‘Ayn Sīnyā", "WE", 31.97127, 35.22781);
case 263: return new CityInfo("‘Ayn Qīniyā", "WE", 31.92653, 35.14994);
case 264: return new CityInfo("‘Ayn ‘Arīk", "WE", 31.90613, 35.14254);
case 265: return new CityInfo("‘Aynabūs", "WE", 32.14706, 35.24513);
case 266: return new CityInfo("Usarin", "WE", 32.12499, 35.30999);
case 267: return new CityInfo("‘Awartā", "WE", 32.16108, 35.28388);
case 268: return new CityInfo("Aţ Ţīrah", "WE", 31.87022, 35.12682);
case 269: return new CityInfo("‘Attīl", "WE", 32.36935, 35.07189);
case 270: return new CityInfo("Aţ Ţaybah", "WE", 32.51494, 35.18574);
case 271: return new CityInfo("Aţ Ţaybah", "WE", 31.95388, 35.2998);
case 272: return new CityInfo("‘Aţārah", "WE", 32.00058, 35.20466);
case 273: return new CityInfo("Kalandia", "WE", 31.86667, 35.21667);
case 274: return new CityInfo("As Sāwiyah", "WE", 32.08537, 35.25782);
case 275: return new CityInfo("As Samū‘", "WE", 31.39671, 35.06611);
case 276: return new CityInfo("‘Aşīrah ash Shamālīyah", "WE", 32.25124, 35.26716);
case 277: return new CityInfo("‘Aşīrah al Qiblīyah", "WE", 32.17842, 35.21569);
case 278: return new CityInfo("Ash Shuyūkh", "WE", 31.57004, 35.15606);
case 279: return new CityInfo("Ash Shuhadā’", "WE", 32.42949, 35.27112);
case 280: return new CityInfo("Arţās", "WE", 31.68939, 35.18681);
case 281: return new CityInfo("Ar Rīḩīyah", "WE", 31.4695, 35.07781);
case 282: return new CityInfo("Ar Rās", "WE", 32.25134, 35.062);
case 283: return new CityInfo("‘Arrānah", "WE", 32.4972, 35.32271);
case 284: return new CityInfo("Ar Rāmah", "WE", 32.35922, 35.17122);
case 285: return new CityInfo("Ar Rām wa Ḑāḩiyat al Barīd", "GZ", 31.84945, 35.2342);
case 286: return new CityInfo("‘Arrābah", "WE", 32.40517, 35.20189);
case 287: return new CityInfo("Jericho", "WE", 31.86667, 35.45);
case 288: return new CityInfo("Al ‘Araqa", "WE", 32.47057, 35.20027);
case 289: return new CityInfo("‘Arabbūnah", "WE", 32.51129, 35.36291);
case 290: return new CityInfo("‘Aqrabā", "WE", 32.12495, 35.34547);
case 291: return new CityInfo("‘Anzah", "WE", 32.35916, 35.22011);
case 292: return new CityInfo("An Nuway‘imah", "WE", 31.89212, 35.43549);
case 293: return new CityInfo("An Nazlah ash Sharqīyah", "WE", 32.41072, 35.10916);
case 294: return new CityInfo("An Nazlah al Gharbīyah", "WE", 32.4027, 35.08455);
case 295: return new CityInfo("An Nāqūrah", "WE", 32.26506, 35.20135);
case 296: return new CityInfo("An Nabī Şāliḩ", "WE", 32.01638, 35.12403);
case 297: return new CityInfo("An Nabī Ilyās", "WE", 32.18482, 35.0176);
case 298: return new CityInfo("‘Anīn", "WE", 32.50259, 35.16668);
case 299: return new CityInfo("‘Anātā", "WE", 31.80924, 35.25902);
case 300: return new CityInfo("‘Anabtā", "WE", 32.30792, 35.11693);
case 301: return new CityInfo("Al Yāmūn", "WE", 32.48563, 35.23011);
case 302: return new CityInfo("Al Qubaybah", "WE", 31.83886, 35.13678);
case 303: return new CityInfo("Al Mughayyir", "WE", 32.42228, 35.38476);
case 304: return new CityInfo("Al Mughayyir", "WE", 32.0192, 35.34783);
case 305: return new CityInfo("Al Midyah", "WE", 31.93592, 35.005);
case 306: return new CityInfo("Al Mazra‘ah ash Sharqīyah", "WE", 32.00018, 35.28152);
case 307: return new CityInfo("Az Zaytūnīyah", "WE", 31.95403, 35.1624);
case 308: return new CityInfo("Al Lubban al Gharbī", "WE", 32.03504, 35.03928);
case 309: return new CityInfo("Al Khaḑir", "WE", 31.69405, 35.16685);
case 310: return new CityInfo("Hebron", "WE", 31.52935, 35.0938);
case 311: return new CityInfo("Al Judayrah", "WE", 31.85587, 35.19706);
case 312: return new CityInfo("Al Jīb", "WE", 31.85203, 35.18451);
case 313: return new CityInfo("Al Jāniyah", "WE", 31.93848, 35.12142);
case 314: return new CityInfo("Al Hāshimīyah", "WE", 32.46392, 35.21938);
case 315: return new CityInfo("Al Funduq", "WE", 32.19055, 35.13709);
case 316: return new CityInfo("Al Faşāyil", "WE", 32.02509, 35.44351);
case 317: return new CityInfo("Al Fandaqūmīyah", "WE", 32.3206, 35.20329);
case 318: return new CityInfo("Al Bīrah", "WE", 31.91001, 35.21645);
case 319: return new CityInfo("Al ‘Ayzarīyah", "WE", 31.77078, 35.26917);
case 320: return new CityInfo("Al ‘Awjā", "WE", 31.95069, 35.46756);
case 321: return new CityInfo("Al ‘Aţţārah", "WE", 32.32571, 35.16373);
case 322: return new CityInfo("‘Ajjūl", "WE", 32.02232, 35.17969);
case 323: return new CityInfo("‘Ajjah", "WE", 32.36074, 35.1959);
case 324: return new CityInfo("‘Ayn ad Duyūk al Fawqā", "WE", 31.88709, 35.42721);
case 325: return new CityInfo("‘Ibwayn", "WE", 32.03144, 35.19992);
case 326: return new CityInfo("Abū Qashsh", "WE", 31.94883, 35.18426);
case 327: return new CityInfo("Abū Dīs", "WE", 31.76215, 35.26166);
case 328: return new CityInfo("‘Ābūd", "WE", 32.01637, 35.06833);
case 329: return new CityInfo("Old City", "WE", 31.77667, 35.23417);
case 330: return new CityInfo("An Naşr", "GZ", 31.28137, 34.30253);
case 331: return new CityInfo("‘Abasān al Jadīdah", "00", 31.34158, 34.34592);
case 332: return new CityInfo("Al Qarārah", "GZ", 31.37389, 34.34085);
case 333: return new CityInfo("Umm an Naşr", "GZ", 31.56085, 34.51863);
case 334: return new CityInfo("Juḩr ad Dīk", "GZ", 31.45571, 34.43719);
case 335: return new CityInfo("Az Zuwāydah", "GZ", 31.43954, 34.38053);
case 336: return new CityInfo("Al Muşaddar", "GZ", 31.41052, 34.37802);
case 337: return new CityInfo("Wādī as Salqā", "GZ", 31.40048, 34.33754);
case 338: return new CityInfo("Al Mughrāqah", "GZ", 31.46587, 34.41208);
case 339: return new CityInfo("East Jerusalem", "WE", 31.78336, 35.23388);
case 340: return new CityInfo("Karney Shomron", "WE", 32.1714, 35.09767);
case 341: return new CityInfo("al-Kum", "WE", 31.53123, 34.96064);
case 342: return new CityInfo("Azun Atme", "WE", 32.12167, 35.02036);
case 343: return new CityInfo("Jinşāfūţ", "WE", 32.17916, 35.13038);
case 344: return new CityInfo("‘Izbat Salmān", "00", 32.14222, 34.99829);
case 345: return new CityInfo("Banī Zayd", "00", 32.03924, 35.10316);
case 346: return new CityInfo("Badiw al Mu‘arrajāt", "00", 31.92548, 35.31833);
case 347: return new CityInfo("Al Ka‘ābinah (Tajammu‘ Badawī)", "00", 31.80725, 35.3277);
case 348: return new CityInfo("Az Za‘ayyim", "00", 31.78852, 35.26511);
case 349: return new CityInfo("‘Arab al Jahālīn", "00", 31.75926, 35.285);
case 350: return new CityInfo("Al ‘Ubaydīyah", "00", 31.71697, 35.29007);
case 351: return new CityInfo("Khallat an Nu‘mān", "00", 31.71749, 35.24227);
case 352: return new CityInfo("Khallat Ḩamāmah", "WE", 31.7216, 35.19243);
case 353: return new CityInfo("Bi’r ‘Awnah", "WE", 31.71974, 35.17848);
case 354: return new CityInfo("Ad Dawḩah", "WE", 31.69948, 35.18047);
case 355: return new CityInfo("Khallat al Lūzah", "00", 31.6737, 35.20272);
case 356: return new CityInfo("Wādī Raḩḩāl", "00", 31.66516, 35.16727);
case 357: return new CityInfo("Wādī an Nīş", "00", 31.65387, 35.16152);
case 358: return new CityInfo("Marāḩ Ma‘allā", "00", 31.64925, 35.17478);
case 359: return new CityInfo("Al Manīyah", "00", 31.61851, 35.22115);
case 360: return new CityInfo("‘Arab ar Rashāydah", "00", 31.57112, 35.23227);
case 361: return new CityInfo("Ḩattā", "00", 31.6188, 35.02361);
case 362: return new CityInfo("Bayt ‘Īnūn", "00", 31.5587, 35.1244);
case 363: return new CityInfo("Bayt Maqdum", "WE", 31.53537, 34.97192);
case 364: return new CityInfo("Al Buq‘ah", "00", 31.54199, 35.14279);
case 365: return new CityInfo("Al Buwayrah", "00", 31.48794, 35.11665);
case 366: return new CityInfo("Khallat ad Dār", "00", 31.49737, 35.11362);
case 367: return new CityInfo("Dayr Sāmit", "00", 31.52057, 34.97442);
case 368: return new CityInfo("Al Ḩīlah", "00", 31.47454, 35.10742);
case 369: return new CityInfo("Wādī ash Shājinah", "00", 31.47057, 35.03151);
case 370: return new CityInfo("Aş Şūrrah", "00", 31.47097, 34.99897);
case 371: return new CityInfo("Zīf", "00", 31.46693, 35.13671);
case 372: return new CityInfo("Al Buwayb", "00", 31.46396, 35.15227);
case 373: return new CityInfo("Ḩadb al ‘Alqah", "00", 31.4555, 34.99493);
case 374: return new CityInfo("Bayt ‘Amrah", "WE", 31.4502, 35.04952);
case 375: return new CityInfo("Umm ad Daraj", "00", 31.44538, 35.20071);
case 376: return new CityInfo("Ad Dayrāt", "00", 31.4438, 35.16352);
case 377: return new CityInfo("Khashm ad Daraj", "00", 31.41627, 35.23948);
case 378: return new CityInfo("Rābūd", "WE", 31.43909, 35.0162);
case 379: return new CityInfo("Umm Laşafā", "00", 31.43597, 35.15613);
case 380: return new CityInfo("Umm al Khayr", "00", 31.42544, 35.1957);
case 381: return new CityInfo("Al Karmil", "WE", 31.42301, 35.13278);
case 382: return new CityInfo("Khallat Şāliḩ", "00", 31.42013, 35.11516);
case 383: return new CityInfo("‘Arab al Furayjāt", "00", 31.35638, 34.92072);
case 384: return new CityInfo("Umm Dār", "00", 32.4571, 35.13661);
case 385: return new CityInfo("Al Khuljān", "00", 32.45428, 35.14427);
case 386: return new CityInfo("Bīr al Bāshā", "WE", 32.42022, 35.23013);
case 387: return new CityInfo("Al Bādhān", "00", 32.25857, 35.33247);
case 388: return new CityInfo("‘Ayn al Bayḑā", "00", 32.38051, 35.50838);
case 389: return new CityInfo("Ath Thaghrah", "00", 32.33004, 35.38979);
case 390: return new CityInfo("Az Zubaydāt", "00", 32.1733, 35.53005);
case 391: return new CityInfo("Al Jiftlik", "WE", 32.1407, 35.48738);
case 392: return new CityInfo("Al Ma‘şarah", "00", 31.65534, 35.17928);
case 393: return new CityInfo("Khursā", "00", 31.48232, 35.01742);
case 394: return new CityInfo("Givat Zeev", "WE", 31.86145, 35.16861);
default: return new CityInfo("Oranit", "WE", 32.13165, 34.99094);

                                    }                                        
                                }
                            
                        }
                    }
                