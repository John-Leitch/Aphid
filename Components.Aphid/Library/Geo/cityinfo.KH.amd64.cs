
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
                                    public const string Country = "KH";
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
                            
                                        var cur = (Math.Abs(11.56245 - lat) + Math.Abs(104.91601 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(13.97598 - lat) + Math.Abs(106.81144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.48333 - lat) + Math.Abs(104.95 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.99081 - lat) + Math.Abs(104.78498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.08785 - lat) + Math.Abs(105.79935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.80539 - lat) + Math.Abs(102.96184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.91178 - lat) + Math.Abs(105.65821 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.52586 - lat) + Math.Abs(105.9683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.12212 - lat) + Math.Abs(103.75383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.58588 - lat) + Math.Abs(102.97369 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.36179 - lat) + Math.Abs(103.86056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.11728 - lat) + Math.Abs(106.38838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.45583 - lat) + Math.Abs(107.18811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.48682 - lat) + Math.Abs(105.32533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.36067 - lat) + Math.Abs(105.00776 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.12421 - lat) + Math.Abs(105.05722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.53878 - lat) + Math.Abs(103.9192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.98081 - lat) + Math.Abs(104.77828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.56903 - lat) + Math.Abs(102.95542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.93987 - lat) + Math.Abs(103.05307 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.8079 - lat) + Math.Abs(103.46023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.18175 - lat) + Math.Abs(103.51761 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.95612 - lat) + Math.Abs(102.60891 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.35367 - lat) + Math.Abs(106.03562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.75588 - lat) + Math.Abs(103.25514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.09167 - lat) + Math.Abs(103.90078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.83644 - lat) + Math.Abs(104.45528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.2561 - lat) + Math.Abs(105.97004 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.25128 - lat) + Math.Abs(102.87795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.59623 - lat) + Math.Abs(103.9639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.93964 - lat) + Math.Abs(103.14239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.80731 - lat) + Math.Abs(104.98046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.65805 - lat) + Math.Abs(102.56365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.84895 - lat) + Math.Abs(102.60928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.77452 - lat) + Math.Abs(103.44926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.49146 - lat) + Math.Abs(106.98022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.82147 - lat) + Math.Abs(104.69824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.48291 - lat) + Math.Abs(104.31672 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.61531 - lat) + Math.Abs(102.9838 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.48811 - lat) + Math.Abs(106.01879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.98935 - lat) + Math.Abs(104.94208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.61041 - lat) + Math.Abs(104.18145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.55847 - lat) + Math.Abs(104.46753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.14379 - lat) + Math.Abs(105.48275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.71112 - lat) + Math.Abs(104.88873 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.45332 - lat) + Math.Abs(104.52085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.60932 - lat) + Math.Abs(103.52958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.25 - lat) + Math.Abs(104.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.99339 - lat) + Math.Abs(105.4635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.55329 - lat) + Math.Abs(106.09224 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.73939 - lat) + Math.Abs(106.98727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.68267 - lat) + Math.Abs(104.69945 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.10271 - lat) + Math.Abs(103.19822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.39429 - lat) + Math.Abs(105.07518 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.6862 - lat) + Math.Abs(107.21417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.79226 - lat) + Math.Abs(104.97859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.23223 - lat) + Math.Abs(104.08107 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.4319 - lat) + Math.Abs(102.37574 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.54665 - lat) + Math.Abs(103.03569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.2235 - lat) + Math.Abs(102.39546 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.08806 - lat) + Math.Abs(102.49074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.61698 - lat) + Math.Abs(102.85862 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.63885 - lat) + Math.Abs(102.58356 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.30491 - lat) + Math.Abs(103.1023 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.15993 - lat) + Math.Abs(103.23134 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.26298 - lat) + Math.Abs(103.09037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.74403 - lat) + Math.Abs(103.33892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.60535 - lat) + Math.Abs(103.41903 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.54057 - lat) + Math.Abs(103.02693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.62371 - lat) + Math.Abs(103.18212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.62411 - lat) + Math.Abs(102.95015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.60412 - lat) + Math.Abs(102.98801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.1872 - lat) + Math.Abs(103.47117 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.07943 - lat) + Math.Abs(103.24454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.62268 - lat) + Math.Abs(103.52473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.62925 - lat) + Math.Abs(103.52958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.35121 - lat) + Math.Abs(103.7694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.8342 - lat) + Math.Abs(103.51315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.92522 - lat) + Math.Abs(104.42185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.60421 - lat) + Math.Abs(104.25611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.53021 - lat) + Math.Abs(104.36881 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.385 - lat) + Math.Abs(104.37165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.75375 - lat) + Math.Abs(104.42743 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.23879 - lat) + Math.Abs(104.13784 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.18689 - lat) + Math.Abs(104.35533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.63781 - lat) + Math.Abs(104.87319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.66781 - lat) + Math.Abs(104.56026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.4135 - lat) + Math.Abs(104.82648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.44641 - lat) + Math.Abs(104.94556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.01173 - lat) + Math.Abs(104.67631 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.14918 - lat) + Math.Abs(104.53641 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.73577 - lat) + Math.Abs(104.97713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.65577 - lat) + Math.Abs(104.86684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.62439 - lat) + Math.Abs(104.90941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.56173 - lat) + Math.Abs(104.85553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.53264 - lat) + Math.Abs(104.93662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.27446 - lat) + Math.Abs(104.72737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.71121 - lat) + Math.Abs(104.89108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.9404 - lat) + Math.Abs(104.57072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.83431 - lat) + Math.Abs(105.01851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.09511 - lat) + Math.Abs(105.38447 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.94627 - lat) + Math.Abs(105.27491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.88548 - lat) + Math.Abs(105.42782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.77264 - lat) + Math.Abs(105.38274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.57101 - lat) + Math.Abs(105.42058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.30851 - lat) + Math.Abs(105.28186 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.05685 - lat) + Math.Abs(105.07475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.05804 - lat) + Math.Abs(105.25723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.10459 - lat) + Math.Abs(105.25407 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.15888 - lat) + Math.Abs(105.82261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.05456 - lat) + Math.Abs(105.88531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.32761 - lat) + Math.Abs(105.54605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.25578 - lat) + Math.Abs(105.53522 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.98431 - lat) + Math.Abs(106.12486 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.18739 - lat) + Math.Abs(106.88061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.7978 - lat) + Math.Abs(106.99378 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.86724 - lat) + Math.Abs(107.29682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.67061 - lat) + Math.Abs(107.34701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.58147 - lat) + Math.Abs(104.91315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.30852 - lat) + Math.Abs(105.28366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.49308 - lat) + Math.Abs(105.34318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.1751 - lat) + Math.Abs(105.2292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.09877 - lat) + Math.Abs(105.22114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.57767 - lat) + Math.Abs(106.77289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.55254 - lat) + Math.Abs(107.42393 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.70939 - lat) + Math.Abs(103.82091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.60209 - lat) + Math.Abs(103.78579 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.48339 - lat) + Math.Abs(103.87413 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.34741 - lat) + Math.Abs(103.98756 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.79322 - lat) + Math.Abs(103.76085 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.68385 - lat) + Math.Abs(103.6479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.68778 - lat) + Math.Abs(104.12959 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.43758 - lat) + Math.Abs(104.46286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(13.12234 - lat) + Math.Abs(104.34627 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Phnom Penh", "22", 11.56245, 104.91601);
case 1: return new CityInfo("Veun Sai", "23", 13.97598, 106.81144);
case 2: return new CityInfo("Ta Khmau", "07", 11.48333, 104.95);
case 3: return new CityInfo("Takeo", "19", 10.99081, 104.78498);
case 4: return new CityInfo("Svay Rieng", "18", 11.08785, 105.79935);
case 5: return new CityInfo("Svay Chek", "25", 13.80539, 102.96184);
case 6: return new CityInfo("Suong", "31", 11.91178, 105.65821);
case 7: return new CityInfo("Stung Treng", "17", 13.52586, 105.9683);
case 8: return new CityInfo("Srae Ambel", "08", 11.12212, 103.75383);
case 9: return new CityInfo("Sisophon", "25", 13.58588, 102.97369);
case 10: return new CityInfo("Siem Reap", "24", 13.36179, 103.86056);
case 11: return new CityInfo("Siem Pang", "17", 14.11728, 106.38838);
case 12: return new CityInfo("Sen Monorom", "10", 12.45583, 107.18811);
case 13: return new CityInfo("Prey Veng", "14", 11.48682, 105.32533);
case 14: return new CityInfo("S’ang", "07", 11.36067, 105.00776);
case 15: return new CityInfo("Koah Thum", "07", 11.12421, 105.05722);
case 16: return new CityInfo("Pursat", "12", 12.53878, 103.9192);
case 17: return new CityInfo("Phumĭ Véal Srê", "19", 10.98081, 104.77828);
case 18: return new CityInfo("Bak Khlang", "08", 11.56903, 102.95542);
case 19: return new CityInfo("Thma Puok", "25", 13.93987, 103.05307);
case 20: return new CityInfo("Ta Loas", "29", 12.8079, 103.46023);
case 21: return new CityInfo("Samraong", "27", 14.18175, 103.51761);
case 22: return new CityInfo("Sala Krau", "30", 12.95612, 102.60891);
case 23: return new CityInfo("Preaek Prasab", "09", 12.35367, 106.03562);
case 24: return new CityInfo("Koas Krala", "29", 12.75588, 103.25514);
case 25: return new CityInfo("Kampong Seila", "08", 11.09167, 103.90078);
case 26: return new CityInfo("Chhuk", "21", 10.83644, 104.45528);
case 27: return new CityInfo("Chhloung", "09", 12.2561, 105.97004);
case 28: return new CityInfo("Bavel", "29", 13.25128, 102.87795);
case 29: return new CityInfo("Banteay Srei", "24", 13.59623, 103.9639);
case 30: return new CityInfo("Banan", "29", 12.93964, 103.14239);
case 31: return new CityInfo("Tbeng Meanchey", "13", 13.80731, 104.98046);
case 32: return new CityInfo("Paoy Paet", "25", 13.65805, 102.56365);
case 33: return new CityInfo("Pailin", "30", 12.84895, 102.60928);
case 34: return new CityInfo("Moung Ruessei", "29", 12.77452, 103.44926);
case 35: return new CityInfo("Lumphat", "23", 13.49146, 106.98022);
case 36: return new CityInfo("Kuleaen", "13", 13.82147, 104.69824);
case 37: return new CityInfo("Krong Kep", "26", 10.48291, 104.31672);
case 38: return new CityInfo("Koh Kong", "08", 11.61531, 102.9838);
case 39: return new CityInfo("Kratié", "09", 12.48811, 106.01879);
case 40: return new CityInfo("Batheay", "02", 11.98935, 104.94208);
case 41: return new CityInfo("Kampot", "21", 10.61041, 104.18145);
case 42: return new CityInfo("Kampong Trach", "21", 10.55847, 104.46753);
case 43: return new CityInfo("Kampong Trabaek", "14", 11.14379, 105.48275);
case 44: return new CityInfo("Kampong Thom", "05", 12.71112, 104.88873);
case 45: return new CityInfo("Kampong Speu", "04", 11.45332, 104.52085);
case 46: return new CityInfo("Sihanoukville", "28", 10.60932, 103.52958);
case 47: return new CityInfo("Kampong Chhnang", "03", 12.25, 104.66667);
case 48: return new CityInfo("Kampong Cham", "02", 11.99339, 105.4635);
case 49: return new CityInfo("Sesan", "17", 13.55329, 106.09224);
case 50: return new CityInfo("Banlung", "23", 13.73939, 106.98727);
case 51: return new CityInfo("Odongk", "04", 11.68267, 104.69945);
case 52: return new CityInfo("Battambang", "29", 13.10271, 103.19822);
case 53: return new CityInfo("Baray", "05", 12.39429, 105.07518);
case 54: return new CityInfo("Bar Kaev", "23", 13.6862, 107.21417);
case 55: return new CityInfo("Pal Hal", "13", 13.79226, 104.97859);
case 56: return new CityInfo("Anlong Veaeng", "27", 14.23223, 104.08107);
case 57: return new CityInfo("Sampov Lun", "25", 13.4319, 102.37574);
case 58: return new CityInfo("Smach Mean Chey", "08", 11.54665, 103.03569);
case 59: return new CityInfo("Phnum Proek", "29", 13.2235, 102.39546);
case 60: return new CityInfo("Kamrieng", "29", 13.08806, 102.49074);
case 61: return new CityInfo("Samlout", "29", 12.61698, 102.85862);
case 62: return new CityInfo("Ou Chrov", "25", 13.63885, 102.58356);
case 63: return new CityInfo("Veal Veaeng", "12", 12.30491, 103.1023);
case 64: return new CityInfo("Aek Phnum", "29", 13.15993, 103.23134);
case 65: return new CityInfo("Bat Dambang", "29", 13.26298, 103.09037);
case 66: return new CityInfo("Phnum Srok", "25", 13.74403, 103.33892);
case 67: return new CityInfo("Kralanh", "24", 13.60535, 103.41903);
case 68: return new CityInfo("Mongkol Borei", "25", 13.54057, 103.02693);
case 69: return new CityInfo("Preah Netr Preah", "25", 13.62371, 103.18212);
case 70: return new CityInfo("Mondul Seima", "08", 11.62411, 102.95015);
case 71: return new CityInfo("Smach Meanchey", "08", 11.60412, 102.98801);
case 72: return new CityInfo("Botum Sakor", "08", 11.1872, 103.47117);
case 73: return new CityInfo("Sangkae", "29", 13.07943, 103.24454);
case 74: return new CityInfo("Mittakpheap", "28", 10.62268, 103.52473);
case 75: return new CityInfo("Thma Bang", "08", 11.62925, 103.52958);
case 76: return new CityInfo("Phnum Kravanh", "12", 12.35121, 103.7694);
case 77: return new CityInfo("Srei Snam", "24", 13.8342, 103.51315);
case 78: return new CityInfo("Chum Kiri", "21", 10.92522, 104.42185);
case 79: return new CityInfo("Kampot", "21", 10.60421, 104.25611);
case 80: return new CityInfo("Damnak Chang’aeur", "26", 10.53021, 104.36881);
case 81: return new CityInfo("Phnum Sruoch", "04", 11.385, 104.37165);
case 82: return new CityInfo("Thpong", "04", 11.75375, 104.42743);
case 83: return new CityInfo("Soutr Nikom", "24", 13.23879, 104.13784);
case 84: return new CityInfo("Trapeang Prasat", "27", 14.18689, 104.35533);
case 85: return new CityInfo("Kiri Vongs", "19", 10.63781, 104.87319);
case 86: return new CityInfo("Banteay Meas", "21", 10.66781, 104.56026);
case 87: return new CityInfo("Kandal Stueng", "07", 11.4135, 104.82648);
case 88: return new CityInfo("Ta Khmau", "07", 11.44641, 104.94556);
case 89: return new CityInfo("Tram Kak", "19", 11.01173, 104.67631);
case 90: return new CityInfo("Basedth", "04", 11.14918, 104.53641);
case 91: return new CityInfo("Mukh Kampul", "07", 11.73577, 104.97713);
case 92: return new CityInfo("Ponhea Lueu", "22", 11.65577, 104.86684);
case 93: return new CityInfo("Ruessei Kaev", "22", 11.62439, 104.90941);
case 94: return new CityInfo("Dangkao", "22", 11.56173, 104.85553);
case 95: return new CityInfo("Mean Chey", "22", 11.53264, 104.93662);
case 96: return new CityInfo("Kampong Leaeng", "03", 12.27446, 104.72737);
case 97: return new CityInfo("Stueng Saen", "05", 12.71121, 104.89108);
case 98: return new CityInfo("Stoung", "05", 12.9404, 104.57072);
case 99: return new CityInfo("Bourei Cholsar", "19", 10.83431, 105.01851);
case 100: return new CityInfo("Preah Sdach", "14", 11.09511, 105.38447);
case 101: return new CityInfo("Kang Meas", "02", 11.94627, 105.27491);
case 102: return new CityInfo("Kaoh Soutin", "02", 11.88548, 105.42782);
case 103: return new CityInfo("Sithor Kandal", "14", 11.77264, 105.38274);
case 104: return new CityInfo("Prey Veaeng", "14", 11.57101, 105.42058);
case 105: return new CityInfo("Chamkar Leu", "02", 12.30851, 105.28186);
case 106: return new CityInfo("Cheung Prey", "02", 12.05685, 105.07475);
case 107: return new CityInfo("Prey Chhor", "02", 12.05804, 105.25723);
case 108: return new CityInfo("Sandan", "05", 13.10459, 105.25407);
case 109: return new CityInfo("Rumduol", "18", 11.15888, 105.82261);
case 110: return new CityInfo("Svay Teab", "18", 11.05456, 105.88531);
case 111: return new CityInfo("Me Sang", "14", 11.32761, 105.54605);
case 112: return new CityInfo("Stueng Trang", "02", 12.25578, 105.53522);
case 113: return new CityInfo("Chantrea", "18", 10.98431, 106.12486);
case 114: return new CityInfo("Kaev Seima", "10", 12.18739, 106.88061);
case 115: return new CityInfo("Ou Chum", "23", 13.7978, 106.99378);
case 116: return new CityInfo("Andoung Meas", "23", 13.86724, 107.29682);
case 117: return new CityInfo("Ou Ya Dav", "23", 13.67061, 107.34701);
case 118: return new CityInfo("Sangkom Thmei", "13", 13.58147, 104.91315);
case 119: return new CityInfo("Peam Ro", "14", 11.30852, 105.28366);
case 120: return new CityInfo("Kampong Leav", "14", 11.49308, 105.34318);
case 121: return new CityInfo("Leuk Daek", "07", 11.1751, 105.2292);
case 122: return new CityInfo("Peam Chor", "14", 11.09877, 105.22114);
case 123: return new CityInfo("Koun Mom", "23", 13.57767, 106.77289);
case 124: return new CityInfo("Pechreada", "10", 12.55254, 107.42393);
case 125: return new CityInfo("Prey Nob", "28", 10.70939, 103.82091);
case 126: return new CityInfo("Bakan", "12", 12.60209, 103.78579);
case 127: return new CityInfo("Angkor Thum", "24", 13.48339, 103.87413);
case 128: return new CityInfo("Bakong", "24", 13.34741, 103.98756);
case 129: return new CityInfo("Varin", "24", 13.79322, 103.76085);
case 130: return new CityInfo("Angkor Chum", "24", 13.68385, 103.6479);
case 131: return new CityInfo("Aoral", "04", 11.68778, 104.12959);
case 132: return new CityInfo("Baribour", "03", 12.43758, 104.46286);
default: return new CityInfo("Chi Kraeng", "24", 13.12234, 104.34627);

                                    }                                        
                                }
                            
                        }
                    }
                